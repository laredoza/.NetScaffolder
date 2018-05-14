// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OracleAdoSourceType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.Oracle
{
    #region Usings

    using System;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Windows.Forms;

    using DatabaseSchemaReader.DataSchema;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using global::Common.Logging;

    using global::Oracle.ManagedDataAccess.Client;

    // using System.Data.OracleClient
    #endregion

    /// <summary>
    ///     The generic ado source type.
    /// </summary>
    [Export(typeof(ISourceType))]
    [ExportMetadata("NameMetaData", "Oracle ADO.NET")]
    [ExportMetadata("ValueMetaData", "4BC1B0C4-1E41-9146-82CF-699181CE4410")]
    public class OracleAdoSourceType : AdoSource
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// Returns the .NET type of the column.
        /// </summary>
        /// <param name="column">
        /// The column.
        /// </param>
        /// <returns>
        /// The .NET type of the column
        /// </returns>
        /// <remarks>
        /// For numeric Db data types uses column.Precision and column.Scale to determine the correct .NET data type.
        /// </remarks>
        public static Type NetDataType(DatabaseColumn column)
        {
            if (column == null) return null;
            if (column.DataType == null) return null;

            if (!column.DataType.IsNumeric || column.DataType.IsInt) return column.DataType.GetNetType();
            var precision = column.Precision.GetValueOrDefault();
            var scale = column.Scale.GetValueOrDefault();
            return NetTypeForIntegers(column, scale, precision);
        }

        /// <summary>
        /// The add config ui.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public override object AddConfigUI(object parameters)
        {
            Logger.Trace("Started AddConfigUI()");

            Control parent = parameters as Control;
            OracleAdoUserControl newControl = new OracleAdoUserControl { Visible = true, Dock = DockStyle.Fill };
            newControl.BringToFront();
            parent.Controls.Add(newControl);

            Logger.Trace("Completed AddConfigUI()");
            return newControl;
        }

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public override object Load(object parameters)
        {
            Logger.Trace("Started Import()");

            string path = this.ReturnFilePath(parameters as string);
            Logger.Debug($"Path: {path}");
            AdoSourceOptions result = null;

            if (File.Exists(path))
            {
                Logger.Trace("Path Exists");
                result = ObjectXMLSerializer<AdoSourceOptions>.Load(path);
            }
            else
            {
                Logger.Trace("Path Doesn't Exist");
                result = new AdoSourceOptions
                             {
                                 ProviderName = "Oracle.ManagedDataAccess.Client",
                                 ConnectionString =
                                     @"DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;USER ID=test;PASSWORD=Test"
                             };
            }

            Logger.Trace("Completed Import()");

            return result;
        }

        /// <summary>
        /// Map database type to c# type.
        /// </summary>
        /// <param name="databaseType">
        /// The database type.
        /// </param>
        /// <param name="extraInfo">
        /// </param>
        /// <returns>
        /// The <see cref="DomainDataType"/>.
        /// </returns>
        public override DomainDataType MapDatabaseType(string databaseType, object extraInfo)
        {
            DatabaseColumn column = extraInfo as DatabaseColumn;
           

            string cSharpName = string.Empty;

            if (column.DbDataType != "BINARY_FLOAT")
            {
                Type cSharpNameType = NetDataType(column);

                if (cSharpNameType != null)
                {
                    cSharpName = cSharpNameType.Name.ToUpper();
                }
            }
            else
            {
                cSharpName = "SINGLE";
            }

            switch (cSharpName)
            {
                case "DECIMAL":
                    return DomainDataType.Decimal;
                case "STRING":
                    return DomainDataType.String;
                case "DATETIME":
                    return DomainDataType.DateTime;
                case "SYSTEM.BYTE[]":
                    return DomainDataType.VarBinary;
                case "INT16":
                    return DomainDataType.Int16;
                case "INT32":
                    return DomainDataType.Int32;
                case "BYTE[]":
                    return DomainDataType.VarBinary;
                case "INT64":
                    return DomainDataType.Int64;
                case "SINGLE":
                    column.Precision = 12;
                    return DomainDataType.Single;
                case "":
                    return DomainDataType.Unsupported;
                case "BOOLEAN":
                    return DomainDataType.Boolean;
                default:
                    throw new NotImplementedException($"Invalid data type {databaseType}");
            }
        }

        /// <summary>
        /// The return file path.
        /// </summary>
        /// <param name="basePath">
        /// The base path.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ReturnFilePath(string basePath)
        {
            Logger.Trace($"Started ReturnFilePath({basePath}");
            Logger.Trace($"Completed ReturnFilePath({basePath}");
            return basePath + @"\OracleAdoSourceType.xml";
        }

        /// <summary>
        /// The test.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public override bool Test(object parameters)
        {
            Logger.Trace("Started Test()");
            bool result = false;

            AdoSourceOptions adoOptions = parameters as AdoSourceOptions;
            using (OracleConnection connection = new OracleConnection(adoOptions.ConnectionString))
            {
                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();

                    result = true;
                }
                catch (Exception ex)
                {
                    Logger.Error($"Unable to connect to database:{ex.Message}");
                }
            }

            Logger.Trace("Complete Test()");

            return result;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The net type for integers.
        /// </summary>
        /// <param name="column">
        /// The column.
        /// </param>
        /// <param name="scale">
        /// The scale.
        /// </param>
        /// <param name="precision">
        /// The precision.
        /// </param>
        /// <returns>
        /// The <see cref="Type"/>.
        /// </returns>
        private static Type NetTypeForIntegers(DatabaseColumn column, int scale, int precision)
        {
            if (scale != 0 || precision >= 19) return column.DataType.GetNetType();

            // could be a short, int or long...
            // VARCHAR2(10) is common for Oracle integers, but it can overflow an int
            // int.MaxValue is 2147483647 so +1 is allowable in the database
            if (precision > 10)
            {
                // up to long.MaxValue
                return typeof(long);
            }

            if (precision > 5)
            {
                // 2147483647
                return typeof(int);
            }

            if (precision > 1)
            {
                return typeof(short);
            }

            if (precision == 1)
            {
                return typeof(bool);
            }

            return column.DataType.GetNetType();
        }

        #endregion
    }
}