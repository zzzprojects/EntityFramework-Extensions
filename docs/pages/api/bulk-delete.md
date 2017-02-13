---
layout: default
title: Entity Framework Extensions - Bulk Delete
permalink: bulk-delete
---

{% include template-h1.html %}

## Bulk Delete
Allow you to perform a DELETE operation.

{% include template-example.html %} 
{% highlight csharp %}
var ctx = new EntitiesContext();

// Easy to use
ctx.BulkDelete(list);

// Easy to customize
context.BulkDelete(customers, 
   bulk => bulk.ColumnPrimaryKeyExpression = customer => customer.Code; });
{% endhighlight %}

### Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| BulkDelete      | 45 ms          | 50 ms          | 60 ms          |

SaveChanges makes one database round-trip for each entity to insert/update/delete. So if you want to save (add, modify or remove) 10,000 entities, 10,000 databases round trip will be required which are **INSANELY** slow.

Bulk Operations save entities in bulk to reduce the number of database round-trip required.

### Related Articles

- [How to Benchmark?](benchmark)
- [How to use Custom Key?](custom-key)
