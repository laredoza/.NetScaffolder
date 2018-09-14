// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextDataError.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes
{
    /// <summary>
    ///     The context data error.
    /// </summary>
    public class ContextDataError
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the context data.
        /// </summary>
        public ContextData ContextData { get; set; }

        /// <summary>
        ///     Gets or sets the table name.
        /// </summary>
        public string TableName { get; set; }

        #endregion
    }
}