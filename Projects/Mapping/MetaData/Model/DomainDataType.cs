// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    ///     The domain data type.
    /// </summary>
    [Serializable]
    public enum DomainDataType
    {
        /// <summary>
        ///     The int 16.
        /// </summary>
        Int16,

        /// <summary>
        ///     The int 32.
        /// </summary>
        Int32,

        /// <summary>
        ///     The int 64.
        /// </summary>
        Int64,

        /// <summary>
        ///     The boolean.
        /// </summary>
        Boolean,

        /// <summary>
        ///     The string.
        /// </summary>
        String,

        /// <summary>
        ///     The short.
        /// </summary>
        Short,

        /// <summary>
        ///     The decimal.
        /// </summary>
        Decimal,

        /// <summary>
        ///     The date time.
        /// </summary>
        DateTime,

        /// <summary>
        ///     The single.
        /// </summary>
        Single,

        /// <summary>
        /// The guid.
        /// </summary>
        Guid,

        /// <summary>
        /// The var binary.
        /// </summary>
        VarBinary,

        /// <summary>
        /// The date.
        /// </summary>
        Date,

        /// <summary>
        /// The time.
        /// </summary>
        Time
    }
}