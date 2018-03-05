---
permalink: out-of-memory
---

## Problem

You execute a method from the Entity Framework Extensions library, and the following error is thrown:

{% include template-exception.html message='An exception of type `System.OutOfMemoryException` occured in...' %}

## Cause
That error is caused when the library consumes too much memory.

Most of the time, this error is caused by some methods used from `Entity Framework` for command generations that will be used later by our library.

### Fix
Turning off Entity Framework Propagation

This solution work with around 99% of model. By turning off this options, our library doesn’t longer use several methods from Entity Framework that consume high memory such as the command generations.

See: <a href="/improve-bulk-savechanges">Improve BulkSaveChanges</a>

### Bulk Operations
In some exceptional scenario, using Bulk Operations such as:

- BulkInsert
- BulkUpdate
- BulkDelete
- BulkMerge

might may a better idea. They are faster and consume way less memory than BulkSaveChanges.

### Reduce the number of entities in the ChangeTracker
Another way is to make sure the ChangeTracker doesn’t contain too many entities.

The ChangeTracker has not been build to support millions entities.