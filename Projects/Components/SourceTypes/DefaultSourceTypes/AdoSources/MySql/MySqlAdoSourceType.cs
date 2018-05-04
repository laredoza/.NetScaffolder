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
            switch (databaseType.ToUpper())
            {
                case "SMALLINT":
                    return DomainDataType.Int16;
                case "INT":
                    return DomainDataType.Int32;
                case "BIT":
                    return DomainDataType.Boolean;
                case "NVARCHAR":
                    return DomainDataType.String;
                case "MONEY":
                    return DomainDataType.Decimal;
                case "NUMERIC":
                    return DomainDataType.Decimal;
                case "DATETIME":
                    return DomainDataType.DateTime;
                case "IMAGE":
                    // Todo: Do something valid with this
                    return DomainDataType.String;
                case "REAL":
                    // Todo: Do something valid with this
                    return DomainDataType.Single;
                default:
                    throw new NotImplementedException($"Invalid data type {databaseType}");
            }
        }

        /// <summary>
        /// The map domain data type to output type.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public override string MapDomainDataTypeToOutputType(DomainDataType type)
        {
            Logger.Trace("Started MapDomainDataTypeToOutputType()");

            switch (type)
            {
                case DomainDataType.Int16:
                    return "short";
                case DomainDataType.Int32:
                    return "int";
                case DomainDataType.Int64:
                    return "long";
                case DomainDataType.Boolean:
                    return "bool";
                case DomainDataType.Short:
                    return "byte";
                case DomainDataType.String:
                    return "string";
                case DomainDataType.Decimal:
                    return "decimal";
                case DomainDataType.DateTime:
                    return "DateTime";
                case DomainDataType.Single:
                    return "float";

                // case case DomainDataType.Int16:
                // // Todo: Do something valid with this
                // return DomainDataType.String;
                default:
                    throw new NotImplementedException($"Invalid data type {type}");
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

        #endregion
    }
}