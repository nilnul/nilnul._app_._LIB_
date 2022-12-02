using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app_.dotnet._mem_
{
	/*
	 docs.microsoft.com/en-us/archive/msdn-magazine/2000/november/garbage-collection-automatic-memory-management-in-the-microsoft-net-framework

When a process is initialized, the runtime reserves a contiguous region of address space that initially has no storage allocated for it. This address space region is the managed heap. The heap also maintains a pointer, which I'll call the NextObjPtr. This pointer indicates where the next object is to be allocated within the heap. Initially, the NextObjPtr is set to the base address of the reserved address space region.
	If no more memory is available for the heap, then the new operator throws an OutOfMemoryException
	 */
	class Heap
	{
	}
}
