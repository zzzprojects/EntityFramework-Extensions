# Delete Range By Key

The `DeleteRangeByKey` is a `DbSet<TEntity>` extension method that deletes multiple entities by using the value from existing entities. 

 - It is a direct operation and doesn't require to call SaveChanges.
 - The entity must exist in the database before this method is called.
 
```csharp
var customersToDelete = context.Customers.ToList().Take(2);
context.Customers.DeleteRangeByKey(customersToDelete);
```
 
[Try it](https://dotnetfiddle.net/ONTPIs)
 
In this example, the first two customers are deleted by specifying the entities itself from the database. 

## Anonymous Type

You can pass a list of anonymous type objects as a parameter. 

```csharp
var anonymousObjects = customers.Take(2).Select(x => new { x.CustomerID });
context.Customers.DeleteRangeByKey(anonymousObjects);
```

[Try it](https://dotnetfiddle.net/iB6UXD)

## Data Transfer Objects (DTOs)

You can also specify a list of DTO entities as a parameter.

```csharp
var customerDTO = context.Customers
    .Take(2)
    .Select(c => new CustomerDTO
    {
        CustomerID = c.CustomerID,
        Name = c.Name
    })
    .ToList();
			
context.Customers.DeleteByKey(customerDTO);
```

[Try it](https://dotnetfiddle.net/MXY1oW)

## Documentation

### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `DeleteRangeByKey<TEntity, T>(IEnumerable<T> entities)` | Deletes multiple entities by key in your database. | [Try it](https://dotnetfiddle.net/ONTPIs) |
| `DeleteRangeByKeyAsync<TEntity, T>(IEnumerable<T> entities)` | Deletes multiple entities by key in your database.  | |
| `DeleteRangeByKeyAsync<TEntity, T>(CancellationToken cancellationToken, IEnumerable<T> entities)` | Deletes multiple entities by key in your database. | |
