<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SSRSReportViewer.aspx.cs" Inherits="Aptify.Services.Framework.forms.SSRSReportViewer" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server" AsyncPostBackTimeout="56000">
        </asp:ScriptManager>
        <input name="b_print" type="button" onclick="printDiv('rptSSRReportViewer_ctl09');" value=" Print Report" />
        <div align="center">
            <rsweb:ReportViewer ID="rptSSRReportViewer" runat="server" ShowPrintButton="true" Width="100%" SizeToReportContent="True"></rsweb:ReportViewer>
        </div>
    </form>
</body>
<script language="javascript" type="text/javascript" src="../Scripts/jquery-1.8.3.min.js"></script>
<%--<script>

    var div = document.getElementById('rptSSRReportViewer_ctl05');
    var divPrint = '<table title="Print" style = "width:40px;padding-left:30px;"><tr><td><input name="b_print"  type="button" onclick="printDiv("rptSSRReportViewer_ctl09");" value=" Print Report" /></td></tr></table>'
    div.innerHTML = div.innerHTML + divPrint;
</script>--%>

<%--<script language="javascript" type="text/javascript">

    function printdiv() {
        var headstr = "<html><head><title></title><style></style></head><body>";
        var footstr = "</body>";
        var newstr = $("#rptSSRReportViewer_ctl09").html()
        var popupWin = window.open('', '_blank');
        popupWin.document.write(headstr + newstr + footstr);
        popupWin.print();
        return false;
    }
</script>--%>
<style>
    @media print {
        .rptSSRReportViewer_ctl05 {
            display: none;
        }
        /*.divPrint {
       display: block;
    }*/
    }
</style>

<script language="javascript" type="text/javascript">
    
    function printDiv(divName) {
        
        var printContents = document.getElementById(divName).innerHTML;
        var originalContents = document.body.innerHTML;

        document.body.innerHTML = printContents;
        window.URL = 'about:blank';
        window.name = "Invoice";
        window.print();

        document.body.innerHTML = originalContents;
    }

    function CallPrint(strid) {
        var printContent = document.getElementById(strid);
        var windowUrl = 'about:blank';
        var uniqueName = new Date();
        var windowName = 'Print' + uniqueName.getTime();

        var printWindow = window.open(windowUrl, windowName, 'left=50000,top=50000,width=800,height=600');
        printWindow.document.body.innerHTML = printContent.innerHTML;
        printWindow.document.close();
        printWindow.focus();
        printWindow.print();
        printWindow.close();
        return false;
    }
</script>
</html>
