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
            progressBar.Maximum = 10480;

            progressBar.Value += 500;
            progressBar.Value -= 1;

            if (progressBar.Value == 10479)
            {
                progressBar.Value -= 1;
                progressBar.Value += 1;
                Thread.Sleep(500);
                this.Close();
            }
        }
    }
}
