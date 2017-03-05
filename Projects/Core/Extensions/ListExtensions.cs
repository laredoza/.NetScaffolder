// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   The list extensions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Extensions
{
    #region Using

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// The list extensions.
    /// </summary>
    public static class ListExtensions
    {
        #region Other Methods

        /// <summary>
        /// Move item.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <param name="oldIndex">
        /// The old index.
        /// </param>
        /// <param name="newIndex">
        /// The new index.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        public static void MoveItem<T>(this List<T> list, int oldIndex, int newIndex)
        {
            T item = list[oldIndex];
            list.RemoveAt(oldIndex);
            list.Insert(newIndex, item);
        }

        #endregion
    }
}