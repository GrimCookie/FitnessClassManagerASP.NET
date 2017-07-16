<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFitnessClassForm.aspx.cs" Inherits="FitnessClassManagerASPnet.AddFitnessClassForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 831px; height: 785px">
        <div style="width: 389px; height: 629px">
        <asp:Label ID="Label1" runat="server" Text="ID: "></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    
    <p>
        <asp:Label ID="Label2" runat="server" Text="Description: "></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
    </p>
   
        <p>
            <asp:Label ID="Label3" runat="server" Text="Location: "></asp:Label>
            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="Spaces: "></asp:Label>
        <asp:TextBox ID="txtSpaces" runat="server">1</asp:TextBox>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Day: "></asp:Label>
            <asp:DropDownList ID="cboDay" runat="server">
                <asp:ListItem>Monday</asp:ListItem>
                <asp:ListItem>Tuesday</asp:ListItem>
                <asp:ListItem>Wednesday</asp:ListItem>
                <asp:ListItem>Thursday</asp:ListItem>
                <asp:ListItem>Friday</asp:ListItem>
                <asp:ListItem>Saturday</asp:ListItem>
                <asp:ListItem>Sunday</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Label ID="Label6" runat="server" Text="Time: "></asp:Label>
        <asp:TextBox ID="txtTime" runat="server">09:00</asp:TextBox>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Duration: "></asp:Label>
            <asp:TextBox ID="txtDuration" runat="server">0</asp:TextBox>
        </p>
        <asp:Label ID="Label8" runat="server" Text="Number sessions: "></asp:Label>
        <asp:TextBox ID="txtNumSessions" runat="server" Enabled="False">N/A</asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkMultiWeek" runat="server" OnCheckedChanged="chkMultiWeek_CheckedChanged" Text="Multi-week" AutoPostBack="True" />
        <p>
            <asp:Label ID="Label9" runat="server" Text="Start Date: "></asp:Label>
            <asp:Calendar ID="calStartDate" runat="server" OnSelectionChanged="calStartDate_SelectionChanged"></asp:Calendar>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="ok" Width="81px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="86px" OnClick="btnCancel_Click" />
                                
                </div>

                <div style="height: 146px; width: 372px">
                   
                <p> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Please enter an ID No" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator> </p>
                <p> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDescription" ErrorMessage="Please enter a Description" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator> </p>
                <p> <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtLocation" ErrorMessage="Please enter a location" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator> </p>
                <p> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSpaces" ErrorMessage="Please enter  the Number of spaces" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator> </p>
                <p> <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtTime" ErrorMessage="Please type in a time" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator> </p>
                <p> <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtTime" ValidationExpression="^(20|21|22|23|[01]\d|\d)(([:][0-5]\d){1,2})$" ErrorMessage="Please enter the correct format for time 09:00 or 20:00" Font-Bold="True" ForeColor="#CC0000"></asp:RegularExpressionValidator> </p>
                <p> <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDuration" ErrorMessage="please set the duration" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator> </p>
                </div>

            </div>
    </form>
</body>
</html>
