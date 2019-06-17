# AuditEntries

## Definition

The 'BulkOperation.AuditEntries' property which is of type `List<AuditEntry>` gets `UPDATED`, `INSERTED` and `DELETED` data from the database when `UseAudit` is enabled.

The following example assigns `AuditEntries` to local `List<AuditEntry>` variable `auditEntries` when the `BulkOperationExecuted` event is executed. 


```csharp
List<AuditEntry> auditEntries = new List<AuditEntry>();

context.BulkSaveChanges(options =>
{
    options.UseAudit = true;
    options.BulkOperationExecuted = bulkOperation => 
    {
        auditEntries.AddRange(bulkOperation.AuditEntries);
    };
});

foreach (var entry in auditEntries)
{
    foreach (var value in entry.Values)
    {
        var oldValue = value.OldValue;
        var newValue = value.NewValue;
    }
}
```
{% include component-try-it.html href='https://dotnetfiddle.net/WwQ7oZ' %}

## Purpose
Logging old value and a new value is often useful to keep a history of changes in the database or file.

## FAQ

### Why enabling this option decreases the performance?
Enabling this option will require additional data to be returned from the database.
