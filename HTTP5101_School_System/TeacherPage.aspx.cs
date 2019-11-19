using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class TeacherPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // clear result
            teacher_result.InnerHtml = "";
            // what user input
            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = teacher_search.Text;
            }

            // query
            string query = "select * from TEACHERS";

            if (searchkey != "")
            {
                query += " WHERE TEACHERFNAME like '%" + searchkey + "%' ";
                query += " or TEACHERLNAME like '%" + searchkey + "%' ";
                query += " or EMPLOYEENUMBER like '%" + searchkey + "%' ";
            }

            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                teacher_result.InnerHtml += "<div class=\"listitem\">";

                string teacherid = row["TEACHERID"];
                string teacherfirstname = row["TEACHERFNAME"];
                string teacherlastname = row["TEACHERLNAME"];
                string teacherfullname = teacherfirstname + " " + teacherlastname;
                string employeenumber = row["EMPLOYEENUMBER"];
                string hiredate = row["HIREDATE"];
                string salary = row["SALARY"];

                teacher_result.InnerHtml += "<div class=\"col4\">" + teacherid + "</div>";

                teacher_result.InnerHtml += "<div class=\"col4\"><a href=\"DetailPage.aspx?teacherid=" + employeenumber + "\">" + teacherfullname + "</a></div>";
                teacher_result.InnerHtml += "<div class=\"col4\">" + hiredate + "</div>";

                teacher_result.InnerHtml += "<div class=\"col4last\">" + salary + "</div>" + "</div>";

            }
        }
    }
}