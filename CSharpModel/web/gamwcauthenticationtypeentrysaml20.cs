/*
               File: GAMWCAuthenticationTypeEntrySaml20
        Description: GAMWCAuthentication Type Entry Saml20
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:2:29.39
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
   public class gamwcauthenticationtypeentrysaml20 : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public gamwcauthenticationtypeentrysaml20( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public gamwcauthenticationtypeentrysaml20( IGxContext context )
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
                           ref String aP1_Name ,
                           ref String aP2_TypeId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV33Name = aP1_Name;
         this.AV41TypeId = aP2_TypeId;
         executePrivate();
         aP0_Gx_mode=this.Gx_mode;
         aP1_Name=this.AV33Name;
         aP2_TypeId=this.AV41TypeId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         cmbavFunctionid = new GXCombobox();
         chkavIsenable = new GXCheckbox();
         chkavForceauthn = new GXCheckbox();
         cmbavUserinforesponseuserlastnamegenauto = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  Gx_mode = GetNextPar( );
                  AssignAttri(sPrefix, false, "Gx_mode", Gx_mode);
                  AV33Name = GetNextPar( );
                  AssignAttri(sPrefix, false, "AV33Name", AV33Name);
                  AV41TypeId = GetNextPar( );
                  AssignAttri(sPrefix, false, "AV41TypeId", AV41TypeId);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)Gx_mode,(String)AV33Name,(String)AV41TypeId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
               {
                  nRC_GXsfl_261 = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_261_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_261_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrGrid1_newrow( ) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
               {
                  Gx_mode = GetNextPar( );
                  AV20IsEnable = StringUtil.StrToBool( GetNextPar( ));
                  AV15ForceAuthn = StringUtil.StrToBool( GetNextPar( ));
                  AV45UserInfoResponseUserErrorDescriptionTag = GetNextPar( );
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid1_refresh( Gx_mode, AV20IsEnable, AV15ForceAuthn, AV45UserInfoResponseUserErrorDescriptionTag, sPrefix) ;
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
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA1Q2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS1Q2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "GAMWCAuthentication Type Entry Saml20") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?20204151122981", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamwcauthenticationtypeentrysaml20.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV33Name)) + "," + UrlEncode(StringUtil.RTrim(AV41TypeId))+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            AssignProp(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vUSERINFORESPONSEUSERERRORDESCRIPTIONTAG", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV45UserInfoResponseUserErrorDescriptionTag, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_261", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_261), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOGx_mode", StringUtil.RTrim( wcpOGx_mode));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV33Name", StringUtil.RTrim( wcpOAV33Name));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV41TypeId", StringUtil.RTrim( wcpOAV41TypeId));
         GxWebStd.gx_hidden_field( context, sPrefix+"vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, sPrefix+"vUSERINFORESPONSEUSERERRORDESCRIPTIONTAG", StringUtil.RTrim( AV45UserInfoResponseUserErrorDescriptionTag));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vUSERINFORESPONSEUSERERRORDESCRIPTIONTAG", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV45UserInfoResponseUserErrorDescriptionTag, "")), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTYPEID", StringUtil.RTrim( AV41TypeId));
         GxWebStd.gx_hidden_field( context, sPrefix+"TAB1_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab1_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"TAB1_Class", StringUtil.RTrim( Tab1_Class));
         GxWebStd.gx_hidden_field( context, sPrefix+"TAB1_Historymanagement", StringUtil.BoolToStr( Tab1_Historymanagement));
         GxWebStd.gx_hidden_field( context, sPrefix+"TBKEYSTOREADVANCED_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(divTbkeystoreadvanced_Visible), 5, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm1Q2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("gamwcauthenticationtypeentrysaml20.js", "?20204151122991", false, true);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "GAMWCAuthenticationTypeEntrySaml20" ;
      }

      public override String GetPgmdesc( )
      {
         return "GAMWCAuthentication Type Entry Saml20" ;
      }

      protected void WB1Q0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "gamwcauthenticationtypeentrysaml20.aspx");
               context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
               context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
               context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
               context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
               context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbldata_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavName_Internalname, "Name", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV33Name), StringUtil.RTrim( context.localUtil.Format( AV33Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,14);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 80, "char", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavFunctionid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavFunctionid_Internalname, "Function", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavFunctionid, cmbavFunctionid_Internalname, StringUtil.RTrim( AV16FunctionId), 1, cmbavFunctionid_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavFunctionid.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,19);\"", "", true, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            cmbavFunctionid.CurrentValue = StringUtil.RTrim( AV16FunctionId);
            AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Values", (String)(cmbavFunctionid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavIsenable_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavIsenable_Internalname, "Enabled?", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavIsenable_Internalname, StringUtil.BoolToStr( AV20IsEnable), "", "Enabled?", 1, chkavIsenable.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(24, this, 'true', 'false',"+"'"+sPrefix+"'"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,24);\"");
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
            GxWebStd.gx_label_element( context, edtavDsc_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDsc_Internalname, StringUtil.RTrim( AV10Dsc), StringUtil.RTrim( context.localUtil.Format( AV10Dsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,29);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDsc_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSmallimagename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSmallimagename_Internalname, "Small image name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSmallimagename_Internalname, StringUtil.RTrim( AV40SmallImageName), StringUtil.RTrim( context.localUtil.Format( AV40SmallImageName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSmallimagename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSmallimagename_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBigimagename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBigimagename_Internalname, "Big image name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBigimagename_Internalname, StringUtil.RTrim( AV7BigImageName), StringUtil.RTrim( context.localUtil.Format( AV7BigImageName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBigimagename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBigimagename_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavImpersonate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavImpersonate_Internalname, "Impersonate", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavImpersonate_Internalname, StringUtil.RTrim( AV19Impersonate), StringUtil.RTrim( context.localUtil.Format( AV19Impersonate, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavImpersonate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavImpersonate_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMAuthenticationTypeName", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
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
            GxWebStd.gx_div_start( context, divTbloauth20_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTab1.SetProperty("PageCount", Tab1_Pagecount);
            ucTab1.SetProperty("Class", Tab1_Class);
            ucTab1.SetProperty("HistoryManagement", Tab1_Historymanagement);
            ucTab1.Render(context, "tab", Tab1_Internalname, sPrefix+"TAB1Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"TAB1Container"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"TAB1Container"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavForceauthn_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavForceauthn_Internalname, "Force Authentication", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavForceauthn_Internalname, StringUtil.BoolToStr( AV15ForceAuthn), "", "Force Authentication", 1, chkavForceauthn.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(60, this, 'true', 'false',"+"'"+sPrefix+"'"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,60);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAuthncontext_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAuthncontext_Internalname, "Authentication Context", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAuthncontext_Internalname, StringUtil.RTrim( AV6AuthnContext), StringUtil.RTrim( context.localUtil.Format( AV6AuthnContext, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,65);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAuthncontext_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavAuthncontext_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavLocalsiteurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavLocalsiteurl_Internalname, "Local Site URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavLocalsiteurl_Internalname, AV31LocalSiteURL, StringUtil.RTrim( context.localUtil.Format( AV31LocalSiteURL, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,70);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavLocalsiteurl_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavLocalsiteurl_Enabled, 1, "text", "", 80, "%", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup6_Internalname, "Login", 1, 0, "px", 0, "px", "Group", "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup6table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavIdentityproviderentityid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavIdentityproviderentityid_Internalname, "Identity Provider Entity ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavIdentityproviderentityid_Internalname, AV18IdentityProviderEntityID, StringUtil.RTrim( context.localUtil.Format( AV18IdentityProviderEntityID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,79);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavIdentityproviderentityid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavIdentityproviderentityid_Enabled, 1, "text", "", 80, "%", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavServiceproviderentityid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavServiceproviderentityid_Internalname, "Service Provider Entity ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavServiceproviderentityid_Internalname, AV38ServiceProviderEntityID, StringUtil.RTrim( context.localUtil.Format( AV38ServiceProviderEntityID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,84);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavServiceproviderentityid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavServiceproviderentityid_Enabled, 1, "text", "", 80, "%", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSamlendpointlocation_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSamlendpointlocation_Internalname, "Saml Endpoint Location", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSamlendpointlocation_Internalname, AV37SamlEndpointLocation, StringUtil.RTrim( context.localUtil.Format( AV37SamlEndpointLocation, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,89);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSamlendpointlocation_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSamlendpointlocation_Enabled, 1, "text", "", 80, "%", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup5_Internalname, "Logout", 1, 0, "px", 0, "px", "Group", "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup5table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSinglelogoutendpoint_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSinglelogoutendpoint_Internalname, "Single Logout Endpoint", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSinglelogoutendpoint_Internalname, AV39SingleLogoutendpoint, StringUtil.RTrim( context.localUtil.Format( AV39SingleLogoutendpoint, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,98);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSinglelogoutendpoint_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSinglelogoutendpoint_Enabled, 1, "text", "", 80, "%", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"TAB1Container"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCredentials_title_Internalname, "Credentials", "", "", lblCredentials_title_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Credentials") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"TAB1Container"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage3table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, "Request credentials", 1, 0, "px", 0, "px", "Group", "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup1table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavKeystpathcredential_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKeystpathcredential_Internalname, "Key Store Path", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 112,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKeystpathcredential_Internalname, AV29KeyStPathCredential, StringUtil.RTrim( context.localUtil.Format( AV29KeyStPathCredential, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,112);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKeystpathcredential_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKeystpathcredential_Enabled, 1, "text", "", 50, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavKeystpwdcredential_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKeystpwdcredential_Internalname, "Key Store Password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKeystpwdcredential_Internalname, StringUtil.RTrim( AV30KeyStPwdCredential), StringUtil.RTrim( context.localUtil.Format( AV30KeyStPwdCredential, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,117);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKeystpwdcredential_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKeystpwdcredential_Enabled, 1, "text", "", 50, "chr", 1, "row", 50, -1, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMPassword", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavKeyaliascredential_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKeyaliascredential_Internalname, "Certificate Alias", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKeyaliascredential_Internalname, StringUtil.RTrim( AV22KeyAliasCredential), StringUtil.RTrim( context.localUtil.Format( AV22KeyAliasCredential, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,122);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKeyaliascredential_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKeyaliascredential_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavKeystorecredential_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKeystorecredential_Internalname, "Key Store Format", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKeystorecredential_Internalname, StringUtil.RTrim( AV25KeyStoreCredential), StringUtil.RTrim( context.localUtil.Format( AV25KeyStoreCredential, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,127);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKeystorecredential_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKeystorecredential_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup2_Internalname, "Response credentials", 1, 0, "px", 0, "px", "Group", "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup2table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavKeystorefilepathtrustcred_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKeystorefilepathtrustcred_Internalname, "Certificate Path", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKeystorefilepathtrustcred_Internalname, AV26KeyStoreFilePathTrustCred, StringUtil.RTrim( context.localUtil.Format( AV26KeyStoreFilePathTrustCred, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,136);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKeystorefilepathtrustcred_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKeystorefilepathtrustcred_Enabled, 1, "text", "", 50, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTboauth20authadvanced_Internalname, "Advanced response configuration", "", "", lblTboauth20authadvanced_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+"e111q1_client"+"'", "", "PagingText", 7, "", 1, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbkeystoreadvanced_Internalname, divTbkeystoreadvanced_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavKeystorepwdtrustcred_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKeystorepwdtrustcred_Internalname, "Trust Store Password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 147,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKeystorepwdtrustcred_Internalname, StringUtil.RTrim( AV27KeyStorePwdTrustCred), StringUtil.RTrim( context.localUtil.Format( AV27KeyStorePwdTrustCred, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,147);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKeystorepwdtrustcred_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKeystorepwdtrustcred_Enabled, 1, "text", "", 50, "chr", 1, "row", 50, -1, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMPassword", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavKeyaliastrustcred_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKeyaliastrustcred_Internalname, "Certificate Alias", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKeyaliastrustcred_Internalname, StringUtil.RTrim( AV23KeyAliasTrustCred), StringUtil.RTrim( context.localUtil.Format( AV23KeyAliasTrustCred, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,152);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKeyaliastrustcred_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKeyaliastrustcred_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavKeystoretrustcred_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKeystoretrustcred_Internalname, "Trust Store Format", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 157,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKeystoretrustcred_Internalname, StringUtil.RTrim( AV28KeyStoreTrustCred), StringUtil.RTrim( context.localUtil.Format( AV28KeyStoreTrustCred, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,157);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKeystoretrustcred_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKeystoretrustcred_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"TAB1Container"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblUserinfo_title_Internalname, "User Information", "", "", lblUserinfo_title_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "UserInfo") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"TAB1Container"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup3_Internalname, "Response", 1, 0, "px", 0, "px", "Group", "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup3table1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseuseremailtag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseuseremailtag_Internalname, "User Email Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 171,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseuseremailtag_Internalname, StringUtil.RTrim( AV44UserInfoResponseUserEmailTag), StringUtil.RTrim( context.localUtil.Format( AV44UserInfoResponseUserEmailTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,171);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseuseremailtag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseuseremailtag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseuserexternalidtag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseuserexternalidtag_Internalname, "User External Id Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 176,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseuserexternalidtag_Internalname, StringUtil.RTrim( AV46UserInfoResponseUserExternalIdTag), StringUtil.RTrim( context.localUtil.Format( AV46UserInfoResponseUserExternalIdTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,176);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseuserexternalidtag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseuserexternalidtag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseusernametag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseusernametag_Internalname, "User Name Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 181,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseusernametag_Internalname, StringUtil.RTrim( AV53UserInfoResponseUserNameTag), StringUtil.RTrim( context.localUtil.Format( AV53UserInfoResponseUserNameTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,181);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseusernametag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseusernametag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbluserfirstname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-md-3", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbuserfirstname_Internalname, "User First Name", "", "", lblTbuserfirstname_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseuserfirstnametag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseuserfirstnametag_Internalname, "Tag", "col-sm-3 col-md-2 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-md-10 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 191,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseuserfirstnametag_Internalname, StringUtil.RTrim( AV47UserInfoResponseUserFirstNameTag), StringUtil.RTrim( context.localUtil.Format( AV47UserInfoResponseUserFirstNameTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,191);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseuserfirstnametag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseuserfirstnametag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-md-5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavUserinforesponseuserlastnamegenauto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavUserinforesponseuserlastnamegenauto_Internalname, "Generate automatic Last Name", "col-sm-8 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 195,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavUserinforesponseuserlastnamegenauto, cmbavUserinforesponseuserlastnamegenauto_Internalname, StringUtil.BoolToStr( AV51UserInfoResponseUserLastNameGenAuto), 1, cmbavUserinforesponseuserlastnamegenauto_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "boolean", "", 1, cmbavUserinforesponseuserlastnamegenauto.Enabled, 1, 0, 100, "%", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,195);\"", "", true, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            cmbavUserinforesponseuserlastnamegenauto.CurrentValue = StringUtil.BoolToStr( AV51UserInfoResponseUserLastNameGenAuto);
            AssignProp(sPrefix, false, cmbavUserinforesponseuserlastnamegenauto_Internalname, "Values", (String)(cmbavUserinforesponseuserlastnamegenauto.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divTbluserlastname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-md-3", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbuserlastname_Internalname, "User Last Name", "", "", lblTbuserlastname_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseuserlastnametag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseuserlastnametag_Internalname, "Tag", "col-sm-3 col-md-2 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-md-10 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 205,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseuserlastnametag_Internalname, StringUtil.RTrim( AV52UserInfoResponseUserLastNameTag), StringUtil.RTrim( context.localUtil.Format( AV52UserInfoResponseUserLastNameTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,205);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseuserlastnametag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseuserlastnametag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-md-5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbuserlastnamehelp_Internalname, "", "", "", lblTbuserlastnamehelp_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
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
            GxWebStd.gx_div_start( context, divTblusergender_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-md-3", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbusergender_Internalname, "User Gender", "", "", lblTbusergender_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseusergendertag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseusergendertag_Internalname, "Tag", "col-sm-3 col-md-2 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-md-10 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 217,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseusergendertag_Internalname, StringUtil.RTrim( AV48UserInfoResponseUserGenderTag), StringUtil.RTrim( context.localUtil.Format( AV48UserInfoResponseUserGenderTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,217);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseusergendertag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseusergendertag_Enabled, 1, "text", "", 40, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-md-5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseusergendervalues_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseusergendervalues_Internalname, "Values", "col-sm-3 col-md-2 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-md-10 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 221,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseusergendervalues_Internalname, AV49UserInfoResponseUserGenderValues, StringUtil.RTrim( context.localUtil.Format( AV49UserInfoResponseUserGenderValues, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,221);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseusergendervalues_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseusergendervalues_Enabled, 1, "text", "", 100, "%", 1, "row", 400, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMPropertyValue", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseuserbirthdaytag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseuserbirthdaytag_Internalname, "User Birthday Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 226,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseuserbirthdaytag_Internalname, StringUtil.RTrim( AV43UserInfoResponseUserBirthdayTag), StringUtil.RTrim( context.localUtil.Format( AV43UserInfoResponseUserBirthdayTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,226);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseuserbirthdaytag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseuserbirthdaytag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseuserurlimagetag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseuserurlimagetag_Internalname, "User URL Image Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 231,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseuserurlimagetag_Internalname, StringUtil.RTrim( AV55UserInfoResponseUserURLImageTag), StringUtil.RTrim( context.localUtil.Format( AV55UserInfoResponseUserURLImageTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,231);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseuserurlimagetag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseuserurlimagetag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseuserurlprofiletag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseuserurlprofiletag_Internalname, "User URL Profile Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 236,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseuserurlprofiletag_Internalname, StringUtil.RTrim( AV56UserInfoResponseUserURLProfileTag), StringUtil.RTrim( context.localUtil.Format( AV56UserInfoResponseUserURLProfileTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,236);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseuserurlprofiletag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseuserurlprofiletag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseuserlanguagetag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseuserlanguagetag_Internalname, "User Language Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 241,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseuserlanguagetag_Internalname, StringUtil.RTrim( AV50UserInfoResponseUserLanguageTag), StringUtil.RTrim( context.localUtil.Format( AV50UserInfoResponseUserLanguageTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,241);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseuserlanguagetag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseuserlanguagetag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseusertimezonetag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseusertimezonetag_Internalname, "User Time Zone Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 246,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseusertimezonetag_Internalname, StringUtil.RTrim( AV54UserInfoResponseUserTimeZoneTag), StringUtil.RTrim( context.localUtil.Format( AV54UserInfoResponseUserTimeZoneTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,246);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseusertimezonetag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseusertimezonetag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserinforesponseerrordescriptiontag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserinforesponseerrordescriptiontag_Internalname, "Error Description Tag", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 251,'" + sPrefix + "',false,'" + sGXsfl_261_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserinforesponseerrordescriptiontag_Internalname, StringUtil.RTrim( AV42UserInfoResponseErrorDescriptionTag), StringUtil.RTrim( context.localUtil.Format( AV42UserInfoResponseErrorDescriptionTag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,251);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserinforesponseerrordescriptiontag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserinforesponseerrordescriptiontag_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup4_Internalname, "Custom User Attributes", 1, 0, "px", 0, "px", "Group", "", "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup4table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"DivS\" data-gxgridid=\"261\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtavDynamicpropname_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Attribute Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtavDynamicproptag_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Attribute Tag") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Image"+"\" "+" style=\""+((edtavDeletepropertyimage_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "WorkWith");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", sPrefix);
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV11DynamicPropName));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDynamicpropname_Enabled), 5, 0, ".", "")));
               Grid1Column.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDynamicpropname_Visible), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV12DynamicPropTag));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDynamicproptag_Enabled), 5, 0, ".", "")));
               Grid1Column.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDynamicproptag_Visible), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV9DeletePropertyImage));
               Grid1Column.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDeletepropertyimage_Visible), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 261 )
         {
            wbEnd = 0;
            nRC_GXsfl_261 = (int)(nGXsfl_261_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid1", Grid1Container);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBtnadd_Internalname, "Add", "", "", lblBtnadd_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'NEWROW\\'."+"'", "", "GridNewRow TextLikeLink", 5, "", lblBtnadd_Visible, 1, 0, "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row BackgroundColorRow", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 273,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(261), 3, 0)+","+"null"+");", "Cancel", bttBtncancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 275,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(261), 3, 0)+","+"null"+");", bttBtnconfirm_Caption, bttBtnconfirm_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtnconfirm_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMWCAuthenticationTypeEntrySaml20.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 261 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid1", Grid1Container);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START1Q2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
               Form.Meta.addItem("description", "GAMWCAuthentication Type Entry Saml20", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP1Q0( ) ;
            }
         }
      }

      protected void WS1Q2( )
      {
         START1Q2( ) ;
         EVT1Q2( ) ;
      }

      protected void EVT1Q2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E121Q2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NEWROW'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'NewRow' */
                                    E131Q2 ();
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDynamicpropname_Internalname;
                                    AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "'DELETEROW'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "'DELETEROW'") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Q0( ) ;
                              }
                              nGXsfl_261_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_261_idx), 4, 0), 4, "0");
                              SubsflControlProps_2612( ) ;
                              AV11DynamicPropName = cgiGet( edtavDynamicpropname_Internalname);
                              AssignAttri(sPrefix, false, edtavDynamicpropname_Internalname, AV11DynamicPropName);
                              AV12DynamicPropTag = cgiGet( edtavDynamicproptag_Internalname);
                              AssignAttri(sPrefix, false, edtavDynamicproptag_Internalname, AV12DynamicPropTag);
                              AV9DeletePropertyImage = cgiGet( edtavDeletepropertyimage_Internalname);
                              AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV9DeletePropertyImage)) ? AV63Deletepropertyimage_GXI : context.convertURL( context.PathToRelativeUrl( AV9DeletePropertyImage))), !bGXsfl_261_Refreshing);
                              AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "SrcSet", context.GetImageSrcSet( AV9DeletePropertyImage), true);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDynamicpropname_Internalname;
                                          AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E141Q2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDynamicpropname_Internalname;
                                          AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E151Q2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DELETEROW'") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDynamicpropname_Internalname;
                                          AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: 'DeleteRow' */
                                          E161Q2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP1Q0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDynamicpropname_Internalname;
                                          AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
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

      protected void WE1Q2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1Q2( ) ;
            }
         }
      }

      protected void PA1Q2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = cmbavFunctionid_Internalname;
               AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_2612( ) ;
         while ( nGXsfl_261_idx <= nRC_GXsfl_261 )
         {
            sendrow_2612( ) ;
            nGXsfl_261_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_261_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_261_idx+1);
            sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_261_idx), 4, 0), 4, "0");
            SubsflControlProps_2612( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String Gx_mode ,
                                        bool AV20IsEnable ,
                                        bool AV15ForceAuthn ,
                                        String AV45UserInfoResponseUserErrorDescriptionTag ,
                                        String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF1Q2( ) ;
         /* End function gxgrGrid1_refresh */
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
         if ( cmbavFunctionid.ItemCount > 0 )
         {
            AV16FunctionId = cmbavFunctionid.getValidValue(AV16FunctionId);
            AssignAttri(sPrefix, false, "AV16FunctionId", AV16FunctionId);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavFunctionid.CurrentValue = StringUtil.RTrim( AV16FunctionId);
            AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Values", cmbavFunctionid.ToJavascriptSource(), true);
         }
         AV20IsEnable = StringUtil.StrToBool( StringUtil.BoolToStr( AV20IsEnable));
         AssignAttri(sPrefix, false, "AV20IsEnable", AV20IsEnable);
         AV15ForceAuthn = StringUtil.StrToBool( StringUtil.BoolToStr( AV15ForceAuthn));
         AssignAttri(sPrefix, false, "AV15ForceAuthn", AV15ForceAuthn);
         if ( cmbavUserinforesponseuserlastnamegenauto.ItemCount > 0 )
         {
            AV51UserInfoResponseUserLastNameGenAuto = StringUtil.StrToBool( cmbavUserinforesponseuserlastnamegenauto.getValidValue(StringUtil.BoolToStr( AV51UserInfoResponseUserLastNameGenAuto)));
            AssignAttri(sPrefix, false, "AV51UserInfoResponseUserLastNameGenAuto", AV51UserInfoResponseUserLastNameGenAuto);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavUserinforesponseuserlastnamegenauto.CurrentValue = StringUtil.BoolToStr( AV51UserInfoResponseUserLastNameGenAuto);
            AssignProp(sPrefix, false, cmbavUserinforesponseuserlastnamegenauto_Internalname, "Values", cmbavUserinforesponseuserlastnamegenauto.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1Q2( ) ;
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

      protected void RF1Q2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 261;
         nGXsfl_261_idx = 1;
         sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_261_idx), 4, 0), 4, "0");
         SubsflControlProps_2612( ) ;
         bGXsfl_261_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", sPrefix);
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "WorkWith");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_fnc_Recordsperpage( );
         if ( subGrid1_Islastpage != 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_fnc_Recordcount( )-subGrid1_fnc_Recordsperpage( ));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
            Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_2612( ) ;
            E151Q2 ();
            wbEnd = 261;
            WB1Q0( ) ;
         }
         bGXsfl_261_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1Q2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"vUSERINFORESPONSEUSERERRORDESCRIPTIONTAG", StringUtil.RTrim( AV45UserInfoResponseUserErrorDescriptionTag));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vUSERINFORESPONSEUSERERRORDESCRIPTIONTAG", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV45UserInfoResponseUserErrorDescriptionTag, "")), context));
      }

      protected int subGrid1_fnc_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_fnc_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_fnc_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_fnc_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP1Q0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E141Q2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_261 = (int)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_261"), ".", ","));
            wcpOGx_mode = cgiGet( sPrefix+"wcpOGx_mode");
            wcpOAV33Name = cgiGet( sPrefix+"wcpOAV33Name");
            wcpOAV41TypeId = cgiGet( sPrefix+"wcpOAV41TypeId");
            Tab1_Pagecount = (int)(context.localUtil.CToN( cgiGet( sPrefix+"TAB1_Pagecount"), ".", ","));
            Tab1_Class = cgiGet( sPrefix+"TAB1_Class");
            Tab1_Historymanagement = StringUtil.StrToBool( cgiGet( sPrefix+"TAB1_Historymanagement"));
            /* Read variables values. */
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               AV33Name = cgiGet( edtavName_Internalname);
               AssignAttri(sPrefix, false, "AV33Name", AV33Name);
            }
            cmbavFunctionid.Name = cmbavFunctionid_Internalname;
            cmbavFunctionid.CurrentValue = cgiGet( cmbavFunctionid_Internalname);
            AV16FunctionId = cgiGet( cmbavFunctionid_Internalname);
            AssignAttri(sPrefix, false, "AV16FunctionId", AV16FunctionId);
            AV20IsEnable = StringUtil.StrToBool( cgiGet( chkavIsenable_Internalname));
            AssignAttri(sPrefix, false, "AV20IsEnable", AV20IsEnable);
            AV10Dsc = cgiGet( edtavDsc_Internalname);
            AssignAttri(sPrefix, false, "AV10Dsc", AV10Dsc);
            AV40SmallImageName = cgiGet( edtavSmallimagename_Internalname);
            AssignAttri(sPrefix, false, "AV40SmallImageName", AV40SmallImageName);
            AV7BigImageName = cgiGet( edtavBigimagename_Internalname);
            AssignAttri(sPrefix, false, "AV7BigImageName", AV7BigImageName);
            AV19Impersonate = cgiGet( edtavImpersonate_Internalname);
            AssignAttri(sPrefix, false, "AV19Impersonate", AV19Impersonate);
            AV15ForceAuthn = StringUtil.StrToBool( cgiGet( chkavForceauthn_Internalname));
            AssignAttri(sPrefix, false, "AV15ForceAuthn", AV15ForceAuthn);
            AV6AuthnContext = cgiGet( edtavAuthncontext_Internalname);
            AssignAttri(sPrefix, false, "AV6AuthnContext", AV6AuthnContext);
            AV31LocalSiteURL = cgiGet( edtavLocalsiteurl_Internalname);
            AssignAttri(sPrefix, false, "AV31LocalSiteURL", AV31LocalSiteURL);
            AV18IdentityProviderEntityID = cgiGet( edtavIdentityproviderentityid_Internalname);
            AssignAttri(sPrefix, false, "AV18IdentityProviderEntityID", AV18IdentityProviderEntityID);
            AV38ServiceProviderEntityID = cgiGet( edtavServiceproviderentityid_Internalname);
            AssignAttri(sPrefix, false, "AV38ServiceProviderEntityID", AV38ServiceProviderEntityID);
            AV37SamlEndpointLocation = cgiGet( edtavSamlendpointlocation_Internalname);
            AssignAttri(sPrefix, false, "AV37SamlEndpointLocation", AV37SamlEndpointLocation);
            AV39SingleLogoutendpoint = cgiGet( edtavSinglelogoutendpoint_Internalname);
            AssignAttri(sPrefix, false, "AV39SingleLogoutendpoint", AV39SingleLogoutendpoint);
            AV29KeyStPathCredential = cgiGet( edtavKeystpathcredential_Internalname);
            AssignAttri(sPrefix, false, "AV29KeyStPathCredential", AV29KeyStPathCredential);
            AV30KeyStPwdCredential = cgiGet( edtavKeystpwdcredential_Internalname);
            AssignAttri(sPrefix, false, "AV30KeyStPwdCredential", AV30KeyStPwdCredential);
            AV22KeyAliasCredential = cgiGet( edtavKeyaliascredential_Internalname);
            AssignAttri(sPrefix, false, "AV22KeyAliasCredential", AV22KeyAliasCredential);
            AV25KeyStoreCredential = cgiGet( edtavKeystorecredential_Internalname);
            AssignAttri(sPrefix, false, "AV25KeyStoreCredential", AV25KeyStoreCredential);
            AV26KeyStoreFilePathTrustCred = cgiGet( edtavKeystorefilepathtrustcred_Internalname);
            AssignAttri(sPrefix, false, "AV26KeyStoreFilePathTrustCred", AV26KeyStoreFilePathTrustCred);
            AV27KeyStorePwdTrustCred = cgiGet( edtavKeystorepwdtrustcred_Internalname);
            AssignAttri(sPrefix, false, "AV27KeyStorePwdTrustCred", AV27KeyStorePwdTrustCred);
            AV23KeyAliasTrustCred = cgiGet( edtavKeyaliastrustcred_Internalname);
            AssignAttri(sPrefix, false, "AV23KeyAliasTrustCred", AV23KeyAliasTrustCred);
            AV28KeyStoreTrustCred = cgiGet( edtavKeystoretrustcred_Internalname);
            AssignAttri(sPrefix, false, "AV28KeyStoreTrustCred", AV28KeyStoreTrustCred);
            AV44UserInfoResponseUserEmailTag = cgiGet( edtavUserinforesponseuseremailtag_Internalname);
            AssignAttri(sPrefix, false, "AV44UserInfoResponseUserEmailTag", AV44UserInfoResponseUserEmailTag);
            AV46UserInfoResponseUserExternalIdTag = cgiGet( edtavUserinforesponseuserexternalidtag_Internalname);
            AssignAttri(sPrefix, false, "AV46UserInfoResponseUserExternalIdTag", AV46UserInfoResponseUserExternalIdTag);
            AV53UserInfoResponseUserNameTag = cgiGet( edtavUserinforesponseusernametag_Internalname);
            AssignAttri(sPrefix, false, "AV53UserInfoResponseUserNameTag", AV53UserInfoResponseUserNameTag);
            AV47UserInfoResponseUserFirstNameTag = cgiGet( edtavUserinforesponseuserfirstnametag_Internalname);
            AssignAttri(sPrefix, false, "AV47UserInfoResponseUserFirstNameTag", AV47UserInfoResponseUserFirstNameTag);
            cmbavUserinforesponseuserlastnamegenauto.Name = cmbavUserinforesponseuserlastnamegenauto_Internalname;
            cmbavUserinforesponseuserlastnamegenauto.CurrentValue = cgiGet( cmbavUserinforesponseuserlastnamegenauto_Internalname);
            AV51UserInfoResponseUserLastNameGenAuto = StringUtil.StrToBool( cgiGet( cmbavUserinforesponseuserlastnamegenauto_Internalname));
            AssignAttri(sPrefix, false, "AV51UserInfoResponseUserLastNameGenAuto", AV51UserInfoResponseUserLastNameGenAuto);
            AV52UserInfoResponseUserLastNameTag = cgiGet( edtavUserinforesponseuserlastnametag_Internalname);
            AssignAttri(sPrefix, false, "AV52UserInfoResponseUserLastNameTag", AV52UserInfoResponseUserLastNameTag);
            AV48UserInfoResponseUserGenderTag = cgiGet( edtavUserinforesponseusergendertag_Internalname);
            AssignAttri(sPrefix, false, "AV48UserInfoResponseUserGenderTag", AV48UserInfoResponseUserGenderTag);
            AV49UserInfoResponseUserGenderValues = cgiGet( edtavUserinforesponseusergendervalues_Internalname);
            AssignAttri(sPrefix, false, "AV49UserInfoResponseUserGenderValues", AV49UserInfoResponseUserGenderValues);
            AV43UserInfoResponseUserBirthdayTag = cgiGet( edtavUserinforesponseuserbirthdaytag_Internalname);
            AssignAttri(sPrefix, false, "AV43UserInfoResponseUserBirthdayTag", AV43UserInfoResponseUserBirthdayTag);
            AV55UserInfoResponseUserURLImageTag = cgiGet( edtavUserinforesponseuserurlimagetag_Internalname);
            AssignAttri(sPrefix, false, "AV55UserInfoResponseUserURLImageTag", AV55UserInfoResponseUserURLImageTag);
            AV56UserInfoResponseUserURLProfileTag = cgiGet( edtavUserinforesponseuserurlprofiletag_Internalname);
            AssignAttri(sPrefix, false, "AV56UserInfoResponseUserURLProfileTag", AV56UserInfoResponseUserURLProfileTag);
            AV50UserInfoResponseUserLanguageTag = cgiGet( edtavUserinforesponseuserlanguagetag_Internalname);
            AssignAttri(sPrefix, false, "AV50UserInfoResponseUserLanguageTag", AV50UserInfoResponseUserLanguageTag);
            AV54UserInfoResponseUserTimeZoneTag = cgiGet( edtavUserinforesponseusertimezonetag_Internalname);
            AssignAttri(sPrefix, false, "AV54UserInfoResponseUserTimeZoneTag", AV54UserInfoResponseUserTimeZoneTag);
            AV42UserInfoResponseErrorDescriptionTag = cgiGet( edtavUserinforesponseerrordescriptiontag_Internalname);
            AssignAttri(sPrefix, false, "AV42UserInfoResponseErrorDescriptionTag", AV42UserInfoResponseErrorDescriptionTag);
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
         E141Q2 ();
         if (returnInSub) return;
      }

      protected void E141Q2( )
      {
         /* Start Routine */
         /* Execute user subroutine: 'INITAUTHENTICATIONSAML' */
         S112 ();
         if (returnInSub) return;
         AV16FunctionId = "OnlyAuthentication";
         AssignAttri(sPrefix, false, "AV16FunctionId", AV16FunctionId);
         cmbavFunctionid.Enabled = 0;
         AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
         divTbkeystoreadvanced_Visible = 0;
         AssignProp(sPrefix, false, divTbkeystoreadvanced_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTbkeystoreadvanced_Visible), 5, 0), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtnconfirm_Visible = 0;
               AssignProp(sPrefix, false, bttBtnconfirm_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtnconfirm_Visible), 5, 0), true);
            }
            lblBtnadd_Visible = 0;
            AssignProp(sPrefix, false, lblBtnadd_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(lblBtnadd_Visible), 5, 0), true);
            cmbavFunctionid.Enabled = 0;
            AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
            chkavIsenable.Enabled = 0;
            AssignProp(sPrefix, false, chkavIsenable_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavIsenable.Enabled), 5, 0), true);
            edtavDsc_Enabled = 0;
            AssignProp(sPrefix, false, edtavDsc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDsc_Enabled), 5, 0), true);
            edtavSmallimagename_Enabled = 0;
            AssignProp(sPrefix, false, edtavSmallimagename_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavSmallimagename_Enabled), 5, 0), true);
            edtavBigimagename_Enabled = 0;
            AssignProp(sPrefix, false, edtavBigimagename_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBigimagename_Enabled), 5, 0), true);
            edtavImpersonate_Enabled = 0;
            AssignProp(sPrefix, false, edtavImpersonate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavImpersonate_Enabled), 5, 0), true);
            bttBtnconfirm_Caption = "Delete";
            AssignProp(sPrefix, false, bttBtnconfirm_Internalname, "Caption", bttBtnconfirm_Caption, true);
            edtavServiceproviderentityid_Enabled = 0;
            AssignProp(sPrefix, false, edtavServiceproviderentityid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavServiceproviderentityid_Enabled), 5, 0), true);
            edtavIdentityproviderentityid_Enabled = 0;
            AssignProp(sPrefix, false, edtavIdentityproviderentityid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavIdentityproviderentityid_Enabled), 5, 0), true);
            edtavSamlendpointlocation_Enabled = 0;
            AssignProp(sPrefix, false, edtavSamlendpointlocation_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavSamlendpointlocation_Enabled), 5, 0), true);
            edtavSinglelogoutendpoint_Enabled = 0;
            AssignProp(sPrefix, false, edtavSinglelogoutendpoint_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavSinglelogoutendpoint_Enabled), 5, 0), true);
            edtavLocalsiteurl_Enabled = 0;
            AssignProp(sPrefix, false, edtavLocalsiteurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavLocalsiteurl_Enabled), 5, 0), true);
            edtavKeystpathcredential_Enabled = 0;
            AssignProp(sPrefix, false, edtavKeystpathcredential_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavKeystpathcredential_Enabled), 5, 0), true);
            edtavKeystpwdcredential_Enabled = 0;
            AssignProp(sPrefix, false, edtavKeystpwdcredential_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavKeystpwdcredential_Enabled), 5, 0), true);
            edtavKeyaliascredential_Enabled = 0;
            AssignProp(sPrefix, false, edtavKeyaliascredential_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavKeyaliascredential_Enabled), 5, 0), true);
            edtavKeystorecredential_Enabled = 0;
            AssignProp(sPrefix, false, edtavKeystorecredential_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavKeystorecredential_Enabled), 5, 0), true);
            edtavKeystorefilepathtrustcred_Enabled = 0;
            AssignProp(sPrefix, false, edtavKeystorefilepathtrustcred_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavKeystorefilepathtrustcred_Enabled), 5, 0), true);
            edtavKeystorepwdtrustcred_Enabled = 0;
            AssignProp(sPrefix, false, edtavKeystorepwdtrustcred_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavKeystorepwdtrustcred_Enabled), 5, 0), true);
            edtavKeyaliastrustcred_Enabled = 0;
            AssignProp(sPrefix, false, edtavKeyaliastrustcred_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavKeyaliastrustcred_Enabled), 5, 0), true);
            edtavKeystoretrustcred_Enabled = 0;
            AssignProp(sPrefix, false, edtavKeystoretrustcred_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavKeystoretrustcred_Enabled), 5, 0), true);
            chkavForceauthn.Enabled = 0;
            AssignProp(sPrefix, false, chkavForceauthn_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavForceauthn.Enabled), 5, 0), true);
            edtavAuthncontext_Enabled = 0;
            AssignProp(sPrefix, false, edtavAuthncontext_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavAuthncontext_Enabled), 5, 0), true);
            edtavUserinforesponseuserbirthdaytag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseuserbirthdaytag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseuserbirthdaytag_Enabled), 5, 0), true);
            edtavUserinforesponseuseremailtag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseuseremailtag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseuseremailtag_Enabled), 5, 0), true);
            edtavUserinforesponseuserexternalidtag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseuserexternalidtag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseuserexternalidtag_Enabled), 5, 0), true);
            edtavUserinforesponseuserfirstnametag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseuserfirstnametag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseuserfirstnametag_Enabled), 5, 0), true);
            edtavUserinforesponseusergendertag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseusergendertag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseusergendertag_Enabled), 5, 0), true);
            edtavUserinforesponseusergendervalues_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseusergendervalues_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseusergendervalues_Enabled), 5, 0), true);
            edtavUserinforesponseuserlanguagetag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseuserlanguagetag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseuserlanguagetag_Enabled), 5, 0), true);
            cmbavUserinforesponseuserlastnamegenauto.Enabled = 0;
            AssignProp(sPrefix, false, cmbavUserinforesponseuserlastnamegenauto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavUserinforesponseuserlastnamegenauto.Enabled), 5, 0), true);
            edtavUserinforesponseuserlastnametag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseuserlastnametag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseuserlastnametag_Enabled), 5, 0), true);
            edtavUserinforesponseusernametag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseusernametag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseusernametag_Enabled), 5, 0), true);
            edtavUserinforesponseusertimezonetag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseusertimezonetag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseusertimezonetag_Enabled), 5, 0), true);
            edtavUserinforesponseuserurlimagetag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseuserurlimagetag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseuserurlimagetag_Enabled), 5, 0), true);
            edtavUserinforesponseuserurlprofiletag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseuserurlprofiletag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseuserurlprofiletag_Enabled), 5, 0), true);
            edtavUserinforesponseerrordescriptiontag_Enabled = 0;
            AssignProp(sPrefix, false, edtavUserinforesponseerrordescriptiontag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserinforesponseerrordescriptiontag_Enabled), 5, 0), true);
         }
         else
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               edtavName_Enabled = 1;
               AssignProp(sPrefix, false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
            }
            else
            {
               edtavName_Enabled = 0;
               AssignProp(sPrefix, false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
            }
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E121Q2 ();
         if (returnInSub) return;
      }

      protected void E121Q2( )
      {
         /* Enter Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            /* Execute user subroutine: 'SAVEAUTHENTICATIONSAML' */
            S122 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV5AuthenticationTypeSaml20.load( AV33Name);
            AssignAttri(sPrefix, false, "AV33Name", AV33Name);
            AV5AuthenticationTypeSaml20.delete();
         }
         if ( AV5AuthenticationTypeSaml20.success() && ( AV14Errors.Count == 0 ) )
         {
            context.CommitDataStores("gamwcauthenticationtypeentrysaml20",pr_default);
            CallWebObject(formatLink("gamexamplewwauthtypes.aspx") );
            context.wjLocDisableFrm = 1;
         }
         else
         {
            AV14Errors = AV5AuthenticationTypeSaml20.geterrors();
            AV61GXV1 = 1;
            while ( AV61GXV1 <= AV14Errors.Count )
            {
               AV13Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV14Errors.Item(AV61GXV1));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV13Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV13Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV61GXV1 = (int)(AV61GXV1+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV5AuthenticationTypeSaml20", AV5AuthenticationTypeSaml20);
      }

      private void E151Q2( )
      {
         /* Grid1_Load Routine */
         AV62GXV2 = 1;
         while ( AV62GXV2 <= AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserproperties.Count )
         {
            AV17GAMPropertySimple = ((GeneXus.Programs.genexussecurity.SdtGAMPropertySimple)AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserproperties.Item(AV62GXV2));
            AV9DeletePropertyImage = context.GetImagePath( "ec7bc09c-00fb-486b-9566-4b67fdc76464", "", context.GetTheme( ));
            AssignAttri(sPrefix, false, edtavDeletepropertyimage_Internalname, AV9DeletePropertyImage);
            AV63Deletepropertyimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "ec7bc09c-00fb-486b-9566-4b67fdc76464", "", context.GetTheme( )));
            AV11DynamicPropName = AV17GAMPropertySimple.gxTpr_Id;
            AssignAttri(sPrefix, false, edtavDynamicpropname_Internalname, AV11DynamicPropName);
            AV12DynamicPropTag = AV17GAMPropertySimple.gxTpr_Value;
            AssignAttri(sPrefix, false, edtavDynamicproptag_Internalname, AV12DynamicPropTag);
            if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
            {
               edtavDeletepropertyimage_Visible = 0;
               edtavDynamicpropname_Enabled = 0;
               edtavDynamicproptag_Enabled = 0;
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 261;
            }
            sendrow_2612( ) ;
            if ( isFullAjaxMode( ) && ! bGXsfl_261_Refreshing )
            {
               context.DoAjaxLoad(261, Grid1Row);
            }
            AV62GXV2 = (int)(AV62GXV2+1);
         }
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'INITAUTHENTICATIONSAML' Routine */
         AV5AuthenticationTypeSaml20.load( AV33Name);
         AssignAttri(sPrefix, false, "AV33Name", AV33Name);
         AV33Name = AV5AuthenticationTypeSaml20.gxTpr_Name;
         AssignAttri(sPrefix, false, "AV33Name", AV33Name);
         AV20IsEnable = AV5AuthenticationTypeSaml20.gxTpr_Isenable;
         AssignAttri(sPrefix, false, "AV20IsEnable", AV20IsEnable);
         AV10Dsc = AV5AuthenticationTypeSaml20.gxTpr_Description;
         AssignAttri(sPrefix, false, "AV10Dsc", AV10Dsc);
         AV40SmallImageName = AV5AuthenticationTypeSaml20.gxTpr_Smallimagename;
         AssignAttri(sPrefix, false, "AV40SmallImageName", AV40SmallImageName);
         AV7BigImageName = AV5AuthenticationTypeSaml20.gxTpr_Bigimagename;
         AssignAttri(sPrefix, false, "AV7BigImageName", AV7BigImageName);
         AV19Impersonate = AV5AuthenticationTypeSaml20.gxTpr_Impersonate;
         AssignAttri(sPrefix, false, "AV19Impersonate", AV19Impersonate);
         AV38ServiceProviderEntityID = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Serviceproviderentityid;
         AssignAttri(sPrefix, false, "AV38ServiceProviderEntityID", AV38ServiceProviderEntityID);
         AV18IdentityProviderEntityID = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Identityproviderentityid;
         AssignAttri(sPrefix, false, "AV18IdentityProviderEntityID", AV18IdentityProviderEntityID);
         AV6AuthnContext = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Authncontext;
         AssignAttri(sPrefix, false, "AV6AuthnContext", AV6AuthnContext);
         AV15ForceAuthn = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Forceauthn;
         AssignAttri(sPrefix, false, "AV15ForceAuthn", AV15ForceAuthn);
         AV22KeyAliasCredential = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keyaliascredential;
         AssignAttri(sPrefix, false, "AV22KeyAliasCredential", AV22KeyAliasCredential);
         AV23KeyAliasTrustCred = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keyaliastrustcred;
         AssignAttri(sPrefix, false, "AV23KeyAliasTrustCred", AV23KeyAliasTrustCred);
         AV25KeyStoreCredential = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystorecredential;
         AssignAttri(sPrefix, false, "AV25KeyStoreCredential", AV25KeyStoreCredential);
         AV26KeyStoreFilePathTrustCred = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystorefilepathtrustcred;
         AssignAttri(sPrefix, false, "AV26KeyStoreFilePathTrustCred", AV26KeyStoreFilePathTrustCred);
         AV27KeyStorePwdTrustCred = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystorepwdtrustcred;
         AssignAttri(sPrefix, false, "AV27KeyStorePwdTrustCred", AV27KeyStorePwdTrustCred);
         AV28KeyStoreTrustCred = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystoretrustcred;
         AssignAttri(sPrefix, false, "AV28KeyStoreTrustCred", AV28KeyStoreTrustCred);
         AV29KeyStPathCredential = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystpathcredential;
         AssignAttri(sPrefix, false, "AV29KeyStPathCredential", AV29KeyStPathCredential);
         AV30KeyStPwdCredential = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystpwdcredential;
         AssignAttri(sPrefix, false, "AV30KeyStPwdCredential", AV30KeyStPwdCredential);
         AV37SamlEndpointLocation = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Samlendpointlocation;
         AssignAttri(sPrefix, false, "AV37SamlEndpointLocation", AV37SamlEndpointLocation);
         AV31LocalSiteURL = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Localsiteurl;
         AssignAttri(sPrefix, false, "AV31LocalSiteURL", AV31LocalSiteURL);
         AV39SingleLogoutendpoint = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Singlelogoutendpoint;
         AssignAttri(sPrefix, false, "AV39SingleLogoutendpoint", AV39SingleLogoutendpoint);
         AV45UserInfoResponseUserErrorDescriptionTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseerrordescription_name;
         AssignAttri(sPrefix, false, "AV45UserInfoResponseUserErrorDescriptionTag", AV45UserInfoResponseUserErrorDescriptionTag);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vUSERINFORESPONSEUSERERRORDESCRIPTIONTAG", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV45UserInfoResponseUserErrorDescriptionTag, "")), context));
         AV43UserInfoResponseUserBirthdayTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserbirthday_name;
         AssignAttri(sPrefix, false, "AV43UserInfoResponseUserBirthdayTag", AV43UserInfoResponseUserBirthdayTag);
         AV44UserInfoResponseUserEmailTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuseremail_name;
         AssignAttri(sPrefix, false, "AV44UserInfoResponseUserEmailTag", AV44UserInfoResponseUserEmailTag);
         AV46UserInfoResponseUserExternalIdTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserexternalid_name;
         AssignAttri(sPrefix, false, "AV46UserInfoResponseUserExternalIdTag", AV46UserInfoResponseUserExternalIdTag);
         AV47UserInfoResponseUserFirstNameTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserfirstname_name;
         AssignAttri(sPrefix, false, "AV47UserInfoResponseUserFirstNameTag", AV47UserInfoResponseUserFirstNameTag);
         AV48UserInfoResponseUserGenderTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseusergender_name;
         AssignAttri(sPrefix, false, "AV48UserInfoResponseUserGenderTag", AV48UserInfoResponseUserGenderTag);
         AV49UserInfoResponseUserGenderValues = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseusergender_values;
         AssignAttri(sPrefix, false, "AV49UserInfoResponseUserGenderValues", AV49UserInfoResponseUserGenderValues);
         AV50UserInfoResponseUserLanguageTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserlanguage_name;
         AssignAttri(sPrefix, false, "AV50UserInfoResponseUserLanguageTag", AV50UserInfoResponseUserLanguageTag);
         AV51UserInfoResponseUserLastNameGenAuto = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserlastname_generateautomatic;
         AssignAttri(sPrefix, false, "AV51UserInfoResponseUserLastNameGenAuto", AV51UserInfoResponseUserLastNameGenAuto);
         AV52UserInfoResponseUserLastNameTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserlastname_name;
         AssignAttri(sPrefix, false, "AV52UserInfoResponseUserLastNameTag", AV52UserInfoResponseUserLastNameTag);
         AV53UserInfoResponseUserNameTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseusername_name;
         AssignAttri(sPrefix, false, "AV53UserInfoResponseUserNameTag", AV53UserInfoResponseUserNameTag);
         AV54UserInfoResponseUserTimeZoneTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseusertimezone_name;
         AssignAttri(sPrefix, false, "AV54UserInfoResponseUserTimeZoneTag", AV54UserInfoResponseUserTimeZoneTag);
         AV55UserInfoResponseUserURLImageTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserurlimage_name;
         AssignAttri(sPrefix, false, "AV55UserInfoResponseUserURLImageTag", AV55UserInfoResponseUserURLImageTag);
         AV56UserInfoResponseUserURLProfileTag = AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserurlprofile_name;
         AssignAttri(sPrefix, false, "AV56UserInfoResponseUserURLProfileTag", AV56UserInfoResponseUserURLProfileTag);
      }

      protected void S122( )
      {
         /* 'SAVEAUTHENTICATIONSAML' Routine */
         AV5AuthenticationTypeSaml20.load( AV33Name);
         AssignAttri(sPrefix, false, "AV33Name", AV33Name);
         AV5AuthenticationTypeSaml20.gxTpr_Name = AV33Name;
         AV5AuthenticationTypeSaml20.gxTpr_Isenable = AV20IsEnable;
         AV5AuthenticationTypeSaml20.gxTpr_Description = AV10Dsc;
         AV5AuthenticationTypeSaml20.gxTpr_Smallimagename = AV40SmallImageName;
         AV5AuthenticationTypeSaml20.gxTpr_Bigimagename = AV7BigImageName;
         AV5AuthenticationTypeSaml20.gxTpr_Impersonate = AV19Impersonate;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Serviceproviderentityid = AV38ServiceProviderEntityID;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Identityproviderentityid = AV18IdentityProviderEntityID;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Authncontext = AV6AuthnContext;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Forceauthn = AV15ForceAuthn;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keyaliascredential = AV22KeyAliasCredential;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keyaliastrustcred = AV23KeyAliasTrustCred;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystorecredential = AV25KeyStoreCredential;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystorefilepathtrustcred = AV26KeyStoreFilePathTrustCred;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystorepwdtrustcred = AV27KeyStorePwdTrustCred;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystoretrustcred = AV28KeyStoreTrustCred;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystpathcredential = AV29KeyStPathCredential;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Keystpwdcredential = AV30KeyStPwdCredential;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Samlendpointlocation = AV37SamlEndpointLocation;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Singlelogoutendpoint = AV39SingleLogoutendpoint;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Localsiteurl = AV31LocalSiteURL;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseerrordescription_name = AV45UserInfoResponseUserErrorDescriptionTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserbirthday_name = AV43UserInfoResponseUserBirthdayTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuseremail_name = AV44UserInfoResponseUserEmailTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserexternalid_name = AV46UserInfoResponseUserExternalIdTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserfirstname_name = AV47UserInfoResponseUserFirstNameTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseusergender_name = AV48UserInfoResponseUserGenderTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseusergender_values = AV49UserInfoResponseUserGenderValues;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserlanguage_name = AV50UserInfoResponseUserLanguageTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserlastname_generateautomatic = AV51UserInfoResponseUserLastNameGenAuto;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserlastname_name = AV52UserInfoResponseUserLastNameTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseusername_name = AV53UserInfoResponseUserNameTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseusertimezone_name = AV54UserInfoResponseUserTimeZoneTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserurlimage_name = AV55UserInfoResponseUserURLImageTag;
         AV5AuthenticationTypeSaml20.gxTpr_Saml20.gxTpr_Userinfo.gxTpr_Responseuserurlprofile_name = AV56UserInfoResponseUserURLProfileTag;
         AV5AuthenticationTypeSaml20.save();
         /* Start For Each Line */
         nRC_GXsfl_261 = (int)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_261"), ".", ","));
         nGXsfl_261_fel_idx = 0;
         while ( nGXsfl_261_fel_idx < nRC_GXsfl_261 )
         {
            nGXsfl_261_fel_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_261_fel_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_261_fel_idx+1);
            sGXsfl_261_fel_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_261_fel_idx), 4, 0), 4, "0");
            SubsflControlProps_fel_2612( ) ;
            AV11DynamicPropName = cgiGet( edtavDynamicpropname_Internalname);
            AV12DynamicPropTag = cgiGet( edtavDynamicproptag_Internalname);
            AV9DeletePropertyImage = cgiGet( edtavDeletepropertyimage_Internalname);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11DynamicPropName)) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV12DynamicPropTag)) )
            {
               AV17GAMPropertySimple = new GeneXus.Programs.genexussecurity.SdtGAMPropertySimple(context);
               AV17GAMPropertySimple.gxTpr_Id = AV11DynamicPropName;
               AV17GAMPropertySimple.gxTpr_Value = AV12DynamicPropTag;
               if ( ! AV5AuthenticationTypeSaml20.setuserinfoproperty(AV17GAMPropertySimple, out  AV14Errors) )
               {
                  AV65GXV3 = 1;
                  while ( AV65GXV3 <= AV14Errors.Count )
                  {
                     AV13Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV14Errors.Item(AV65GXV3));
                     context.StatusMessage( StringUtil.Format( "%1 (GAM%2)", AV13Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV13Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", "") );
                     AV65GXV3 = (int)(AV65GXV3+1);
                  }
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_261_fel_idx == 0 )
         {
            nGXsfl_261_idx = 1;
            sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_261_idx), 4, 0), 4, "0");
            SubsflControlProps_2612( ) ;
         }
         nGXsfl_261_fel_idx = 1;
      }

      protected void E131Q2( )
      {
         /* 'NewRow' Routine */
         AV9DeletePropertyImage = context.GetImagePath( "ec7bc09c-00fb-486b-9566-4b67fdc76464", "", context.GetTheme( ));
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV9DeletePropertyImage)) ? AV63Deletepropertyimage_GXI : context.convertURL( context.PathToRelativeUrl( AV9DeletePropertyImage))), !bGXsfl_261_Refreshing);
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "SrcSet", context.GetImageSrcSet( AV9DeletePropertyImage), true);
         AV63Deletepropertyimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "ec7bc09c-00fb-486b-9566-4b67fdc76464", "", context.GetTheme( )));
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV9DeletePropertyImage)) ? AV63Deletepropertyimage_GXI : context.convertURL( context.PathToRelativeUrl( AV9DeletePropertyImage))), !bGXsfl_261_Refreshing);
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "SrcSet", context.GetImageSrcSet( AV9DeletePropertyImage), true);
         edtavDeletepropertyimage_Visible = 1;
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavDeletepropertyimage_Visible), 5, 0), !bGXsfl_261_Refreshing);
         edtavDynamicpropname_Enabled = 1;
         AssignProp(sPrefix, false, edtavDynamicpropname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDynamicpropname_Enabled), 5, 0), !bGXsfl_261_Refreshing);
         edtavDynamicpropname_Visible = 1;
         AssignProp(sPrefix, false, edtavDynamicpropname_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavDynamicpropname_Visible), 5, 0), !bGXsfl_261_Refreshing);
         edtavDynamicproptag_Enabled = 1;
         AssignProp(sPrefix, false, edtavDynamicproptag_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDynamicproptag_Enabled), 5, 0), !bGXsfl_261_Refreshing);
         edtavDynamicproptag_Visible = 1;
         AssignProp(sPrefix, false, edtavDynamicproptag_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavDynamicproptag_Visible), 5, 0), !bGXsfl_261_Refreshing);
         sendrow_2612( ) ;
         if ( isFullAjaxMode( ) && ! bGXsfl_261_Refreshing )
         {
            context.DoAjaxLoad(261, Grid1Row);
         }
         /*  Sending Event outputs  */
      }

      protected void E161Q2( )
      {
         /* 'DeleteRow' Routine */
         AV9DeletePropertyImage = context.GetImagePath( "ec7bc09c-00fb-486b-9566-4b67fdc76464", "", context.GetTheme( ));
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV9DeletePropertyImage)) ? AV63Deletepropertyimage_GXI : context.convertURL( context.PathToRelativeUrl( AV9DeletePropertyImage))), !bGXsfl_261_Refreshing);
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "SrcSet", context.GetImageSrcSet( AV9DeletePropertyImage), true);
         AV63Deletepropertyimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "ec7bc09c-00fb-486b-9566-4b67fdc76464", "", context.GetTheme( )));
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV9DeletePropertyImage)) ? AV63Deletepropertyimage_GXI : context.convertURL( context.PathToRelativeUrl( AV9DeletePropertyImage))), !bGXsfl_261_Refreshing);
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "SrcSet", context.GetImageSrcSet( AV9DeletePropertyImage), true);
         edtavDeletepropertyimage_Visible = 0;
         AssignProp(sPrefix, false, edtavDeletepropertyimage_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavDeletepropertyimage_Visible), 5, 0), !bGXsfl_261_Refreshing);
         edtavDynamicpropname_Visible = 0;
         AssignProp(sPrefix, false, edtavDynamicpropname_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavDynamicpropname_Visible), 5, 0), !bGXsfl_261_Refreshing);
         edtavDynamicproptag_Visible = 0;
         AssignProp(sPrefix, false, edtavDynamicproptag_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavDynamicproptag_Visible), 5, 0), !bGXsfl_261_Refreshing);
         AV11DynamicPropName = "";
         AssignAttri(sPrefix, false, edtavDynamicpropname_Internalname, AV11DynamicPropName);
         AV12DynamicPropTag = "";
         AssignAttri(sPrefix, false, edtavDynamicproptag_Internalname, AV12DynamicPropTag);
         AV5AuthenticationTypeSaml20.gxTpr_Name = AV33Name;
         AV5AuthenticationTypeSaml20.removeuserinfoproperty( AV11DynamicPropName, out  AV14Errors);
         AssignAttri(sPrefix, false, edtavDynamicpropname_Internalname, AV11DynamicPropName);
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV5AuthenticationTypeSaml20", AV5AuthenticationTypeSaml20);
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         Gx_mode = (String)getParm(obj,0);
         AssignAttri(sPrefix, false, "Gx_mode", Gx_mode);
         AV33Name = (String)getParm(obj,1);
         AssignAttri(sPrefix, false, "AV33Name", AV33Name);
         AV41TypeId = (String)getParm(obj,2);
         AssignAttri(sPrefix, false, "AV41TypeId", AV41TypeId);
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
         PA1Q2( ) ;
         WS1Q2( ) ;
         WE1Q2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlGx_mode = (String)((String)getParm(obj,0));
         sCtrlAV33Name = (String)((String)getParm(obj,1));
         sCtrlAV41TypeId = (String)((String)getParm(obj,2));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA1Q2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "gamwcauthenticationtypeentrysaml20", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA1Q2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            Gx_mode = (String)getParm(obj,2);
            AssignAttri(sPrefix, false, "Gx_mode", Gx_mode);
            AV33Name = (String)getParm(obj,3);
            AssignAttri(sPrefix, false, "AV33Name", AV33Name);
            AV41TypeId = (String)getParm(obj,4);
            AssignAttri(sPrefix, false, "AV41TypeId", AV41TypeId);
         }
         wcpOGx_mode = cgiGet( sPrefix+"wcpOGx_mode");
         wcpOAV33Name = cgiGet( sPrefix+"wcpOAV33Name");
         wcpOAV41TypeId = cgiGet( sPrefix+"wcpOAV41TypeId");
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(Gx_mode, wcpOGx_mode) != 0 ) || ( StringUtil.StrCmp(AV33Name, wcpOAV33Name) != 0 ) || ( StringUtil.StrCmp(AV41TypeId, wcpOAV41TypeId) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOGx_mode = Gx_mode;
         wcpOAV33Name = AV33Name;
         wcpOAV41TypeId = AV41TypeId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlGx_mode = cgiGet( sPrefix+"Gx_mode_CTRL");
         if ( StringUtil.Len( sCtrlGx_mode) > 0 )
         {
            Gx_mode = cgiGet( sCtrlGx_mode);
            AssignAttri(sPrefix, false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = cgiGet( sPrefix+"Gx_mode_PARM");
         }
         sCtrlAV33Name = cgiGet( sPrefix+"AV33Name_CTRL");
         if ( StringUtil.Len( sCtrlAV33Name) > 0 )
         {
            AV33Name = cgiGet( sCtrlAV33Name);
            AssignAttri(sPrefix, false, "AV33Name", AV33Name);
         }
         else
         {
            AV33Name = cgiGet( sPrefix+"AV33Name_PARM");
         }
         sCtrlAV41TypeId = cgiGet( sPrefix+"AV41TypeId_CTRL");
         if ( StringUtil.Len( sCtrlAV41TypeId) > 0 )
         {
            AV41TypeId = cgiGet( sCtrlAV41TypeId);
            AssignAttri(sPrefix, false, "AV41TypeId", AV41TypeId);
         }
         else
         {
            AV41TypeId = cgiGet( sPrefix+"AV41TypeId_PARM");
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA1Q2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS1Q2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS1Q2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"Gx_mode_PARM", StringUtil.RTrim( Gx_mode));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlGx_mode)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"Gx_mode_CTRL", StringUtil.RTrim( sCtrlGx_mode));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV33Name_PARM", StringUtil.RTrim( AV33Name));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV33Name)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV33Name_CTRL", StringUtil.RTrim( sCtrlAV33Name));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV41TypeId_PARM", StringUtil.RTrim( AV41TypeId));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV41TypeId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV41TypeId_CTRL", StringUtil.RTrim( sCtrlAV41TypeId));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE1Q2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020415112397", true, true);
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
         context.AddJavascriptSource("gamwcauthenticationtypeentrysaml20.js", "?2020415112397", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_2612( )
      {
         edtavDynamicpropname_Internalname = sPrefix+"vDYNAMICPROPNAME_"+sGXsfl_261_idx;
         edtavDynamicproptag_Internalname = sPrefix+"vDYNAMICPROPTAG_"+sGXsfl_261_idx;
         edtavDeletepropertyimage_Internalname = sPrefix+"vDELETEPROPERTYIMAGE_"+sGXsfl_261_idx;
      }

      protected void SubsflControlProps_fel_2612( )
      {
         edtavDynamicpropname_Internalname = sPrefix+"vDYNAMICPROPNAME_"+sGXsfl_261_fel_idx;
         edtavDynamicproptag_Internalname = sPrefix+"vDYNAMICPROPTAG_"+sGXsfl_261_fel_idx;
         edtavDeletepropertyimage_Internalname = sPrefix+"vDELETEPROPERTYIMAGE_"+sGXsfl_261_fel_idx;
      }

      protected void sendrow_2612( )
      {
         SubsflControlProps_2612( ) ;
         WB1Q0( ) ;
         Grid1Row = GXWebRow.GetNew(context,Grid1Container);
         if ( subGrid1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid1_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd";
            }
         }
         else if ( subGrid1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid1_Backstyle = 0;
            subGrid1_Backcolor = subGrid1_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Uniform";
            }
         }
         else if ( subGrid1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd";
            }
            subGrid1_Backcolor = (int)(0x0);
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( ((int)((nGXsfl_261_idx) % (2))) == 0 )
            {
               subGrid1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even";
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
         }
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_261_idx+"\">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtavDynamicpropname_Visible==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavDynamicpropname_Enabled!=0)&&(edtavDynamicpropname_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 262,'"+sPrefix+"',false,'"+sGXsfl_261_idx+"',261)\"" : " ");
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDynamicpropname_Internalname,StringUtil.RTrim( AV11DynamicPropName),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavDynamicpropname_Enabled!=0)&&(edtavDynamicpropname_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,262);\"" : " "),(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"Name",(String)edtavDynamicpropname_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(int)edtavDynamicpropname_Visible,(int)edtavDynamicpropname_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)261,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXusSecurityCommon\\GAMPropertyId",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtavDynamicproptag_Visible==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavDynamicproptag_Enabled!=0)&&(edtavDynamicproptag_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 263,'"+sPrefix+"',false,'"+sGXsfl_261_idx+"',261)\"" : " ");
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDynamicproptag_Internalname,StringUtil.RTrim( AV12DynamicPropTag),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavDynamicproptag_Enabled!=0)&&(edtavDynamicproptag_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,263);\"" : " "),(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"Tag",(String)edtavDynamicproptag_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(int)edtavDynamicproptag_Visible,(int)edtavDynamicproptag_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)261,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDeletepropertyimage_Visible==0) ? "display:none;" : "")+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDeletepropertyimage_Enabled!=0)&&(edtavDeletepropertyimage_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 264,'"+sPrefix+"',false,'',261)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         AV9DeletePropertyImage_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV9DeletePropertyImage))&&String.IsNullOrEmpty(StringUtil.RTrim( AV63Deletepropertyimage_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV9DeletePropertyImage)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV9DeletePropertyImage)) ? AV63Deletepropertyimage_GXI : context.PathToRelativeUrl( AV9DeletePropertyImage));
         Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeletepropertyimage_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDeletepropertyimage_Visible,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDeletepropertyimage_Jsonclick,"'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DELETEROW\\'."+sGXsfl_261_idx+"'",(String)StyleString,(String)ClassString,(String)"WWTextActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV9DeletePropertyImage_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
         send_integrity_lvl_hashes1Q2( ) ;
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_261_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_261_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_261_idx+1);
         sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_261_idx), 4, 0), 4, "0");
         SubsflControlProps_2612( ) ;
         /* End function sendrow_2612 */
      }

      protected void init_web_controls( )
      {
         cmbavFunctionid.Name = "vFUNCTIONID";
         cmbavFunctionid.WebTags = "";
         cmbavFunctionid.addItem("AuthenticationAndRoles", "Authentication and Roles", 0);
         cmbavFunctionid.addItem("OnlyAuthentication", "Only Authentication", 0);
         if ( cmbavFunctionid.ItemCount > 0 )
         {
         }
         chkavIsenable.Name = "vISENABLE";
         chkavIsenable.WebTags = "";
         chkavIsenable.Caption = "";
         AssignProp(sPrefix, false, chkavIsenable_Internalname, "TitleCaption", chkavIsenable.Caption, true);
         chkavIsenable.CheckedValue = "false";
         AV20IsEnable = StringUtil.StrToBool( StringUtil.BoolToStr( AV20IsEnable));
         AssignAttri(sPrefix, false, "AV20IsEnable", AV20IsEnable);
         chkavForceauthn.Name = "vFORCEAUTHN";
         chkavForceauthn.WebTags = "";
         chkavForceauthn.Caption = "";
         AssignProp(sPrefix, false, chkavForceauthn_Internalname, "TitleCaption", chkavForceauthn.Caption, true);
         chkavForceauthn.CheckedValue = "false";
         AV15ForceAuthn = StringUtil.StrToBool( StringUtil.BoolToStr( AV15ForceAuthn));
         AssignAttri(sPrefix, false, "AV15ForceAuthn", AV15ForceAuthn);
         cmbavUserinforesponseuserlastnamegenauto.Name = "vUSERINFORESPONSEUSERLASTNAMEGENAUTO";
         cmbavUserinforesponseuserlastnamegenauto.WebTags = "";
         cmbavUserinforesponseuserlastnamegenauto.addItem(StringUtil.BoolToStr( true), "true", 0);
         cmbavUserinforesponseuserlastnamegenauto.addItem(StringUtil.BoolToStr( false), "false", 0);
         if ( cmbavUserinforesponseuserlastnamegenauto.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavName_Internalname = sPrefix+"vNAME";
         cmbavFunctionid_Internalname = sPrefix+"vFUNCTIONID";
         chkavIsenable_Internalname = sPrefix+"vISENABLE";
         edtavDsc_Internalname = sPrefix+"vDSC";
         edtavSmallimagename_Internalname = sPrefix+"vSMALLIMAGENAME";
         edtavBigimagename_Internalname = sPrefix+"vBIGIMAGENAME";
         edtavImpersonate_Internalname = sPrefix+"vIMPERSONATE";
         divTbldata_Internalname = sPrefix+"TBLDATA";
         lblGeneral_title_Internalname = sPrefix+"GENERAL_TITLE";
         chkavForceauthn_Internalname = sPrefix+"vFORCEAUTHN";
         edtavAuthncontext_Internalname = sPrefix+"vAUTHNCONTEXT";
         edtavLocalsiteurl_Internalname = sPrefix+"vLOCALSITEURL";
         edtavIdentityproviderentityid_Internalname = sPrefix+"vIDENTITYPROVIDERENTITYID";
         edtavServiceproviderentityid_Internalname = sPrefix+"vSERVICEPROVIDERENTITYID";
         edtavSamlendpointlocation_Internalname = sPrefix+"vSAMLENDPOINTLOCATION";
         divGroup6table_Internalname = sPrefix+"GROUP6TABLE";
         grpGroup6_Internalname = sPrefix+"GROUP6";
         edtavSinglelogoutendpoint_Internalname = sPrefix+"vSINGLELOGOUTENDPOINT";
         divGroup5table_Internalname = sPrefix+"GROUP5TABLE";
         grpGroup5_Internalname = sPrefix+"GROUP5";
         divTabpage1table_Internalname = sPrefix+"TABPAGE1TABLE";
         lblCredentials_title_Internalname = sPrefix+"CREDENTIALS_TITLE";
         edtavKeystpathcredential_Internalname = sPrefix+"vKEYSTPATHCREDENTIAL";
         edtavKeystpwdcredential_Internalname = sPrefix+"vKEYSTPWDCREDENTIAL";
         edtavKeyaliascredential_Internalname = sPrefix+"vKEYALIASCREDENTIAL";
         edtavKeystorecredential_Internalname = sPrefix+"vKEYSTORECREDENTIAL";
         divGroup1table_Internalname = sPrefix+"GROUP1TABLE";
         grpGroup1_Internalname = sPrefix+"GROUP1";
         edtavKeystorefilepathtrustcred_Internalname = sPrefix+"vKEYSTOREFILEPATHTRUSTCRED";
         lblTboauth20authadvanced_Internalname = sPrefix+"TBOAUTH20AUTHADVANCED";
         edtavKeystorepwdtrustcred_Internalname = sPrefix+"vKEYSTOREPWDTRUSTCRED";
         edtavKeyaliastrustcred_Internalname = sPrefix+"vKEYALIASTRUSTCRED";
         edtavKeystoretrustcred_Internalname = sPrefix+"vKEYSTORETRUSTCRED";
         divTbkeystoreadvanced_Internalname = sPrefix+"TBKEYSTOREADVANCED";
         divGroup2table_Internalname = sPrefix+"GROUP2TABLE";
         grpGroup2_Internalname = sPrefix+"GROUP2";
         divTabpage3table_Internalname = sPrefix+"TABPAGE3TABLE";
         lblUserinfo_title_Internalname = sPrefix+"USERINFO_TITLE";
         edtavUserinforesponseuseremailtag_Internalname = sPrefix+"vUSERINFORESPONSEUSEREMAILTAG";
         edtavUserinforesponseuserexternalidtag_Internalname = sPrefix+"vUSERINFORESPONSEUSEREXTERNALIDTAG";
         edtavUserinforesponseusernametag_Internalname = sPrefix+"vUSERINFORESPONSEUSERNAMETAG";
         lblTbuserfirstname_Internalname = sPrefix+"TBUSERFIRSTNAME";
         edtavUserinforesponseuserfirstnametag_Internalname = sPrefix+"vUSERINFORESPONSEUSERFIRSTNAMETAG";
         cmbavUserinforesponseuserlastnamegenauto_Internalname = sPrefix+"vUSERINFORESPONSEUSERLASTNAMEGENAUTO";
         divTbluserfirstname_Internalname = sPrefix+"TBLUSERFIRSTNAME";
         lblTbuserlastname_Internalname = sPrefix+"TBUSERLASTNAME";
         edtavUserinforesponseuserlastnametag_Internalname = sPrefix+"vUSERINFORESPONSEUSERLASTNAMETAG";
         lblTbuserlastnamehelp_Internalname = sPrefix+"TBUSERLASTNAMEHELP";
         divTbluserlastname_Internalname = sPrefix+"TBLUSERLASTNAME";
         lblTbusergender_Internalname = sPrefix+"TBUSERGENDER";
         edtavUserinforesponseusergendertag_Internalname = sPrefix+"vUSERINFORESPONSEUSERGENDERTAG";
         edtavUserinforesponseusergendervalues_Internalname = sPrefix+"vUSERINFORESPONSEUSERGENDERVALUES";
         divTblusergender_Internalname = sPrefix+"TBLUSERGENDER";
         edtavUserinforesponseuserbirthdaytag_Internalname = sPrefix+"vUSERINFORESPONSEUSERBIRTHDAYTAG";
         edtavUserinforesponseuserurlimagetag_Internalname = sPrefix+"vUSERINFORESPONSEUSERURLIMAGETAG";
         edtavUserinforesponseuserurlprofiletag_Internalname = sPrefix+"vUSERINFORESPONSEUSERURLPROFILETAG";
         edtavUserinforesponseuserlanguagetag_Internalname = sPrefix+"vUSERINFORESPONSEUSERLANGUAGETAG";
         edtavUserinforesponseusertimezonetag_Internalname = sPrefix+"vUSERINFORESPONSEUSERTIMEZONETAG";
         edtavUserinforesponseerrordescriptiontag_Internalname = sPrefix+"vUSERINFORESPONSEERRORDESCRIPTIONTAG";
         edtavDynamicpropname_Internalname = sPrefix+"vDYNAMICPROPNAME";
         edtavDynamicproptag_Internalname = sPrefix+"vDYNAMICPROPTAG";
         edtavDeletepropertyimage_Internalname = sPrefix+"vDELETEPROPERTYIMAGE";
         lblBtnadd_Internalname = sPrefix+"BTNADD";
         divGroup4table_Internalname = sPrefix+"GROUP4TABLE";
         grpGroup4_Internalname = sPrefix+"GROUP4";
         divTable1_Internalname = sPrefix+"TABLE1";
         divGroup3table1_Internalname = sPrefix+"GROUP3TABLE1";
         grpGroup3_Internalname = sPrefix+"GROUP3";
         divTabpage1table1_Internalname = sPrefix+"TABPAGE1TABLE1";
         Tab1_Internalname = sPrefix+"TAB1";
         divTbloauth20_Internalname = sPrefix+"TBLOAUTH20";
         divTable2_Internalname = sPrefix+"TABLE2";
         bttBtncancel_Internalname = sPrefix+"BTNCANCEL";
         bttBtnconfirm_Internalname = sPrefix+"BTNCONFIRM";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid1_Internalname = sPrefix+"GRID1";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         chkavForceauthn.Caption = "Force Authentication";
         chkavIsenable.Caption = "Enabled?";
         edtavDeletepropertyimage_Jsonclick = "";
         edtavDeletepropertyimage_Enabled = 1;
         edtavDynamicproptag_Jsonclick = "";
         edtavDynamicpropname_Jsonclick = "";
         bttBtnconfirm_Caption = "Confirm";
         bttBtnconfirm_Visible = 1;
         lblBtnadd_Visible = 1;
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         subGrid1_Header = "";
         edtavDeletepropertyimage_Visible = -1;
         edtavDynamicproptag_Enabled = 1;
         edtavDynamicproptag_Visible = -1;
         edtavDynamicpropname_Enabled = 1;
         edtavDynamicpropname_Visible = -1;
         subGrid1_Class = "WorkWith";
         subGrid1_Backcolorstyle = 0;
         edtavUserinforesponseerrordescriptiontag_Jsonclick = "";
         edtavUserinforesponseerrordescriptiontag_Enabled = 1;
         edtavUserinforesponseusertimezonetag_Jsonclick = "";
         edtavUserinforesponseusertimezonetag_Enabled = 1;
         edtavUserinforesponseuserlanguagetag_Jsonclick = "";
         edtavUserinforesponseuserlanguagetag_Enabled = 1;
         edtavUserinforesponseuserurlprofiletag_Jsonclick = "";
         edtavUserinforesponseuserurlprofiletag_Enabled = 1;
         edtavUserinforesponseuserurlimagetag_Jsonclick = "";
         edtavUserinforesponseuserurlimagetag_Enabled = 1;
         edtavUserinforesponseuserbirthdaytag_Jsonclick = "";
         edtavUserinforesponseuserbirthdaytag_Enabled = 1;
         edtavUserinforesponseusergendervalues_Jsonclick = "";
         edtavUserinforesponseusergendervalues_Enabled = 1;
         edtavUserinforesponseusergendertag_Jsonclick = "";
         edtavUserinforesponseusergendertag_Enabled = 1;
         edtavUserinforesponseuserlastnametag_Jsonclick = "";
         edtavUserinforesponseuserlastnametag_Enabled = 1;
         cmbavUserinforesponseuserlastnamegenauto_Jsonclick = "";
         cmbavUserinforesponseuserlastnamegenauto.Enabled = 1;
         edtavUserinforesponseuserfirstnametag_Jsonclick = "";
         edtavUserinforesponseuserfirstnametag_Enabled = 1;
         edtavUserinforesponseusernametag_Jsonclick = "";
         edtavUserinforesponseusernametag_Enabled = 1;
         edtavUserinforesponseuserexternalidtag_Jsonclick = "";
         edtavUserinforesponseuserexternalidtag_Enabled = 1;
         edtavUserinforesponseuseremailtag_Jsonclick = "";
         edtavUserinforesponseuseremailtag_Enabled = 1;
         edtavKeystoretrustcred_Jsonclick = "";
         edtavKeystoretrustcred_Enabled = 1;
         edtavKeyaliastrustcred_Jsonclick = "";
         edtavKeyaliastrustcred_Enabled = 1;
         edtavKeystorepwdtrustcred_Jsonclick = "";
         edtavKeystorepwdtrustcred_Enabled = 1;
         divTbkeystoreadvanced_Visible = 1;
         edtavKeystorefilepathtrustcred_Jsonclick = "";
         edtavKeystorefilepathtrustcred_Enabled = 1;
         edtavKeystorecredential_Jsonclick = "";
         edtavKeystorecredential_Enabled = 1;
         edtavKeyaliascredential_Jsonclick = "";
         edtavKeyaliascredential_Enabled = 1;
         edtavKeystpwdcredential_Jsonclick = "";
         edtavKeystpwdcredential_Enabled = 1;
         edtavKeystpathcredential_Jsonclick = "";
         edtavKeystpathcredential_Enabled = 1;
         edtavSinglelogoutendpoint_Jsonclick = "";
         edtavSinglelogoutendpoint_Enabled = 1;
         edtavSamlendpointlocation_Jsonclick = "";
         edtavSamlendpointlocation_Enabled = 1;
         edtavServiceproviderentityid_Jsonclick = "";
         edtavServiceproviderentityid_Enabled = 1;
         edtavIdentityproviderentityid_Jsonclick = "";
         edtavIdentityproviderentityid_Enabled = 1;
         edtavLocalsiteurl_Jsonclick = "";
         edtavLocalsiteurl_Enabled = 1;
         edtavAuthncontext_Jsonclick = "";
         edtavAuthncontext_Enabled = 1;
         chkavForceauthn.Enabled = 1;
         edtavImpersonate_Jsonclick = "";
         edtavImpersonate_Enabled = 1;
         edtavBigimagename_Jsonclick = "";
         edtavBigimagename_Enabled = 1;
         edtavSmallimagename_Jsonclick = "";
         edtavSmallimagename_Enabled = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Enabled = 1;
         chkavIsenable.Enabled = 1;
         cmbavFunctionid_Jsonclick = "";
         cmbavFunctionid.Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 0;
         Tab1_Historymanagement = Convert.ToBoolean( 0);
         Tab1_Class = "WWTab";
         Tab1_Pagecount = 3;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'sPrefix'},{av:'AV45UserInfoResponseUserErrorDescriptionTag',fld:'vUSERINFORESPONSEUSERERRORDESCRIPTIONTAG',pic:'',hsh:true},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]}");
         setEventMetadata("ENTER","{handler:'E121Q2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'AV33Name',fld:'vNAME',pic:''},{av:'AV10Dsc',fld:'vDSC',pic:''},{av:'AV40SmallImageName',fld:'vSMALLIMAGENAME',pic:''},{av:'AV7BigImageName',fld:'vBIGIMAGENAME',pic:''},{av:'AV19Impersonate',fld:'vIMPERSONATE',pic:''},{av:'AV38ServiceProviderEntityID',fld:'vSERVICEPROVIDERENTITYID',pic:''},{av:'AV18IdentityProviderEntityID',fld:'vIDENTITYPROVIDERENTITYID',pic:''},{av:'AV6AuthnContext',fld:'vAUTHNCONTEXT',pic:''},{av:'AV22KeyAliasCredential',fld:'vKEYALIASCREDENTIAL',pic:''},{av:'AV23KeyAliasTrustCred',fld:'vKEYALIASTRUSTCRED',pic:''},{av:'AV25KeyStoreCredential',fld:'vKEYSTORECREDENTIAL',pic:''},{av:'AV26KeyStoreFilePathTrustCred',fld:'vKEYSTOREFILEPATHTRUSTCRED',pic:''},{av:'AV27KeyStorePwdTrustCred',fld:'vKEYSTOREPWDTRUSTCRED',pic:''},{av:'AV28KeyStoreTrustCred',fld:'vKEYSTORETRUSTCRED',pic:''},{av:'AV29KeyStPathCredential',fld:'vKEYSTPATHCREDENTIAL',pic:''},{av:'AV30KeyStPwdCredential',fld:'vKEYSTPWDCREDENTIAL',pic:''},{av:'AV37SamlEndpointLocation',fld:'vSAMLENDPOINTLOCATION',pic:''},{av:'AV39SingleLogoutendpoint',fld:'vSINGLELOGOUTENDPOINT',pic:''},{av:'AV31LocalSiteURL',fld:'vLOCALSITEURL',pic:''},{av:'AV45UserInfoResponseUserErrorDescriptionTag',fld:'vUSERINFORESPONSEUSERERRORDESCRIPTIONTAG',pic:'',hsh:true},{av:'AV43UserInfoResponseUserBirthdayTag',fld:'vUSERINFORESPONSEUSERBIRTHDAYTAG',pic:''},{av:'AV44UserInfoResponseUserEmailTag',fld:'vUSERINFORESPONSEUSEREMAILTAG',pic:''},{av:'AV46UserInfoResponseUserExternalIdTag',fld:'vUSERINFORESPONSEUSEREXTERNALIDTAG',pic:''},{av:'AV47UserInfoResponseUserFirstNameTag',fld:'vUSERINFORESPONSEUSERFIRSTNAMETAG',pic:''},{av:'AV48UserInfoResponseUserGenderTag',fld:'vUSERINFORESPONSEUSERGENDERTAG',pic:''},{av:'AV49UserInfoResponseUserGenderValues',fld:'vUSERINFORESPONSEUSERGENDERVALUES',pic:''},{av:'AV50UserInfoResponseUserLanguageTag',fld:'vUSERINFORESPONSEUSERLANGUAGETAG',pic:''},{av:'cmbavUserinforesponseuserlastnamegenauto'},{av:'AV51UserInfoResponseUserLastNameGenAuto',fld:'vUSERINFORESPONSEUSERLASTNAMEGENAUTO',pic:''},{av:'AV52UserInfoResponseUserLastNameTag',fld:'vUSERINFORESPONSEUSERLASTNAMETAG',pic:''},{av:'AV53UserInfoResponseUserNameTag',fld:'vUSERINFORESPONSEUSERNAMETAG',pic:''},{av:'AV54UserInfoResponseUserTimeZoneTag',fld:'vUSERINFORESPONSEUSERTIMEZONETAG',pic:''},{av:'AV55UserInfoResponseUserURLImageTag',fld:'vUSERINFORESPONSEUSERURLIMAGETAG',pic:''},{av:'AV56UserInfoResponseUserURLProfileTag',fld:'vUSERINFORESPONSEUSERURLPROFILETAG',pic:''},{av:'AV11DynamicPropName',fld:'vDYNAMICPROPNAME',grid:261,pic:''},{av:'GRID1_nFirstRecordOnPage'},{av:'nRC_GXsfl_261',ctrl:'GRID1',grid:261,prop:'GridRC'},{av:'AV12DynamicPropTag',fld:'vDYNAMICPROPTAG',grid:261,pic:''},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]}");
         setEventMetadata("GRID1.LOAD","{handler:'E151Q2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]");
         setEventMetadata("GRID1.LOAD",",oparms:[{av:'AV9DeletePropertyImage',fld:'vDELETEPROPERTYIMAGE',pic:''},{av:'AV11DynamicPropName',fld:'vDYNAMICPROPNAME',pic:''},{av:'AV12DynamicPropTag',fld:'vDYNAMICPROPTAG',pic:''},{av:'edtavDeletepropertyimage_Visible',ctrl:'vDELETEPROPERTYIMAGE',prop:'Visible'},{av:'edtavDynamicpropname_Enabled',ctrl:'vDYNAMICPROPNAME',prop:'Enabled'},{av:'edtavDynamicproptag_Enabled',ctrl:'vDYNAMICPROPTAG',prop:'Enabled'},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]}");
         setEventMetadata("'NEWROW'","{handler:'E131Q2',iparms:[{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]");
         setEventMetadata("'NEWROW'",",oparms:[{av:'AV9DeletePropertyImage',fld:'vDELETEPROPERTYIMAGE',pic:''},{av:'edtavDeletepropertyimage_Visible',ctrl:'vDELETEPROPERTYIMAGE',prop:'Visible'},{av:'edtavDynamicpropname_Enabled',ctrl:'vDYNAMICPROPNAME',prop:'Enabled'},{av:'edtavDynamicpropname_Visible',ctrl:'vDYNAMICPROPNAME',prop:'Visible'},{av:'edtavDynamicproptag_Enabled',ctrl:'vDYNAMICPROPTAG',prop:'Enabled'},{av:'edtavDynamicproptag_Visible',ctrl:'vDYNAMICPROPTAG',prop:'Visible'},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]}");
         setEventMetadata("'DELETEROW'","{handler:'E161Q2',iparms:[{av:'AV33Name',fld:'vNAME',pic:''},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]");
         setEventMetadata("'DELETEROW'",",oparms:[{av:'AV9DeletePropertyImage',fld:'vDELETEPROPERTYIMAGE',pic:''},{av:'edtavDeletepropertyimage_Visible',ctrl:'vDELETEPROPERTYIMAGE',prop:'Visible'},{av:'edtavDynamicpropname_Visible',ctrl:'vDYNAMICPROPNAME',prop:'Visible'},{av:'edtavDynamicproptag_Visible',ctrl:'vDYNAMICPROPTAG',prop:'Visible'},{av:'AV11DynamicPropName',fld:'vDYNAMICPROPNAME',pic:''},{av:'AV12DynamicPropTag',fld:'vDYNAMICPROPTAG',pic:''},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]}");
         setEventMetadata("'TBKEYSTOREADVANCED'","{handler:'E111Q1',iparms:[{av:'divTbkeystoreadvanced_Visible',ctrl:'TBKEYSTOREADVANCED',prop:'Visible'},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]");
         setEventMetadata("'TBKEYSTOREADVANCED'",",oparms:[{av:'divTbkeystoreadvanced_Visible',ctrl:'TBKEYSTOREADVANCED',prop:'Visible'},{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]}");
         setEventMetadata("VALIDV_FUNCTIONID","{handler:'Validv_Functionid',iparms:[{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]");
         setEventMetadata("VALIDV_FUNCTIONID",",oparms:[{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]}");
         setEventMetadata("NULL","{handler:'Validv_Deletepropertyimage',iparms:[{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]");
         setEventMetadata("NULL",",oparms:[{av:'AV20IsEnable',fld:'vISENABLE',pic:''},{av:'AV15ForceAuthn',fld:'vFORCEAUTHN',pic:''}]}");
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
         wcpOAV33Name = "";
         wcpOAV41TypeId = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV45UserInfoResponseUserErrorDescriptionTag = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         TempTags = "";
         AV16FunctionId = "";
         ClassString = "";
         StyleString = "";
         AV10Dsc = "";
         AV40SmallImageName = "";
         AV7BigImageName = "";
         AV19Impersonate = "";
         ucTab1 = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         AV6AuthnContext = "";
         AV31LocalSiteURL = "";
         AV18IdentityProviderEntityID = "";
         AV38ServiceProviderEntityID = "";
         AV37SamlEndpointLocation = "";
         AV39SingleLogoutendpoint = "";
         lblCredentials_title_Jsonclick = "";
         AV29KeyStPathCredential = "";
         AV30KeyStPwdCredential = "";
         AV22KeyAliasCredential = "";
         AV25KeyStoreCredential = "";
         AV26KeyStoreFilePathTrustCred = "";
         lblTboauth20authadvanced_Jsonclick = "";
         AV27KeyStorePwdTrustCred = "";
         AV23KeyAliasTrustCred = "";
         AV28KeyStoreTrustCred = "";
         lblUserinfo_title_Jsonclick = "";
         AV44UserInfoResponseUserEmailTag = "";
         AV46UserInfoResponseUserExternalIdTag = "";
         AV53UserInfoResponseUserNameTag = "";
         lblTbuserfirstname_Jsonclick = "";
         AV47UserInfoResponseUserFirstNameTag = "";
         lblTbuserlastname_Jsonclick = "";
         AV52UserInfoResponseUserLastNameTag = "";
         lblTbuserlastnamehelp_Jsonclick = "";
         lblTbusergender_Jsonclick = "";
         AV48UserInfoResponseUserGenderTag = "";
         AV49UserInfoResponseUserGenderValues = "";
         AV43UserInfoResponseUserBirthdayTag = "";
         AV55UserInfoResponseUserURLImageTag = "";
         AV56UserInfoResponseUserURLProfileTag = "";
         AV50UserInfoResponseUserLanguageTag = "";
         AV54UserInfoResponseUserTimeZoneTag = "";
         AV42UserInfoResponseErrorDescriptionTag = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV11DynamicPropName = "";
         AV12DynamicPropTag = "";
         AV9DeletePropertyImage = "";
         lblBtnadd_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         bttBtnconfirm_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV63Deletepropertyimage_GXI = "";
         AV5AuthenticationTypeSaml20 = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSaml20(context);
         AV14Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV13Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         AV17GAMPropertySimple = new GeneXus.Programs.genexussecurity.SdtGAMPropertySimple(context);
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlGx_mode = "";
         sCtrlAV33Name = "";
         sCtrlAV41TypeId = "";
         ROClassString = "";
         sImgUrl = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamwcauthenticationtypeentrysaml20__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamwcauthenticationtypeentrysaml20__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private short GRID1_nEOF ;
      private int divTbkeystoreadvanced_Visible ;
      private int nRC_GXsfl_261 ;
      private int nGXsfl_261_idx=1 ;
      private int Tab1_Pagecount ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavSmallimagename_Enabled ;
      private int edtavBigimagename_Enabled ;
      private int edtavImpersonate_Enabled ;
      private int edtavAuthncontext_Enabled ;
      private int edtavLocalsiteurl_Enabled ;
      private int edtavIdentityproviderentityid_Enabled ;
      private int edtavServiceproviderentityid_Enabled ;
      private int edtavSamlendpointlocation_Enabled ;
      private int edtavSinglelogoutendpoint_Enabled ;
      private int edtavKeystpathcredential_Enabled ;
      private int edtavKeystpwdcredential_Enabled ;
      private int edtavKeyaliascredential_Enabled ;
      private int edtavKeystorecredential_Enabled ;
      private int edtavKeystorefilepathtrustcred_Enabled ;
      private int edtavKeystorepwdtrustcred_Enabled ;
      private int edtavKeyaliastrustcred_Enabled ;
      private int edtavKeystoretrustcred_Enabled ;
      private int edtavUserinforesponseuseremailtag_Enabled ;
      private int edtavUserinforesponseuserexternalidtag_Enabled ;
      private int edtavUserinforesponseusernametag_Enabled ;
      private int edtavUserinforesponseuserfirstnametag_Enabled ;
      private int edtavUserinforesponseuserlastnametag_Enabled ;
      private int edtavUserinforesponseusergendertag_Enabled ;
      private int edtavUserinforesponseusergendervalues_Enabled ;
      private int edtavUserinforesponseuserbirthdaytag_Enabled ;
      private int edtavUserinforesponseuserurlimagetag_Enabled ;
      private int edtavUserinforesponseuserurlprofiletag_Enabled ;
      private int edtavUserinforesponseuserlanguagetag_Enabled ;
      private int edtavUserinforesponseusertimezonetag_Enabled ;
      private int edtavUserinforesponseerrordescriptiontag_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int edtavDynamicpropname_Visible ;
      private int edtavDynamicproptag_Visible ;
      private int edtavDeletepropertyimage_Visible ;
      private int edtavDynamicpropname_Enabled ;
      private int edtavDynamicproptag_Enabled ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int lblBtnadd_Visible ;
      private int bttBtnconfirm_Visible ;
      private int subGrid1_Islastpage ;
      private int AV61GXV1 ;
      private int AV62GXV2 ;
      private int nGXsfl_261_fel_idx=1 ;
      private int AV65GXV3 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavDeletepropertyimage_Enabled ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nFirstRecordOnPage ;
      private String Gx_mode ;
      private String AV33Name ;
      private String AV41TypeId ;
      private String wcpOGx_mode ;
      private String wcpOAV33Name ;
      private String wcpOAV41TypeId ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_261_idx="0001" ;
      private String AV45UserInfoResponseUserErrorDescriptionTag ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Tab1_Class ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String divTable2_Internalname ;
      private String divTbldata_Internalname ;
      private String edtavName_Internalname ;
      private String TempTags ;
      private String edtavName_Jsonclick ;
      private String cmbavFunctionid_Internalname ;
      private String AV16FunctionId ;
      private String cmbavFunctionid_Jsonclick ;
      private String chkavIsenable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDsc_Internalname ;
      private String AV10Dsc ;
      private String edtavDsc_Jsonclick ;
      private String edtavSmallimagename_Internalname ;
      private String AV40SmallImageName ;
      private String edtavSmallimagename_Jsonclick ;
      private String edtavBigimagename_Internalname ;
      private String AV7BigImageName ;
      private String edtavBigimagename_Jsonclick ;
      private String edtavImpersonate_Internalname ;
      private String AV19Impersonate ;
      private String edtavImpersonate_Jsonclick ;
      private String divTbloauth20_Internalname ;
      private String Tab1_Internalname ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String chkavForceauthn_Internalname ;
      private String edtavAuthncontext_Internalname ;
      private String AV6AuthnContext ;
      private String edtavAuthncontext_Jsonclick ;
      private String edtavLocalsiteurl_Internalname ;
      private String edtavLocalsiteurl_Jsonclick ;
      private String grpGroup6_Internalname ;
      private String divGroup6table_Internalname ;
      private String edtavIdentityproviderentityid_Internalname ;
      private String edtavIdentityproviderentityid_Jsonclick ;
      private String edtavServiceproviderentityid_Internalname ;
      private String edtavServiceproviderentityid_Jsonclick ;
      private String edtavSamlendpointlocation_Internalname ;
      private String edtavSamlendpointlocation_Jsonclick ;
      private String grpGroup5_Internalname ;
      private String divGroup5table_Internalname ;
      private String edtavSinglelogoutendpoint_Internalname ;
      private String edtavSinglelogoutendpoint_Jsonclick ;
      private String lblCredentials_title_Internalname ;
      private String lblCredentials_title_Jsonclick ;
      private String divTabpage3table_Internalname ;
      private String grpGroup1_Internalname ;
      private String divGroup1table_Internalname ;
      private String edtavKeystpathcredential_Internalname ;
      private String edtavKeystpathcredential_Jsonclick ;
      private String edtavKeystpwdcredential_Internalname ;
      private String AV30KeyStPwdCredential ;
      private String edtavKeystpwdcredential_Jsonclick ;
      private String edtavKeyaliascredential_Internalname ;
      private String AV22KeyAliasCredential ;
      private String edtavKeyaliascredential_Jsonclick ;
      private String edtavKeystorecredential_Internalname ;
      private String AV25KeyStoreCredential ;
      private String edtavKeystorecredential_Jsonclick ;
      private String grpGroup2_Internalname ;
      private String divGroup2table_Internalname ;
      private String edtavKeystorefilepathtrustcred_Internalname ;
      private String edtavKeystorefilepathtrustcred_Jsonclick ;
      private String lblTboauth20authadvanced_Internalname ;
      private String lblTboauth20authadvanced_Jsonclick ;
      private String divTbkeystoreadvanced_Internalname ;
      private String edtavKeystorepwdtrustcred_Internalname ;
      private String AV27KeyStorePwdTrustCred ;
      private String edtavKeystorepwdtrustcred_Jsonclick ;
      private String edtavKeyaliastrustcred_Internalname ;
      private String AV23KeyAliasTrustCred ;
      private String edtavKeyaliastrustcred_Jsonclick ;
      private String edtavKeystoretrustcred_Internalname ;
      private String AV28KeyStoreTrustCred ;
      private String edtavKeystoretrustcred_Jsonclick ;
      private String lblUserinfo_title_Internalname ;
      private String lblUserinfo_title_Jsonclick ;
      private String divTabpage1table1_Internalname ;
      private String grpGroup3_Internalname ;
      private String divGroup3table1_Internalname ;
      private String edtavUserinforesponseuseremailtag_Internalname ;
      private String AV44UserInfoResponseUserEmailTag ;
      private String edtavUserinforesponseuseremailtag_Jsonclick ;
      private String edtavUserinforesponseuserexternalidtag_Internalname ;
      private String AV46UserInfoResponseUserExternalIdTag ;
      private String edtavUserinforesponseuserexternalidtag_Jsonclick ;
      private String edtavUserinforesponseusernametag_Internalname ;
      private String AV53UserInfoResponseUserNameTag ;
      private String edtavUserinforesponseusernametag_Jsonclick ;
      private String divTbluserfirstname_Internalname ;
      private String lblTbuserfirstname_Internalname ;
      private String lblTbuserfirstname_Jsonclick ;
      private String edtavUserinforesponseuserfirstnametag_Internalname ;
      private String AV47UserInfoResponseUserFirstNameTag ;
      private String edtavUserinforesponseuserfirstnametag_Jsonclick ;
      private String cmbavUserinforesponseuserlastnamegenauto_Internalname ;
      private String cmbavUserinforesponseuserlastnamegenauto_Jsonclick ;
      private String divTbluserlastname_Internalname ;
      private String lblTbuserlastname_Internalname ;
      private String lblTbuserlastname_Jsonclick ;
      private String edtavUserinforesponseuserlastnametag_Internalname ;
      private String AV52UserInfoResponseUserLastNameTag ;
      private String edtavUserinforesponseuserlastnametag_Jsonclick ;
      private String lblTbuserlastnamehelp_Internalname ;
      private String lblTbuserlastnamehelp_Jsonclick ;
      private String divTblusergender_Internalname ;
      private String lblTbusergender_Internalname ;
      private String lblTbusergender_Jsonclick ;
      private String edtavUserinforesponseusergendertag_Internalname ;
      private String AV48UserInfoResponseUserGenderTag ;
      private String edtavUserinforesponseusergendertag_Jsonclick ;
      private String edtavUserinforesponseusergendervalues_Internalname ;
      private String edtavUserinforesponseusergendervalues_Jsonclick ;
      private String edtavUserinforesponseuserbirthdaytag_Internalname ;
      private String AV43UserInfoResponseUserBirthdayTag ;
      private String edtavUserinforesponseuserbirthdaytag_Jsonclick ;
      private String edtavUserinforesponseuserurlimagetag_Internalname ;
      private String AV55UserInfoResponseUserURLImageTag ;
      private String edtavUserinforesponseuserurlimagetag_Jsonclick ;
      private String edtavUserinforesponseuserurlprofiletag_Internalname ;
      private String AV56UserInfoResponseUserURLProfileTag ;
      private String edtavUserinforesponseuserurlprofiletag_Jsonclick ;
      private String edtavUserinforesponseuserlanguagetag_Internalname ;
      private String AV50UserInfoResponseUserLanguageTag ;
      private String edtavUserinforesponseuserlanguagetag_Jsonclick ;
      private String edtavUserinforesponseusertimezonetag_Internalname ;
      private String AV54UserInfoResponseUserTimeZoneTag ;
      private String edtavUserinforesponseusertimezonetag_Jsonclick ;
      private String edtavUserinforesponseerrordescriptiontag_Internalname ;
      private String AV42UserInfoResponseErrorDescriptionTag ;
      private String edtavUserinforesponseerrordescriptiontag_Jsonclick ;
      private String divTable1_Internalname ;
      private String grpGroup4_Internalname ;
      private String divGroup4table_Internalname ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String AV11DynamicPropName ;
      private String AV12DynamicPropTag ;
      private String lblBtnadd_Internalname ;
      private String lblBtnadd_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String bttBtnconfirm_Internalname ;
      private String bttBtnconfirm_Caption ;
      private String bttBtnconfirm_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDynamicpropname_Internalname ;
      private String edtavDynamicproptag_Internalname ;
      private String edtavDeletepropertyimage_Internalname ;
      private String sGXsfl_261_fel_idx="0001" ;
      private String sCtrlGx_mode ;
      private String sCtrlAV33Name ;
      private String sCtrlAV41TypeId ;
      private String ROClassString ;
      private String edtavDynamicpropname_Jsonclick ;
      private String edtavDynamicproptag_Jsonclick ;
      private String sImgUrl ;
      private String edtavDeletepropertyimage_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV20IsEnable ;
      private bool AV15ForceAuthn ;
      private bool toggleJsOutput ;
      private bool Tab1_Historymanagement ;
      private bool wbLoad ;
      private bool AV51UserInfoResponseUserLastNameGenAuto ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_261_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV9DeletePropertyImage_IsBlob ;
      private String AV31LocalSiteURL ;
      private String AV18IdentityProviderEntityID ;
      private String AV38ServiceProviderEntityID ;
      private String AV37SamlEndpointLocation ;
      private String AV39SingleLogoutendpoint ;
      private String AV29KeyStPathCredential ;
      private String AV26KeyStoreFilePathTrustCred ;
      private String AV49UserInfoResponseUserGenderValues ;
      private String AV63Deletepropertyimage_GXI ;
      private String AV9DeletePropertyImage ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private GXUserControl ucTab1 ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private String aP0_Gx_mode ;
      private String aP1_Name ;
      private String aP2_TypeId ;
      private GXCombobox cmbavFunctionid ;
      private GXCheckbox chkavIsenable ;
      private GXCheckbox chkavForceauthn ;
      private GXCombobox cmbavUserinforesponseuserlastnamegenauto ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV14Errors ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSaml20 AV5AuthenticationTypeSaml20 ;
      private GeneXus.Programs.genexussecurity.SdtGAMPropertySimple AV17GAMPropertySimple ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV13Error ;
   }

   public class gamwcauthenticationtypeentrysaml20__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamwcauthenticationtypeentrysaml20__default : DataStoreHelperBase, IDataStoreHelper
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
