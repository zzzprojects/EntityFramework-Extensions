# 📊 Benchmark Results – EF Core / Oracle

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Provider:** Oracle  
* **EF Version:** EF Core 9.x  

⚠️ Notes  

* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection string defined in `appsettings.json`.  

---

## 🔹 Bulk Insert

![Benchmark EFCore vs EFE – Oracle - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **Oracle**, including plain insert, insert with graph, and insert with keep identity.  

Entity Framework Extensions is consistently faster than EF Core, though memory usage improvements are less pronounced on Oracle compared to other providers.  

---

## 🔹 Bulk Update

![Benchmark EFCore vs EFE – Oracle - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **Oracle**, including plain update and update with graph.  

Entity Framework Extensions delivers much faster execution than EF Core, with memory usage improvements that vary depending on scenario.  

---

## 🔹 Bulk Delete

![Benchmark EFCore vs EFE – Oracle - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **Oracle**, including plain delete, delete with composite keys, and delete with graph.  

Entity Framework Extensions significantly outperforms EF Core in speed, though memory usage is sometimes closer to EF Core levels.  

---

## 🔹 Bulk Merge

![Benchmark EFCore vs EFE – Oracle - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **Oracle**, including plain merge and merge with graph.  

Entity Framework Extensions is much faster than EF Core, with memory usage gains that depend on the dataset size.  

---

## 🔹 Bulk Synchronize

![Benchmark EFCore vs EFE – Oracle - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **Oracle**.  

Only Entity Framework Extensions is included, since EF Core has no equivalent method to compare.  

---

## 🔹 Bulk SaveChanges

![Benchmark EFCore vs EFE – Oracle - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-oracle-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **Oracle**, including plain SaveChanges and SaveChanges with graph.  

Entity Framework Extensions is consistently faster than EF Core, however currently use more memory.

---

## 🏁 Conclusion

Across all tested operations on **Oracle**, Entity Framework Extensions shows clear performance benefits compared to EF Core:  

* **Performance:** EF Extensions delivers substantial speed improvements, often making large data operations complete several times faster.  
* **Memory Usage:** While EF Extensions generally uses less memory, Oracle benchmarks show cases where memory usage is closer to EF Core.  
* **Features:** Exclusive features such as **Bulk Synchronize** add functionality beyond what EF Core offers.  

For developers using **Oracle**, EF Extensions provides a reliable way to scale bulk operations, ensuring faster execution while keeping memory use within reasonable limits.  
