using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Type;
using RepositoryEFDotnet.Core.Base;

namespace RepositoryEFDotnet.Contexts.NHib.Base
{
    /// <summary>
    /// The audit interceptor.
    /// </summary>
    public class AuditInterceptor : EmptyInterceptor
    {
        #region Public Methods And Operators

        /// <summary>
        /// The on flush dirty.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="currentState">
        /// The current state.
        /// </param>
        /// <param name="previousState">
        /// The previous state.
        /// </param>
        /// <param name="propertyNames">
        /// The property names.
        /// </param>
        /// <param name="types">
        /// The types.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool OnFlushDirty(
            object entity,
            object id,
            object[] currentState,
            object[] previousState,
            string[] propertyNames,
            IType[] types)
        {
            if (entity is IAuditable auditable)
            {
                auditable.Stamp = DateTime.Now;

                // TODO: auditable.UserName = Auditing.GetCurrentUserName();
                this.SetProperty(currentState, propertyNames, "Stamp", auditable.Stamp);
                this.SetProperty(currentState, propertyNames, "UserName", auditable.UserName);
                return true;
            }

            return false;
        }

        /// <summary>
        /// The on save.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <param name="propertyNames">
        /// The property names.
        /// </param>
        /// <param name="types">
        /// The types.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool OnSave(
            object entity,
            object id,
            object[] state,
            string[] propertyNames,
            IType[] types)
        {
            if (entity is IAuditable auditable)
            {
                auditable.Stamp = DateTime.Now;

                // TODO: auditable.UserName = Auditing.GetCurrentUserName();
                if (string.IsNullOrEmpty(auditable.UserName))
                    auditable.UserName = "Anonymous";
                this.SetProperty(state, propertyNames, "Stamp", auditable.Stamp);
                this.SetProperty(state, propertyNames, "UserName", auditable.UserName);

                return true;
            }

            return false;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The set property.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <param name="propertyNames">
        /// The property names.
        /// </param>
        /// <param name="property">
        /// The property.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        private void SetProperty(object[] state, string[] propertyNames, string property, object value)
        {
            var idx = Array.IndexOf(propertyNames, property);
            if (idx >= 0) state[idx] = value;
        }

        #endregion
    }
}
