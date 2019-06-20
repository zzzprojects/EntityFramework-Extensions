# Context Factory

The context factory is required to provide a working context to the EFE library. For example, this context will be used to retrieve some information by attaching/detaching entities without impacting the current context.
If your context has a default constructor (no parameter), specifying a context factory may be optional unless your context requires some special configuration.

### EF6/EF5/EF4
Having a default context constructor or specifying a context factory is only required with the following option:
- IncludeGraph

### EF Core
Having a default context constructor or specifying a context factory is always required.

## Context Factory
The context factory is a function `Func<DbContext, DbContext>` that provides the current DbContext as a parameter and require to return a new DbContext.
The current DbContext is passed in a parameter in case you need to create a working context that depends on the current context configuration or type.

```csharp
// Using the default constructor
EntityFrameworkManager.ContextFactory = context => new CurrentContext();
```
{% include component-try-it.html href='https://dotnetfiddle.net/6BQAzg' %}

```csharp
// Using a constructor that requires a connection string
EntityFrameworkManager.ContextFactory = context => new CurrentContext(My.ConnectionString);
```
{% include component-try-it.html href='https://dotnetfiddle.net/44eGOE' %}

```csharp
// Using a constructor that requires optionsBuilder (EF Core) 
EntityFrameworkManager.ContextFactory = context =>
{
	var optionsBuilder = new DbContextOptionsBuilder<EntityContext>();
	optionsBuilder.UseSqlServer(My.ConnectionString);
	return new EntityContext(optionsBuilder.Options);
};
`

```csharp
// Using a constructor that depends on the current context
EntityFrameworkManager.ContextFactory = context =>
{
	if (context is EntityContext)
	{
		return new EntityContext();
	}
	else
	{
		return new ElseContext();
	}
};
```
{% include component-try-it.html href='https://dotnetfiddle.net/fyTeS7' %}

## Default Constructor
If your context has a default constructor, you might now need to specify a context factory.


```csharp
public class EntitiesContext : DbContext
{
	public EntitiesContext() : base("CodeFirstEntities")
	{
		// I'm a default constructor!
	}
	
	// ...code...
}
```
{% include component-try-it.html href='https://dotnetfiddle.net/jEPrjg' %}
