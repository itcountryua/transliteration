<%@ Page Language="C#" AutoEventWireup="true" CodeFile="get_atu.aspx.cs" Inherits="get_atu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:auto; text-align:center; font-size:26px; max-width:700px;">
            Даний сервіс дозволяє отримати дані по кожному населеному пункту України у транслітерованому форматі
        </div>
    <table style="width:100%;">
        <tr>
            <td style="width:250px; vertical-align:top;">
                <asp:Label ID="Label3" runat="server" Text="Оберіть населений пункт:" style="margin-left:5px; font-size:20px;"></asp:Label>
            </td>
            <td style="vertical-align:top;">
                 <asp:Label ID="Label1" runat="server" Font-Names="Segoe UI" style="font-size: large"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Names="Segoe UI" style="font-size: large"></asp:Label>
            </td>            
        </tr>        
        <tr>
            <td style="width:250px; vertical-align:top;">
                <div style="margin-top:-18px;">
        <asp:TreeView ID="TreeView1" runat="server" ForeColor="#000066" OnTreeNodePopulate="TreeView1_TreeNodePopulate" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
            <NodeStyle Font-Names="Segoe UI" />
        </asp:TreeView>
                    </div>
            </td>
            <td style="vertical-align:top;">
                <asp:GridView PageSize="1000" ID="GridView1" runat="server" ShowHeader="False" AutoGenerateColumns="False"  ForeColor="#333333" GridLines="None" CellPadding="4" >
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>                                 
                            <asp:BoundField ItemStyle-Width="270px" DataField="RAZ" HeaderText="номер" >
                                <HeaderStyle Width="270px" />
<ItemStyle Width="270px"></ItemStyle>
                                </asp:BoundField>
                            <asp:BoundField ItemStyle-Width="270px" DataField="DVA" HeaderText="дата" >
                                <HeaderStyle Width="270px" />
<ItemStyle Width="270px"></ItemStyle>
                                </asp:BoundField>
                                </Columns>
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle ForeColor="#333333" HorizontalAlign="Center" BackColor="#FFCC66" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>

            </td>            
        </tr>        
    </table>
    </form>
    </body>
</html>
