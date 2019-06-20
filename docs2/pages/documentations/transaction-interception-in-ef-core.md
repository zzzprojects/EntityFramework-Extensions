---
Permalink: transaction-interception-in-ef-core
---

# Transaction Interception

The `DbTransactionInterceptor` is a class that can receive notifications when Entity Framework uses a transaction. You must override the method from this class.

To get this feature in your EF Core, install the [Z.EntityFramework.Extensions.EFCore](https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/) NuGet package or run the following command in **Package Manager Console**.

```csharp
PM> Install-Package Z.EntityFramework.Extensions.EFCore
```

## Create Interceptor

To implement transaction interception, we need to create a custom interceptor and register it accordingly. Entity Framework will call it whenever a transaction is used.

Let's create a new class `EFTransactionInterceptor` that implements `DbTransactionInterceptor` class which is available in [Z.EntityFramework.Extensions.EFCore](https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/).

```csharp
public class EFTransactionInterceptor : DbTransactionInterceptor
{
    public override void Committed(DbTransaction transaction, DbTransactionInterceptionContext interceptionContext)
    {
        base.Committed(transaction, interceptionContext);
        LogInfo("EFTransactionInterceptor.Committed", interceptionContext.EventData.ToString());
    }

    public override void Disposed(DbTransaction transaction, DbTransactionInterceptionContext interceptionContext)
    {
        base.Disposed(transaction, interceptionContext);
        LogInfo("EFTransactionInterceptor.Disposed", interceptionContext.EventData.ToString());
    }

    public override void Error(DbTransaction transaction, DbTransactionInterceptionContext interceptionContext, Exception exception)
    {
        base.Error(transaction, interceptionContext, exception);
        LogInfo("EFTransactionInterceptor.Error", interceptionContext.EventData.ToString(), exception.Message);
    }

    public override void RolledBack(DbTransaction transaction, DbTransactionInterceptionContext interceptionContext)
    {
        base.RolledBack(transaction, interceptionContext);
        LogInfo("EFTransactionInterceptor.RolledBack", interceptionContext.EventData.ToString());
    }

    public override void Started(DbTransaction transaction, DbTransactionInterceptionContext interceptionContext)
    {
        base.Started(transaction, interceptionContext);
        LogInfo("EFTransactionInterceptor.Started", interceptionContext.EventData.ToString());
    }

    public override void Used(DbTransaction transaction, DbTransactionInterceptionContext interceptionContext)
    {
        base.Used(transaction, interceptionContext);
        LogInfo("EFTransactionInterceptor.Used", interceptionContext.EventData.ToString());
    }

    private void LogInfo(string method, string data)
    {
        Console.WriteLine("Intercepted on: {0}: \n\t{1}", method, data);
    }

    private void LogInfo(string method, string data, string exception)
    {
        Console.WriteLine("Intercepted on: {0}: \n\t{1} \n\t{2}", method, data, exception);
    }
}
```

This code writes connection information on the Console Window. The `DbConnectionInterceptionContext` currently have the following properties: 

 - DbContext
 - EventData which contains all information about this event.

## Register Interceptor

Once a class that implements the interception has been created it can be registered using the `DbInterception` class as shown below. 

```csharp
DbInterception.Add(new EFTransactionInterceptor());
```

You can add interceptors using the `DbInterception.Add` method anywhere in your code such as, `Application_Start` method or in the `DbConfiguration` class, etc.

 - Be careful not to execute `DbInterception.Add` for the same interceptor more than once, otherwise, you will get additional interceptor instances. 
 - For example, if you add the logging interceptor twice, you will see two logs for every SQL query.
 - In this example, we will register the interceptor in the `main` method.

You can also bind the interceptor to the context if you want to have information about context, but this step is optional.

```csharp
public static EFTransactionInterceptor TransactionInterceptor = new EFTransactionInterceptor();

public class CurrentContext : DbContext
{
    public CurrentContext()
    {
        this.BindInterceptor(TransactionInterceptor);
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=TestDB;");
    }
}
```

Now let's insert some data to the database and then retrieve the data from the database.

```csharp
static void Main(string[] args)
{
    DbInterception.Add(TransactionInterceptor);

    using (var context = new CurrentContext())
    {
        var list = new List<Customer>();

        list.Add(new Customer() { Name = "Customer_A", IsActive = true });
        list.Add(new Customer() { Name = "Customer_B", IsActive = true });
        list.Add(new Customer() { Name = "Customer_C", IsActive = true });

        context.Customers.AddRange(list);
        context.SaveChanges();
    }

    using (var context = new CurrentContext())
    {
        var list = context.Customers.ToList();
    }
}
```

Let's run your application in debug mode, and you will see all the information related to transaction on the console window.

```csharp
Intercepted on: EFTransactionInterceptor.Started:
        Beginning transaction with isolation level 'ReadCommitted'.
Intercepted on: EFTransactionInterceptor.Committed:
        Committing transaction.
Intercepted on: EFTransactionInterceptor.Disposed:
        Disposing transaction.
```
