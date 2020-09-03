/*
               File: TareaGeneral
        Description: Tarea General
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/23/2020 14:32:30.91
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
   public class tareageneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tareageneral( )
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

      public tareageneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_IdTarea )
      {
         this.A5IdTarea = aP0_IdTarea;
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
                  A5IdTarea = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri(sPrefix, false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A5IdTarea});
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
            PA0X2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV13Pgmname = "TareaGeneral";
               context.Gx_err = 0;
               WS0X2( ) ;
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
            context.SendWebValue( "Tarea General") ;
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
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 142546), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 142546), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 142546), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202082314323094", false, true);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("tareageneral.aspx") + "?" + UrlEncode("" +A5IdTarea)+"\">") ;
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
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", sPrefix+"hsh"+"TareaGeneral");
         forbiddenHiddens.Add("IdProyecto", context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9"));
         forbiddenHiddens.Add("IdFase", context.localUtil.Format( (decimal)(A13IdFase), "ZZZ9"));
         forbiddenHiddens.Add("IdPrioridad", context.localUtil.Format( (decimal)(A9IdPrioridad), "ZZZ9"));
         forbiddenHiddens.Add("IdEstadoTarea", context.localUtil.Format( (decimal)(A17IdEstadoTarea), "ZZZ9"));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLogInfo("tareageneral:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA5IdTarea", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA5IdTarea), 4, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm0X2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("tareageneral.js", "?202082314323096", false, true);
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
         return "TareaGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tarea General" ;
      }

      protected void WB0X0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tareageneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewActionsCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group WWViewActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Update", bttBtnupdate_Jsonclick, 7, "Update", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e110x1_client"+"'", TempTags, "", 2, "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Delete", bttBtndelete_Jsonclick, 7, "Delete", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e120x1_client"+"'", TempTags, "", 2, "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAttributestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdTarea_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtIdTarea_Internalname, "Id de Tarea", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtIdTarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5IdTarea), 4, 0, ".", "")), ((edtIdTarea_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A5IdTarea), "ZZZ9")) : context.localUtil.Format( (decimal)(A5IdTarea), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdTarea_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtIdTarea_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdProyecto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtIdProyecto_Internalname, "Id de Proyecto", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtIdProyecto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1IdProyecto), 4, 0, ".", "")), ((edtIdProyecto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9")) : context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdProyecto_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtIdProyecto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNombreProyecto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNombreProyecto_Internalname, "Nombre de Proyecto", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtNombreProyecto_Internalname, StringUtil.RTrim( A2NombreProyecto), StringUtil.RTrim( context.localUtil.Format( A2NombreProyecto, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtNombreProyecto_Link, "", "", "", edtNombreProyecto_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtNombreProyecto_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNombreTarea_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNombreTarea_Internalname, "Nombre de Tarea", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtNombreTarea_Internalname, StringUtil.RTrim( A6NombreTarea), StringUtil.RTrim( context.localUtil.Format( A6NombreTarea, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNombreTarea_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtNombreTarea_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDescripcionTarea_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDescripcionTarea_Internalname, "Descripcion de Tarea", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtDescripcionTarea_Internalname, StringUtil.RTrim( A7DescripcionTarea), StringUtil.RTrim( context.localUtil.Format( A7DescripcionTarea, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDescripcionTarea_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtDescripcionTarea_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdFase_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtIdFase_Internalname, "Id Fase", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtIdFase_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13IdFase), 4, 0, ".", "")), ((edtIdFase_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13IdFase), "ZZZ9")) : context.localUtil.Format( (decimal)(A13IdFase), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdFase_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtIdFase_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtFase_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtFase_Internalname, "Fase", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtFase_Internalname, StringUtil.RTrim( A14Fase), StringUtil.RTrim( context.localUtil.Format( A14Fase, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtFase_Link, "", "", "", edtFase_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtFase_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdPrioridad_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtIdPrioridad_Internalname, "Id de Prioridad", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtIdPrioridad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A9IdPrioridad), 4, 0, ".", "")), ((edtIdPrioridad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A9IdPrioridad), "ZZZ9")) : context.localUtil.Format( (decimal)(A9IdPrioridad), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdPrioridad_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtIdPrioridad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrioridad_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrioridad_Internalname, "Prioridad", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPrioridad_Internalname, StringUtil.RTrim( A10Prioridad), StringUtil.RTrim( context.localUtil.Format( A10Prioridad, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtPrioridad_Link, "", "", "", edtPrioridad_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtPrioridad_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdEstadoTarea_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtIdEstadoTarea_Internalname, "Id Estado Tarea", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtIdEstadoTarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17IdEstadoTarea), 4, 0, ".", "")), ((edtIdEstadoTarea_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A17IdEstadoTarea), "ZZZ9")) : context.localUtil.Format( (decimal)(A17IdEstadoTarea), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdEstadoTarea_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtIdEstadoTarea_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstadoTarea_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstadoTarea_Internalname, "Estado Tarea", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEstadoTarea_Internalname, StringUtil.RTrim( A18EstadoTarea), StringUtil.RTrim( context.localUtil.Format( A18EstadoTarea, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtEstadoTarea_Link, "", "", "", edtEstadoTarea_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEstadoTarea_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdPadre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtIdPadre_Internalname, "Id Tarea Padre", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtIdPadre_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19IdPadre), 4, 0, ".", "")), ((edtIdPadre_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19IdPadre), "ZZZ9")) : context.localUtil.Format( (decimal)(A19IdPadre), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdPadre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtIdPadre_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNombrePadre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNombrePadre_Internalname, "Nombre Tarea Padre", "col-sm-3 ReadonlyAttributeLabel", 1, true, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtNombrePadre_Internalname, StringUtil.RTrim( A20NombrePadre), StringUtil.RTrim( context.localUtil.Format( A20NombrePadre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNombrePadre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtNombrePadre_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_TareaGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtStatusTarea_Internalname, "Status Tarea", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtStatusTarea_Internalname, StringUtil.BoolToStr( A23StatusTarea), StringUtil.BoolToStr( A23StatusTarea), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtStatusTarea_Jsonclick, 0, "Attribute", "", "", "", "", edtStatusTarea_Visible, edtStatusTarea_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "", "HLP_TareaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0X2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               if ( context.ExposeMetadata( ) )
               {
                  Form.Meta.addItem("generator", "GeneXus C# 16_0_10-142546", 0) ;
               }
               Form.Meta.addItem("description", "Tarea General", 0) ;
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
               STRUP0X0( ) ;
            }
         }
      }

      protected void WS0X2( )
      {
         START0X2( ) ;
         EVT0X2( ) ;
      }

      protected void EVT0X2( )
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
                                 STRUP0X0( ) ;
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
                                 STRUP0X0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E130X2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0X0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E140X2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0X0( ) ;
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
                                 STRUP0X0( ) ;
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
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0X2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0X2( ) ;
            }
         }
      }

      protected void PA0X2( )
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
            before_start_formulas( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0X2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV13Pgmname = "TareaGeneral";
         context.Gx_err = 0;
      }

      protected void RF0X2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000X2 */
            pr_default.execute(0, new Object[] {A5IdTarea});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A23StatusTarea = H000X2_A23StatusTarea[0];
               AssignAttri(sPrefix, false, "A23StatusTarea", A23StatusTarea);
               A20NombrePadre = H000X2_A20NombrePadre[0];
               AssignAttri(sPrefix, false, "A20NombrePadre", A20NombrePadre);
               A19IdPadre = H000X2_A19IdPadre[0];
               n19IdPadre = H000X2_n19IdPadre[0];
               AssignAttri(sPrefix, false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
               A18EstadoTarea = H000X2_A18EstadoTarea[0];
               AssignAttri(sPrefix, false, "A18EstadoTarea", A18EstadoTarea);
               A17IdEstadoTarea = H000X2_A17IdEstadoTarea[0];
               AssignAttri(sPrefix, false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
               A10Prioridad = H000X2_A10Prioridad[0];
               AssignAttri(sPrefix, false, "A10Prioridad", A10Prioridad);
               A9IdPrioridad = H000X2_A9IdPrioridad[0];
               AssignAttri(sPrefix, false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
               A14Fase = H000X2_A14Fase[0];
               AssignAttri(sPrefix, false, "A14Fase", A14Fase);
               A13IdFase = H000X2_A13IdFase[0];
               AssignAttri(sPrefix, false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
               A7DescripcionTarea = H000X2_A7DescripcionTarea[0];
               AssignAttri(sPrefix, false, "A7DescripcionTarea", A7DescripcionTarea);
               A6NombreTarea = H000X2_A6NombreTarea[0];
               AssignAttri(sPrefix, false, "A6NombreTarea", A6NombreTarea);
               A2NombreProyecto = H000X2_A2NombreProyecto[0];
               AssignAttri(sPrefix, false, "A2NombreProyecto", A2NombreProyecto);
               A1IdProyecto = H000X2_A1IdProyecto[0];
               AssignAttri(sPrefix, false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
               A20NombrePadre = H000X2_A20NombrePadre[0];
               AssignAttri(sPrefix, false, "A20NombrePadre", A20NombrePadre);
               A18EstadoTarea = H000X2_A18EstadoTarea[0];
               AssignAttri(sPrefix, false, "A18EstadoTarea", A18EstadoTarea);
               A10Prioridad = H000X2_A10Prioridad[0];
               AssignAttri(sPrefix, false, "A10Prioridad", A10Prioridad);
               A14Fase = H000X2_A14Fase[0];
               AssignAttri(sPrefix, false, "A14Fase", A14Fase);
               A2NombreProyecto = H000X2_A2NombreProyecto[0];
               AssignAttri(sPrefix, false, "A2NombreProyecto", A2NombreProyecto);
               /* Execute user event: Load */
               E140X2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB0X0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0X2( )
      {
      }

      protected void before_start_formulas( )
      {
         AV13Pgmname = "TareaGeneral";
         context.Gx_err = 0;
      }

      protected void STRUP0X0( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E130X2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            wcpOA5IdTarea = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA5IdTarea"), ".", ","));
            /* Read variables values. */
            A1IdProyecto = (short)(context.localUtil.CToN( cgiGet( edtIdProyecto_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
            A2NombreProyecto = cgiGet( edtNombreProyecto_Internalname);
            AssignAttri(sPrefix, false, "A2NombreProyecto", A2NombreProyecto);
            A6NombreTarea = cgiGet( edtNombreTarea_Internalname);
            AssignAttri(sPrefix, false, "A6NombreTarea", A6NombreTarea);
            A7DescripcionTarea = cgiGet( edtDescripcionTarea_Internalname);
            AssignAttri(sPrefix, false, "A7DescripcionTarea", A7DescripcionTarea);
            A13IdFase = (short)(context.localUtil.CToN( cgiGet( edtIdFase_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
            A14Fase = cgiGet( edtFase_Internalname);
            AssignAttri(sPrefix, false, "A14Fase", A14Fase);
            A9IdPrioridad = (short)(context.localUtil.CToN( cgiGet( edtIdPrioridad_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
            A10Prioridad = cgiGet( edtPrioridad_Internalname);
            AssignAttri(sPrefix, false, "A10Prioridad", A10Prioridad);
            A17IdEstadoTarea = (short)(context.localUtil.CToN( cgiGet( edtIdEstadoTarea_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
            A18EstadoTarea = cgiGet( edtEstadoTarea_Internalname);
            AssignAttri(sPrefix, false, "A18EstadoTarea", A18EstadoTarea);
            A19IdPadre = (short)(context.localUtil.CToN( cgiGet( edtIdPadre_Internalname), ".", ","));
            n19IdPadre = false;
            AssignAttri(sPrefix, false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
            A20NombrePadre = cgiGet( edtNombrePadre_Internalname);
            AssignAttri(sPrefix, false, "A20NombrePadre", A20NombrePadre);
            A23StatusTarea = StringUtil.StrToBool( cgiGet( edtStatusTarea_Internalname));
            AssignAttri(sPrefix, false, "A23StatusTarea", A23StatusTarea);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = new GXProperties();
            forbiddenHiddens.Add("hshsalt", sPrefix+"hsh"+"TareaGeneral");
            A1IdProyecto = (short)(context.localUtil.CToN( cgiGet( edtIdProyecto_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
            forbiddenHiddens.Add("IdProyecto", context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9"));
            A13IdFase = (short)(context.localUtil.CToN( cgiGet( edtIdFase_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
            forbiddenHiddens.Add("IdFase", context.localUtil.Format( (decimal)(A13IdFase), "ZZZ9"));
            A9IdPrioridad = (short)(context.localUtil.CToN( cgiGet( edtIdPrioridad_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
            forbiddenHiddens.Add("IdPrioridad", context.localUtil.Format( (decimal)(A9IdPrioridad), "ZZZ9"));
            A17IdEstadoTarea = (short)(context.localUtil.CToN( cgiGet( edtIdEstadoTarea_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
            forbiddenHiddens.Add("IdEstadoTarea", context.localUtil.Format( (decimal)(A17IdEstadoTarea), "ZZZ9"));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
            {
               GXUtil.WriteLogError("tareageneral:[ SecurityCheckFailed (403 Forbidden) value for]"+forbiddenHiddens.ToJSonString());
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
         E130X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130X2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E140X2( )
      {
         /* Load Routine */
         edtNombreProyecto_Link = formatLink("viewproyecto.aspx") + "?" + UrlEncode("" +A1IdProyecto) + "," + UrlEncode(StringUtil.RTrim(""));
         AssignProp(sPrefix, false, edtNombreProyecto_Internalname, "Link", edtNombreProyecto_Link, true);
         edtFase_Link = formatLink("viewfase.aspx") + "?" + UrlEncode("" +A13IdFase) + "," + UrlEncode(StringUtil.RTrim(""));
         AssignProp(sPrefix, false, edtFase_Internalname, "Link", edtFase_Link, true);
         edtPrioridad_Link = formatLink("viewprioridad.aspx") + "?" + UrlEncode("" +A9IdPrioridad) + "," + UrlEncode(StringUtil.RTrim(""));
         AssignProp(sPrefix, false, edtPrioridad_Internalname, "Link", edtPrioridad_Link, true);
         edtEstadoTarea_Link = formatLink("viewestadotarea.aspx") + "?" + UrlEncode("" +A17IdEstadoTarea) + "," + UrlEncode(StringUtil.RTrim(""));
         AssignProp(sPrefix, false, edtEstadoTarea_Internalname, "Link", edtEstadoTarea_Link, true);
         edtStatusTarea_Visible = 0;
         AssignProp(sPrefix, false, edtStatusTarea_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtStatusTarea_Visible), 5, 0), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV7TrnContext = new SdtTransactionContext(context);
         AV7TrnContext.gxTpr_Callerobject = AV13Pgmname;
         AV7TrnContext.gxTpr_Callerondelete = false;
         AV7TrnContext.gxTpr_Callerurl = AV10HTTPRequest.ScriptName+"?"+AV10HTTPRequest.QueryString;
         AV7TrnContext.gxTpr_Transactionname = "Tarea";
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8TrnContextAtt.gxTpr_Attributename = "IdTarea";
         AV8TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6IdTarea), 4, 0);
         AV7TrnContext.gxTpr_Attributes.Add(AV8TrnContextAtt, 0);
         AV9Session.Set("TrnContext", AV7TrnContext.ToXml(false, true, "TransactionContext", "SGCS"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A5IdTarea = Convert.ToInt16(getParm(obj,0));
         AssignAttri(sPrefix, false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
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
         PA0X2( ) ;
         WS0X2( ) ;
         WE0X2( ) ;
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
         sCtrlA5IdTarea = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0X2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "tareageneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0X2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A5IdTarea = Convert.ToInt16(getParm(obj,2));
            AssignAttri(sPrefix, false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
         }
         wcpOA5IdTarea = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA5IdTarea"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A5IdTarea != wcpOA5IdTarea ) ) )
         {
            setjustcreated();
         }
         wcpOA5IdTarea = A5IdTarea;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA5IdTarea = cgiGet( sPrefix+"A5IdTarea_CTRL");
         if ( StringUtil.Len( sCtrlA5IdTarea) > 0 )
         {
            A5IdTarea = (short)(context.localUtil.CToN( cgiGet( sCtrlA5IdTarea), ".", ","));
            AssignAttri(sPrefix, false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
         }
         else
         {
            A5IdTarea = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A5IdTarea_PARM"), ".", ","));
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
         PA0X2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0X2( ) ;
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
         WS0X2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A5IdTarea_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5IdTarea), 4, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA5IdTarea)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A5IdTarea_CTRL", StringUtil.RTrim( sCtrlA5IdTarea));
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
         WE0X2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202082314323119", true, true);
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
         context.AddJavascriptSource("tareageneral.js", "?202082314323119", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         edtIdTarea_Internalname = sPrefix+"IDTAREA";
         edtIdProyecto_Internalname = sPrefix+"IDPROYECTO";
         edtNombreProyecto_Internalname = sPrefix+"NOMBREPROYECTO";
         edtNombreTarea_Internalname = sPrefix+"NOMBRETAREA";
         edtDescripcionTarea_Internalname = sPrefix+"DESCRIPCIONTAREA";
         edtIdFase_Internalname = sPrefix+"IDFASE";
         edtFase_Internalname = sPrefix+"FASE";
         edtIdPrioridad_Internalname = sPrefix+"IDPRIORIDAD";
         edtPrioridad_Internalname = sPrefix+"PRIORIDAD";
         edtIdEstadoTarea_Internalname = sPrefix+"IDESTADOTAREA";
         edtEstadoTarea_Internalname = sPrefix+"ESTADOTAREA";
         edtIdPadre_Internalname = sPrefix+"IDPADRE";
         edtNombrePadre_Internalname = sPrefix+"NOMBREPADRE";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         edtStatusTarea_Internalname = sPrefix+"STATUSTAREA";
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
         edtStatusTarea_Jsonclick = "";
         edtStatusTarea_Enabled = 0;
         edtStatusTarea_Visible = 1;
         edtNombrePadre_Jsonclick = "";
         edtNombrePadre_Enabled = 0;
         edtIdPadre_Jsonclick = "";
         edtIdPadre_Enabled = 0;
         edtEstadoTarea_Jsonclick = "";
         edtEstadoTarea_Link = "";
         edtEstadoTarea_Enabled = 0;
         edtIdEstadoTarea_Jsonclick = "";
         edtIdEstadoTarea_Enabled = 0;
         edtPrioridad_Jsonclick = "";
         edtPrioridad_Link = "";
         edtPrioridad_Enabled = 0;
         edtIdPrioridad_Jsonclick = "";
         edtIdPrioridad_Enabled = 0;
         edtFase_Jsonclick = "";
         edtFase_Link = "";
         edtFase_Enabled = 0;
         edtIdFase_Jsonclick = "";
         edtIdFase_Enabled = 0;
         edtDescripcionTarea_Jsonclick = "";
         edtDescripcionTarea_Enabled = 0;
         edtNombreTarea_Jsonclick = "";
         edtNombreTarea_Enabled = 0;
         edtNombreProyecto_Jsonclick = "";
         edtNombreProyecto_Link = "";
         edtNombreProyecto_Enabled = 0;
         edtIdProyecto_Jsonclick = "";
         edtIdProyecto_Enabled = 0;
         edtIdTarea_Jsonclick = "";
         edtIdTarea_Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A5IdTarea',fld:'IDTAREA',pic:'ZZZ9'},{av:'A1IdProyecto',fld:'IDPROYECTO',pic:'ZZZ9'},{av:'A13IdFase',fld:'IDFASE',pic:'ZZZ9'},{av:'A9IdPrioridad',fld:'IDPRIORIDAD',pic:'ZZZ9'},{av:'A17IdEstadoTarea',fld:'IDESTADOTAREA',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOUPDATE'","{handler:'E110X1',iparms:[{av:'A5IdTarea',fld:'IDTAREA',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E120X1',iparms:[{av:'A5IdTarea',fld:'IDTAREA',pic:'ZZZ9'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
         setEventMetadata("VALID_IDTAREA","{handler:'Valid_Idtarea',iparms:[]");
         setEventMetadata("VALID_IDTAREA",",oparms:[]}");
         setEventMetadata("VALID_IDPROYECTO","{handler:'Valid_Idproyecto',iparms:[]");
         setEventMetadata("VALID_IDPROYECTO",",oparms:[]}");
         setEventMetadata("VALID_IDFASE","{handler:'Valid_Idfase',iparms:[]");
         setEventMetadata("VALID_IDFASE",",oparms:[]}");
         setEventMetadata("VALID_IDPRIORIDAD","{handler:'Valid_Idprioridad',iparms:[]");
         setEventMetadata("VALID_IDPRIORIDAD",",oparms:[]}");
         setEventMetadata("VALID_IDESTADOTAREA","{handler:'Valid_Idestadotarea',iparms:[]");
         setEventMetadata("VALID_IDESTADOTAREA",",oparms:[]}");
         setEventMetadata("VALID_IDPADRE","{handler:'Valid_Idpadre',iparms:[]");
         setEventMetadata("VALID_IDPADRE",",oparms:[]}");
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
         sPrefix = "";
         AV13Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = new GXProperties();
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A2NombreProyecto = "";
         A6NombreTarea = "";
         A7DescripcionTarea = "";
         A14Fase = "";
         A10Prioridad = "";
         A18EstadoTarea = "";
         A20NombrePadre = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H000X2_A5IdTarea = new short[1] ;
         H000X2_A23StatusTarea = new bool[] {false} ;
         H000X2_A20NombrePadre = new String[] {""} ;
         H000X2_A19IdPadre = new short[1] ;
         H000X2_n19IdPadre = new bool[] {false} ;
         H000X2_A18EstadoTarea = new String[] {""} ;
         H000X2_A17IdEstadoTarea = new short[1] ;
         H000X2_A10Prioridad = new String[] {""} ;
         H000X2_A9IdPrioridad = new short[1] ;
         H000X2_A14Fase = new String[] {""} ;
         H000X2_A13IdFase = new short[1] ;
         H000X2_A7DescripcionTarea = new String[] {""} ;
         H000X2_A6NombreTarea = new String[] {""} ;
         H000X2_A2NombreProyecto = new String[] {""} ;
         H000X2_A1IdProyecto = new short[1] ;
         hsh = "";
         AV7TrnContext = new SdtTransactionContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA5IdTarea = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tareageneral__default(),
            new Object[][] {
                new Object[] {
               H000X2_A5IdTarea, H000X2_A23StatusTarea, H000X2_A20NombrePadre, H000X2_A19IdPadre, H000X2_n19IdPadre, H000X2_A18EstadoTarea, H000X2_A17IdEstadoTarea, H000X2_A10Prioridad, H000X2_A9IdPrioridad, H000X2_A14Fase,
               H000X2_A13IdFase, H000X2_A7DescripcionTarea, H000X2_A6NombreTarea, H000X2_A2NombreProyecto, H000X2_A1IdProyecto
               }
            }
         );
         AV13Pgmname = "TareaGeneral";
         /* GeneXus formulas. */
         AV13Pgmname = "TareaGeneral";
         context.Gx_err = 0;
      }

      private short A5IdTarea ;
      private short wcpOA5IdTarea ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short A1IdProyecto ;
      private short A13IdFase ;
      private short A9IdPrioridad ;
      private short A17IdEstadoTarea ;
      private short wbEnd ;
      private short wbStart ;
      private short A19IdPadre ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6IdTarea ;
      private short nGXWrapped ;
      private int edtIdTarea_Enabled ;
      private int edtIdProyecto_Enabled ;
      private int edtNombreProyecto_Enabled ;
      private int edtNombreTarea_Enabled ;
      private int edtDescripcionTarea_Enabled ;
      private int edtIdFase_Enabled ;
      private int edtFase_Enabled ;
      private int edtIdPrioridad_Enabled ;
      private int edtPrioridad_Enabled ;
      private int edtIdEstadoTarea_Enabled ;
      private int edtEstadoTarea_Enabled ;
      private int edtIdPadre_Enabled ;
      private int edtNombrePadre_Enabled ;
      private int edtStatusTarea_Visible ;
      private int edtStatusTarea_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV13Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divAttributestable_Internalname ;
      private String edtIdTarea_Internalname ;
      private String edtIdTarea_Jsonclick ;
      private String edtIdProyecto_Internalname ;
      private String edtIdProyecto_Jsonclick ;
      private String edtNombreProyecto_Internalname ;
      private String A2NombreProyecto ;
      private String edtNombreProyecto_Link ;
      private String edtNombreProyecto_Jsonclick ;
      private String edtNombreTarea_Internalname ;
      private String A6NombreTarea ;
      private String edtNombreTarea_Jsonclick ;
      private String edtDescripcionTarea_Internalname ;
      private String A7DescripcionTarea ;
      private String edtDescripcionTarea_Jsonclick ;
      private String edtIdFase_Internalname ;
      private String edtIdFase_Jsonclick ;
      private String edtFase_Internalname ;
      private String A14Fase ;
      private String edtFase_Link ;
      private String edtFase_Jsonclick ;
      private String edtIdPrioridad_Internalname ;
      private String edtIdPrioridad_Jsonclick ;
      private String edtPrioridad_Internalname ;
      private String A10Prioridad ;
      private String edtPrioridad_Link ;
      private String edtPrioridad_Jsonclick ;
      private String edtIdEstadoTarea_Internalname ;
      private String edtIdEstadoTarea_Jsonclick ;
      private String edtEstadoTarea_Internalname ;
      private String A18EstadoTarea ;
      private String edtEstadoTarea_Link ;
      private String edtEstadoTarea_Jsonclick ;
      private String edtIdPadre_Internalname ;
      private String edtIdPadre_Jsonclick ;
      private String edtNombrePadre_Internalname ;
      private String A20NombrePadre ;
      private String edtNombrePadre_Jsonclick ;
      private String edtStatusTarea_Internalname ;
      private String edtStatusTarea_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String hsh ;
      private String sCtrlA5IdTarea ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A23StatusTarea ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n19IdPadre ;
      private bool returnInSub ;
      private GXProperties forbiddenHiddens ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000X2_A5IdTarea ;
      private bool[] H000X2_A23StatusTarea ;
      private String[] H000X2_A20NombrePadre ;
      private short[] H000X2_A19IdPadre ;
      private bool[] H000X2_n19IdPadre ;
      private String[] H000X2_A18EstadoTarea ;
      private short[] H000X2_A17IdEstadoTarea ;
      private String[] H000X2_A10Prioridad ;
      private short[] H000X2_A9IdPrioridad ;
      private String[] H000X2_A14Fase ;
      private short[] H000X2_A13IdFase ;
      private String[] H000X2_A7DescripcionTarea ;
      private String[] H000X2_A6NombreTarea ;
      private String[] H000X2_A2NombreProyecto ;
      private short[] H000X2_A1IdProyecto ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private IGxSession AV9Session ;
      private SdtTransactionContext AV7TrnContext ;
      private SdtTransactionContext_Attribute AV8TrnContextAtt ;
   }

   public class tareageneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000X2 ;
          prmH000X2 = new Object[] {
          new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000X2", "SELECT T1.[IdTarea], T1.[StatusTarea], T2.[NombreTarea] AS NombrePadre, T1.[IdPadre] AS IdPadre, T3.[EstadoTarea], T1.[IdEstadoTarea], T4.[Prioridad], T1.[IdPrioridad], T5.[Fase], T1.[IdFase], T1.[DescripcionTarea], T1.[NombreTarea], T6.[NombreProyecto], T1.[IdProyecto] FROM ((((([Tarea] T1 LEFT JOIN [Tarea] T2 ON T2.[IdTarea] = T1.[IdPadre]) INNER JOIN [EstadoTarea] T3 ON T3.[IdEstadoTarea] = T1.[IdEstadoTarea]) INNER JOIN [Prioridad] T4 ON T4.[IdPrioridad] = T1.[IdPrioridad]) INNER JOIN [Fase] T5 ON T5.[IdFase] = T1.[IdFase]) INNER JOIN [Proyecto] T6 ON T6.[IdProyecto] = T1.[IdProyecto]) WHERE T1.[IdTarea] = @IdTarea ORDER BY T1.[IdTarea] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000X2,1, GxCacheFrequency.OFF ,true,true )
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
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((String[]) buf[7])[0] = rslt.getString(7, 20) ;
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                ((String[]) buf[9])[0] = rslt.getString(9, 20) ;
                ((short[]) buf[10])[0] = rslt.getShort(10) ;
                ((String[]) buf[11])[0] = rslt.getString(11, 60) ;
                ((String[]) buf[12])[0] = rslt.getString(12, 60) ;
                ((String[]) buf[13])[0] = rslt.getString(13, 60) ;
                ((short[]) buf[14])[0] = rslt.getShort(14) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
