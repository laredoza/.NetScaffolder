// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IConfigurationApplicationService.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices
{
    #region Usings

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Application;

    #endregion

    /// <summary>
    /// The ConfigurationApplicationService interface.
    /// </summary>
    public interface IConfigurationApplicationService : IValidate
    {
        #region Properties

        /// <summary>
        /// Gets or sets the application settings.
        /// </summary>
        ApplicationSettings ApplicationSettings { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     Load ProjectDefinition.
        /// </summary>
        void Load();

        /// <summary>
        ///     Save ProjectDefinition.
        /// </summary>
        void Save();

        #endregion
    }
}