# Bulk SaveChanges

## Definition

BulkSaveChanges method is the upgraded version of `SaveChanges`.

All changes made in the context are persisted in the database but way faster by reducing the number of database round-trip required!

BulkSaveChanges supports everything:

- Association (One to One, One to Many, Many to Many, etc.)
- Complex Type
- Enum
- Inheritance (TPC, TPH, TPT)
- Navigation Property
- Self-Hierarchy
- Etc.

### BulkSaveChanges Examples
```csharp
context.Customers.AddRange(listToAdd); // add
context.Customers.RemoveRange(listToRemove); // remove
listToModify.ForEach(x => x.DateModified = DateTime.Now); // modify

// Easy to use
context.BulkSaveChanges();

// Easy to customize
context.BulkSaveChanges(bulk => bulk.BatchSize = 100);
```

## Purpose
Using the `ChangeTracker` to detect and persist changes automatically is great! However, it leads very fast to some problems when multiple entities need to be saved.

`SaveChanges` method makes a database round-trip for every change. So if you need to insert 10000 entities, then 10000 database round-trips will be performed which is INSANELY slow.

`BulkSaveChanges` works exactly like `SaveChanges` but reduces the number of database round-trips required to greatly help improve the performance.

## Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| BulkSaveChanges | 90 ms          | 150 ms         | 350 ms         |

{% include section-faq-begin.html %}
## FAQ

### How can I specify more than one option?
You can specify more than one option using anonymous block.


```csharp
context.BulkSaveChanges(options => {
	options.BatchSize = 100;
	options.AllowConcurrency = false;
});
```

### How can I specify the Batch Size?
You can specify a custom batch size using the `BatchSize` option.

Read more: [BatchSize](/batch-size)


```csharp
context.BulkSaveChanges(options => options.BatchSize = 100);
```

### How can I turn off Concurrency Check?
You can turn off concurrency check using the `AllowConcurrency` option.

Read more: [AllowConcurrency](/allow-concurrency)


```csharp
context.BulkSaveChanges(options => options.AllowConcurrency = false);
```
{% include section-faq-end.html %}

## Related Articles

- [How to Benchmark?](benchmark)
- [How to Improve Bulk SaveChanges Performances?](improve-bulk-savechanges)
