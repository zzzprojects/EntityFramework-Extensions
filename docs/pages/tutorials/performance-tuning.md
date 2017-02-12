---
layout: default
title: Entity Framework Extensions - Performance Turning
permalink: performance-tuning
---

{% include template-h1.html %}

## Introduction

Entity Framework Extensions is very fast but also very flexible. Almost all options can be configured.

## Global/Instance Setting
Set your configurationg globally (for all instances) or by instance.

{% include template-example.html %} 
{% highlight csharp %}
// Set Global Configuration
BulkOperationManager.BulkOperationBuilder = operation => operation.BatchSize = 1000;

// Set Instance Configuration
context.BulkSaveChanges(operation => operation.BatchSize = 100);
{% endhighlight %}

## Batch
Customize how batch is handled to increase performance.

**Properties:**
- BatchSize
- BatchTimeout
- BatchDelayInterval

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(operation =>
{
   // Increasing/Decreasing the value affects the performance
   // There is no perfect value, it depends on column, trigger, index, etc.
   operation.BatchSize = 100; // Default value = 10,000 for SQL Server

   // Specify the timeout for a batch
   operation.BatchTimeout = 180; // seconds, default value = 15s

   // Specify the delay between  batch executions
   operation.BatchDelayInterval = 100; // milliseconds, default value = 0
});
{% endhighlight %}

## Temporary Table
Customize how and when to use a temporary table instead of inline SQL.

**Properties:**
- TemporaryTableBatchByTable
- TemporaryTableInsertBatchSize
- TemporaryTableMinRecord
- TemporaryTableUseTableLock

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(operation =>
{
   // Specify how many batch a temporary table must contain
   bulk.TemporaryTableBatchByTable = 5; // Default value = 0 (infinite)

   // Can increase/decrease performance depending on the number of columns
   bulk.TemporaryTableInsertBatchSize = 1000; // Default value = 10,000

   // Increasing the value may improve performance for sources with few records
   bulk.TemporaryTableMinRecord = 15; // Default value = 10

   // Using TableLock may increase performance but also increase row lock
   bulk.TemporaryTableUseTableLock = true; // Default value = false
});
{% endhighlight %}

## SQL Server Options
Customize how SqlBulkCopy should be used

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(operation =>
{
   // SET default options to use when a SqlBulkCopy instance is used
   bulk.SqlBulkCopyOptions = SqlBulkCopyOptions.Default | SqlBulkCopyOptions.TableLock;
});
{% endhighlight %}

