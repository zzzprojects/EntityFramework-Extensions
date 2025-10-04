# 📊 Benchmark Results – EF Core Bulk Synchronize

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Operation:** Bulk Synchronize  
* **EF Version:** EF Core 9.x  

⚠️ Notes  
* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection strings are defined in `appsettings.json`.  
* EF Core does not provide a native **Bulk Synchronize** method, so only EF Extensions is shown.  

---

## 🔹 SQL Server

![Benchmark EFCore vs EFE – SQL Server - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **SQL Server**.  
Entity Framework Extensions enables full synchronization between datasets and tables, a feature not available in EF Core.  

---

## 🔹 PostgreSQL

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **PostgreSQL**.  
Entity Framework Extensions performs efficient synchronization, which EF Core does not support natively.  

---

## 🔹 MySQL

![Benchmark EFCore vs EFE – MySQL - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **MySQL**.  
Entity Framework Extensions allows table synchronization scenarios that EF Core cannot handle directly.  

---

## 🔹 MariaDB

![Benchmark EFCore vs EFE – MariaDB - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **MariaDB**.  
Entity Framework Extensions introduces advanced synchronization functionality not included in EF Core.  

---

## 🔹 Oracle

![Benchmark EFCore vs EFE – Oracle - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **Oracle**.  
Entity Framework Extensions enables merge-style synchronization, a feature EF Core lacks.  

---

## 🔹 SQLite

![Benchmark EFCore vs EFE – SQLite - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **SQLite**.  
Entity Framework Extensions makes it possible to perform efficient synchronization in SQLite, which EF Core cannot do natively.  

---

## 🏁 Conclusion

Across all providers, **Bulk Synchronize is an exclusive feature of Entity Framework Extensions**:  

* **Performance:** EF Extensions efficiently synchronizes large datasets with database tables, combining insert, update, and delete operations in a single step.  
* **Memory Usage:** Synchronization is optimized to minimize allocations, keeping resource usage reasonable even on large datasets.  
* **Features:** Since EF Core has no equivalent, EF Extensions provides unique functionality essential for scenarios requiring data reconciliation.  

For applications where **data synchronization** is critical, EF Extensions is the only option, delivering high performance and scalability across all major database providers.  
