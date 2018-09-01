# Batch

### BatchSize
Gets or sets the number of records to use in a batch.


```csharp
context.BulkSaveChanges(options => options.BatchSize = 1000);
```
{% include component-try-it.html href='https://dotnetfiddle.net/BThvHs' %}

### BatchTimeout
Gets or sets the maximum of time in seconds to wait for a batch before the command throws a timeout exception.


```csharp
context.BulkSaveChanges(options => options.BatchTimeout = 180);
```
{% include component-try-it.html href='https://dotnetfiddle.net/HDmeWa' %}

### BatchDelayInterval
Gets or sets a delay in milliseconds to wait between batches.


```csharp
context.BulkInsert(list, options => options.BatchDelayInterval = 100);
```
{% include component-try-it.html href='https://dotnetfiddle.net/65v3k3' %}
