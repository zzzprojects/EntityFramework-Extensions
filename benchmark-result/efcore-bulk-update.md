# 📊 Benchmark Results – EF Core Bulk Update

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Operation:** Bulk Update  
* **EF Version:** EF Core 9.x  

⚠️ Notes  
* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection strings are defined in `appsettings.json`.  

---

## 🔹 SQL Server

![Benchmark EFCore vs EFE – SQL Server - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **SQL Server**, including plain update and update with graph.  
Entity Framework Extensions is consistently faster and uses less memory than EF Core.  

---

## 🔹 PostgreSQL

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **PostgreSQL**, including plain update and update with graph.  
Entity Framework Extensions is much faster than EF Core, though memory gains vary by dataset.  

---

## 🔹 MySQL

![Benchmark EFCore vs EFE – MySQL - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **MySQL**, including plain update and update with graph.  
Entity Framework Extensions executes faster and typically uses less memory.  

---

## 🔹 MariaDB

![Benchmark EFCore vs EFE – MariaDB - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **MariaDB**, including plain update and update with graph.  
Entity Framework Extensions is significantly faster and more memory efficient.  

---

## 🔹 Oracle

![Benchmark EFCore vs EFE – Oracle - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **Oracle**, including plain update and update with graph.  
Entity Framework Extensions provides strong performance gains, though memory usage improvements vary.  

---

## 🔹 SQLite

![Benchmark EFCore vs EFE – SQLite - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **SQLite**, including plain update and update with graph.  
Entity Framework Extensions is much faster than EF Core, with moderate memory improvements.  

---

## 🏁 Conclusion

Across all providers, **Bulk Update with Entity Framework Extensions** is consistently faster than EF Core:  

* **Performance:** EF Extensions cuts execution time dramatically in all databases tested.  
* **Memory Usage:** EF Extensions usually reduces memory usage, though some providers (e.g., Oracle) show results closer to EF Core.  
* **Scalability:** Updates with graph benefit strongly, showing EF Extensions’ ability to handle complex object graphs efficiently.  

For applications where **update performance** matters, EF Extensions delivers speed and efficiency across every major provider.  
