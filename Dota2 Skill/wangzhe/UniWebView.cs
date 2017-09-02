using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UniWebView : MonoBehaviour
{
	public delegate void LoadCompleteDelegate(UniWebView webView, bool success, string errorMessage);

	public delegate void LoadBeginDelegate(UniWebView webView, string loadingUrl);

	public delegate void ReceivedMessageDelegate(UniWebView webView, UniWebViewMessage message);

	public delegate void EvalJavaScriptFinishedDelegate(UniWebView webView, string result);

	public delegate bool WebViewShouldCloseDelegate(UniWebView webView);

	public delegate void ReceivedKeyCodeDelegate(UniWebView webView, int keyCode);

	public delegate UniWebViewEdgeInsets InsetsForScreenOreitationDelegate(UniWebView webView, UniWebViewOrientation orientation);

	[SerializeField]
	private UniWebViewEdgeInsets _insets = new UniWebViewEdgeInsets(0, 0, 0, 0);

	public string url;

	public bool loadOnStart;

	public bool autoShowWhenLoadComplete;

	private bool _backButtonEnable = true;

	private bool _bouncesEnable;

	private bool _zoomEnable;

	private string _currentGUID;

	private int _lastScreenHeight;

	private bool _immersiveMode = true;

	private Action _showTransitionAction;

	private Action _hideTransitionAction;

	public bool toolBarShow;

	public event UniWebView.LoadCompleteDelegate OnLoadComplete
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.OnLoadComplete = (UniWebView.LoadCompleteDelegate)Delegate.Combine(this.OnLoadComplete, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.OnLoadComplete = (UniWebView.LoadCompleteDelegate)Delegate.Remove(this.OnLoadComplete, value);
		}
	}

	public event UniWebView.LoadBeginDelegate OnLoadBegin
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.OnLoadBegin = (UniWebView.LoadBeginDelegate)Delegate.Combine(this.OnLoadBegin, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.OnLoadBegin = (UniWebView.LoadBeginDelegate)Delegate.Remove(this.OnLoadBegin, value);
		}
	}

	public event UniWebView.ReceivedMessageDelegate OnReceivedMessage
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.OnReceivedMessage = (UniWebView.ReceivedMessageDelegate)Delegate.Combine(this.OnReceivedMessage, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.OnReceivedMessage = (UniWebView.ReceivedMessageDelegate)Delegate.Remove(this.OnReceivedMessage, value);
		}
	}

	public event UniWebView.EvalJavaScriptFinishedDelegate OnEvalJavaScriptFinished
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.OnEvalJavaScriptFinished = (UniWebView.EvalJavaScriptFinishedDelegate)Delegate.Combine(this.OnEvalJavaScriptFinished, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.OnEvalJavaScriptFinished = (UniWebView.EvalJavaScriptFinishedDelegate)Delegate.Remove(this.OnEvalJavaScriptFinished, value);
		}
	}

	public event UniWebView.WebViewShouldCloseDelegate OnWebViewShouldClose
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.OnWebViewShouldClose = (UniWebView.WebViewShouldCloseDelegate)Delegate.Combine(this.OnWebViewShouldClose, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.OnWebViewShouldClose = (UniWebView.WebViewShouldCloseDelegate)Delegate.Remove(this.OnWebViewShouldClose, value);
		}
	}

	public event UniWebView.ReceivedKeyCodeDelegate OnReceivedKeyCode
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.OnReceivedKeyCode = (UniWebView.ReceivedKeyCodeDelegate)Delegate.Combine(this.OnReceivedKeyCode, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.OnReceivedKeyCode = (UniWebView.ReceivedKeyCodeDelegate)Delegate.Remove(this.OnReceivedKeyCode, value);
		}
	}

	public event UniWebView.InsetsForScreenOreitationDelegate InsetsForScreenOreitation
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.InsetsForScreenOreitation = (UniWebView.InsetsForScreenOreitationDelegate)Delegate.Combine(this.InsetsForScreenOreitation, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.InsetsForScreenOreitation = (UniWebView.InsetsForScreenOreitationDelegate)Delegate.Remove(this.InsetsForScreenOreitation, value);
		}
	}

	public UniWebViewEdgeInsets insets
	{
		get
		{
			return this._insets;
		}
		set
		{
			if (this._insets != value)
			{
				this.ForceUpdateInsetsInternal(value);
			}
		}
	}

	public string currentUrl
	{
		get
		{
			return UniWebViewPlugin.GetCurrentUrl(base.gameObject.name);
		}
	}

	public bool backButtonEnable
	{
		get
		{
			return this._backButtonEnable;
		}
		set
		{
			if (this._backButtonEnable != value)
			{
				this._backButtonEnable = value;
				UniWebViewPlugin.SetBackButtonEnable(base.gameObject.name, this._backButtonEnable);
			}
		}
	}

	public bool bouncesEnable
	{
		get
		{
			return this._bouncesEnable;
		}
		set
		{
			if (this._bouncesEnable != value)
			{
				this._bouncesEnable = value;
				UniWebViewPlugin.SetBounces(base.gameObject.name, this._bouncesEnable);
			}
		}
	}

	public bool zoomEnable
	{
		get
		{
			return this._zoomEnable;
		}
		set
		{
			if (this._zoomEnable != value)
			{
				this._zoomEnable = value;
				UniWebViewPlugin.SetZoomEnable(base.gameObject.name, this._zoomEnable);
			}
		}
	}

	public string userAgent
	{
		get
		{
			return UniWebViewPlugin.GetUserAgent(base.gameObject.name);
		}
	}

	public float alpha
	{
		get
		{
			return UniWebViewPlugin.GetAlpha(base.gameObject.name);
		}
		set
		{
			UniWebViewPlugin.SetAlpha(base.gameObject.name, Mathf.Clamp01(value));
		}
	}

	public bool immersiveMode
	{
		get
		{
			return this._immersiveMode;
		}
		set
		{
			this._immersiveMode = value;
			UniWebViewPlugin.SetImmersiveModeEnabled(base.gameObject.name, this._immersiveMode);
		}
	}

	private void ForceUpdateInsetsInternal(UniWebViewEdgeInsets insets)
	{
		this._insets = insets;
		UniWebViewPlugin.ChangeInsets(base.gameObject.name, this.insets.top, this.insets.left, this.insets.bottom, this.insets.right);
	}

	public static void SetUserAgent(string value)
	{
		UniWebViewPlugin.SetUserAgent(value);
	}

	public static void ResetUserAgent()
	{
		UniWebViewPlugin.SetUserAgent(null);
	}

	public void Load()
	{
		string text = (!string.IsNullOrEmpty(this.url)) ? this.url.Trim() : "about:blank";
		UniWebViewPlugin.Load(base.gameObject.name, text);
	}

	public void Load(string aUrl)
	{
		this.url = aUrl;
		this.Load();
	}

	public void LoadHTMLString(string htmlString, string baseUrl)
	{
		UniWebViewPlugin.LoadHTMLString(base.gameObject.name, htmlString, baseUrl);
	}

	public void Reload()
	{
		UniWebViewPlugin.Reload(base.gameObject.name);
	}

	public void Stop()
	{
		UniWebViewPlugin.Stop(base.gameObject.name);
	}

	public void Show(bool fade = false, UniWebViewTransitionEdge direction = UniWebViewTransitionEdge.None, float duration = 0.4f, Action finishAction = null)
	{
		this._lastScreenHeight = UniWebViewHelper.screenHeight;
		this.ResizeInternal();
		UniWebViewPlugin.Show(base.gameObject.name, fade, (int)direction, duration);
		this._showTransitionAction = finishAction;
		if (this.toolBarShow)
		{
			this.ShowToolBar(true);
		}
	}

	public void Hide(bool fade = false, UniWebViewTransitionEdge direction = UniWebViewTransitionEdge.None, float duration = 0.4f, Action finishAction = null)
	{
		UniWebViewPlugin.Hide(base.gameObject.name, fade, (int)direction, duration);
		this._hideTransitionAction = finishAction;
	}

	public void EvaluatingJavaScript(string javaScript)
	{
		UniWebViewPlugin.EvaluatingJavaScript(base.gameObject.name, javaScript);
	}

	public void AddJavaScript(string javaScript)
	{
		UniWebViewPlugin.AddJavaScript(base.gameObject.name, javaScript);
	}

	public void CleanCache()
	{
		UniWebViewPlugin.CleanCache(base.gameObject.name);
	}

	public void CleanCookie(string key = null)
	{
		UniWebViewPlugin.CleanCookie(base.gameObject.name, key);
	}

	[Obsolete("SetTransparentBackground is deprecated, please use SetBackgroundColor instead.")]
	public void SetTransparentBackground(bool transparent = true)
	{
		UniWebViewPlugin.TransparentBackground(base.gameObject.name, transparent);
	}

	public void SetBackgroundColor(Color color)
	{
		UniWebViewPlugin.SetBackgroundColor(base.gameObject.name, color.r, color.g, color.b, color.a);
	}

	public void ShowToolBar(bool animate)
	{
	}

	public void HideToolBar(bool animate)
	{
	}

	public void SetShowSpinnerWhenLoading(bool show)
	{
		UniWebViewPlugin.SetSpinnerShowWhenLoading(base.gameObject.name, show);
	}

	public void SetSpinnerLabelText(string text)
	{
		UniWebViewPlugin.SetSpinnerText(base.gameObject.name, text);
	}

	public void SetUseWideViewPort(bool use)
	{
		UniWebViewPlugin.SetUseWideViewPort(base.gameObject.name, use);
	}

	public bool CanGoBack()
	{
		return UniWebViewPlugin.CanGoBack(base.gameObject.name);
	}

	public bool CanGoForward()
	{
		return UniWebViewPlugin.CanGoForward(base.gameObject.name);
	}

	public void GoBack()
	{
		UniWebViewPlugin.GoBack(base.gameObject.name);
	}

	public void GoForward()
	{
		UniWebViewPlugin.GoForward(base.gameObject.name);
	}

	public void AddPermissionRequestTrustSite(string url)
	{
		UniWebViewPlugin.AddPermissionRequestTrustSite(base.gameObject.name, url);
	}

	public void AddUrlScheme(string scheme)
	{
		UniWebViewPlugin.AddUrlScheme(base.gameObject.name, scheme);
	}

	public void RemoveUrlScheme(string scheme)
	{
		UniWebViewPlugin.RemoveUrlScheme(base.gameObject.name, scheme);
	}

	public void SetHeaderField(string key, string value)
	{
		UniWebViewPlugin.SetHeaderField(base.gameObject.name, key, value);
	}

	public void SetVerticalScrollBarShow(bool show)
	{
		UniWebViewPlugin.SetVerticalScrollBarShow(base.gameObject.name, show);
	}

	public void SetHorizontalScrollBarShow(bool show)
	{
		UniWebViewPlugin.SetHorizontalScrollBarShow(base.gameObject.name, show);
	}

	private bool OrientationChanged()
	{
		int screenHeight = UniWebViewHelper.screenHeight;
		if (this._lastScreenHeight != screenHeight)
		{
			this._lastScreenHeight = screenHeight;
			return true;
		}
		return false;
	}

	private void ResizeInternal()
	{
		int screenHeight = UniWebViewHelper.screenHeight;
		int screenWidth = UniWebViewHelper.screenWidth;
		UniWebViewEdgeInsets insets = this.insets;
		if (this.InsetsForScreenOreitation != null)
		{
			UniWebViewOrientation orientation = (screenHeight < screenWidth) ? UniWebViewOrientation.LandScape : UniWebViewOrientation.Portrait;
			insets = this.InsetsForScreenOreitation(this, orientation);
		}
		this.ForceUpdateInsetsInternal(insets);
	}

	private void LoadComplete(string message)
	{
		bool flag = string.Equals(message, string.Empty);
		bool flag2 = this.OnLoadComplete != null;
		if (flag)
		{
			if (flag2)
			{
				this.OnLoadComplete(this, true, null);
			}
			if (this.autoShowWhenLoadComplete)
			{
				this.Show(false, UniWebViewTransitionEdge.None, 0.4f, null);
			}
		}
		else
		{
			UnityEngine.Debug.LogWarning(string.Concat(new string[]
			{
				"Web page load failed: ",
				base.gameObject.name,
				"; url: ",
				this.url,
				"; error:",
				message
			}));
			if (flag2)
			{
				this.OnLoadComplete(this, false, message);
			}
		}
	}

	private void LoadBegin(string url)
	{
		if (this.OnLoadBegin != null)
		{
			this.OnLoadBegin(this, url);
		}
	}

	private void ReceivedMessage(string rawMessage)
	{
		UniWebViewMessage message = new UniWebViewMessage(rawMessage);
		if (this.OnReceivedMessage != null)
		{
			this.OnReceivedMessage(this, message);
		}
	}

	private void WebViewDone(string message)
	{
		bool flag = true;
		if (this.OnWebViewShouldClose != null)
		{
			flag = this.OnWebViewShouldClose(this);
		}
		if (flag)
		{
			this.Hide(false, UniWebViewTransitionEdge.None, 0.4f, null);
			UnityEngine.Object.Destroy(this);
		}
	}

	private void WebViewKeyDown(string message)
	{
		int keyCode = Convert.ToInt32(message);
		if (this.OnReceivedKeyCode != null)
		{
			this.OnReceivedKeyCode(this, keyCode);
		}
	}

	private void EvalJavaScriptFinished(string result)
	{
		if (this.OnEvalJavaScriptFinished != null)
		{
			this.OnEvalJavaScriptFinished(this, result);
		}
	}

	private void AnimationFinished(string identifier)
	{
	}

	private void ShowTransitionFinished(string message)
	{
		if (this._showTransitionAction != null)
		{
			this._showTransitionAction();
			this._showTransitionAction = null;
		}
	}

	private void HideTransitionFinished(string message)
	{
		if (this._hideTransitionAction != null)
		{
			this._hideTransitionAction();
			this._hideTransitionAction = null;
		}
	}

	[DebuggerHidden]
	private IEnumerator LoadFromJarPackage(string jarFilePath)
	{
		UniWebView.<LoadFromJarPackage>c__IteratorB <LoadFromJarPackage>c__IteratorB = new UniWebView.<LoadFromJarPackage>c__IteratorB();
		<LoadFromJarPackage>c__IteratorB.jarFilePath = jarFilePath;
		<LoadFromJarPackage>c__IteratorB.<$>jarFilePath = jarFilePath;
		<LoadFromJarPackage>c__IteratorB.<>f__this = this;
		return <LoadFromJarPackage>c__IteratorB;
	}

	private void Awake()
	{
		this._currentGUID = Guid.NewGuid().ToString();
		base.gameObject.name = base.gameObject.name + this._currentGUID;
		UniWebViewPlugin.Init(base.gameObject.name, this.insets.top, this.insets.left, this.insets.bottom, this.insets.right);
		this._lastScreenHeight = UniWebViewHelper.screenHeight;
	}

	private void Start()
	{
		if (this.loadOnStart)
		{
			this.Load();
		}
	}

	private void OnDestroy()
	{
		this.RemoveAllListeners();
		UniWebViewPlugin.Destroy(base.gameObject.name);
		base.gameObject.name = base.gameObject.name.Replace(this._currentGUID, string.Empty);
	}

	private void RemoveAllListeners()
	{
		this.OnLoadBegin = null;
		this.OnLoadComplete = null;
		this.OnReceivedMessage = null;
		this.OnReceivedKeyCode = null;
		this.OnEvalJavaScriptFinished = null;
		this.OnWebViewShouldClose = null;
		this.InsetsForScreenOreitation = null;
	}

	private void Update()
	{
		if (this.OrientationChanged())
		{
			this.ResizeInternal();
		}
	}
}
