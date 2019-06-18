# InsertKeepIdentity

## Definition

The `BulkOperation.InsertKeepIdentity` sets if the source identity value should be preserved on `Insert`. When not specified, identity values are assigned by the destination.

In the following example, the `InsertKeepIdentity` is enabled and the specified value for `IdentityInt` column will be stored in the database instead of the database generated values on `INSERT` operation. 
```csharp
List<Customer> list =  new List<Customer>() 
{
    new Customer() { CustomerID = 1, IdentityInt = 3, Name ="Customer_A" }, 
    new Customer() { CustomerID = 2, IdentityInt = 2, Name ="Customer_B" }, 
    new Customer() { CustomerID = 3, IdentityInt = 4, Name ="Customer_C" }
};
				
using (var context = new EntityContext())
{
    context.BulkInsert(list, options => options.InsertKeepIdentity = true);
}
```
{% include component-try-it.html href='https://dotnetfiddle.net/ZWLodr' %}

## Purpose
The `InsertKeepIdentity` option let you keep the source identity value when `inserting`.

By example, when importing a file, you may want to keep the value specified.
