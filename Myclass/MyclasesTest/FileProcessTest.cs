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
        public void FileNameIsNull_usingAttribute()
        {

        }
        [TestMethod]
        public void FileNameIsEmpty_UsingTryCatch()
        {

        }
    }
}
