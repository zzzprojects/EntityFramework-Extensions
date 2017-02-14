---
layout: default
title: Entity Framework Extensions - Licensing
permalink: licensing
---

{% include template-h1.html %}

## Licensing
Every month, a new monthly trial of the PRO Version is available to let you evaluate all its features without limitations.

Learn more about the **[PRO Version](http://entityframework-extensions.net/#pro)**

The monthly trial allows you to evaluate the library for several months before making a purchase.

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
Upon purchase completion, an email will be sent with your license key information.
{% include template-example.html %} 
{% highlight csharp %}
string licenseName = //... PRO license name
string licenseKey = //... PRO license key

Z.EntityFramework.Extensions.LicenseManager.AddLicense("[LicenseName]", "[LicenseKey]");
{% endhighlight %}

### Recommendation
- Use the config file to store your license name and license key.
- **Web App:** Use Application_Start in global.asax to activate your license.
- **WinForm App:** Use the main thread method to activate your license.
- **Win Service:** Use the OnStart method to activate your license

> The AddLicense must always be set before the first call to the library. Otherwise, the monthly trial will start.

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
