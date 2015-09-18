using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_1_Agilametoder_SUW
   
    //Form1 starts
{
    public partial class Form1 :Form
    {
        List<String> addresslist = new List<string>();
        public Form1()
        {
            //person details
            InitializeComponent();
            addresslist.Add("Namn     Mejl     Nummer");
            addresslist.Add("Bengt     benga55@gmail.com     0701234567");
            addresslist.Add("Peter     ptr@hotspot.com     0701234576");
            addresslist.Add("Lina     lina_w@gmail.com     0701239654");
            addresslist.Add("Ahmed     ahmed_ahmed@gmail.com     0707654321");
            addresslist.Add("Angelica     angelangelica@gmail.com     0701212125");
            addresslist.Add("Olof     olof_olofsson5@gmail.com     0702223336");
            addresslist.Add("Clara     stensson_c@gmail.com     0730456789");
            addresslist.Add("Stina     stinastinastinastina@hotmail.com     0700554412");
            addresslist.Add("Bertil     beritochbertil@telia.com     0700000258");

        }
        // Serch perne name this box

        private void Serch_Click(object sender, EventArgs e)
        {
            addresslist.Add(textBox1.Text +"     "+ textBox2.Text + "     "+ textBox3.Text);
            Stuff();
        }

        // Find person details  here

        private void Finddetails_Click(object sender, EventArgs e)
        {
            int i = 0;while(i < addresslist.Count)
            {
                listBox1.Items.Add(addresslist.ElementAt(i));i++;
            }
            Stuff();
        }
        private void Stuff()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
        }

        //send email 

        private void sendemail_Click(object sender, EventArgs e)
        {

            string str = textBox4.Text;int i = 0;
            while (i < addresslist.Count)
            {if (addresslist.ElementAt(i).Contains(str)){    MessageBox.Show("Hittade: " + addresslist.ElementAt(i)); i++;}else
                {MessageBox.Show("Nope"); i++; }}
        }

        // Form 1 Finish
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
