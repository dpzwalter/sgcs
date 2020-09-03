/*
               File: GAMExampleSecurityPolicyEntry
        Description: Security Policy
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:7:1.67
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
   public class gamexamplesecuritypolicyentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamexamplesecuritypolicyentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamexamplesecuritypolicyentry( IGxContext context )
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
                           ref long aP1_Id )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV9Id = aP1_Id;
         executePrivate();
         aP0_Gx_mode=this.Gx_mode;
         aP1_Id=this.AV9Id;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavAllowmultipleconcurrentwebsessions = new GXCombobox();
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
                  AV9Id = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "AV9Id", StringUtil.LTrimStr( (decimal)(AV9Id), 12, 0));
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
         PA1D2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1D2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020415117175", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamexamplesecuritypolicyentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV9Id)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "ACTIONSCONTAINER_Class", StringUtil.RTrim( divActionscontainer_Class));
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
            WE1D2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1D2( ) ;
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
         return formatLink("gamexamplesecuritypolicyentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV9Id) ;
      }

      public override String GetPgmname( )
      {
         return "GAMExampleSecurityPolicyEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "Security Policy" ;
      }

      protected void WB1D0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-11 col-sm-offset-1 col-md-10 col-lg-8 col-lg-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPanelname_Internalname, "Security Policy", "", "", lblPanelname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-12 hidden-sm hidden-md hidden-lg", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttShowhide_Internalname, "", "Actions", bttShowhide_Jsonclick, 7, "Actions", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e111d1_client"+"'", TempTags, "", 2, "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-sm-push-9 col-lg-2 col-lg-push-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divActionscontainer_Internalname, divActionscontainer_Visible, 0, "px", 0, "px", divActionscontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableedit_Internalname, divTableedit_Visible, 0, "px", 0, "px", "ActionsContainerItem", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "left", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = "(none)";
            GxWebStd.gx_bitmap( context, imgImage4_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Edit", "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121d1_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleSecurityPolicyEntry.htm");
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
            GxWebStd.gx_div_start( context, divTable5_Internalname, 1, 0, "px", 0, "px", "ActionsContainerItem", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "left", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "014fc44a-5df4-4dab-a62f-c70059b92e11", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImage2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDelete_Internalname, "Delete", "", "", lblDelete_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131d1_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-1 col-sm-pull-3 col-lg-offset-2 col-lg-pull-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavId_Internalname, "Id", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9Id), 12, 0, ".", "")), ((edtavId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9Id), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9Id), "ZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavId_Enabled, 0, "number", "1", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMKeyNumLong", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
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
            GxWebStd.gx_label_element( context, edtavGuid_Internalname, "GUID", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGuid_Internalname, StringUtil.RTrim( AV8GUID), StringUtil.RTrim( context.localUtil.Format( AV8GUID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGuid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGuid_Enabled, 0, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
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
            GxWebStd.gx_label_element( context, edtavName_Internalname, "Name", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV16Name), StringUtil.RTrim( context.localUtil.Format( AV16Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "Middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "ONLY WEB", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavAllowmultipleconcurrentwebsessions_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavAllowmultipleconcurrentwebsessions_Internalname, "Allow multiple concurrent user sessions", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavAllowmultipleconcurrentwebsessions, cmbavAllowmultipleconcurrentwebsessions_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0)), 1, cmbavAllowmultipleconcurrentwebsessions_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavAllowmultipleconcurrentwebsessions.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,58);\"", "", true, "HLP_GAMExampleSecurityPolicyEntry.htm");
            cmbavAllowmultipleconcurrentwebsessions.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0));
            AssignProp("", false, cmbavAllowmultipleconcurrentwebsessions_Internalname, "Values", (String)(cmbavAllowmultipleconcurrentwebsessions.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWebsessiontimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWebsessiontimeout_Internalname, "Session time out (minutes)", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWebsessiontimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21WebSessionTimeOut), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21WebSessionTimeOut), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWebsessiontimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWebsessiontimeout_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "Middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "ONLY REST OAUTH (Mobile, GAMRemoteRest)", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavOauthtokenexpire_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavOauthtokenexpire_Internalname, "Token Expire (minutes)", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOauthtokenexpire_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17OauthTokenExpire), 6, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17OauthTokenExpire), "ZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOauthtokenexpire_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavOauthtokenexpire_Enabled, 1, "number", "1", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavOauthtokenmaximumrenovations_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavOauthtokenmaximumrenovations_Internalname, "Token maximum renovations", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOauthtokenmaximumrenovations_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18OauthTokenMaximumRenovations), 3, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18OauthTokenMaximumRenovations), "ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOauthtokenmaximumrenovations_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavOauthtokenmaximumrenovations_Enabled, 1, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "Middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "GENERAL", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavPeriodchangepassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPeriodchangepassword_Internalname, "Period change password (days)", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPeriodchangepassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19PeriodChangePassword), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19PeriodChangePassword), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPeriodchangepassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavPeriodchangepassword_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavMinimumtimetochangepasswords_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavMinimumtimetochangepasswords_Internalname, "Minimum waiting time between password changes (days)", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMinimumtimetochangepasswords_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14MinimumTimeToChangePasswords), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14MinimumTimeToChangePasswords), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,89);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMinimumtimetochangepasswords_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavMinimumtimetochangepasswords_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavMinimumlengthpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavMinimumlengthpassword_Internalname, "Minimum password length ", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMinimumlengthpassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11MinimumLengthPassword), 2, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11MinimumLengthPassword), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,94);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMinimumlengthpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavMinimumlengthpassword_Enabled, 1, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavMinimumnumericalcharacterpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavMinimumnumericalcharacterpassword_Internalname, "Minumum number of numeric characters in passwords", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMinimumnumericalcharacterpassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12MinimumNumericalCharacterPassword), 2, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12MinimumNumericalCharacterPassword), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMinimumnumericalcharacterpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavMinimumnumericalcharacterpassword_Enabled, 1, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavMinimumuppercasecharacterspassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavMinimumuppercasecharacterspassword_Internalname, "Minimum number of uppercase characters in passwords", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMinimumuppercasecharacterspassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15MinimumUpperCaseCharactersPassword), 2, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV15MinimumUpperCaseCharactersPassword), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMinimumuppercasecharacterspassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavMinimumuppercasecharacterspassword_Enabled, 1, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavMinimumspecialcharacterspassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavMinimumspecialcharacterspassword_Internalname, "Minimum number of special characters in passwords", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMinimumspecialcharacterspassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13MinimumSpecialCharactersPassword), 2, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13MinimumSpecialCharactersPassword), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,109);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMinimumspecialcharacterspassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavMinimumspecialcharacterspassword_Enabled, 1, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavMaximumpasswordhistoryentries_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavMaximumpasswordhistoryentries_Internalname, "Maximum password history entries", "col-sm-6 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMaximumpasswordhistoryentries_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10MaximumPasswordHistoryEntries), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10MaximumPasswordHistoryEntries), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,114);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMaximumpasswordhistoryentries_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavMaximumpasswordhistoryentries_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleSecurityPolicyEntry.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Cancel", bttBtncancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "", bttBtnconfirm_Caption, bttBtnconfirm_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtnconfirm_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1D2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Security Policy", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1D0( ) ;
      }

      protected void WS1D2( )
      {
         START1D2( ) ;
         EVT1D2( ) ;
      }

      protected void EVT1D2( )
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
                              E141D2 ();
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
                                    E151D2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E161D2 ();
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

      protected void WE1D2( )
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

      protected void PA1D2( )
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
         if ( cmbavAllowmultipleconcurrentwebsessions.ItemCount > 0 )
         {
            AV5AllowMultipleConcurrentWebSessions = (short)(NumberUtil.Val( cmbavAllowmultipleconcurrentwebsessions.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0))), "."));
            AssignAttri("", false, "AV5AllowMultipleConcurrentWebSessions", StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavAllowmultipleconcurrentwebsessions.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0));
            AssignProp("", false, cmbavAllowmultipleconcurrentwebsessions_Internalname, "Values", cmbavAllowmultipleconcurrentwebsessions.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1D2( ) ;
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
      }

      protected void RF1D2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E161D2 ();
            WB1D0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1D2( )
      {
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void STRUP1D0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), true);
         edtavGuid_Enabled = 0;
         AssignProp("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGuid_Enabled), 5, 0), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E141D2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            /* Read variables values. */
            AV9Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ","));
            AssignAttri("", false, "AV9Id", StringUtil.LTrimStr( (decimal)(AV9Id), 12, 0));
            AV8GUID = cgiGet( edtavGuid_Internalname);
            AssignAttri("", false, "AV8GUID", AV8GUID);
            AV16Name = cgiGet( edtavName_Internalname);
            AssignAttri("", false, "AV16Name", AV16Name);
            cmbavAllowmultipleconcurrentwebsessions.CurrentValue = cgiGet( cmbavAllowmultipleconcurrentwebsessions_Internalname);
            AV5AllowMultipleConcurrentWebSessions = (short)(NumberUtil.Val( cgiGet( cmbavAllowmultipleconcurrentwebsessions_Internalname), "."));
            AssignAttri("", false, "AV5AllowMultipleConcurrentWebSessions", StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavWebsessiontimeout_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavWebsessiontimeout_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vWEBSESSIONTIMEOUT");
               GX_FocusControl = edtavWebsessiontimeout_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21WebSessionTimeOut = 0;
               AssignAttri("", false, "AV21WebSessionTimeOut", StringUtil.LTrimStr( (decimal)(AV21WebSessionTimeOut), 4, 0));
            }
            else
            {
               AV21WebSessionTimeOut = (short)(context.localUtil.CToN( cgiGet( edtavWebsessiontimeout_Internalname), ".", ","));
               AssignAttri("", false, "AV21WebSessionTimeOut", StringUtil.LTrimStr( (decimal)(AV21WebSessionTimeOut), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOauthtokenexpire_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOauthtokenexpire_Internalname), ".", ",") > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vOAUTHTOKENEXPIRE");
               GX_FocusControl = edtavOauthtokenexpire_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17OauthTokenExpire = 0;
               AssignAttri("", false, "AV17OauthTokenExpire", StringUtil.LTrimStr( (decimal)(AV17OauthTokenExpire), 6, 0));
            }
            else
            {
               AV17OauthTokenExpire = (int)(context.localUtil.CToN( cgiGet( edtavOauthtokenexpire_Internalname), ".", ","));
               AssignAttri("", false, "AV17OauthTokenExpire", StringUtil.LTrimStr( (decimal)(AV17OauthTokenExpire), 6, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOauthtokenmaximumrenovations_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOauthtokenmaximumrenovations_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vOAUTHTOKENMAXIMUMRENOVATIONS");
               GX_FocusControl = edtavOauthtokenmaximumrenovations_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18OauthTokenMaximumRenovations = 0;
               AssignAttri("", false, "AV18OauthTokenMaximumRenovations", StringUtil.LTrimStr( (decimal)(AV18OauthTokenMaximumRenovations), 3, 0));
            }
            else
            {
               AV18OauthTokenMaximumRenovations = (short)(context.localUtil.CToN( cgiGet( edtavOauthtokenmaximumrenovations_Internalname), ".", ","));
               AssignAttri("", false, "AV18OauthTokenMaximumRenovations", StringUtil.LTrimStr( (decimal)(AV18OauthTokenMaximumRenovations), 3, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPeriodchangepassword_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPeriodchangepassword_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPERIODCHANGEPASSWORD");
               GX_FocusControl = edtavPeriodchangepassword_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19PeriodChangePassword = 0;
               AssignAttri("", false, "AV19PeriodChangePassword", StringUtil.LTrimStr( (decimal)(AV19PeriodChangePassword), 4, 0));
            }
            else
            {
               AV19PeriodChangePassword = (short)(context.localUtil.CToN( cgiGet( edtavPeriodchangepassword_Internalname), ".", ","));
               AssignAttri("", false, "AV19PeriodChangePassword", StringUtil.LTrimStr( (decimal)(AV19PeriodChangePassword), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMinimumtimetochangepasswords_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMinimumtimetochangepasswords_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMINIMUMTIMETOCHANGEPASSWORDS");
               GX_FocusControl = edtavMinimumtimetochangepasswords_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14MinimumTimeToChangePasswords = 0;
               AssignAttri("", false, "AV14MinimumTimeToChangePasswords", StringUtil.LTrimStr( (decimal)(AV14MinimumTimeToChangePasswords), 4, 0));
            }
            else
            {
               AV14MinimumTimeToChangePasswords = (short)(context.localUtil.CToN( cgiGet( edtavMinimumtimetochangepasswords_Internalname), ".", ","));
               AssignAttri("", false, "AV14MinimumTimeToChangePasswords", StringUtil.LTrimStr( (decimal)(AV14MinimumTimeToChangePasswords), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMinimumlengthpassword_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMinimumlengthpassword_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMINIMUMLENGTHPASSWORD");
               GX_FocusControl = edtavMinimumlengthpassword_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11MinimumLengthPassword = 0;
               AssignAttri("", false, "AV11MinimumLengthPassword", StringUtil.LTrimStr( (decimal)(AV11MinimumLengthPassword), 2, 0));
            }
            else
            {
               AV11MinimumLengthPassword = (short)(context.localUtil.CToN( cgiGet( edtavMinimumlengthpassword_Internalname), ".", ","));
               AssignAttri("", false, "AV11MinimumLengthPassword", StringUtil.LTrimStr( (decimal)(AV11MinimumLengthPassword), 2, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMinimumnumericalcharacterpassword_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMinimumnumericalcharacterpassword_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMINIMUMNUMERICALCHARACTERPASSWORD");
               GX_FocusControl = edtavMinimumnumericalcharacterpassword_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12MinimumNumericalCharacterPassword = 0;
               AssignAttri("", false, "AV12MinimumNumericalCharacterPassword", StringUtil.LTrimStr( (decimal)(AV12MinimumNumericalCharacterPassword), 2, 0));
            }
            else
            {
               AV12MinimumNumericalCharacterPassword = (short)(context.localUtil.CToN( cgiGet( edtavMinimumnumericalcharacterpassword_Internalname), ".", ","));
               AssignAttri("", false, "AV12MinimumNumericalCharacterPassword", StringUtil.LTrimStr( (decimal)(AV12MinimumNumericalCharacterPassword), 2, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMinimumuppercasecharacterspassword_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMinimumuppercasecharacterspassword_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMINIMUMUPPERCASECHARACTERSPASSWORD");
               GX_FocusControl = edtavMinimumuppercasecharacterspassword_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15MinimumUpperCaseCharactersPassword = 0;
               AssignAttri("", false, "AV15MinimumUpperCaseCharactersPassword", StringUtil.LTrimStr( (decimal)(AV15MinimumUpperCaseCharactersPassword), 2, 0));
            }
            else
            {
               AV15MinimumUpperCaseCharactersPassword = (short)(context.localUtil.CToN( cgiGet( edtavMinimumuppercasecharacterspassword_Internalname), ".", ","));
               AssignAttri("", false, "AV15MinimumUpperCaseCharactersPassword", StringUtil.LTrimStr( (decimal)(AV15MinimumUpperCaseCharactersPassword), 2, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMinimumspecialcharacterspassword_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMinimumspecialcharacterspassword_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMINIMUMSPECIALCHARACTERSPASSWORD");
               GX_FocusControl = edtavMinimumspecialcharacterspassword_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13MinimumSpecialCharactersPassword = 0;
               AssignAttri("", false, "AV13MinimumSpecialCharactersPassword", StringUtil.LTrimStr( (decimal)(AV13MinimumSpecialCharactersPassword), 2, 0));
            }
            else
            {
               AV13MinimumSpecialCharactersPassword = (short)(context.localUtil.CToN( cgiGet( edtavMinimumspecialcharacterspassword_Internalname), ".", ","));
               AssignAttri("", false, "AV13MinimumSpecialCharactersPassword", StringUtil.LTrimStr( (decimal)(AV13MinimumSpecialCharactersPassword), 2, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMaximumpasswordhistoryentries_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMaximumpasswordhistoryentries_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMAXIMUMPASSWORDHISTORYENTRIES");
               GX_FocusControl = edtavMaximumpasswordhistoryentries_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10MaximumPasswordHistoryEntries = 0;
               AssignAttri("", false, "AV10MaximumPasswordHistoryEntries", StringUtil.LTrimStr( (decimal)(AV10MaximumPasswordHistoryEntries), 4, 0));
            }
            else
            {
               AV10MaximumPasswordHistoryEntries = (short)(context.localUtil.CToN( cgiGet( edtavMaximumpasswordhistoryentries_Internalname), ".", ","));
               AssignAttri("", false, "AV10MaximumPasswordHistoryEntries", StringUtil.LTrimStr( (decimal)(AV10MaximumPasswordHistoryEntries), 4, 0));
            }
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
         E141D2 ();
         if (returnInSub) return;
      }

      protected void E141D2( )
      {
         /* Start Routine */
         divTableedit_Visible = 0;
         AssignProp("", false, divTableedit_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTableedit_Visible), 5, 0), true);
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            AV20SecurityPolicy.load( (int)(AV9Id));
            AssignAttri("", false, "AV9Id", StringUtil.LTrimStr( (decimal)(AV9Id), 12, 0));
            AV9Id = AV20SecurityPolicy.gxTpr_Id;
            AssignAttri("", false, "AV9Id", StringUtil.LTrimStr( (decimal)(AV9Id), 12, 0));
            AV8GUID = AV20SecurityPolicy.gxTpr_Guid;
            AssignAttri("", false, "AV8GUID", AV8GUID);
            AV16Name = AV20SecurityPolicy.gxTpr_Name;
            AssignAttri("", false, "AV16Name", AV16Name);
            AV5AllowMultipleConcurrentWebSessions = AV20SecurityPolicy.gxTpr_Allowmultipleconcurrentwebsessions;
            AssignAttri("", false, "AV5AllowMultipleConcurrentWebSessions", StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0));
            AV21WebSessionTimeOut = AV20SecurityPolicy.gxTpr_Websessiontimeout;
            AssignAttri("", false, "AV21WebSessionTimeOut", StringUtil.LTrimStr( (decimal)(AV21WebSessionTimeOut), 4, 0));
            AV17OauthTokenExpire = AV20SecurityPolicy.gxTpr_Oauthtokenexpire;
            AssignAttri("", false, "AV17OauthTokenExpire", StringUtil.LTrimStr( (decimal)(AV17OauthTokenExpire), 6, 0));
            AV18OauthTokenMaximumRenovations = AV20SecurityPolicy.gxTpr_Oauthtokenmaximumrenovations;
            AssignAttri("", false, "AV18OauthTokenMaximumRenovations", StringUtil.LTrimStr( (decimal)(AV18OauthTokenMaximumRenovations), 3, 0));
            AV19PeriodChangePassword = AV20SecurityPolicy.gxTpr_Periodchangepassword;
            AssignAttri("", false, "AV19PeriodChangePassword", StringUtil.LTrimStr( (decimal)(AV19PeriodChangePassword), 4, 0));
            AV14MinimumTimeToChangePasswords = AV20SecurityPolicy.gxTpr_Minimumtimetochangepasswords;
            AssignAttri("", false, "AV14MinimumTimeToChangePasswords", StringUtil.LTrimStr( (decimal)(AV14MinimumTimeToChangePasswords), 4, 0));
            AV11MinimumLengthPassword = AV20SecurityPolicy.gxTpr_Minimumlengthpassword;
            AssignAttri("", false, "AV11MinimumLengthPassword", StringUtil.LTrimStr( (decimal)(AV11MinimumLengthPassword), 2, 0));
            AV12MinimumNumericalCharacterPassword = AV20SecurityPolicy.gxTpr_Minimumnumericcharacterspassword;
            AssignAttri("", false, "AV12MinimumNumericalCharacterPassword", StringUtil.LTrimStr( (decimal)(AV12MinimumNumericalCharacterPassword), 2, 0));
            AV15MinimumUpperCaseCharactersPassword = AV20SecurityPolicy.gxTpr_Minimumuppercasecharacterspassword;
            AssignAttri("", false, "AV15MinimumUpperCaseCharactersPassword", StringUtil.LTrimStr( (decimal)(AV15MinimumUpperCaseCharactersPassword), 2, 0));
            AV13MinimumSpecialCharactersPassword = AV20SecurityPolicy.gxTpr_Minimumspecialcharacterspassword;
            AssignAttri("", false, "AV13MinimumSpecialCharactersPassword", StringUtil.LTrimStr( (decimal)(AV13MinimumSpecialCharactersPassword), 2, 0));
            AV10MaximumPasswordHistoryEntries = AV20SecurityPolicy.gxTpr_Maximumpasswordhistoryentries;
            AssignAttri("", false, "AV10MaximumPasswordHistoryEntries", StringUtil.LTrimStr( (decimal)(AV10MaximumPasswordHistoryEntries), 4, 0));
            if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
            {
               if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
               {
                  bttBtnconfirm_Visible = 0;
                  AssignProp("", false, bttBtnconfirm_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtnconfirm_Visible), 5, 0), true);
                  divTableedit_Visible = 1;
                  AssignProp("", false, divTableedit_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTableedit_Visible), 5, 0), true);
               }
               edtavName_Enabled = 0;
               AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
               cmbavAllowmultipleconcurrentwebsessions.Enabled = 0;
               AssignProp("", false, cmbavAllowmultipleconcurrentwebsessions_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavAllowmultipleconcurrentwebsessions.Enabled), 5, 0), true);
               edtavWebsessiontimeout_Enabled = 0;
               AssignProp("", false, edtavWebsessiontimeout_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavWebsessiontimeout_Enabled), 5, 0), true);
               edtavOauthtokenexpire_Enabled = 0;
               AssignProp("", false, edtavOauthtokenexpire_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavOauthtokenexpire_Enabled), 5, 0), true);
               edtavOauthtokenmaximumrenovations_Enabled = 0;
               AssignProp("", false, edtavOauthtokenmaximumrenovations_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavOauthtokenmaximumrenovations_Enabled), 5, 0), true);
               edtavPeriodchangepassword_Enabled = 0;
               AssignProp("", false, edtavPeriodchangepassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavPeriodchangepassword_Enabled), 5, 0), true);
               edtavMinimumtimetochangepasswords_Enabled = 0;
               AssignProp("", false, edtavMinimumtimetochangepasswords_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavMinimumtimetochangepasswords_Enabled), 5, 0), true);
               edtavMinimumlengthpassword_Enabled = 0;
               AssignProp("", false, edtavMinimumlengthpassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavMinimumlengthpassword_Enabled), 5, 0), true);
               edtavMinimumnumericalcharacterpassword_Enabled = 0;
               AssignProp("", false, edtavMinimumnumericalcharacterpassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavMinimumnumericalcharacterpassword_Enabled), 5, 0), true);
               edtavMinimumuppercasecharacterspassword_Enabled = 0;
               AssignProp("", false, edtavMinimumuppercasecharacterspassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavMinimumuppercasecharacterspassword_Enabled), 5, 0), true);
               edtavMinimumspecialcharacterspassword_Enabled = 0;
               AssignProp("", false, edtavMinimumspecialcharacterspassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavMinimumspecialcharacterspassword_Enabled), 5, 0), true);
               edtavMaximumpasswordhistoryentries_Enabled = 0;
               AssignProp("", false, edtavMaximumpasswordhistoryentries_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavMaximumpasswordhistoryentries_Enabled), 5, 0), true);
               bttBtnconfirm_Caption = "Delete";
               AssignProp("", false, bttBtnconfirm_Internalname, "Caption", bttBtnconfirm_Caption, true);
            }
         }
         else
         {
            divActionscontainer_Visible = 0;
            AssignProp("", false, divActionscontainer_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divActionscontainer_Visible), 5, 0), true);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E151D2 ();
         if (returnInSub) return;
      }

      protected void E151D2( )
      {
         /* Enter Routine */
         AV20SecurityPolicy.gxTpr_Id = (int)(AV9Id);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
            {
               AV20SecurityPolicy.load( (int)(AV9Id));
               AssignAttri("", false, "AV9Id", StringUtil.LTrimStr( (decimal)(AV9Id), 12, 0));
            }
            AV20SecurityPolicy.gxTpr_Name = AV16Name;
            AV20SecurityPolicy.gxTpr_Allowmultipleconcurrentwebsessions = AV5AllowMultipleConcurrentWebSessions;
            AV20SecurityPolicy.gxTpr_Websessiontimeout = AV21WebSessionTimeOut;
            AV20SecurityPolicy.gxTpr_Oauthtokenexpire = AV17OauthTokenExpire;
            AV20SecurityPolicy.gxTpr_Oauthtokenmaximumrenovations = AV18OauthTokenMaximumRenovations;
            AV20SecurityPolicy.gxTpr_Periodchangepassword = AV19PeriodChangePassword;
            AV20SecurityPolicy.gxTpr_Minimumtimetochangepasswords = AV14MinimumTimeToChangePasswords;
            AV20SecurityPolicy.gxTpr_Minimumlengthpassword = AV11MinimumLengthPassword;
            AV20SecurityPolicy.gxTpr_Minimumnumericcharacterspassword = AV12MinimumNumericalCharacterPassword;
            AV20SecurityPolicy.gxTpr_Minimumuppercasecharacterspassword = AV15MinimumUpperCaseCharactersPassword;
            AV20SecurityPolicy.gxTpr_Minimumspecialcharacterspassword = AV13MinimumSpecialCharactersPassword;
            AV20SecurityPolicy.gxTpr_Maximumpasswordhistoryentries = AV10MaximumPasswordHistoryEntries;
            AV20SecurityPolicy.save();
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV20SecurityPolicy.load( (int)(AV9Id));
            AssignAttri("", false, "AV9Id", StringUtil.LTrimStr( (decimal)(AV9Id), 12, 0));
            AV20SecurityPolicy.delete();
         }
         if ( AV20SecurityPolicy.success() )
         {
            context.CommitDataStores("gamexamplesecuritypolicyentry",pr_default);
            CallWebObject(formatLink("gamexamplewwsecuritypolicies.aspx") );
            context.wjLocDisableFrm = 1;
         }
         else
         {
            AV7Errors = AV20SecurityPolicy.geterrors();
            AV25GXV1 = 1;
            while ( AV25GXV1 <= AV7Errors.Count )
            {
               AV6Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV7Errors.Item(AV25GXV1));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV6Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV6Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV25GXV1 = (int)(AV25GXV1+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20SecurityPolicy", AV20SecurityPolicy);
      }

      protected void nextLoad( )
      {
      }

      protected void E161D2( )
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
         AV9Id = Convert.ToInt64(getParm(obj,1));
         AssignAttri("", false, "AV9Id", StringUtil.LTrimStr( (decimal)(AV9Id), 12, 0));
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
         PA1D2( ) ;
         WS1D2( ) ;
         WE1D2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202041511732", true, true);
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
         context.AddJavascriptSource("gamexamplesecuritypolicyentry.js", "?202041511733", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbavAllowmultipleconcurrentwebsessions.Name = "vALLOWMULTIPLECONCURRENTWEBSESSIONS";
         cmbavAllowmultipleconcurrentwebsessions.WebTags = "";
         cmbavAllowmultipleconcurrentwebsessions.addItem("1", "Yes, from different IP address", 0);
         cmbavAllowmultipleconcurrentwebsessions.addItem("2", "Yes, from same IP address", 0);
         cmbavAllowmultipleconcurrentwebsessions.addItem("3", "No", 0);
         if ( cmbavAllowmultipleconcurrentwebsessions.ItemCount > 0 )
         {
            AV5AllowMultipleConcurrentWebSessions = (short)(NumberUtil.Val( cmbavAllowmultipleconcurrentwebsessions.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0))), "."));
            AssignAttri("", false, "AV5AllowMultipleConcurrentWebSessions", StringUtil.Str( (decimal)(AV5AllowMultipleConcurrentWebSessions), 1, 0));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblPanelname_Internalname = "PANELNAME";
         bttShowhide_Internalname = "SHOWHIDE";
         divTable1_Internalname = "TABLE1";
         imgImage4_Internalname = "IMAGE4";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         divTableedit_Internalname = "TABLEEDIT";
         imgImage2_Internalname = "IMAGE2";
         lblDelete_Internalname = "DELETE";
         divTable5_Internalname = "TABLE5";
         divActionscontainer_Internalname = "ACTIONSCONTAINER";
         edtavId_Internalname = "vID";
         edtavGuid_Internalname = "vGUID";
         edtavName_Internalname = "vNAME";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         cmbavAllowmultipleconcurrentwebsessions_Internalname = "vALLOWMULTIPLECONCURRENTWEBSESSIONS";
         edtavWebsessiontimeout_Internalname = "vWEBSESSIONTIMEOUT";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         edtavOauthtokenexpire_Internalname = "vOAUTHTOKENEXPIRE";
         edtavOauthtokenmaximumrenovations_Internalname = "vOAUTHTOKENMAXIMUMRENOVATIONS";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         edtavPeriodchangepassword_Internalname = "vPERIODCHANGEPASSWORD";
         edtavMinimumtimetochangepasswords_Internalname = "vMINIMUMTIMETOCHANGEPASSWORDS";
         edtavMinimumlengthpassword_Internalname = "vMINIMUMLENGTHPASSWORD";
         edtavMinimumnumericalcharacterpassword_Internalname = "vMINIMUMNUMERICALCHARACTERPASSWORD";
         edtavMinimumuppercasecharacterspassword_Internalname = "vMINIMUMUPPERCASECHARACTERSPASSWORD";
         edtavMinimumspecialcharacterspassword_Internalname = "vMINIMUMSPECIALCHARACTERSPASSWORD";
         edtavMaximumpasswordhistoryentries_Internalname = "vMAXIMUMPASSWORDHISTORYENTRIES";
         divTable2_Internalname = "TABLE2";
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
         bttBtnconfirm_Caption = "Confirm";
         bttBtnconfirm_Visible = 1;
         edtavMaximumpasswordhistoryentries_Jsonclick = "";
         edtavMaximumpasswordhistoryentries_Enabled = 1;
         edtavMinimumspecialcharacterspassword_Jsonclick = "";
         edtavMinimumspecialcharacterspassword_Enabled = 1;
         edtavMinimumuppercasecharacterspassword_Jsonclick = "";
         edtavMinimumuppercasecharacterspassword_Enabled = 1;
         edtavMinimumnumericalcharacterpassword_Jsonclick = "";
         edtavMinimumnumericalcharacterpassword_Enabled = 1;
         edtavMinimumlengthpassword_Jsonclick = "";
         edtavMinimumlengthpassword_Enabled = 1;
         edtavMinimumtimetochangepasswords_Jsonclick = "";
         edtavMinimumtimetochangepasswords_Enabled = 1;
         edtavPeriodchangepassword_Jsonclick = "";
         edtavPeriodchangepassword_Enabled = 1;
         edtavOauthtokenmaximumrenovations_Jsonclick = "";
         edtavOauthtokenmaximumrenovations_Enabled = 1;
         edtavOauthtokenexpire_Jsonclick = "";
         edtavOauthtokenexpire_Enabled = 1;
         edtavWebsessiontimeout_Jsonclick = "";
         edtavWebsessiontimeout_Enabled = 1;
         cmbavAllowmultipleconcurrentwebsessions_Jsonclick = "";
         cmbavAllowmultipleconcurrentwebsessions.Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 1;
         edtavGuid_Jsonclick = "";
         edtavGuid_Enabled = 1;
         edtavId_Jsonclick = "";
         edtavId_Enabled = 0;
         lblDelete_Jsonclick = "";
         divTableedit_Visible = 1;
         divActionscontainer_Visible = 1;
         divActionscontainer_Class = "ActionsContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Security Policy";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E151D2',iparms:[{av:'AV9Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV16Name',fld:'vNAME',pic:''},{av:'cmbavAllowmultipleconcurrentwebsessions'},{av:'AV5AllowMultipleConcurrentWebSessions',fld:'vALLOWMULTIPLECONCURRENTWEBSESSIONS',pic:'9'},{av:'AV21WebSessionTimeOut',fld:'vWEBSESSIONTIMEOUT',pic:'ZZZ9'},{av:'AV17OauthTokenExpire',fld:'vOAUTHTOKENEXPIRE',pic:'ZZZZZ9'},{av:'AV18OauthTokenMaximumRenovations',fld:'vOAUTHTOKENMAXIMUMRENOVATIONS',pic:'ZZ9'},{av:'AV19PeriodChangePassword',fld:'vPERIODCHANGEPASSWORD',pic:'ZZZ9'},{av:'AV14MinimumTimeToChangePasswords',fld:'vMINIMUMTIMETOCHANGEPASSWORDS',pic:'ZZZ9'},{av:'AV11MinimumLengthPassword',fld:'vMINIMUMLENGTHPASSWORD',pic:'Z9'},{av:'AV12MinimumNumericalCharacterPassword',fld:'vMINIMUMNUMERICALCHARACTERPASSWORD',pic:'Z9'},{av:'AV15MinimumUpperCaseCharactersPassword',fld:'vMINIMUMUPPERCASECHARACTERSPASSWORD',pic:'Z9'},{av:'AV13MinimumSpecialCharactersPassword',fld:'vMINIMUMSPECIALCHARACTERSPASSWORD',pic:'Z9'},{av:'AV10MaximumPasswordHistoryEntries',fld:'vMAXIMUMPASSWORDHISTORYENTRIES',pic:'ZZZ9'}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("'DELETE'","{handler:'E131D1',iparms:[{av:'AV9Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("'DELETE'",",oparms:[{av:'AV9Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]}");
         setEventMetadata("'EDIT'","{handler:'E121D1',iparms:[{av:'AV9Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]");
         setEventMetadata("'EDIT'",",oparms:[{av:'AV9Id',fld:'vID',pic:'ZZZZZZZZZZZ9'}]}");
         setEventMetadata("'SHOWHIDE'","{handler:'E111D1',iparms:[{av:'divActionscontainer_Class',ctrl:'ACTIONSCONTAINER',prop:'Class'}]");
         setEventMetadata("'SHOWHIDE'",",oparms:[{av:'divActionscontainer_Class',ctrl:'ACTIONSCONTAINER',prop:'Class'}]}");
         setEventMetadata("VALIDV_ALLOWMULTIPLECONCURRENTWEBSESSIONS","{handler:'Validv_Allowmultipleconcurrentwebsessions',iparms:[]");
         setEventMetadata("VALIDV_ALLOWMULTIPLECONCURRENTWEBSESSIONS",",oparms:[]}");
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
         lblPanelname_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttShowhide_Jsonclick = "";
         sImgUrl = "";
         lblTextblock4_Jsonclick = "";
         AV8GUID = "";
         AV16Name = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         bttBtnconfirm_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV20SecurityPolicy = new GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy(context);
         AV7Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV6Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamexamplesecuritypolicyentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamexamplesecuritypolicyentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         edtavGuid_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short AV5AllowMultipleConcurrentWebSessions ;
      private short AV21WebSessionTimeOut ;
      private short AV18OauthTokenMaximumRenovations ;
      private short AV19PeriodChangePassword ;
      private short AV14MinimumTimeToChangePasswords ;
      private short AV11MinimumLengthPassword ;
      private short AV12MinimumNumericalCharacterPassword ;
      private short AV15MinimumUpperCaseCharactersPassword ;
      private short AV13MinimumSpecialCharactersPassword ;
      private short AV10MaximumPasswordHistoryEntries ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int divActionscontainer_Visible ;
      private int divTableedit_Visible ;
      private int edtavId_Enabled ;
      private int edtavGuid_Enabled ;
      private int edtavName_Enabled ;
      private int edtavWebsessiontimeout_Enabled ;
      private int AV17OauthTokenExpire ;
      private int edtavOauthtokenexpire_Enabled ;
      private int edtavOauthtokenmaximumrenovations_Enabled ;
      private int edtavPeriodchangepassword_Enabled ;
      private int edtavMinimumtimetochangepasswords_Enabled ;
      private int edtavMinimumlengthpassword_Enabled ;
      private int edtavMinimumnumericalcharacterpassword_Enabled ;
      private int edtavMinimumuppercasecharacterspassword_Enabled ;
      private int edtavMinimumspecialcharacterspassword_Enabled ;
      private int edtavMaximumpasswordhistoryentries_Enabled ;
      private int bttBtnconfirm_Visible ;
      private int AV25GXV1 ;
      private int idxLst ;
      private long AV9Id ;
      private long wcpOAV9Id ;
      private String Gx_mode ;
      private String wcpOGx_mode ;
      private String divActionscontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String lblPanelname_Internalname ;
      private String lblPanelname_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttShowhide_Internalname ;
      private String bttShowhide_Jsonclick ;
      private String divActionscontainer_Internalname ;
      private String divTableedit_Internalname ;
      private String sImgUrl ;
      private String imgImage4_Internalname ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String divTable5_Internalname ;
      private String imgImage2_Internalname ;
      private String lblDelete_Internalname ;
      private String lblDelete_Jsonclick ;
      private String divTable2_Internalname ;
      private String edtavId_Internalname ;
      private String edtavId_Jsonclick ;
      private String edtavGuid_Internalname ;
      private String AV8GUID ;
      private String edtavGuid_Jsonclick ;
      private String edtavName_Internalname ;
      private String AV16Name ;
      private String edtavName_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String cmbavAllowmultipleconcurrentwebsessions_Internalname ;
      private String cmbavAllowmultipleconcurrentwebsessions_Jsonclick ;
      private String edtavWebsessiontimeout_Internalname ;
      private String edtavWebsessiontimeout_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavOauthtokenexpire_Internalname ;
      private String edtavOauthtokenexpire_Jsonclick ;
      private String edtavOauthtokenmaximumrenovations_Internalname ;
      private String edtavOauthtokenmaximumrenovations_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavPeriodchangepassword_Internalname ;
      private String edtavPeriodchangepassword_Jsonclick ;
      private String edtavMinimumtimetochangepasswords_Internalname ;
      private String edtavMinimumtimetochangepasswords_Jsonclick ;
      private String edtavMinimumlengthpassword_Internalname ;
      private String edtavMinimumlengthpassword_Jsonclick ;
      private String edtavMinimumnumericalcharacterpassword_Internalname ;
      private String edtavMinimumnumericalcharacterpassword_Jsonclick ;
      private String edtavMinimumuppercasecharacterspassword_Internalname ;
      private String edtavMinimumuppercasecharacterspassword_Jsonclick ;
      private String edtavMinimumspecialcharacterspassword_Internalname ;
      private String edtavMinimumspecialcharacterspassword_Jsonclick ;
      private String edtavMaximumpasswordhistoryentries_Internalname ;
      private String edtavMaximumpasswordhistoryentries_Jsonclick ;
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
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private String aP0_Gx_mode ;
      private long aP1_Id ;
      private GXCombobox cmbavAllowmultipleconcurrentwebsessions ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV7Errors ;
      private GXWebForm Form ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV6Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy AV20SecurityPolicy ;
   }

   public class gamexamplesecuritypolicyentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamexamplesecuritypolicyentry__default : DataStoreHelperBase, IDataStoreHelper
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
