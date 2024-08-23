// documentation: https://entityframework-extensions.net/adding-a-namespace-to-entity-framework-extensions

extern alias EntityFrameworkExtensionsCoreAlias;
using EntityFrameworkExtensionsCoreAlias.Z.BulkOperations;
using EntityFrameworkExtensionsCoreAlias.Z.EntityFramework.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Data.Common;
using System.Dynamic;
using System.Linq.Expressions;

namespace EntityFrameworkExtensionsCoreNamespace
{
    public static class Extensions
    {
        #region BulkDelete  

        public static void BulkDelete<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        { 
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete<T>(@this, entities);
        } 

        public static void BulkDelete<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete<T>(@this, entities, options);
        }

        public static void BulkDelete<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete<T>(@this, entities, options);
        }   

        public static void SingleDelete<T>(this DbContext @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete<T>(@this, entity);
        } 

        public static void SingleDelete<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete<T>(@this, entity, options);
        } 

        public static void SingleDelete<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete<T>(@this, entity, options);
        }
         
        public static void BulkDelete<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDelete<T>(@this, entities);
        }
         
        public static void BulkDelete<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDelete<T>(@this, entities, options);
        }
         
        public static void BulkDelete<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDelete<T>(@this, entities, options);
        }

        public static void SingleDelete<T>(this DbSet<T> @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDelete<T>(@this, entity);
        } 
         
        public static void SingleDelete<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDelete<T>(@this, entity, options);
        }
         
        public static void SingleDelete<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDelete<T>(@this, entity, options);
        }

        public static void BulkDelete<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete<T>(@this, entities);
        }

        public static void BulkDelete<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete<T>(@this, entities, options);
        }

        #region Bulk with typeof() 

        public static void BulkDelete(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete(@this, type, entities);
        }

        public static void BulkDelete(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete(@this, type, entities, options);
        }

        #endregion 

        public static void BulkDelete<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete<T>(@this, entities, options);
        }

        #region Bulk with typeof()  

        public static void BulkDelete(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDelete(@this, type, entities, options);
        }

        #endregion
         
        public static void SingleDelete<T>(this DbContext @this, object entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete<T>(@this, entity);
        }
      
        public static void SingleDelete<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete<T>(@this, entity, options);
        }

        #region Bulk with typeof() 
         
        public static void SingleDelete(this DbContext @this, Type type, object entity)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete(@this, type, entity);
        }
      
        public static void SingleDelete(this DbContext @this, Type type, object entity, Action<BulkOperation> options) 
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete(@this, type, entity, options);
        }

        #endregion
         
        public static void SingleDelete<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete<T>(@this, entity, options);
        }

        #region Bulk with typeof()  
         
        public static void SingleDelete(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDelete(@this, type, entity, options);
        }

        #endregion

        #endregion

        #region BulkDeleteAsync
         
        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities); 
        } 

        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, options);
        }  

        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, options);
        }
         
        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, options, cancellationToken);
        }
         
        public static Task SingleDeleteAsync<T>(this DbContext @this, T entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity);
        }
         
        public static Task SingleDeleteAsync<T>(this DbContext @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, cancellationToken);
        } 

        public static Task SingleDeleteAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class 
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, options);
        } 

        public static Task SingleDeleteAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, options, cancellationToken);
        }
         
        public static Task SingleDeleteAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, options);
        }
         
        public static Task SingleDeleteAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task BulkDeleteAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class 
        { 
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDeleteAsync<T>(@this, entities, options);
        } 

        public static Task BulkDeleteAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDeleteAsync<T>(@this, entities, options, cancellationToken);
        }
         
        public static Task BulkDeleteAsync<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDeleteAsync<T>(@this, entities);
        } 

        public static Task BulkDeleteAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDeleteAsync<T>(@this, entities, cancellationToken);
        } 

        public static Task BulkDeleteAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDeleteAsync<T>(@this, entities, options);
        }
         
        public static Task BulkDeleteAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkDeleteAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task SingleDeleteAsync<T>(this DbSet<T> @this, T entity) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDeleteAsync<T>(@this, entity);
        }

        public static Task SingleDeleteAsync<T>(this DbSet<T> @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDeleteAsync<T>(@this, entity, cancellationToken);
        }

        public static Task SingleDeleteAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDeleteAsync<T>(@this, entity, options);
        } 
        public static Task SingleDeleteAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDeleteAsync<T>(@this, entity, options, cancellationToken);
        }
         
        public static Task SingleDeleteAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDeleteAsync<T>(@this, entity, options);
        }
         
        public static Task SingleDeleteAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleDeleteAsync<T>(@this, entity, options, cancellationToken);
        }

        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities);
        }

        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<object> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, cancellationToken);
        }

        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, options);
        } 

        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof() 
         
        public static Task BulkDeleteAsync(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync(@this, type, entities);
        } 

        public static Task BulkDeleteAsync(this DbContext @this, Type type, IEnumerable<object> entities, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync(@this, type, entities, cancellationToken);
        } 

        public static Task BulkDeleteAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync(@this, type, entities, options);
        } 

        public static Task BulkDeleteAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion
         
        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, options);
        }
         
        public static Task BulkDeleteAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof()  
         
        public static Task BulkDeleteAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync(@this, type, entities, options);
        }
         
        public static Task BulkDeleteAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkDeleteAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion 

        public static Task SingleDeleteAsync<T>(this DbContext @this, object entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity);
        }
         
        public static Task SingleDeleteAsync<T>(this DbContext @this, object entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, cancellationToken);
        }

        public static Task SingleDeleteAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, options);
        } 

        public static Task SingleDeleteAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof() 
         
        public static Task SingleDeleteAsync(this DbContext @this, Type type, object entity)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync(@this, type, entity);
        }
         
        public static Task SingleDeleteAsync(this DbContext @this, Type type, object entity, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync(@this, type, entity, cancellationToken);
        } 
        public static Task SingleDeleteAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync(@this, type, entity, options);
        } 

        public static Task SingleDeleteAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion
         
        public static Task SingleDeleteAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, options);
        }
         
        public static Task SingleDeleteAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof()  
         
        public static Task SingleDeleteAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync(@this, type, entity, options);
        } 

        public static Task SingleDeleteAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleDeleteAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion

        #endregion

        #region BulkInsert 

        public static void BulkInsert<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert<T>(@this, entities);
        } 

        public static void BulkInsert<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert<T>(@this, entities, options);
        } 

        public static void BulkInsert<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert<T>(@this, entities, options);
        }
 
        public static void SingleInsert<T>(this DbContext @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert<T>(@this, entity);
        } 

        public static void SingleInsert<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert<T>(@this, entity, options);
        } 

        public static void SingleInsert<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert<T>(@this, entity, options);
        }

        public static void BulkInsert<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsert<T>(@this, entities);
        } 

        public static void BulkInsert<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsert<T>(@this, entities, options);
        } 

        public static void BulkInsert<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsert<T>(@this, entities, options);
        } 

        public static void SingleInsert<T>(this DbSet<T> @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsert<T>(@this, entity);
        } 

        public static void SingleInsert<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsert<T>(@this, entity, options);
        } 

        public static void SingleInsert<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsert<T>(@this, entity, options);
        }

        public static void BulkInsert<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        { 
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert<T>(@this, entities);
        } 

        public static void BulkInsert<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert<T>(@this, entities, options);
        }

        #region Bulk with typeof()  

        public static void BulkInsert(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert(@this, type, entities);
        } 

        public static void BulkInsert(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert(@this, type, entities, options);
        }

        #endregion
         
        public static void BulkInsert<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert<T>(@this, entities, options);
        }

        #region Bulk with typeof() 
         
        public static void BulkInsert(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsert(@this, type, entities, options);
        }

        #endregion 

        public static void SingleInsert<T>(this DbContext @this, object entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert<T>(@this, entity);
        } 

        public static void SingleInsert<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert<T>(@this, entity, options);
        }

        #region Bulk with typeof()  

        public static void SingleInsert(this DbContext @this, Type type, object entity)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert(@this, type, entity);
        } 

        public static void SingleInsert(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert(@this, type, entity, options);
        }

        #endregion 

        public static void SingleInsert<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert<T>(@this, entity, options);
        }

        #region Bulk with typeof()   

        public static void SingleInsert(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsert(@this, type, entity, options);
        }

        #endregion
        #endregion

        #region BulkInsertAsync

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities);
        } 

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, cancellationToken);
        } 

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, options);
        }

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, options);
        }
         
        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, options, cancellationToken);
        }

        public static Task SingleInsertAsync<T>(this DbContext @this, T entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity);
        }
         
        public static Task SingleInsertAsync<T>(this DbContext @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, cancellationToken);
        } 

        public static Task SingleInsertAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, options);
        }
         
        public static Task SingleInsertAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task SingleInsertAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, options);
        } 

        public static Task SingleInsertAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task BulkInsertAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertAsync<T>(@this, entities, options);
        }
         
        public static Task BulkInsertAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertAsync<T>(@this, entities, options, cancellationToken);
        }
         
        public static Task BulkInsertAsync<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertAsync<T>(@this, entities);
        }
         
        public static Task BulkInsertAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkInsertAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertAsync<T>(@this, entities, options);
        }
         
        public static Task BulkInsertAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task SingleInsertAsync<T>(this DbSet<T> @this, T entity) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsertAsync<T>(@this, entity);
        } 
        
        public static Task SingleInsertAsync<T>(this DbSet<T> @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsertAsync<T>(@this, entity, cancellationToken);
        } 

        public static Task SingleInsertAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsertAsync<T>(@this, entity, options);
        } 
        public static Task SingleInsertAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsertAsync<T>(@this, entity, options, cancellationToken);
        }
         
        public static Task SingleInsertAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsertAsync<T>(@this, entity, options);
        }
         
        public static Task SingleInsertAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleInsertAsync<T>(@this, entity, options, cancellationToken);
        }

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities);
        } 

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<object> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, cancellationToken);
        }

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, options);
        } 

        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof()  

        public static Task BulkInsertAsync(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync(@this, type, entities);
        }
         
        public static Task BulkInsertAsync(this DbContext @this, Type type, IEnumerable<object> entities, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync(@this, type, entities, cancellationToken);
        }

        public static Task BulkInsertAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync(@this, type, entities, options);
        } 
        public static Task BulkInsertAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion
         
        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, options);
        }
         
        public static Task BulkInsertAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof()  
         
        public static Task BulkInsertAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync(@this, type, entities, options);
        }
         
        public static Task BulkInsertAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion 
        public static Task SingleInsertAsync<T>(this DbContext @this, object entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity);
        }
         
        public static Task SingleInsertAsync<T>(this DbContext @this, object entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, cancellationToken);
        } 
        public static Task SingleInsertAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, options);
        } 
        public static Task SingleInsertAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof() 
         
        public static Task SingleInsertAsync(this DbContext @this, Type type, object entity)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync(@this, type, entity);
        } 

        public static Task SingleInsertAsync(this DbContext @this, Type type, object entity, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync(@this, type, entity, cancellationToken);
        } 

        public static Task SingleInsertAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync(@this, type, entity, options);
        } 

        public static Task SingleInsertAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion 

        public static Task SingleInsertAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, options);
        }
         
        public static Task SingleInsertAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof()  
         
        public static Task SingleInsertAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync(@this, type, entity, options);
        }
         
        public static Task SingleInsertAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleInsertAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion

        #endregion

        #region BulkInsertOptimized

        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized<T>(@this, entities);
        }
         
        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized<T>(@this, entities, options);
        }

        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized<T>(@this, entities, options);
        }

        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimized<T>(@this, entities);
        } 

        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimized<T>(@this, entities, options);
        }
         
        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimized<T>(@this, entities, options);
        } 

        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized<T>(@this, entities);
        }

        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized<T>(@this, entities, options);
        }

        #region Bulk with typeof() 
        public static BulkOptimizedAnalysis BulkInsertOptimized(this DbContext @this, Type type, IEnumerable<object> entities)
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized(@this, type, entities);
        }
         
        public static BulkOptimizedAnalysis BulkInsertOptimized(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized(@this, type, entities, options);
        }

        #endregion
         
        public static BulkOptimizedAnalysis BulkInsertOptimized<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized<T>(@this, entities, options);
        }

        #region Bulk with typeof() 
         
        public static BulkOptimizedAnalysis BulkInsertOptimized(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimized(@this, type, entities, options);
        }

        #endregion

        #endregion

        #region BulkInsertOptimizedAsync
          
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, cancellationToken);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options, cancellationToken);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimizedAsync<T>(@this, entities);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimizedAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options, cancellationToken);
        }

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<object> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, cancellationToken);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof()  

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync(@this, type, entities);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync(this DbContext @this, Type type, IEnumerable<object> entities, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync(@this, type, entities, cancellationToken);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync(@this, type, entities, options);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options);
        } 

        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof()   
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync(@this, type, entities, options);
        }
         
        public static Task<BulkOptimizedAnalysis> BulkInsertOptimizedAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkInsertOptimizedAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion

        #endregion

        #region BulkMerge

        public static void BulkMerge<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        { 
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge<T>(@this, entities);
        }

        public static void BulkMerge<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge<T>(@this, entities, options);
        }

        public static void BulkMerge<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge<T>(@this, entities, options);
        }

        public static void SingleMerge<T>(this DbContext @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge<T>(@this, entity);
        }
        public static void SingleMerge<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge<T>(@this, entity, options);
        }

        public static void SingleMerge<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge<T>(@this, entity, options);
        }

        public static void BulkMerge<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMerge<T>(@this, entities);
        }

        public static void BulkMerge<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMerge<T>(@this, entities, options);
        }

        public static void BulkMerge<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMerge<T>(@this, entities, options);
        }

        public static void SingleMerge<T>(this DbSet<T> @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMerge<T>(@this, entity);
        }
        public static void SingleMerge<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMerge<T>(@this, entity, options);
        }

        public static void SingleMerge<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMerge<T>(@this, entity, options);
        }

        public static void BulkMerge<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge<T>(@this, entities);
        }

        public static void BulkMerge<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge<T>(@this, entities, options);
        }

        #region Bulk with typeof() 

        public static void BulkMerge(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge(@this, type, entities);
        }

        public static void BulkMerge(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge(@this, type, entities, options);
        }

        #endregion

        public static void BulkMerge<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge<T>(@this, entities, options);
        }

        #region Bulk with typeof()  

        public static void BulkMerge(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMerge(@this, type, entities, options);
        }

        #endregion

        public static void SingleMerge<T>(this DbContext @this, object entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge<T>(@this, entity);
        }

        public static void SingleMerge<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge<T>(@this, entity, options);
        }

        #region Bulk with typeof() 

        public static void SingleMerge(this DbContext @this, Type type, object entity)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge(@this, type, entity);
        }

        public static void SingleMerge(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge(@this, type, entity, options);
        }

        #endregion

        public static void SingleMerge<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge<T>(@this, entity, options);
        }

        #region Bulk with typeof()  

        public static void SingleMerge(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMerge(@this, type, entity, options);
        }

        #endregion

        #endregion

        #region BulkMergeAsync

        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities); 
        }
         
        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, options);
        } 

        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, options, cancellationToken);
        }
         
        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, options);
        }
         
        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, options, cancellationToken);
        }

        public static Task SingleMergeAsync<T>(this DbContext @this, T entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity);
        }
         
        public static Task SingleMergeAsync<T>(this DbContext @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, cancellationToken);
        } 
        public static Task SingleMergeAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, options);
        } 

        public static Task SingleMergeAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task SingleMergeAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, options);
        } 

        public static Task SingleMergeAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task BulkMergeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMergeAsync<T>(@this, entities, options);
        } 

        public static Task BulkMergeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMergeAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task BulkMergeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMergeAsync<T>(@this, entities);
        }
         
        public static Task BulkMergeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMergeAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkMergeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMergeAsync<T>(@this, entities, options);
        }
         
        public static Task BulkMergeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkMergeAsync<T>(@this, entities, options, cancellationToken);
        }

        public static Task SingleMergeAsync<T>(this DbSet<T> @this, T entity) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMergeAsync<T>(@this, entity);
        }
         
        public static Task SingleMergeAsync<T>(this DbSet<T> @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMergeAsync<T>(@this, entity, cancellationToken);
        } 
        public static Task SingleMergeAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMergeAsync<T>(@this, entity, options);
        } 

        public static Task SingleMergeAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMergeAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task SingleMergeAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMergeAsync<T>(@this, entity, options);
        }
         
        public static Task SingleMergeAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleMergeAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities);
        }
         
        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<object> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, options);
        } 

        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof()  

        public static Task BulkMergeAsync(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync(@this, type, entities);
        }
         
        public static Task BulkMergeAsync(this DbContext @this, Type type, IEnumerable<object> entities, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync(@this, type, entities, cancellationToken);
        } 

        public static Task BulkMergeAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync(@this, type, entities, options);
        } 

        public static Task BulkMergeAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion
         
        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, options);
        }
         
        public static Task BulkMergeAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof() 
         
        public static Task BulkMergeAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync(@this, type, entities, options);
        }
         
        public static Task BulkMergeAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkMergeAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion 

        public static Task SingleMergeAsync<T>(this DbContext @this, object entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity);
        } 
        public static Task SingleMergeAsync<T>(this DbContext @this, object entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, cancellationToken);
        } 

        public static Task SingleMergeAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, options);
        } 

        public static Task SingleMergeAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof() 

        public static Task SingleMergeAsync(this DbContext @this, Type type, object entity)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync(@this, type, entity);
        }

        public static Task SingleMergeAsync(this DbContext @this, Type type, object entity, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync(@this, type, entity, cancellationToken);
        } 

        public static Task SingleMergeAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync(@this, type, entity, options);
        } 

        public static Task SingleMergeAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion
         
        public static Task SingleMergeAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, options);
        }
         
        public static Task SingleMergeAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof()  
         
        public static Task SingleMergeAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync(@this, type, entity, options);
        }
         
        public static Task SingleMergeAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleMergeAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion

        #endregion

        #region BulkSynchronize 
          
        public static void BulkSynchronize<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize<T>(@this, entities); 
        }
         
        public static void BulkSynchronize<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize<T>(@this, entities, options);
        } 

        public static void BulkSynchronize<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize<T>(@this, entities, options);
        }

        public static void SingleSynchronize<T>(this DbContext @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize<T>(@this, entity);
        } 

        public static void SingleSynchronize<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize<T>(@this, entity, options);
        } 

        public static void SingleSynchronize<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize<T>(@this, entity, options);
        }

        public static void BulkSynchronize<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronize<T>(@this, entities);
        } 

        public static void BulkSynchronize<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronize<T>(@this, entities, options);
        } 

        public static void BulkSynchronize<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronize<T>(@this, entities, options);
        } 

        public static void SingleSynchronize<T>(this DbSet<T> @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronize<T>(@this, entity);
        } 
        public static void SingleSynchronize<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronize<T>(@this, entity, options);
        }
         
        public static void SingleSynchronize<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronize<T>(@this, entity, options);
        } 

        public static void BulkSynchronize<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize<T>(@this, entities);
        } 

        public static void BulkSynchronize<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize<T>(@this, entities, options);
        }

        #region Bulk with typeof() 
         
        public static void BulkSynchronize(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize(@this, type, entities);
        } 

        public static void BulkSynchronize(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize(@this, type, entities, options);
        }

        #endregion
         
        public static void BulkSynchronize<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize<T>(@this, entities, options);
        }

        #region Bulk with typeof() 
         
        public static void BulkSynchronize(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronize(@this, type, entities, options);
        }

        #endregion 

        public static void SingleSynchronize<T>(this DbContext @this, object entity) where T : class
        { 
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize<T>(@this, entity);
        }
         
        public static void SingleSynchronize<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize<T>(@this, entity, options);
        }

        #region Bulk with typeof() 
         
        public static void SingleSynchronize(this DbContext @this, Type type, object entity)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize(@this, type, entity);
        } 

        public static void SingleSynchronize(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize(@this, type, entity, options);
        }

        #endregion
         
        public static void SingleSynchronize<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize<T>(@this, entity, options);
        }

        #region Bulk with typeof()  
         
        public static void SingleSynchronize(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronize(@this, type, entity, options);
        }

        #endregion

        #endregion

        #region BulkSynchronizeAsync 

        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities); 
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, cancellationToken);
        } 

        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, options);
        } 
        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, options);
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, options, cancellationToken);
        }

        public static Task SingleSynchronizeAsync<T>(this DbContext @this, T entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity);
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, cancellationToken);
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, options);
        } 
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, options, cancellationToken);
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, options);
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task BulkSynchronizeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronizeAsync<T>(@this, entities, options);
        } 

        public static Task BulkSynchronizeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronizeAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task BulkSynchronizeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronizeAsync<T>(@this, entities);
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronizeAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronizeAsync<T>(@this, entities, options);
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkSynchronizeAsync<T>(@this, entities, options, cancellationToken);
        }

        public static Task SingleSynchronizeAsync<T>(this DbSet<T> @this, T entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronizeAsync<T>(@this, entity);
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbSet<T> @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronizeAsync<T>(@this, entity, cancellationToken);
        } 

        public static Task SingleSynchronizeAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronizeAsync<T>(@this, entity, options);
        } 

        public static Task SingleSynchronizeAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronizeAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task SingleSynchronizeAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronizeAsync<T>(@this, entity, options);
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleSynchronizeAsync<T>(@this, entity, options, cancellationToken);
        }

        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities);
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<object> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, options);
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof() 
         
        public static Task BulkSynchronizeAsync(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync(@this, type, entities);
        }
         
        public static Task BulkSynchronizeAsync(this DbContext @this, Type type, IEnumerable<object> entities, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync(@this, type, entities, cancellationToken);
        } 

        public static Task BulkSynchronizeAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync(@this, type, entities, options);
        } 
         
        public static Task BulkSynchronizeAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion
         
        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, options);
        }
         
        public static Task BulkSynchronizeAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof()  

        public static Task BulkSynchronizeAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync(@this, type, entities, options);
        }
         
        public static Task BulkSynchronizeAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSynchronizeAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion 
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, object entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity); 
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, object entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, cancellationToken);
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, options);
        }
         
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof() 
         
        public static Task SingleSynchronizeAsync(this DbContext @this, Type type, object entity)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync(@this, type, entity);
        }
         
        public static Task SingleSynchronizeAsync(this DbContext @this, Type type, object entity, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync(@this, type, entity, cancellationToken);
        }
         
        public static Task SingleSynchronizeAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync(@this, type, entity, options);
        }
         
        public static Task SingleSynchronizeAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion
         
        public static Task SingleSynchronizeAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, options); 
        } 

        public static Task SingleSynchronizeAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof()  
         
        public static Task SingleSynchronizeAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync(@this, type, entity, options);
        }
         
        public static Task SingleSynchronizeAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleSynchronizeAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion

        #endregion

        #region BulkUpdate
         
        public static void BulkUpdate<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate<T>(@this, entities);
        } 

        public static void BulkUpdate<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate<T>(@this, entities, options);
        } 

        public static void BulkUpdate<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate<T>(@this, entities, options);
        } 

        public static void SingleUpdate<T>(this DbContext @this, T entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate<T>(@this, entity);
        } 
        public static void SingleUpdate<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate<T>(@this, entity, options);
        } 

        public static void SingleUpdate<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate<T>(@this, entity, options);
        } 

        public static void BulkUpdate<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdate<T>(@this, entities);
        }
         
        public static void BulkUpdate<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdate<T>(@this, entities, options);
        } 

        public static void BulkUpdate<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdate<T>(@this, entities, options);
        }

        public static void SingleUpdate<T>(this DbSet<T> @this, T entity) where T : class
        { 
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdate<T>(@this, entity);
        } 

        public static void SingleUpdate<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdate<T>(@this, entity, options);
        } 

        public static void SingleUpdate<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdate<T>(@this, entity, options);
        }

        public static void BulkUpdate<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate<T>(@this, entities);
        } 

        public static void BulkUpdate<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate<T>(@this, entities, options);
        }

        #region Bulk with typeof() 
         
        public static void BulkUpdate(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate(@this, type, entities);
        } 

        public static void BulkUpdate(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate(@this, type, entities, options);
        }

        #endregion
         
        public static void BulkUpdate<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate<T>(@this, entities, options);
        }

        #region Bulk with typeof() 
         
        public static void BulkUpdate(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdate(@this, type, entities, options);
        }

        #endregion 
        public static void SingleUpdate<T>(this DbContext @this, object entity) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate<T>(@this, entity);
        }
         
        public static void SingleUpdate<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate<T>(@this, entity, options);
        }

        #region Bulk with typeof() 
         
        public static void SingleUpdate(this DbContext @this, Type type, object entity)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate(@this, type, entity);
        } 

        public static void SingleUpdate(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate(@this, type, entity, options);
        }

        #endregion 

        public static void SingleUpdate<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate<T>(@this, entity, options);
        }

        #region Bulk with typeof()   

        public static void SingleUpdate(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdate(@this, type, entity, options);
        }

        #endregion

        #endregion

        #region BulkUpdateAsync 
         
        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities); 
        }
         
        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, options);
        } 

        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, options);
        }
         
        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, options, cancellationToken);
        } 

        public static Task SingleUpdateAsync<T>(this DbContext @this, T entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity);
        }
         
        public static Task SingleUpdateAsync<T>(this DbContext @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, cancellationToken);
        }
         
        public static Task SingleUpdateAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options) where T : class 
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, options);
        } 

        public static Task SingleUpdateAsync<T>(this DbContext @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task SingleUpdateAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, options); 
        } 

        public static Task SingleUpdateAsync<T>(this DbContext @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task BulkUpdateAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdateAsync<T>(@this, entities, options);
        } 

        public static Task BulkUpdateAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdateAsync<T>(@this, entities, options, cancellationToken);
        }
         
        public static Task BulkUpdateAsync<T>(this DbSet<T> @this, IEnumerable<T> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdateAsync<T>(@this, entities);
        }
         
        public static Task BulkUpdateAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdateAsync<T>(@this, entities, cancellationToken);
        }
         
        public static Task BulkUpdateAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdateAsync<T>(@this, entities, options);
        }
         
        public static Task BulkUpdateAsync<T>(this DbSet<T> @this, IEnumerable<T> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.BulkUpdateAsync<T>(@this, entities, options, cancellationToken);
        } 
        public static Task SingleUpdateAsync<T>(this DbSet<T> @this, T entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdateAsync<T>(@this, entity);
        }
         
        public static Task SingleUpdateAsync<T>(this DbSet<T> @this, T entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdateAsync<T>(@this, entity, cancellationToken);
        }
         
        public static Task SingleUpdateAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdateAsync<T>(@this, entity, options);
        }
         
        public static Task SingleUpdateAsync<T>(this DbSet<T> @this, T entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdateAsync<T>(@this, entity, options, cancellationToken);
        }
         
        public static Task SingleUpdateAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdateAsync<T>(@this, entity, options);
        }
         
        public static Task SingleUpdateAsync<T>(this DbSet<T> @this, T entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.SingleUpdateAsync<T>(@this, entity, options, cancellationToken);
        } 

        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<object> entities) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities);
        }
         
        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<object> entities, CancellationToken cancellationToken) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, cancellationToken);
        } 

        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options) where T : class 
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, options);
        }
         
        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<object> entities, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof() 
         
        public static Task BulkUpdateAsync(this DbContext @this, Type type, IEnumerable<object> entities)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync(@this, type, entities);
        }
         
        public static Task BulkUpdateAsync(this DbContext @this, Type type, IEnumerable<object> entities, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync(@this, type, entities, cancellationToken);
        }
         
        public static Task BulkUpdateAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync(@this, type, entities, options);
        }
         
        public static Task BulkUpdateAsync(this DbContext @this, Type type, IEnumerable<object> entities, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion
         
        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, options);
        }
         
        public static Task BulkUpdateAsync<T>(this DbContext @this, IEnumerable<object> entities, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync<T>(@this, entities, options, cancellationToken);
        }

        #region Bulk with typeof()  
         
        public static Task BulkUpdateAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync(@this, type, entities, options);
        }
         
        public static Task BulkUpdateAsync(this DbContext @this, Type type, IEnumerable<object> entities, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkUpdateAsync(@this, type, entities, options, cancellationToken);
        }

        #endregion 
        public static Task SingleUpdateAsync<T>(this DbContext @this, object entity) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity);
        }
         
        public static Task SingleUpdateAsync<T>(this DbContext @this, object entity, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, cancellationToken);
        }
         
        public static Task SingleUpdateAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, options);
        }
         
        public static Task SingleUpdateAsync<T>(this DbContext @this, object entity, Action<BulkOperation<T>> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof() 
         
        public static Task SingleUpdateAsync(this DbContext @this, Type type, object entity)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync(@this, type, entity);
        }
         
        public static Task SingleUpdateAsync(this DbContext @this, Type type, object entity, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync(@this, type, entity, cancellationToken);
        }
         
        public static Task SingleUpdateAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync(@this, type, entity, options);
        }
         
        public static Task SingleUpdateAsync(this DbContext @this, Type type, object entity, Action<BulkOperation> options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion
         
        public static Task SingleUpdateAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, options);
        }
         
        public static Task SingleUpdateAsync<T>(this DbContext @this, object entity, BulkOperationOptions<T> options, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync<T>(@this, entity, options, cancellationToken);
        }

        #region Bulk with typeof()  
         
        public static Task SingleUpdateAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync(@this, type, entity, options);
        }
         
        public static Task SingleUpdateAsync(this DbContext @this, Type type, object entity, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.SingleUpdateAsync(@this, type, entity, options, cancellationToken);
        }

        #endregion

        #endregion

        #region BulkSaveChanges
         
        public static void BulkSaveChanges(this DbContext @this)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChanges(@this); 
        }
         
        public static void BulkSaveChanges(this DbContext @this, Action<BulkOperation> options)
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChanges(@this, options);
        } 
         
        public static void BulkSaveChanges(this DbContext @this, BulkOperationOptions options)
        { 
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChanges(@this, options);
        }

        #endregion

        #region BulkSaveChangesAsync
         
        public static Task BulkSaveChangesAsync(this DbContext @this)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChangesAsync(@this);
        }
         
        public static Task BulkSaveChangesAsync(this DbContext @this, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChangesAsync(@this, cancellationToken);
        }
         
        public static Task BulkSaveChangesAsync(this DbContext @this, Action<BulkOperation> options) 
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChangesAsync(@this, options);
        }
         
        public static Task BulkSaveChangesAsync(this DbContext @this, Action<BulkOperation> options, CancellationToken cancellationToken) 
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChangesAsync(@this, options, cancellationToken);
        }
         
        public static Task BulkSaveChangesAsync(this DbContext @this, BulkOperationOptions options)
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChangesAsync(@this, options);
        }
         
        public static Task BulkSaveChangesAsync(this DbContext @this, BulkOperationOptions options, CancellationToken cancellationToken)
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.BulkSaveChangesAsync(@this, options, cancellationToken);
        }

        #endregion

        #region CreateBulkOptions

        public static BulkOperationOptions<T> CreateBulkOptions<T>(this DbSet<T> @this) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.CreateBulkOptions<T>(@this);
        }

        public static BulkOperationOptions<T> CreateBulkOptions<T>(this DbContext @this) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.CreateBulkOptions<T>(@this);
        }
         
        public static BulkOperationOptions CreateBulkOptions(this DbContext @this)
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.CreateBulkOptions(@this);
        }

        #endregion

        #region DeleteFromQuery
         
        public static int DeleteFromQuery<T>(this IQueryable<T> query) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchDeleteExtensions.DeleteFromQuery<T>(query);
        }
         
        public static int DeleteFromQuery<T>(this IQueryable<T> query, Action<BatchDelete> batchDeleteBuilder) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchDeleteExtensions.DeleteFromQuery<T>(query, batchDeleteBuilder);
        }

        #endregion

        #region DeleteFromQueryAsync
         
        public static Task<int> DeleteFromQueryAsync<T>(this IQueryable<T> query, CancellationToken cancellationToken = default(CancellationToken)) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchDeleteExtensions.DeleteFromQueryAsync<T>(query, cancellationToken); 
        }
         
        public static Task<int> DeleteFromQueryAsync<T>(this IQueryable<T> query, Action<BatchDelete> batchDeleteBuilder, CancellationToken cancellationToken = default(CancellationToken)) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchDeleteExtensions.DeleteFromQueryAsync<T>(query, batchDeleteBuilder, cancellationToken);
        }

        #endregion

        #region UpdateFromQuery
         
        public static int UpdateFromQuery<T>(this IQueryable<T> query, Expression<Func<T, T>> updateFactory) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQuery<T>(query, updateFactory); 
        } 

        public static int UpdateFromQuery<T>(this IQueryable<T> query, Expression<Func<T, T>> updateFactory, Action<BatchUpdate> batchUpdateBuilder) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQuery<T>(query, updateFactory, batchUpdateBuilder);
        }

        #region Expando & Dictionary & Anonymous 

        public static int UpdateFromQuery<T>(this IQueryable<T> query, ExpandoObject expandoObject) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQuery<T>(query, expandoObject);
        }
         
        public static int UpdateFromQuery<T>(this IQueryable<T> query, ExpandoObject expandoObject, Action<BatchUpdate> batchUpdateBuilder) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQuery<T>(query, expandoObject, batchUpdateBuilder);
        }
         
        public static int UpdateFromQuery<T>(this IQueryable<T> query, IDictionary<string, object> dictionary) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQuery<T>(query, dictionary);
        }
         
        public static int UpdateFromQuery<T>(this IQueryable<T> query, IDictionary<string, object> dictionary, Action<BatchUpdate> batchUpdateBuilder) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQuery<T>(query, dictionary, batchUpdateBuilder);
        }
         
        public static int UpdateFromQuery<T>(this IQueryable<T> query, Expression<Func<T, object>> updateExpression) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQuery<T>(query, updateExpression);
        }
         
        public static int UpdateFromQuery<T>(this IQueryable<T> query, Expression<Func<T, object>> updateExpression, Action<BatchUpdate> batchUpdateBuilde) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQuery<T>(query, updateExpression, batchUpdateBuilde);
        }

        #endregion

        #endregion

        #region UpdateFromQueryAsync
         
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, Expression<Func<T, T>> updateFactory, CancellationToken cancellationToken = default(CancellationToken)) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, updateFactory, cancellationToken); 
        }
         
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, Expression<Func<T, T>> updateFactory, Action<BatchUpdate> batchUpdateBuilder, CancellationToken cancellationToken = default(CancellationToken)) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, updateFactory, batchUpdateBuilder, cancellationToken);
        }

        #region Expando
         
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, ExpandoObject expandoObject) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, expandoObject);
        }
         
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, ExpandoObject expandoObject, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, expandoObject, cancellationToken);
        }
         
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, ExpandoObject expandoObject, Action<BatchUpdate> batchUpdateBuilder) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, expandoObject, batchUpdateBuilder);
        } 
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, ExpandoObject expandoObject, Action<BatchUpdate> batchUpdateBuilder, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, expandoObject, batchUpdateBuilder, cancellationToken);
        }

        #endregion

        #region Dictionary
         
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, IDictionary<string, object> dictionary) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, dictionary);
        } 

        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, IDictionary<string, object> dictionary, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, dictionary, cancellationToken);
        }
         
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, IDictionary<string, object> dictionary, Action<BatchUpdate> batchUpdateBuilder) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, dictionary, batchUpdateBuilder);
        }
         
        public static Task<int> UpdateFromQueryAsync<T>(this IQueryable<T> query, IDictionary<string, object> dictionary, Action<BatchUpdate> batchUpdateBuilder, CancellationToken cancellationToken) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<T>(query, dictionary, batchUpdateBuilder, cancellationToken);
        }

        #endregion

        #region Anonymous
         
        public static Task<int> UpdateFromQueryAsync<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, object>> updateExpression) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<TEntity>(query, updateExpression);
        }
         
        public static Task<int> UpdateFromQueryAsync<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, object>> updateExpression, CancellationToken cancellationToken) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<TEntity>(query, updateExpression, cancellationToken);
        }
         
        public static Task<int> UpdateFromQueryAsync<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, object>> updateExpression, Action<BatchUpdate> batchUpdateBuilder) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<TEntity>(query, updateExpression, batchUpdateBuilder);
        }
         
        public static Task<int> UpdateFromQueryAsync<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, object>> updateExpression, Action<BatchUpdate> batchUpdateBuilder, CancellationToken cancellationToken) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.BatchUpdateExtensions.UpdateFromQueryAsync<TEntity>(query, updateExpression, batchUpdateBuilder, cancellationToken);
        }

        #endregion

        #endregion

        #region InsertFromQuery
         
        public static int InsertFromQuery<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, object>> selectExpression) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQuery<TEntity>(query, selectExpression);
        }
         
        public static int InsertFromQuery<TEntity>(this IQueryable<TEntity> query, string tableName, Expression<Func<TEntity, object>> selectExpression) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQuery<TEntity>(query, tableName, selectExpression);
        }
         
        public static int InsertFromQuery<TEntity>(this IQueryable<TEntity> query, Type tableType, Expression<Func<TEntity, object>> selectExpression) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQuery<TEntity>(query, tableType, selectExpression);
        }
         
        public static int InsertFromQuery<TEntity>(this IQueryable<TEntity> query, string schemaName, string tableName, Expression<Func<TEntity, object>> selectExpression) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQuery<TEntity>(query, schemaName, tableName, selectExpression);
        }
         
        public static int InsertFromQuery<TEntity>(this IQueryable<TEntity> query, string schemaName, Type tableType, Expression<Func<TEntity, object>> selectExpression) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQuery<TEntity>(query, schemaName, tableType, selectExpression);
        }
         
        public static int InsertFromQuery<TEntity>(this IQueryable<TEntity> query, string databaseName, string schemaName, string tableName, Expression<Func<TEntity, object>> selectExpression) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQuery<TEntity>(query, databaseName, schemaName, tableName, selectExpression);
        }
         
        public static int InsertFromQuery<TEntity>(this IQueryable<TEntity> query, string databaseName, string schemaName, Type tableType, Expression<Func<TEntity, object>> selectExpression) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQuery<TEntity>(query, databaseName, schemaName, tableType, selectExpression);
        }
         
        public static int InsertFromQuery<TEntity>(this IQueryable<TEntity> query, Action<BatchInsert<TEntity>> batchInsertBuilder) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQuery<TEntity>(query, batchInsertBuilder);
        }

        #endregion

        #region InsertFromQueryAsync 
         
        public static Task<int> InsertFromQueryAsync<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, object>> selectExpression, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQueryAsync<TEntity>(query, selectExpression, cancellationToken); 
        } 
        public static Task<int> InsertFromQueryAsync<TEntity>(this IQueryable<TEntity> query, string tableName, Expression<Func<TEntity, object>> selectExpression, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQueryAsync<TEntity>(query, tableName, selectExpression, cancellationToken);
        }
         
        public static Task<int> InsertFromQueryAsync<TEntity>(this IQueryable<TEntity> query, Type tableType, Expression<Func<TEntity, object>> selectExpression, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQueryAsync<TEntity>(query, tableType, selectExpression, cancellationToken);
        }
         
        public static Task<int> InsertFromQueryAsync<TEntity>(this IQueryable<TEntity> query, string schemaName, string tableName, Expression<Func<TEntity, object>> selectExpression, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQueryAsync<TEntity>(query, schemaName, tableName, selectExpression, cancellationToken);
        } 

        public static Task<int> InsertFromQueryAsync<TEntity>(this IQueryable<TEntity> query, string schemaName, Type tableType, Expression<Func<TEntity, object>> selectExpression, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQueryAsync<TEntity>(query, schemaName, tableType, selectExpression, cancellationToken);
        }
         
        public static Task<int> InsertFromQueryAsync<TEntity>(this IQueryable<TEntity> query, string databaseName, string schemaName, string tableName, Expression<Func<TEntity, object>> selectExpression, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQueryAsync<TEntity>(query, databaseName, schemaName, tableName, selectExpression, cancellationToken);
        }
         
        public static Task<int> InsertFromQueryAsync<TEntity>(this IQueryable<TEntity> query, string databaseName, string schemaName, Type tableType, Expression<Func<TEntity, object>> selectExpression, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQueryAsync<TEntity>(query, databaseName, schemaName, tableType, selectExpression, cancellationToken);
        }
         
        public static Task<int> InsertFromQueryAsync<TEntity>(this IQueryable<TEntity> query, Action<BatchInsert<TEntity>> batchInsertBuilder, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbContextExtensions.InsertFromQueryAsync<TEntity>(query, batchInsertBuilder, cancellationToken);
        }

        #endregion

        #region BindInterceptor
         
        public static void BindInterceptor(this DbContext dbContext, DbCommandInterceptor interceptor)
        { 
            EntityFrameworkExtensionsCoreAlias.BindInterceptorExtensions.BindInterceptor(dbContext, interceptor);
        }
         
        public static void BindInterceptor(this DbContext dbContext, DbConnectionInterceptor interceptor)
        { 
            EntityFrameworkExtensionsCoreAlias.BindInterceptorExtensions.BindInterceptor(dbContext, interceptor);
        }
         
        public static void BindInterceptor(this DbContext dbContext, DbTransactionInterceptor interceptor)
        {
            EntityFrameworkExtensionsCoreAlias.BindInterceptorExtensions.BindInterceptor(dbContext, interceptor);
        }

        #endregion

        #region DeleteByKey

        public static int DeleteByKey<TEntity, T>(this DbSet<TEntity> dbSet, T entityOrKeyValue) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteByKey<TEntity, T>(dbSet, entityOrKeyValue); 
        }
         
        public static int DeleteByKey<TEntity>(this DbSet<TEntity> dbSet, params object[] keyValues) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteByKey<TEntity>(dbSet, keyValues);
        }

        #endregion

        #region DeleteByKeyAsync
         
        public static Task<int> DeleteByKeyAsync<TEntity, T>(this DbSet<TEntity> dbSet, T entityOrKeyValue) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteByKeyAsync<TEntity, T>(dbSet, entityOrKeyValue);
        }
         
        public static Task<int> DeleteByKeyAsync<TEntity>(this DbSet<TEntity> dbSet, params object[] keyValues) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteByKeyAsync<TEntity>(dbSet, keyValues); 
        }
         
        public static Task<int> DeleteByKeyAsync<TEntity, T>(this DbSet<TEntity> dbSet, CancellationToken cancellationToken, T entityOrKeyValue) where TEntity : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteByKeyAsync<TEntity, T>(dbSet, cancellationToken, entityOrKeyValue);
        }
         
        public static Task<int> DeleteByKeyAsync<TEntity>(this DbSet<TEntity> dbSet, CancellationToken cancellationToken, params object[] keyValues) where TEntity : class
        { 
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteByKeyAsync<TEntity>(dbSet, cancellationToken, keyValues);
        }

        #endregion

        #region DeleteRangeByKey 
        public static int DeleteRangeByKey<TEntity, T>(this DbSet<TEntity> dbSet, IEnumerable<T> entities) where TEntity : class where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteRangeByKey<TEntity, T>(dbSet, entities); 
        }

        #endregion

        #region DeleteRangeByKeyAsync

        public static Task<int> DeleteRangeByKeyAsync<TEntity, T>(this DbSet<TEntity> dbSet, IEnumerable<T> entities) where TEntity : class where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteRangeByKeyAsync<TEntity, T>(dbSet, entities);
        }
         
        public static Task<int> DeleteRangeByKeyAsync<TEntity, T>(this DbSet<TEntity> dbSet, CancellationToken cancellationToken, IEnumerable<T> entities) where TEntity : class where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.DbSetExtensions.DeleteRangeByKeyAsync<TEntity, T>(dbSet, cancellationToken, entities);
        }

        #endregion

        #region Hook 

        public static IQueryable<T> Hook<T>(this IQueryable<T> @this, IQueryHook hook)
        {
            return EntityFrameworkExtensionsCoreAlias.QueryHookExtensions.Hook<T>(@this, hook);
        }

        #endregion

        #region HookExecuting
         
        public static IQueryable<T> HookExecuting<T>(this IQueryable<T> @this, Action<DbCommand, DbContext> action)
        {
            return EntityFrameworkExtensionsCoreAlias.QueryHookExtensions.HookExecuting<T>(@this, action);
        }

        #endregion

        #region  WhereBulkNotContainsFilterList

        public static List<TReturn> WhereBulkNotContainsFilterList<T, TReturn>(this IQueryable<T> query, IEnumerable<TReturn> list) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkNotContainsFilterTargetExtensions.WhereBulkNotContainsFilterList<T, TReturn>(query, list); 
        }
         
        public static List<TReturn> WhereBulkNotContainsFilterList<T, TReturn>(this IQueryable<T> query, IEnumerable<TReturn> list, Expression<Func<T, object>> keyExpression) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkNotContainsFilterTargetExtensions.WhereBulkNotContainsFilterList<T, TReturn>(query, list, keyExpression);
        }
         
        public static List<TReturn> WhereBulkNotContainsFilterList<T, TReturn>(this IQueryable<T> query, IEnumerable<TReturn> list, List<string> keyNames) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkNotContainsFilterTargetExtensions.WhereBulkNotContainsFilterList<T, TReturn>(query, list, keyNames);
        }
         
        public static List<TReturn> WhereBulkNotContainsFilterList<T, TReturn>(this IQueryable<T> query, IEnumerable<TReturn> list, params string[] keyNames) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkNotContainsFilterTargetExtensions.WhereBulkNotContainsFilterList<T, TReturn>(query, list, keyNames);
        }

        #endregion

        #region WhereBulkContainsFilterList
         
        public static List<TReturn> WhereBulkContainsFilterList<T, TReturn>(this IQueryable<T> query, IEnumerable<TReturn> list) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsFilterTargetExtensions.WhereBulkContainsFilterList<T, TReturn>(query, list); 
        }
         
        public static List<TReturn> WhereBulkContainsFilterList<T, TReturn>(this IQueryable<T> query, IEnumerable<TReturn> list, Expression<Func<T, object>> keyExpression) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsFilterTargetExtensions.WhereBulkContainsFilterList<T, TReturn>(query, list, keyExpression);
        }
         
        public static List<TReturn> WhereBulkContainsFilterList<T, TReturn>(this IQueryable<T> query, IEnumerable<TReturn> list, List<string> keyNames) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsFilterTargetExtensions.WhereBulkContainsFilterList<T, TReturn>(query, list, keyNames); 
        }
         
        public static List<TReturn> WhereBulkContainsFilterList<T, TReturn>(this IQueryable<T> query, IEnumerable<TReturn> list, params string[] keyNames) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsFilterTargetExtensions.WhereBulkContainsFilterList<T, TReturn>(query, list, keyNames);
        }

        #endregion

        #region ExecuteFutureAction

        public static void ExecuteFutureAction<T>(this T @this, bool useTransaction = false) where T : DbContext
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.ExecuteFutureAction<T>(@this, useTransaction);
        }
         
        public static void ExecuteFutureAction<T>(this T @this, Action<EntityFrameworkExtensionsCoreAlias.Z.EntityFramework.Extensions.EFCore.ExecuteFutureOption> executeFutureActionOption) where T : DbContext
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.ExecuteFutureAction<T>(@this, executeFutureActionOption);
        }

        #endregion

        #region FutureAction
        public static void FutureAction<T>(this T @this, Action<T> action) where T : DbContext
        {
            EntityFrameworkExtensionsCoreAlias.DbContextExtensions.FutureAction<T>(@this, action);
        }

        #endregion

        #region  BulkReadAsync

        public static Task<List<T>> BulkReadAsync<T>(this IQueryable<T> query, IEnumerable list, CancellationToken cancellationToken = default) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadAsyncExtensions.BulkReadAsync<T>(query, list, cancellationToken);
        }
         
        public static Task<List<T>> BulkReadAsync<T>(this IQueryable<T> query, IEnumerable list, Expression<Func<T, object>> keyExpression, CancellationToken cancellationToken = default) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadAsyncExtensions.BulkReadAsync<T>(query, list, keyExpression, cancellationToken);
        }
         
        public static Task<List<T>> BulkReadAsync<T>(this IQueryable<T> query, IEnumerable list, List<string> keyNames, CancellationToken cancellationToken = default) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadAsyncExtensions.BulkReadAsync<T>(query, list, keyNames, cancellationToken);
        }
         
        public static Task<List<T>> BulkReadAsync<T, TChild>(this IQueryable<T> query, Expression<Func<T, TChild>> selector, IEnumerable list, CancellationToken cancellationToken = default) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadAsyncExtensions.BulkReadAsync<T, TChild>(query, selector, list, cancellationToken);
        }
         
        public static Task<List<T>> BulkReadAsync<T, TChild>(this IQueryable<T> query, Expression<Func<T, TChild>> selector, IEnumerable list, Expression<Func<TChild, object>> keyExpression, CancellationToken cancellationToken = default) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadAsyncExtensions.BulkReadAsync<T, TChild>(query, selector, list, keyExpression, cancellationToken);
        }
         
        public static Task<List<T>> BulkReadAsync<T, TChild>(this IQueryable<T> query, Expression<Func<T, IEnumerable<TChild>>> selector, IEnumerable list, Expression<Func<TChild, object>> keyExpression, CancellationToken cancellationToken = default) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadAsyncExtensions.BulkReadAsync<T, TChild>(query, selector, list, keyExpression, cancellationToken);
        }
         
        public static Task<List<T>> BulkReadAsync<T, TChild>(this IQueryable<T> query, Expression<Func<T, TChild>> selector, IEnumerable list, List<string> keyNames, CancellationToken cancellationToken = default) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadAsyncExtensions.BulkReadAsync<T, TChild>(query, selector, list, keyNames, cancellationToken);
        }

        #endregion

        #region BulkRead 

        public static List<T> BulkRead<T>(this IQueryable<T> query, IEnumerable list) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T>(query, list); 
        }
         
        public static List<T> BulkRead<T>(this IQueryable<T> query, IEnumerable list, Expression<Func<T, object>> keyExpression) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T>(query, list, keyExpression);
        } 

        public static List<T> BulkRead<T>(this IQueryable<T> query, IEnumerable list, List<string> keyNames) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T>(query, list, keyNames);
        }
         
        public static List<T> BulkRead<T>(this IQueryable<T> query, IEnumerable list, params string[] keyNames) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T>(query, list, keyNames);
        }
         
        public static List<T> BulkRead<T, TChild>(this IQueryable<T> query, Expression<Func<T, TChild>> selector, IEnumerable list) where T : class where TChild : class
        {
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T, TChild>(query, selector, list);
        }
         
        public static List<T> BulkRead<T, TChild>(this IQueryable<T> query, Expression<Func<T, TChild>> selector, IEnumerable list, Expression<Func<TChild, object>> keyExpression) where T : class where TChild : class
        {
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T, TChild>(query, selector, list);
        }
         
        public static List<T> BulkRead<T, TChild>(this IQueryable<T> query, Expression<Func<T, IEnumerable<TChild>>> selector, IEnumerable list, Expression<Func<TChild, object>> keyExpression) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T, TChild>(query, selector, list, keyExpression);
        } 
        public static List<T> BulkRead<T, TChild>(this IQueryable<T> query, Expression<Func<T, TChild>> selector, IEnumerable list, List<string> keyNames) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T, TChild>(query, selector, list, keyNames);
        }
         
        public static List<T> BulkRead<T, TChild>(this IQueryable<T> query, Expression<Func<T, TChild>> selector, IEnumerable list, params string[] keyNames) where T : class where TChild : class
        {
            return EntityFrameworkExtensionsCoreAlias.BulkReadExtensions.BulkRead<T, TChild>(query, selector, list, keyNames);
        }

        #endregion

        #region WhereBulkContains
         
        public static IQueryable<T> WhereBulkContains<T>(this IQueryable<T> @this, IEnumerable isInList) where T : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T>(@this, isInList);
        }
         
        public static IQueryable<T> WhereBulkContains<T>(this IQueryable<T> @this, IEnumerable isInList, List<string> keyNames) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T>(@this, isInList, keyNames);
        }
         
        public static IQueryable<T> WhereBulkContains<T>(this IQueryable<T> @this, IEnumerable isInList, params string[] keyNames) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T>(@this, isInList, keyNames);
        }
         
        public static IQueryable<T> WhereBulkContains<T>(this IQueryable<T> @this, IEnumerable isInList, Expression<Func<T, object>> keyExpression) where T : class
        { 
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T>(@this, isInList, keyExpression);
        }
         
        public static IQueryable<T> WhereBulkContains<T, TChild>(this IQueryable<T> @this, Expression<Func<T, TChild>> selector, IEnumerable isInList) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T, TChild>(@this, selector, isInList);
        }
         
        public static IQueryable<T> WhereBulkContains<T, TChild>(this IQueryable<T> @this, Expression<Func<T, TChild>> selector, IEnumerable isInList, List<string> keyNames) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T, TChild>(@this, selector, isInList, keyNames);
        }
         
        public static IQueryable<T> WhereBulkContains<T, TChild>(this IQueryable<T> @this, Expression<Func<T, TChild>> selector, IEnumerable isInList, params string[] keyNames) where T : class where TChild : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T, TChild>(@this, selector, isInList, keyNames);
        }
         
        public static IQueryable<T> WhereBulkContains<T, TChild>(this IQueryable<T> @this, Expression<Func<T, IEnumerable<TChild>>> selector, IEnumerable isInList, Expression<Func<TChild, object>> keyExpression) where T : class where TChild : class
        { 
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T, TChild>(@this, selector, isInList, keyExpression);
        }
         
        public static IQueryable<T> WhereBulkContains<T, TChild>(this IQueryable<T> @this, Expression<Func<T, TChild>> selector, IEnumerable isInList, Expression<Func<TChild, object>> keyExpression) where T : class where TChild : class
        {
            return EntityFrameworkExtensionsCoreAlias.WhereBulkContainsExtensions.WhereBulkContains<T, TChild>(@this, selector, isInList, keyExpression);
        }
         

        #endregion 
    }
}
