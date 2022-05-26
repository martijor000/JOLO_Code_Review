using System.Text;

namespace JOLO_FileManager
{
    public class FileManager
    {
        public static bool FileExists(string filePath) // Group
        {
            return File.Exists(filePath);
        }
        public static string DirectoryName(string filePath) // Martin
        {
            return Directory.GetParent(filePath).Name;
        }
        public static string LargestFileInCurrentDirectory(/*filepath*/) // Rolo
        {
            return String.Empty;
        }
        //      if a tie is found, first one alpha sorted
        public static string VowelWeight(string filePath) // Neal
        {
            // If not .txt return all 0's
            if (Path.GetExtension(filePath) != ".txt") 
            {
                return "0 A's, 0 E's, 0 I's, 0 O's, 0 U's, 0 Y's";
            }
            // Count vowels (Method Below)
            int[] vowelCounts = GetVowelCounts(
                File.ReadAllText(filePath)); // Whole .txt doc => String
            // Output vowels in correct format (Method Below)
            return GetVowelOutputs(vowelCounts); 
        }
        public static string FileName(string filePath) // Martin
        {
            return Path.GetFileNameWithoutExtension(filePath);
        }
        public static string FileExtension(string filePath) // Martin
        {
            return Path.GetExtension(filePath);
        }
        public static byte[]? GetByteArray(/*filepath*/) // Rolo
        {
            return null;
        }
        public override string ToString() // Neal
        {
            return string.Empty;   
        }
        //      returns a string concatenation of:
        //          string FilePath
        //          long Size
        //          bool ReadOnly
        //          DateTime DateChanged

        public static int[] GetVowelCounts(string allText)
        {
            int[] vowelCounts = new int[6]; // Store the 6 vowels 0-5 alphabetically

            for (int j = 0; j < allText.Length; j++)
            {
                if (allText[j].ToString().ToLower() == "a")
                {
                    vowelCounts[0]++;
                }
                if (allText[j].ToString().ToLower() == "e")
                {
                    vowelCounts[1]++;
                }
                if (allText[j].ToString().ToLower() == "i")
                {
                    vowelCounts[2]++;
                }
                if (allText[j].ToString().ToLower() == "o")
                {
                    vowelCounts[3]++;
                }
                if (allText[j].ToString().ToLower() == "u")
                {
                    vowelCounts[4]++;
                }
                if (allText[j].ToString().ToLower() == "y")
                {
                    vowelCounts[5]++;
                }
            }
            return vowelCounts;
        }
        public static string GetVowelOutputs(int[] vowelCounts)
        {
            StringBuilder sb = new StringBuilder();

            if (vowelCounts[0] != 1) // [0] == A's
            {
                sb.Append($"{vowelCounts[0]} A's, ");
            }
            else
            {
                sb.Append("1 A, ");
            }
            if (vowelCounts[1] != 1) // [1] == E's
            {
                sb.Append($"{vowelCounts[1]} E's, ");
            }
            else
            {
                sb.Append("1 E, ");
            }
            if (vowelCounts[2] != 1) // [2] == I's
            {
                sb.Append($"{vowelCounts[2]} I's, ");
            }
            else
            {
                sb.Append("1 I, ");
            }
            if (vowelCounts[3] != 1) // [3] == O's
            {
                sb.Append($"{vowelCounts[3]} O's, ");
            }
            else
            {
                sb.Append("1 O, ");
            }
            if (vowelCounts[4] != 1) // [4] == U's
            {
                sb.Append($"{vowelCounts[4]} U's, ");
            }
            else
            {
                sb.Append("1 U, ");
            }
            if (vowelCounts[5] != 1) // [5] == Y's
            {
                sb.Append($"{vowelCounts[5]} Y's");
            }
            else
            {
                sb.Append("1 Y");
            }
            return sb.ToString();
        }
    }
}