---
permalink: retry-interval
---

## Definition
Gets or sets the interval to wait before retrying an operation when a transient error occurs.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
	options.RetryInterval = new TimeSpan(100);
});

{% endhighlight %}

## Purpose
A transient error is a temporary error that is likely to disappear soon. That rarely happens but they might occur!

These options allow to reduce a bulk operations fail by making them retry when a transient error occurs.

## FAQ

### What are transient error codes supported?
You can find a list of transient errors here: [Transient fault error codes](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-develop-error-messages#transient-fault-error-codes)

Which includes the most common error such as:
- Cannot open database
- The service is currently busy
- Database is not currently available
- Not enough resources to process request