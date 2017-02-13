---
layout: default
title: Entity Framework Extensions - Delete from Query
permalink: delete-from-query
---

{% include template-h1.html %}

## Delete FromQuery
Allow you to execute to DELETE multiples records in a database from a LINQ Query without loading entities in the context

{% include template-example.html %} 
{% highlight csharp %}
// DELETE all customers that are inactive for more than two years
context.Customers
    .Where(x => x.LastLogin < DateTime.Now.AddYears(-2))
    .DeleteFromQuery();
{% endhighlight %}

### Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| DeleteFromQuery | 1 ms           | 1 ms           | 1 ms           |

SaveChanges makes one database round-trip for each entity to insert/update/delete. So if you want to save (add, modify or remove) 10,000 entities, 10,000 databases round trip will be required which are **INSANELY** slow.

FromQuery operations directly execute the SQL statements on the target database.

### Support
- SQL Server 2008+
- SQL Azure

_More provider will be available on next major version_
