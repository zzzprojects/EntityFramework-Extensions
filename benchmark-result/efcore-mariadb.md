# 📊 Benchmark Results – EF Core / MariaDB

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Provider:** MariaDB  
* **EF Version:** EF Core 9.x  

⚠️ Notes  

* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection string defined in `appsettings.json`.  

---

## 🔹 Bulk Insert

![Benchmark EFCore vs EFE – MariaDB - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **MariaDB**, including plain insert, insert with graph, and insert with keep identity.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core (beside the keep identity) and uses only a fraction of the memory.  

---

## 🔹 Bulk Update

![Benchmark EFCore vs EFE – MariaDB - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **MariaDB**, including plain update and update with graph.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and uses only a fraction of the memory.  

---

## 🔹 Bulk Delete

![Benchmark EFCore vs EFE – MariaDB - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **MariaDB**, including plain delete, delete with composite keys, and delete with graph.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and uses only a fraction of the memory.  

---

## 🔹 Bulk Merge

![Benchmark EFCore vs EFE – MariaDB - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **MariaDB**, including plain merge and merge with graph.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core.  

---

## 🔹 Bulk Synchronize

![Benchmark EFCore vs EFE – MariaDB - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **MariaDB**.  

Only Entity Framework Extensions is included, since EF Core has no equivalent method to compare.  

---

## 🔹 Bulk SaveChanges

![Benchmark EFCore vs EFE – MariaDB - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mariadb-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **MariaDB**, including plain SaveChanges and SaveChanges with graph.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core.  

---

## 🏁 Conclusion

Across all tested operations on **MariaDB**, Entity Framework Extensions consistently outperforms EF Core:  

* **Performance:** EF Extensions methods execute dramatically faster, particularly in large batch operations.  
* **Memory Usage:** In most cases, EF Extensions also consumes significantly less memory, though on MariaDB some variations show memory usage closer to EF Core.  
* **Features:** For operations like **Bulk Synchronize**, EF Extensions provides functionality that EF Core does not natively support.  

For developers working with **MariaDB**, EF Extensions delivers a major boost in performance and efficiency, making it especially valuable for applications handling high-volume data workloads.  
