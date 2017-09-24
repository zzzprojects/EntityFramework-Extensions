---
layout: dev
title: BulkOperationExecuting
permalink: bulk-operation-executing
---

{% include template-h1.html %}

## Definition
Gets or sets an action to execute `before` the bulk operation is executed.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.BulkOperationExecuting = bulkOperation => { /* configuration */ };
});
{% endhighlight %}

## Purpose
This event allows you to check or change some options that have been automatically added when none is specified such as Batch Size, Column Mapping, Timeout, etc.
