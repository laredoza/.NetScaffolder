// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The table user control.
    /// </summary>
    public partial class ModelUserControl : UserControl, IValidate
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
        private Table dataSource;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ModelUserControl" /> class.
        /// </summary>
        public ModelUserControl()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public Table DataSource
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
        /// Gets or sets the description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.TxtDescription.Text;
            }

            set
            {
                if (this.DataSource.Description != value)
                {
                    this.DataSource.Description = value;
                }

                if (this.TxtDescription.Text != value)
                {
                    this.TxtDescription.Text = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the model name.
        /// </summary>
        public string ModelName
        {
            get
            {
                return this.TxtName.Text;
            }

            set
            {
                if (this.DataSource.TableName != value)
                {
                    this.DataSource.TableName = value;
                }

                if (this.TxtName.Text != value)
                {
                    this.TxtName.Text = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the schema name.
        /// </summary>
        public string SchemaName
        {
            get
            {
                return this.TxtSchema.Text;
            }

            set
            {
                if (this.DataSource.SchemaName != value)
                {
                    this.DataSource.SchemaName = value;
                }

                if (this.TxtSchema.Text != value)
                {
                    this.TxtSchema.Text = value;
                }
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The txt description_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            this.Description = this.TxtDescription.Text;
        }

        /// <summary>
        /// The txt name_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            this.ModelName = this.TxtName.Text;
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                this.SchemaName = this.DataSource.SchemaName;
                this.ModelName = this.DataSource.TableName;
                this.Description = this.Description;
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion

        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>>
        public List<Validation> ValidationResult { get; set; }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validation()");

            List<Validation> result = new List<Validation>();

            if (string.IsNullOrEmpty(this.TxtName.Text))
            {
                Validation validation = new Validation(ValidationType.ModelErrorName, "The model name may not be empty");
                result.Add(validation);
                this.ErrorProvider1.SetError(this.TxtName, validation.Description);
            }

            Logger.Trace("Completed Validation()");
            return result;
        }
    }
}