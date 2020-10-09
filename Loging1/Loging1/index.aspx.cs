using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loging1
{

    public partial class index : System.Web.UI.Page
    {
        private static string sExceptionLogFile = "Error.log";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWriteLog_Click(object sender, EventArgs e)
        {
            string  msg = string.Empty;
            string psMessage = "Error!";
            msg = udfWriteErrorLog(psMessage);

        }
        public static string udfWriteErrorLog(string psMessage)
        {
            string msg = string.Empty;
            try
            {             
                string sCurDateTime = DateTime.Now.ToString();
                string sExceptionLnToPrint = sCurDateTime + " | " + psMessage + Environment.NewLine;

                File.AppendAllText( "D:\\Users\\Eldho\\Practise\\TextFiles" + "\\" + sExceptionLogFile, sExceptionLnToPrint, System.Text.Encoding.Unicode);
            }
            catch(Exception ex)
            {
                 msg = ex.Message;
            }
            return msg;
        }
    }
}