using JOLO_FileManager;
using System.Text;

namespace TestHarness
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 0;
                ofd.Multiselect = false;
                DialogResult = ofd.ShowDialog();

                if (DialogResult == DialogResult.OK)
                {
                    FileManager fm = new(String.Empty);
                    StringBuilder sb = new();

                    sb.Append(
                        $"File Exists: {fm.FileExists()}\n" +
                        $"Directory Name: {fm.DirectoryName()}\n" +
                        $"Largest File In Current Directory: {fm.LargestFileInCurrentDirectory()}\n" +
                        $"Vowel Weight: {fm.VowelWeight()}\n" +
                        $"File Name: {fm.FileName()}\n" +
                        $"File Extension: {fm.FileExtension()}\n" +
                        $"Get Byte Array: {fm.GetByteArray()}\n" +
                        $"ToString() \n{fm}");

                    MessageBox.Show(sb.ToString());
                }
            }
        }
    }
}