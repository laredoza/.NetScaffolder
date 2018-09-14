// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Validation.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Common.Validation
{
    /// <summary>
    ///     The validation.
    /// </summary>
    public class Validation
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Validation"/> class.
        /// </summary>
        /// <param name="validationType">
        /// The validation type.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        public Validation(ValidationType validationType, string description)
        {
            this.ValidationType = validationType;
            this.Description = description;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the validation type.
        /// </summary>
        public ValidationType ValidationType { get; set; }

        #endregion
    }
}