package mono.ru.yandex.yandexmapkit.map;


public class OnMapListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		ru.yandex.yandexmapkit.map.OnMapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapActionEvent:(Lru/yandex/yandexmapkit/map/MapEvent;)V:GetOnMapActionEvent_Lru_yandex_yandexmapkit_map_MapEvent_Handler:RU.Yandex.Yandexmapkit.Map.IOnMapListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"";
		mono.android.Runtime.register ("RU.Yandex.Yandexmapkit.Map.IOnMapListenerImplementor, YandexMaps.Xamarin.Android", OnMapListenerImplementor.class, __md_methods);
	}


	public OnMapListenerImplementor ()
	{
		super ();
		if (getClass () == OnMapListenerImplementor.class) {
			mono.android.TypeManager.Activate ("RU.Yandex.Yandexmapkit.Map.IOnMapListenerImplementor, YandexMaps.Xamarin.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void onMapActionEvent (ru.yandex.yandexmapkit.map.MapEvent p0)
	{
		n_onMapActionEvent (p0);
	}

	private native void n_onMapActionEvent (ru.yandex.yandexmapkit.map.MapEvent p0);

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
