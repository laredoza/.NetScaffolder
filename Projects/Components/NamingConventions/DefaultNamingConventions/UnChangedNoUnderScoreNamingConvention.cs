namespace DotNetScaffolder.Components.NamingConventions.DefaultNamingConventions
{
    #region Usings

    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     The title case naming convention.
    /// </summary>
    /// <example>securityview will be SecurityView</example>
    [Export(typeof(INamingConvention))]
    [ExportMetadata("NameMetaData", "UnChangedNoUnderScore")]
    [ExportMetadata("ValueMetaData", "1408695A-273C-4C5D-A904-1EC2EDCEF377")]
    public class UnChangedNoUnderScoreNamingConvention : INamingConvention
    {
        #region Public Methods And Operators

        public string ApplyNamingConvention(string value)
        {
            return value.Replace("_", string.Empty);
        }

        #endregion
    }
}