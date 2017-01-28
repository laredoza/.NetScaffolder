using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MetaData.Model
{
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
            get { return _description; }
            set { _description = value; }
        }

        [XmlAttribute("GridColumnWidth")]
        public int GridColumnWidth
        {
            get { return _gridColumnWidth; }
            set { _gridColumnWidth = value; }
        }

        [XmlAttribute("DefaultFieldValue")]
        public string DefaultFieldValue { get; set; }

        [XmlAttribute("RenderToEntity")]
        public bool RenderToEntity
        {
            get { return _renderToEntity; }
            set
            {
                _renderToEntity = value;
                if (!_renderToEntity)
                    _renderToView = false;
            }
        }

        [XmlAttribute("RenderToView")]
        public bool RenderToView
        {
            get { return _renderToView; }
            set
            {
                _renderToView = value;
                // RaisePropertyChanged();
            }
        }

        [XmlAttribute("RenderToViewOrder")]
        public int RenderToViewOrder
        {
            get { return _renderToViewOrder; }
            set { _renderToViewOrder = value; }
        }

        
        [XmlAttribute("LookupClassName")]
        public string LookupClassName { get; set; }

        #endregion // Serializable Properties

        #region Non-serializable Properties

        public string ColumnNameWithKeyIndicator { get { return string.Format("{0} {1}", IsPrimaryKey ? "* " : "   ", ColumnName); } }

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
            get { return (!IsRequired) && (!IsPrimaryKey); }
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
