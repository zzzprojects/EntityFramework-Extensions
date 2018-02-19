---
permalink: execute-event
---

## BulkOperationExecuting
Gets or sets an action to execute `before` the bulk operation is executed.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.BulkOperationExecuting = bulkOperation => { /* configuration */ };
});
{% endhighlight %}

---

## BulkOperationExecuted
Gets or sets an action to execute `after` the bulk operation is executed.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.BulkOperationExecuted = bulkOperation => { /* configuration */ };
});
{% endhighlight %}
