// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CSharpOutputMapper.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common
{
    #region Usings

    using System;

    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    /// The c sharp output mapper.
    /// </summary>
    public static class CSharpOutputMapper
    {
        #region Public Methods And Operators

        /// <summary>
        /// The map to output.
        /// </summary>
        /// <param name="col">
        /// The col.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public static string MapToOutput(Column col)
        {
            string nullableFormat = "Nullable<{0}>";

            switch (col.DomainDataType)
            {
                case DomainDataType.Int16:
                    return col.IsRequired ? "short" : string.Format(nullableFormat, "short");
                case DomainDataType.Int32:
                    return col.IsRequired ? "int" : string.Format(nullableFormat, "int");
                case DomainDataType.Int64:
                    return col.IsRequired ? "long" : string.Format(nullableFormat, "long");
                case DomainDataType.Boolean:
                    return col.IsRequired ? "bool" : string.Format(nullableFormat, "bool");
                case DomainDataType.Short:
                    return col.IsRequired ? "byte" : string.Format(nullableFormat, "byte");
                case DomainDataType.String:
                    return "string";
                case DomainDataType.Decimal:
                    return col.IsRequired ? "decimal" : string.Format(nullableFormat, "decimal");
                case DomainDataType.DateTime:
                    return col.IsRequired ? "DateTime" : string.Format(nullableFormat, "DateTime");
                case DomainDataType.Single:
                    return col.IsRequired ? "float" : string.Format(nullableFormat, "float");
                case DomainDataType.Guid:
                    return col.IsRequired ? "Guid" : string.Format(nullableFormat, "Guid");
                case DomainDataType.VarBinary:
                    return "byte[]";
                case DomainDataType.Date:
                    return col.IsRequired ? "DateTime" : string.Format(nullableFormat, "DateTime");
                case DomainDataType.Time:
                    return col.IsRequired ? "DateTime" : string.Format(nullableFormat, "DateTime");
                default:
                    throw new NotImplementedException($"Invalid data type {col.DomainDataType}");
            }
        }

        #endregion
    }
}