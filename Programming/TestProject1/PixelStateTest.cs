using Programming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "PixelStateTest" und soll
    ///alle PixelStateTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class PixelStateTest
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
        ///Ein Test für "add"
        ///</summary>
        [TestMethod()]
        public void addTest()
        {
            PixelState target = PixelState.getInstance();
            Bitmap b = new Bitmap(10,10);
            Image img = (Image)b;
            ImageObject imgObj = new ImageObject(img, ImageManipulatorType.Name.GRAYSCALE);

            ImageObject imgObj2 = target.get_last();
            Assert.IsNull(imgObj2);
            target.add(imgObj);

            imgObj2 = target.get_last();

            Assert.IsInstanceOfType(imgObj2, typeof(ImageObject));
            Assert.IsNotNull(imgObj2);
        }

        /// <summary>
        ///Ein Test für "getInstance"
        ///</summary>
        [TestMethod()]
        public void getInstanceTest()
        {
            PixelState expected = PixelState.getInstance(); 
            PixelState actual;
            actual = PixelState.getInstance();
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///Ein Test für "get_last"
        ///</summary>
        [TestMethod()]
        public void get_lastTest()
        {
            PixelState target = PixelState.getInstance();
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;

            ImageObject imgObj1 = new ImageObject(img, ImageManipulatorType.Name.INVERT);
            ImageObject imgObj2 = new ImageObject(img, ImageManipulatorType.Name.GRAYSCALE);
            ImageObject imgObj3 = new ImageObject(img, ImageManipulatorType.Name.RGB_RED);

            target.add(imgObj3);
            target.add(imgObj2);
            target.add(imgObj1);

            ImageObject img_last = target.get_last();

            Assert.AreEqual(img_last.get_ImageManipulatorType(), imgObj1.get_ImageManipulatorType());

            target.add(imgObj3);
            img_last = target.get_last();
            Assert.AreEqual(img_last.get_ImageManipulatorType(), imgObj3.get_ImageManipulatorType());
        }

        /// <summary>
        ///Ein Test für "remove_last"
        ///</summary>
        [TestMethod()]
        public void remove_lastTest()
        {
            PixelState target = PixelState.getInstance();
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;

            ImageObject imgObj1 = new ImageObject(img, ImageManipulatorType.Name.INVERT);
            ImageObject imgObj2 = new ImageObject(img, ImageManipulatorType.Name.GRAYSCALE);
            ImageObject imgObj3 = new ImageObject(img, ImageManipulatorType.Name.RGB_RED);
            target.reset();
            target.add(imgObj3);
            target.add(imgObj2);
            target.add(imgObj1);

            ImageObject img_last = target.remove_last();

            Assert.AreEqual(img_last.get_ImageManipulatorType(), imgObj1.get_ImageManipulatorType());


            img_last = target.remove_last();
            Assert.AreEqual(img_last.get_ImageManipulatorType(), imgObj2.get_ImageManipulatorType());

            img_last = target.remove_last();
            Assert.AreEqual(img_last.get_ImageManipulatorType(), imgObj3.get_ImageManipulatorType());

            img_last = target.remove_last(); 
            Assert.IsNull(img_last);

        }

        /// <summary>
        ///Ein Test für "reset"
        ///</summary>
        [TestMethod()]
        public void resetTest()
        {
            PixelState target = PixelState.getInstance();
            Bitmap b = new Bitmap(10, 10);
            Image img = (Image)b;

            ImageObject imgObj1 = new ImageObject(img, ImageManipulatorType.Name.INVERT);
            ImageObject imgObj2 = new ImageObject(img, ImageManipulatorType.Name.GRAYSCALE);
            ImageObject imgObj3 = new ImageObject(img, ImageManipulatorType.Name.RGB_RED);

            target.add(imgObj3);
            target.add(imgObj2);
            target.add(imgObj1);
            ImageObject img_last = target.get_last();
            

            img_last = target.get_last();
            Assert.AreEqual(img_last.get_ImageManipulatorType(), imgObj1.get_ImageManipulatorType());
            target.reset();
            ImageObject img_last2 = target.get_last();
            Assert.IsNull(img_last2);
        }
    }
}
