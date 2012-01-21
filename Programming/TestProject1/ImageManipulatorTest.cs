using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "ImageManipulatorTest" und soll
    ///alle ImageManipulatorTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class ImageManipulatorTest
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

            Bitmap bitmap = new Bitmap(10, 10);
            ImageManipulatorType.Name filter = ImageManipulatorType.Name.GRAYSCALE; // TODO: Passenden Wert initialisieren
            int threads = 2; // TODO: Passenden Wert initialisieren
            ThreadHandler thHandler = new ThreadHandler(threads);
            ImageManipulator target = new ImageManipulator(bitmap, filter, thHandler); // TODO: Passenden Wert initialisieren

            bool expected = true; // TODO: Passenden Wert initialisieren
            bool actual = target.perform(); 
           
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///Ein Test für "perform"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void performTest1()
        {

            Bitmap bitmap = new Bitmap(100, 100);
            ImageManipulatorType.Name filter = ImageManipulatorType.Name.GRAYSCALE; // TODO: Passenden Wert initialisieren
            int threads = 2; // TODO: Passenden Wert initialisieren
            ThreadHandler thHandler = new ThreadHandler(threads);
            ImageManipulator t = new ImageManipulator(bitmap, filter, thHandler); // TODO: Passenden Wert initialisieren
            PrivateObject param0 = new PrivateObject(t); // TODO: Passenden Wert initialisieren
            ImageManipulator_Accessor target = new ImageManipulator_Accessor(param0);

            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
           ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;

            int bytes = Math.Abs(bmData.Stride) * bmData.Height;

            System.IntPtr Scan0 = bmData.Scan0;

            target.perform(Scan0, stride);

            // Die Funktion stößt nur andere Funktionen ab hier an. Was testen?

            bitmap.UnlockBits(bmData);

        }


        /// <summary>
        ///Ein Test für "computeHeightSteps"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void computeHeightStepsTest()
        {
            Bitmap bitmap = new Bitmap(10, 10);
            ImageManipulatorType.Name filter = ImageManipulatorType.Name.GRAYSCALE; // TODO: Passenden Wert initialisieren
            int threads = 2; // TODO: Passenden Wert initialisieren
            ThreadHandler thHandler = new ThreadHandler(threads);
            ImageManipulator t = new ImageManipulator(bitmap, filter, thHandler); // TODO: Passenden Wert initialisieren
            PrivateObject param0 = new PrivateObject(t); // TODO: Passenden Wert initialisieren
            ImageManipulator_Accessor target = new ImageManipulator_Accessor(param0);
            int height = 10; // TODO: Passenden Wert initialisieren
            int expected = 5; // TODO: Passenden Wert initialisieren
            int actual;
            actual = target.computeHeightSteps(height);
            Assert.AreEqual(expected, actual);
           
        }


        /// <summary>
        ///Ein Test für "ImageManipulator-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void ImageManipulatorConstructorTest()
        {
            Bitmap bitmap = new Bitmap(10, 10);
            ImageManipulatorType.Name filter = ImageManipulatorType.Name.GRAYSCALE; // TODO: Passenden Wert initialisieren
            int threads = 2; // TODO: Passenden Wert initialisieren
            ThreadHandler thHandler = new ThreadHandler(threads);
            ImageManipulator t = new ImageManipulator(bitmap, filter, thHandler); // TODO: Passenden Wert initialisieren
            PrivateObject param0 = new PrivateObject(t); // TODO: Passenden Wert initialisieren
            ImageManipulator_Accessor target = new ImageManipulator_Accessor(param0);
            
            Assert.IsNotNull( target.bitmap);
            Assert.IsNotNull(target.thHandler);
            Assert.IsNotNull(target.filter);

        }
    }
}
