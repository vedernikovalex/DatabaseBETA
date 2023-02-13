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
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.ReadUncommitted);
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
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.ReadUncommitted);
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
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.ReadUncommitted);
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

        [TestMethod]
        public void DirtyReadCommited()
        {
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.ReadCommitted);
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
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.ReadCommitted);
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
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.ReadCommitted);
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

        [TestMethod]
        public void DirtyReadRepeatableRead()
        {
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.RepeatableRead);
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
        public void NonRepeatableRepeatableRead()
        {
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.RepeatableRead);
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
        public void PhantomReadRepeatableRead()
        {
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.RepeatableRead);
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


        [TestMethod]
        public void DirtyReadSerializable()
        {
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.Serializable);
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
        public void NonRepeatableSerializable()
        {
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.Serializable);
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
        public void PhantomReadSerializable()
        {
            UnitOfWork.Instance.SetIsolationLevel(System.Data.IsolationLevel.Serializable);
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