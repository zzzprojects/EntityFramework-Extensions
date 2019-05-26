# IgnoreOnSynchronizeUpdateExpression

The `IgnoreOnSynchronizeUpdateExpression` allows you to ignore some columns when the `BulkSynchronize` method executes the `UPDATE` statement and these columns will only be used in `INSERT` statement.

The following example ignores the `CreatedDate` property when updating the existing records, and it will be considered in insertion only.

```csharp
using (var context = new EntityContext())
{
    var customers = context.Customers.Take(2).ToList();
    customers.ForEach(x => 
    { 
        x.Name += "_Updated"; 
        x.Description += "_Updated"; 
        x.ModifiedDate = DateTime.Now; 
        x.IsActive = false; 
    });
	
    customers.Add(new Customer() 
    { 
        Name = "Alexander", 
        Description = "Description of Alexander", 
        CreatedDate = DateTime.Now, 
        ModifiedDate = DateTime.Now, 
        IsActive = true 
    });

    context.BulkSynchronize(customers, options => 
    {
        options.IgnoreOnSynchronizeUpdateExpression = customer => new 
        {
            customer.CustomerID,  
	    customer.CreatedDate
        };
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/ebEAZa' %}

 - It updates all the columns of an existing records except for the `CreatedDate` column because `CreatedDate` property is specified in `IgnoreOnSynchronizeUpdateExpression`. 
 - I will insert non-matching rows that exist in the source (`customers` list).
 - It will also delete non-matching rows that exist in the database.
