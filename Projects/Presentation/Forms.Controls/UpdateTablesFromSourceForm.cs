// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateTablesFromSourceForm.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    ///     The update tables from source form.
    /// </summary>
    public partial class UpdateTablesFromSourceForm : Form
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateTablesFromSourceForm" /> class.
        /// </summary>
        public UpdateTablesFromSourceForm()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The button 3_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}