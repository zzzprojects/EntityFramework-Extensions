Evaluate, Compile and Execute C# code at runtime.

## Url

- [Website](https://entityframework-extensions.net/)
- [Getting Started](https://entityframework-extensions.net/overview)
- [Documentation](https://entityframework-extensions.net/bulk-savechanges)
- [Online Examples](https://entityframework-extensions.net/online-examples)

## NuGet Packages

- EF Core: [https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/](https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/)
- EF6: [https://www.nuget.org/packages/Z.EntityFramework.Extensions/](https://www.nuget.org/packages/Z.EntityFramework.Extensions/)
- EF5: [https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF5/](https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF5/)
- EF4: [https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF4/](https://www.nuget.org/packages/Z.EntityFramework.Extensions.EF4/)

## Example BulkInsert

```csharp
// Easy to use
context.BulkInsert(customers);

// Easy to customize
context.BulkInsert(invoices, options => options.IncludeGraph = true);
```

- Try it (EF Core): [https://dotnetfiddle.net/2eVfFT](https://dotnetfiddle.net/2eVfFT)
- Try it (EF 6): [https://dotnetfiddle.net/bNektu](https://dotnetfiddle.net/bNektu)

## Example BulkMerge

```csharp
// Easy to use
context.BulkMerge(customers);

// Easy to customize
context.BulkMerge(customers, options => options.IncludeGraph = true);
```

- Try it (EF Core): [https://dotnetfiddle.net/v08Jzy](https://dotnetfiddle.net/v08Jzy)
- Try it (EF 6): [https://dotnetfiddle.net/Aodij2](https://dotnetfiddle.net/Aodij2)
