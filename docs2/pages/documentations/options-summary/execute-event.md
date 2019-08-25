# Execute Event

## BulkOperationExecuting
Gets or sets an action to execute `before` the bulk operation is executed.


```csharp
context.BulkSaveChanges(options => {
	options.BulkOperationExecuting = bulkOperation => { /* configuration */ };
});
```

[Try it in EF6](https://dotnetfiddle.net/mIhWyT) | [Try it in EF Core](https://dotnetfiddle.net/TEE4xQ)

## BulkOperationExecuted
Gets or sets an action to execute `after` the bulk operation is executed.


```csharp
context.BulkSaveChanges(options => {
	options.BulkOperationExecuted = bulkOperation => { /* configuration */ };
});
```

[Try it in EF6](https://dotnetfiddle.net/u3MlB7) | [Try it in EF Core](https://dotnetfiddle.net/wnXwJF)
