# Bulk Synchronize

## Description

The EF `BulkSynchronize` extension method let you synchronize a large number of entities in your database.

A synchronize is a mirror operation from the data source to the database. All rows that match the entity key are `UPDATED`, non-matching rows that exist from the source are `INSERTED`, non-matching rows that exist in the database are `DELETED`.

```csharp
// Easy to use
context.BulkSynchronize(customers);

// Easy to customize
context.BulkSynchronize(customers, options => {
    options.ColumnPrimaryKeyExpression = customer => customer.Code;
});
```
[Try it](https://dotnetfiddle.net/nZedku)

### Scenarios
The `BulkSynchronize` method is **fast** but also **flexible** to let you handle various scenarios in Entity Framework such as:
- [Synchronize and keep identity value](#synchronize-and-keep-identity-value)
- [Synchronize and include/exclude properties](#synchronize-and-includeexclude-properties)
- [Synchronize with custom key](#synchronize-with-custom-key)
- [Synchronize with future action](#synchronize-with-future-action)
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

### Bulk Synchronize
The `BulkSynchronize` and `BulkSynchronizeAync` methods extend your `DbContext` to let you synchronize a large number of entities in your database.

```csharp
context.BulkSynchronize(customers);

context.BulkSynchronizeAsync(customers, cancellationToken);
```
[Try it](https://dotnetfiddle.net/yPs4WF)

### Bulk Synchronize with options
The `options` parameter let you use a lambda expression to customize the way entities are inserted.

```csharp
context.BulkSynchronize(customers, options => options.BatchSize = 100);

context.BulkSynchronize(customers, options => {
    options.ColumnPrimaryKeyExpression = customer => customer.Code;
});
```
[Try it](https://dotnetfiddle.net/FX3Quf)

## Real Life Scenarios

### Synchronize and keep identity value
Your entity has an identity property, but you want to force to insert a specific value instead. The `SynchronizeKeepIdentity` option allows you to keep the identity value of your entity.

```csharp
context.BulkSynchronize(customers, options => options.SynchronizeKeepIdentity = true);
```
[Try it](https://dotnetfiddle.net/crxeJ3)

### Synchronize and include/exclude properties
You want to insert your entities but only for specific properties.

- `ColumnInputExpression`: This option let you choose which properties to map.
- `IgnoreOnSynchronizeInsertExpression`: This option let you ignore when inserting properties that are auto-mapped.
- `IgnoreOnSynchronizeUpdateExpression`: This option let you ignore when updating properties that are auto-mapped.

```csharp
context.BulkSynchronize(customizeToSynchronize, options => {
    options.IgnoreOnSynchronizeInsertExpression = c => c.UpdatedDate;
    options.IgnoreOnSynchronizeUpdateExpression = c => c.CreatedDate;
});
```
[Try it](https://dotnetfiddle.net/mOlppr)

### Synchronize with custom key
You want to synchronize entities, but you don't have the primary key. The `ColumnPrimaryKeyExpression` let you use as a key any property or combination of properties.

```csharp
context.BulkSynchronize(customers, options => options.ColumnPrimaryKeyExpression = c => c.Code);    
```
[Try it](https://dotnetfiddle.net/PYjmAJ)

### Synchronize with future action
You want to synchronize entities, but you want to defer the execution.

By default, `BulkSynchronize` is an immediate operation. That mean, it's executed as soon as you call the method.

`FutureAction`: This option let you defer the execution of a Bulk Synchronize.
`ExecuteFutureAction`: This option trigger and execute all pending `FutureAction`.

```csharp
context.FutureAction(x => x.BulkSynchronize(customers));
context.FutureAction(x => x.BulkSynchronize(invoices));

// ...code...

context.ExecuteFutureAction();
```
[Try it](https://dotnetfiddle.net/78FeXe)

### More scenarios
Hundred of scenarios has been solved and are now supported.

The best way to ask for a special request or to find out if a solution for your scenario already exists is by contacting us:
info@zzzprojects.com

## Documentation

### BulkInsert

###### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `BulkSynchronize<T>(items)` | Bulk synchronize entities in your database. | [Try it](https://dotnetfiddle.net/rYYc4V) |
| `BulkSynchronize<T>(items, options)` | Bulk synchronize entities in your database.  | [Try it](https://dotnetfiddle.net/D1GBYP) |
| `BulkSynchronizeAsync<T>(items)` | Bulk synchronize entities asynchronously in your database. | |
| `BulkSynchronizeAsync<T>(items, cancellationToken)` | Bulk synchronize entities asynchronously in your database. | |
| `BulkSynchronizeAsync<T>(items, options, cancellationToken)` | Bulk synchronize entities asynchronously in your database. | |

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
