<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberCooperative.aspx.cs" Inherits="Sharia_Cooperative.MemberCooperative" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <!-- Remove This Before You Start -->
    <h2>Member Cooperative</h2>
    <%--<hr />--%>
            <form id="Form1" method="post" runat="server">
                <div class="form-group">
                    <label for="Member ID">Member ID:</label>
                    <asp:TextBox ID="memberID" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Member_Name">Member_Name:</label>
                    <asp:TextBox ID="memberName" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Address">Address:</label>
                    <asp:TextBox ID="Address" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Date_Of_Birth">Date_Of_Birth:</label>
                    <asp:TextBox ID="Dateof" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Gender">Gender:</label>
                    <asp:TextBox ID="Gender" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Work">Work:</label>
                    <asp:TextBox ID="Work" CssClass="form-control" runat="server" style="margin-left: 24px" Width="121px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Monthly_Income">Monthly_Income:</label>
                    <asp:TextBox ID="gaji" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Email">Email:</label>
                    <asp:TextBox ID="Email" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="No_HP">No_HP:</label>
                    <asp:TextBox ID="Nohp" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btn_save" CssClass="btn btn-md btn-primary" runat="server" Text="save" OnClick="save"  />
                    <button type="reset" class="btn btn-md btn-danger">Cancel</button>
                </div>
            </form>
</asp:Content>
