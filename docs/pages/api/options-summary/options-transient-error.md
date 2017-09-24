---
layout: dev
title: Transient Error
permalink: transient-error
---

{% include template-h1.html %}

- [RetryCount](#retrycount)
- [RetryInterval](#retryinterval)

---

## RetryCount
Gets or sets the maximum number of operation retry when a transient error occurs.

Read more: [RetryCount](retry-count)

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
});
{% endhighlight %}

---

## RetryInterval
Gets or sets the interval to wait before retrying an operation when a transient error occurs.

Read more: [RetryInterval](retry-interval)

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
	options.RetryInterval = new TimeSpan(100);
});

{% endhighlight %}
