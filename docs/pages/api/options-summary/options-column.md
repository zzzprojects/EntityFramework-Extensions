---
permalink: column
---

## Column Input
Gets or sets columns to map with the direction `Input`.

The key is required for operation such as `BulkUpdate` and `BulkMerge`.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkMerge(list, options => 
        options.ColumnInputExpression = entity => new {entity.ID, entity.Code}
); 
{% endhighlight %}

## Column Output
Gets or sets columns to map with the direction `Output`.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkMerge(list, options => 
        options.ColumnOutputExpression = entity => new {entity.ModifiedDate, entity.ModifiedUser}
); 
{% endhighlight %}

## Column InputOutput
Gets or sets columns to map with the direction `InputOutput`.

The key is required for operation such as `BulkUpdate` and `BulkMerge`.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkMerge(list, options => 
        options.ColumnInputOutputExpression = entity => new {entity.ID, entity.Code}
); 
{% endhighlight %}

## Column Primary Key
Gets or sets columns to use as the `key` for the operation.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkMerge(list, options => 
        options.ColumnPrimaryKeyExpression = entity => new { entity.Code1, entity.Code2 }
); 
{% endhighlight %}

## Ignore On Merge Insert
Gets or sets columns to ignore when the `BulkMerge` method executes the `insert` statement.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkMerge(list, options => 
        options.IgnoreOnMergeUpdateExpression = entity => new {entity.ModifiedDate, entity.ModifiedUser}
); 
{% endhighlight %}

## Ignore On Merge Update
Gets or sets columns to ignore when the `BulkMerge` method executes the `update` statement.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkMerge(list, options => 
        options.IgnoreOnMergeUpdateExpression = entity => new {entity.CreatedDate, entity.CreatedUser}
); 
{% endhighlight %}