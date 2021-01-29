<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AptifyRefreshCache.aspx.cs" Inherits="Aptify.Services.Framework.forms.AptifyRefreshCache" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            width: 239px;
        }
    </style>

    <script type="text/javascript">

        function Reset()
        {
            localStorage.clear();
            //document.writeln("Local Storage Cleared.");
           
        }

    </script>
</head>
<body>
    <p> &nbsp;</p>
    <form id="form1" runat="server" >
    <div>
 <p  style="height: 58px; width: 265px; ">
        <asp:Button ID="Button2" runat="server"  Text="Clear Cache" OnClientClick="Reset();" OnClick="Button2_Click"  /> </p>
       
        <p style="height: 429px; width: 827px"> <asp:TextBox ID="TxtResult" runat="server" Height="404px" Width="764px" TextMode="MultiLine" ></asp:TextBox>
        </p>
       
    
    </div>
    </form>
    
   
</body>
</html>
