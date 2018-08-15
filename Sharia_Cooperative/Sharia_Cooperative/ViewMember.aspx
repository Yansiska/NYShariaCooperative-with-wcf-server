<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewMember.aspx.cs" Inherits="Sharia_Cooperative.View" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <!-- Remove This Before You Start -->
    <h2>Daftar Barang PT. Oke Oce</h2>
            <table class="table table-bordered">
                <thead>
                <tr>
                    <th>Member ID</th>
                    <th>Member Name</th>
                    <th>Address</th>
                    <th>Date Of Birth</th>
                    <th>Gender</th>
                    <th>Work</th>
                    <th>Monthly Income</th>
                    <th>Email</th>
                    <th>No Handphone</th>
                </tr>
                </thead>
                <tbody>
                    <asp:PlaceHolder ID="PlaceHolder_Data" runat="server"></asp:PlaceHolder>
                </tbody>
            </table>
</asp:Content>

