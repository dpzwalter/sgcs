/*
               File: GAMExampleRolePermissionSelect
        Description: Application permission select to role
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:9:55.53
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
   public class gamexamplerolepermissionselect : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamexamplerolepermissionselect( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamexamplerolepermissionselect( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_RoleId ,
                           ref long aP1_ApplicationId )
      {
         this.AV24RoleId = aP0_RoleId;
         this.AV8ApplicationId = aP1_ApplicationId;
         executePrivate();
         aP0_RoleId=this.AV24RoleId;
         aP1_ApplicationId=this.AV8ApplicationId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavPermissionaccesstype = new GXCombobox();
         cmbavBoolenfilter = new GXCombobox();
         chkavSelect = new GXCheckbox();
         cmbavAccess = new GXCombobox();
         cmbavCurrentpage = new GXCombobox();
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
               nRC_GXsfl_71 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_71_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_71_idx = GetNextPar( );
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
               AV24RoleId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV8ApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25Search = GetNextPar( );
               AV26SearchFilter = GetNextPar( );
               AV20PermissionAccessType = GetNextPar( );
               AV9BoolenFilter = GetNextPar( );
               AV11CurrentPage = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( AV24RoleId, AV8ApplicationId, AV25Search, AV26SearchFilter, AV20PermissionAccessType, AV9BoolenFilter, AV11CurrentPage) ;
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
               AV24RoleId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV24RoleId", StringUtil.LTrimStr( (decimal)(AV24RoleId), 12, 0));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8ApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "AV8ApplicationId", StringUtil.LTrimStr( (decimal)(AV8ApplicationId), 12, 0));
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
         PA262( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START262( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20204151195574", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamexamplerolepermissionselect.aspx") + "?" + UrlEncode("" +AV24RoleId) + "," + UrlEncode("" +AV8ApplicationId)+"\">") ;
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
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_71", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_71), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24RoleId), 12, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ApplicationId), 12, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vISOK", AV17isOK);
         GxWebStd.gx_hidden_field( context, "FILTERSCONTAINER_Class", StringUtil.RTrim( divFilterscontainer_Class));
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
            WE262( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT262( ) ;
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
         return formatLink("gamexamplerolepermissionselect.aspx") + "?" + UrlEncode("" +AV24RoleId) + "," + UrlEncode("" +AV8ApplicationId) ;
      }

      public override String GetPgmname( )
      {
         return "GAMExampleRolePermissionSelect" ;
      }

      public override String GetPgmdesc( )
      {
         return "Application permission select to role" ;
      }

      protected void WB260( )
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
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable7_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = bttHide_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttHide_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(71), 2, 0)+","+"null"+");", bttHide_Caption, bttHide_Jsonclick, 7, "HIDE FILTERS", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e11261_client"+"'", TempTags, "", 2, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10 col-sm-2", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Add Permission", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-sm-push-3 col-md-3", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5 col-sm-3", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"";
            ClassString = "BtnTextBlockBack";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBack_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(71), 2, 0)+","+"null"+");", "Back", bttBack_Jsonclick, 1, "Back", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7 col-sm-9", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnAdd";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttAddselected_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(71), 2, 0)+","+"null"+");", "Add Selected", bttAddselected_Jsonclick, 5, "Add Selected", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'ADDSELECTED\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-sm-pull-4 col-md-pull-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_71_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSearch_Internalname, AV25Search, StringUtil.RTrim( context.localUtil.Format( AV25Search, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Try a Search", edtavSearch_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavSearch_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMUserIdentification", "left", true, "", "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCellfilters_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-md-4 col-lg-2 WWAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFilterscontainer_Internalname, 1, 0, "px", 0, "px", divFilterscontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10 col-xs-offset-1 hidden-sm hidden-md hidden-lg", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable8_Internalname, 1, 0, "px", 0, "px", "AdvancedContainerItemExpanded", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_71_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSearchfilter_Internalname, AV26SearchFilter, StringUtil.RTrim( context.localUtil.Format( AV26SearchFilter, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Try a Search", edtavSearchfilter_Jsonclick, 0, "FilterAttribute", "", "", "", "", 1, edtavSearchfilter_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMUserIdentification", "left", true, "", "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10 col-xs-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "AdvancedContainerItemExpanded", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "DEFAULT ACCESS TYPE", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FilterLabel", 0, "", 1, 1, 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_71_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPermissionaccesstype, cmbavPermissionaccesstype_Internalname, StringUtil.RTrim( AV20PermissionAccessType), 1, cmbavPermissionaccesstype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavPermissionaccesstype.Enabled, 0, 0, 0, "em", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "", true, "HLP_GAMExampleRolePermissionSelect.htm");
            cmbavPermissionaccesstype.CurrentValue = StringUtil.RTrim( AV20PermissionAccessType);
            AssignProp("", false, cmbavPermissionaccesstype_Internalname, "Values", (String)(cmbavPermissionaccesstype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10 col-xs-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable5_Internalname, 1, 0, "px", 0, "px", "AdvancedContainerItemExpanded", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "IS INHERITED?", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FilterLabel", 0, "", 1, 1, 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_71_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBoolenfilter, cmbavBoolenfilter_Internalname, StringUtil.RTrim( AV9BoolenFilter), 1, cmbavBoolenfilter_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavBoolenfilter.Enabled, 0, 0, 0, "em", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "", true, "HLP_GAMExampleRolePermissionSelect.htm");
            cmbavBoolenfilter.CurrentValue = StringUtil.RTrim( AV9BoolenFilter);
            AssignProp("", false, cmbavBoolenfilter_Internalname, "Values", (String)(cmbavBoolenfilter.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridcell_Internalname, 1, 0, "px", 0, "px", divGridcell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "ContainerFluid WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 SubtitleContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCtlname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtlname_Internalname, "APPLICATION", "col-xs-6 col-sm-5 col-md-4 SubtitleAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-7 col-md-8 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "SubtitleAttribute";
            StyleString = "";
            ClassString = "SubtitleAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavCtlname_Internalname, StringUtil.RTrim( AV5GAMApplication.gxTpr_Name), "", "", 0, 1, edtavCtlname_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "254", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5 col-sm-offset-1 col-md-6 col-md-offset-0 SubtitleContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCtlname2_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtlname2_Internalname, "ROLE", "col-xs-6 col-sm-3 SubtitleAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "SubtitleAttribute";
            StyleString = "";
            ClassString = "SubtitleAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavCtlname2_Internalname, StringUtil.RTrim( AV15GAMRole.gxTpr_Name), "", "", 0, 1, edtavCtlname2_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "254", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9 col-xs-offset-3 col-sm-12 col-sm-offset-0", "Center", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /*  Grid Control  */
            GridwwContainer.SetWrapped(nGXWrapped);
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"71\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"CheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Select") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Permission name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Description") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ComboAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Permissions options") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Key Numeric Long") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "GUID") ;
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
               GridwwColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV27Select));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV18Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV12Dsc));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDsc_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV6Access));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AppId), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAppid_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV16Id));
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
         if ( wbEnd == 71 )
         {
            wbEnd = 0;
            nRC_GXsfl_71 = (int)(nGXsfl_71_idx-1);
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
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-4 col-lg-offset-4", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-xs-offset-1 col-sm-3 col-sm-offset-0", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbfirst_Internalname, "FIRST", "", "", lblTbfirst_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12261_client"+"'", "", lblTbfirst_Class, 7, "", 1, lblTbfirst_Enabled, 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTb1_Internalname, "/", "", "", lblTb1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SelectedPagingText TextLikeLink", 0, "", 1, 1, 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-3", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbprev_Internalname, "PREV", "", "", lblTbprev_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13261_client"+"'", "", lblTbprev_Class, 7, "", 1, lblTbprev_Enabled, 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTb2_Internalname, "/", "", "", lblTb2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SelectedPagingText TextLikeLink", 0, "", 1, 1, 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbnext_Internalname, "NEXT", "", "", lblTbnext_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14261_client"+"'", "", lblTbnext_Class, 7, "", 1, 1, 0, "HLP_GAMExampleRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", cmbavCurrentpage.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavCurrentpage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCurrentpage_Internalname, "Current Page", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'" + sGXsfl_71_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCurrentpage, cmbavCurrentpage_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV11CurrentPage), 4, 0)), 1, cmbavCurrentpage_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavCurrentpage.Visible, cmbavCurrentpage.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,96);\"", "", true, "HLP_GAMExampleRolePermissionSelect.htm");
            cmbavCurrentpage.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV11CurrentPage), 4, 0));
            AssignProp("", false, cmbavCurrentpage_Internalname, "Values", (String)(cmbavCurrentpage.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 71 )
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

      protected void START262( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Application permission select to role", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP260( ) ;
      }

      protected void WS262( )
      {
         START262( ) ;
         EVT262( ) ;
      }

      protected void EVT262( )
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
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDSELECTED'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddSelected' */
                              E15262 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "GRIDWW.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_71_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_71_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_71_idx), 4, 0), 4, "0");
                              SubsflControlProps_712( ) ;
                              AV27Select = StringUtil.StrToBool( cgiGet( chkavSelect_Internalname));
                              AssignAttri("", false, chkavSelect_Internalname, AV27Select);
                              AV18Name = cgiGet( edtavName_Internalname);
                              AssignAttri("", false, edtavName_Internalname, AV18Name);
                              AV12Dsc = cgiGet( edtavDsc_Internalname);
                              AssignAttri("", false, edtavDsc_Internalname, AV12Dsc);
                              cmbavAccess.Name = cmbavAccess_Internalname;
                              cmbavAccess.CurrentValue = cgiGet( cmbavAccess_Internalname);
                              AV6Access = cgiGet( cmbavAccess_Internalname);
                              AssignAttri("", false, cmbavAccess_Internalname, AV6Access);
                              if ( ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vAPPID");
                                 GX_FocusControl = edtavAppid_Internalname;
                                 AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV7AppId = 0;
                                 AssignAttri("", false, edtavAppid_Internalname, StringUtil.LTrimStr( (decimal)(AV7AppId), 12, 0));
                                 AssignAttri("", false, "gxhash_vAPPID"+"_"+sGXsfl_71_idx, GetSecureSignedToken( sGXsfl_71_idx, context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
                              }
                              else
                              {
                                 AV7AppId = (long)(context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ".", ","));
                                 AssignAttri("", false, edtavAppid_Internalname, StringUtil.LTrimStr( (decimal)(AV7AppId), 12, 0));
                                 AssignAttri("", false, "gxhash_vAPPID"+"_"+sGXsfl_71_idx, GetSecureSignedToken( sGXsfl_71_idx, context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
                              }
                              AV16Id = cgiGet( edtavId_Internalname);
                              AssignAttri("", false, edtavId_Internalname, AV16Id);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E16262 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E17262 ();
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

      protected void WE262( )
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

      protected void PA262( )
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
               GX_FocusControl = edtavSearch_Internalname;
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
         SubsflControlProps_712( ) ;
         while ( nGXsfl_71_idx <= nRC_GXsfl_71 )
         {
            sendrow_712( ) ;
            nGXsfl_71_idx = ((subGridww_Islastpage==1)&&(nGXsfl_71_idx+1>subGridww_fnc_Recordsperpage( )) ? 1 : nGXsfl_71_idx+1);
            sGXsfl_71_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_71_idx), 4, 0), 4, "0");
            SubsflControlProps_712( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( GridwwContainer)) ;
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( long AV24RoleId ,
                                         long AV8ApplicationId ,
                                         String AV25Search ,
                                         String AV26SearchFilter ,
                                         String AV20PermissionAccessType ,
                                         String AV9BoolenFilter ,
                                         short AV11CurrentPage )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRIDWW_nCurrentRecord = 0;
         RF262( ) ;
         /* End function gxgrGridww_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAPPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AppId), 12, 0, ".", "")));
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
         if ( cmbavPermissionaccesstype.ItemCount > 0 )
         {
            AV20PermissionAccessType = cmbavPermissionaccesstype.getValidValue(AV20PermissionAccessType);
            AssignAttri("", false, "AV20PermissionAccessType", AV20PermissionAccessType);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPermissionaccesstype.CurrentValue = StringUtil.RTrim( AV20PermissionAccessType);
            AssignProp("", false, cmbavPermissionaccesstype_Internalname, "Values", cmbavPermissionaccesstype.ToJavascriptSource(), true);
         }
         if ( cmbavBoolenfilter.ItemCount > 0 )
         {
            AV9BoolenFilter = cmbavBoolenfilter.getValidValue(AV9BoolenFilter);
            AssignAttri("", false, "AV9BoolenFilter", AV9BoolenFilter);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBoolenfilter.CurrentValue = StringUtil.RTrim( AV9BoolenFilter);
            AssignProp("", false, cmbavBoolenfilter_Internalname, "Values", cmbavBoolenfilter.ToJavascriptSource(), true);
         }
         if ( cmbavCurrentpage.ItemCount > 0 )
         {
            AV11CurrentPage = (short)(NumberUtil.Val( cmbavCurrentpage.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV11CurrentPage), 4, 0))), "."));
            AssignAttri("", false, "AV11CurrentPage", StringUtil.LTrimStr( (decimal)(AV11CurrentPage), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCurrentpage.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV11CurrentPage), 4, 0));
            AssignProp("", false, cmbavCurrentpage_Internalname, "Values", cmbavCurrentpage.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF262( ) ;
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
         edtavCtlname2_Enabled = 0;
         AssignProp("", false, edtavCtlname2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname2_Enabled), 5, 0), true);
         edtavName_Enabled = 0;
         AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), !bGXsfl_71_Refreshing);
         edtavDsc_Enabled = 0;
         AssignProp("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDsc_Enabled), 5, 0), !bGXsfl_71_Refreshing);
         edtavAppid_Enabled = 0;
         AssignProp("", false, edtavAppid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavAppid_Enabled), 5, 0), !bGXsfl_71_Refreshing);
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), !bGXsfl_71_Refreshing);
      }

      protected void RF262( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 71;
         nGXsfl_71_idx = 1;
         sGXsfl_71_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_71_idx), 4, 0), 4, "0");
         SubsflControlProps_712( ) ;
         bGXsfl_71_Refreshing = true;
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
            SubsflControlProps_712( ) ;
            E17262 ();
            wbEnd = 71;
            WB260( ) ;
         }
         bGXsfl_71_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes262( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPID"+"_"+sGXsfl_71_idx, GetSecureSignedToken( sGXsfl_71_idx, context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
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

      protected void STRUP260( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavCtlname_Enabled = 0;
         AssignProp("", false, edtavCtlname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname_Enabled), 5, 0), true);
         edtavCtlname2_Enabled = 0;
         AssignProp("", false, edtavCtlname2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname2_Enabled), 5, 0), true);
         edtavName_Enabled = 0;
         AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), !bGXsfl_71_Refreshing);
         edtavDsc_Enabled = 0;
         AssignProp("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDsc_Enabled), 5, 0), !bGXsfl_71_Refreshing);
         edtavAppid_Enabled = 0;
         AssignProp("", false, edtavAppid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavAppid_Enabled), 5, 0), !bGXsfl_71_Refreshing);
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), !bGXsfl_71_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E16262 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_71 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_71"), ".", ","));
            AV8ApplicationId = (long)(context.localUtil.CToN( cgiGet( "vAPPLICATIONID"), ".", ","));
            /* Read variables values. */
            AV25Search = cgiGet( edtavSearch_Internalname);
            AssignAttri("", false, "AV25Search", AV25Search);
            AV26SearchFilter = cgiGet( edtavSearchfilter_Internalname);
            AssignAttri("", false, "AV26SearchFilter", AV26SearchFilter);
            cmbavPermissionaccesstype.Name = cmbavPermissionaccesstype_Internalname;
            cmbavPermissionaccesstype.CurrentValue = cgiGet( cmbavPermissionaccesstype_Internalname);
            AV20PermissionAccessType = cgiGet( cmbavPermissionaccesstype_Internalname);
            AssignAttri("", false, "AV20PermissionAccessType", AV20PermissionAccessType);
            cmbavBoolenfilter.Name = cmbavBoolenfilter_Internalname;
            cmbavBoolenfilter.CurrentValue = cgiGet( cmbavBoolenfilter_Internalname);
            AV9BoolenFilter = cgiGet( cmbavBoolenfilter_Internalname);
            AssignAttri("", false, "AV9BoolenFilter", AV9BoolenFilter);
            AV5GAMApplication.gxTpr_Name = cgiGet( edtavCtlname_Internalname);
            AV15GAMRole.gxTpr_Name = cgiGet( edtavCtlname2_Internalname);
            cmbavCurrentpage.Name = cmbavCurrentpage_Internalname;
            cmbavCurrentpage.CurrentValue = cgiGet( cmbavCurrentpage_Internalname);
            AV11CurrentPage = (short)(NumberUtil.Val( cgiGet( cmbavCurrentpage_Internalname), "."));
            AssignAttri("", false, "AV11CurrentPage", StringUtil.LTrimStr( (decimal)(AV11CurrentPage), 4, 0));
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
         E16262 ();
         if (returnInSub) return;
      }

      protected void E16262( )
      {
         /* Start Routine */
         if ( (0==AV24RoleId) || (0==AV8ApplicationId) )
         {
            context.setWebReturnParms(new Object[] {(long)AV24RoleId,(long)AV8ApplicationId});
            context.setWebReturnParmsMetadata(new Object[] {"AV24RoleId","AV8ApplicationId"});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         AV11CurrentPage = 1;
         AssignAttri("", false, "AV11CurrentPage", StringUtil.LTrimStr( (decimal)(AV11CurrentPage), 4, 0));
         cmbavCurrentpage.Visible = 0;
         AssignProp("", false, cmbavCurrentpage_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(cmbavCurrentpage.Visible), 5, 0), true);
      }

      private void E17262( )
      {
         /* Gridww_Load Routine */
         AV10CountPermissions = 0;
         AV23PermissionsXPage = 10;
         AV15GAMRole.load( AV24RoleId);
         AssignAttri("", false, "AV24RoleId", StringUtil.LTrimStr( (decimal)(AV24RoleId), 12, 0));
         AV5GAMApplication.load( AV8ApplicationId);
         AssignAttri("", false, "AV8ApplicationId", StringUtil.LTrimStr( (decimal)(AV8ApplicationId), 12, 0));
         AV7AppId = AV8ApplicationId;
         AssignAttri("", false, edtavAppid_Internalname, StringUtil.LTrimStr( (decimal)(AV7AppId), 12, 0));
         AssignAttri("", false, "gxhash_vAPPID"+"_"+sGXsfl_71_idx, GetSecureSignedToken( sGXsfl_71_idx, context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
         AV22PermissionFilter.gxTpr_Applicationid = AV7AppId;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25Search)) )
         {
            AV22PermissionFilter.gxTpr_Name = "%"+AV25Search;
         }
         else
         {
            AV22PermissionFilter.gxTpr_Name = "%"+AV26SearchFilter;
         }
         AV22PermissionFilter.gxTpr_Accesstype = AV20PermissionAccessType;
         AV22PermissionFilter.gxTpr_Inherited = AV9BoolenFilter;
         AV22PermissionFilter.gxTpr_Limit = AV23PermissionsXPage;
         AV22PermissionFilter.gxTpr_Start = (int)((AV11CurrentPage-1)*AV22PermissionFilter.gxTpr_Limit+1);
         if ( ! (0==AV7AppId) )
         {
            AV33GXV4 = 1;
            AV32GXV3 = AV15GAMRole.getunassignedpermissions(AV22PermissionFilter, out  AV14Errors);
            while ( AV33GXV4 <= AV32GXV3.Count )
            {
               AV19Permission = ((GeneXus.Programs.genexussecurity.SdtGAMPermission)AV32GXV3.Item(AV33GXV4));
               AV10CountPermissions = (long)(AV10CountPermissions+1);
               AV16Id = AV19Permission.gxTpr_Guid;
               AssignAttri("", false, edtavId_Internalname, AV16Id);
               AV18Name = AV19Permission.gxTpr_Name;
               AssignAttri("", false, edtavName_Internalname, AV18Name);
               AV12Dsc = AV19Permission.gxTpr_Description;
               AssignAttri("", false, edtavDsc_Internalname, AV12Dsc);
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 71;
               }
               sendrow_712( ) ;
               if ( isFullAjaxMode( ) && ! bGXsfl_71_Refreshing )
               {
                  context.DoAjaxLoad(71, GridwwRow);
               }
               AV33GXV4 = (int)(AV33GXV4+1);
            }
         }
         if ( AV10CountPermissions < AV23PermissionsXPage )
         {
            lblTbnext_Class = "SelectedPagingText";
            AssignProp("", false, lblTbnext_Internalname, "Class", lblTbnext_Class, true);
         }
         else
         {
            lblTbnext_Class = "PagingText";
            AssignProp("", false, lblTbnext_Internalname, "Class", lblTbnext_Class, true);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15GAMRole", AV15GAMRole);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5GAMApplication", AV5GAMApplication);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PermissionFilter", AV22PermissionFilter);
      }

      protected void E15262( )
      {
         /* 'AddSelected' Routine */
         AV15GAMRole.load( AV24RoleId);
         AssignAttri("", false, "AV24RoleId", StringUtil.LTrimStr( (decimal)(AV24RoleId), 12, 0));
         /* Start For Each Line */
         nRC_GXsfl_71 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_71"), ".", ","));
         nGXsfl_71_fel_idx = 0;
         while ( nGXsfl_71_fel_idx < nRC_GXsfl_71 )
         {
            nGXsfl_71_fel_idx = ((subGridww_Islastpage==1)&&(nGXsfl_71_fel_idx+1>subGridww_fnc_Recordsperpage( )) ? 1 : nGXsfl_71_fel_idx+1);
            sGXsfl_71_fel_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_71_fel_idx), 4, 0), 4, "0");
            SubsflControlProps_fel_712( ) ;
            AV27Select = StringUtil.StrToBool( cgiGet( chkavSelect_Internalname));
            AV18Name = cgiGet( edtavName_Internalname);
            AV12Dsc = cgiGet( edtavDsc_Internalname);
            cmbavAccess.Name = cmbavAccess_Internalname;
            cmbavAccess.CurrentValue = cgiGet( cmbavAccess_Internalname);
            AV6Access = cgiGet( cmbavAccess_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vAPPID");
               GX_FocusControl = edtavAppid_Internalname;
               wbErr = true;
               AV7AppId = 0;
            }
            else
            {
               AV7AppId = (long)(context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ".", ","));
            }
            AV16Id = cgiGet( edtavId_Internalname);
            if ( AV27Select )
            {
               AV21PermissionAdd.gxTpr_Applicationid = AV7AppId;
               AV21PermissionAdd.gxTpr_Guid = AV16Id;
               AV21PermissionAdd.gxTpr_Type = AV6Access;
               AV17isOK = AV15GAMRole.addpermission(AV21PermissionAdd, out  AV14Errors);
               AssignAttri("", false, "AV17isOK", AV17isOK);
               if ( ! AV17isOK )
               {
                  AV35GXV5 = 1;
                  while ( AV35GXV5 <= AV14Errors.Count )
                  {
                     AV13Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV14Errors.Item(AV35GXV5));
                     GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV13Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV13Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
                     AV35GXV5 = (int)(AV35GXV5+1);
                  }
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_71_fel_idx == 0 )
         {
            nGXsfl_71_idx = 1;
            sGXsfl_71_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_71_idx), 4, 0), 4, "0");
            SubsflControlProps_712( ) ;
         }
         nGXsfl_71_fel_idx = 1;
         if ( AV17isOK )
         {
            context.CommitDataStores("gamexamplerolepermissionselect",pr_default);
            CallWebObject(formatLink("gamexamplewwrolepermissions.aspx") + "?" + UrlEncode("" +AV24RoleId) + "," + UrlEncode("" +AV8ApplicationId));
            context.wjLocDisableFrm = 1;
         }
         else
         {
            AV36GXV6 = 1;
            while ( AV36GXV6 <= AV14Errors.Count )
            {
               AV13Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV14Errors.Item(AV36GXV6));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV13Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV13Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV36GXV6 = (int)(AV36GXV6+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15GAMRole", AV15GAMRole);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21PermissionAdd", AV21PermissionAdd);
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV24RoleId = Convert.ToInt64(getParm(obj,0));
         AssignAttri("", false, "AV24RoleId", StringUtil.LTrimStr( (decimal)(AV24RoleId), 12, 0));
         AV8ApplicationId = Convert.ToInt64(getParm(obj,1));
         AssignAttri("", false, "AV8ApplicationId", StringUtil.LTrimStr( (decimal)(AV8ApplicationId), 12, 0));
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
         PA262( ) ;
         WS262( ) ;
         WE262( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20204151110130", true, true);
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
         context.AddJavascriptSource("gamexamplerolepermissionselect.js", "?20204151110131", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_712( )
      {
         chkavSelect_Internalname = "vSELECT_"+sGXsfl_71_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_71_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_71_idx;
         cmbavAccess_Internalname = "vACCESS_"+sGXsfl_71_idx;
         edtavAppid_Internalname = "vAPPID_"+sGXsfl_71_idx;
         edtavId_Internalname = "vID_"+sGXsfl_71_idx;
      }

      protected void SubsflControlProps_fel_712( )
      {
         chkavSelect_Internalname = "vSELECT_"+sGXsfl_71_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_71_fel_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_71_fel_idx;
         cmbavAccess_Internalname = "vACCESS_"+sGXsfl_71_fel_idx;
         edtavAppid_Internalname = "vAPPID_"+sGXsfl_71_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_71_fel_idx;
      }

      protected void sendrow_712( )
      {
         SubsflControlProps_712( ) ;
         WB260( ) ;
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
            if ( ((int)((nGXsfl_71_idx) % (2))) == 0 )
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
            context.WriteHtmlText( " gxrow=\""+sGXsfl_71_idx+"\">") ;
         }
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavSelect.Enabled!=0)&&(chkavSelect.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 72,'',false,'"+sGXsfl_71_idx+"',71)\"" : " ");
         ClassString = "CheckBox";
         StyleString = "";
         GXCCtl = "vSELECT_" + sGXsfl_71_idx;
         chkavSelect.Name = GXCCtl;
         chkavSelect.WebTags = "";
         chkavSelect.Caption = "";
         AssignProp("", false, chkavSelect_Internalname, "TitleCaption", chkavSelect.Caption, !bGXsfl_71_Refreshing);
         chkavSelect.CheckedValue = "false";
         AV27Select = StringUtil.StrToBool( StringUtil.BoolToStr( AV27Select));
         AssignAttri("", false, chkavSelect_Internalname, AV27Select);
         GridwwRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSelect_Internalname,StringUtil.BoolToStr( AV27Select),(String)"",(String)"",(short)-1,(short)1,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",TempTags+" onclick="+"\"gx.fn.checkboxClick(72, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+((chkavSelect.Enabled!=0)&&(chkavSelect.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,72);\"" : " ")});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 73,'',false,'"+sGXsfl_71_idx+"',71)\"" : " ");
         ROClassString = "Attribute";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV18Name),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,73);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+"e18262_client"+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)7,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)71,(short)1,(short)-1,(short)-1,(bool)true,(String)"GeneXusSecurityCommon\\GAMDescriptionLong",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavDsc_Enabled!=0)&&(edtavDsc_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 74,'',false,'"+sGXsfl_71_idx+"',71)\"" : " ");
         ROClassString = "Attribute";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDsc_Internalname,StringUtil.RTrim( AV12Dsc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavDsc_Enabled!=0)&&(edtavDsc_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,74);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(int)edtavDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)71,(short)1,(short)-1,(short)-1,(bool)true,(String)"GeneXusSecurityCommon\\GAMDescriptionLong",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         TempTags = " " + ((cmbavAccess.Enabled!=0)&&(cmbavAccess.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 75,'',false,'"+sGXsfl_71_idx+"',71)\"" : " ");
         if ( ( cmbavAccess.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "vACCESS_" + sGXsfl_71_idx;
            cmbavAccess.Name = GXCCtl;
            cmbavAccess.WebTags = "";
            cmbavAccess.addItem("A", "Allow", 0);
            cmbavAccess.addItem("D", "Deny", 0);
            cmbavAccess.addItem("R", "Restricted", 0);
            if ( cmbavAccess.ItemCount > 0 )
            {
               AV6Access = cmbavAccess.getValidValue(AV6Access);
               AssignAttri("", false, cmbavAccess_Internalname, AV6Access);
            }
         }
         /* ComboBox */
         GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavAccess,(String)cmbavAccess_Internalname,StringUtil.RTrim( AV6Access),(short)1,(String)cmbavAccess_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)1,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"ComboAttribute",(String)"WWColumn",(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((cmbavAccess.Enabled!=0)&&(cmbavAccess.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,75);\"" : " "),(String)"",(bool)true});
         cmbavAccess.CurrentValue = StringUtil.RTrim( AV6Access);
         AssignProp("", false, cmbavAccess_Internalname, "Values", (String)(cmbavAccess.ToJavascriptSource()), !bGXsfl_71_Refreshing);
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavAppid_Enabled!=0)&&(edtavAppid_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 76,'',false,'"+sGXsfl_71_idx+"',71)\"" : " ");
         ROClassString = "Attribute";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAppid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AppId), 12, 0, ".", "")),((edtavAppid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+((edtavAppid_Enabled!=0)&&(edtavAppid_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,76);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAppid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtavAppid_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)71,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXusSecurityCommon\\GAMKeyNumLong",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 77,'',false,'"+sGXsfl_71_idx+"',71)\"" : " ");
         ROClassString = "Attribute";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.RTrim( AV16Id),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,77);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)71,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXusSecurityCommon\\GAMGUID",(String)"left",(bool)true,(String)""});
         send_integrity_lvl_hashes262( ) ;
         GridwwContainer.AddRow(GridwwRow);
         nGXsfl_71_idx = ((subGridww_Islastpage==1)&&(nGXsfl_71_idx+1>subGridww_fnc_Recordsperpage( )) ? 1 : nGXsfl_71_idx+1);
         sGXsfl_71_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_71_idx), 4, 0), 4, "0");
         SubsflControlProps_712( ) ;
         /* End function sendrow_712 */
      }

      protected void init_web_controls( )
      {
         cmbavPermissionaccesstype.Name = "vPERMISSIONACCESSTYPE";
         cmbavPermissionaccesstype.WebTags = "";
         cmbavPermissionaccesstype.addItem("", "(None)", 0);
         cmbavPermissionaccesstype.addItem("A", "Allow", 0);
         cmbavPermissionaccesstype.addItem("D", "Deny", 0);
         cmbavPermissionaccesstype.addItem("R", "Restricted", 0);
         if ( cmbavPermissionaccesstype.ItemCount > 0 )
         {
            AV20PermissionAccessType = cmbavPermissionaccesstype.getValidValue(AV20PermissionAccessType);
            AssignAttri("", false, "AV20PermissionAccessType", AV20PermissionAccessType);
         }
         cmbavBoolenfilter.Name = "vBOOLENFILTER";
         cmbavBoolenfilter.WebTags = "";
         cmbavBoolenfilter.addItem("A", "All", 0);
         cmbavBoolenfilter.addItem("T", "Yes", 0);
         cmbavBoolenfilter.addItem("F", "No", 0);
         if ( cmbavBoolenfilter.ItemCount > 0 )
         {
            AV9BoolenFilter = cmbavBoolenfilter.getValidValue(AV9BoolenFilter);
            AssignAttri("", false, "AV9BoolenFilter", AV9BoolenFilter);
         }
         GXCCtl = "vSELECT_" + sGXsfl_71_idx;
         chkavSelect.Name = GXCCtl;
         chkavSelect.WebTags = "";
         chkavSelect.Caption = "";
         AssignProp("", false, chkavSelect_Internalname, "TitleCaption", chkavSelect.Caption, !bGXsfl_71_Refreshing);
         chkavSelect.CheckedValue = "false";
         AV27Select = StringUtil.StrToBool( StringUtil.BoolToStr( AV27Select));
         AssignAttri("", false, chkavSelect_Internalname, AV27Select);
         GXCCtl = "vACCESS_" + sGXsfl_71_idx;
         cmbavAccess.Name = GXCCtl;
         cmbavAccess.WebTags = "";
         cmbavAccess.addItem("A", "Allow", 0);
         cmbavAccess.addItem("D", "Deny", 0);
         cmbavAccess.addItem("R", "Restricted", 0);
         if ( cmbavAccess.ItemCount > 0 )
         {
            AV6Access = cmbavAccess.getValidValue(AV6Access);
            AssignAttri("", false, cmbavAccess_Internalname, AV6Access);
         }
         cmbavCurrentpage.Name = "vCURRENTPAGE";
         cmbavCurrentpage.WebTags = "";
         cmbavCurrentpage.addItem("15", "Rows", 0);
         if ( cmbavCurrentpage.ItemCount > 0 )
         {
            AV11CurrentPage = (short)(NumberUtil.Val( cmbavCurrentpage.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV11CurrentPage), 4, 0))), "."));
            AssignAttri("", false, "AV11CurrentPage", StringUtil.LTrimStr( (decimal)(AV11CurrentPage), 4, 0));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttHide_Internalname = "HIDE";
         divTable7_Internalname = "TABLE7";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         bttBack_Internalname = "BACK";
         bttAddselected_Internalname = "ADDSELECTED";
         divTable3_Internalname = "TABLE3";
         edtavSearch_Internalname = "vSEARCH";
         divTable2_Internalname = "TABLE2";
         edtavSearchfilter_Internalname = "vSEARCHFILTER";
         divTable8_Internalname = "TABLE8";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         cmbavPermissionaccesstype_Internalname = "vPERMISSIONACCESSTYPE";
         divTable4_Internalname = "TABLE4";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         cmbavBoolenfilter_Internalname = "vBOOLENFILTER";
         divTable5_Internalname = "TABLE5";
         divFilterscontainer_Internalname = "FILTERSCONTAINER";
         divCellfilters_Internalname = "CELLFILTERS";
         edtavCtlname_Internalname = "CTLNAME";
         edtavCtlname2_Internalname = "CTLNAME2";
         chkavSelect_Internalname = "vSELECT";
         edtavName_Internalname = "vNAME";
         edtavDsc_Internalname = "vDSC";
         cmbavAccess_Internalname = "vACCESS";
         edtavAppid_Internalname = "vAPPID";
         edtavId_Internalname = "vID";
         lblTbfirst_Internalname = "TBFIRST";
         lblTb1_Internalname = "TB1";
         lblTbprev_Internalname = "TBPREV";
         lblTb2_Internalname = "TB2";
         lblTbnext_Internalname = "TBNEXT";
         divTable1_Internalname = "TABLE1";
         cmbavCurrentpage_Internalname = "vCURRENTPAGE";
         divGridtable_Internalname = "GRIDTABLE";
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
         edtavAppid_Jsonclick = "";
         edtavAppid_Visible = 0;
         cmbavAccess_Jsonclick = "";
         cmbavAccess.Visible = -1;
         cmbavAccess.Enabled = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Visible = -1;
         edtavName_Jsonclick = "";
         edtavName_Visible = -1;
         chkavSelect.Caption = "";
         chkavSelect.Visible = -1;
         chkavSelect.Enabled = 1;
         edtavCtlname2_Enabled = -1;
         edtavCtlname_Enabled = -1;
         cmbavCurrentpage_Jsonclick = "";
         cmbavCurrentpage.Enabled = 1;
         cmbavCurrentpage.Visible = 1;
         lblTbnext_Class = "PagingText TextLikeLink";
         lblTbprev_Class = "SelectedPagingText TextLikeLink";
         lblTbprev_Enabled = 1;
         lblTbfirst_Class = "SelectedPagingText TextLikeLink";
         lblTbfirst_Enabled = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         subGridww_Header = "";
         edtavId_Enabled = 1;
         edtavAppid_Enabled = 1;
         edtavDsc_Enabled = 1;
         edtavName_Enabled = 1;
         subGridww_Class = "WorkWith";
         subGridww_Backcolorstyle = 0;
         edtavCtlname2_Enabled = 0;
         edtavCtlname_Enabled = 0;
         divGridcell_Class = "col-xs-12 col-sm-8 col-md-7 col-lg-8 WWGridCell";
         cmbavBoolenfilter_Jsonclick = "";
         cmbavBoolenfilter.Enabled = 1;
         cmbavPermissionaccesstype_Jsonclick = "";
         cmbavPermissionaccesstype.Enabled = 1;
         edtavSearchfilter_Jsonclick = "";
         edtavSearchfilter_Enabled = 1;
         edtavSearch_Jsonclick = "";
         edtavSearch_Enabled = 1;
         bttHide_Class = "ShowFiltersButton";
         bttHide_Caption = "HIDE FILTERS";
         divFilterscontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Application permission select to role";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV25Search',fld:'vSEARCH',pic:''},{av:'AV26SearchFilter',fld:'vSEARCHFILTER',pic:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:''},{av:'cmbavCurrentpage'},{av:'AV11CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E17262',iparms:[{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV25Search',fld:'vSEARCH',pic:''},{av:'AV26SearchFilter',fld:'vSEARCHFILTER',pic:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:''},{av:'cmbavCurrentpage'},{av:'AV11CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("GRIDWW.LOAD",",oparms:[{av:'AV7AppId',fld:'vAPPID',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV16Id',fld:'vID',pic:''},{av:'AV18Name',fld:'vNAME',pic:''},{av:'AV12Dsc',fld:'vDSC',pic:''},{av:'lblTbnext_Class',ctrl:'TBNEXT',prop:'Class'}]}");
         setEventMetadata("'ADDSELECTED'","{handler:'E15262',iparms:[{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9'},{av:'AV27Select',fld:'vSELECT',grid:71,pic:''},{av:'GRIDWW_nFirstRecordOnPage'},{av:'nRC_GXsfl_71',ctrl:'GRIDWW',grid:71,prop:'GridRC'},{av:'AV7AppId',fld:'vAPPID',grid:71,pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV16Id',fld:'vID',grid:71,pic:''},{av:'AV6Access',fld:'vACCESS',grid:71,pic:''},{av:'AV17isOK',fld:'vISOK',pic:''},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("'ADDSELECTED'",",oparms:[{av:'AV17isOK',fld:'vISOK',pic:''},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9'}]}");
         setEventMetadata("'HIDE'","{handler:'E11261',iparms:[{av:'divFilterscontainer_Class',ctrl:'FILTERSCONTAINER',prop:'Class'}]");
         setEventMetadata("'HIDE'",",oparms:[{av:'divFilterscontainer_Class',ctrl:'FILTERSCONTAINER',prop:'Class'},{ctrl:'HIDE',prop:'Caption'},{ctrl:'HIDE',prop:'Class'},{av:'divGridcell_Class',ctrl:'GRIDCELL',prop:'Class'}]}");
         setEventMetadata("VNAME.CLICK","{handler:'E18262',iparms:[{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV16Id',fld:'vID',pic:''}]");
         setEventMetadata("VNAME.CLICK",",oparms:[{av:'AV16Id',fld:'vID',pic:''},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'}]}");
         setEventMetadata("'FIRST'","{handler:'E12261',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV25Search',fld:'vSEARCH',pic:''},{av:'AV26SearchFilter',fld:'vSEARCHFILTER',pic:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:''},{av:'cmbavCurrentpage'},{av:'AV11CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("'FIRST'",",oparms:[{av:'cmbavCurrentpage'},{av:'AV11CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'},{av:'lblTbfirst_Class',ctrl:'TBFIRST',prop:'Class'},{av:'lblTbprev_Class',ctrl:'TBPREV',prop:'Class'},{av:'lblTbfirst_Enabled',ctrl:'TBFIRST',prop:'Enabled'},{av:'lblTbprev_Enabled',ctrl:'TBPREV',prop:'Enabled'}]}");
         setEventMetadata("'PREVIOUS'","{handler:'E13261',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV25Search',fld:'vSEARCH',pic:''},{av:'AV26SearchFilter',fld:'vSEARCHFILTER',pic:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:''},{av:'cmbavCurrentpage'},{av:'AV11CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("'PREVIOUS'",",oparms:[{av:'cmbavCurrentpage'},{av:'AV11CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'},{av:'lblTbfirst_Class',ctrl:'TBFIRST',prop:'Class'},{av:'lblTbprev_Class',ctrl:'TBPREV',prop:'Class'},{av:'lblTbfirst_Enabled',ctrl:'TBFIRST',prop:'Enabled'},{av:'lblTbprev_Enabled',ctrl:'TBPREV',prop:'Enabled'}]}");
         setEventMetadata("'NEXT'","{handler:'E14261',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV25Search',fld:'vSEARCH',pic:''},{av:'AV26SearchFilter',fld:'vSEARCHFILTER',pic:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:''},{av:'cmbavCurrentpage'},{av:'AV11CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("'NEXT'",",oparms:[{av:'lblTbfirst_Class',ctrl:'TBFIRST',prop:'Class'},{av:'lblTbprev_Class',ctrl:'TBPREV',prop:'Class'},{av:'lblTbfirst_Enabled',ctrl:'TBFIRST',prop:'Enabled'},{av:'lblTbprev_Enabled',ctrl:'TBPREV',prop:'Enabled'},{av:'cmbavCurrentpage'},{av:'AV11CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]}");
         setEventMetadata("VALIDV_PERMISSIONACCESSTYPE","{handler:'Validv_Permissionaccesstype',iparms:[]");
         setEventMetadata("VALIDV_PERMISSIONACCESSTYPE",",oparms:[]}");
         setEventMetadata("VALIDV_BOOLENFILTER","{handler:'Validv_Boolenfilter',iparms:[]");
         setEventMetadata("VALIDV_BOOLENFILTER",",oparms:[]}");
         setEventMetadata("VALIDV_CURRENTPAGE","{handler:'Validv_Currentpage',iparms:[]");
         setEventMetadata("VALIDV_CURRENTPAGE",",oparms:[]}");
         setEventMetadata("VALIDV_ACCESS","{handler:'Validv_Access',iparms:[]");
         setEventMetadata("VALIDV_ACCESS",",oparms:[]}");
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
         AV25Search = "";
         AV26SearchFilter = "";
         AV20PermissionAccessType = "";
         AV9BoolenFilter = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttHide_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         bttBack_Jsonclick = "";
         bttAddselected_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         AV5GAMApplication = new GeneXus.Programs.genexussecurity.SdtGAMApplication(context);
         AV15GAMRole = new GeneXus.Programs.genexussecurity.SdtGAMRole(context);
         GridwwContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridww_Linesclass = "";
         GridwwColumn = new GXWebColumn();
         AV18Name = "";
         AV12Dsc = "";
         AV6Access = "";
         AV16Id = "";
         lblTbfirst_Jsonclick = "";
         lblTb1_Jsonclick = "";
         lblTbprev_Jsonclick = "";
         lblTb2_Jsonclick = "";
         lblTbnext_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV22PermissionFilter = new GeneXus.Programs.genexussecurity.SdtGAMPermissionFilter(context);
         AV32GXV3 = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMPermission>( context, "GeneXus.Programs.genexussecurity.SdtGAMPermission", "GeneXus.Programs");
         AV14Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV19Permission = new GeneXus.Programs.genexussecurity.SdtGAMPermission(context);
         GridwwRow = new GXWebRow();
         AV21PermissionAdd = new GeneXus.Programs.genexussecurity.SdtGAMPermission(context);
         AV13Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         GXCCtl = "";
         ROClassString = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamexamplerolepermissionselect__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamexamplerolepermissionselect__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavCtlname_Enabled = 0;
         edtavCtlname2_Enabled = 0;
         edtavName_Enabled = 0;
         edtavDsc_Enabled = 0;
         edtavAppid_Enabled = 0;
         edtavId_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short AV11CurrentPage ;
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
      private short AV23PermissionsXPage ;
      private short nGXWrapped ;
      private short subGridww_Backstyle ;
      private short GRIDWW_nEOF ;
      private int nRC_GXsfl_71 ;
      private int nGXsfl_71_idx=1 ;
      private int edtavSearch_Enabled ;
      private int edtavSearchfilter_Enabled ;
      private int edtavCtlname_Enabled ;
      private int edtavCtlname2_Enabled ;
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavAppid_Enabled ;
      private int edtavId_Enabled ;
      private int subGridww_Selectedindex ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int lblTbfirst_Enabled ;
      private int lblTbprev_Enabled ;
      private int subGridww_Islastpage ;
      private int AV33GXV4 ;
      private int nGXsfl_71_fel_idx=1 ;
      private int AV35GXV5 ;
      private int AV36GXV6 ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private int edtavName_Visible ;
      private int edtavDsc_Visible ;
      private int edtavAppid_Visible ;
      private int edtavId_Visible ;
      private long AV24RoleId ;
      private long AV8ApplicationId ;
      private long wcpOAV24RoleId ;
      private long wcpOAV8ApplicationId ;
      private long AV7AppId ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV10CountPermissions ;
      private String divFilterscontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_71_idx="0001" ;
      private String AV20PermissionAccessType ;
      private String AV9BoolenFilter ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable2_Internalname ;
      private String divTable7_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String bttHide_Class ;
      private String StyleString ;
      private String bttHide_Internalname ;
      private String bttHide_Caption ;
      private String bttHide_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String divTable3_Internalname ;
      private String bttBack_Internalname ;
      private String bttBack_Jsonclick ;
      private String bttAddselected_Internalname ;
      private String bttAddselected_Jsonclick ;
      private String edtavSearch_Internalname ;
      private String edtavSearch_Jsonclick ;
      private String divCellfilters_Internalname ;
      private String divFilterscontainer_Internalname ;
      private String divTable8_Internalname ;
      private String edtavSearchfilter_Internalname ;
      private String edtavSearchfilter_Jsonclick ;
      private String divTable4_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String cmbavPermissionaccesstype_Internalname ;
      private String cmbavPermissionaccesstype_Jsonclick ;
      private String divTable5_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String cmbavBoolenfilter_Internalname ;
      private String cmbavBoolenfilter_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridcell_Class ;
      private String divGridtable_Internalname ;
      private String edtavCtlname_Internalname ;
      private String edtavCtlname2_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String subGridww_Header ;
      private String AV18Name ;
      private String AV12Dsc ;
      private String AV6Access ;
      private String AV16Id ;
      private String divTable1_Internalname ;
      private String lblTbfirst_Internalname ;
      private String lblTbfirst_Jsonclick ;
      private String lblTbfirst_Class ;
      private String lblTb1_Internalname ;
      private String lblTb1_Jsonclick ;
      private String lblTbprev_Internalname ;
      private String lblTbprev_Jsonclick ;
      private String lblTbprev_Class ;
      private String lblTb2_Internalname ;
      private String lblTb2_Jsonclick ;
      private String lblTbnext_Internalname ;
      private String lblTbnext_Jsonclick ;
      private String lblTbnext_Class ;
      private String cmbavCurrentpage_Internalname ;
      private String cmbavCurrentpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavSelect_Internalname ;
      private String edtavName_Internalname ;
      private String edtavDsc_Internalname ;
      private String cmbavAccess_Internalname ;
      private String edtavAppid_Internalname ;
      private String edtavId_Internalname ;
      private String sGXsfl_71_fel_idx="0001" ;
      private String GXCCtl ;
      private String ROClassString ;
      private String edtavName_Jsonclick ;
      private String edtavDsc_Jsonclick ;
      private String cmbavAccess_Jsonclick ;
      private String edtavAppid_Jsonclick ;
      private String edtavId_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV17isOK ;
      private bool wbLoad ;
      private bool AV27Select ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_71_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String AV25Search ;
      private String AV26SearchFilter ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private long aP0_RoleId ;
      private long aP1_ApplicationId ;
      private GXCombobox cmbavPermissionaccesstype ;
      private GXCombobox cmbavBoolenfilter ;
      private GXCheckbox chkavSelect ;
      private GXCombobox cmbavAccess ;
      private GXCombobox cmbavCurrentpage ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV14Errors ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMPermission> AV32GXV3 ;
      private GXWebForm Form ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplication AV5GAMApplication ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV13Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMRole AV15GAMRole ;
      private GeneXus.Programs.genexussecurity.SdtGAMPermission AV19Permission ;
      private GeneXus.Programs.genexussecurity.SdtGAMPermission AV21PermissionAdd ;
      private GeneXus.Programs.genexussecurity.SdtGAMPermissionFilter AV22PermissionFilter ;
   }

   public class gamexamplerolepermissionselect__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamexamplerolepermissionselect__default : DataStoreHelperBase, IDataStoreHelper
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
