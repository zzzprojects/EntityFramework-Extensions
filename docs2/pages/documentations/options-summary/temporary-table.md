# Temporary Table

## TemporaryTableBatchByTable
Gets or sets the number of batches a temporary table can contain. This option may create multiple temporary tables when the number of batches to execute exceeds the specified limit.


```csharp
context.BulkSaveChanges(options =>
{
   options.TemporaryTableBatchByTable = 0; // unlimited
});
```
[Try it in EF6](https://dotnetfiddle.net/YjoyLn) | [Try it in EF Core](https://dotnetfiddle.net/Md4oAe)

## TemporaryTableInsertBatchSize
Gets or sets the number of records to use in a batch when inserting in a temporary table. This number is recommended to be high.


```csharp
context.BulkSaveChanges(options =>
{
   options.TemporaryTableInsertBatchSize = 50000;
});
```
[Try it in EF6](https://dotnetfiddle.net/0n66D0) | [Try it in EF Core](https://dotnetfiddle.net/uoGd8y)

## TemporaryTableMinRecord
Gets or sets the minimum number of records to use a temporary table instead of using SQL derived table.


```csharp
context.BulkSaveChanges(options =>
{
   options.TemporaryTableMinRecord = 25;
});
```
[Try it in EF6](https://dotnetfiddle.net/jkIJzF) | [Try it in EF Core](https://dotnetfiddle.net/YgKiT1)

## TemporaryTableSchemaName
Gets or sets the schema name to use for the temporary table.


```csharp
context.BulkSaveChanges(options =>
{
   options.TemporaryTableSchemaName = "zzz";
});
```
[Try it in EF6](https://dotnetfiddle.net/RjriRf) | [Try it in EF Core](https://dotnetfiddle.net/SWJi9t)

## TemporaryTableUseTableLock
Gets or sets if the temporary table must be locked when inserting records into it.


```csharp
context.BulkSaveChanges(options =>
{
   options.TemporaryTableUseTableLock = true;
});
```
[Try it in EF6](https://dotnetfiddle.net/z2Pg1K) | [Try it in EF Core](https://dotnetfiddle.net/PM2evv)

## UsePermanentTable
Gets or sets if the library should `create` and `drop` a permanent table instead of using a temporary table.


```csharp
context.BulkSaveChanges(options =>
{
   options.UsePermanentTable = true;
});
```
[Try it in EF6](https://dotnetfiddle.net/B5qNg5) | [Try it in EF Core](https://dotnetfiddle.net/XnYfP6)
