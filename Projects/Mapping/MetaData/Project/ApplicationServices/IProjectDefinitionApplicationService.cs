﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProjectDefinitionPersistance.cs" company="">
//   
// </copyright>
// <summary>
//   The ProjectDefinitionPersistance interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project.ApplicationServices
{
    using System;

    using DotNetScaffolder.Mapping.MetaData.Domain;
    using Core.Common.Validation;
    /// <summary>
    /// The ProjectDefinitionApplicationService interface.
    /// This interface is used to load and save project data.
    /// </summary>
    public interface IProjectDefinitionApplicationService : IValidate
    {
        /// <summary>
        /// Gets or sets the project definition.
        /// </summary>
        ProjectDefinition ProjectDefinition { get; set; }

        #region Public methods and operators

        /// <summary>
        /// Load ProjectDefinition.
        /// </summary>
        void Load();

        /// <summary>
        /// Save ProjectDefinition.
        /// </summary>
        void Save();

        /// <summary>
        /// The add domain.
        /// </summary>
        /// <returns>
        /// The <see cref="DomainDefinition"/>.
        /// </returns>
        DomainDefinition AddDomain();

        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        void Delete(Guid id);

        #endregion
    }
}