namespace JOLO_FileManager
{
    public class FileManager
    {
        public static bool FileExists(string filePath) // Group
        {
            bool result = File.Exists(filePath);
            return result;
        }
        public static string DirectoryName(/*filepath*/) // Martin
        {
            return String.Empty;
        }
        public static string LargestFileInCurrentDirectory(/*filepath*/) // Rolo
        {
            return String.Empty;
        }
        //      if a tie is found, first one alpha sorted
        public static string VowelWeight(/*filepath*/) // Neal
        {
            return String.Empty;
        }
        //      Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
        //      return all zeros if file supplied has no txt extension
        public static string FileName(/*filepath*/) // Martin
        {
            return String.Empty;
        }
        public static string FileExtension(/*filepath*/) // Martin
        {
            return String.Empty;
        }
        public static byte[]? GetByteArray(/*filepath*/) // Rolo
        {
            return null;
        }
        public override string ToString() // Neal
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