using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using DatabaseBETA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseBETAUnitTest
{
    [TestClass]
    public class IsolationTests
    {
        public Database database = new Database();
        public SqlConnection con = Database.Instance.Connection;

        [TestMethod]
        public void DirtyReadUncommited()
        {
            TechnikRepository repository = new TechnikRepository();
            Technik technik = new Technik();
            technik.jmeno = "Pavel";
            technik.prijmeni = "Yes";
            technik.nadrizeny_technik = 2;
            Technik technikEdited = new Technik();
            technikEdited.jmeno = "Martin";
            technikEdited.prijmeni = "Yes";
            technikEdited.nadrizeny_technik = 2;

            repository.Update(technikEdited, 1);
            //no commit
            Technik technikSelect = repository.GetById(1);
            Assert.AreEqual(technik.jmeno, technikSelect.jmeno);
        }

        [TestMethod]
        public void NonRepeatableReadUncommited()
        {
            TechnikRepository repository = new TechnikRepository();
            Technik technik = repository.GetById(1);
            Technik technikEdited = new Technik();
            technikEdited.jmeno = "Martin";
            technikEdited.prijmeni = "Yes";
            technikEdited.nadrizeny_technik = 2;

            repository.Update(technikEdited, 1);
            UnitOfWork.Instance.Commit();

            Technik technikSelect = repository.GetById(1);
            Assert.AreEqual(technik.jmeno, technikSelect.jmeno);
        }

        [TestMethod]
        public void PhantomReadUncommited()
        {
            TechnikRepository repository = new TechnikRepository();

            // Begin transaction 1
            using (var transaction1 = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                Technik technik = repository.GetById(1);
                int countBefore = repository.GetAll().Count();

                // Begin transaction 2
                using (var transaction2 = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
                {
                    Technik technikNew = new Technik();
                    technikNew.jmeno = "Pavel";
                    technikNew.prijmeni = "No";
                    technikNew.nadrizeny_technik = 2;

                    repository.Insert(technikNew);
                    transaction2.Commit();
                }

                int countAfter = repository.GetAll().Count();
                Assert.AreEqual(countBefore, countAfter);

                transaction1.Commit();
            }
        }

        [TestInitialize]
        public void SetNewLevel()
        {
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.ReadCommitted);
        }

        [TestMethod]
        public void DirtyReadCommitedz()
        {
            TechnikRepository repository = new TechnikRepository();
            Technik technik = new Technik();
            technik.jmeno = "Pavel";
            technik.prijmeni = "Yes";
            technik.nadrizeny_technik = 2;
            Technik technikEdited = new Technik();
            technikEdited.jmeno = "Martin";
            technikEdited.prijmeni = "Yes";
            technikEdited.nadrizeny_technik = 2;

            repository.Update(technikEdited, 1);
            //no commit
            Technik technikSelect = repository.GetById(1);
            Assert.AreEqual(technik.jmeno, technikSelect.jmeno);
        }

        [TestMethod]
        public void NonRepeatableReadCommited()
        {
            TechnikRepository repository = new TechnikRepository();
            Technik technik = repository.GetById(1);
            Technik technikEdited = new Technik();
            technikEdited.jmeno = "Martin";
            technikEdited.prijmeni = "Yes";
            technikEdited.nadrizeny_technik = 2;

            repository.Update(technikEdited, 1);
            UnitOfWork.Instance.Commit();

            Technik technikSelect = repository.GetById(1);
            Assert.AreEqual(technik.jmeno, technikSelect.jmeno);
        }

        [TestMethod]
        public void PhantomReadCommited()
        {
            TechnikRepository repository = new TechnikRepository();

            // Begin transaction 1
            using (var transaction1 = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                Technik technik = repository.GetById(1);
                int countBefore = repository.GetAll().Count();

                // Begin transaction 2
                using (var transaction2 = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
                {
                    Technik technikNew = new Technik();
                    technikNew.jmeno = "Pavel";
                    technikNew.prijmeni = "No";
                    technikNew.nadrizeny_technik = 2;

                    repository.Insert(technikNew);
                    transaction2.Commit();
                }

                int countAfter = repository.GetAll().Count();
                Assert.AreEqual(countBefore, countAfter);

                transaction1.Commit();
            }
        }

    }
}