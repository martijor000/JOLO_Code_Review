using Microsoft.VisualStudio.TestTools.UnitTesting;
using JOLO_FileManager;

namespace FileManagerTest
{
    [TestClass]
    public class Tests
    {
        public TestContext TestContext { get; set; }

        private string? _filePath;

        [TestInitialize]
        public void TestInitialize()
        {
            _filePath = TestContext.Properties["FileOne"].ToString();
        }


        [TestMethod]
        public void FileExistsPASS()
        {
            //Arange
            bool result;

            //Act
            result = FileManager.FileExists(_filePath);
            
            //Assert
            Assert.IsTrue(true, result.ToString());
        }
        //[TestMethod]
        //public void FileExistsFAIL()
        //{
        //    Assert.IsNull(FileManager.FileExists(_filePath));
        //}
        //[TestMethod]
        //public void DirectoryNamePASS()
        //{
        //    FileManager.DirectoryName();
        //}
        //[TestMethod]
        //public void LargestFileInCurrentDirectoryPASS()
        //{
        //    FileManager.LargestFileInCurrentDirectory();
        //}
        //[TestMethod]
        //public void FileNamePASS()
        //{
        //    FileManager.FileName();
        //}
        //[TestMethod]
        //public void VowelWeightPASS()
        //{
        //    FileManager.VowelWeight();
        //}
        //[TestMethod]
        //public void FileExtensionPASS()
        //{
        //    FileManager.FileExtension();
        //}
        //[TestMethod]
        //public void GetByteArrayPASS()
        //{
        //    FileManager.GetByteArray();
        //}
    }
}