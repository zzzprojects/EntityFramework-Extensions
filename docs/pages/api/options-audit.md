---
layout: default
title: Entity Framework Extensions - Audit
permalink: audit
---

{% include template-h1.html %}

## Audit Options
- [UseAudit](#useaudit)

## UseAudit
Allow you to output inserted/deleted data from the database.

This feature does not use the ChangeTracker. It takes value directly from the database.

- Default Value: False

### Example
{% include template-example.html %} 
{% highlight csharp %}
List<AuditEntry> auditEntries = new List<AuditEntry>();
using (var ctx = new EntitiesContext())
{
    ctx.BulkSaveChanges(list, operation =>
    {
        operation.UseAudit = true;
        operation.BulkOperationExecuted = bulkOperation => auditEntries.AddRange(bulkOperation.AuditEntries);
    });
}

foreach (var entry in auditEntries)
{
    foreach (var value in entry.Values)
    {
        var oldValue = value.OldValue;
        var newValue = value.NewValue;
    }
}
{% endhighlight %}

> WARNING: Enabling this feature will slow down considerably the performance of Bulk Operations
