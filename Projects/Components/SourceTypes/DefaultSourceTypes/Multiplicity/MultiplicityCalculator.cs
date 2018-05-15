using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes
{
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Multiplicity;
    using DotNetScaffolder.Mapping.MetaData.Enum;

    public static class MultiplicityCalculator
    {
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
    }
}
