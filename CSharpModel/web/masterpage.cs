/*
               File: MasterPage
        Description: Master Page
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/25/2020 23:27:50.99
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class masterpage : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public masterpage( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public masterpage( IGxContext context )
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
            PA2Y2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS2Y2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE2Y2( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlHeaders();
         }
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlOpenForm();
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
      }

      protected void RenderHtmlCloseForm2Y2( )
      {
         SendCloseFormHiddens( ) ;
         SendSecurityToken((String)(sPrefix));
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlCloseForm();
         }
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.AddJavascriptSource("masterpage.js", "?20208252327511", false, true);
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "MasterPage" ;
      }

      public override String GetPgmdesc( )
      {
         return "Master Page" ;
      }

      protected void WB2Y0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            if ( ! ShowMPWhenPopUp( ) && context.isPopUpObject( ) )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
               /* Content placeholder */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gx-content-placeholder");
               context.WriteHtmlText( ">") ;
               if ( ! isFullAjaxMode( ) )
               {
                  getDataAreaObject().RenderHtmlContent();
               }
               context.WriteHtmlText( "</div>") ;
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
               wbLoad = true;
               return  ;
            }
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTxtscript1_Internalname, lblTxtscript1_Caption, "", "", lblTxtscript1_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlock", 0, "", 1, 1, 2, "HLP_MasterPage.htm");
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            /* Content placeholder */
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-content-placeholder");
            context.WriteHtmlText( ">") ;
            if ( ! isFullAjaxMode( ) )
            {
               getDataAreaObject().RenderHtmlContent();
            }
            context.WriteHtmlText( "</div>") ;
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTxtscript2_Internalname, lblTxtscript2_Caption, "", "", lblTxtscript2_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlock", 0, "", 1, 1, 2, "HLP_MasterPage.htm");
         }
         wbLoad = true;
      }

      protected void START2Y2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2Y0( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      protected void WS2Y2( )
      {
         START2Y2( ) ;
         EVT2Y2( ) ;
      }

      protected void EVT2Y2( )
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
                        if ( StringUtil.StrCmp(sEvt, "RFR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E112Y2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E122Y2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER_MPAGE") == 0 )
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
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE2Y2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2Y2( ) ;
            }
         }
      }

      protected void PA2Y2( )
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
         RF2Y2( ) ;
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

      protected void RF2Y2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ShowMPWhenPopUp( ) || ! context.isPopUpObject( ) )
         {
            gxdyncontrolsrefreshing = true;
            fix_multi_value_controls( ) ;
            gxdyncontrolsrefreshing = false;
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E122Y2 ();
            WB2Y0( ) ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
      }

      protected void send_integrity_lvl_hashes2Y2( )
      {
      }

      protected void before_start_formulas( )
      {
         context.Gx_err = 0;
      }

      protected void STRUP2Y0( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E112Y2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
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
         E112Y2 ();
         if (returnInSub) return;
      }

      protected void E112Y2( )
      {
         /* Start Routine */
         AV6vRuta = AV5HttpRequest.BaseURL;
         AV11vUsuId = AV10WebSession.Get("USULOG");
         AssignAttri("", true, "AV11vUsuId", AV11vUsuId);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11vUsuId)) )
         {
            CallWebObject(formatLink("login.aspx") );
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'BUSCAR ROL' */
         S112 ();
         if (returnInSub) return;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13vUsuImg)) && String.IsNullOrEmpty(StringUtil.RTrim( AV23Vusuimg_GXI)) )
         {
            AV14vUrlImg = "MyMaster/dist/img/user2-160x160.jpg";
         }
         else
         {
            AV14vUrlImg = AV23Vusuimg_GXI;
         }
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Headerrawhtml = "<meta content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\" name=\"viewport\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\""+AV6vRuta+"MyMaster/bower_components/font-awesome/css/font-awesome.min.css\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\""+AV6vRuta+"MyMaster/bower_components/Ionicons/css/ionicons.min.css\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\""+AV6vRuta+"MyMaster/dist/css/AdminLTE.min.css\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\""+AV6vRuta+"MyMaster/dist/css/skins/_all-skins.min.css\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\""+AV6vRuta+"MyMaster/bower_components/morris.js/morris.css\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\""+AV6vRuta+"MyMaster/bower_components/jvectormap/jquery-jvectormap.css\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\""+AV6vRuta+"MyMaster/bower_components/bootstrap-daterangepicker/daterangepicker.css\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\""+AV6vRuta+"MyMaster/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css\">"+StringUtil.NewLine( )+"<link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic\">"+StringUtil.NewLine( )+"<script>window.onload = function(){document.body.className = \"form-horizontal Form form-horizontal-fx hold-transition skin-blue sidebar-mini\";}</script>";
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/jquery/dist/jquery.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/jquery-ui/jquery-ui.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/raphael/raphael.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/plugins/jvectormap/jquery-jvectormap-world-mill-en.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/jquery-knob/dist/jquery.knob.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/moment/min/moment.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/bootstrap-daterangepicker/daterangepicker.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/jquery-slimscroll/jquery.slimscroll.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/bower_components/fastclick/lib/fastclick.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/dist/js/adminlte.min.js") ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Add(AV6vRuta+"MyMaster/dist/js/demo.js") ;
         AV7vScript = "<div class=\"wrapper\">" + StringUtil.NewLine( ) + "<header class=\"main-header\">" + StringUtil.NewLine( ) + "<a href=\"index2.html\" class=\"logo\">" + StringUtil.NewLine( ) + "<span class=\"logo-mini\"><b>SGCS</b>Admin</span>" + StringUtil.NewLine( ) + "<span class=\"logo-lg\"><b>SGCS</b>Soft</span>" + StringUtil.NewLine( ) + "</a>" + StringUtil.NewLine( ) + "<nav class=\"navbar navbar-static-top\">" + StringUtil.NewLine( ) + "<a href=\"#\" class=\"sidebar-toggle\" data-toggle=\"push-menu\" role=\"button\">" + StringUtil.NewLine( ) + " <span class=\"sr-only\"></span>" + StringUtil.NewLine( ) + "</a>" + StringUtil.NewLine( ) + "<div class=\"navbar-custom-menu\">" + StringUtil.NewLine( ) + "<ul class=\"nav navbar-nav\">" + StringUtil.NewLine( ) + "<li class=\"dropdown notifications-menu\">" + StringUtil.NewLine( ) + "<a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\">" + StringUtil.NewLine( ) + "<button class=\"btn-primary\" id=\"ProfileBtn\">" + AV12vUsuNomCom + "</button>" + StringUtil.NewLine( ) + "</a>" + StringUtil.NewLine( ) + "<ul class=\"dropdown-menu\">" + StringUtil.NewLine( ) + "<li class=\"footer\"><a href=\"" + AV6vRuta + "wpdestroyer.aspx\">Cerrar Sesión</a></li>" + StringUtil.NewLine( ) + "</ul>" + StringUtil.NewLine( ) + "</li>" + StringUtil.NewLine( ) + "</ul>" + StringUtil.NewLine( ) + "</div>" + StringUtil.NewLine( ) + "</nav>" + StringUtil.NewLine( ) + "</header>" + StringUtil.NewLine( ) + "<aside class=\"main-sidebar\" style=\"max-height: 100%;\">" + StringUtil.NewLine( ) + "<section class=\"sidebar\">" + StringUtil.NewLine( ) + "<div class=\"user-panel\">" + StringUtil.NewLine( ) + "<div class=\"pull-left image\">" + StringUtil.NewLine( ) + "<img src=\"" + AV14vUrlImg + "\" class=\"img-circle\" alt=\"User Image\">" + StringUtil.NewLine( ) + "</div>" + StringUtil.NewLine( ) + "<div class=\"pull-left info\">" + StringUtil.NewLine( ) + "<p>" + AV12vUsuNomCom + "</p>" + StringUtil.NewLine( ) + "<a href=\"#\"><i class=\"fa fa-circle text-success\"></i> Online</a>" + StringUtil.NewLine( ) + "</div>" + StringUtil.NewLine( ) + "</div>" + StringUtil.NewLine( ) + "<ul class=\"sidebar-menu\" data-widget=\"tree\">" + StringUtil.NewLine( ) + "<li class=\"header\">SOFTWARE</li>";
         /* Using cursor H002Y2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31MenXEst = H002Y2_A31MenXEst[0];
            n31MenXEst = H002Y2_n31MenXEst[0];
            A43MenXPadre = H002Y2_A43MenXPadre[0];
            A28MenuXDesc = H002Y2_A28MenuXDesc[0];
            n28MenuXDesc = H002Y2_n28MenuXDesc[0];
            A30MenXUrl = H002Y2_A30MenXUrl[0];
            n30MenXUrl = H002Y2_n30MenXUrl[0];
            A27MenuXid = H002Y2_A27MenuXid[0];
            A29MenuXPosi = H002Y2_A29MenuXPosi[0];
            n29MenuXPosi = H002Y2_n29MenuXPosi[0];
            AV9vScript11 = AV9vScript11 + "<li class=\"active treeview\">" + StringUtil.NewLine( ) + "<a href=\"" + StringUtil.Trim( A30MenXUrl) + "\">" + StringUtil.NewLine( ) + "<i class=\"fa fa-tasks\" aria-hidden=\"true\"></i> <span>" + StringUtil.Trim( A28MenuXDesc) + "</span>" + StringUtil.NewLine( ) + "<span class=\"pull-right-container\">" + StringUtil.NewLine( ) + "<i class=\"fa fa-angle-left pull-right\"></i>" + StringUtil.NewLine( ) + "</span>" + StringUtil.NewLine( ) + "</a>";
            AssignAttri("", true, "AV9vScript11", AV9vScript11);
            AV15vMenuXId = A27MenuXid;
            AssignAttri("", true, "AV15vMenuXId", StringUtil.LTrimStr( (decimal)(AV15vMenuXId), 4, 0));
            /* Execute user subroutine: 'SUBMENU' */
            S123 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               returnInSub = true;
               if (true) return;
            }
            if ( AV20ban == 1 )
            {
               AV9vScript11 = AV9vScript11 + AV16vSubMenu;
               AssignAttri("", true, "AV9vScript11", AV9vScript11);
            }
            AV9vScript11 = AV9vScript11 + "</li>";
            AssignAttri("", true, "AV9vScript11", AV9vScript11);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV7vScript = AV7vScript + AV9vScript11 + "</ul>" + StringUtil.NewLine( ) + "</section>" + StringUtil.NewLine( ) + "</aside>" + StringUtil.NewLine( ) + "<div class=\"content-wrapper\" >" + StringUtil.NewLine( ) + "<section class=\"content-header\">" + StringUtil.NewLine( ) + "<ol class=\"breadcrumb\" style=\"position:static;\">" + StringUtil.NewLine( ) + "<li><a href=\"#\"><i class=\"fa fa-dashboard\"></i> Position</a></li>" + StringUtil.NewLine( ) + "<li class=\"active\">" + (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Caption + "</li>" + StringUtil.NewLine( ) + "</ol>" + StringUtil.NewLine( ) + "</section>" + StringUtil.NewLine( ) + "<section class=\"content\" >";
         AV8vScript2 = "  </section></div></div>";
         lblTxtscript1_Caption = AV7vScript;
         AssignProp("", true, lblTxtscript1_Internalname, "Caption", lblTxtscript1_Caption, true);
         lblTxtscript2_Caption = AV8vScript2;
         AssignProp("", true, lblTxtscript2_Internalname, "Caption", lblTxtscript2_Caption, true);
      }

      protected void S112( )
      {
         /* 'BUSCAR ROL' Routine */
         /* Using cursor H002Y3 */
         pr_default.execute(1, new Object[] {AV11vUsuId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A32UsuID = H002Y3_A32UsuID[0];
            A40000UsuImg_GXI = H002Y3_A40000UsuImg_GXI[0];
            A40RolId = H002Y3_A40RolId[0];
            A36UsuApe = H002Y3_A36UsuApe[0];
            A35UsuNom = H002Y3_A35UsuNom[0];
            A33UsuImg = H002Y3_A33UsuImg[0];
            A34UsuNomCom = StringUtil.Trim( A35UsuNom) + " " + StringUtil.Trim( A36UsuApe);
            AssignAttri("", true, "A34UsuNomCom", A34UsuNomCom);
            AV12vUsuNomCom = A34UsuNomCom;
            AssignAttri("", true, "AV12vUsuNomCom", AV12vUsuNomCom);
            AV13vUsuImg = A33UsuImg;
            AssignAttri("", true, "AV13vUsuImg", AV13vUsuImg);
            AV23Vusuimg_GXI = A40000UsuImg_GXI;
            AV18vUsuRol = A40RolId;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         if ( AV18vUsuRol == 1 )
         {
            new procedurerol(context ).execute( ) ;
         }
         else
         {
            new procedurerolinactivo(context ).execute( ) ;
         }
      }

      protected void S123( )
      {
         /* 'SUBMENU' Routine */
         AV16vSubMenu = "";
         AssignAttri("", true, "AV16vSubMenu", AV16vSubMenu);
         AV16vSubMenu = "<ul class=\"treeview-menu\">";
         AssignAttri("", true, "AV16vSubMenu", AV16vSubMenu);
         AV20ban = 0;
         AssignAttri("", true, "AV20ban", StringUtil.LTrimStr( (decimal)(AV20ban), 4, 0));
         /* Using cursor H002Y4 */
         pr_default.execute(2, new Object[] {AV15vMenuXId});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A43MenXPadre = H002Y4_A43MenXPadre[0];
            A31MenXEst = H002Y4_A31MenXEst[0];
            n31MenXEst = H002Y4_n31MenXEst[0];
            A28MenuXDesc = H002Y4_A28MenuXDesc[0];
            n28MenuXDesc = H002Y4_n28MenuXDesc[0];
            A30MenXUrl = H002Y4_A30MenXUrl[0];
            n30MenXUrl = H002Y4_n30MenXUrl[0];
            AV17Icon = "fa fa-circle-o";
            AV16vSubMenu = AV16vSubMenu + "<li><a href=\"" + StringUtil.Trim( A30MenXUrl) + "\"><i class=\"" + StringUtil.Trim( AV17Icon) + "\"></i>" + StringUtil.Trim( A28MenuXDesc) + "</a></li>";
            AssignAttri("", true, "AV16vSubMenu", AV16vSubMenu);
            AV20ban = 1;
            AssignAttri("", true, "AV20ban", StringUtil.LTrimStr( (decimal)(AV20ban), 4, 0));
            pr_default.readNext(2);
         }
         pr_default.close(2);
         AV16vSubMenu = AV16vSubMenu + "</ul>";
         AssignAttri("", true, "AV16vSubMenu", AV16vSubMenu);
      }

      protected void nextLoad( )
      {
      }

      protected void E122Y2( )
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
         PA2Y2( ) ;
         WS2Y2( ) ;
         WE2Y2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void master_styles( )
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
         while ( idxLst <= (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Item(idxLst))), "?20208252327519", true, true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("masterpage.js", "?202082523275110", false, true);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTxtscript1_Internalname = "TXTSCRIPT1_MPAGE";
         lblTxtscript2_Internalname = "TXTSCRIPT2_MPAGE";
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Internalname = "FORM_MPAGE";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         lblTxtscript2_Caption = "Script2";
         lblTxtscript1_Caption = "Script1";
         Contholder1.setDataArea(getDataAreaObject());
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
         setEventMetadata("REFRESH_MPAGE","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH_MPAGE",",oparms:[]}");
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
         Contholder1 = new GXDataAreaControl();
         GXKey = "";
         sPrefix = "";
         lblTxtscript1_Jsonclick = "";
         lblTxtscript2_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV6vRuta = "";
         AV5HttpRequest = new GxHttpRequest( context);
         AV11vUsuId = "";
         AV10WebSession = context.GetSession();
         AV13vUsuImg = "";
         AV23Vusuimg_GXI = "";
         AV14vUrlImg = "";
         AV7vScript = "";
         AV12vUsuNomCom = "";
         scmdbuf = "";
         H002Y2_A31MenXEst = new String[] {""} ;
         H002Y2_n31MenXEst = new bool[] {false} ;
         H002Y2_A43MenXPadre = new short[1] ;
         H002Y2_A28MenuXDesc = new String[] {""} ;
         H002Y2_n28MenuXDesc = new bool[] {false} ;
         H002Y2_A30MenXUrl = new String[] {""} ;
         H002Y2_n30MenXUrl = new bool[] {false} ;
         H002Y2_A27MenuXid = new short[1] ;
         H002Y2_A29MenuXPosi = new short[1] ;
         H002Y2_n29MenuXPosi = new bool[] {false} ;
         A31MenXEst = "";
         A28MenuXDesc = "";
         A30MenXUrl = "";
         AV9vScript11 = "";
         AV16vSubMenu = "";
         AV8vScript2 = "";
         H002Y3_A42UsuarioID = new short[1] ;
         H002Y3_A32UsuID = new String[] {""} ;
         H002Y3_A40000UsuImg_GXI = new String[] {""} ;
         H002Y3_A40RolId = new short[1] ;
         H002Y3_A36UsuApe = new String[] {""} ;
         H002Y3_A35UsuNom = new String[] {""} ;
         H002Y3_A33UsuImg = new String[] {""} ;
         A32UsuID = "";
         A40000UsuImg_GXI = "";
         A36UsuApe = "";
         A35UsuNom = "";
         A33UsuImg = "";
         A34UsuNomCom = "";
         H002Y4_A27MenuXid = new short[1] ;
         H002Y4_A43MenXPadre = new short[1] ;
         H002Y4_A31MenXEst = new String[] {""} ;
         H002Y4_n31MenXEst = new bool[] {false} ;
         H002Y4_A28MenuXDesc = new String[] {""} ;
         H002Y4_n28MenuXDesc = new bool[] {false} ;
         H002Y4_A30MenXUrl = new String[] {""} ;
         H002Y4_n30MenXUrl = new bool[] {false} ;
         AV17Icon = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "";
         Form = new GXWebForm();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.masterpage__default(),
            new Object[][] {
                new Object[] {
               H002Y2_A31MenXEst, H002Y2_n31MenXEst, H002Y2_A43MenXPadre, H002Y2_A28MenuXDesc, H002Y2_n28MenuXDesc, H002Y2_A30MenXUrl, H002Y2_n30MenXUrl, H002Y2_A27MenuXid, H002Y2_A29MenuXPosi, H002Y2_n29MenuXPosi
               }
               , new Object[] {
               H002Y3_A42UsuarioID, H002Y3_A32UsuID, H002Y3_A40000UsuImg_GXI, H002Y3_A40RolId, H002Y3_A36UsuApe, H002Y3_A35UsuNom, H002Y3_A33UsuImg
               }
               , new Object[] {
               H002Y4_A27MenuXid, H002Y4_A43MenXPadre, H002Y4_A31MenXEst, H002Y4_n31MenXEst, H002Y4_A28MenuXDesc, H002Y4_n28MenuXDesc, H002Y4_A30MenXUrl, H002Y4_n30MenXUrl
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nRcdExists_5 ;
      private short nIsMod_5 ;
      private short nRcdExists_4 ;
      private short nIsMod_4 ;
      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A43MenXPadre ;
      private short A27MenuXid ;
      private short A29MenuXPosi ;
      private short AV15vMenuXId ;
      private short AV20ban ;
      private short A40RolId ;
      private short AV18vUsuRol ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int idxLst ;
      private String GXKey ;
      private String sPrefix ;
      private String lblTxtscript1_Internalname ;
      private String lblTxtscript1_Caption ;
      private String lblTxtscript1_Jsonclick ;
      private String lblTxtscript2_Internalname ;
      private String lblTxtscript2_Caption ;
      private String lblTxtscript2_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String A31MenXEst ;
      private String sDynURL ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool toggleJsOutput ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool n31MenXEst ;
      private bool n28MenuXDesc ;
      private bool n30MenXUrl ;
      private bool n29MenuXPosi ;
      private String AV7vScript ;
      private String AV9vScript11 ;
      private String AV16vSubMenu ;
      private String AV8vScript2 ;
      private String AV6vRuta ;
      private String AV11vUsuId ;
      private String AV23Vusuimg_GXI ;
      private String AV14vUrlImg ;
      private String AV12vUsuNomCom ;
      private String A28MenuXDesc ;
      private String A30MenXUrl ;
      private String A32UsuID ;
      private String A40000UsuImg_GXI ;
      private String A36UsuApe ;
      private String A35UsuNom ;
      private String A34UsuNomCom ;
      private String AV17Icon ;
      private String AV13vUsuImg ;
      private String A33UsuImg ;
      private IGxSession AV10WebSession ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contholder1 ;
      private IDataStoreProvider pr_default ;
      private String[] H002Y2_A31MenXEst ;
      private bool[] H002Y2_n31MenXEst ;
      private short[] H002Y2_A43MenXPadre ;
      private String[] H002Y2_A28MenuXDesc ;
      private bool[] H002Y2_n28MenuXDesc ;
      private String[] H002Y2_A30MenXUrl ;
      private bool[] H002Y2_n30MenXUrl ;
      private short[] H002Y2_A27MenuXid ;
      private short[] H002Y2_A29MenuXPosi ;
      private bool[] H002Y2_n29MenuXPosi ;
      private short[] H002Y3_A42UsuarioID ;
      private String[] H002Y3_A32UsuID ;
      private String[] H002Y3_A40000UsuImg_GXI ;
      private short[] H002Y3_A40RolId ;
      private String[] H002Y3_A36UsuApe ;
      private String[] H002Y3_A35UsuNom ;
      private String[] H002Y3_A33UsuImg ;
      private short[] H002Y4_A27MenuXid ;
      private short[] H002Y4_A43MenXPadre ;
      private String[] H002Y4_A31MenXEst ;
      private bool[] H002Y4_n31MenXEst ;
      private String[] H002Y4_A28MenuXDesc ;
      private bool[] H002Y4_n28MenuXDesc ;
      private String[] H002Y4_A30MenXUrl ;
      private bool[] H002Y4_n30MenXUrl ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV5HttpRequest ;
      private GXWebForm Form ;
   }

   public class masterpage__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002Y2 ;
          prmH002Y2 = new Object[] {
          } ;
          Object[] prmH002Y3 ;
          prmH002Y3 = new Object[] {
          new Object[] {"@AV11vUsuId",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmH002Y4 ;
          prmH002Y4 = new Object[] {
          new Object[] {"@AV15vMenuXId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002Y2", "SELECT [MenXEst], [MenXPadre], [MenuXDesc], [MenXUrl], [MenuXid], [MenuXPosi] FROM [Menu] WHERE ([MenXEst] = 'A') AND ([MenXPadre] = 0) ORDER BY [MenuXPosi] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Y2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H002Y3", "SELECT TOP 1 [UsuarioID], [UsuID], [UsuImg_GXI], [RolId], [UsuApe], [UsuNom], [UsuImg] FROM [Usuario] WHERE [UsuID] = @AV11vUsuId ORDER BY [UsuID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Y3,1, GxCacheFrequency.OFF ,false,true )
             ,new CursorDef("H002Y4", "SELECT [MenuXid], [MenXPadre], [MenXEst], [MenuXDesc], [MenXUrl] FROM [Menu] WHERE [MenXPadre] = @AV15vMenuXId and [MenXEst] = 'A' ORDER BY [MenXPadre], [MenXEst] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Y4,100, GxCacheFrequency.OFF ,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(3)) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
