---
permalink: update-from-query
---

## Definition
`UPDATE` all rows from the database using a LINQ Query without loading entities in the context.

An `UPDATE` statement is built using the LINQ expression and directly executed in the database.

{% include template-example.html %} 
{% highlight csharp %}
// UPDATE all customers that are inactive for more than two years
context.Customers
    .Where(x => x.Actif && x.LastLogin < DateTime.Now.AddYears(-2))
    .UpdateFromQuery(x => new Customer {Actif = false});
	
// UPDATE customers by id
context.Customers.Where(x => x.ID == userId).UpdateFromQuery(x => new Customer {Actif = false});
{% endhighlight %}

## Purpose
`Updating` entities using `SaveChanges` normally requires to load them first in the `ChangeTracker`. These additional round-trips are often not necessary.

`UpdateFromQuery` gives you access to directly execute an `UPDATE` statement in the database and provide a **HUGE** performance improvement.

## Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| UpdateFromQuery | 1 ms           | 1 ms           | 1 ms           |

{% include section-faq-begin.html %}
## FAQ

### Why UpdateFromQuery is faster than SaveChanges, BulkSaveChanges, and BulkUpdate?

`UpdateFromQuery` executes a statement directly in SQL such as `UPDATE [TableName] SET [SetColumnsAndValues] WHERE [Key]`. 

Other operations normally require one or multiple database round-trips which makes the performance slower.
{% include section-faq-end.html %}