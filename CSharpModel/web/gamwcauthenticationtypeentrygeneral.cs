/*
               File: GAMWCAuthenticationTypeEntryGeneral
        Description: Authentication Type Entry General
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:2:58.91
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
   public class gamwcauthenticationtypeentrygeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public gamwcauthenticationtypeentrygeneral( )
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

      public gamwcauthenticationtypeentrygeneral( IGxContext context )
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
         this.AV34Name = aP1_Name;
         this.AV37TypeId = aP2_TypeId;
         executePrivate();
         aP0_Gx_mode=this.Gx_mode;
         aP1_Name=this.AV34Name;
         aP2_TypeId=this.AV37TypeId;
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
         chkavAdduseradditionaldatascope = new GXCheckbox();
         chkavAddinitialpropertiesscope = new GXCheckbox();
         cmbavWsversion = new GXCombobox();
         cmbavWsserversecureprotocol = new GXCombobox();
         cmbavCusversion = new GXCombobox();
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
                  AV34Name = GetNextPar( );
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
                  AV37TypeId = GetNextPar( );
                  AssignAttri(sPrefix, false, "AV37TypeId", AV37TypeId);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)Gx_mode,(String)AV34Name,(String)AV37TypeId});
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
            PA1R2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS1R2( ) ;
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
            context.SendWebValue( "Authentication Type Entry General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020415113089", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
            context.WriteHtmlText( " "+"class=\"form-horizontal\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal\" data-gx-class=\"form-horizontal\" novalidate action=\""+formatLink("gamwcauthenticationtypeentrygeneral.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV34Name)) + "," + UrlEncode(StringUtil.RTrim(AV37TypeId))+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            AssignProp(sPrefix, false, "FORM", "Class", "form-horizontal", true);
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
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal" : Form.Class)+"-fx");
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
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOGx_mode", StringUtil.RTrim( wcpOGx_mode));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV34Name", StringUtil.RTrim( wcpOAV34Name));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV37TypeId", StringUtil.RTrim( wcpOAV37TypeId));
         GxWebStd.gx_hidden_field( context, sPrefix+"vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTYPEID", StringUtil.RTrim( AV37TypeId));
      }

      protected void RenderHtmlCloseForm1R2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("gamwcauthenticationtypeentrygeneral.js", "?2020415113130", false, true);
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
         return "GAMWCAuthenticationTypeEntryGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Authentication Type Entry General" ;
      }

      protected void WB1R0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "gamwcauthenticationtypeentrygeneral.aspx");
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
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "FormWebComp", "left", "top", "", "", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV34Name), StringUtil.RTrim( context.localUtil.Format( AV34Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,14);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavFunctionid, cmbavFunctionid_Internalname, StringUtil.RTrim( AV28FunctionId), 1, cmbavFunctionid_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavFunctionid.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,19);\"", "", true, "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            cmbavFunctionid.CurrentValue = StringUtil.RTrim( AV28FunctionId);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'" + sPrefix + "',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavIsenable_Internalname, StringUtil.BoolToStr( AV33IsEnable), "", "Enabled?", 1, chkavIsenable.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(24, this, 'true', 'false',"+"'"+sPrefix+"'"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,24);\"");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDsc_Internalname, StringUtil.RTrim( AV25Dsc), StringUtil.RTrim( context.localUtil.Format( AV25Dsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,29);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDsc_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSmallimagename_Internalname, StringUtil.RTrim( AV36SmallImageName), StringUtil.RTrim( context.localUtil.Format( AV36SmallImageName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSmallimagename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSmallimagename_Enabled, 1, "text", "", 60, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBigimagename_Internalname, StringUtil.RTrim( AV14BigImageName), StringUtil.RTrim( context.localUtil.Format( AV14BigImageName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBigimagename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBigimagename_Enabled, 1, "text", "", 60, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTblimpersonate_Internalname, divTblimpersonate_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavImpersonate_Internalname, StringUtil.RTrim( AV32Impersonate), StringUtil.RTrim( context.localUtil.Format( AV32Impersonate, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,47);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavImpersonate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavImpersonate_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMAuthenticationTypeName", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTblclientidsecret_Internalname, divTblclientidsecret_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientid_Internalname, "Client Id.", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientid_Internalname, AV16ClientId, StringUtil.RTrim( context.localUtil.Format( AV16ClientId, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,55);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientid_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavClientid_Enabled, 1, "text", "", 60, "chr", 1, "row", 400, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMPropertyValue", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientsecret_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientsecret_Internalname, "Client Secret", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientsecret_Internalname, AV17ClientSecret, StringUtil.RTrim( context.localUtil.Format( AV17ClientSecret, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,60);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientsecret_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavClientsecret_Enabled, 1, "text", "", 60, "chr", 1, "row", 400, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMPropertyValue", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavVersionpath_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVersionpath_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVersionpath_Internalname, "Version path", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVersionpath_Internalname, StringUtil.RTrim( AV52VersionPath), StringUtil.RTrim( context.localUtil.Format( AV52VersionPath, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,65);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVersionpath_Jsonclick, 0, "Attribute", "", "", "", "", edtavVersionpath_Visible, edtavVersionpath_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTblclientlocalserver_Internalname, divTblclientlocalserver_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavSiteurl_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSiteurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSiteurl_Internalname, "Local site URL", "col-sm-3 URLAttributeLabel RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSiteurl_Internalname, AV35SiteURL, StringUtil.RTrim( context.localUtil.Format( AV35SiteURL, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,73);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSiteurl_Jsonclick, 0, "URLAttribute RequiredAttribute", "", "", "", "", edtavSiteurl_Visible, edtavSiteurl_Enabled, 1, "text", "", 60, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTbltwitter_Internalname, divTbltwitter_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConsumerkey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConsumerkey_Internalname, "Consumer Key", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConsumerkey_Internalname, StringUtil.RTrim( AV18ConsumerKey), StringUtil.RTrim( context.localUtil.Format( AV18ConsumerKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,81);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConsumerkey_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavConsumerkey_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConsumersecret_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConsumersecret_Internalname, "Consumer Secret", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConsumersecret_Internalname, StringUtil.RTrim( AV19ConsumerSecret), StringUtil.RTrim( context.localUtil.Format( AV19ConsumerSecret, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,86);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConsumersecret_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavConsumersecret_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCallbackurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCallbackurl_Internalname, "Callback URL", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCallbackurl_Internalname, AV15CallbackURL, StringUtil.RTrim( context.localUtil.Format( AV15CallbackURL, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,91);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCallbackurl_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavCallbackurl_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTblscopes_Internalname, divTblscopes_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 FormCell", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavAdduseradditionaldatascope_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavAdduseradditionaldatascope_Internalname, "Add gam_user_additional_data scope?", "col-sm-9 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'" + sPrefix + "',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavAdduseradditionaldatascope_Internalname, StringUtil.BoolToStr( AV54AddUserAdditionalDataScope), "", "Add gam_user_additional_data scope?", 1, chkavAdduseradditionaldatascope.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(99, this, 'true', 'false',"+"'"+sPrefix+"'"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,99);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 FormCell", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavAddinitialpropertiesscope_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavAddinitialpropertiesscope_Internalname, "Add gam_session_initial_prop scope?", "col-sm-9 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'" + sPrefix + "',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavAddinitialpropertiesscope_Internalname, StringUtil.BoolToStr( AV50AddInitialPropertiesScope), "", "Add gam_session_initial_prop scope?", 1, chkavAddinitialpropertiesscope.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(103, this, 'true', 'false',"+"'"+sPrefix+"'"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,103);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTblcommonadditional_Internalname, divTblcommonadditional_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAdditionalscope_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdditionalscope_Internalname, "Additional Scope", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAdditionalscope_Internalname, AV5AdditionalScope, StringUtil.RTrim( context.localUtil.Format( AV5AdditionalScope, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,111);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAdditionalscope_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavAdditionalscope_Enabled, 1, "text", "", 60, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTblauthtypename_Internalname, divTblauthtypename_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamrauthenticationtypename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamrauthenticationtypename_Internalname, "Remote server authentication type name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamrauthenticationtypename_Internalname, StringUtil.RTrim( AV53GAMRAuthenticationTypeName), StringUtil.RTrim( context.localUtil.Format( AV53GAMRAuthenticationTypeName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,119);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamrauthenticationtypename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGamrauthenticationtypename_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMAuthenticationTypeName", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTblserverhost_Internalname, divTblserverhost_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamrserverurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamrserverurl_Internalname, "Remote server URL", "col-sm-3 URLAttributeLabel RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamrserverurl_Internalname, AV31GAMRServerURL, StringUtil.RTrim( context.localUtil.Format( AV31GAMRServerURL, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,127);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamrserverurl_Jsonclick, 0, "URLAttribute RequiredAttribute", "", "", "", "", 1, edtavGamrserverurl_Enabled, 1, "text", "", 60, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamrprivateencryptkey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamrprivateencryptkey_Internalname, "Private Encription Key", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 132,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamrprivateencryptkey_Internalname, StringUtil.RTrim( AV29GAMRPrivateEncryptKey), StringUtil.RTrim( context.localUtil.Format( AV29GAMRPrivateEncryptKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,132);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamrprivateencryptkey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGamrprivateencryptkey_Enabled, 1, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMEncryptionKey", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFormcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamrrepositoryguid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamrrepositoryguid_Internalname, "Repository GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 137,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamrrepositoryguid_Internalname, StringUtil.RTrim( AV30GAMRRepositoryGUID), StringUtil.RTrim( context.localUtil.Format( AV30GAMRRepositoryGUID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,137);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamrrepositoryguid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGamrrepositoryguid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMGUID", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTblwebservice_Internalname, divTblwebservice_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavWsversion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavWsversion_Internalname, "Web service version", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 145,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavWsversion, cmbavWsversion_Internalname, StringUtil.RTrim( AV47WSVersion), 1, cmbavWsversion_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavWsversion.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,145);\"", "", true, "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            cmbavWsversion.CurrentValue = StringUtil.RTrim( AV47WSVersion);
            AssignProp(sPrefix, false, cmbavWsversion_Internalname, "Values", (String)(cmbavWsversion.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsprivateencryptkey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsprivateencryptkey_Internalname, "Private Encription Key", "col-sm-4 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 150,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsprivateencryptkey_Internalname, StringUtil.RTrim( AV41WSPrivateEncryptKey), StringUtil.RTrim( context.localUtil.Format( AV41WSPrivateEncryptKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,150);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsprivateencryptkey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsprivateencryptkey_Enabled, 1, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMEncryptionKey", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'" + sPrefix + "',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngenkey_Internalname, "", "Generate Key", bttBtngenkey_Jsonclick, 5, "Generate Key", "", StyleString, ClassString, bttBtngenkey_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'GENERATEKEY\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsservername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsservername_Internalname, "Server name", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 157,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsservername_Internalname, StringUtil.RTrim( AV43WSServerName), StringUtil.RTrim( context.localUtil.Format( AV43WSServerName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,157);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsservername_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavWsservername_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsserverport_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsserverport_Internalname, "Server port", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 162,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsserverport_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44WSServerPort), 5, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV44WSServerPort), "ZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,162);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsserverport_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavWsserverport_Enabled, 1, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsserverbaseurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsserverbaseurl_Internalname, "Base URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 167,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsserverbaseurl_Internalname, StringUtil.RTrim( AV42WSServerBaseURL), StringUtil.RTrim( context.localUtil.Format( AV42WSServerBaseURL, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,167);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsserverbaseurl_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsserverbaseurl_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavWsserversecureprotocol_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavWsserversecureprotocol_Internalname, "Secure protocol", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 172,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavWsserversecureprotocol, cmbavWsserversecureprotocol_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV45WSServerSecureProtocol), 1, 0)), 1, cmbavWsserversecureprotocol_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavWsserversecureprotocol.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,172);\"", "", true, "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            cmbavWsserversecureprotocol.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV45WSServerSecureProtocol), 1, 0));
            AssignProp(sPrefix, false, cmbavWsserversecureprotocol_Internalname, "Values", (String)(cmbavWsserversecureprotocol.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWstimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWstimeout_Internalname, "Timeout (Seconds)", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 177,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWstimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV46WSTimeout), 5, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV46WSTimeout), "ZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,177);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWstimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWstimeout_Enabled, 1, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWspackage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWspackage_Internalname, "Package", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 182,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWspackage_Internalname, StringUtil.RTrim( AV40WSPackage), StringUtil.RTrim( context.localUtil.Format( AV40WSPackage, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,182);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWspackage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWspackage_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsname_Internalname, "Name", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 187,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsname_Internalname, StringUtil.RTrim( AV39WSName), StringUtil.RTrim( context.localUtil.Format( AV39WSName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,187);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsname_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavWsname_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsextension_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsextension_Internalname, "Extension", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 192,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsextension_Internalname, StringUtil.RTrim( AV38WSExtension), StringUtil.RTrim( context.localUtil.Format( AV38WSExtension, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,192);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsextension_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsextension_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
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
            GxWebStd.gx_div_start( context, divTblexternal_Internalname, divTblexternal_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavCusversion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCusversion_Internalname, "JSON version", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 200,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCusversion, cmbavCusversion_Internalname, StringUtil.RTrim( AV24CusVersion), 1, cmbavCusversion_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavCusversion.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,200);\"", "", true, "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            cmbavCusversion.CurrentValue = StringUtil.RTrim( AV24CusVersion);
            AssignProp(sPrefix, false, cmbavCusversion_Internalname, "Values", (String)(cmbavCusversion.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCusprivateencryptkey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusprivateencryptkey_Internalname, "Private encription key", "col-sm-4 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 205,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusprivateencryptkey_Internalname, StringUtil.RTrim( AV23CusPrivateEncryptKey), StringUtil.RTrim( context.localUtil.Format( AV23CusPrivateEncryptKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,205);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusprivateencryptkey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCusprivateencryptkey_Enabled, 1, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMEncryptionKey", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 207,'" + sPrefix + "',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngenkeycustom_Internalname, "", "Generate Key Custom", bttBtngenkeycustom_Jsonclick, 5, "Generate Key Custom", "", StyleString, ClassString, bttBtngenkeycustom_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'GENERATEKEYCUSTOM\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCusfilename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusfilename_Internalname, "File name", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 212,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusfilename_Internalname, StringUtil.RTrim( AV21CusFileName), StringUtil.RTrim( context.localUtil.Format( AV21CusFileName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,212);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusfilename_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavCusfilename_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCuspackage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCuspackage_Internalname, "Package", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 217,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCuspackage_Internalname, StringUtil.RTrim( AV22CusPackage), StringUtil.RTrim( context.localUtil.Format( AV22CusPackage, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,217);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCuspackage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCuspackage_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCusclassname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusclassname_Internalname, "Class name", "col-sm-3 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 222,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusclassname_Internalname, StringUtil.RTrim( AV20CusClassName), StringUtil.RTrim( context.localUtil.Format( AV20CusClassName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,222);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusclassname_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavCusclassname_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row BackgroundColorRow", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 227,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Cancel", bttBtncancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 229,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "", bttBtnconfirm_Caption, bttBtnconfirm_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtnconfirm_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMWCAuthenticationTypeEntryGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
               Form.Meta.addItem("description", "Authentication Type Entry General", 0) ;
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
               STRUP1R0( ) ;
            }
         }
      }

      protected void WS1R2( )
      {
         START1R2( ) ;
         EVT1R2( ) ;
      }

      protected void EVT1R2( )
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
                                 STRUP1R0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E111R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1R0( ) ;
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
                                          E121R2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GENERATEKEY'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'GenerateKey' */
                                    E131R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GENERATEKEYCUSTOM'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'GenerateKeyCustom' */
                                    E141R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E151R2 ();
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = cmbavFunctionid_Internalname;
                                    AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
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

      protected void WE1R2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1R2( ) ;
            }
         }
      }

      protected void PA1R2( )
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
            AV28FunctionId = cmbavFunctionid.getValidValue(AV28FunctionId);
            AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavFunctionid.CurrentValue = StringUtil.RTrim( AV28FunctionId);
            AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Values", cmbavFunctionid.ToJavascriptSource(), true);
         }
         AV33IsEnable = StringUtil.StrToBool( StringUtil.BoolToStr( AV33IsEnable));
         AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
         AV54AddUserAdditionalDataScope = StringUtil.StrToBool( StringUtil.BoolToStr( AV54AddUserAdditionalDataScope));
         AssignAttri(sPrefix, false, "AV54AddUserAdditionalDataScope", AV54AddUserAdditionalDataScope);
         AV50AddInitialPropertiesScope = StringUtil.StrToBool( StringUtil.BoolToStr( AV50AddInitialPropertiesScope));
         AssignAttri(sPrefix, false, "AV50AddInitialPropertiesScope", AV50AddInitialPropertiesScope);
         if ( cmbavWsversion.ItemCount > 0 )
         {
            AV47WSVersion = cmbavWsversion.getValidValue(AV47WSVersion);
            AssignAttri(sPrefix, false, "AV47WSVersion", AV47WSVersion);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavWsversion.CurrentValue = StringUtil.RTrim( AV47WSVersion);
            AssignProp(sPrefix, false, cmbavWsversion_Internalname, "Values", cmbavWsversion.ToJavascriptSource(), true);
         }
         if ( cmbavWsserversecureprotocol.ItemCount > 0 )
         {
            AV45WSServerSecureProtocol = (short)(NumberUtil.Val( cmbavWsserversecureprotocol.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV45WSServerSecureProtocol), 1, 0))), "."));
            AssignAttri(sPrefix, false, "AV45WSServerSecureProtocol", StringUtil.Str( (decimal)(AV45WSServerSecureProtocol), 1, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavWsserversecureprotocol.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV45WSServerSecureProtocol), 1, 0));
            AssignProp(sPrefix, false, cmbavWsserversecureprotocol_Internalname, "Values", cmbavWsserversecureprotocol.ToJavascriptSource(), true);
         }
         if ( cmbavCusversion.ItemCount > 0 )
         {
            AV24CusVersion = cmbavCusversion.getValidValue(AV24CusVersion);
            AssignAttri(sPrefix, false, "AV24CusVersion", AV24CusVersion);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCusversion.CurrentValue = StringUtil.RTrim( AV24CusVersion);
            AssignProp(sPrefix, false, cmbavCusversion_Internalname, "Values", cmbavCusversion.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1R2( ) ;
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

      protected void RF1R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E151R2 ();
            WB1R0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1R2( )
      {
      }

      protected void STRUP1R0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111R2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            wcpOGx_mode = cgiGet( sPrefix+"wcpOGx_mode");
            wcpOAV34Name = cgiGet( sPrefix+"wcpOAV34Name");
            wcpOAV37TypeId = cgiGet( sPrefix+"wcpOAV37TypeId");
            /* Read variables values. */
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               AV34Name = cgiGet( edtavName_Internalname);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
            }
            cmbavFunctionid.CurrentValue = cgiGet( cmbavFunctionid_Internalname);
            AV28FunctionId = cgiGet( cmbavFunctionid_Internalname);
            AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
            AV33IsEnable = StringUtil.StrToBool( cgiGet( chkavIsenable_Internalname));
            AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
            AV25Dsc = cgiGet( edtavDsc_Internalname);
            AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
            AV36SmallImageName = cgiGet( edtavSmallimagename_Internalname);
            AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
            AV14BigImageName = cgiGet( edtavBigimagename_Internalname);
            AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
            AV32Impersonate = cgiGet( edtavImpersonate_Internalname);
            AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
            AV16ClientId = cgiGet( edtavClientid_Internalname);
            AssignAttri(sPrefix, false, "AV16ClientId", AV16ClientId);
            AV17ClientSecret = cgiGet( edtavClientsecret_Internalname);
            AssignAttri(sPrefix, false, "AV17ClientSecret", AV17ClientSecret);
            AV52VersionPath = cgiGet( edtavVersionpath_Internalname);
            AssignAttri(sPrefix, false, "AV52VersionPath", AV52VersionPath);
            AV35SiteURL = cgiGet( edtavSiteurl_Internalname);
            AssignAttri(sPrefix, false, "AV35SiteURL", AV35SiteURL);
            AV18ConsumerKey = cgiGet( edtavConsumerkey_Internalname);
            AssignAttri(sPrefix, false, "AV18ConsumerKey", AV18ConsumerKey);
            AV19ConsumerSecret = cgiGet( edtavConsumersecret_Internalname);
            AssignAttri(sPrefix, false, "AV19ConsumerSecret", AV19ConsumerSecret);
            AV15CallbackURL = cgiGet( edtavCallbackurl_Internalname);
            AssignAttri(sPrefix, false, "AV15CallbackURL", AV15CallbackURL);
            AV54AddUserAdditionalDataScope = StringUtil.StrToBool( cgiGet( chkavAdduseradditionaldatascope_Internalname));
            AssignAttri(sPrefix, false, "AV54AddUserAdditionalDataScope", AV54AddUserAdditionalDataScope);
            AV50AddInitialPropertiesScope = StringUtil.StrToBool( cgiGet( chkavAddinitialpropertiesscope_Internalname));
            AssignAttri(sPrefix, false, "AV50AddInitialPropertiesScope", AV50AddInitialPropertiesScope);
            AV5AdditionalScope = cgiGet( edtavAdditionalscope_Internalname);
            AssignAttri(sPrefix, false, "AV5AdditionalScope", AV5AdditionalScope);
            AV53GAMRAuthenticationTypeName = cgiGet( edtavGamrauthenticationtypename_Internalname);
            AssignAttri(sPrefix, false, "AV53GAMRAuthenticationTypeName", AV53GAMRAuthenticationTypeName);
            AV31GAMRServerURL = cgiGet( edtavGamrserverurl_Internalname);
            AssignAttri(sPrefix, false, "AV31GAMRServerURL", AV31GAMRServerURL);
            AV29GAMRPrivateEncryptKey = cgiGet( edtavGamrprivateencryptkey_Internalname);
            AssignAttri(sPrefix, false, "AV29GAMRPrivateEncryptKey", AV29GAMRPrivateEncryptKey);
            AV30GAMRRepositoryGUID = cgiGet( edtavGamrrepositoryguid_Internalname);
            AssignAttri(sPrefix, false, "AV30GAMRRepositoryGUID", AV30GAMRRepositoryGUID);
            cmbavWsversion.CurrentValue = cgiGet( cmbavWsversion_Internalname);
            AV47WSVersion = cgiGet( cmbavWsversion_Internalname);
            AssignAttri(sPrefix, false, "AV47WSVersion", AV47WSVersion);
            AV41WSPrivateEncryptKey = cgiGet( edtavWsprivateencryptkey_Internalname);
            AssignAttri(sPrefix, false, "AV41WSPrivateEncryptKey", AV41WSPrivateEncryptKey);
            AV43WSServerName = cgiGet( edtavWsservername_Internalname);
            AssignAttri(sPrefix, false, "AV43WSServerName", AV43WSServerName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavWsserverport_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavWsserverport_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vWSSERVERPORT");
               GX_FocusControl = edtavWsserverport_Internalname;
               AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV44WSServerPort = 0;
               AssignAttri(sPrefix, false, "AV44WSServerPort", StringUtil.LTrimStr( (decimal)(AV44WSServerPort), 5, 0));
            }
            else
            {
               AV44WSServerPort = (int)(context.localUtil.CToN( cgiGet( edtavWsserverport_Internalname), ".", ","));
               AssignAttri(sPrefix, false, "AV44WSServerPort", StringUtil.LTrimStr( (decimal)(AV44WSServerPort), 5, 0));
            }
            AV42WSServerBaseURL = cgiGet( edtavWsserverbaseurl_Internalname);
            AssignAttri(sPrefix, false, "AV42WSServerBaseURL", AV42WSServerBaseURL);
            cmbavWsserversecureprotocol.CurrentValue = cgiGet( cmbavWsserversecureprotocol_Internalname);
            AV45WSServerSecureProtocol = (short)(NumberUtil.Val( cgiGet( cmbavWsserversecureprotocol_Internalname), "."));
            AssignAttri(sPrefix, false, "AV45WSServerSecureProtocol", StringUtil.Str( (decimal)(AV45WSServerSecureProtocol), 1, 0));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavWstimeout_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavWstimeout_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vWSTIMEOUT");
               GX_FocusControl = edtavWstimeout_Internalname;
               AssignAttri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV46WSTimeout = 0;
               AssignAttri(sPrefix, false, "AV46WSTimeout", StringUtil.LTrimStr( (decimal)(AV46WSTimeout), 5, 0));
            }
            else
            {
               AV46WSTimeout = (int)(context.localUtil.CToN( cgiGet( edtavWstimeout_Internalname), ".", ","));
               AssignAttri(sPrefix, false, "AV46WSTimeout", StringUtil.LTrimStr( (decimal)(AV46WSTimeout), 5, 0));
            }
            AV40WSPackage = cgiGet( edtavWspackage_Internalname);
            AssignAttri(sPrefix, false, "AV40WSPackage", AV40WSPackage);
            AV39WSName = cgiGet( edtavWsname_Internalname);
            AssignAttri(sPrefix, false, "AV39WSName", AV39WSName);
            AV38WSExtension = cgiGet( edtavWsextension_Internalname);
            AssignAttri(sPrefix, false, "AV38WSExtension", AV38WSExtension);
            cmbavCusversion.CurrentValue = cgiGet( cmbavCusversion_Internalname);
            AV24CusVersion = cgiGet( cmbavCusversion_Internalname);
            AssignAttri(sPrefix, false, "AV24CusVersion", AV24CusVersion);
            AV23CusPrivateEncryptKey = cgiGet( edtavCusprivateencryptkey_Internalname);
            AssignAttri(sPrefix, false, "AV23CusPrivateEncryptKey", AV23CusPrivateEncryptKey);
            AV21CusFileName = cgiGet( edtavCusfilename_Internalname);
            AssignAttri(sPrefix, false, "AV21CusFileName", AV21CusFileName);
            AV22CusPackage = cgiGet( edtavCuspackage_Internalname);
            AssignAttri(sPrefix, false, "AV22CusPackage", AV22CusPackage);
            AV20CusClassName = cgiGet( edtavCusclassname_Internalname);
            AssignAttri(sPrefix, false, "AV20CusClassName", AV20CusClassName);
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
         E111R2 ();
         if (returnInSub) return;
      }

      protected void E111R2( )
      {
         /* Start Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            edtavName_Enabled = 1;
            AssignProp(sPrefix, false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
            if ( StringUtil.StrCmp(AV37TypeId, "Twitter") == 0 )
            {
               AV36SmallImageName = "GAMButtonTwitterSmall";
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Facebook") == 0 )
            {
               AV36SmallImageName = "GAMButtonFacebookSmall";
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Google") == 0 )
            {
               AV36SmallImageName = "GAMButtonGoogleSmall";
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
            }
         }
         else
         {
            edtavName_Enabled = 0;
            AssignProp(sPrefix, false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
            AV28FunctionId = "OnlyAuthentication";
            AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
            if ( StringUtil.StrCmp(AV37TypeId, "GAMLocal") == 0 )
            {
               AV10AuthenticationTypeLocal.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV10AuthenticationTypeLocal.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV28FunctionId = AV10AuthenticationTypeLocal.gxTpr_Functionid;
               AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
               AV33IsEnable = AV10AuthenticationTypeLocal.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV10AuthenticationTypeLocal.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV10AuthenticationTypeLocal.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV10AuthenticationTypeLocal.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "AppleID") == 0 )
            {
               cmbavFunctionid.Enabled = 0;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV48AuthenticationTypeApple.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV48AuthenticationTypeApple.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV33IsEnable = AV48AuthenticationTypeApple.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV48AuthenticationTypeApple.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV48AuthenticationTypeApple.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV48AuthenticationTypeApple.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
               AV32Impersonate = AV48AuthenticationTypeApple.gxTpr_Impersonate;
               AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
               AV16ClientId = AV48AuthenticationTypeApple.gxTpr_Apple.gxTpr_Clientid;
               AssignAttri(sPrefix, false, "AV16ClientId", AV16ClientId);
               AV17ClientSecret = AV48AuthenticationTypeApple.gxTpr_Apple.gxTpr_Clientsecret;
               AssignAttri(sPrefix, false, "AV17ClientSecret", AV17ClientSecret);
               AV35SiteURL = AV48AuthenticationTypeApple.gxTpr_Apple.gxTpr_Siteurl;
               AssignAttri(sPrefix, false, "AV35SiteURL", AV35SiteURL);
               AV5AdditionalScope = AV48AuthenticationTypeApple.gxTpr_Apple.gxTpr_Additionalscope;
               AssignAttri(sPrefix, false, "AV5AdditionalScope", AV5AdditionalScope);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Facebook") == 0 )
            {
               cmbavFunctionid.Enabled = 0;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV7AuthenticationTypeFacebook.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV7AuthenticationTypeFacebook.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV33IsEnable = AV7AuthenticationTypeFacebook.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV7AuthenticationTypeFacebook.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV7AuthenticationTypeFacebook.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV7AuthenticationTypeFacebook.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
               AV32Impersonate = AV7AuthenticationTypeFacebook.gxTpr_Impersonate;
               AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
               AV16ClientId = AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Clientid;
               AssignAttri(sPrefix, false, "AV16ClientId", AV16ClientId);
               AV17ClientSecret = AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Clientsecret;
               AssignAttri(sPrefix, false, "AV17ClientSecret", AV17ClientSecret);
               AV52VersionPath = AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Versionpath;
               AssignAttri(sPrefix, false, "AV52VersionPath", AV52VersionPath);
               AV35SiteURL = AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Siteurl;
               AssignAttri(sPrefix, false, "AV35SiteURL", AV35SiteURL);
               AV5AdditionalScope = AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Additionalscope;
               AssignAttri(sPrefix, false, "AV5AdditionalScope", AV5AdditionalScope);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Google") == 0 )
            {
               cmbavFunctionid.Enabled = 0;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV9AuthenticationTypeGoogle.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV9AuthenticationTypeGoogle.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV33IsEnable = AV9AuthenticationTypeGoogle.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV9AuthenticationTypeGoogle.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV9AuthenticationTypeGoogle.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV9AuthenticationTypeGoogle.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
               AV32Impersonate = AV9AuthenticationTypeGoogle.gxTpr_Impersonate;
               AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
               AV16ClientId = AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Clientid;
               AssignAttri(sPrefix, false, "AV16ClientId", AV16ClientId);
               AV17ClientSecret = AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Clientsecret;
               AssignAttri(sPrefix, false, "AV17ClientSecret", AV17ClientSecret);
               AV52VersionPath = AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Versionpath;
               AssignAttri(sPrefix, false, "AV52VersionPath", AV52VersionPath);
               AV35SiteURL = AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Siteurl;
               AssignAttri(sPrefix, false, "AV35SiteURL", AV35SiteURL);
               AV5AdditionalScope = AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Additionalscope;
               AssignAttri(sPrefix, false, "AV5AdditionalScope", AV5AdditionalScope);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemote") == 0 )
            {
               cmbavFunctionid.Enabled = 1;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV8AuthenticationTypeGAMRemote.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV8AuthenticationTypeGAMRemote.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV28FunctionId = AV8AuthenticationTypeGAMRemote.gxTpr_Functionid;
               AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
               AV33IsEnable = AV8AuthenticationTypeGAMRemote.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV8AuthenticationTypeGAMRemote.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV8AuthenticationTypeGAMRemote.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV8AuthenticationTypeGAMRemote.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
               AV32Impersonate = AV8AuthenticationTypeGAMRemote.gxTpr_Impersonate;
               AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
               AV16ClientId = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Clientid;
               AssignAttri(sPrefix, false, "AV16ClientId", AV16ClientId);
               AV17ClientSecret = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Clientsecret;
               AssignAttri(sPrefix, false, "AV17ClientSecret", AV17ClientSecret);
               AV35SiteURL = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Siteurl;
               AssignAttri(sPrefix, false, "AV35SiteURL", AV35SiteURL);
               AV50AddInitialPropertiesScope = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Addsessioninitialpropertiesscope;
               AssignAttri(sPrefix, false, "AV50AddInitialPropertiesScope", AV50AddInitialPropertiesScope);
               AV54AddUserAdditionalDataScope = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Adduseradditionaldatascope;
               AssignAttri(sPrefix, false, "AV54AddUserAdditionalDataScope", AV54AddUserAdditionalDataScope);
               AV5AdditionalScope = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Additionalscope;
               AssignAttri(sPrefix, false, "AV5AdditionalScope", AV5AdditionalScope);
               AV31GAMRServerURL = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoteserverurl;
               AssignAttri(sPrefix, false, "AV31GAMRServerURL", AV31GAMRServerURL);
               AV29GAMRPrivateEncryptKey = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoteserverkey;
               AssignAttri(sPrefix, false, "AV29GAMRPrivateEncryptKey", AV29GAMRPrivateEncryptKey);
               AV30GAMRRepositoryGUID = AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoterepositoryguid;
               AssignAttri(sPrefix, false, "AV30GAMRRepositoryGUID", AV30GAMRRepositoryGUID);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemoteRest") == 0 )
            {
               cmbavFunctionid.Enabled = 1;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV51AuthenticationTypeGAMRemoteRest.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV28FunctionId = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Functionid;
               AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
               AV33IsEnable = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
               AV32Impersonate = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Impersonate;
               AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
               AV16ClientId = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Clientid;
               AssignAttri(sPrefix, false, "AV16ClientId", AV16ClientId);
               AV17ClientSecret = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Clientsecret;
               AssignAttri(sPrefix, false, "AV17ClientSecret", AV17ClientSecret);
               AV52VersionPath = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Versionpath;
               AssignAttri(sPrefix, false, "AV52VersionPath", AV52VersionPath);
               AV50AddInitialPropertiesScope = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Addsessioninitialpropertiesscope;
               AssignAttri(sPrefix, false, "AV50AddInitialPropertiesScope", AV50AddInitialPropertiesScope);
               AV54AddUserAdditionalDataScope = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Adduseradditionaldatascope;
               AssignAttri(sPrefix, false, "AV54AddUserAdditionalDataScope", AV54AddUserAdditionalDataScope);
               AV5AdditionalScope = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Additionalscope;
               AssignAttri(sPrefix, false, "AV5AdditionalScope", AV5AdditionalScope);
               AV53GAMRAuthenticationTypeName = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Remoteauthenticationtypename;
               AssignAttri(sPrefix, false, "AV53GAMRAuthenticationTypeName", AV53GAMRAuthenticationTypeName);
               AV31GAMRServerURL = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Remoteserverurl;
               AssignAttri(sPrefix, false, "AV31GAMRServerURL", AV31GAMRServerURL);
               AV29GAMRPrivateEncryptKey = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Remoteserverkey;
               AssignAttri(sPrefix, false, "AV29GAMRPrivateEncryptKey", AV29GAMRPrivateEncryptKey);
               AV30GAMRRepositoryGUID = AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Remoterepositoryguid;
               AssignAttri(sPrefix, false, "AV30GAMRRepositoryGUID", AV30GAMRRepositoryGUID);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Twitter") == 0 )
            {
               cmbavFunctionid.Enabled = 0;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV12AuthenticationTypeTwitter.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV12AuthenticationTypeTwitter.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV33IsEnable = AV12AuthenticationTypeTwitter.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV12AuthenticationTypeTwitter.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV12AuthenticationTypeTwitter.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV12AuthenticationTypeTwitter.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
               AV32Impersonate = AV12AuthenticationTypeTwitter.gxTpr_Impersonate;
               AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
               AV18ConsumerKey = AV12AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Consumerkey;
               AssignAttri(sPrefix, false, "AV18ConsumerKey", AV18ConsumerKey);
               AV19ConsumerSecret = AV12AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Consumersecret;
               AssignAttri(sPrefix, false, "AV19ConsumerSecret", AV19ConsumerSecret);
               AV15CallbackURL = AV12AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Callbackurl;
               AssignAttri(sPrefix, false, "AV15CallbackURL", AV15CallbackURL);
               AV5AdditionalScope = AV12AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Additionalscope;
               AssignAttri(sPrefix, false, "AV5AdditionalScope", AV5AdditionalScope);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "ExternalWebService") == 0 )
            {
               cmbavFunctionid.Enabled = 1;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV13AuthenticationTypeWebService.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV13AuthenticationTypeWebService.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV28FunctionId = AV13AuthenticationTypeWebService.gxTpr_Functionid;
               AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
               AV33IsEnable = AV13AuthenticationTypeWebService.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV13AuthenticationTypeWebService.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV13AuthenticationTypeWebService.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV13AuthenticationTypeWebService.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
               AV32Impersonate = AV13AuthenticationTypeWebService.gxTpr_Impersonate;
               AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
               AV47WSVersion = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Version;
               AssignAttri(sPrefix, false, "AV47WSVersion", AV47WSVersion);
               AV41WSPrivateEncryptKey = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Privateencryptkey;
               AssignAttri(sPrefix, false, "AV41WSPrivateEncryptKey", AV41WSPrivateEncryptKey);
               AV43WSServerName = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV43WSServerName", AV43WSServerName);
               AV44WSServerPort = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Port;
               AssignAttri(sPrefix, false, "AV44WSServerPort", StringUtil.LTrimStr( (decimal)(AV44WSServerPort), 5, 0));
               AV42WSServerBaseURL = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Baseurl;
               AssignAttri(sPrefix, false, "AV42WSServerBaseURL", AV42WSServerBaseURL);
               AV45WSServerSecureProtocol = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Secureprotocol;
               AssignAttri(sPrefix, false, "AV45WSServerSecureProtocol", StringUtil.Str( (decimal)(AV45WSServerSecureProtocol), 1, 0));
               AV46WSTimeout = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Timeout;
               AssignAttri(sPrefix, false, "AV46WSTimeout", StringUtil.LTrimStr( (decimal)(AV46WSTimeout), 5, 0));
               AV40WSPackage = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Package;
               AssignAttri(sPrefix, false, "AV40WSPackage", AV40WSPackage);
               AV39WSName = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV39WSName", AV39WSName);
               AV38WSExtension = AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Extension;
               AssignAttri(sPrefix, false, "AV38WSExtension", AV38WSExtension);
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Custom") == 0 )
            {
               cmbavFunctionid.Enabled = 1;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV6AuthenticationTypeCustom.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV34Name = AV6AuthenticationTypeCustom.gxTpr_Name;
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV28FunctionId = AV6AuthenticationTypeCustom.gxTpr_Functionid;
               AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
               AV33IsEnable = AV6AuthenticationTypeCustom.gxTpr_Isenable;
               AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
               AV25Dsc = AV6AuthenticationTypeCustom.gxTpr_Description;
               AssignAttri(sPrefix, false, "AV25Dsc", AV25Dsc);
               AV36SmallImageName = AV6AuthenticationTypeCustom.gxTpr_Smallimagename;
               AssignAttri(sPrefix, false, "AV36SmallImageName", AV36SmallImageName);
               AV14BigImageName = AV6AuthenticationTypeCustom.gxTpr_Bigimagename;
               AssignAttri(sPrefix, false, "AV14BigImageName", AV14BigImageName);
               AV32Impersonate = AV6AuthenticationTypeCustom.gxTpr_Impersonate;
               AssignAttri(sPrefix, false, "AV32Impersonate", AV32Impersonate);
               AV24CusVersion = AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Version;
               AssignAttri(sPrefix, false, "AV24CusVersion", AV24CusVersion);
               AV23CusPrivateEncryptKey = AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Privateencryptkey;
               AssignAttri(sPrefix, false, "AV23CusPrivateEncryptKey", AV23CusPrivateEncryptKey);
               AV21CusFileName = AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Filename;
               AssignAttri(sPrefix, false, "AV21CusFileName", AV21CusFileName);
               AV22CusPackage = AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Package;
               AssignAttri(sPrefix, false, "AV22CusPackage", AV22CusPackage);
               AV20CusClassName = AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Classname;
               AssignAttri(sPrefix, false, "AV20CusClassName", AV20CusClassName);
            }
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtnconfirm_Visible = 0;
            AssignProp(sPrefix, false, bttBtnconfirm_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtnconfirm_Visible), 5, 0), true);
            cmbavFunctionid.Enabled = 1;
            AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtngenkey_Visible = 0;
            AssignProp(sPrefix, false, bttBtngenkey_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtngenkey_Visible), 5, 0), true);
            bttBtngenkeycustom_Visible = 0;
            AssignProp(sPrefix, false, bttBtngenkeycustom_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtngenkeycustom_Visible), 5, 0), true);
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
            cmbavWsversion.Enabled = 0;
            AssignProp(sPrefix, false, cmbavWsversion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavWsversion.Enabled), 5, 0), true);
            edtavWsprivateencryptkey_Enabled = 0;
            AssignProp(sPrefix, false, edtavWsprivateencryptkey_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWsprivateencryptkey_Enabled), 5, 0), true);
            edtavWsservername_Enabled = 0;
            AssignProp(sPrefix, false, edtavWsservername_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWsservername_Enabled), 5, 0), true);
            edtavWsserverport_Enabled = 0;
            AssignProp(sPrefix, false, edtavWsserverport_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWsserverport_Enabled), 5, 0), true);
            edtavWsserverbaseurl_Enabled = 0;
            AssignProp(sPrefix, false, edtavWsserverbaseurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWsserverbaseurl_Enabled), 5, 0), true);
            cmbavWsserversecureprotocol.Enabled = 0;
            AssignProp(sPrefix, false, cmbavWsserversecureprotocol_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavWsserversecureprotocol.Enabled), 5, 0), true);
            edtavWstimeout_Enabled = 0;
            AssignProp(sPrefix, false, edtavWstimeout_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWstimeout_Enabled), 5, 0), true);
            edtavWspackage_Enabled = 0;
            AssignProp(sPrefix, false, edtavWspackage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWspackage_Enabled), 5, 0), true);
            edtavWsname_Enabled = 0;
            AssignProp(sPrefix, false, edtavWsname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWsname_Enabled), 5, 0), true);
            edtavWsextension_Enabled = 0;
            AssignProp(sPrefix, false, edtavWsextension_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWsextension_Enabled), 5, 0), true);
            edtavClientid_Enabled = 0;
            AssignProp(sPrefix, false, edtavClientid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientid_Enabled), 5, 0), true);
            edtavClientsecret_Enabled = 0;
            AssignProp(sPrefix, false, edtavClientsecret_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientsecret_Enabled), 5, 0), true);
            edtavVersionpath_Enabled = 0;
            AssignProp(sPrefix, false, edtavVersionpath_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavVersionpath_Enabled), 5, 0), true);
            edtavSiteurl_Enabled = 0;
            AssignProp(sPrefix, false, edtavSiteurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavSiteurl_Enabled), 5, 0), true);
            edtavConsumerkey_Enabled = 0;
            AssignProp(sPrefix, false, edtavConsumerkey_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavConsumerkey_Enabled), 5, 0), true);
            edtavConsumersecret_Enabled = 0;
            AssignProp(sPrefix, false, edtavConsumersecret_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavConsumersecret_Enabled), 5, 0), true);
            edtavCallbackurl_Enabled = 0;
            AssignProp(sPrefix, false, edtavCallbackurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCallbackurl_Enabled), 5, 0), true);
            cmbavCusversion.Enabled = 0;
            AssignProp(sPrefix, false, cmbavCusversion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavCusversion.Enabled), 5, 0), true);
            edtavCusprivateencryptkey_Enabled = 0;
            AssignProp(sPrefix, false, edtavCusprivateencryptkey_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCusprivateencryptkey_Enabled), 5, 0), true);
            edtavCusfilename_Enabled = 0;
            AssignProp(sPrefix, false, edtavCusfilename_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCusfilename_Enabled), 5, 0), true);
            edtavCuspackage_Enabled = 0;
            AssignProp(sPrefix, false, edtavCuspackage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCuspackage_Enabled), 5, 0), true);
            edtavCusclassname_Enabled = 0;
            AssignProp(sPrefix, false, edtavCusclassname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCusclassname_Enabled), 5, 0), true);
            chkavAdduseradditionaldatascope.Enabled = 0;
            AssignProp(sPrefix, false, chkavAdduseradditionaldatascope_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavAdduseradditionaldatascope.Enabled), 5, 0), true);
            chkavAddinitialpropertiesscope.Enabled = 0;
            AssignProp(sPrefix, false, chkavAddinitialpropertiesscope_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavAddinitialpropertiesscope.Enabled), 5, 0), true);
            edtavAdditionalscope_Enabled = 0;
            AssignProp(sPrefix, false, edtavAdditionalscope_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavAdditionalscope_Enabled), 5, 0), true);
            edtavGamrauthenticationtypename_Enabled = 0;
            AssignProp(sPrefix, false, edtavGamrauthenticationtypename_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGamrauthenticationtypename_Enabled), 5, 0), true);
            edtavGamrserverurl_Enabled = 0;
            AssignProp(sPrefix, false, edtavGamrserverurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGamrserverurl_Enabled), 5, 0), true);
            edtavGamrprivateencryptkey_Enabled = 0;
            AssignProp(sPrefix, false, edtavGamrprivateencryptkey_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGamrprivateencryptkey_Enabled), 5, 0), true);
            edtavGamrrepositoryguid_Enabled = 0;
            AssignProp(sPrefix, false, edtavGamrrepositoryguid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGamrrepositoryguid_Enabled), 5, 0), true);
            bttBtnconfirm_Caption = "Delete";
            AssignProp(sPrefix, false, bttBtnconfirm_Internalname, "Caption", bttBtnconfirm_Caption, true);
         }
         /* Execute user subroutine: 'REFRESHAUTHENTICATIONTYPE' */
         S112 ();
         if (returnInSub) return;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E121R2 ();
         if (returnInSub) return;
      }

      protected void E121R2( )
      {
         /* Enter Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            if ( StringUtil.StrCmp(AV37TypeId, "GAMLocal") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV10AuthenticationTypeLocal.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               AV10AuthenticationTypeLocal.gxTpr_Name = AV34Name;
               AV10AuthenticationTypeLocal.gxTpr_Functionid = AV28FunctionId;
               AV10AuthenticationTypeLocal.gxTpr_Isenable = AV33IsEnable;
               AV10AuthenticationTypeLocal.gxTpr_Description = AV25Dsc;
               AV10AuthenticationTypeLocal.gxTpr_Smallimagename = AV36SmallImageName;
               AV10AuthenticationTypeLocal.gxTpr_Bigimagename = AV14BigImageName;
               AV10AuthenticationTypeLocal.save();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "AppleID") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV48AuthenticationTypeApple.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               AV48AuthenticationTypeApple.gxTpr_Name = AV34Name;
               AV48AuthenticationTypeApple.gxTpr_Isenable = AV33IsEnable;
               AV48AuthenticationTypeApple.gxTpr_Description = AV25Dsc;
               AV48AuthenticationTypeApple.gxTpr_Smallimagename = AV36SmallImageName;
               AV48AuthenticationTypeApple.gxTpr_Bigimagename = AV14BigImageName;
               AV48AuthenticationTypeApple.gxTpr_Impersonate = AV32Impersonate;
               AV48AuthenticationTypeApple.gxTpr_Apple.gxTpr_Clientid = AV16ClientId;
               AV48AuthenticationTypeApple.gxTpr_Apple.gxTpr_Clientsecret = AV17ClientSecret;
               AV48AuthenticationTypeApple.gxTpr_Apple.gxTpr_Siteurl = AV35SiteURL;
               AV48AuthenticationTypeApple.gxTpr_Apple.gxTpr_Additionalscope = AV5AdditionalScope;
               AV48AuthenticationTypeApple.save();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Facebook") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV7AuthenticationTypeFacebook.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               AV7AuthenticationTypeFacebook.gxTpr_Name = AV34Name;
               AV7AuthenticationTypeFacebook.gxTpr_Isenable = AV33IsEnable;
               AV7AuthenticationTypeFacebook.gxTpr_Description = AV25Dsc;
               AV7AuthenticationTypeFacebook.gxTpr_Smallimagename = AV36SmallImageName;
               AV7AuthenticationTypeFacebook.gxTpr_Bigimagename = AV14BigImageName;
               AV7AuthenticationTypeFacebook.gxTpr_Impersonate = AV32Impersonate;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Clientid = AV16ClientId;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Clientsecret = AV17ClientSecret;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Versionpath = AV52VersionPath;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Siteurl = AV35SiteURL;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Additionalscope = AV5AdditionalScope;
               AV7AuthenticationTypeFacebook.save();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Google") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV9AuthenticationTypeGoogle.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               AV9AuthenticationTypeGoogle.gxTpr_Name = AV34Name;
               AV9AuthenticationTypeGoogle.gxTpr_Isenable = AV33IsEnable;
               AV9AuthenticationTypeGoogle.gxTpr_Description = AV25Dsc;
               AV9AuthenticationTypeGoogle.gxTpr_Smallimagename = AV36SmallImageName;
               AV9AuthenticationTypeGoogle.gxTpr_Bigimagename = AV14BigImageName;
               AV9AuthenticationTypeGoogle.gxTpr_Impersonate = AV32Impersonate;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Clientid = AV16ClientId;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Clientsecret = AV17ClientSecret;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Versionpath = AV52VersionPath;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Siteurl = AV35SiteURL;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Additionalscope = AV5AdditionalScope;
               AV9AuthenticationTypeGoogle.save();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemote") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV8AuthenticationTypeGAMRemote.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               AV8AuthenticationTypeGAMRemote.gxTpr_Name = AV34Name;
               AV8AuthenticationTypeGAMRemote.gxTpr_Functionid = AV28FunctionId;
               AV8AuthenticationTypeGAMRemote.gxTpr_Isenable = AV33IsEnable;
               AV8AuthenticationTypeGAMRemote.gxTpr_Description = AV25Dsc;
               AV8AuthenticationTypeGAMRemote.gxTpr_Smallimagename = AV36SmallImageName;
               AV8AuthenticationTypeGAMRemote.gxTpr_Bigimagename = AV14BigImageName;
               AV8AuthenticationTypeGAMRemote.gxTpr_Impersonate = AV32Impersonate;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Clientid = AV16ClientId;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Clientsecret = AV17ClientSecret;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Siteurl = AV35SiteURL;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Addsessioninitialpropertiesscope = AV50AddInitialPropertiesScope;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Adduseradditionaldatascope = AV54AddUserAdditionalDataScope;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Additionalscope = AV5AdditionalScope;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoteserverurl = AV31GAMRServerURL;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoteserverkey = AV29GAMRPrivateEncryptKey;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoterepositoryguid = AV30GAMRRepositoryGUID;
               AV8AuthenticationTypeGAMRemote.save();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemoteRest") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV51AuthenticationTypeGAMRemoteRest.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Name = AV34Name;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Functionid = AV28FunctionId;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Isenable = AV33IsEnable;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Description = AV25Dsc;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Smallimagename = AV36SmallImageName;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Bigimagename = AV14BigImageName;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Impersonate = AV32Impersonate;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Clientid = AV16ClientId;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Clientsecret = AV17ClientSecret;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Versionpath = AV52VersionPath;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Addsessioninitialpropertiesscope = AV50AddInitialPropertiesScope;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Adduseradditionaldatascope = AV54AddUserAdditionalDataScope;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Additionalscope = AV5AdditionalScope;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Remoteauthenticationtypename = AV53GAMRAuthenticationTypeName;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Remoteserverurl = AV31GAMRServerURL;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Remoteserverkey = AV29GAMRPrivateEncryptKey;
               AV51AuthenticationTypeGAMRemoteRest.gxTpr_Gamremoterest.gxTpr_Remoterepositoryguid = AV30GAMRRepositoryGUID;
               AV51AuthenticationTypeGAMRemoteRest.save();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Twitter") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV12AuthenticationTypeTwitter.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               AV12AuthenticationTypeTwitter.gxTpr_Name = AV34Name;
               AV12AuthenticationTypeTwitter.gxTpr_Isenable = AV33IsEnable;
               AV12AuthenticationTypeTwitter.gxTpr_Description = AV25Dsc;
               AV12AuthenticationTypeTwitter.gxTpr_Smallimagename = AV36SmallImageName;
               AV12AuthenticationTypeTwitter.gxTpr_Bigimagename = AV14BigImageName;
               AV12AuthenticationTypeTwitter.gxTpr_Impersonate = AV32Impersonate;
               AV12AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Consumerkey = AV18ConsumerKey;
               AV12AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Consumersecret = AV19ConsumerSecret;
               AV12AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Callbackurl = AV15CallbackURL;
               AV12AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Additionalscope = AV5AdditionalScope;
               AV12AuthenticationTypeTwitter.save();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "ExternalWebService") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV13AuthenticationTypeWebService.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               cmbavFunctionid.Enabled = 1;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV13AuthenticationTypeWebService.gxTpr_Name = AV34Name;
               AV13AuthenticationTypeWebService.gxTpr_Functionid = AV28FunctionId;
               AV13AuthenticationTypeWebService.gxTpr_Isenable = AV33IsEnable;
               AV13AuthenticationTypeWebService.gxTpr_Description = AV25Dsc;
               AV13AuthenticationTypeWebService.gxTpr_Smallimagename = AV36SmallImageName;
               AV13AuthenticationTypeWebService.gxTpr_Bigimagename = AV14BigImageName;
               AV13AuthenticationTypeWebService.gxTpr_Impersonate = AV32Impersonate;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Version = AV47WSVersion;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Privateencryptkey = AV41WSPrivateEncryptKey;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Timeout = AV46WSTimeout;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Package = AV40WSPackage;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Name = AV39WSName;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Extension = AV38WSExtension;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Name = AV43WSServerName;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Port = AV44WSServerPort;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Baseurl = AV42WSServerBaseURL;
               AV13AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Secureprotocol = AV45WSServerSecureProtocol;
               AV13AuthenticationTypeWebService.save();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Custom") == 0 )
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  AV6AuthenticationTypeCustom.load( AV34Name);
                  AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               }
               cmbavFunctionid.Enabled = 1;
               AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
               AV6AuthenticationTypeCustom.gxTpr_Name = AV34Name;
               AV6AuthenticationTypeCustom.gxTpr_Functionid = AV28FunctionId;
               AV6AuthenticationTypeCustom.gxTpr_Isenable = AV33IsEnable;
               AV6AuthenticationTypeCustom.gxTpr_Description = AV25Dsc;
               AV6AuthenticationTypeCustom.gxTpr_Smallimagename = AV36SmallImageName;
               AV6AuthenticationTypeCustom.gxTpr_Bigimagename = AV14BigImageName;
               AV6AuthenticationTypeCustom.gxTpr_Impersonate = AV32Impersonate;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Version = AV24CusVersion;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Privateencryptkey = AV23CusPrivateEncryptKey;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Filename = AV21CusFileName;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Package = AV22CusPackage;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Classname = AV20CusClassName;
               AV6AuthenticationTypeCustom.save();
            }
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            if ( StringUtil.StrCmp(AV37TypeId, "GAMLocal") == 0 )
            {
               AV10AuthenticationTypeLocal.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV10AuthenticationTypeLocal.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "AppleID") == 0 )
            {
               AV48AuthenticationTypeApple.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV48AuthenticationTypeApple.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Facebook") == 0 )
            {
               AV7AuthenticationTypeFacebook.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV7AuthenticationTypeFacebook.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Google") == 0 )
            {
               AV9AuthenticationTypeGoogle.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV9AuthenticationTypeGoogle.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemote") == 0 )
            {
               AV8AuthenticationTypeGAMRemote.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV8AuthenticationTypeGAMRemote.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemoteRest") == 0 )
            {
               AV51AuthenticationTypeGAMRemoteRest.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV51AuthenticationTypeGAMRemoteRest.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Oauth20") == 0 )
            {
               AV11AuthenticationTypeOauth20.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV11AuthenticationTypeOauth20.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Twitter") == 0 )
            {
               AV12AuthenticationTypeTwitter.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV12AuthenticationTypeTwitter.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "ExternalWebService") == 0 )
            {
               AV13AuthenticationTypeWebService.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV13AuthenticationTypeWebService.delete();
            }
            else if ( StringUtil.StrCmp(AV37TypeId, "Custom") == 0 )
            {
               AV6AuthenticationTypeCustom.load( AV34Name);
               AssignAttri(sPrefix, false, "AV34Name", AV34Name);
               AV6AuthenticationTypeCustom.delete();
            }
         }
         if ( StringUtil.StrCmp(AV37TypeId, "GAMLocal") == 0 )
         {
            if ( AV10AuthenticationTypeLocal.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "AppleID") == 0 )
         {
            if ( AV48AuthenticationTypeApple.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "Facebook") == 0 )
         {
            if ( AV7AuthenticationTypeFacebook.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "Google") == 0 )
         {
            if ( AV9AuthenticationTypeGoogle.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemote") == 0 )
         {
            if ( AV8AuthenticationTypeGAMRemote.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemoteRest") == 0 )
         {
            if ( AV51AuthenticationTypeGAMRemoteRest.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
               CallWebObject(formatLink("gamexamplewwauthtypes.aspx") );
               context.wjLocDisableFrm = 1;
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "Oauth20") == 0 )
         {
            if ( AV11AuthenticationTypeOauth20.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "Twitter") == 0 )
         {
            if ( AV12AuthenticationTypeTwitter.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "ExternalWebService") == 0 )
         {
            if ( AV13AuthenticationTypeWebService.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "Custom") == 0 )
         {
            if ( AV6AuthenticationTypeCustom.success() )
            {
               context.CommitDataStores("gamwcauthenticationtypeentrygeneral",pr_default);
            }
         }
         AV27Errors = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).getlasterrors();
         if ( AV27Errors.Count == 0 )
         {
            CallWebObject(formatLink("gamexamplewwauthtypes.aspx") );
            context.wjLocDisableFrm = 1;
         }
         else
         {
            AV59GXV1 = 1;
            while ( AV59GXV1 <= AV27Errors.Count )
            {
               AV26Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV27Errors.Item(AV59GXV1));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV26Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV26Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV59GXV1 = (int)(AV59GXV1+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV6AuthenticationTypeCustom", AV6AuthenticationTypeCustom);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV13AuthenticationTypeWebService", AV13AuthenticationTypeWebService);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12AuthenticationTypeTwitter", AV12AuthenticationTypeTwitter);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV51AuthenticationTypeGAMRemoteRest", AV51AuthenticationTypeGAMRemoteRest);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV8AuthenticationTypeGAMRemote", AV8AuthenticationTypeGAMRemote);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV9AuthenticationTypeGoogle", AV9AuthenticationTypeGoogle);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV7AuthenticationTypeFacebook", AV7AuthenticationTypeFacebook);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV48AuthenticationTypeApple", AV48AuthenticationTypeApple);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10AuthenticationTypeLocal", AV10AuthenticationTypeLocal);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11AuthenticationTypeOauth20", AV11AuthenticationTypeOauth20);
      }

      protected void E131R2( )
      {
         /* 'GenerateKey' Routine */
         AV41WSPrivateEncryptKey = Crypto.GetEncryptionKey( );
         AssignAttri(sPrefix, false, "AV41WSPrivateEncryptKey", AV41WSPrivateEncryptKey);
         /*  Sending Event outputs  */
      }

      protected void E141R2( )
      {
         /* 'GenerateKeyCustom' Routine */
         AV23CusPrivateEncryptKey = Crypto.GetEncryptionKey( );
         AssignAttri(sPrefix, false, "AV23CusPrivateEncryptKey", AV23CusPrivateEncryptKey);
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'REFRESHAUTHENTICATIONTYPE' Routine */
         edtavSiteurl_Visible = 1;
         AssignProp(sPrefix, false, edtavSiteurl_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavSiteurl_Visible), 5, 0), true);
         divTblimpersonate_Visible = 1;
         AssignProp(sPrefix, false, divTblimpersonate_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblimpersonate_Visible), 5, 0), true);
         divTblclientidsecret_Visible = 0;
         AssignProp(sPrefix, false, divTblclientidsecret_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblclientidsecret_Visible), 5, 0), true);
         divTblclientlocalserver_Visible = 0;
         AssignProp(sPrefix, false, divTblclientlocalserver_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblclientlocalserver_Visible), 5, 0), true);
         divTblscopes_Visible = 0;
         AssignProp(sPrefix, false, divTblscopes_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblscopes_Visible), 5, 0), true);
         divTblauthtypename_Visible = 0;
         AssignProp(sPrefix, false, divTblauthtypename_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblauthtypename_Visible), 5, 0), true);
         divTblcommonadditional_Visible = 0;
         AssignProp(sPrefix, false, divTblcommonadditional_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblcommonadditional_Visible), 5, 0), true);
         divTblserverhost_Visible = 0;
         AssignProp(sPrefix, false, divTblserverhost_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblserverhost_Visible), 5, 0), true);
         divTbltwitter_Visible = 0;
         AssignProp(sPrefix, false, divTbltwitter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTbltwitter_Visible), 5, 0), true);
         divTblwebservice_Visible = 0;
         AssignProp(sPrefix, false, divTblwebservice_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblwebservice_Visible), 5, 0), true);
         divTblexternal_Visible = 0;
         AssignProp(sPrefix, false, divTblexternal_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblexternal_Visible), 5, 0), true);
         if ( ( StringUtil.StrCmp(AV37TypeId, "AppleID") == 0 ) || ( StringUtil.StrCmp(AV37TypeId, "Facebook") == 0 ) || ( StringUtil.StrCmp(AV37TypeId, "Google") == 0 ) || ( StringUtil.StrCmp(AV37TypeId, "Twitter") == 0 ) )
         {
            AV28FunctionId = "OnlyAuthentication";
            AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
            cmbavFunctionid.Enabled = 0;
            AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
         }
         else
         {
            cmbavFunctionid.Enabled = 1;
            AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
         }
         if ( StringUtil.StrCmp(AV37TypeId, "GAMLocal") == 0 )
         {
            divTblimpersonate_Visible = 0;
            AssignProp(sPrefix, false, divTblimpersonate_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblimpersonate_Visible), 5, 0), true);
         }
         else if ( ( StringUtil.StrCmp(AV37TypeId, "AppleID") == 0 ) || ( StringUtil.StrCmp(AV37TypeId, "Facebook") == 0 ) || ( StringUtil.StrCmp(AV37TypeId, "Google") == 0 ) || ( StringUtil.StrCmp(AV37TypeId, "GAMRemote") == 0 ) )
         {
            divTblclientidsecret_Visible = 1;
            AssignProp(sPrefix, false, divTblclientidsecret_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblclientidsecret_Visible), 5, 0), true);
            divTblclientlocalserver_Visible = 1;
            AssignProp(sPrefix, false, divTblclientlocalserver_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblclientlocalserver_Visible), 5, 0), true);
            divTblcommonadditional_Visible = 1;
            AssignProp(sPrefix, false, divTblcommonadditional_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblcommonadditional_Visible), 5, 0), true);
            if ( StringUtil.StrCmp(AV37TypeId, "GAMRemote") == 0 )
            {
               edtavVersionpath_Visible = 0;
               AssignProp(sPrefix, false, edtavVersionpath_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavVersionpath_Visible), 5, 0), true);
               divTblscopes_Visible = 1;
               AssignProp(sPrefix, false, divTblscopes_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblscopes_Visible), 5, 0), true);
               divTblserverhost_Visible = 1;
               AssignProp(sPrefix, false, divTblserverhost_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblserverhost_Visible), 5, 0), true);
            }
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "GAMRemoteRest") == 0 )
         {
            divTblclientidsecret_Visible = 1;
            AssignProp(sPrefix, false, divTblclientidsecret_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblclientidsecret_Visible), 5, 0), true);
            divTblscopes_Visible = 1;
            AssignProp(sPrefix, false, divTblscopes_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblscopes_Visible), 5, 0), true);
            divTblcommonadditional_Visible = 1;
            AssignProp(sPrefix, false, divTblcommonadditional_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblcommonadditional_Visible), 5, 0), true);
            divTblauthtypename_Visible = 1;
            AssignProp(sPrefix, false, divTblauthtypename_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblauthtypename_Visible), 5, 0), true);
            divTblserverhost_Visible = 1;
            AssignProp(sPrefix, false, divTblserverhost_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblserverhost_Visible), 5, 0), true);
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "Twitter") == 0 )
         {
            AV28FunctionId = "OnlyAuthentication";
            AssignAttri(sPrefix, false, "AV28FunctionId", AV28FunctionId);
            cmbavFunctionid.Enabled = 0;
            AssignProp(sPrefix, false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavFunctionid.Enabled), 5, 0), true);
            divTbltwitter_Visible = 1;
            AssignProp(sPrefix, false, divTbltwitter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTbltwitter_Visible), 5, 0), true);
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "ExternalWebService") == 0 )
         {
            divTblwebservice_Visible = 1;
            AssignProp(sPrefix, false, divTblwebservice_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblwebservice_Visible), 5, 0), true);
         }
         else if ( StringUtil.StrCmp(AV37TypeId, "Custom") == 0 )
         {
            divTblexternal_Visible = 1;
            AssignProp(sPrefix, false, divTblexternal_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblexternal_Visible), 5, 0), true);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E151R2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         Gx_mode = (String)getParm(obj,0);
         AssignAttri(sPrefix, false, "Gx_mode", Gx_mode);
         AV34Name = (String)getParm(obj,1);
         AssignAttri(sPrefix, false, "AV34Name", AV34Name);
         AV37TypeId = (String)getParm(obj,2);
         AssignAttri(sPrefix, false, "AV37TypeId", AV37TypeId);
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
         PA1R2( ) ;
         WS1R2( ) ;
         WE1R2( ) ;
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
         sCtrlAV34Name = (String)((String)getParm(obj,1));
         sCtrlAV37TypeId = (String)((String)getParm(obj,2));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA1R2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "gamwcauthenticationtypeentrygeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA1R2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            Gx_mode = (String)getParm(obj,2);
            AssignAttri(sPrefix, false, "Gx_mode", Gx_mode);
            AV34Name = (String)getParm(obj,3);
            AssignAttri(sPrefix, false, "AV34Name", AV34Name);
            AV37TypeId = (String)getParm(obj,4);
            AssignAttri(sPrefix, false, "AV37TypeId", AV37TypeId);
         }
         wcpOGx_mode = cgiGet( sPrefix+"wcpOGx_mode");
         wcpOAV34Name = cgiGet( sPrefix+"wcpOAV34Name");
         wcpOAV37TypeId = cgiGet( sPrefix+"wcpOAV37TypeId");
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(Gx_mode, wcpOGx_mode) != 0 ) || ( StringUtil.StrCmp(AV34Name, wcpOAV34Name) != 0 ) || ( StringUtil.StrCmp(AV37TypeId, wcpOAV37TypeId) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOGx_mode = Gx_mode;
         wcpOAV34Name = AV34Name;
         wcpOAV37TypeId = AV37TypeId;
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
         sCtrlAV34Name = cgiGet( sPrefix+"AV34Name_CTRL");
         if ( StringUtil.Len( sCtrlAV34Name) > 0 )
         {
            AV34Name = cgiGet( sCtrlAV34Name);
            AssignAttri(sPrefix, false, "AV34Name", AV34Name);
         }
         else
         {
            AV34Name = cgiGet( sPrefix+"AV34Name_PARM");
         }
         sCtrlAV37TypeId = cgiGet( sPrefix+"AV37TypeId_CTRL");
         if ( StringUtil.Len( sCtrlAV37TypeId) > 0 )
         {
            AV37TypeId = cgiGet( sCtrlAV37TypeId);
            AssignAttri(sPrefix, false, "AV37TypeId", AV37TypeId);
         }
         else
         {
            AV37TypeId = cgiGet( sPrefix+"AV37TypeId_PARM");
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
         PA1R2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS1R2( ) ;
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
         WS1R2( ) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"AV34Name_PARM", StringUtil.RTrim( AV34Name));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV34Name)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV34Name_CTRL", StringUtil.RTrim( sCtrlAV34Name));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV37TypeId_PARM", StringUtil.RTrim( AV37TypeId));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV37TypeId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV37TypeId_CTRL", StringUtil.RTrim( sCtrlAV37TypeId));
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
         WE1R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20204151163485", true, true);
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
         context.AddJavascriptSource("gamwcauthenticationtypeentrygeneral.js", "?20204151163493", false, true);
         /* End function include_jscripts */
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
         AV33IsEnable = StringUtil.StrToBool( StringUtil.BoolToStr( AV33IsEnable));
         AssignAttri(sPrefix, false, "AV33IsEnable", AV33IsEnable);
         chkavAdduseradditionaldatascope.Name = "vADDUSERADDITIONALDATASCOPE";
         chkavAdduseradditionaldatascope.WebTags = "";
         chkavAdduseradditionaldatascope.Caption = "";
         AssignProp(sPrefix, false, chkavAdduseradditionaldatascope_Internalname, "TitleCaption", chkavAdduseradditionaldatascope.Caption, true);
         chkavAdduseradditionaldatascope.CheckedValue = "false";
         AV54AddUserAdditionalDataScope = StringUtil.StrToBool( StringUtil.BoolToStr( AV54AddUserAdditionalDataScope));
         AssignAttri(sPrefix, false, "AV54AddUserAdditionalDataScope", AV54AddUserAdditionalDataScope);
         chkavAddinitialpropertiesscope.Name = "vADDINITIALPROPERTIESSCOPE";
         chkavAddinitialpropertiesscope.WebTags = "";
         chkavAddinitialpropertiesscope.Caption = "";
         AssignProp(sPrefix, false, chkavAddinitialpropertiesscope_Internalname, "TitleCaption", chkavAddinitialpropertiesscope.Caption, true);
         chkavAddinitialpropertiesscope.CheckedValue = "false";
         AV50AddInitialPropertiesScope = StringUtil.StrToBool( StringUtil.BoolToStr( AV50AddInitialPropertiesScope));
         AssignAttri(sPrefix, false, "AV50AddInitialPropertiesScope", AV50AddInitialPropertiesScope);
         cmbavWsversion.Name = "vWSVERSION";
         cmbavWsversion.WebTags = "";
         cmbavWsversion.addItem("GAM10", "Version 1.0", 0);
         cmbavWsversion.addItem("GAM20", "Version 2.0", 0);
         if ( cmbavWsversion.ItemCount > 0 )
         {
         }
         cmbavWsserversecureprotocol.Name = "vWSSERVERSECUREPROTOCOL";
         cmbavWsserversecureprotocol.WebTags = "";
         cmbavWsserversecureprotocol.addItem("0", "No", 0);
         cmbavWsserversecureprotocol.addItem("1", "Yes", 0);
         if ( cmbavWsserversecureprotocol.ItemCount > 0 )
         {
         }
         cmbavCusversion.Name = "vCUSVERSION";
         cmbavCusversion.WebTags = "";
         cmbavCusversion.addItem("GAM10", "Version 1.0", 0);
         cmbavCusversion.addItem("GAM20", "Version 2.0", 0);
         if ( cmbavCusversion.ItemCount > 0 )
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
         divTbldata_Internalname = sPrefix+"TBLDATA";
         edtavImpersonate_Internalname = sPrefix+"vIMPERSONATE";
         divTblimpersonate_Internalname = sPrefix+"TBLIMPERSONATE";
         edtavClientid_Internalname = sPrefix+"vCLIENTID";
         edtavClientsecret_Internalname = sPrefix+"vCLIENTSECRET";
         edtavVersionpath_Internalname = sPrefix+"vVERSIONPATH";
         divTblclientidsecret_Internalname = sPrefix+"TBLCLIENTIDSECRET";
         edtavSiteurl_Internalname = sPrefix+"vSITEURL";
         divTblclientlocalserver_Internalname = sPrefix+"TBLCLIENTLOCALSERVER";
         edtavConsumerkey_Internalname = sPrefix+"vCONSUMERKEY";
         edtavConsumersecret_Internalname = sPrefix+"vCONSUMERSECRET";
         edtavCallbackurl_Internalname = sPrefix+"vCALLBACKURL";
         divTbltwitter_Internalname = sPrefix+"TBLTWITTER";
         chkavAdduseradditionaldatascope_Internalname = sPrefix+"vADDUSERADDITIONALDATASCOPE";
         chkavAddinitialpropertiesscope_Internalname = sPrefix+"vADDINITIALPROPERTIESSCOPE";
         divTblscopes_Internalname = sPrefix+"TBLSCOPES";
         edtavAdditionalscope_Internalname = sPrefix+"vADDITIONALSCOPE";
         divTblcommonadditional_Internalname = sPrefix+"TBLCOMMONADDITIONAL";
         edtavGamrauthenticationtypename_Internalname = sPrefix+"vGAMRAUTHENTICATIONTYPENAME";
         divTblauthtypename_Internalname = sPrefix+"TBLAUTHTYPENAME";
         edtavGamrserverurl_Internalname = sPrefix+"vGAMRSERVERURL";
         edtavGamrprivateencryptkey_Internalname = sPrefix+"vGAMRPRIVATEENCRYPTKEY";
         edtavGamrrepositoryguid_Internalname = sPrefix+"vGAMRREPOSITORYGUID";
         divFormcell_Internalname = sPrefix+"FORMCELL";
         divTblserverhost_Internalname = sPrefix+"TBLSERVERHOST";
         cmbavWsversion_Internalname = sPrefix+"vWSVERSION";
         edtavWsprivateencryptkey_Internalname = sPrefix+"vWSPRIVATEENCRYPTKEY";
         bttBtngenkey_Internalname = sPrefix+"BTNGENKEY";
         edtavWsservername_Internalname = sPrefix+"vWSSERVERNAME";
         edtavWsserverport_Internalname = sPrefix+"vWSSERVERPORT";
         edtavWsserverbaseurl_Internalname = sPrefix+"vWSSERVERBASEURL";
         cmbavWsserversecureprotocol_Internalname = sPrefix+"vWSSERVERSECUREPROTOCOL";
         edtavWstimeout_Internalname = sPrefix+"vWSTIMEOUT";
         edtavWspackage_Internalname = sPrefix+"vWSPACKAGE";
         edtavWsname_Internalname = sPrefix+"vWSNAME";
         edtavWsextension_Internalname = sPrefix+"vWSEXTENSION";
         divTblwebservice_Internalname = sPrefix+"TBLWEBSERVICE";
         cmbavCusversion_Internalname = sPrefix+"vCUSVERSION";
         edtavCusprivateencryptkey_Internalname = sPrefix+"vCUSPRIVATEENCRYPTKEY";
         bttBtngenkeycustom_Internalname = sPrefix+"BTNGENKEYCUSTOM";
         edtavCusfilename_Internalname = sPrefix+"vCUSFILENAME";
         edtavCuspackage_Internalname = sPrefix+"vCUSPACKAGE";
         edtavCusclassname_Internalname = sPrefix+"vCUSCLASSNAME";
         divTblexternal_Internalname = sPrefix+"TBLEXTERNAL";
         divTable2_Internalname = sPrefix+"TABLE2";
         bttBtncancel_Internalname = sPrefix+"BTNCANCEL";
         bttBtnconfirm_Internalname = sPrefix+"BTNCONFIRM";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
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
         chkavAddinitialpropertiesscope.Caption = "Add gam_session_initial_prop scope?";
         chkavAdduseradditionaldatascope.Caption = "Add gam_user_additional_data scope?";
         chkavIsenable.Caption = "Enabled?";
         bttBtnconfirm_Caption = "Confirm";
         bttBtnconfirm_Visible = 1;
         edtavCusclassname_Jsonclick = "";
         edtavCusclassname_Enabled = 1;
         edtavCuspackage_Jsonclick = "";
         edtavCuspackage_Enabled = 1;
         edtavCusfilename_Jsonclick = "";
         edtavCusfilename_Enabled = 1;
         bttBtngenkeycustom_Visible = 1;
         edtavCusprivateencryptkey_Jsonclick = "";
         edtavCusprivateencryptkey_Enabled = 1;
         cmbavCusversion_Jsonclick = "";
         cmbavCusversion.Enabled = 1;
         divTblexternal_Visible = 1;
         edtavWsextension_Jsonclick = "";
         edtavWsextension_Enabled = 1;
         edtavWsname_Jsonclick = "";
         edtavWsname_Enabled = 1;
         edtavWspackage_Jsonclick = "";
         edtavWspackage_Enabled = 1;
         edtavWstimeout_Jsonclick = "";
         edtavWstimeout_Enabled = 1;
         cmbavWsserversecureprotocol_Jsonclick = "";
         cmbavWsserversecureprotocol.Enabled = 1;
         edtavWsserverbaseurl_Jsonclick = "";
         edtavWsserverbaseurl_Enabled = 1;
         edtavWsserverport_Jsonclick = "";
         edtavWsserverport_Enabled = 1;
         edtavWsservername_Jsonclick = "";
         edtavWsservername_Enabled = 1;
         bttBtngenkey_Visible = 1;
         edtavWsprivateencryptkey_Jsonclick = "";
         edtavWsprivateencryptkey_Enabled = 1;
         cmbavWsversion_Jsonclick = "";
         cmbavWsversion.Enabled = 1;
         divTblwebservice_Visible = 1;
         edtavGamrrepositoryguid_Jsonclick = "";
         edtavGamrrepositoryguid_Enabled = 1;
         edtavGamrprivateencryptkey_Jsonclick = "";
         edtavGamrprivateencryptkey_Enabled = 1;
         edtavGamrserverurl_Jsonclick = "";
         edtavGamrserverurl_Enabled = 1;
         divTblserverhost_Visible = 1;
         edtavGamrauthenticationtypename_Jsonclick = "";
         edtavGamrauthenticationtypename_Enabled = 1;
         divTblauthtypename_Visible = 1;
         edtavAdditionalscope_Jsonclick = "";
         edtavAdditionalscope_Enabled = 1;
         divTblcommonadditional_Visible = 1;
         chkavAddinitialpropertiesscope.Enabled = 1;
         chkavAdduseradditionaldatascope.Enabled = 1;
         divTblscopes_Visible = 1;
         edtavCallbackurl_Jsonclick = "";
         edtavCallbackurl_Enabled = 1;
         edtavConsumersecret_Jsonclick = "";
         edtavConsumersecret_Enabled = 1;
         edtavConsumerkey_Jsonclick = "";
         edtavConsumerkey_Enabled = 1;
         divTbltwitter_Visible = 1;
         edtavSiteurl_Jsonclick = "";
         edtavSiteurl_Enabled = 1;
         edtavSiteurl_Visible = 1;
         divTblclientlocalserver_Visible = 1;
         edtavVersionpath_Jsonclick = "";
         edtavVersionpath_Enabled = 1;
         edtavVersionpath_Visible = 1;
         edtavClientsecret_Jsonclick = "";
         edtavClientsecret_Enabled = 1;
         edtavClientid_Jsonclick = "";
         edtavClientid_Enabled = 1;
         divTblclientidsecret_Visible = 1;
         edtavImpersonate_Jsonclick = "";
         edtavImpersonate_Enabled = 1;
         divTblimpersonate_Visible = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]}");
         setEventMetadata("ENTER","{handler:'E121R2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'AV35SiteURL',fld:'vSITEURL',pic:''},{av:'AV30GAMRRepositoryGUID',fld:'vGAMRREPOSITORYGUID',pic:''},{av:'AV29GAMRPrivateEncryptKey',fld:'vGAMRPRIVATEENCRYPTKEY',pic:''},{av:'AV31GAMRServerURL',fld:'vGAMRSERVERURL',pic:''},{av:'AV53GAMRAuthenticationTypeName',fld:'vGAMRAUTHENTICATIONTYPENAME',pic:''},{av:'AV52VersionPath',fld:'vVERSIONPATH',pic:''},{av:'AV17ClientSecret',fld:'vCLIENTSECRET',pic:''},{av:'AV16ClientId',fld:'vCLIENTID',pic:''},{av:'AV5AdditionalScope',fld:'vADDITIONALSCOPE',pic:''},{av:'AV15CallbackURL',fld:'vCALLBACKURL',pic:''},{av:'AV19ConsumerSecret',fld:'vCONSUMERSECRET',pic:''},{av:'AV18ConsumerKey',fld:'vCONSUMERKEY',pic:''},{av:'cmbavWsserversecureprotocol'},{av:'AV45WSServerSecureProtocol',fld:'vWSSERVERSECUREPROTOCOL',pic:'9'},{av:'AV42WSServerBaseURL',fld:'vWSSERVERBASEURL',pic:''},{av:'AV44WSServerPort',fld:'vWSSERVERPORT',pic:'ZZZZ9'},{av:'AV43WSServerName',fld:'vWSSERVERNAME',pic:''},{av:'AV38WSExtension',fld:'vWSEXTENSION',pic:''},{av:'AV39WSName',fld:'vWSNAME',pic:''},{av:'AV40WSPackage',fld:'vWSPACKAGE',pic:''},{av:'AV46WSTimeout',fld:'vWSTIMEOUT',pic:'ZZZZ9'},{av:'AV41WSPrivateEncryptKey',fld:'vWSPRIVATEENCRYPTKEY',pic:''},{av:'cmbavWsversion'},{av:'AV47WSVersion',fld:'vWSVERSION',pic:''},{av:'AV20CusClassName',fld:'vCUSCLASSNAME',pic:''},{av:'AV22CusPackage',fld:'vCUSPACKAGE',pic:''},{av:'AV21CusFileName',fld:'vCUSFILENAME',pic:''},{av:'AV23CusPrivateEncryptKey',fld:'vCUSPRIVATEENCRYPTKEY',pic:''},{av:'cmbavCusversion'},{av:'AV24CusVersion',fld:'vCUSVERSION',pic:''},{av:'AV32Impersonate',fld:'vIMPERSONATE',pic:''},{av:'AV14BigImageName',fld:'vBIGIMAGENAME',pic:''},{av:'AV36SmallImageName',fld:'vSMALLIMAGENAME',pic:''},{av:'AV25Dsc',fld:'vDSC',pic:''},{av:'cmbavFunctionid'},{av:'AV28FunctionId',fld:'vFUNCTIONID',pic:''},{av:'AV34Name',fld:'vNAME',pic:''},{av:'AV37TypeId',fld:'vTYPEID',pic:''},{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'cmbavFunctionid'},{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]}");
         setEventMetadata("'GENERATEKEY'","{handler:'E131R2',iparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]");
         setEventMetadata("'GENERATEKEY'",",oparms:[{av:'AV41WSPrivateEncryptKey',fld:'vWSPRIVATEENCRYPTKEY',pic:''},{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]}");
         setEventMetadata("'GENERATEKEYCUSTOM'","{handler:'E141R2',iparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]");
         setEventMetadata("'GENERATEKEYCUSTOM'",",oparms:[{av:'AV23CusPrivateEncryptKey',fld:'vCUSPRIVATEENCRYPTKEY',pic:''},{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]}");
         setEventMetadata("VALIDV_FUNCTIONID","{handler:'Validv_Functionid',iparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]");
         setEventMetadata("VALIDV_FUNCTIONID",",oparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]}");
         setEventMetadata("VALIDV_WSVERSION","{handler:'Validv_Wsversion',iparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]");
         setEventMetadata("VALIDV_WSVERSION",",oparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]}");
         setEventMetadata("VALIDV_CUSVERSION","{handler:'Validv_Cusversion',iparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]");
         setEventMetadata("VALIDV_CUSVERSION",",oparms:[{av:'AV33IsEnable',fld:'vISENABLE',pic:''},{av:'AV54AddUserAdditionalDataScope',fld:'vADDUSERADDITIONALDATASCOPE',pic:''},{av:'AV50AddInitialPropertiesScope',fld:'vADDINITIALPROPERTIESSCOPE',pic:''}]}");
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
         wcpOAV34Name = "";
         wcpOAV37TypeId = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         TempTags = "";
         AV28FunctionId = "";
         ClassString = "";
         StyleString = "";
         AV25Dsc = "";
         AV36SmallImageName = "";
         AV14BigImageName = "";
         AV32Impersonate = "";
         AV16ClientId = "";
         AV17ClientSecret = "";
         AV52VersionPath = "";
         AV35SiteURL = "";
         AV18ConsumerKey = "";
         AV19ConsumerSecret = "";
         AV15CallbackURL = "";
         AV5AdditionalScope = "";
         AV53GAMRAuthenticationTypeName = "";
         AV31GAMRServerURL = "";
         AV29GAMRPrivateEncryptKey = "";
         AV30GAMRRepositoryGUID = "";
         AV47WSVersion = "";
         AV41WSPrivateEncryptKey = "";
         bttBtngenkey_Jsonclick = "";
         AV43WSServerName = "";
         AV42WSServerBaseURL = "";
         AV45WSServerSecureProtocol = 0;
         AV40WSPackage = "";
         AV39WSName = "";
         AV38WSExtension = "";
         AV24CusVersion = "";
         AV23CusPrivateEncryptKey = "";
         bttBtngenkeycustom_Jsonclick = "";
         AV21CusFileName = "";
         AV22CusPackage = "";
         AV20CusClassName = "";
         bttBtncancel_Jsonclick = "";
         bttBtnconfirm_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV10AuthenticationTypeLocal = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeLocal(context);
         AV48AuthenticationTypeApple = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeApple(context);
         AV7AuthenticationTypeFacebook = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeFacebook(context);
         AV9AuthenticationTypeGoogle = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeGoogle(context);
         AV8AuthenticationTypeGAMRemote = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeGAMRemote(context);
         AV51AuthenticationTypeGAMRemoteRest = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeGAMRemoteRest(context);
         AV12AuthenticationTypeTwitter = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeTwitter(context);
         AV13AuthenticationTypeWebService = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeWebService(context);
         AV6AuthenticationTypeCustom = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeCustom(context);
         AV11AuthenticationTypeOauth20 = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeOauth20(context);
         AV27Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV26Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlGx_mode = "";
         sCtrlAV34Name = "";
         sCtrlAV37TypeId = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamwcauthenticationtypeentrygeneral__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamwcauthenticationtypeentrygeneral__default(),
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
      private short AV45WSServerSecureProtocol ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavSmallimagename_Enabled ;
      private int edtavBigimagename_Enabled ;
      private int divTblimpersonate_Visible ;
      private int edtavImpersonate_Enabled ;
      private int divTblclientidsecret_Visible ;
      private int edtavClientid_Enabled ;
      private int edtavClientsecret_Enabled ;
      private int edtavVersionpath_Visible ;
      private int edtavVersionpath_Enabled ;
      private int divTblclientlocalserver_Visible ;
      private int edtavSiteurl_Visible ;
      private int edtavSiteurl_Enabled ;
      private int divTbltwitter_Visible ;
      private int edtavConsumerkey_Enabled ;
      private int edtavConsumersecret_Enabled ;
      private int edtavCallbackurl_Enabled ;
      private int divTblscopes_Visible ;
      private int divTblcommonadditional_Visible ;
      private int edtavAdditionalscope_Enabled ;
      private int divTblauthtypename_Visible ;
      private int edtavGamrauthenticationtypename_Enabled ;
      private int divTblserverhost_Visible ;
      private int edtavGamrserverurl_Enabled ;
      private int edtavGamrprivateencryptkey_Enabled ;
      private int edtavGamrrepositoryguid_Enabled ;
      private int divTblwebservice_Visible ;
      private int edtavWsprivateencryptkey_Enabled ;
      private int bttBtngenkey_Visible ;
      private int edtavWsservername_Enabled ;
      private int AV44WSServerPort ;
      private int edtavWsserverport_Enabled ;
      private int edtavWsserverbaseurl_Enabled ;
      private int AV46WSTimeout ;
      private int edtavWstimeout_Enabled ;
      private int edtavWspackage_Enabled ;
      private int edtavWsname_Enabled ;
      private int edtavWsextension_Enabled ;
      private int divTblexternal_Visible ;
      private int edtavCusprivateencryptkey_Enabled ;
      private int bttBtngenkeycustom_Visible ;
      private int edtavCusfilename_Enabled ;
      private int edtavCuspackage_Enabled ;
      private int edtavCusclassname_Enabled ;
      private int bttBtnconfirm_Visible ;
      private int AV59GXV1 ;
      private int idxLst ;
      private String Gx_mode ;
      private String AV34Name ;
      private String AV37TypeId ;
      private String wcpOGx_mode ;
      private String wcpOAV34Name ;
      private String wcpOAV37TypeId ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String divTable2_Internalname ;
      private String divTbldata_Internalname ;
      private String edtavName_Internalname ;
      private String TempTags ;
      private String edtavName_Jsonclick ;
      private String cmbavFunctionid_Internalname ;
      private String AV28FunctionId ;
      private String cmbavFunctionid_Jsonclick ;
      private String chkavIsenable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDsc_Internalname ;
      private String AV25Dsc ;
      private String edtavDsc_Jsonclick ;
      private String edtavSmallimagename_Internalname ;
      private String AV36SmallImageName ;
      private String edtavSmallimagename_Jsonclick ;
      private String edtavBigimagename_Internalname ;
      private String AV14BigImageName ;
      private String edtavBigimagename_Jsonclick ;
      private String divTblimpersonate_Internalname ;
      private String edtavImpersonate_Internalname ;
      private String AV32Impersonate ;
      private String edtavImpersonate_Jsonclick ;
      private String divTblclientidsecret_Internalname ;
      private String edtavClientid_Internalname ;
      private String edtavClientid_Jsonclick ;
      private String edtavClientsecret_Internalname ;
      private String edtavClientsecret_Jsonclick ;
      private String edtavVersionpath_Internalname ;
      private String AV52VersionPath ;
      private String edtavVersionpath_Jsonclick ;
      private String divTblclientlocalserver_Internalname ;
      private String edtavSiteurl_Internalname ;
      private String edtavSiteurl_Jsonclick ;
      private String divTbltwitter_Internalname ;
      private String edtavConsumerkey_Internalname ;
      private String AV18ConsumerKey ;
      private String edtavConsumerkey_Jsonclick ;
      private String edtavConsumersecret_Internalname ;
      private String AV19ConsumerSecret ;
      private String edtavConsumersecret_Jsonclick ;
      private String edtavCallbackurl_Internalname ;
      private String edtavCallbackurl_Jsonclick ;
      private String divTblscopes_Internalname ;
      private String chkavAdduseradditionaldatascope_Internalname ;
      private String chkavAddinitialpropertiesscope_Internalname ;
      private String divTblcommonadditional_Internalname ;
      private String edtavAdditionalscope_Internalname ;
      private String edtavAdditionalscope_Jsonclick ;
      private String divTblauthtypename_Internalname ;
      private String edtavGamrauthenticationtypename_Internalname ;
      private String AV53GAMRAuthenticationTypeName ;
      private String edtavGamrauthenticationtypename_Jsonclick ;
      private String divTblserverhost_Internalname ;
      private String edtavGamrserverurl_Internalname ;
      private String edtavGamrserverurl_Jsonclick ;
      private String edtavGamrprivateencryptkey_Internalname ;
      private String AV29GAMRPrivateEncryptKey ;
      private String edtavGamrprivateencryptkey_Jsonclick ;
      private String divFormcell_Internalname ;
      private String edtavGamrrepositoryguid_Internalname ;
      private String AV30GAMRRepositoryGUID ;
      private String edtavGamrrepositoryguid_Jsonclick ;
      private String divTblwebservice_Internalname ;
      private String cmbavWsversion_Internalname ;
      private String AV47WSVersion ;
      private String cmbavWsversion_Jsonclick ;
      private String edtavWsprivateencryptkey_Internalname ;
      private String AV41WSPrivateEncryptKey ;
      private String edtavWsprivateencryptkey_Jsonclick ;
      private String bttBtngenkey_Internalname ;
      private String bttBtngenkey_Jsonclick ;
      private String edtavWsservername_Internalname ;
      private String AV43WSServerName ;
      private String edtavWsservername_Jsonclick ;
      private String edtavWsserverport_Internalname ;
      private String edtavWsserverport_Jsonclick ;
      private String edtavWsserverbaseurl_Internalname ;
      private String AV42WSServerBaseURL ;
      private String edtavWsserverbaseurl_Jsonclick ;
      private String cmbavWsserversecureprotocol_Internalname ;
      private String cmbavWsserversecureprotocol_Jsonclick ;
      private String edtavWstimeout_Internalname ;
      private String edtavWstimeout_Jsonclick ;
      private String edtavWspackage_Internalname ;
      private String AV40WSPackage ;
      private String edtavWspackage_Jsonclick ;
      private String edtavWsname_Internalname ;
      private String AV39WSName ;
      private String edtavWsname_Jsonclick ;
      private String edtavWsextension_Internalname ;
      private String AV38WSExtension ;
      private String edtavWsextension_Jsonclick ;
      private String divTblexternal_Internalname ;
      private String cmbavCusversion_Internalname ;
      private String AV24CusVersion ;
      private String cmbavCusversion_Jsonclick ;
      private String edtavCusprivateencryptkey_Internalname ;
      private String AV23CusPrivateEncryptKey ;
      private String edtavCusprivateencryptkey_Jsonclick ;
      private String bttBtngenkeycustom_Internalname ;
      private String bttBtngenkeycustom_Jsonclick ;
      private String edtavCusfilename_Internalname ;
      private String AV21CusFileName ;
      private String edtavCusfilename_Jsonclick ;
      private String edtavCuspackage_Internalname ;
      private String AV22CusPackage ;
      private String edtavCuspackage_Jsonclick ;
      private String edtavCusclassname_Internalname ;
      private String AV20CusClassName ;
      private String edtavCusclassname_Jsonclick ;
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
      private String sCtrlGx_mode ;
      private String sCtrlAV34Name ;
      private String sCtrlAV37TypeId ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool AV33IsEnable ;
      private bool AV54AddUserAdditionalDataScope ;
      private bool AV50AddInitialPropertiesScope ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String AV16ClientId ;
      private String AV17ClientSecret ;
      private String AV35SiteURL ;
      private String AV15CallbackURL ;
      private String AV5AdditionalScope ;
      private String AV31GAMRServerURL ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private String aP0_Gx_mode ;
      private String aP1_Name ;
      private String aP2_TypeId ;
      private GXCombobox cmbavFunctionid ;
      private GXCheckbox chkavIsenable ;
      private GXCheckbox chkavAdduseradditionaldatascope ;
      private GXCheckbox chkavAddinitialpropertiesscope ;
      private GXCombobox cmbavWsversion ;
      private GXCombobox cmbavWsserversecureprotocol ;
      private GXCombobox cmbavCusversion ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV27Errors ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeCustom AV6AuthenticationTypeCustom ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV26Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeFacebook AV7AuthenticationTypeFacebook ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeGAMRemote AV8AuthenticationTypeGAMRemote ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeGoogle AV9AuthenticationTypeGoogle ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeLocal AV10AuthenticationTypeLocal ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeOauth20 AV11AuthenticationTypeOauth20 ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeTwitter AV12AuthenticationTypeTwitter ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeWebService AV13AuthenticationTypeWebService ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeApple AV48AuthenticationTypeApple ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeGAMRemoteRest AV51AuthenticationTypeGAMRemoteRest ;
   }

   public class gamwcauthenticationtypeentrygeneral__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamwcauthenticationtypeentrygeneral__default : DataStoreHelperBase, IDataStoreHelper
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
