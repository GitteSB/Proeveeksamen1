using System;
using BilAfgift;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBilAfgift
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestafException()
        
            {
                // Arrange
                Afgift afgiftKlasse = new Afgift();

                // Act
                int resultat = afgiftKlasse.BilAfgift(100000);
                int forventetResultat = 85000;

                // Assert
                Assert.AreEqual(forventetResultat, resultat);
            }

            [TestMethod]
            public void TestBilAfgiftForh�jet()
            {
                // Arrange
                Afgift afgiftKlasse = new Afgift();

                // Act
                int resultat = afgiftKlasse.BilAfgift(200001);
                int forventetResultat = 170002;

                // Assert
                Assert.AreEqual(forventetResultat, resultat);
            }

            [TestMethod]
                [ExpectedException(typeof(ArgumentException))]
            public void TestBilAfgiftException()
            {
                // Arrange
                Afgift afgiftKlasse = new Afgift();

                // Act
                int resultat = afgiftKlasse.BilAfgift(-1);

                // Assert. Hvis den n�r hertil skal den fejle da den ikke har smidt en exception som den skal.
                Assert.Fail();
            }

            [TestMethod]
            public void TestElBilAfgift()
            {
                // Arrange
                Afgift afgiftKlasse = new Afgift();

                // Act
                int resultat = afgiftKlasse.ElBilAfgift(100000);
                int forventetResultat = 17000;

                // Assert
                Assert.AreEqual(forventetResultat, resultat);
            }

            [TestMethod]
            public void TestEilBilAfgiftForh�jet()
            {
                // Arrange
                Afgift afgiftKlasse = new Afgift();

                // Act
                int resultat = afgiftKlasse.ElBilAfgift(200001);
                int forventetResultat = 34000;

                // Assert
                Assert.AreEqual(forventetResultat, resultat);
            }
    }
    
}
