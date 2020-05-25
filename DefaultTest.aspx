<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="DefaultTest.aspx.cs" Inherits="DefaultTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">

           <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block">Logo</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <asp:FileUpload ID="flp" runat="server" />
                                                                                        
                                                                                            
                                                                                    </div>
                                                                                </div>
    <div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">
                                                                    <asp:Button ID="btnsubmit" class="btn btn-primary m-b-0" runat="server" Text="Submit" OnClick="Button1_Click" />
                                                                   
                                                                </div>
                                                            </div>


    </form>
    
</asp:Content>

