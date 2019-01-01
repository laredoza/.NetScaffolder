// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// <summary>
//   This interface defines a unit of work
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Domain.Core.Interfaces
{
    /// <summary>
    ///     This interface defines a unit of work
    /// </summary>
    /// <summary>
    ///     The UnitOfWork contract for EF implementation
    /// </summary>
    public interface IRepository<TEntity>
        where TEntity : class
    {
    }
}