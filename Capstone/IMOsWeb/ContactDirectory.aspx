<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactDirectory.aspx.cs" Inherits="ContactDirectory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
    
</head>
<body>
    <h1>Company Header</h1>
        <img src="images/img.jpg" id="head"/>
        <p><strong>Mission Statement:</strong> Equip Yoself.</p>

    <form id="form1" runat="server">
    <div>       
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table>
                    <tr>
                        <td>ID:</td>
                        <td>Company Id</td>
                        <td>First Name</td>
                        <td>Last Name</td>
                        <td>Title</td>
                        <td>Extension</td>
                        <td>Branch</td>
                        <td>Signature</td>                        
                        <td>Salutation</td>
                        <td>Image?</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>

                <tr>
                    <td><%# DataBinder.Eval(Container.DataItem, "Id") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "companyId") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "firstName") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "lastName") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "title") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "extension") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "branchId") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "signature") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "salutation") %></td>
                    <td><img width="100" height="100" src="images/<%# DataBinder.Eval(Container.DataItem, "Id") +".jpg" %>"/></td>
                    
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
