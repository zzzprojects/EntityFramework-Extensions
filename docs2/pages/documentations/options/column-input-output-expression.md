# Column InputOutput Expression

The `ColumnInputOutputExpression` allows you to choose specific properties in which you want to perform the bulk operations with the direction `InputOutput`.

The key is required for operation such as `BulkUpdate` and `BulkMerge`. The following example uses `CustomerID`, `Description`, `IsActive` properties in the `ColumnInputOutputExpression`. 

```csharp
using (var context = new EntityContext())
{
    list = context.Customers.ToList();
    list.Add(new Customer() { Name ="Customer_C", Description = "Description"});
    list.ForEach(x => { x.IsActive = false; x.Name += "_NotMerge"; x.Description += "_Merge"; });
			
    context.BulkMerge(list, options => 
        options.ColumnInputOutputExpression = c => new 
	{
	    c.CustomerID, 
	    c.Description, 
	    c.IsActive
	}
    );	
}
```

[Try it in EF6](https://dotnetfiddle.net/3js97I) | [Try it in EF Core](https://dotnetfiddle.net/wAEaSb)

- It will merge data for `CustomerID`, `Description` and `IsActive` fields and all other properties will remain `NULL` in the database.
- It will also update the list by updating only the specified properties from the database.
