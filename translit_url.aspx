<%@ Page Language="C#" AutoEventWireup="true" CodeFile="translit_url.aspx.cs" Inherits="translit_url" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Транслітерація посилання</title>
</head>
<body>    
    <form id="form1" runat="server">
    <div>
    <div>    
        <asp:Label ID="Label1" Font-Size="Large" runat="server" Text="Транслітерація URL посилання"></asp:Label>    
        <br />        
        <table style="width: 100%;">
            <tr>
                <td style="width:100px;" >
                    <asp:Label ID="Label2" Font-Size="Large" runat="server" Text="Посилання:"></asp:Label>    
                </td>
                <td style="width:700px" >
                    <asp:TextBox ID="TB_URL" Font-Size="20" Width="690px"  runat="server"></asp:TextBox>        
                </td>
                <td>
                    <asp:ImageButton ID="IMBT_TRANSLITERATION" runat="server" ImageUrl="~/synchronizationtitle.png" OnClick="IMBT_TRANSLITERATION_Click" />
                </td>
            </tr>            
        </table>
    </div>
        <div id="TEKST_DOKUMENTU" runat="server">
        </div>                
    </div>
    </form>
</body>
</html>
