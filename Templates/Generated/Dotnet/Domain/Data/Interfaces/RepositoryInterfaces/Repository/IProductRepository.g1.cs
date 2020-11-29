// <copyright file="Product" company="MIT">
//  Copyright (c) 2020 MIT
// </copyright>  

// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
// IN THE SOFTWARE.


// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces
{
	/// <summary>
	/// The <#= DataType.RepoName #>Repository interface that defines database functions for the <#= DataType.ModelName #> table
	/// </summary>
	public partial interface I<#= DataType.RepoName #>Repository : IRepository<I<#= DataType.RepoName #>>
	{
		#region Load
<#+ if(DataType.MetaData.PrimaryKeyCount > 1){ #>

        /// <summary>
        /// Load <#= DataType.ModelName #> entities from the database using the composite primary keys
        /// </summary
<#+ foreach(var col in DataType.MetaData.Columns.Where(o => o.IsPrimaryKey)) {#>
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param>
<#+ } #>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns>I<#= DataType.ModelName #></returns>
		I<#= DataType.ModelName #> Load(<#= DataType.TransformAsParameter(DataType.MetaData.Columns.Where(o => o.IsPrimaryKey)) #>, bool cache, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
		
        /// <summary>
        /// Load <#= DataType.ModelName #> entities async from the database using the composite primary keys
        /// </summary
<#+ foreach(var col in DataType.MetaData.Columns.Where(o => o.IsPrimaryKey)) {#>
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param>
<#+ } #>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns>I<#= DataType.ModelName #></returns>
		Task<I<#= DataType.ModelName #>> LoadAsync(<#= DataType.TransformAsParameter(DataType.MetaData.Columns.Where(o => o.IsPrimaryKey)) #>, bool cache, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
<#+ } #>

<#+ if(DataType.MetaData.PrimaryKeyCount == 1){ var col = DataType.MetaData.Columns.First(o => o.IsPrimaryKey);#>

        /// <summary>
        /// Load <#= DataType.ModelName #> entities from the database using the composite primary keys
        /// </summary
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns>I<#= DataType.ModelName #></returns>
		I<#= DataType.ModelName #> LoadBy<#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #>(<#= DataType.TransformAsParameter(col) #>, bool cache, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
		
        /// <summary>
        /// Load <#= DataType.ModelName #> entities async from the database using the composite primary keys
        /// </summary
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns>I<#= DataType.ModelName #></returns>
		Task<I<#= DataType.ModelName #>> LoadBy<#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #>Async(<#= DataType.TransformAsParameter(col) #>, bool cache, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
<#+ } #>

<#+ foreach(var col in DataType.MetaData.Columns.Where(o => !o.IsPrimaryKey && o.DomainDataType != DomainDataType.String)){ #>

        /// <summary>
        /// Load <#= DataType.ModelName #> entities from the database using the <#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #> field
        /// </summary>
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns><#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>></returns>
		<#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>> LoadBy<#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #>(<#= DataType.TransformAsParameter(col) #>, bool cache,  params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
		
        /// <summary>
        /// Load <#= DataType.ModelName #> entities async from the database using the <#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #> field
        /// </summary>
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns><#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>></returns>
		Task<<#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>>> LoadBy<#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #>Async(<#= DataType.TransformAsParameter(col) #>, bool cache, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
<#+ }  #>

        /// <summary>
        /// Load all <#= DataType.ModelName #> entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns><#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>></returns>
		<#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>> LoadAll( bool cache, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
		
        /// <summary>
        /// Load all <#= DataType.ModelName #> entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns><#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>></returns>
		Task<<#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>>> LoadAllAsync(bool cache, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
		
		#endregion

		#region Search
<#+ foreach(var col in DataType.MetaData.Columns.Where(o => !o.IsPrimaryKey && o.DomainDataType == DomainDataType.String)){ #>

        /// <summary>
        /// Search for <#= DataType.ModelName #> entities in the database by <#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #>
        /// </summary>
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns><#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>></returns>
		<#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>> SearchBy<#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #>(<#= DataType.TransformAsParameter(col) #>, bool cache, bool caseSensitive = false, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
		
        /// <summary>
        /// Search for <#= DataType.ModelName #> entities async in the database by <#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #>
        /// </summary>
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<I<#= DataType.RepoName #>, object>>[]</param>
        /// <returns><#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>></returns>
		Task<<#= DataType.CollectionOption.ClassNameInterface #><I<#= DataType.ModelName #>>> SearchBy<#= DataType.NamingConvention.ApplyNamingConvention(col.ColumnName) #>Async(<#= DataType.TransformAsParameter(col) #>, bool cache, bool caseSensitive = false, params Expression<Func<I<#= DataType.RepoName #>, object>>[] includes);
<#+ }  #>

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the <#= DataType.ModelName #> entity to the database.
        /// </summary>
        /// <param name="entity">I<#= DataType.ModelName #></param>
        /// <returns>bool</returns>
		bool Add(I<#= DataType.ModelName #> entity);
		
        /// <summary>
        /// Add the <#= DataType.ModelName #> entity async to the database.
        /// </summary>
        /// <param name="entity">I<#= DataType.ModelName #></param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(I<#= DataType.ModelName #> entity);

        /// <summary>
        /// Update the <#= DataType.ModelName #> entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">I<#= DataType.ModelName #></param>
        /// <returns>bool</returns>
		bool Update(I<#= DataType.ModelName #> entity);
		
        /// <summary>
        /// Update the <#= DataType.ModelName #> entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">I<#= DataType.ModelName #></param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(I<#= DataType.ModelName #> entity);
		
        /// <summary>
        /// Delete the <#= DataType.ModelName #> entity from the database
        /// </summary>
        /// <param name="entity">I<#= DataType.ModelName #></param>
        /// <returns>bool</returns>
		bool Delete(I<#= DataType.ModelName #> entity);
		
        /// <summary>
        /// Delete the <#= DataType.ModelName #> entity async from the database
        /// </summary>
        /// <param name="entity">I<#= DataType.ModelName #></param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(I<#= DataType.ModelName #> entity);

		/// <summary>
        /// Delete the <#= DataType.ModelName #> entity from the database
        /// </summary>
<#+ foreach(var col in DataType.MetaData.Columns.Where(o => o.IsPrimaryKey)) {#>
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #></param>
<#+ } #>
        /// <returns>bool</returns>
		bool Delete(<#= DataType.TransformAsParameter(DataType.MetaData.Columns.Where(o => o.IsPrimaryKey)) #>, bool cache);

		/// <summary>
        /// Delete the <#= DataType.ModelName #> entity async from the database
        /// </summary>
<#+ foreach(var col in DataType.MetaData.Columns.Where(o => o.IsPrimaryKey)) {#>
        /// <param name="<#= DataType.TransformParameterName(col.ColumnName) #>"><#= CSharpOutputMapper.MapToOutput(col) #>, bool cache</param>
<#+ } #>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(<#= DataType.TransformAsParameter(DataType.MetaData.Columns.Where(o => o.IsPrimaryKey)) #>, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<I<#= DataType.ModelName #>, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<I<#= DataType.ModelName #>, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<I<#= DataType.ModelName #>, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<I<#= DataType.ModelName #>, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<I<#= DataType.ModelName #>> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<I<#= DataType.ModelName #>> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<I<#= DataType.ModelName #>> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<I<#= DataType.ModelName #>> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<I<#= DataType.ModelName #>> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<I<#= DataType.ModelName #>> items);

        #endregion
	}
}
