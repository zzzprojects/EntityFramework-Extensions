# Bulk Update

## Description

The EF `BulkUpdate` extension method let you update a large number of entities in your database.

```csharp
// Easy to use
context.BulkUpdate(customers);

// Easy to customize
context.BulkUpdate(customers, options => options.IncludeGraph = true);
```
[Try it in EF6](https://dotnetfiddle.net/5wBlVh) | [Try it in EF Core](https://dotnetfiddle.net/Cwn8NC)

### Performance Comparison

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,200 ms       | 2,400 ms       | 6,000 ms       |
| BulkUpdate      | 80 ms          | 110 ms         | 170 ms         |

[Try it](https://dotnetfiddle.net/xVwYDE)

> HINT: A lot of factors might affect the benchmark time such as index, column type, latency, throttling, etc.

### Scenarios
The `BulkUpdate` method is **fast** but also **flexible** to let you handle various scenarios in Entity Framework such as:

- [Update and include/exclude properties](#update-and-includeexclude-properties)
- [Update with custom key](#update-with-custom-key)
- [Update with related child entities (Include Graph)](#update-with-related-child-entities-include-graph)
- [Update with future action](#update-with-future-action)
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

### Bulk Update
The `BulkUpdate` and `BulkUpdateAync` methods extend your `DbContext` to let you update a large number of entities in your database.

```csharp
context.BulkUpdate(customers);

context.BulUpdateAsync(customers, cancellationToken);
```
[Try it in EF6](https://dotnetfiddle.net/81oBov) | [Try it in EF Core](https://dotnetfiddle.net/zmsc2T)

### Bulk Update with options
The `options` parameter lets you use a lambda expression to customize the way entities are updated.

```csharp
context.BulkUpdate(customers, options => options.ColumnPrimaryKeyExpression = c => c.Code });
```
[Try it in EF6](https://dotnetfiddle.net/yw6M79) | [Try it in EF Core](https://dotnetfiddle.net/BW6WIy)

### Why BulkUpdate is faster than SaveChanges?
Updating thousands of entities for a file importation is a typical scenario.

The `SaveChanges` method makes it quite impossible to handle this kind of situation due to the number of database round-trips required. The `SaveChanges` perform one database round-trip for every entity to update. So, if you need to update 10,000 entities, 10,000 database round-trips will be performed which is **INSANELY** slow.

The `BulkUpdate` in counterpart requires the minimum database round-trips as possible. For example under the hood for SQL Server, a `SqlBulkCopy` is performed first in a temporary table, then an `UPDATE` from the temporary table to the destination table is performed which is the fastest way available.

## Real Life Scenarios

### Update and include/exclude properties
You want to update your entities but only for specific properties.

- `IgnoreOnUpdateExpression`: This option lets you ignore properties that are auto-mapped.

```csharp            
context.BulkUpdate(customers, options => options.IgnoreOnUpdateExpression = c => new { c.ColumnToIgnore } );
```
[Try it in EF6](https://dotnetfiddle.net/R43wS0) | [Try it in EF Core](https://dotnetfiddle.net/Enr2KP)

### Update with custom key
You want to update entities, but you don't have the primary key. The `ColumnPrimaryKeyExpression` let you use as a key any property or combination of properties.

```csharp
context.BulkUpdate(customers, options => options.ColumnPrimaryKeyExpression = c => c.Code);    
```
[Try it in EF6](https://dotnetfiddle.net/La7vr8) | [Try it in EF Core](https://dotnetfiddle.net/YasxiY)

### Update with related child entities (Include Graph)
You want to update entities but also automatically insert related child entities.

- `IncludeGraph`: This option lets you to automatically update all entities part of the graph.
- `IncludeGraphBuilder`: This option lets you customize how to update entities for a specific type.

```csharp
context.BulkUpdate(invoices, options => options.IncludeGraph = true);
```
[Try it in EF6](https://dotnetfiddle.net/PAVo4c) | [Try it in EF Core](https://dotnetfiddle.net/Iciz2K)

### Update with future action
You want to update entities, but you want to defer the execution.

By default, `BulkUpdate` is an immediate operation. That mean, it's executed as soon as you call the method.

`FutureAction`: This option lets you defer the execution of a Bulk Update.
`ExecuteFutureAction`: This option trigger and execute all pending `FutureAction`.

```csharp
context.FutureAction(x => x.BulkUpdate(customers));
context.FutureAction(x => x.BulkUpdate(invoices, options => options.IncludeGraph = true));

// ...code...

context.ExecuteFutureAction();
```
[Try it in EF6](https://dotnetfiddle.net/YnV5Fs) | [Try it in EF Core](https://dotnetfiddle.net/i9pMsP)

### More scenarios
Hundreds of scenarios have been solved and are now supported.

The best way to ask for a special request or to find out if a solution for your scenario already exists is by contacting us:
info@zzzprojects.com

## Documentation

### BulkUpdate

###### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `BulkUpdate<T>(items)` | Bulk update entities in your database. | [EF6](https://dotnetfiddle.net/XbT4Ad) / [EFCore](https://dotnetfiddle.net/1SMtjq)|
| `BulkUpdate<T>(items, options)` | Bulk update entities in your database.  | [EF6](https://dotnetfiddle.net/6E5DYO) / [EFCore](https://dotnetfiddle.net/WhC2bb)|
| `BulkUpdateAsync<T>(items)` | Bulk update entities asynchronously in your database. | |
| `BulkUpdateAsync<T>(items, cancellationToken)` | Bulk update entities asynchronously in your database. | |
| `BulkUpdateAsync<T>(items, options, cancellationToken)` | Bulk update entities asynchronously in your database. | |

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
