---
permalink: include-graph
---

The IncludeGraph options allow to INSERT/UPDATE/MERGE entities by including the child entities graph.
By example, if you use BulkInsert using a list of Invoice with the options IncludeGraph, all invoices items will also be inserted.


```csharp
ctx.BulkInsert(invoices, options => options.IncludeGraph = true);
```

## IncludeGraphOperationBuilder
The IncludeGraphOperationBuilder let you customize the bulk operations by entity type. 

Options are not copied when using IncludeGraph


```csharp
ctx.BulkMerge(users, options =>
{
	options.IncludeGraph = true;
	options.IncludeGraphOperationBuilder = operation =>
	{
		if (operation is BulkOperation<User>)
		{
			var bulk = (BulkOperation<User>) operation;
			bulk.ColumnPrimaryKeyExpression = x => x.Name;
		}
		else if (operation is BulkOperation<Role>)
		{
			var bulk = (BulkOperation<Role>) operation;
			bulk.ColumnPrimaryKeyExpression = x => x.Name;
		}
	};
});
```

### ReadOnly
You can specify that some entities should not be inserted/updated by marked them as ReadOnly.


```csharp
ctx.BulkMerge(users, options =>
{
	options.IncludeGraph = true;
	options.IncludeGraphOperationBuilder = operation =>
	{
		if (operation is BulkOperation<User>)
		{
			var bulk = (BulkOperation<User>) operation;
			bulk.IsReadOnly = true;
		}
	};
});
```


{% include section-faq-begin.html %}
## FAQ

### Why I receive an error that asks me to specify a context factory?
To retrieve the current entities graph, our library requires a working context to use some Entity Framework feature without impacting the current context.
The context factory is optional if your context has a default constructor.

Read more: [Context Factory](context-factory)

### Why I received an error that asks me to use unsafe mode?
The unsafe mode is required when some proxy entities are found in the graph.
To retrieve all information, we need to detach temporary proxy type from the current context before re-attaching them.
There is currently no known issue about this technic, but we prefer to force people to understand that some unsafe code is currently done under the hood by our library.

### Why is IncludeGraph not compatible with BulkDelete?
For security purpose, we prefer to force people to delete their entities. We currently have no plan to support it.

{% include section-faq-end.html %}