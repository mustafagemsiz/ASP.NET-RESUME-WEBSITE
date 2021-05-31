<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HobiEkle.aspx.cs" Inherits="CvProject.HobiEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
            <div class="container">
        <form id="Form1" runat="server">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Hobi"></asp:Label>
                <asp:TextBox ID="TxtHobi" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="Save" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Save_Click"/>
        </form>
    </div>
</asp:Content>
