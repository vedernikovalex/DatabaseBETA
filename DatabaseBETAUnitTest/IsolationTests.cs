using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using DatabaseBETA;

namespace DatabaseBETAUnitTest
{
    [TestClass]
    public class IsolationTests
    {
        public Database database = new Database();
        public SqlConnection con = Database.Instance.Connection;

        [TestMethod]
        public void DirtyRead1()
        {
            TechnikRepository repository = new TechnikRepository();
            Technik technik = new Technik();
            technik.jmeno = "Pavel";
            technik.prijmeni = "Yes";
            technik.nadrizeny_technik = 2;

            repository.Update(technik,1);
            UnitOfWork.Instance.Commit();

            Technik technikSelect = repository.GetById(1);
            Assert.AreEqual(technik.jmeno,technikSelect.jmeno);
        }

        [TestMethod]
        public void DirtyRead2()
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


    }
}