// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Common.Validation
{
    /// <summary>
    ///     The validation type.
    /// </summary>
    public enum ValidationType
    {
        /// <summary>
        ///     The domain name.
        /// </summary>
        DomainName,

        /// <summary>
        ///     The domain id.
        /// </summary>
        DomainId,

        /// <summary>
        ///     The project base name space.
        /// </summary>
        ProjectBaseNameSpace,

        /// <summary>
        ///     The project output folder.
        /// </summary>
        ProjectOutputFolder,

        /// <summary>
        ///     The project version.
        /// </summary>
        ProjectVersion,

        /// <summary>
        ///     The project model path.
        /// </summary>
        ProjectModelPath,

        /// <summary>
        ///     The source type id.
        /// </summary>
        SourceTypeId,

        /// <summary>
        ///     The naming convention id.
        /// </summary>
        NamingConventionId,

        /// <summary>
        ///     The driver id.
        /// </summary>
        DriverId,

        /// <summary>
        ///     The driver type id.
        /// </summary>
        DriverTypeId,

        /// <summary>
        ///     The template id.
        /// </summary>
        TemplateId,

        /// <summary>
        ///     The template name.
        /// </summary>
        TemplateName,

        /// <summary>
        ///     The template path.
        /// </summary>
        TemplatePath,

        /// <summary>
        ///     The template version.
        /// </summary>
        TemplateVersion,

        /// <summary>
        ///     The template language output id.
        /// </summary>
        TemplateLanguageOutputId,

        /// <summary>
        ///     The template generator type id.
        /// </summary>
        TemplateGeneratorTypeId,

        /// <summary>
        ///     The collection option id.
        /// </summary>
        CollectionOptionId,

        /// <summary>
        ///     The model error name.
        /// </summary>
        ModelErrorName,

        /// <summary>
        ///     The model field error.
        /// </summary>
        ModelFieldError,

        /// <summary>
        ///     The model field repository.
        /// </summary>
        ModelFieldRepository,

        /// <summary>
        ///     The context missing models.
        /// </summary>
        ContextMissingModels,

        /// <summary>
        /// The context name is empty.
        /// </summary>
        ContextNameEmpty
    }
}