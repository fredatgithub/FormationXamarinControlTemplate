using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XFControlTemplate.Views;

namespace XFControlTemplate
{
    public partial class TestDataTemplate : ContentPage
    {
        public TestDataTemplate()
        {
            InitializeComponent();
            //ImageSource image = ImageSource.FromResource("XFDataTemplate.Images.img3.PNG");
            //Image ctl = this.FindByName<Image>("imgCtl");
            //ctl.Source = image;


        }

        private void Test()
        {
        //    ImageSource image = ImageSource.FromResource("XFDataTemplate.Views/Images/img3.PNG");
        //    img.Source = image;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
        }

        private void SwitchCell_OnOnChanged(object sender, ToggledEventArgs e)
        {
            ControlTemplate ctlTemplate = this.Resources["ctl1"] as ControlTemplate;
            if ((ctlTemplate != null)&&(e.Value))
            {
                ctlTemplate = new ControlTemplate(typeof(View2));
                this.Resources["ctl1"] = ctlTemplate;
                //

            }
            else if((ctlTemplate != null) && (!e.Value))
            {
                ctlTemplate = new ControlTemplate(typeof(View1));
                this.Resources["ctl1"] = ctlTemplate;
            }
        }
    }
}
