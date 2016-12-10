<%@ Page Title="Cards" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WingtipToys.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            
                <h2><%:Page.Title %></h2>
            
            <asp:ListView ID="productList" runat="server"  
                DataKeyNames="ProductID" GroupItemCount="4" ItemType="WingtipToys.Models.Product" SelectMethod="GetProducts">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data Found</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate><td /></EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">    
                                    <img src="/Catalog/Images/<%#:Item.ImagePath%>"                                            
                                    width="230" height="318"  />
                                    </a> 
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <span>
                                            <%#:Item.ProductName%> 
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Price:</b><%#:Item.UnitPrice%> (Dust)
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                     <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                          <tr id="groupPlaceholder"></tr>
                                     </table>
                                </td>
                            </tr>
                            <tr>  
                            <td></td>                             
                            </tr>                             
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
