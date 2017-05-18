---
layout: default
title: Foreign Key Constraint + AutoDectectChanges Disabled
permalink: foreign-key-constraint-autodetectchanges-disabled
---

{% include template-h1.html %}

## Problem

You execute a method from the Entity Framework Extensions library, and the following error is thrown:

{% include template-exception.html message='The MERGE statement conflicted with the FOREIGN KEY constraint "[FK_Name]". The conflict occurred in database "[Database_Name]", table "[Table_Name]", column \'[Column_Name]\'.' %}

{% highlight csharp %}
using (var ctx = new MyEntities())
{
	ctx.Configuration.AutoDetectChangesEnabled = false;
	ctx.Categories.AddRange(categories);
	ctx.Items.AddRange(items);
	ctx.BulkSaveChanges();
}
{% endhighlight %}

## Solution

### Cause

One cause could be simply a wrong save order provided by either Entity Framework or our library.

### Cause Source
The main reason that could cause this issue is disabling AutoDetectChanges and not enabling it before the SaveChanges/BulkSaveChanges.

In your example you provided, there is no reason why you should disable DetectChanges. Since you use the AddRange method, the “DetectChanges” method is called only once, so you don’t suffer from performance issue from it (way less..).

When the AutoDetectChanges is disabled, there is no check about the relationship, and that could cause sometime the ScenarioItem to be added before a new ScenarioCategory! That will obviously lead to cause the Foreign Key issue.

### Fix

1.	ADD the line AutoDectectChangesEnabled = true; before BulkSaveChanges
2.	REMOVE the line AutoDetectChangesEnabled = false;
