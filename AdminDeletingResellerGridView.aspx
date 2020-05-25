<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeletingResellerGridView.aspx.cs" Inherits="AdminDeletingResellerGridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="pcoded-content">
                        <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">Reseller List</h5>
                                            <p class="m-b-0">All Delete Reseller List</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="index.html"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminActivePatnerReport.aspx">Patner List</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminActivePatnerReport.aspx">Active</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Page-header end -->

                        <div class="pcoded-inner-content">
                            <div class="main-body">
                                <div class="page-wrapper">
                                    <div class="page-body">
                                        <!-- `New` Constructor table start -->
                                        <div class="card">
                                            <div class="card-header">
                                                <h5>Delete Reseller List</h5>
                                                <span>Responsive will automatically detect new DataTable instances being created on a page and initialize itself if it finds the responsive option or responsive class name on the table, as shown in the other examples.</span>
                                            </div>
                                            <div class="card-block">
                                                <div class="dt-responsive table-responsive">

                                                    <form id="form1" runat="server">
                                                    <div>
                                                        <asp:GridView ID="gvtblImages" runat="server" AutoGenerateColumns ="false" DataKeyNames="PID" CssClass="table table-striped table-bordered nowrap" ShowHeaderWhenEmpty="true"> 
                                                            <Columns>
                                                                <asp:BoundField DataField ="sno" HeaderText ="S No#" />
                                                                <asp:ImageField DataImageUrlField="Img" ControlStyle-Height="50px" ControlStyle-Width="80px" HeaderText ="logo" ></asp:ImageField>
                                                                <asp:BoundField DataField ="Name" HeaderText ="Reseller" />
                                                                <asp:BoundField DataField ="Address" HeaderText ="Address" />
                                                                <asp:BoundField DataField ="CompanySize" HeaderText ="Company Size" />
                                                                <asp:TemplateField>
                                                                    <ItemTemplate>
                                                                        <asp:LinkButton ID="LnkSelect" data-toggle="tooltip" runat="server" CssClass="txt-muted" data-placement="top" title="" data-original-title="Delete" OnClick="LnkSelect_Click" CommandArgument='<%# Eval("PID")%>'>
                                                                            <i class="icofont icofont-delete-alt"></i>
                                                                        </asp:LinkButton>
                                                                     
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                            </Columns>
                                                        </asp:GridView>
                                                        
                                                    </div>
                                                    </form>





                                                    <%--<table id="ajax-table2" class="table table-striped table-bordered nowrap">
                                                        <thead>
                                                            <tr>
                                                                <th>SNO</th>
                                                                <th>Logo</th>
                                                                <th>Patner</th>
                                                                <th>Email</th>
                                                                <th>Phone</th>
                                                                <th>Type</th>
                                                                <th>Contact Person</th>
                                                                <th>Contact Person Email</th>
                                                                <th>Contact Person Phone : </th>
                                                                <th>Annual Revenue : </th>
                                                                <th>Company Size : </th>
                                                                <th>Region : </th>
                                                                <th>Country : </th>
                                                                <th>City : </th>
                                                            </tr>
                                                        </thead>
                                                        <tfoot>
                                                             <tr>
                                                                <th>SNO</th>
                                                                <th>Logo</th>
                                                                <th>Patner</th>
                                                                <th>Email</th>
                                                                <th>Phone</th>
                                                                <th>Type</th>
                                                                <th>Contact Person</th>
                                                                <th>Contact Person Email</th>
                                                                <th>Contact Person Phone : </th>
                                                                <th>Annual Revenue : </th>
                                                                <th>Company Size : </th>
                                                                <th>Region : </th>
                                                                <th>Country : </th>
                                                                <th>City : </th>
                                                            </tr>
                                                        </tfoot>
                                                        <tbody>
                                                            
                                                         
                                                        </tbody>
                                                    </table>--%>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- `New` Constructor table end -->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Warning Section Starts -->
                    <div id="styleSelector">

                    </div>

</asp:Content>

