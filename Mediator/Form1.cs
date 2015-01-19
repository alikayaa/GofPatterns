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
    public partial class contactForm : Form
    {
        private string myName = string.Empty;
        public contactForm(string Name)
        {
            this.myName = Name;
            InitializeComponent();
            InitializeMediator();
        }

        private void contactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string,Contact> selectedContact = (KeyValuePair<string,Contact>)contactList.SelectedItem;

        }

        private void InitializeMediator()
        {         
            contactList.DisplayMember = "Name";
            contactList.ValueMember = "";
            contactList.DataSource = MediatorHelper.Instance().ChatRoom._user.Where(i=> i.Key != myName).ToList();
        }
    }
}
