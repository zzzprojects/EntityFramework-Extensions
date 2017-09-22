---
layout: dev
title: Column Expression
permalink: column-expression
---

{% include template-h1.html %}
## Column Expression Options
- [Input](#column-input-expression)
- [Output](#column-output-expression)
- [Primary Key](#column-primary-key-expression)
- [Ignore On Merge Insert](#ignore-on-merge-insert-expression)
- [Ignore On Merge Update](#ignore-on-merge-update-expression)
- [Synchronize Delete Key Subset](#column-synchronize-delete-key-subset-expression)


## Column Input Expression
Gets or sets columns to map with direction Input.

> Always include the key for operation required one.

### Example
{% highlight csharp %}
ctx.BulkMerge(parents, operation => 
        operation.ColumnInputExpression = entity => new {entity.ParentID, entity.ColumnInt}); 
{% endhighlight %}

## Column Output Expression
Gets or sets columns to map with the direction output.

### Example
{% highlight csharp %}
ctx.BulkMerge(parents, operation => 
        operation.ColumnOutputExpression = entity => new {entity.ModifiedDate, entity.ModifiedUser}); 
{% endhighlight %}

## Column Primary Key Expression
Gets or sets columns to map with the primary key option to true.

### Example
{% highlight csharp %}
ctx.BulkMerge(parents, operation => 
        operation.ColumnPrimaryKeyExpression = entity => new { entity.Name }); 
{% endhighlight %}

## Ignore On Merge Insert Expression
Gets or sets columns to skip when the merge execute the insert part.

### Example
{% highlight csharp %}
ctx.BulkMerge(parents, operation => 
        operation.IgnoreOnMergeUpdateExpression = entity => new {entity.ModifiedDate, entity.ModifiedUser}); 
{% endhighlight %}

## Ignore On Merge Update Expression
Gets or sets columns to skip when the merge execute the update part.

### Example
{% highlight csharp %}
ctx.BulkMerge(parents, operation => 
        operation.IgnoreOnMergeUpdateExpression = entity => new {entity.CreatedDate, entity.CreatedUser}); 
{% endhighlight %}

## Column Synchronize Delete Key Subset Expression
Gets or sets the key used to delete only rows matching the key and not existing in the source. 

> Sorry for the name!

### Example
{% highlight csharp %}
ctx.BulkMerge(parents, operation => 
        operation.ColumnPrimaryKeyExpression = entity => new { entity.Name }); 
{% endhighlight %}
