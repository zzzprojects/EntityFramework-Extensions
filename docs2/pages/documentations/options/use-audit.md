# UseAudit

## Definition

The `BulkOperation.UseAudit` property sets if `UPDATED`, `INSERTED` and `DELETED` data from the database should be returned as `AuditEntries`.

The following example sets `UseAudit` to `true` and assigns `AuditEntries` to local `List<AuditEntry>` variable `auditEntries` when the `BulkOperationExecuted` event is executed. 

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
```

{% include component-try-it.html href='https://dotnetfiddle.net/cIHYyb' %}

## Purpose
Logging old values and new values are often useful to keep a history of changes in the database or file.

## FAQ

### Why enabling this option decreases the performance?
Enabling this option will require additional data to be returned from the database.
