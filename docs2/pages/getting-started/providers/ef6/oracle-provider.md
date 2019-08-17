# Oracle Provider

Oracle Database is the first database designed for enterprise grid computing, the most flexible and cost-effective way to manage information and applications.

 - The database has logical structures and physical structures. 
 - The physical and logical structures are separate, and the physical storage of data can be managed without affecting the access to logical storage structures.

## Install EFE

Let's create a new application using the **Console App (.NET Framework)** template and install [Z.EntityFramework.Extensions](https://www.nuget.org/packages/Z.EntityFramework.Extensions/). 

**Entity Framework Extensions (EFE)** library is available as a nuget package and you can install it using **Nuget Package Manager**.

In the **Package Manager Console** window, enter the following command.

```csharp
PM> Install-Package Z.EntityFramework.Extensions
```

You can also install EFE by right-clicking on your project in Solution Explorer and select **Manage Nuget Packages...**. 

<img src="https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/docs2/images/postgresql-1.png">

Search for **Z.EntityFramework.Extensions** and install the latest version by pressing the install button. 

## Register EF Provider

EF providers can be registered using either code-based configuration or in the application's config file. Install the [Oracle.ManagedDataAccess.EntityFramework](https://www.nuget.org/packages/Oracle.ManagedDataAccess.EntityFramework/) NuGet package to add this reference automatically within `app.config` or `web.config` file during the installation.

```csharp
PM> Install-Package Oracle.ManagedDataAccess.EntityFramework
```

Let's open the `App.config` file.

```csharp
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
    <section name="entityFramework"
      type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
      requirePermission="false"/>
    <section name="oracle.manageddataaccess.client"
      type="OracleInternal.Common.ODPMSectionHandler, Oracle.ManagedDataAccess, Version=4.122.19.1, Culture=neutral, PublicKeyToken=89b483f429c47342"/>
  </configSections>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2"/>
  </startup>
  <entityFramework>
    <defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework"/>
    <providers>
      <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer"/>
      <provider invariantName="Oracle.ManagedDataAccess.Client"
        type="Oracle.ManagedDataAccess.EntityFramework.EFOracleProviderServices, Oracle.ManagedDataAccess.EntityFramework, Version=6.122.19.1, Culture=neutral, PublicKeyToken=89b483f429c47342"/>
    </providers>
  </entityFramework>
  <system.data>
    <DbProviderFactories>
      <remove invariant="Oracle.ManagedDataAccess.Client"/>
      <add name="ODP.NET, Managed Driver" invariant="Oracle.ManagedDataAccess.Client" description="Oracle Data Provider for .NET, Managed Driver"
        type="Oracle.ManagedDataAccess.Client.OracleClientFactory, Oracle.ManagedDataAccess, Version=4.122.19.1, Culture=neutral, PublicKeyToken=89b483f429c47342"/>
    </DbProviderFactories>
  </system.data>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <publisherPolicy apply="no"/>
        <assemblyIdentity name="Oracle.ManagedDataAccess" publicKeyToken="89b483f429c47342" culture="neutral"/>
        <bindingRedirect oldVersion="4.121.0.0 - 4.65535.65535.65535" newVersion="4.122.19.1"/>
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
  <oracle.manageddataaccess.client>
    <version number="*">
      <dataSources>
        <dataSource alias="SampleDataSource" descriptor="(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL))) "/>
      </dataSources>
    </version>
  </oracle.manageddataaccess.client>
  <connectionStrings>
    <add name="OracleDbContext" providerName="Oracle.ManagedDataAccess.Client"
      connectionString="User Id=oracle_user;Password=oracle_user_password;Data Source=oracle"/>
  </connectionStrings>
</configuration>
```

Note that often if the EF provider is installed from NuGet, then the NuGet package will automatically add this registration to the config file.

 - The **invariantName** in this registration is the same invariant name used to identify an ADO.NET provider. The invariant name `Oracle.ManagedDataAccess.Client`  is for Oracle.
 - The **type** in this registration is the assembly-qualified name of the provider type that derives from `Oracle.ManagedDataAccess.EntityFramework.EFOracleProviderServices`. 

