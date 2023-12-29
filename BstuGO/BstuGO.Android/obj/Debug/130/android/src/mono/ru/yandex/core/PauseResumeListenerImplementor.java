package mono.ru.yandex.core;


public class PauseResumeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		ru.yandex.core.PauseResumeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPaused:()V:GetOnPausedHandler:RU.Yandex.Core.IPauseResumeListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"n_onResumed:()V:GetOnResumedHandler:RU.Yandex.Core.IPauseResumeListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"";
		mono.android.Runtime.register ("RU.Yandex.Core.IPauseResumeListenerImplementor, YandexMaps.Xamarin.Android", PauseResumeListenerImplementor.class, __md_methods);
	}


	public PauseResumeListenerImplementor ()
	{
		super ();
		if (getClass () == PauseResumeListenerImplementor.class) {
			mono.android.TypeManager.Activate ("RU.Yandex.Core.IPauseResumeListenerImplementor, YandexMaps.Xamarin.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void onPaused ()
	{
		n_onPaused ();
	}

	private native void n_onPaused ();


	public void onResumed ()
	{
		n_onResumed ();
	}

	private native void n_onResumed ();

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
