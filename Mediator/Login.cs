using Mediator.Pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact mySelf = new Contact(textBox1.Text);
            MediatorHelper.Instance().ChatRoom.Register(mySelf);

            contactForm contactListForm = new contactForm(textBox1.Text);
            this.Visible = false;
            contactListForm.ShowDialog();
            this.Close();
        }
    }
}
