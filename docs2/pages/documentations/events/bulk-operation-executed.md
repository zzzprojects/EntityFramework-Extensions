# BulkOperationExecuted

The `BulkOperationExecuted` event is executed after the action in the BulkOperations library is called. 

The following example updates the `Description` and `IsActive` properties after data is saved to the database in the `BulkSaveChanges` method.

```csharp
using (var context = new EntityContext())
{
    context.Customers.AddRange(list);
	
    context.BulkSaveChanges(options => 
    {
        options.BulkOperationExecuted = bulkOperation => 
        {
            list.ForEach(x =>  
            { 
                x.Description = "After_Execution_Description"; 
                x.IsActive = false;
            });
        };
    });
}
```
[Try it in EF6](https://dotnetfiddle.net/u3MlB7) | [Try it in EF Core](https://dotnetfiddle.net/wnXwJF)

The `BulkOperationExecuted` is updating the `Description` and `IsActive` in the `list` of customers but not in the database.
