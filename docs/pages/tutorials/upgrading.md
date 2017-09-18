---
layout: dev
title: Upgrading
permalink: upgrading
---

{% include template-h1.html %}

All our release are normally backward compatible to make it very easy for you to upgrade.

## Step 1 - Before Upgrading
Before upgrading:
- Make sure to read [release notes](https://github.com/zzzprojects/EntityFramework-Extensions/releases)
- **NEVER** upgrade to production without testing in a development environment first

## Step 2 - NuGet Download

Choose the Entity Framework version and the Package Manager you want to use to download **Entity Framework Extensions**.

### Entity Framework Core (EF Core)
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-efcore-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-efcore-d.svg" alt="" /></a>

<div class="block-download">
	<!-- nav-tabs -->
	<ul class="nav nav-tabs" role="tablist">
		<li class="nav-item">
			<a class="nav-link active nav-tab-item" href="#download-nuget-core" role="tab" data-toggle="tab" aria-expanded="true">NuGet</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-net-cli-core" role="tab" data-toggle="tab" aria-expanded="false">.NET CLI</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-paket-cli-core" role="tab" data-toggle="tab" aria-expanded="false">Paket CLI</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-direct-download-core" role="tab" data-toggle="tab" aria-expanded="false">Direct Download</a>
		</li>
	</ul>

	<!-- tab-content -->
	<div class="tab-content">
		<div role="tabpanel" class="tab-pane fade in active show" id="download-nuget-core" aria-expanded="true">
			<code>PM> Install-Package Z.EntityFramework.Extensions.EFCore</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-net-cli-core" aria-expanded="false">
			<code>> dotnet add package Z.EntityFramework.Extensions.EFCore</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-paket-cli-core" aria-expanded="false">
			<code>> paket add Z.EntityFramework.Extensions.EFCore</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-direct-download-core" aria-expanded="false">
			<a href="https://www.nuget.org/api/v2/package/Z.EntityFramework.Extensions.EFCore/">Z.EntityFramework.Extensions.EFCore</a>&nbsp;<span class="font-italic">(Unzip the "nupkg" after downloading)</span>
		</div>
	</div>
</div>

<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/">View on NuGet</a>

### Entity Framework 6 (EF6)

<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-d.svg" alt="" /></a>

<div class="block-download">
	<!-- nav-tabs -->
	<ul class="nav nav-tabs" role="tablist">
		<li class="nav-item">
			<a class="nav-link active nav-tab-item" href="#download-nuget-ef6" role="tab" data-toggle="tab" aria-expanded="true">NuGet</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-net-cli-ef6" role="tab" data-toggle="tab" aria-expanded="false">.NET CLI</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-paket-cli-ef6" role="tab" data-toggle="tab" aria-expanded="false">Paket CLI</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-direct-download-ef6" role="tab" data-toggle="tab" aria-expanded="false">Direct Download</a>
		</li>
	</ul>

	<!-- tab-content -->
	<div class="tab-content">
		<div role="tabpanel" class="tab-pane fade in active show" id="download-nuget-ef6" aria-expanded="true">
			<code>PM> Install-Package Z.EntityFramework.Extensions</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-net-cli-ef6" aria-expanded="false">
			<code>> dotnet add package Z.EntityFramework.Extensions</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-paket-cli-ef6" aria-expanded="false">
			<code>> paket add Z.EntityFramework.Extensions</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-direct-download-ef6" aria-expanded="false">
			<a href="https://www.nuget.org/api/v2/package/Z.EntityFramework.Extensions/">Z.EntityFramework.Extensions Download</a>&nbsp;<span class="font-italic">(Unzip the "nupkg" after downloading)</span>
		</div>
	</div>
</div>

<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions/">View on NuGet</a>

### Entity Framework 5 (EF 5)

<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF5/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-ef5-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF5/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/entity-framework-extensions-ef5-d.svg" alt="" /></a>

<div class="block-download">
	<!-- nav-tabs -->
	<ul class="nav nav-tabs" role="tablist">
		<li class="nav-item">
			<a class="nav-link active nav-tab-item" href="#download-nuget-ef5" role="tab" data-toggle="tab" aria-expanded="true">NuGet</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-net-cli-ef5" role="tab" data-toggle="tab" aria-expanded="false">.NET CLI</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-paket-cli-ef5" role="tab" data-toggle="tab" aria-expanded="false">Paket CLI</a>
		</li>
		<li class="nav-item">
			<a class="nav-link nav-tab-item" href="#download-direct-download-ef5" role="tab" data-toggle="tab" aria-expanded="false">Direct Download</a>
		</li>
	</ul>

	<!-- tab-content -->
	<div class="tab-content">
		<div role="tabpanel" class="tab-pane fade in active show" id="download-nuget-ef5" aria-expanded="true">
			<code>PM> Install-Package Z.EntityFramework.Extensions.EF5</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-net-cli-ef5" aria-expanded="false">
			<code>> dotnet add package Z.EntityFramework.Extensions.EF5</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-paket-cli-ef5" aria-expanded="false">
			<code>> paket add Z.EntityFramework.Extensions.EF5</code>
		</div>
		<div role="tabpanel" class="tab-pane fade" id="download-direct-download-ef5" aria-expanded="false">
			<a href="https://www.nuget.org/api/v2/package/Z.EntityFramework.Extensions.EF5/">Z.EntityFramework.Extensions.EF5 Download</a>&nbsp;<span class="font-italic">(Unzip the "nupkg" after downloading)</span>
		</div>
	</div>
</div>

<a href="https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF5/">View on NuGet</a>