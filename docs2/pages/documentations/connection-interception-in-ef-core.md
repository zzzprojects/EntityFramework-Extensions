---
Permalink: connection-interception-in-ef-core
---

# Connection Interception

The `DbConnectionInterceptor` is a class that can receive notifications when Entity Framework uses a connection. You must override the method from this class.

To get this feature in your EF Core, install the [Z.EntityFramework.Extensions.EFCore](https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/) NuGet package or run the following command in **Package Manager Console**.

```csharp
PM> Install-Package Z.EntityFramework.Extensions.EFCore
```

## Create Interceptor

To implement connection interception, we need to create a custom interceptor and register it accordingly. Entity Framework will call it whenever a connection is used.

Let's create a new class `EFConnectionInterceptor` that implements `DbConnectionInterceptor` class which is available in [Z.EntityFramework.Extensions.EFCore](https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/).

```csharp
public class EFConnectionInterceptor : DbConnectionInterceptor
{
    public override void Opening(DbConnection connection, DbConnectionInterceptionContext interceptionContext)
    {
        base.Opening(connection, interceptionContext);
        LogInfo("EFConnectionInterceptor.Opening", interceptionContext.EventData.ToString());                
    }
    public override void Opened(DbConnection connection, DbConnectionInterceptionContext interceptionContext)
    {
        base.Opened(connection, interceptionContext);
        LogInfo("EFConnectionInterceptor.Opened", interceptionContext.EventData.ToString());
    }

    public override void Error(DbConnection connection, DbConnectionInterceptionContext interceptionContext, Exception exception)
    {
        base.Error(connection, interceptionContext, exception);
        LogInfo("EFConnectionInterceptor.Error", interceptionContext.EventData.ToString(), exception.Message);
    }

    public override void Closing(DbConnection connection, DbConnectionInterceptionContext interceptionContext)
    {
        base.Closing(connection, interceptionContext);
        LogInfo("EFConnectionInterceptor.Closing", interceptionContext.EventData.ToString());
    }

    public override void Closed(DbConnection connection, DbConnectionInterceptionContext interceptionContext)
    {
        base.Closed(connection, interceptionContext);
        LogInfo("EFConnectionInterceptor.Closed", interceptionContext.EventData.ToString());
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

This code writes connection information on the Console Window. The `DbConnectionInterceptionContext` currently have the followings properties: 

 - DbContext
 - EventData which contains all informations about this event.

## Register Interceptor

Once a class that implements the interception has been created it can be registered using the `DbInterception` class as shown below. 

```csharp
DbInterception.Add(new EFConnectionInterceptor());
```

You can add interceptors using the `DbInterception.Add` method anywhere in your code such as, `Application_Start` method or in the `DbConfiguration` class, etc.

 - Be careful not to execute `DbInterception.Add` for the same interceptor more than once, otherwise, you will get additional interceptor instances. 
 - For example, if you add the logging interceptor twice, you will see two logs for every SQL query.
 - In this example, we will register the interceptor in the `main` method.

You can also bind the interceptor to the context if you want to have information about context, but this step is optional.

```csharp

public static EFConnectionInterceptor ConnectionInterceptor = new EFConnectionInterceptor();

public class CurrentContext : DbContext
{
    public CurrentContext()
    {
        this.BindInterceptor(ConnectionInterceptor);
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
    DbInterception.Add(ConnectionInterceptor);

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

Let's run your application in debug mode, and you will see all the commands on the console window.

```csharp
Intercepted on: EFConnectionInterceptor.Opening:
        Opening connection to database 'TestDB' on server '(localdb)\ProjectsV13'.
Intercepted on: EFConnectionInterceptor.Opened:
        Opened connection to database 'TestDB' on server '(localdb)\ProjectsV13'.
Intercepted on: EFConnectionInterceptor.Closing:
        Closing connection to database 'TestDB' on server '(localdb)\ProjectsV13'.
Intercepted on: EFConnectionInterceptor.Closed:
        Closed connection to database 'TestDB' on server '(localdb)\ProjectsV13'.
Intercepted on: EFConnectionInterceptor.Opening:
        Opening connection to database 'TestDB' on server '(localdb)\ProjectsV13'.
Intercepted on: EFConnectionInterceptor.Opened:
        Opened connection to database 'TestDB' on server '(localdb)\ProjectsV13'.
Intercepted on: EFConnectionInterceptor.Closing:
        Closing connection to database 'TestDB' on server '(localdb)\ProjectsV13'.
Intercepted on: EFConnectionInterceptor.Closed:
        Closed connection to database 'TestDB' on server '(localdb)\ProjectsV13'.
```
