<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simple.aspx.cs" Inherits="AspNetWebFormsLoadTime.Simple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Simple Load Time Example</h1>
        <div>
            Load Time: <asp:Literal runat="server" ID="loadTimeLiteral"></asp:Literal> seconds
        </div>
    </form>
</body>
</html>
