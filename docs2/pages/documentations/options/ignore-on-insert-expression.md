# IgnoreOnInsertExpression

The `IgnoreOnInsertExpression` allows you to ignore some columns when the `BulkInsert` method is executed.

The following example ignores the `ModifiedDate` property when bulk insert operation is performed.

```csharp
using (var context = new EntityContext())
{
    var customers = new List<Customer>();
    customers.Add(new Customer() { Name = "Alexander", Description = "Description of Alexander", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true });
    customers.Add(new Customer() { Name = "Carson", Description = "Description of Carson", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true });
    customers.Add(new Customer() { Name = "Meredith", Description = "Description of Meredith", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true });
    customers.Add(new Customer() { Name = "Arturo", Description = "Description of Arturo", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true });

    context.BulkInsert(customers, options => 
    {
        options.IgnoreOnInsertExpression = customer => new {customer.CustomerID,  customer.ModifiedDate};
    });
}
```

{% include component-try-it.html href='https://dotnetfiddle.net/RljtrO' %}

 - It will insert data in all the columns except for the `ModifiedDate` column because `ModifiedDate` property is specified in `IgnoreOnInsertExpression`. 
