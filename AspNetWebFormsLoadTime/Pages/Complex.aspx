<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Complex.Master" AutoEventWireup="true" CodeBehind="Complex.aspx.cs" Inherits="AspNetWebFormsLoadTime.Pages.Complex" %>
<%@ Register Src="~/UserControls/FirstUserControl.ascx" TagName="FirstUserControl" TagPrefix="usercontrols" %>
<%@ Register Src="~/UserControls/SecondUserControl.ascx" TagName="SecondUserControl" TagPrefix="usercontrols" %>
<%@ Register Src="~/UserControls/LoadTimeUserControl.ascx" TagName="LoadTimeUserControl" TagPrefix="usercontrols" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Complex Load Time Example</h1>
    <usercontrols:FirstUserControl runat="server" ID="firstUserControl" />
    <usercontrols:SecondUserControl runat="server" ID="secondUserControl" />
    <usercontrols:LoadTimeUserControl runat="server" ID="loadTimeUserControl" />
</asp:Content>
