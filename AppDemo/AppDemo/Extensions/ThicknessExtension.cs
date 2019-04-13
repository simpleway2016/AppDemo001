using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDemo
{
    [ContentProperty(nameof(Value))]
    public class ThicknessExtension : IMarkupExtension
    {
        public string Value { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(Value))
            {
                return null;
            }
            return GetThickness(Value);
        }
        public static Thickness GetThickness(string value)
        {
            if (value.Contains("/"))
            {
                string[] arr = value.Split('/');
                var scale = App.CurrentDevice.ScreenWidth / SizeExtension.DesignWidth;
                return new Thickness(Convert.ToDouble(arr[0]) * scale, Convert.ToDouble(arr[1]) * scale, Convert.ToDouble(arr[2]) * scale, Convert.ToDouble(arr[3]) * scale);
            }
            else
            {
                double result = Convert.ToDouble(value);
                result *= App.CurrentDevice.ScreenWidth / SizeExtension.DesignWidth;
                return new Thickness(result);
            }
        }
    }

}
