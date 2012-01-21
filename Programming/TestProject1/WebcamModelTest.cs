using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Collections.Generic;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using AForge.Video;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "WebcamModelTest" und soll
    ///alle WebcamModelTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class WebcamModelTest
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
        ///Ein Test für "WebcamModel-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void WebcamModelConstructorTest()
        {
            WebcamModel target = new WebcamModel();
            Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren");
        }

        /// <summary>
        ///Ein Test für "get_Image"
        ///</summary>
        [TestMethod()]
        public void get_ImageTest()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            Image expected = null; // TODO: Passenden Wert initialisieren
            Image actual;
            actual = target.get_Image();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.");
        }

        /// <summary>
        ///Ein Test für "get_device"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void get_deviceTest()
        {
            WebcamModel_Accessor target = new WebcamModel_Accessor(); // TODO: Passenden Wert initialisieren
            KeyValuePair<int, string> expected = new KeyValuePair<int, string>(); // TODO: Passenden Wert initialisieren
            KeyValuePair<int, string> actual;
            actual = target.get_device();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.");
        }

        /// <summary>
        ///Ein Test für "get_devices"
        ///</summary>
        [TestMethod()]
        public void get_devicesTest()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            Dictionary<int, string> expected = null; // TODO: Passenden Wert initialisieren
            Dictionary<int, string> actual;
            actual = target.get_devices();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.");
        }

        /// <summary>
        ///Ein Test für "get_solution"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void get_solutionTest()
        {
            WebcamModel_Accessor target = new WebcamModel_Accessor(); // TODO: Passenden Wert initialisieren
            VideoCaptureDevice videoSource = null; // TODO: Passenden Wert initialisieren
            KeyValuePair<int, string> expected = new KeyValuePair<int, string>(); // TODO: Passenden Wert initialisieren
            KeyValuePair<int, string> actual;
            actual = target.get_solution(videoSource);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.");
        }

        /// <summary>
        ///Ein Test für "get_solution_modes"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void get_solution_modesTest()
        {
            WebcamModel_Accessor target = new WebcamModel_Accessor(); // TODO: Passenden Wert initialisieren
            VideoCaptureDevice videoSource = null; // TODO: Passenden Wert initialisieren
            Dictionary<int, string> expected = null; // TODO: Passenden Wert initialisieren
            Dictionary<int, string> actual;
            actual = target.get_solution_modes(videoSource);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.");
        }

        /// <summary>
        ///Ein Test für "get_solution_modes"
        ///</summary>
        [TestMethod()]
        public void get_solution_modesTest1()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            Dictionary<int, string> expected = null; // TODO: Passenden Wert initialisieren
            Dictionary<int, string> actual;
            actual = target.get_solution_modes();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.");
        }

        /// <summary>
        ///Ein Test für "set_device"
        ///</summary>
        [TestMethod()]
        public void set_deviceTest()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            KeyValuePair<int, string> selob = new KeyValuePair<int, string>(); // TODO: Passenden Wert initialisieren
            target.set_device(selob);
            Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.");
        }

        /// <summary>
        ///Ein Test für "set_solution"
        ///</summary>
        [TestMethod()]
        public void set_solutionTest()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            KeyValuePair<int, string> selob = new KeyValuePair<int, string>(); // TODO: Passenden Wert initialisieren
            target.set_solution(selob);
            Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.");
        }

        /// <summary>
        ///Ein Test für "show_picture"
        ///</summary>
        [TestMethod()]
        public void show_pictureTest()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            PictureBox pic = null; // TODO: Passenden Wert initialisieren
            WebcamOptions form = null; // TODO: Passenden Wert initialisieren
            target.show_picture(pic, form);
            Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.");
        }

        /// <summary>
        ///Ein Test für "stop_capture"
        ///</summary>
        [TestMethod()]
        public void stop_captureTest()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            target.stop_capture();
            Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.");
        }

        /// <summary>
        ///Ein Test für "videoSource_NewFrame"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void videoSource_NewFrameTest()
        {
            WebcamModel_Accessor target = new WebcamModel_Accessor(); // TODO: Passenden Wert initialisieren
            object sender = null; // TODO: Passenden Wert initialisieren
            NewFrameEventArgs eventArgs = null; // TODO: Passenden Wert initialisieren
            target.videoSource_NewFrame(sender, eventArgs);
            Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.");
        }
    }
}
