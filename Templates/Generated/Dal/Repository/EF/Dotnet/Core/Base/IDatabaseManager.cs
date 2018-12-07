// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDatabaseManager.cs" company="">
//   
// </copyright>
// <summary>
//   The DatabaseManager interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using StructureMap;

namespace RepositoryEFDotnet.Core.Base
{
    /// <summary>
    /// The DatabaseManager interface.
    /// </summary>
    public interface IDatabaseManager
    {
        #region Public Methods And Operators

        void RegisterUnitOfWork(IDataConfiguration configuration, IContainer container, IServiceProvider serviceProvider = null);

        #endregion
    }
}