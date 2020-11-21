// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataTypeGenerator.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using DotNetScaffolder.Mapping.MetaData.Domain;

namespace DotNetScaffolder.Components.Common.Contract
{
    /// <summary>
    ///     The OutputGenerator interface.
    /// </summary>
    public interface IDataTypeGenerator
    {
        void Run(IDataType dataType, DomainDefinition domain);
        bool UsedForDataType(IDataType dataType);
    }
}