using Xamarin.Forms;

namespace XFControlTemplate.Views
{
  public partial class View1 : ContentView
  {
    public View1()
    {
      InitializeComponent();
      ImageSource image =
          ImageSource.FromResource("XFControlTemplate.Images.img6.PNG");
      //          
      Image ctl = this.FindByName<Image>("imgCtl");
      ctl.Source = image;
      ctl.Rotation = 0;
      ctl.RotateTo(360, 500);
      //ctl.RotateTo(360, 500).ContinueWith((task) =>
      //{
      //    ctl.Rotation = 0;

      //});
    }
  }
}