<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CountUppercase.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My uppercase calculator</title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <%--HeadLine--%>
        <h1 id="HeadLine" runat="server" class="headline">Hur många versaler?</h1>
        
        <%--Textbox for user input and validationcontrols--%>
        <div>
            <asp:ValidationSummary ID="ValidationSummary" runat="server" CssClass="validation-summary-errors" />
            <asp:TextBox ID="UserInputTextBox" runat="server" TextMode="MultiLine" CssClass="userinputtextbox"></asp:TextBox>  
            <asp:RequiredFieldValidator ID="UserInputTextBoxValidator" runat="server" ErrorMessage="Text saknas." Display="Dynamic" ControlToValidate="UserInputTextBox" CssClass="field-validation-errors">*</asp:RequiredFieldValidator> 
        </div>
        
        <%--Message with number of uppercase letters--%>
        <div>
            <asp:Label ID="UpperCaseMessage" runat="server" Visible="False">
            Texten innehåller <asp:Literal ID="UpperCaseMessageLiteral" runat="server"></asp:Literal> versaler
        </asp:Label>
        
        <%--Buttons for submitting user input and clearing textbox--%>
        </div>
        <asp:Button ID="CalculateUpperCaseButton" runat="server" Text="Bestäm antalet versaler" OnClick="calculateUpperCaseButton_Click" />
        <asp:Button ID="ClearTextBoxButton" runat="server" Text="Rensa" Visible="False" OnClick="clearTextBoxButton_Click" CausesValidation="False" />
    </form>
</body>
</html>  

