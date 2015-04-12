using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlanlarBot
{
    public partial class Destek : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();


        public Destek()
        {
            base.Load += new EventHandler(this.Form4_Load);
            __ENCAddToList(this);
            this.InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            //  MyProject.Forms.Form1.WebBrowser1.Navigate(MyProject.Forms.Form2.TextBox11.Text);
        }

        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                if (__ENCList.Count == __ENCList.Capacity)
                {
                    int index = 0;
                    int num3 = __ENCList.Count - 1;
                    for (int i = 0; i <= num3; i++)
                    {
                        WeakReference reference = __ENCList[i];
                        if (reference.IsAlive)
                        {
                            if (i != index)
                            {
                                __ENCList[index] = __ENCList[i];
                            }
                            index++;
                        }
                    }
                    __ENCList.RemoveRange(index, __ENCList.Count - index);
                    __ENCList.Capacity = __ENCList.Count;
                }
                __ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*   HtmlElement elementById = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_spear");
               HtmlElement element7 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_sword");
               HtmlElement element2 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_axe");
               HtmlElement element4 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_spy");
               HtmlElement element5 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_light");
               HtmlElement element = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_heavy");
               HtmlElement element3 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_ram");
               HtmlElement element8 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_catapult");
               HtmlElement element11 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("unit_input_snob");
               HtmlElement element10 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("target_support");
               HtmlElement element6 = MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("input");
               elementById.SetAttribute("Value", this.TextBox1.Text);
               element7.SetAttribute("Value", this.TextBox2.Text);
               element2.SetAttribute("Value", this.TextBox3.Text);
               element4.SetAttribute("Value", this.TextBox4.Text);
               element5.SetAttribute("Value", this.TextBox5.Text);
               element.SetAttribute("Value", this.TextBox6.Text);
               element3.SetAttribute("Value", this.TextBox7.Text);
               element8.SetAttribute("Value", this.TextBox8.Text);
               element11.SetAttribute("Value", this.TextBox9.Text);
               element6.SetAttribute("Value", this.TextBox10.Text);
               element10.InvokeMember("Click");*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // MyProject.Forms.Form1.WebBrowser1.Document.GetElementById("troop_confirm_go").InvokeMember("Click");
        }
    }
}
