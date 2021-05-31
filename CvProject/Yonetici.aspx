<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yonetici.aspx.cs" Inherits="CvProject.Sifre" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form id="Form1" runat="server">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
                <asp:TextBox ID="TxtUsername" runat="server" CssClass="form-control" MaxLength="24" placeholder="Yeni kullanıcı adını giriniz." ></asp:TextBox>
            </div>
            <asp:Button ID="BtnUsername" runat="server" Text="Kullanıcı Adı Güncelle" CssClass="btn btn-warning" OnClick="BtnUsername_Click" />
            <hr />
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label>
                <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" MaxLength="24" placeholder="Yeni şifrenizi giriniz."></asp:TextBox>
            </div>
            <asp:Button ID="Update" runat="server" Text="Şifre Güncelle" CssClass="btn btn-warning" OnClick="Update_Click" />
        </form>
    </div>
</asp:Content>
