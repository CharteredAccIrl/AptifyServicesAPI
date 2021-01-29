<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrystalReportView.aspx.cs" Inherits="Aptify.Services.Framework.forms.CrystalReportView" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server"> 
    <title></title>
</head>
<body >
    <form id="form1" runat="server" >
        <asp:ScriptManager ID="ScriptManager1" runat="server" AsyncPostBackTimeOut="56000" >
        </asp:ScriptManager>
    <div>
       <%-- <asp:ScriptManager ID="ScriptManager1" runat="server" AsyncPostBackTimeOut="56000" >--%>
              <CR:CrystalReportViewer ID="VnextWebAccessReport" HasCrystalLogo="False"    runat="server" HasRefreshButton="True" AutoDataBind="true" DisplayStatusbar="true"   ReuseParameterValuesOnRefresh="true" Height="700px" Width="100%"  />
      <%--        --%>
    </div>
    </form>
</body>
</html>

