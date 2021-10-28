using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class DayCoba
    {
        private Day hari;
        [SetUp]
        public void Init() {
            hari = new Day();
        }
        [Test]
        public void DayTest() 
        {
            Assert.AreEqual("Senin", hari.NameOfDay(1));
            Assert.AreEqual("Selasa", hari.NameOfDay(2));
            Assert.AreEqual("Rabu", hari.NameOfDay(3));
            Assert.AreEqual("Kamis", hari.NameOfDay(4));
            Assert.AreEqual("Jum'at", hari.NameOfDay(5));
            Assert.AreEqual("Sabtu", hari.NameOfDay(6));
            Assert.AreEqual("Minggu", hari.NameOfDay(7));

        }
    }
}
