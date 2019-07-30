# Delete By Key

The `DeleteByKey` is a `DbSet<TEntity>` extension method that deletes an entity by using the value from an existing entity or directly key values. 

 - It is a direct operation and doesn't require to call SaveChanges.
 - The entity must exist in the database before this method is called.
 
```csharp
var key = customers.FirstOrDefault().CustomerID;
context.Customers.DeleteByKey(key);
            
var customer = context.Customers.FirstOrDefault();
context.Customers.DeleteByKey(customer);
```
 
[Try it](https://dotnetfiddle.net/AtVQZj)
 
In this example, the first customer is deleted by specifying it key and then another customer is deleted based on an entity itself from the database. 
 
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
