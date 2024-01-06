<%@ Page Language="C#" Title="EBP - Informatique" AutoEventWireup="true" 
     MasterPageFile="~/Site.Master" 
    CodeBehind="Index.aspx.cs" Inherits="EBP_WebForms.Index" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>

    <div>

        <table>

            <tr>
                <td style="vertical-align:top;">Original text:</td>
                <td>
                     <asp:TextBox ID="txtOriginalText" TextMode="MultiLine" Wrap="true" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="vertical-align:top;">Destination text:</td>
                <td> 
                    <asp:TextBox ID="txtDestinationText" TextMode="MultiLine" ReadOnly="true" Wrap="true" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Type:</td>
                <td>
                    <asp:DropDownList runat="server" ID="DropDownList"></asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td colspan="2" style="text-align:center;">
                    <asp:Button ID="btnSubmit" runat="server" Text="Transform value" OnClick="btnSubmit_Click" />
                </td>

            </tr>

        </table>

    </div>

    <asp:Label runat="server" id="txtError"></asp:Label>

</asp:Content>

