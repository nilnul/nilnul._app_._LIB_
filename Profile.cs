using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app
{
	/*
Profiling

Even if your code functionally behaves as you would expect, that might not be good enough if it takes all your CPU or memory in the process. Algorithms classes often teach big O notation but not how to find hot spots in your programs. Since premature optimization is the root of all evil, you should learn about profilers and monitoring tools. They will help you understand which parts of your program are taking most of the time and/or resources so you can focus on optimizing those parts.

Timing
Similarly to the debugging case, in many scenarios it can be enough to just print the time it took your code between two points.

However, wall clock time can be misleading since your computer might be running other processes at the same time or waiting for events to happen. It is common for tools to make a distinction between Real, User and Sys time. In general, User + Sys tells you how much time your process actually spent in the CPU (more detailed explanation here).
Real - Wall clock elapsed time from start to finish of the program, including the time taken by other processes and time taken while blocked (e.g. waiting for I/O or network)
User - Amount of time spent in the CPU running user code
Sys - Amount of time spent in the CPU running kernel code

For example, try running a command that performs an HTTP request and prefixing it with time. Under a slow connection you might get an output like the one below. Here it took over 2 seconds for the request to complete but the process only took 15ms of CPU user time and 12ms of kernel CPU time.
$ time curl https://missing.csail.mit.edu &> /dev/null`
real    0m2.561s
user    0m0.015s
sys     0m0.012s
		 */
	interface IProfile
	{
	}
}
