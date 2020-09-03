/*
               File: GAMHeader
        Description: GAMHeader
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:2:20.50
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
   public class gamheader : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public gamheader( )
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

      public gamheader( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_AactualPage )
      {
         this.AV5AactualPage = aP0_AactualPage;
         executePrivate();
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
                  AV5AactualPage = GetNextPar( );
                  AssignAttri(sPrefix, false, "AV5AactualPage", AV5AactualPage);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV5AactualPage});
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
            PA1Y2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS1Y2( ) ;
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
            context.SendWebValue( "GAMHeader") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20204151122072", false, true);
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
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamheader.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5AactualPage))+"\">") ;
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
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV5AactualPage", StringUtil.RTrim( wcpOAV5AactualPage));
         GxWebStd.gx_hidden_field( context, sPrefix+"vAACTUALPAGE", StringUtil.RTrim( AV5AactualPage));
      }

      protected void RenderHtmlCloseForm1Y2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("gamheader.js", "?20204151122092", false, true);
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
            if ( ! ( WebComp_Component2 == null ) )
            {
               WebComp_Component2.componentjscripts();
            }
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
         return "GAMHeader" ;
      }

      public override String GetPgmdesc( )
      {
         return "GAMHeader" ;
      }

      protected void WB1Y0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "gamheader.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "ThinHeaderContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-8 col-xs-push-2 col-sm-4 col-sm-push-0 col-md-3", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "GENEXUS", "", "", lblTextblock3_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "GlobalTitle", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "ACCESS MANAGER", "", "", lblTextblock4_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'GOHOME\\'."+"'", "", "BigGlobalTitle", 5, "", 1, 1, 0, "HLP_GAMHeader.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-xs-pull-8 col-sm-5 col-sm-pull-0 col-md-6", "Center", "top", "", "", "div");
            context.WriteHtmlText( "<nav class=\"navbar navbar-default gx-navbar  MainMenu\" data-gx-actiongroup-type=\"menu\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "container-fluid", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "navbar-header", "left", "top", "", "", "div");
            context.WriteHtmlText( "<button type=\"button\" class=\"navbar-toggle collapsed gx-navbar-toggle\" data-toggle=\"collapse\" aria-expanded=\"false\">") ;
            context.WriteHtmlText( "<span class=\"icon-bar\"></span>") ;
            context.WriteHtmlText( "<span class=\"icon-bar\"></span>") ;
            context.WriteHtmlText( "<span class=\"icon-bar\"></span>") ;
            context.WriteHtmlText( "</button>") ;
            context.WriteHtmlText( "<span class=\"navbar-brand\"></span>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMenu_inner_Internalname, 1, 0, "px", 0, "px", "collapse navbar-collapse gx-navbar-inner", "left", "top", "", "", "div");
            context.WriteHtmlText( "<ul class=\"nav navbar-nav\">") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbmenuusers_Internalname, "USERS", lblTbmenuusers_Link, "", lblTbmenuusers_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbmenuroles_Internalname, "ROLES", lblTbmenuroles_Link, "", lblTbmenuroles_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li class=\"dropdown\">") ;
            context.WriteHtmlText( "<a href=\"#\" data-toggle=\"dropdown\" role=\"button\" aria-haspopup=\"true\" aria-expanded=\"false\" class=\"dropdown-toggle\">") ;
            context.WriteHtmlText( "SETTINGS") ;
            context.WriteHtmlText( "<span class=\"caret\"></span>") ;
            context.WriteHtmlText( "</a>") ;
            context.WriteHtmlText( "<ul class=\"gx-dropdown-menu dropdown-menu Submenu\">") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblWwsecpol_Internalname, "Security Policies", lblWwsecpol_Link, "", lblWwsecpol_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblWwapplications_Internalname, "Applications", lblWwapplications_Link, "", lblWwapplications_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblRepconf_Internalname, "Repository Configuration", lblRepconf_Link, "", lblRepconf_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblRepositoryconnections_Internalname, "Repository Connections", lblRepositoryconnections_Link, "", lblRepositoryconnections_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblAuthtype_Internalname, "Authentication Types", lblAuthtype_Link, "", lblAuthtype_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", lblAuthtype_Visible, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblChangepasswd_Internalname, "Change Password", lblChangepasswd_Link, "", lblChangepasswd_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblChangeworkrepo_Internalname, "Change Working Repository", lblChangeworkrepo_Link, "", lblChangeworkrepo_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbrepositories_Internalname, "Repositories", lblTbrepositories_Link, "", lblTbrepositories_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", lblTbrepositories_Visible, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "<li>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbevents_Internalname, "Event Subscriptions", lblTbevents_Link, "", lblTbevents_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "gx-navbar-textblock", 0, "", 1, 1, 0, "HLP_GAMHeader.htm");
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "</ul>") ;
            context.WriteHtmlText( "</li>") ;
            context.WriteHtmlText( "</ul>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</nav>") ;
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "Bottom", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+sPrefix+"gxHTMLWrpW0032"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( ! context.isAjaxRequest( ) )
               {
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix+"gxHTMLWrpW0032"+"");
               }
               WebComp_Component2.componentdraw();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "Right", "Bottom", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1Y2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
               Form.Meta.addItem("description", "GAMHeader", 0) ;
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
               STRUP1Y0( ) ;
            }
         }
      }

      protected void WS1Y2( )
      {
         START1Y2( ) ;
         EVT1Y2( ) ;
      }

      protected void EVT1Y2( )
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
                                 STRUP1Y0( ) ;
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
                                 STRUP1Y0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E111Y2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GOHOME'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Y0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'GoHome' */
                                    E121Y2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Y0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E131Y2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Y0( ) ;
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
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Y0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 32 )
                        {
                           WebComp_Component2 = getWebComponent(GetType(), "GeneXus.Programs", "gamlogout", new Object[] {context} );
                           WebComp_Component2.ComponentInit();
                           WebComp_Component2.Name = "GAMLogout";
                           WebComp_Component2_Component = "GAMLogout";
                           WebComp_Component2.componentprocess(sPrefix+"W0032", "", sEvt);
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1Y2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1Y2( ) ;
            }
         }
      }

      protected void PA1Y2( )
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1Y2( ) ;
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

      protected void RF1Y2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( StringUtil.StrCmp(WebComp_Component2_Component, "") == 0 )
            {
               WebComp_Component2 = getWebComponent(GetType(), "GeneXus.Programs", "gamlogout", new Object[] {context} );
               WebComp_Component2.ComponentInit();
               WebComp_Component2.Name = "GAMLogout";
               WebComp_Component2_Component = "GAMLogout";
            }
            WebComp_Component2.setjustcreated();
            WebComp_Component2.componentprepare(new Object[] {(String)sPrefix+"W0032",(String)""});
            WebComp_Component2.componentbind(new Object[] {});
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp(sPrefix+"gxHTMLWrpW0032"+"");
               WebComp_Component2.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            if ( 1 != 0 )
            {
               WebComp_Component2.componentstart();
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E131Y2 ();
            WB1Y0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1Y2( )
      {
      }

      protected void STRUP1Y0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111Y2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            wcpOAV5AactualPage = cgiGet( sPrefix+"wcpOAV5AactualPage");
            /* Read variables values. */
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
         E111Y2 ();
         if (returnInSub) return;
      }

      protected void E111Y2( )
      {
         /* Start Routine */
         AV8IsRepoAdministrator = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).isgamadministrator(out  AV7Errors);
         if ( AV8IsRepoAdministrator )
         {
            lblTbrepositories_Visible = 1;
            AssignProp(sPrefix, false, lblTbrepositories_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(lblTbrepositories_Visible), 5, 0), true);
         }
         else
         {
            lblTbrepositories_Visible = 0;
            AssignProp(sPrefix, false, lblTbrepositories_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(lblTbrepositories_Visible), 5, 0), true);
         }
         AV9GAMRepository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
         if ( (0==AV9GAMRepository.gxTpr_Authenticationmasterrepositoryid) )
         {
            lblAuthtype_Visible = 1;
            AssignProp(sPrefix, false, lblAuthtype_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(lblAuthtype_Visible), 5, 0), true);
         }
         else
         {
            lblAuthtype_Visible = 0;
            AssignProp(sPrefix, false, lblAuthtype_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(lblAuthtype_Visible), 5, 0), true);
         }
         if ( AV7Errors.Count > 0 )
         {
            /* Execute user subroutine: 'DISPLAYERRORS' */
            S112 ();
            if (returnInSub) return;
         }
         lblTbmenuusers_Link = formatLink("gamexamplewwusers.aspx") ;
         AssignProp(sPrefix, false, lblTbmenuusers_Internalname, "Link", lblTbmenuusers_Link, true);
         lblTbmenuroles_Link = formatLink("gamexamplewwroles.aspx") ;
         AssignProp(sPrefix, false, lblTbmenuroles_Internalname, "Link", lblTbmenuroles_Link, true);
         lblWwsecpol_Link = formatLink("gamexamplewwsecuritypolicies.aspx") ;
         AssignProp(sPrefix, false, lblWwsecpol_Internalname, "Link", lblWwsecpol_Link, true);
         lblWwapplications_Link = formatLink("gamexamplewwapplications.aspx") ;
         AssignProp(sPrefix, false, lblWwapplications_Internalname, "Link", lblWwapplications_Link, true);
         lblRepconf_Link = formatLink("gamrepositoryconfiguration.aspx") + "?" + UrlEncode("" +0);
         AssignProp(sPrefix, false, lblRepconf_Internalname, "Link", lblRepconf_Link, true);
         lblRepositoryconnections_Link = formatLink("gamexamplewwconnections.aspx") ;
         AssignProp(sPrefix, false, lblRepositoryconnections_Internalname, "Link", lblRepositoryconnections_Link, true);
         lblAuthtype_Link = formatLink("gamexamplewwauthtypes.aspx") ;
         AssignProp(sPrefix, false, lblAuthtype_Internalname, "Link", lblAuthtype_Link, true);
         lblChangepasswd_Link = formatLink("gamexamplechangeyourpassword.aspx") ;
         AssignProp(sPrefix, false, lblChangepasswd_Internalname, "Link", lblChangepasswd_Link, true);
         lblChangeworkrepo_Link = formatLink("gamexamplechangerepository.aspx") ;
         AssignProp(sPrefix, false, lblChangeworkrepo_Internalname, "Link", lblChangeworkrepo_Link, true);
         lblTbrepositories_Link = formatLink("gamexamplewwrepositories.aspx") ;
         AssignProp(sPrefix, false, lblTbrepositories_Internalname, "Link", lblTbrepositories_Link, true);
         lblTbevents_Link = formatLink("gamexamplewweventsubscriptions.aspx") ;
         AssignProp(sPrefix, false, lblTbevents_Internalname, "Link", lblTbevents_Link, true);
      }

      protected void S112( )
      {
         /* 'DISPLAYERRORS' Routine */
         AV13GXV1 = 1;
         while ( AV13GXV1 <= AV7Errors.Count )
         {
            AV6Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV7Errors.Item(AV13GXV1));
            GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV6Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV6Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
            AV13GXV1 = (int)(AV13GXV1+1);
         }
      }

      protected void E121Y2( )
      {
         /* 'GoHome' Routine */
         new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).applicationgohome("8d9934db-05db-4d64-adba-5e0466c3appU") ;
      }

      protected void nextLoad( )
      {
      }

      protected void E131Y2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5AactualPage = (String)getParm(obj,0);
         AssignAttri(sPrefix, false, "AV5AactualPage", AV5AactualPage);
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
         PA1Y2( ) ;
         WS1Y2( ) ;
         WE1Y2( ) ;
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
         sCtrlAV5AactualPage = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA1Y2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "gamheader", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA1Y2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV5AactualPage = (String)getParm(obj,2);
            AssignAttri(sPrefix, false, "AV5AactualPage", AV5AactualPage);
         }
         wcpOAV5AactualPage = cgiGet( sPrefix+"wcpOAV5AactualPage");
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV5AactualPage, wcpOAV5AactualPage) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV5AactualPage = AV5AactualPage;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV5AactualPage = cgiGet( sPrefix+"AV5AactualPage_CTRL");
         if ( StringUtil.Len( sCtrlAV5AactualPage) > 0 )
         {
            AV5AactualPage = cgiGet( sCtrlAV5AactualPage);
            AssignAttri(sPrefix, false, "AV5AactualPage", AV5AactualPage);
         }
         else
         {
            AV5AactualPage = cgiGet( sPrefix+"AV5AactualPage_PARM");
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
         PA1Y2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS1Y2( ) ;
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
         WS1Y2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV5AactualPage_PARM", StringUtil.RTrim( AV5AactualPage));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV5AactualPage)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV5AactualPage_CTRL", StringUtil.RTrim( sCtrlAV5AactualPage));
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
         WE1Y2( ) ;
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
         if ( ! ( WebComp_Component2 == null ) )
         {
            WebComp_Component2.componentjscripts();
         }
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         if ( StringUtil.StrCmp(WebComp_Component2_Component, "") == 0 )
         {
            WebComp_Component2 = getWebComponent(GetType(), "GeneXus.Programs", "gamlogout", new Object[] {context} );
            WebComp_Component2.ComponentInit();
            WebComp_Component2.Name = "GAMLogout";
            WebComp_Component2_Component = "GAMLogout";
         }
         if ( ! ( WebComp_Component2 == null ) )
         {
            WebComp_Component2.componentthemes();
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20204151122693", true, true);
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
         context.AddJavascriptSource("gamheader.js", "?20204151122697", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock3_Internalname = sPrefix+"TEXTBLOCK3";
         lblTextblock4_Internalname = sPrefix+"TEXTBLOCK4";
         divTable1_Internalname = sPrefix+"TABLE1";
         lblTbmenuusers_Internalname = sPrefix+"TBMENUUSERS";
         lblTbmenuroles_Internalname = sPrefix+"TBMENUROLES";
         lblWwsecpol_Internalname = sPrefix+"WWSECPOL";
         lblWwapplications_Internalname = sPrefix+"WWAPPLICATIONS";
         lblRepconf_Internalname = sPrefix+"REPCONF";
         lblRepositoryconnections_Internalname = sPrefix+"REPOSITORYCONNECTIONS";
         lblAuthtype_Internalname = sPrefix+"AUTHTYPE";
         lblChangepasswd_Internalname = sPrefix+"CHANGEPASSWD";
         lblChangeworkrepo_Internalname = sPrefix+"CHANGEWORKREPO";
         lblTbrepositories_Internalname = sPrefix+"TBREPOSITORIES";
         lblTbevents_Internalname = sPrefix+"TBEVENTS";
         divMenu_inner_Internalname = sPrefix+"MENU_INNER";
         divTable2_Internalname = sPrefix+"TABLE2";
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
         lblTbevents_Link = "";
         lblTbrepositories_Link = "";
         lblTbrepositories_Visible = 1;
         lblChangeworkrepo_Link = "";
         lblChangepasswd_Link = "";
         lblAuthtype_Link = "";
         lblAuthtype_Visible = 1;
         lblRepositoryconnections_Link = "";
         lblRepconf_Link = "";
         lblWwapplications_Link = "";
         lblWwsecpol_Link = "";
         lblTbmenuroles_Link = "";
         lblTbmenuusers_Link = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'GOHOME'","{handler:'E121Y2',iparms:[]");
         setEventMetadata("'GOHOME'",",oparms:[]}");
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
         wcpOAV5AactualPage = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         lblTextblock3_Jsonclick = "";
         lblTextblock4_Jsonclick = "";
         lblTbmenuusers_Jsonclick = "";
         lblTbmenuroles_Jsonclick = "";
         lblWwsecpol_Jsonclick = "";
         lblWwapplications_Jsonclick = "";
         lblRepconf_Jsonclick = "";
         lblRepositoryconnections_Jsonclick = "";
         lblAuthtype_Jsonclick = "";
         lblChangepasswd_Jsonclick = "";
         lblChangeworkrepo_Jsonclick = "";
         lblTbrepositories_Jsonclick = "";
         lblTbevents_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         WebComp_Component2_Component = "";
         AV7Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV9GAMRepository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV6Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV5AactualPage = "";
         WebComp_Component2 = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int lblAuthtype_Visible ;
      private int lblTbrepositories_Visible ;
      private int AV13GXV1 ;
      private int idxLst ;
      private String AV5AactualPage ;
      private String wcpOAV5AactualPage ;
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
      private String divTable1_Internalname ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String divMenu_inner_Internalname ;
      private String lblTbmenuusers_Internalname ;
      private String lblTbmenuusers_Link ;
      private String lblTbmenuusers_Jsonclick ;
      private String lblTbmenuroles_Internalname ;
      private String lblTbmenuroles_Link ;
      private String lblTbmenuroles_Jsonclick ;
      private String lblWwsecpol_Internalname ;
      private String lblWwsecpol_Link ;
      private String lblWwsecpol_Jsonclick ;
      private String lblWwapplications_Internalname ;
      private String lblWwapplications_Link ;
      private String lblWwapplications_Jsonclick ;
      private String lblRepconf_Internalname ;
      private String lblRepconf_Link ;
      private String lblRepconf_Jsonclick ;
      private String lblRepositoryconnections_Internalname ;
      private String lblRepositoryconnections_Link ;
      private String lblRepositoryconnections_Jsonclick ;
      private String lblAuthtype_Internalname ;
      private String lblAuthtype_Link ;
      private String lblAuthtype_Jsonclick ;
      private String lblChangepasswd_Internalname ;
      private String lblChangepasswd_Link ;
      private String lblChangepasswd_Jsonclick ;
      private String lblChangeworkrepo_Internalname ;
      private String lblChangeworkrepo_Link ;
      private String lblChangeworkrepo_Jsonclick ;
      private String lblTbrepositories_Internalname ;
      private String lblTbrepositories_Link ;
      private String lblTbrepositories_Jsonclick ;
      private String lblTbevents_Internalname ;
      private String lblTbevents_Link ;
      private String lblTbevents_Jsonclick ;
      private String divTable2_Internalname ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String WebComp_Component2_Component ;
      private String sCtrlAV5AactualPage ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV8IsRepoAdministrator ;
      private GXWebComponent WebComp_Component2 ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV7Errors ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV6Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV9GAMRepository ;
   }

}
