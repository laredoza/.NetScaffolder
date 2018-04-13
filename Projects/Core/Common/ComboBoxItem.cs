// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComboBoxItem.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Common
{
    /// <summary>
    ///     The combobox item.
    /// </summary>
    public class ComboboxItem
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        public object Value { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return Text;
        }

        #endregion
    }
}