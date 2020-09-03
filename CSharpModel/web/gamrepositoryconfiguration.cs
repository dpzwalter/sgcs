/*
               File: GAMRepositoryConfiguration
        Description: Repository configuration
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:8:1.32
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
   public class gamrepositoryconfiguration : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamrepositoryconfiguration( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamrepositoryconfiguration( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_pId )
      {
         this.AV32pId = aP0_pId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavDefaultauthtypename = new GXCombobox();
         chkavSessionexpiresonipchange = new GXCheckbox();
         chkavAllowoauthaccess = new GXCheckbox();
         cmbavDefaultsecuritypolicyid = new GXCombobox();
         cmbavLogoutbehavior = new GXCombobox();
         cmbavDefaultroleid = new GXCombobox();
         cmbavEnabletracing = new GXCombobox();
         chkavEnableworkingasgammanagerrepo = new GXCheckbox();
         cmbavUseridentification = new GXCombobox();
         cmbavUseractivationmethod = new GXCombobox();
         chkavUseremailisunique = new GXCheckbox();
         chkavRequiredemail = new GXCheckbox();
         chkavRequiredpassword = new GXCheckbox();
         chkavRequiredfirstname = new GXCheckbox();
         chkavRequiredlastname = new GXCheckbox();
         cmbavGeneratesessionstatistics = new GXCombobox();
         chkavGiveanonymoussession = new GXCheckbox();
         cmbavUserremembermetype = new GXCombobox();
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
               AV32pId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV32pId", StringUtil.LTrimStr( (decimal)(AV32pId), 12, 0));
               AssignAttri("", false, "gxhash_vPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV32pId), "ZZZZZZZZZZZ9"), context));
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
         PA1L2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1L2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020415118181", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamrepositoryconfiguration.aspx") + "?" + UrlEncode("" +AV32pId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECURITYADMINISTRATOREMAIL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV41SecurityAdministratorEmail, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vCANREGISTERUSERS", GetSecureSignedToken( "", AV8CanRegisterUsers, context));
         GxWebStd.gx_hidden_field( context, "gxhash_vPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV32pId), "ZZZZZZZZZZZ9"), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", "hsh"+"GAMRepositoryConfiguration");
         forbiddenHiddens.Add("Id", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("gamrepositoryconfiguration:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vSECURITYADMINISTRATOREMAIL", AV41SecurityAdministratorEmail);
         GxWebStd.gx_hidden_field( context, "gxhash_vSECURITYADMINISTRATOREMAIL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV41SecurityAdministratorEmail, "")), context));
         GxWebStd.gx_boolean_hidden_field( context, "vCANREGISTERUSERS", AV8CanRegisterUsers);
         GxWebStd.gx_hidden_field( context, "gxhash_vCANREGISTERUSERS", GetSecureSignedToken( "", AV8CanRegisterUsers, context));
         GxWebStd.gx_hidden_field( context, "vPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV32pId), 12, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV32pId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "TAB1_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab1_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB1_Class", StringUtil.RTrim( Tab1_Class));
         GxWebStd.gx_hidden_field( context, "TAB1_Historymanagement", StringUtil.BoolToStr( Tab1_Historymanagement));
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
            WE1L2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1L2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gamrepositoryconfiguration.aspx") + "?" + UrlEncode("" +AV32pId) ;
      }

      public override String GetPgmname( )
      {
         return "GAMRepositoryConfiguration" ;
      }

      public override String GetPgmdesc( )
      {
         return "Repository configuration " ;
      }

      protected void WB1L0( )
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
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5 col-sm-6 col-md-offset-1 col-lg-3 col-lg-offset-2", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Repository Configuration", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 col-sm-6 col-md-3", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-10 col-md-offset-1 col-lg-8 col-lg-offset-2", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTab1.SetProperty("PageCount", Tab1_Pagecount);
            ucTab1.SetProperty("Class", Tab1_Class);
            ucTab1.SetProperty("HistoryManagement", Tab1_Historymanagement);
            ucTab1.Render(context, "tab", Tab1_Internalname, "TAB1Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavId_Internalname, "Id", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23Id), 12, 0, ".", "")), ((edtavId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavId_Enabled, 0, "number", "1", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMKeyNumLong", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGuid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGuid_Internalname, "GUID", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGuid_Internalname, StringUtil.RTrim( AV22GUID), StringUtil.RTrim( context.localUtil.Format( AV22GUID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGuid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGuid_Enabled, 0, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavNamespace_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavNamespace_Internalname, "Namespace", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNamespace_Internalname, StringUtil.RTrim( AV31NameSpace), StringUtil.RTrim( context.localUtil.Format( AV31NameSpace, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNamespace_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavNamespace_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMRepositoryNameSpace", "left", true, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavName_Internalname, "Name", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV30Name), StringUtil.RTrim( context.localUtil.Format( AV30Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavName_Enabled, 0, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDsc_Internalname, "Description", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDsc_Internalname, StringUtil.RTrim( AV12Dsc), StringUtil.RTrim( context.localUtil.Format( AV12Dsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDsc_Enabled, 0, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDefaultauthtypenamecell_Internalname, divDefaultauthtypenamecell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavDefaultauthtypename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDefaultauthtypename_Internalname, "Default authentication type", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDefaultauthtypename, cmbavDefaultauthtypename_Internalname, StringUtil.RTrim( AV9DefaultAuthTypeName), 1, cmbavDefaultauthtypename_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavDefaultauthtypename.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavDefaultauthtypename.CurrentValue = StringUtil.RTrim( AV9DefaultAuthTypeName);
            AssignProp("", false, cmbavDefaultauthtypename_Internalname, "Values", (String)(cmbavDefaultauthtypename.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavSessionexpiresonipchange_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavSessionexpiresonipchange_Internalname, "GAM Session expires on IP change?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavSessionexpiresonipchange_Internalname, StringUtil.BoolToStr( AV44SessionExpiresOnIPChange), "", "GAM Session expires on IP change?", 1, chkavSessionexpiresonipchange.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(54, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,54);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavAllowoauthaccess_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavAllowoauthaccess_Internalname, "Allow oauth access (Smart Devices)", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavAllowoauthaccess_Internalname, StringUtil.BoolToStr( AV5AllowOauthAccess), "", "Allow oauth access (Smart Devices)", 1, chkavAllowoauthaccess.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(59, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,59);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDefaultsecuritypolicyidcell_Internalname, divDefaultsecuritypolicyidcell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavDefaultsecuritypolicyid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDefaultsecuritypolicyid_Internalname, "Repository default security policy", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDefaultsecuritypolicyid, cmbavDefaultsecuritypolicyid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV11DefaultSecurityPolicyId), 9, 0)), 1, cmbavDefaultsecuritypolicyid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavDefaultsecuritypolicyid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,64);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavDefaultsecuritypolicyid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV11DefaultSecurityPolicyId), 9, 0));
            AssignProp("", false, cmbavDefaultsecuritypolicyid_Internalname, "Values", (String)(cmbavDefaultsecuritypolicyid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSsobehaviorcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavLogoutbehavior_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavLogoutbehavior_Internalname, "GAM Remote logout behavior", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavLogoutbehavior, cmbavLogoutbehavior_Internalname, StringUtil.RTrim( AV28LogoutBehavior), 1, cmbavLogoutbehavior_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavLogoutbehavior.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,69);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavLogoutbehavior.CurrentValue = StringUtil.RTrim( AV28LogoutBehavior);
            AssignProp("", false, cmbavLogoutbehavior_Internalname, "Values", (String)(cmbavLogoutbehavior.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDefaultroleidcell_Internalname, divDefaultroleidcell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavDefaultroleid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDefaultroleid_Internalname, "Repository default role", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDefaultroleid, cmbavDefaultroleid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV10DefaultRoleId), 12, 0)), 1, cmbavDefaultroleid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavDefaultroleid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,74);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavDefaultroleid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10DefaultRoleId), 12, 0));
            AssignProp("", false, cmbavDefaultroleid_Internalname, "Values", (String)(cmbavDefaultroleid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavEnabletracing_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavEnabletracing_Internalname, "Enable tracing", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavEnabletracing, cmbavEnabletracing_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV13EnableTracing), 4, 0)), 1, cmbavEnabletracing_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavEnabletracing.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,79);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavEnabletracing.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV13EnableTracing), 4, 0));
            AssignProp("", false, cmbavEnabletracing_Internalname, "Values", (String)(cmbavEnabletracing.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavEnableworkingasgammanagerrepo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavEnableworkingasgammanagerrepo_Internalname, "Enable working as GAMManager repository", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavEnableworkingasgammanagerrepo_Internalname, StringUtil.BoolToStr( AV14EnableWorkingAsGAMManagerRepo), "", "Enable working as GAMManager repository", 1, chkavEnableworkingasgammanagerrepo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(84, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,84);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblUsers_title_Internalname, "Users", "", "", lblUsers_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Users") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage2table_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavUseridentification_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavUseridentification_Internalname, "User identification by", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavUseridentification, cmbavUseridentification_Internalname, StringUtil.RTrim( AV48UserIdentification), 1, cmbavUseridentification_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavUseridentification.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,94);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavUseridentification.CurrentValue = StringUtil.RTrim( AV48UserIdentification);
            AssignProp("", false, cmbavUseridentification_Internalname, "Values", (String)(cmbavUseridentification.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavUseractivationmethod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavUseractivationmethod_Internalname, "User activation method", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavUseractivationmethod, cmbavUseractivationmethod_Internalname, StringUtil.RTrim( AV45UserActivationMethod), 1, cmbavUseractivationmethod_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavUseractivationmethod.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,99);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavUseractivationmethod.CurrentValue = StringUtil.RTrim( AV45UserActivationMethod);
            AssignProp("", false, cmbavUseractivationmethod_Internalname, "Values", (String)(cmbavUseractivationmethod.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserautomaticactivationtimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserautomaticactivationtimeout_Internalname, "User automatic activation timeout  (hours)", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserautomaticactivationtimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV46UserAutomaticActivationTimeout), 4, 0, ".", "")), ((edtavUserautomaticactivationtimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV46UserAutomaticActivationTimeout), "ZZZ9")) : context.localUtil.Format( (decimal)(AV46UserAutomaticActivationTimeout), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserautomaticactivationtimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserautomaticactivationtimeout_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUseremailisunique_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUseremailisunique_Internalname, "User email is unique?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUseremailisunique_Internalname, StringUtil.BoolToStr( AV47UserEmailisUnique), "", "User email is unique?", 1, chkavUseremailisunique.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(109, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,109);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavRequiredemail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRequiredemail_Internalname, "Required email?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRequiredemail_Internalname, StringUtil.BoolToStr( AV35RequiredEmail), "", "Required email?", 1, chkavRequiredemail.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(114, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,114);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavRequiredpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRequiredpassword_Internalname, "Required password?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRequiredpassword_Internalname, StringUtil.BoolToStr( AV38RequiredPassword), "", "Required password?", 1, chkavRequiredpassword.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(119, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,119);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavRequiredfirstname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRequiredfirstname_Internalname, "Required first name?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRequiredfirstname_Internalname, StringUtil.BoolToStr( AV36RequiredFirstName), "", "Required first name?", 1, chkavRequiredfirstname.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(124, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,124);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavRequiredlastname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRequiredlastname_Internalname, "Required last name?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRequiredlastname_Internalname, StringUtil.BoolToStr( AV37RequiredLastName), "", "Required last name?", 1, chkavRequiredlastname.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(129, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,129);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSession_title_Internalname, "Session", "", "", lblSession_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Session") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage3table_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavGeneratesessionstatistics_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavGeneratesessionstatistics_Internalname, "Generate session statistics?", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavGeneratesessionstatistics, cmbavGeneratesessionstatistics_Internalname, StringUtil.RTrim( AV20GenerateSessionStatistics), 1, cmbavGeneratesessionstatistics_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavGeneratesessionstatistics.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,139);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavGeneratesessionstatistics.CurrentValue = StringUtil.RTrim( AV20GenerateSessionStatistics);
            AssignProp("", false, cmbavGeneratesessionstatistics_Internalname, "Values", (String)(cmbavGeneratesessionstatistics.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUsersessioncachetimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUsersessioncachetimeout_Internalname, "User session cache timeout (seconds)", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 144,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsersessioncachetimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV52UserSessionCacheTimeout), 6, 0, ".", "")), ((edtavUsersessioncachetimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV52UserSessionCacheTimeout), "ZZZZZ9")) : context.localUtil.Format( (decimal)(AV52UserSessionCacheTimeout), "ZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,144);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsersessioncachetimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUsersessioncachetimeout_Enabled, 0, "number", "1", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavGiveanonymoussession_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavGiveanonymoussession_Internalname, "Give anonymous session?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 149,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavGiveanonymoussession_Internalname, StringUtil.BoolToStr( AV21GiveAnonymousSession), "", "Give anonymous session?", 1, chkavGiveanonymoussession.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(149, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,149);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavLoginattemptstolocksession_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavLoginattemptstolocksession_Internalname, "Login attempts to lock session", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 154,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavLoginattemptstolocksession_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26LoginAttemptsToLockSession), 2, 0, ".", "")), ((edtavLoginattemptstolocksession_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26LoginAttemptsToLockSession), "Z9")) : context.localUtil.Format( (decimal)(AV26LoginAttemptsToLockSession), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,154);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavLoginattemptstolocksession_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavLoginattemptstolocksession_Enabled, 0, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamunblockusertimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamunblockusertimeout_Internalname, "Unblock user timeout (minutes)", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 159,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamunblockusertimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19GAMUnblockUserTimeout), 4, 0, ".", "")), ((edtavGamunblockusertimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19GAMUnblockUserTimeout), "ZZZ9")) : context.localUtil.Format( (decimal)(AV19GAMUnblockUserTimeout), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,159);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamunblockusertimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGamunblockusertimeout_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavLoginattemptstolockuser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavLoginattemptstolockuser_Internalname, "Login retries to lock user", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 164,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavLoginattemptstolockuser_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27LoginAttemptsToLockUser), 2, 0, ".", "")), ((edtavLoginattemptstolockuser_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV27LoginAttemptsToLockUser), "Z9")) : context.localUtil.Format( (decimal)(AV27LoginAttemptsToLockUser), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,164);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavLoginattemptstolockuser_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavLoginattemptstolockuser_Enabled, 0, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavMinimumamountcharactersinlogin_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavMinimumamountcharactersinlogin_Internalname, "Minimum amount characters in login", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 169,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMinimumamountcharactersinlogin_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29MinimumAmountCharactersInLogin), 2, 0, ".", "")), ((edtavMinimumamountcharactersinlogin_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV29MinimumAmountCharactersInLogin), "Z9")) : context.localUtil.Format( (decimal)(AV29MinimumAmountCharactersInLogin), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,169);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMinimumamountcharactersinlogin_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavMinimumamountcharactersinlogin_Enabled, 0, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserrecoverypasswordkeytimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserrecoverypasswordkeytimeout_Internalname, "User recovery password key timeout (minutes)", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 174,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserrecoverypasswordkeytimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV49UserRecoveryPasswordKeyTimeOut), 4, 0, ".", "")), ((edtavUserrecoverypasswordkeytimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV49UserRecoveryPasswordKeyTimeOut), "ZZZ9")) : context.localUtil.Format( (decimal)(AV49UserRecoveryPasswordKeyTimeOut), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,174);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserrecoverypasswordkeytimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserrecoverypasswordkeytimeout_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserremembermetimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserremembermetimeout_Internalname, "User remember me timeout (days)", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 179,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserremembermetimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV50UserRememberMeTimeOut), 4, 0, ".", "")), ((edtavUserremembermetimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV50UserRememberMeTimeOut), "ZZZ9")) : context.localUtil.Format( (decimal)(AV50UserRememberMeTimeOut), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,179);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserremembermetimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserremembermetimeout_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavUserremembermetype_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavUserremembermetype_Internalname, "User remember me type", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 184,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavUserremembermetype, cmbavUserremembermetype_Internalname, StringUtil.RTrim( AV51UserRememberMeType), 1, cmbavUserremembermetype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavUserremembermetype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,184);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavUserremembermetype.CurrentValue = StringUtil.RTrim( AV51UserRememberMeType);
            AssignProp("", false, cmbavUserremembermetype_Internalname, "Values", (String)(cmbavUserremembermetype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavRepositorycachetimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositorycachetimeout_Internalname, "Repository cache timeout (minutes)", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 189,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositorycachetimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34RepositoryCacheTimeout), 6, 0, ".", "")), ((edtavRepositorycachetimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV34RepositoryCacheTimeout), "ZZZZZ9")) : context.localUtil.Format( (decimal)(AV34RepositoryCacheTimeout), "ZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,189);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositorycachetimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositorycachetimeout_Enabled, 0, "number", "1", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 194,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttConfirm_Internalname, "", "Confirm", bttConfirm_Jsonclick, 5, "Confirm", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1L2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Repository configuration ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1L0( ) ;
      }

      protected void WS1L2( )
      {
         START1L2( ) ;
         EVT1L2( ) ;
      }

      protected void EVT1L2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E111L2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E121L2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E131L2 ();
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
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1L2( )
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

      protected void PA1L2( )
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
               GX_FocusControl = edtavId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
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
         if ( cmbavDefaultauthtypename.ItemCount > 0 )
         {
            AV9DefaultAuthTypeName = cmbavDefaultauthtypename.getValidValue(AV9DefaultAuthTypeName);
            AssignAttri("", false, "AV9DefaultAuthTypeName", AV9DefaultAuthTypeName);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDefaultauthtypename.CurrentValue = StringUtil.RTrim( AV9DefaultAuthTypeName);
            AssignProp("", false, cmbavDefaultauthtypename_Internalname, "Values", cmbavDefaultauthtypename.ToJavascriptSource(), true);
         }
         AV44SessionExpiresOnIPChange = StringUtil.StrToBool( StringUtil.BoolToStr( AV44SessionExpiresOnIPChange));
         AssignAttri("", false, "AV44SessionExpiresOnIPChange", AV44SessionExpiresOnIPChange);
         AV5AllowOauthAccess = StringUtil.StrToBool( StringUtil.BoolToStr( AV5AllowOauthAccess));
         AssignAttri("", false, "AV5AllowOauthAccess", AV5AllowOauthAccess);
         if ( cmbavDefaultsecuritypolicyid.ItemCount > 0 )
         {
            AV11DefaultSecurityPolicyId = (int)(NumberUtil.Val( cmbavDefaultsecuritypolicyid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV11DefaultSecurityPolicyId), 9, 0))), "."));
            AssignAttri("", false, "AV11DefaultSecurityPolicyId", StringUtil.LTrimStr( (decimal)(AV11DefaultSecurityPolicyId), 9, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDefaultsecuritypolicyid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV11DefaultSecurityPolicyId), 9, 0));
            AssignProp("", false, cmbavDefaultsecuritypolicyid_Internalname, "Values", cmbavDefaultsecuritypolicyid.ToJavascriptSource(), true);
         }
         if ( cmbavLogoutbehavior.ItemCount > 0 )
         {
            AV28LogoutBehavior = cmbavLogoutbehavior.getValidValue(AV28LogoutBehavior);
            AssignAttri("", false, "AV28LogoutBehavior", AV28LogoutBehavior);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavLogoutbehavior.CurrentValue = StringUtil.RTrim( AV28LogoutBehavior);
            AssignProp("", false, cmbavLogoutbehavior_Internalname, "Values", cmbavLogoutbehavior.ToJavascriptSource(), true);
         }
         if ( cmbavDefaultroleid.ItemCount > 0 )
         {
            AV10DefaultRoleId = (long)(NumberUtil.Val( cmbavDefaultroleid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10DefaultRoleId), 12, 0))), "."));
            AssignAttri("", false, "AV10DefaultRoleId", StringUtil.LTrimStr( (decimal)(AV10DefaultRoleId), 12, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDefaultroleid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10DefaultRoleId), 12, 0));
            AssignProp("", false, cmbavDefaultroleid_Internalname, "Values", cmbavDefaultroleid.ToJavascriptSource(), true);
         }
         if ( cmbavEnabletracing.ItemCount > 0 )
         {
            AV13EnableTracing = (short)(NumberUtil.Val( cmbavEnabletracing.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV13EnableTracing), 4, 0))), "."));
            AssignAttri("", false, "AV13EnableTracing", StringUtil.LTrimStr( (decimal)(AV13EnableTracing), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavEnabletracing.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV13EnableTracing), 4, 0));
            AssignProp("", false, cmbavEnabletracing_Internalname, "Values", cmbavEnabletracing.ToJavascriptSource(), true);
         }
         AV14EnableWorkingAsGAMManagerRepo = StringUtil.StrToBool( StringUtil.BoolToStr( AV14EnableWorkingAsGAMManagerRepo));
         AssignAttri("", false, "AV14EnableWorkingAsGAMManagerRepo", AV14EnableWorkingAsGAMManagerRepo);
         if ( cmbavUseridentification.ItemCount > 0 )
         {
            AV48UserIdentification = cmbavUseridentification.getValidValue(AV48UserIdentification);
            AssignAttri("", false, "AV48UserIdentification", AV48UserIdentification);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavUseridentification.CurrentValue = StringUtil.RTrim( AV48UserIdentification);
            AssignProp("", false, cmbavUseridentification_Internalname, "Values", cmbavUseridentification.ToJavascriptSource(), true);
         }
         if ( cmbavUseractivationmethod.ItemCount > 0 )
         {
            AV45UserActivationMethod = cmbavUseractivationmethod.getValidValue(AV45UserActivationMethod);
            AssignAttri("", false, "AV45UserActivationMethod", AV45UserActivationMethod);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavUseractivationmethod.CurrentValue = StringUtil.RTrim( AV45UserActivationMethod);
            AssignProp("", false, cmbavUseractivationmethod_Internalname, "Values", cmbavUseractivationmethod.ToJavascriptSource(), true);
         }
         AV47UserEmailisUnique = StringUtil.StrToBool( StringUtil.BoolToStr( AV47UserEmailisUnique));
         AssignAttri("", false, "AV47UserEmailisUnique", AV47UserEmailisUnique);
         AV35RequiredEmail = StringUtil.StrToBool( StringUtil.BoolToStr( AV35RequiredEmail));
         AssignAttri("", false, "AV35RequiredEmail", AV35RequiredEmail);
         AV38RequiredPassword = StringUtil.StrToBool( StringUtil.BoolToStr( AV38RequiredPassword));
         AssignAttri("", false, "AV38RequiredPassword", AV38RequiredPassword);
         AV36RequiredFirstName = StringUtil.StrToBool( StringUtil.BoolToStr( AV36RequiredFirstName));
         AssignAttri("", false, "AV36RequiredFirstName", AV36RequiredFirstName);
         AV37RequiredLastName = StringUtil.StrToBool( StringUtil.BoolToStr( AV37RequiredLastName));
         AssignAttri("", false, "AV37RequiredLastName", AV37RequiredLastName);
         if ( cmbavGeneratesessionstatistics.ItemCount > 0 )
         {
            AV20GenerateSessionStatistics = cmbavGeneratesessionstatistics.getValidValue(AV20GenerateSessionStatistics);
            AssignAttri("", false, "AV20GenerateSessionStatistics", AV20GenerateSessionStatistics);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavGeneratesessionstatistics.CurrentValue = StringUtil.RTrim( AV20GenerateSessionStatistics);
            AssignProp("", false, cmbavGeneratesessionstatistics_Internalname, "Values", cmbavGeneratesessionstatistics.ToJavascriptSource(), true);
         }
         AV21GiveAnonymousSession = StringUtil.StrToBool( StringUtil.BoolToStr( AV21GiveAnonymousSession));
         AssignAttri("", false, "AV21GiveAnonymousSession", AV21GiveAnonymousSession);
         if ( cmbavUserremembermetype.ItemCount > 0 )
         {
            AV51UserRememberMeType = cmbavUserremembermetype.getValidValue(AV51UserRememberMeType);
            AssignAttri("", false, "AV51UserRememberMeType", AV51UserRememberMeType);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavUserremembermetype.CurrentValue = StringUtil.RTrim( AV51UserRememberMeType);
            AssignProp("", false, cmbavUserremembermetype_Internalname, "Values", cmbavUserremembermetype.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1L2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), true);
         edtavGuid_Enabled = 0;
         AssignProp("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGuid_Enabled), 5, 0), true);
         edtavNamespace_Enabled = 0;
         AssignProp("", false, edtavNamespace_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavNamespace_Enabled), 5, 0), true);
      }

      protected void RF1L2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E131L2 ();
            WB1L0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1L2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vSECURITYADMINISTRATOREMAIL", AV41SecurityAdministratorEmail);
         GxWebStd.gx_hidden_field( context, "gxhash_vSECURITYADMINISTRATOREMAIL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV41SecurityAdministratorEmail, "")), context));
         GxWebStd.gx_boolean_hidden_field( context, "vCANREGISTERUSERS", AV8CanRegisterUsers);
         GxWebStd.gx_hidden_field( context, "gxhash_vCANREGISTERUSERS", GetSecureSignedToken( "", AV8CanRegisterUsers, context));
      }

      protected void STRUP1L0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), true);
         edtavGuid_Enabled = 0;
         AssignProp("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGuid_Enabled), 5, 0), true);
         edtavNamespace_Enabled = 0;
         AssignProp("", false, edtavNamespace_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavNamespace_Enabled), 5, 0), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111L2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Tab1_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TAB1_Pagecount"), ".", ","));
            Tab1_Class = cgiGet( "TAB1_Class");
            Tab1_Historymanagement = StringUtil.StrToBool( cgiGet( "TAB1_Historymanagement"));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ",") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vID");
               GX_FocusControl = edtavId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV23Id = 0;
               AssignAttri("", false, "AV23Id", StringUtil.LTrimStr( (decimal)(AV23Id), 12, 0));
               AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
            }
            else
            {
               AV23Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ","));
               AssignAttri("", false, "AV23Id", StringUtil.LTrimStr( (decimal)(AV23Id), 12, 0));
               AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
            }
            AV22GUID = cgiGet( edtavGuid_Internalname);
            AssignAttri("", false, "AV22GUID", AV22GUID);
            AV31NameSpace = cgiGet( edtavNamespace_Internalname);
            AssignAttri("", false, "AV31NameSpace", AV31NameSpace);
            AV30Name = cgiGet( edtavName_Internalname);
            AssignAttri("", false, "AV30Name", AV30Name);
            AV12Dsc = cgiGet( edtavDsc_Internalname);
            AssignAttri("", false, "AV12Dsc", AV12Dsc);
            cmbavDefaultauthtypename.CurrentValue = cgiGet( cmbavDefaultauthtypename_Internalname);
            AV9DefaultAuthTypeName = cgiGet( cmbavDefaultauthtypename_Internalname);
            AssignAttri("", false, "AV9DefaultAuthTypeName", AV9DefaultAuthTypeName);
            AV44SessionExpiresOnIPChange = StringUtil.StrToBool( cgiGet( chkavSessionexpiresonipchange_Internalname));
            AssignAttri("", false, "AV44SessionExpiresOnIPChange", AV44SessionExpiresOnIPChange);
            AV5AllowOauthAccess = StringUtil.StrToBool( cgiGet( chkavAllowoauthaccess_Internalname));
            AssignAttri("", false, "AV5AllowOauthAccess", AV5AllowOauthAccess);
            cmbavDefaultsecuritypolicyid.CurrentValue = cgiGet( cmbavDefaultsecuritypolicyid_Internalname);
            AV11DefaultSecurityPolicyId = (int)(NumberUtil.Val( cgiGet( cmbavDefaultsecuritypolicyid_Internalname), "."));
            AssignAttri("", false, "AV11DefaultSecurityPolicyId", StringUtil.LTrimStr( (decimal)(AV11DefaultSecurityPolicyId), 9, 0));
            cmbavLogoutbehavior.CurrentValue = cgiGet( cmbavLogoutbehavior_Internalname);
            AV28LogoutBehavior = cgiGet( cmbavLogoutbehavior_Internalname);
            AssignAttri("", false, "AV28LogoutBehavior", AV28LogoutBehavior);
            cmbavDefaultroleid.CurrentValue = cgiGet( cmbavDefaultroleid_Internalname);
            AV10DefaultRoleId = (long)(NumberUtil.Val( cgiGet( cmbavDefaultroleid_Internalname), "."));
            AssignAttri("", false, "AV10DefaultRoleId", StringUtil.LTrimStr( (decimal)(AV10DefaultRoleId), 12, 0));
            cmbavEnabletracing.CurrentValue = cgiGet( cmbavEnabletracing_Internalname);
            AV13EnableTracing = (short)(NumberUtil.Val( cgiGet( cmbavEnabletracing_Internalname), "."));
            AssignAttri("", false, "AV13EnableTracing", StringUtil.LTrimStr( (decimal)(AV13EnableTracing), 4, 0));
            AV14EnableWorkingAsGAMManagerRepo = StringUtil.StrToBool( cgiGet( chkavEnableworkingasgammanagerrepo_Internalname));
            AssignAttri("", false, "AV14EnableWorkingAsGAMManagerRepo", AV14EnableWorkingAsGAMManagerRepo);
            cmbavUseridentification.CurrentValue = cgiGet( cmbavUseridentification_Internalname);
            AV48UserIdentification = cgiGet( cmbavUseridentification_Internalname);
            AssignAttri("", false, "AV48UserIdentification", AV48UserIdentification);
            cmbavUseractivationmethod.CurrentValue = cgiGet( cmbavUseractivationmethod_Internalname);
            AV45UserActivationMethod = cgiGet( cmbavUseractivationmethod_Internalname);
            AssignAttri("", false, "AV45UserActivationMethod", AV45UserActivationMethod);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavUserautomaticactivationtimeout_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavUserautomaticactivationtimeout_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vUSERAUTOMATICACTIVATIONTIMEOUT");
               GX_FocusControl = edtavUserautomaticactivationtimeout_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV46UserAutomaticActivationTimeout = 0;
               AssignAttri("", false, "AV46UserAutomaticActivationTimeout", StringUtil.LTrimStr( (decimal)(AV46UserAutomaticActivationTimeout), 4, 0));
            }
            else
            {
               AV46UserAutomaticActivationTimeout = (short)(context.localUtil.CToN( cgiGet( edtavUserautomaticactivationtimeout_Internalname), ".", ","));
               AssignAttri("", false, "AV46UserAutomaticActivationTimeout", StringUtil.LTrimStr( (decimal)(AV46UserAutomaticActivationTimeout), 4, 0));
            }
            AV47UserEmailisUnique = StringUtil.StrToBool( cgiGet( chkavUseremailisunique_Internalname));
            AssignAttri("", false, "AV47UserEmailisUnique", AV47UserEmailisUnique);
            AV35RequiredEmail = StringUtil.StrToBool( cgiGet( chkavRequiredemail_Internalname));
            AssignAttri("", false, "AV35RequiredEmail", AV35RequiredEmail);
            AV38RequiredPassword = StringUtil.StrToBool( cgiGet( chkavRequiredpassword_Internalname));
            AssignAttri("", false, "AV38RequiredPassword", AV38RequiredPassword);
            AV36RequiredFirstName = StringUtil.StrToBool( cgiGet( chkavRequiredfirstname_Internalname));
            AssignAttri("", false, "AV36RequiredFirstName", AV36RequiredFirstName);
            AV37RequiredLastName = StringUtil.StrToBool( cgiGet( chkavRequiredlastname_Internalname));
            AssignAttri("", false, "AV37RequiredLastName", AV37RequiredLastName);
            cmbavGeneratesessionstatistics.CurrentValue = cgiGet( cmbavGeneratesessionstatistics_Internalname);
            AV20GenerateSessionStatistics = cgiGet( cmbavGeneratesessionstatistics_Internalname);
            AssignAttri("", false, "AV20GenerateSessionStatistics", AV20GenerateSessionStatistics);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavUsersessioncachetimeout_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavUsersessioncachetimeout_Internalname), ".", ",") > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vUSERSESSIONCACHETIMEOUT");
               GX_FocusControl = edtavUsersessioncachetimeout_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV52UserSessionCacheTimeout = 0;
               AssignAttri("", false, "AV52UserSessionCacheTimeout", StringUtil.LTrimStr( (decimal)(AV52UserSessionCacheTimeout), 6, 0));
            }
            else
            {
               AV52UserSessionCacheTimeout = (int)(context.localUtil.CToN( cgiGet( edtavUsersessioncachetimeout_Internalname), ".", ","));
               AssignAttri("", false, "AV52UserSessionCacheTimeout", StringUtil.LTrimStr( (decimal)(AV52UserSessionCacheTimeout), 6, 0));
            }
            AV21GiveAnonymousSession = StringUtil.StrToBool( cgiGet( chkavGiveanonymoussession_Internalname));
            AssignAttri("", false, "AV21GiveAnonymousSession", AV21GiveAnonymousSession);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavLoginattemptstolocksession_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavLoginattemptstolocksession_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vLOGINATTEMPTSTOLOCKSESSION");
               GX_FocusControl = edtavLoginattemptstolocksession_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV26LoginAttemptsToLockSession = 0;
               AssignAttri("", false, "AV26LoginAttemptsToLockSession", StringUtil.LTrimStr( (decimal)(AV26LoginAttemptsToLockSession), 2, 0));
            }
            else
            {
               AV26LoginAttemptsToLockSession = (short)(context.localUtil.CToN( cgiGet( edtavLoginattemptstolocksession_Internalname), ".", ","));
               AssignAttri("", false, "AV26LoginAttemptsToLockSession", StringUtil.LTrimStr( (decimal)(AV26LoginAttemptsToLockSession), 2, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGamunblockusertimeout_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGamunblockusertimeout_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGAMUNBLOCKUSERTIMEOUT");
               GX_FocusControl = edtavGamunblockusertimeout_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19GAMUnblockUserTimeout = 0;
               AssignAttri("", false, "AV19GAMUnblockUserTimeout", StringUtil.LTrimStr( (decimal)(AV19GAMUnblockUserTimeout), 4, 0));
            }
            else
            {
               AV19GAMUnblockUserTimeout = (short)(context.localUtil.CToN( cgiGet( edtavGamunblockusertimeout_Internalname), ".", ","));
               AssignAttri("", false, "AV19GAMUnblockUserTimeout", StringUtil.LTrimStr( (decimal)(AV19GAMUnblockUserTimeout), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavLoginattemptstolockuser_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavLoginattemptstolockuser_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vLOGINATTEMPTSTOLOCKUSER");
               GX_FocusControl = edtavLoginattemptstolockuser_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV27LoginAttemptsToLockUser = 0;
               AssignAttri("", false, "AV27LoginAttemptsToLockUser", StringUtil.LTrimStr( (decimal)(AV27LoginAttemptsToLockUser), 2, 0));
            }
            else
            {
               AV27LoginAttemptsToLockUser = (short)(context.localUtil.CToN( cgiGet( edtavLoginattemptstolockuser_Internalname), ".", ","));
               AssignAttri("", false, "AV27LoginAttemptsToLockUser", StringUtil.LTrimStr( (decimal)(AV27LoginAttemptsToLockUser), 2, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMinimumamountcharactersinlogin_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMinimumamountcharactersinlogin_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMINIMUMAMOUNTCHARACTERSINLOGIN");
               GX_FocusControl = edtavMinimumamountcharactersinlogin_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29MinimumAmountCharactersInLogin = 0;
               AssignAttri("", false, "AV29MinimumAmountCharactersInLogin", StringUtil.LTrimStr( (decimal)(AV29MinimumAmountCharactersInLogin), 2, 0));
            }
            else
            {
               AV29MinimumAmountCharactersInLogin = (short)(context.localUtil.CToN( cgiGet( edtavMinimumamountcharactersinlogin_Internalname), ".", ","));
               AssignAttri("", false, "AV29MinimumAmountCharactersInLogin", StringUtil.LTrimStr( (decimal)(AV29MinimumAmountCharactersInLogin), 2, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavUserrecoverypasswordkeytimeout_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavUserrecoverypasswordkeytimeout_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vUSERRECOVERYPASSWORDKEYTIMEOUT");
               GX_FocusControl = edtavUserrecoverypasswordkeytimeout_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV49UserRecoveryPasswordKeyTimeOut = 0;
               AssignAttri("", false, "AV49UserRecoveryPasswordKeyTimeOut", StringUtil.LTrimStr( (decimal)(AV49UserRecoveryPasswordKeyTimeOut), 4, 0));
            }
            else
            {
               AV49UserRecoveryPasswordKeyTimeOut = (short)(context.localUtil.CToN( cgiGet( edtavUserrecoverypasswordkeytimeout_Internalname), ".", ","));
               AssignAttri("", false, "AV49UserRecoveryPasswordKeyTimeOut", StringUtil.LTrimStr( (decimal)(AV49UserRecoveryPasswordKeyTimeOut), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavUserremembermetimeout_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavUserremembermetimeout_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vUSERREMEMBERMETIMEOUT");
               GX_FocusControl = edtavUserremembermetimeout_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV50UserRememberMeTimeOut = 0;
               AssignAttri("", false, "AV50UserRememberMeTimeOut", StringUtil.LTrimStr( (decimal)(AV50UserRememberMeTimeOut), 4, 0));
            }
            else
            {
               AV50UserRememberMeTimeOut = (short)(context.localUtil.CToN( cgiGet( edtavUserremembermetimeout_Internalname), ".", ","));
               AssignAttri("", false, "AV50UserRememberMeTimeOut", StringUtil.LTrimStr( (decimal)(AV50UserRememberMeTimeOut), 4, 0));
            }
            cmbavUserremembermetype.CurrentValue = cgiGet( cmbavUserremembermetype_Internalname);
            AV51UserRememberMeType = cgiGet( cmbavUserremembermetype_Internalname);
            AssignAttri("", false, "AV51UserRememberMeType", AV51UserRememberMeType);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositorycachetimeout_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositorycachetimeout_Internalname), ".", ",") > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYCACHETIMEOUT");
               GX_FocusControl = edtavRepositorycachetimeout_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV34RepositoryCacheTimeout = 0;
               AssignAttri("", false, "AV34RepositoryCacheTimeout", StringUtil.LTrimStr( (decimal)(AV34RepositoryCacheTimeout), 6, 0));
            }
            else
            {
               AV34RepositoryCacheTimeout = (int)(context.localUtil.CToN( cgiGet( edtavRepositorycachetimeout_Internalname), ".", ","));
               AssignAttri("", false, "AV34RepositoryCacheTimeout", StringUtil.LTrimStr( (decimal)(AV34RepositoryCacheTimeout), 6, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = new GXProperties();
            forbiddenHiddens.Add("hshsalt", "hsh"+"GAMRepositoryConfiguration");
            AV23Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ","));
            AssignAttri("", false, "AV23Id", StringUtil.LTrimStr( (decimal)(AV23Id), 12, 0));
            AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
            forbiddenHiddens.Add("Id", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"));
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
            {
               GXUtil.WriteLog("gamrepositoryconfiguration:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E111L2 ();
         if (returnInSub) return;
      }

      protected void E111L2( )
      {
         /* Start Routine */
         AV24isLoginRepositoryAdm = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).isgamadministrator(out  AV16Errors);
         divDefaultauthtypenamecell_Visible = (!AV24isLoginRepositoryAdm ? 1 : 0);
         AssignProp("", false, divDefaultauthtypenamecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divDefaultauthtypenamecell_Visible), 5, 0), true);
         divDefaultsecuritypolicyidcell_Visible = (!AV24isLoginRepositoryAdm ? 1 : 0);
         AssignProp("", false, divDefaultsecuritypolicyidcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divDefaultsecuritypolicyidcell_Visible), 5, 0), true);
         divDefaultroleidcell_Visible = (!AV24isLoginRepositoryAdm ? 1 : 0);
         AssignProp("", false, divDefaultroleidcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divDefaultroleidcell_Visible), 5, 0), true);
         AV7AuthenticationTypes = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).getenabledauthenticationtypes(AV25Language, out  AV16Errors);
         AV55GXV1 = 1;
         while ( AV55GXV1 <= AV7AuthenticationTypes.Count )
         {
            AV6AuthenticationType = ((GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple)AV7AuthenticationTypes.Item(AV55GXV1));
            cmbavDefaultauthtypename.addItem(AV6AuthenticationType.gxTpr_Name, AV6AuthenticationType.gxTpr_Description, 0);
            AV55GXV1 = (int)(AV55GXV1+1);
         }
         AV42SecurityPolicies = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).getsecuritypolicies(AV18FilterSecPol, out  AV16Errors);
         AV56GXV2 = 1;
         while ( AV56GXV2 <= AV42SecurityPolicies.Count )
         {
            AV43SecurityPolicy = ((GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy)AV42SecurityPolicies.Item(AV56GXV2));
            cmbavDefaultsecuritypolicyid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV43SecurityPolicy.gxTpr_Id), 9, 0)), AV43SecurityPolicy.gxTpr_Name, 0);
            AV56GXV2 = (int)(AV56GXV2+1);
         }
         AV40Roles = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).getroles(AV17FilterRole, out  AV16Errors);
         AV57GXV3 = 1;
         while ( AV57GXV3 <= AV40Roles.Count )
         {
            AV39Role = ((GeneXus.Programs.genexussecurity.SdtGAMRole)AV40Roles.Item(AV57GXV3));
            cmbavDefaultroleid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV39Role.gxTpr_Id), 12, 0)), AV39Role.gxTpr_Name, 0);
            AV57GXV3 = (int)(AV57GXV3+1);
         }
         if ( (0==AV32pId) )
         {
            AV23Id = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).getid();
            AssignAttri("", false, "AV23Id", StringUtil.LTrimStr( (decimal)(AV23Id), 12, 0));
            AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
         }
         else
         {
            AV23Id = AV32pId;
            AssignAttri("", false, "AV23Id", StringUtil.LTrimStr( (decimal)(AV23Id), 12, 0));
            AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
         }
         AV33Repository.load( (int)(AV23Id));
         AssignAttri("", false, "AV23Id", StringUtil.LTrimStr( (decimal)(AV23Id), 12, 0));
         AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
         AV22GUID = AV33Repository.gxTpr_Guid;
         AssignAttri("", false, "AV22GUID", AV22GUID);
         AV31NameSpace = AV33Repository.gxTpr_Namespace;
         AssignAttri("", false, "AV31NameSpace", AV31NameSpace);
         AV30Name = AV33Repository.gxTpr_Name;
         AssignAttri("", false, "AV30Name", AV30Name);
         AV12Dsc = AV33Repository.gxTpr_Description;
         AssignAttri("", false, "AV12Dsc", AV12Dsc);
         AV9DefaultAuthTypeName = AV33Repository.gxTpr_Defaultauthenticationtypename;
         AssignAttri("", false, "AV9DefaultAuthTypeName", AV9DefaultAuthTypeName);
         AV48UserIdentification = AV33Repository.gxTpr_Useridentification;
         AssignAttri("", false, "AV48UserIdentification", AV48UserIdentification);
         AV20GenerateSessionStatistics = AV33Repository.gxTpr_Generatesessionstatistics;
         AssignAttri("", false, "AV20GenerateSessionStatistics", AV20GenerateSessionStatistics);
         AV45UserActivationMethod = AV33Repository.gxTpr_Useractivationmethod;
         AssignAttri("", false, "AV45UserActivationMethod", AV45UserActivationMethod);
         AV46UserAutomaticActivationTimeout = AV33Repository.gxTpr_Userautomaticactivationtimeout;
         AssignAttri("", false, "AV46UserAutomaticActivationTimeout", StringUtil.LTrimStr( (decimal)(AV46UserAutomaticActivationTimeout), 4, 0));
         AV51UserRememberMeType = AV33Repository.gxTpr_Userremembermetype;
         AssignAttri("", false, "AV51UserRememberMeType", AV51UserRememberMeType);
         AV50UserRememberMeTimeOut = AV33Repository.gxTpr_Userremembermetimeout;
         AssignAttri("", false, "AV50UserRememberMeTimeOut", StringUtil.LTrimStr( (decimal)(AV50UserRememberMeTimeOut), 4, 0));
         AV49UserRecoveryPasswordKeyTimeOut = AV33Repository.gxTpr_Userrecoverypasswordkeytimeout;
         AssignAttri("", false, "AV49UserRecoveryPasswordKeyTimeOut", StringUtil.LTrimStr( (decimal)(AV49UserRecoveryPasswordKeyTimeOut), 4, 0));
         AV29MinimumAmountCharactersInLogin = AV33Repository.gxTpr_Minimumamountcharactersinlogin;
         AssignAttri("", false, "AV29MinimumAmountCharactersInLogin", StringUtil.LTrimStr( (decimal)(AV29MinimumAmountCharactersInLogin), 2, 0));
         AV27LoginAttemptsToLockUser = AV33Repository.gxTpr_Loginattemptstolockuser;
         AssignAttri("", false, "AV27LoginAttemptsToLockUser", StringUtil.LTrimStr( (decimal)(AV27LoginAttemptsToLockUser), 2, 0));
         AV19GAMUnblockUserTimeout = AV33Repository.gxTpr_Gamunblockusertimeout;
         AssignAttri("", false, "AV19GAMUnblockUserTimeout", StringUtil.LTrimStr( (decimal)(AV19GAMUnblockUserTimeout), 4, 0));
         AV26LoginAttemptsToLockSession = AV33Repository.gxTpr_Loginattemptstolocksession;
         AssignAttri("", false, "AV26LoginAttemptsToLockSession", StringUtil.LTrimStr( (decimal)(AV26LoginAttemptsToLockSession), 2, 0));
         AV52UserSessionCacheTimeout = AV33Repository.gxTpr_Usersessioncachetimeout;
         AssignAttri("", false, "AV52UserSessionCacheTimeout", StringUtil.LTrimStr( (decimal)(AV52UserSessionCacheTimeout), 6, 0));
         AV34RepositoryCacheTimeout = AV33Repository.gxTpr_Cachetimeout;
         AssignAttri("", false, "AV34RepositoryCacheTimeout", StringUtil.LTrimStr( (decimal)(AV34RepositoryCacheTimeout), 6, 0));
         AV28LogoutBehavior = AV33Repository.gxTpr_Gamremotelogoutbehavior;
         AssignAttri("", false, "AV28LogoutBehavior", AV28LogoutBehavior);
         AV41SecurityAdministratorEmail = AV33Repository.gxTpr_Securityadministratoremail;
         AssignAttri("", false, "AV41SecurityAdministratorEmail", AV41SecurityAdministratorEmail);
         AssignAttri("", false, "gxhash_vSECURITYADMINISTRATOREMAIL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV41SecurityAdministratorEmail, "")), context));
         AV21GiveAnonymousSession = AV33Repository.gxTpr_Giveanonymoussession;
         AssignAttri("", false, "AV21GiveAnonymousSession", AV21GiveAnonymousSession);
         AV8CanRegisterUsers = AV33Repository.gxTpr_Canregisterusers;
         AssignAttri("", false, "AV8CanRegisterUsers", AV8CanRegisterUsers);
         AssignAttri("", false, "gxhash_vCANREGISTERUSERS", GetSecureSignedToken( "", AV8CanRegisterUsers, context));
         AV47UserEmailisUnique = AV33Repository.gxTpr_Useremailisunique;
         AssignAttri("", false, "AV47UserEmailisUnique", AV47UserEmailisUnique);
         AV11DefaultSecurityPolicyId = AV33Repository.gxTpr_Defaultsecuritypolicyid;
         AssignAttri("", false, "AV11DefaultSecurityPolicyId", StringUtil.LTrimStr( (decimal)(AV11DefaultSecurityPolicyId), 9, 0));
         AV10DefaultRoleId = AV33Repository.gxTpr_Defaultroleid;
         AssignAttri("", false, "AV10DefaultRoleId", StringUtil.LTrimStr( (decimal)(AV10DefaultRoleId), 12, 0));
         AV14EnableWorkingAsGAMManagerRepo = AV33Repository.gxTpr_Enableworkingasgammanagerrepository;
         AssignAttri("", false, "AV14EnableWorkingAsGAMManagerRepo", AV14EnableWorkingAsGAMManagerRepo);
         AV13EnableTracing = AV33Repository.gxTpr_Enabletracing;
         AssignAttri("", false, "AV13EnableTracing", StringUtil.LTrimStr( (decimal)(AV13EnableTracing), 4, 0));
         AV5AllowOauthAccess = AV33Repository.gxTpr_Allowoauthaccess;
         AssignAttri("", false, "AV5AllowOauthAccess", AV5AllowOauthAccess);
         AV44SessionExpiresOnIPChange = AV33Repository.gxTpr_Sessionexpiresonipchange;
         AssignAttri("", false, "AV44SessionExpiresOnIPChange", AV44SessionExpiresOnIPChange);
         AV38RequiredPassword = AV33Repository.gxTpr_Requiredpassword;
         AssignAttri("", false, "AV38RequiredPassword", AV38RequiredPassword);
         AV35RequiredEmail = AV33Repository.gxTpr_Requiredemail;
         AssignAttri("", false, "AV35RequiredEmail", AV35RequiredEmail);
         AV36RequiredFirstName = AV33Repository.gxTpr_Requiredfirstname;
         AssignAttri("", false, "AV36RequiredFirstName", AV36RequiredFirstName);
         AV37RequiredLastName = AV33Repository.gxTpr_Requiredlastname;
         AssignAttri("", false, "AV37RequiredLastName", AV37RequiredLastName);
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E121L2 ();
         if (returnInSub) return;
      }

      protected void E121L2( )
      {
         /* Enter Routine */
         AV33Repository.load( (int)(AV23Id));
         AssignAttri("", false, "AV23Id", StringUtil.LTrimStr( (decimal)(AV23Id), 12, 0));
         AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV23Id), "ZZZZZZZZZZZ9"), context));
         AV33Repository.gxTpr_Name = AV30Name;
         AV33Repository.gxTpr_Description = AV12Dsc;
         AV33Repository.gxTpr_Defaultauthenticationtypename = AV9DefaultAuthTypeName;
         AV33Repository.gxTpr_Useridentification = AV48UserIdentification;
         AV33Repository.gxTpr_Generatesessionstatistics = AV20GenerateSessionStatistics;
         AV33Repository.gxTpr_Useractivationmethod = AV45UserActivationMethod;
         AV33Repository.gxTpr_Userautomaticactivationtimeout = AV46UserAutomaticActivationTimeout;
         AV33Repository.gxTpr_Gamunblockusertimeout = AV19GAMUnblockUserTimeout;
         AV33Repository.gxTpr_Userremembermetype = AV51UserRememberMeType;
         AV33Repository.gxTpr_Userremembermetimeout = AV50UserRememberMeTimeOut;
         AV33Repository.gxTpr_Userrecoverypasswordkeytimeout = AV49UserRecoveryPasswordKeyTimeOut;
         AV33Repository.gxTpr_Gamremotelogoutbehavior = AV28LogoutBehavior;
         AV33Repository.gxTpr_Minimumamountcharactersinlogin = AV29MinimumAmountCharactersInLogin;
         AV33Repository.gxTpr_Loginattemptstolockuser = AV27LoginAttemptsToLockUser;
         AV33Repository.gxTpr_Loginattemptstolocksession = AV26LoginAttemptsToLockSession;
         AV33Repository.gxTpr_Usersessioncachetimeout = AV52UserSessionCacheTimeout;
         AV33Repository.gxTpr_Cachetimeout = AV34RepositoryCacheTimeout;
         AV33Repository.gxTpr_Securityadministratoremail = AV41SecurityAdministratorEmail;
         AV33Repository.gxTpr_Giveanonymoussession = AV21GiveAnonymousSession;
         AV33Repository.gxTpr_Canregisterusers = AV8CanRegisterUsers;
         AV33Repository.gxTpr_Useremailisunique = AV47UserEmailisUnique;
         AV33Repository.gxTpr_Defaultsecuritypolicyid = AV11DefaultSecurityPolicyId;
         AV33Repository.gxTpr_Defaultroleid = AV10DefaultRoleId;
         AV33Repository.gxTpr_Enableworkingasgammanagerrepository = AV14EnableWorkingAsGAMManagerRepo;
         AV33Repository.gxTpr_Enabletracing = AV13EnableTracing;
         AV33Repository.gxTpr_Allowoauthaccess = AV5AllowOauthAccess;
         AV33Repository.gxTpr_Sessionexpiresonipchange = AV44SessionExpiresOnIPChange;
         AV33Repository.gxTpr_Requiredpassword = AV38RequiredPassword;
         AV33Repository.gxTpr_Requiredemail = AV35RequiredEmail;
         AV33Repository.gxTpr_Requiredfirstname = AV36RequiredFirstName;
         AV33Repository.gxTpr_Requiredlastname = AV37RequiredLastName;
         AV33Repository.save();
         if ( AV33Repository.success() )
         {
            context.CommitDataStores("gamrepositoryconfiguration",pr_default);
            GX_msglist.addItem(context.GetMessage( "Data has been successfully updated.", ""));
         }
         else
         {
            AV16Errors = AV33Repository.geterrors();
            AV58GXV4 = 1;
            while ( AV58GXV4 <= AV16Errors.Count )
            {
               AV15Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV16Errors.Item(AV58GXV4));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV15Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV15Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV58GXV4 = (int)(AV58GXV4+1);
            }
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E131L2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV32pId = Convert.ToInt64(getParm(obj,0));
         AssignAttri("", false, "AV32pId", StringUtil.LTrimStr( (decimal)(AV32pId), 12, 0));
         AssignAttri("", false, "gxhash_vPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV32pId), "ZZZZZZZZZZZ9"), context));
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
         PA1L2( ) ;
         WS1L2( ) ;
         WE1L2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20204151183654", true, true);
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
         context.AddJavascriptSource("gamrepositoryconfiguration.js", "?20204151183657", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbavDefaultauthtypename.Name = "vDEFAULTAUTHTYPENAME";
         cmbavDefaultauthtypename.WebTags = "";
         if ( cmbavDefaultauthtypename.ItemCount > 0 )
         {
            AV9DefaultAuthTypeName = cmbavDefaultauthtypename.getValidValue(AV9DefaultAuthTypeName);
            AssignAttri("", false, "AV9DefaultAuthTypeName", AV9DefaultAuthTypeName);
         }
         chkavSessionexpiresonipchange.Name = "vSESSIONEXPIRESONIPCHANGE";
         chkavSessionexpiresonipchange.WebTags = "";
         chkavSessionexpiresonipchange.Caption = "";
         AssignProp("", false, chkavSessionexpiresonipchange_Internalname, "TitleCaption", chkavSessionexpiresonipchange.Caption, true);
         chkavSessionexpiresonipchange.CheckedValue = "false";
         AV44SessionExpiresOnIPChange = StringUtil.StrToBool( StringUtil.BoolToStr( AV44SessionExpiresOnIPChange));
         AssignAttri("", false, "AV44SessionExpiresOnIPChange", AV44SessionExpiresOnIPChange);
         chkavAllowoauthaccess.Name = "vALLOWOAUTHACCESS";
         chkavAllowoauthaccess.WebTags = "";
         chkavAllowoauthaccess.Caption = "";
         AssignProp("", false, chkavAllowoauthaccess_Internalname, "TitleCaption", chkavAllowoauthaccess.Caption, true);
         chkavAllowoauthaccess.CheckedValue = "false";
         AV5AllowOauthAccess = StringUtil.StrToBool( StringUtil.BoolToStr( AV5AllowOauthAccess));
         AssignAttri("", false, "AV5AllowOauthAccess", AV5AllowOauthAccess);
         cmbavDefaultsecuritypolicyid.Name = "vDEFAULTSECURITYPOLICYID";
         cmbavDefaultsecuritypolicyid.WebTags = "";
         if ( cmbavDefaultsecuritypolicyid.ItemCount > 0 )
         {
            AV11DefaultSecurityPolicyId = (int)(NumberUtil.Val( cmbavDefaultsecuritypolicyid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV11DefaultSecurityPolicyId), 9, 0))), "."));
            AssignAttri("", false, "AV11DefaultSecurityPolicyId", StringUtil.LTrimStr( (decimal)(AV11DefaultSecurityPolicyId), 9, 0));
         }
         cmbavLogoutbehavior.Name = "vLOGOUTBEHAVIOR";
         cmbavLogoutbehavior.WebTags = "";
         cmbavLogoutbehavior.addItem("clionl", "Client only", 0);
         cmbavLogoutbehavior.addItem("cliip", "Identity Provider and Client", 0);
         cmbavLogoutbehavior.addItem("all", "Identity Provider and all Clients", 0);
         if ( cmbavLogoutbehavior.ItemCount > 0 )
         {
            AV28LogoutBehavior = cmbavLogoutbehavior.getValidValue(AV28LogoutBehavior);
            AssignAttri("", false, "AV28LogoutBehavior", AV28LogoutBehavior);
         }
         cmbavDefaultroleid.Name = "vDEFAULTROLEID";
         cmbavDefaultroleid.WebTags = "";
         if ( cmbavDefaultroleid.ItemCount > 0 )
         {
            AV10DefaultRoleId = (long)(NumberUtil.Val( cmbavDefaultroleid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10DefaultRoleId), 12, 0))), "."));
            AssignAttri("", false, "AV10DefaultRoleId", StringUtil.LTrimStr( (decimal)(AV10DefaultRoleId), 12, 0));
         }
         cmbavEnabletracing.Name = "vENABLETRACING";
         cmbavEnabletracing.WebTags = "";
         cmbavEnabletracing.addItem("0", "0 - Off", 0);
         cmbavEnabletracing.addItem("1", "1 - Debug", 0);
         if ( cmbavEnabletracing.ItemCount > 0 )
         {
            AV13EnableTracing = (short)(NumberUtil.Val( cmbavEnabletracing.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV13EnableTracing), 4, 0))), "."));
            AssignAttri("", false, "AV13EnableTracing", StringUtil.LTrimStr( (decimal)(AV13EnableTracing), 4, 0));
         }
         chkavEnableworkingasgammanagerrepo.Name = "vENABLEWORKINGASGAMMANAGERREPO";
         chkavEnableworkingasgammanagerrepo.WebTags = "";
         chkavEnableworkingasgammanagerrepo.Caption = "";
         AssignProp("", false, chkavEnableworkingasgammanagerrepo_Internalname, "TitleCaption", chkavEnableworkingasgammanagerrepo.Caption, true);
         chkavEnableworkingasgammanagerrepo.CheckedValue = "false";
         AV14EnableWorkingAsGAMManagerRepo = StringUtil.StrToBool( StringUtil.BoolToStr( AV14EnableWorkingAsGAMManagerRepo));
         AssignAttri("", false, "AV14EnableWorkingAsGAMManagerRepo", AV14EnableWorkingAsGAMManagerRepo);
         cmbavUseridentification.Name = "vUSERIDENTIFICATION";
         cmbavUseridentification.WebTags = "";
         cmbavUseridentification.addItem("name", "Name", 0);
         cmbavUseridentification.addItem("email", "EMail", 0);
         cmbavUseridentification.addItem("namema", "Name and Email", 0);
         if ( cmbavUseridentification.ItemCount > 0 )
         {
            AV48UserIdentification = cmbavUseridentification.getValidValue(AV48UserIdentification);
            AssignAttri("", false, "AV48UserIdentification", AV48UserIdentification);
         }
         cmbavUseractivationmethod.Name = "vUSERACTIVATIONMETHOD";
         cmbavUseractivationmethod.WebTags = "";
         cmbavUseractivationmethod.addItem("A", "Automatic", 0);
         cmbavUseractivationmethod.addItem("U", "User", 0);
         cmbavUseractivationmethod.addItem("D", "Administrator", 0);
         if ( cmbavUseractivationmethod.ItemCount > 0 )
         {
            AV45UserActivationMethod = cmbavUseractivationmethod.getValidValue(AV45UserActivationMethod);
            AssignAttri("", false, "AV45UserActivationMethod", AV45UserActivationMethod);
         }
         chkavUseremailisunique.Name = "vUSEREMAILISUNIQUE";
         chkavUseremailisunique.WebTags = "";
         chkavUseremailisunique.Caption = "";
         AssignProp("", false, chkavUseremailisunique_Internalname, "TitleCaption", chkavUseremailisunique.Caption, true);
         chkavUseremailisunique.CheckedValue = "false";
         AV47UserEmailisUnique = StringUtil.StrToBool( StringUtil.BoolToStr( AV47UserEmailisUnique));
         AssignAttri("", false, "AV47UserEmailisUnique", AV47UserEmailisUnique);
         chkavRequiredemail.Name = "vREQUIREDEMAIL";
         chkavRequiredemail.WebTags = "";
         chkavRequiredemail.Caption = "";
         AssignProp("", false, chkavRequiredemail_Internalname, "TitleCaption", chkavRequiredemail.Caption, true);
         chkavRequiredemail.CheckedValue = "false";
         AV35RequiredEmail = StringUtil.StrToBool( StringUtil.BoolToStr( AV35RequiredEmail));
         AssignAttri("", false, "AV35RequiredEmail", AV35RequiredEmail);
         chkavRequiredpassword.Name = "vREQUIREDPASSWORD";
         chkavRequiredpassword.WebTags = "";
         chkavRequiredpassword.Caption = "";
         AssignProp("", false, chkavRequiredpassword_Internalname, "TitleCaption", chkavRequiredpassword.Caption, true);
         chkavRequiredpassword.CheckedValue = "false";
         AV38RequiredPassword = StringUtil.StrToBool( StringUtil.BoolToStr( AV38RequiredPassword));
         AssignAttri("", false, "AV38RequiredPassword", AV38RequiredPassword);
         chkavRequiredfirstname.Name = "vREQUIREDFIRSTNAME";
         chkavRequiredfirstname.WebTags = "";
         chkavRequiredfirstname.Caption = "";
         AssignProp("", false, chkavRequiredfirstname_Internalname, "TitleCaption", chkavRequiredfirstname.Caption, true);
         chkavRequiredfirstname.CheckedValue = "false";
         AV36RequiredFirstName = StringUtil.StrToBool( StringUtil.BoolToStr( AV36RequiredFirstName));
         AssignAttri("", false, "AV36RequiredFirstName", AV36RequiredFirstName);
         chkavRequiredlastname.Name = "vREQUIREDLASTNAME";
         chkavRequiredlastname.WebTags = "";
         chkavRequiredlastname.Caption = "";
         AssignProp("", false, chkavRequiredlastname_Internalname, "TitleCaption", chkavRequiredlastname.Caption, true);
         chkavRequiredlastname.CheckedValue = "false";
         AV37RequiredLastName = StringUtil.StrToBool( StringUtil.BoolToStr( AV37RequiredLastName));
         AssignAttri("", false, "AV37RequiredLastName", AV37RequiredLastName);
         cmbavGeneratesessionstatistics.Name = "vGENERATESESSIONSTATISTICS";
         cmbavGeneratesessionstatistics.WebTags = "";
         cmbavGeneratesessionstatistics.addItem("None", "None", 0);
         cmbavGeneratesessionstatistics.addItem("Minimum", "Minimum (Only authenticated users)", 0);
         cmbavGeneratesessionstatistics.addItem("Detail", "Detail (Authenticated and anonymous users)", 0);
         cmbavGeneratesessionstatistics.addItem("Full", "Full log (Authenticated and anonymous users)", 0);
         if ( cmbavGeneratesessionstatistics.ItemCount > 0 )
         {
            AV20GenerateSessionStatistics = cmbavGeneratesessionstatistics.getValidValue(AV20GenerateSessionStatistics);
            AssignAttri("", false, "AV20GenerateSessionStatistics", AV20GenerateSessionStatistics);
         }
         chkavGiveanonymoussession.Name = "vGIVEANONYMOUSSESSION";
         chkavGiveanonymoussession.WebTags = "";
         chkavGiveanonymoussession.Caption = "";
         AssignProp("", false, chkavGiveanonymoussession_Internalname, "TitleCaption", chkavGiveanonymoussession.Caption, true);
         chkavGiveanonymoussession.CheckedValue = "false";
         AV21GiveAnonymousSession = StringUtil.StrToBool( StringUtil.BoolToStr( AV21GiveAnonymousSession));
         AssignAttri("", false, "AV21GiveAnonymousSession", AV21GiveAnonymousSession);
         cmbavUserremembermetype.Name = "vUSERREMEMBERMETYPE";
         cmbavUserremembermetype.WebTags = "";
         cmbavUserremembermetype.addItem("None", "None", 0);
         cmbavUserremembermetype.addItem("Login", "Login", 0);
         cmbavUserremembermetype.addItem("Auth", "Authentication", 0);
         cmbavUserremembermetype.addItem("Both", "Both", 0);
         if ( cmbavUserremembermetype.ItemCount > 0 )
         {
            AV51UserRememberMeType = cmbavUserremembermetype.getValidValue(AV51UserRememberMeType);
            AssignAttri("", false, "AV51UserRememberMeType", AV51UserRememberMeType);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         divTable1_Internalname = "TABLE1";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         edtavId_Internalname = "vID";
         edtavGuid_Internalname = "vGUID";
         edtavNamespace_Internalname = "vNAMESPACE";
         edtavName_Internalname = "vNAME";
         edtavDsc_Internalname = "vDSC";
         cmbavDefaultauthtypename_Internalname = "vDEFAULTAUTHTYPENAME";
         divDefaultauthtypenamecell_Internalname = "DEFAULTAUTHTYPENAMECELL";
         chkavSessionexpiresonipchange_Internalname = "vSESSIONEXPIRESONIPCHANGE";
         chkavAllowoauthaccess_Internalname = "vALLOWOAUTHACCESS";
         cmbavDefaultsecuritypolicyid_Internalname = "vDEFAULTSECURITYPOLICYID";
         divDefaultsecuritypolicyidcell_Internalname = "DEFAULTSECURITYPOLICYIDCELL";
         cmbavLogoutbehavior_Internalname = "vLOGOUTBEHAVIOR";
         divSsobehaviorcell_Internalname = "SSOBEHAVIORCELL";
         cmbavDefaultroleid_Internalname = "vDEFAULTROLEID";
         divDefaultroleidcell_Internalname = "DEFAULTROLEIDCELL";
         cmbavEnabletracing_Internalname = "vENABLETRACING";
         chkavEnableworkingasgammanagerrepo_Internalname = "vENABLEWORKINGASGAMMANAGERREPO";
         divTabpage1table_Internalname = "TABPAGE1TABLE";
         lblUsers_title_Internalname = "USERS_TITLE";
         cmbavUseridentification_Internalname = "vUSERIDENTIFICATION";
         cmbavUseractivationmethod_Internalname = "vUSERACTIVATIONMETHOD";
         edtavUserautomaticactivationtimeout_Internalname = "vUSERAUTOMATICACTIVATIONTIMEOUT";
         chkavUseremailisunique_Internalname = "vUSEREMAILISUNIQUE";
         chkavRequiredemail_Internalname = "vREQUIREDEMAIL";
         chkavRequiredpassword_Internalname = "vREQUIREDPASSWORD";
         chkavRequiredfirstname_Internalname = "vREQUIREDFIRSTNAME";
         chkavRequiredlastname_Internalname = "vREQUIREDLASTNAME";
         divTabpage2table_Internalname = "TABPAGE2TABLE";
         lblSession_title_Internalname = "SESSION_TITLE";
         cmbavGeneratesessionstatistics_Internalname = "vGENERATESESSIONSTATISTICS";
         edtavUsersessioncachetimeout_Internalname = "vUSERSESSIONCACHETIMEOUT";
         chkavGiveanonymoussession_Internalname = "vGIVEANONYMOUSSESSION";
         edtavLoginattemptstolocksession_Internalname = "vLOGINATTEMPTSTOLOCKSESSION";
         edtavGamunblockusertimeout_Internalname = "vGAMUNBLOCKUSERTIMEOUT";
         edtavLoginattemptstolockuser_Internalname = "vLOGINATTEMPTSTOLOCKUSER";
         edtavMinimumamountcharactersinlogin_Internalname = "vMINIMUMAMOUNTCHARACTERSINLOGIN";
         edtavUserrecoverypasswordkeytimeout_Internalname = "vUSERRECOVERYPASSWORDKEYTIMEOUT";
         edtavUserremembermetimeout_Internalname = "vUSERREMEMBERMETIMEOUT";
         cmbavUserremembermetype_Internalname = "vUSERREMEMBERMETYPE";
         edtavRepositorycachetimeout_Internalname = "vREPOSITORYCACHETIMEOUT";
         divTabpage3table_Internalname = "TABPAGE3TABLE";
         Tab1_Internalname = "TAB1";
         bttConfirm_Internalname = "CONFIRM";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         chkavGiveanonymoussession.Caption = "Give anonymous session?";
         chkavRequiredlastname.Caption = "Required last name?";
         chkavRequiredfirstname.Caption = "Required first name?";
         chkavRequiredpassword.Caption = "Required password?";
         chkavRequiredemail.Caption = "Required email?";
         chkavUseremailisunique.Caption = "User email is unique?";
         chkavEnableworkingasgammanagerrepo.Caption = "Enable working as GAMManager repository";
         chkavAllowoauthaccess.Caption = "Allow oauth access (Smart Devices)";
         chkavSessionexpiresonipchange.Caption = "GAM Session expires on IP change?";
         edtavRepositorycachetimeout_Jsonclick = "";
         edtavRepositorycachetimeout_Enabled = 1;
         cmbavUserremembermetype_Jsonclick = "";
         cmbavUserremembermetype.Enabled = 1;
         edtavUserremembermetimeout_Jsonclick = "";
         edtavUserremembermetimeout_Enabled = 1;
         edtavUserrecoverypasswordkeytimeout_Jsonclick = "";
         edtavUserrecoverypasswordkeytimeout_Enabled = 1;
         edtavMinimumamountcharactersinlogin_Jsonclick = "";
         edtavMinimumamountcharactersinlogin_Enabled = 1;
         edtavLoginattemptstolockuser_Jsonclick = "";
         edtavLoginattemptstolockuser_Enabled = 1;
         edtavGamunblockusertimeout_Jsonclick = "";
         edtavGamunblockusertimeout_Enabled = 1;
         edtavLoginattemptstolocksession_Jsonclick = "";
         edtavLoginattemptstolocksession_Enabled = 1;
         chkavGiveanonymoussession.Enabled = 1;
         edtavUsersessioncachetimeout_Jsonclick = "";
         edtavUsersessioncachetimeout_Enabled = 1;
         cmbavGeneratesessionstatistics_Jsonclick = "";
         cmbavGeneratesessionstatistics.Enabled = 1;
         chkavRequiredlastname.Enabled = 1;
         chkavRequiredfirstname.Enabled = 1;
         chkavRequiredpassword.Enabled = 1;
         chkavRequiredemail.Enabled = 1;
         chkavUseremailisunique.Enabled = 1;
         edtavUserautomaticactivationtimeout_Jsonclick = "";
         edtavUserautomaticactivationtimeout_Enabled = 1;
         cmbavUseractivationmethod_Jsonclick = "";
         cmbavUseractivationmethod.Enabled = 1;
         cmbavUseridentification_Jsonclick = "";
         cmbavUseridentification.Enabled = 1;
         chkavEnableworkingasgammanagerrepo.Enabled = 1;
         cmbavEnabletracing_Jsonclick = "";
         cmbavEnabletracing.Enabled = 1;
         cmbavDefaultroleid_Jsonclick = "";
         cmbavDefaultroleid.Enabled = 1;
         divDefaultroleidcell_Visible = 1;
         cmbavLogoutbehavior_Jsonclick = "";
         cmbavLogoutbehavior.Enabled = 1;
         cmbavDefaultsecuritypolicyid_Jsonclick = "";
         cmbavDefaultsecuritypolicyid.Enabled = 1;
         divDefaultsecuritypolicyidcell_Visible = 1;
         chkavAllowoauthaccess.Enabled = 1;
         chkavSessionexpiresonipchange.Enabled = 1;
         cmbavDefaultauthtypename_Jsonclick = "";
         cmbavDefaultauthtypename.Enabled = 1;
         divDefaultauthtypenamecell_Visible = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 1;
         edtavNamespace_Jsonclick = "";
         edtavNamespace_Enabled = 1;
         edtavGuid_Jsonclick = "";
         edtavGuid_Enabled = 1;
         edtavId_Jsonclick = "";
         edtavId_Enabled = 1;
         Tab1_Historymanagement = Convert.ToBoolean( 0);
         Tab1_Class = "Tab";
         Tab1_Pagecount = 3;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Repository configuration ";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV32pId',fld:'vPID',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV23Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV41SecurityAdministratorEmail',fld:'vSECURITYADMINISTRATOREMAIL',pic:'',hsh:true},{av:'AV8CanRegisterUsers',fld:'vCANREGISTERUSERS',pic:'',hsh:true},{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]}");
         setEventMetadata("ENTER","{handler:'E121L2',iparms:[{av:'AV23Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV30Name',fld:'vNAME',pic:''},{av:'AV12Dsc',fld:'vDSC',pic:''},{av:'cmbavDefaultauthtypename'},{av:'AV9DefaultAuthTypeName',fld:'vDEFAULTAUTHTYPENAME',pic:''},{av:'cmbavUseridentification'},{av:'AV48UserIdentification',fld:'vUSERIDENTIFICATION',pic:''},{av:'cmbavGeneratesessionstatistics'},{av:'AV20GenerateSessionStatistics',fld:'vGENERATESESSIONSTATISTICS',pic:''},{av:'cmbavUseractivationmethod'},{av:'AV45UserActivationMethod',fld:'vUSERACTIVATIONMETHOD',pic:''},{av:'AV46UserAutomaticActivationTimeout',fld:'vUSERAUTOMATICACTIVATIONTIMEOUT',pic:'ZZZ9'},{av:'AV19GAMUnblockUserTimeout',fld:'vGAMUNBLOCKUSERTIMEOUT',pic:'ZZZ9'},{av:'cmbavUserremembermetype'},{av:'AV51UserRememberMeType',fld:'vUSERREMEMBERMETYPE',pic:''},{av:'AV50UserRememberMeTimeOut',fld:'vUSERREMEMBERMETIMEOUT',pic:'ZZZ9'},{av:'AV49UserRecoveryPasswordKeyTimeOut',fld:'vUSERRECOVERYPASSWORDKEYTIMEOUT',pic:'ZZZ9'},{av:'cmbavLogoutbehavior'},{av:'AV28LogoutBehavior',fld:'vLOGOUTBEHAVIOR',pic:''},{av:'AV29MinimumAmountCharactersInLogin',fld:'vMINIMUMAMOUNTCHARACTERSINLOGIN',pic:'Z9'},{av:'AV27LoginAttemptsToLockUser',fld:'vLOGINATTEMPTSTOLOCKUSER',pic:'Z9'},{av:'AV26LoginAttemptsToLockSession',fld:'vLOGINATTEMPTSTOLOCKSESSION',pic:'Z9'},{av:'AV52UserSessionCacheTimeout',fld:'vUSERSESSIONCACHETIMEOUT',pic:'ZZZZZ9'},{av:'AV34RepositoryCacheTimeout',fld:'vREPOSITORYCACHETIMEOUT',pic:'ZZZZZ9'},{av:'AV41SecurityAdministratorEmail',fld:'vSECURITYADMINISTRATOREMAIL',pic:'',hsh:true},{av:'AV8CanRegisterUsers',fld:'vCANREGISTERUSERS',pic:'',hsh:true},{av:'cmbavDefaultsecuritypolicyid'},{av:'AV11DefaultSecurityPolicyId',fld:'vDEFAULTSECURITYPOLICYID',pic:'ZZZZZZZZ9'},{av:'cmbavDefaultroleid'},{av:'AV10DefaultRoleId',fld:'vDEFAULTROLEID',pic:'ZZZZZZZZZZZ9'},{av:'cmbavEnabletracing'},{av:'AV13EnableTracing',fld:'vENABLETRACING',pic:'ZZZ9'},{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]}");
         setEventMetadata("VALIDV_LOGOUTBEHAVIOR","{handler:'Validv_Logoutbehavior',iparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]");
         setEventMetadata("VALIDV_LOGOUTBEHAVIOR",",oparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]}");
         setEventMetadata("VALIDV_ENABLETRACING","{handler:'Validv_Enabletracing',iparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]");
         setEventMetadata("VALIDV_ENABLETRACING",",oparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]}");
         setEventMetadata("VALIDV_USERIDENTIFICATION","{handler:'Validv_Useridentification',iparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]");
         setEventMetadata("VALIDV_USERIDENTIFICATION",",oparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]}");
         setEventMetadata("VALIDV_USERACTIVATIONMETHOD","{handler:'Validv_Useractivationmethod',iparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]");
         setEventMetadata("VALIDV_USERACTIVATIONMETHOD",",oparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]}");
         setEventMetadata("VALIDV_GENERATESESSIONSTATISTICS","{handler:'Validv_Generatesessionstatistics',iparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]");
         setEventMetadata("VALIDV_GENERATESESSIONSTATISTICS",",oparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]}");
         setEventMetadata("VALIDV_USERREMEMBERMETYPE","{handler:'Validv_Userremembermetype',iparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]");
         setEventMetadata("VALIDV_USERREMEMBERMETYPE",",oparms:[{av:'AV44SessionExpiresOnIPChange',fld:'vSESSIONEXPIRESONIPCHANGE',pic:''},{av:'AV5AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:''},{av:'AV14EnableWorkingAsGAMManagerRepo',fld:'vENABLEWORKINGASGAMMANAGERREPO',pic:''},{av:'AV47UserEmailisUnique',fld:'vUSEREMAILISUNIQUE',pic:''},{av:'AV35RequiredEmail',fld:'vREQUIREDEMAIL',pic:''},{av:'AV38RequiredPassword',fld:'vREQUIREDPASSWORD',pic:''},{av:'AV36RequiredFirstName',fld:'vREQUIREDFIRSTNAME',pic:''},{av:'AV37RequiredLastName',fld:'vREQUIREDLASTNAME',pic:''},{av:'AV21GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:''}]}");
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
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV41SecurityAdministratorEmail = "";
         GXKey = "";
         forbiddenHiddens = new GXProperties();
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         ucTab1 = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         TempTags = "";
         AV22GUID = "";
         AV31NameSpace = "";
         AV30Name = "";
         AV12Dsc = "";
         AV9DefaultAuthTypeName = "";
         AV28LogoutBehavior = "";
         lblUsers_title_Jsonclick = "";
         AV48UserIdentification = "";
         AV45UserActivationMethod = "";
         lblSession_title_Jsonclick = "";
         AV20GenerateSessionStatistics = "";
         AV51UserRememberMeType = "";
         bttConfirm_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         hsh = "";
         AV16Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV7AuthenticationTypes = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple>( context, "GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple", "GeneXus.Programs");
         AV25Language = "";
         AV6AuthenticationType = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple(context);
         AV42SecurityPolicies = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy>( context, "GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy", "GeneXus.Programs");
         AV18FilterSecPol = new GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicyFilter(context);
         AV43SecurityPolicy = new GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy(context);
         AV40Roles = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMRole>( context, "GeneXus.Programs.genexussecurity.SdtGAMRole", "GeneXus.Programs");
         AV17FilterRole = new GeneXus.Programs.genexussecurity.SdtGAMRoleFilter(context);
         AV39Role = new GeneXus.Programs.genexussecurity.SdtGAMRole(context);
         AV33Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV15Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamrepositoryconfiguration__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamrepositoryconfiguration__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         edtavGuid_Enabled = 0;
         edtavNamespace_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short AV13EnableTracing ;
      private short AV46UserAutomaticActivationTimeout ;
      private short AV26LoginAttemptsToLockSession ;
      private short AV19GAMUnblockUserTimeout ;
      private short AV27LoginAttemptsToLockUser ;
      private short AV29MinimumAmountCharactersInLogin ;
      private short AV49UserRecoveryPasswordKeyTimeOut ;
      private short AV50UserRememberMeTimeOut ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int Tab1_Pagecount ;
      private int edtavId_Enabled ;
      private int edtavGuid_Enabled ;
      private int edtavNamespace_Enabled ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int divDefaultauthtypenamecell_Visible ;
      private int divDefaultsecuritypolicyidcell_Visible ;
      private int AV11DefaultSecurityPolicyId ;
      private int divDefaultroleidcell_Visible ;
      private int edtavUserautomaticactivationtimeout_Enabled ;
      private int AV52UserSessionCacheTimeout ;
      private int edtavUsersessioncachetimeout_Enabled ;
      private int edtavLoginattemptstolocksession_Enabled ;
      private int edtavGamunblockusertimeout_Enabled ;
      private int edtavLoginattemptstolockuser_Enabled ;
      private int edtavMinimumamountcharactersinlogin_Enabled ;
      private int edtavUserrecoverypasswordkeytimeout_Enabled ;
      private int edtavUserremembermetimeout_Enabled ;
      private int AV34RepositoryCacheTimeout ;
      private int edtavRepositorycachetimeout_Enabled ;
      private int AV55GXV1 ;
      private int AV56GXV2 ;
      private int AV57GXV3 ;
      private int AV58GXV4 ;
      private int idxLst ;
      private long AV32pId ;
      private long wcpOAV32pId ;
      private long AV23Id ;
      private long AV10DefaultRoleId ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Tab1_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String Tab1_Internalname ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String edtavId_Internalname ;
      private String TempTags ;
      private String edtavId_Jsonclick ;
      private String edtavGuid_Internalname ;
      private String AV22GUID ;
      private String edtavGuid_Jsonclick ;
      private String edtavNamespace_Internalname ;
      private String AV31NameSpace ;
      private String edtavNamespace_Jsonclick ;
      private String edtavName_Internalname ;
      private String AV30Name ;
      private String edtavName_Jsonclick ;
      private String edtavDsc_Internalname ;
      private String AV12Dsc ;
      private String edtavDsc_Jsonclick ;
      private String divDefaultauthtypenamecell_Internalname ;
      private String cmbavDefaultauthtypename_Internalname ;
      private String AV9DefaultAuthTypeName ;
      private String cmbavDefaultauthtypename_Jsonclick ;
      private String chkavSessionexpiresonipchange_Internalname ;
      private String chkavAllowoauthaccess_Internalname ;
      private String divDefaultsecuritypolicyidcell_Internalname ;
      private String cmbavDefaultsecuritypolicyid_Internalname ;
      private String cmbavDefaultsecuritypolicyid_Jsonclick ;
      private String divSsobehaviorcell_Internalname ;
      private String cmbavLogoutbehavior_Internalname ;
      private String AV28LogoutBehavior ;
      private String cmbavLogoutbehavior_Jsonclick ;
      private String divDefaultroleidcell_Internalname ;
      private String cmbavDefaultroleid_Internalname ;
      private String cmbavDefaultroleid_Jsonclick ;
      private String cmbavEnabletracing_Internalname ;
      private String cmbavEnabletracing_Jsonclick ;
      private String chkavEnableworkingasgammanagerrepo_Internalname ;
      private String lblUsers_title_Internalname ;
      private String lblUsers_title_Jsonclick ;
      private String divTabpage2table_Internalname ;
      private String cmbavUseridentification_Internalname ;
      private String AV48UserIdentification ;
      private String cmbavUseridentification_Jsonclick ;
      private String cmbavUseractivationmethod_Internalname ;
      private String AV45UserActivationMethod ;
      private String cmbavUseractivationmethod_Jsonclick ;
      private String edtavUserautomaticactivationtimeout_Internalname ;
      private String edtavUserautomaticactivationtimeout_Jsonclick ;
      private String chkavUseremailisunique_Internalname ;
      private String chkavRequiredemail_Internalname ;
      private String chkavRequiredpassword_Internalname ;
      private String chkavRequiredfirstname_Internalname ;
      private String chkavRequiredlastname_Internalname ;
      private String lblSession_title_Internalname ;
      private String lblSession_title_Jsonclick ;
      private String divTabpage3table_Internalname ;
      private String cmbavGeneratesessionstatistics_Internalname ;
      private String AV20GenerateSessionStatistics ;
      private String cmbavGeneratesessionstatistics_Jsonclick ;
      private String edtavUsersessioncachetimeout_Internalname ;
      private String edtavUsersessioncachetimeout_Jsonclick ;
      private String chkavGiveanonymoussession_Internalname ;
      private String edtavLoginattemptstolocksession_Internalname ;
      private String edtavLoginattemptstolocksession_Jsonclick ;
      private String edtavGamunblockusertimeout_Internalname ;
      private String edtavGamunblockusertimeout_Jsonclick ;
      private String edtavLoginattemptstolockuser_Internalname ;
      private String edtavLoginattemptstolockuser_Jsonclick ;
      private String edtavMinimumamountcharactersinlogin_Internalname ;
      private String edtavMinimumamountcharactersinlogin_Jsonclick ;
      private String edtavUserrecoverypasswordkeytimeout_Internalname ;
      private String edtavUserrecoverypasswordkeytimeout_Jsonclick ;
      private String edtavUserremembermetimeout_Internalname ;
      private String edtavUserremembermetimeout_Jsonclick ;
      private String cmbavUserremembermetype_Internalname ;
      private String AV51UserRememberMeType ;
      private String cmbavUserremembermetype_Jsonclick ;
      private String edtavRepositorycachetimeout_Internalname ;
      private String edtavRepositorycachetimeout_Jsonclick ;
      private String bttConfirm_Internalname ;
      private String bttConfirm_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String hsh ;
      private String AV25Language ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV8CanRegisterUsers ;
      private bool Tab1_Historymanagement ;
      private bool wbLoad ;
      private bool AV44SessionExpiresOnIPChange ;
      private bool AV5AllowOauthAccess ;
      private bool AV14EnableWorkingAsGAMManagerRepo ;
      private bool AV47UserEmailisUnique ;
      private bool AV35RequiredEmail ;
      private bool AV38RequiredPassword ;
      private bool AV36RequiredFirstName ;
      private bool AV37RequiredLastName ;
      private bool AV21GiveAnonymousSession ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV24isLoginRepositoryAdm ;
      private String AV41SecurityAdministratorEmail ;
      private GXProperties forbiddenHiddens ;
      private GXUserControl ucTab1 ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavDefaultauthtypename ;
      private GXCheckbox chkavSessionexpiresonipchange ;
      private GXCheckbox chkavAllowoauthaccess ;
      private GXCombobox cmbavDefaultsecuritypolicyid ;
      private GXCombobox cmbavLogoutbehavior ;
      private GXCombobox cmbavDefaultroleid ;
      private GXCombobox cmbavEnabletracing ;
      private GXCheckbox chkavEnableworkingasgammanagerrepo ;
      private GXCombobox cmbavUseridentification ;
      private GXCombobox cmbavUseractivationmethod ;
      private GXCheckbox chkavUseremailisunique ;
      private GXCheckbox chkavRequiredemail ;
      private GXCheckbox chkavRequiredpassword ;
      private GXCheckbox chkavRequiredfirstname ;
      private GXCheckbox chkavRequiredlastname ;
      private GXCombobox cmbavGeneratesessionstatistics ;
      private GXCheckbox chkavGiveanonymoussession ;
      private GXCombobox cmbavUserremembermetype ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple> AV7AuthenticationTypes ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV16Errors ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMRole> AV40Roles ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy> AV42SecurityPolicies ;
      private GXWebForm Form ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple AV6AuthenticationType ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV15Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMRoleFilter AV17FilterRole ;
      private GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicyFilter AV18FilterSecPol ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV33Repository ;
      private GeneXus.Programs.genexussecurity.SdtGAMRole AV39Role ;
      private GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy AV43SecurityPolicy ;
   }

   public class gamrepositoryconfiguration__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamrepositoryconfiguration__default : DataStoreHelperBase, IDataStoreHelper
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
