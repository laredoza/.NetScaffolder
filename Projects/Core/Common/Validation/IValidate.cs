// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IValidate.cs" company="">
//   
// </copyright>
// <summary>
//   The Validate interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Common.Validation
{
    #region Using

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The Validate interface.
    /// </summary>
    public interface IValidate
    {
        #region Properties
        
        List<Validation> ValidationResult { get; set; }
        #endregion

        #region Public methods and operators

        /// <summary>
        ///     Validate class.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />
        ///     Errors returned
        /// </returns>
        List<Validation> Validate();

        #endregion
    }
}