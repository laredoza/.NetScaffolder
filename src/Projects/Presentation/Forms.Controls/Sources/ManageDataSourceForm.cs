﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ManageDataSourceForm.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Sources
{
    #region Usings

    using System;
    using System.Threading;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Presentation.Forms.Controls.SplashScreens;

    using SplashScreenThreaded;

    #endregion

    /// <summary>
    ///     The manage data source form.
    /// </summary>
    public partial class ManageDataSourceForm : Form
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        /// <summary>
        ///     The source type.
        /// </summary>
        private ISourceType sourceType;

        /// <summary>
        ///     The source type control.
        /// </summary>
        private IDataSourceUI sourceTypeControl;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ManageDataSourceForm" /> class.
        /// </summary>
        public ManageDataSourceForm()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource
        {
            get
            {
                return this.dataSource;
            }

            set
            {
                this.dataSource = value;
                this.UpdateDataSource();
            }
        }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath { get; set; }

        #endregion

        #region Other Methods

        /// <summary>
        /// The btn save_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.sourceTypeControl.Validate().Count == 0)
            {
                this.sourceTypeControl.SaveData(this.SavePath);
                this.Close();
            }
        }

        /// <summary>
        /// The btn test_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnTest_Click(object sender, EventArgs e)
        {
            Logger.Trace("Test Button Click Start");

            if (this.DataSource != null && this.sourceTypeControl.Validate().Count == 0)
            {
                Thread splashthread = this.StartSplashScreen();
                Thread.Sleep(100);
                SplashScreen.UdpateStatusText("Loading schema information");

                if (this.sourceTypeControl.TestData(this.SavePath, true))
                {
                    Thread.Sleep(100);
                    this.CloseSplashScreen();

                    MessageBox.Show(
                        "Connected to Datasource",
                        "Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    Thread.Sleep(100);
                    this.CloseSplashScreen();

                    MessageBox.Show(
                        "Failed to Connect to Datasource",
                        "Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }

            Logger.Trace("Test Button Click Completed");
        }

        private Thread StartSplashScreen()
        {
            this.Hide();
            Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();

            return splashthread;
        }

        private void CloseSplashScreen(bool show = true)
        {
            if (show)
            {
                this.Show();
            }

            SplashScreen.CloseSplashScreen();
            this.Activate();
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                Thread splashthread = this.StartSplashScreen();
                Thread.Sleep(100);
                SplashScreen.UdpateStatusText("Loading schema information");

                this.sourceType = ScaffoldConfig.ReturnSourceType(this.DataSource.SourceTypeId);
                this.tabPage2.Controls.Clear();
                this.sourceTypeControl = this.sourceType.AddConfigUI(this.tabPage2) as IDataSourceUI;
                this.sourceTypeControl.SourceType = this.sourceType;

                if (this.sourceTypeControl.LoadData(this.SavePath))
                {
                    Thread.Sleep(100);
                    this.CloseSplashScreen();
                }
                else
                {
                    Thread.Sleep(100);
                    this.CloseSplashScreen();

                    MessageBox.Show(
                        "Failed to Connect to Datasource",
                        "Loading",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion
    }
}