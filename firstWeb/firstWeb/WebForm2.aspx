<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="firstWeb.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        table, th, td, tr {
            border: 1px solid black;
            width: 200px;
            text-align: center;
        }
        p {
            font-size: 20px;
            font-weight: 600;
        }
        .tableUser {
            width: 300px;
            float: left;
        }
        .tableFoods {
            width: 300px;
            float: left;
        }
        .clear {
            clear: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>This is your New Year company:</h1>
        </div>
        <div class="tableUser">
            <asp:Table ID="tableUsers"
                runat="server" />
        </div>
        <div class="tableFoods">
            <asp:Table ID="tableFood"
                runat="server" />
        </div>
        <div class="clear"></div>
        <div>
            <p>I want to bring some food!</p>
            Write what u want to bring in the field and then press the button
        </div>
        <div>
            <asp:Button ID="AddFoodButton"
                runat="server"
                OnClick="addFoodButtonOnClick"
                Text="Add food" />
            <asp:TextBox ID="textAddFood"
                runat="server"
                style="margin-left: 50px" />
        </div>
        <div>
            <p>I've changed my mind and don't wanna join the party</p>
            <asp:Button ID="leaveButton"
                runat="server"
                OnClick="leaveButtonOnClick"
                Text="Leave the party" style="margin-left: 3px" />
        </div>
    </form>
</body>
</html>
