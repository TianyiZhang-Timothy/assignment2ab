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
            string query = "select * from CLASSES C JOIN TEACHERS T ON C.TEACHERID = T.TEACHERID";

            //if (searchkey != "")
            //{
            //    query += " WHERE CLASSNAME like '%" + searchkey + "%' ";
            //    query += " or CLASSCODE like '%" + searchkey + "%' ";
            //}

            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                class_result.InnerHtml += "<div class=\"listitem\">";

                string classid = row["CLASSES.CLASSID"];
                string classcode = row["CLASSES.CLASSCODE"];
                string teacherid = row["CLASSES.TEACHERID"];
                string teacherfname = row["TEACHERS.TEACHERFNAME"];

                string startdate = row["CLASSES.STARTDATE"];
                string finishdate = row["CLASSES.FINISHDATE"];
                string classname = row["CLASSES.CLASSNAME"];

                class_result.InnerHtml += "<div class=\"col4\"><a href=\"DetailPage.aspx?studentid=" + classcode + "\">" + classname + "</a></div>";

                class_result.InnerHtml += "<div class=\"col4\">" + teacherfname + "</div>";
                class_result.InnerHtml += "<div class=\"col4\">" + startdate + "</div>";

                class_result.InnerHtml += "<div class=\"col4last\">" + finishdate + "</div>" + "</div>";

            }
        }
    }
}