# Transient Error

## RetryCount
Gets or sets the maximum number of operations retry when a transient error occurs.


```csharp
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
});
```
{% include component-try-it.html href='https://dotnetfiddle.net/BJJKFg' %}

## RetryInterval
Gets or sets the interval to wait before retrying an operation when a transient error occurs.


```csharp
context.BulkSaveChanges(options => {
	options.RetryCount = 3;
	options.RetryInterval = new TimeSpan(100);
});

```
{% include component-try-it.html href='https://dotnetfiddle.net/wy84D5' %}
