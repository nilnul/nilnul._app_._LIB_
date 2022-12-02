using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app_.dotnet.mem
{
	/*docs.microsoft.com/en-us/archive/msdn-magazine/2000/november/garbage-collection-automatic-memory-management-in-the-microsoft-net-framework
	 * 
	 * When the garbage collector starts running, it makes the assumption that all objects in the heap are garbage.
	 * Now, the garbage collector starts walking the roots and building a graph of all objects reachable from the roots.
	 * 
	 * The garbage collector now walks through the heap linearly, looking for contiguous blocks of garbage objects (now considered free space). The garbage collector then shifts the non-garbage objects down in memory (using the standard memcpy function that you've known for years), removing all of the gaps in the heap.
	 * Of course, moving the objects in memory invalidates all pointers to the objects. So the garbage collector must modify the application's roots so that the pointers point to the objects' new locations. In addition, if any object contains a pointer to another object, the garbage collector is responsible for correcting these pointers as well.
	 * the NextObjPtr is positioned just after the last non-garbage object. At this point, the new operation is tried again and the resource requested by the application is successfully created.
	 * keep in mind that GCs only occur when the heap is full and, until then, the managed heap is significantly faster than a C-runtime heap
	 * 
	 * The problem with C++ is that it allows casting a pointer from one type to another, and there's no way to know what a pointer refers to.
	 */
	/// <summary>
	/// 
	/// </summary>
	class Gc
	{
	}
}
