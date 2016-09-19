# Improve Entity Framework performance with Bulk SaveChanges and Bulk Operations

Solve Entity Framework performance issue when saving with high performance bulk operations and hundred of flexibles feature.
 - BulkSaveChanges
 - BulkInsert
 - BulkUpdate
 - BulkDelete
 - BulkMerge
 - DeleteFromQuery
 - UpdateFromQuery

```csharp
var context = new CustomerContext();
// ... context code ...

// Easy to use
context.BulkSaveChanges();

// Easy to customize
context.BulkSaveChanges(operation => operation.BatchSize = 1000);
```

```csharp
// Perform specific bulk operations
context.BulkDelete(customers);
context.BulkInsert(customers);
context.BulkUpdate(customers);

// Customize Primary Key
context.BulkMerge(customers, operation => {
   operation.ColumnPrimaryKeyExpression = customer => customer.Code;
});
```

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
- Oracle

## Download
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-d.svg" alt="" /></a>

```
PM> Install-Package Z.EntityFramework.Extensions
```

_* PRO Version unlocked for the current month_

Stay updated with latest changes

<a href="https://twitter.com/zzzprojects" target="_blank"><img src="http://www.zzzprojects.com/images/twitter_follow.png" alt="Twitter Follow" height="24" /></a>
<a href="https://www.facebook.com/zzzprojects/" target="_blank"><img src="http://www.zzzprojects.com/images/facebook_like.png" alt="Facebook Like" height="24" /></a>

## BulkSaveChanges

##### Problem
You need to save hundreds or thousands of entities but you are not satisfied with Entity Framework performance.

##### Solution
BulkSaveChanges is exactly like SaveChanges but perform way faster. It’s easy to use, you only need to replace “SaveChanges” by “BulkSaveChanges” and you are done!

```
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
You need even more performance then BulkSaveChanges, save detached entities or save entities in a specific order.

##### Solution
Use bulk operations such as bulk insert, update, delete and merge which perform operation on specified entities and bypass the change tracker to increase performance.

```csharp
// Perform specific bulk operations on entities
context.BulkDelete(customers);
context.BulkInsert(customers);
context.BulkUpdate(customers);
context.BulkMerge(customers);
```

##### Maintainability
Bulk Operation use directly the Entity Framework Model. Even if you change column name or change inheritance (TPC, TPH, TPT), Bulk operation will continue to work as expected.

## Custom Key
##### Problem
You need to perform an update, delete or merge using a specific custom key like the custom code.

##### Solution
Specify your own key by customizing the operation.

```csharp
// Use flexible features such as specifying the primary key
context.BulkMerge(customers, operation => {
   operation.ColumnPrimaryKeyExpression = customer => customer.Code;
});
```

##### Flexibility
Bulk operations offers hundred of customization such as BatchSize, Custom Key, Custom Mapping, etc.

## PRO Version
_PRO Version unlocked for the current month_

Features                    | [PRO Version](http://entityframework-extensions.net/#pro)
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
Learn more about the **[PRO Version](http://entityframework-extensions.net/#pro)**

## Contribute
The best way to contribute is by **spreading the word** about the library:

 - Blog it
 - Comment it
 - Fork it
 - Star it
 - Share it
 
A **HUGE THANKS** for your help.

## More Projects

**Entity Framework**
- [EntityFramework Extensions](http://entityframework-extensions.net/)
- [EntityFramework Plus](http://entityframework-plus.net)

**Bulk Operations**
- [Bulk Operations](http://bulk-operations.net/)
- [Dapper Plus](http://dapper-plus.net/)

**Expression Evaluator**
- [Eval-SQL.NET](http://eval-sql.net/)
- [Eval-Expression.NET](http://eval-expression.net/)

**Others**
- [Extension Methods Library](https://github.com/zzzprojects/Z.ExtensionMethods/)
- [LINQ Async](https://github.com/zzzprojects/Linq-AsyncExtensions)

**Need more info?** info@zzzprojects.com

Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!
