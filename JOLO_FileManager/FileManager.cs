using System.Text;

namespace JOLO_FileManager
{
    public class FileManager
    {
        public string? FilePath { get; set; }

        public FileManager(string filePath)
        {
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));
            FilePath = filePath;
        }
        public bool FileExists() // Group
        {
            return File.Exists(FilePath);
        }
        public string DirectoryName() // Martin
        {
            return Directory.GetParent(FilePath!).Name;
        }
        public string LargestFileInCurrentDirectory() // Rolo
        {
            FileInfo[] files = Directory.GetParent(FilePath!).GetFiles();
            if (files.Length == 0)
            {
                return String.Empty;
            }

            FileInfo largestFile = files[0]; 
            List<string> largeTies = new();

            for (int i = 0; i < files.Length; i++)
            {
                if (i > 0 && files[i].Length == largestFile.Length)
                {
                    largeTies.Add(files[i].Name);

                    if (!largeTies.Contains(largestFile.Name))
                    {
                        largeTies.Add(largestFile.Name);
                    }
                }
                if (files[i].Length > largestFile.Length)
                {
                    largestFile = files[i];
                }    
            }

            if (largeTies.Count > 0)
            {
                largeTies.Sort();
                return largeTies[0];
            }

            return largestFile.Name;
        }
        public string VowelWeight() // Neal
        {
            // If not .txt return all 0's
            if (Path.GetExtension(FilePath) != ".txt") 
            {
                return "0 A's, 0 E's, 0 I's, 0 O's, 0 U's, 0 Y's";
            }
            // Count vowels (Method Below)
            int[] vowelCounts = GetVowelCounts(
                File.ReadAllText(FilePath!)); // Whole .txt doc => String
            // Output vowels in correct format (Method Below)
            return GetVowelOutputs(vowelCounts); 
        }
        public string FileName() // Martin
        {
            return Path.GetFileNameWithoutExtension(FilePath!);
        }
        public string FileExtension() // Martin
        {
            return Path.GetExtension(FilePath!);
        }
        public byte[]? GetByteArray() // Rolo
        {
            return File.ReadAllBytes(FilePath!);
        }
        public override string ToString() // Neal
        {
            FileInfo fileInfo = new(FilePath!);
            return 
                FilePath + "\n" +
                fileInfo.Length + "\n" +
                fileInfo.IsReadOnly + "\n" +
                fileInfo.LastWriteTime;
        }

        // The methods below are only public/static for ease of testing
        // Will return to private / non-static when release build is made

        public static int[] GetVowelCounts(string allText)
        {
            int[] vowelCounts = new int[6]; // Store the 6 vowels 0-5 alphabetically

            for (int i = 0; i < allText.Length; i++)
            {
                if (allText[i].ToString().ToLower() == "a")
                {
                    vowelCounts[0]++;
                }
                if (allText[i].ToString().ToLower() == "e")
                {
                    vowelCounts[1]++;
                }
                if (allText[i].ToString().ToLower() == "i")
                {
                    vowelCounts[2]++;
                }
                if (allText[i].ToString().ToLower() == "o")
                {
                    vowelCounts[3]++;
                }
                if (allText[i].ToString().ToLower() == "u")
                {
                    vowelCounts[4]++;
                }
                if (allText[i].ToString().ToLower() == "y")
                {
                    vowelCounts[5]++;
                }
            }
            return vowelCounts;
        }
        public static string GetVowelOutputs(int[] vowelCounts)
        {
            StringBuilder sb = new();

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