---
layout: default
title: Entity Framework Extensions - BulkSaveChanges
permalink: tutorial-bulk-savechanges
---

{% include template-h1.html %}

## Introduction

BulkSaveChanges work exactly like SaveChanges but way faster!

Using it could not be simpler:
 - ADD "Bulk" prefix before "SaveChanges"

### Example
{% include template-example.html %} 
{% highlight csharp %}
var ctx = new EntitiesContext();

ctx.Customers.AddRange(listToAdd);
ctx.Customers.RemoveRange(listToRemove);
listToModify.ForEach(x => x.DateModified = DateTime.Now);

// Easy to use
ctx.BulkSaveChanges();

// Easy to customize
context.BulkSaveChanges(bulk => bulk.BatchSize = 100);
{% endhighlight %}

### Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| BulkSaveChanges | 90 ms          | 150 ms         | 350 ms         |


SaveChanges makes one database round-trip for each entity to insert/update/delete. So if you want to save (add, modify or remove) 10,000 entities, 10,000 databases round trip will be required which are **INSANELY** slow.

BulkSaveChanges use bulk operations to reduce the number of database round-trip required.

### Support

BulkSaveChanges support everything!

- Association (One to One, One to Many, Many to Many, etc.)
- Complex Type
- Enum
- Inheritance (TPC, TPH, TPT)
- Navigation Property
- Self-Hierarchy
- Etc.

### Related Articles

- [How to Benchmark?](benchmark)
- [How to Improve Bulk SaveChanges Performances?](improve-bulk-savechanges)
