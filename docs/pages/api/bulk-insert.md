---
layout: default
title: Entity Framework Extensions - Bulk Insert
permalink: bulk-insert
---

{% include template-h1.html %}

## Bulk Insert
Allow you to perform an INSERT operation.

{% include template-example.html %} 
{% highlight csharp %}
var ctx = new EntitiesContext();

// Easy to use
ctx.BulkInsert(list);

// Easy to customize
context.BulkInsert(list, bulk => bulk.BatchSize = 100);
{% endhighlight %}

### Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| BulkInsert      | 6 ms           | 10 ms          | 15 ms          |

SaveChanges makes one database round-trip for each entity to insert/update/delete. So if you want to save (add, modify or remove) 10,000 entities, 10,000 databases round trip will be required which are **INSANELY** slow.

Bulk Operations save entities in bulk to reduce the number of database round-trip required.

### Exampale - Default
Insert 10000 records using default BulkInsert operation

{% highlight csharp %}
My.Database.Reset();

using (var ctx = new EntitiesContext())
{
    var list = new List<Invoice>();

    for (var i = 0; i < My.AppSettings.NbTestItems; i++)
    {
        list.Add(new Invoice {Code = "Invoice_" + i, Kind = InvoiceKind.WebInvoice});
    }

    ctx.Invoices.AddRange(list);

    var clock = new Stopwatch();

    clock.Start();
    ctx.BulkInsert(list);
    clock.Stop();

    My.Result.Show(clock, list.Count, My.Result.Type.BulkInsert);
}
{% endhighlight %}

<img src="images/BulkInsert_Default.png" alt="BulkInsert Default" />

### Exampale - Custom Columns
Insert 10000 records using Custom Columns BulkInsert operation

{% highlight csharp %}
My.Database.Reset();

using (var ctx = new EntitiesContext())
{
    var list = new List<Invoice>();

    for (var i = 0; i < My.AppSettings.NbTestItems; i++)
    {
        list.Add(new Invoice {Code = "Invoice_" + i, Kind = InvoiceKind.WebInvoice});
    }

    ctx.Invoices.AddRange(list);

    var clock = new Stopwatch();

    clock.Start();
    ctx.BulkInsert(list, operation => operation.ColumnInputExpression = invoice => new {invoice.Kind});
    clock.Stop();

    My.Result.Show(clock, list.Count, My.Result.Type.BulkInsert);
}
{% endhighlight %}

<img src="images/BulkInsert_CustomColumns.png" alt="BulkInsert Custom Columns" />

### Exampale - AutoMapOutputDirection
Insert 10000 records using BulkInsert operation with AutoMapOutputDirection set to false

{% highlight csharp %}
My.Database.Reset();

using (var ctx = new EntitiesContext())
{
    var list = new List<Invoice>();

    for (var i = 0; i < My.AppSettings.NbTestItems; i++)
    {
        list.Add(new Invoice {Code = "Invoice_" + i, Kind = InvoiceKind.WebInvoice});
    }

    ctx.Invoices.AddRange(list);

    var clock = new Stopwatch();

    clock.Start();
    ctx.BulkInsert(list, operation => operation.AutoMapOutputDirection = false);
    clock.Stop();

    My.Result.Show(clock, list.Count, My.Result.Type.BulkInsert);
}
{% endhighlight %}

<img src="images/BulkInsert_AutoMapOutputDirection.png" alt="BulkInsert AutoMapOutputDirection" />
### Related Articles

- [How to Benchmark?](benchmark)

- [How to use Custom Column?](custom-column)


