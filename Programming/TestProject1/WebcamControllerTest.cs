using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "WebcamControllerTest" und soll
    ///alle WebcamControllerTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class WebcamControllerTest
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
        ///Ein Test für "WebcamController-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void WebcamControllerConstructorTest()
        {
            WebcamController target = new WebcamController();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///Ein Test für "getInstance"
        ///</summary>
        [TestMethod()]
        public void getInstanceTest()
        {
            PictureBox pictureBox1 = new PictureBox();
            PixelState.getInstance().set_pictureBox(pictureBox1);
            WebcamController expected = WebcamController.getInstance();
            WebcamController actual;
            actual = null;
            Assert.AreNotEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "init"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void initTest()
        {
            PictureBox pic = new PictureBox();
            PixelState.getInstance().set_pictureBox(pic);
            WebcamController_Accessor target = WebcamController_Accessor.getInstance(); 
            target.init();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///Ein Test für "openWebcamWindow"
        ///</summary>
        [TestMethod()]
        public void openWebcamWindowTest()
        {
            WebcamController target = new WebcamController(); // TODO: Passenden Wert initialisieren
            target.openWebcamWindow();
            
        }

        /// <summary>
        ///Ein Test für "setMainForm"
        ///</summary>
        [TestMethod()]
        public void setMainFormTest()
        {
            WebcamController target = new WebcamController(); // TODO: Passenden Wert initialisieren
            Form1 form = new Form1(); 
            target.setMainForm(form);
            
            
        }

        /// <summary>
        ///Ein Test für "set_Webcam_picture"
        ///</summary>
        [TestMethod()]
        public void set_Webcam_pictureTest()
        {
            WebcamController target = new WebcamController(); // TODO: Passenden Wert initialisieren
            KeyValuePair<int, string> src = new KeyValuePair<int, string>(); // TODO: Passenden Wert initialisieren
            target.set_Webcam_picture(src);
            
        }

        /// <summary>
        ///Ein Test für "set_device"
        ///</summary>
        [TestMethod()]
        public void set_deviceTest()
        {
            WebcamController target = new WebcamController(); // TODO: Passenden Wert initialisieren
            KeyValuePair<int, string> selob = new KeyValuePair<int, string>(); // TODO: Passenden Wert initialisieren
            target.set_device(selob);
            
        }

        /// <summary>
        ///Ein Test für "set_solution"
        ///</summary>
        [TestMethod()]
        public void set_solutionTest()
        {
            
            PixelState.getInstance().set_pictureBox(new PictureBox());
            WebcamController target =  WebcamController.getInstance(); 
            KeyValuePair<int, string> selob = new KeyValuePair<int, string>();
            target.set_solution(selob);
            Assert.IsNotNull(target);
            
        }

        /// <summary>
        ///Ein Test für "show_Webcam_picture"
        ///</summary>
        [TestMethod()]
        public void show_Webcam_pictureTest()
        {

            PixelState.getInstance().set_pictureBox(new PictureBox());
            WebcamController target = WebcamController.getInstance();
            PictureBox webcamPictureBox = new PictureBox();
            
            WebcamOptions form = null;
            target.show_Webcam_picture(webcamPictureBox, form);
            
        }

        /// <summary>
        ///Ein Test für "stop_capture"
        ///</summary>
        [TestMethod()]
        public void stop_captureTest()
        {
            WebcamController target = new WebcamController(); // TODO: Passenden Wert initialisieren
            target.stop_capture();
            
        }
    }
}
