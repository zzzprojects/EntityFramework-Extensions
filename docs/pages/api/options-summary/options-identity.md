---
permalink: identity
---

### InsertKeepIdentity
Gets or sets if the source identity value should be preserved on `Insert`. When not specified, identity values are assigned by the destination.

{% include template-example.html %} 
{% highlight csharp %}
context.Insert(options => options.InsertKeepIdentity = true);
{% endhighlight %}

---

### MergeKeepIdentity
Gets or sets if the source identity value should be preserved on `Merge`. When not specified, identity values are assigned by the destination.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkMerge(options => options.MergeKeepIdentity = true);
{% endhighlight %}

---

### SynchronizeKeepIdentity
Gets or sets if the source identity value should be preserved on `Synchronize`. When not specified, identity values are assigned by the destination.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSynchronize(options => options.SynchronizeKeepIdentity = true);
{% endhighlight %}