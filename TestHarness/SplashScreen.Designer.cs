namespace TestHarness
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LoadingBar
            // 
            this.LoadingBar.BackColor = System.Drawing.Color.White;
            this.LoadingBar.Location = new System.Drawing.Point(183, 486);
            this.LoadingBar.Maximum = 200;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(290, 20);
            this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LoadingBar.TabIndex = 0;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Enabled = true;
            this.tmrLoading.Interval = 20;
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 657);
            this.Controls.Add(this.LoadingBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar LoadingBar;
        private System.Windows.Forms.Timer tmrLoading;
    }
}