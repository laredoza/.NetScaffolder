﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProjectDefinitionApplicationService.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices
{
    #region Usings

    using System;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Project;

    #endregion

    /// <summary>
    ///     The ProjectDefinitionApplicationService interface.
    ///     This interface is used to load and save project data.
    /// </summary>
    public interface IProjectDefinitionApplicationService : IValidate
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the project definition.
        /// </summary>
        ProjectDefinition ProjectDefinition { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The add domain.
        /// </summary>
        /// <returns>
        ///     The <see cref="DomainDefinition" />.
        /// </returns>
        DomainDefinition AddDomain();

        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        void Delete(Guid id);

        void Load(string dllPath = "");

        /// <summary>
        ///     Save ProjectDefinition.
        /// </summary>
        void Save();

        #endregion
    }
}