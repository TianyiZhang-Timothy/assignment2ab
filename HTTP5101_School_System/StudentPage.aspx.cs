using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class StudentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string searchkey = "";

            // query
            string query = "select * from STUDENTS";

            if (searchkey != "")
            {
                query += " WHERE STUDENTFNAME like '%" + searchkey + "%' ";
                query += " or STUDENTLNAME like '%" + searchkey + "%' ";
                query += " or STUDENTNUMBER like '%" + searchkey + "%' ";
            }

            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                student_result.InnerHtml += "<div class=\"listitem\">";

                string studentid = row["STUDENTID"];

                string studentfirstname = row["STUDENTFNAME"];
                student_result.InnerHtml += "<div class=\"col4\"><a href=\"ShowStudent.aspx?studentid=" + studentid + "\">" + studentfirstname + "</a></div>";

                string studentlastname = row["STUDENTLNAME"];
                student_result.InnerHtml += "<div class=\"col4\">" + studentlastname + "</div>";

                string studentnumber = row["STUDENTNUMBER"];
                student_result.InnerHtml += "<div class=\"col4\">" + studentnumber + "</div>";

                string enrolmentdate = row["ENROLMENTDATE"];
                student_result.InnerHtml += "<div class=\"col4last\">" + enrolmentdate + "</div>";

                student_result.InnerHtml += "</div>";
            }
        }
    }
}