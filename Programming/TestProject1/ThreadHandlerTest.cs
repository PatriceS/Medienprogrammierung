using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Diagnostics;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "ThreadHandlerTest" und soll
    ///alle ThreadHandlerTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class ThreadHandlerTest
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
        ///Ein Test für "ThreadHandler-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void ThreadHandlerConstructorTest()
        {
            int threads = 2; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads);

            Assert.AreEqual(target.getThreads(), threads);
        }

        /// <summary>
        ///Ein Test für "getInstance"
        ///</summary>
        [TestMethod()]
        public void getInstanceTest()
        {

            int threads = 2; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads);
            ThreadHandler actual = ThreadHandler.getInstance();
            Assert.AreEqual(actual, target);
            
        }

        /// <summary>
        ///Ein Test für "getThreads"
        ///</summary>
        [TestMethod()]
        public void getThreadsTest()
        {
            int threads = 2; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads); // TODO: Passenden Wert initialisieren
            int expected = 2; // TODO: Passenden Wert initialisieren
            int actual;
            actual = target.getThreads();
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///Ein Test für "getTime"
        ///</summary>
        [TestMethod()]
        public void getTimeTest()
        {
            int threads = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads); // TODO: Passenden Wert initialisieren
            
            long actual;
            actual = target.getTime();
            Assert.IsNotNull( actual > -1);
        }

        /// <summary>
        ///Ein Test für "invoke_refresh"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void invoke_refreshTest()
        {
            int threads = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads); // TODO: Passenden Wert initialisieren
            PictureBox pic = null; // TODO: Passenden Wert initialisieren
            target.refresh(pic);
        }

        /// <summary>
        ///Ein Test für "refresh"
        ///</summary>
        [TestMethod()]
        public void refreshTest()
        {
            int threads = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads); // TODO: Passenden Wert initialisieren
            PictureBox pic = new PictureBox(); // TODO: Passenden Wert initialisieren
            target.refresh(pic);
           
        }

        /// <summary>
        ///Ein Test für "register"
        ///</summary>
        [TestMethod()]
        public void registerTest()
        {
            PixelState p = PixelState.getInstance();

            int threads = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads); // TODO: Passenden Wert initialisieren
            Thread thread = new Thread(p.reset); // TODO: Passenden Wert initialisieren
            target.register(thread);

            Assert.IsFalse(target.threadsAreAlive());
            
        }

        /// <summary>
        ///Ein Test für "save_PixelState"
        ///</summary>
        [TestMethod()]
        public void save_PixelStateTest()
        {
            int threads = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads); // TODO: Passenden Wert initialisieren
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;
            ImageManipulatorType.Name manipulator = ImageManipulatorType.Name.RGB_RED; // TODO: Passenden Wert initialisieren
            ImageObject imgO = new ImageObject(img, manipulator);
            target.save_PixelState(imgO);
            PixelState state = PixelState.getInstance();
            Assert.IsInstanceOfType(state, typeof(PixelState));
            
           
        }

        /// <summary>
        ///Ein Test für "startTime"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void startTimeTest()
        {
            ThreadHandler t = new ThreadHandler(2); // TODO: Passenden Wert initialisieren
            PrivateObject param0 = new PrivateObject(t); // TODO: Passenden Wert initialisieren
            ThreadHandler_Accessor target = new ThreadHandler_Accessor(param0); // TODO: Passenden Wert initialisieren
            target.startTime();

            Assert.IsInstanceOfType(target.watch, typeof(Stopwatch));
            Assert.IsNotNull(target.watch);
        }

        /// <summary>
        ///Ein Test für "threadsAreAlive"
        ///</summary>
        [TestMethod()]
        public void threadsAreAliveTest()
        {
            int threads = 0; // TODO: Passenden Wert initialisieren
            ThreadHandler target = new ThreadHandler(threads); // TODO: Passenden Wert initialisieren
            bool expected = false; // TODO: Passenden Wert initialisieren
            bool actual;
            actual = target.threadsAreAlive();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "try_refresh"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void try_refreshTest()
        {
            // In refresh getestet. Ansonsten keine Ahnung wie zu testen
        }

        /// <summary>
        ///Ein Test für "try_save_PixelState"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void try_save_PixelStateTest()
        {
            ThreadHandler t = new ThreadHandler(2);
            PrivateObject param0 = new PrivateObject(t);
            ThreadHandler_Accessor target = new ThreadHandler_Accessor(param0); // TODO: Passenden Wert initialisieren
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;
            ImageManipulatorType.Name manipulator = ImageManipulatorType.Name.RGB_RED; // TODO: Passenden Wert initialisieren
            ImageObject imgO = new ImageObject(img, manipulator);
            target.try_save_PixelState(imgO);
            PixelState state = PixelState.getInstance();
            Assert.IsInstanceOfType(state.get_last(), typeof(ImageObject));
            Assert.IsNotNull(state.get_last());





         
            
        }
    }
}
