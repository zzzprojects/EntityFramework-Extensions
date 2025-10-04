# 📊 Benchmark Results – EF Core Bulk SaveChanges

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Operation:** Bulk SaveChanges  
* **EF Version:** EF Core 9.x  

⚠️ Notes  
* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection strings are defined in `appsettings.json`.  

---

## 🔹 SQL Server

![Benchmark EFCore vs EFE – SQL Server - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **SQL Server**, including plain SaveChanges and SaveChanges with graph.  

---

## 🔹 PostgreSQL

![Benchmark EFCore vs EFE – PostgreSQL - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **PostgreSQL**, including plain SaveChanges and SaveChanges with graph.  

---

## 🔹 MySQL

![Benchmark EFCore vs EFE – MySQL - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **MySQL**, including plain SaveChanges and SaveChanges with graph.  

---

## 🔹 MariaDB

![Benchmark EFCore vs EFE – MariaDB - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **MariaDB**, including plain SaveChanges and SaveChanges with graph.  

---

## 🔹 Oracle

![Benchmark EFCore vs EFE – Oracle - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **Oracle**, including plain SaveChanges and SaveChanges with graph.  

---

## 🔹 SQLite

![Benchmark EFCore vs EFE – SQLite - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **SQLite**, including plain SaveChanges and SaveChanges with graph.  

---

## 🏁 Conclusion

Across all providers, **Bulk SaveChanges with Entity Framework Extensions** consistently outperforms EF Core:  

* **Performance:** EF Extensions cuts SaveChanges execution time dramatically, especially when handling large entity graphs.  
* **Scalability:** By batching changes efficiently, Bulk SaveChanges reduces overhead and boosts performance for high-volume applications.  

For applications where **SaveChanges performance** is a bottleneck, EF Extensions provides reliable speed and scalability across every major database provider.  
