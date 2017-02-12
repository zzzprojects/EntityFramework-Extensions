---
layout: default
title: SqlBulkCopy - Oracle
permalink: oracle
---

{% include template-h1.html %}

## Problem

You found out SqlBulkCopy is not supported for Oracle.

But you still want to know what's the **fastest way to insert** in Oracle using one theses providers:

- Oracle.DataAccess
- Oracle.ManagedDataAccess
- [Devart.Data.Oracle](https://www.devart.com/dotconnect/oracle/){:target="_blank"}

## Solution
Proposed solution:

- [OracleBulkCopy](#solution---oraclebulkcopy) _(Not recommended)_
- [OracleLoader](#solution---oracleloader) _(Not recommended)_
- [Array Bindings](#solution---array-bindings)
- [.NET Bulk Operations](#solution---net-bulk-operations-with-oracle)


## Solution - OracleBulkCopy
Documentation: https://docs.oracle.com/cd/E17666_01/doc/win.112/e17357/OracleBulkCopyClass.htm

This solution only supports the provider Oracle.DataAccess.

Due to the limitation and by experience! We highly recommend you to use the [Array Bindings solution](#solution---array-bindings) over OracleBulkCopy.

Limitation:

- SLOWER than Array Bindings solution (sometimes 3x slower!)
- DO NOT support Oracle.ManagedDataAccess
- DO NOT support all column types
- DO NOT check constraints
- DO NOT check triggers
- CANNOT perform INSERT RETURNING statement
- And a lot of more problem...

You can find some restriction here: [Oracle Bulk Copy](https://docs.oracle.com/cd/E51173_01/win.122/e17732/featBulkCopy.htm#ODPNT213){:target="_blank"}

{% include template-example.html %} 
{% highlight csharp %}
using (var connection = new OracleConnection(My.Config.ConnectionStrings.OracleBulkOperations))
{
    connection.Open();

    using (var bulk = new OracleBulkCopy(connection))
    {
        bulk.ColumnMappings.Add("TheColumnInt", "THECOLUMNINT");
        bulk.ColumnMappings.Add("TheColumnString", "THECOLUMNSTRING");
        bulk.DestinationTableName = "THEDESTINATIONTABLE";

        bulk.WriteToServer(dt);
    }
}
{% endhighlight %}

## Solution - OracleLoader
Documentation: http://www.devart.com/dotconnect/oracle/docs/?Devart.Data.Oracle~Devart.Data.Oracle.OracleLoader.html

This solution only supports the provider Devart.Data.Oracle.

Under the hood, the OracleLoader use the OracleBulkCopy. So for the same limitation reason, we recommend using Array Binding over this solution.

## Solution - Array Bindings
This solution is supported by all providers. That is the fastest solution with the [.NET Bulk Operations](#solution---net-bulk-operations-with-oracle)

{% include template-example.html %} 
{% highlight csharp %}
using (var connection = new OracleConnection(My.Config.ConnectionStrings.OracleBulkOperations))
{
    connection.Open();

    using (var command = new OracleCommand())
    {
        command.ArrayBindCount = dt.Rows.Count;
        command.BindByName = true;
        command.Connection = connection;

        command.CommandText = "INSERT INTO THEDESTINATIONTABLE (THECOLUMNINT, THECOLUMNSTRING) VALUES (:THECOLUMNINT, :THECOLUMNSTRING)";
        command.Parameters.Add(":THECOLUMNINT", OracleDbType.Int32, dt.AsEnumerable().Select(x => x["TheColumnInt"]).ToArray(), ParameterDirection.Input);
        command.Parameters.Add(":THECOLUMNSTRING", OracleDbType.Varchar2, dt.AsEnumerable().Select(x => x["TheColumnString"]).ToArray(), ParameterDirection.Input);

        command.ExecuteNonQuery();
    }
}
{% endhighlight %}

## Solution - .NET Bulk Operations with Oracle
That is the **fastest** (use Array Bindings under the hood) and **easiest** solution.

All Oracle provider are supported:

- Oracle.DataAccess
- Oracle.ManagedDataAccess
- Devart.Data.Oracle


Even more, all bulk operations are supported:

- BulkInsert
- BulkUpdate
- BulkDelete
- BulkMerge

{% include template-example.html %} 
{% highlight csharp %}

// Easy to use
var bulk = new BulkOperation(connection);
bulk.BulkInsert(dt);
bulk.BulkUpdate(dt);
bulk.BulkDelete(dt);
bulk.BulkMerge(dt);

// Easy to customize
var bulk = new BulkOperation<Customer>(connection);
bulk.BatchSize = 1000;
bulk.ColumnInputExpression = c => new { c.Name,  c.FirstName };
bulk.ColumnOutputExpression = c => c.CustomerID;
bulk.ColumnPrimaryKeyExpression = c => c.Code;
bulk.BulkMerge(customers);

{% endhighlight %}
