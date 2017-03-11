---
layout: default
title: Entity Framework Extensions - Licensing
permalink: licensing
---

{% include template-h1.html %}

## Evaluation Period
You can evaluate our library for several months before purchasing it.

The trial period stops at the end of the month. When you receive a license expiration error, download the latest version which will automatically extend your trial period.

You can also purchase the library [here](http://entityframework-extensions.net/#pro)

Upon purchase, you will receive a license name and a license key.

## Setup License from config file
The license name and key can be directly be added in the app.config or web.config file in the appSettings section.

{% include template-example.html %} 
{% highlight csharp %}
<appSettings>
	<add key="Z_EntityFramework_Extensions_LicenseName" value="[licenseName]"/>
	<add key="Z_EntityFramework_Extensions_LicenseKey" value="[licenseKey]"/>
</appSettings>
{% endhighlight %}

## Setup License from code
You can also set the license name and key directly in the code.

{% include template-example.html %} 
{% highlight csharp %}
Z.EntityFramework.Extensions.LicenseManager.AddLicense([licenseName], [licenseKey]);
{% endhighlight %}

### Recommendation
- Use the config file to store your license name and license key.
- **Web App:** Use Application_Start in global.asax to activate your license.
- **WinForm App:** Use the main thread method to activate your license.
- **Win Service:** Use the OnStart method to activate your license

> The AddLicense must always be set before the first call to the library. Otherwise, you will start the evaluation period

## How can I check if my license is valid?
The validate method allow you to know whether your license is valid or not.
{% include template-example.html %} 
{% highlight csharp %}
// CHECK for default provider (SQL Server)
string licenseErrorMessage;
if (!Z.EntityFramework.Extensions.LicenseManager.ValidateLicense(out licenseErrorMessage))
{
    throw new Exception(licenseErrorMessage);
}

// CHECK for a specific provider
string licenseErrorMessage;
if (!Z.EntityFramework.Extensions.LicenseManager.ValidateLicense(out licenseErrorMessage, ProviderType.MySql))
{
   throw new Exception(licenseErrorMessage);
}
{% endhighlight %}

Another way to check if your license is valid is simply adding an invalid license instead.

The following error should be raised:

> ERROR_001: The provided license key is invalid or trial period is expired. Please buy a product license or go to http://www.zzzprojects.com and download the latest trial version. License Count: 1
