/*
               File: GAMExampleWWAppMenuOptions
        Description: GAMExample WWApp Menu Options
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:11:9.41
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gamexamplewwappmenuoptions : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamexamplewwappmenuoptions( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamexamplewwappmenuoptions( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_ApplicationId ,
                           ref long aP1_MenuId )
      {
         this.AV6ApplicationId = aP0_ApplicationId;
         this.AV19MenuId = aP1_MenuId;
         executePrivate();
         aP0_ApplicationId=this.AV6ApplicationId;
         aP1_MenuId=this.AV19MenuId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavType = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridww") == 0 )
            {
               nRC_GXsfl_37 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_37_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_37_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGridww_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridww") == 0 )
            {
               AV15FilName = GetNextPar( );
               AV24SearchFilter = GetNextPar( );
               AV19MenuId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( AV15FilName, AV24SearchFilter, AV19MenuId) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               send_integrity_footer_hashes( ) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               AddString( context.getJSONResponse( )) ;
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV6ApplicationId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV6ApplicationId", StringUtil.LTrimStr( (decimal)(AV6ApplicationId), 12, 0));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV19MenuId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "AV19MenuId", StringUtil.LTrimStr( (decimal)(AV19MenuId), 12, 0));
               }
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("gammasterpage", "GeneXus.Programs.gammasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  AddString( context.getJSONResponse( )) ;
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA2H2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2H2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?20204151111988", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamexamplewwappmenuoptions.aspx") + "?" + UrlEncode("" +AV6ApplicationId) + "," + UrlEncode("" +AV19MenuId)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vSEARCHFILTER", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV24SearchFilter, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_37", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_37), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSEARCHFILTER", StringUtil.RTrim( AV24SearchFilter));
         GxWebStd.gx_hidden_field( context, "gxhash_vSEARCHFILTER", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV24SearchFilter, "")), context));
         GxWebStd.gx_hidden_field( context, "vMENUID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19MenuId), 12, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6ApplicationId), 12, 0, ".", "")));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE2H2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2H2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gamexamplewwappmenuoptions.aspx") + "?" + UrlEncode("" +AV6ApplicationId) + "," + UrlEncode("" +AV19MenuId) ;
      }

      public override String GetPgmname( )
      {
         return "GAMExampleWWAppMenuOptions" ;
      }

      public override String GetPgmdesc( )
      {
         return "GAMExample WWApp Menu Options" ;
      }

      protected void WB2H0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "BodyContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-2 col-sm-offset-1", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Options", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GAMExampleWWAppMenuOptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-4 col-sm-push-4", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7 col-sm-6", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnTextBlockBack";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttCancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(37), 2, 0)+","+"null"+");", "BACK", bttCancel_Jsonclick, 1, "BACK", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleWWAppMenuOptions.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5 col-sm-6", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnAdd";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttAddnew_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(37), 2, 0)+","+"null"+");", "Add", bttAddnew_Jsonclick, 7, "Add", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e112h1_client"+"'", TempTags, "", 2, "HLP_GAMExampleWWAppMenuOptions.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-sm-pull-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilname_Internalname, "Name", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_37_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilname_Internalname, StringUtil.RTrim( AV15FilName), StringUtil.RTrim( context.localUtil.Format( AV15FilName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,19);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Try a Search", edtavFilname_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavFilname_Enabled, 0, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleWWAppMenuOptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 WWGridCellExpanded", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable7_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 SubtitleContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCtlname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtlname_Internalname, "APPLICATION", "col-xs-6 col-sm-4 SubtitleAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "SubtitleAttribute";
            StyleString = "";
            ClassString = "SubtitleAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavCtlname_Internalname, StringUtil.RTrim( AV5Application.gxTpr_Name), "", "", 0, 1, edtavCtlname_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "254", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMExampleWWAppMenuOptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 SubtitleContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCtlname1_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtlname1_Internalname, "MENU", "col-xs-6 col-sm-3 SubtitleAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "SubtitleAttribute";
            StyleString = "";
            ClassString = "SubtitleAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavCtlname1_Internalname, StringUtil.RTrim( AV18Menu.gxTpr_Name), "", "", 0, 1, edtavCtlname1_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "254", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMExampleWWAppMenuOptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SubtitleContainer", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridwwContainer.SetWrapped(nGXWrapped);
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"37\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridww_Internalname, subGridww_Internalname, "", "WorkWith", 0, "", "", 1, 0, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGridww_Backcolorstyle == 0 )
               {
                  subGridww_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGridww_Class) > 0 )
                  {
                     subGridww_Linesclass = subGridww_Class+"Title";
                  }
               }
               else
               {
                  subGridww_Titlebackstyle = 1;
                  if ( subGridww_Backcolorstyle == 1 )
                  {
                     subGridww_Titlebackcolor = subGridww_Allbackcolor;
                     if ( StringUtil.Len( subGridww_Class) > 0 )
                     {
                        subGridww_Linesclass = subGridww_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGridww_Class) > 0 )
                     {
                        subGridww_Linesclass = subGridww_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute TextLikeLink SmallLink"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Menu name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Description") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Type") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute TextLikeLink"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute TextLikeLink"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute TextLikeLink"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute TextLikeLink"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridwwContainer.AddObjectProperty("GridName", "Gridww");
            }
            else
            {
               GridwwContainer.AddObjectProperty("GridName", "Gridww");
               GridwwContainer.AddObjectProperty("Header", subGridww_Header);
               GridwwContainer.AddObjectProperty("Class", "WorkWith");
               GridwwContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Backcolorstyle), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("CmpContext", "");
               GridwwContainer.AddObjectProperty("InMasterPage", "false");
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV21Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV12Dsc));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDsc_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV25Type));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavType.Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV10BtnUp));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnup_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV9BtnDown));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtndown_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV11BtnUpd));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnupd_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV8BtnDlt));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtndlt_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Id), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavId_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectedindex), 4, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowselection), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectioncolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowhovering), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Hoveringcolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowcollapsing), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 37 )
         {
            wbEnd = 0;
            nRC_GXsfl_37 = (int)(nGXsfl_37_idx-1);
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridww", GridwwContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridwwContainerData", GridwwContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridwwContainerData"+"V", GridwwContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridwwContainerData"+"V"+"\" value='"+GridwwContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 37 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridwwContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridww", GridwwContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridwwContainerData", GridwwContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridwwContainerData"+"V", GridwwContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridwwContainerData"+"V"+"\" value='"+GridwwContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START2H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "GAMExample WWApp Menu Options", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2H0( ) ;
      }

      protected void WS2H2( )
      {
         START2H2( ) ;
         EVT2H2( ) ;
      }

      protected void EVT2H2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "GRIDWW.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 12), "VBTNUP.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "VBTNDOWN.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 12), "VBTNUP.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "VBTNDOWN.CLICK") == 0 ) )
                           {
                              nGXsfl_37_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_37_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_37_idx), 4, 0), 4, "0");
                              SubsflControlProps_372( ) ;
                              AV21Name = cgiGet( edtavName_Internalname);
                              AssignAttri("", false, edtavName_Internalname, AV21Name);
                              AV12Dsc = cgiGet( edtavDsc_Internalname);
                              AssignAttri("", false, edtavDsc_Internalname, AV12Dsc);
                              cmbavType.Name = cmbavType_Internalname;
                              cmbavType.CurrentValue = cgiGet( cmbavType_Internalname);
                              AV25Type = cgiGet( cmbavType_Internalname);
                              AssignAttri("", false, cmbavType_Internalname, AV25Type);
                              AV10BtnUp = cgiGet( edtavBtnup_Internalname);
                              AssignAttri("", false, edtavBtnup_Internalname, AV10BtnUp);
                              AV9BtnDown = cgiGet( edtavBtndown_Internalname);
                              AssignAttri("", false, edtavBtndown_Internalname, AV9BtnDown);
                              AV11BtnUpd = cgiGet( edtavBtnupd_Internalname);
                              AssignAttri("", false, edtavBtnupd_Internalname, AV11BtnUpd);
                              AV8BtnDlt = cgiGet( edtavBtndlt_Internalname);
                              AssignAttri("", false, edtavBtndlt_Internalname, AV8BtnDlt);
                              if ( ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ",") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vID");
                                 GX_FocusControl = edtavId_Internalname;
                                 AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV17Id = 0;
                                 AssignAttri("", false, edtavId_Internalname, StringUtil.LTrimStr( (decimal)(AV17Id), 12, 0));
                              }
                              else
                              {
                                 AV17Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ","));
                                 AssignAttri("", false, edtavId_Internalname, StringUtil.LTrimStr( (decimal)(AV17Id), 12, 0));
                              }
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E122H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E132H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VBTNUP.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E142H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VBTNDOWN.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E152H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE2H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA2H2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavFilname_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridww_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_372( ) ;
         while ( nGXsfl_37_idx <= nRC_GXsfl_37 )
         {
            sendrow_372( ) ;
            nGXsfl_37_idx = ((subGridww_Islastpage==1)&&(nGXsfl_37_idx+1>subGridww_fnc_Recordsperpage( )) ? 1 : nGXsfl_37_idx+1);
            sGXsfl_37_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_37_idx), 4, 0), 4, "0");
            SubsflControlProps_372( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( GridwwContainer)) ;
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( String AV15FilName ,
                                         String AV24SearchFilter ,
                                         long AV19MenuId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRIDWW_nCurrentRecord = 0;
         RF2H2( ) ;
         /* End function gxgrGridww_refresh */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2H2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavCtlname_Enabled = 0;
         AssignProp("", false, edtavCtlname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname_Enabled), 5, 0), true);
         edtavCtlname1_Enabled = 0;
         AssignProp("", false, edtavCtlname1_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname1_Enabled), 5, 0), true);
         edtavName_Enabled = 0;
         AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavDsc_Enabled = 0;
         AssignProp("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDsc_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         cmbavType.Enabled = 0;
         AssignProp("", false, cmbavType_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavType.Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavBtnup_Enabled = 0;
         AssignProp("", false, edtavBtnup_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtnup_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavBtndown_Enabled = 0;
         AssignProp("", false, edtavBtndown_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtndown_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavBtnupd_Enabled = 0;
         AssignProp("", false, edtavBtnupd_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtnupd_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavBtndlt_Enabled = 0;
         AssignProp("", false, edtavBtndlt_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtndlt_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), !bGXsfl_37_Refreshing);
      }

      protected void RF2H2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 37;
         nGXsfl_37_idx = 1;
         sGXsfl_37_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_37_idx), 4, 0), 4, "0");
         SubsflControlProps_372( ) ;
         bGXsfl_37_Refreshing = true;
         GridwwContainer.AddObjectProperty("GridName", "Gridww");
         GridwwContainer.AddObjectProperty("CmpContext", "");
         GridwwContainer.AddObjectProperty("InMasterPage", "false");
         GridwwContainer.AddObjectProperty("Class", "WorkWith");
         GridwwContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridwwContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
         GridwwContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Backcolorstyle), 1, 0, ".", "")));
         GridwwContainer.PageSize = subGridww_fnc_Recordsperpage( );
         if ( subGridww_Islastpage != 0 )
         {
            GRIDWW_nFirstRecordOnPage = (long)(subGridww_fnc_Recordcount( )-subGridww_fnc_Recordsperpage( ));
            GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
            GridwwContainer.AddObjectProperty("GRIDWW_nFirstRecordOnPage", GRIDWW_nFirstRecordOnPage);
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_372( ) ;
            E132H2 ();
            wbEnd = 37;
            WB2H0( ) ;
         }
         bGXsfl_37_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2H2( )
      {
         GxWebStd.gx_hidden_field( context, "vSEARCHFILTER", StringUtil.RTrim( AV24SearchFilter));
         GxWebStd.gx_hidden_field( context, "gxhash_vSEARCHFILTER", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV24SearchFilter, "")), context));
      }

      protected int subGridww_fnc_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGridww_fnc_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGridww_fnc_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGridww_fnc_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP2H0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavCtlname_Enabled = 0;
         AssignProp("", false, edtavCtlname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname_Enabled), 5, 0), true);
         edtavCtlname1_Enabled = 0;
         AssignProp("", false, edtavCtlname1_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname1_Enabled), 5, 0), true);
         edtavName_Enabled = 0;
         AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavDsc_Enabled = 0;
         AssignProp("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDsc_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         cmbavType.Enabled = 0;
         AssignProp("", false, cmbavType_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavType.Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavBtnup_Enabled = 0;
         AssignProp("", false, edtavBtnup_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtnup_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavBtndown_Enabled = 0;
         AssignProp("", false, edtavBtndown_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtndown_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavBtnupd_Enabled = 0;
         AssignProp("", false, edtavBtnupd_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtnupd_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavBtndlt_Enabled = 0;
         AssignProp("", false, edtavBtndlt_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtndlt_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), !bGXsfl_37_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E122H2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_37 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_37"), ".", ","));
            AV19MenuId = (long)(context.localUtil.CToN( cgiGet( "vMENUID"), ".", ","));
            AV6ApplicationId = (long)(context.localUtil.CToN( cgiGet( "vAPPLICATIONID"), ".", ","));
            /* Read variables values. */
            AV15FilName = cgiGet( edtavFilname_Internalname);
            AssignAttri("", false, "AV15FilName", AV15FilName);
            AV5Application.gxTpr_Name = cgiGet( edtavCtlname_Internalname);
            AV18Menu.gxTpr_Name = cgiGet( edtavCtlname1_Internalname);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E122H2 ();
         if (returnInSub) return;
      }

      protected void E122H2( )
      {
         /* Start Routine */
         AV5Application.load( AV6ApplicationId);
         AssignAttri("", false, "AV6ApplicationId", StringUtil.LTrimStr( (decimal)(AV6ApplicationId), 12, 0));
         AV18Menu = AV5Application.getmenu(AV19MenuId, out  AV14Errors);
      }

      private void E132H2( )
      {
         /* Gridww_Load Routine */
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15FilName)) )
         {
            AV16Filter.gxTpr_Name = "%"+AV15FilName;
         }
         else
         {
            AV16Filter.gxTpr_Name = "%"+AV24SearchFilter;
         }
         AV31GXV4 = 1;
         AV30GXV3 = AV5Application.getmenuoptions(AV19MenuId, AV16Filter, out  AV14Errors);
         while ( AV31GXV4 <= AV30GXV3.Count )
         {
            AV7AppMenuOption = ((GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOption)AV30GXV3.Item(AV31GXV4));
            AV11BtnUpd = "EDIT";
            AssignAttri("", false, edtavBtnupd_Internalname, AV11BtnUpd);
            AV8BtnDlt = "DELETE";
            AssignAttri("", false, edtavBtndlt_Internalname, AV8BtnDlt);
            AV10BtnUp = "UP";
            AssignAttri("", false, edtavBtnup_Internalname, AV10BtnUp);
            AV9BtnDown = "DOWN";
            AssignAttri("", false, edtavBtndown_Internalname, AV9BtnDown);
            AV17Id = AV7AppMenuOption.gxTpr_Id;
            AssignAttri("", false, edtavId_Internalname, StringUtil.LTrimStr( (decimal)(AV17Id), 12, 0));
            AV21Name = AV7AppMenuOption.gxTpr_Name;
            AssignAttri("", false, edtavName_Internalname, AV21Name);
            AV12Dsc = AV7AppMenuOption.gxTpr_Description;
            AssignAttri("", false, edtavDsc_Internalname, AV12Dsc);
            AV25Type = AV7AppMenuOption.gxTpr_Type;
            AssignAttri("", false, cmbavType_Internalname, AV25Type);
            AV22Order = AV7AppMenuOption.gxTpr_Order;
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 37;
            }
            sendrow_372( ) ;
            if ( isFullAjaxMode( ) && ! bGXsfl_37_Refreshing )
            {
               context.DoAjaxLoad(37, GridwwRow);
            }
            AV31GXV4 = (int)(AV31GXV4+1);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16Filter", AV16Filter);
         cmbavType.CurrentValue = StringUtil.RTrim( AV25Type);
      }

      protected void E142H2( )
      {
         /* Btnup_Click Routine */
         AV23Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
         AV5Application.load( AV6ApplicationId);
         AssignAttri("", false, "AV6ApplicationId", StringUtil.LTrimStr( (decimal)(AV6ApplicationId), 12, 0));
         AV20MenuOption = AV5Application.getmenuoption(AV19MenuId, AV17Id, out  AV14Errors);
         AV20MenuOption.moveup( AV23Repository.gxTpr_Id,  AV6ApplicationId,  AV19MenuId, out  AV14Errors);
         AssignAttri("", false, "AV6ApplicationId", StringUtil.LTrimStr( (decimal)(AV6ApplicationId), 12, 0));
         AssignAttri("", false, "AV19MenuId", StringUtil.LTrimStr( (decimal)(AV19MenuId), 12, 0));
         if ( AV14Errors.Count > 0 )
         {
            AV32GXV5 = 1;
            while ( AV32GXV5 <= AV14Errors.Count )
            {
               AV13Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV14Errors.Item(AV32GXV5));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV13Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV13Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV32GXV5 = (int)(AV32GXV5+1);
            }
         }
         else
         {
            context.CommitDataStores("gamexamplewwappmenuoptions",pr_default);
         }
         gxgrGridww_refresh( AV15FilName, AV24SearchFilter, AV19MenuId) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5Application", AV5Application);
      }

      protected void E152H2( )
      {
         /* Btndown_Click Routine */
         AV23Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
         AV5Application.load( AV6ApplicationId);
         AssignAttri("", false, "AV6ApplicationId", StringUtil.LTrimStr( (decimal)(AV6ApplicationId), 12, 0));
         AV18Menu = AV5Application.getmenu(AV19MenuId, out  AV14Errors);
         AV20MenuOption = AV5Application.getmenuoption(AV19MenuId, AV17Id, out  AV14Errors);
         AV20MenuOption.movedown( AV23Repository.gxTpr_Id,  AV6ApplicationId,  AV19MenuId, out  AV14Errors);
         AssignAttri("", false, "AV6ApplicationId", StringUtil.LTrimStr( (decimal)(AV6ApplicationId), 12, 0));
         AssignAttri("", false, "AV19MenuId", StringUtil.LTrimStr( (decimal)(AV19MenuId), 12, 0));
         if ( AV14Errors.Count > 0 )
         {
            AV33GXV6 = 1;
            while ( AV33GXV6 <= AV14Errors.Count )
            {
               AV13Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV14Errors.Item(AV33GXV6));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV13Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV13Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV33GXV6 = (int)(AV33GXV6+1);
            }
         }
         else
         {
            context.CommitDataStores("gamexamplewwappmenuoptions",pr_default);
         }
         gxgrGridww_refresh( AV15FilName, AV24SearchFilter, AV19MenuId) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5Application", AV5Application);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18Menu", AV18Menu);
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6ApplicationId = Convert.ToInt64(getParm(obj,0));
         AssignAttri("", false, "AV6ApplicationId", StringUtil.LTrimStr( (decimal)(AV6ApplicationId), 12, 0));
         AV19MenuId = Convert.ToInt64(getParm(obj,1));
         AssignAttri("", false, "AV19MenuId", StringUtil.LTrimStr( (decimal)(AV19MenuId), 12, 0));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA2H2( ) ;
         WS2H2( ) ;
         WE2H2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202041511112885", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("gamexamplewwappmenuoptions.js", "?202041511112888", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_372( )
      {
         edtavName_Internalname = "vNAME_"+sGXsfl_37_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_37_idx;
         cmbavType_Internalname = "vTYPE_"+sGXsfl_37_idx;
         edtavBtnup_Internalname = "vBTNUP_"+sGXsfl_37_idx;
         edtavBtndown_Internalname = "vBTNDOWN_"+sGXsfl_37_idx;
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_37_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_37_idx;
         edtavId_Internalname = "vID_"+sGXsfl_37_idx;
      }

      protected void SubsflControlProps_fel_372( )
      {
         edtavName_Internalname = "vNAME_"+sGXsfl_37_fel_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_37_fel_idx;
         cmbavType_Internalname = "vTYPE_"+sGXsfl_37_fel_idx;
         edtavBtnup_Internalname = "vBTNUP_"+sGXsfl_37_fel_idx;
         edtavBtndown_Internalname = "vBTNDOWN_"+sGXsfl_37_fel_idx;
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_37_fel_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_37_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_37_fel_idx;
      }

      protected void sendrow_372( )
      {
         SubsflControlProps_372( ) ;
         WB2H0( ) ;
         GridwwRow = GXWebRow.GetNew(context,GridwwContainer);
         if ( subGridww_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridww_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
            {
               subGridww_Linesclass = subGridww_Class+"Odd";
            }
         }
         else if ( subGridww_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridww_Backstyle = 0;
            subGridww_Backcolor = subGridww_Allbackcolor;
            if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
            {
               subGridww_Linesclass = subGridww_Class+"Uniform";
            }
         }
         else if ( subGridww_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridww_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
            {
               subGridww_Linesclass = subGridww_Class+"Odd";
            }
            subGridww_Backcolor = (int)(0x0);
         }
         else if ( subGridww_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridww_Backstyle = 1;
            if ( ((int)((nGXsfl_37_idx) % (2))) == 0 )
            {
               subGridww_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
               {
                  subGridww_Linesclass = subGridww_Class+"Even";
               }
            }
            else
            {
               subGridww_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
               {
                  subGridww_Linesclass = subGridww_Class+"Odd";
               }
            }
         }
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_37_idx+"\">") ;
         }
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 38,'',false,'"+sGXsfl_37_idx+"',37)\"" : " ");
         ROClassString = "Attribute TextLikeLink SmallLink";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV21Name),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,38);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+"e162h2_client"+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)7,(String)"Attribute TextLikeLink SmallLink",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)120,(short)0,(short)0,(short)37,(short)1,(short)-1,(short)-1,(bool)true,(String)"GeneXusSecurityCommon\\GAMDescriptionMedium",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavDsc_Enabled!=0)&&(edtavDsc_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 39,'',false,'"+sGXsfl_37_idx+"',37)\"" : " ");
         ROClassString = "Attribute";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDsc_Internalname,StringUtil.RTrim( AV12Dsc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavDsc_Enabled!=0)&&(edtavDsc_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,39);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(int)edtavDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)37,(short)1,(short)-1,(short)-1,(bool)true,(String)"GeneXusSecurityCommon\\GAMDescriptionLong",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         TempTags = " " + ((cmbavType.Enabled!=0)&&(cmbavType.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 40,'',false,'"+sGXsfl_37_idx+"',37)\"" : " ");
         if ( ( cmbavType.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "vTYPE_" + sGXsfl_37_idx;
            cmbavType.Name = GXCCtl;
            cmbavType.WebTags = "";
            cmbavType.addItem("S", "Simple", 0);
            cmbavType.addItem("M", "Menu", 0);
            if ( cmbavType.ItemCount > 0 )
            {
               AV25Type = cmbavType.getValidValue(AV25Type);
               AssignAttri("", false, cmbavType_Internalname, AV25Type);
            }
         }
         /* ComboBox */
         GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavType,(String)cmbavType_Internalname,StringUtil.RTrim( AV25Type),(short)1,(String)cmbavType_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,cmbavType.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWSecondaryColumn",(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((cmbavType.Enabled!=0)&&(cmbavType.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,40);\"" : " "),(String)"",(bool)true});
         cmbavType.CurrentValue = StringUtil.RTrim( AV25Type);
         AssignProp("", false, cmbavType_Internalname, "Values", (String)(cmbavType.ToJavascriptSource()), !bGXsfl_37_Refreshing);
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavBtnup_Enabled!=0)&&(edtavBtnup_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 41,'',false,'"+sGXsfl_37_idx+"',37)\"" : " ");
         ROClassString = "TextActionAttribute TextLikeLink";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnup_Internalname,StringUtil.RTrim( AV10BtnUp),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavBtnup_Enabled!=0)&&(edtavBtnup_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,41);\"" : " "),"'"+""+"'"+",false,"+"'"+"EVBTNUP.CLICK."+sGXsfl_37_idx+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavBtnup_Jsonclick,(short)5,(String)"TextActionAttribute TextLikeLink",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavBtnup_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)37,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavBtndown_Enabled!=0)&&(edtavBtndown_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 42,'',false,'"+sGXsfl_37_idx+"',37)\"" : " ");
         ROClassString = "TextActionAttribute TextLikeLink";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndown_Internalname,StringUtil.RTrim( AV9BtnDown),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavBtndown_Enabled!=0)&&(edtavBtndown_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,42);\"" : " "),"'"+""+"'"+",false,"+"'"+"EVBTNDOWN.CLICK."+sGXsfl_37_idx+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavBtndown_Jsonclick,(short)5,(String)"TextActionAttribute TextLikeLink",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavBtndown_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)37,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavBtnupd_Enabled!=0)&&(edtavBtnupd_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 43,'',false,'"+sGXsfl_37_idx+"',37)\"" : " ");
         ROClassString = "TextActionAttribute TextLikeLink";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnupd_Internalname,StringUtil.RTrim( AV11BtnUpd),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavBtnupd_Enabled!=0)&&(edtavBtnupd_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,43);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+"e172h2_client"+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavBtnupd_Jsonclick,(short)7,(String)"TextActionAttribute TextLikeLink",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavBtnupd_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)37,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavBtndlt_Enabled!=0)&&(edtavBtndlt_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 44,'',false,'"+sGXsfl_37_idx+"',37)\"" : " ");
         ROClassString = "TextActionAttribute TextLikeLink";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndlt_Internalname,StringUtil.RTrim( AV8BtnDlt),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavBtndlt_Enabled!=0)&&(edtavBtndlt_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,44);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+"e182h2_client"+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavBtndlt_Jsonclick,(short)7,(String)"TextActionAttribute TextLikeLink",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavBtndlt_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)37,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 45,'',false,'"+sGXsfl_37_idx+"',37)\"" : " ");
         ROClassString = "Attribute";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Id), 12, 0, ".", "")),((edtavId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17Id), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV17Id), "ZZZZZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,45);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)37,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXusSecurityCommon\\GAMKeyNumLong",(String)"right",(bool)false,(String)""});
         send_integrity_lvl_hashes2H2( ) ;
         GridwwContainer.AddRow(GridwwRow);
         nGXsfl_37_idx = ((subGridww_Islastpage==1)&&(nGXsfl_37_idx+1>subGridww_fnc_Recordsperpage( )) ? 1 : nGXsfl_37_idx+1);
         sGXsfl_37_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_37_idx), 4, 0), 4, "0");
         SubsflControlProps_372( ) ;
         /* End function sendrow_372 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "vTYPE_" + sGXsfl_37_idx;
         cmbavType.Name = GXCCtl;
         cmbavType.WebTags = "";
         cmbavType.addItem("S", "Simple", 0);
         cmbavType.addItem("M", "Menu", 0);
         if ( cmbavType.ItemCount > 0 )
         {
            AV25Type = cmbavType.getValidValue(AV25Type);
            AssignAttri("", false, cmbavType_Internalname, AV25Type);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         bttCancel_Internalname = "CANCEL";
         bttAddnew_Internalname = "ADDNEW";
         divTable1_Internalname = "TABLE1";
         edtavFilname_Internalname = "vFILNAME";
         divTabletop_Internalname = "TABLETOP";
         edtavCtlname_Internalname = "CTLNAME";
         edtavCtlname1_Internalname = "CTLNAME1";
         edtavName_Internalname = "vNAME";
         edtavDsc_Internalname = "vDSC";
         cmbavType_Internalname = "vTYPE";
         edtavBtnup_Internalname = "vBTNUP";
         edtavBtndown_Internalname = "vBTNDOWN";
         edtavBtnupd_Internalname = "vBTNUPD";
         edtavBtndlt_Internalname = "vBTNDLT";
         edtavId_Internalname = "vID";
         divTable7_Internalname = "TABLE7";
         divGridcell_Internalname = "GRIDCELL";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridww_Internalname = "GRIDWW";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavId_Jsonclick = "";
         edtavId_Visible = 0;
         edtavBtndlt_Jsonclick = "";
         edtavBtndlt_Visible = -1;
         edtavBtnupd_Jsonclick = "";
         edtavBtnupd_Visible = -1;
         edtavBtndown_Jsonclick = "";
         edtavBtndown_Visible = -1;
         edtavBtnup_Jsonclick = "";
         edtavBtnup_Visible = -1;
         cmbavType_Jsonclick = "";
         cmbavType.Visible = -1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Visible = -1;
         edtavName_Jsonclick = "";
         edtavName_Visible = -1;
         edtavCtlname1_Enabled = -1;
         edtavCtlname_Enabled = -1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         subGridww_Header = "";
         edtavId_Enabled = 1;
         edtavBtndlt_Enabled = 1;
         edtavBtnupd_Enabled = 1;
         edtavBtndown_Enabled = 1;
         edtavBtnup_Enabled = 1;
         cmbavType.Enabled = 1;
         edtavDsc_Enabled = 1;
         edtavName_Enabled = 1;
         subGridww_Class = "WorkWith";
         subGridww_Backcolorstyle = 0;
         edtavCtlname1_Enabled = 0;
         edtavCtlname_Enabled = 0;
         edtavFilname_Jsonclick = "";
         edtavFilname_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "GAMExample WWApp Menu Options";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'AV15FilName',fld:'vFILNAME',pic:''},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV24SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E132H2',iparms:[{av:'AV15FilName',fld:'vFILNAME',pic:''},{av:'AV24SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("GRIDWW.LOAD",",oparms:[{av:'AV11BtnUpd',fld:'vBTNUPD',pic:''},{av:'AV8BtnDlt',fld:'vBTNDLT',pic:''},{av:'AV10BtnUp',fld:'vBTNUP',pic:''},{av:'AV9BtnDown',fld:'vBTNDOWN',pic:''},{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV21Name',fld:'vNAME',pic:''},{av:'AV12Dsc',fld:'vDSC',pic:''},{av:'cmbavType'},{av:'AV25Type',fld:'vTYPE',pic:''}]}");
         setEventMetadata("'ADDNEW'","{handler:'E112H1',iparms:[{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("'ADDNEW'",",oparms:[{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'}]}");
         setEventMetadata("VNAME.CLICK","{handler:'E162H2',iparms:[{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("VNAME.CLICK",",oparms:[{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'}]}");
         setEventMetadata("VBTNUPD.CLICK","{handler:'E172H2',iparms:[{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("VBTNUPD.CLICK",",oparms:[{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'}]}");
         setEventMetadata("VBTNDLT.CLICK","{handler:'E182H2',iparms:[{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("VBTNDLT.CLICK",",oparms:[{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'}]}");
         setEventMetadata("VBTNUP.CLICK","{handler:'E142H2',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'AV15FilName',fld:'vFILNAME',pic:''},{av:'AV24SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("VBTNUP.CLICK",",oparms:[]}");
         setEventMetadata("VBTNDOWN.CLICK","{handler:'E152H2',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'AV15FilName',fld:'vFILNAME',pic:''},{av:'AV24SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV19MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9'},{av:'AV6ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV17Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("VBTNDOWN.CLICK",",oparms:[]}");
         setEventMetadata("VALIDV_TYPE","{handler:'Validv_Type',iparms:[]");
         setEventMetadata("VALIDV_TYPE",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Validv_Id',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV15FilName = "";
         AV24SearchFilter = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblTitle_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttCancel_Jsonclick = "";
         bttAddnew_Jsonclick = "";
         AV5Application = new GeneXus.Programs.genexussecurity.SdtGAMApplication(context);
         AV18Menu = new GeneXus.Programs.genexussecurity.SdtGAMApplicationMenu(context);
         GridwwContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridww_Linesclass = "";
         GridwwColumn = new GXWebColumn();
         AV21Name = "";
         AV12Dsc = "";
         AV25Type = "";
         AV10BtnUp = "";
         AV9BtnDown = "";
         AV11BtnUpd = "";
         AV8BtnDlt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV14Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV16Filter = new GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOptionFilter(context);
         AV30GXV3 = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOption>( context, "GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOption", "GeneXus.Programs");
         AV7AppMenuOption = new GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOption(context);
         GridwwRow = new GXWebRow();
         AV23Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV20MenuOption = new GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOption(context);
         AV13Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamexamplewwappmenuoptions__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamexamplewwappmenuoptions__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavCtlname_Enabled = 0;
         edtavCtlname1_Enabled = 0;
         edtavName_Enabled = 0;
         edtavDsc_Enabled = 0;
         cmbavType.Enabled = 0;
         edtavBtnup_Enabled = 0;
         edtavBtndown_Enabled = 0;
         edtavBtnupd_Enabled = 0;
         edtavBtndlt_Enabled = 0;
         edtavId_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGridww_Backcolorstyle ;
      private short subGridww_Titlebackstyle ;
      private short subGridww_Allowselection ;
      private short subGridww_Allowhovering ;
      private short subGridww_Allowcollapsing ;
      private short subGridww_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short GRIDWW_nEOF ;
      private short nGXWrapped ;
      private short subGridww_Backstyle ;
      private int nRC_GXsfl_37 ;
      private int nGXsfl_37_idx=1 ;
      private int edtavFilname_Enabled ;
      private int edtavCtlname_Enabled ;
      private int edtavCtlname1_Enabled ;
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavBtnup_Enabled ;
      private int edtavBtndown_Enabled ;
      private int edtavBtnupd_Enabled ;
      private int edtavBtndlt_Enabled ;
      private int edtavId_Enabled ;
      private int subGridww_Selectedindex ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int subGridww_Islastpage ;
      private int AV31GXV4 ;
      private int AV22Order ;
      private int AV32GXV5 ;
      private int AV33GXV6 ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private int edtavName_Visible ;
      private int edtavDsc_Visible ;
      private int edtavBtnup_Visible ;
      private int edtavBtndown_Visible ;
      private int edtavBtnupd_Visible ;
      private int edtavBtndlt_Visible ;
      private int edtavId_Visible ;
      private long AV6ApplicationId ;
      private long AV19MenuId ;
      private long wcpOAV6ApplicationId ;
      private long wcpOAV19MenuId ;
      private long AV17Id ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_37_idx="0001" ;
      private String AV15FilName ;
      private String AV24SearchFilter ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTabletop_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String divTable1_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttCancel_Internalname ;
      private String bttCancel_Jsonclick ;
      private String bttAddnew_Internalname ;
      private String bttAddnew_Jsonclick ;
      private String edtavFilname_Internalname ;
      private String edtavFilname_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divTable7_Internalname ;
      private String edtavCtlname_Internalname ;
      private String edtavCtlname1_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String subGridww_Header ;
      private String AV21Name ;
      private String AV12Dsc ;
      private String AV25Type ;
      private String AV10BtnUp ;
      private String AV9BtnDown ;
      private String AV11BtnUpd ;
      private String AV8BtnDlt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavName_Internalname ;
      private String edtavDsc_Internalname ;
      private String cmbavType_Internalname ;
      private String edtavBtnup_Internalname ;
      private String edtavBtndown_Internalname ;
      private String edtavBtnupd_Internalname ;
      private String edtavBtndlt_Internalname ;
      private String edtavId_Internalname ;
      private String sGXsfl_37_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavName_Jsonclick ;
      private String edtavDsc_Jsonclick ;
      private String GXCCtl ;
      private String cmbavType_Jsonclick ;
      private String edtavBtnup_Jsonclick ;
      private String edtavBtndown_Jsonclick ;
      private String edtavBtnupd_Jsonclick ;
      private String edtavBtndlt_Jsonclick ;
      private String edtavId_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_37_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private long aP0_ApplicationId ;
      private long aP1_MenuId ;
      private GXCombobox cmbavType ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV14Errors ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOption> AV30GXV3 ;
      private GXWebForm Form ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplication AV5Application ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV13Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplicationMenu AV18Menu ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOption AV7AppMenuOption ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOption AV20MenuOption ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuOptionFilter AV16Filter ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV23Repository ;
   }

   public class gamexamplewwappmenuoptions__gam : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "GAM";
    }

 }

 public class gamexamplewwappmenuoptions__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        def= new CursorDef[] {
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
     }
  }

}

}
