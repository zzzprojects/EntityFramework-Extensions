---
layout: default
title: Entity Framework Extensions - Introduction
permalink: tutorial-introduction
---

{% include template-h1.html %}

## Introduction
Entity Framework Extensions allow you to improve dramatically your save operations performance.

It's easy to use, and easy to customize.

## Bulk SaveChanges

### Example
{% include template-example.html %} 
{% highlight csharp %}
var ctx = new EntitiesContext();

ctx.Customers.AddRange(listToAdd); // add
ctx.Customers.RemoveRange(listToRemove); // remove
listToModify.ForEach(x => x.DateModified = DateTime.Now); // modify

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

## Bulk Operations

### Example

{% include template-example.html %} 
{% highlight csharp %}
var ctx = new EntitiesContext();

// Easy to use
ctx.BulkInsert(list);
ctx.BulkUpdate(list);
ctx.BulkDelete(list);
ctx.BulkMerge(list);

// Easy to customize
context.BulkMerge(customers, 
   bulk => bulk.ColumnPrimaryKeyExpression = customer => customer.Code; });
{% endhighlight %}

### Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| BulkInsert      | 6 ms           | 10 ms          | 15 ms          |
| BulkUpdate      | 50 ms          | 55 ms          | 65 ms          |
| BulkDelete      | 45 ms          | 50 ms          | 60 ms          |
| BulkMerge       | 65 ms          | 80 ms          | 110 ms         |

## FromQuery Operations

### Example

{% include template-example.html %} 
{% highlight csharp %}
// DELETE all customers that are inactive for more than two years
context.Customers
    .Where(x => x.LastLogin < DateTime.Now.AddYears(-2))
    .DeleteFromQuery();
 
// UPDATE all customers that are inactive for more than two years
context.Customers
    .Where(x => x.Actif && x.LastLogin < DateTime.Now.AddYears(-2))
    .UpdateFromQuery(x => new Customer {Actif = false});
{% endhighlight %}

### Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| DeleteFromQuery | 1 ms           | 1 ms           | 1 ms           |
| UpdateFromQuery | 1 ms           | 1 ms           | 1 ms           |
