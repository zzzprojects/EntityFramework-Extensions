---
permalink: transient-error
---

## RetryCount
Gets or sets the maximum number of operations retry when a transient error occurs.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
});
{% endhighlight %}

---

## RetryInterval
Gets or sets the interval to wait before retrying an operation when a transient error occurs.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
	options.RetryInterval = new TimeSpan(100);
});

{% endhighlight %}
