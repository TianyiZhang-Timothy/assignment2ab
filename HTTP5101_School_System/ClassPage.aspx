<%@ Page Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="ClassPage.aspx.cs" Inherits="HTTP5101_School_System.ClassPage" %>

<asp:Content ID="class_page" ContentPlaceHolderID="body" runat="server">
    <h1>Class</h1>
    <div id="class_search_div">
        <asp:Label for="class_search" runat="server">Search:</asp:Label>
        <asp:TextBox ID="class_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" Text="submit" />
    </div>
    <div id="class_delete_div">

    </div>
    <div class="info_table" runat="server">
        <div class="title">
            <div class="col4">CLASS CODE</div>
            <div class="col4">TEACHER NAME</div>
            <div class="col4">STARTDATE</div>
            <div class="col4last">FINISHDATE</div>
        </div>
        <div id="class_result" runat="server">
        </div>
    </div>

</asp:Content>
