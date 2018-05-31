// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqlServerNHibernateContext.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Banking.Models.Context.NHibernate
{

    using global::NHibernate;

    /// <summary>
    /// The sql server n hibernate context.
    /// </summary>
    public class SqlServerNHibernateContext : BaseContext
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerNHibernateContext"/> class.
        /// </summary>
        /// <param name="session">
        /// The session.
        /// </param>
        public SqlServerNHibernateContext(ISession session) : base(session)
        {

        }

        #endregion
    }
}