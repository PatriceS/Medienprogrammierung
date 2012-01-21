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
        ///Ein Test für "get_Image"
        ///</summary>
        [TestMethod()]
        public void get_ImageTest()
        {
            WebcamModel target = new WebcamModel(); 
            Image expected = null; 
            Image actual;
            actual = target.get_Image();
            Assert.AreEqual(expected, actual);
           
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
            Assert.IsInstanceOfType(expected, typeof(KeyValuePair<int, string>));
         
        }

        /// <summary>
        ///Ein Test für "get_devices"
        ///</summary>
        [TestMethod()]
        public void get_devicesTest()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            
            Dictionary<int, string> actual;
            actual = target.get_devices();
            Assert.IsInstanceOfType(actual, typeof(Dictionary<int, string>));
            
        }




        /// <summary>
        ///Ein Test für "set_device"
        ///</summary>
        [TestMethod()]
        public void set_deviceTest()
        {
            WebcamModel target = new WebcamModel(); 
            KeyValuePair<int, string> selob = new KeyValuePair<int, string>(); 
            target.set_device(selob);
            
        }

        /// <summary>
        ///Ein Test für "set_solution"
        ///</summary>
        [TestMethod()]
        public void set_solutionTest()
        {
            WebcamModel target = new WebcamModel(); 
            KeyValuePair<int, string> selob = new KeyValuePair<int, string>(); 
            target.set_solution(selob);
            
        }

        /// <summary>
        ///Ein Test für "show_picture"
        ///</summary>
        [TestMethod()]
        public void show_pictureTest()
        {
            PictureBox pic = new PictureBox();
            PixelState.getInstance().set_pictureBox(pic);
            WebcamModel target = new WebcamModel();
            Dictionary<int, string> devices = new Dictionary<int, string>();
            Dictionary<int, string> solutions = new Dictionary<int, string>();
            devices.Add(1,"");
            solutions.Add(1, "");
            WebcamOptions form = new WebcamOptions(devices, solutions); 
            target.show_picture(pic, form);
        }

        /// <summary>
        ///Ein Test für "stop_capture"
        ///</summary>
        [TestMethod()]
        public void stop_captureTest()
        {
            WebcamModel target = new WebcamModel(); // TODO: Passenden Wert initialisieren
            target.stop_capture();
            
        }

        
    }
}
