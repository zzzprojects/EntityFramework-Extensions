# Batch

### BatchSize

Batch size is the number of records in each batch. The rows in a batch are sent to the server at the end of each batch.

The `BatchSize` property gets or sets the number of records to use in a batch. The following example save bulk data in batches of 1000 rows. 

```csharp
context.BulkSaveChanges(options => options.BatchSize = 1000);
```
{% include component-try-it.html href='https://dotnetfiddle.net/BThvHs' %}

 - A batch is complete when `BatchSize` rows have been processed or there are no more rows to send to the destination data source.
 - The default value is zero which indicates that each operation is a single batch.

### BatchTimeout

Batch timeout is the number of seconds for the operation to complete before it times out.

The `BatchTimeout` gets or sets the maximum of time in seconds to wait for a batch before the command throws a timeout exception. The following example modifies the time-out to 180 seconds when bulk saving data.

```csharp
context.BulkSaveChanges(options => options.BatchTimeout = 180);
```
{% include component-try-it.html href='https://dotnetfiddle.net/HDmeWa' %}

### BatchDelayInterval

The batch delay interval is the delay between any two batch operations.

The `BatchDelayInterval` gets or sets a delay in milliseconds to wait between batches. The following example specifies the delay interval to 100 milliseconds between any two batch operations.

```csharp
context.BulkInsert(list, options => options.BatchDelayInterval = 100);
```
{% include component-try-it.html href='https://dotnetfiddle.net/65v3k3' %}
