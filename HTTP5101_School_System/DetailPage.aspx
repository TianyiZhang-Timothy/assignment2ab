<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowStudent.aspx.cs" Inherits="HTTP5101_School_System.ShowStudent" %>
<asp:Content ID="student_view" ContentPlaceHolderID="body" runat="server">

    <!-- 
        Note: this page is intentionally styled poorly.
        Work with your group members to understand how it works and improve it!
    -->
    <div id="detail" runat="server">
        <h2>Details for <span id="title_fullname" runat="server"></span></h2>
        Full Name: <span id="fullname" runat="server"></span><br />
        Student Number: <span id="student_number" runat="server"></span><br />
        Enrolment Date: <span id="enrolment_date" runat="server"></span><br />
    </div>
</asp:Content>
