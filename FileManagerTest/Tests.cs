using Microsoft.VisualStudio.TestTools.UnitTesting;
using JOLO_FileManager;
using System;

namespace FileManagerTest
{
    [TestClass]
    public class Tests
    {
        private static string? _filePath;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            //string fileName = "ich_will.mp3";
            //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            _filePath = context.Properties["FileOne"].ToString();
        }

        [TestMethod]
        public void FileExistsPASS()
        {
            Assert.IsTrue(FileManager.FileExists(_filePath));
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