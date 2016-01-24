package md5ba6caf9a9061d0cbb25c0daaef535be4;


public class CourseActivity
	extends android.support.v4.app.FragmentActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Courses.Android.CourseActivity, Courses.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CourseActivity.class, __md_methods);
	}


	public CourseActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CourseActivity.class)
			mono.android.TypeManager.Activate ("Courses.Android.CourseActivity, Courses.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
