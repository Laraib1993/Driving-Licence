  'use strict';
  $(document).ready(function() {

     
  

      // $('#date,#datejoin').bootstrapMaterialDatePicker({
      //        time: false,
      //        clearButton: true
      //    });
      //  $("#example-date-inputS").bootstrapMaterialDatePicker({
      //                time: false,
      //                clearButton: true
      //            });

      
      //Add rules for File upload control
      //$("#<%=FileUpload1.ClientID%>").rules('add', {
      //    required: true,
      //    accept: "image/jpeg,image/jpg",
      //    fileSize: true,
      //    messages: {
      //        accept: "Invalid file format"
      //    }
      //});
      //custom validation method for file size
      //$.validator.addMethod("fileSize", function (value, element) {
      //    files = element.files;
      //    size = files[0].size;
      //    if (size > 71680) {
      //        return false;
      //    }
      //    return true;
      //}, 'file should be upto 70 kb');
      //$(document).on("change", function () {
      //    $("#<%=form1.ClientID%>").valid();
      //});
      
   
      var form = $(".exampleadvancedform").show();

      form.steps({

          headerTag: "h3",
          bodyTag: "fieldset",
          transitionEffect: "slideLeft",
          onStepChanging: function (event, currentIndex, newIndex) {

              // Allways allow previous action even if the current form is not valid!
              if (currentIndex > newIndex) {
                  return true;
              }
              // Forbid next action on "Warning" step if the user is to young
              if (newIndex === 3 && Number($("#age-2").val()) < 18) {
                  return false;
              }
              // Needed in some cases if the user went back (clean up)
              if (currentIndex < newIndex) {
                  // To remove error styles
                  form.find(".body:eq(" + newIndex + ") label.error").remove();
                  form.find(".body:eq(" + newIndex + ") .error").removeClass("error");
              }
              form.validate().settings.ignore = ":disabled,:hidden";
              return form.valid();
          },
          onStepChanged: function (event, currentIndex, priorIndex) {

              // Used to skip the "Warning" step if the user is old enough.
              if (currentIndex === 2 && Number($("#age-2").val()) >= 18) {
                  form.steps("next");
              }
              // Used to skip the "Warning" step if the user is old enough and wants to the previous step.
              if (currentIndex === 2 && priorIndex === 3) {
                  form.steps("previous");
              }
          },
          onFinishing: function (event, currentIndex) {

              form.validate().settings.ignore = ":disabled";
              return form.valid();
          },
          onFinished: function (event, currentIndex) {

              


              var Companyname = $.trim($("[id*=txtpatnername]").val());
              var city = $.trim($("[id*=txtcity]").val());
              var email = $("[id*=txtemail]").val();
              var phone = $("[id*=txtphone]").val();
              var address = $.trim($("[id*=txtaddress]").val());
              var postalcode = $.trim($("[id*=txtpostalcode]").val());
              var contactpersonname = $.trim($("[id*=txtcontactpersonname]").val());
              var contactpersonalemail = $.trim($("[id*=txtcontactpersonemail]").val());
              var contactpersonphone = $("[id*=txtcontactpersonphone]").val();
              var website = $.trim($("[id*=txtwebsite]").val());
              var companysize = $.trim($("[id*=slctcompsize]").val());
              var companyrevenue = $.trim($("[id*=slctrevenue]").val());
              var selValue = $('input[name=radio]:checked').val();
              var patner = selValue;

              var fileUpload = $("#Upload").get(0);
              var files = fileUpload.files;
              var test = new FormData();
              for (var i = 0; i < files.length; i++) {
                  test.append(files[i].name, files[i]);
              }
              test.append("Companyname", JSON.stringify(Companyname));
              test.append("city", JSON.stringify(city));
              test.append("email", JSON.stringify(email));
              test.append("phone", JSON.stringify(phone));
              test.append("address", JSON.stringify(address));
              test.append("postalcode", JSON.stringify(postalcode));
              test.append("contactpersonname", JSON.stringify(contactpersonname));
              test.append("contactpersonalemail", JSON.stringify(contactpersonalemail));
              test.append("contactpersonphone", JSON.stringify(contactpersonphone));
              test.append("website", JSON.stringify(website));
              test.append("companysize", JSON.stringify(companysize));
              test.append("companyrevenue", JSON.stringify(companyrevenue));
              test.append("patner", JSON.stringify(patner));

                  $.ajax({
                      url: "UploadHandler.ashx",
                      type: "POST",
                      contentType: false,
                      processData: false,
                      data: test,
                      dataType: "json",
                      success: function (result) {
                          alert(result);
                          //$('.content input[type="text"]').val('');
                          //$('.content input[type="email"]').val('');
                      },
                      error: function (err) {
                          alert(err.statusText);
                          //    { alert('there is some error'); }
                      }
                  });

              //    success: function () {

              //        alert("Record Has been Saved in Database");
              //    },
              //    error: function ()
              //    { alert('there is some error'); }
              //});
              //alert("Submitted!");
              

          }
      });

      

      $(".basic-forms").steps({
          headerTag: "h3",
          bodyTag: "fieldset",
          transitionEffect: "slideLeft",
          onFinished: function (event, currentIndex) {




              var Companyname = $.trim($("[id*=txtpatnername]").val());
              var city = $.trim($("[id*=txtcity]").val());
              var email = $("[id*=txtemail]").val();
              var phone = $("[id*=txtphone]").val();
              var address = $.trim($("[id*=txtaddress]").val());
              var postalcode = $.trim($("[id*=txtpostalcode]").val());
              var contactpersonname = $.trim($("[id*=txtcontactpersonname]").val());
              var contactpersonalemail = $.trim($("[id*=txtcontactpersonemail]").val());
              var contactpersonphone = $("[id*=txtcontactpersonphone]").val();
              var website = $.trim($("[id*=txtwebsite]").val());
              var companysize = $.trim($("[id*=slctcompsize]").val());
              var companyrevenue = $.trim($("[id*=slctrevenue]").val());
              var selValue = $('input[name=radio]:checked').val();
              var patner = selValue;

              var fileUpload = $("#Upload").get(0);
              var files = fileUpload.files;
              var test = new FormData();
              for (var i = 0; i < files.length; i++) {
                  test.append(files[i].name, files[i]);
              }
              test.append("Companyname", JSON.stringify(Companyname));
              test.append("city", JSON.stringify(city));
              test.append("email", JSON.stringify(email));
              test.append("phone", JSON.stringify(phone));
              test.append("address", JSON.stringify(address));
              test.append("postalcode", JSON.stringify(postalcode));
              test.append("contactpersonname", JSON.stringify(contactpersonname));
              test.append("contactpersonalemail", JSON.stringify(contactpersonalemail));
              test.append("contactpersonphone", JSON.stringify(contactpersonphone));
              test.append("website", JSON.stringify(website));
              test.append("companysize", JSON.stringify(companysize));
              test.append("companyrevenue", JSON.stringify(companyrevenue));
              test.append("patner", JSON.stringify(patner));

              $.ajax({
                  url: "AddVendorHandler.ashx",
                  type: "POST",
                  contentType: false,
                  processData: false,
                  data: test,
                  dataType: "json",
                  success: function (result) {
                      alert(result);
                      //$('.content input[type="text"]').val('');
                      //$('.content input[type="email"]').val('');
                  },
                  error: function (err) {
                      alert(err.statusText);
                      //    { alert('there is some error'); }
                  }
              });

              //    success: function () {

              //        alert("Record Has been Saved in Database");
              //    },
              //    error: function ()
              //    { alert('there is some error'); }
              //});
              //alert("Submitted!");


          }







      });



      $(".distributer-forms").steps({
          headerTag: "h3",
          bodyTag: "fieldset",
          transitionEffect: "slideLeft",
          onFinished: function (event, currentIndex) {




              var Companyname = $.trim($("[id*=txtpatnername]").val());
              var city = $.trim($("[id*=txtcity]").val());
              var email = $("[id*=txtemail]").val();
              var phone = $("[id*=txtphone]").val();
              var address = $.trim($("[id*=txtaddress]").val());
              var postalcode = $.trim($("[id*=txtpostalcode]").val());
              var contactpersonname = $.trim($("[id*=txtcontactpersonname]").val());
              var contactpersonalemail = $.trim($("[id*=txtcontactpersonemail]").val());
              var contactpersonphone = $("[id*=txtcontactpersonphone]").val();
              var website = $.trim($("[id*=txtwebsite]").val());
              var companysize = $.trim($("[id*=slctcompsize]").val());
              var companyrevenue = $.trim($("[id*=slctrevenue]").val());
              var selValue = $('input[name=radio]:checked').val();
              var patner = selValue;

              var fileUpload = $("#Upload").get(0);
              var files = fileUpload.files;
              var test = new FormData();
              for (var i = 0; i < files.length; i++) {
                  test.append(files[i].name, files[i]);
              }
              test.append("Companyname", JSON.stringify(Companyname));
              test.append("city", JSON.stringify(city));
              test.append("email", JSON.stringify(email));
              test.append("phone", JSON.stringify(phone));
              test.append("address", JSON.stringify(address));
              test.append("postalcode", JSON.stringify(postalcode));
              test.append("contactpersonname", JSON.stringify(contactpersonname));
              test.append("contactpersonalemail", JSON.stringify(contactpersonalemail));
              test.append("contactpersonphone", JSON.stringify(contactpersonphone));
              test.append("website", JSON.stringify(website));
              test.append("companysize", JSON.stringify(companysize));
              test.append("companyrevenue", JSON.stringify(companyrevenue));
              test.append("patner", JSON.stringify(patner));

              $.ajax({
                  url: "AddDistributerHandler.ashx",
                  type: "POST",
                  contentType: false,
                  processData: false,
                  data: test,
                  dataType: "json",
                  success: function (result) {
                      alert(result);
                      //$('.content input[type="text"]').val('');
                      //$('.content input[type="email"]').val('');
                  },
                  error: function (err) {
                      alert(err.statusText);
                      //    { alert('there is some error'); }
                  }
              });

              //    success: function () {

              //        alert("Record Has been Saved in Database");
              //    },
              //    error: function ()
              //    { alert('there is some error'); }
              //});
              //alert("Submitted!");


          }







      });

    
      $(".reseller-forms").steps({
          headerTag: "h3",
          bodyTag: "fieldset",
          transitionEffect: "slideLeft",
          onFinished: function (event, currentIndex) {




              var Companyname = $.trim($("[id*=txtpatnername]").val());
              var city = $.trim($("[id*=txtcity]").val());
              var email = $("[id*=txtemail]").val();
              var phone = $("[id*=txtphone]").val();
              var address = $.trim($("[id*=txtaddress]").val());
              var postalcode = $.trim($("[id*=txtpostalcode]").val());
              var contactpersonname = $.trim($("[id*=txtcontactpersonname]").val());
              var contactpersonalemail = $.trim($("[id*=txtcontactpersonemail]").val());
              var contactpersonphone = $("[id*=txtcontactpersonphone]").val();
              var website = $.trim($("[id*=txtwebsite]").val());
              var companysize = $.trim($("[id*=slctcompsize]").val());
              var companyrevenue = $.trim($("[id*=slctrevenue]").val());
              var selValue = $('input[name=radio]:checked').val();
              var patner = selValue;

              var fileUpload = $("#Upload").get(0);
              var files = fileUpload.files;
              var test = new FormData();
              for (var i = 0; i < files.length; i++) {
                  test.append(files[i].name, files[i]);
              }
              test.append("Companyname", JSON.stringify(Companyname));
              test.append("city", JSON.stringify(city));
              test.append("email", JSON.stringify(email));
              test.append("phone", JSON.stringify(phone));
              test.append("address", JSON.stringify(address));
              test.append("postalcode", JSON.stringify(postalcode));
              test.append("contactpersonname", JSON.stringify(contactpersonname));
              test.append("contactpersonalemail", JSON.stringify(contactpersonalemail));
              test.append("contactpersonphone", JSON.stringify(contactpersonphone));
              test.append("website", JSON.stringify(website));
              test.append("companysize", JSON.stringify(companysize));
              test.append("companyrevenue", JSON.stringify(companyrevenue));
              test.append("patner", JSON.stringify(patner));

              $.ajax({
                  url: "AddDistributerHandler.ashx",
                  type: "POST",
                  contentType: false,
                  processData: false,
                  data: test,
                  dataType: "json",
                  success: function (result) {
                      alert(result);
                      //$('.content input[type="text"]').val('');
                      //$('.content input[type="email"]').val('');
                  },
                  error: function (err) {
                      alert(err.statusText);
                      //    { alert('there is some error'); }
                  }
              });

              //    success: function () {

              //        alert("Record Has been Saved in Database");
              //    },
              //    error: function ()
              //    { alert('there is some error'); }
              //});
              //alert("Submitted!");


          }

      });



      $(".UpdatePatnerforms").steps({


          headerTag: "h3",
          bodyTag: "fieldset",
          transitionEffect: "slideLeft",
          onFinished: function (event, currentIndex) {



              var slctpatner = $.trim($("[id*=ddlpatnertobeedit]").val());
              var Companyname = $.trim($("[id*=txtname]").val());
              var city = $.trim($("[id*=slctcity]").val());
              var email = $("[id*=txtemail]").val();
              var phone = $("[id*=txtphone]").val();
              var address = $.trim($("[id*=txtaddress]").val());
              var postalcode = $.trim($("[id*=txtpostalcode]").val());
              var contactpersonname = $.trim($("[id*=txtcontactpersonname]").val());
              var contactpersonalemail = $.trim($("[id*=txtcontactpersonemail]").val());
              var contactpersonphone = $("[id*=txtcontactpersonphone]").val();
              var website = $.trim($("[id*=txtwebsite]").val());
              var companysize = $.trim($("[id*=slctcompsize]").val());
              var companyrevenue = $.trim($("[id*=slctrevenue]").val());
              var selValue = $('input[name=radio]:checked').val();
              var patner = selValue;

              var fileUpload = $("#Upload").get(0);
              var files = fileUpload.files;
              var test = new FormData();
              for (var i = 0; i < files.length; i++) {
                  test.append(files[i].name, files[i]);
              }
              test.append("slctpatner", JSON.stringify(slctpatner))
              test.append("Companyname", JSON.stringify(Companyname));
              test.append("city", JSON.stringify(city));
              test.append("email", JSON.stringify(email));
              test.append("phone", JSON.stringify(phone));
              test.append("address", JSON.stringify(address));
              test.append("postalcode", JSON.stringify(postalcode));
              test.append("contactpersonname", JSON.stringify(contactpersonname));
              test.append("contactpersonalemail", JSON.stringify(contactpersonalemail));
              test.append("contactpersonphone", JSON.stringify(contactpersonphone));
              test.append("website", JSON.stringify(website));
              test.append("companysize", JSON.stringify(companysize));
              test.append("companyrevenue", JSON.stringify(companyrevenue));
              test.append("patner", JSON.stringify(patner));

              $.ajax({
                  url: "UpdatePatner.ashx",
                  type: "POST",
                  contentType: false,
                  processData: false,
                  data: test,
                  dataType: "json",
                  success: function (result) {
                      alert(result);
                      //$('.content input[type="text"]').val('');
                      //$('.content input[type="email"]').val('');
                  },
                  error: function (err) {
                      alert(err.statusText);
                      //    { alert('there is some error'); }
                  }
              });

              //    success: function () {

              //        alert("Record Has been Saved in Database");
              //    },
              //    error: function ()
              //    { alert('there is some error'); }
              //});
              //alert("Submitted!");


          }

      });

  });
