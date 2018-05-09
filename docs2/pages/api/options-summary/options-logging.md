---
permalink: logging
---

## Log
Gets or sets an action to `log` all database events as soon as they happen.

{% include template-example.html %} 
{% highlight csharp %}
StringBuilder logger = new StringBuilder();

context.BulkSaveChanges(options =>
{
	options.Log += s => logger.AppendLine(s);
});
{% endhighlight %}

---

## UseLogDump
Gets or sets if all `log` related to database event should be stored in a `LogDump` properties.

{% include template-example.html %} 
{% highlight csharp %}
StringBuilder logDump;

context.BulkSaveChanges(options =>
{
	options.UseLogDump = true;
	options.BulkOperationExecuted = bulkOperation => logDump = bulkOperation.LogDump;
});
{% endhighlight %}

---

## LogDump
Gets all `logged` database event when `UseLogDump` is enabled.

{% include template-example.html %} 
{% highlight csharp %}
StringBuilder logDump;

context.BulkSaveChanges(options =>
{
	options.UseLogDump = true;
	options.BulkOperationExecuted = bulkOperation => logDump = bulkOperation.LogDump;
});
{% endhighlight %}
