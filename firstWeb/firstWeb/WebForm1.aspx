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
            <h1>New Year party!!!</h1>
            <p>Hey, if you'd like to join the best New Year party ever, sign in here!</p>
        </div>
        <div>
            <label>Your name:</label><input type="text", id="name" />
        </div>
        <div>
            <label>Your surname:</label><input type="text" id="surname" />
        </div>
        <div>
            <asp:Button ID="ButtonSignIn"
                Text="Sign in!"
                Onclick="buttonSignInOnClick"
                runat="server" />
            <br />
            <br />
            <asp:Label ID="SignInLabel"
                runat="server"
                Visible="false"
                Text="You've signed in!" />
            <br />
            <br />
            <asp:Button ID="ButtonNext"
                Text ="Go next!"
                runat ="server"
                Visible ="false" />
        </div>
    </form>
</body>
</html>
