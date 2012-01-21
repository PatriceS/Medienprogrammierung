using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "NullImageObjectTest" und soll
    ///alle NullImageObjectTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class NullImageObjectTest
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
        ///Ein Test für "get_Image"
        ///</summary>
        [TestMethod()]
        public void get_ImageTest()
        {
            Image img = new Bitmap(1, 1);
            PictureBox pic = new PictureBox();
            pic.Image = img;
            NullImageObject target = new NullImageObject(pic); 
            Image expected = img; 
            Image actual;
            actual = target.get_Image();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "get_Bitmap"
        ///</summary>
        [TestMethod()]
        public void get_BitmapTest()
        {
            Image img = new Bitmap(1, 1);
            PictureBox pic = new PictureBox();
            pic.Image = img;
            NullImageObject target = new NullImageObject(pic); // TODO: Passenden Wert initialisieren
            Bitmap expected = (Bitmap)img; 
            Bitmap actual;
            actual = target.get_Bitmap();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "NullImageObject-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void NullImageObjectConstructorTest()
        {
            PictureBox pic = new PictureBox(); // TODO: Passenden Wert initialisieren
            NullImageObject target = new NullImageObject(pic);
            
        }

        /// <summary>
        ///Ein Test für "get_ImageManipulatorType"
        ///</summary>
        [TestMethod()]
        public void get_ImageManipulatorTypeTest()
        {
            Image img = new Bitmap(1,1);
            PictureBox pic = new PictureBox();
            pic.Image = img;
            NullImageObject target = new NullImageObject(pic); 
            ImageManipulatorType.Name expected = ImageManipulatorType.Name.DEFAULT; 
            ImageManipulatorType.Name actual;
            actual = target.get_ImageManipulatorType();
            Assert.AreEqual(expected, actual);
            
        }
    }
}
