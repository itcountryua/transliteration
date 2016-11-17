<%@ Page Language="C#" AutoEventWireup="true" CodeFile="transletee.aspx.cs" Inherits="transletee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div>    
        <table style="width:100%; border-collapse:collapse;">
            <tr>
                <td style="width:48%;">
                    <asp:TextBox Width="100%"  Height="250" ID="TB_FROM" runat="server" CssClass="auto-style1" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td style="width:4%; vertical-align:central; text-align:center;">
                    
                    <asp:ImageButton ID="IMBT_TRANSLETE" runat="server" Height="25px" ImageUrl="~/gtk-refresh.png" Width="26px" OnClick="IMBT_TRANSLETE_Click" />
                    
                </td>
                <td style="width:48%;">
                    <asp:TextBox Width="100%" Height="250" ID="TB_TO" runat="server" CssClass="auto-style1" TextMode="MultiLine"></asp:TextBox>
                </td>                
            </tr>
        </table>    
    </div>            
    </form>
</body>
</html>
