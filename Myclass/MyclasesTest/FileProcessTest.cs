using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Myclass;

namespace MyclasesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //act
            fromCall = fp.FileExists(@"C:\Users\jmichael\Downloads\working.txt");

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
            fromCall = fp.FileExists(@"C:\Users\jmichael\Downloads\woking.txt");

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
