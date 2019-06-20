# Column Synchronize DeleteKey Subset Expression

The `ColumnSynchronizeDeleteKeySubsetExpression` allows you to synchronize (insert/update/delete) only a part of the tables by specifying a key.

The following example synchronizes customers of `Type` equal to "1" by specifying the customer name as a key. 

```csharp

var customers = new List<Customer>();
customers.Add(new Customer() { Name = "Carson", Type = 1, Description = "Updated_Description of Carson", IsActive = false });
customers.Add(new Customer() { Name = "Alexander", Type = 1, Description = "Description of Alexander", IsActive = false });

using (var context = new EntityContext())
{
    context.BulkSynchronize(customers, options => {
        options.ColumnPrimaryKeyExpression = customer => customer.Name;
        options.ColumnSynchronizeDeleteKeySubsetExpression = customer => customer.Type;
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/y5snLt' %}

A synchronize is a mirror operation from the data source to the database. All rows that match the entity key are `UPDATED`, non-matching rows that exist from the source are `INSERTED`, non-matching rows that exist in the database are `DELETED`.

 - It updates the record of **Carson** as it is already in the database 
 - It inserts **Alexander** record because it is not available in the database.
 - It will also delete any other customers available in the database of Type "1" which are not available in the source (`customers` list). 
