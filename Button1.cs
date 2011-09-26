using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GDX
{
    public class Button1 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public Button1()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;
            Form1 form1 = new Form1();
            form1.Activate();
            form1.Show();            
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
