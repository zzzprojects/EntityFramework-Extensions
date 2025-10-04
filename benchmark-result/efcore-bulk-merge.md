# 📊 Benchmark Results – EF Core Bulk Merge

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Operation:** Bulk Merge  
* **EF Version:** EF Core 9.x  

⚠️ Notes  
* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection strings are defined in `appsettings.json`.  

---

## 🔹 SQL Server

![Benchmark EFCore vs EFE – SQL Server - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlserver-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **SQL Server**, including plain merge and merge with graph.  
Entity Framework Extensions is consistently faster and uses significantly less memory than EF Core.  

---

## 🔹 PostgreSQL

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **PostgreSQL**, including plain merge and merge with graph.  
Entity Framework Extensions executes merges much faster, with memory usage improvements depending on dataset size.  

---

## 🔹 MySQL

![Benchmark EFCore vs EFE – MySQL - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **MySQL**, including plain merge and merge with graph.  
Entity Framework Extensions delivers major speed advantages and generally uses less memory than EF Core.  

---

## 🔹 MariaDB

![Benchmark EFCore vs EFE – MariaDB - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **MariaDB**, including plain merge and merge with graph.  
Entity Framework Extensions consistently outperforms EF Core, both in performance and memory usage.  

---

## 🔹 Oracle

![Benchmark EFCore vs EFE – Oracle - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **Oracle**, including plain merge and merge with graph.  
Entity Framework Extensions provides clear performance improvements, though memory usage gains are less consistent compared to other providers.  

---

## 🔹 SQLite

![Benchmark EFCore vs EFE – SQLite - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **SQLite**, including plain merge and merge with graph.  
Entity Framework Extensions is significantly faster than EF Core, with moderate memory improvements.  

---

## 🏁 Conclusion

Across all providers, **Bulk Merge with Entity Framework Extensions** delivers substantial benefits compared to EF Core:  

* **Performance:** EF Extensions consistently runs merges several times faster, even in complex scenarios involving graphs.  
* **Memory Usage:** In most providers, EF Extensions uses less memory, though Oracle and SQLite sometimes show usage closer to EF Core.  
* **Scalability:** Bulk Merge excels with complex datasets, reducing both execution time and memory pressure for large-scale operations.  

For applications where **merge operations** are essential, EF Extensions ensures high performance and efficiency across all major database providers.  
