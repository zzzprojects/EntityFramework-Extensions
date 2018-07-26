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
{% include component-try-it.html href='https://dotnetfiddle.net/YjoyLn' %}

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
{% include component-try-it.html href='https://dotnetfiddle.net/0n66D0' %}
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
{% include component-try-it.html href='https://dotnetfiddle.net/jkIJzF' %}

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
{% include component-try-it.html href='https://dotnetfiddle.net/RjriRf' %}

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
{% include component-try-it.html href='https://dotnetfiddle.net/z2Pg1K' %}

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
{% include component-try-it.html href='https://dotnetfiddle.net/B5qNg5' %}
