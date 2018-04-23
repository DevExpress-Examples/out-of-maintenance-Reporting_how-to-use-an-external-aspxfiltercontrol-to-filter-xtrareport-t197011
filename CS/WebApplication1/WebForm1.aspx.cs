using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                XtraReport1 report = new XtraReport1();
                Session["report"] = report;
            }
            ASPxDocumentViewer1.Report = Session["report"] as XtraReport;

        }
        protected void ASPxDocumentViewer1_Unload(object sender, EventArgs e)
        {
            (sender as ASPxDocumentViewer).Report = null;
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            ASPxDocumentViewer1.Report.FilterString = filter.FilterExpression;
            ASPxDocumentViewer1.Report.CreateDocument();        

        }
    }
}