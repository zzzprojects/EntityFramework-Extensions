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

### Related Articles

- [How to Benchmark?](benchmark)
- [How to use Custom Column?](custom-column)


