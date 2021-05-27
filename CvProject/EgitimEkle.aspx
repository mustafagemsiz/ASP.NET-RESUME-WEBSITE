<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EgitimEkle.aspx.cs" Inherits="CvProject.EğitimEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form id="Form1" runat="server">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label>
                <asp:TextBox ID="TxtTitle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Altbaşlık"></asp:Label>
                <asp:TextBox ID="TxtSubtitle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Açıklama"></asp:Label>
                <asp:TextBox ID="TxtDescription" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Genel Not"></asp:Label>
                <asp:TextBox ID="TxtGnot" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Tarih"></asp:Label>
                <asp:TextBox ID="TxtDate" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="Save" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Save_Click" />
        </form>
    </div>
</asp:Content>
