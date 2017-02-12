---
layout: default
title: SqlBulkCopy - SQLite
permalink: sqlite
---

{% include template-h1.html %}

## Problem

You found out SqlBulkCopy is not supported for MySql.

But you still want to know what's the **fastest way to insert** in MySql using one theses providers:

## Solution
Proposed solution:

- [Prepared Command and Transaction](#solution---prepared-command-and-transaction)
- [.NET Bulk Operations](#solution---net-bulk-operations-with-sqlite)

## Solution - Prepared Command and Transaction
There is not a lot of technique available for SQLite.

Use prepared command will for sure help but using a transaction make all the difference.

{% include template-example.html %} 
{% highlight csharp %}
// TBD

{% endhighlight %}

## Solution - .NET Bulk Operations with SQLite
That is the **fastest** (use derived table under the hood) and **easiest** solution.

Even more, all bulk operations are supported:

- BulkInsert
- BulkUpdate
- BulkDelete
- BulkMerge

{% include template-example.html %} 
{% highlight csharp %}

// Easy to use
var bulk = new BulkOperation(connection);
bulk.BulkInsert(dt);
bulk.BulkUpdate(dt);
bulk.BulkDelete(dt);
bulk.BulkMerge(dt);

// Easy to customize
var bulk = new BulkOperation<Customer>(connection);
bulk.BatchSize = 1000;
bulk.ColumnInputExpression = c => new { c.Name,  c.FirstName };
bulk.ColumnOutputExpression = c => c.CustomerID;
bulk.ColumnPrimaryKeyExpression = c => c.Code;
bulk.BulkMerge(customers);

{% endhighlight %}

