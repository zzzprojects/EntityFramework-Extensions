# Key

## AllowDuplicateKeys
Gets or sets if a duplicate key is possible in the source.


```csharp
context.BulkMerge(list,options => {
				options.ColumnPrimaryKeyExpression = customer => customer.Name;
				options.AllowDuplicateKeys = true;
			});
```
{% include component-try-it.html href='https://dotnetfiddle.net/tvZXih' %}

## AllowUpdatePrimaryKeys
Gets or sets if the key must also be included in columns to `UPDATE`.


```csharp
context.BulkSaveChanges(options => options.AllowUpdatePrimaryKeys = true);
```
