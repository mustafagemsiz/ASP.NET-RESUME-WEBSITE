<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncelle.aspx.cs" Inherits="CvProject.YetenekGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <div class="container">
        <form id="Form1" runat="server">
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Yetenek No"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Yetenek"></asp:Label>
                <asp:TextBox ID="TxtSkill" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="Update" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Update_Click"/>
        </form>
    </div>
</asp:Content>
