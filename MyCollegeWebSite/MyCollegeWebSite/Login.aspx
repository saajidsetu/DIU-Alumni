<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyCollegeWebSite.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
        body
        {
            background:#808080;
        }

        .fromclass
        {
            padding: 100px;
            margin:0px auto;
            background:#808080;
            width:200px;
        }

        h2
        {
            text-align:center;
        }
        .input
        {
            padding: 10px;
            }
            .auto-style2 {
                text-align: center;
            }
            .auto-style3 {
                margin-left: 0px;
            }
            .auto-style5 {
                width: 583px;
            }
            .auto-style6 {
                font-size: large;
                font-weight: bold;
                text-align: left;
                height: 33px;
            }
            .auto-style7 {
                height: 33px;
                width: 495px;
            }
            .auto-style8 {
                width: 82px;
                height: 33px;
            }
    </style>
</head>
<body style="width: 332px; height: 174px">
    
    <form id="form1" runat="server">
    <div>
        <table class="auto-style5">
        <tr>
            <td class="auto-style6">User Name</td>
    <center>
    
            <td class="auto-style7">
                <asp:TextBox ID="txt_username" runat="server" Width="220px" OnTextChanged="txt_username_TextChanged" Height="20px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_username" ErrorMessage="RequiredFieldValidator" ForeColor="Red">User Name IS Required</asp:RequiredFieldValidator>
            </td>
    
            <td class="auto-style8">
                </td>
        </tr>
        </center>
        <tr>
            <td class="auto-style6">Password</td>
    <center>
    
            <td class="auto-style7">
                <asp:TextBox ID="txt_password" type="password" runat="server" Width="220px" CssClass="auto-style3" Height="20px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_password" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Password Is Required</asp:RequiredFieldValidator>
            </td>
    
            <td class="auto-style8">
                </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Width="120px" />

                <asp:Label ID="Label1" runat="server"></asp:Label>

            </td>
        </tr>
    </table>
    </div>
    </form>
        </center>
    <p class="auto-style2">
        &nbsp;</p>
</body>
</html>
