# Bulk SaveChanges

## Description

The EF `BulkSaveChanges` extension method execute bulk operations from entries to save.

```csharp
// Easy to use
context.BulkSaveChanges();

// Easy to customize
context.BulkSaveChanges(options => options.BatchSize = 100);
```
[Try it in EF6](https://dotnetfiddle.net/MP65WH)       [Try it in EF Core](https://dotnetfiddle.net/4nbecz)

### Performance Comparison

| Operations       | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :--------------- | -------------: | -------------: | -------------: |
| SaveChanges      | 1,200 ms       | 2,400 ms       | 6,000 ms       |
| BatchSaveChanges | 150 ms         | 225 ms         | 500 ms         |

[Try this benchmark online](https://dotnetfiddle.net/4FLmNE)

> HINT: A lot of factors might affect the benchmark time such as index, column type, latency, throttling, etc.

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
- Increase application responsivness
- Reduce database load
- Reduce database round-trips

### FAQ

#### Why BatchSaveChanges is faster than SaveChanges?
The `SaveChanges` method makes it quite slow/impossible to handle a scenario that requires to save a lot of entities due to the number of database round-trips required. The `SaveChanges` perform one database round-trip for every entity to insert. So, if you need to insert 10,000 entities, 10,000 database round-trips will be performed which is **INSANELY** slow.

The `BulkSaveChanges` in counterpart requires the minimum database round-trips as possible. By using Bulk Operations, fewer commands are executed which lead to better performance.

#### When should I use BulkSaveChanges over SaveChanges?
Whenever you have more than one entity to save. The `BulkSaveChanges` is almost as fast as the `SaveChanges` for one entity, but becomes way faster as the number of entities to save grows.

#### When should I use BulkSaveChanges over BatchSaveChanges?
`BatchSaveChanges` become slower and slower in comparisons to `BulkSaveChanges` when the number of entities to save grows due to the `ChangeTracker`.

After a few thousands of entities, we recommend using `BulkSaveChanges` which is a more scalable solution.

## Documentation

### BatchSaveChanges

###### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `BulkSaveChanges()` | Save all changes made in this context to the underlying database by executing bulk operations. | [Try it](https://dotnetfiddle.net/nKd0mT) |
| `BulkSaveChanges(Action<BulkOperation> bulkOperationFactory)` | Save all changes made in this context to the underlying database by executing bulk operations. | [Try it](https://dotnetfiddle.net/lJVdXR) |
| `BulkSaveChanges(bool useEntityFrameworkPropagation)` | Save all changes made in this context to the underlying database by executing bulk operations. | [Try it](https://dotnetfiddle.net/ZWNQPA) |
| `BulkSaveChanges(bool useEntityFrameworkPropagation, Action<BulkOperation> bulkOperationFactory)` | Save all changes made in this context to the underlying database by executing bulk operations. | [Try it](https://dotnetfiddle.net/Aqp0EK) |
| `BulkSaveChangesAsync(...)` | Save all changes asynchronously made in this context to the underlying database by executing bulk operations. | |

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
