using Microsoft.VisualStudio.TestTools.UnitTesting;
using JOLO_FileManager;
using System.IO;

namespace FileManagerTest
{
    [TestClass]
    public class Tests
    {
        private static string? _filePath = null;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            string fileName = context.Properties["FileOne"].ToString();
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())
                .Parent.Parent.Parent.ToString(), @"Files\", fileName);
            _filePath = path;
        }

        [TestMethod]
        public void FileExistsPASS()
        {
            Assert.IsTrue(FileManager.FileExists(_filePath));
        }
        [TestMethod]
        public void FileExistsFAIL()
        {
            Assert.IsFalse(FileManager.FileExists(null));
            Assert.IsFalse(FileManager.FileExists(""));
        }
        [TestMethod]
        public void DirectoryNamePASS()
        {
            Assert.AreEqual("Files", FileManager.DirectoryName(_filePath));

        }
        [TestMethod]
        public void DirectoryNameFAIL()
        {
            Assert.AreNotEqual("Fail", FileManager.DirectoryName(_filePath));
        }
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
        [TestMethod]
        public void VowelWeightPASS()
        {
            Assert.AreEqual("1 A, 2 E's, 3 I's, 0 O's, 2 U's, 1 Y",
                FileManager.VowelWeight(_filePath));
        }
        [TestMethod]
        public void VowelWeightFAIL()
        {
            Assert.AreNotEqual("", FileManager.VowelWeight(_filePath));
        }
        [TestMethod]
        public void FileNamePASS()
        {
            Assert.AreEqual("One", FileManager.FileName(_filePath));
        }
        [TestMethod]
        public void FileNameFAIL()
        {
            Assert.AreNotEqual("Fail", FileManager.FileName(_filePath));
        }
        [TestMethod]
        public void FileExtensionPASS()
        {
            Assert.AreEqual(".txt", FileManager.FileExtension(_filePath));
        }
        [TestMethod]
        public void FileExtensionFail()
        {
            Assert.AreNotEqual("Fail", FileManager.FileExtension(_filePath));
        }

        // Byte Array


        // ToString
    }
}