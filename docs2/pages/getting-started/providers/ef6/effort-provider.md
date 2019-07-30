# Effort Provider

Effort (Entity Framework Fake ObjectContext Realization Tool) is the official In-Memory provider for Entity Framework Classic. 

 - It creates a fake or mock database that allows you to test the Business Logic Layer (BLL) without worrying about your Data Access Layer (DAL).
 - It is an ADO.NET provider that executes all the data operations on a lightweight in-process main memory database instead of a traditional external database.
 - PostgreSQL requires very minimum maintained efforts because of its stability.

## Install EFE

Let's create a new application using the **Console App (.NET Framework)** template and install [Z.EntityFramework.Extensions](https://www.nuget.org/packages/Z.EntityFramework.Extensions/). 

**Entity Framework Extensions (EFE)** library is available as a nuget package and you can install it using **Nuget Package Manager**.

In the **Package Manager Console** window, enter the following command.

```csharp
PM> Install-Package Z.EntityFramework.Extensions
```

You can also install EFE by right-clicking on your project in Solution Explorer and select **Manage Nuget Packages...**. 

<img src="https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/docs2/images/effort-1.png">

Search for **Z.EntityFramework.Extensions** and install the latest version by pressing the install button. 

## Install Effort

Install the [Effort.EF6](https://www.nuget.org/packages/Effort.EF6/) NuGet package by using the following command in **Package Manager Console** window.

```csharp
PM> Install-Package Effort.EF6
```

Similarly, you can also install [Effort.EF6](https://www.nuget.org/packages/Effort.EF6/) by right-clicking on your project in Solution Explorer and select **Manage Nuget Packages...**. 

<img src="https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/docs2/images/effort-2.png">

Search for **Effort.EF6** and install the latest version by pressing the install button. 

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
 - You can also customize certain Entity Framework behaviors. 

So, let's add a new `EntityContext` class which will inherit the `DbContext` class.

```csharp
public class EntityContext : DbContext
{
    public EntityContext()
    {
    }

    public EntityContext(DbConnection connection) : base(connection, true)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
}
```

This code creates a `DbSet` property for each entity set. In Entity Framework terminology, an entity set typically corresponds to a database table, and an entity corresponds to a row in the table.

Now, we are done with the required classes, to use Effort, you need to create a transient connection and use it for our context. 

```csharp
DbConnection connection = Effort.DbConnectionFactory.CreateTransient();
Z.EntityFramework.Extensions.EntityFrameworkManager.ContextFactory = context => new EntityContext(connection);
var context = new EntityContext(connection));
```

We are using a special connection, so we also need to let [Z.EntityFramework.Extensions](https://entityframework-extensions.net) library also know how to create a context by setting the `EntityFrameworkManager.ContextFactory`. 

Now, let's add some authors and books records to the database and then retrieve it.

```csharp
DbConnection connection = Effort.DbConnectionFactory.CreateTransient();
Z.EntityFramework.Extensions.EntityFrameworkManager.ContextFactory = context => new EntityContext(connection);

using (var context = new EntityContext(connection))
{
    context.Database.CreateIfNotExists();

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
                new Book { Title = "Advanced Topics in Machine Learning"}
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

    context.BulkInsert(authors, options => options.IncludeGraph = true);
}

using (var context = new EntityContext())
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

If you run the application, you will see that authors entities are successfully inserted into the database.
