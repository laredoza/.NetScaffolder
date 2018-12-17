// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextDataError.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes
{
    /// <summary>
    ///     The context data error.
    /// </summary>
    public class ApplicationServiceDataError
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the context data.
        /// </summary>
        public ApplicationServiceData ApplicationServiceData { get; set; }

        /// <summary>
        ///     Gets or sets the table name.
        /// </summary>
        public string TableName { get; set; }

        #endregion
    }
}