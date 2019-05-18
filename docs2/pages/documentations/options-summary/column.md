# Column

## Column Input

The `ColumnInputExpression` allows you to choose specific properties of an entity in which you want to perform the bulk operations.

The following example inserts data to the database by specifying `Name` and `IsActive` properties using the `BulkInsert` operation.

```csharp
context.BulkInsert(list, 
        options => options.ColumnInputExpression = c => new { c.Name, c.IsActive }
);
```

The key is required for operation such as `BulkUpdate` and `BulkMerge`.

```csharp
context.BulkMerge(list, options => 
        options.ColumnInputExpression = c => new {c.CustomerID, c.Name, c.IsActive }
); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/lwF8DZ' %}

## Column Output

The `ColumnOutputExpression` allows you to choose specific properties in which you want to retrieve data from the database.

The following example uses `IsActive` property in the `ColumnInputExpression` and `Name` and `IsActive` properties in the `ColumnOutputExpression`. 

 - It will insert data only in the `IsActive` field and all other properties will remain `NULL` in the database.
 - In the `ColumnOutputExpression`, `Name` and `IsActive` properties are specified so it will update the specified properties from the database to the list.

```csharp
context.BulkInsert(list, options => {
        options.ColumnOutputExpression = c => new { c.Name, c.IsActive };
        options.ColumnInputExpression = c => new { c.IsActive };
}); 
```

 - Now as result you will see the `Name` property is `null`, that is because we have inserted data only for `IsActive`, and the `Name` field remains null in the database.
 - When the list was updated from the database, it replaces the value of `Name` and `IsActive` from the database and `Name` is `NULL` to the database.
 - The `Description` property is unchanged because it is not updated from the database.

{% include component-try-it.html href='https://dotnetfiddle.net/se3Vjk' %}

## Column InputOutput

The `ColumnInputOutputExpression` allows you to choose specific properties in which you want to perform the bulk operations with the direction `InputOutput`.

The key is required for operation such as `BulkUpdate` and `BulkMerge`. The following example uses `CustomerID`, `Description`, `IsActive` properties in the `ColumnInputOutputExpression`. 

```csharp
context.BulkMerge(list, 
        options => options.ColumnInputOutputExpression = c => new {c.CustomerID, c.Description, c.IsActive}
);
```

- It will merge data for `CustomerID`, `Description` and `IsActive` fields and all other properties will remain `NULL` in the database.
- It will also update the list by updating only the specified properties from the database.
-  
{% include component-try-it.html href='https://dotnetfiddle.net/40zGTH' %}

## Column Primary Key

The `ColumnPrimaryKeyExpression` allows you to choose a specific property or properties as a key to perform the bulk operations.

The following example uses `Login` and `Password` properties as a key to perform `BulkMerge`.

```csharp
context.BulkMerge(list, 
        options => options.ColumnPrimaryKeyExpression = customer => new { customer.Login, customer.Password }
); 
```

It will update those records for which the `Login` and `Password` already exists in the database and all the new records will be inserted to the database. 

{% include component-try-it.html href='https://dotnetfiddle.net/L1Wvep' %}

## Ignore On Merge Insert

The `IgnoreOnMergeInsertExpression` allows you to ignore some columns when the `BulkMerge` method executes the `insert` statement and these columns will only be used in `update` statement.

The following example ignores the `Description` property in insertion and will be considered when updating the records.

```csharp
context.BulkMerge(list, options => 
{
        options.IgnoreOnMergeInsertExpression = customer => new {customer.CustomerID,  customer.Description};
}); 
```
{% include component-try-it.html href='https://dotnetfiddle.net/ggtMXb' %}

## Ignore On Merge Update

The `IgnoreOnMergeUpdateExpression` allows you to ignore some columns when the `BulkMerge` method executes the `update` statement and these columns will only be used in `insert` statement.

The following example ignores the `Name` and `IsActive` properties while updating the records and will be considered during insertion.


```csharp
context.BulkMerge(list, options => 
{
        options.IgnoreOnMergeUpdateExpression = customer => new {customer.CustomerID, customer.IsActive, customer.Name};
});
```
{% include component-try-it.html href='https://dotnetfiddle.net/Z0xM1L' %}
