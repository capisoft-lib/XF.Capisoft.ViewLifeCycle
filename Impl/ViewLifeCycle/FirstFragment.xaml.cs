using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using XF.Capisoft.ViewLifeCycle;

namespace ViewLifeCycle
{
    public partial class FirstFragment : LivingContentView
    {
        public MyButtonViewModel ViewModel { get; set; }

        public FirstFragment()
        {
            this.ViewModel = new MyButtonViewModel();
            this.BindingContext = this.ViewModel;
            InitializeComponent();
        }

        public override void Loaded()
        {
            ViewModel.ButtonText = "LOADED";
        }
    }
}
