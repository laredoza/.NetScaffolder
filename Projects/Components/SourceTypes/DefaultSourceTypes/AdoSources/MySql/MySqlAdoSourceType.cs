// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MySqlAdoSourceType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.MySql
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using DatabaseSchemaReader;
    using DatabaseSchemaReader.DataSchema;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using global::Common.Logging;

    using global::MySql.Data.MySqlClient;

    #endregion

    /// <summary>
    ///     The generic ado source type.
    /// </summary>
    [Export(typeof(ISourceType))]
    [ExportMetadata("NameMetaData", "MySql ADO.NET")]
    [ExportMetadata("ValueMetaData", "4BC1B0C4-1E41-9146-82CF-799181CE4410")]
    public class MySqlAdoSourceType : AdoSource
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Public Methods And Operators

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
            MySqlAdoUserControl newControl = new MySqlAdoUserControl { Visible = true, Dock = DockStyle.Fill };
            newControl.BringToFront();
            parent.Controls.Add(newControl);

            Logger.Trace("Completed AddConfigUI()");
            return newControl;
        }

        /// <summary>
        /// Map database type to c# type.
        /// </summary>
        /// <param name="databaseType">
        ///     The database type.
        /// </param>
        /// <param name="extraInfo"></param>
        /// <returns>
        /// The <see cref="DomainDataType"/>.
        /// </returns>
        public override DomainDataType MapDatabaseType(string databaseType, object extraInfo)
        {
            DatabaseColumn column = extraInfo as DatabaseColumn;
            string cSharpName = string.Empty;

            if (column.DataType != null)
            {
                cSharpName = databaseType.ToUpper();
            }

            switch (cSharpName)
            {
                case "VARCHAR":
                case "LONGTEXT":
                case "TEXT":
                case "ENUM":
                case "SET":
                case "CHAR":
                    return DomainDataType.String;
                case "TIMESTAMP":
                case "DATE":
                    return DomainDataType.DateTime;
                case "INT":
                case "YEAR":
                case "MEDIUMINT":
                    return DomainDataType.Int32;
                case "DECIMAL":
                    return DomainDataType.Decimal;
                case "TINYINT":
                    return DomainDataType.SByte;
                case "SMALLINT":
                    return DomainDataType.Int16;
                case "FLOAT":
                    return DomainDataType.Single;
                case "LONGBLOB":
                case "BLOB":
                    return DomainDataType.VarBinary;
                case "":
                    return DomainDataType.Unsupported;
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
            return basePath + @"\MySqlAdoSourceType.xml";
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
            using (MySqlConnection connection =
                new MySqlConnection(adoOptions.ConnectionString))
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

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
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
                                 ProviderName = "MySql.Data.MySqlClient",
                                 ConnectionString =
                                     @"server=localhost;userid=test;password=password;database=test;SslMode=none"
                };
            }

            Logger.Trace("Completed Import()");

            return result;
        }

        #endregion
    }
}