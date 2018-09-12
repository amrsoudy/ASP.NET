<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aspNetConverter.aspx.cs" Inherits="WebApplication2.aspNetConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            text-align: center;
            width: 378px;
        }
        .auto-style4 {
            text-align: center;
            width: 378px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Valeur a convertion </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="283px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">resultat</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="281px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert" Width="107px" />
                    </td>
                </tr>
            </table>

        </div>

      
    </form>

                <div runat="server" id="res"></div>

    </body>
</html>
