namespace JOLO_FileManager
{
    public class FileManager
    {
        string _filename = @"C:\JOLO_FileManager\\FileManagerTest\\Files";
        public static bool FileExists(/*filepath*/)
        {
            return true;
        }
        public static string DirectoryName(/*filepath*/)
        {
            return String.Empty;
        }
        public static string LargestFileInCurrentDirectory(/*filepath*/)
        {
            return String.Empty;
        }
        //      if a tie is found, first one alpha sorted
        public static string VowelWeight(/*filepath*/)
        {
            return String.Empty;
        }
        //      Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
        //      return all zeros if file supplied has no txt extension
        public static string FileName(/*filepath*/)
        {
            return String.Empty;
        }
        public static string FileExtension(/*filepath*/)
        {
            return String.Empty;
        }
        public static byte[]? GetByteArray(/*filepath*/)
        {
            return null;
        }
        public override string ToString()
        {
            return String.Empty;
        }
        //      returns a string concatenation of:
        //          string FilePath
        //          long Size
        //          bool ReadOnly
        //          DateTime DateChanged
    }
}