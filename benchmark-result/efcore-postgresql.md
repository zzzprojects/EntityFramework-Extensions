# 📊 Benchmark Results – EF Core / PostgreSQL

* **Comparison:** EF Core vs Entity Framework Extensions  
* **Provider:** PostgreSQL  
* **EF Version:** EF Core 9.x  

⚠️ Notes  

* Benchmarks executed with **BenchmarkDotNet** (25 iterations, 1 warmup).  
* Results may vary depending on hardware, configuration, and dataset size.  
* Connection string defined in `appsettings.json`.  

---

## 🔹 Bulk Insert

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Insert](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-insert.png)

**Description:**  
This chart shows Bulk Insert benchmarks on **PostgreSQL**, including plain insert, insert with graph, and insert with keep identity.  

In all scenarios, Entity Framework Extensions is significantly faster than EF Core, while memory usage improvements vary depending on the case.  

---

## 🔹 Bulk Update

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Update](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-update.png)

**Description:**  
This chart shows Bulk Update benchmarks on **PostgreSQL**, including plain update and update with graph.  

Entity Framework Extensions is consistently faster than EF Core, with memory usage generally lower but sometimes closer to EF Core.  

---

## 🔹 Bulk Delete

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Delete](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-delete.png)

**Description:**  
This chart shows Bulk Delete benchmarks on **PostgreSQL**, including plain delete, delete with composite keys, and delete with graph.  

Entity Framework Extensions provides a major speed improvement compared to EF Core and usually requires less memory.  

---

## 🔹 Bulk Merge

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Merge](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-merge.png)

**Description:**  
This chart shows Bulk Merge benchmarks on **PostgreSQL**, including plain merge and merge with graph.  

Entity Framework Extensions is significantly faster, while memory usage improvements vary depending on the dataset and scenario.  

---

## 🔹 Bulk Synchronize

![Benchmark EFCore vs EFE – PostgreSQL - Bulk Synchronize](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-synchronize.png)

**Description:**  
This chart shows Bulk Synchronize benchmarks on **PostgreSQL**.  

Only Entity Framework Extensions is included, since EF Core has no equivalent method to compare.  

---

## 🔹 Bulk SaveChanges

![Benchmark EFCore vs EFE – PostgreSQL - Bulk SaveChanges](https://raw.githubusercontent.com/zzzprojects/EntityFramework-Extensions/master/images/benchmark-efcore-vs-efe-postgresql-bulk-savechanges.png)

**Description:**  
This chart shows Bulk SaveChanges benchmarks on **PostgreSQL**, including plain SaveChanges and SaveChanges with graph.  

Entity Framework Extensions is consistently faster and generally uses less memory than EF Core.  

---

## 🏁 Conclusion

Across all tested operations on **PostgreSQL**, Entity Framework Extensions demonstrates clear advantages over EF Core:  

* **Performance:** EF Extensions operations consistently run faster, often achieving dramatic reductions in execution time.  
* **Memory Usage:** In most benchmarks, EF Extensions uses less memory, though in some variations memory usage is closer to EF Core.  
* **Features:** Advanced features such as **Bulk Synchronize** remain exclusive to EF Extensions.  

For teams working with **PostgreSQL**, EF Extensions offers reliable performance gains and greater scalability, making it a strong choice for handling large datasets efficiently.  
