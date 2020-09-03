/*
               File: Login
        Description: Login
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/23/2020 14:32:30.55
       Program type: Main program
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class login : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public login( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public login( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
            ValidateSpaRequest();
            PA322( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS322( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE322( ) ;
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
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( "Login") ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 142546), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 142546), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 142546), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202082314323056", false, true);
         context.AddJavascriptSource("UserControls/ClickLoginUCRender.js", "", false, true);
         context.CloseHtmlHeader();
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal FormLogin\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal FormLogin\" data-gx-class=\"form-horizontal FormLogin\" novalidate action=\""+formatLink("login.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal FormLogin", true);
         toggleJsOutput = isJsOutputEnabled( );
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
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Rutakb", StringUtil.RTrim( Clickloginuc1_Rutakb));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Image", StringUtil.RTrim( Clickloginuc1_Image));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Titulo", StringUtil.RTrim( Clickloginuc1_Titulo));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Erroremail", StringUtil.RTrim( Clickloginuc1_Erroremail));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Errorpassword", StringUtil.RTrim( Clickloginuc1_Errorpassword));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Alertamsg", StringUtil.RTrim( Clickloginuc1_Alertamsg));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Textomsgalert", StringUtil.RTrim( Clickloginuc1_Textomsgalert));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Textbutton", StringUtil.RTrim( Clickloginuc1_Textbutton));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Forgot1", StringUtil.RTrim( Clickloginuc1_Forgot1));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Linkforgot", StringUtil.RTrim( Clickloginuc1_Linkforgot));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Forgot2", StringUtil.RTrim( Clickloginuc1_Forgot2));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Linkcreateaccount", StringUtil.RTrim( Clickloginuc1_Linkcreateaccount));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Createaccount", StringUtil.RTrim( Clickloginuc1_Createaccount));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Varusuario", StringUtil.RTrim( Clickloginuc1_Varusuario));
         GxWebStd.gx_hidden_field( context, "CLICKLOGINUC1_Varpassword", StringUtil.RTrim( Clickloginuc1_Varpassword));
      }

      protected void RenderHtmlCloseForm322( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      public override String GetPgmname( )
      {
         return "Login" ;
      }

      public override String GetPgmdesc( )
      {
         return "Login" ;
      }

      protected void WB320( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucClickloginuc1.Render(context, "clickloginuc", Clickloginuc1_Internalname, "CLICKLOGINUC1Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"CLICKLOGINUC1Container"+"Clickloginuc1_addusuarioin2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divClickloginuc1_addusuarioin2_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVusuario_Internalname, "v Usuario", "col-sm-3 input100Label", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVusuario_Internalname, AV11vUsuario, StringUtil.RTrim( context.localUtil.Format( AV11vUsuario, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,12);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVusuario_Jsonclick, 0, "input100", "", "", "", "", 1, edtavVusuario_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Login.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"CLICKLOGINUC1Container"+"Clickloginuc1_addpasswordin2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divClickloginuc1_addpasswordin2_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVpassword_Internalname, "v Password", "col-sm-3 input100Label", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVpassword_Internalname, AV9vPassword, StringUtil.RTrim( context.localUtil.Format( AV9vPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,18);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVpassword_Jsonclick, 0, "input100", "", "", "", "", 1, edtavVpassword_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, -1, 0, 0, 1, 0, -1, true, "", "left", true, "", "HLP_Login.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START322( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            if ( context.ExposeMetadata( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_10-142546", 0) ;
            }
            Form.Meta.addItem("description", "Login", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP320( ) ;
      }

      protected void WS322( )
      {
         START322( ) ;
         EVT322( ) ;
      }

      protected void EVT322( )
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
                        else if ( StringUtil.StrCmp(sEvt, "CLICKLOGINUC1.CLICK") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E11322 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E12322 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E13322 ();
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

      protected void WE322( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm322( ) ;
            }
         }
      }

      protected void PA322( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavVusuario_Internalname;
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
            before_start_formulas( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF322( ) ;
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

      protected void RF322( )
      {
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E13322 ();
            WB320( ) ;
         }
      }

      protected void send_integrity_lvl_hashes322( )
      {
      }

      protected void before_start_formulas( )
      {
         context.Gx_err = 0;
      }

      protected void STRUP320( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E12322 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Clickloginuc1_Rutakb = cgiGet( "CLICKLOGINUC1_Rutakb");
            Clickloginuc1_Image = cgiGet( "CLICKLOGINUC1_Image");
            Clickloginuc1_Titulo = cgiGet( "CLICKLOGINUC1_Titulo");
            Clickloginuc1_Erroremail = cgiGet( "CLICKLOGINUC1_Erroremail");
            Clickloginuc1_Errorpassword = cgiGet( "CLICKLOGINUC1_Errorpassword");
            Clickloginuc1_Alertamsg = cgiGet( "CLICKLOGINUC1_Alertamsg");
            Clickloginuc1_Textomsgalert = cgiGet( "CLICKLOGINUC1_Textomsgalert");
            Clickloginuc1_Textbutton = cgiGet( "CLICKLOGINUC1_Textbutton");
            Clickloginuc1_Forgot1 = cgiGet( "CLICKLOGINUC1_Forgot1");
            Clickloginuc1_Linkforgot = cgiGet( "CLICKLOGINUC1_Linkforgot");
            Clickloginuc1_Forgot2 = cgiGet( "CLICKLOGINUC1_Forgot2");
            Clickloginuc1_Linkcreateaccount = cgiGet( "CLICKLOGINUC1_Linkcreateaccount");
            Clickloginuc1_Createaccount = cgiGet( "CLICKLOGINUC1_Createaccount");
            Clickloginuc1_Varusuario = cgiGet( "CLICKLOGINUC1_Varusuario");
            Clickloginuc1_Varpassword = cgiGet( "CLICKLOGINUC1_Varpassword");
            /* Read variables values. */
            AV11vUsuario = cgiGet( edtavVusuario_Internalname);
            AssignAttri("", false, "AV11vUsuario", AV11vUsuario);
            AV9vPassword = cgiGet( edtavVpassword_Internalname);
            AssignAttri("", false, "AV9vPassword", AV9vPassword);
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
         E12322 ();
         if (returnInSub) return;
      }

      protected void E12322( )
      {
         /* Start Routine */
         AV12vUsuId = AV13WebSession.Get("USULOG");
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12vUsuId)) )
         {
            CallWebObject(formatLink("dashboard.aspx") );
            context.wjLocDisableFrm = 1;
         }
         AV10vRuta = AV6HttpRequest.BaseURL;
         AV8vImage = context.GetImagePath( "7b718545-8ca4-404f-9e28-33f7ca2835e8", "", context.GetTheme( ));
         AV16Vimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7b718545-8ca4-404f-9e28-33f7ca2835e8", "", context.GetTheme( )));
         Clickloginuc1_Image = AV16Vimage_GXI;
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "image", Clickloginuc1_Image);
         Clickloginuc1_Titulo = "SGCS-Soft";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "titulo", Clickloginuc1_Titulo);
         Clickloginuc1_Erroremail = "Escribir email asociado";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "erroremail", Clickloginuc1_Erroremail);
         Clickloginuc1_Errorpassword = "Escribir contraseña";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "errorpassword", Clickloginuc1_Errorpassword);
         Clickloginuc1_Textbutton = "Ingresar";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "textbutton", Clickloginuc1_Textbutton);
         Clickloginuc1_Linkcreateaccount = formatLink("wwmenu.aspx") ;
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "linkcreateaccount", Clickloginuc1_Linkcreateaccount);
         Clickloginuc1_Linkforgot = formatLink("wwmenu.aspx") ;
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "linkforgot", Clickloginuc1_Linkforgot);
         Clickloginuc1_Createaccount = "Registrarse";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "createaccount", Clickloginuc1_Createaccount);
         Clickloginuc1_Forgot1 = "Se me olvido ";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "forgot1", Clickloginuc1_Forgot1);
         Clickloginuc1_Forgot2 = "Usuario o Contraseña";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "forgot2", Clickloginuc1_Forgot2);
         Clickloginuc1_Linkforgot = formatLink("wwmenu.aspx") ;
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "linkforgot", Clickloginuc1_Linkforgot);
         Clickloginuc1_Textomsgalert = "Usuario o Contraseña incorrectas";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "textomsgalert", Clickloginuc1_Textomsgalert);
         Clickloginuc1_Alertamsg = "alerthidden";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "alertamsg", Clickloginuc1_Alertamsg);
         Clickloginuc1_Rutakb = StringUtil.Trim( AV10vRuta);
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "rutakb", Clickloginuc1_Rutakb);
         Clickloginuc1_Varusuario = "VUSUARIO";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "varusuario", Clickloginuc1_Varusuario);
         Clickloginuc1_Varpassword = "VPASSWORD";
         ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "varpassword", Clickloginuc1_Varpassword);
      }

      protected void E11322( )
      {
         /* Clickloginuc1_Click Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11vUsuario)) && String.IsNullOrEmpty(StringUtil.RTrim( AV9vPassword)) )
         {
            Clickloginuc1_Alertamsg = "alertvisible";
            ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "alertamsg", Clickloginuc1_Alertamsg);
         }
         else
         {
            AV17GXLvl30 = 0;
            /* Using cursor H00322 */
            pr_default.execute(0, new Object[] {AV11vUsuario, AV9vPassword});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A32UsuID = H00322_A32UsuID[0];
               A37UsuCla = H00322_A37UsuCla[0];
               AV17GXLvl30 = 1;
               AV13WebSession.Set("USULOG", A32UsuID);
               CallWebObject(formatLink("dashboard.aspx") );
               context.wjLocDisableFrm = 1;
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( AV17GXLvl30 == 0 )
            {
               Clickloginuc1_Alertamsg = "alertvisible";
               ucClickloginuc1.SendProperty(context, "", false, Clickloginuc1_Internalname, "alertamsg", Clickloginuc1_Alertamsg);
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E13322( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA322( ) ;
         WS322( ) ;
         WE322( ) ;
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
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202082314323067", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("login.js", "?202082314323067", false, true);
         context.AddJavascriptSource("UserControls/ClickLoginUCRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavVusuario_Internalname = "vVUSUARIO";
         divClickloginuc1_addusuarioin2_Internalname = "CLICKLOGINUC1_ADDUSUARIOIN2";
         edtavVpassword_Internalname = "vVPASSWORD";
         divClickloginuc1_addpasswordin2_Internalname = "CLICKLOGINUC1_ADDPASSWORDIN2";
         Clickloginuc1_Internalname = "CLICKLOGINUC1";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         init_default_properties( ) ;
         edtavVpassword_Jsonclick = "";
         edtavVpassword_Enabled = 1;
         edtavVusuario_Jsonclick = "";
         edtavVusuario_Enabled = 1;
         Clickloginuc1_Varpassword = "";
         Clickloginuc1_Varusuario = "";
         Clickloginuc1_Createaccount = "";
         Clickloginuc1_Linkcreateaccount = "";
         Clickloginuc1_Forgot2 = "";
         Clickloginuc1_Linkforgot = "";
         Clickloginuc1_Forgot1 = "";
         Clickloginuc1_Textbutton = "";
         Clickloginuc1_Textomsgalert = "";
         Clickloginuc1_Alertamsg = "";
         Clickloginuc1_Errorpassword = "";
         Clickloginuc1_Erroremail = "";
         Clickloginuc1_Titulo = "";
         Clickloginuc1_Image = "";
         Clickloginuc1_Rutakb = "";
      }

      protected override bool IsSpaSupported( )
      {
         return false ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("VALIDV_VUSUARIO","{handler:'Validv_Vusuario',iparms:[]");
         setEventMetadata("VALIDV_VUSUARIO",",oparms:[]}");
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
         GXKey = "";
         GX_FocusControl = "";
         sPrefix = "";
         ucClickloginuc1 = new GXUserControl();
         TempTags = "";
         AV11vUsuario = "";
         AV9vPassword = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV12vUsuId = "";
         AV13WebSession = context.GetSession();
         AV10vRuta = "";
         AV6HttpRequest = new GxHttpRequest( context);
         AV8vImage = "";
         AV16Vimage_GXI = "";
         scmdbuf = "";
         H00322_A42UsuarioID = new short[1] ;
         H00322_A32UsuID = new String[] {""} ;
         H00322_A37UsuCla = new String[] {""} ;
         A32UsuID = "";
         A37UsuCla = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.login__default(),
            new Object[][] {
                new Object[] {
               H00322_A42UsuarioID, H00322_A32UsuID, H00322_A37UsuCla
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV17GXLvl30 ;
      private short nGXWrapped ;
      private int edtavVusuario_Enabled ;
      private int edtavVpassword_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Clickloginuc1_Rutakb ;
      private String Clickloginuc1_Image ;
      private String Clickloginuc1_Titulo ;
      private String Clickloginuc1_Erroremail ;
      private String Clickloginuc1_Errorpassword ;
      private String Clickloginuc1_Alertamsg ;
      private String Clickloginuc1_Textomsgalert ;
      private String Clickloginuc1_Textbutton ;
      private String Clickloginuc1_Forgot1 ;
      private String Clickloginuc1_Linkforgot ;
      private String Clickloginuc1_Forgot2 ;
      private String Clickloginuc1_Linkcreateaccount ;
      private String Clickloginuc1_Createaccount ;
      private String Clickloginuc1_Varusuario ;
      private String Clickloginuc1_Varpassword ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String Clickloginuc1_Internalname ;
      private String divClickloginuc1_addusuarioin2_Internalname ;
      private String edtavVusuario_Internalname ;
      private String TempTags ;
      private String edtavVusuario_Jsonclick ;
      private String divClickloginuc1_addpasswordin2_Internalname ;
      private String edtavVpassword_Internalname ;
      private String edtavVpassword_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String A37UsuCla ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String AV11vUsuario ;
      private String AV9vPassword ;
      private String AV12vUsuId ;
      private String AV10vRuta ;
      private String AV16Vimage_GXI ;
      private String A32UsuID ;
      private String AV8vImage ;
      private IGxSession AV13WebSession ;
      private GXUserControl ucClickloginuc1 ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00322_A42UsuarioID ;
      private String[] H00322_A32UsuID ;
      private String[] H00322_A37UsuCla ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV6HttpRequest ;
   }

   public class login__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00322 ;
          prmH00322 = new Object[] {
          new Object[] {"@AV11vUsuario",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV9vPassword",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00322", "SELECT [UsuarioID], [UsuID], [UsuCla] FROM [Usuario] WHERE ([UsuID] = @AV11vUsuario) AND ([UsuCla] = @AV9vPassword) ORDER BY [UsuID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00322,100, GxCacheFrequency.OFF ,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
