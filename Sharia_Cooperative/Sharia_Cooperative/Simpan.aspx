<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Simpan.aspx.cs" Inherits="Sharia_Cooperative.Simpan" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <!-- Remove This Before You Start -->
    <h2>Member Cooperative</h2>
    <%--<hr />--%>
            <form id="Form1" method="post" runat="server">
                <div class="form-group">
                    <label for="ID Simpan">ID Simpan:</label>
                    <asp:TextBox ID="simpanID" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Member ID">Member ID:</label>
                    <asp:TextBox ID="memberId" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Member Name">Member Name:</label>
                    <asp:TextBox ID="memberN" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Pembayaran Perbulan">Pembayaran Perbulan:</label>
                    <asp:TextBox ID="bayarBln" CssClass="form-control" runat="server" style="margin-left: 24px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btn_save" CssClass="btn btn-md btn-primary" runat="server" Text="Save" OnClick="save"  />
                    <button type="reset" class="btn btn-md btn-danger">Cancel</button>
                </div>
            </form>
</asp:Content>

