---
layout: default
title: Entity Framework Extensions - Column Expression
permalink: column-expression
---

{% include template-h1.html %}
## SQL Server Options
- [SqlBulkCopyOptions](#sqlbulkcopyoptions)

## SqlBulkCopyOptions
Allow you to set the SqlBulkCopyOptions to use when a strategy with the SqlBulkCopy is selected.

### Example
{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(operation =>
{
   bulk.SqlBulkCopyOptions = SqlBulkCopyOptions.Default | SqlBulkCopyOptions.TableLock;
});
{% endhighlight %}
