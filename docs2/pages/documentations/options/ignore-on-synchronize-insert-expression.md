# IgnoreOnSynchronizeInsertExpression

The `IgnoreOnSynchronizeInsertExpression` allows you to ignore some columns when the `BulkSynchronize` method executes the `insert` statement and these columns will only be used in `update` statement.

The following example ignores the `ModifiedDate` property in insertion and will be considered when updating the records.

```csharp
using (var context = new EntityContext())
{
	var customers = context.Customers.Take(2).ToList();
	customers.ForEach(x => { x.Name += "_Updated"; x.Description += "_Updated"; x.ModifiedDate = DateTime.Now; x.IsActive = false; });
	customers.Add(new Customer() { Name = "Alexander", Description = "Description of Alexander", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true });

	context.BulkSynchronize(customers, options => 
	{
	    options.IgnoreOnSynchronizeInsertExpression = customer => new {customer.CustomerID,  customer.ModifiedDate};
	});
	
	FiddleHelper.WriteTable("After BulkSynchronize",context.Customers.ToList());
					  
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/bCXqPB' %}

 - It updates all the columns of existing records.
 - I will insert data of new records in all the columns except for the `ModifiedDate` column because `ModifiedDate` property is specified in `IgnoreOnSynchronizeInsertExpression`. 
 - It will also delete non-matching rows that exist in the database.
