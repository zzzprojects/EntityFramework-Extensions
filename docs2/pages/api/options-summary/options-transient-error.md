---
permalink: transient-error
---

## RetryCount
Gets or sets the maximum number of operations retry when a transient error occurs.


```csharp
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
});
```

---

## RetryInterval
Gets or sets the interval to wait before retrying an operation when a transient error occurs.


```csharp
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
	options.RetryInterval = new TimeSpan(100);
});

```
