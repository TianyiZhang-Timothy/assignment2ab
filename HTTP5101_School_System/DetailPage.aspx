<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/site.Master" CodeBehind="DetailPage.aspx.cs" Inherits="HTTP5101_School_System.DetailPage" %>

<asp:Content ID="DetailPage" ContentPlaceHolderID="body" runat="server">
      <div id="student" runat="server">
        <h2>Details for <span id="title_fullname" runat="server" style="color: #f08e63"></span></h2><br />
        Full Name: <span id="student_fullname" runat="server"></span><br /><br />
        Student Number: <span id="student_number" runat="server"></span><br /><br />
        Enrolment Date: <span id="enrolment_date" runat="server"></span><br /><br />
    </div>
</asp:Content>