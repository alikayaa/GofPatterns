using Mediator.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mediator.Chat
{
    public partial class ChatRoom : System.Web.UI.Page
    {
        public string CurrentUser
        {
            get { return UserName.Value;}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserName.Value = ((Contact)Session["User"]).Name;
                GetChatMessages();
                GetChatRoomUser();
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

            MediatorHelper.Instance().ChatRoom.SendMessage(CurrentUser, txtMessage.Text);
            txtMessage.Text = string.Empty;
            GetChatMessages();
            GetChatRoomUser();
        }

        private void GetChatRoomUser()
        {
            contactList.Items.Clear();
            foreach (KeyValuePair<string, Colleague> item in MediatorHelper.Instance().ChatRoom._user)
            {
                contactList.Items.Add(item.Key);
            }
        }

        private void GetChatMessages()
        {
            messageField.Items.Clear();
            foreach (var message in MediatorHelper.Instance().ChatRoom.UserMessage)
            {
                messageField.Items.Add(message);
            }
        }
    }
}