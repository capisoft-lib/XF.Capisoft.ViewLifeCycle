using System;
using System.ComponentModel;
using Android.Content;
using Android.Views;
using Xamarin.Forms.Platform.Android;
using XF.Capisoft.ViewLifeCycle;
using XF.Capisoft.ViewLifeCycle.Android;

//[assembly: Xamarin.Forms.ExportRenderer(typeof(LivingContentView), typeof(ViewLifecycleRender))]
namespace XF.Capisoft.ViewLifeCycle.Android
{
    public class ViewLifecycleRender : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<LivingContentView, View>
    {

        protected ViewLifecycleEffect effect = new XF.Capisoft.ViewLifeCycle.ViewLifecycleEffect();

        public ViewLifecycleRender(Context context) : base(context){
            effect.Loaded += (object sender, EventArgs e) => {
                if(sender is IViewLifecycle){
                    (sender as IViewLifecycle).Loaded();
                }
            };
            effect.Unloaded += (object sender, EventArgs e) => {
                if (sender is IViewLifecycle)
                {
                    (sender as IViewLifecycle).Unloaded();
                }
            };
        }

        protected override void OnElementChanged(ElementChangedEventArgs<LivingContentView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                e.NewElement.Effects.Add(effect);
            }
            else
            {
                e.OldElement.Effects.Remove(effect);
            }
        }
    }
}
