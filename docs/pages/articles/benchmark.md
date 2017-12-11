---
permalink: benchmark
---

## Problem
You perform benchmark tests for a method like BulkSaveChanges, but you get very bad performance results.

### Solution
The performance issue may be caused by some common mistakes:

- Forget to JIT compile the library
- Include method not related to the test



## Forget to JIT compile the library
In C#, the code is compiled into IL by the compiler. Then when needed, the IL is compiled just-in-time (JIT) into the native assembly language of the host machine.

Additionally, some libraries like Entity Framework require some extra work like creating/reading the model. Some people report the first load taking several seconds!

Entity Framework Extensions also takes some time to be compiled. It can take around 100ms the first time you use a method! So if you include it this time, your benchmark time is currently way higher than it should.

### Solution
Invoke the method once before performing the benchmark tests

## Include method not related to the test
Someone once reported a performance issue and thought our BulkSaveChanges method was slow. We discovered he was including the time to Add every entity to the context.

The Add method was taking 99,9% of the total time while BulkSaveChanges only 0,1%.


| Operations | 100 Entities | 1,000 Entities | 10,000 Entities |
| :--------- | -----------: | -------------: | --------------: |
| Add             | 15 ms        | 1,050 ms       | 105,000 ms      |
| BulKSaveChanges | 40 ms        | 90ms           | 400 ms     |


The Add method doesn't affect much the performance when adding 100 entities, but if you make your test with 10,000 entities:
 - Add: 99.6%
 - BulkSaveChanges: 0,4%

### Solution
Include only the method you want to benchmark.

## Good Example
Here is an example of how we normally do all our benchmarks tests

### Example
{% include template-example.html %} 
{% highlight csharp %}
public Benchmark()
{
    // BENCHMARK using Stopwatch
    var clock1 = new Stopwatch();
    var clock2 = new Stopwatch();

    var nbRecord = 1000;
    var nbTry = 5;

    var list = GenerateData(nbRecord);

    // BENCHMARK: JIT compile library first
    Test1(list, null);
    Test2(list, null);
    
    for (var i = 0; i < nbTry; i++)
    {
        Test1(list, clock1);
        Test2(list, clock2);
    }

    var r1 = clock1.ElapsedMilliseconds/nbTry;
    var r2 = clock2.ElapsedMilliseconds/nbTry;
}

public void Test1(List<string> lines, Stopwatch clock)
{
    using (var ctx = new CustomerContext())
    {
        var customers = new List<Customer>();

        foreach (var line in lines)
        {
            var customer = new Customer();
            // ...code...
            customers.Add(customer);
        }

        ctx.Customers.AddRange(customers);

        // BENCHMARK: Only method we want to test
        clock.Start();
        ctx.BulkSaveChanges();
        clock.Stop();
    }
}

public void Test2(List<string> lines, Stopwatch clock)
{
    using (var ctx = new CustomerContext())
    {
        var customers = new List<Customer>();

        foreach (var line in lines)
        {
            var customer = new Customer();
            // ...code...
            customers.Add(customer);
        }

        ctx.Customers.AddRange(customers);

        // BENCHMARK: Only method we want to test
        clock.Start();
        ctx.SaveChanges();
        clock.Stop();
    }
}

public List<string> GenerateData(int nbRecord)
{
	var list = new List<string>();

	for (var i = 0; i < nbRecord; i++)
	{
		list.Add(i.ToString());
	}

	return list;
}
{% endhighlight %}

