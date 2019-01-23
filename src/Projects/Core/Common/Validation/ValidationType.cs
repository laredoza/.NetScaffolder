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
        DomainName = 0,

        /// <summary>
        ///     The domain id.
        /// </summary>
        DomainId = 1,

        /// <summary>
        ///     The project base name space.
        /// </summary>
        ProjectBaseNameSpace = 2,

        /// <summary>
        ///     The project output folder.
        /// </summary>
        ProjectOutputFolder = 3,

        /// <summary>
        ///     The project version.
        /// </summary>
        ProjectVersion = 4,

        /// <summary>
        ///     The project model path.
        /// </summary>
        ProjectModelPath = 5,

        /// <summary>
        ///     The source type id.
        /// </summary>
        SourceTypeId = 6,

        /// <summary>
        ///     The naming convention id.
        /// </summary>
        NamingConventionId = 7,

        /// <summary>
        ///     The driver id.
        /// </summary>
        DriverId = 8,

        /// <summary>
        ///     The driver type id.
        /// </summary>
        DriverTypeId = 9,

        /// <summary>
        ///     The template id.
        /// </summary>
        TemplateId = 10,

        /// <summary>
        ///     The template name.
        /// </summary>
        TemplateName = 11,

        /// <summary>
        ///     The template path.
        /// </summary>
        TemplatePath = 12,

        /// <summary>
        ///     The template version.
        /// </summary>
        TemplateVersion = 13,

        /// <summary>
        ///     The template language output id.
        /// </summary>
        TemplateLanguageOutputId = 14,

        /// <summary>
        ///     The template generator type id.
        /// </summary>
        TemplateGeneratorTypeId = 15,

        /// <summary>
        ///     The collection option id.
        /// </summary>
        CollectionOptionId = 16,

        /// <summary>
        ///     The model error name.
        /// </summary>
        ModelErrorName = 17,

        /// <summary>
        ///     The model field error.
        /// </summary>
        ModelFieldError = 18,

        /// <summary>
        ///     The model field repository.
        /// </summary>
        ModelFieldRepository = 19,

        /// <summary>
        ///     The context missing models.
        /// </summary>
        ContextMissingModels = 20,

        /// <summary>
        ///     The context name is empty.
        /// </summary>
        ContextNameEmpty = 21,

        /// <summary>
        /// The data type language missing.
        /// </summary>
        DataTypeLanguageMissing = 22,

        ContextDuplicateIsDefaultConfig = 23
        ,
        ContextIsDefaultNotSet = 24,

        ApplicationServiceMissingModels = 25,

        ApplicationServiceNameEmpty = 26,

        ApplicationServiceDefaultNotSet = 27,

        ApplicationServiceDuplicateIsDefaultConfig = 28,

        ApplicationServicesMissing = 29,
    }
}