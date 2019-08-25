# UseAudit

## Definition

The `BulkOperation.UseAudit` property sets if `UPDATED`, `INSERTED` and `DELETED` data from the database should be returned as `AuditEntries`.

The following example sets `UseAudit` to `true` and assigns the list of `AuditEntries` to populate.

```csharp
List<AuditEntry> auditEntries = new List<AuditEntry>();
            
context.BulkSaveChanges(options =>
{
    options.UseAudit = true;
    options.AuditEntries = auditEntries;
});
```

[Try it in EF6](https://dotnetfiddle.net/cIHYyb) | [Try it in EF Core](https://dotnetfiddle.net/WcLZPP)

## Purpose
Logging old and new values is often useful to keep a history of changes in the database or file.

## FAQ

### Why enabling this option decreases the performance?
Enabling this option will require additional data to be returned from the database.
