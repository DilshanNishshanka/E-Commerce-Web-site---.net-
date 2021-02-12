<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
       <div style="font-size:x-large" align="center">Studen Info Manage Form</div>
       <br />
       <table class="nav-justified">
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">Student ID</td>
               <td>
                   <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="171px"></asp:TextBox>
                   <asp:Button ID="Button5" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button5_Click" Text="Get" />
               </td>
           </tr>
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">Student Name</td>
               <td>
                   <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Width="171px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">Address</td>
               <td>
                   <asp:DropDownList ID="DropDownList1" runat="server">
                       <asp:ListItem>USA</asp:ListItem>
                       <asp:ListItem>Canada</asp:ListItem>
                       <asp:ListItem>UK</asp:ListItem>
                   </asp:DropDownList>
               </td>
           </tr>
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">Age</td>
               <td>
                   <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Width="171px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td style="width: 217px; height: 24px"></td>
               <td style="width: 179px; height: 24px">Contact</td>
               <td style="height: 24px">
                   <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium" Width="171px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">&nbsp;</td>
               <td>
                   <asp:Button ID="Button1" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button1_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="Button2" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button2_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="Button3" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button3_Click" OnClientClick="return confirm('are you sure to delete?');" Text="Delete" />
&nbsp;&nbsp;
                   <asp:Button ID="Button4" runat="server" BackColor="#9900CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button4_Click" Text="Search" />
               </td>
           </tr>
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">&nbsp;</td>
               <td>
                   <asp:GridView ID="GridView1" runat="server" Width="447px">
                   </asp:GridView>
               </td>
           </tr>
           <tr>
               <td style="width: 217px">&nbsp;</td>
               <td style="width: 179px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
       </table>
   </div>
    
</asp:Content>
