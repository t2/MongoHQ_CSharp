<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MongoHQ_CSharp.Models.DeveloperModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Developers
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Developers</h2>

<ul>
    <% foreach(var developer in Model.developers) { %>
        <li>
            <%= developer.name %> (<%= developer.company %>)
            <ul>
                <% foreach (var language in developer.languages) { %>
                    <li><%= language %></li>
                <% } %>
            </ul>
        </li>
    <% } %>
</ul>

</asp:Content>
