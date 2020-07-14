using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bottom_tab_navegation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
            //var pages = Children.GetEnumerator();
            //pages.MoveNext(); // primera pagina
            //pages.MoveNext(); // segunda pagina home
            //CurrentPage = pages.Current;
        }
    }
}