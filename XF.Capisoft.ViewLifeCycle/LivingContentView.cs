using System;
using Xamarin.Forms;

namespace XF.Capisoft.ViewLifeCycle
{
    public abstract class LivingContentView : ContentView, IViewLifecycle
    {
        protected ViewLifecycleEffect effect = new XF.Capisoft.ViewLifeCycle.ViewLifecycleEffect();

        public LivingContentView() : base(){
            effect.Loaded += Loaded_Method;
            effect.Unloaded += Unloaded_Method;
            this.Effects.Add(effect);
        }

        public virtual void Loaded(){}

        public virtual void Loaded_Method(object sender, EventArgs e) { Loaded(); }

        public virtual void Unloaded(){}

        public virtual void Unloaded_Method(object sender, EventArgs e) { Unloaded(); }
    }
}
