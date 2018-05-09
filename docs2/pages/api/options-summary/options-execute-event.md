# Execute Event

## BulkOperationExecuting
Gets or sets an action to execute `before` the bulk operation is executed.


```csharp
context.BulkSaveChanges(options => {
	options.BulkOperationExecuting = bulkOperation => { /* configuration */ };
});
```

---

## BulkOperationExecuted
Gets or sets an action to execute `after` the bulk operation is executed.


```csharp
context.BulkSaveChanges(options => {
	options.BulkOperationExecuted = bulkOperation => { /* configuration */ };
});
```
