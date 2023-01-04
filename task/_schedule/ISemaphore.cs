using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.task._schedule
{
	/*
	 stackoverflow.com/questions/24067200/semaphoreslim-with-dynamic-maxcount

	 So let's say that the absolute maximum number of concurrent calls is 100, but initially you want it to be 25. You initialize your semaphore:

SemaphoreSlim sem = new SemaphoreSlim(25, 100);
So 25 is the number of requests that can be serviced concurrently. You have reserved the other 75.

If you then want to increase the number allowed, just call Release(num). If you called Release(10), then the number would go to 35.

Now, if you want to reduce the number of available requests, you have to call WaitOne multiple times. For example, if you want to remove 10 from the available count:

for (var i = 0; i < 10; ++i)
{
    sem.WaitOne();
}
This has the potential of blocking until other clients release the semaphore. That is, if you allow 35 concurrent requests and you want to reduce it to 25, but there are already 35 clients with active requests, that WaitOne will block until a client calls Release, and the loop won't terminate until 10 clients release.
	 */
	/// <summary>
	/// Normally, when the SemaphoreSlim is used as a throttler, both initialCount and maxCount have the same value:
	/// var semaphore = new SemaphoreSlim(maximumConcurrency, maximumConcurrency);
	/// </summary>
	/// initialCount is the "degree of parallelism" (number of threads that can enter)
	/// maxCount ensures that you don't Release more than you should
	/// For example, say you want a concurrency degree of "1" (only one operation at a time). But then due to some bug in your code, you release the semaphore twice. So now you have a concurrency of two!
	/// But if you set maxCount - it will not allow this and throw an exception.
	internal class ISemaphore
	{
	}
}
