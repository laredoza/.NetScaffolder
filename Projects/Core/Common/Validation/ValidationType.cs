// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationType.cs" company="">
//   
// </copyright>
// <summary>
//   The validation type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Common.Validation
{
    /// <summary>
    /// The validation type.
    /// </summary>
    public enum ValidationType
    {
        /// <summary>
        /// The domain name.
        /// </summary>
        DomainName,

        /// <summary>
        /// The domain id.
        /// </summary>
        DomainId,

        /// <summary>
        /// The project base name space.
        /// </summary>
        ProjectBaseNameSpace,

        /// <summary>
        /// The project output folder.
        /// </summary>
        ProjectOutputFolder,

        /// <summary>
        /// The project version.
        /// </summary>
        ProjectVersion,

        /// <summary>
        /// The project model path.
        /// </summary>
        ProjectModelPath,

        SourceTypeId,

        NamingConventionId,

        DriverId,

        DriverTypeId,

        TemplateId,

        TemplateName,

        TemplatePath,

        TemplateVersion,

        TemplateLanguageOutputId,

        TemplateGeneratorTypeId,

        CollectionOptionId
    }
}