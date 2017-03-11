---
layout: default
title: Entity Framework Extensions - Installing
permalink: installing
---

{% include template-h1.html %}

## Installing
Is it the first time you use our Library?

Don't worry. People love our library because it's so easy to use.


## Step 1 - NuGet Download

Entity Framework Extensions is only available through NuGet

<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-d.svg" alt="" /></a>

> PM> Install-Package Z.EntityFramework.Extensions

## Step 2 - Have Fun!

No configuration is required!

Following extension methods are automatically added to DbContext:
- BulkSaveChanges
- BulkInsert
- BulkUpdate
- BulkDelete
- BulkMerge
- BulkSynchronize

{% include template-example.html %} 
{% highlight csharp %}
ctx.BulkSaveChanges();
ctx.BulkInsert(list);
ctx.BulkUpdate(list);
ctx.BulkDelete(list);
ctx.BulkMerge(list);
ctx.BulkSynchronize(list);
{% endhighlight %}

Following extension methods are automatically added to IQueryable:
- DeleteFromQuery
- UpdateFromQuery

{% include template-example.html %} 
{% highlight csharp %}
ctx.Customers.Where(x => !x.IsActif).DeleteFromQuery();
ctx.Customers.Where(x => !x.IsActif).UpdateFromQuery(x => new Customer {Actif = true});
{% endhighlight %}
