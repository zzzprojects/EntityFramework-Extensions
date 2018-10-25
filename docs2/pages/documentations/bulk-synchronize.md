# Bulk Synchronize

## Definition
`SYNCHRONIZE` all entities from the database.

A synchronize is a mirror operation from the data source to the database. All rows that match the entity key are `UPDATED`, non-matching rows that exist from the source are `INSERTED`, non-matching rows that exist in the database are `DELETED`.

The database table becomes a mirror of the entity list provided.


```csharp
// Easy to use
ctx.BulkSynchronize(list);

// Easy to customize
context.BulkSynchronize(customers, options => options.ColumnPrimaryKeyExpression = customer => customer.Code);
```
{% include component-try-it.html href='https://dotnetfiddle.net/FTUTYa' %}

## Purpose
`Synchronizing` entities with the database is a very rare scenario, but it may happen when two databases need to be synchronized.

`BulkSynchronize` give you the scalability and flexibility required when if you encounter this situation.

## Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| BulkSynchronize | 55 ms          | 65 ms          | 85 ms          |

{% include section-faq-begin.html %}
## FAQ

### How can I specify more than one option?
You can specify more than one option using anonymous block.


```csharp
context.BulkSynchronize(list, options => {
	options.BatchSize = 100;
	options.ColumnInputExpression = c => new {c.ID, c.Name, c.Description};
});
```
{% include component-try-it.html href='https://dotnetfiddle.net/Ztz1qr' %}

### How can I specify the Batch Size?
You can specify a custom batch size using the `BatchSize` option.

Read more: [BatchSize](/batch-size)


```csharp
context.BulkSynchronize(list, options => options.BatchSize = 100);
```
{% include component-try-it.html href='https://dotnetfiddle.net/FzA4Zd' %}

### How can I specify custom columns to Synchronize?
You can specify custom columns using the `ColumnInputExpression` option.

Read more: [ColumnInputExpression](/column-input-expression)


```csharp
context.BulkSynchronize(list, options => options.ColumnInputExpression = c => new {c.Name, c.Description});
```
{% include component-try-it.html href='https://dotnetfiddle.net/FzA4Zd' %}

### How can I specify custom keys to use?
You can specify custom keys using the `ColumnPrimaryKeyExpression` option.

Read more: [ColumnPrimaryKeyExpression](/column-primary-key-expression)


```csharp
// Single Key
context.BulkSynchronize(customers, options => options.ColumnPrimaryKeyExpression = customer => customer.Code);

// Surrogate Key
context.BulkSynchronize(customers, options => options.ColumnPrimaryKeyExpression = customer => new { customer.Code1, customer.Code2 });
```
{% include section-faq-end.html %}

## Related Articles
- [How to Benchmark?](benchmark)
- [How to use Custom Column?](custom-column)
- [How to use Custom Key?](custom-key)
