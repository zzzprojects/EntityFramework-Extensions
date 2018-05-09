---
permalink: use-audit
---

## Definition
Gets or sets if `INSERTED` and `DELETED` data from the database should be returned as `AuditEntries`.


```csharp
List<AuditEntry> auditEntries = new List<AuditEntry>();

context.BulkSaveChanges(options =>
{
	options.UseAudit = true;
	options.BulkOperationExecuted = bulkOperation => auditEntries.AddRange(bulkOperation.AuditEntries);
});
```

## Purpose
Logging old values and new values is often useful to keep history of changes in the database or file.

## FAQ

### Why enabling this option decreases the performance?
Enabling this option will require additional data to be returned from the database.