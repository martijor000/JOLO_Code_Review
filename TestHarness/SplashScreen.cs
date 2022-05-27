using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (LoadingBar.Value < 200)
            {
                LoadingBar.Value += 2;
            }
            if (LoadingBar.Value == 200)
            {
                this.Close();
            }
        }

    }
}
