using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AppDemo.BaseModels
{
    class TextResourceModel:BaseViewModel
    {

        private Dictionary<string,string> _items;
        public Dictionary<string,string> items
        {
            get => _items;
            set
            {
                if (_items != value)
                {
                    _items = value;
                    this.OnPropertyChanged("items");
                }
            }
        }

        /// <summary>
        /// 加载文字资源
        /// </summary>
        /// <param name="langName">语言名称</param>
        /// <returns></returns>
        public void LoadTextResource(string langName)
        {
            langName = langName.Replace("-","_");

            using (var stream = typeof(TextResourceModel).GetTypeInfo().Assembly.GetManifestResourceStream($"AppDemo.Resources.lang.{langName}.json"))
            using (var sr = new System.IO.StreamReader(stream , System.Text.Encoding.UTF8))
            {
                var json = sr.ReadToEnd();
                this.items = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
        }
    }
}
