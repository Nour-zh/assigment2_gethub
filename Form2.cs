using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment2_gethub
{
    public partial class Form2 : Form
    {
        private string _username;
       
        public Form2(string username )
        {
            _username = username;
            

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblmessagename.Text = _username;
            
        }
    }
}
