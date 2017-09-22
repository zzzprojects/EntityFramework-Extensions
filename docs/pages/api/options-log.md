---
layout: dev
title: Log
permalink: log
---

{% include template-h1.html %}
## Log Options
- [Log](#log)
- [UseLogDump](#uselogdump)
- [LogDump](#logdump)

## Log
Allow you to log some event happening in your database.

### Example
{% include template-example.html %} 
{% highlight csharp %}
StringBuilder logger = new StringBuilder();
using (var ctx = new EntitiesContext())
{
    ctx.BulkSaveChanges(operation =>
    {
        operation.Log += s => logger.AppendLine(s);
    });
}
{% endhighlight %}

## UseLogDump
Allow you to log in a string (LogDump) event happening in your database.

### Example
{% include template-example.html %} 
{% highlight csharp %}
StringBuilder logDump;

using (var ctx = new EntitiesContext())
{
    ctx.BulkSaveChanges(operation =>
    {
        operation.UseLogDump = true;
        operation.BulkOperationExecuting = bulkOperation => logDump = bulkOperation.LogDump;
    });
}
{% endhighlight %}

## LogDump
Allow you to retrieve event happening in your database when UseLogDump is enabled.

### Example
{% include template-example.html %} 
{% highlight csharp %}
StringBuilder logDump;

using (var ctx = new EntitiesContext())
{
    ctx.BulkSaveChanges(operation =>
    {
        operation.UseLogDump = true;
        operation.BulkOperationExecuting = bulkOperation => logDump = bulkOperation.LogDump;
    });
}
{% endhighlight %}
