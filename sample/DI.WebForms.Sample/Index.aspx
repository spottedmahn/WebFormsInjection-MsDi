<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" CodeBehind="Index.aspx.cs" Inherits="Microsoft.Extensions.DependencyInjection.WebForms.Sample.Index" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>
<%@ Register Src="~/WebUserControl2.ascx" TagPrefix="uc1" TagName="WebUserControl2" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Hi from Index</h1>
    <div><%=Dependency.GetFormattedTime() %></div>
    <div>Dependency #<%=Dependency.Id %></div>
    <uc1:WebUserControl1 runat="server" id="WebUserControl1" OnTestEventHandler="MyTestEventHandler" />
    <uc1:WebUserControl2 runat="server" id="WebUserControl2" OnTestEvent2="MyTestEventHandler2" />
</asp:Content>

