using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDemo
{
    [ContentProperty(nameof(Value))]
    public class SizeExtension : IMarkupExtension
    {
        /// <summary>
        /// UI设计图的像素宽度
        /// </summary>
        public const double DesignWidth = 1024;
        public string Value { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {


            if (string.IsNullOrEmpty(Value))
            {
                return null;
            }
            var value = GetSize(Value);
            try
            {
                var target = serviceProvider.GetService<IProvideValueTarget>();

                Type proType;
                if (target.TargetProperty is System.Reflection.PropertyInfo)
                {
                    var property = (PropertyInfo)target.TargetProperty;
                    proType = property.PropertyType;

                }
                else
                {
                    BindableProperty pro = ((BindableProperty)target.TargetProperty);
                    proType = pro.ReturnType;

                }
                //根据绑定目标的类型，需要做一些转换
                if (proType == typeof(GridLength))
                    return new GridLength(value);
                else if (proType != typeof(double))
                    return Convert.ChangeType(value, proType);
                else
                    return value;

            }
            catch (Exception)
            {
                return value;
            }
        }
        public static double GetSize(string value)
        {
            var designValue = Convert.ToDouble(value);
            return (designValue * App.CurrentDevice.ScreenWidth) / DesignWidth;
        }
    }
}
