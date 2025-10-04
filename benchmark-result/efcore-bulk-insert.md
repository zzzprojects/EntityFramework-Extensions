# 📊 Benchmark Results – EF Core Bulk Insert

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Operation:** Bulk Insert  
* **EF Version:** EF Core 9.x  

⚠️ Notes  
* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection strings are defined in `appsettings.json`.  

---

## 🔹 SQL Server

![Benchmark EFCore vs EFE – SQL Server - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **SQL Server**, including plain insert, insert with graph, and insert with keep identity.  
Entity Framework Extensions is significantly faster than EF Core and uses only a fraction of the memory.  

---

## 🔹 PostgreSQL

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **PostgreSQL**, including plain insert, insert with graph, and insert with keep identity.  
Entity Framework Extensions consistently outperforms EF Core, with memory usage improvements that vary by scenario.  

---

## 🔹 MySQL

![Benchmark EFCore vs EFE – MySQL - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **MySQL**, including plain insert, insert with graph, and insert with keep identity.  
Entity Framework Extensions executes inserts much faster than EF Core and often uses less memory.  

---

## 🔹 MariaDB

![Benchmark EFCore vs EFE – MariaDB - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **MariaDB**, including plain insert, insert with graph, and insert with keep identity.  
Entity Framework Extensions is consistently faster and usually more memory-efficient than EF Core.  

---

## 🔹 Oracle

![Benchmark EFCore vs EFE – Oracle - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **Oracle**, including plain insert, insert with graph, and insert with keep identity.  
Entity Framework Extensions is significantly faster than EF Core, though memory gains are less consistent than with other providers.  

---

## 🔹 SQLite

![Benchmark EFCore vs EFE – SQLite - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **SQLite**, including plain insert, insert with graph, and insert with keep identity.  
Entity Framework Extensions achieves clear speed improvements, with memory usage generally lower than EF Core.  

---

## 🏁 Conclusion

Across all providers, **Bulk Insert with Entity Framework Extensions** shows dramatic performance improvements compared to EF Core:  

* **Performance:** In every database tested, EF Extensions executes inserts several times faster than EF Core, especially at higher entity counts.  
* **Memory Usage:** EF Extensions usually consumes less memory, though results vary slightly across providers (Oracle tends to be closer to EF Core).  
* **Scalability:** Complex scenarios such as inserts with graph or keep identity benefit greatly from EF Extensions, making it the preferred choice for bulk operations.  

For applications where **insert performance** is critical, EF Extensions provides consistent speed and efficiency gains across all major database providers.  
