<%@ Page Language="C#" AutoEventWireup="true" CodeFile="name.aspx.cs" Inherits="name" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Транслітерація ПІБ</title>
    <script type="text/javascript">
    function RefreshUpdatePanel() {
        __doPostBack('<%= LB_PR.ClientID %>', '');
    };

          function RefreshUpdatePanel1() {
        __doPostBack('<%= LB_IM.ClientID %>', '');
          };

          function RefreshUpdatePanel2() {
        __doPostBack('<%= LB_PB.ClientID %>', '');
    };
</script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>  
    <div>  
            <div style="text-align:center; max-width:550px;">
                За допомогою даного сервісу є можливість провести транслітерацію згідно з Постановою Кабінету Міністрів України від 27 січня 2010 р. N 55 «Про впорядкування транслітерації українського алфавіту латиницею» та переглянути як будуть виглядати Ваші дані
            </div>      
        <table style="margin-left:20px;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Прізвище" Font-Names="Arial" style="font-size: small"></asp:Label>   
                    <br />     
            <asp:TextBox ID="TB_PR" Width="147" runat="server" onkeyup="RefreshUpdatePanel();" AutoPostBack="true" OnTextChanged="TB_PR_TextChanged" TabIndex="1"></asp:TextBox>                                                                            
                </td>
                <td>    
                    <asp:Label ID="Label2" runat="server" Text="Ім’я" Font-Names="Arial" style="font-size: small"></asp:Label>   
                    <br />                  
                    <asp:TextBox ID="TB_IM" Width="147" runat="server" onkeyup="RefreshUpdatePanel1();" AutoPostBack="true" OnTextChanged="TB_IM_TextChanged" TabIndex="2"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="По батькові" Font-Names="Arial" style="font-size: small"></asp:Label>   
                    <br />  
                    <asp:TextBox ID="TB_PB" Width="147" runat="server" onkeyup="RefreshUpdatePanel2();" AutoPostBack="true" OnTextChanged="TB_PB_TextChanged" TabIndex="3"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td style="background-image: url('tr_2.jpg');height:500px; width:500px; background-size:contain; background-repeat: no-repeat; vertical-align:top;">
                    <br />
                    <br />
                    <br />
                    <br />                                   
                      <asp:UpdatePanel ID="Update" runat="server">
        <ContentTemplate>                        
            <asp:Label ID="LB_PR" runat="server" Text="" style="margin-left:220px; font-size:25px; color: #000000; font-weight: 700;"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="TB_PR" />
        </Triggers>
    </asp:UpdatePanel>                    
                    
                    <br />                    
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate> 
            <asp:Label ID="LB_IM" runat="server" Text="" style="margin-left:220px; font-size:25px; color: #000000; font-weight: 700;"></asp:Label>                                   
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="TB_IM" />
        </Triggers>
    </asp:UpdatePanel>
                
                    <br />
                    
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate> 
            <asp:Label ID="LB_PB" runat="server" Text="" style="margin-left:220px; font-size:25px; color: #000000; font-weight: 700;"></asp:Label>            
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="TB_PB" />
        </Triggers>
    </asp:UpdatePanel>
                </td>            
            </tr>           
        </table>

    </div>
         
               
    

    </form>
</body>
</html>
