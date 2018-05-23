// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Presentation.UI
{
    #region Usings

    using System;
    using System.Windows.Forms;

    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Presentation.Forms;

    #endregion

    /// <summary>
    ///     The program.
    /// </summary>
    static class Program
    {
        #region Other Methods

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ScaffoldConfig.Load();
            Application.Run(new Form1());
        }

        #endregion
    }
}