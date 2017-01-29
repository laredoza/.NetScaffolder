// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdmxSourceType.cs" company="">
//   
// </copyright>
// <summary>
//   The edmx source type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    /// This datasource uses the default Microsoft edmx file to return the data structure.
    /// </summary>
    [Export(typeof(ISourceType))]
    [ExportMetadata("NameMetaData", "Edmx")]
    [ExportMetadata("ValueMetaData", "3BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class EdmxSourceType : ISourceType
    {
        #region Public methods and operators

        /// <summary>
        /// Import data structure.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Table> Import()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}