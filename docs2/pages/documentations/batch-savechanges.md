# Batch SaveChanges

---

## Limited Time Offer
For a limited time, the **BatchSaveChanges** is offered in a standalone version for only 79$.

[Buy now](/pricing-limited)

---

## Description

The Entity Framework `BatchSaveChanges` method is the fastest way to save a few or hundreds of entities.

The same sql in the same order as `SaveChanges` is used but batched in fewer commands to increase the performance.

```csharp
var affectedRows = context.BatchSaveChanges();
```
[Try it](https://dotnetfiddle.net/hHLUnp)

### Performance Comparison
_On average, people report a performance improvement of 500%._

| Operations       | 50 Entities  | 200 Entities | 500 Entities |
| :--------------- | -----------: | -----------: | -----------: |
| SaveChanges      | 65 ms        | 250 ms       | 600 ms       |
| BatchSaveChanges | 25 ms        | 50 ms        | 125 ms       |

[Try this benchmark online](https://dotnetfiddle.net/qCVyzm)

> HINT: A lot of factors might affect the benchmark time such as index, column type, latency, throttling, etc.

### What is supported?
- Entity Framework 6
- SQL Server/Azure

_EF Core and more provider support is under development_

## Getting Started

### Replace SaveChanges
Optimizing your performance is very easy, you simply need to replace `SaveChanges` by `BatchSaveChanges`:

```csharp
// var affectedRows = context.SaveChanges();
var affectedRows = context.BatchSaveChanges();
```
[Try it](https://dotnetfiddle.net/8f4foP)

### Override SaveChanges
Or you can also override the `SaveChanges` method to call `BatchSaveChanges` method instead:

```csharp
public class EntityContext : DbContext
{
    // ...code...
    
    public override int SaveChanges()
    {
        return this.BatchSaveChanges();
    }
}
```
[Try it](https://dotnetfiddle.net/I3h9XM)

## FAQ

### Why BatchSaveChanges is faster than SaveChanges?
The `SaveChanges` method makes 1 database round-trip for every **1** entitiy to save.

The `BatchSaveChanges` method makes 1 database round-trip for every **25** entities to save (Default Value).

So, if you need to save **100** entities:
- The `SaveChanges` method will execute **100** sql commands.
- The `BatchSaveChanges` method will execute **4** sql commands.

The same sql in the same order as `SaveChanges` is used but batched in fewer commands to increase the performance.

### Is BatchSaveChanges as fast as SaveChanges with one entity?

Under the hood, `BatchSaveChanges` use `SaveChanges` to save **1** entity (so, as fast!), but will outperform it by batching commands in all other cases.

We always recommend to use BatchSaveChanges.

### What is the difference between BatchSaveChanges and BulkSaveChanges?
For a few hundreds of entities or less, the **BatchSaveChanges** offers better performance then **BulkSaveChanges**.

However, the **BulkSaveChanges** is a more scalable method. So, it becomes faster than **BatchSaveChanges** when you start to save thousands of entities.

## Documentation

### BatchSaveChanges

###### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `BatchSaveChanges()` | Saves all changes made in this context to the underlying database by combining sql command generated. | [Try it](https://dotnetfiddle.net/kCl8oB) |
| `BatchSaveChangesAsync()` | Saves all changes asynchronously made in this context to the underlying database by combining sql command generated. | [Try it](https://dotnetfiddle.net/RF1oec) |
| `BatchSaveChangesAsync(cancellationToken)` | Saves all changes asynchronously made in this context to the underlying database by combining sql command generated. | [Try it](https://dotnetfiddle.net/gYTj7w) |
