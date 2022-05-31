using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Myclass;

namespace MyclasesTest
{
    
    [TestClass]
    public class FileProcessTest
    {
        private const string  BadPath = @"C:\Users\jmichael\Downloads\woking.txt";
        private const string GoodPath = @"C:\Users\jmichael\Downloads\working.txt";
        public TestContext TestContext{get; set;}

        [TestMethod]
        public void FileNameDoesExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //act
            fromCall = fp.FileExists(GoodPath);

            TestContext.WriteLine("checking if file exists at"+GoodPath);
            //assert
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //act
            fromCall = fp.FileExists(BadPath);
            
            //assert
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameIsNull_usingAttribute()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");

        }

        [TestMethod]
        public void FileNameIsEmpty_UsingTryCatch()
        {
            FileProcess fp = new FileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentException)
            {
                //test was a success
                return;
            }
            
            Assert.Fail("Call to file failed as file exists did not throw an exception");

        }
    }
}
