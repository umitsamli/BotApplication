using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KlanlarBot
{
    public partial class DetayliSaldiriGorunum : Form
    {
        public DetayliSaldiriGorunum()
        {
            InitializeComponent();
        }
         
        private void Form3_Load(object sender, EventArgs e)
        {
            dgvSaldiri.DataSource = Utility.BarbarianVillages;
        } 
    }
}
