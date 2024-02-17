<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="practice_database_add_show.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <label for="Roll">Roll</label>
        <asp:TextBox ID="Roll_textbox" runat="server" class="form_Control"></asp:TextBox>

        <label for="Name"> Name</label>
        <asp:TextBox ID="Name_textbox" runat="server" class="form_Control"></asp:TextBox>

        <label for="Email"> Email</label>
        <asp:TextBox ID="Email_textbox" class="form_Control" runat="server"></asp:TextBox>

        <label for="Message"> Message</label>
        <asp:TextBox ID="Message_textbox" class="form_Control" runat="server"></asp:TextBox>
        <asp:Button ID="Submit_button" CssClass="form_Control" runat="server" Text="submit" OnClick="Submit_Click"/>

    </div>
</asp:Content>
