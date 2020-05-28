using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Properties
{


    // Login Start
    public string LoginUsername { get; set; }
    public string LoginPassword { get; set; }
    // Login End


    // User Interface Start //
    public System.Web.UI.HtmlControls.HtmlGenericControl MyProperty { get; set; }

    public System.Web.UI.HtmlControls.HtmlGenericControl UI_VendorControl { get; set; }

    // User Interface End //





    // Insertion Area Start //


    //insert into city //
    public string AdminInsertcitycity { get; set; }
    public int AdminInsertcitycountry { get; set; }
    public int AdminInsertcitycreatedon { get; set; }

    //insert into country//
    public string AdminInsertcountrycountry { get; set; }
    public int AdminInsertcountrycreatedon { get; set; }

    //insert into delivered step//
    public DateTime AdminInsertdelivereddeliveredon { get; set; }
    public int AdminInsertdeliveredRider { get; set; }
    public int AdminInsertdeliveredshipment { get; set; }
    public int AdminInsertdeliveredcreatedby { get; set; }

    //update into district//
    public string AdminInsertdistrictdistrict { get; set; }
    public int AdminInserdistrictcity { get; set; }
    public int AdminInsertdistrictcreated { get; set; }

    //insert into ongoing step//
    public DateTime AdminInsertongoingassignedon { get; set; }
    public DateTime AdminInsertongoingestimatedtime { get; set; }
    public int AdminInsertongoingrider { get; set; }
    public int AdminInsertongoingcreatedby { get; set; }
    public int AdminInsertongoingshipment { get; set; }

    //update into return reason//
    public string AdminInsertreasonreason { get; set; }
    public DateTime AdminInsertreasoncreateon { get; set; }

    //insert into return step//
    public DateTime AdminInsertreturnerturnon { get; set; }
    public int AdminInsertreturnrider { get; set; }
    public int AdminInsertreturncreatedby { get; set; }
    public int AdminInsertreturnshipment { get; set; }
    public int AdminInsertreturnreason { get; set; }
    public string AdminInsertreturndisccription { get; set; }

    //update into rider//
    public string AdminInsertrider { get; set; }
    public string AdminInsertridercnic { get; set; }
    public string AdminInsertrideraddress { get; set; }
    public string AdminInsertriderphone { get; set; }
    public int AdminInsertridercreatedby { get; set; }

    //insert into shipment detail//
    public string AdminInsertshipmentid { get; set; }
    public string AdminInsertshipmentcnic { get; set; }
    public int AdminInsertshipmentdistrict { get; set; }
    public int AdminInsertshipmentcreatedby { get; set; }
    public int AdminInsertshipmentstatus { get; set; }
    public int AdminInsertshipmentrider { get; set; }


    //insert into user//
    public string AdminInsertuseremail { get; set; }
    public string AdminInsertuserpassword { get; set; }
    public string AdminInsertuserrole { get; set; }


    //insert into shipment entry//
    public DateTime AdminInsertentryreceivedon { get; set; }
    public string AdminInsertentryreceivedby { get; set; }
    public DateTime AdminInsertentryestimatedongoingdate { get; set; }
    public int AdminInsertentrycreatedby { get; set; }
    public int AdminInsertentryshipment { get; set; }
    public int AdminInsertentryrider { get; set; }

   

    //update into city//
    public string AdminUpdatecitycity { get; set; }
    public int AdminUpdatecityupdatedby { get; set; }
    public int AdminUpdatecityID { get; set; }


    //update into country//
    public string AdminUpdatecountrycountry { get; set; }
    public int AdminUpdatecountryupdatedby { get; set; }
    public int AdminUpdatecountryID { get; set; }


    //update into main for new id outward//
    public DateTime AdminUpdatedeliveredon { get; set; }
    public int AdminUpdatedeliveredrider { get; set; }
    public int AdminUpdatedeliveredshipment { get; set; }
    public int AdminUpdatedeliveredupdatedby { get; set; }
    public int AdminUpdatedeliveredid { get; set; }

    //update into district//
    public string AdminUpdatedistrictdistrict { get; set; }
    public int AdminUpdatedistrictupdatedby { get; set; }
    public int AdminUpdatedistrictcity { get; set; }
    public int AdminUpdateDistrictID { get; set; }

    //update ongoing step//
    public int AdminUpdateongoingassignedon { get; set; }
    public int AdminUpdateongoingestimatedon{ get; set; }
    public int AdminUpdateongoingrider { get; set; }
    public string AdminUpdateongoingupdateby { get; set; }
    public string AdminUpdateongoingshipment { get; set; }
    public string AdminUpdateongoingID { get; set; }

    //update into return reason//
    public string AdminUpdatereasonreason { get; set; }
    public int AdminUpdatereasonupdatedby { get; set; }
    public int AdminUpdatereasonID { get; set; }


    //update return step//
    public DateTime AdminUpdatereturndatetime { get; set; }
    public int AdminUpdatereturnrider { get; set; }
    public int AdminUpdatereturnreason { get; set; }
    public string AdminUpdatereturnupdateby { get; set; }
    public string AdminUpdatereturnshipment { get; set; }
    public string AdminUpdatereturnID { get; set; }
    public string AdminUpdatereturndescription { get; set; }



    //update rider//
    public string AdminUpdateriderrider { get; set; }
    public string AdminUpdateridercnic { get; set; }
    public string AdminUpdaterideraddress { get; set; }
    public string AdminUpdateriderphone { get; set; }
    public int AdminUpdateriderupdateby { get; set; }
    public int AdminUpdateriderID { get; set; }



    //update shipment detail//
    public string AdminUpdatshipmentshipmentID { get; set; }
    public string AdminUpdateshipmentcnicno { get; set; }
    public string AdminUpdateshipmentaddress { get; set; }
    public int AdminUpdateshipmentdistrict { get; set; }
    public int AdminUpdateshipmentupdate { get; set; }
    public string AdminUpdateshipmentrider { get; set; }
    public int AdminUpdateshipmentID { get; set; }


    //update shipment detail//
    public DateTime AdminUpdatentryreceivedon { get; set; }
    public int AdminUpdateentryreceivedby { get; set; }
    public string AdminUpdateentryestimatedon { get; set; }
    public int AdminUpdateentryshipment { get; set; }
    public int AdminUpdateentryupdate { get; set; }
    public string AdminUpdateentryrider { get; set; }
    public int AdminUpdateentryID { get; set; }


    //update user//
    public string AdminUpdatuseremail { get; set; }
    public int AdminUpdateuserpassword { get; set; }
    public string AdminUpdateuserrole { get; set; }
    public int AdminUpdateuserID { get; set; }

    // Dropdown //
    public int AdminFetchID { get; set; }
    



    // Insertion Area End //



    // <---------------------------------------------------> //



    // Updation Area Start //

    // Patner Form Start //

    // Patner Form  End //

    // Updation Area End //


    // <---------------------------------------------------> //


    

    // <---------------------------------------------------> //

    // Reseller Form Start //
    public string ResellerInsertProductFormProductName { get; set; }
    public string ResellerInsertProductFormDetail { get; set; }
    public string ResellerInsertProductFormModelNo { get; set; }
    public decimal ResellerInsertProductFormPrice { get; set; }
    public DateTime ResellerInsertProductFormLaunchDate { get; set; }
    public string ResellerInsertProductFormPic1name { get; set; }
    public string ResellerInsertProductFormPic1path { get; set; }
    public string ResellerInsertProductFormPic2name { get; set; }
    public string ResellerInsertProductFormPic2path { get; set; }
    public string ResellerInsertProductFormPic3name { get; set; }
    public string ResellerInsertProductFormPic3path { get; set; }
    public long ResellerInsertProductFormFK_Createdby { get; set; }
    public long ResellerInsertProductFormFK_ProductType { get; set; }
    public long ResellerInsertProductFormFK_Vendor { get; set; }
    public int ResellerInsertProductFormFK_Status { get; set; }
    public long ResellerInsertProductFormFK_Patner { get; set; }





    public string ResellerUpdateProductFormProductName { get; set; }
    public string ResellerUpdateProductFormDetail { get; set; }
    public string ResellerUpdateProductFormModelNo { get; set; }
    public long ResellerUpdateProductFormPrice { get; set; }
    public DateTime ResellerUpdateProductFormLaunchDate { get; set; }
    public string ResellerUpdateProductFormPic1name { get; set; }
    public string ResellerUpdateProductFormPic1path { get; set; }
    public string ResellerUpdateProductFormPic2name { get; set; }
    public string ResellerUpdateProductFormPic2path { get; set; }
    public string ResellerUpdateProductFormPic3name { get; set; }
    public string ResellerUpdateProductFormPic3path { get; set; }
    public string ResellerUpdateProductFormFK_Createdby { get; set; }
    public string ResellerUpdateProductFormFK_ProductType { get; set; }
    public string ResellerUpdateProductFormFK_Vendor { get; set; }
    public string ResellerUpdateProductFormFK_Status { get; set; }
    public string ResellerUpdateProductFormProductID { get; set; }

    // Reseller Form  End //



    //Distributer Form Start//

    public string DistributerInsertProductFormProductName { get; set; }
    public string DistributerInsertProductFormDetail { get; set; }
    public string DistributerInsertProductFormModelNo { get; set; }
    public double DistributerInsertProductFormPrice { get; set; }
    public DateTime DistributerInsertProductFormLaunchDate { get; set; }
    public string DistributerInsertProductFormPic1name { get; set; }
    public string DistributerInsertProductFormPic1path { get; set; }
    public string DistributerInsertProductFormPic2name { get; set; }
    public string DistributerInsertProductFormPic2path { get; set; }
    public string DistributerInsertProductFormPic3name { get; set; }
    public string DistributerInsertProductFormPic3path { get; set; }
    public int DistributerInsertProductFormFk_Createdby { get; set; }
    public int DistributerInsertProductFormFk_ProductType { get; set; }
    public int DistributerInsertProductFormFk_Vendor { get; set; }
    public int DistributerInsertProductFormFk_Status { get; set; }
    public long DistributerInsertProductFormFK_Patner { get; set; }



    public int DistributerUpdateProductFormPID { get; set; }
    public string DistributerUpdateProductFormProductName { get; set; }
    public string DistributerUpdateProductFormDetail { get; set; }
    public string DistributerUpdateProductFormModelNo { get; set; }
    public int DistributerUpdateProductFormPrice { get; set; }
    public DateTime DistributerUpdateProductFormLaunchDate { get; set; }
    public string DistributerUpdateProductFormPic1name { get; set; }
    public string DistributerUpdateProductFormPic1path { get; set; }
    public string DistributerUpdateProductFormPic2name { get; set; }
    public string DistributerUpdateProductFormPic2path { get; set; }
    public string DistributerUpdateProductFormPic3name { get; set; }
    public string DistributerUpdateProductFormPic3path { get; set; }
    public int DistributerUpdateProductFormFk_Createdby { get; set; }
    public int DistributerUpdateProductFormFk_ProductType { get; set; }
    public int DistributerUpdateProductFormFk_Vendor { get; set; }
    public int DistributerUpdateProductFormFk_Status { get; set; }


    //Distributer Form End//



    // <---------------------------------------------------> //










    public int AdminEditCityFetch { get; set; }


    public int AdminEditServiceFetch { get; set; }



    public int AdminEditProductTypeFetch { get; set; }



    public int AdminEditRegionForm { get; set; }


    public int AdminEditCountryForm { get; set; }


    public int AdminEditProductCategoryForm { get; set; }


    //UPDATE AREA START //
    public int AdminUpdateProductCategoryPCID { get; set; }
    public string AdminUpdateCategoryFormCategory { get; set; }
    public int AdminUpdateProductCategoryFK_Srevicetype { get; set; }
    public int AdminUpdateProductCategoryFK_Createdby { get; set; }
    public int AdminUpdateProductCategoryFK_Status { get; set; }
    public string AdminUpdateProductCategoryPic_Name { get; set; }
    public string AdminUpdateProductCategoryPic_Path { get; set; }




    public int AdminUpdateCityCID { get; set; }
    public string AdminUpdateCityCity { get; set; }
    public int AdminUpdateCityFK_Createdby { get; set; }
    public int AdminUpdateCityFK_Status { get; set; }
    public int AdminUpdateCityFK_CountryName { get; set; }





    public int AdminUpdateCountryCountID { get; set; }
    public string AdminUpdateCountryCountry { get; set; }
    public int AdminUpdateCountryFK_Createdby { get; set; }
    public int AdminUpdateCountryFK_Region { get; set; }
    public int AdminUpdateCountryFK_Status { get; set; }





    public int AdminUpdatePartnerTypePTID { get; set; }
    public string AdminUpdatePartnerTypeType { get; set; }
    public int AdminUpdatePartnerTypeFK_Createdby { get; set; }
    public int AdminUpdatePartnerTypeFK_Status { get; set; }



    public int AdminUpdateRegionRID { get; set; }
    public string AdminUpdateRegionRegion { get; set; }
    public int AdminUpdateRegionFK_Createdby { get; set; }
    public int AdminUpdateRegionFK_Status { get; set; }





    public int AdminUpdateProductTypePTID { get; set; }
    public string AdminUpdateProductTypeType { get; set; }
    public int AdminUpdateProductTypeFK_Createdby { get; set; }
    public int AdminUpdateProductTypeFK_ProductCategory { get; set; }
    public int AdminUpdateProductTypeFK_Status { get; set; }
    public DateTime AdminUpdateProductTypeCreatedon { get; set; }




    public int AdminUpdateServicePSID { get; set; }
    public string AdminUpdateServiceService { get; set; }
    public string AdminUpdateServiceDetail { get; set; }
    public int AdminUpdateServiceFK_Createdby { get; set; }
    public int AdminUpdateServiceFK_Status { get; set; }
    public string AdminUpdateServicePic_Name { get; set; }
    public string AdminUpdateServicePic_Path { get; set; }



    public int AdminUpdatePatnerPID { get; set; }
    public string AdminUpdatePatnerName { get; set; }
    public string AdminUpdatePatnerAddress { get; set; }
    public string AdminUpdatePatnerEmail { get; set; }
    public string AdminUpdatePatnerPhone { get; set; }
    public string AdminUpdatePatnerWebsite { get; set; }
    public string AdminUpdatePatnerContactPersonName { get; set; }
    public string AdminUpdatePatnerContactPersonPhone { get; set; }
    public string AdminUpdatePatnerContactPersonEmail { get; set; }
    public string AdminUpdatePatnerLogoPath { get; set; }
    public string AdminUpdatePatnerLogoName { get; set; }
    public string AdminUpdatePatnerPostalCode { get; set; }
    public string AdminUpdatePatnerAnnualRevenue { get; set; }
    public string AdminUpdatePatnerCompanySize { get; set; }
    public long AdminUpdatePatnerCreatedby { get; set; }
    public long AdminUpdatePatnerCity { get; set; }
    public long AdminUpdatePatnerPatnerType { get; set; }
    public long AdminUpdatePatnerStatus { get; set; }


    
    public int AdminUpdateProductFormPID { get; set; }
    public string AdminUpdateProductFormProductName { get; set; }
    public string AdminUpdateProductFormDetail { get; set; }
    public string AdminUpdateProductFormModelNo { get; set; }
    public decimal AdminUpdateProductFormPrice { get; set; }
    public DateTime AdminUpdateProductFormLaunchDate { get; set; }
    public string AdminUpdateProductFormPic1name { get; set; }
    public string AdminUpdateProductFormPic1path { get; set; }
    public string AdminUpdateProductFormPic2path { get; set; }
    public string AdminUpdateProductFormPic2name { get; set; }
    public string AdminUpdateProductFormPic3name { get; set; }
    public string AdminUpdateProductFormPic3path { get; set; }
    public int AdminUpdateProductFormFk_Createdby { get; set; }
    public int AdminUpdateProductFormFk_ProductType { get; set; }
    public int AdminUpdateProductFormFk_Vendor { get; set; }
    public int AdminUpdateProductFormFk_Status { get; set; }
    public int AdminUpdateProductFormFk_Patner { get; set; }
    public int AdmnEditProductFetch { get; set; }

    //UPDATE AREA END //

    //sign up first area start//

    public int AdminUpdateUI_PatnerRegistrationFirstPRID { get; set; }
    public string AdminUpdateUI_PatnerRegistrationFirstHeading { get; set; }
    public string AdminUpdateUI_PatnerRegistrationFirstTextArea { get; set; }
    public string AdminUpdateUI_PatnerRegistrationFirstButtonText { get; set; }
    public string AdminUpdateUI_PatnerRegistrationFirstPicName { get; set; }
    public string AdminUpdateUI_PatnerRegistrationFirstPicPath { get; set; }
    public int AdminUpdateUI_PatnerRegistrationFirstFk_Createdby { get; set; }
    public int AdminUpdateUI_PatnerRegistrationFirstFk_Modifiedby { get; set; }
    public DateTime AdminUpdateUI_PatnerRegistrationFirstCreatedon { get; set; }
    public DateTime AdminUpdateUI_PatnerRegistrationFirstModifiedon { get; set; }

    //sign up first area end//


    //sign up second area start//

    public int AdminUpdateUI_PatnerRegistrationSecondPRID { get; set; }
    public string AdminUpdateUI_PatnerRegistrationSecondHeading { get; set; }
    public string AdminUpdateUI_PatnerRegistrationSecondTextArea { get; set; }
    public string AdminUpdateUI_PatnerRegistrationSecondButtonText { get; set; }
    public string AdminUpdateUI_PatnerRegistrationSecondPicName { get; set; }
    public string AdminUpdateUI_PatnerRegistrationSecondPicPath { get; set; }
    public int AdminUpdateUI_PatnerRegistrationSecondFk_Createdby { get; set; }
    public int AdminUpdateUI_PatnerRegistrationSecondFk_Modifiedby { get; set; }
    public DateTime AdminUpdateUI_PatnerRegistrationSecondCreatedon { get; set; }
    public DateTime AdminUpdateUI_PatnerRegistrationSecondModifiedon { get; set; }

    //sign up second area end//



    //sign up third area start//

    public int AdminUpdateUI_PatnerRegistrationThirdPRID { get; set; }
    public string AdminUpdateUI_PatnerRegistrationThirdHeading { get; set; }
    public string AdminUpdateUI_PatnerRegistrationThirdTextArea { get; set; }
    public string AdminUpdateUI_PatnerRegistrationThirdButtonText { get; set; }
    public string AdminUpdateUI_PatnerRegistrationThirdPicName { get; set; }
    public string AdminUpdateUI_PatnerRegistrationThirdPicPath { get; set; }
    public int AdminUpdateUI_PatnerRegistrationThirdFk_Createdby { get; set; }
    public int AdminUpdateUI_PatnerRegistrationThirdFk_Modifiedby { get; set; }
    public DateTime AdminUpdateUI_PatnerRegistrationThirdCreatedon { get; set; }
    public DateTime AdminUpdateUI_PatnerRegistrationThirdModifiedon { get; set; }

    //sign up third area end//



    //transparent area start//

    public int AdminUpdateUI_TransparentAreaTAID { get; set; }
    public string AdminUpdateUI_TransparentAreaHeading { get; set; }
    public string AdminUpdateUI_TransparentAreaTextArea { get; set; }
    public string AdminUpdateUI_TransparentAreaButtonText { get; set; }
    public string AdminUpdateUI_TransparentAreaPicName { get; set; }
    public string AdminUpdateUI_TransparentAreaPicPath { get; set; }
    public int AdminUpdateUI_TransparentAreaFk_Modifiedby { get; set; }

    //transparent area end//


    

    //Vendor Start//
    public long AdminPendngVendorGridviewPID { get; set; }


    public long AdminDeleteVendorGridviewPID { get; set; }

    public long AdminDeActiveVendorGridViewPID { get; set; }

    //Vendor End//

    //Reseller start//

    public long AdminPendingResellerGridViewPID { get; set; }


    public long AdminDeletingResellerGridViewPID { get; set; }


    public long AdminDeActiveResellerGridViewPID { get; set; }
    //Reseller End//

    //Distributer Start//

    public long AdminPendingDistributerGridViewPID { get; set; }


    public long AdminDeletingDistributerGridViewPID { get; set; }


    public long AdminDeActiveDistributerGridViewPID { get; set; }

    //Distributer End//


    //product category start//
    public long AdminPendingProductCategoryGridViewPCID { get; set; }

    public long AdminDeletingProductCategoryGridViewPCID { get; set; }

    public long AdminDeActiveProductCategoryGridViewPCID { get; set; }

    //product category end//

    //product type start//
    public long AdminPendingProductTypeGridViewPTID { get; set; }

    public long AdminDeletingProductTypeGridViewPTID { get; set; }

    public long AdminDeActiveProductTypeGridViewPTID { get; set; }
    //product type end//

    //product Service start//
    public long AdminPendingProductServiceGridViewPSID { get; set; }

    public long AdminDeletingProductServiceGridViewPSID { get; set; }

    public long AdminDeActiveProductServiceGridViewPSID { get; set; }
    //product Service end//

    //region start//
    public long AdminPendingRegionGridViewRID { get; set; }

    public long AdminDeletingRegionGridViewRID { get; set; }

    public long AdminDeActiveRegionGridViewRID { get; set; }
    //region end//

    //country start//
    public long AdminPendingCountryGridViewCountID { get; set; }

    public long AdminDeletingCountryGridViewCountID { get; set; }

    public long AdminDeActiveCountryGridViewCountID { get; set; }
    //country end//

    //city start//
    public long AdminPendingCityGridViewCID { get; set; }

    public long AdminDeletingCityGridViewCID { get; set; }

    public long AdminInwordGridView { get; set; }
    //city end//


    public long ResellerDeletingProductGridViewPID { get; set; }
    public long ResellerDeletingProductGridViewFK_Createdby { get; set; }



    public long DistributerDeletingProductGridViewPID { get; set; }
    public long DistributerDeletingProductGridViewFK_Createdby { get; set; }



    public int AdminUpdateSliderASID { get; set; }
    public string AdminUpdateSliderASliderFirstHeadingFirstText { get; set; }
    public string AdminUpdateSliderASliderBoldTechnologyText { get; set; }
    public DateTime AdminUpdateSliderAModifiedon { get; set; }
    public int AdminUpdateSliderAFk_Modifiedby { get; set; }



    public int AdminUpdateSideSliderSID { get; set; }
    public string AdminUpdateSideSliderSignuptodayHeading1 { get; set; }
    public string AdminUpdateSideSliderSignuptodayHeading2 { get; set; }
    public string AdminUpdateSideSliderSignuptodayHeading3 { get; set; }
    public string AdminUpdateSideSliderSignuptodayText1 { get; set; }
    public string AdminUpdateSideSliderSignuptodayText2 { get; set; }
    public string AdminUpdateSideSliderSignuptodayText3 { get; set; }
    public int AdminUpdateSideSliderFk_Modifiedby { get; set; }



    //tier level//
    public string AdminInsertTierLevelTierLevel { get; set; }
    public DateTime AdminInsertTierLevelCreatedon { get; set; }
    public int AdminInsertTierLevelFk_Createdby { get; set; }


    public int AdminUpdateTierLevelTLID { get; set; }
    public string AdminUpdateTierLevelTierLevel { get; set; }
    public DateTime AdminUpdateTierLevelCreatedon { get; set; }
    public int AdminUpdateTierLevelFk_Createdby { get; set; }
    public int AdminEditTierLevelForm { get; set; }
    //tier level//


    //assign tier level//
    public int AdminInsertAssignTierLevelFk_TierLevel { get; set; }
    public int AdminInsertAssignTierLevelFk_Distributer { get; set; }
    public DateTime AdminInsertAssignTierLevelCreatedon { get; set; }
    public int AdminInsertAssignTierLevelFk_Createdby { get; set; }



    public int AdminUpdateAssignTierLevelTID { get; set; }
    public int AdminUpdateAssignTierLevelFk_TierLevel { get; set; }
    public int AdminUpdateAssignTierLevelFk_Distributer { get; set; }
    public DateTime AdminUpdateAssignTierLevelModifiedon { get; set; }
    public int AdminUpdateAssignTierLevelFk_Modifiedby { get; set; }
    public int AdminEditAssignTierLevelForm { get; set; }
    //assign tier level//


    //what we do//
    public int AdminUpdateWhatWeDoWWDID { get; set; }
    public string AdminUpdateWhatWeDoHeading { get; set; }
    public string AdminUpdateWhatWeDoText { get; set; }
    public DateTime AdminUpdateWhatWeDoModifiedon { get; set; }
    public int AdminUpdateWhatWeDoModifiedby { get; set; }
    //what we do//


    //what we are//
    public int AdminUpdateWhatWeAreWWAID { get; set; }
    public string AdminUpdateWhatWeAreHeading { get; set; }
    public string AdminUpdateWhatWeAreText { get; set; }
    public int AdminUpdateWhatWeAreFk_Modifiedby { get; set; }
    //what we are//

    //subscriber info//
    public int AdminInsertSubscriberInfoSIID { get; set; }
    public string AdminInsertSubscriberInfoSubscriberEmail { get; set; }
    public DateTime AdminInsertSubscriberInfoCreatedon { get; set; }
    public int AdminInsertSubscriberInfoFk_Createdby { get; set; }
    //subscriber info//


    //social media link form//
    public int AdminUpdateSocialMediaLinksSMTID { get; set; }
    public string AdminUpdateSocialMediaLinksFacebook { get; set; }
    public string AdminUpdateSocialMediaLinksYouTube { get; set; }
    public string AdminUpdateSocialMediaLinksGoogle { get; set; }
    public string AdminUpdateSocialMediaLinksTwitter { get; set; }
    public DateTime AdminUpdateSocialMediaLinksModifiedon { get; set; }
    public int AdminUpdateSocialMediaLinksFk_Modifiedby { get; set; }
    //social media link form//



    //branch patner//
    



    public int AdminUpdatePatnerBranchFormBranchID { get; set; }
    public string AdminUpdatePatnerBranchFormAddress { get; set; }
    public string AdminUpdatePatnerBranchFormPostalcode { get; set; }
    public DateTime AdminUpdatePatnerBranchFormModifiedon { get; set; }
    public int AdminUpdatePatnerBranchFormFk_City { get; set; }
    public int AdminUpdatePatnerBranchFormFk_Patner { get; set; }
    public int AdminUpdatePatnerBranchFormFk_Modifiedby { get; set; }
    public int AdminUpdatePatnerBranchFormFk_Status { get; set; }
    public int AdminEditPatnerBranchForm { get; set; }
    //branch patner//


    //product patner relationship//
    public int AdminUpdateProductPatnerRelationshipPPRID { get; set; }
    public int AdminUpdateProductPatnerRelationshipFK_Product { get; set; }
    public int AdminUpdateProductPatnerRelationshipFK_Patner { get; set; }
    public int AdminUpdateProductPatnerRelationshipFK_Status { get; set; }
    public int AdminUpdateProductPatnerRelationshipFK_Createdby { get; set; }
    public int AdminEditProductPatnerRelationshipFetch { get; set; }
    //product patner relationship//

    //vendor product form//
    public string VendorInsertProductFormProductName { get; set; }
    public string VendorInsertProductFormDetail { get; set; }
    public string VendorInsertProductFormModelNo { get; set; }
    public decimal VendorInsertProductFormPrice { get; set; }
    public DateTime VendorInsertProductFormLaunchDate { get; set; }
    public string VendorInsertProductFormPic1name { get; set; }
    public string VendorInsertProductFormPic1path { get; set; }
    public string VendorInsertProductFormPic2name { get; set; }
    public string VendorInsertProductFormPic2path { get; set; }
    public string VendorInsertProductFormPic3name { get; set; }
    public string VendorInsertProductFormPic3path { get; set; }
    public long VendorInsertProductFormFK_Createdby { get; set; }
    public long VendorInsertProductFormFK_ProductType { get; set; }
    public long VendorInsertProductFormFK_Vendor { get; set; }
    public int VendorInsertProductFormFK_Status { get; set; }
    public long VendorInsertProductFormFK_Patner { get; set; }


    public int VendorUpdateProductFormPID { get; set; }
    public string VendorUpdateProductFormProductName { get; set; }
    public string VendorUpdateProductFormDetail { get; set; }
    public string VendorUpdateProductFormModelNo { get; set; }
    public decimal VendorUpdateProductFormPrice { get; set; }
    public DateTime VendorUpdateProductFormLaunchDate { get; set; }
    public string VendorUpdateProductFormPic1name { get; set; }
    public string VendorUpdateProductFormPic1path { get; set; }
    public string VendorUpdateProductFormPic2name { get; set; }
    public string VendorUpdateProductFormPic2path { get; set; }
    public string VendorUpdateProductFormPic3name { get; set; }
    public string VendorUpdateProductFormPic3path { get; set; }
    public long VendorUpdateProductFormFK_Createdby { get; set; }
    public long VendorUpdateProductFormFK_ProductType { get; set; }
    public long VendorUpdateProductFormFK_Vendor { get; set; }
    public int VendorUpdateProductFormFK_Status { get; set; }
    public long VendorUpdateProductFormFK_Patner { get; set; }
    public int VendorEditProductFetch { get; set; }
    //vendor product form//



    public int ResellerAddProductFetch { get; set; }
    public int ResellerAddProductFormPPRID { get; set; }
    public int ResellerAddProductFormFK_Product { get; set; }
    public int ResellerAddProductFormFK_Patner { get; set; }
    public int ResellerAddProductFormFK_Status { get; set; }
    public int ResellerAddProductFormFK_Createdby { get; set; }




    public int DistributerAddProductFetch { get; set; }
    public int DistributerAddProductFormPPRID { get; set; }
    public int DistributerAddProductFormFK_Product { get; set; }
    public int DistributerAddProductFormFK_Patner { get; set; }
    public int DistributerAddProductFormFK_Status { get; set; }
    public int DistributerAddProductFormFK_Createdby { get; set; }
}