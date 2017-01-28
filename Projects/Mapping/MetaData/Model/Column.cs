namespace DotNetScaffolder.Mapping.MetaData.Model
{
    using System.ComponentModel;
    using System.Xml.Serialization;

    public class Column : INotifyPropertyChanged
    {

        #region Privates

        private bool _renderToEntity = true;
        private bool _renderToView = true;
        private string _description;
        private int _gridColumnWidth = 80;
        private int _renderToViewOrder;
        // private GridViewControl _gridViewControlType = GridViewControl.Unknown;

        #endregion // Privates

        #region Serializable Properties

        [XmlAttribute("ColumnName")]
        public string ColumnName { get; set; }

        [XmlAttribute("ColumnOrder")]
        public int ColumnOrder { get; set; }

        [XmlAttribute("CSharpDataType")]
        public string CSharpDataType { get; set; }

        [XmlAttribute("DbType")]
        public string DbType { get; set; }

        [XmlAttribute("IsRequired")]
        public bool IsRequired { get; set; }

        [XmlAttribute("Length")]
        public int Length { get; set; }

        [XmlAttribute("IsPrimaryKey")]
        public bool IsPrimaryKey { get; set; }

        [XmlAttribute("Precision")]
        public int Precision { get; set; }

        [XmlAttribute("Scale")]
        public int Scale { get; set; }

        [XmlAttribute("Description")]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        [XmlAttribute("GridColumnWidth")]
        public int GridColumnWidth
        {
            get { return this._gridColumnWidth; }
            set { this._gridColumnWidth = value; }
        }

        [XmlAttribute("DefaultFieldValue")]
        public string DefaultFieldValue { get; set; }

        [XmlAttribute("RenderToEntity")]
        public bool RenderToEntity
        {
            get { return this._renderToEntity; }
            set
            {
                this._renderToEntity = value;
                if (!this._renderToEntity)
                    this._renderToView = false;
            }
        }

        [XmlAttribute("RenderToView")]
        public bool RenderToView
        {
            get { return this._renderToView; }
            set
            {
                this._renderToView = value;
                // RaisePropertyChanged();
            }
        }

        [XmlAttribute("RenderToViewOrder")]
        public int RenderToViewOrder
        {
            get { return this._renderToViewOrder; }
            set { this._renderToViewOrder = value; }
        }

        
        [XmlAttribute("LookupClassName")]
        public string LookupClassName { get; set; }

        #endregion // Serializable Properties

        #region Non-serializable Properties

        public string ColumnNameWithKeyIndicator { get { return string.Format("{0} {1}", this.IsPrimaryKey ? "* " : "   ", this.ColumnName); } }

        #region Relational in class structure

        [XmlIgnore]
        public Table Table { get; set; }

        //[XmlIgnore]
        //public AutomationDomain Domain
        //{
        //    get { return Table == null ? null : Table.TableCollection.Domain; }
        //}

        #endregion // Relational in class structure

        #region Text Transformation

        //[XmlIgnore]
        //private string DataTypeString
        //{
        //    get
        //    {
        //        if ((!IsRequired) && (!IsPrimaryKey))
        //        {
        //            return NullableDataTypeString;
        //        }
        //        return RemappedCSharpDataType;
        //    }
        //}

        private bool Nullable
        {
            get { return (!this.IsRequired) && (!this.IsPrimaryKey); }
        }
        //private string NullableDataTypeString
        //{
        //    get
        //    {
        //        switch (RemappedCSharpDataType.ToUpper())
        //        {
        //            case "INT":
        //            case "LONG":
        //            case "DECIMAL":
        //            case "DOUBLE":
        //            case "DATETIME":
        //            case "GUID":
        //                return string.Format("{0}?", RemappedCSharpDataType);
        //                break;
        //            default:
        //                return RemappedCSharpDataType;
        //        }
        //    }
        //}

        #region Views

        #endregion // Views

        #endregion // Text Transformation

        #region Binding

        #endregion // Binding

        #endregion // Non-serializable Properties

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        //public void RaisePropertyChanged([CallerMemberName]string prop = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //}

        //public void RaisePropertyChanged<T>(Expression<Func<T>> prop)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        var member = prop.Body as MemberExpression;
        //        if (member == null) return;

        //        var propInfo = member.Member as PropertyInfo;
        //        if (propInfo == null) return;

        //        PropertyChanged(this, new PropertyChangedEventArgs(propInfo.Name));
        //    }
        //}

        #endregion // INotifyPropertyChanged Members

        #region Helpers

        //private GridViewControl SetControlType(string dataType)
        //{
        //    switch (dataType.ToUpper())
        //    {
        //        case "DATETIME":
        //            return GridViewControl.DateTime;
        //            break;
        //        case "INT":
        //        case "DECIMAL":
        //            return GridViewControl.Number;
        //            break;
        //        default:
        //            return GridViewControl.TextBox;
        //            break;
        //    }
        //}

        #endregion // Helpers

    }
}
