using Microsoft.VisualStudio.TestTools.UnitTesting;
using JOLO_FileManager;

namespace FileManagerTest
{
    [TestClass]
    public class Tests
    {
        private TestContext _context;

        private string? _filePath;

        [TestMethod]
        public void FileExistsPASS()
        {
            _filePath = _context.Properties["FileOne"].ToString();
            Assert.IsTrue(FileManager.FileExists(_filePath));
        }
        [TestMethod]
        public void FileExistsFAIL()
        {
            Assert.IsNull(FileManager.FileExists(_filePath));
        }
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