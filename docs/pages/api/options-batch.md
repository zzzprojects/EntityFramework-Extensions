---
layout: dev
title: Batch
permalink: batch
---

{% include template-h1.html %}

## Batch Options
- [BatchSize](#batchsize)
- [BatchTimeout](#batchtimeout)
- [BatchDelayInteval](#batchdelayinterval)

## BatchSize
Allow you to set the number of records to use in a batch.

By example, if you insert 1000 entities, and you set a batch size of 100, then ten inserts will be performed.

### Example
{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(operation =>
{
   operation.BatchSize = 100;
});
{% endhighlight %}

## BatchTimeout
Allow you to set the maximum of time elapsing for a batch before the command throws a timeout exception.

### Example
{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(operation =>
{
   operation.BatchTimeout = 180;
});
{% endhighlight %}

## BatchDelayInterval
Allow you to set a delay between every batch.

### Example
```csharp
context.BulkSaveChanges(operation =>
{
   operation.BatchDelayInterval = 100;
});
```

> WARNING: Be careful, this options can often cause lock/deadlock within a transaction.
