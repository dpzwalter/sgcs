/*
               File: GAMExampleApplicationEntry
        Description: Application
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:9:49.8
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
   public class gamexampleapplicationentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamexampleapplicationentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamexampleapplicationentry( IGxContext context )
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
         this.AV42Id = aP1_Id;
         executePrivate();
         aP0_Gx_mode=this.Gx_mode;
         aP1_Id=this.AV42Id;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavUseabsoluteurlbyenvironment = new GXCheckbox();
         cmbavMainmenu = new GXCombobox();
         chkavAccessrequirespermission = new GXCheckbox();
         chkavClientallowremoteauth = new GXCheckbox();
         chkavClientallowgetuserroles = new GXCheckbox();
         chkavClientallowgetuseradddata = new GXCheckbox();
         chkavClientallowgetsessioniniprop = new GXCheckbox();
         chkavClientallowremoterestauth = new GXCheckbox();
         chkavClientallowgetuserrolesrest = new GXCheckbox();
         chkavClientallowgetuseradddatarest = new GXCheckbox();
         chkavClientallowgetsessioniniproprest = new GXCheckbox();
         chkavClientaccessuniquebyuser = new GXCheckbox();
         chkavStsprotocolenable = new GXCheckbox();
         cmbavStsmode = new GXCombobox();
         chkavEnvironmentsecureprotocol = new GXCheckbox();
         chkavAutoregisteranomymoususer = new GXCheckbox();
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
                  AV42Id = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "AV42Id", StringUtil.LTrimStr( (decimal)(AV42Id), 12, 0));
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
         PA222( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START222( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20204151194969", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 138086), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamexampleapplicationentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV42Id)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "TAB2_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab2_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB2_Class", StringUtil.RTrim( Tab2_Class));
         GxWebStd.gx_hidden_field( context, "TAB2_Historymanagement", StringUtil.BoolToStr( Tab2_Historymanagement));
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
            WE222( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT222( ) ;
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
         return formatLink("gamexampleapplicationentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV42Id) ;
      }

      public override String GetPgmname( )
      {
         return "GAMExampleApplicationEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "Application" ;
      }

      protected void WB220( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10 col-sm-offset-1 col-lg-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7 col-sm-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Application", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5 col-sm-12 hidden-sm hidden-md hidden-lg", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttShowhide_Internalname, "", "Actions", bttShowhide_Jsonclick, 7, "Actions", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e11221_client"+"'", TempTags, "", 2, "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-sm-push-9", "left", "top", "", "", "div");
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
            sImgUrl = (String)(context.GetImagePath( "cbd11b4c-4489-4259-ab98-efb5a708cb2c", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Edit", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12221_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_div_start( context, divTable6_Internalname, 1, 0, "px", 0, "px", "ActionsContainerItem", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "left", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "baac128e-62aa-4a75-8034-3bc742d1fc6c", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImageprm_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPermissions_Internalname, "Permissions", "", "", lblPermissions_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13221_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "ActionsContainerItem", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "left", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "c6f2be06-b81b-4875-8b52-aa40300ba5b9", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImagemenu_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblMenus_Internalname, "Menus", "", "", lblMenus_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14221_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_div_start( context, divTable7_Internalname, 1, 0, "px", 0, "px", "ActionsContainerItem", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "left", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = imgImagerevoke_Bitmap;
            GxWebStd.gx_bitmap( context, imgImagerevoke_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblApplicationstatus_Internalname, lblApplicationstatus_Caption, "", "", lblApplicationstatus_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REVOKE-AUTHORIZE\\'."+"'", "", "ActionText TextLikeLink", 5, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_bitmap( context, imgImagedlt_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDeleteapp_Internalname, "Delete Application", "", "", lblDeleteapp_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15221_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-1 col-sm-pull-3", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTab2.SetProperty("PageCount", Tab2_Pagecount);
            ucTab2.SetProperty("Class", Tab2_Class);
            ucTab2.SetProperty("HistoryManagement", Tab2_Historymanagement);
            ucTab2.Render(context, "tab", Tab2_Internalname, "TAB2Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42Id), 12, 0, ".", "")), ((edtavId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV42Id), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV42Id), "ZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavId_Enabled, 0, "number", "1", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMKeyNumLong", "right", false, "", "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_label_element( context, edtavGuid_Internalname, "GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGuid_Internalname, StringUtil.RTrim( AV40GUID), StringUtil.RTrim( context.localUtil.Format( AV40GUID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGuid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGuid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMGUID", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV48Name), StringUtil.RTrim( context.localUtil.Format( AV48Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDsc_Internalname, StringUtil.RTrim( AV29Dsc), StringUtil.RTrim( context.localUtil.Format( AV29Dsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDsc_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVersion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVersion_Internalname, "Version", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVersion_Internalname, StringUtil.RTrim( AV62Version), StringUtil.RTrim( context.localUtil.Format( AV62Version, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,89);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVersion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavVersion_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCompany_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCompany_Internalname, "Company", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCompany_Internalname, StringUtil.RTrim( AV27Company), StringUtil.RTrim( context.localUtil.Format( AV27Company, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,94);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCompany_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCompany_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCopyright_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCopyright_Internalname, "Copyright", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCopyright_Internalname, StringUtil.RTrim( AV28Copyright), StringUtil.RTrim( context.localUtil.Format( AV28Copyright, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCopyright_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCopyright_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUseabsoluteurlbyenvironment_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUseabsoluteurlbyenvironment_Internalname, "Use absolute URL by Environment", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUseabsoluteurlbyenvironment_Internalname, StringUtil.BoolToStr( AV59UseAbsoluteUrlByEnvironment), "", "Use absolute URL by Environment", 1, chkavUseabsoluteurlbyenvironment.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(104, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,104);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavHomeobject_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavHomeobject_Internalname, "Home Object", "col-sm-3 URLAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavHomeobject_Internalname, AV41HomeObject, StringUtil.RTrim( context.localUtil.Format( AV41HomeObject, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,109);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavHomeobject_Jsonclick, 0, "URLAttribute", "", "", "", "", 1, edtavHomeobject_Enabled, 1, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavLogoutobject_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavLogoutobject_Internalname, "Local Logout Object (specify an object or a URL)", "col-sm-3 URLAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavLogoutobject_Internalname, AV44LogoutObject, StringUtil.RTrim( context.localUtil.Format( AV44LogoutObject, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,114);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavLogoutobject_Jsonclick, 0, "URLAttribute", "", "", "", "", 1, edtavLogoutobject_Enabled, 1, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavMainmenu_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavMainmenu_Internalname, "Main Menu", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavMainmenu, cmbavMainmenu_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV45MainMenu), 12, 0)), 1, cmbavMainmenu_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavMainmenu.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,119);\"", "", true, "HLP_GAMExampleApplicationEntry.htm");
            cmbavMainmenu.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV45MainMenu), 12, 0));
            AssignProp("", false, cmbavMainmenu_Internalname, "Values", (String)(cmbavMainmenu.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientrevoked_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientrevoked_Internalname, "Revoked", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavClientrevoked_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavClientrevoked_Internalname, context.localUtil.TToC( AV25ClientRevoked, 10, 8, 1, 2, "/", ":", " "), context.localUtil.Format( AV25ClientRevoked, "99/99/9999 99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'MDY',5,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'MDY',5,12,'eng',false,0);"+";gx.evt.onblur(this,124);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientrevoked_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientrevoked_Enabled, 1, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMDateTime", "right", false, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_bitmap( context, edtavClientrevoked_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavClientrevoked_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_GAMExampleApplicationEntry.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavAccessrequirespermission_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavAccessrequirespermission_Internalname, "Requires Permissions?", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavAccessrequirespermission_Internalname, StringUtil.BoolToStr( AV5AccessRequiresPermission), "", "Requires Permissions?", 1, chkavAccessrequirespermission.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(129, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,129);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpage3_title_Internalname, "Remote Authentication", "", "", lblTabpage3_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPage3") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage3table_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientid_Internalname, "Client ID", "col-sm-3 col-lg-4 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-lg-8 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientid_Internalname, StringUtil.RTrim( AV21ClientId), StringUtil.RTrim( context.localUtil.Format( AV21ClientId, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,139);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMClientApplicationId", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_label_element( context, edtavClientsecret_Internalname, "Client secret", "col-sm-3 col-lg-4 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-lg-8 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 144,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientsecret_Internalname, StringUtil.RTrim( AV26ClientSecret), StringUtil.RTrim( context.localUtil.Format( AV26ClientSecret, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,144);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientsecret_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientsecret_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMClientApplicationSecret", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "WEB (Identity Provider, SSO)", "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAllowcell_Internalname, 1, 0, "px", 0, "px", divAllowcell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowremoteauth_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowremoteauth_Internalname, "Allow authentication?", "col-sm-3 col-lg-4 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-lg-8 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowremoteauth_Internalname, StringUtil.BoolToStr( AV17ClientAllowRemoteAuth), "", "Allow authentication?", 1, chkavClientallowremoteauth.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onblur=\""+""+";gx.evt.onblur(this,152);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTblwebauth_Internalname, divTblwebauth_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowgetuserroles_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowgetuserroles_Internalname, "Can get user roles?", "col-sm-4 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 160,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowgetuserroles_Internalname, StringUtil.BoolToStr( AV15ClientAllowGetUserRoles), "", "Can get user roles?", 1, chkavClientallowgetuserroles.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(160, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,160);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowgetuseradddata_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowgetuseradddata_Internalname, "Can get user additional data?", "col-sm-4 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 165,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowgetuseradddata_Internalname, StringUtil.BoolToStr( AV13ClientAllowGetUserAddData), "", "Can get user additional data?", 1, chkavClientallowgetuseradddata.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(165, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,165);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowgetsessioniniprop_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowgetsessioniniprop_Internalname, "Can get session initial properties?", "col-sm-4 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 170,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowgetsessioniniprop_Internalname, StringUtil.BoolToStr( AV11ClientAllowGetSessionIniProp), "", "Can get session initial properties?", 1, chkavClientallowgetsessioniniprop.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(170, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,170);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientimageurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientimageurl_Internalname, "Image URL", "col-sm-4 URLAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 175,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientimageurl_Internalname, AV22ClientImageURL, StringUtil.RTrim( context.localUtil.Format( AV22ClientImageURL, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,175);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientimageurl_Jsonclick, 0, "URLAttribute", "", "", "", "", 1, edtavClientimageurl_Enabled, 1, "text", "", 80, "%", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientlocalloginurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientlocalloginurl_Internalname, "Local login URL", "col-sm-4 URLAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 180,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientlocalloginurl_Internalname, AV23ClientLocalLoginURL, StringUtil.RTrim( context.localUtil.Format( AV23ClientLocalLoginURL, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,180);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientlocalloginurl_Jsonclick, 0, "URLAttribute", "", "", "", "", 1, edtavClientlocalloginurl_Enabled, 1, "text", "", 80, "%", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientcallbackurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientcallbackurl_Internalname, "Callback URLs", "col-sm-4 URLAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 185,'',false,'',0)\"";
            ClassString = "URLAttribute";
            StyleString = "";
            ClassString = "URLAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavClientcallbackurl_Internalname, AV19ClientCallbackURL, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,185);\"", 0, 1, edtavClientcallbackurl_Enabled, 1, 80, "chr", 4, "row", StyleString, ClassString, "", "", "32768", 1, 0, "", "", -1, true, "GeneXusSecurityCommon\\GAMString", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMExampleApplicationEntry.htm");
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
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "REST OAUTH (Mobile, GAMRemoteRest)", "", "", lblTextblock5_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowremoterestauth_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowremoterestauth_Internalname, "Allow authentication v.2.0 ?", "col-sm-3 col-lg-4 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-lg-8 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 193,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowremoterestauth_Internalname, StringUtil.BoolToStr( AV18ClientAllowRemoteRestAuth), "", "Allow authentication v.2.0 ?", 1, chkavClientallowremoterestauth.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onblur=\""+""+";gx.evt.onblur(this,193);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTblrestauth_Internalname, divTblrestauth_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowgetuserrolesrest_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowgetuserrolesrest_Internalname, "Can get user roles?", "col-sm-4 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 201,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowgetuserrolesrest_Internalname, StringUtil.BoolToStr( AV16ClientAllowGetUserRolesRest), "", "Can get user roles?", 1, chkavClientallowgetuserrolesrest.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(201, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,201);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowgetuseradddatarest_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowgetuseradddatarest_Internalname, "Can get user additional data?", "col-sm-4 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 206,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowgetuseradddatarest_Internalname, StringUtil.BoolToStr( AV14ClientAllowGetUserAddDataRest), "", "Can get user additional data?", 1, chkavClientallowgetuseradddatarest.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(206, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,206);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowgetsessioniniproprest_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowgetsessioniniproprest_Internalname, "Can get session initial properties?", "col-sm-4 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 211,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowgetsessioniniproprest_Internalname, StringUtil.BoolToStr( AV12ClientAllowGetSessionIniPropRest), "", "Can get session initial properties?", 1, chkavClientallowgetsessioniniproprest.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(211, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,211);\"");
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
            GxWebStd.gx_div_start( context, divTblgeneralauth_Internalname, divTblgeneralauth_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "GENERAL", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientaccessuniquebyuser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientaccessuniquebyuser_Internalname, "Oauth single user access?", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 222,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientaccessuniquebyuser_Internalname, StringUtil.BoolToStr( AV8ClientAccessUniqueByUser), "", "Oauth single user access?", 1, chkavClientaccessuniquebyuser.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(222, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,222);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-md-9 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientencryptionkey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientencryptionkey_Internalname, "Private encryption key", "col-sm-6 col-md-4 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 col-md-8 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 227,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientencryptionkey_Internalname, StringUtil.RTrim( AV20ClientEncryptionKey), StringUtil.RTrim( context.localUtil.Format( AV20ClientEncryptionKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,227);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientencryptionkey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientencryptionkey_Enabled, 1, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMEncryptionKey", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-md-3 FormCellSimple", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 229,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttGeneratekeygamremote_Internalname, "", "Generate Key GAMRemote", bttGeneratekeygamremote_Jsonclick, 5, "Generate Key GAMRemote", "", StyleString, ClassString, bttGeneratekeygamremote_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'GENERATEKEYGAMREMOTE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientrepositoryguid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientrepositoryguid_Internalname, "Repository GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 234,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientrepositoryguid_Internalname, StringUtil.RTrim( AV24ClientRepositoryGUID), StringUtil.RTrim( context.localUtil.Format( AV24ClientRepositoryGUID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,234);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientrepositoryguid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientrepositoryguid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMGUID", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSts_title_Internalname, "STS", "", "", lblSts_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "STS") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table2_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavStsprotocolenable_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavStsprotocolenable_Internalname, "Enable STS protocol?", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 244,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavStsprotocolenable_Internalname, StringUtil.BoolToStr( AV55STSProtocolEnable), "", "Enable STS protocol?", 1, chkavStsprotocolenable.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onblur=\""+""+";gx.evt.onblur(this,244);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablests_Internalname, divTablests_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavStsmode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavStsmode_Internalname, "STS Mode", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 252,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavStsmode, cmbavStsmode_Internalname, StringUtil.RTrim( AV54STSMode), 1, cmbavStsmode_Jsonclick, 7, "'"+""+"'"+",false,"+"'"+"e16221_client"+"'", "char", "", 1, cmbavStsmode.Enabled, 1, 0, 0, "em", 0, "", "", "CheckBox", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,252);\"", "", true, "HLP_GAMExampleApplicationEntry.htm");
            cmbavStsmode.CurrentValue = StringUtil.RTrim( AV54STSMode);
            AssignProp("", false, cmbavStsmode_Internalname, "Values", (String)(cmbavStsmode.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablestsserverchecktoken_Internalname, divTablestsserverchecktoken_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavStsauthorizationusername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavStsauthorizationusername_Internalname, "User name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 260,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavStsauthorizationusername_Internalname, AV53STSAuthorizationUserName, StringUtil.RTrim( context.localUtil.Format( AV53STSAuthorizationUserName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,260);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavStsauthorizationusername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavStsauthorizationusername_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMUserIdentification", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavStsauthorizationuserguid_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavStsauthorizationuserguid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavStsauthorizationuserguid_Internalname, " User GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 264,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavStsauthorizationuserguid_Internalname, StringUtil.RTrim( AV52STSAuthorizationUserGUID), StringUtil.RTrim( context.localUtil.Format( AV52STSAuthorizationUserGUID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,264);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavStsauthorizationuserguid_Jsonclick, 0, "Attribute", "", "", "", "", edtavStsauthorizationuserguid_Visible, edtavStsauthorizationuserguid_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMGUID", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_div_start( context, divTablestsclientgettoken_Internalname, divTablestsclientgettoken_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavStsserverclientpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavStsserverclientpassword_Internalname, "Client password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 272,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavStsserverclientpassword_Internalname, StringUtil.RTrim( AV56STSServerClientPassword), StringUtil.RTrim( context.localUtil.Format( AV56STSServerClientPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,272);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavStsserverclientpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavStsserverclientpassword_Enabled, 1, "text", "", 50, "chr", 1, "row", 50, -1, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMPassword", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_div_start( context, divTablestsclient_Internalname, divTablestsclient_Visible, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavStsserverurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavStsserverurl_Internalname, "Server URL", "col-sm-3 URLAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 280,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavStsserverurl_Internalname, AV58STSServerURL, StringUtil.RTrim( context.localUtil.Format( AV58STSServerURL, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,280);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavStsserverurl_Jsonclick, 0, "URLAttribute", "", "", "", "", 1, edtavStsserverurl_Enabled, 1, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavStsserverrepositoryguid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavStsserverrepositoryguid_Internalname, "Repository GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 285,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavStsserverrepositoryguid_Internalname, StringUtil.RTrim( AV57STSServerRepositoryGUID), StringUtil.RTrim( context.localUtil.Format( AV57STSServerRepositoryGUID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,285);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavStsserverrepositoryguid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavStsserverrepositoryguid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMGUID", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"title4"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblEnvironment_title_Internalname, "Environment Settings", "", "", lblEnvironment_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleApplicationEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Environment") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"panel4"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table1_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentname_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 296,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentname_Internalname, StringUtil.RTrim( AV31EnvironmentName), StringUtil.RTrim( context.localUtil.Format( AV31EnvironmentName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,296);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentname_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavEnvironmentsecureprotocol_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavEnvironmentsecureprotocol_Internalname, "Is HTTPS?", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 301,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavEnvironmentsecureprotocol_Internalname, StringUtil.BoolToStr( AV35EnvironmentSecureProtocol), "", "Is HTTPS?", 1, chkavEnvironmentsecureprotocol.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(301, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,301);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmenthost_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmenthost_Internalname, "Host", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 306,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmenthost_Internalname, StringUtil.RTrim( AV30EnvironmentHost), StringUtil.RTrim( context.localUtil.Format( AV30EnvironmentHost, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,306);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmenthost_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmenthost_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentport_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentport_Internalname, "Port", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 311,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentport_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV32EnvironmentPort), 5, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV32EnvironmentPort), "ZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,311);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentport_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentport_Enabled, 1, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentvirtualdirectory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentvirtualdirectory_Internalname, "Virtual Directory", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 316,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentvirtualdirectory_Internalname, StringUtil.RTrim( AV36EnvironmentVirtualDirectory), StringUtil.RTrim( context.localUtil.Format( AV36EnvironmentVirtualDirectory, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,316);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentvirtualdirectory_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentvirtualdirectory_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionMedium", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentprogrampackage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentprogrampackage_Internalname, "Package", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 321,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentprogrampackage_Internalname, StringUtil.RTrim( AV34EnvironmentProgramPackage), StringUtil.RTrim( context.localUtil.Format( AV34EnvironmentProgramPackage, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,321);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentprogrampackage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentprogrampackage_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellSimple", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentprogramextension_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentprogramextension_Internalname, "Extension", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 326,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentprogramextension_Internalname, StringUtil.RTrim( AV33EnvironmentProgramExtension), StringUtil.RTrim( context.localUtil.Format( AV33EnvironmentProgramExtension, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,326);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentprogramextension_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentprogramextension_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMExampleApplicationEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 331,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Cancel", bttBtncancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 333,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "", bttBtnconfirm_Caption, bttBtnconfirm_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtnconfirm_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavAutoregisteranomymoususer_Internalname, "Auto Register Anomymous User", "col-sm-3 CheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 337,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavAutoregisteranomymoususer_Internalname, StringUtil.BoolToStr( AV7AutoRegisterAnomymousUser), "", "Auto Register Anomymous User", chkavAutoregisteranomymoususer.Visible, chkavAutoregisteranomymoususer.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(337, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,337);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START222( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Application", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP220( ) ;
      }

      protected void WS222( )
      {
         START222( ) ;
         EVT222( ) ;
      }

      protected void EVT222( )
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
                              E17222 ();
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
                                    E18222 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GENERATEKEYGAMREMOTE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'GenerateKeyGAMRemote' */
                              E19222 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REVOKE-AUTHORIZE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Revoke-Authorize' */
                              E20222 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E21222 ();
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

      protected void WE222( )
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

      protected void PA222( )
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
         AV59UseAbsoluteUrlByEnvironment = StringUtil.StrToBool( StringUtil.BoolToStr( AV59UseAbsoluteUrlByEnvironment));
         AssignAttri("", false, "AV59UseAbsoluteUrlByEnvironment", AV59UseAbsoluteUrlByEnvironment);
         if ( cmbavMainmenu.ItemCount > 0 )
         {
            AV45MainMenu = (long)(NumberUtil.Val( cmbavMainmenu.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV45MainMenu), 12, 0))), "."));
            AssignAttri("", false, "AV45MainMenu", StringUtil.LTrimStr( (decimal)(AV45MainMenu), 12, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavMainmenu.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV45MainMenu), 12, 0));
            AssignProp("", false, cmbavMainmenu_Internalname, "Values", cmbavMainmenu.ToJavascriptSource(), true);
         }
         AV5AccessRequiresPermission = StringUtil.StrToBool( StringUtil.BoolToStr( AV5AccessRequiresPermission));
         AssignAttri("", false, "AV5AccessRequiresPermission", AV5AccessRequiresPermission);
         AV17ClientAllowRemoteAuth = StringUtil.StrToBool( StringUtil.BoolToStr( AV17ClientAllowRemoteAuth));
         AssignAttri("", false, "AV17ClientAllowRemoteAuth", AV17ClientAllowRemoteAuth);
         AV15ClientAllowGetUserRoles = StringUtil.StrToBool( StringUtil.BoolToStr( AV15ClientAllowGetUserRoles));
         AssignAttri("", false, "AV15ClientAllowGetUserRoles", AV15ClientAllowGetUserRoles);
         AV13ClientAllowGetUserAddData = StringUtil.StrToBool( StringUtil.BoolToStr( AV13ClientAllowGetUserAddData));
         AssignAttri("", false, "AV13ClientAllowGetUserAddData", AV13ClientAllowGetUserAddData);
         AV11ClientAllowGetSessionIniProp = StringUtil.StrToBool( StringUtil.BoolToStr( AV11ClientAllowGetSessionIniProp));
         AssignAttri("", false, "AV11ClientAllowGetSessionIniProp", AV11ClientAllowGetSessionIniProp);
         AV18ClientAllowRemoteRestAuth = StringUtil.StrToBool( StringUtil.BoolToStr( AV18ClientAllowRemoteRestAuth));
         AssignAttri("", false, "AV18ClientAllowRemoteRestAuth", AV18ClientAllowRemoteRestAuth);
         AV16ClientAllowGetUserRolesRest = StringUtil.StrToBool( StringUtil.BoolToStr( AV16ClientAllowGetUserRolesRest));
         AssignAttri("", false, "AV16ClientAllowGetUserRolesRest", AV16ClientAllowGetUserRolesRest);
         AV14ClientAllowGetUserAddDataRest = StringUtil.StrToBool( StringUtil.BoolToStr( AV14ClientAllowGetUserAddDataRest));
         AssignAttri("", false, "AV14ClientAllowGetUserAddDataRest", AV14ClientAllowGetUserAddDataRest);
         AV12ClientAllowGetSessionIniPropRest = StringUtil.StrToBool( StringUtil.BoolToStr( AV12ClientAllowGetSessionIniPropRest));
         AssignAttri("", false, "AV12ClientAllowGetSessionIniPropRest", AV12ClientAllowGetSessionIniPropRest);
         AV8ClientAccessUniqueByUser = StringUtil.StrToBool( StringUtil.BoolToStr( AV8ClientAccessUniqueByUser));
         AssignAttri("", false, "AV8ClientAccessUniqueByUser", AV8ClientAccessUniqueByUser);
         AV55STSProtocolEnable = StringUtil.StrToBool( StringUtil.BoolToStr( AV55STSProtocolEnable));
         AssignAttri("", false, "AV55STSProtocolEnable", AV55STSProtocolEnable);
         if ( cmbavStsmode.ItemCount > 0 )
         {
            AV54STSMode = cmbavStsmode.getValidValue(AV54STSMode);
            AssignAttri("", false, "AV54STSMode", AV54STSMode);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavStsmode.CurrentValue = StringUtil.RTrim( AV54STSMode);
            AssignProp("", false, cmbavStsmode_Internalname, "Values", cmbavStsmode.ToJavascriptSource(), true);
         }
         AV35EnvironmentSecureProtocol = StringUtil.StrToBool( StringUtil.BoolToStr( AV35EnvironmentSecureProtocol));
         AssignAttri("", false, "AV35EnvironmentSecureProtocol", AV35EnvironmentSecureProtocol);
         AV7AutoRegisterAnomymousUser = StringUtil.StrToBool( StringUtil.BoolToStr( AV7AutoRegisterAnomymousUser));
         AssignAttri("", false, "AV7AutoRegisterAnomymousUser", AV7AutoRegisterAnomymousUser);
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF222( ) ;
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
         edtavClientrevoked_Enabled = 0;
         AssignProp("", false, edtavClientrevoked_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientrevoked_Enabled), 5, 0), true);
         edtavStsauthorizationuserguid_Enabled = 0;
         AssignProp("", false, edtavStsauthorizationuserguid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavStsauthorizationuserguid_Enabled), 5, 0), true);
      }

      protected void RF222( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E21222 ();
            WB220( ) ;
         }
      }

      protected void send_integrity_lvl_hashes222( )
      {
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void STRUP220( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), true);
         edtavGuid_Enabled = 0;
         AssignProp("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGuid_Enabled), 5, 0), true);
         edtavClientrevoked_Enabled = 0;
         AssignProp("", false, edtavClientrevoked_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientrevoked_Enabled), 5, 0), true);
         edtavStsauthorizationuserguid_Enabled = 0;
         AssignProp("", false, edtavStsauthorizationuserguid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavStsauthorizationuserguid_Enabled), 5, 0), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E17222 ();
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
            AV42Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ","));
            AssignAttri("", false, "AV42Id", StringUtil.LTrimStr( (decimal)(AV42Id), 12, 0));
            AV40GUID = cgiGet( edtavGuid_Internalname);
            AssignAttri("", false, "AV40GUID", AV40GUID);
            AV48Name = cgiGet( edtavName_Internalname);
            AssignAttri("", false, "AV48Name", AV48Name);
            AV29Dsc = cgiGet( edtavDsc_Internalname);
            AssignAttri("", false, "AV29Dsc", AV29Dsc);
            AV62Version = cgiGet( edtavVersion_Internalname);
            AssignAttri("", false, "AV62Version", AV62Version);
            AV27Company = cgiGet( edtavCompany_Internalname);
            AssignAttri("", false, "AV27Company", AV27Company);
            AV28Copyright = cgiGet( edtavCopyright_Internalname);
            AssignAttri("", false, "AV28Copyright", AV28Copyright);
            AV59UseAbsoluteUrlByEnvironment = StringUtil.StrToBool( cgiGet( chkavUseabsoluteurlbyenvironment_Internalname));
            AssignAttri("", false, "AV59UseAbsoluteUrlByEnvironment", AV59UseAbsoluteUrlByEnvironment);
            AV41HomeObject = cgiGet( edtavHomeobject_Internalname);
            AssignAttri("", false, "AV41HomeObject", AV41HomeObject);
            AV44LogoutObject = cgiGet( edtavLogoutobject_Internalname);
            AssignAttri("", false, "AV44LogoutObject", AV44LogoutObject);
            cmbavMainmenu.CurrentValue = cgiGet( cmbavMainmenu_Internalname);
            AV45MainMenu = (long)(NumberUtil.Val( cgiGet( cmbavMainmenu_Internalname), "."));
            AssignAttri("", false, "AV45MainMenu", StringUtil.LTrimStr( (decimal)(AV45MainMenu), 12, 0));
            if ( context.localUtil.VCDateTime( cgiGet( edtavClientrevoked_Internalname), 1, 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Client Revoked"}), 1, "vCLIENTREVOKED");
               GX_FocusControl = edtavClientrevoked_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25ClientRevoked = (DateTime)(DateTime.MinValue);
               AssignAttri("", false, "AV25ClientRevoked", context.localUtil.TToC( AV25ClientRevoked, 10, 5, 1, 2, "/", ":", " "));
            }
            else
            {
               AV25ClientRevoked = context.localUtil.CToT( cgiGet( edtavClientrevoked_Internalname));
               AssignAttri("", false, "AV25ClientRevoked", context.localUtil.TToC( AV25ClientRevoked, 10, 5, 1, 2, "/", ":", " "));
            }
            AV5AccessRequiresPermission = StringUtil.StrToBool( cgiGet( chkavAccessrequirespermission_Internalname));
            AssignAttri("", false, "AV5AccessRequiresPermission", AV5AccessRequiresPermission);
            AV21ClientId = cgiGet( edtavClientid_Internalname);
            AssignAttri("", false, "AV21ClientId", AV21ClientId);
            AV26ClientSecret = cgiGet( edtavClientsecret_Internalname);
            AssignAttri("", false, "AV26ClientSecret", AV26ClientSecret);
            AV17ClientAllowRemoteAuth = StringUtil.StrToBool( cgiGet( chkavClientallowremoteauth_Internalname));
            AssignAttri("", false, "AV17ClientAllowRemoteAuth", AV17ClientAllowRemoteAuth);
            AV15ClientAllowGetUserRoles = StringUtil.StrToBool( cgiGet( chkavClientallowgetuserroles_Internalname));
            AssignAttri("", false, "AV15ClientAllowGetUserRoles", AV15ClientAllowGetUserRoles);
            AV13ClientAllowGetUserAddData = StringUtil.StrToBool( cgiGet( chkavClientallowgetuseradddata_Internalname));
            AssignAttri("", false, "AV13ClientAllowGetUserAddData", AV13ClientAllowGetUserAddData);
            AV11ClientAllowGetSessionIniProp = StringUtil.StrToBool( cgiGet( chkavClientallowgetsessioniniprop_Internalname));
            AssignAttri("", false, "AV11ClientAllowGetSessionIniProp", AV11ClientAllowGetSessionIniProp);
            AV22ClientImageURL = cgiGet( edtavClientimageurl_Internalname);
            AssignAttri("", false, "AV22ClientImageURL", AV22ClientImageURL);
            AV23ClientLocalLoginURL = cgiGet( edtavClientlocalloginurl_Internalname);
            AssignAttri("", false, "AV23ClientLocalLoginURL", AV23ClientLocalLoginURL);
            AV19ClientCallbackURL = cgiGet( edtavClientcallbackurl_Internalname);
            AssignAttri("", false, "AV19ClientCallbackURL", AV19ClientCallbackURL);
            AV18ClientAllowRemoteRestAuth = StringUtil.StrToBool( cgiGet( chkavClientallowremoterestauth_Internalname));
            AssignAttri("", false, "AV18ClientAllowRemoteRestAuth", AV18ClientAllowRemoteRestAuth);
            AV16ClientAllowGetUserRolesRest = StringUtil.StrToBool( cgiGet( chkavClientallowgetuserrolesrest_Internalname));
            AssignAttri("", false, "AV16ClientAllowGetUserRolesRest", AV16ClientAllowGetUserRolesRest);
            AV14ClientAllowGetUserAddDataRest = StringUtil.StrToBool( cgiGet( chkavClientallowgetuseradddatarest_Internalname));
            AssignAttri("", false, "AV14ClientAllowGetUserAddDataRest", AV14ClientAllowGetUserAddDataRest);
            AV12ClientAllowGetSessionIniPropRest = StringUtil.StrToBool( cgiGet( chkavClientallowgetsessioniniproprest_Internalname));
            AssignAttri("", false, "AV12ClientAllowGetSessionIniPropRest", AV12ClientAllowGetSessionIniPropRest);
            AV8ClientAccessUniqueByUser = StringUtil.StrToBool( cgiGet( chkavClientaccessuniquebyuser_Internalname));
            AssignAttri("", false, "AV8ClientAccessUniqueByUser", AV8ClientAccessUniqueByUser);
            AV20ClientEncryptionKey = cgiGet( edtavClientencryptionkey_Internalname);
            AssignAttri("", false, "AV20ClientEncryptionKey", AV20ClientEncryptionKey);
            AV24ClientRepositoryGUID = cgiGet( edtavClientrepositoryguid_Internalname);
            AssignAttri("", false, "AV24ClientRepositoryGUID", AV24ClientRepositoryGUID);
            AV55STSProtocolEnable = StringUtil.StrToBool( cgiGet( chkavStsprotocolenable_Internalname));
            AssignAttri("", false, "AV55STSProtocolEnable", AV55STSProtocolEnable);
            cmbavStsmode.CurrentValue = cgiGet( cmbavStsmode_Internalname);
            AV54STSMode = cgiGet( cmbavStsmode_Internalname);
            AssignAttri("", false, "AV54STSMode", AV54STSMode);
            AV53STSAuthorizationUserName = cgiGet( edtavStsauthorizationusername_Internalname);
            AssignAttri("", false, "AV53STSAuthorizationUserName", AV53STSAuthorizationUserName);
            AV52STSAuthorizationUserGUID = cgiGet( edtavStsauthorizationuserguid_Internalname);
            AssignAttri("", false, "AV52STSAuthorizationUserGUID", AV52STSAuthorizationUserGUID);
            AV56STSServerClientPassword = cgiGet( edtavStsserverclientpassword_Internalname);
            AssignAttri("", false, "AV56STSServerClientPassword", AV56STSServerClientPassword);
            AV58STSServerURL = cgiGet( edtavStsserverurl_Internalname);
            AssignAttri("", false, "AV58STSServerURL", AV58STSServerURL);
            AV57STSServerRepositoryGUID = cgiGet( edtavStsserverrepositoryguid_Internalname);
            AssignAttri("", false, "AV57STSServerRepositoryGUID", AV57STSServerRepositoryGUID);
            AV31EnvironmentName = cgiGet( edtavEnvironmentname_Internalname);
            AssignAttri("", false, "AV31EnvironmentName", AV31EnvironmentName);
            AV35EnvironmentSecureProtocol = StringUtil.StrToBool( cgiGet( chkavEnvironmentsecureprotocol_Internalname));
            AssignAttri("", false, "AV35EnvironmentSecureProtocol", AV35EnvironmentSecureProtocol);
            AV30EnvironmentHost = cgiGet( edtavEnvironmenthost_Internalname);
            AssignAttri("", false, "AV30EnvironmentHost", AV30EnvironmentHost);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavEnvironmentport_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavEnvironmentport_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vENVIRONMENTPORT");
               GX_FocusControl = edtavEnvironmentport_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV32EnvironmentPort = 0;
               AssignAttri("", false, "AV32EnvironmentPort", StringUtil.LTrimStr( (decimal)(AV32EnvironmentPort), 5, 0));
            }
            else
            {
               AV32EnvironmentPort = (int)(context.localUtil.CToN( cgiGet( edtavEnvironmentport_Internalname), ".", ","));
               AssignAttri("", false, "AV32EnvironmentPort", StringUtil.LTrimStr( (decimal)(AV32EnvironmentPort), 5, 0));
            }
            AV36EnvironmentVirtualDirectory = cgiGet( edtavEnvironmentvirtualdirectory_Internalname);
            AssignAttri("", false, "AV36EnvironmentVirtualDirectory", AV36EnvironmentVirtualDirectory);
            AV34EnvironmentProgramPackage = cgiGet( edtavEnvironmentprogrampackage_Internalname);
            AssignAttri("", false, "AV34EnvironmentProgramPackage", AV34EnvironmentProgramPackage);
            AV33EnvironmentProgramExtension = cgiGet( edtavEnvironmentprogramextension_Internalname);
            AssignAttri("", false, "AV33EnvironmentProgramExtension", AV33EnvironmentProgramExtension);
            AV7AutoRegisterAnomymousUser = StringUtil.StrToBool( cgiGet( chkavAutoregisteranomymoususer_Internalname));
            AssignAttri("", false, "AV7AutoRegisterAnomymousUser", AV7AutoRegisterAnomymousUser);
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
         E17222 ();
         if (returnInSub) return;
      }

      protected void E17222( )
      {
         /* Start Routine */
         edtavStsauthorizationuserguid_Visible = 0;
         AssignProp("", false, edtavStsauthorizationuserguid_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavStsauthorizationuserguid_Visible), 5, 0), true);
         chkavAutoregisteranomymoususer.Visible = 0;
         AssignProp("", false, chkavAutoregisteranomymoususer_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(chkavAutoregisteranomymoususer.Visible), 5, 0), true);
         divTableedit_Visible = 0;
         AssignProp("", false, divTableedit_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTableedit_Visible), 5, 0), true);
         AV60User = new GeneXus.Programs.genexussecurity.SdtGAMUser(context).get();
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            AV6Application.load( AV42Id);
            AssignAttri("", false, "AV42Id", StringUtil.LTrimStr( (decimal)(AV42Id), 12, 0));
            AV42Id = AV6Application.gxTpr_Id;
            AssignAttri("", false, "AV42Id", StringUtil.LTrimStr( (decimal)(AV42Id), 12, 0));
            AV40GUID = AV6Application.gxTpr_Guid;
            AssignAttri("", false, "AV40GUID", AV40GUID);
            AV48Name = AV6Application.gxTpr_Name;
            AssignAttri("", false, "AV48Name", AV48Name);
            AV29Dsc = AV6Application.gxTpr_Description;
            AssignAttri("", false, "AV29Dsc", AV29Dsc);
            AV62Version = AV6Application.gxTpr_Version;
            AssignAttri("", false, "AV62Version", AV62Version);
            AV28Copyright = AV6Application.gxTpr_Copyright;
            AssignAttri("", false, "AV28Copyright", AV28Copyright);
            AV27Company = AV6Application.gxTpr_Companyname;
            AssignAttri("", false, "AV27Company", AV27Company);
            AV59UseAbsoluteUrlByEnvironment = AV6Application.gxTpr_Useabsoluteurlbyenvironment;
            AssignAttri("", false, "AV59UseAbsoluteUrlByEnvironment", AV59UseAbsoluteUrlByEnvironment);
            AV41HomeObject = AV6Application.gxTpr_Homeobject;
            AssignAttri("", false, "AV41HomeObject", AV41HomeObject);
            AV44LogoutObject = AV6Application.gxTpr_Logoutobject;
            AssignAttri("", false, "AV44LogoutObject", AV44LogoutObject);
            AV68GXV2 = 1;
            AV67GXV1 = AV6Application.getmenus(AV47MenuFilter, out  AV38Errors);
            while ( AV68GXV2 <= AV67GXV1.Count )
            {
               AV46Menu = ((GeneXus.Programs.genexussecurity.SdtGAMApplicationMenu)AV67GXV1.Item(AV68GXV2));
               cmbavMainmenu.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV46Menu.gxTpr_Id), 12, 0)), AV46Menu.gxTpr_Name, 0);
               AV68GXV2 = (int)(AV68GXV2+1);
            }
            AV45MainMenu = AV6Application.gxTpr_Mainmenuid;
            AssignAttri("", false, "AV45MainMenu", StringUtil.LTrimStr( (decimal)(AV45MainMenu), 12, 0));
            AV5AccessRequiresPermission = AV6Application.gxTpr_Accessrequirespermission;
            AssignAttri("", false, "AV5AccessRequiresPermission", AV5AccessRequiresPermission);
            AV7AutoRegisterAnomymousUser = AV6Application.gxTpr_Clientautoregisteranomymoususer;
            AssignAttri("", false, "AV7AutoRegisterAnomymousUser", AV7AutoRegisterAnomymousUser);
            AV21ClientId = AV6Application.gxTpr_Clientid;
            AssignAttri("", false, "AV21ClientId", AV21ClientId);
            AV26ClientSecret = AV6Application.gxTpr_Clientsecret;
            AssignAttri("", false, "AV26ClientSecret", AV26ClientSecret);
            AV8ClientAccessUniqueByUser = AV6Application.gxTpr_Clientaccessuniquebyuser;
            AssignAttri("", false, "AV8ClientAccessUniqueByUser", AV8ClientAccessUniqueByUser);
            AV25ClientRevoked = AV6Application.gxTpr_Clientrevoked;
            AssignAttri("", false, "AV25ClientRevoked", context.localUtil.TToC( AV25ClientRevoked, 10, 5, 1, 2, "/", ":", " "));
            AV17ClientAllowRemoteAuth = AV6Application.gxTpr_Clientallowremoteauthentication;
            AssignAttri("", false, "AV17ClientAllowRemoteAuth", AV17ClientAllowRemoteAuth);
            AV15ClientAllowGetUserRoles = AV6Application.gxTpr_Clientallowgetuserroles;
            AssignAttri("", false, "AV15ClientAllowGetUserRoles", AV15ClientAllowGetUserRoles);
            AV13ClientAllowGetUserAddData = AV6Application.gxTpr_Clientallowgetuseradditionaldata;
            AssignAttri("", false, "AV13ClientAllowGetUserAddData", AV13ClientAllowGetUserAddData);
            AV11ClientAllowGetSessionIniProp = AV6Application.gxTpr_Clientallowgetsessioninitialproperties;
            AssignAttri("", false, "AV11ClientAllowGetSessionIniProp", AV11ClientAllowGetSessionIniProp);
            AV22ClientImageURL = AV6Application.gxTpr_Clientimageurl;
            AssignAttri("", false, "AV22ClientImageURL", AV22ClientImageURL);
            AV23ClientLocalLoginURL = AV6Application.gxTpr_Clientlocalloginurl;
            AssignAttri("", false, "AV23ClientLocalLoginURL", AV23ClientLocalLoginURL);
            AV19ClientCallbackURL = AV6Application.gxTpr_Clientcallbackurl;
            AssignAttri("", false, "AV19ClientCallbackURL", AV19ClientCallbackURL);
            AV18ClientAllowRemoteRestAuth = AV6Application.gxTpr_Clientallowremoterestauthentication;
            AssignAttri("", false, "AV18ClientAllowRemoteRestAuth", AV18ClientAllowRemoteRestAuth);
            AV16ClientAllowGetUserRolesRest = AV6Application.gxTpr_Clientallowgetuserrolesrest;
            AssignAttri("", false, "AV16ClientAllowGetUserRolesRest", AV16ClientAllowGetUserRolesRest);
            AV14ClientAllowGetUserAddDataRest = AV6Application.gxTpr_Clientallowgetuseradditionaldatarest;
            AssignAttri("", false, "AV14ClientAllowGetUserAddDataRest", AV14ClientAllowGetUserAddDataRest);
            AV12ClientAllowGetSessionIniPropRest = AV6Application.gxTpr_Clientallowgetsessioninitialpropertiesrest;
            AssignAttri("", false, "AV12ClientAllowGetSessionIniPropRest", AV12ClientAllowGetSessionIniPropRest);
            AV20ClientEncryptionKey = AV6Application.gxTpr_Clientencryptionkey;
            AssignAttri("", false, "AV20ClientEncryptionKey", AV20ClientEncryptionKey);
            AV24ClientRepositoryGUID = AV6Application.gxTpr_Clientrepositoryguid;
            AssignAttri("", false, "AV24ClientRepositoryGUID", AV24ClientRepositoryGUID);
            AV55STSProtocolEnable = AV6Application.gxTpr_Stsprotocolenable;
            AssignAttri("", false, "AV55STSProtocolEnable", AV55STSProtocolEnable);
            AV39GAMUser.load( AV6Application.gxTpr_Stsauthorizationuserguid);
            AV53STSAuthorizationUserName = AV39GAMUser.gxTpr_Name;
            AssignAttri("", false, "AV53STSAuthorizationUserName", AV53STSAuthorizationUserName);
            AV54STSMode = AV6Application.gxTpr_Stsmode;
            AssignAttri("", false, "AV54STSMode", AV54STSMode);
            AV58STSServerURL = AV6Application.gxTpr_Stsserverurl;
            AssignAttri("", false, "AV58STSServerURL", AV58STSServerURL);
            AV56STSServerClientPassword = AV6Application.gxTpr_Stsserverclientpassword;
            AssignAttri("", false, "AV56STSServerClientPassword", AV56STSServerClientPassword);
            AV57STSServerRepositoryGUID = AV6Application.gxTpr_Stsserverrepositoryguid;
            AssignAttri("", false, "AV57STSServerRepositoryGUID", AV57STSServerRepositoryGUID);
            AV31EnvironmentName = AV6Application.gxTpr_Environment.gxTpr_Name;
            AssignAttri("", false, "AV31EnvironmentName", AV31EnvironmentName);
            AV35EnvironmentSecureProtocol = AV6Application.gxTpr_Environment.gxTpr_Secureprotocol;
            AssignAttri("", false, "AV35EnvironmentSecureProtocol", AV35EnvironmentSecureProtocol);
            AV30EnvironmentHost = AV6Application.gxTpr_Environment.gxTpr_Host;
            AssignAttri("", false, "AV30EnvironmentHost", AV30EnvironmentHost);
            AV32EnvironmentPort = AV6Application.gxTpr_Environment.gxTpr_Port;
            AssignAttri("", false, "AV32EnvironmentPort", StringUtil.LTrimStr( (decimal)(AV32EnvironmentPort), 5, 0));
            AV36EnvironmentVirtualDirectory = AV6Application.gxTpr_Environment.gxTpr_Virtualdirectory;
            AssignAttri("", false, "AV36EnvironmentVirtualDirectory", AV36EnvironmentVirtualDirectory);
            AV34EnvironmentProgramPackage = AV6Application.gxTpr_Environment.gxTpr_Programpackage;
            AssignAttri("", false, "AV34EnvironmentProgramPackage", AV34EnvironmentProgramPackage);
            AV33EnvironmentProgramExtension = AV6Application.gxTpr_Environment.gxTpr_Programextension;
            AssignAttri("", false, "AV33EnvironmentProgramExtension", AV33EnvironmentProgramExtension);
            if ( (DateTime.MinValue==AV6Application.gxTpr_Clientrevoked) )
            {
               lblApplicationstatus_Caption = "Revoke";
               AssignProp("", false, lblApplicationstatus_Internalname, "Caption", lblApplicationstatus_Caption, true);
               imgImagerevoke_Bitmap = context.GetImagePath( "b423b6f7-ce34-4e3a-bcfe-788dddb2cbc6", "", context.GetTheme( ));
               AssignProp("", false, imgImagerevoke_Internalname, "Bitmap", context.convertURL( context.PathToRelativeUrl( imgImagerevoke_Bitmap)), true);
               AssignProp("", false, imgImagerevoke_Internalname, "SrcSet", context.GetImageSrcSet( imgImagerevoke_Bitmap), true);
            }
            else
            {
               lblApplicationstatus_Caption = "Authorize";
               AssignProp("", false, lblApplicationstatus_Internalname, "Caption", lblApplicationstatus_Caption, true);
               imgImagerevoke_Bitmap = context.GetImagePath( "2ae17eb5-7b83-4853-9ade-265674418bc5", "", context.GetTheme( ));
               AssignProp("", false, imgImagerevoke_Internalname, "Bitmap", context.convertURL( context.PathToRelativeUrl( imgImagerevoke_Bitmap)), true);
               AssignProp("", false, imgImagerevoke_Internalname, "SrcSet", context.GetImageSrcSet( imgImagerevoke_Bitmap), true);
            }
         }
         else
         {
            divActionscontainer_Visible = 0;
            AssignProp("", false, divActionscontainer_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divActionscontainer_Visible), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            edtavGuid_Enabled = 0;
            AssignProp("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavGuid_Enabled), 5, 0), true);
            edtavName_Enabled = 0;
            AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
            edtavDsc_Enabled = 0;
            AssignProp("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDsc_Enabled), 5, 0), true);
            edtavVersion_Enabled = 0;
            AssignProp("", false, edtavVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavVersion_Enabled), 5, 0), true);
            edtavCopyright_Enabled = 0;
            AssignProp("", false, edtavCopyright_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCopyright_Enabled), 5, 0), true);
            edtavCompany_Enabled = 0;
            AssignProp("", false, edtavCompany_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCompany_Enabled), 5, 0), true);
            chkavUseabsoluteurlbyenvironment.Enabled = 0;
            AssignProp("", false, chkavUseabsoluteurlbyenvironment_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavUseabsoluteurlbyenvironment.Enabled), 5, 0), true);
            edtavHomeobject_Enabled = 0;
            AssignProp("", false, edtavHomeobject_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavHomeobject_Enabled), 5, 0), true);
            edtavLogoutobject_Enabled = 0;
            AssignProp("", false, edtavLogoutobject_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavLogoutobject_Enabled), 5, 0), true);
            cmbavMainmenu.Enabled = 0;
            AssignProp("", false, cmbavMainmenu_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavMainmenu.Enabled), 5, 0), true);
            chkavAccessrequirespermission.Enabled = 0;
            AssignProp("", false, chkavAccessrequirespermission_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavAccessrequirespermission.Enabled), 5, 0), true);
            edtavClientid_Enabled = 0;
            AssignProp("", false, edtavClientid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientid_Enabled), 5, 0), true);
            edtavClientsecret_Enabled = 0;
            AssignProp("", false, edtavClientsecret_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientsecret_Enabled), 5, 0), true);
            chkavClientaccessuniquebyuser.Enabled = 0;
            AssignProp("", false, chkavClientaccessuniquebyuser_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientaccessuniquebyuser.Enabled), 5, 0), true);
            edtavClientrevoked_Enabled = 0;
            AssignProp("", false, edtavClientrevoked_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientrevoked_Enabled), 5, 0), true);
            chkavClientallowremoteauth.Enabled = 0;
            AssignProp("", false, chkavClientallowremoteauth_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientallowremoteauth.Enabled), 5, 0), true);
            chkavClientallowgetuserroles.Enabled = 0;
            AssignProp("", false, chkavClientallowgetuserroles_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientallowgetuserroles.Enabled), 5, 0), true);
            chkavClientallowgetuseradddata.Enabled = 0;
            AssignProp("", false, chkavClientallowgetuseradddata_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientallowgetuseradddata.Enabled), 5, 0), true);
            chkavClientallowgetsessioniniprop.Enabled = 0;
            AssignProp("", false, chkavClientallowgetsessioniniprop_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientallowgetsessioniniprop.Enabled), 5, 0), true);
            chkavClientallowremoterestauth.Enabled = 0;
            AssignProp("", false, chkavClientallowremoterestauth_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientallowremoterestauth.Enabled), 5, 0), true);
            chkavClientallowgetuserrolesrest.Enabled = 0;
            AssignProp("", false, chkavClientallowgetuserrolesrest_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientallowgetuserrolesrest.Enabled), 5, 0), true);
            chkavClientallowgetuseradddatarest.Enabled = 0;
            AssignProp("", false, chkavClientallowgetuseradddatarest_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientallowgetuseradddatarest.Enabled), 5, 0), true);
            chkavClientallowgetsessioniniproprest.Enabled = 0;
            AssignProp("", false, chkavClientallowgetsessioniniproprest_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavClientallowgetsessioniniproprest.Enabled), 5, 0), true);
            edtavClientlocalloginurl_Enabled = 0;
            AssignProp("", false, edtavClientlocalloginurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientlocalloginurl_Enabled), 5, 0), true);
            edtavClientcallbackurl_Enabled = 0;
            AssignProp("", false, edtavClientcallbackurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientcallbackurl_Enabled), 5, 0), true);
            edtavClientimageurl_Enabled = 0;
            AssignProp("", false, edtavClientimageurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientimageurl_Enabled), 5, 0), true);
            edtavClientencryptionkey_Enabled = 0;
            AssignProp("", false, edtavClientencryptionkey_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientencryptionkey_Enabled), 5, 0), true);
            edtavClientrepositoryguid_Enabled = 0;
            AssignProp("", false, edtavClientrepositoryguid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavClientrepositoryguid_Enabled), 5, 0), true);
            chkavStsprotocolenable.Enabled = 0;
            AssignProp("", false, chkavStsprotocolenable_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavStsprotocolenable.Enabled), 5, 0), true);
            edtavStsauthorizationusername_Enabled = 0;
            AssignProp("", false, edtavStsauthorizationusername_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavStsauthorizationusername_Enabled), 5, 0), true);
            cmbavStsmode.Enabled = 0;
            AssignProp("", false, cmbavStsmode_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavStsmode.Enabled), 5, 0), true);
            edtavStsserverurl_Enabled = 0;
            AssignProp("", false, edtavStsserverurl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavStsserverurl_Enabled), 5, 0), true);
            edtavStsserverclientpassword_Enabled = 0;
            AssignProp("", false, edtavStsserverclientpassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavStsserverclientpassword_Enabled), 5, 0), true);
            edtavStsserverrepositoryguid_Enabled = 0;
            AssignProp("", false, edtavStsserverrepositoryguid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavStsserverrepositoryguid_Enabled), 5, 0), true);
            edtavEnvironmentname_Enabled = 0;
            AssignProp("", false, edtavEnvironmentname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavEnvironmentname_Enabled), 5, 0), true);
            chkavEnvironmentsecureprotocol.Enabled = 0;
            AssignProp("", false, chkavEnvironmentsecureprotocol_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavEnvironmentsecureprotocol.Enabled), 5, 0), true);
            edtavEnvironmenthost_Enabled = 0;
            AssignProp("", false, edtavEnvironmenthost_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavEnvironmenthost_Enabled), 5, 0), true);
            edtavEnvironmentport_Enabled = 0;
            AssignProp("", false, edtavEnvironmentport_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavEnvironmentport_Enabled), 5, 0), true);
            edtavEnvironmentvirtualdirectory_Enabled = 0;
            AssignProp("", false, edtavEnvironmentvirtualdirectory_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavEnvironmentvirtualdirectory_Enabled), 5, 0), true);
            edtavEnvironmentprogrampackage_Enabled = 0;
            AssignProp("", false, edtavEnvironmentprogrampackage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavEnvironmentprogrampackage_Enabled), 5, 0), true);
            edtavEnvironmentprogramextension_Enabled = 0;
            AssignProp("", false, edtavEnvironmentprogramextension_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavEnvironmentprogramextension_Enabled), 5, 0), true);
            bttGeneratekeygamremote_Visible = 0;
            AssignProp("", false, bttGeneratekeygamremote_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttGeneratekeygamremote_Visible), 5, 0), true);
            bttBtnconfirm_Caption = "Delete";
            AssignProp("", false, bttBtnconfirm_Internalname, "Caption", bttBtnconfirm_Caption, true);
         }
         /* Execute user subroutine: 'UI_REMOTEAUTHENTICATIONWEB' */
         S112 ();
         if (returnInSub) return;
         /* Execute user subroutine: 'UI_REMOTEAUTHENTICATIONREST' */
         S122 ();
         if (returnInSub) return;
         /* Execute user subroutine: 'UI_STSPROTOCOL' */
         S132 ();
         if (returnInSub) return;
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            divTableedit_Visible = 1;
            AssignProp("", false, divTableedit_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTableedit_Visible), 5, 0), true);
            bttBtnconfirm_Visible = 0;
            AssignProp("", false, bttBtnconfirm_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtnconfirm_Visible), 5, 0), true);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E18222 ();
         if (returnInSub) return;
      }

      protected void E18222( )
      {
         /* Enter Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            AV6Application.load( AV42Id);
            AssignAttri("", false, "AV42Id", StringUtil.LTrimStr( (decimal)(AV42Id), 12, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            AV6Application.gxTpr_Name = AV48Name;
            AV6Application.gxTpr_Description = AV29Dsc;
            AV6Application.gxTpr_Version = AV62Version;
            AV6Application.gxTpr_Copyright = AV28Copyright;
            AV6Application.gxTpr_Companyname = AV27Company;
            AV6Application.gxTpr_Useabsoluteurlbyenvironment = AV59UseAbsoluteUrlByEnvironment;
            AV6Application.gxTpr_Homeobject = AV41HomeObject;
            AV6Application.gxTpr_Logoutobject = AV44LogoutObject;
            AV6Application.gxTpr_Mainmenuid = AV45MainMenu;
            AV6Application.gxTpr_Accessrequirespermission = AV5AccessRequiresPermission;
            AV6Application.gxTpr_Clientautoregisteranomymoususer = AV7AutoRegisterAnomymousUser;
            AV6Application.gxTpr_Clientid = AV21ClientId;
            AV6Application.gxTpr_Clientsecret = AV26ClientSecret;
            AV6Application.gxTpr_Clientaccessuniquebyuser = AV8ClientAccessUniqueByUser;
            AV6Application.gxTpr_Clientallowremoteauthentication = AV17ClientAllowRemoteAuth;
            AV6Application.gxTpr_Clientallowgetuserroles = AV15ClientAllowGetUserRoles;
            AV6Application.gxTpr_Clientallowgetuseradditionaldata = AV13ClientAllowGetUserAddData;
            AV6Application.gxTpr_Clientallowgetsessioninitialproperties = AV11ClientAllowGetSessionIniProp;
            AV6Application.gxTpr_Clientlocalloginurl = AV23ClientLocalLoginURL;
            AV6Application.gxTpr_Clientcallbackurl = AV19ClientCallbackURL;
            AV6Application.gxTpr_Clientimageurl = AV22ClientImageURL;
            AV6Application.gxTpr_Clientallowremoterestauthentication = AV18ClientAllowRemoteRestAuth;
            AV6Application.gxTpr_Clientallowgetuserrolesrest = AV16ClientAllowGetUserRolesRest;
            AV6Application.gxTpr_Clientallowgetuseradditionaldatarest = AV14ClientAllowGetUserAddDataRest;
            AV6Application.gxTpr_Clientallowgetsessioninitialpropertiesrest = AV12ClientAllowGetSessionIniPropRest;
            AV6Application.gxTpr_Clientencryptionkey = AV20ClientEncryptionKey;
            AV6Application.gxTpr_Clientrepositoryguid = AV24ClientRepositoryGUID;
            AV6Application.gxTpr_Stsprotocolenable = AV55STSProtocolEnable;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53STSAuthorizationUserName)) )
            {
               AV39GAMUser = AV39GAMUser.getbylogin("local", AV53STSAuthorizationUserName, out  AV61UserErrors);
               AV52STSAuthorizationUserGUID = AV39GAMUser.gxTpr_Guid;
               AssignAttri("", false, "AV52STSAuthorizationUserGUID", AV52STSAuthorizationUserGUID);
            }
            AV6Application.gxTpr_Stsauthorizationuserguid = AV52STSAuthorizationUserGUID;
            AV6Application.gxTpr_Stsmode = AV54STSMode;
            AV6Application.gxTpr_Stsserverurl = AV58STSServerURL;
            AV6Application.gxTpr_Stsserverclientpassword = AV56STSServerClientPassword;
            AV6Application.gxTpr_Stsserverrepositoryguid = AV57STSServerRepositoryGUID;
            AV6Application.gxTpr_Environment.gxTpr_Name = AV31EnvironmentName;
            AV6Application.gxTpr_Environment.gxTpr_Secureprotocol = AV35EnvironmentSecureProtocol;
            AV6Application.gxTpr_Environment.gxTpr_Host = AV30EnvironmentHost;
            AV6Application.gxTpr_Environment.gxTpr_Port = AV32EnvironmentPort;
            AV6Application.gxTpr_Environment.gxTpr_Virtualdirectory = AV36EnvironmentVirtualDirectory;
            AV6Application.gxTpr_Environment.gxTpr_Programpackage = AV34EnvironmentProgramPackage;
            AV6Application.gxTpr_Environment.gxTpr_Programextension = AV33EnvironmentProgramExtension;
            AV6Application.save();
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV6Application.delete();
         }
         if ( AV6Application.success() && ( AV61UserErrors.Count == 0 ) )
         {
            context.CommitDataStores("gamexampleapplicationentry",pr_default);
            CallWebObject(formatLink("gamexamplewwapplications.aspx") );
            context.wjLocDisableFrm = 1;
         }
         else
         {
            AV38Errors = AV6Application.geterrors();
            /* Execute user subroutine: 'ERRORS' */
            S142 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV6Application", AV6Application);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39GAMUser", AV39GAMUser);
      }

      protected void S142( )
      {
         /* 'ERRORS' Routine */
         if ( AV38Errors.Count > 0 )
         {
            AV69GXV3 = 1;
            while ( AV69GXV3 <= AV38Errors.Count )
            {
               AV37Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV38Errors.Item(AV69GXV3));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV37Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV37Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV69GXV3 = (int)(AV69GXV3+1);
            }
         }
         if ( AV61UserErrors.Count > 0 )
         {
            AV70GXV4 = 1;
            while ( AV70GXV4 <= AV61UserErrors.Count )
            {
               AV37Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV61UserErrors.Item(AV70GXV4));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV37Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV37Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV70GXV4 = (int)(AV70GXV4+1);
            }
         }
      }

      protected void E19222( )
      {
         /* 'GenerateKeyGAMRemote' Routine */
         AV20ClientEncryptionKey = Crypto.GetEncryptionKey( );
         AssignAttri("", false, "AV20ClientEncryptionKey", AV20ClientEncryptionKey);
         /*  Sending Event outputs  */
      }

      protected void E20222( )
      {
         /* 'Revoke-Authorize' Routine */
         AV6Application.load( AV42Id);
         AssignAttri("", false, "AV42Id", StringUtil.LTrimStr( (decimal)(AV42Id), 12, 0));
         if ( (DateTime.MinValue==AV6Application.gxTpr_Clientrevoked) )
         {
            AV43isOk = AV6Application.revokeclient(out  AV38Errors);
         }
         else
         {
            AV43isOk = AV6Application.authorizeclient(out  AV38Errors);
         }
         if ( AV43isOk )
         {
            if ( (DateTime.MinValue==AV6Application.gxTpr_Clientrevoked) )
            {
               lblApplicationstatus_Caption = "Revoke";
               AssignProp("", false, lblApplicationstatus_Internalname, "Caption", lblApplicationstatus_Caption, true);
               imgImagerevoke_Bitmap = context.GetImagePath( "b423b6f7-ce34-4e3a-bcfe-788dddb2cbc6", "", context.GetTheme( ));
               AssignProp("", false, imgImagerevoke_Internalname, "Bitmap", context.convertURL( context.PathToRelativeUrl( imgImagerevoke_Bitmap)), true);
               AssignProp("", false, imgImagerevoke_Internalname, "SrcSet", context.GetImageSrcSet( imgImagerevoke_Bitmap), true);
            }
            else
            {
               lblApplicationstatus_Caption = "Authorize";
               AssignProp("", false, lblApplicationstatus_Internalname, "Caption", lblApplicationstatus_Caption, true);
               imgImagerevoke_Bitmap = context.GetImagePath( "2ae17eb5-7b83-4853-9ade-265674418bc5", "", context.GetTheme( ));
               AssignProp("", false, imgImagerevoke_Internalname, "Bitmap", context.convertURL( context.PathToRelativeUrl( imgImagerevoke_Bitmap)), true);
               AssignProp("", false, imgImagerevoke_Internalname, "SrcSet", context.GetImageSrcSet( imgImagerevoke_Bitmap), true);
            }
            context.CommitDataStores("gamexampleapplicationentry",pr_default);
            context.DoAjaxRefresh();
         }
         else
         {
            /* Execute user subroutine: 'ERRORS' */
            S142 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV6Application", AV6Application);
      }

      protected void S112( )
      {
         /* 'UI_REMOTEAUTHENTICATIONWEB' Routine */
         if ( AV17ClientAllowRemoteAuth )
         {
            divTblwebauth_Visible = 1;
            AssignProp("", false, divTblwebauth_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblwebauth_Visible), 5, 0), true);
            divAllowcell_Class = "FormCell";
            AssignProp("", false, divAllowcell_Internalname, "Class", divAllowcell_Class, true);
            divTblgeneralauth_Visible = 1;
            AssignProp("", false, divTblgeneralauth_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblgeneralauth_Visible), 5, 0), true);
         }
         else
         {
            divTblwebauth_Visible = 0;
            AssignProp("", false, divTblwebauth_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblwebauth_Visible), 5, 0), true);
            divAllowcell_Class = "FormCellSimple";
            AssignProp("", false, divAllowcell_Internalname, "Class", divAllowcell_Class, true);
            if ( ! AV18ClientAllowRemoteRestAuth )
            {
               divTblgeneralauth_Visible = 0;
               AssignProp("", false, divTblgeneralauth_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblgeneralauth_Visible), 5, 0), true);
            }
         }
      }

      protected void S122( )
      {
         /* 'UI_REMOTEAUTHENTICATIONREST' Routine */
         if ( AV18ClientAllowRemoteRestAuth )
         {
            divTblrestauth_Visible = 1;
            AssignProp("", false, divTblrestauth_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblrestauth_Visible), 5, 0), true);
            divAllowcell_Class = "FormCell";
            AssignProp("", false, divAllowcell_Internalname, "Class", divAllowcell_Class, true);
            divTblgeneralauth_Visible = 1;
            AssignProp("", false, divTblgeneralauth_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblgeneralauth_Visible), 5, 0), true);
         }
         else
         {
            divTblrestauth_Visible = 0;
            AssignProp("", false, divTblrestauth_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblrestauth_Visible), 5, 0), true);
            divAllowcell_Class = "FormCellSimple";
            AssignProp("", false, divAllowcell_Internalname, "Class", divAllowcell_Class, true);
            if ( ! AV17ClientAllowRemoteAuth )
            {
               divTblgeneralauth_Visible = 0;
               AssignProp("", false, divTblgeneralauth_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTblgeneralauth_Visible), 5, 0), true);
            }
         }
      }

      protected void S132( )
      {
         /* 'UI_STSPROTOCOL' Routine */
         if ( AV55STSProtocolEnable )
         {
            divTablests_Visible = 1;
            AssignProp("", false, divTablests_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablests_Visible), 5, 0), true);
            if ( StringUtil.StrCmp(AV54STSMode, "server") == 0 )
            {
               divTablestsserverchecktoken_Visible = 1;
               AssignProp("", false, divTablestsserverchecktoken_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsserverchecktoken_Visible), 5, 0), true);
               divTablestsclientgettoken_Visible = 0;
               AssignProp("", false, divTablestsclientgettoken_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsclientgettoken_Visible), 5, 0), true);
               divTablestsclient_Visible = 0;
               AssignProp("", false, divTablestsclient_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsclient_Visible), 5, 0), true);
            }
            else if ( StringUtil.StrCmp(AV54STSMode, "gettoken") == 0 )
            {
               divTablestsserverchecktoken_Visible = 0;
               AssignProp("", false, divTablestsserverchecktoken_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsserverchecktoken_Visible), 5, 0), true);
               divTablestsclientgettoken_Visible = 1;
               AssignProp("", false, divTablestsclientgettoken_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsclientgettoken_Visible), 5, 0), true);
               divTablestsclient_Visible = 1;
               AssignProp("", false, divTablestsclient_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsclient_Visible), 5, 0), true);
            }
            else if ( StringUtil.StrCmp(AV54STSMode, "checktoken") == 0 )
            {
               divTablestsserverchecktoken_Visible = 1;
               AssignProp("", false, divTablestsserverchecktoken_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsserverchecktoken_Visible), 5, 0), true);
               divTablestsclientgettoken_Visible = 0;
               AssignProp("", false, divTablestsclientgettoken_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsclientgettoken_Visible), 5, 0), true);
               divTablestsclient_Visible = 1;
               AssignProp("", false, divTablestsclient_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsclient_Visible), 5, 0), true);
            }
            else if ( StringUtil.StrCmp(AV54STSMode, "fulltoken") == 0 )
            {
               divTablestsserverchecktoken_Visible = 1;
               AssignProp("", false, divTablestsserverchecktoken_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsserverchecktoken_Visible), 5, 0), true);
               divTablestsclientgettoken_Visible = 1;
               AssignProp("", false, divTablestsclientgettoken_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsclientgettoken_Visible), 5, 0), true);
               divTablestsclient_Visible = 1;
               AssignProp("", false, divTablestsclient_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablestsclient_Visible), 5, 0), true);
            }
            divAllowcell_Class = "FormCell";
            AssignProp("", false, divAllowcell_Internalname, "Class", divAllowcell_Class, true);
         }
         else
         {
            divTablests_Visible = 0;
            AssignProp("", false, divTablests_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTablests_Visible), 5, 0), true);
            divAllowcell_Class = "FormCellSimple";
            AssignProp("", false, divAllowcell_Internalname, "Class", divAllowcell_Class, true);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E21222( )
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
         AV42Id = Convert.ToInt64(getParm(obj,1));
         AssignAttri("", false, "AV42Id", StringUtil.LTrimStr( (decimal)(AV42Id), 12, 0));
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
         PA222( ) ;
         WS222( ) ;
         WE222( ) ;
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
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20204151110491", true, true);
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
         context.AddJavascriptSource("gamexampleapplicationentry.js", "?20204151110492", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         chkavUseabsoluteurlbyenvironment.Name = "vUSEABSOLUTEURLBYENVIRONMENT";
         chkavUseabsoluteurlbyenvironment.WebTags = "";
         chkavUseabsoluteurlbyenvironment.Caption = "";
         AssignProp("", false, chkavUseabsoluteurlbyenvironment_Internalname, "TitleCaption", chkavUseabsoluteurlbyenvironment.Caption, true);
         chkavUseabsoluteurlbyenvironment.CheckedValue = "false";
         AV59UseAbsoluteUrlByEnvironment = StringUtil.StrToBool( StringUtil.BoolToStr( AV59UseAbsoluteUrlByEnvironment));
         AssignAttri("", false, "AV59UseAbsoluteUrlByEnvironment", AV59UseAbsoluteUrlByEnvironment);
         cmbavMainmenu.Name = "vMAINMENU";
         cmbavMainmenu.WebTags = "";
         if ( cmbavMainmenu.ItemCount > 0 )
         {
            AV45MainMenu = (long)(NumberUtil.Val( cmbavMainmenu.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV45MainMenu), 12, 0))), "."));
            AssignAttri("", false, "AV45MainMenu", StringUtil.LTrimStr( (decimal)(AV45MainMenu), 12, 0));
         }
         chkavAccessrequirespermission.Name = "vACCESSREQUIRESPERMISSION";
         chkavAccessrequirespermission.WebTags = "";
         chkavAccessrequirespermission.Caption = "";
         AssignProp("", false, chkavAccessrequirespermission_Internalname, "TitleCaption", chkavAccessrequirespermission.Caption, true);
         chkavAccessrequirespermission.CheckedValue = "false";
         AV5AccessRequiresPermission = StringUtil.StrToBool( StringUtil.BoolToStr( AV5AccessRequiresPermission));
         AssignAttri("", false, "AV5AccessRequiresPermission", AV5AccessRequiresPermission);
         chkavClientallowremoteauth.Name = "vCLIENTALLOWREMOTEAUTH";
         chkavClientallowremoteauth.WebTags = "";
         chkavClientallowremoteauth.Caption = "";
         AssignProp("", false, chkavClientallowremoteauth_Internalname, "TitleCaption", chkavClientallowremoteauth.Caption, true);
         chkavClientallowremoteauth.CheckedValue = "false";
         AV17ClientAllowRemoteAuth = StringUtil.StrToBool( StringUtil.BoolToStr( AV17ClientAllowRemoteAuth));
         AssignAttri("", false, "AV17ClientAllowRemoteAuth", AV17ClientAllowRemoteAuth);
         chkavClientallowgetuserroles.Name = "vCLIENTALLOWGETUSERROLES";
         chkavClientallowgetuserroles.WebTags = "";
         chkavClientallowgetuserroles.Caption = "";
         AssignProp("", false, chkavClientallowgetuserroles_Internalname, "TitleCaption", chkavClientallowgetuserroles.Caption, true);
         chkavClientallowgetuserroles.CheckedValue = "false";
         AV15ClientAllowGetUserRoles = StringUtil.StrToBool( StringUtil.BoolToStr( AV15ClientAllowGetUserRoles));
         AssignAttri("", false, "AV15ClientAllowGetUserRoles", AV15ClientAllowGetUserRoles);
         chkavClientallowgetuseradddata.Name = "vCLIENTALLOWGETUSERADDDATA";
         chkavClientallowgetuseradddata.WebTags = "";
         chkavClientallowgetuseradddata.Caption = "";
         AssignProp("", false, chkavClientallowgetuseradddata_Internalname, "TitleCaption", chkavClientallowgetuseradddata.Caption, true);
         chkavClientallowgetuseradddata.CheckedValue = "false";
         AV13ClientAllowGetUserAddData = StringUtil.StrToBool( StringUtil.BoolToStr( AV13ClientAllowGetUserAddData));
         AssignAttri("", false, "AV13ClientAllowGetUserAddData", AV13ClientAllowGetUserAddData);
         chkavClientallowgetsessioniniprop.Name = "vCLIENTALLOWGETSESSIONINIPROP";
         chkavClientallowgetsessioniniprop.WebTags = "";
         chkavClientallowgetsessioniniprop.Caption = "";
         AssignProp("", false, chkavClientallowgetsessioniniprop_Internalname, "TitleCaption", chkavClientallowgetsessioniniprop.Caption, true);
         chkavClientallowgetsessioniniprop.CheckedValue = "false";
         AV11ClientAllowGetSessionIniProp = StringUtil.StrToBool( StringUtil.BoolToStr( AV11ClientAllowGetSessionIniProp));
         AssignAttri("", false, "AV11ClientAllowGetSessionIniProp", AV11ClientAllowGetSessionIniProp);
         chkavClientallowremoterestauth.Name = "vCLIENTALLOWREMOTERESTAUTH";
         chkavClientallowremoterestauth.WebTags = "";
         chkavClientallowremoterestauth.Caption = "";
         AssignProp("", false, chkavClientallowremoterestauth_Internalname, "TitleCaption", chkavClientallowremoterestauth.Caption, true);
         chkavClientallowremoterestauth.CheckedValue = "false";
         AV18ClientAllowRemoteRestAuth = StringUtil.StrToBool( StringUtil.BoolToStr( AV18ClientAllowRemoteRestAuth));
         AssignAttri("", false, "AV18ClientAllowRemoteRestAuth", AV18ClientAllowRemoteRestAuth);
         chkavClientallowgetuserrolesrest.Name = "vCLIENTALLOWGETUSERROLESREST";
         chkavClientallowgetuserrolesrest.WebTags = "";
         chkavClientallowgetuserrolesrest.Caption = "";
         AssignProp("", false, chkavClientallowgetuserrolesrest_Internalname, "TitleCaption", chkavClientallowgetuserrolesrest.Caption, true);
         chkavClientallowgetuserrolesrest.CheckedValue = "false";
         AV16ClientAllowGetUserRolesRest = StringUtil.StrToBool( StringUtil.BoolToStr( AV16ClientAllowGetUserRolesRest));
         AssignAttri("", false, "AV16ClientAllowGetUserRolesRest", AV16ClientAllowGetUserRolesRest);
         chkavClientallowgetuseradddatarest.Name = "vCLIENTALLOWGETUSERADDDATAREST";
         chkavClientallowgetuseradddatarest.WebTags = "";
         chkavClientallowgetuseradddatarest.Caption = "";
         AssignProp("", false, chkavClientallowgetuseradddatarest_Internalname, "TitleCaption", chkavClientallowgetuseradddatarest.Caption, true);
         chkavClientallowgetuseradddatarest.CheckedValue = "false";
         AV14ClientAllowGetUserAddDataRest = StringUtil.StrToBool( StringUtil.BoolToStr( AV14ClientAllowGetUserAddDataRest));
         AssignAttri("", false, "AV14ClientAllowGetUserAddDataRest", AV14ClientAllowGetUserAddDataRest);
         chkavClientallowgetsessioniniproprest.Name = "vCLIENTALLOWGETSESSIONINIPROPREST";
         chkavClientallowgetsessioniniproprest.WebTags = "";
         chkavClientallowgetsessioniniproprest.Caption = "";
         AssignProp("", false, chkavClientallowgetsessioniniproprest_Internalname, "TitleCaption", chkavClientallowgetsessioniniproprest.Caption, true);
         chkavClientallowgetsessioniniproprest.CheckedValue = "false";
         AV12ClientAllowGetSessionIniPropRest = StringUtil.StrToBool( StringUtil.BoolToStr( AV12ClientAllowGetSessionIniPropRest));
         AssignAttri("", false, "AV12ClientAllowGetSessionIniPropRest", AV12ClientAllowGetSessionIniPropRest);
         chkavClientaccessuniquebyuser.Name = "vCLIENTACCESSUNIQUEBYUSER";
         chkavClientaccessuniquebyuser.WebTags = "";
         chkavClientaccessuniquebyuser.Caption = "";
         AssignProp("", false, chkavClientaccessuniquebyuser_Internalname, "TitleCaption", chkavClientaccessuniquebyuser.Caption, true);
         chkavClientaccessuniquebyuser.CheckedValue = "false";
         AV8ClientAccessUniqueByUser = StringUtil.StrToBool( StringUtil.BoolToStr( AV8ClientAccessUniqueByUser));
         AssignAttri("", false, "AV8ClientAccessUniqueByUser", AV8ClientAccessUniqueByUser);
         chkavStsprotocolenable.Name = "vSTSPROTOCOLENABLE";
         chkavStsprotocolenable.WebTags = "";
         chkavStsprotocolenable.Caption = "";
         AssignProp("", false, chkavStsprotocolenable_Internalname, "TitleCaption", chkavStsprotocolenable.Caption, true);
         chkavStsprotocolenable.CheckedValue = "false";
         AV55STSProtocolEnable = StringUtil.StrToBool( StringUtil.BoolToStr( AV55STSProtocolEnable));
         AssignAttri("", false, "AV55STSProtocolEnable", AV55STSProtocolEnable);
         cmbavStsmode.Name = "vSTSMODE";
         cmbavStsmode.WebTags = "";
         cmbavStsmode.addItem("server", "Server", 0);
         cmbavStsmode.addItem("gettoken", "Get token", 0);
         cmbavStsmode.addItem("checktoken", "Check token", 0);
         cmbavStsmode.addItem("fulltoken", "Get and check token", 0);
         if ( cmbavStsmode.ItemCount > 0 )
         {
            AV54STSMode = cmbavStsmode.getValidValue(AV54STSMode);
            AssignAttri("", false, "AV54STSMode", AV54STSMode);
         }
         chkavEnvironmentsecureprotocol.Name = "vENVIRONMENTSECUREPROTOCOL";
         chkavEnvironmentsecureprotocol.WebTags = "";
         chkavEnvironmentsecureprotocol.Caption = "";
         AssignProp("", false, chkavEnvironmentsecureprotocol_Internalname, "TitleCaption", chkavEnvironmentsecureprotocol.Caption, true);
         chkavEnvironmentsecureprotocol.CheckedValue = "false";
         AV35EnvironmentSecureProtocol = StringUtil.StrToBool( StringUtil.BoolToStr( AV35EnvironmentSecureProtocol));
         AssignAttri("", false, "AV35EnvironmentSecureProtocol", AV35EnvironmentSecureProtocol);
         chkavAutoregisteranomymoususer.Name = "vAUTOREGISTERANOMYMOUSUSER";
         chkavAutoregisteranomymoususer.WebTags = "";
         chkavAutoregisteranomymoususer.Caption = "";
         AssignProp("", false, chkavAutoregisteranomymoususer_Internalname, "TitleCaption", chkavAutoregisteranomymoususer.Caption, true);
         chkavAutoregisteranomymoususer.CheckedValue = "false";
         AV7AutoRegisterAnomymousUser = StringUtil.StrToBool( StringUtil.BoolToStr( AV7AutoRegisterAnomymousUser));
         AssignAttri("", false, "AV7AutoRegisterAnomymousUser", AV7AutoRegisterAnomymousUser);
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock2_Internalname = "TEXTBLOCK2";
         bttShowhide_Internalname = "SHOWHIDE";
         divTable3_Internalname = "TABLE3";
         imgImage1_Internalname = "IMAGE1";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         divTableedit_Internalname = "TABLEEDIT";
         imgImageprm_Internalname = "IMAGEPRM";
         lblPermissions_Internalname = "PERMISSIONS";
         divTable6_Internalname = "TABLE6";
         imgImagemenu_Internalname = "IMAGEMENU";
         lblMenus_Internalname = "MENUS";
         divTable4_Internalname = "TABLE4";
         imgImagerevoke_Internalname = "IMAGEREVOKE";
         lblApplicationstatus_Internalname = "APPLICATIONSTATUS";
         divTable7_Internalname = "TABLE7";
         imgImagedlt_Internalname = "IMAGEDLT";
         lblDeleteapp_Internalname = "DELETEAPP";
         divTable5_Internalname = "TABLE5";
         divActionscontainer_Internalname = "ACTIONSCONTAINER";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         edtavId_Internalname = "vID";
         edtavGuid_Internalname = "vGUID";
         edtavName_Internalname = "vNAME";
         edtavDsc_Internalname = "vDSC";
         edtavVersion_Internalname = "vVERSION";
         edtavCompany_Internalname = "vCOMPANY";
         edtavCopyright_Internalname = "vCOPYRIGHT";
         chkavUseabsoluteurlbyenvironment_Internalname = "vUSEABSOLUTEURLBYENVIRONMENT";
         edtavHomeobject_Internalname = "vHOMEOBJECT";
         edtavLogoutobject_Internalname = "vLOGOUTOBJECT";
         cmbavMainmenu_Internalname = "vMAINMENU";
         edtavClientrevoked_Internalname = "vCLIENTREVOKED";
         chkavAccessrequirespermission_Internalname = "vACCESSREQUIRESPERMISSION";
         divTabpage1table_Internalname = "TABPAGE1TABLE";
         lblTabpage3_title_Internalname = "TABPAGE3_TITLE";
         edtavClientid_Internalname = "vCLIENTID";
         edtavClientsecret_Internalname = "vCLIENTSECRET";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         chkavClientallowremoteauth_Internalname = "vCLIENTALLOWREMOTEAUTH";
         divAllowcell_Internalname = "ALLOWCELL";
         chkavClientallowgetuserroles_Internalname = "vCLIENTALLOWGETUSERROLES";
         chkavClientallowgetuseradddata_Internalname = "vCLIENTALLOWGETUSERADDDATA";
         chkavClientallowgetsessioniniprop_Internalname = "vCLIENTALLOWGETSESSIONINIPROP";
         edtavClientimageurl_Internalname = "vCLIENTIMAGEURL";
         edtavClientlocalloginurl_Internalname = "vCLIENTLOCALLOGINURL";
         edtavClientcallbackurl_Internalname = "vCLIENTCALLBACKURL";
         divTblwebauth_Internalname = "TBLWEBAUTH";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         chkavClientallowremoterestauth_Internalname = "vCLIENTALLOWREMOTERESTAUTH";
         chkavClientallowgetuserrolesrest_Internalname = "vCLIENTALLOWGETUSERROLESREST";
         chkavClientallowgetuseradddatarest_Internalname = "vCLIENTALLOWGETUSERADDDATAREST";
         chkavClientallowgetsessioniniproprest_Internalname = "vCLIENTALLOWGETSESSIONINIPROPREST";
         divTblrestauth_Internalname = "TBLRESTAUTH";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         chkavClientaccessuniquebyuser_Internalname = "vCLIENTACCESSUNIQUEBYUSER";
         edtavClientencryptionkey_Internalname = "vCLIENTENCRYPTIONKEY";
         bttGeneratekeygamremote_Internalname = "GENERATEKEYGAMREMOTE";
         edtavClientrepositoryguid_Internalname = "vCLIENTREPOSITORYGUID";
         divTblgeneralauth_Internalname = "TBLGENERALAUTH";
         divTabpage3table_Internalname = "TABPAGE3TABLE";
         lblSts_title_Internalname = "STS_TITLE";
         chkavStsprotocolenable_Internalname = "vSTSPROTOCOLENABLE";
         cmbavStsmode_Internalname = "vSTSMODE";
         edtavStsauthorizationusername_Internalname = "vSTSAUTHORIZATIONUSERNAME";
         edtavStsauthorizationuserguid_Internalname = "vSTSAUTHORIZATIONUSERGUID";
         divTablestsserverchecktoken_Internalname = "TABLESTSSERVERCHECKTOKEN";
         edtavStsserverclientpassword_Internalname = "vSTSSERVERCLIENTPASSWORD";
         divTablestsclientgettoken_Internalname = "TABLESTSCLIENTGETTOKEN";
         edtavStsserverurl_Internalname = "vSTSSERVERURL";
         edtavStsserverrepositoryguid_Internalname = "vSTSSERVERREPOSITORYGUID";
         divTablestsclient_Internalname = "TABLESTSCLIENT";
         divTablests_Internalname = "TABLESTS";
         divTabpage1table2_Internalname = "TABPAGE1TABLE2";
         lblEnvironment_title_Internalname = "ENVIRONMENT_TITLE";
         edtavEnvironmentname_Internalname = "vENVIRONMENTNAME";
         chkavEnvironmentsecureprotocol_Internalname = "vENVIRONMENTSECUREPROTOCOL";
         edtavEnvironmenthost_Internalname = "vENVIRONMENTHOST";
         edtavEnvironmentport_Internalname = "vENVIRONMENTPORT";
         edtavEnvironmentvirtualdirectory_Internalname = "vENVIRONMENTVIRTUALDIRECTORY";
         edtavEnvironmentprogrampackage_Internalname = "vENVIRONMENTPROGRAMPACKAGE";
         edtavEnvironmentprogramextension_Internalname = "vENVIRONMENTPROGRAMEXTENSION";
         divTabpage1table1_Internalname = "TABPAGE1TABLE1";
         Tab2_Internalname = "TAB2";
         bttBtncancel_Internalname = "BTNCANCEL";
         bttBtnconfirm_Internalname = "BTNCONFIRM";
         chkavAutoregisteranomymoususer_Internalname = "vAUTOREGISTERANOMYMOUSUSER";
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
         chkavAutoregisteranomymoususer.Caption = "Auto Register Anomymous User";
         chkavEnvironmentsecureprotocol.Caption = "Is HTTPS?";
         chkavStsprotocolenable.Caption = "Enable STS protocol?";
         chkavClientaccessuniquebyuser.Caption = "Oauth single user access?";
         chkavClientallowgetsessioniniproprest.Caption = "Can get session initial properties?";
         chkavClientallowgetuseradddatarest.Caption = "Can get user additional data?";
         chkavClientallowgetuserrolesrest.Caption = "Can get user roles?";
         chkavClientallowremoterestauth.Caption = "Allow authentication v.2.0 ?";
         chkavClientallowgetsessioniniprop.Caption = "Can get session initial properties?";
         chkavClientallowgetuseradddata.Caption = "Can get user additional data?";
         chkavClientallowgetuserroles.Caption = "Can get user roles?";
         chkavClientallowremoteauth.Caption = "Allow authentication?";
         chkavAccessrequirespermission.Caption = "Requires Permissions?";
         chkavUseabsoluteurlbyenvironment.Caption = "Use absolute URL by Environment";
         chkavAutoregisteranomymoususer.Enabled = 1;
         chkavAutoregisteranomymoususer.Visible = 1;
         bttBtnconfirm_Caption = "Confirm";
         bttBtnconfirm_Visible = 1;
         edtavEnvironmentprogramextension_Jsonclick = "";
         edtavEnvironmentprogramextension_Enabled = 1;
         edtavEnvironmentprogrampackage_Jsonclick = "";
         edtavEnvironmentprogrampackage_Enabled = 1;
         edtavEnvironmentvirtualdirectory_Jsonclick = "";
         edtavEnvironmentvirtualdirectory_Enabled = 1;
         edtavEnvironmentport_Jsonclick = "";
         edtavEnvironmentport_Enabled = 1;
         edtavEnvironmenthost_Jsonclick = "";
         edtavEnvironmenthost_Enabled = 1;
         chkavEnvironmentsecureprotocol.Enabled = 1;
         edtavEnvironmentname_Jsonclick = "";
         edtavEnvironmentname_Enabled = 1;
         edtavStsserverrepositoryguid_Jsonclick = "";
         edtavStsserverrepositoryguid_Enabled = 1;
         edtavStsserverurl_Jsonclick = "";
         edtavStsserverurl_Enabled = 1;
         divTablestsclient_Visible = 1;
         edtavStsserverclientpassword_Jsonclick = "";
         edtavStsserverclientpassword_Enabled = 1;
         divTablestsclientgettoken_Visible = 1;
         edtavStsauthorizationuserguid_Jsonclick = "";
         edtavStsauthorizationuserguid_Enabled = 1;
         edtavStsauthorizationuserguid_Visible = 1;
         edtavStsauthorizationusername_Jsonclick = "";
         edtavStsauthorizationusername_Enabled = 1;
         divTablestsserverchecktoken_Visible = 1;
         cmbavStsmode_Jsonclick = "";
         cmbavStsmode.Enabled = 1;
         divTablests_Visible = 1;
         chkavStsprotocolenable.Enabled = 1;
         edtavClientrepositoryguid_Jsonclick = "";
         edtavClientrepositoryguid_Enabled = 1;
         bttGeneratekeygamremote_Visible = 1;
         edtavClientencryptionkey_Jsonclick = "";
         edtavClientencryptionkey_Enabled = 1;
         chkavClientaccessuniquebyuser.Enabled = 1;
         divTblgeneralauth_Visible = 1;
         chkavClientallowgetsessioniniproprest.Enabled = 1;
         chkavClientallowgetuseradddatarest.Enabled = 1;
         chkavClientallowgetuserrolesrest.Enabled = 1;
         divTblrestauth_Visible = 1;
         chkavClientallowremoterestauth.Enabled = 1;
         edtavClientcallbackurl_Enabled = 1;
         edtavClientlocalloginurl_Jsonclick = "";
         edtavClientlocalloginurl_Enabled = 1;
         edtavClientimageurl_Jsonclick = "";
         edtavClientimageurl_Enabled = 1;
         chkavClientallowgetsessioniniprop.Enabled = 1;
         chkavClientallowgetuseradddata.Enabled = 1;
         chkavClientallowgetuserroles.Enabled = 1;
         divTblwebauth_Visible = 1;
         chkavClientallowremoteauth.Enabled = 1;
         divAllowcell_Class = "col-xs-12 FormCellSimple";
         edtavClientsecret_Jsonclick = "";
         edtavClientsecret_Enabled = 1;
         edtavClientid_Jsonclick = "";
         edtavClientid_Enabled = 1;
         chkavAccessrequirespermission.Enabled = 1;
         edtavClientrevoked_Jsonclick = "";
         edtavClientrevoked_Enabled = 1;
         cmbavMainmenu_Jsonclick = "";
         cmbavMainmenu.Enabled = 1;
         edtavLogoutobject_Jsonclick = "";
         edtavLogoutobject_Enabled = 1;
         edtavHomeobject_Jsonclick = "";
         edtavHomeobject_Enabled = 1;
         chkavUseabsoluteurlbyenvironment.Enabled = 1;
         edtavCopyright_Jsonclick = "";
         edtavCopyright_Enabled = 1;
         edtavCompany_Jsonclick = "";
         edtavCompany_Enabled = 1;
         edtavVersion_Jsonclick = "";
         edtavVersion_Enabled = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 1;
         edtavGuid_Jsonclick = "";
         edtavGuid_Enabled = 1;
         edtavId_Jsonclick = "";
         edtavId_Enabled = 0;
         lblApplicationstatus_Caption = "Revoke";
         imgImagerevoke_Bitmap = (String)(context.GetImagePath( "b423b6f7-ce34-4e3a-bcfe-788dddb2cbc6", "", context.GetTheme( )));
         lblMenus_Jsonclick = "";
         lblPermissions_Jsonclick = "";
         divTableedit_Visible = 1;
         divActionscontainer_Visible = 1;
         divActionscontainer_Class = "ActionsContainer";
         Tab2_Historymanagement = Convert.ToBoolean( 0);
         Tab2_Class = "Tab";
         Tab2_Pagecount = 4;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Application";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("ENTER","{handler:'E18222',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV48Name',fld:'vNAME',pic:''},{av:'AV29Dsc',fld:'vDSC',pic:''},{av:'AV62Version',fld:'vVERSION',pic:''},{av:'AV28Copyright',fld:'vCOPYRIGHT',pic:''},{av:'AV27Company',fld:'vCOMPANY',pic:''},{av:'AV41HomeObject',fld:'vHOMEOBJECT',pic:''},{av:'AV44LogoutObject',fld:'vLOGOUTOBJECT',pic:''},{av:'cmbavMainmenu'},{av:'AV45MainMenu',fld:'vMAINMENU',pic:'ZZZZZZZZZZZ9'},{av:'AV21ClientId',fld:'vCLIENTID',pic:''},{av:'AV26ClientSecret',fld:'vCLIENTSECRET',pic:''},{av:'AV23ClientLocalLoginURL',fld:'vCLIENTLOCALLOGINURL',pic:''},{av:'AV19ClientCallbackURL',fld:'vCLIENTCALLBACKURL',pic:''},{av:'AV22ClientImageURL',fld:'vCLIENTIMAGEURL',pic:''},{av:'AV20ClientEncryptionKey',fld:'vCLIENTENCRYPTIONKEY',pic:''},{av:'AV24ClientRepositoryGUID',fld:'vCLIENTREPOSITORYGUID',pic:''},{av:'AV53STSAuthorizationUserName',fld:'vSTSAUTHORIZATIONUSERNAME',pic:''},{av:'AV52STSAuthorizationUserGUID',fld:'vSTSAUTHORIZATIONUSERGUID',pic:''},{av:'cmbavStsmode'},{av:'AV54STSMode',fld:'vSTSMODE',pic:''},{av:'AV58STSServerURL',fld:'vSTSSERVERURL',pic:''},{av:'AV56STSServerClientPassword',fld:'vSTSSERVERCLIENTPASSWORD',pic:''},{av:'AV57STSServerRepositoryGUID',fld:'vSTSSERVERREPOSITORYGUID',pic:''},{av:'AV31EnvironmentName',fld:'vENVIRONMENTNAME',pic:''},{av:'AV30EnvironmentHost',fld:'vENVIRONMENTHOST',pic:''},{av:'AV32EnvironmentPort',fld:'vENVIRONMENTPORT',pic:'ZZZZ9'},{av:'AV36EnvironmentVirtualDirectory',fld:'vENVIRONMENTVIRTUALDIRECTORY',pic:''},{av:'AV34EnvironmentProgramPackage',fld:'vENVIRONMENTPROGRAMPACKAGE',pic:''},{av:'AV33EnvironmentProgramExtension',fld:'vENVIRONMENTPROGRAMEXTENSION',pic:''},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV52STSAuthorizationUserGUID',fld:'vSTSAUTHORIZATIONUSERGUID',pic:''},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("'GENERATEKEYGAMREMOTE'","{handler:'E19222',iparms:[{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("'GENERATEKEYGAMREMOTE'",",oparms:[{av:'AV20ClientEncryptionKey',fld:'vCLIENTENCRYPTIONKEY',pic:''},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("'REVOKE-AUTHORIZE'","{handler:'E20222',iparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("'REVOKE-AUTHORIZE'",",oparms:[{av:'lblApplicationstatus_Caption',ctrl:'APPLICATIONSTATUS',prop:'Caption'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("'DELETE'","{handler:'E15221',iparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("'DELETE'",",oparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("'PERMISSIONS'","{handler:'E13221',iparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("'PERMISSIONS'",",oparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("'MENUS'","{handler:'E14221',iparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("'MENUS'",",oparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("'SHOWHIDE'","{handler:'E11221',iparms:[{av:'divActionscontainer_Class',ctrl:'ACTIONSCONTAINER',prop:'Class'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("'SHOWHIDE'",",oparms:[{av:'divActionscontainer_Class',ctrl:'ACTIONSCONTAINER',prop:'Class'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("'EDIT'","{handler:'E12221',iparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("'EDIT'",",oparms:[{av:'AV42Id',fld:'vID',pic:'ZZZZZZZZZZZ9'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("VSTSMODE.CLICK","{handler:'E16221',iparms:[{av:'cmbavStsmode'},{av:'AV54STSMode',fld:'vSTSMODE',pic:''},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("VSTSMODE.CLICK",",oparms:[{av:'divTablestsserverchecktoken_Visible',ctrl:'TABLESTSSERVERCHECKTOKEN',prop:'Visible'},{av:'divTablestsclientgettoken_Visible',ctrl:'TABLESTSCLIENTGETTOKEN',prop:'Visible'},{av:'divTablestsclient_Visible',ctrl:'TABLESTSCLIENT',prop:'Visible'},{av:'divAllowcell_Class',ctrl:'ALLOWCELL',prop:'Class'},{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("VALIDV_CLIENTREVOKED","{handler:'Validv_Clientrevoked',iparms:[{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("VALIDV_CLIENTREVOKED",",oparms:[{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
         setEventMetadata("VALIDV_STSMODE","{handler:'Validv_Stsmode',iparms:[{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]");
         setEventMetadata("VALIDV_STSMODE",",oparms:[{av:'AV59UseAbsoluteUrlByEnvironment',fld:'vUSEABSOLUTEURLBYENVIRONMENT',pic:''},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:''},{av:'AV17ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:''},{av:'AV15ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:''},{av:'AV13ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:''},{av:'AV11ClientAllowGetSessionIniProp',fld:'vCLIENTALLOWGETSESSIONINIPROP',pic:''},{av:'AV18ClientAllowRemoteRestAuth',fld:'vCLIENTALLOWREMOTERESTAUTH',pic:''},{av:'AV16ClientAllowGetUserRolesRest',fld:'vCLIENTALLOWGETUSERROLESREST',pic:''},{av:'AV14ClientAllowGetUserAddDataRest',fld:'vCLIENTALLOWGETUSERADDDATAREST',pic:''},{av:'AV12ClientAllowGetSessionIniPropRest',fld:'vCLIENTALLOWGETSESSIONINIPROPREST',pic:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:''},{av:'AV55STSProtocolEnable',fld:'vSTSPROTOCOLENABLE',pic:''},{av:'AV35EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:''},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:''}]}");
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
         lblTextblock2_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttShowhide_Jsonclick = "";
         sImgUrl = "";
         lblTextblock1_Jsonclick = "";
         lblApplicationstatus_Jsonclick = "";
         lblDeleteapp_Jsonclick = "";
         ucTab2 = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         AV40GUID = "";
         AV48Name = "";
         AV29Dsc = "";
         AV62Version = "";
         AV27Company = "";
         AV28Copyright = "";
         AV41HomeObject = "";
         AV44LogoutObject = "";
         AV25ClientRevoked = (DateTime)(DateTime.MinValue);
         lblTabpage3_title_Jsonclick = "";
         AV21ClientId = "";
         AV26ClientSecret = "";
         lblTextblock4_Jsonclick = "";
         AV22ClientImageURL = "";
         AV23ClientLocalLoginURL = "";
         AV19ClientCallbackURL = "";
         lblTextblock5_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         AV20ClientEncryptionKey = "";
         bttGeneratekeygamremote_Jsonclick = "";
         AV24ClientRepositoryGUID = "";
         lblSts_title_Jsonclick = "";
         AV54STSMode = "";
         AV53STSAuthorizationUserName = "";
         AV52STSAuthorizationUserGUID = "";
         AV56STSServerClientPassword = "";
         AV58STSServerURL = "";
         AV57STSServerRepositoryGUID = "";
         lblEnvironment_title_Jsonclick = "";
         AV31EnvironmentName = "";
         AV30EnvironmentHost = "";
         AV36EnvironmentVirtualDirectory = "";
         AV34EnvironmentProgramPackage = "";
         AV33EnvironmentProgramExtension = "";
         bttBtncancel_Jsonclick = "";
         bttBtnconfirm_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV60User = new GeneXus.Programs.genexussecurity.SdtGAMUser(context);
         AV6Application = new GeneXus.Programs.genexussecurity.SdtGAMApplication(context);
         AV67GXV1 = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMApplicationMenu>( context, "GeneXus.Programs.genexussecurity.SdtGAMApplicationMenu", "GeneXus.Programs");
         AV47MenuFilter = new GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuFilter(context);
         AV38Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV46Menu = new GeneXus.Programs.genexussecurity.SdtGAMApplicationMenu(context);
         AV39GAMUser = new GeneXus.Programs.genexussecurity.SdtGAMUser(context);
         AV61UserErrors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV37Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamexampleapplicationentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamexampleapplicationentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         edtavGuid_Enabled = 0;
         edtavClientrevoked_Enabled = 0;
         edtavStsauthorizationuserguid_Enabled = 0;
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
      private int Tab2_Pagecount ;
      private int divActionscontainer_Visible ;
      private int divTableedit_Visible ;
      private int edtavId_Enabled ;
      private int edtavGuid_Enabled ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavVersion_Enabled ;
      private int edtavCompany_Enabled ;
      private int edtavCopyright_Enabled ;
      private int edtavHomeobject_Enabled ;
      private int edtavLogoutobject_Enabled ;
      private int edtavClientrevoked_Enabled ;
      private int edtavClientid_Enabled ;
      private int edtavClientsecret_Enabled ;
      private int divTblwebauth_Visible ;
      private int edtavClientimageurl_Enabled ;
      private int edtavClientlocalloginurl_Enabled ;
      private int edtavClientcallbackurl_Enabled ;
      private int divTblrestauth_Visible ;
      private int divTblgeneralauth_Visible ;
      private int edtavClientencryptionkey_Enabled ;
      private int bttGeneratekeygamremote_Visible ;
      private int edtavClientrepositoryguid_Enabled ;
      private int divTablests_Visible ;
      private int divTablestsserverchecktoken_Visible ;
      private int edtavStsauthorizationusername_Enabled ;
      private int edtavStsauthorizationuserguid_Visible ;
      private int edtavStsauthorizationuserguid_Enabled ;
      private int divTablestsclientgettoken_Visible ;
      private int edtavStsserverclientpassword_Enabled ;
      private int divTablestsclient_Visible ;
      private int edtavStsserverurl_Enabled ;
      private int edtavStsserverrepositoryguid_Enabled ;
      private int edtavEnvironmentname_Enabled ;
      private int edtavEnvironmenthost_Enabled ;
      private int AV32EnvironmentPort ;
      private int edtavEnvironmentport_Enabled ;
      private int edtavEnvironmentvirtualdirectory_Enabled ;
      private int edtavEnvironmentprogrampackage_Enabled ;
      private int edtavEnvironmentprogramextension_Enabled ;
      private int bttBtnconfirm_Visible ;
      private int AV68GXV2 ;
      private int AV69GXV3 ;
      private int AV70GXV4 ;
      private int idxLst ;
      private long AV42Id ;
      private long wcpOAV42Id ;
      private long AV45MainMenu ;
      private String Gx_mode ;
      private String wcpOGx_mode ;
      private String divActionscontainer_Class ;
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
      private String divTable3_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttShowhide_Internalname ;
      private String bttShowhide_Jsonclick ;
      private String divActionscontainer_Internalname ;
      private String divTableedit_Internalname ;
      private String sImgUrl ;
      private String imgImage1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String divTable6_Internalname ;
      private String imgImageprm_Internalname ;
      private String lblPermissions_Internalname ;
      private String lblPermissions_Jsonclick ;
      private String divTable4_Internalname ;
      private String imgImagemenu_Internalname ;
      private String lblMenus_Internalname ;
      private String lblMenus_Jsonclick ;
      private String divTable7_Internalname ;
      private String imgImagerevoke_Internalname ;
      private String lblApplicationstatus_Internalname ;
      private String lblApplicationstatus_Caption ;
      private String lblApplicationstatus_Jsonclick ;
      private String divTable5_Internalname ;
      private String imgImagedlt_Internalname ;
      private String lblDeleteapp_Internalname ;
      private String lblDeleteapp_Jsonclick ;
      private String Tab2_Internalname ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String edtavId_Internalname ;
      private String edtavId_Jsonclick ;
      private String edtavGuid_Internalname ;
      private String AV40GUID ;
      private String edtavGuid_Jsonclick ;
      private String edtavName_Internalname ;
      private String AV48Name ;
      private String edtavName_Jsonclick ;
      private String edtavDsc_Internalname ;
      private String AV29Dsc ;
      private String edtavDsc_Jsonclick ;
      private String edtavVersion_Internalname ;
      private String AV62Version ;
      private String edtavVersion_Jsonclick ;
      private String edtavCompany_Internalname ;
      private String AV27Company ;
      private String edtavCompany_Jsonclick ;
      private String edtavCopyright_Internalname ;
      private String AV28Copyright ;
      private String edtavCopyright_Jsonclick ;
      private String chkavUseabsoluteurlbyenvironment_Internalname ;
      private String edtavHomeobject_Internalname ;
      private String edtavHomeobject_Jsonclick ;
      private String edtavLogoutobject_Internalname ;
      private String edtavLogoutobject_Jsonclick ;
      private String cmbavMainmenu_Internalname ;
      private String cmbavMainmenu_Jsonclick ;
      private String edtavClientrevoked_Internalname ;
      private String edtavClientrevoked_Jsonclick ;
      private String chkavAccessrequirespermission_Internalname ;
      private String lblTabpage3_title_Internalname ;
      private String lblTabpage3_title_Jsonclick ;
      private String divTabpage3table_Internalname ;
      private String edtavClientid_Internalname ;
      private String AV21ClientId ;
      private String edtavClientid_Jsonclick ;
      private String edtavClientsecret_Internalname ;
      private String AV26ClientSecret ;
      private String edtavClientsecret_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String divAllowcell_Internalname ;
      private String divAllowcell_Class ;
      private String chkavClientallowremoteauth_Internalname ;
      private String divTblwebauth_Internalname ;
      private String chkavClientallowgetuserroles_Internalname ;
      private String chkavClientallowgetuseradddata_Internalname ;
      private String chkavClientallowgetsessioniniprop_Internalname ;
      private String edtavClientimageurl_Internalname ;
      private String edtavClientimageurl_Jsonclick ;
      private String edtavClientlocalloginurl_Internalname ;
      private String edtavClientlocalloginurl_Jsonclick ;
      private String edtavClientcallbackurl_Internalname ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String chkavClientallowremoterestauth_Internalname ;
      private String divTblrestauth_Internalname ;
      private String chkavClientallowgetuserrolesrest_Internalname ;
      private String chkavClientallowgetuseradddatarest_Internalname ;
      private String chkavClientallowgetsessioniniproprest_Internalname ;
      private String divTblgeneralauth_Internalname ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String chkavClientaccessuniquebyuser_Internalname ;
      private String edtavClientencryptionkey_Internalname ;
      private String AV20ClientEncryptionKey ;
      private String edtavClientencryptionkey_Jsonclick ;
      private String bttGeneratekeygamremote_Internalname ;
      private String bttGeneratekeygamremote_Jsonclick ;
      private String edtavClientrepositoryguid_Internalname ;
      private String AV24ClientRepositoryGUID ;
      private String edtavClientrepositoryguid_Jsonclick ;
      private String lblSts_title_Internalname ;
      private String lblSts_title_Jsonclick ;
      private String divTabpage1table2_Internalname ;
      private String chkavStsprotocolenable_Internalname ;
      private String divTablests_Internalname ;
      private String cmbavStsmode_Internalname ;
      private String AV54STSMode ;
      private String cmbavStsmode_Jsonclick ;
      private String divTablestsserverchecktoken_Internalname ;
      private String edtavStsauthorizationusername_Internalname ;
      private String edtavStsauthorizationusername_Jsonclick ;
      private String edtavStsauthorizationuserguid_Internalname ;
      private String AV52STSAuthorizationUserGUID ;
      private String edtavStsauthorizationuserguid_Jsonclick ;
      private String divTablestsclientgettoken_Internalname ;
      private String edtavStsserverclientpassword_Internalname ;
      private String AV56STSServerClientPassword ;
      private String edtavStsserverclientpassword_Jsonclick ;
      private String divTablestsclient_Internalname ;
      private String edtavStsserverurl_Internalname ;
      private String edtavStsserverurl_Jsonclick ;
      private String edtavStsserverrepositoryguid_Internalname ;
      private String AV57STSServerRepositoryGUID ;
      private String edtavStsserverrepositoryguid_Jsonclick ;
      private String lblEnvironment_title_Internalname ;
      private String lblEnvironment_title_Jsonclick ;
      private String divTabpage1table1_Internalname ;
      private String edtavEnvironmentname_Internalname ;
      private String AV31EnvironmentName ;
      private String edtavEnvironmentname_Jsonclick ;
      private String chkavEnvironmentsecureprotocol_Internalname ;
      private String edtavEnvironmenthost_Internalname ;
      private String AV30EnvironmentHost ;
      private String edtavEnvironmenthost_Jsonclick ;
      private String edtavEnvironmentport_Internalname ;
      private String edtavEnvironmentport_Jsonclick ;
      private String edtavEnvironmentvirtualdirectory_Internalname ;
      private String AV36EnvironmentVirtualDirectory ;
      private String edtavEnvironmentvirtualdirectory_Jsonclick ;
      private String edtavEnvironmentprogrampackage_Internalname ;
      private String AV34EnvironmentProgramPackage ;
      private String edtavEnvironmentprogrampackage_Jsonclick ;
      private String edtavEnvironmentprogramextension_Internalname ;
      private String AV33EnvironmentProgramExtension ;
      private String edtavEnvironmentprogramextension_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String bttBtnconfirm_Internalname ;
      private String bttBtnconfirm_Caption ;
      private String bttBtnconfirm_Jsonclick ;
      private String chkavAutoregisteranomymoususer_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private DateTime AV25ClientRevoked ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Tab2_Historymanagement ;
      private bool wbLoad ;
      private bool AV59UseAbsoluteUrlByEnvironment ;
      private bool AV5AccessRequiresPermission ;
      private bool AV17ClientAllowRemoteAuth ;
      private bool AV15ClientAllowGetUserRoles ;
      private bool AV13ClientAllowGetUserAddData ;
      private bool AV11ClientAllowGetSessionIniProp ;
      private bool AV18ClientAllowRemoteRestAuth ;
      private bool AV16ClientAllowGetUserRolesRest ;
      private bool AV14ClientAllowGetUserAddDataRest ;
      private bool AV12ClientAllowGetSessionIniPropRest ;
      private bool AV8ClientAccessUniqueByUser ;
      private bool AV55STSProtocolEnable ;
      private bool AV35EnvironmentSecureProtocol ;
      private bool AV7AutoRegisterAnomymousUser ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV43isOk ;
      private String AV19ClientCallbackURL ;
      private String AV41HomeObject ;
      private String AV44LogoutObject ;
      private String AV22ClientImageURL ;
      private String AV23ClientLocalLoginURL ;
      private String AV53STSAuthorizationUserName ;
      private String AV58STSServerURL ;
      private String imgImagerevoke_Bitmap ;
      private GXUserControl ucTab2 ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private String aP0_Gx_mode ;
      private long aP1_Id ;
      private GXCheckbox chkavUseabsoluteurlbyenvironment ;
      private GXCombobox cmbavMainmenu ;
      private GXCheckbox chkavAccessrequirespermission ;
      private GXCheckbox chkavClientallowremoteauth ;
      private GXCheckbox chkavClientallowgetuserroles ;
      private GXCheckbox chkavClientallowgetuseradddata ;
      private GXCheckbox chkavClientallowgetsessioniniprop ;
      private GXCheckbox chkavClientallowremoterestauth ;
      private GXCheckbox chkavClientallowgetuserrolesrest ;
      private GXCheckbox chkavClientallowgetuseradddatarest ;
      private GXCheckbox chkavClientallowgetsessioniniproprest ;
      private GXCheckbox chkavClientaccessuniquebyuser ;
      private GXCheckbox chkavStsprotocolenable ;
      private GXCombobox cmbavStsmode ;
      private GXCheckbox chkavEnvironmentsecureprotocol ;
      private GXCheckbox chkavAutoregisteranomymoususer ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV38Errors ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV61UserErrors ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMApplicationMenu> AV67GXV1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplication AV6Application ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV37Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplicationMenu AV46Menu ;
      private GeneXus.Programs.genexussecurity.SdtGAMApplicationMenuFilter AV47MenuFilter ;
      private GeneXus.Programs.genexussecurity.SdtGAMUser AV60User ;
      private GeneXus.Programs.genexussecurity.SdtGAMUser AV39GAMUser ;
   }

   public class gamexampleapplicationentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamexampleapplicationentry__default : DataStoreHelperBase, IDataStoreHelper
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
