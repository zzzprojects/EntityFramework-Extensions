# BulkInsert vs BulkSaveChanges

## What's the difference between BulkInsert and BulkSaveChanges?
BulkInsert will always be a lot faster than BulkSaveChanges.

BulkSaveChanges work like SaveChanges but faster. It uses the Change Tracker to get the list of entities and check the Entity State to know which operation should be performed. 

In counterpart, Bulk methods such as BulkInsert, BulkUpdate, and BulkDelete doesn't use the Change Tracker to make these methods as efficient as possible. It takes the list of entities from the parameter provided and doesn't care about the Entity State.

## Should I always use BulkInsert?
No! Even if BulkInsert is faster.

BulkSaveChanges even if slower makes everything easier. All you need to do is adding `Bulk` before `SaveChanges` and everything works as expected.

BulkInsert require more time to implement when you have several different lists to insert. You need to create/handle a transaction in your code and specify yourself the right order to save.

## We normally always recommend using BulkSaveChanges unless you want to boost even more the performance of a critical section.
How is transaction handled?

BulkSaveChanges as SaveChanges create an internal transaction. So, there is nothing to do.

BulkInsert doesn't create a transaction by default. If you want to save multiple lists, you will need to handle the transaction in your code.


```csharp
var transaction = context.Database.BeginTransaction();
try
{
	context.BulkInsert(list1);
	context.BulkInsert(list2);
	transaction.Commit();
}
catch
{
	transaction.Rollback();
}
```
