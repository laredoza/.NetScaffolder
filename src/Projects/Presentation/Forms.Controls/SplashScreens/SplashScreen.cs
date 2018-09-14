// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SplashScreen.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.SplashScreens
{
    #region Usings

    using SplashScreenThreaded;

    #endregion

    /// <summary>
    ///     Initiate instance of SplashScreen
    /// </summary>
    public static class SplashScreen
    {
        #region Static Fields

        /// <summary>
        /// The splashScreen.
        /// </summary>
        private static SplashScreenForm splashScreen;

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     Closes the SplashScreen
        /// </summary>
        public static void CloseSplashScreen()
        {
            if (splashScreen != null)
            {
                splashScreen.CloseSplashScreen();
                splashScreen = null;
            }
        }

        /// <summary>
        ///     Displays the Splash Screen
        /// </summary>
        public static void ShowSplashScreen()
        {
            if (splashScreen == null)
            {
                splashScreen = new SplashScreenForm();
                splashScreen.ShowSplashScreen();
            }
        }

        /// <summary>
        /// Update text in default green color of success message
        /// </summary>
        /// <param name="Text">
        /// Message
        /// </param>
        public static void UdpateStatusText(string Text)
        {
            if (splashScreen != null)
                splashScreen.UdpateStatusText(Text);
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
        public static void UdpateStatusTextWithStatus(string Text, TypeOfMessage tom)
        {
            if (splashScreen != null)
                splashScreen.UdpateStatusTextWithStatus(Text, tom);
        }

        #endregion
    }
}