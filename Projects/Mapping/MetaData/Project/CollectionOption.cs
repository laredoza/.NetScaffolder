// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollectionOption.cs" company="">
//   
// </copyright>
// <summary>
//   The collection option.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project
{
    #region Using

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// Collection options.
    /// The selected collection will be used as the parent for any generated collections
    /// </summary>
    [Serializable]
    public class CollectionOption
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name space.
        /// </summary>
        public string NameSpace { get; set; }

        #endregion
    }
}