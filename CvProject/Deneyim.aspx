<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Deneyim.aspx.cs" Inherits="CvProject.Deneyim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">ID</th>
                <th scope="col">BASLIK</th>
                <th scope="col">ALTBASLIK</th>
                <th scope="col">AÇIKLAMA</th>
                <th scope="col">TARİH</th>
                <th scope="col">İŞLEMLER</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%#Eval("ID")%></th>
                        <td><%#Eval("BASLIK")%></td>
                        <td><%#Eval("ALTBASLIK")%></td>
                        <td><%#Eval("ACIKLAMA")%></td>
                        <td><%#Eval("TARIH") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%#"DeneyimSil.aspx?ID="+Eval("ID")%>'>Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%#"DeneyimGuncelle.aspx?ID="+Eval("ID")%>'>Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                    </tbody>
                </ItemTemplate>
            </asp:Repeater>
    </table>
        <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn btn-primary" NavigateUrl="~/DeneyimEkle.aspx">Yeni Ekle</asp:HyperLink>
        </form>
</asp:Content>
