using Validator;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        ValidatorHesel validator = new ValidatorHesel();

        [TestMethod]
        public void MaViceNezPet()
        {
            Assert.AreEqual(true, validator.SpravneHeslo("wdok55wdwd"));
        }

        [TestMethod]
        public void JePrazdne()
        {
            Assert.AreEqual(false, validator.SpravneHeslo(""));
        }

        [TestMethod]
        public void Test()
        {
            Assert.AreNotEqual(true, validator.SpravneHeslo("kwadkwawkdalklwalk"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreNotEqual(true, validator.SpravneHeslo("kwadkwawkdalklwalk"));
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreNotEqual(true, validator.SpravneHeslo("x"));
        }

        [TestMethod]
        public void MaCislo()
        {
            Assert.AreEqual(false, validator.SpravneHeslo("hawdhhjawdh"));
        }
    }
}