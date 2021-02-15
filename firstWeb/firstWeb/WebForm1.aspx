<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="firstWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Spring holidays party!!!</h1>
            <p>Hey, if you'd like to join the best New Year party ever, sign in here!</p>
        </div>
        <div>
            <asp:Label ID="labelName"
                Text="Your name:"
                runat="server"/>
            <asp:TextBox ID="textName"
                runat="server" style="margin-left: 40px" />
        </div>
        <div>
            <asp:Label ID="labelSurname"
                Text="Your surname:"
                runat="server"/>
            <asp:TextBox ID="textSurname"
                runat="server" style="margin-left: 21px" />
        </div>
        <div>
            <asp:Button ID="buttonSignIn"
                Text="Sign in!"
                Onclick="buttonSignInOnClick"
                runat="server" />
            <br />
            <br />
            <asp:Label ID="signInLabel"
                runat="server"
                Visible="false"
                Text="You've signed in!" />
            <br />
            <br />
            <asp:Button ID="buttonNext"
                Text ="Go next!"
                OnClick="buttonNextOnClick"
                runat ="server"
                Visible ="false" />
        </div>
    </form>
</body>
</html>
