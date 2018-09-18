#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Logging;
using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Mapping.MetaData.Model;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    #region Usings

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

        private bool loading;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ModelUserControl" /> class.
        /// </summary>
        public ModelUserControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public Table DataSource
        {
            get { return dataSource; }

            set
            {
                dataSource = value;
                UpdateDataSource();
            }
        }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public string Description
        {
            get { return TxtDescription.Text; }

            set
            {
                if (DataSource.Description != value)
                {
                    DataSource.Description = value;
                }

                if (TxtDescription.Text != value)
                {
                    TxtDescription.Text = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the model name.
        /// </summary>
        public string ModelName
        {
            get { return TxtName.Text; }

            set
            {
                if (DataSource.TableName != value)
                {
                    DataSource.TableName = value;
                }

                if (TxtName.Text != value)
                {
                    TxtName.Text = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the schema name.
        /// </summary>
        public string SchemaName
        {
            get { return TxtSchema.Text; }

            set
            {
                if (DataSource.SchemaName != value)
                {
                    DataSource.SchemaName = value;
                }

                if (TxtSchema.Text != value)
                {
                    TxtSchema.Text = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the EnabledForCodeGeneration .
        /// </summary>
        public bool EnabledForCodeGeneration
        {
            get { return chkEnabledForCodeGeneration.Checked; }

            set
            {
                if (DataSource.EnabledForCodeGeneration != value)
                {
                    DataSource.EnabledForCodeGeneration = value;
                }

                if (chkEnabledForCodeGeneration.Checked != value)
                {
                    chkEnabledForCodeGeneration.Checked = value;
                }
            }
        }



        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        /// >
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validation()");

            List<Validation> result = new List<Validation>();

            if (string.IsNullOrEmpty(TxtName.Text))
            {
                Validation validation = new Validation(
                    ValidationType.ModelErrorName,
                    "The model name may not be empty");
                result.Add(validation);
                ErrorProvider1.SetError(TxtName, validation.Description);
            }

            Logger.Trace("Completed Validation()");
            return result;
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The txt description_ text changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!this.loading)
            {
                Description = TxtDescription.Text;
            }
        }

        /// <summary>
        ///     The txt name_ text changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (!this.loading)
            {
                ModelName = TxtName.Text;
            }
        }

        /// <summary>
        /// The chkEnabledForCodeGeneration Checked changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkEnabledForCodeGeneration_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.loading)
            {
                EnabledForCodeGeneration = chkEnabledForCodeGeneration.Checked;
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (DataSource != null)
            {
                this.loading = true;

                SchemaName = DataSource.SchemaName;
                ModelName = DataSource.TableName;
                Description = Description;
                EnabledForCodeGeneration = DataSource.EnabledForCodeGeneration;

                this.loading = false;
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