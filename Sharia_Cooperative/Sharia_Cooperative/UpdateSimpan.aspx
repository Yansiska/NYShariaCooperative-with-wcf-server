<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateSimpan.aspx.cs" Inherits="Sharia_Cooperative.UpdateSimpan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Remove This Before You Start -->
 <h2>Edit Barang PT. Oke Oce</h2>
 <hr />
 <form id="Form1" method="post" runat="server">
 <div class="form-group">
 <label for="ID_Simpan">ID Simpan:</label>
 <asp:TextBox ID="ID_Simpan" CssClass="form-control" runat="server"
Visible="False"></asp:TextBox>
 <!--<asp:TextBox type="text" ID="deskripsi" CssClass="form-control"
runat="server" TextMode="MultiLine"></asp:TextBox>-->
 </div>
<div class="form-group">
 <label for="Member_ID">Member ID:</label>
 <asp:TextBox ID="TextBox1" CssClass="form-control"
runat="server"></asp:TextBox>
 <!--<asp:TextBox type="text" ID="nama" CssClass="form-control"
runat="server"></asp:TextBox>-->
 </div>
 <div class="form-group">
 <label for="Member_Name">Member Name:</label>
 <asp:TextBox ID="TextBox2" CssClass="form-control"
runat="server"></asp:TextBox>
 <!--<asp:TextBox type="text" ID="deskripsi" CssClass="form-control"
runat="server" TextMode="MultiLine"></asp:TextBox>-->
 </div>
 <div class="form-group">
 <label for="Pembayaran_Perbulan">Pembayaran Perbulan:</label>
 <asp:TextBox ID="TextBox3" CssClass="form-control"
runat="server"></asp:TextBox>
 <!--<asp:TextBox type="text" ID="harga" CssClass="form-control"
runat="server"></asp:TextBox>-->
 </div>
 <div class="form-group">
 <asp:Button ID="btn_save" CssClass="btn btn-md btn-primary"
OnClick="update" runat="server" Text="Update" />
 <button type="reset" class="btn btn-md btn-danger">Cancel</button>
 </div>
 </form>
</asp:Content>