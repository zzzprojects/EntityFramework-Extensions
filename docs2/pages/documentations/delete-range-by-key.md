# Delete Range By Key

The `DeleteRangeByKey` is a `DbSet<TEntity>` extension method that deletes multiple entities by using the value from existing entities. 

 - It is a direct operation and doesn't require to call SaveChanges.
 - The entity must exist in the database before this method is called.
 
 ```csharp
var keys = customers.Take(2).Select(x => new { x.CustomerID });
context.Customers.DeleteRangeByKey(keys);
            
var customersToDelete = context.Customers.ToList().Take(2);
context.Customers.DeleteRangeByKey(customersToDelete);
 ```
 
 [Try it](https://dotnetfiddle.net/ONTPIs)
 
 In this example, the first two customers are deleted by specifying their keys and then two customers are deleted by specifying the entities itself. 
 
 ## Documentation

### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `DeleteRangeByKey<TEntity, T>(IEnumerable<T> entities)` | Deletes multiple entities by key in your database. | [Try it](https://dotnetfiddle.net/ONTPIs) |
| `DeleteRangeByKeyAsync<TEntity, T>(IEnumerable<T> entities)` | Deletes multiple entities by key in your database.  | |
| `DeleteRangeByKeyAsync<TEntity, T>(CancellationToken cancellationToken, IEnumerable<T> entities)` | Deletes multiple entities by key in your database. | |

### Options
More options can be found here:

- [Audit](https://entityframework-extensions.net/audit)
- [Batch](https://entityframework-extensions.net/batch)
- [Column](https://entityframework-extensions.net/column)
- [Context Factory](https://entityframework-extensions.net/context-factory)
- [Execute Event](https://entityframework-extensions.net/execute-event)
- [Identity](https://entityframework-extensions.net/identity)
- [Include Graph](https://entityframework-extensions.net/include-graph)
- [Key](https://entityframework-extensions.net/key)
- [Logging](https://entityframework-extensions.net/logging)
- [Temporary Table](https://entityframework-extensions.net/temporary-table)
- [Transaction](https://entityframework-extensions.net/transaction)
- [Transient Error](https://entityframework-extensions.net/transient-error)
- [SQL Server](https://entityframework-extensions.net/sql-server)
