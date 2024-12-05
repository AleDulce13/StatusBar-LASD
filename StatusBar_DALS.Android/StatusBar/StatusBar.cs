using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plugin.CurrentActivity;
using StatusBar_DALS.Droid.StatusBar;
using StatusBar_DALS.VistaModelo;
using System.ComponentModel;
using Xamarin.Forms;

[assembly:Dependency(typeof(StatusBar))]

namespace StatusBar_DALS.Droid.StatusBar
{
    internal class StatusBar : VMstatusbar
    {
        public void CambiarColor()
        {
            throw new NotImplementedException();
        }

        public void MostrarStatusBar()
        {
            throw new NotImplementedException();
        }

        public void OcultarStatusBar()
        {
            throw new NotImplementedException();
        }

        public void Transparente()
        {
            throw new NotImplementedException();
        }

        public void Traslucido()
        {
            throw new NotImplementedException();
        }
    }
}