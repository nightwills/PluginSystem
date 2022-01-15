using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewMainInterface;
namespace NewPlugins1
{
    public partial class Form1 : Form
    {
        private readonly IPlugin _pl;
        public Form1(IPlugin pl)
        {
            InitializeComponent();
            this._pl = pl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
