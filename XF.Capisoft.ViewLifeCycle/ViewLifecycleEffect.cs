using System;
using Xamarin.Forms;

namespace XF.Capisoft.ViewLifeCycle
{
    public class ViewLifecycleEffect : RoutingEffect
    {
        public const string EffectGroupName = "XamarinForms.Lifecycle";
        public const string EffectName = "LifecycleEffect";

        public event EventHandler<EventArgs> Loaded;
        public event EventHandler<EventArgs> Unloaded;

        public ViewLifecycleEffect() : base($"{EffectGroupName}.{EffectName}") { }

        public void RaiseLoaded(Element element) => Loaded?.Invoke(element, EventArgs.Empty);
        public void RaiseUnloaded(Element element) => Unloaded?.Invoke(element, EventArgs.Empty);
    }
}
