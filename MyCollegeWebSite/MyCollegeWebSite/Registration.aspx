<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MyCollegeWebSite.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 125px;
        }
        .auto-style2 {
            width: 391px;
        }
    </style>
</head>
<body>
    <center>
            <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>First Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_first" runat="server"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_first" ErrorMessage="Take a Single Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_last" runat="server"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_last" ErrorMessage="Take a Single Name " ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Username</td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_username" runat="server"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_username" ErrorMessage="Create a User Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_email" runat="server"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txt_email" ErrorMessage="Enter Valid Email" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_email" ErrorMessage="  You must Enter the valid email Id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_password" runat="server"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_password" ErrorMessage="Create a password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>PhoneNumber</td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_number" runat="server"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_number" ErrorMessage="Take a Valid Phone Number" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_address" runat="server"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_address" ErrorMessage="Valid Address" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Batch</td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_batch" runat="server"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_batch" ErrorMessage="Required Batch  " ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
        </tr>
    </table>
    </div>
    </form>
        </center>

</body>
</html>
