using System;
using System.Collections.Generic;
using System.Text;

namespace StatusBar_DALS.VistaModelo
{
    public interface VMstatusbar
    {
        void OcultarStatusBar();
        void MostrarStatusBar();
        void Traslucido();
        void Transparente();
        void CambiarColor();
    }
}
