// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextDataError.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.WebApiServiceDataTypes
{
    /// <summary>
    ///     The context data error.
    /// </summary>
    public class WebApiServiceDataError
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the ApplicationService data.
        /// </summary>
        public ApplicationServiceData ApplicationServiceData { get; set; }

        /// <summary>
        ///     Gets or sets the table name.
        /// </summary>
        public string TableName { get; set; }

        #endregion
    }
}