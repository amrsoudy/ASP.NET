<!-- <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %> -->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script runat="server">
        protected void convert_us_can(object sender, EventArgs e)
        {
            decimal USAmount = Decimal.Parse(us.Value);
            if (USAmount > 0)
            {

                decimal euroAmount = USAmount * 0.85M;

                can.Value = euroAmount.ToString() + "$ Can ";
                can.Disabled = true;
                //canDiv.InnerHtml = euroAmount.ToString() + "$ can";
                HttpContext _context = HttpContext.Current;
                _context.Items.Add("can", euroAmount.ToString());
                Server.Transfer("resultat.aspx");


            }
            else {


                Response.Redirect("erreur.html");

            }




        }


    </script>

</head>
<body>
    <form id="form1" runat="server">

        <table style="width: 50%;">

            <tr>

                <td>Mountant  us </td>

                <td>
                    <input id="us" type="text" runat="server" />
                </td>

            </tr>
            <tr>

                <td colspan="2">

                    <input id="Submit1" type="submit" value="submit" onclick="afficher()" onserverclick="convert_us_can" runat="server" />
                </td>


            </tr>

            <tr>

                <td>Mountant  $ cad </td>

                <td>
                    <input id="can" type="text" runat="server" />
                </td>

            </tr>

            <tr>

                <td>Mountant  $ CAN dans DIV </td>

                <td>

                    <div style="border-style: dotted; width: 118px;" id="canDiv" runat="server" />

                </td>

            </tr>
        </table>


    </form>




</body>
</html>
