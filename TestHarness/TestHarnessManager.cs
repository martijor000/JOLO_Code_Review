using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManagerTest;

namespace TestHarness
{
    [TestClass]
    public class TestHarnessManager
    {
        // The idea of this class is to run all methods inside the other test project and input the filepath.
        // While the the tests class will take input from this class.

        [TestMethod]
        public void AllMetrics(string filepath)
        {
            Tests ts = new Tests();
            ts.FileExistsPASS();
        }
    }
}