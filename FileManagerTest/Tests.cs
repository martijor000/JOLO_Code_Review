using Microsoft.VisualStudio.TestTools.UnitTesting;
using JOLO_FileManager;

namespace FileManagerTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FileExistsPASS()
        {
            FileManager.FileExists();
        }
        [TestMethod]
        public void DirectoryNamePASS()
        {
            FileManager.DirectoryName();
        }
        [TestMethod]
        public void LargestFileInCurrentDirectoryPASS()
        {
            FileManager.LargestFileInCurrentDirectory();
        }
        [TestMethod]
        public void FileNamePASS()
        {
            FileManager.FileName();
        }
        [TestMethod]
        public void VowelWeightPASS()
        {
            FileManager.VowelWeight();
        }
        [TestMethod]
        public void FileExtensionPASS()
        {
            FileManager.FileExtension();
        }
        [TestMethod]
        public void GetByteArrayPASS()
        {
            FileManager.GetByteArray();
        }
    }
}