[PROMOTION]

# Batch SaveChanges

## Description

The Entity Framework `BatchSaveChanges` method is the fastest way to save a few or hundreds of entities.

### But WHY it is faster?
The `SaveChanges` method make 1 database round-trip for every **1** entities to save.

The `BatchSaveChanges` method make 1 database round-trip for every **25** entities to save (Default Value).

So if you need to save **100** entities:
- The `SaveChanges` method will execute sql **100** commands
- The `BatchSaveChanges` method will do **4** commands

Lesser command to execute => Lesser database round-trips => Better performance => Happy Customer!

### The BEST of Both World
The `BatchSaveChanges` method have everything:
- As fast as `SaveChanges` with one entity
- Faster in all other cases

### What is supported?
- Entity Framework 6
- SQL Server

_EF Core and more provider support is under development_

### Getting Started

#### Replace SaveChanges
Optimizing your performance is very easy, you simply need to replace `SaveChanges` by `BatchSaveChanges`:

```csharp
// var affectedRows = context.SaveChanges();
var affectedRows = context.BatchSaveChanges();
```
[Try it](https://dotnetfiddle.net/hHLUnp)

#### Override SaveChanges
Or you can also override the `SaveChanges` method to call `BatchSaveChanges` method instead:

```csharp
// TODO: Add this code with a try it
// var affectedRows = context.SaveChanges();
var affectedRows = context.BatchSaveChanges();
```
[Try it](https://dotnetfiddle.net/hHLUnp)

### Performance Comparison
// TODO: Lower the number of entities, 100, 200 and 500!

How much our `BatchSaveChanges` could increase your application performance?

| Operations       | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :--------------- | -------------: | -------------: | -------------: |
| SaveChanges      | 1,200 ms       | 2,400 ms       | 6,000 ms       |
| BatchSaveChanges | 75 ms          | 150 ms         | 500 ms         |

[Try this benchmark online](https://dotnetfiddle.net/qCVyzm)

> HINT: A lot of factors might affect the benchmark time such as index, column type, latency, throttling, etc.

### FAQ

#### Why BatchSaveChanges is faster than SaveChanges?
The `SaveChanges` method make 1 database round-trip for every **1** entities to save.
The `BatchSaveChanges` method make 1 database round-trip for every **25** entities to save.

If you need to save 100 entities:
- The `SaveChanges` method will do **100** database round-trips
- The `BatchSaveChanges` method will do **4** database round-trips

#### When should I use BatchSaveChanges over SaveChanges?
We recommand to always use **BatchSaveChanges**, always!

Under the hood, `BatchSaveChanges` use `SaveChanges` to save **1** entity (so as fast!), but will outperform by batching command in all other cases.

#### What is the difference between BatchSaveChanges and BulkSaveChanges?
The **BatchSaveChanges** is great!

However, batching command


`BatchSaveChanges` becomes slower and slower in comparison to `BulkSaveChanges` when the number of entities to save grows due to the `ChangeTracker`.

After a few thousand of entities, we recommend using `BulkSaveChanges` which is a more scalable solution. But be aware, the SQL used is no longer the same as `SaveChanges`.

## Documentation

### BatchSaveChanges

###### Methods

| Name | Description | Example |
| :--- | :---------- | :------ |
| `BatchSaveChanges()` | Saves all changes made in this context to the underlying database by combining sql command generated. | [Try it](https://dotnetfiddle.net/kCl8oB) |
| `BatchSaveChangesAsync()` | Saves all changes asynchronously made in this context to the underlying database by combining sql command generated. | |
| `BatchSaveChangesAsync(cancellationToken)` | Saves all changes asynchronously made in this context to the underlying database by combining sql command generated. | |

## Limitations

- Support EF6 only
- Support SQL Server only

_EF Core and more provider are under development._

## Limited Time Offer
For a limited time, the **BatchSaveChanges** is offer in a standalone version for only 79$
