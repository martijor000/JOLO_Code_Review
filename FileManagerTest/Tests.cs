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
            FileManager.FileExists()
        }
    }
}