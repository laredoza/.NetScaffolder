// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiServiceDataError.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.WebApiServiceDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;

    #endregion

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