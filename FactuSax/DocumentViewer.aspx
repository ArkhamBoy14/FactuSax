<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DocumentViewer.aspx.vb" Inherits="FactuSax.DocumentViewer" %>

<%@ Register assembly="DevExpress.XtraReports.v21.2.Web.WebForms, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server">
        </dx:ASPxWebDocumentViewer>
        <div>
        </div>
    </form>
</body>
</html>
