using System;
using Android.App;
using Android.Runtime;
using Shiny;

namespace ShinyTest.Droid
{
    [Application(
        Theme = "@style/MainTheme"
        )]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            this.ShinyOnCreate(new MyShinyStartup());
            base.OnCreate();
            Xamarin.Essentials.Platform.Init(this);
        }
    }
}
