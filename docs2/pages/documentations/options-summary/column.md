# Column

## Column Input
Gets or sets columns to map with the direction `Input`.

The key is required for operation such as `BulkUpdate` and `BulkMerge`.


```csharp
context.BulkMerge(list, options => 
        options.ColumnInputExpression = entity => new {entity.ID, entity.Code}
); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/lwF8DZ' %}

## Column Output
Gets or sets columns to map with the direction `Output`.


```csharp
context.BulkMerge(list, options => 
        options.ColumnOutputExpression = entity => new {entity.ModifiedDate, entity.ModifiedUser}
); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/se3Vjk' %}

## Column InputOutput
Gets or sets columns to map with the direction `InputOutput`.

The key is required for operation such as `BulkUpdate` and `BulkMerge`.


```csharp
context.BulkMerge(list, options => 
        options.ColumnInputOutputExpression = entity => new {entity.ID, entity.Code}
); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/40zGTH' %}

## Column Primary Key
Gets or sets columns to use as the `key` for the operation.


```csharp
context.BulkMerge(list, options => 
        options.ColumnPrimaryKeyExpression = entity => new { entity.Code1, entity.Code2 }
); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/L1Wvep' %}

## Ignore On Merge Insert
Gets or sets columns to ignore when the `BulkMerge` method executes the `insert` statement.


```csharp
context.BulkMerge(list, options => 
        options.IgnoreOnMergeInsertExpression = entity => new {entity.ModifiedDate, entity.ModifiedUser}
); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/ggtMXb' %}

## Ignore On Merge Update
Gets or sets columns to ignore when the `BulkMerge` method executes the `update` statement.


```csharp
context.BulkMerge(list, options => 
        options.IgnoreOnMergeUpdateExpression = entity => new {entity.CreatedDate, entity.CreatedUser}
); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/Z0xM1L' %}
