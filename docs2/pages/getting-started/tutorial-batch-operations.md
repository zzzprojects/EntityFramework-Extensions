# Bulk Operations

## Definition
Batch Operations method allows to perform `UPDATE` or `DELETE` operations directly in the database using a LINQ Query without loading entities in the context.

Everything is executed on the database side to let you get the best performance available.

Batch Operations Available:
- [DeleteFromQuery](delete-from-query)
- [UpdateFromQuery](update-from-query)

### Batch Operations Examples
```csharp
// DELETE all customers that are inactive for more than two years
context.Customers
    .Where(x => x.LastLogin < DateTime.Now.AddYears(-2))
    .DeleteFromQuery();
 
// UPDATE all customers that are inactive for more than two years
context.Customers
    .Where(x => x.Actif && x.LastLogin < DateTime.Now.AddYears(-2))
    .UpdateFromQuery(x => new Customer {Actif = false});
```

## Purpose
Updating or deleting data with SaveChanges requires to load data first which significantly reduces application performance.

It also becomes kind of weird to have to load an entity after deleting it.

Batch Operations are executed directly on the database side which provides the best performance available.

## Performance Comparisons

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| SaveChanges     | 1,000 ms       | 2,000 ms       | 5,000 ms       |
| DeleteFromQuery | 1 ms           | 1 ms           | 1 ms           |
| UpdateFromQuery | 1 ms           | 1 ms           | 1 ms           |
