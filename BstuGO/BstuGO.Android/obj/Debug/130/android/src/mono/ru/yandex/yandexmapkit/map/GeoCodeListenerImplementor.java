package mono.ru.yandex.yandexmapkit.map;


public class GeoCodeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		ru.yandex.yandexmapkit.map.GeoCodeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFinishGeoCode:(Lru/yandex/yandexmapkit/map/GeoCode;)Z:GetOnFinishGeoCode_Lru_yandex_yandexmapkit_map_GeoCode_Handler:RU.Yandex.Yandexmapkit.Map.IGeoCodeListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"";
		mono.android.Runtime.register ("RU.Yandex.Yandexmapkit.Map.IGeoCodeListenerImplementor, YandexMaps.Xamarin.Android", GeoCodeListenerImplementor.class, __md_methods);
	}


	public GeoCodeListenerImplementor ()
	{
		super ();
		if (getClass () == GeoCodeListenerImplementor.class) {
			mono.android.TypeManager.Activate ("RU.Yandex.Yandexmapkit.Map.IGeoCodeListenerImplementor, YandexMaps.Xamarin.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public boolean onFinishGeoCode (ru.yandex.yandexmapkit.map.GeoCode p0)
	{
		return n_onFinishGeoCode (p0);
	}

	private native boolean n_onFinishGeoCode (ru.yandex.yandexmapkit.map.GeoCode p0);

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
