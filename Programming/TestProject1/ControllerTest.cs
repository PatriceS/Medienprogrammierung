using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "ControllerTest" und soll
    ///alle ControllerTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class ControllerTest
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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            // Reset the sole instance of ClassToBeTested

            new PrivateType(typeof(Controller)).SetStaticField("con", null);
        }
        //
        //Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Ein Test für "getInstance"
        ///</summary>
        [TestMethod()]
        public void getInstanceTest()
        {
            Controller expected = null; // TODO: Passenden Wert initialisieren
            Controller actual;
            actual = Controller.getInstance();
            Assert.AreNotEqual(expected, actual);

            Assert.IsInstanceOfType(actual, typeof(Controller));
            
        }

        /// <summary>
        ///Ein Test für "setMainForm"
        ///</summary>
        [TestMethod()]
        public void setMainFormTest()
        {
            Controller t = Controller.getInstance(); 

            Form1 form = new Form1(); // TODO: Passenden Wert initialisieren
            t.setMainForm(form);
            
            PrivateObject param0 = new PrivateObject(t); // TODO: Passenden Wert initialisieren
            Controller_Accessor target = new Controller_Accessor(param0); // TODO: Passenden Wert initialisieren

            Assert.AreSame(form, target.mainForm);
        }

        /// <summary>
        ///Ein Test für "setPictureBox"
        ///</summary>
        [TestMethod()]
        public void setPictureBoxTest()
        {
            Controller t = Controller.getInstance();
            PrivateObject param0 = new PrivateObject(t);
            Controller_Accessor target = new Controller_Accessor(param0);

            PictureBox pictureBox1 = new PictureBox();
            t.setPictureBox(pictureBox1);

            Assert.AreSame(pictureBox1, Controller_Accessor.pic);
        }

        /// <summary>
        ///Ein Test für "undo"
        ///</summary>
        [TestMethod()]
        public void undoTest()
        {
            Controller t = Controller.getInstance();
            PrivateObject param0 = new PrivateObject(t);
            Controller_Accessor target = new Controller_Accessor(param0);

            PixelState p = PixelState.getInstance();
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;
            ImageObject imgObj = new ImageObject(img, ImageManipulatorType.Name.GRAYSCALE);
           
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = img;
            target.setPictureBox(pictureBox1);
            



            Bitmap c = new Bitmap(13, 14);
            Image img2 = (Image)c; 
            ImageObject imgObj2 = new ImageObject(img, ImageManipulatorType.Name.GRAYSCALE);
            p.add(imgObj2);

            target.undo();
            Image i1 = imgObj2.get_Image();
            Image i2 = Controller_Accessor.pic.Image;

            //  Erwartet:<System.Drawing.Bitmap>. Tatsächlich:<System.Drawing.Bitmap> . 	
            Assert.AreEqual(i1, i2, "Das System wirft einen Fehler weil er bekommt was er erwartet. ALLES KLAAR!!! :(");

         
        }
    }
}
