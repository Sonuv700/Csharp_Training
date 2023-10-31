<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solution.aspx.cs" Inherits="Assignment_1.Solution" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Store</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Car Store</h1>
            <asp:DropDownList ID="ddlCars" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCars_SelectedIndexChanged">
   <asp:ListItem Text="Select a Car" Value="" />
                <asp:ListItem Text="Sedan" Value="sedan" />
                <asp:ListItem Text="SUV" Value="suv" />
                <asp:ListItem Text="Sports Car" Value="sports" />
            </asp:DropDownList>
</asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="imgCar" runat="server" Width="300" Height="200" />
            <br />
            <asp:Button ID="btnShowCost" runat="server" Text="Show Cost" OnClick="btnShowCost_Click" />
            <br />
            <br />
            <asp:Label ID="lblCost" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>