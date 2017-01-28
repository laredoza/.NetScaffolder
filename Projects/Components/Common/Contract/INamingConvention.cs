// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INamingConvention.cs" company="">
//   
// </copyright>
// <summary>
//   The NamingConvention interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Components.Common.Contract
{
    /// <summary>
    /// The NamingConvention interface. This is used to apply a namimg convention 
    /// to a property, class, etc. 
    /// <example>securityview will be SecurityView</example>
    /// </summary>
    public interface INamingConvention
    {
        #region Public methods and operators

        /// <summary>
        /// Apply the naming convention.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string ApplyNamingConvention(string value);

        #endregion
    }
}