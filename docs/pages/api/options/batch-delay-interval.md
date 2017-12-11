---
permalink: batch-delay-interval
---

## Definition
Gets or sets a delay in milliseconds to wait between batch.

**DO NOT** use this options with transaction.

{% include template-example.html %} 
{% highlight csharp %}
// Instance
context.BulkInsert(list, options => options.BatchDelayInterval = 100);

// Global
EntityFrameworkManager.BulkOperationBuilder = builder => builder.BatchDelayInterval = 100;
{% endhighlight %}

## Purpose
Having access to add a delay interval between batches may help to give responsivity to other applications by giving them a chance to insert data during the delay time.

## FAQ

### Why should I not use this option with transaction?
You should not because if may often lead to lock and deadlock.

A transaction must be as short as possible and completed as soon as possible.
