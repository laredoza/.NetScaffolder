using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryEFDotnet.Core.Base
{
    public interface IAuditable
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the stamp.
        /// </summary>
        DateTime? Stamp { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        string UserName { get; set; }

        #endregion
    }
}
