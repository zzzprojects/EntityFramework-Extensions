# BulkOperationExecuting

The `BulkOperationExecuting` event is executed before the action in the BulkOperations library is called. 

The following example updates the `Description` and `IsActive` properties before data is saved to the database in the `BulkSaveChanges` method.

```csharp
using (var context = new EntityContext())
{
    context.Customers.AddRange(list);
    
    context.BulkSaveChanges(options => 
    {
        options.BulkOperationExecuting = bulkOperation => 
        {
            list.ForEach(x =>  
            { 
                x.Description = "Before_Execution_Description"; 
                x.IsActive = false;
            });
        };
    });
}
```

[Try it in EF6](https://dotnetfiddle.net/mIhWyT) | [Try it in EF Core](https://dotnetfiddle.net/TEE4xQ)

The `BulkOperationExecuting` is updating the `Description` and `IsActive` in the `list` of customers but not in the database.
