# SynchronizeKeepIdentity

The `BulkOperation.SynchronizeKeepIdentity` sets if the source identity value should be preserved on `Synchronize`. When not specified, identity values are assigned by the destination.

In the following example, the `SynchronizeKeepIdentity` is enabled and the specified value for `IdentityInt` column will be stored in the database instead of the database generated values on `Synchronize` operation.

```csharp
using (var context = new EntityContext())
{
    var list = context.Customers.ToList();
    list.ForEach(x => x.Name += "_Synchronize" );
    list.ForEach(x => x.IdentityInt += 100 );
    list.Add( new Customer() { CustomerID = 3, IdentityInt = 4, Name ="Customer_C" });

    context.BulkMerge(list, options => options.SynchronizeKeepidentity = true);
}
```
{% include component-try-it.html href='https://dotnetfiddle.net/JBYGfz' %}

## Purpose
The `SynchronizeKeepIdentity` option let you keep the source identity value when `synchronizing`.

By example, when importing a file, you may want to keep the value specified.
