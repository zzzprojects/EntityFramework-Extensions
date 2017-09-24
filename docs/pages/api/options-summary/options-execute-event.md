---
layout: dev
title: Execute Event
permalink: execute-event
---

{% include template-h1.html %}

- [BulkOperationExecuting](#bulkoperationexecuting)
- [BulkOperationExecuted](#bulkoperationexecuted)

---

## BulkOperationExecuting
Gets or sets an action to execute `before` the bulk operation is executed.

Read more: [BulkOperationExecuting](bulk-operation-executing)

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.BulkOperationExecuting = bulkOperation => { /* configuration */ };
});
{% endhighlight %}

---

## BulkOperationExecuted
Gets or sets an action to execute `after` the bulk operation is executed.

Read more: [BulkOperationExecuted](bulk-operation-executed)

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.BulkOperationExecuted = bulkOperation => { /* configuration */ };
});
{% endhighlight %}
