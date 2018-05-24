﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DriverUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Project.Drivers
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes;
    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    ///     The driver user control.
    /// </summary>
    public partial class DriverUserControl : UserControl
    {
        #region Fields

        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        /// <summary>
        ///     The driver types.
        /// </summary>
        private List<IDriverType> driverTypes;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DriverUserControl" /> class.
        /// </summary>
        public DriverUserControl()
        {
            this.InitializeComponent();
            this.driverTypes = new List<IDriverType>();
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
                if (this.dataSource != value)
                {
                    this.dataSource = value;
                    this.driverTypes = this.ReturnDriverTypes();
                    this.UpdateDataSource();
                }
            }
        }

        /// <summary>
        ///     Gets the driver types.
        /// </summary>
        public List<IDriverType> DriverTypes
        {
            get
            {
                return this.driverTypes;
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The return driver types.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        private List<IDriverType> ReturnDriverTypes()
        {
            List<IDriverType> result = new List<IDriverType>();

            IDriver driver;

            foreach (Guid driverId in this.DataSource.DriverIdList)
            {
                driver = ScaffoldConfig.ReturnDriver(driverId);

                if (!result.Any(d => d.Id == driver.DriverType.Id))
                {
                    result.Add(driver.DriverType);
                }
            }

            return result;
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            if (this.DataSource != null)
            {
                this.TabControl.TabPages.Clear();

                TabPage page;
                foreach (IDriverType driverType in this.DriverTypes)
                {
                    page = new TabPage { Text = driverType.Name, BackColor = DefaultBackColor };
                    page.Controls.Add(ScaffoldConfig.ReturnDriverDataTypeUi(driverType.Id, DisplayType.WinForm) as Control);
                    this.TabControl.TabPages.Add(page);
                }
            }
        }

        #endregion
    }
}