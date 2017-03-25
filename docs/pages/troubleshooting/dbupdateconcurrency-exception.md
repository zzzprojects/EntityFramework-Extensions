---
layout: default
title: DbUpdateConcurrency Exception
permalink: dbupdateconcurrency-exception
---

{% include template-h1.html %}

## Problem

You execute a method from the Entity Framework Extensions library, and the following error is thrown:

- Type: DbUpdateConcurrencyException

{% include template-exception.html message='Store update, insert, or delete statement affected an unexpected number of rows ([row count]). Entities may have been modified or deleted since entities were loaded. See http://go.microsoft.com/fwlink/?LinkId=472540 for information on understanding and handling optimistic concurrency exceptions.' %}

## Solution

### Cause

Another thread have already performed the operation.

### Fix

