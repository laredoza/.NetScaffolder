// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationServiceDataError.cs" company="DotnetScaffolder">
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
        /// Gets or sets the application service data.
        /// </summary>
        public ApplicationServiceData ApplicationServiceData { get; set; }

        /// <summary>
        /// Gets or sets the application service name.
        /// </summary>
        public string ApplicationServiceName { get; set; }

        #endregion
    }
}