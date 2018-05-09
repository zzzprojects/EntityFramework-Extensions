---
permalink: temporary-table
---

## TemporaryTableBatchByTable
Gets or sets the number of batches a temporary table can contain. This option may create multiple temporary tables when the number of batches to execute exceeds the specified limit.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options =>
{
   options.TemporaryTableBatchByTable = 0; // unlimited
});
{% endhighlight %}

---

## TemporaryTableInsertBatchSize
Gets or sets the number of records to use in a batch when inserting in a temporary table. This number is recommended to be high.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options =>
{
   options.TemporaryTableInsertBatchSize = 50000;
});
{% endhighlight %}

---

## TemporaryTableMinRecord
Gets or sets the minimum number of records to use a temporary table instead of using SQL derived table.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options =>
{
   options.TemporaryTableMinRecord = 25;
});
{% endhighlight %}

---

## TemporaryTableSchemaName
Gets or sets the schema name to use for the temporary table.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options =>
{
   options.TemporaryTableSchemaName = "zzz";
});
{% endhighlight %}

---

## TemporaryTableUseTableLock
Gets or sets if the temporary table must be locked when inserting records into it.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options =>
{
   options.TemporaryTableUseTableLock = true;
});
{% endhighlight %}


---

## UsePermanentTable
Gets or sets if the library should `create` and `drop` a permanent table instead of using a temporary table.

{% include template-example.html %} 
{% highlight csharp %}
context.BulkSaveChanges(options =>
{
   options.UsePermanentTable = true;
});
{% endhighlight %}
