<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Layout.Master" CodeBehind="StudentPage.aspx.cs" Inherits="HTTP5101_School_System.StudentPage" %>

<asp:Content ID="student_page" ContentPlaceHolderID="body" runat="server">
    <h1>Student</h1>
    <div id="student_search_div">
        <asp:label for="student_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="student_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" Text="submit" />
        <div id="show_sql" runat="server"></div>
    </div>
    <div class="info_table" runat="server">
        <div class="title">
            <div class="col3">STUDENT NUMBER</div>
            <div class="col3">FULL NAME</div>
            <div class="col3last">ENROLMENT DATE</div>
        </div>
        <div id="student_result" runat="server">

        </div>
    </div>

</asp:Content>