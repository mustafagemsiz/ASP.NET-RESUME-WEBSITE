<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yetenek.aspx.cs" Inherits="CvProject.Yetenek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <table class="table">
            <thead class="thead-dark">
                <tr>
                    <th scope="col">ID</th>
                    <th scope="col">YETENEKLER</th>
                    <th scope="col">İŞLEMLER</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th scope="row"><%#Eval("ID")%></th>
                            <td><%#Eval("YETENEK")%></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%#"YetenekSil.aspx?ID="+Eval("ID")%>'>Sil</asp:HyperLink>
                                <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%#"YetenekGuncelle.aspx?ID="+Eval("ID")%>'>Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                        </tbody>
                    </ItemTemplate>
                </asp:Repeater>
        </table>
        <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn btn-primary" NavigateUrl="~/YetenekEkle.aspx">Yeni Ekle</asp:HyperLink>
    </form>
</asp:Content>
