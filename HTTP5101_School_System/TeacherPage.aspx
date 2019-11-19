<%@ Page Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="TeacherPage.aspx.cs" Inherits="HTTP5101_School_System.TeacherPage" %>

<asp:Content ID="teacher_page" ContentPlaceHolderID="body" runat="server">
    <h1>Teacher</h1>
    <div id="teacher_search_div">
        <asp:Label for="teacher_search" runat="server">Search:</asp:Label>
        <asp:TextBox ID="teacher_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" Text="submit" />
    </div>
    <div id="teacher_delete_div">

    </div>
    <div class="info_table" runat="server">
        <div class="title">
            <div class="col4">STUDENT NUMBER</div>
            <div class="col4">FULL NAME</div>
            <div class="col4">FULL NAME</div>
            <div class="col4last">ENROLMENT DATE</div>
        </div>
        <div id="student_result" runat="server">
        </div>
    </div>

</asp:Content>
