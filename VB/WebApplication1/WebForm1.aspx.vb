Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace WebApplication1
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then
                Dim report As New XtraReport1()
                Session("report") = report
            End If
            ASPxDocumentViewer1.Report = TryCast(Session("report"), XtraReport)

        End Sub
        Protected Sub ASPxDocumentViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
            TryCast(sender, ASPxDocumentViewer).Report = Nothing
        End Sub

        Protected Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs)
            ASPxDocumentViewer1.Report.FilterString = filter.FilterExpression
            ASPxDocumentViewer1.Report.CreateDocument()

        End Sub
    End Class
End Namespace