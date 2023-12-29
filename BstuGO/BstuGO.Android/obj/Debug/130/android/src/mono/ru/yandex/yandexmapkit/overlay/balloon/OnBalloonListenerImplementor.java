package mono.ru.yandex.yandexmapkit.overlay.balloon;


public class OnBalloonListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		ru.yandex.yandexmapkit.overlay.balloon.OnBalloonListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBalloonAnimationEnd:(Lru/yandex/yandexmapkit/overlay/balloon/BalloonItem;)V:GetOnBalloonAnimationEnd_Lru_yandex_yandexmapkit_overlay_balloon_BalloonItem_Handler:RU.Yandex.Yandexmapkit.Overlay.Balloon.IOnBalloonListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"n_onBalloonAnimationStart:(Lru/yandex/yandexmapkit/overlay/balloon/BalloonItem;)V:GetOnBalloonAnimationStart_Lru_yandex_yandexmapkit_overlay_balloon_BalloonItem_Handler:RU.Yandex.Yandexmapkit.Overlay.Balloon.IOnBalloonListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"n_onBalloonHide:(Lru/yandex/yandexmapkit/overlay/balloon/BalloonItem;)V:GetOnBalloonHide_Lru_yandex_yandexmapkit_overlay_balloon_BalloonItem_Handler:RU.Yandex.Yandexmapkit.Overlay.Balloon.IOnBalloonListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"n_onBalloonShow:(Lru/yandex/yandexmapkit/overlay/balloon/BalloonItem;)V:GetOnBalloonShow_Lru_yandex_yandexmapkit_overlay_balloon_BalloonItem_Handler:RU.Yandex.Yandexmapkit.Overlay.Balloon.IOnBalloonListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"n_onBalloonViewClick:(Lru/yandex/yandexmapkit/overlay/balloon/BalloonItem;Landroid/view/View;)V:GetOnBalloonViewClick_Lru_yandex_yandexmapkit_overlay_balloon_BalloonItem_Landroid_view_View_Handler:RU.Yandex.Yandexmapkit.Overlay.Balloon.IOnBalloonListenerInvoker, YandexMaps.Xamarin.Android\n" +
			"";
		mono.android.Runtime.register ("RU.Yandex.Yandexmapkit.Overlay.Balloon.IOnBalloonListenerImplementor, YandexMaps.Xamarin.Android", OnBalloonListenerImplementor.class, __md_methods);
	}


	public OnBalloonListenerImplementor ()
	{
		super ();
		if (getClass () == OnBalloonListenerImplementor.class) {
			mono.android.TypeManager.Activate ("RU.Yandex.Yandexmapkit.Overlay.Balloon.IOnBalloonListenerImplementor, YandexMaps.Xamarin.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void onBalloonAnimationEnd (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0)
	{
		n_onBalloonAnimationEnd (p0);
	}

	private native void n_onBalloonAnimationEnd (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0);


	public void onBalloonAnimationStart (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0)
	{
		n_onBalloonAnimationStart (p0);
	}

	private native void n_onBalloonAnimationStart (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0);


	public void onBalloonHide (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0)
	{
		n_onBalloonHide (p0);
	}

	private native void n_onBalloonHide (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0);


	public void onBalloonShow (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0)
	{
		n_onBalloonShow (p0);
	}

	private native void n_onBalloonShow (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0);


	public void onBalloonViewClick (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0, android.view.View p1)
	{
		n_onBalloonViewClick (p0, p1);
	}

	private native void n_onBalloonViewClick (ru.yandex.yandexmapkit.overlay.balloon.BalloonItem p0, android.view.View p1);

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
