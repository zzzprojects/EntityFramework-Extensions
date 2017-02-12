---
layout: default
title: Entity Framework Extensions - Transient Error
permalink: transient-error
---

{% include template-h1.html %}
## Transient Error Options
- [RetryCount](#retrycount)
- [RetryInterval](#retryinterval)

## RetryCount
Allow you to set how many time the bulk operation should retry the operation when a transient error occurs.

### Example

{% include template-example.html %} 
{% highlight csharp %}
using (var ctx = new EntitiesContext())
{
    ctx.BulkSaveChanges(operation =>
    {
        operation.RetryCount = 3;
    });
}
{% endhighlight %}

## RetryInterval
Allow you to set how many time to wait before trying an operation again when a transient error occurs.

### Example

{% include template-example.html %} 
{% highlight csharp %}
using (var ctx = new EntitiesContext())
{
    ctx.BulkSaveChanges(operation =>
    {
        operation.RetryCount = 3;
        operation.RetryInterval = new TimeSpan(100);
    });
}
{% endhighlight %}
