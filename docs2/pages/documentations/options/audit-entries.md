# AuditEntries

## Definition

The `BulkOperation.AuditEntries` property which is of type `List<AuditEntry>` gets `UPDATED`, `INSERTED` and `DELETED` data from the database when `UseAudit` is enabled.

The following example sets `UseAudit` to `true` and assigns the list of `AuditEntries` to populate.

```csharp
List<AuditEntry> auditEntries = new List<AuditEntry>();

context.BulkSaveChanges(options =>
{
    options.UseAudit = true;
    options.AuditEntries = auditEntries;
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
Logging old and new values is often useful to keep a history of changes in the database or file.

## FAQ

### Why enabling this option decreases the performance?
Enabling this option will require additional data to be returned from the database.
