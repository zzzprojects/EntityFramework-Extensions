# AllowDuplicateKeys

## Definition
The `BulkOperation.AuditEntries` property gets or sets if a duplicate key is possible in the source.

The following example chooses a `Name` property as a key to perform the `BulkMerge` operations and also allows a duplicate key.
```csharp
var list = new List<Customer>() 
{
    new Customer() { Name = "Customer_A", Description = "Description_updated" },
    new Customer() { Name ="Customer_B", Description = "Description"}    
};
        
using (var context = new EntityContext())
{
    context.BulkMerge(list,options => 
    {
        options.ColumnPrimaryKeyExpression = customer => customer.Name;
        options.AllowDuplicateKeys = true;
    });
}
```
[Try it in EF6](https://dotnetfiddle.net/tvZXih) | [Try it in EF Core](https://dotnetfiddle.net/DoD5hE)

 - It will update the record of "Customer_A" because it already exists in the database.
 - The data for "Customer_B" is inserted to the database as a new record.
 
## Purpose
In a rare scenario such as importing a file, a key may be used in multiple rows.

In some provider such as SQL Server, the statement created by our library (`Merge`) makes it impossible to use with some duplicate keys.

By enabling this option, only the latest key is used instead.

