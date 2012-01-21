using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "FilterFactoryTest" und soll
    ///alle FilterFactoryTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class FilterFactoryTest
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
        ///Ein Test für "FilterFactory-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void FilterFactoryConstructorTest()
        {
            FilterFactory target = new FilterFactory();
            Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren");
        }

        /// <summary>
        ///Ein Test für "create"
        ///</summary>
        [TestMethod()]
        public void createTest()
        {
            FilterFactory target = new FilterFactory(); // TODO: Passenden Wert initialisieren
            ImageManipulatorType.Name name = ImageManipulatorType.Name.INVERT;
            Bitmap bitmap = new Bitmap(1, 1);
            IntPtr Scan0 = new IntPtr(); // TODO: Passenden Wert initialisieren
            int stride = 0; // TODO: Passenden Wert initialisieren
            int height_start = 0; // TODO: Passenden Wert initialisieren
            int height_end = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler thHandler = null; // TODO: Passenden Wert initialisieren
            int[] values = null; // TODO: Passenden Wert initialisieren
            Manipulate expected = null; // TODO: Passenden Wert initialisieren
            Manipulate actual;
            actual = target.create(name, bitmap, Scan0, stride, height_start, height_end, thHandler, values);
            Assert.AreNotEqual(expected, actual);
            Assert.IsInstanceOfType(actual, typeof(Manipulate));
            
        }
    }
}
