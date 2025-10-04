# 📊 Benchmark Results – EF Core / MySQL

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Provider:** MySQL  
* **EF Version:** EF Core 9.x  

⚠️ Notes  

* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection string defined in `appsettings.json`.  

---

## 🔹 Bulk Insert

![Benchmark EFCore vs EFE – MySQL - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **MySQL**, including plain insert, insert with graph, and insert with keep identity.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and often uses less memory.  

---

## 🔹 Bulk Update

![Benchmark EFCore vs EFE – MySQL - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **MySQL**, including plain update and update with graph.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core, with memory usage improvements in most cases.  

---

## 🔹 Bulk Delete

![Benchmark EFCore vs EFE – MySQL - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **MySQL**, including plain delete, delete with composite keys, and delete with graph.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and usually more memory-efficient.  

---

## 🔹 Bulk Merge

![Benchmark EFCore vs EFE – MySQL - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **MySQL**, including plain merge and merge with graph.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and typically consumes less memory.  

---

## 🔹 Bulk Synchronize

![Benchmark EFCore vs EFE – MySQL - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **MySQL**.  

Only Entity Framework Extensions is included, since EF Core has no equivalent method to compare.  

---

## 🔹 Bulk SaveChanges

![Benchmark EFCore vs EFE – MySQL - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-mysql-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **MySQL**, including plain SaveChanges and SaveChanges with graph.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core and often uses much less memory.  

---

## 🏁 Conclusion

Across all tested operations on **MySQL**, Entity Framework Extensions provides substantial benefits compared to EF Core:  

* **Performance:** EF Extensions consistently delivers faster execution, often reducing processing time by more than 90%.  
* **Memory Usage:** In most scenarios, EF Extensions uses considerably less memory than EF Core, though some variations show usage close to EF Core levels.  
* **Features:** With advanced operations like **Bulk Synchronize**, EF Extensions introduces capabilities not available in EF Core.  

For teams building applications on **MySQL**, EF Extensions offers both speed and scalability improvements, making it a powerful solution for high-volume data operations.  
