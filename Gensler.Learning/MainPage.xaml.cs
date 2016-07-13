using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.UI;

namespace Gensler.Learning
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page, IDockablePaneProvider
    {
        public MainPage()
        {
            InitializeComponent();
            this.Browser.Navigate("http://10.37.129.2:3000/");
        }

        public void SetupDockablePane(DockablePaneProviderData data)
        {
            data.FrameworkElement = this;
            //data.InitialState.DockPosition = DockPosition.Tabbed;
            //data.InitialState.TabBehind = DockablePanes.BuiltInDockablePanes.ProjectBrowser;
        }
    }
}
