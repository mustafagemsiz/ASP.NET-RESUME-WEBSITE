<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EgitimGuncelle.aspx.cs" Inherits="CvProject.EgitimGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form id="Form1" runat="server">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Eğitim No"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Başlık"></asp:Label>
                <asp:TextBox ID="TxtTitle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Altbaşlık"></asp:Label>
                <asp:TextBox ID="TxtSubtitle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Açıklama"></asp:Label>
                <asp:TextBox ID="TxtDescription" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Genel Not"></asp:Label>
                <asp:TextBox ID="TxtGnot" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Tarih"></asp:Label>
                <asp:TextBox ID="TxtDate" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="Update" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Update_Click" />
        </form>
    </div>
</asp:Content>
