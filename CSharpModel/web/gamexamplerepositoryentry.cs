/*
               File: GAMExampleRepositoryEntry
        Description: Repository
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:7:49.18
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
   public class gamexamplerepositoryentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamexamplerepositoryentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamexamplerepositoryentry( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_Gx_mode ,
                           ref int aP1_Id )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV30Id = aP1_Id;
         executePrivate();
         aP0_Gx_mode=this.Gx_mode;
         aP1_Id=this.AV30Id;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavUsecurrentrepositorasmasterauthentication = new GXCheckbox();
         cmbavGeneratesessionstatistics = new GXCombobox();
         chkavUpdateconnectionfile = new GXCheckbox();
         chkavIsgamadminaccessrepository = new GXCheckbox();
         chkavCreategamapplication = new GXCheckbox();
         cmbavCopyfromrepositoryid = new GXCombobox();
         chkavCopyroles = new GXCheckbox();
         chkavCopysecuritypolicies = new GXCheckbox();
         chkavCopyapplication = new GXCheckbox();
         chkavCopyapplicationrolepermissions = new GXCheckbox();
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
               Gx_mode = gxfirstwebparm;
               AssignAttri("", false, "Gx_mode", Gx_mode);
               AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV30Id = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "AV30Id", StringUtil.LTrimStr( (decimal)(AV30Id), 9, 0));
                  AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV30Id), "ZZZZZZZZ9"), context));
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
         PA1K2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1K2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20204151174971", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamexamplerepositoryentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV30Id)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV30Id), "ZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vALLOWOAUTHACCESS", GetSecureSignedToken( "", AV8AllowOauthAccess, context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30Id), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV30Id), "ZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_boolean_hidden_field( context, "vALLOWOAUTHACCESS", AV8AllowOauthAccess);
         GxWebStd.gx_hidden_field( context, "gxhash_vALLOWOAUTHACCESS", GetSecureSignedToken( "", AV8AllowOauthAccess, context));
         GxWebStd.gx_hidden_field( context, "TAB2_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab2_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB2_Class", StringUtil.RTrim( Tab2_Class));
         GxWebStd.gx_hidden_field( context, "TAB2_Historymanagement", StringUtil.BoolToStr( Tab2_Historymanagement));
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
            WE1K2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1K2( ) ;
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
         return formatLink("gamexamplerepositoryentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV30Id) ;
      }

      public override String GetPgmname( )
      {
         return "GAMExampleRepositoryEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "Repository " ;
      }

      protected void WB1K0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-10 col-md-offset-1 col-lg-8 col-lg-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5 col-sm-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Repository", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-10 col-md-offset-1 col-lg-8 col-lg-offset-2", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTab2.SetProperty("PageCount", Tab2_Pagecount);
            ucTab2.SetProperty("Class", Tab2_Class);
            ucTab2.SetProperty("HistoryManagement", Tab2_Historymanagement);
            ucTab2.Render(context, "tab", Tab2_Internalname, "TAB2Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleRepositoryEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTab1_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGuidcell_Internalname, divGuidcell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGuid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGuid_Internalname, "GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGuid_Internalname, StringUtil.RTrim( AV29GUID), StringUtil.RTrim( context.localUtil.Format( AV29GUID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGuid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGuid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMGUID", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
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
            GxWebStd.gx_label_element( context, edtavName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV33Name), StringUtil.RTrim( context.localUtil.Format( AV33Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDescription_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDescription_Internalname, StringUtil.RTrim( AV21Description), StringUtil.RTrim( context.localUtil.Format( AV21Description, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDescription_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDescription_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUsecurrentrepositorasmasterauthentication_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUsecurrentrepositorasmasterauthentication_Internalname, "Use the current repository as the authentication master repository", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUsecurrentrepositorasmasterauthentication_Internalname, StringUtil.BoolToStr( AV42UseCurrentRepositorAsMasterAuthentication), "", "Use the current repository as the authentication master repository", 1, chkavUsecurrentrepositorasmasterauthentication.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onblur=\""+""+";gx.evt.onblur(this,40);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divNamespacecell_Internalname, divNamespacecell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavNamespace_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavNamespace_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavNamespace_Internalname, "Namespace", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNamespace_Internalname, StringUtil.RTrim( AV34NameSpace), StringUtil.RTrim( context.localUtil.Format( AV34NameSpace, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNamespace_Jsonclick, 0, "Attribute", "", "", "", "", edtavNamespace_Visible, edtavNamespace_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMRepositoryNameSpace", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavGeneratesessionstatistics_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavGeneratesessionstatistics_Internalname, "Generate session statistics", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavGeneratesessionstatistics, cmbavGeneratesessionstatistics_Internalname, StringUtil.RTrim( AV27GenerateSessionStatistics), 1, cmbavGeneratesessionstatistics_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavGeneratesessionstatistics.Enabled, 1, 0, 0, "em", 0, "", "", "CheckBox", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "", true, "HLP_GAMExampleRepositoryEntry.htm");
            cmbavGeneratesessionstatistics.CurrentValue = StringUtil.RTrim( AV27GenerateSessionStatistics);
            AssignProp("", false, cmbavGeneratesessionstatistics_Internalname, "Values", (String)(cmbavGeneratesessionstatistics.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbluserssettings_Internalname, divTbluserssettings_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConnectionusername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConnectionusername_Internalname, "Connection user name", "col-sm-5 col-lg-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-lg-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConnectionusername_Internalname, StringUtil.RTrim( AV12ConnectionUserName), StringUtil.RTrim( context.localUtil.Format( AV12ConnectionUserName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConnectionusername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConnectionusername_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMConnectionUser", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConnectionuserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConnectionuserpassword_Internalname, "Connection user password", "col-sm-5 col-lg-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-lg-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConnectionuserpassword_Internalname, StringUtil.RTrim( AV13ConnectionUserPassword), StringUtil.RTrim( context.localUtil.Format( AV13ConnectionUserPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConnectionuserpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConnectionuserpassword_Enabled, 1, "text", "", 0, "px", 1, "row", 254, -1, 0, 0, 1, 0, -1, true, "", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConfconnectionuserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConfconnectionuserpassword_Internalname, "Confirm connection user password", "col-sm-5 col-lg-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-lg-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConfconnectionuserpassword_Internalname, StringUtil.RTrim( AV11ConfConnectionUserPassword), StringUtil.RTrim( context.localUtil.Format( AV11ConfConnectionUserPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConfconnectionuserpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConfconnectionuserpassword_Enabled, 0, "text", "", 0, "px", 1, "row", 254, -1, 0, 0, 1, 0, -1, true, "", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTblusecurrentasmasterrepository_Internalname, divTblusecurrentasmasterrepository_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAuthenticationmasterauthtypename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAuthenticationmasterauthtypename_Internalname, "Authentication type name in current repository", "col-sm-5 col-lg-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-lg-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAuthenticationmasterauthtypename_Internalname, StringUtil.RTrim( AV9AuthenticationMasterAuthTypeName), StringUtil.RTrim( context.localUtil.Format( AV9AuthenticationMasterAuthTypeName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAuthenticationmasterauthtypename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavAuthenticationmasterauthtypename_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMAuthenticationTypeName", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAdministratorusername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdministratorusername_Internalname, "Administrator user name (nickname)", "col-sm-5 col-lg-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-lg-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAdministratorusername_Internalname, StringUtil.RTrim( AV6AdministratorUserName), StringUtil.RTrim( context.localUtil.Format( AV6AdministratorUserName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAdministratorusername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavAdministratorusername_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMConnectionUser", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavAdministratoruserpassword_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAdministratoruserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdministratoruserpassword_Internalname, "Administrator user password", "col-sm-5 col-lg-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-lg-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAdministratoruserpassword_Internalname, StringUtil.RTrim( AV7AdministratorUserPassword), StringUtil.RTrim( context.localUtil.Format( AV7AdministratorUserPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAdministratoruserpassword_Jsonclick, 0, "Attribute", "", "", "", "", edtavAdministratoruserpassword_Visible, edtavAdministratoruserpassword_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, -1, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMPasswordDB", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavConfadministratoruserpassword_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConfadministratoruserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConfadministratoruserpassword_Internalname, "Confirm administrator user password", "col-sm-5 col-lg-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-lg-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConfadministratoruserpassword_Internalname, StringUtil.RTrim( AV10ConfAdministratorUserPassword), StringUtil.RTrim( context.localUtil.Format( AV10ConfAdministratorUserPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConfadministratoruserpassword_Jsonclick, 0, "Attribute", "", "", "", "", edtavConfadministratoruserpassword_Visible, edtavConfadministratoruserpassword_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, -1, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMPasswordDB", "left", true, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbupdconnfile_Internalname, divTbupdconnfile_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", chkavUpdateconnectionfile.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUpdateconnectionfile_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUpdateconnectionfile_Internalname, "Update connection.gam file", "col-sm-5 col-lg-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-lg-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUpdateconnectionfile_Internalname, StringUtil.BoolToStr( AV41UpdateConnectionFile), "", "Update connection.gam file", chkavUpdateconnectionfile.Visible, chkavUpdateconnectionfile.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(99, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,99);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavIsgamadminaccessrepository_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavIsgamadminaccessrepository_Internalname, "Is the current user an administrator of the new repository? ", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavIsgamadminaccessrepository_Internalname, StringUtil.BoolToStr( AV31isGAMAdminAccessRepository), "", "Is the current user an administrator of the new repository? ", 1, chkavIsgamadminaccessrepository.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(104, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,104);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavCreategamapplication_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCreategamapplication_Internalname, "Create GAM Backend application?", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCreategamapplication_Internalname, StringUtil.BoolToStr( AV20CreateGAMApplication), "", "Create GAM Backend application?", 1, chkavCreategamapplication.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(109, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,109);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCopyrepositorydata_title_Internalname, "Copy Repository Data", "", "", lblCopyrepositorydata_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleRepositoryEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "CopyRepositoryData") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage3table_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCopyapplicationtable_Internalname, divCopyapplicationtable_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavCopyfromrepositoryid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCopyfromrepositoryid_Internalname, "Copy from Repository Id.", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCopyfromrepositoryid, cmbavCopyfromrepositoryid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV17CopyFromRepositoryId), 9, 0)), 1, cmbavCopyfromrepositoryid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavCopyfromrepositoryid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,122);\"", "", true, "HLP_GAMExampleRepositoryEntry.htm");
            cmbavCopyfromrepositoryid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17CopyFromRepositoryId), 9, 0));
            AssignProp("", false, cmbavCopyfromrepositoryid_Internalname, "Values", (String)(cmbavCopyfromrepositoryid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavCopyroles_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCopyroles_Internalname, "Copy Roles?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCopyroles_Internalname, StringUtil.BoolToStr( AV18CopyRoles), "", "Copy Roles?", 1, chkavCopyroles.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onblur=\""+""+";gx.evt.onblur(this,127);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdminroleidcell_Internalname, divAdminroleidcell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAdministratorroleid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdministratorroleid_Internalname, "Administrator Role Id.", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 132,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAdministratorroleid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5AdministratorRoleId), 12, 0, ".", "")), ((edtavAdministratorroleid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5AdministratorRoleId), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV5AdministratorRoleId), "ZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,132);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAdministratorroleid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavAdministratorroleid_Enabled, 0, "number", "1", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMKeyNumLong", "right", false, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavCopysecuritypolicies_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCopysecuritypolicies_Internalname, "Copy Security Policies?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 137,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCopysecuritypolicies_Internalname, StringUtil.BoolToStr( AV19CopySecurityPolicies), "", "Copy Security Policies?", 1, chkavCopysecuritypolicies.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(137, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,137);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavCopyapplication_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCopyapplication_Internalname, "Copy Application? (Menus and Permissions)", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCopyapplication_Internalname, StringUtil.BoolToStr( AV14CopyApplication), "", "Copy Application? (Menus and Permissions)", 1, chkavCopyapplication.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onblur=\""+""+";gx.evt.onblur(this,142);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCopyfrommappidcell_Internalname, divCopyfrommappidcell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCopyfromapplicationid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCopyfromapplicationid_Internalname, "Copy from Application Id.", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 147,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCopyfromapplicationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16CopyFromApplicationId), 12, 0, ".", "")), ((edtavCopyfromapplicationid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV16CopyFromApplicationId), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV16CopyFromApplicationId), "ZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,147);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCopyfromapplicationid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCopyfromapplicationid_Enabled, 0, "number", "1", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMKeyNumLong", "right", false, "", "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavCopyapplicationrolepermissions_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCopyapplicationrolepermissions_Internalname, "Copy Roles Permissions?", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCopyapplicationrolepermissions_Internalname, StringUtil.BoolToStr( AV15CopyApplicationRolePermissions), "", "Copy Roles Permissions?", 1, chkavCopyapplicationrolepermissions.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onblur=\""+""+";gx.evt.onblur(this,152);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 157,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Cancel", bttBtncancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 159,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "", bttBtnconfirm_Caption, bttBtnconfirm_Jsonclick, 5, "Confirm", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1K2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Repository ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1K0( ) ;
      }

      protected void WS1K2( )
      {
         START1K2( ) ;
         EVT1K2( ) ;
      }

      protected void EVT1K2( )
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
                              E111K2 ();
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
                                    E121K2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VUSECURRENTREPOSITORASMASTERAUTHENTICATION.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E131K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E141K2 ();
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

      protected void WE1K2( )
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

      protected void PA1K2( )
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
               GX_FocusControl = edtavGuid_Internalname;
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
         AV42UseCurrentRepositorAsMasterAuthentication = StringUtil.StrToBool( StringUtil.BoolToStr( AV42UseCurrentRepositorAsMasterAuthentication));
         AssignAttri("", false, "AV42UseCurrentRepositorAsMasterAuthentication", AV42UseCurrentRepositorAsMasterAuthentication);
         if ( cmbavGeneratesessionstatistics.ItemCount > 0 )
         {
            AV27GenerateSessionStatistics = cmbavGeneratesessionstatistics.getValidValue(AV27GenerateSessionStatistics);
            AssignAttri("", false, "AV27GenerateSessionStatistics", AV27GenerateSessionStatistics);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavGeneratesessionstatistics.CurrentValue = StringUtil.RTrim( AV27GenerateSessionStatistics);
            AssignProp("", false, cmbavGeneratesessionstatistics_Internalname, "Values", cmbavGeneratesessionstatistics.ToJavascriptSource(), true);
         }
         AV41UpdateConnectionFile = StringUtil.StrToBool( StringUtil.BoolToStr( AV41UpdateConnectionFile));
         AssignAttri("", false, "AV41UpdateConnectionFile", AV41UpdateConnectionFile);
         AV31isGAMAdminAccessRepository = StringUtil.StrToBool( StringUtil.BoolToStr( AV31isGAMAdminAccessRepository));
         AssignAttri("", false, "AV31isGAMAdminAccessRepository", AV31isGAMAdminAccessRepository);
         AV20CreateGAMApplication = StringUtil.StrToBool( StringUtil.BoolToStr( AV20CreateGAMApplication));
         AssignAttri("", false, "AV20CreateGAMApplication", AV20CreateGAMApplication);
         if ( cmbavCopyfromrepositoryid.ItemCount > 0 )
         {
            AV17CopyFromRepositoryId = (int)(NumberUtil.Val( cmbavCopyfromrepositoryid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17CopyFromRepositoryId), 9, 0))), "."));
            AssignAttri("", false, "AV17CopyFromRepositoryId", StringUtil.LTrimStr( (decimal)(AV17CopyFromRepositoryId), 9, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCopyfromrepositoryid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17CopyFromRepositoryId), 9, 0));
            AssignProp("", false, cmbavCopyfromrepositoryid_Internalname, "Values", cmbavCopyfromrepositoryid.ToJavascriptSource(), true);
         }
         AV18CopyRoles = StringUtil.StrToBool( StringUtil.BoolToStr( AV18CopyRoles));
         AssignAttri("", false, "AV18CopyRoles", AV18CopyRoles);
         AV19CopySecurityPolicies = StringUtil.StrToBool( StringUtil.BoolToStr( AV19CopySecurityPolicies));
         AssignAttri("", false, "AV19CopySecurityPolicies", AV19CopySecurityPolicies);
         AV14CopyApplication = StringUtil.StrToBool( StringUtil.BoolToStr( AV14CopyApplication));
         AssignAttri("", false, "AV14CopyApplication", AV14CopyApplication);
         AV15CopyApplicationRolePermissions = StringUtil.StrToBool( StringUtil.BoolToStr( AV15CopyApplicationRolePermissions));
         AssignAttri("", false, "AV15CopyApplicationRolePermissions", AV15CopyApplicationRolePermissions);
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1K2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF1K2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E141K2 ();
            WB1K0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1K2( )
      {
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30Id), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV30Id), "ZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_boolean_hidden_field( context, "vALLOWOAUTHACCESS", AV8AllowOauthAccess);
         GxWebStd.gx_hidden_field( context, "gxhash_vALLOWOAUTHACCESS", GetSecureSignedToken( "", AV8AllowOauthAccess, context));
      }

      protected void STRUP1K0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111K2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Tab2_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TAB2_Pagecount"), ".", ","));
            Tab2_Class = cgiGet( "TAB2_Class");
            Tab2_Historymanagement = StringUtil.StrToBool( cgiGet( "TAB2_Historymanagement"));
            /* Read variables values. */
            AV29GUID = cgiGet( edtavGuid_Internalname);
            AssignAttri("", false, "AV29GUID", AV29GUID);
            AV33Name = cgiGet( edtavName_Internalname);
            AssignAttri("", false, "AV33Name", AV33Name);
            AV21Description = cgiGet( edtavDescription_Internalname);
            AssignAttri("", false, "AV21Description", AV21Description);
            AV42UseCurrentRepositorAsMasterAuthentication = StringUtil.StrToBool( cgiGet( chkavUsecurrentrepositorasmasterauthentication_Internalname));
            AssignAttri("", false, "AV42UseCurrentRepositorAsMasterAuthentication", AV42UseCurrentRepositorAsMasterAuthentication);
            AV34NameSpace = cgiGet( edtavNamespace_Internalname);
            AssignAttri("", false, "AV34NameSpace", AV34NameSpace);
            cmbavGeneratesessionstatistics.CurrentValue = cgiGet( cmbavGeneratesessionstatistics_Internalname);
            AV27GenerateSessionStatistics = cgiGet( cmbavGeneratesessionstatistics_Internalname);
            AssignAttri("", false, "AV27GenerateSessionStatistics", AV27GenerateSessionStatistics);
            AV12ConnectionUserName = cgiGet( edtavConnectionusername_Internalname);
            AssignAttri("", false, "AV12ConnectionUserName", AV12ConnectionUserName);
            AV13ConnectionUserPassword = cgiGet( edtavConnectionuserpassword_Internalname);
            AssignAttri("", false, "AV13ConnectionUserPassword", AV13ConnectionUserPassword);
            AV11ConfConnectionUserPassword = cgiGet( edtavConfconnectionuserpassword_Internalname);
            AssignAttri("", false, "AV11ConfConnectionUserPassword", AV11ConfConnectionUserPassword);
            AV9AuthenticationMasterAuthTypeName = cgiGet( edtavAuthenticationmasterauthtypename_Internalname);
            AssignAttri("", false, "AV9AuthenticationMasterAuthTypeName", AV9AuthenticationMasterAuthTypeName);
            AV6AdministratorUserName = cgiGet( edtavAdministratorusername_Internalname);
            AssignAttri("", false, "AV6AdministratorUserName", AV6AdministratorUserName);
            AV7AdministratorUserPassword = cgiGet( edtavAdministratoruserpassword_Internalname);
            AssignAttri("", false, "AV7AdministratorUserPassword", AV7AdministratorUserPassword);
            AV10ConfAdministratorUserPassword = cgiGet( edtavConfadministratoruserpassword_Internalname);
            AssignAttri("", false, "AV10ConfAdministratorUserPassword", AV10ConfAdministratorUserPassword);
            AV41UpdateConnectionFile = StringUtil.StrToBool( cgiGet( chkavUpdateconnectionfile_Internalname));
            AssignAttri("", false, "AV41UpdateConnectionFile", AV41UpdateConnectionFile);
            AV31isGAMAdminAccessRepository = StringUtil.StrToBool( cgiGet( chkavIsgamadminaccessrepository_Internalname));
            AssignAttri("", false, "AV31isGAMAdminAccessRepository", AV31isGAMAdminAccessRepository);
            AV20CreateGAMApplication = StringUtil.StrToBool( cgiGet( chkavCreategamapplication_Internalname));
            AssignAttri("", false, "AV20CreateGAMApplication", AV20CreateGAMApplication);
            cmbavCopyfromrepositoryid.CurrentValue = cgiGet( cmbavCopyfromrepositoryid_Internalname);
            AV17CopyFromRepositoryId = (int)(NumberUtil.Val( cgiGet( cmbavCopyfromrepositoryid_Internalname), "."));
            AssignAttri("", false, "AV17CopyFromRepositoryId", StringUtil.LTrimStr( (decimal)(AV17CopyFromRepositoryId), 9, 0));
            AV18CopyRoles = StringUtil.StrToBool( cgiGet( chkavCopyroles_Internalname));
            AssignAttri("", false, "AV18CopyRoles", AV18CopyRoles);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavAdministratorroleid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavAdministratorroleid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vADMINISTRATORROLEID");
               GX_FocusControl = edtavAdministratorroleid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5AdministratorRoleId = 0;
               AssignAttri("", false, "AV5AdministratorRoleId", StringUtil.LTrimStr( (decimal)(AV5AdministratorRoleId), 12, 0));
            }
            else
            {
               AV5AdministratorRoleId = (long)(context.localUtil.CToN( cgiGet( edtavAdministratorroleid_Internalname), ".", ","));
               AssignAttri("", false, "AV5AdministratorRoleId", StringUtil.LTrimStr( (decimal)(AV5AdministratorRoleId), 12, 0));
            }
            AV19CopySecurityPolicies = StringUtil.StrToBool( cgiGet( chkavCopysecuritypolicies_Internalname));
            AssignAttri("", false, "AV19CopySecurityPolicies", AV19CopySecurityPolicies);
            AV14CopyApplication = StringUtil.StrToBool( cgiGet( chkavCopyapplication_Internalname));
            AssignAttri("", false, "AV14CopyApplication", AV14CopyApplication);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCopyfromapplicationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCopyfromapplicationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCOPYFROMAPPLICATIONID");
               GX_FocusControl = edtavCopyfromapplicationid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16CopyFromApplicationId = 0;
               AssignAttri("", false, "AV16CopyFromApplicationId", StringUtil.LTrimStr( (decimal)(AV16CopyFromApplicationId), 12, 0));
            }
            else
            {
               AV16CopyFromApplicationId = (long)(context.localUtil.CToN( cgiGet( edtavCopyfromapplicationid_Internalname), ".", ","));
               AssignAttri("", false, "AV16CopyFromApplicationId", StringUtil.LTrimStr( (decimal)(AV16CopyFromApplicationId), 12, 0));
            }
            AV15CopyApplicationRolePermissions = StringUtil.StrToBool( cgiGet( chkavCopyapplicationrolepermissions_Internalname));
            AssignAttri("", false, "AV15CopyApplicationRolePermissions", AV15CopyApplicationRolePermissions);
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
         E111K2 ();
         if (returnInSub) return;
      }

      protected void E111K2( )
      {
         /* Start Routine */
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV37Repository.load( AV30Id);
            AssignAttri("", false, "AV30Id", StringUtil.LTrimStr( (decimal)(AV30Id), 9, 0));
            AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV30Id), "ZZZZZZZZ9"), context));
            if ( AV37Repository.success() )
            {
               AV29GUID = AV37Repository.gxTpr_Guid;
               AssignAttri("", false, "AV29GUID", AV29GUID);
               AV33Name = AV37Repository.gxTpr_Name;
               AssignAttri("", false, "AV33Name", AV33Name);
               AV34NameSpace = AV37Repository.gxTpr_Namespace;
               AssignAttri("", false, "AV34NameSpace", AV34NameSpace);
               AV21Description = AV37Repository.gxTpr_Description;
               AssignAttri("", false, "AV21Description", AV21Description);
               AV27GenerateSessionStatistics = AV37Repository.gxTpr_Generatesessionstatistics;
               AssignAttri("", false, "AV27GenerateSessionStatistics", AV27GenerateSessionStatistics);
               edtavGuid_Enabled = 0;
               AssignProp("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGuid_Enabled), 5, 0), true);
               edtavName_Enabled = 0;
               AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
               edtavNamespace_Enabled = 0;
               AssignProp("", false, edtavNamespace_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavNamespace_Enabled), 5, 0), true);
               edtavDescription_Enabled = 0;
               AssignProp("", false, edtavDescription_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDescription_Enabled), 5, 0), true);
               edtavAdministratorusername_Enabled = 0;
               AssignProp("", false, edtavAdministratorusername_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavAdministratorusername_Enabled), 5, 0), true);
               edtavAdministratoruserpassword_Enabled = 0;
               AssignProp("", false, edtavAdministratoruserpassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavAdministratoruserpassword_Enabled), 5, 0), true);
               cmbavGeneratesessionstatistics.Enabled = 0;
               AssignProp("", false, cmbavGeneratesessionstatistics_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavGeneratesessionstatistics.Enabled), 5, 0), true);
               edtavConnectionusername_Enabled = 0;
               AssignProp("", false, edtavConnectionusername_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavConnectionusername_Enabled), 5, 0), true);
               edtavConnectionuserpassword_Enabled = 0;
               AssignProp("", false, edtavConnectionuserpassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavConnectionuserpassword_Enabled), 5, 0), true);
               divTbluserssettings_Visible = 0;
               AssignProp("", false, divTbluserssettings_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTbluserssettings_Visible), 5, 0), true);
               divTbupdconnfile_Visible = 0;
               AssignProp("", false, divTbupdconnfile_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTbupdconnfile_Visible), 5, 0), true);
               chkavUpdateconnectionfile.Visible = 0;
               AssignProp("", false, chkavUpdateconnectionfile_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(chkavUpdateconnectionfile.Visible), 5, 0), true);
               bttBtnconfirm_Caption = "Delete";
               AssignProp("", false, bttBtnconfirm_Internalname, "Caption", bttBtnconfirm_Caption, true);
            }
            else
            {
               AV23Errors = AV37Repository.geterrors();
               /* Execute user subroutine: 'DISPLAYERRORS' */
               S112 ();
               if (returnInSub) return;
            }
         }
         else
         {
            divGuidcell_Visible = 0;
            AssignProp("", false, divGuidcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divGuidcell_Visible), 5, 0), true);
         }
         divCopyapplicationtable_Visible = 0;
         AssignProp("", false, divCopyapplicationtable_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divCopyapplicationtable_Visible), 5, 0), true);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            AV27GenerateSessionStatistics = "Minimum";
            AssignAttri("", false, "AV27GenerateSessionStatistics", AV27GenerateSessionStatistics);
            AV20CreateGAMApplication = true;
            AssignAttri("", false, "AV20CreateGAMApplication", AV20CreateGAMApplication);
            AV41UpdateConnectionFile = true;
            AssignAttri("", false, "AV41UpdateConnectionFile", AV41UpdateConnectionFile);
            divCopyapplicationtable_Visible = 1;
            AssignProp("", false, divCopyapplicationtable_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divCopyapplicationtable_Visible), 5, 0), true);
            AV36Repositories = new GeneXus.Programs.genexussecurity.SdtGAM(context).getallrepositories(AV39RepositoryFilter, out  AV23Errors);
            if ( AV23Errors.Count == 0 )
            {
               AV46GXV1 = 1;
               while ( AV46GXV1 <= AV36Repositories.Count )
               {
                  AV35Repo = ((GeneXus.Programs.genexussecurity.SdtGAMRepository)AV36Repositories.Item(AV46GXV1));
                  cmbavCopyfromrepositoryid.addItem("0", "(No copying)", 0);
                  cmbavCopyfromrepositoryid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV35Repo.gxTpr_Id), 9, 0)), StringUtil.Str( (decimal)(AV35Repo.gxTpr_Id), 9, 0)+" - "+StringUtil.Trim( AV35Repo.gxTpr_Name), 0);
                  AV46GXV1 = (int)(AV46GXV1+1);
               }
            }
            else
            {
               /* Execute user subroutine: 'DISPLAYERRORS' */
               S112 ();
               if (returnInSub) return;
            }
            divTblusecurrentasmasterrepository_Visible = 0;
            AssignProp("", false, divTblusecurrentasmasterrepository_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblusecurrentasmasterrepository_Visible), 5, 0), true);
            AV17CopyFromRepositoryId = 2;
            AssignAttri("", false, "AV17CopyFromRepositoryId", StringUtil.LTrimStr( (decimal)(AV17CopyFromRepositoryId), 9, 0));
            AV18CopyRoles = true;
            AssignAttri("", false, "AV18CopyRoles", AV18CopyRoles);
            AV5AdministratorRoleId = 2;
            AssignAttri("", false, "AV5AdministratorRoleId", StringUtil.LTrimStr( (decimal)(AV5AdministratorRoleId), 12, 0));
            AV19CopySecurityPolicies = true;
            AssignAttri("", false, "AV19CopySecurityPolicies", AV19CopySecurityPolicies);
            AV14CopyApplication = true;
            AssignAttri("", false, "AV14CopyApplication", AV14CopyApplication);
            AV16CopyFromApplicationId = 2;
            AssignAttri("", false, "AV16CopyFromApplicationId", StringUtil.LTrimStr( (decimal)(AV16CopyFromApplicationId), 12, 0));
            AV15CopyApplicationRolePermissions = true;
            AssignAttri("", false, "AV15CopyApplicationRolePermissions", AV15CopyApplicationRolePermissions);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E121K2 ();
         if (returnInSub) return;
      }

      protected void E121K2( )
      {
         /* Enter Routine */
         AV37Repository.load( AV30Id);
         AssignAttri("", false, "AV30Id", StringUtil.LTrimStr( (decimal)(AV30Id), 9, 0));
         AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV30Id), "ZZZZZZZZ9"), context));
         AV32isOK = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV7AdministratorUserPassword), StringUtil.Trim( AV10ConfAdministratorUserPassword)) != 0 )
            {
               GX_msglist.addItem("The administrator password and confirmation do not match");
               AV32isOK = false;
            }
            if ( StringUtil.StrCmp(StringUtil.Trim( AV13ConnectionUserPassword), StringUtil.Trim( AV11ConfConnectionUserPassword)) != 0 )
            {
               GX_msglist.addItem("The connection password and confirmation do not match");
               AV32isOK = false;
            }
         }
         if ( AV32isOK )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               AV29GUID = Guid.NewGuid( ).ToString();
               AssignAttri("", false, "AV29GUID", AV29GUID);
               AV38RepositoryCreate.gxTpr_Guid = AV29GUID;
               AV38RepositoryCreate.gxTpr_Name = AV33Name;
               AV38RepositoryCreate.gxTpr_Namespace = AV34NameSpace;
               AV38RepositoryCreate.gxTpr_Description = AV21Description;
               AV38RepositoryCreate.gxTpr_Administratorusername = AV6AdministratorUserName;
               AV38RepositoryCreate.gxTpr_Administratoruserpassword = AV7AdministratorUserPassword;
               AV38RepositoryCreate.gxTpr_Allowoauthaccess = AV8AllowOauthAccess;
               AV38RepositoryCreate.gxTpr_Connectionusername = AV12ConnectionUserName;
               AV38RepositoryCreate.gxTpr_Connectionuserpassword = AV13ConnectionUserPassword;
               AV38RepositoryCreate.gxTpr_Generatesessionstatistics = AV27GenerateSessionStatistics;
               AV38RepositoryCreate.gxTpr_Giveanonymoussession = true;
               AV38RepositoryCreate.gxTpr_Allowoauthaccess = true;
               if ( AV42UseCurrentRepositorAsMasterAuthentication )
               {
                  AV25GAMRepository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
                  AV38RepositoryCreate.gxTpr_Authenticationmasterrepositoryid = AV25GAMRepository.gxTpr_Id;
                  AV38RepositoryCreate.gxTpr_Authenticationmasterauthtypename = AV9AuthenticationMasterAuthTypeName;
               }
               AV38RepositoryCreate.gxTpr_Creategamapplication = AV20CreateGAMApplication;
               if ( ! (0==AV17CopyFromRepositoryId) )
               {
                  AV38RepositoryCreate.gxTpr_Copyfromrepositoryid = AV17CopyFromRepositoryId;
                  if ( AV18CopyRoles )
                  {
                     AV38RepositoryCreate.gxTpr_Copyroles = AV18CopyRoles;
                     AV38RepositoryCreate.gxTpr_Administratorroleid = AV5AdministratorRoleId;
                  }
                  AV38RepositoryCreate.gxTpr_Copysecuritypolicies = AV19CopySecurityPolicies;
               }
               if ( AV14CopyApplication && ! (0==AV16CopyFromApplicationId) )
               {
                  AV38RepositoryCreate.gxTpr_Copyapplication = AV14CopyApplication;
                  AV38RepositoryCreate.gxTpr_Copyfromapplicationid = AV16CopyFromApplicationId;
                  AV38RepositoryCreate.gxTpr_Copyapplicationrolepermissions = AV15CopyApplicationRolePermissions;
               }
               AV32isOK = new GeneXus.Programs.genexussecurity.SdtGAM(context).createrepository(AV38RepositoryCreate, AV41UpdateConnectionFile, out  AV23Errors);
               if ( AV32isOK )
               {
                  context.CommitDataStores("gamexamplerepositoryentry",pr_default);
                  if ( AV31isGAMAdminAccessRepository )
                  {
                     AV40RepositoryNew = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).getbyguid(AV29GUID, out  AV23Errors);
                     AV26GAMUser = new GeneXus.Programs.genexussecurity.SdtGAMUser(context).get();
                     AV32isOK = new GeneXus.Programs.genexussecurity.SdtGAM(context).repositoryuserenable(AV40RepositoryNew.gxTpr_Id, AV26GAMUser, AV5AdministratorRoleId, out  AV23Errors);
                     if ( AV32isOK )
                     {
                        context.CommitDataStores("gamexamplerepositoryentry",pr_default);
                     }
                  }
               }
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               AV32isOK = new GeneXus.Programs.genexussecurity.SdtGAM(context).deleterepository(AV37Repository.gxTpr_Guid, out  AV23Errors);
               if ( AV32isOK )
               {
                  context.CommitDataStores("gamexamplerepositoryentry",pr_default);
               }
            }
         }
         if ( AV32isOK )
         {
            context.setWebReturnParms(new Object[] {(String)Gx_mode,(int)AV30Id});
            context.setWebReturnParmsMetadata(new Object[] {"Gx_mode","AV30Id"});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         else
         {
            /* Execute user subroutine: 'DISPLAYERRORS' */
            S112 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38RepositoryCreate", AV38RepositoryCreate);
      }

      protected void E131K2( )
      {
         /* Usecurrentrepositorasmasterauthentication_Click Routine */
         AV25GAMRepository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
         AV34NameSpace = AV25GAMRepository.gxTpr_Namespace;
         AssignAttri("", false, "AV34NameSpace", AV34NameSpace);
         if ( AV42UseCurrentRepositorAsMasterAuthentication )
         {
            edtavNamespace_Visible = 0;
            AssignProp("", false, edtavNamespace_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavNamespace_Visible), 5, 0), true);
            divNamespacecell_Visible = 0;
            AssignProp("", false, divNamespacecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divNamespacecell_Visible), 5, 0), true);
            divTblusecurrentasmasterrepository_Visible = 1;
            AssignProp("", false, divTblusecurrentasmasterrepository_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblusecurrentasmasterrepository_Visible), 5, 0), true);
            AV7AdministratorUserPassword = "";
            AssignAttri("", false, "AV7AdministratorUserPassword", AV7AdministratorUserPassword);
            edtavAdministratoruserpassword_Visible = 0;
            AssignProp("", false, edtavAdministratoruserpassword_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavAdministratoruserpassword_Visible), 5, 0), true);
            AV10ConfAdministratorUserPassword = "";
            AssignAttri("", false, "AV10ConfAdministratorUserPassword", AV10ConfAdministratorUserPassword);
            edtavConfadministratoruserpassword_Visible = 0;
            AssignProp("", false, edtavConfadministratoruserpassword_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavConfadministratoruserpassword_Visible), 5, 0), true);
         }
         else
         {
            edtavNamespace_Visible = 1;
            AssignProp("", false, edtavNamespace_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavNamespace_Visible), 5, 0), true);
            divNamespacecell_Visible = 1;
            AssignProp("", false, divNamespacecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divNamespacecell_Visible), 5, 0), true);
            divTblusecurrentasmasterrepository_Visible = 0;
            AssignProp("", false, divTblusecurrentasmasterrepository_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblusecurrentasmasterrepository_Visible), 5, 0), true);
            edtavAdministratoruserpassword_Visible = 1;
            AssignProp("", false, edtavAdministratoruserpassword_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavAdministratoruserpassword_Visible), 5, 0), true);
            edtavConfadministratoruserpassword_Visible = 1;
            AssignProp("", false, edtavConfadministratoruserpassword_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavConfadministratoruserpassword_Visible), 5, 0), true);
         }
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'DISPLAYERRORS' Routine */
         AV47GXV2 = 1;
         while ( AV47GXV2 <= AV23Errors.Count )
         {
            AV22Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV23Errors.Item(AV47GXV2));
            GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV22Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV22Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
            AV47GXV2 = (int)(AV47GXV2+1);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E141K2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         Gx_mode = (String)getParm(obj,0);
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         AV30Id = Convert.ToInt32(getParm(obj,1));
         AssignAttri("", false, "AV30Id", StringUtil.LTrimStr( (decimal)(AV30Id), 9, 0));
         AssignAttri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV30Id), "ZZZZZZZZ9"), context));
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
         PA1K2( ) ;
         WS1K2( ) ;
         WE1K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20204151182043", true, true);
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
         context.AddJavascriptSource("gamexamplerepositoryentry.js", "?20204151182048", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         chkavUsecurrentrepositorasmasterauthentication.Name = "vUSECURRENTREPOSITORASMASTERAUTHENTICATION";
         chkavUsecurrentrepositorasmasterauthentication.WebTags = "";
         chkavUsecurrentrepositorasmasterauthentication.Caption = "";
         AssignProp("", false, chkavUsecurrentrepositorasmasterauthentication_Internalname, "TitleCaption", chkavUsecurrentrepositorasmasterauthentication.Caption, true);
         chkavUsecurrentrepositorasmasterauthentication.CheckedValue = "false";
         AV42UseCurrentRepositorAsMasterAuthentication = StringUtil.StrToBool( StringUtil.BoolToStr( AV42UseCurrentRepositorAsMasterAuthentication));
         AssignAttri("", false, "AV42UseCurrentRepositorAsMasterAuthentication", AV42UseCurrentRepositorAsMasterAuthentication);
         cmbavGeneratesessionstatistics.Name = "vGENERATESESSIONSTATISTICS";
         cmbavGeneratesessionstatistics.WebTags = "";
         cmbavGeneratesessionstatistics.addItem("None", "None", 0);
         cmbavGeneratesessionstatistics.addItem("Minimum", "Minimum (Only authenticated users)", 0);
         cmbavGeneratesessionstatistics.addItem("Detail", "Detail (Authenticated and anonymous users)", 0);
         cmbavGeneratesessionstatistics.addItem("Full", "Full log (Authenticated and anonymous users)", 0);
         if ( cmbavGeneratesessionstatistics.ItemCount > 0 )
         {
            AV27GenerateSessionStatistics = cmbavGeneratesessionstatistics.getValidValue(AV27GenerateSessionStatistics);
            AssignAttri("", false, "AV27GenerateSessionStatistics", AV27GenerateSessionStatistics);
         }
         chkavUpdateconnectionfile.Name = "vUPDATECONNECTIONFILE";
         chkavUpdateconnectionfile.WebTags = "";
         chkavUpdateconnectionfile.Caption = "";
         AssignProp("", false, chkavUpdateconnectionfile_Internalname, "TitleCaption", chkavUpdateconnectionfile.Caption, true);
         chkavUpdateconnectionfile.CheckedValue = "false";
         AV41UpdateConnectionFile = StringUtil.StrToBool( StringUtil.BoolToStr( AV41UpdateConnectionFile));
         AssignAttri("", false, "AV41UpdateConnectionFile", AV41UpdateConnectionFile);
         chkavIsgamadminaccessrepository.Name = "vISGAMADMINACCESSREPOSITORY";
         chkavIsgamadminaccessrepository.WebTags = "";
         chkavIsgamadminaccessrepository.Caption = "";
         AssignProp("", false, chkavIsgamadminaccessrepository_Internalname, "TitleCaption", chkavIsgamadminaccessrepository.Caption, true);
         chkavIsgamadminaccessrepository.CheckedValue = "false";
         AV31isGAMAdminAccessRepository = StringUtil.StrToBool( StringUtil.BoolToStr( AV31isGAMAdminAccessRepository));
         AssignAttri("", false, "AV31isGAMAdminAccessRepository", AV31isGAMAdminAccessRepository);
         chkavCreategamapplication.Name = "vCREATEGAMAPPLICATION";
         chkavCreategamapplication.WebTags = "";
         chkavCreategamapplication.Caption = "";
         AssignProp("", false, chkavCreategamapplication_Internalname, "TitleCaption", chkavCreategamapplication.Caption, true);
         chkavCreategamapplication.CheckedValue = "false";
         AV20CreateGAMApplication = StringUtil.StrToBool( StringUtil.BoolToStr( AV20CreateGAMApplication));
         AssignAttri("", false, "AV20CreateGAMApplication", AV20CreateGAMApplication);
         cmbavCopyfromrepositoryid.Name = "vCOPYFROMREPOSITORYID";
         cmbavCopyfromrepositoryid.WebTags = "";
         if ( cmbavCopyfromrepositoryid.ItemCount > 0 )
         {
            AV17CopyFromRepositoryId = (int)(NumberUtil.Val( cmbavCopyfromrepositoryid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17CopyFromRepositoryId), 9, 0))), "."));
            AssignAttri("", false, "AV17CopyFromRepositoryId", StringUtil.LTrimStr( (decimal)(AV17CopyFromRepositoryId), 9, 0));
         }
         chkavCopyroles.Name = "vCOPYROLES";
         chkavCopyroles.WebTags = "";
         chkavCopyroles.Caption = "";
         AssignProp("", false, chkavCopyroles_Internalname, "TitleCaption", chkavCopyroles.Caption, true);
         chkavCopyroles.CheckedValue = "false";
         AV18CopyRoles = StringUtil.StrToBool( StringUtil.BoolToStr( AV18CopyRoles));
         AssignAttri("", false, "AV18CopyRoles", AV18CopyRoles);
         chkavCopysecuritypolicies.Name = "vCOPYSECURITYPOLICIES";
         chkavCopysecuritypolicies.WebTags = "";
         chkavCopysecuritypolicies.Caption = "";
         AssignProp("", false, chkavCopysecuritypolicies_Internalname, "TitleCaption", chkavCopysecuritypolicies.Caption, true);
         chkavCopysecuritypolicies.CheckedValue = "false";
         AV19CopySecurityPolicies = StringUtil.StrToBool( StringUtil.BoolToStr( AV19CopySecurityPolicies));
         AssignAttri("", false, "AV19CopySecurityPolicies", AV19CopySecurityPolicies);
         chkavCopyapplication.Name = "vCOPYAPPLICATION";
         chkavCopyapplication.WebTags = "";
         chkavCopyapplication.Caption = "";
         AssignProp("", false, chkavCopyapplication_Internalname, "TitleCaption", chkavCopyapplication.Caption, true);
         chkavCopyapplication.CheckedValue = "false";
         AV14CopyApplication = StringUtil.StrToBool( StringUtil.BoolToStr( AV14CopyApplication));
         AssignAttri("", false, "AV14CopyApplication", AV14CopyApplication);
         chkavCopyapplicationrolepermissions.Name = "vCOPYAPPLICATIONROLEPERMISSIONS";
         chkavCopyapplicationrolepermissions.WebTags = "";
         chkavCopyapplicationrolepermissions.Caption = "";
         AssignProp("", false, chkavCopyapplicationrolepermissions_Internalname, "TitleCaption", chkavCopyapplicationrolepermissions.Caption, true);
         chkavCopyapplicationrolepermissions.CheckedValue = "false";
         AV15CopyApplicationRolePermissions = StringUtil.StrToBool( StringUtil.BoolToStr( AV15CopyApplicationRolePermissions));
         AssignAttri("", false, "AV15CopyApplicationRolePermissions", AV15CopyApplicationRolePermissions);
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         divTable1_Internalname = "TABLE1";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         edtavGuid_Internalname = "vGUID";
         divGuidcell_Internalname = "GUIDCELL";
         edtavName_Internalname = "vNAME";
         edtavDescription_Internalname = "vDESCRIPTION";
         chkavUsecurrentrepositorasmasterauthentication_Internalname = "vUSECURRENTREPOSITORASMASTERAUTHENTICATION";
         edtavNamespace_Internalname = "vNAMESPACE";
         divNamespacecell_Internalname = "NAMESPACECELL";
         cmbavGeneratesessionstatistics_Internalname = "vGENERATESESSIONSTATISTICS";
         edtavConnectionusername_Internalname = "vCONNECTIONUSERNAME";
         edtavConnectionuserpassword_Internalname = "vCONNECTIONUSERPASSWORD";
         edtavConfconnectionuserpassword_Internalname = "vCONFCONNECTIONUSERPASSWORD";
         edtavAuthenticationmasterauthtypename_Internalname = "vAUTHENTICATIONMASTERAUTHTYPENAME";
         divTblusecurrentasmasterrepository_Internalname = "TBLUSECURRENTASMASTERREPOSITORY";
         edtavAdministratorusername_Internalname = "vADMINISTRATORUSERNAME";
         edtavAdministratoruserpassword_Internalname = "vADMINISTRATORUSERPASSWORD";
         edtavConfadministratoruserpassword_Internalname = "vCONFADMINISTRATORUSERPASSWORD";
         divTbluserssettings_Internalname = "TBLUSERSSETTINGS";
         chkavUpdateconnectionfile_Internalname = "vUPDATECONNECTIONFILE";
         divTbupdconnfile_Internalname = "TBUPDCONNFILE";
         chkavIsgamadminaccessrepository_Internalname = "vISGAMADMINACCESSREPOSITORY";
         chkavCreategamapplication_Internalname = "vCREATEGAMAPPLICATION";
         divTab1_Internalname = "TAB1";
         lblCopyrepositorydata_title_Internalname = "COPYREPOSITORYDATA_TITLE";
         cmbavCopyfromrepositoryid_Internalname = "vCOPYFROMREPOSITORYID";
         chkavCopyroles_Internalname = "vCOPYROLES";
         edtavAdministratorroleid_Internalname = "vADMINISTRATORROLEID";
         divAdminroleidcell_Internalname = "ADMINROLEIDCELL";
         chkavCopysecuritypolicies_Internalname = "vCOPYSECURITYPOLICIES";
         chkavCopyapplication_Internalname = "vCOPYAPPLICATION";
         edtavCopyfromapplicationid_Internalname = "vCOPYFROMAPPLICATIONID";
         divCopyfrommappidcell_Internalname = "COPYFROMMAPPIDCELL";
         chkavCopyapplicationrolepermissions_Internalname = "vCOPYAPPLICATIONROLEPERMISSIONS";
         divCopyapplicationtable_Internalname = "COPYAPPLICATIONTABLE";
         divTabpage3table_Internalname = "TABPAGE3TABLE";
         Tab2_Internalname = "TAB2";
         bttBtncancel_Internalname = "BTNCANCEL";
         bttBtnconfirm_Internalname = "BTNCONFIRM";
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
         chkavCopyapplicationrolepermissions.Caption = "Copy Roles Permissions?";
         chkavCopyapplication.Caption = "Copy Application? (Menus and Permissions)";
         chkavCopysecuritypolicies.Caption = "Copy Security Policies?";
         chkavCopyroles.Caption = "Copy Roles?";
         chkavCreategamapplication.Caption = "Create GAM Backend application?";
         chkavIsgamadminaccessrepository.Caption = "Is the current user an administrator of the new repository? ";
         chkavUpdateconnectionfile.Caption = "Update connection.gam file";
         chkavUsecurrentrepositorasmasterauthentication.Caption = "Use the current repository as the authentication master repository";
         bttBtnconfirm_Caption = "Confirm";
         chkavCopyapplicationrolepermissions.Enabled = 1;
         edtavCopyfromapplicationid_Jsonclick = "";
         edtavCopyfromapplicationid_Enabled = 1;
         divCopyfrommappidcell_Visible = 1;
         chkavCopyapplication.Enabled = 1;
         chkavCopysecuritypolicies.Enabled = 1;
         edtavAdministratorroleid_Jsonclick = "";
         edtavAdministratorroleid_Enabled = 1;
         divAdminroleidcell_Visible = 1;
         chkavCopyroles.Enabled = 1;
         cmbavCopyfromrepositoryid_Jsonclick = "";
         cmbavCopyfromrepositoryid.Enabled = 1;
         divCopyapplicationtable_Visible = 1;
         chkavCreategamapplication.Enabled = 1;
         chkavIsgamadminaccessrepository.Enabled = 1;
         chkavUpdateconnectionfile.Enabled = 1;
         chkavUpdateconnectionfile.Visible = 1;
         divTbupdconnfile_Visible = 1;
         edtavConfadministratoruserpassword_Jsonclick = "";
         edtavConfadministratoruserpassword_Enabled = 1;
         edtavConfadministratoruserpassword_Visible = 1;
         edtavAdministratoruserpassword_Jsonclick = "";
         edtavAdministratoruserpassword_Enabled = 1;
         edtavAdministratoruserpassword_Visible = 1;
         edtavAdministratorusername_Jsonclick = "";
         edtavAdministratorusername_Enabled = 1;
         edtavAuthenticationmasterauthtypename_Jsonclick = "";
         edtavAuthenticationmasterauthtypename_Enabled = 1;
         divTblusecurrentasmasterrepository_Visible = 1;
         edtavConfconnectionuserpassword_Jsonclick = "";
         edtavConfconnectionuserpassword_Enabled = 1;
         edtavConnectionuserpassword_Jsonclick = "";
         edtavConnectionuserpassword_Enabled = 1;
         edtavConnectionusername_Jsonclick = "";
         edtavConnectionusername_Enabled = 1;
         divTbluserssettings_Visible = 1;
         cmbavGeneratesessionstatistics_Jsonclick = "";
         cmbavGeneratesessionstatistics.Enabled = 1;
         edtavNamespace_Jsonclick = "";
         edtavNamespace_Enabled = 1;
         edtavNamespace_Visible = 1;
         divNamespacecell_Visible = 1;
         chkavUsecurrentrepositorasmasterauthentication.Enabled = 1;
         edtavDescription_Jsonclick = "";
         edtavDescription_Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 1;
         edtavGuid_Jsonclick = "";
         edtavGuid_Enabled = 1;
         divGuidcell_Visible = 1;
         Tab2_Historymanagement = Convert.ToBoolean( 0);
         Tab2_Class = "Tab";
         Tab2_Pagecount = 2;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Repository ";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV30Id',fld:'vID',pic:'ZZZZZZZZ9',hsh:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:'',hsh:true},{av:'AV42UseCurrentRepositorAsMasterAuthentication',fld:'vUSECURRENTREPOSITORASMASTERAUTHENTICATION',pic:''},{av:'AV41UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:''},{av:'AV31isGAMAdminAccessRepository',fld:'vISGAMADMINACCESSREPOSITORY',pic:''},{av:'AV20CreateGAMApplication',fld:'vCREATEGAMAPPLICATION',pic:''},{av:'AV18CopyRoles',fld:'vCOPYROLES',pic:''},{av:'AV19CopySecurityPolicies',fld:'vCOPYSECURITYPOLICIES',pic:''},{av:'AV14CopyApplication',fld:'vCOPYAPPLICATION',pic:''},{av:'AV15CopyApplicationRolePermissions',fld:'vCOPYAPPLICATIONROLEPERMISSIONS',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV42UseCurrentRepositorAsMasterAuthentication',fld:'vUSECURRENTREPOSITORASMASTERAUTHENTICATION',pic:''},{av:'AV41UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:''},{av:'AV31isGAMAdminAccessRepository',fld:'vISGAMADMINACCESSREPOSITORY',pic:''},{av:'AV20CreateGAMApplication',fld:'vCREATEGAMAPPLICATION',pic:''},{av:'AV18CopyRoles',fld:'vCOPYROLES',pic:''},{av:'AV19CopySecurityPolicies',fld:'vCOPYSECURITYPOLICIES',pic:''},{av:'AV14CopyApplication',fld:'vCOPYAPPLICATION',pic:''},{av:'AV15CopyApplicationRolePermissions',fld:'vCOPYAPPLICATIONROLEPERMISSIONS',pic:''}]}");
         setEventMetadata("ENTER","{handler:'E121K2',iparms:[{av:'AV30Id',fld:'vID',pic:'ZZZZZZZZ9',hsh:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7AdministratorUserPassword',fld:'vADMINISTRATORUSERPASSWORD',pic:''},{av:'AV10ConfAdministratorUserPassword',fld:'vCONFADMINISTRATORUSERPASSWORD',pic:''},{av:'AV13ConnectionUserPassword',fld:'vCONNECTIONUSERPASSWORD',pic:''},{av:'AV11ConfConnectionUserPassword',fld:'vCONFCONNECTIONUSERPASSWORD',pic:''},{av:'AV33Name',fld:'vNAME',pic:''},{av:'AV34NameSpace',fld:'vNAMESPACE',pic:''},{av:'AV21Description',fld:'vDESCRIPTION',pic:''},{av:'AV6AdministratorUserName',fld:'vADMINISTRATORUSERNAME',pic:''},{av:'AV8AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:'',hsh:true},{av:'AV12ConnectionUserName',fld:'vCONNECTIONUSERNAME',pic:''},{av:'cmbavGeneratesessionstatistics'},{av:'AV27GenerateSessionStatistics',fld:'vGENERATESESSIONSTATISTICS',pic:''},{av:'AV9AuthenticationMasterAuthTypeName',fld:'vAUTHENTICATIONMASTERAUTHTYPENAME',pic:''},{av:'cmbavCopyfromrepositoryid'},{av:'AV17CopyFromRepositoryId',fld:'vCOPYFROMREPOSITORYID',pic:'ZZZZZZZZ9'},{av:'AV5AdministratorRoleId',fld:'vADMINISTRATORROLEID',pic:'ZZZZZZZZZZZ9'},{av:'AV16CopyFromApplicationId',fld:'vCOPYFROMAPPLICATIONID',pic:'ZZZZZZZZZZZ9'},{av:'AV42UseCurrentRepositorAsMasterAuthentication',fld:'vUSECURRENTREPOSITORASMASTERAUTHENTICATION',pic:''},{av:'AV41UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:''},{av:'AV31isGAMAdminAccessRepository',fld:'vISGAMADMINACCESSREPOSITORY',pic:''},{av:'AV20CreateGAMApplication',fld:'vCREATEGAMAPPLICATION',pic:''},{av:'AV18CopyRoles',fld:'vCOPYROLES',pic:''},{av:'AV19CopySecurityPolicies',fld:'vCOPYSECURITYPOLICIES',pic:''},{av:'AV14CopyApplication',fld:'vCOPYAPPLICATION',pic:''},{av:'AV15CopyApplicationRolePermissions',fld:'vCOPYAPPLICATIONROLEPERMISSIONS',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV29GUID',fld:'vGUID',pic:''},{av:'AV42UseCurrentRepositorAsMasterAuthentication',fld:'vUSECURRENTREPOSITORASMASTERAUTHENTICATION',pic:''},{av:'AV41UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:''},{av:'AV31isGAMAdminAccessRepository',fld:'vISGAMADMINACCESSREPOSITORY',pic:''},{av:'AV20CreateGAMApplication',fld:'vCREATEGAMAPPLICATION',pic:''},{av:'AV18CopyRoles',fld:'vCOPYROLES',pic:''},{av:'AV19CopySecurityPolicies',fld:'vCOPYSECURITYPOLICIES',pic:''},{av:'AV14CopyApplication',fld:'vCOPYAPPLICATION',pic:''},{av:'AV15CopyApplicationRolePermissions',fld:'vCOPYAPPLICATIONROLEPERMISSIONS',pic:''}]}");
         setEventMetadata("VUSECURRENTREPOSITORASMASTERAUTHENTICATION.CLICK","{handler:'E131K2',iparms:[{av:'AV42UseCurrentRepositorAsMasterAuthentication',fld:'vUSECURRENTREPOSITORASMASTERAUTHENTICATION',pic:''},{av:'AV41UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:''},{av:'AV31isGAMAdminAccessRepository',fld:'vISGAMADMINACCESSREPOSITORY',pic:''},{av:'AV20CreateGAMApplication',fld:'vCREATEGAMAPPLICATION',pic:''},{av:'AV18CopyRoles',fld:'vCOPYROLES',pic:''},{av:'AV19CopySecurityPolicies',fld:'vCOPYSECURITYPOLICIES',pic:''},{av:'AV14CopyApplication',fld:'vCOPYAPPLICATION',pic:''},{av:'AV15CopyApplicationRolePermissions',fld:'vCOPYAPPLICATIONROLEPERMISSIONS',pic:''}]");
         setEventMetadata("VUSECURRENTREPOSITORASMASTERAUTHENTICATION.CLICK",",oparms:[{av:'AV34NameSpace',fld:'vNAMESPACE',pic:''},{av:'AV7AdministratorUserPassword',fld:'vADMINISTRATORUSERPASSWORD',pic:''},{av:'AV10ConfAdministratorUserPassword',fld:'vCONFADMINISTRATORUSERPASSWORD',pic:''},{av:'edtavNamespace_Visible',ctrl:'vNAMESPACE',prop:'Visible'},{av:'divNamespacecell_Visible',ctrl:'NAMESPACECELL',prop:'Visible'},{av:'divTblusecurrentasmasterrepository_Visible',ctrl:'TBLUSECURRENTASMASTERREPOSITORY',prop:'Visible'},{av:'edtavAdministratoruserpassword_Visible',ctrl:'vADMINISTRATORUSERPASSWORD',prop:'Visible'},{av:'edtavConfadministratoruserpassword_Visible',ctrl:'vCONFADMINISTRATORUSERPASSWORD',prop:'Visible'},{av:'AV42UseCurrentRepositorAsMasterAuthentication',fld:'vUSECURRENTREPOSITORASMASTERAUTHENTICATION',pic:''},{av:'AV41UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:''},{av:'AV31isGAMAdminAccessRepository',fld:'vISGAMADMINACCESSREPOSITORY',pic:''},{av:'AV20CreateGAMApplication',fld:'vCREATEGAMAPPLICATION',pic:''},{av:'AV18CopyRoles',fld:'vCOPYROLES',pic:''},{av:'AV19CopySecurityPolicies',fld:'vCOPYSECURITYPOLICIES',pic:''},{av:'AV14CopyApplication',fld:'vCOPYAPPLICATION',pic:''},{av:'AV15CopyApplicationRolePermissions',fld:'vCOPYAPPLICATIONROLEPERMISSIONS',pic:''}]}");
         setEventMetadata("VALIDV_GENERATESESSIONSTATISTICS","{handler:'Validv_Generatesessionstatistics',iparms:[{av:'AV42UseCurrentRepositorAsMasterAuthentication',fld:'vUSECURRENTREPOSITORASMASTERAUTHENTICATION',pic:''},{av:'AV41UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:''},{av:'AV31isGAMAdminAccessRepository',fld:'vISGAMADMINACCESSREPOSITORY',pic:''},{av:'AV20CreateGAMApplication',fld:'vCREATEGAMAPPLICATION',pic:''},{av:'AV18CopyRoles',fld:'vCOPYROLES',pic:''},{av:'AV19CopySecurityPolicies',fld:'vCOPYSECURITYPOLICIES',pic:''},{av:'AV14CopyApplication',fld:'vCOPYAPPLICATION',pic:''},{av:'AV15CopyApplicationRolePermissions',fld:'vCOPYAPPLICATIONROLEPERMISSIONS',pic:''}]");
         setEventMetadata("VALIDV_GENERATESESSIONSTATISTICS",",oparms:[{av:'AV42UseCurrentRepositorAsMasterAuthentication',fld:'vUSECURRENTREPOSITORASMASTERAUTHENTICATION',pic:''},{av:'AV41UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:''},{av:'AV31isGAMAdminAccessRepository',fld:'vISGAMADMINACCESSREPOSITORY',pic:''},{av:'AV20CreateGAMApplication',fld:'vCREATEGAMAPPLICATION',pic:''},{av:'AV18CopyRoles',fld:'vCOPYROLES',pic:''},{av:'AV19CopySecurityPolicies',fld:'vCOPYSECURITYPOLICIES',pic:''},{av:'AV14CopyApplication',fld:'vCOPYAPPLICATION',pic:''},{av:'AV15CopyApplicationRolePermissions',fld:'vCOPYAPPLICATIONROLEPERMISSIONS',pic:''}]}");
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
         wcpOGx_mode = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         ucTab2 = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         TempTags = "";
         AV29GUID = "";
         AV33Name = "";
         AV21Description = "";
         AV34NameSpace = "";
         AV27GenerateSessionStatistics = "";
         AV12ConnectionUserName = "";
         AV13ConnectionUserPassword = "";
         AV11ConfConnectionUserPassword = "";
         AV9AuthenticationMasterAuthTypeName = "";
         AV6AdministratorUserName = "";
         AV7AdministratorUserPassword = "";
         AV10ConfAdministratorUserPassword = "";
         lblCopyrepositorydata_title_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         bttBtnconfirm_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV37Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV23Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV36Repositories = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMRepository>( context, "GeneXus.Programs.genexussecurity.SdtGAMRepository", "GeneXus.Programs");
         AV39RepositoryFilter = new GeneXus.Programs.genexussecurity.SdtGAMRepositoryFilter(context);
         AV35Repo = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV38RepositoryCreate = new GeneXus.Programs.genexussecurity.SdtGAMRepositoryCreate(context);
         AV25GAMRepository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV40RepositoryNew = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV26GAMUser = new GeneXus.Programs.genexussecurity.SdtGAMUser(context);
         AV22Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamexamplerepositoryentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamexamplerepositoryentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int AV30Id ;
      private int wcpOAV30Id ;
      private int Tab2_Pagecount ;
      private int divGuidcell_Visible ;
      private int edtavGuid_Enabled ;
      private int edtavName_Enabled ;
      private int edtavDescription_Enabled ;
      private int divNamespacecell_Visible ;
      private int edtavNamespace_Visible ;
      private int edtavNamespace_Enabled ;
      private int divTbluserssettings_Visible ;
      private int edtavConnectionusername_Enabled ;
      private int edtavConnectionuserpassword_Enabled ;
      private int edtavConfconnectionuserpassword_Enabled ;
      private int divTblusecurrentasmasterrepository_Visible ;
      private int edtavAuthenticationmasterauthtypename_Enabled ;
      private int edtavAdministratorusername_Enabled ;
      private int edtavAdministratoruserpassword_Visible ;
      private int edtavAdministratoruserpassword_Enabled ;
      private int edtavConfadministratoruserpassword_Visible ;
      private int edtavConfadministratoruserpassword_Enabled ;
      private int divTbupdconnfile_Visible ;
      private int divCopyapplicationtable_Visible ;
      private int AV17CopyFromRepositoryId ;
      private int divAdminroleidcell_Visible ;
      private int edtavAdministratorroleid_Enabled ;
      private int divCopyfrommappidcell_Visible ;
      private int edtavCopyfromapplicationid_Enabled ;
      private int AV46GXV1 ;
      private int AV47GXV2 ;
      private int idxLst ;
      private long AV5AdministratorRoleId ;
      private long AV16CopyFromApplicationId ;
      private String Gx_mode ;
      private String wcpOGx_mode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Tab2_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String Tab2_Internalname ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divTab1_Internalname ;
      private String divGuidcell_Internalname ;
      private String edtavGuid_Internalname ;
      private String TempTags ;
      private String AV29GUID ;
      private String edtavGuid_Jsonclick ;
      private String edtavName_Internalname ;
      private String AV33Name ;
      private String edtavName_Jsonclick ;
      private String edtavDescription_Internalname ;
      private String AV21Description ;
      private String edtavDescription_Jsonclick ;
      private String chkavUsecurrentrepositorasmasterauthentication_Internalname ;
      private String divNamespacecell_Internalname ;
      private String edtavNamespace_Internalname ;
      private String AV34NameSpace ;
      private String edtavNamespace_Jsonclick ;
      private String cmbavGeneratesessionstatistics_Internalname ;
      private String AV27GenerateSessionStatistics ;
      private String cmbavGeneratesessionstatistics_Jsonclick ;
      private String divTbluserssettings_Internalname ;
      private String edtavConnectionusername_Internalname ;
      private String AV12ConnectionUserName ;
      private String edtavConnectionusername_Jsonclick ;
      private String edtavConnectionuserpassword_Internalname ;
      private String AV13ConnectionUserPassword ;
      private String edtavConnectionuserpassword_Jsonclick ;
      private String edtavConfconnectionuserpassword_Internalname ;
      private String AV11ConfConnectionUserPassword ;
      private String edtavConfconnectionuserpassword_Jsonclick ;
      private String divTblusecurrentasmasterrepository_Internalname ;
      private String edtavAuthenticationmasterauthtypename_Internalname ;
      private String AV9AuthenticationMasterAuthTypeName ;
      private String edtavAuthenticationmasterauthtypename_Jsonclick ;
      private String edtavAdministratorusername_Internalname ;
      private String AV6AdministratorUserName ;
      private String edtavAdministratorusername_Jsonclick ;
      private String edtavAdministratoruserpassword_Internalname ;
      private String AV7AdministratorUserPassword ;
      private String edtavAdministratoruserpassword_Jsonclick ;
      private String edtavConfadministratoruserpassword_Internalname ;
      private String AV10ConfAdministratorUserPassword ;
      private String edtavConfadministratoruserpassword_Jsonclick ;
      private String divTbupdconnfile_Internalname ;
      private String chkavUpdateconnectionfile_Internalname ;
      private String chkavIsgamadminaccessrepository_Internalname ;
      private String chkavCreategamapplication_Internalname ;
      private String lblCopyrepositorydata_title_Internalname ;
      private String lblCopyrepositorydata_title_Jsonclick ;
      private String divTabpage3table_Internalname ;
      private String divCopyapplicationtable_Internalname ;
      private String cmbavCopyfromrepositoryid_Internalname ;
      private String cmbavCopyfromrepositoryid_Jsonclick ;
      private String chkavCopyroles_Internalname ;
      private String divAdminroleidcell_Internalname ;
      private String edtavAdministratorroleid_Internalname ;
      private String edtavAdministratorroleid_Jsonclick ;
      private String chkavCopysecuritypolicies_Internalname ;
      private String chkavCopyapplication_Internalname ;
      private String divCopyfrommappidcell_Internalname ;
      private String edtavCopyfromapplicationid_Internalname ;
      private String edtavCopyfromapplicationid_Jsonclick ;
      private String chkavCopyapplicationrolepermissions_Internalname ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String bttBtnconfirm_Internalname ;
      private String bttBtnconfirm_Caption ;
      private String bttBtnconfirm_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV8AllowOauthAccess ;
      private bool Tab2_Historymanagement ;
      private bool wbLoad ;
      private bool AV42UseCurrentRepositorAsMasterAuthentication ;
      private bool AV41UpdateConnectionFile ;
      private bool AV31isGAMAdminAccessRepository ;
      private bool AV20CreateGAMApplication ;
      private bool AV18CopyRoles ;
      private bool AV19CopySecurityPolicies ;
      private bool AV14CopyApplication ;
      private bool AV15CopyApplicationRolePermissions ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV32isOK ;
      private GXUserControl ucTab2 ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private String aP0_Gx_mode ;
      private int aP1_Id ;
      private GXCheckbox chkavUsecurrentrepositorasmasterauthentication ;
      private GXCombobox cmbavGeneratesessionstatistics ;
      private GXCheckbox chkavUpdateconnectionfile ;
      private GXCheckbox chkavIsgamadminaccessrepository ;
      private GXCheckbox chkavCreategamapplication ;
      private GXCombobox cmbavCopyfromrepositoryid ;
      private GXCheckbox chkavCopyroles ;
      private GXCheckbox chkavCopysecuritypolicies ;
      private GXCheckbox chkavCopyapplication ;
      private GXCheckbox chkavCopyapplicationrolepermissions ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV23Errors ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMRepository> AV36Repositories ;
      private GXWebForm Form ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV22Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepositoryCreate AV38RepositoryCreate ;
      private GeneXus.Programs.genexussecurity.SdtGAMUser AV26GAMUser ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV37Repository ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV35Repo ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV25GAMRepository ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV40RepositoryNew ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepositoryFilter AV39RepositoryFilter ;
   }

   public class gamexamplerepositoryentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamexamplerepositoryentry__default : DataStoreHelperBase, IDataStoreHelper
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
