# IncludeGraph

The `BulkOperation.IncludeGraph` option allows you to `INSERT/UPDATE/MERGE` entities by including the child entities graph. 

In the following example, the `IncludeGraph` is enabled and the list of `Invoice` is added to the database using `BulkInsert`.

```csharp
List<Invoice> list = new List<Invoice>()
{
    new Invoice()
    {
        Description = "Invoice_A",
        InvoiceItems = new List<InvoiceItem>()
        {
            new InvoiceItem() { Description = "Invoice_A_InvoiceItem_A" } ,
            new InvoiceItem() { Description = "Invoice_A_InvoiceItem_B" }
        }
    },
    new Invoice()
    {
        Description = "Invoice_B",
        InvoiceItems = new List<InvoiceItem>()
        {
            new InvoiceItem() { Description = "Invoice_B_InvoiceItem_A" } ,
            new InvoiceItem() { Description = "Invoice_B_InvoiceItem_B" }
        }
    }
};


// IncludeGraph: The IncludeGraph option allows to INSERT/UPDATE/MERGE entities by including the child entities graph.
using (var context = new EntityContext())
{
    context.BulkInsert(list, options => options.IncludeGraph = true);
}

```
{% include component-try-it.html href='https://dotnetfiddle.net/spN4T5' %}

 - It will insert a list of invoices including all the invoices items for each invoice.
