using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DLL;
namespace Web
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json; charset=utf-8";

            string input = Request.Form["input"];
            if (string.IsNullOrEmpty(input))
            {
                Response.Write("{\"error\":\"Thiếu dữ liệu\"}");
                return;
            }
            Class1 calc = new Class1();
            calc.Input = input;
            string report = calc.Caculate();

            // Escape chuỗi JSON (replace \ and ")
            report = report.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "").Replace("\n", "\\n");

            string json = "{\"report\":\"" + report + "\"}";
            Response.Write(json);
        }
    }
}
