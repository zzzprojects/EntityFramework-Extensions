---
permalink: key
---

## AllowDuplicateKeys
Gets or sets if a duplicate key is possible in the source.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => options.AllowDuplicateKeys = true);
{% endhighlight %}

---

## AllowUpdatePrimaryKeys
Gets or sets if the key must also be included in columns to `UPDATE`.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options => options.AllowUpdatePrimaryKeys = true);
{% endhighlight %}
