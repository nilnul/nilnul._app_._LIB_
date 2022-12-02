using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app_.dotnet.mem._gc
{
	/*docs.microsoft.com/en-us/archive/msdn-magazine/2000/november/garbage-collection-automatic-memory-management-in-the-microsoft-net-framework
	 
	 let me warn you right now: object finalization and destructors have very different semantics

When an application terminates, some objects are still reachable and will not have their Finalize method called. This can happen if background threads are using the objects or if objects are created during application shutdown or AppDomain unloading. In addition, by default, Finalize methods are not called for unreachable objects when an application exits so that the application may terminate quickly. Of course, all operating system resources will be reclaimed, but any objects in the managed heap are not able to clean up gracefully. You can change this default behavior by calling the System.GC type's RequestFinalizeOnShutdown method. However, you should use this method with care since calling it means that your type is controlling a policy for the entire application.

 if you let any exceptions escape the Finalize method, the system just assumes that the Finalize method returned and continues calling other objects' Finalize methods.

 let's say there is an object that contains a pointer to an inner object. The garbage collector has detected that both objects are garbage. Furthermore, say that the inner object's Finalize method gets called first. Now, the outer object's Finalize method is allowed to access the inner object and call methods on it, but the inner object has been finalized and the results may be unpredictable.
	 the compiler does not automatically generate code to call a base type's Finalize method.

 If the object's type contains a Finalize method, then a pointer to the object is placed on the finalization queue.
 the pointer is removed from the finalization queue and appended to the freachable queue when being garbaged.	
	 There is a special runtime thread dedicated to calling Finalize methods. the special runtime thread empties the freachable queue, executing each object's Finalize method.next time the garbage collector is invoked, it sees that the finalized objects are truly garbage. two GCs are required to reclaim memory used by objects that require finalization. In reality, more than two collections may be necessary since the objects could get promoted to an older generation.This is a very interesting phenomenon called resurrection.

	when finalizer has been called, an object might be resurrected, that is, regarded as nongarbage as, say, it in its finalizer allows other to reference itself again directly or indirectly.

keeping a Boolean flag indicating whether the object has been finalized or not.	
Then, if methods are called on your finalized object, you might consider throwing an exception.
	Eventually the garbage collector will consider the object to be garbage and will reclaim the object's storage. Note that the object's Finalize method will not be called because no pointer to the object exists on the finalization queue, as its finalizer has been called in the past.
Make sure that you call ReRegisterForFinalize no more than once per resurrection, or the object will have its Finalize method called multiple times. This happens because each call to ReRegisterForFinalize appends a new entry to the end of the finalization queue. When an object is determined to be garbage, all of these entries move from the finalization queue to the freachable queue, calling the object's Finalize method multiple times.

When you call SuppressFinalize, it turns on a bit flag associated with the object. When this flag is on, the runtime knows not to move this object's pointer to the freachable queue, preventing the object's Finalize method from being called.this flag is reset when the runtime determines that it's time to call a Finalize method, when for example, in resurrecting.

	 */
	class Finalize0
	{
		~Finalize0()
		{
			//Note that you'll usually call the base type's Finalize method as the last statement in the derived type's Finalize method. This keeps the base object alive as long as possible. Since calling a base type Finalize method is common, C# has a syntax that simplifies your work.
			//base.Finalize();


		}

	}
}