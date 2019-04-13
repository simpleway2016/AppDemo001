using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageVM();
        }

        private void zhCN_Click(object sender, EventArgs e)
        {
            App.TextResource.LoadTextResource("zh-CN");
        }

        private void enUS_Click(object sender, EventArgs e)
        {
            App.TextResource.LoadTextResource("en-US");
        }
    }
    
}
