using System;
using System.Linq;
using Android.Views;
using XF.Capisoft.ViewLifeCycle;
using XF.Capisoft.ViewLifeCycle.Android;

[assembly: Xamarin.Forms.ResolutionGroupName(ViewLifecycleEffect.EffectGroupName)]
[assembly: Xamarin.Forms.ExportEffect(typeof(AndroidViewLifecycleEffect), ViewLifecycleEffect.EffectName)]
namespace XF.Capisoft.ViewLifeCycle.Android
{
    public class AndroidViewLifecycleEffect : Xamarin.Forms.Platform.Android.PlatformEffect
    {
        private View _nativeView;
        private ViewLifecycleEffect _viewLifecycleEffect;

        protected override void OnAttached()
        {
            _viewLifecycleEffect = Element.Effects.OfType<ViewLifecycleEffect>().FirstOrDefault();

            _nativeView = Control ?? Container;
            _nativeView.ViewAttachedToWindow += OnViewAttachedToWindow;
            _nativeView.ViewDetachedFromWindow += OnViewDetachedFromWindow;
        }

        protected override void OnDetached()
        {
            View view = Control ?? Container;
            _viewLifecycleEffect.RaiseUnloaded(Element);
            _nativeView.ViewAttachedToWindow -= OnViewAttachedToWindow;
            _nativeView.ViewDetachedFromWindow -= OnViewDetachedFromWindow;
        }

        private void OnViewAttachedToWindow(object sender, View.ViewAttachedToWindowEventArgs e)
        {
            _viewLifecycleEffect?.RaiseLoaded(Element);
        }
        private void OnViewDetachedFromWindow(object sender, View.ViewDetachedFromWindowEventArgs e) => _viewLifecycleEffect?.RaiseUnloaded(Element);
    }
}
