---
permalink: audit
---

## UseAudit
Gets or sets if `INSERTED` and `DELETED` data from the database should be returned as `AuditEntries`.

{% include template-example.html %} 
{% highlight csharp %}
List<AuditEntry> auditEntries = new List<AuditEntry>();

context.BulkSaveChanges(options =>
{
	options.UseAudit = true;
	options.BulkOperationExecuted = bulkOperation => auditEntries.AddRange(bulkOperation.AuditEntries);
});

{% endhighlight %}

---

## AuditEntries
Gets `INSERTED` and `DELETED` data when `UseAudit` option is enabled.

{% include template-example.html %} 
{% highlight csharp %}
List<AuditEntry> auditEntries = new List<AuditEntry>();

context.BulkSaveChanges(options =>
{
	options.UseAudit = true;
	options.BulkOperationExecuted = bulkOperation => auditEntries.AddRange(bulkOperation.AuditEntries);
});

foreach (var entry in auditEntries)
{
    foreach (var value in entry.Values)
    {
        var oldValue = value.OldValue;
        var newValue = value.NewValue;
    }
}
{% endhighlight %}