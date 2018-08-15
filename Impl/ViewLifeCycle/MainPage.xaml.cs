using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Capisoft.ViewLifeCycle;

namespace ViewLifeCycle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //ViewLifecycleEffect effect = Effect.Resolve($"{ViewLifecycleEffect.EffectGroupName}.{ViewLifecycleEffect.EffectName}") as ViewLifecycleEffect;
            //effect.Loaded += Handle_Loaded;
            //effect.Unloaded += Handle_Unloaded;
            //this.Effects.Add(effect);
        }

        void Handle_Loaded(object sender, System.EventArgs e)
        {
            DisplayAlert("LifeCycle", "Button Loaded", "OK");
        }

        void Handle_Unloaded(object sender, System.EventArgs e)
        {
            DisplayAlert("LifeCycle", "Button Unloaded", "OK");
        }
    }
}
