# 📊 Benchmark Results – EF Core / SQL Server

* **Comparison:** EF Core vs Entity Framework Extensions
* **Provider:** SQL Server
* **EF Version:** EF Core 9.x

⚠️ Notes

* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).
* Results may vary depending on hardware, configuration, and dataset size.
* Connection string defined in `appsettings.json`.

---

## 🔹 Bulk Insert

![Benchmark EFCore vs EFE – SQL Server - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-insert.png)

**Description:**
This chart shows Bulk Insert benchmarks on **SQL Server**, including plain insert, insert with graph, and insert with keep identity.

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and uses only a fraction of the memory.

---

## 🔹 Bulk Update

![Benchmark EFCore vs EFE – SQL Server - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-update.png)

**Description:**
This chart shows Bulk Update benchmarks on **SQL Server**, including plain update and update with graph.

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and uses only a fraction of the memory.

---

## 🔹 Bulk Delete

![Benchmark EFCore vs EFE – SQL Server - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-delete.png)

**Description:**
This chart shows Bulk Delete benchmarks on **SQL Server**, including plain delete, delete with composite keys, and delete with graph.

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and uses only a fraction of the memory.

---

## 🔹 Bulk Merge

![Benchmark EFCore vs EFE – SQL Server - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-merge.png)

**Description:**
This chart shows Bulk Merge benchmarks on **SQL Server**, including plain merge and merge with graph.

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and uses only a fraction of the memory.

---

## 🔹 Bulk Synchronize

![Benchmark EFCore vs EFE – SQL Server - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-synchronize.png)

**Description:**
This chart shows Bulk Synchronize benchmarks on **SQL Server**.

Only Entity Framework Extensions is included, since EF Core has no equivalent method to compare.

---

## 🔹 Bulk SaveChanges

![Benchmark EFCore vs EFE – SQL Server - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-savechanges.png)

**Description:**
This chart shows Bulk SaveChanges benchmarks on **SQL Server**, including plain SaveChanges and SaveChanges with graph.

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and uses only a fraction of the memory.

## 🏁 Conclusion

Across all tested operations on **SQL Server**, Entity Framework Extensions consistently outperforms EF Core:

* **Performance:** EF Extensions methods complete in a fraction of the time compared to EF Core.
* **Memory Usage:** In most cases, EF Extensions also consumes far less memory, reducing pressure on the GC and improving overall scalability.
* **Features:** For certain scenarios like **Bulk Synchronize**, EF Extensions provides capabilities that EF Core does not offer at all.

For applications that need to process large datasets efficiently, EF Extensions delivers both speed and reliability, making it a strong choice for developers looking to push EF Core beyond its default limits.
