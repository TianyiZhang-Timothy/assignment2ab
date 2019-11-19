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
            // clear result
            student_result.InnerHtml = "";
            // what user input
            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = student_search.Text;
            }

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
                string studentlastname = row["STUDENTLNAME"];
                string studentfullname = studentfirstname + " " + studentlastname;
                string studentnumber = row["STUDENTNUMBER"];
                string enrolmentdate = row["ENROLMENTDATE"];

                student_result.InnerHtml += "<div class=\"col3\"><a href=\"ShowStudent.aspx?studentid=" + studentid + "\">" + studentfullname + "</a></div>";

                student_result.InnerHtml += "<div class=\"col3\">" + studentnumber + "</div>";

                student_result.InnerHtml += "<div class=\"col3last\">" + enrolmentdate + "</div>"+ "</div>";

            }
        }
    }
}