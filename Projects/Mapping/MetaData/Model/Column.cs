// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Column.cs" company="">
//   
// </copyright>
// <summary>
//   The column.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model
{
    #region Using

    using System.ComponentModel;
    using System.Xml.Serialization;

    #endregion

    /// <summary>
    /// The column.
    /// </summary>
    public class Column : INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        /// The render to entity.
        /// </summary>
        private bool renderToEntity = true;

        #endregion

        #region Public Events

        /// <summary>
        /// The property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the column name.
        /// </summary>
        [XmlAttribute("ColumnName")]
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets the column name with key indicator.
        /// </summary>
        public string ColumnNameWithKeyIndicator
        {
            get
            {
                return string.Format("{0} {1}", this.IsPrimaryKey ? "* " : "   ", this.ColumnName);
            }
        }

        /// <summary>
        /// Gets or sets the column order.
        /// </summary>
        [XmlAttribute("ColumnOrder")]
        public int ColumnOrder { get; set; }

        /// <summary>
        /// Gets or sets the c sharp data type.
        /// </summary>
        [XmlAttribute("DataType")]
        public DomainDataType CSharpDataType { get; set; }

        /// <summary>
        /// Gets or sets the db type.
        /// </summary>
        [XmlAttribute("DbType")]
        public string DbType { get; set; }

        /// <summary>
        /// Gets or sets the default field value.
        /// </summary>
        [XmlAttribute("DefaultFieldValue")]
        public string DefaultFieldValue { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [XmlAttribute("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the grid column width.
        /// </summary>
        [XmlAttribute("GridColumnWidth")]
        public int GridColumnWidth { get; set; } = 80;

        /// <summary>
        /// Gets or sets a value indicating whether is primary key.
        /// </summary>
        [XmlAttribute("IsPrimaryKey")]
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is required.
        /// </summary>
        [XmlAttribute("IsRequired")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        [XmlAttribute("Length")]
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets the lookup class name.
        /// </summary>
        [XmlAttribute("LookupClassName")]
        public string LookupClassName { get; set; }

        /// <summary>
        /// Gets or sets the precision.
        /// </summary>
        [XmlAttribute("Precision")]
        public int Precision { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether render to entity.
        /// </summary>
        [XmlAttribute("RenderToEntity")]
        public bool RenderToEntity
        {
            get
            {
                return this.renderToEntity;
            }

            set
            {
                this.renderToEntity = value;
                if (!this.renderToEntity) this.RenderToView = false;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether render to view.
        /// </summary>
        [XmlAttribute("RenderToView")]
        public bool RenderToView { get; set; } = true;

        /// <summary>
        /// Gets or sets the render to view order.
        /// </summary>
        [XmlAttribute("RenderToViewOrder")]
        public int RenderToViewOrder { get; set; }

        /// <summary>
        /// Gets or sets the scale.
        /// </summary>
        [XmlAttribute("Scale")]
        public int Scale { get; set; }

        /// <summary>
        /// Gets or sets the table.
        /// </summary>
        [XmlIgnore]
        public Table Table { get; set; }

        #endregion

        #region Other Properties

        // [XmlIgnore]
        // private string DataTypeString
        // {
        // get
        // {
        // if ((!IsRequired) && (!IsPrimaryKey))
        // {
        // return NullableDataTypeString;
        // }
        // return RemappedCSharpDataType;
        // }
        // }

        /// <summary>
        /// Gets a value indicating whether nullable.
        /// </summary>
        private bool Nullable
        {
            get
            {
                return !this.IsRequired && !this.IsPrimaryKey;
            }
        }

        #endregion

        // }
        // }
        // return RemappedCSharpDataType;
        // default:
        // private GridViewControl _gridViewControlType = GridViewControl.Unknown;
        // break;
        // return string.Format("{0}?", RemappedCSharpDataType);
        // case "GUID":
        // case "DATETIME":
        // case "DOUBLE":
        // case "DECIMAL":
        // case "LONG":
        // case "INT":
        // {
        // switch (RemappedCSharpDataType.ToUpper())
        // {
        // get
        // {
        // }
        // get { return Table == null ? null : Table.TableCollection.Domain; }
        // {
        // public AutomationDomain Domain

        // [XmlIgnore]
        // private string NullableDataTypeString

        // public void RaisePropertyChanged([CallerMemberName]string prop = "")
        // }
        // {
        // if (PropertyChanged != null)
        // PropertyChanged(this, new PropertyChangedEventArgs(prop));
        // }

        // public void RaisePropertyChanged<T>(Expression<Func<T>> prop)
        // {
        // if (PropertyChanged != null)
        // {
        // var member = prop.Body as MemberExpression;
        // if (member == null) return;

        // var propInfo = member.Member as PropertyInfo;
        // if (propInfo == null) return;

        // PropertyChanged(this, new PropertyChangedEventArgs(propInfo.Name));
        // }
        // }

        // private GridViewControl SetControlType(string dataType)
        // {
        // switch (dataType.ToUpper())
        // {
        // case "DATETIME":
        // return GridViewControl.DateTime;
        // break;
        // case "INT":
        // case "DECIMAL":
        // return GridViewControl.Number;
        // break;
        // default:
        // return GridViewControl.TextBox;
        // break;
        // }
        // }
    }
}