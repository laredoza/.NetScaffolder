// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SplashScreenForm.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SplashScreenThreaded
{
    #region Usings

    using System.Drawing;
    using System.Windows.Forms;

    using DotNetScaffolder.Presentation.Forms.Controls.SplashScreens;

    #endregion

    /// <summary>
    /// The splash screen form.
    /// </summary>
    public partial class SplashScreenForm : Form
    {
        #region Fields

        /// <summary>
        ///     To ensure splash screen is closed using the API and not by keyboard or any other things
        /// </summary>
        private bool CloseSplashScreenFlag;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SplashScreenForm"/> class. 
        ///     Base constructor
        /// </summary>
        public SplashScreenForm()
        {
            this.InitializeComponent();
            this.label1.Parent = this.pictureBox1;

            // this.label1.BackColor = Color.Transparent;
            // label1.ForeColor = Color.Green;

            // this.progressBar1.Parent = this.pictureBox1;
            // this.progressBar1.BackColor = Color.Transparent;
            this.progressBar1.Show();
        }

        #endregion

        /// <summary>
        /// The splash show close delegate.
        /// </summary>
        private delegate void SplashShowCloseDelegate();

        /// <summary>
        /// The string parameter delegate.
        /// </summary>
        /// <param name="Text">
        /// The text.
        /// </param>
        private delegate void StringParameterDelegate(string Text);

        /// <summary>
        /// The string parameter with status delegate.
        /// </summary>
        /// <param name="Text">
        /// The text.
        /// </param>
        /// <param name="tom">
        /// The tom.
        /// </param>
        private delegate void StringParameterWithStatusDelegate(string Text, TypeOfMessage tom);

        #region Public Methods And Operators

        /// <summary>
        ///     Closes the SplashScreen
        /// </summary>
        public void CloseSplashScreen()
        {
            if (this.InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                this.BeginInvoke(new SplashShowCloseDelegate(this.CloseSplashScreen));
                return;
            }

            this.CloseSplashScreenFlag = true;
            this.Close();
        }

        /// <summary>
        ///     Displays the splashscreen
        /// </summary>
        public void ShowSplashScreen()
        {
            if (this.InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                this.BeginInvoke(new SplashShowCloseDelegate(this.ShowSplashScreen));
                return;
            }

            this.Show();
            Application.Run(this);
        }

        /// <summary>
        /// Update text in default green color of success message
        /// </summary>
        /// <param name="Text">
        /// Message
        /// </param>
        public void UdpateStatusText(string Text)
        {
            if (this.InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                this.BeginInvoke(new StringParameterDelegate(this.UdpateStatusText), Text);
                return;
            }

            // Must be on the UI thread if we've got this far
            // label1.ForeColor = Color.Green;
            this.label1.Text = Text;
        }

        /// <summary>
        /// Update text with message color defined as green/yellow/red/ for success/warning/failure
        /// </summary>
        /// <param name="Text">
        /// Message
        /// </param>
        /// <param name="tom">
        /// Type of Message
        /// </param>
        public void UdpateStatusTextWithStatus(string Text, TypeOfMessage tom)
        {
            if (this.InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                this.BeginInvoke(new StringParameterWithStatusDelegate(this.UdpateStatusTextWithStatus), Text, tom);
                return;
            }

            // Must be on the UI thread if we've got this far
            switch (tom)
            {
                case TypeOfMessage.Error:
                    this.label1.ForeColor = Color.Red;
                    break;
                case TypeOfMessage.Warning:
                    this.label1.ForeColor = Color.Yellow;
                    break;
                case TypeOfMessage.Success:
                    // label1.ForeColor = Color.Green;
                    break;
            }

            this.label1.Text = Text;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// Prevents the closing of form other than by calling the CloseSplashScreen function
        /// </summary>
        /// <param name="sender">
        /// </param>
        /// <param name="e">
        /// </param>
        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.CloseSplashScreenFlag == false)
                e.Cancel = true;
        }

        #endregion
    }
}