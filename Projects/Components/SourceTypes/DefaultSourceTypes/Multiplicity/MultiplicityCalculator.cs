// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MultiplicityCalculator.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes
{
    #region Usings

    using System;

    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Multiplicity;
    using DotNetScaffolder.Mapping.MetaData.Enum;

    #endregion

    /// <summary>
    /// The multiplicity calculator.
    /// </summary>
    public static class MultiplicityCalculator
    {
        #region Public Methods And Operators

        /// <summary>
        /// The calculate.
        /// </summary>
        /// <param name="relationshipType">
        /// The relationship type.
        /// </param>
        /// <param name="columnIsPrimaryKey">
        /// The column is primary key.
        /// </param>
        /// <param name="relatedColumnIsPrimaryKey">
        /// The related column is primary key.
        /// </param>
        /// <param name="columnIsForeignKey">
        /// The column is foreign key.
        /// </param>
        /// <param name="columnIsNullable">
        /// The column is nullable.
        /// </param>
        /// <param name="foreignColumnIsNullable">
        /// The foreign column is nullable.
        /// </param>
        /// <returns>
        /// The <see cref="MultiplicityResult"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        public static MultiplicityResult Calculate(
            RelationshipType relationshipType,
            bool columnIsPrimaryKey,
            bool relatedColumnIsPrimaryKey,
            bool columnIsForeignKey,
            bool columnIsNullable,
            bool foreignColumnIsNullable)
        {
            MultiplicityResult result = new MultiplicityResult();

            if (relationshipType == RelationshipType.ForeignKey)
            {
                if (columnIsPrimaryKey && relatedColumnIsPrimaryKey)
                {
                    // Extending Tables. i.e)  Book --> Product
                    if (columnIsPrimaryKey && columnIsForeignKey)
                    {
                        result.Multiplicity = RelationshipMultiplicity.ZeroToOne;
                        result.ReferencedMultiplicity = RelationshipMultiplicity.One;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else if (!columnIsPrimaryKey && columnIsForeignKey)
                {
                    result.Multiplicity = RelationshipMultiplicity.Many;

                    if (columnIsNullable)
                    {
                        // Zero to Many: 
                        result.ReferencedMultiplicity = RelationshipMultiplicity.ZeroToOne;
                    }
                    else
                    {
                        // 1 to Many
                        result.ReferencedMultiplicity = RelationshipMultiplicity.One;
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (relationshipType == RelationshipType.ForeignKeyChild)
            {
                if (columnIsPrimaryKey && relatedColumnIsPrimaryKey)
                {
                    // Todo: Extending Tables. i.e)  Product --> Book 
                    if (columnIsPrimaryKey && !columnIsForeignKey)
                    {
                        result.Multiplicity = RelationshipMultiplicity.One;
                        result.ReferencedMultiplicity = RelationshipMultiplicity.ZeroToOne;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else if (columnIsPrimaryKey && !columnIsForeignKey)
                {
                    result.ReferencedMultiplicity = RelationshipMultiplicity.Many;

                    if (foreignColumnIsNullable)
                    {
                        // Zero to Many: 
                        result.Multiplicity = RelationshipMultiplicity.ZeroToOne;
                    }
                    else
                    {
                        // 1 to Many
                        result.Multiplicity = RelationshipMultiplicity.One;
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            return result;
        }

        #endregion
    }
}