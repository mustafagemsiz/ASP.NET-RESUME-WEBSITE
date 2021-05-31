<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekEkle.aspx.cs" Inherits="CvProject.YetenekEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <div class="container">
        <form id="Form1" runat="server">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Yetenek"></asp:Label>
                <asp:TextBox ID="TxtSkill" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="Save" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Save_Click"/>
        </form>
    </div>
</asp:Content>
