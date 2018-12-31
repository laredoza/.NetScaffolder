// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationValidation.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// <summary>
//   Defines the GenerationValidation type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Domain.Core
{
    /// <summary>
    /// The generation validation.
    /// </summary>
    public class GenerationValidation
    {
        #region Other Methods

        /// <summary>
        /// The invalid precision.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private bool InvalidPrecision(object type)
        {
            if (type is short || type is int) return true;

            return false;
        }

        #endregion
    }
}