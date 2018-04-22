// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelRelationshipUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    #region Usings

    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The relationship user control.
    /// </summary>
    public partial class ModelRelationshipUserControl : UserControl
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
        private Relationship dataSource;

        #endregion

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public Relationship DataSource
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

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ModelRelationshipUserControl" /> class.
        /// </summary>
        public ModelRelationshipUserControl()
        {
            this.InitializeComponent();
        }

        #endregion

        public string RelationshipName 
        {
            get
            {
                return this.LblRelationship.Text;
            }

            set
            {
                if (this.DataSource.RelationshipName != value)
                {
                    this.DataSource.RelationshipName = value;
                }

                if (this.LblRelationship.Text != value)
                {
                    this.LblRelationship.Text = value;
                }
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                this.RelationshipName = this.DataSource.RelationshipName;
                //                this.ColumnName = this.DataSource.ColumnName;
                //                this.Description = this.DataSource.Description;
                //                this.Order = this.DataSource.ColumnOrder;
                //                this.DataType = this.DataSource.DomainDataType;
                //                this.Length = this.DataSource.Length;
                //                this.Precision = this.DataSource.Precision;
                //                this.Scale = this.DataSource.Scale;
                //                this.DefaultValue = this.DataSource.DefaultFieldValue;
                //                this.IsRequired = this.DataSource.IsRequired;
                //                this.IsPrimaryKey = this.DataSource.IsPrimaryKey;
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }
    }
}