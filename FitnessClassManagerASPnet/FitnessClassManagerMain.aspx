<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FitnessClassManagerMain.aspx.cs" Inherits="FitnessClassManagerASPnet.FitnessClassManagerMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fitness Class Manager</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Welcome to the Fitness Class Manager Web's form</h2>
    <div>
    
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Class" />
    
    </div>
        <asp:ListBox ID="lstFitnessClasses" runat="server" Width="686px" DataValueField="lstBox"></asp:ListBox>
        <p>
        <asp:Label ID="lblAlert" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="brnSave" runat="server" OnClick="brnSave_Click" Text="Save" />
            <asp:Button ID="btnLoad" runat="server" OnClick="btnLoad_Click" Text="Load" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Location: "></asp:Label>
        <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
        <asp:Label ID="lblDay" runat="server" Text=" Day: "></asp:Label>
        <asp:DropDownList ID="cboDay" runat="server">
            <asp:ListItem>Monday</asp:ListItem>
            <asp:ListItem>Tuesday</asp:ListItem>
            <asp:ListItem>Wednesday</asp:ListItem>
            <asp:ListItem>Thursday</asp:ListItem>
            <asp:ListItem>Friday</asp:ListItem>
            <asp:ListItem>Saturday</asp:ListItem>
            <asp:ListItem>Sunday</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="btnRunReports" runat="server" OnClick="btnRunReports_Click" Text="RunReports" />
        </p>
    </form>
</body>
</html>
