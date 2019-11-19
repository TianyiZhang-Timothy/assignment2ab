using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ClassPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // clear result
            class_result.InnerHtml = "";
            // what user input
            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = class_search.Text;
            }

            // query
            string query = "select * from CLASSES";

            if (searchkey != "")
            {
                query += " WHERE CLASSNAME like '%" + searchkey + "%' ";
                query += " or CLASSCODE like '%" + searchkey + "%' ";
            }

            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                class_result.InnerHtml += "<div class=\"listitem\">";

                string classid = row["TEACHERID"];
                string classcode = row["CLASSCODE"];
                string teacherid = row["TEACHERID"];

                string teacherfname = "";

                List<Dictionary<String, String>> ts = db.List_Query("select TEACHERFNAME from TEACHER where TEACHERID = " + teacherid);
                foreach(Dictionary<String,String>teacher in ts)
                {
                    teacherfname = teacher["TEACHERFNAME"];
                }

                    teacherfname = "can't get teacher name";

                string startdate = row["STARTDATE"];
                string finishdate = row["FINISHDATE"];
                string classname = row["CLASSNAME"];

                class_result.InnerHtml += "<div class=\"col4\"><a href=\"DetailPage.aspx?studentid=" + classcode + "\">" + classname + "</a></div>";

                class_result.InnerHtml += "<div class=\"col4\">" + teacherfname + "</div>";
                class_result.InnerHtml += "<div class=\"col4\">" + startdate + "</div>";

                class_result.InnerHtml += "<div class=\"col4last\">" + finishdate + "</div>" + "</div>";

            }
        }
    }
}