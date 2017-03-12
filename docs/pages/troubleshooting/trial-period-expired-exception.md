---
layout: default
title: Trial Period Expired Exception
permalink: trial-period-expired-exception
---

{% include template-h1.html %}

## Problem

You execute a method from the Entity Framework Extensions library, and the following error is thrown:

{% include template-exception.html message='ERROR_005: The monthly trial period is expired. You can extend your trial by downloading the latest version. You can also purchase a perpetual license on our website. If you already own this license, this error only appears if the license has not been found, you can find additional information on our troubleshooting section (http://entityframework-extensions.net/troubleshooting). Contact our support team for more details: info@zzzprojects.com' %}

## Solution

### Cause

- You are currently evaluating the library and the trial period is expired
- You have purchased a library but didn't register the license correctly

### Fix

#### Trial Period Expired

You can extended indefinetly the trial period by downloading the latest version:

http://entityframework-extensions.net/upgrading

#### License Badly Registered

Make sure to follow recommandation how to setup your license:
http://entityframework-extensions.net/licensing

Otherwise, contact us: info@zzzprojects.com
