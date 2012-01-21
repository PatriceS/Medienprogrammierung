using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "StatistikModelTest" und soll
    ///alle StatistikModelTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class StatistikModelTest
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
        ///Ein Test für "StatistikModel-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void StatistikModelConstructorTest()
        {
            Image image = new Bitmap(1,1);
           // StatistikModel target = new StatistikModel(image);
            StatistikModel_Accessor target = new StatistikModel_Accessor(image);
          //  target.bitmap
            Assert.IsInstanceOfType(target.bitmap, typeof(Bitmap));
            Assert.IsNotNull(target.bitmap);

            Image image2 = null;
            // StatistikModel target = new StatistikModel(image);
            StatistikModel_Accessor target2 = new StatistikModel_Accessor(image2);
            //  target.bitmap
            Assert.IsNotInstanceOfType(target2.bitmap, typeof(Bitmap));
            Assert.IsNull(target2.bitmap);
        }

        /// <summary>
        ///Ein Test für "calculate_average"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void calculate_averageTest()
        {
            Bitmap image = new Bitmap(3, 1);
            StatistikModel_Accessor target = new StatistikModel_Accessor(image); // TODO: Passenden Wert initialisieren
            int sum_grey_values = 9;
            int expected = 3; 
            int actual;
            actual = target.calculate_average(sum_grey_values);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "calculate_entropy"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void calculate_entropyTest()
        {
            Bitmap image = new Bitmap(3, 1);
            StatistikModel_Accessor target = new StatistikModel_Accessor(image); 
            double expected = 0F; 
            double actual;
            actual = target.calculate_entropy();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "calculate_peak"
        ///</summary>
        [TestMethod()]
        public void calculate_peakTest()
        {
            Bitmap image = new Bitmap(3, 1);
            StatistikModel_Accessor target = new StatistikModel_Accessor(image); 
            int histo = 3; 
            int peak = 100; 
            int expected = 100; 
            int actual;
            actual = target.calculate_peak(histo, peak);
            Assert.AreEqual(expected, actual);

             histo = 100;
             peak = 3;
             expected = 100;
            
            actual = target.calculate_peak(histo, peak);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "calculate_variance"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Programming.exe")]
        public void calculate_varianceTest()
        {
            Bitmap image = new Bitmap(3, 1);
            StatistikModel_Accessor target = new StatistikModel_Accessor(image); 
            double expected = 0F; 
            double actual;
            actual = target.calculate_variance();
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///Ein Test für "draw_histogram"
        ///</summary>
        [TestMethod()]
        public void draw_histogramTest()
        {
            Bitmap bitmap = new Bitmap(3, 1);
            StatistikModel acc = new StatistikModel(bitmap);

            System.Windows.Forms.PictureBox statistik_pic = new System.Windows.Forms.PictureBox();
            statistik_pic.Image = (Image)bitmap;
            acc.draw_histogram(statistik_pic, Config.histogram_canal.GREEN);


            
        }

        /// <summary>
        ///Ein Test für "findMinMax"
        ///</summary>
        [TestMethod()]
        public void findMinMaxTest()
        {
            Bitmap bitmap = new Bitmap(3, 1);
            StatistikModel target = new StatistikModel(bitmap); 
            int grey = 0; 
            target.findMinMax(grey);
            Assert.AreEqual(target.get_max_value(), 0);
        }

        /// <summary>
        ///Ein Test für "get_average"
        ///</summary>
        [TestMethod()]
        public void get_averageTest()
        {
            Bitmap bitmap = new Bitmap(3, 1);
            StatistikModel target = new StatistikModel(bitmap); 
            int expected = 0; // TODO: Passenden Wert initialisieren
            int actual;
            actual = target.get_average();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "get_entropy"
        ///</summary>
        [TestMethod()]
        public void get_entropyTest()
        {
            Bitmap bitmap = new Bitmap(3, 1);
            StatistikModel target = new StatistikModel(bitmap); 
            double expected = 0F; // TODO: Passenden Wert initialisieren
            double actual;
            actual = target.get_entropy();
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///Ein Test für "get_max_value"
        ///</summary>
        [TestMethod()]
        public void get_max_valueTest()
        {
            Bitmap bitmap = new Bitmap(3, 1);
            StatistikModel target = new StatistikModel(bitmap); 
            int expected = 0; // TODO: Passenden Wert initialisieren
            int actual;
            actual = target.get_max_value();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "get_min_value"
        ///</summary>
        [TestMethod()]
        public void get_min_valueTest()
        {
            Bitmap bitmap = new Bitmap(3, 1);
            StatistikModel target = new StatistikModel(bitmap); 
            int expected = 255; // TODO: Passenden Wert initialisieren
            int actual;
            actual = target.get_min_value();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "get_variance"
        ///</summary>
        [TestMethod()]
        public void get_varianceTest()
        {
            Bitmap bitmap = new Bitmap(3, 1);
            StatistikModel target = new StatistikModel(bitmap); 
            double expected = 0F; // TODO: Passenden Wert initialisieren
            double actual;
            actual = target.get_variance();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Ein Test für "prepare_histogram_data"
        ///</summary>
        [TestMethod()]
        public void prepare_histogram_dataTest()
        {
            Bitmap bitmap = new Bitmap(3, 1);
            StatistikModel_Accessor target = new StatistikModel_Accessor(bitmap);
            target.entropy = 1234.34;
            Assert.AreEqual( 1234.34, target.get_entropy());
            target.prepare_histogram_data();
            Assert.IsNotNull(target.get_entropy());
           
        }
    }
}
