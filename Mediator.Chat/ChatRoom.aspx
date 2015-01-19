<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChatRoom.aspx.cs" Inherits="Mediator.Chat.ChatRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="messageField" runat="server" Height="486px" Width="674px"></asp:ListBox>
        <asp:ListBox ID="contactList" runat="server" Height="483px" style="margin-top: 0px" Width="215px"></asp:ListBox>
        <br />
        <br />
        <asp:TextBox ID="txtMessage" runat="server" Width="666px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Gönder" />
        <input type="hidden" ID="UserName" value="" runat="server"/>
    </div>
    </form>
    
</body>
</html>
