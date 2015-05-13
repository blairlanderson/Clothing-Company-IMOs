<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductCatalog.aspx.cs" Inherits="ProductCatalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table, td, tr {
            border: 1px solid black;
        }

        #head {
            width: 780px;
            height: 80px;
        }
    </style>
</head>
<body>
    <h1>Company Header</h1>
        <img src="images/img.jpg" id="head"/>
        <p><strong>Mission Statement:</strong> Equip Yourself For Anything</p>

    <form id="form1" runat="server">
    <div>       
        <h3>Winter 2015 Catalog</h3>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table>
                    <tr>
                        <td>ID:</td>
                        <td>Name:</td>
                        <td>Price:</td>
                        <td>Description:</td>
                        <td>Size:</td>
                        <td>Colour:</td>
                        <td>Status:</td>
                        <td>Notes:</td>                        
                        <td>Image:</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>

                <tr>
                    <td><%# DataBinder.Eval(Container.DataItem, "ProductlID") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Name") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "RetailPrice") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Description") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Size") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Colour") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Status") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "ImageFile") %></td>
                    <td><img width="100" height="100" src="images/<%# DataBinder.Eval(Container.DataItem, "ImageFile") %>"/></td>
                    
                    
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
