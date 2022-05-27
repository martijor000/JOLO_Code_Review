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
            string fileName = context.Properties["FileOne"].ToString()!;
            string path = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory())
                .Parent.Parent.Parent.ToString(), @"Files\", fileName);
            _filePath = path;
        }

        [TestMethod]
        public void FileExistsPASS()
        {
            FileManager fm = new(_filePath!);
            Assert.IsTrue(fm.FileExists());
        }
        [TestMethod]
        public void FileExistsFAIL()
        {
            FileManager fm = new("");
            Assert.IsFalse(fm.FileExists());
        }
        [TestMethod]
        public void DirectoryNamePASS()
        {
            FileManager fm = new(_filePath!);
            Assert.AreEqual("Files", fm.DirectoryName());
        }
        [TestMethod]
        public void DirectoryNameFAIL()
        {
            FileManager fm = new(_filePath!);
            Assert.AreNotEqual("Fail", fm.DirectoryName());
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
            FileManager fm = new(_filePath!);
            Assert.AreEqual("1 A, 2 E's, 3 I's, 0 O's, 2 U's, 1 Y",
                fm.VowelWeight());
        }
        [TestMethod]
        public void VowelWeightNOTTXTFILE()
        {
            FileManager fm = new("");
            Assert.AreEqual("0 A's, 0 E's, 0 I's, 0 O's, 0 U's, 0 Y's", 
                fm.VowelWeight());
        }
        [TestMethod]
        public void GetVowelOutputALLONES()
        {
            int[] allOnes = { 1, 1, 1, 1, 1, 1 };
            Assert.AreEqual("1 A, 1 E, 1 I, 1 O, 1 U, 1 Y", 
                FileManager.GetVowelOutputs(allOnes));
        }
        [TestMethod]
        public void GetVowelOutputALLNINES()
        {
            int[] allNines = { 9, 9, 9, 9, 9, 9 };
            Assert.AreEqual("9 A's, 9 E's, 9 I's, 9 O's, 9 U's, 9 Y's", 
                FileManager.GetVowelOutputs(allNines));
        }
        [TestMethod]
        public void GetVowelCountALLZEROS()
        {
            int[] allZeros = { 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(allZeros, FileManager.GetVowelCounts(""));
        }
        [TestMethod]
        public void GetVowelCountALLTHREES()
        {
            int[] allThrees = { 3, 3, 3, 3, 3, 3 };
            CollectionAssert.AreEqual(allThrees, 
                FileManager.GetVowelCounts("aaaeeeiiiooouuuyyy"));
        }
        [TestMethod]
        public void FileNamePASS()
        {
            FileManager fm = new(_filePath!);
            Assert.AreEqual("One", fm.FileName());
        }
        [TestMethod]
        public void FileNameFAIL()
        {
            FileManager fm = new(_filePath!);
            Assert.AreNotEqual("Fail", fm.FileName());
        }
        [TestMethod]
        public void FileExtensionPASS()
        {
            FileManager fm = new(_filePath!);
            Assert.AreEqual(".txt", fm.FileExtension());
        }
        [TestMethod]
        public void FileExtensionFAIL()
        {
            FileManager fm = new(_filePath!);
            Assert.AreNotEqual("Fail", fm.FileExtension());
        }

        // Byte Array
        
        [TestMethod]
        public void ToStringTEST()
        {
            FileManager fm = new(_filePath!);
            string output = fm.ToString();
            Assert.IsNotNull(output);
        }
    }
}