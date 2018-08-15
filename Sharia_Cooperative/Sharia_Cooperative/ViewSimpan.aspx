<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSimpan.aspx.cs" Inherits="Sharia_Cooperative.ViewSimpan" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <!-- Remove This Before You Start -->
    <h2>Daftar Barang PT. Oke Oce</h2>
            <table class="table table-bordered">
                <thead>
                <tr>
                    <th>ID Simpan</th>
                    <th>Member ID</th>
                    <th>Member Name</th>
                    <th>Pembayaran Perbulan</th>>
                </tr>
                </thead>
                <tbody>
                    <asp:PlaceHolder ID="PlaceHolder_Data" runat="server"></asp:PlaceHolder>
                </tbody>
            </table>
</asp:Content>

