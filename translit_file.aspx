<%@ Page Language="C#" AutoEventWireup="true" CodeFile="translit_file.aspx.cs" Inherits="translit_file" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Транслітерація файлу</title>
</head>
<body>
    <form id="form1" runat="server">    
    <asp:Label ID="Label1" Font-Size="Large" runat="server" Text="Транслітерація DocX файлу" Font-Names="Segoe UI Light"></asp:Label>    
        <br />
        <div>
        <asp:Label ID="Label2" Font-Size="Large" runat="server" Font-Names="Segoe UI Light" Text="шлях до файлу:"></asp:Label>            
        <asp:FileUpload ID="FileUploadControl" runat="server" />
        <asp:ImageButton ID="IMBT_TRANSLITERATION"  runat="server" ImageUrl="~/synchronizationtitle.png" OnClick="IMBT_TRANSLITERATION_Click" />
            </div>    
    </form>
</body>
</html>
