using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using XF.Capisoft.ViewLifeCycle;

namespace ViewLifeCycle
{
    public partial class MyButton : Button, IViewLifecycle
    {
        public MyButtonViewModel ViewModel { get; set; }

        public MyButton()
        {
            ViewModel = new MyButtonViewModel();
            this.BindingContext = this.ViewModel;

            InitializeComponent();
        }

        public void Loaded()
        {
            this.ViewModel.ButtonText = "Button Loaded";
        }

        public void Unloaded()
        {
            this.ViewModel.ButtonText = "Button Unloaded";
        }
    }
}
