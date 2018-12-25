package md53264be7088df2211f97d3e880b1af276;


public class SummaryActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ReindersMichaelAssn3.SummaryActivity, ReindersMichaelAssn3", SummaryActivity.class, __md_methods);
	}


	public SummaryActivity ()
	{
		super ();
		if (getClass () == SummaryActivity.class)
			mono.android.TypeManager.Activate ("ReindersMichaelAssn3.SummaryActivity, ReindersMichaelAssn3", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
