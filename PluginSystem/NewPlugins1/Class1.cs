using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMainInterface;
namespace NewPlugins1
{
    public class Plugin1 : IPlugin
    {
        private string _Name = "Plugin1";
        private string _DisplayName = "Первый плагин";
        private string _Description = "Описание первого плагина";
        private string _Author = "NightWill";
        private int _Version = 1;
        private IPluginHost _Main;
        public void Visible()
        {
            Form1 first = new Form1(this);
            first.ShowDialog();
        }

        public IPluginHost Main
        {
            get { return this._Main; }
            set
            {
                this._Main = value;
                this._Main.Register(this);
            }
        }

        public string Name
        {
            get { return this._Name; }
        }

        public string DisplayName
        {
            get { return this._DisplayName; }
        }

        public string Description
        {
            get { return this._Description; }
        }

        public string Author
        {
            get { return this._Author; }
        }

        public int Version
        {
            get { return this._Version; }
        }
    }
}
