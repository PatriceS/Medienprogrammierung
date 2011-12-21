using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "ImageObjectTest" und soll
    ///alle ImageObjectTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class ImageObjectTest
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
        ///Ein Test für "ImageObject-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void ImageObjectConstructorTest()
        {
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;
            ImageManipulatorType.Name manipulator =  ImageManipulatorType.Name.RGB_RED; // TODO: Passenden Wert initialisieren
            ImageObject target = new ImageObject(img, manipulator);

            Assert.AreEqual( target.get_ImageManipulatorType(), ImageManipulatorType.Name.RGB_RED );
            Assert.AreSame(target.get_Image(), img);
            Assert.IsInstanceOfType(target.get_Image(), typeof(Image));
        }

        /// <summary>
        ///Ein Test für "get_Image"
        ///</summary>
        [TestMethod()]
        public void get_ImageTest()
        {
           
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;

            ImageManipulatorType.Name manipulator = ImageManipulatorType.Name.RGB_RED; // TODO: Passenden Wert initialisieren
            ImageObject target = new ImageObject(img, manipulator); // TODO: Passenden Wert initialisieren
            
            Image actual = target.get_Image();

            Assert.IsNotNull( actual);
            Assert.IsInstanceOfType(actual, typeof(Image));

            
        }

        /// <summary>
        ///Ein Test für "get_ImageManipulatorType"
        ///</summary>
        [TestMethod()]
        public void get_ImageManipulatorTypeTest()
        {
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;

            ImageManipulatorType.Name manipulator = ImageManipulatorType.Name.ERROR_DIFFUSION;
            ImageObject target = new ImageObject(img, manipulator); 
            ImageManipulatorType.Name expected =  ImageManipulatorType.Name.ERROR_DIFFUSION; 
            ImageManipulatorType.Name actual;
            actual = target.get_ImageManipulatorType();
            Assert.AreEqual(expected, actual);

            manipulator = ImageManipulatorType.Name.BLACKWHITE;
            target = new ImageObject(img, manipulator);

            actual = target.get_ImageManipulatorType();
            Assert.AreNotEqual(expected, actual);
        }
    }
}
