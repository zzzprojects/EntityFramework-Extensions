---
layout: dev
title: Execute Event
permalink: execute-event
---

{% include template-h1.html %}
## Excecute Event Options
- [BulkOperationExecuting](#bulkoperationexecuting)
- [BulkOperationExecuted](#bulkoperationexecuted)

## BulkOperationExecuting
Allow you to change configuration before the bulk operation is executed.

### Example
{% include template-example.html %} 
{% highlight csharp %}
using (var ctx = new EntitiesContext())
{
    ctx.BulkSaveChanges(operation =>
    {
        operation.BulkOperationExecuting = bulkOperation => { /* configuration */ };
    });
}
{% endhighlight %}

## BulkOperationExecuted
Allow you to change configuration after the bulk operation is executed.

### Example
{% include template-example.html %} 
{% highlight csharp %}
using (var ctx = new EntitiesContext())
{
    ctx.BulkSaveChanges(operation =>
    {
        operation.BulkOperationExecuted = bulkOperation =>  { /* configuration */ };
    });
}
{% endhighlight %}
