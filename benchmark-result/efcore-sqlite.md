# 📊 Benchmark Results – EF Core / SQLite

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Provider:** SQLite  
* **EF Version:** EF Core 9.x  

⚠️ Notes  

* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection string defined in `appsettings.json`.  

---

## 🔹 Bulk Insert

![Benchmark EFCore vs EFE – SQLite - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **SQLite**, including plain insert, insert with graph, and insert with keep identity.  

Entity Framework Extensions is consistently faster than EF Core and in most cases uses less memory.  

---

## 🔹 Bulk Update

![Benchmark EFCore vs EFE – SQLite - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **SQLite**, including plain update and update with graph.  

Entity Framework Extensions executes updates much faster than EF Core, while memory usage varies depending on dataset size.  

---

## 🔹 Bulk Delete

![Benchmark EFCore vs EFE – SQLite - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **SQLite**, including plain delete, delete with composite keys, and delete with graph.  

Entity Framework Extensions provides a clear speed advantage, with memory usage generally lower than EF Core.  

---

## 🔹 Bulk Merge

![Benchmark EFCore vs EFE – SQLite - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **SQLite**, including plain merge and merge with graph.  

Entity Framework Extensions significantly outperforms EF Core, though memory improvements are less consistent compared to larger providers.  

---

## 🔹 Bulk Synchronize

![Benchmark EFCore vs EFE – SQLite - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **SQLite**.  

Only Entity Framework Extensions is included, since EF Core has no equivalent method to compare.  

---

## 🔹 Bulk SaveChanges

![Benchmark EFCore vs EFE – SQLite - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-sqlite-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **SQLite**, including plain SaveChanges and SaveChanges with graph.  

Entity Framework Extensions is consistently faster than EF Core, however currently use more memory.

---

## 🏁 Conclusion

Across all tested operations on **SQLite**, Entity Framework Extensions provides consistent performance improvements over EF Core:  

* **Performance:** EF Extensions operations complete much faster, even on lightweight databases like SQLite.  
* **Memory Usage:** EF Extensions generally uses less memory, though on very small datasets the difference is less pronounced.  
* **Features:** Exclusive operations such as **Bulk Synchronize** are available only with EF Extensions.  

For developers using **SQLite**, EF Extensions offers reliable performance boosts and efficiency improvements, especially valuable for applications that manipulate many records locally.  
