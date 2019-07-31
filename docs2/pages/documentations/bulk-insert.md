# Bulk Insert

## Description

The EF `BulkInsert` extension method let you insert a large number of entities in your database.

```csharp
// Easy to use
context.BulkInsert(customers);

// Easy to customize
context.BulkInsert(invoices, options => options.IncludeGraph = true);
```
[Try it in EF6](https://dotnetfiddle.net/bNektu) | [Try it in EF Core](https://dotnetfiddle.net/2eVfFT)

### Performance Comparison

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,200 ms       | 2,400 ms       | 6,000 ms       |
| BulkInsert      | 50 ms          | 55 ms          | 75 ms          |

[Try this benchmark online](https://dotnetfiddle.net/pSpD10)

> HINT: A lot of factors might affect the benchmark time such as index, column type, latency, throttling, etc.

### Scenarios
The `BulkInsert` method is **fast** but also **flexible** to let you handle various scenarios in Entity Framework such as:
- [Insert and keep identity value](#insert-and-keep-identity-value)
- [Insert and include/exclude properties](#insert-and-includeexclude-properties)
- [Insert only if the entity not already exists](#insert-only-if-the-entity-not-already-exists)
- [Insert with related child entities (Include Graph)](#insert-with-related-child-entities-include-graph)
- [Insert with future action](#insert-with-future-action)
- [Insert without returning identity value](#insert-without-returning-identity-value)
- [More scenarios](#more-scenarios)

### What is supported?
- All Entity Framework versions (EF4, EF5, EF6, EF Core, [EF Classic](https://entityframework-classic.net/))
- All Inheritances (TPC, TPH, TPT)
- Complex Type/Owned Entity Type
- Enum
- Value Converter (EF Core)
- And more!

### Advantages
- Easy to use
- Flexible
- Increase performance
- Increase application responsiveness
- Reduce database load
- Reduce database round-trips

## Getting Started

### Bulk Insert
The `BulkInsert` and `BulkInsertAync` methods extend your `DbContext` to let you insert a large number of entities in your database.

```csharp
context.BulkInsert(customers);

context.BulkInsertAsync(customers, cancellationToken);
```
[Try it](https://dotnetfiddle.net/4xB7Tf)

### Bulk Insert with options
The `options` parameter let you use a lambda expression to customize the way entities are inserted.

```csharp
context.BulkInsert(customers, options => options.BatchSize = 100);

context.BulkInsert(customers, options => { 
    options.InsertIfNotExists = true;
    options.PrimaryKeyExpression = customer => customer.Code;
  });
```
[Try it](https://dotnetfiddle.net/9rUgry)

### Why BulkInsert is faster than SaveChanges?
Inserting thousands of entities for an initial load or a file importation is a typical scenario.

The `SaveChanges` method makes it quite slow/impossible to handle this kind of situation due to the number of database round-trips required. The `SaveChanges` perform one database round-trip for every entity to insert. So if you need to insert 10,000 entities, 10,000 database round-trips will be performed which is **INSANELY** slow.

The `BulkInsert` in counterpart requires the minimum database round-trips as possible. For example, under the hood for SQL Server, a `SqlBulkCopy` is performed to insert 10,000 entities which is the fastest way available.

## Real Life Scenarios

### Insert and keep identity value
Your entity has an identity property, but you want to force to insert a specific value instead. The `InsertKeepIdentity` option allows you to keep the identity value of your entity.

```csharp
context.BulkInsert(customers, options => options.InsertKeepIdentity = true);
```
[Try it](https://dotnetfiddle.net/JJeqbn)

### Insert and include/exclude properties
You want to insert your entities but only for specific properties.

- `ColumnInputExpression`: This option let you choose which properties to map.
- `IgnoreOnInsertExpression`: This option let you ignore properties that are auto-mapped.

```csharp
context.BulkInsert(customers, options => options.ColumnInputExpression = c => new { c.CustomerID, c.Name} );
            
context.BulkInsert(customers, options => options.IgnoreOnInsertExpression = c => new { c.ColumnToIgnore } );
```
[Try it](https://dotnetfiddle.net/TUyT7A)

### Insert only if the entity not already exists
You want to insert entities but only those that don't already exist in the database.

- `InsertIfNotExists`: This option let you insert only entity that doesn't already exists.
- `PrimaryKeyExpression`: This option let you customize the key to use to check if the entity already exists or not.

```csharp
context.BulkInsert(customers, options => {
    options.InsertIfNotExists = true;
    options.ColumnPrimaryKeyExpression = c => c.Code;
});
```
[Try it](https://dotnetfiddle.net/Etc2k7)

### Insert with related child entities (Include Graph)
You want to insert entities but also automatically insert related child entities.

- `IncludeGraph`: This option lets you to automatically insert all entities part of the graph.
- `IncludeGraphBuilder`: This option lets you customize how to insert entities for a specific type.

```csharp
context.BulkInsert(invoices, options => options.IncludeGraph = true);
```
[Try it](https://dotnetfiddle.net/geInHT)

### Insert with future action
You want to insert entities, but you want to defer the execution.

By default, `BulkInsert` is an immediate operation. That mean, it's executed as soon as you call the method.

`FutureAction`: This option let you defer the execution of a Bulk Insert.
`ExecuteFutureAction`: This option trigger and execute all pending `FutureAction`.

```csharp
context.FutureAction(x => x.BulkInsert(customers));
context.FutureAction(x => x.BulkInsert(invoices, options => options.IncludeGraph = true));

// ...code...

context.ExecuteFutureAction();
```
[Try it](https://dotnetfiddle.net/Ju3ReL)

### Insert without returning identity value
By default, the EF `BulkInsert` method already returns the identity when inserting.

However, such behavior impacts performance. For example, when the identity must be returned, a temporary table is created in SQL Server instead of directly using `SqlBulkCopy` into the destination table.

You can improve your performance by turning off the `AutoMapOutput` option.

```csharp
context.BulkInsert(customers, options => options.AutoMapOutputDirection = false);
```
[Try it](https://dotnetfiddle.net/Ld0l03)

### More scenarios
Hundreds of scenarios have been solved and are now supported.

The best way to ask for a special request or to find out if a solution for your scenario already exists is by contacting us:
info@zzzprojects.com

## Documentation

### BulkInsert

###### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `BulkInsert<T>(items)` | Bulk insert entities in your database. | [Try it](https://dotnetfiddle.net/ShIYXu) |
| `BulkInsert<T>(items, options)` | Bulk insert entities in your database.  | [Try it](https://dotnetfiddle.net/NBVSTZ) |
| `BulkInsertAsync<T>(items)` | Bulk insert entities asynchronously in your database. | |
| `BulkInsertAsync<T>(items, cancellationToken)` | Bulk insert entities asynchronously in your database. | |
| `BulkInsertAsync<T>(items, options, cancellationToken)` | Bulk insert entities asynchronously in your database. | |

###### Options
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

## Limitations

### Hidden Navigation
The `BulkInsert` doesn't use the ChangeTracker to optimize the performance unless no other alternative exists.

For example, you want to insert `InvoiceItem` but there is no relation toward the parent `Invoice`. In this case, you will need to add your entities in the `ChangeTracker`. The `ChangeTracker` will be used to find the related `Invoice` for your `InvoiceItem`.

```csharp
try
{
    context.BulkInsert(items);
}
catch
{
    Console.WriteLine("An error is throw because the Invoice relation cannot be found.");
}

context.Invoices.AddRange(invoices);

// The ChangeTracker is used for this case
context.BulkInsert(items);
```
[Try it](https://dotnetfiddle.net/vKlII0)
