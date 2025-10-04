# What's Entity Framework Extensions? 

Entity Framework Extensions is a library that dramatically improves EF performances by using bulk and batch operations.

People using this library often report performance enhancement by 50x times and more!

## Improve Entity Framework performance with Bulk SaveChanges and Bulk Operations

Solve Entity Framework performance issue when saving with high performance bulk operations and hundreds of flexibles feature.
 - BulkSaveChanges
 - BulkInsert
 - BulkUpdate
 - BulkDelete
 - BulkMerge
 - DeleteFromQuery
 - UpdateFromQuery

```csharp
// @nuget: Z.EntityFramework.Extensions.EFCore
using Z.EntityFramework.Extensions;

var context = new CustomerContext();
// ... context code ...

// Easy to use
context.BulkSaveChanges();

// Easy to customize
context.BulkSaveChanges(operation => operation.BatchSize = 1000);
```

```csharp
// @nuget: Z.EntityFramework.Extensions.EFCore
using Z.EntityFramework.Extensions;

// Perform specific bulk operations
context.BulkDelete(customers);
context.BulkInsert(customers);
context.BulkUpdate(customers);

// Customize Primary Key
context.BulkMerge(customers, operation => {
   operation.ColumnPrimaryKeyExpression = customer => customer.Code;
});
```

## 📊 Benchmark Results

We provide extensive benchmarks to demonstrate the performance improvements of **Entity Framework Extensions** compared to EF Core.

You can browse them either **by database provider** or **by operation**:

### 🔹 Benchmarks by Provider
- [EF Core – SQL Server](benchmark-result/efcore-sqlserver.md)  
- [EF Core – PostgreSQL](benchmark-result/efcore-postgresql.md)  
- [EF Core – MySQL](benchmark-result/efcore-mysql.md)  
- [EF Core – MariaDB](benchmark-result/efcore-mariadb.md)  
- [EF Core – Oracle](benchmark-result/efcore-oracle.md)  
- [EF Core – SQLite](benchmark-result/efcore-sqlite.md)  

### 🔹 Benchmarks by Operation
- [Bulk Insert](benchmark-result/efcore-bulk-insert.md)  
- [Bulk Update](benchmark-result/efcore-bulk-update.md)  
- [Bulk Delete](benchmark-result/efcore-bulk-delete.md)  
- [Bulk Merge](benchmark-result/efcore-bulk-merge.md)  
- [Bulk SaveChanges](benchmark-result/efcore-bulk-savechanges.md)  
- [Bulk Synchronize](benchmark-result/efcore-bulk-synchronize.md)  

📌 Each page includes detailed charts (execution time and memory usage) generated with **BenchmarkDotNet** across multiple scenarios.  

##### Scalable
SQL Server - Benchmarks

| Operations         | 100 Rows | 1,000 Rows | 10,000 Rows |
| ------------------ | -------: | ---------: | ----------: |
|**BulkSaveChanges** | 20 ms    | 200 ms     | 2,000 ms    |
|**BulkInsert**      | 2 ms     | 6 ms       | 25 ms       |
|**BulkUpdate**      | 27 ms    | 50 ms      | 80 ms       |
|**BulkDelete**      | 25 ms    | 45 ms      | 70 ms       |
|**BulkMerge**       | 30 ms    | 65 ms      | 160 ms      |

##### Extensible
Support Multiple SQL Providers:
- SQL Server 2008+
- SQL Azure
- SQL Compact
- MySQL
- SQLite
- PostgreSQL
- Oracle

## Download

### Entity Framework Core (EF Core)
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-efcore-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-efcore-d.svg" alt="" /></a>

```
PM> Install-Package Z.EntityFramework.Extensions.EFCore
```

### Entity Framework 6 (EF6)
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-d.svg" alt="" /></a>

```
PM> Install-Package Z.EntityFramework.Extensions
```

### Entity Framework 5 (EF5)
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF5/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-ef5-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF5/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-ef5-d.svg" alt="" /></a>

```
PM> Install-Package Z.EntityFramework.Extensions.EF5
```

_* PRO Version unlocked for the current month_

## BulkSaveChanges

##### Problem
You need to save hundreds or thousands of entities, but you are not satisfied with Entity Framework performance.

##### Solution
BulkSaveChanges is exactly like SaveChanges but performs way faster. It’s easy to use, you only need to replace “SaveChanges” by “BulkSaveChanges”, and you are done!

```
// @nuget: Z.EntityFramework.Extensions.EFCore
using Z.EntityFramework.Extensions;

// Upgrade SaveChanges performance with BulkSaveChanges
var context = new CustomerContext();
// ... context code ...

// Easy to use
context.BulkSaveChanges();

// Easy to customize
context.BulkSaveChanges(operation => operation.BatchSize = 1000);
```

##### Scalability
BulkSaveChanges is as fast as SaveChanges with one entity and quickly become **10-50x faster** with hundreds and thousands of entities.

## Bulk Operations
##### Problem
You need even more performance than BulkSaveChanges, save detached entities or save entities in a specific order.

##### Solution
Use bulk operations such as bulk insert, update, delete and merge which perform operations on specified entities and bypass the change tracker to increase performance.

```csharp
// @nuget: Z.EntityFramework.Extensions.EFCore
using Z.EntityFramework.Extensions;

// Perform specific bulk operations on entities
context.BulkDelete(customers);
context.BulkInsert(customers);
context.BulkUpdate(customers);
context.BulkMerge(customers);
```

##### Maintainability
Bulk Operation directly uses the Entity Framework Model. Even if you change column name or change inheritance (TPC, TPH, TPT), Bulk Operation will continue to work as expected.

## Custom Key
##### Problem
You need to perform an update, delete, or merge using a specific custom key like the custom code.

##### Solution
Specify your own key by customizing the operation.

```csharp
// @nuget: Z.EntityFramework.Extensions.EFCore
using Z.EntityFramework.Extensions;

// Use flexible features such as specifying the primary key
context.BulkMerge(customers, operation => {
   operation.ColumnPrimaryKeyExpression = customer => customer.Code;
});
```

##### Flexibility
Bulk operations offer hundreds of customization such as BatchSize, Custom Key, Custom Mapping, etc.

## PRO Version
_PRO Version unlocked for the current month_

Features                    | [PRO Version](https://entityframework-extensions.net/#pro)
--------                    | :-------------:
Bulk SaveChanges            | Yes
Bulk Insert                 | Yes
Bulk Update                 | Yes
Bulk Delete                 | Yes
Bulk Merge                  | Yes
DeleteFromQuery             | Yes
UpdateFromQuery             | Yes
Commercial License          | Yes
Royalty-Free                | Yes
Support & Upgrades (1 year) | Yes
Learn more about the **[PRO Version](https://entityframework-extensions.net/#pro)**

## Contribute

The best way to contribute is by **spreading the word** about the library:

 - Blog it
 - Comment it
 - Star it
 - Share it
 
A **HUGE THANKS** for your help.

## More Projects

- Projects:
   - [EntityFramework Extensions](https://entityframework-extensions.net/)
   - [Dapper Plus](https://dapper-plus.net/)
   - [C# Eval Expression](https://eval-expression.net/)
- Learn Websites
   - [Learn EF Core](https://www.learnentityframeworkcore.com/)
   - [Learn Dapper](https://www.learndapper.com/)
- Online Tools:
   - [.NET Fiddle](https://dotnetfiddle.net/)
   - [SQL Fiddle](https://sqlfiddle.com/)
   - [ZZZ Code AI](https://zzzcode.ai/)
- and much more!

To view all our free and paid projects, visit our website [ZZZ Projects](https://zzzprojects.com/).
