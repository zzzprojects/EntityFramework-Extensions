# MergeKeepIdentity

## Definition
The `BulkOperation.InsertKeepIdentity` sets if the source identity value should be preserved on `Merge`. When not specified, identity values are assigned by the destination.

In the following example, the `MergeKeepIdentity` is enabled and the specified value for `IdentityInt` column will be stored in the database instead of the database generated values on `MERGE` operation.

```csharp
using (var context = new EntityContext())
{
    var list = context.Customers.ToList();
    list.ForEach(x => x.Name += "_Merged" );
    list.ForEach(x => x.IdentityInt += 100 );
    list.Add( new Customer() { CustomerID = 3, IdentityInt = 4, Name ="Customer_C" });

    context.BulkMerge(list, options => options.MergeKeepIdentity = true);
}
```
{% include component-try-it.html href='https://dotnetfiddle.net/I00rLw' %}

 - The `IdentityInt` column for existing records will not be updated, only for the new records, it will preserve the specified value.

## Purpose
The `MergeKeepIdentity` option lets you keep the source identity value when `merging`.

By example, when importing a file, you may want to keep the specified value.
