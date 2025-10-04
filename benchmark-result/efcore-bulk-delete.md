# 📊 Benchmark Results – EF Core Bulk Delete

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Operation:** Bulk Delete  
* **EF Version:** EF Core 9.x  

⚠️ Notes  
* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection strings are defined in `appsettings.json`.  

---

## 🔹 SQL Server

![Benchmark EFCore vs EFE – SQL Server - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **SQL Server**, including plain delete, delete with composite keys, and delete with graph.  
Entity Framework Extensions is consistently faster and uses less memory than EF Core.  

---

## 🔹 PostgreSQL

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **PostgreSQL**, including plain delete, delete with composite keys, and delete with graph.  
Entity Framework Extensions is significantly faster, with memory usage improvements that vary by scenario.  

---

## 🔹 MySQL

![Benchmark EFCore vs EFE – MySQL - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **MySQL**, including plain delete, delete with composite keys, and delete with graph.  
Entity Framework Extensions executes deletes much faster than EF Core and usually consumes less memory.  

---

## 🔹 MariaDB

![Benchmark EFCore vs EFE – MariaDB - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **MariaDB**, including plain delete, delete with composite keys, and delete with graph.  
Entity Framework Extensions is consistently faster than EF Core and generally more memory-efficient.  

---

## 🔹 Oracle

![Benchmark EFCore vs EFE – Oracle - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **Oracle**, including plain delete, delete with composite keys, and delete with graph.  
Entity Framework Extensions shows strong speed advantages, while memory usage is sometimes closer to EF Core.  

---

## 🔹 SQLite

![Benchmark EFCore vs EFE – SQLite - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **SQLite**, including plain delete, delete with composite keys, and delete with graph.  
Entity Framework Extensions is much faster and usually requires less memory than EF Core.  

---

## 🏁 Conclusion

Across all providers, **Bulk Delete with Entity Framework Extensions** consistently outperforms EF Core:  

* **Performance:** EF Extensions operations complete in a fraction of the time, especially when working with composite keys or graphs.  
* **Memory Usage:** EF Extensions generally uses less memory, though some providers (like Oracle) show memory usage closer to EF Core.  
* **Scalability:** Complex deletes involving graphs or composite keys benefit strongly, demonstrating EF Extensions’ ability to handle advanced scenarios.  

For applications where **deletion performance** is critical, EF Extensions provides dramatic improvements in both speed and efficiency across every major database provider.  
