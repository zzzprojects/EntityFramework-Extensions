# Delete By Key

The `DeleteByKey` is a `DbSet<TEntity>` extension method that deletes an entity by using the value from an existing entity or directly key values. 

 - It is a direct operation and doesn't require to call SaveChanges.
 - The entity must exist in the database before this method is called.
 
 ```csharp
 int key = 1;
context.Customers.DeleteByKey(key);
            
var customer = context.Customers.FirstOrDefault();
context.Customers.DeleteByKey(customer.CustomerID);
 ```
 
 [Try it](https://dotnetfiddle.net/AtVQZj)
 
 In this example, first the customer with `CustomerID` equal to 1 is deleted and it retrieves the customer from the database and then pass the key value is specified as an argument in `DeleteByKey` method. 
 
 ## Documentation

### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `DeleteByKey<TEntity, T>(T entityOrKeyValue)` | Deletes an entity by key in your database. | [Try it](https://dotnetfiddle.net/AtVQZj) |
| `DeleteByKey<TEntity>(params object[] keyValues)` | Deletes an entity by key in your database.  | |
| `DeleteByKeyAsync<TEntity, T>(T entityOrKeyValue)` | Deletes an entity by key in your database. | |
| `DeleteByKeyAsync<TEntity>(params object[] keyValues)` | Deletes an entity by key in your database. | |
| `DeleteByKeyAsync<TEntity, T>(CancellationToken cancellationToken, T entityOrKeyValue)` | Deletes an entity by key in your database. | |
| `DeleteByKeyAsync<TEntity>(CancellationToken cancellationToken, params object[] keyValues)` | Deletes an entity by key in your database. | |

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
