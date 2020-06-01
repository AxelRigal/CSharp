using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciceInitiale;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void ShouldBeAR()
        {
            var initiales = ClassChaine.RetourneChaine("axel rigal");
            Assert.AreEqual("A.R.", initiales);
        }
    }
}
