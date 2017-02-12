---
layout: default
title: Entity Framework Extensions - Bulk Merge
permalink: bulk-merge
---

{% include template-h1.html %}

## Bulk Merge
Allow you to perform a MERGE (Insert/Update) operation.

{% include template-example.html %} 
{% highlight csharp %}
var ctx = new EntitiesContext();

// Easy to use
ctx.BulkMerge(list);

// Easy to customize
context.BulkDelete(customers, 
   bulk => bulk.ColumnPrimaryKeyExpression = customer => customer.Code; });
{% endhighlight %}

### Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| BulkMerge       | 65 ms          | 80 ms          | 110 ms         |

SaveChanges makes one database round-trip for each entity to insert/update/delete. So if you want to save (add, modify or remove) 10,000 entities, 10,000 databases round trip will be required which are **INSANELY** slow.

Bulk Operations save entities in bulk to reduce the number of database round-trip required.

### Related Articles
- [How to Benchmark?](https://github.com/zzzprojects/docs/blob/master/entity-framework-extensions/docs/how/benchmark.md)
- [How to use Custom Column?](https://github.com/zzzprojects/docs/blob/master/entity-framework-extensions/docs/how/custom-column.md)
- [How to use Custom Key?](https://github.com/zzzprojects/docs/blob/master/entity-framework-extensions/docs/how/custom-key.md)
