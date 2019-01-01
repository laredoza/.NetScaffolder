using System;

namespace DotNetScaffolder.Domain.Core.Interfaces
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
