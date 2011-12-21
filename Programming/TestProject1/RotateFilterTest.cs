using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "RotateFilterTest" und soll
    ///alle RotateFilterTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class RotateFilterTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Ruft den Testkontext auf, der Informationen
        ///über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Zusätzliche Testattribute
        // 
        //Sie können beim Verfassen Ihrer Tests die folgenden zusätzlichen Attribute verwenden:
        //
        //Mit ClassInitialize führen Sie Code aus, bevor Sie den ersten Test in der Klasse ausführen.
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Mit ClassCleanup führen Sie Code aus, nachdem alle Tests in einer Klasse ausgeführt wurden.
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen.
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Ein Test für "rotate"
        ///</summary>
        [TestMethod()]
        public void rotateTest()
        {
            Bitmap b = new Bitmap(10, 10);
            RotateFlipType type = new RotateFlipType(); // TODO: Passenden Wert initialisieren
            RotateFilter.rotate(b, type);
           
        }

        /// <summary>
        ///Ein Test für "RotateFilter-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void RotateFilterConstructorTest()
        {
            RotateFilter target = new RotateFilter();
           
        }
    }
}
