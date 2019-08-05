# Bulk Delete

## Description

The EF `BulkDelete` extension method let you delete a large number of entities in your database.

```csharp
// Easy to use
context.BulkDelete(customers);

// Easy to customize
context.BulkDelete(customers, options => options.BatchSize = 100);
```
[Try it in EF6](https://dotnetfiddle.net/ESKZJq) | [Try it in EF Core](https://dotnetfiddle.net/BCyXU6)

### Performance Comparison

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,200 ms       | 2,400 ms       | 6,000 ms       |
| BulkDelete      | 50 ms          | 55 ms          | 75 ms         |

[Try it](https://dotnetfiddle.net/qYjiA9)

> HINT: A lot of factors might affect the benchmark time such as index, column type, latency, throttling, etc.

### Scenarios
The `BulkDelete` method is **fast** but also **flexible** to let you handle various scenarios in Entity Framework such as:

- [Delete with custom key](#delete-with-custom-key)
- [Delete with future action](#delete-with-future-action)
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

### Bulk Delete
The `BulkDelete` and `BulkDeleteAync` methods extend your `DbContext` to let you delete a large number of entities in your database.

```csharp
context.BulkDelete(customers);

context.BulkDeleteAsync(customers, cancellationToken);
```
[Try it in EF6](https://dotnetfiddle.net/10nw7a) | [Try it in EF Core](https://dotnetfiddle.net/EO0Z1R)

### Bulk Delete with options
The `options` parameter let you use a lambda expression to customize the way entities are deleted.

```csharp
context.BulkDelete(customers, options => options.BatchSize = 100);
```
[Try it in EF6](https://dotnetfiddle.net/ygZVAu) | [Try it in EF Core](https://dotnetfiddle.net/lIUiH2)

### Why BulkDelete is faster than SaveChanges?
Deleting thousands of entities for a file importation is a typical scenario.

The `SaveChanges` method makes it quite impossible to handle this kind of situation due to the number of database round-trips required. The `SaveChanges` perform one database round-trip for every entity to delete. So if you need to delete 10,000 entities, 10,000 database round-trips will be performed which is **INSANELY** slow.

The `BulkDelete` in counterpart requires the minimum database round-trips as possible. For example under the hood for SQL Server, a `SqlBulkCopy` is performed first in a temporary table, then a `DELETE` from the temporary table to the destination table is performed which is the fastest way available.

## Real Life Scenarios

### Delete with custom key
You want to delete entities, but you don't have the primary key. The `ColumnPrimaryKeyExpression` let you use as a key any property or combination of properties.

```csharp
context.BulkDelete(customers, options => options.ColumnPrimaryKeyExpression = c => c.Code);    
```
[Try it in EF6](https://dotnetfiddle.net/9M6bKt) | [Try it in EF Core](https://dotnetfiddle.net/91wZzc)

### Delete with future action
You want to delete entities, but you want to defer the execution.

By default, `BulkDelete` is an immediate operation. That mean, it's executed as soon as you call the method.

`FutureAction`: This option let you defer the execution of a Bulk Delete.
`ExecuteFutureAction`: This option trigger and execute all pending `FutureAction`.

```csharp
context.FutureAction(x => x.BulkDelete(customers1));
context.FutureAction(x => x.BulkDelete(customers2));

// ...code...

context.ExecuteFutureAction();
```
[Try it in EF6](https://dotnetfiddle.net/KovTrj) | [Try it in EF Core](https://dotnetfiddle.net/V6KsSl)

### More scenarios
Hundreds of scenarios have been solved and are now supported.

The best way to ask for a special request or to find out if a solution for your scenario already exists is by contacting us:
info@zzzprojects.com

## Documentation

### BulkDelete

###### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `BulkDelete<T>(items)` | Bulk delete entities in your database. | [EF6](https://dotnetfiddle.net/4Jv1H6) / [EFCore](https://dotnetfiddle.net/gwc9hl)|
| `BulkDelete<T>(items, options)` | Bulk delete entities in your database.  | [EF6](https://dotnetfiddle.net/IedG1h) / [EFCore](https://dotnetfiddle.net/Qek2MJ) |
| `BulkDeleteAsync<T>(items)` | Bulk delete entities asynchronously in your database. | |
| `BulkDeleteAsync<T>(items, cancellationToken)` | Bulk delete entities asynchronously in your database. | |
| `BulkDeleteAsync<T>(items, options, cancellationToken)` | Bulk delete entities asynchronously in your database. | |

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
