package mono.ru.yandex.yandexmapkit.overlay.location;


public class OnMyLocationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		ru.yandex.yandexmapkit.overlay.location.OnMyLocationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMyLocationChange:(Lru/yandex/yandexmapkit/overlay/location/MyLocationItem;)V:GetOnMyLocationChange_Lru_yandex_yandexmapkit_overlay_location_MyLocationItem_Handler:RU.Yandex.Yandexmapkit.Overlay.Location.IOnMyLocationListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"";
		mono.android.Runtime.register ("RU.Yandex.Yandexmapkit.Overlay.Location.IOnMyLocationListenerImplementor, YandexMaps.Xamarin.Android", OnMyLocationListenerImplementor.class, __md_methods);
	}


	public OnMyLocationListenerImplementor ()
	{
		super ();
		if (getClass () == OnMyLocationListenerImplementor.class) {
			mono.android.TypeManager.Activate ("RU.Yandex.Yandexmapkit.Overlay.Location.IOnMyLocationListenerImplementor, YandexMaps.Xamarin.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void onMyLocationChange (ru.yandex.yandexmapkit.overlay.location.MyLocationItem p0)
	{
		n_onMyLocationChange (p0);
	}

	private native void n_onMyLocationChange (ru.yandex.yandexmapkit.overlay.location.MyLocationItem p0);

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