You are now ready to start your application.
 
 ## Create Data Model
 
 Model is a collection of classes to interact with the database.

 - A model stores data that is retrieved according to the commands from the Controller and displayed in the View.
 - It can also be used to manipulate the data to implement the business logic.

To create a data model for our application, we will start with the following two entities.

```csharp
public class Author
{
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Book> Books { get; set; }
}

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }
}
```

There's a one-to-many relationship between `Author` and `Book` entities. In other words, an author can write any number of books, and a book can be written by only one author.

## Create Database Context

The database context class provides the main functionality to coordinate Entity Framework with a given data model. 

 - You create this class by deriving from the `System.Data.Entity.DbContext` class. 
 - In your code, you specify which entities are included in the data model. 
 - You can also customize certain Entity Framework behavior. 

So, let's add a new `BookStore` class which will inherit the `DbContext` class.

```csharp
public class BookStore : DbContext
{
    public BookStore() : base("OracleDbContext")
    {
    }
        
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("SYSTEM");
    }
}
```

 - This code creates a `DbSet` property for each entity set. 
 - In Entity Framework terminology, an entity set typically corresponds to a database table, and an entity corresponds to a row in the table.
 - In `OnModelCreating`, set the default schema, here we are using the `SYSTEM` user so the schema is `SYSTEM`.

## Setup Database

The name of the connection string is passed into the constructor of the context class.

```csharp
public BookStore() : base("OracleDbContext")
{
}
```
So, let's open the application `App.config` file and add a connectionStrings element.

```csharp
<connectionStrings>
  <add name="OracleDbContext" providerName="Oracle.ManagedDataAccess.Client"
    connectionString="User Id=SYSTEM;Password=mw;Data Source=SampleDataSource"/>
</connectionStrings>
```

The above connection string specifies that Entity Framework will use a `SYSTEM` user id and a SampleDataSource which is defined in `<dataSources>` tag. 

In this example, we are using Oracle Express, so we need to change the service name from `SERVICE_NAME=ORCL` to `SERVICE_NAME=XE`.

```csharp
<oracle.manageddataaccess.client>
  <version number="*">
    <dataSources>
      <dataSource alias="SampleDataSource" descriptor="(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE))) "/>
    </dataSources>
  </version>
</oracle.manageddataaccess.client>
```

Now, we are done with the required classes, so let's add some authors and book records to the database and then retrieve it.

```csharp
using (var context = new BookStore())
{
    context.Database.Delete();

    var authors = new List<Author>
    {
        new Author
        {
            FirstName ="Carson",
            LastName ="Alexander",
            BirthDate = DateTime.Parse("1985-09-01"),
            Books = new List<Book>()
            {
                new Book { Title = "Introduction to Machine Learning"},
                new Book { Title = "Advanced Topics on Machine Learning"},
                new Book { Title = "Introduction to Computing"}
            }
        },
        new Author
        {
            FirstName ="Meredith",
            LastName ="Alonso",
            BirthDate = DateTime.Parse("1970-09-01"),
            Books = new List<Book>()
            {
                new Book { Title = "Introduction to Microeconomics"}
            }
        },
        new Author
        {
            FirstName ="Arturo",
            LastName ="Anand",
            BirthDate = DateTime.Parse("1963-09-01"),
            Books = new List<Book>()
            {
                new Book { Title = "Calculus I"},
                new Book { Title = "Calculus II"}
            }
        }
    };

    //IncludeGraph allow you to INSERT/UPDATE/MERGE entities by including the child entities graph.
    context.BulkInsert(authors, options => options.IncludeGraph = true );
}

using (var context = new BookStore())
{
    var list = context.Authors
        .Include(a => a.Books)
        .ToList();

    foreach (var author in list)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);

        foreach (var book in author.Books)
        {
            Console.WriteLine("\t" + book.Title);
        }
    }
}
```

If you run the application, you will see that authors and books are successfully inserted into the database.
