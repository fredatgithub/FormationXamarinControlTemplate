using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFControlTemplate.Views
{
    public partial class View2 : ContentView
    {
        public View2()
        {
            InitializeComponent();
            ImageSource image = ImageSource.FromResource("XFControlTemplate.Images.img3.PNG");
            Image ctl = this.FindByName<Image>("imgCtl");
            ctl.Source = image;
            ctl.RotateTo(360, 500).ContinueWith((task) =>
            {
                ctl.Rotation = 0;             
            });
        }
    }
}
