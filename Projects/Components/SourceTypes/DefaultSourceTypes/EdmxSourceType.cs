// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdmxSourceType.cs" company="">
//   
// </copyright>
// <summary>
//   The edmx source type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contractors.SourceTypes.DefaultSourceTypes
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using Components.Common.Contract;

    using MetaData.Model;

    #endregion

    /// <summary>
    /// This datasource uses the default Microsoft edmx file to return the data structure.
    /// </summary>
    [Export(typeof(ISourceType))]
    [ExportMetadata("NameMetaData", "Edmx")]
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