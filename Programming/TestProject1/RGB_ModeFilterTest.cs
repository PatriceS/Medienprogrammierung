using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "RGB_ModeFilterTest" und soll
    ///alle RGB_ModeFilterTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class RGB_ModeFilterTest
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
        ///Ein Test für "perform"
        ///</summary>
        [TestMethod()]
        public void performTest()
        {
            Bitmap b = new Bitmap(10, 10);
            IntPtr Scan0 = new IntPtr(); // TODO: Passenden Wert initialisieren
            int stride = 0; // TODO: Passenden Wert initialisieren
            int height_start = 0; // TODO: Passenden Wert initialisieren
            int height_end = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler thInfo = null; // TODO: Passenden Wert initialisieren
            ImageManipulatorType.Name color_type = new ImageManipulatorType.Name(); // TODO: Passenden Wert initialisieren
            RGB_ModeFilter target = new RGB_ModeFilter(b, Scan0, stride, height_start, height_end, thInfo, color_type); // TODO: Passenden Wert initialisieren
            target.perform();
           
        }

        /// <summary>
        ///Ein Test für "RGB_ModeFilter-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void RGB_ModeFilterConstructorTest()
        {
            Bitmap b = new Bitmap(10, 10);
            IntPtr Scan0 = new IntPtr(); // TODO: Passenden Wert initialisieren
            int stride = 0; // TODO: Passenden Wert initialisieren
            int height_start = 0; // TODO: Passenden Wert initialisieren
            int height_end = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler thInfo = null; // TODO: Passenden Wert initialisieren
            ImageManipulatorType.Name color_type = new ImageManipulatorType.Name(); // TODO: Passenden Wert initialisieren
            RGB_ModeFilter target = new RGB_ModeFilter(b, Scan0, stride, height_start, height_end, thInfo, color_type);
            
        }
    }
}
