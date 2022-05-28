using System.Threading;

namespace TestHarness
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            progressBar.Maximum = 10487;

            progressBar.Value += 50;
            progressBar.Value -= 1;

            if (progressBar.Value == 10486)
            {
                progressBar.Value -= 1;
                progressBar.Value += 1;
                Thread.Sleep(250);
                this.Close();
            }
        }
    }
}
