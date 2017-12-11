---
permalink: batch-timeout
---

## Definition
Gets or sets the maximum of time in seconds to wait for a batch before the command throws a timeout exception. 

{% include template-example.html %} 
{% highlight csharp %}
// Instance
context.BulkSaveChanges(options => options.BatchTimeout = 180);

// Global
EntityFrameworkManager.BulkOperationBuilder = builder => builder.BatchTimeout = 180;
{% endhighlight %}

## Purpose
Having access to change the `BatchTimeout` gives you the flexibility required when some operations are too slow to complete due to several reasons such as:
- Batch Size
- Column Size
- Latency
- Trigger
- Etc.