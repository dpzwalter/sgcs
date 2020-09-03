/*
               File: GAMExampleUserEntry
        Description: User
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:5:51.19
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
   public class gamexampleuserentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamexampleuserentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamexampleuserentry( IGxContext context )
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
                           ref String aP1_UserId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV44UserId = aP1_UserId;
         executePrivate();
         aP0_Gx_mode=this.Gx_mode;
         aP1_UserId=this.AV44UserId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavAuthenticationtypename = new GXCombobox();
         cmbavGender = new GXCombobox();
         chkavIsactive = new GXCheckbox();
         chkavDontreceiveinformation = new GXCheckbox();
         chkavCannotchangepassword = new GXCheckbox();
         chkavMustchangepassword = new GXCheckbox();
         chkavPasswordneverexpires = new GXCheckbox();
         chkavIsblocked = new GXCheckbox();
         cmbavSecuritypolicyid = new GXCombobox();
         chkavIsenabledinrepository = new GXCheckbox();
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
                  AV44UserId = GetNextPar( );
                  AssignAttri("", false, "AV44UserId", AV44UserId);
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
         PA152( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START152( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20204151155185", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 138086), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamexampleuserentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV44UserId))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vSTRING", AV41String);
         GxWebStd.gx_hidden_field( context, "ACTIONSCONTAINER_Class", StringUtil.RTrim( divActionscontainer_Class));
         GxWebStd.gx_hidden_field( context, "TBGO_Link", StringUtil.RTrim( lblTbgo_Link));
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
            WE152( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT152( ) ;
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
         return formatLink("gamexampleuserentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV44UserId)) ;
      }

      public override String GetPgmname( )
      {
         return "GAMExampleUserEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "User" ;
      }

      protected void WB150( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7 col-sm-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "User", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5 col-sm-12 hidden-sm hidden-md hidden-lg", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttShowhide_Internalname, "", "Actions", bttShowhide_Jsonclick, 7, "Actions", "", StyleString, ClassString, bttShowhide_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e11151_client"+"'", TempTags, "", 2, "HLP_GAMExampleUserEntry.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-sm-push-8 col-md-3 col-md-push-9", "left", "top", "", "", "div");
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
            GxWebStd.gx_bitmap( context, imgImage4_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Edit", "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12151_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleUserEntry.htm");
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
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "ActionsContainerItem", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "left", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "baac128e-62aa-4a75-8034-3bc742d1fc6c", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImage5_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPermission_Internalname, "Permissions", "", "", lblPermission_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13151_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleUserEntry.htm");
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
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "ActionsContainerItem", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "left", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "e32d92b4-38bb-48a0-babd-8d4f08d9a852", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblChangeroles_Internalname, "Roles", "", "", lblChangeroles_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14151_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
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
            GxWebStd.gx_bitmap( context, imgImage3_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblChangepassword_Internalname, "Change Password", "", "", lblChangepassword_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15151_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
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
            GxWebStd.gx_bitmap( context, imgImage2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDeleteuser_Internalname, "Delete User", "", "", lblDeleteuser_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'DELETE\\'."+"'", "", "ActionText TextLikeLink", 5, "", 1, 1, 0, "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7 col-sm-offset-1 col-sm-pull-4 col-md-8 col-md-pull-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPhotocell_Internalname, divPhotocell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, "", "Photo", "col-sm-5 ProfileImageAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ProfileImageAttribute";
            StyleString = "";
            AV36Photo_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV36Photo))&&String.IsNullOrEmpty(StringUtil.RTrim( AV55Photo_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV36Photo)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV36Photo)) ? AV55Photo_GXI : context.PathToRelativeUrl( AV36Photo));
            GxWebStd.gx_bitmap( context, imgavPhoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, AV36Photo_IsBlob, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserid_Internalname, "GUID", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavUserid_Internalname, StringUtil.RTrim( AV44UserId), StringUtil.RTrim( context.localUtil.Format( AV44UserId, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserid_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMGUID", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUsernamespace_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUsernamespace_Internalname, "Name Space", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsernamespace_Internalname, StringUtil.RTrim( AV45UserNameSpace), StringUtil.RTrim( context.localUtil.Format( AV45UserNameSpace, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsernamespace_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUsernamespace_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMRepositoryNameSpace", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", cmbavAuthenticationtypename.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavAuthenticationtypename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavAuthenticationtypename_Internalname, "Authentication Type", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavAuthenticationtypename, cmbavAuthenticationtypename_Internalname, StringUtil.RTrim( AV7AuthenticationTypeName), 1, cmbavAuthenticationtypename_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", cmbavAuthenticationtypename.Visible, cmbavAuthenticationtypename.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,78);\"", "", true, "HLP_GAMExampleUserEntry.htm");
            cmbavAuthenticationtypename.CurrentValue = StringUtil.RTrim( AV7AuthenticationTypeName);
            AssignProp("", false, cmbavAuthenticationtypename_Internalname, "Values", (String)(cmbavAuthenticationtypename.ToJavascriptSource()), true);
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
            GxWebStd.gx_label_element( context, edtavName_Internalname, "User Name", "col-sm-5 RequiredAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, AV31Name, StringUtil.RTrim( context.localUtil.Format( AV31Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "RequiredAttribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMUserIdentification", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEmail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEmail_Internalname, "EMail", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEmail_Internalname, AV16EMail, StringUtil.RTrim( context.localUtil.Format( AV16EMail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,88);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmail_Jsonclick, 0, edtavEmail_Class, "", "", "", "", 1, edtavEmail_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMEMail", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasscell_Internalname, divPasscell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavPassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPassword_Internalname, "Password", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPassword_Internalname, StringUtil.RTrim( AV32Password), StringUtil.RTrim( context.localUtil.Format( AV32Password, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,93);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPassword_Jsonclick, 0, edtavPassword_Class, "", "", "", "", 1, edtavPassword_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, -1, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMPassword", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPassconfcell_Internalname, divPassconfcell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavPasswordconf_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPasswordconf_Internalname, "Password confirmation", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPasswordconf_Internalname, StringUtil.RTrim( AV33PasswordConf), StringUtil.RTrim( context.localUtil.Format( AV33PasswordConf, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPasswordconf_Jsonclick, 0, edtavPasswordconf_Class, "", "", "", "", 1, edtavPasswordconf_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, -1, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMPassword", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavFirstname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFirstname_Internalname, "First Name", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFirstname_Internalname, StringUtil.RTrim( AV21FirstName), StringUtil.RTrim( context.localUtil.Format( AV21FirstName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFirstname_Jsonclick, 0, edtavFirstname_Class, "", "", "", "", 1, edtavFirstname_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavLastname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavLastname_Internalname, "Last Name", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavLastname_Internalname, StringUtil.RTrim( AV29LastName), StringUtil.RTrim( context.localUtil.Format( AV29LastName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,108);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavLastname_Jsonclick, 0, edtavLastname_Class, "", "", "", "", 1, edtavLastname_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionShort", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavExternalid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavExternalid_Internalname, "External Id", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavExternalid_Internalname, AV19ExternalId, StringUtil.RTrim( context.localUtil.Format( AV19ExternalId, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,113);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavExternalid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavExternalid_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GeneXusSecurityCommon\\GAMUserIdentification", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBirthday_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBirthday_Internalname, "Birthday", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBirthday_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBirthday_Internalname, context.localUtil.Format(AV11Birthday, "99/99/9999"), context.localUtil.Format( AV11Birthday, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,118);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBirthday_Jsonclick, 0, edtavBirthday_Class, "", "", "", "", 1, edtavBirthday_Enabled, 1, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMDate", "right", false, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_bitmap( context, edtavBirthday_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBirthday_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_GAMExampleUserEntry.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavGender_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavGender_Internalname, "Gender", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavGender, cmbavGender_Internalname, StringUtil.RTrim( AV22Gender), 1, cmbavGender_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavGender.Enabled, 1, 0, 0, "em", 0, "", "", cmbavGender_Class, "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,123);\"", "", true, "HLP_GAMExampleUserEntry.htm");
            cmbavGender.CurrentValue = StringUtil.RTrim( AV22Gender);
            AssignProp("", false, cmbavGender_Internalname, "Values", (String)(cmbavGender.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUrlcell_Internalname, divUrlcell_Visible, 0, "px", 0, "px", "col-xs-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUrlprofile_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUrlprofile_Internalname, "URLProfile", "col-sm-6 URLAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUrlprofile_Internalname, AV42URLProfile, StringUtil.RTrim( context.localUtil.Format( AV42URLProfile, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,128);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUrlprofile_Jsonclick, 0, "URLAttribute", "", "", "", "", 1, edtavUrlprofile_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMURL", "left", true, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGocell_Internalname, divGocell_Visible, 0, "px", 0, "px", "col-xs-2", "Center", "Middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbgo_Internalname, "GO", lblTbgo_Link, "", lblTbgo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "Center", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divImagecell_Internalname, divImagecell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgavImage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, "", "External Image", "col-sm-5 ImageAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV23Image_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV23Image))&&String.IsNullOrEmpty(StringUtil.RTrim( AV52Image_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV23Image)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV23Image)) ? AV52Image_GXI : context.PathToRelativeUrl( AV23Image));
            GxWebStd.gx_bitmap( context, imgavImage_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgavImage_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, AV23Image_IsBlob, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divIsactivecell_Internalname, divIsactivecell_Visible, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavIsactive_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavIsactive_Internalname, "Account is active?", "col-sm-10 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-2 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavIsactive_Internalname, StringUtil.BoolToStr( AV24IsActive), "", "Account is active?", 1, chkavIsactive.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(140, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,140);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divActivationdatecell_Internalname, divActivationdatecell_Visible, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavActivationdate_Internalname, "Activation Date", "col-sm-5 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavActivationdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavActivationdate_Internalname, context.localUtil.TToC( AV5ActivationDate, 10, 8, 1, 2, "/", ":", " "), context.localUtil.Format( AV5ActivationDate, "99/99/9999 99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'MDY',5,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'MDY',5,12,'eng',false,0);"+";gx.evt.onblur(this,143);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavActivationdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavActivationdate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "GeneXusSecurityCommon\\GAMDateTime", "right", false, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_bitmap( context, edtavActivationdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavActivationdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_GAMExampleUserEntry.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavDontreceiveinformation_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavDontreceiveinformation_Internalname, "Don't want to receive information", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 148,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDontreceiveinformation_Internalname, StringUtil.BoolToStr( AV15DontReceiveInformation), "", "Don't want to receive information", 1, chkavDontreceiveinformation.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(148, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,148);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavCannotchangepassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCannotchangepassword_Internalname, "Cannot change password", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 153,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCannotchangepassword_Internalname, StringUtil.BoolToStr( AV13CannotChangePassword), "", "Cannot change password", 1, chkavCannotchangepassword.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(153, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,153);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavMustchangepassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavMustchangepassword_Internalname, "Must change password", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavMustchangepassword_Internalname, StringUtil.BoolToStr( AV30MustChangePassword), "", "Must change password", 1, chkavMustchangepassword.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(158, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,158);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavPasswordneverexpires_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavPasswordneverexpires_Internalname, "Password never expires", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 163,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavPasswordneverexpires_Internalname, StringUtil.BoolToStr( AV35PasswordNeverExpires), "", "Password never expires", 1, chkavPasswordneverexpires.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(163, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,163);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavIsblocked_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavIsblocked_Internalname, "User is blocked", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 168,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavIsblocked_Internalname, StringUtil.BoolToStr( AV25IsBlocked), "", "User is blocked", 1, chkavIsblocked.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(168, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,168);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavSecuritypolicyid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavSecuritypolicyid_Internalname, "Security policy", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 173,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavSecuritypolicyid, cmbavSecuritypolicyid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV40SecurityPolicyId), 9, 0)), 1, cmbavSecuritypolicyid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavSecuritypolicyid.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,173);\"", "", true, "HLP_GAMExampleUserEntry.htm");
            cmbavSecuritypolicyid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV40SecurityPolicyId), 9, 0));
            AssignProp("", false, cmbavSecuritypolicyid_Internalname, "Values", (String)(cmbavSecuritypolicyid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavIsenabledinrepository_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavIsenabledinrepository_Internalname, "Enabled in repository", "col-sm-5 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 178,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavIsenabledinrepository_Internalname, StringUtil.BoolToStr( AV26IsEnabledInRepository), "", "Enabled in repository", 1, chkavIsenabledinrepository.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(178, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,178);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLastauthcell_Internalname, divLastauthcell_Visible, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavDatelastauthentication_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDatelastauthentication_Internalname, "Last authentication", "col-sm-5 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 183,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDatelastauthentication_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDatelastauthentication_Internalname, context.localUtil.TToC( AV14DateLastAuthentication, 10, 8, 1, 2, "/", ":", " "), context.localUtil.Format( AV14DateLastAuthentication, "99/99/99 99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',5,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',5,12,'eng',false,0);"+";gx.evt.onblur(this,183);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDatelastauthentication_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDatelastauthentication_Enabled, 0, "text", "", 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_bitmap( context, edtavDatelastauthentication_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavDatelastauthentication_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_GAMExampleUserEntry.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 188,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Cancel", bttBtncancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 190,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "", bttBtnconfirm_Caption, bttBtnconfirm_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtnconfirm_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START152( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "User", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP150( ) ;
      }

      protected void WS152( )
      {
         START152( ) ;
         EVT152( ) ;
      }

      protected void EVT152( )
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
                              E16152 ();
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
                                    E17152 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VAUTHENTICATIONTYPENAME.ISVALID") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DELETE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Delete' */
                              E19152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E20152 ();
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

      protected void WE152( )
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

      protected void PA152( )
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
               GX_FocusControl = edtavUsernamespace_Internalname;
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
         if ( cmbavAuthenticationtypename.ItemCount > 0 )
         {
            AV7AuthenticationTypeName = cmbavAuthenticationtypename.getValidValue(AV7AuthenticationTypeName);
            AssignAttri("", false, "AV7AuthenticationTypeName", AV7AuthenticationTypeName);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavAuthenticationtypename.CurrentValue = StringUtil.RTrim( AV7AuthenticationTypeName);
            AssignProp("", false, cmbavAuthenticationtypename_Internalname, "Values", cmbavAuthenticationtypename.ToJavascriptSource(), true);
         }
         if ( cmbavGender.ItemCount > 0 )
         {
            AV22Gender = cmbavGender.getValidValue(AV22Gender);
            AssignAttri("", false, "AV22Gender", AV22Gender);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavGender.CurrentValue = StringUtil.RTrim( AV22Gender);
            AssignProp("", false, cmbavGender_Internalname, "Values", cmbavGender.ToJavascriptSource(), true);
         }
         AV24IsActive = StringUtil.StrToBool( StringUtil.BoolToStr( AV24IsActive));
         AssignAttri("", false, "AV24IsActive", AV24IsActive);
         AV15DontReceiveInformation = StringUtil.StrToBool( StringUtil.BoolToStr( AV15DontReceiveInformation));
         AssignAttri("", false, "AV15DontReceiveInformation", AV15DontReceiveInformation);
         AV13CannotChangePassword = StringUtil.StrToBool( StringUtil.BoolToStr( AV13CannotChangePassword));
         AssignAttri("", false, "AV13CannotChangePassword", AV13CannotChangePassword);
         AV30MustChangePassword = StringUtil.StrToBool( StringUtil.BoolToStr( AV30MustChangePassword));
         AssignAttri("", false, "AV30MustChangePassword", AV30MustChangePassword);
         AV35PasswordNeverExpires = StringUtil.StrToBool( StringUtil.BoolToStr( AV35PasswordNeverExpires));
         AssignAttri("", false, "AV35PasswordNeverExpires", AV35PasswordNeverExpires);
         AV25IsBlocked = StringUtil.StrToBool( StringUtil.BoolToStr( AV25IsBlocked));
         AssignAttri("", false, "AV25IsBlocked", AV25IsBlocked);
         if ( cmbavSecuritypolicyid.ItemCount > 0 )
         {
            AV40SecurityPolicyId = (int)(NumberUtil.Val( cmbavSecuritypolicyid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV40SecurityPolicyId), 9, 0))), "."));
            AssignAttri("", false, "AV40SecurityPolicyId", StringUtil.LTrimStr( (decimal)(AV40SecurityPolicyId), 9, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavSecuritypolicyid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV40SecurityPolicyId), 9, 0));
            AssignProp("", false, cmbavSecuritypolicyid_Internalname, "Values", cmbavSecuritypolicyid.ToJavascriptSource(), true);
         }
         AV26IsEnabledInRepository = StringUtil.StrToBool( StringUtil.BoolToStr( AV26IsEnabledInRepository));
         AssignAttri("", false, "AV26IsEnabledInRepository", AV26IsEnabledInRepository);
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF152( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavUserid_Enabled = 0;
         AssignProp("", false, edtavUserid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserid_Enabled), 5, 0), true);
         edtavUsernamespace_Enabled = 0;
         AssignProp("", false, edtavUsernamespace_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUsernamespace_Enabled), 5, 0), true);
         edtavActivationdate_Enabled = 0;
         AssignProp("", false, edtavActivationdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavActivationdate_Enabled), 5, 0), true);
         edtavDatelastauthentication_Enabled = 0;
         AssignProp("", false, edtavDatelastauthentication_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDatelastauthentication_Enabled), 5, 0), true);
      }

      protected void RF152( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E20152 ();
            WB150( ) ;
         }
      }

      protected void send_integrity_lvl_hashes152( )
      {
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void STRUP150( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavUserid_Enabled = 0;
         AssignProp("", false, edtavUserid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUserid_Enabled), 5, 0), true);
         edtavUsernamespace_Enabled = 0;
         AssignProp("", false, edtavUsernamespace_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUsernamespace_Enabled), 5, 0), true);
         edtavActivationdate_Enabled = 0;
         AssignProp("", false, edtavActivationdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavActivationdate_Enabled), 5, 0), true);
         edtavDatelastauthentication_Enabled = 0;
         AssignProp("", false, edtavDatelastauthentication_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDatelastauthentication_Enabled), 5, 0), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E16152 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            AV41String = cgiGet( "vSTRING");
            lblTbgo_Link = cgiGet( "TBGO_Link");
            /* Read variables values. */
            AV36Photo = cgiGet( imgavPhoto_Internalname);
            AV44UserId = cgiGet( edtavUserid_Internalname);
            AssignAttri("", false, "AV44UserId", AV44UserId);
            AV45UserNameSpace = cgiGet( edtavUsernamespace_Internalname);
            AssignAttri("", false, "AV45UserNameSpace", AV45UserNameSpace);
            cmbavAuthenticationtypename.CurrentValue = cgiGet( cmbavAuthenticationtypename_Internalname);
            AV7AuthenticationTypeName = cgiGet( cmbavAuthenticationtypename_Internalname);
            AssignAttri("", false, "AV7AuthenticationTypeName", AV7AuthenticationTypeName);
            AV31Name = cgiGet( edtavName_Internalname);
            AssignAttri("", false, "AV31Name", AV31Name);
            AV16EMail = cgiGet( edtavEmail_Internalname);
            AssignAttri("", false, "AV16EMail", AV16EMail);
            AV32Password = cgiGet( edtavPassword_Internalname);
            AssignAttri("", false, "AV32Password", AV32Password);
            AV33PasswordConf = cgiGet( edtavPasswordconf_Internalname);
            AssignAttri("", false, "AV33PasswordConf", AV33PasswordConf);
            AV21FirstName = cgiGet( edtavFirstname_Internalname);
            AssignAttri("", false, "AV21FirstName", AV21FirstName);
            AV29LastName = cgiGet( edtavLastname_Internalname);
            AssignAttri("", false, "AV29LastName", AV29LastName);
            AV19ExternalId = cgiGet( edtavExternalid_Internalname);
            AssignAttri("", false, "AV19ExternalId", AV19ExternalId);
            if ( context.localUtil.VCDate( cgiGet( edtavBirthday_Internalname), 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Birthday"}), 1, "vBIRTHDAY");
               GX_FocusControl = edtavBirthday_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11Birthday = DateTime.MinValue;
               AssignAttri("", false, "AV11Birthday", context.localUtil.Format(AV11Birthday, "99/99/9999"));
            }
            else
            {
               AV11Birthday = context.localUtil.CToD( cgiGet( edtavBirthday_Internalname), 1);
               AssignAttri("", false, "AV11Birthday", context.localUtil.Format(AV11Birthday, "99/99/9999"));
            }
            cmbavGender.CurrentValue = cgiGet( cmbavGender_Internalname);
            AV22Gender = cgiGet( cmbavGender_Internalname);
            AssignAttri("", false, "AV22Gender", AV22Gender);
            AV42URLProfile = cgiGet( edtavUrlprofile_Internalname);
            AssignAttri("", false, "AV42URLProfile", AV42URLProfile);
            AV23Image = cgiGet( imgavImage_Internalname);
            AV24IsActive = StringUtil.StrToBool( cgiGet( chkavIsactive_Internalname));
            AssignAttri("", false, "AV24IsActive", AV24IsActive);
            if ( context.localUtil.VCDateTime( cgiGet( edtavActivationdate_Internalname), 1, 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Activation Date"}), 1, "vACTIVATIONDATE");
               GX_FocusControl = edtavActivationdate_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5ActivationDate = (DateTime)(DateTime.MinValue);
               AssignAttri("", false, "AV5ActivationDate", context.localUtil.TToC( AV5ActivationDate, 10, 5, 1, 2, "/", ":", " "));
            }
            else
            {
               AV5ActivationDate = context.localUtil.CToT( cgiGet( edtavActivationdate_Internalname));
               AssignAttri("", false, "AV5ActivationDate", context.localUtil.TToC( AV5ActivationDate, 10, 5, 1, 2, "/", ":", " "));
            }
            AV15DontReceiveInformation = StringUtil.StrToBool( cgiGet( chkavDontreceiveinformation_Internalname));
            AssignAttri("", false, "AV15DontReceiveInformation", AV15DontReceiveInformation);
            AV13CannotChangePassword = StringUtil.StrToBool( cgiGet( chkavCannotchangepassword_Internalname));
            AssignAttri("", false, "AV13CannotChangePassword", AV13CannotChangePassword);
            AV30MustChangePassword = StringUtil.StrToBool( cgiGet( chkavMustchangepassword_Internalname));
            AssignAttri("", false, "AV30MustChangePassword", AV30MustChangePassword);
            AV35PasswordNeverExpires = StringUtil.StrToBool( cgiGet( chkavPasswordneverexpires_Internalname));
            AssignAttri("", false, "AV35PasswordNeverExpires", AV35PasswordNeverExpires);
            AV25IsBlocked = StringUtil.StrToBool( cgiGet( chkavIsblocked_Internalname));
            AssignAttri("", false, "AV25IsBlocked", AV25IsBlocked);
            cmbavSecuritypolicyid.CurrentValue = cgiGet( cmbavSecuritypolicyid_Internalname);
            AV40SecurityPolicyId = (int)(NumberUtil.Val( cgiGet( cmbavSecuritypolicyid_Internalname), "."));
            AssignAttri("", false, "AV40SecurityPolicyId", StringUtil.LTrimStr( (decimal)(AV40SecurityPolicyId), 9, 0));
            AV26IsEnabledInRepository = StringUtil.StrToBool( cgiGet( chkavIsenabledinrepository_Internalname));
            AssignAttri("", false, "AV26IsEnabledInRepository", AV26IsEnabledInRepository);
            if ( context.localUtil.VCDateTime( cgiGet( edtavDatelastauthentication_Internalname), 1, 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Date Last Authentication"}), 1, "vDATELASTAUTHENTICATION");
               GX_FocusControl = edtavDatelastauthentication_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14DateLastAuthentication = (DateTime)(DateTime.MinValue);
               AssignAttri("", false, "AV14DateLastAuthentication", context.localUtil.TToC( AV14DateLastAuthentication, 8, 5, 1, 2, "/", ":", " "));
            }
            else
            {
               AV14DateLastAuthentication = context.localUtil.CToT( cgiGet( edtavDatelastauthentication_Internalname));
               AssignAttri("", false, "AV14DateLastAuthentication", context.localUtil.TToC( AV14DateLastAuthentication, 8, 5, 1, 2, "/", ":", " "));
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
         E16152 ();
         if (returnInSub) return;
      }

      protected void E16152( )
      {
         /* Start Routine */
         /* Execute user subroutine: 'MARK REQUIERED USER DATA' */
         S112 ();
         if (returnInSub) return;
         divPhotocell_Visible = 0;
         AssignProp("", false, divPhotocell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPhotocell_Visible), 5, 0), true);
         divTableedit_Visible = 0;
         AssignProp("", false, divTableedit_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTableedit_Visible), 5, 0), true);
         AV46GAMRepository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
         if ( (0==AV46GAMRepository.gxTpr_Authenticationmasterrepositoryid) )
         {
            cmbavAuthenticationtypename.removeAllItems();
            AV8AuthenticationTypes = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).getenabledauthenticationtypes(AV28Language, out  AV18Errors);
            AV50GXV1 = 1;
            while ( AV50GXV1 <= AV8AuthenticationTypes.Count )
            {
               AV9AuthenticationTypesIns = ((GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple)AV8AuthenticationTypes.Item(AV50GXV1));
               cmbavAuthenticationtypename.addItem(AV9AuthenticationTypesIns.gxTpr_Name, AV9AuthenticationTypesIns.gxTpr_Description, 0);
               AV50GXV1 = (int)(AV50GXV1+1);
            }
         }
         else
         {
            cmbavAuthenticationtypename.Visible = 0;
            AssignProp("", false, cmbavAuthenticationtypename_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(cmbavAuthenticationtypename.Visible), 5, 0), true);
         }
         AV38SecurityPolicies = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).getsecuritypolicies(AV20FilterSecPol, out  AV18Errors);
         cmbavSecuritypolicyid.addItem("0", "(None)", 0);
         AV51GXV2 = 1;
         while ( AV51GXV2 <= AV38SecurityPolicies.Count )
         {
            AV39SecurityPolicy = ((GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy)AV38SecurityPolicies.Item(AV51GXV2));
            cmbavSecuritypolicyid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV39SecurityPolicy.gxTpr_Id), 9, 0)), AV39SecurityPolicy.gxTpr_Name, 0);
            AV51GXV2 = (int)(AV51GXV2+1);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            chkavIsenabledinrepository.Enabled = 0;
            AssignProp("", false, chkavIsenabledinrepository_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavIsenabledinrepository.Enabled), 5, 0), true);
            cmbavAuthenticationtypename.Enabled = 1;
            AssignProp("", false, cmbavAuthenticationtypename_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavAuthenticationtypename.Enabled), 5, 0), true);
            AV7AuthenticationTypeName = "local";
            AssignAttri("", false, "AV7AuthenticationTypeName", AV7AuthenticationTypeName);
            divImagecell_Visible = 0;
            AssignProp("", false, divImagecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divImagecell_Visible), 5, 0), true);
            divUrlcell_Visible = 0;
            AssignProp("", false, divUrlcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divUrlcell_Visible), 5, 0), true);
            divGocell_Visible = 0;
            AssignProp("", false, divGocell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divGocell_Visible), 5, 0), true);
            divLastauthcell_Visible = 0;
            AssignProp("", false, divLastauthcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divLastauthcell_Visible), 5, 0), true);
            AV10AuthTypeId = AV6AuthenticationType.gettypebyname(AV7AuthenticationTypeName, out  AV18Errors);
            if ( StringUtil.StrCmp(AV10AuthTypeId, "GAMLocal") == 0 )
            {
               divPasscell_Visible = 1;
               AssignProp("", false, divPasscell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPasscell_Visible), 5, 0), true);
               divPassconfcell_Visible = 1;
               AssignProp("", false, divPassconfcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPassconfcell_Visible), 5, 0), true);
            }
            else
            {
               divPasscell_Visible = 0;
               AssignProp("", false, divPasscell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPasscell_Visible), 5, 0), true);
               divPassconfcell_Visible = 0;
               AssignProp("", false, divPassconfcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPassconfcell_Visible), 5, 0), true);
            }
            AV37Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
            AV45UserNameSpace = AV37Repository.gxTpr_Namespace;
            AssignAttri("", false, "AV45UserNameSpace", AV45UserNameSpace);
            divIsactivecell_Visible = 0;
            AssignProp("", false, divIsactivecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divIsactivecell_Visible), 5, 0), true);
            divActivationdatecell_Visible = 0;
            AssignProp("", false, divActivationdatecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divActivationdatecell_Visible), 5, 0), true);
            bttShowhide_Visible = 0;
            AssignProp("", false, bttShowhide_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttShowhide_Visible), 5, 0), true);
            divActionscontainer_Visible = 0;
            AssignProp("", false, divActionscontainer_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divActionscontainer_Visible), 5, 0), true);
         }
         else
         {
            AV43User.load( AV44UserId);
            AssignAttri("", false, "AV44UserId", AV44UserId);
            cmbavAuthenticationtypename.Enabled = 0;
            AssignProp("", false, cmbavAuthenticationtypename_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavAuthenticationtypename.Enabled), 5, 0), true);
            AV7AuthenticationTypeName = AV43User.gxTpr_Authenticationtypename;
            AssignAttri("", false, "AV7AuthenticationTypeName", AV7AuthenticationTypeName);
            divImagecell_Visible = 1;
            AssignProp("", false, divImagecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divImagecell_Visible), 5, 0), true);
            divUrlcell_Visible = 1;
            AssignProp("", false, divUrlcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divUrlcell_Visible), 5, 0), true);
            divIsactivecell_Visible = 1;
            AssignProp("", false, divIsactivecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divIsactivecell_Visible), 5, 0), true);
            divLastauthcell_Visible = 1;
            AssignProp("", false, divLastauthcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divLastauthcell_Visible), 5, 0), true);
            divPasscell_Visible = 0;
            AssignProp("", false, divPasscell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPasscell_Visible), 5, 0), true);
            divPassconfcell_Visible = 0;
            AssignProp("", false, divPassconfcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPassconfcell_Visible), 5, 0), true);
            AV10AuthTypeId = AV6AuthenticationType.gettypebyname(AV7AuthenticationTypeName, out  AV18Errors);
            if ( StringUtil.StrCmp(AV10AuthTypeId, "GAMLocal") == 0 )
            {
               edtavName_Enabled = 1;
               AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
               imgavImage_Enabled = 1;
               AssignProp("", false, imgavImage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgavImage_Enabled), 5, 0), true);
               edtavUrlprofile_Enabled = 0;
               AssignProp("", false, edtavUrlprofile_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUrlprofile_Enabled), 5, 0), true);
            }
            else
            {
               edtavName_Enabled = 0;
               AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
               imgavImage_Enabled = 0;
               AssignProp("", false, imgavImage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgavImage_Enabled), 5, 0), true);
               edtavUrlprofile_Enabled = 1;
               AssignProp("", false, edtavUrlprofile_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUrlprofile_Enabled), 5, 0), true);
            }
            AV44UserId = AV43User.gxTpr_Guid;
            AssignAttri("", false, "AV44UserId", AV44UserId);
            AV45UserNameSpace = AV43User.gxTpr_Namespace;
            AssignAttri("", false, "AV45UserNameSpace", AV45UserNameSpace);
            AV31Name = AV43User.gxTpr_Name;
            AssignAttri("", false, "AV31Name", AV31Name);
            AV16EMail = AV43User.gxTpr_Email;
            AssignAttri("", false, "AV16EMail", AV16EMail);
            AV21FirstName = AV43User.gxTpr_Firstname;
            AssignAttri("", false, "AV21FirstName", AV21FirstName);
            AV29LastName = AV43User.gxTpr_Lastname;
            AssignAttri("", false, "AV29LastName", AV29LastName);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43User.gxTpr_Urlimage)) )
            {
               AV23Image = AV43User.gxTpr_Urlimage;
               AssignProp("", false, imgavImage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV23Image)) ? AV52Image_GXI : context.convertURL( context.PathToRelativeUrl( AV23Image))), true);
               AssignProp("", false, imgavImage_Internalname, "SrcSet", context.GetImageSrcSet( AV23Image), true);
               AV52Image_GXI = GXDbFile.PathToUrl( AV43User.gxTpr_Urlimage);
               AssignProp("", false, imgavImage_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV23Image)) ? AV52Image_GXI : context.convertURL( context.PathToRelativeUrl( AV23Image))), true);
               AssignProp("", false, imgavImage_Internalname, "SrcSet", context.GetImageSrcSet( AV23Image), true);
            }
            else
            {
               divImagecell_Visible = 0;
               AssignProp("", false, divImagecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divImagecell_Visible), 5, 0), true);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43User.gxTpr_Urlprofile)) && ( StringUtil.StrCmp(AV43User.gxTpr_Authenticationtypename, "GAMLocal") != 0 ) )
            {
               AV42URLProfile = AV43User.gxTpr_Urlprofile;
               AssignAttri("", false, "AV42URLProfile", AV42URLProfile);
               lblTbgo_Link = AV42URLProfile;
               AssignProp("", false, lblTbgo_Internalname, "Link", lblTbgo_Link, true);
               divGocell_Visible = 1;
               AssignProp("", false, divGocell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divGocell_Visible), 5, 0), true);
            }
            else
            {
               divGocell_Visible = 0;
               AssignProp("", false, divGocell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divGocell_Visible), 5, 0), true);
            }
            AV19ExternalId = AV43User.gxTpr_Externalid;
            AssignAttri("", false, "AV19ExternalId", AV19ExternalId);
            AV11Birthday = AV43User.gxTpr_Birthday;
            AssignAttri("", false, "AV11Birthday", context.localUtil.Format(AV11Birthday, "99/99/9999"));
            AV22Gender = AV43User.gxTpr_Gender;
            AssignAttri("", false, "AV22Gender", AV22Gender);
            AV24IsActive = AV43User.gxTpr_Isactive;
            AssignAttri("", false, "AV24IsActive", AV24IsActive);
            AV5ActivationDate = AV43User.gxTpr_Activationdate;
            AssignAttri("", false, "AV5ActivationDate", context.localUtil.TToC( AV5ActivationDate, 10, 5, 1, 2, "/", ":", " "));
            AV15DontReceiveInformation = AV43User.gxTpr_Dontreceiveinformation;
            AssignAttri("", false, "AV15DontReceiveInformation", AV15DontReceiveInformation);
            AV13CannotChangePassword = AV43User.gxTpr_Cannotchangepassword;
            AssignAttri("", false, "AV13CannotChangePassword", AV13CannotChangePassword);
            AV30MustChangePassword = AV43User.gxTpr_Mustchangepassword;
            AssignAttri("", false, "AV30MustChangePassword", AV30MustChangePassword);
            AV35PasswordNeverExpires = AV43User.gxTpr_Passwordneverexpires;
            AssignAttri("", false, "AV35PasswordNeverExpires", AV35PasswordNeverExpires);
            AV25IsBlocked = AV43User.gxTpr_Isblocked;
            AssignAttri("", false, "AV25IsBlocked", AV25IsBlocked);
            AV40SecurityPolicyId = AV43User.gxTpr_Securitypolicyid;
            AssignAttri("", false, "AV40SecurityPolicyId", StringUtil.LTrimStr( (decimal)(AV40SecurityPolicyId), 9, 0));
            AV26IsEnabledInRepository = AV43User.gxTpr_Isenabledinrepository;
            AssignAttri("", false, "AV26IsEnabledInRepository", AV26IsEnabledInRepository);
            AV14DateLastAuthentication = AV43User.gxTpr_Datelastauthentication;
            AssignAttri("", false, "AV14DateLastAuthentication", context.localUtil.TToC( AV14DateLastAuthentication, 8, 5, 1, 2, "/", ":", " "));
            divIsactivecell_Visible = 1;
            AssignProp("", false, divIsactivecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divIsactivecell_Visible), 5, 0), true);
            divActivationdatecell_Visible = 1;
            AssignProp("", false, divActivationdatecell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divActivationdatecell_Visible), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            edtavName_Enabled = 0;
            AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), true);
            edtavEmail_Enabled = 0;
            AssignProp("", false, edtavEmail_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavEmail_Enabled), 5, 0), true);
            edtavFirstname_Enabled = 0;
            AssignProp("", false, edtavFirstname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavFirstname_Enabled), 5, 0), true);
            edtavLastname_Enabled = 0;
            AssignProp("", false, edtavLastname_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavLastname_Enabled), 5, 0), true);
            edtavUrlprofile_Enabled = 0;
            AssignProp("", false, edtavUrlprofile_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUrlprofile_Enabled), 5, 0), true);
            edtavExternalid_Enabled = 0;
            AssignProp("", false, edtavExternalid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavExternalid_Enabled), 5, 0), true);
            edtavBirthday_Enabled = 0;
            AssignProp("", false, edtavBirthday_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBirthday_Enabled), 5, 0), true);
            cmbavGender.Enabled = 0;
            AssignProp("", false, cmbavGender_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavGender.Enabled), 5, 0), true);
            chkavIsactive.Enabled = 0;
            AssignProp("", false, chkavIsactive_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavIsactive.Enabled), 5, 0), true);
            chkavDontreceiveinformation.Enabled = 0;
            AssignProp("", false, chkavDontreceiveinformation_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavDontreceiveinformation.Enabled), 5, 0), true);
            chkavCannotchangepassword.Enabled = 0;
            AssignProp("", false, chkavCannotchangepassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavCannotchangepassword.Enabled), 5, 0), true);
            chkavMustchangepassword.Enabled = 0;
            AssignProp("", false, chkavMustchangepassword_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavMustchangepassword.Enabled), 5, 0), true);
            chkavIsblocked.Enabled = 0;
            AssignProp("", false, chkavIsblocked_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavIsblocked.Enabled), 5, 0), true);
            chkavPasswordneverexpires.Enabled = 0;
            AssignProp("", false, chkavPasswordneverexpires_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavPasswordneverexpires.Enabled), 5, 0), true);
            cmbavSecuritypolicyid.Enabled = 0;
            AssignProp("", false, cmbavSecuritypolicyid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbavSecuritypolicyid.Enabled), 5, 0), true);
            chkavIsenabledinrepository.Enabled = 0;
            AssignProp("", false, chkavIsenabledinrepository_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavIsenabledinrepository.Enabled), 5, 0), true);
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               bttBtnconfirm_Caption = "Delete";
               AssignProp("", false, bttBtnconfirm_Internalname, "Caption", bttBtnconfirm_Caption, true);
            }
            else
            {
               bttBtnconfirm_Visible = 0;
               AssignProp("", false, bttBtnconfirm_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtnconfirm_Visible), 5, 0), true);
            }
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               divTableedit_Visible = 1;
               AssignProp("", false, divTableedit_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divTableedit_Visible), 5, 0), true);
            }
         }
         if ( AV24IsActive )
         {
            chkavIsactive.Enabled = 0;
            AssignProp("", false, chkavIsactive_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkavIsactive.Enabled), 5, 0), true);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E17152 ();
         if (returnInSub) return;
      }

      protected void E17152( )
      {
         /* Enter Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            AV43User.load( AV44UserId);
            AssignAttri("", false, "AV44UserId", AV44UserId);
         }
         AV34PasswordIsOK = true;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               AV10AuthTypeId = AV6AuthenticationType.gettypebyname(AV7AuthenticationTypeName, out  AV18Errors);
               AV26IsEnabledInRepository = true;
               AssignAttri("", false, "AV26IsEnabledInRepository", AV26IsEnabledInRepository);
               if ( StringUtil.StrCmp(AV10AuthTypeId, "GAMLocal") == 0 )
               {
                  if ( StringUtil.StrCmp(AV32Password, AV33PasswordConf) != 0 )
                  {
                     AV34PasswordIsOK = false;
                     GX_msglist.addItem("The password and confirmation password do not match.");
                  }
               }
               else
               {
                  AV32Password = "";
                  AssignAttri("", false, "AV32Password", AV32Password);
               }
            }
            if ( AV34PasswordIsOK )
            {
               AV43User.gxTpr_Authenticationtypename = AV7AuthenticationTypeName;
               AV43User.gxTpr_Name = AV31Name;
               AV43User.gxTpr_Email = AV16EMail;
               AV43User.gxTpr_Firstname = AV21FirstName;
               AV43User.gxTpr_Lastname = AV29LastName;
               AV43User.gxTpr_Password = AV32Password;
               AV43User.gxTpr_Externalid = AV19ExternalId;
               AV43User.gxTpr_Birthday = AV11Birthday;
               AV43User.gxTpr_Gender = AV22Gender;
               AV43User.gxTpr_Isactive = AV24IsActive;
               AV12BlobPhoto = AV36Photo;
               AV43User.gxTpr_Urlprofile = AV42URLProfile;
               AV43User.gxTpr_Dontreceiveinformation = AV15DontReceiveInformation;
               AV43User.gxTpr_Cannotchangepassword = AV13CannotChangePassword;
               AV43User.gxTpr_Mustchangepassword = AV30MustChangePassword;
               AV43User.gxTpr_Isblocked = AV25IsBlocked;
               AV43User.gxTpr_Passwordneverexpires = AV35PasswordNeverExpires;
               AV43User.gxTpr_Securitypolicyid = AV40SecurityPolicyId;
               AV43User.save();
            }
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV43User.delete();
         }
         if ( AV34PasswordIsOK )
         {
            if ( AV43User.success() )
            {
               context.CommitDataStores("gamexampleuserentry",pr_default);
               AV27isOK = true;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  if ( AV26IsEnabledInRepository != AV43User.gxTpr_Isenabledinrepository )
                  {
                     if ( AV26IsEnabledInRepository )
                     {
                        AV27isOK = AV43User.repositoryenable(out  AV18Errors);
                     }
                     else
                     {
                        AV27isOK = AV43User.repositorydisable(out  AV18Errors);
                     }
                  }
               }
               if ( AV27isOK )
               {
                  context.CommitDataStores("gamexampleuserentry",pr_default);
                  if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                  {
                     CallWebObject(formatLink("gamexamplewwusers.aspx") );
                     context.wjLocDisableFrm = 1;
                  }
                  else
                  {
                     context.setWebReturnParms(new Object[] {(String)Gx_mode,(String)AV44UserId});
                     context.setWebReturnParmsMetadata(new Object[] {"Gx_mode","AV44UserId"});
                     context.wjLocDisableFrm = 1;
                     context.nUserReturn = 1;
                     returnInSub = true;
                     if (true) return;
                  }
               }
               else
               {
                  AV53GXV3 = 1;
                  while ( AV53GXV3 <= AV18Errors.Count )
                  {
                     AV17Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV18Errors.Item(AV53GXV3));
                     GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV17Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV17Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
                     AV53GXV3 = (int)(AV53GXV3+1);
                  }
               }
            }
            else
            {
               AV18Errors = AV43User.geterrors();
               AV54GXV4 = 1;
               while ( AV54GXV4 <= AV18Errors.Count )
               {
                  AV17Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV18Errors.Item(AV54GXV4));
                  GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV17Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV17Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
                  AV54GXV4 = (int)(AV54GXV4+1);
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43User", AV43User);
      }

      protected void E18152( )
      {
         /* Authenticationtypename_Isvalid Routine */
         AV10AuthTypeId = AV6AuthenticationType.gettypebyname(AV7AuthenticationTypeName, out  AV18Errors);
         if ( StringUtil.StrCmp(AV10AuthTypeId, "GAMLocal") == 0 )
         {
            divPasscell_Visible = 1;
            AssignProp("", false, divPasscell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPasscell_Visible), 5, 0), true);
            divPassconfcell_Visible = 1;
            AssignProp("", false, divPassconfcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPassconfcell_Visible), 5, 0), true);
            divUrlcell_Visible = 0;
            AssignProp("", false, divUrlcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divUrlcell_Visible), 5, 0), true);
         }
         else
         {
            divUrlcell_Visible = 1;
            AssignProp("", false, divUrlcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divUrlcell_Visible), 5, 0), true);
            divPasscell_Visible = 0;
            AssignProp("", false, divPasscell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPasscell_Visible), 5, 0), true);
            divPassconfcell_Visible = 0;
            AssignProp("", false, divPassconfcell_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(divPassconfcell_Visible), 5, 0), true);
         }
         /*  Sending Event outputs  */
      }

      protected void E19152( )
      {
         /* 'Delete' Routine */
         AV43User.load( AV44UserId);
         AssignAttri("", false, "AV44UserId", AV44UserId);
         AV43User.delete();
         if ( AV43User.success() )
         {
            context.CommitDataStores("gamexampleuserentry",pr_default);
            context.setWebReturnParms(new Object[] {(String)Gx_mode,(String)AV44UserId});
            context.setWebReturnParmsMetadata(new Object[] {"Gx_mode","AV44UserId"});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43User", AV43User);
      }

      protected void S112( )
      {
         /* 'MARK REQUIERED USER DATA' Routine */
         AV37Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
         if ( AV37Repository.gxTpr_Requiredemail )
         {
            edtavEmail_Class = "RequiredAttribute";
            AssignProp("", false, edtavEmail_Internalname, "Class", edtavEmail_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredfirstname )
         {
            edtavFirstname_Class = "RequiredAttribute";
            AssignProp("", false, edtavFirstname_Internalname, "Class", edtavFirstname_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredlastname )
         {
            edtavLastname_Class = "RequiredAttribute";
            AssignProp("", false, edtavLastname_Internalname, "Class", edtavLastname_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredbirthday )
         {
            edtavBirthday_Class = "RequiredAttribute";
            AssignProp("", false, edtavBirthday_Internalname, "Class", edtavBirthday_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredgender )
         {
            cmbavGender_Class = "RequiredAttribute";
            AssignProp("", false, cmbavGender_Internalname, "Class", cmbavGender_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredpassword )
         {
            edtavPassword_Class = "RequiredAttribute";
            AssignProp("", false, edtavPassword_Internalname, "Class", edtavPassword_Class, true);
            edtavPasswordconf_Class = "RequiredAttribute";
            AssignProp("", false, edtavPasswordconf_Internalname, "Class", edtavPasswordconf_Class, true);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E20152( )
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
         AV44UserId = (String)getParm(obj,1);
         AssignAttri("", false, "AV44UserId", AV44UserId);
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
         PA152( ) ;
         WS152( ) ;
         WE152( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20204151162120", true, true);
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
         context.AddJavascriptSource("gamexampleuserentry.js", "?20204151162123", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbavAuthenticationtypename.Name = "vAUTHENTICATIONTYPENAME";
         cmbavAuthenticationtypename.WebTags = "";
         if ( cmbavAuthenticationtypename.ItemCount > 0 )
         {
            AV7AuthenticationTypeName = cmbavAuthenticationtypename.getValidValue(AV7AuthenticationTypeName);
            AssignAttri("", false, "AV7AuthenticationTypeName", AV7AuthenticationTypeName);
         }
         cmbavGender.Name = "vGENDER";
         cmbavGender.WebTags = "";
         cmbavGender.addItem("N", "Not Specified", 0);
         cmbavGender.addItem("F", "Female", 0);
         cmbavGender.addItem("M", "Male", 0);
         if ( cmbavGender.ItemCount > 0 )
         {
            AV22Gender = cmbavGender.getValidValue(AV22Gender);
            AssignAttri("", false, "AV22Gender", AV22Gender);
         }
         chkavIsactive.Name = "vISACTIVE";
         chkavIsactive.WebTags = "";
         chkavIsactive.Caption = "";
         AssignProp("", false, chkavIsactive_Internalname, "TitleCaption", chkavIsactive.Caption, true);
         chkavIsactive.CheckedValue = "false";
         AV24IsActive = StringUtil.StrToBool( StringUtil.BoolToStr( AV24IsActive));
         AssignAttri("", false, "AV24IsActive", AV24IsActive);
         chkavDontreceiveinformation.Name = "vDONTRECEIVEINFORMATION";
         chkavDontreceiveinformation.WebTags = "";
         chkavDontreceiveinformation.Caption = "";
         AssignProp("", false, chkavDontreceiveinformation_Internalname, "TitleCaption", chkavDontreceiveinformation.Caption, true);
         chkavDontreceiveinformation.CheckedValue = "false";
         AV15DontReceiveInformation = StringUtil.StrToBool( StringUtil.BoolToStr( AV15DontReceiveInformation));
         AssignAttri("", false, "AV15DontReceiveInformation", AV15DontReceiveInformation);
         chkavCannotchangepassword.Name = "vCANNOTCHANGEPASSWORD";
         chkavCannotchangepassword.WebTags = "";
         chkavCannotchangepassword.Caption = "";
         AssignProp("", false, chkavCannotchangepassword_Internalname, "TitleCaption", chkavCannotchangepassword.Caption, true);
         chkavCannotchangepassword.CheckedValue = "false";
         AV13CannotChangePassword = StringUtil.StrToBool( StringUtil.BoolToStr( AV13CannotChangePassword));
         AssignAttri("", false, "AV13CannotChangePassword", AV13CannotChangePassword);
         chkavMustchangepassword.Name = "vMUSTCHANGEPASSWORD";
         chkavMustchangepassword.WebTags = "";
         chkavMustchangepassword.Caption = "";
         AssignProp("", false, chkavMustchangepassword_Internalname, "TitleCaption", chkavMustchangepassword.Caption, true);
         chkavMustchangepassword.CheckedValue = "false";
         AV30MustChangePassword = StringUtil.StrToBool( StringUtil.BoolToStr( AV30MustChangePassword));
         AssignAttri("", false, "AV30MustChangePassword", AV30MustChangePassword);
         chkavPasswordneverexpires.Name = "vPASSWORDNEVEREXPIRES";
         chkavPasswordneverexpires.WebTags = "";
         chkavPasswordneverexpires.Caption = "";
         AssignProp("", false, chkavPasswordneverexpires_Internalname, "TitleCaption", chkavPasswordneverexpires.Caption, true);
         chkavPasswordneverexpires.CheckedValue = "false";
         AV35PasswordNeverExpires = StringUtil.StrToBool( StringUtil.BoolToStr( AV35PasswordNeverExpires));
         AssignAttri("", false, "AV35PasswordNeverExpires", AV35PasswordNeverExpires);
         chkavIsblocked.Name = "vISBLOCKED";
         chkavIsblocked.WebTags = "";
         chkavIsblocked.Caption = "";
         AssignProp("", false, chkavIsblocked_Internalname, "TitleCaption", chkavIsblocked.Caption, true);
         chkavIsblocked.CheckedValue = "false";
         AV25IsBlocked = StringUtil.StrToBool( StringUtil.BoolToStr( AV25IsBlocked));
         AssignAttri("", false, "AV25IsBlocked", AV25IsBlocked);
         cmbavSecuritypolicyid.Name = "vSECURITYPOLICYID";
         cmbavSecuritypolicyid.WebTags = "";
         if ( cmbavSecuritypolicyid.ItemCount > 0 )
         {
            AV40SecurityPolicyId = (int)(NumberUtil.Val( cmbavSecuritypolicyid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV40SecurityPolicyId), 9, 0))), "."));
            AssignAttri("", false, "AV40SecurityPolicyId", StringUtil.LTrimStr( (decimal)(AV40SecurityPolicyId), 9, 0));
         }
         chkavIsenabledinrepository.Name = "vISENABLEDINREPOSITORY";
         chkavIsenabledinrepository.WebTags = "";
         chkavIsenabledinrepository.Caption = "";
         AssignProp("", false, chkavIsenabledinrepository_Internalname, "TitleCaption", chkavIsenabledinrepository.Caption, true);
         chkavIsenabledinrepository.CheckedValue = "false";
         AV26IsEnabledInRepository = StringUtil.StrToBool( StringUtil.BoolToStr( AV26IsEnabledInRepository));
         AssignAttri("", false, "AV26IsEnabledInRepository", AV26IsEnabledInRepository);
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         bttShowhide_Internalname = "SHOWHIDE";
         divTable2_Internalname = "TABLE2";
         imgImage4_Internalname = "IMAGE4";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         divTableedit_Internalname = "TABLEEDIT";
         imgImage5_Internalname = "IMAGE5";
         lblPermission_Internalname = "PERMISSION";
         divTable1_Internalname = "TABLE1";
         imgImage1_Internalname = "IMAGE1";
         lblChangeroles_Internalname = "CHANGEROLES";
         divTable4_Internalname = "TABLE4";
         imgImage3_Internalname = "IMAGE3";
         lblChangepassword_Internalname = "CHANGEPASSWORD";
         divTable6_Internalname = "TABLE6";
         imgImage2_Internalname = "IMAGE2";
         lblDeleteuser_Internalname = "DELETEUSER";
         divTable5_Internalname = "TABLE5";
         divActionscontainer_Internalname = "ACTIONSCONTAINER";
         imgavPhoto_Internalname = "vPHOTO";
         divPhotocell_Internalname = "PHOTOCELL";
         edtavUserid_Internalname = "vUSERID";
         edtavUsernamespace_Internalname = "vUSERNAMESPACE";
         cmbavAuthenticationtypename_Internalname = "vAUTHENTICATIONTYPENAME";
         edtavName_Internalname = "vNAME";
         edtavEmail_Internalname = "vEMAIL";
         edtavPassword_Internalname = "vPASSWORD";
         divPasscell_Internalname = "PASSCELL";
         edtavPasswordconf_Internalname = "vPASSWORDCONF";
         divPassconfcell_Internalname = "PASSCONFCELL";
         edtavFirstname_Internalname = "vFIRSTNAME";
         edtavLastname_Internalname = "vLASTNAME";
         edtavExternalid_Internalname = "vEXTERNALID";
         edtavBirthday_Internalname = "vBIRTHDAY";
         cmbavGender_Internalname = "vGENDER";
         edtavUrlprofile_Internalname = "vURLPROFILE";
         divUrlcell_Internalname = "URLCELL";
         lblTbgo_Internalname = "TBGO";
         divGocell_Internalname = "GOCELL";
         imgavImage_Internalname = "vIMAGE";
         divImagecell_Internalname = "IMAGECELL";
         chkavIsactive_Internalname = "vISACTIVE";
         divIsactivecell_Internalname = "ISACTIVECELL";
         edtavActivationdate_Internalname = "vACTIVATIONDATE";
         divActivationdatecell_Internalname = "ACTIVATIONDATECELL";
         chkavDontreceiveinformation_Internalname = "vDONTRECEIVEINFORMATION";
         chkavCannotchangepassword_Internalname = "vCANNOTCHANGEPASSWORD";
         chkavMustchangepassword_Internalname = "vMUSTCHANGEPASSWORD";
         chkavPasswordneverexpires_Internalname = "vPASSWORDNEVEREXPIRES";
         chkavIsblocked_Internalname = "vISBLOCKED";
         cmbavSecuritypolicyid_Internalname = "vSECURITYPOLICYID";
         chkavIsenabledinrepository_Internalname = "vISENABLEDINREPOSITORY";
         edtavDatelastauthentication_Internalname = "vDATELASTAUTHENTICATION";
         divLastauthcell_Internalname = "LASTAUTHCELL";
         divTable3_Internalname = "TABLE3";
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
         chkavIsenabledinrepository.Caption = "Enabled in repository";
         chkavIsblocked.Caption = "User is blocked";
         chkavPasswordneverexpires.Caption = "Password never expires";
         chkavMustchangepassword.Caption = "Must change password";
         chkavCannotchangepassword.Caption = "Cannot change password";
         chkavDontreceiveinformation.Caption = "Don't want to receive information";
         chkavIsactive.Caption = "Account is active?";
         bttBtnconfirm_Caption = "Confirm";
         bttBtnconfirm_Visible = 1;
         edtavDatelastauthentication_Jsonclick = "";
         edtavDatelastauthentication_Enabled = 1;
         divLastauthcell_Visible = 1;
         chkavIsenabledinrepository.Enabled = 1;
         cmbavSecuritypolicyid_Jsonclick = "";
         cmbavSecuritypolicyid.Enabled = 1;
         chkavIsblocked.Enabled = 1;
         chkavPasswordneverexpires.Enabled = 1;
         chkavMustchangepassword.Enabled = 1;
         chkavCannotchangepassword.Enabled = 1;
         chkavDontreceiveinformation.Enabled = 1;
         edtavActivationdate_Jsonclick = "";
         edtavActivationdate_Enabled = 1;
         divActivationdatecell_Visible = 1;
         chkavIsactive.Enabled = 1;
         divIsactivecell_Visible = 1;
         imgavImage_Enabled = 0;
         divImagecell_Visible = 1;
         lblTbgo_Link = "";
         divGocell_Visible = 1;
         edtavUrlprofile_Jsonclick = "";
         edtavUrlprofile_Enabled = 1;
         divUrlcell_Visible = 1;
         cmbavGender_Jsonclick = "";
         cmbavGender.Enabled = 1;
         cmbavGender_Class = "Attribute";
         edtavBirthday_Jsonclick = "";
         edtavBirthday_Class = "Attribute";
         edtavBirthday_Enabled = 1;
         edtavExternalid_Jsonclick = "";
         edtavExternalid_Enabled = 1;
         edtavLastname_Jsonclick = "";
         edtavLastname_Class = "Attribute";
         edtavLastname_Enabled = 1;
         edtavFirstname_Jsonclick = "";
         edtavFirstname_Class = "Attribute";
         edtavFirstname_Enabled = 1;
         edtavPasswordconf_Jsonclick = "";
         edtavPasswordconf_Class = "Attribute";
         edtavPasswordconf_Enabled = 1;
         divPassconfcell_Visible = 1;
         edtavPassword_Jsonclick = "";
         edtavPassword_Class = "Attribute";
         edtavPassword_Enabled = 1;
         divPasscell_Visible = 1;
         edtavEmail_Jsonclick = "";
         edtavEmail_Class = "Attribute";
         edtavEmail_Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 1;
         cmbavAuthenticationtypename_Jsonclick = "";
         cmbavAuthenticationtypename.Enabled = 1;
         cmbavAuthenticationtypename.Visible = 1;
         edtavUsernamespace_Jsonclick = "";
         edtavUsernamespace_Enabled = 1;
         edtavUserid_Jsonclick = "";
         edtavUserid_Enabled = 0;
         divPhotocell_Visible = 1;
         divTableedit_Visible = 1;
         divActionscontainer_Visible = 1;
         bttShowhide_Visible = 1;
         divActionscontainer_Class = "ActionsContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "User";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("ENTER","{handler:'E17152',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'cmbavAuthenticationtypename'},{av:'AV7AuthenticationTypeName',fld:'vAUTHENTICATIONTYPENAME',pic:''},{av:'AV32Password',fld:'vPASSWORD',pic:''},{av:'AV33PasswordConf',fld:'vPASSWORDCONF',pic:''},{av:'AV31Name',fld:'vNAME',pic:''},{av:'AV16EMail',fld:'vEMAIL',pic:''},{av:'AV21FirstName',fld:'vFIRSTNAME',pic:''},{av:'AV29LastName',fld:'vLASTNAME',pic:''},{av:'AV19ExternalId',fld:'vEXTERNALID',pic:''},{av:'AV11Birthday',fld:'vBIRTHDAY',pic:''},{av:'cmbavGender'},{av:'AV22Gender',fld:'vGENDER',pic:''},{av:'AV36Photo',fld:'vPHOTO',pic:''},{av:'AV42URLProfile',fld:'vURLPROFILE',pic:''},{av:'cmbavSecuritypolicyid'},{av:'AV40SecurityPolicyId',fld:'vSECURITYPOLICYID',pic:'ZZZZZZZZ9'},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV32Password',fld:'vPASSWORD',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("VAUTHENTICATIONTYPENAME.ISVALID","{handler:'E18152',iparms:[{av:'cmbavAuthenticationtypename'},{av:'AV7AuthenticationTypeName',fld:'vAUTHENTICATIONTYPENAME',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("VAUTHENTICATIONTYPENAME.ISVALID",",oparms:[{av:'divPasscell_Visible',ctrl:'PASSCELL',prop:'Visible'},{av:'divPassconfcell_Visible',ctrl:'PASSCONFCELL',prop:'Visible'},{av:'divUrlcell_Visible',ctrl:'URLCELL',prop:'Visible'},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("'DELETE'","{handler:'E19152',iparms:[{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("'DELETE'",",oparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("'ROLES'","{handler:'E14151',iparms:[{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("'ROLES'",",oparms:[{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("'EDIT'","{handler:'E12151',iparms:[{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("'EDIT'",",oparms:[{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("'CHANGE PASSWORD'","{handler:'E15151',iparms:[{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("'CHANGE PASSWORD'",",oparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("'SHOWHIDE'","{handler:'E11151',iparms:[{av:'divActionscontainer_Class',ctrl:'ACTIONSCONTAINER',prop:'Class'},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("'SHOWHIDE'",",oparms:[{av:'divActionscontainer_Class',ctrl:'ACTIONSCONTAINER',prop:'Class'},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("'USERPERMISSIONS'","{handler:'E13151',iparms:[{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("'USERPERMISSIONS'",",oparms:[{av:'AV44UserId',fld:'vUSERID',pic:''},{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("VALIDV_BIRTHDAY","{handler:'Validv_Birthday',iparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("VALIDV_BIRTHDAY",",oparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("VALIDV_GENDER","{handler:'Validv_Gender',iparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("VALIDV_GENDER",",oparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("VALIDV_ACTIVATIONDATE","{handler:'Validv_Activationdate',iparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("VALIDV_ACTIVATIONDATE",",oparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
         setEventMetadata("VALIDV_DATELASTAUTHENTICATION","{handler:'Validv_Datelastauthentication',iparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]");
         setEventMetadata("VALIDV_DATELASTAUTHENTICATION",",oparms:[{av:'AV24IsActive',fld:'vISACTIVE',pic:''},{av:'AV15DontReceiveInformation',fld:'vDONTRECEIVEINFORMATION',pic:''},{av:'AV13CannotChangePassword',fld:'vCANNOTCHANGEPASSWORD',pic:''},{av:'AV30MustChangePassword',fld:'vMUSTCHANGEPASSWORD',pic:''},{av:'AV35PasswordNeverExpires',fld:'vPASSWORDNEVEREXPIRES',pic:''},{av:'AV25IsBlocked',fld:'vISBLOCKED',pic:''},{av:'AV26IsEnabledInRepository',fld:'vISENABLEDINREPOSITORY',pic:''}]}");
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
         wcpOAV44UserId = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV41String = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttShowhide_Jsonclick = "";
         sImgUrl = "";
         lblTextblock4_Jsonclick = "";
         lblPermission_Jsonclick = "";
         lblChangeroles_Jsonclick = "";
         lblChangepassword_Jsonclick = "";
         lblDeleteuser_Jsonclick = "";
         AV36Photo = "";
         AV55Photo_GXI = "";
         AV45UserNameSpace = "";
         AV7AuthenticationTypeName = "";
         AV31Name = "";
         AV16EMail = "";
         AV32Password = "";
         AV33PasswordConf = "";
         AV21FirstName = "";
         AV29LastName = "";
         AV19ExternalId = "";
         AV11Birthday = DateTime.MinValue;
         AV22Gender = "";
         AV42URLProfile = "";
         lblTbgo_Jsonclick = "";
         AV23Image = "";
         AV52Image_GXI = "";
         AV5ActivationDate = (DateTime)(DateTime.MinValue);
         AV14DateLastAuthentication = (DateTime)(DateTime.MinValue);
         bttBtncancel_Jsonclick = "";
         bttBtnconfirm_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV46GAMRepository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV8AuthenticationTypes = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple>( context, "GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple", "GeneXus.Programs");
         AV28Language = "";
         AV18Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV9AuthenticationTypesIns = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple(context);
         AV38SecurityPolicies = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy>( context, "GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy", "GeneXus.Programs");
         AV20FilterSecPol = new GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicyFilter(context);
         AV39SecurityPolicy = new GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy(context);
         AV10AuthTypeId = "";
         AV6AuthenticationType = new GeneXus.Programs.genexussecurity.SdtGAMAuthenticationType(context);
         AV37Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV43User = new GeneXus.Programs.genexussecurity.SdtGAMUser(context);
         AV12BlobPhoto = "";
         AV17Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamexampleuserentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamexampleuserentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavUserid_Enabled = 0;
         edtavUsernamespace_Enabled = 0;
         edtavActivationdate_Enabled = 0;
         edtavDatelastauthentication_Enabled = 0;
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
      private int bttShowhide_Visible ;
      private int divActionscontainer_Visible ;
      private int divTableedit_Visible ;
      private int divPhotocell_Visible ;
      private int edtavUserid_Enabled ;
      private int edtavUsernamespace_Enabled ;
      private int edtavName_Enabled ;
      private int edtavEmail_Enabled ;
      private int divPasscell_Visible ;
      private int edtavPassword_Enabled ;
      private int divPassconfcell_Visible ;
      private int edtavPasswordconf_Enabled ;
      private int edtavFirstname_Enabled ;
      private int edtavLastname_Enabled ;
      private int edtavExternalid_Enabled ;
      private int edtavBirthday_Enabled ;
      private int divUrlcell_Visible ;
      private int edtavUrlprofile_Enabled ;
      private int divGocell_Visible ;
      private int divImagecell_Visible ;
      private int imgavImage_Enabled ;
      private int divIsactivecell_Visible ;
      private int divActivationdatecell_Visible ;
      private int edtavActivationdate_Enabled ;
      private int AV40SecurityPolicyId ;
      private int divLastauthcell_Visible ;
      private int edtavDatelastauthentication_Enabled ;
      private int bttBtnconfirm_Visible ;
      private int AV50GXV1 ;
      private int AV51GXV2 ;
      private int AV53GXV3 ;
      private int AV54GXV4 ;
      private int idxLst ;
      private String Gx_mode ;
      private String AV44UserId ;
      private String wcpOGx_mode ;
      private String wcpOAV44UserId ;
      private String divActionscontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String lblTbgo_Link ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
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
      private String divTable1_Internalname ;
      private String imgImage5_Internalname ;
      private String lblPermission_Internalname ;
      private String lblPermission_Jsonclick ;
      private String divTable4_Internalname ;
      private String imgImage1_Internalname ;
      private String lblChangeroles_Internalname ;
      private String lblChangeroles_Jsonclick ;
      private String divTable6_Internalname ;
      private String imgImage3_Internalname ;
      private String lblChangepassword_Internalname ;
      private String lblChangepassword_Jsonclick ;
      private String divTable5_Internalname ;
      private String imgImage2_Internalname ;
      private String lblDeleteuser_Internalname ;
      private String lblDeleteuser_Jsonclick ;
      private String divTable3_Internalname ;
      private String divPhotocell_Internalname ;
      private String imgavPhoto_Internalname ;
      private String edtavUserid_Internalname ;
      private String edtavUserid_Jsonclick ;
      private String edtavUsernamespace_Internalname ;
      private String AV45UserNameSpace ;
      private String edtavUsernamespace_Jsonclick ;
      private String cmbavAuthenticationtypename_Internalname ;
      private String AV7AuthenticationTypeName ;
      private String cmbavAuthenticationtypename_Jsonclick ;
      private String edtavName_Internalname ;
      private String edtavName_Jsonclick ;
      private String edtavEmail_Internalname ;
      private String edtavEmail_Jsonclick ;
      private String edtavEmail_Class ;
      private String divPasscell_Internalname ;
      private String edtavPassword_Internalname ;
      private String AV32Password ;
      private String edtavPassword_Jsonclick ;
      private String edtavPassword_Class ;
      private String divPassconfcell_Internalname ;
      private String edtavPasswordconf_Internalname ;
      private String AV33PasswordConf ;
      private String edtavPasswordconf_Jsonclick ;
      private String edtavPasswordconf_Class ;
      private String edtavFirstname_Internalname ;
      private String AV21FirstName ;
      private String edtavFirstname_Jsonclick ;
      private String edtavFirstname_Class ;
      private String edtavLastname_Internalname ;
      private String AV29LastName ;
      private String edtavLastname_Jsonclick ;
      private String edtavLastname_Class ;
      private String edtavExternalid_Internalname ;
      private String edtavExternalid_Jsonclick ;
      private String edtavBirthday_Internalname ;
      private String edtavBirthday_Jsonclick ;
      private String edtavBirthday_Class ;
      private String cmbavGender_Internalname ;
      private String AV22Gender ;
      private String cmbavGender_Jsonclick ;
      private String cmbavGender_Class ;
      private String divUrlcell_Internalname ;
      private String edtavUrlprofile_Internalname ;
      private String edtavUrlprofile_Jsonclick ;
      private String divGocell_Internalname ;
      private String lblTbgo_Internalname ;
      private String lblTbgo_Jsonclick ;
      private String divImagecell_Internalname ;
      private String imgavImage_Internalname ;
      private String divIsactivecell_Internalname ;
      private String chkavIsactive_Internalname ;
      private String divActivationdatecell_Internalname ;
      private String edtavActivationdate_Internalname ;
      private String edtavActivationdate_Jsonclick ;
      private String chkavDontreceiveinformation_Internalname ;
      private String chkavCannotchangepassword_Internalname ;
      private String chkavMustchangepassword_Internalname ;
      private String chkavPasswordneverexpires_Internalname ;
      private String chkavIsblocked_Internalname ;
      private String cmbavSecuritypolicyid_Internalname ;
      private String cmbavSecuritypolicyid_Jsonclick ;
      private String chkavIsenabledinrepository_Internalname ;
      private String divLastauthcell_Internalname ;
      private String edtavDatelastauthentication_Internalname ;
      private String edtavDatelastauthentication_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String bttBtnconfirm_Internalname ;
      private String bttBtnconfirm_Caption ;
      private String bttBtnconfirm_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV28Language ;
      private String AV10AuthTypeId ;
      private DateTime AV5ActivationDate ;
      private DateTime AV14DateLastAuthentication ;
      private DateTime AV11Birthday ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool AV36Photo_IsBlob ;
      private bool AV23Image_IsBlob ;
      private bool AV24IsActive ;
      private bool AV15DontReceiveInformation ;
      private bool AV13CannotChangePassword ;
      private bool AV30MustChangePassword ;
      private bool AV35PasswordNeverExpires ;
      private bool AV25IsBlocked ;
      private bool AV26IsEnabledInRepository ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV34PasswordIsOK ;
      private bool AV27isOK ;
      private String AV41String ;
      private String AV55Photo_GXI ;
      private String AV31Name ;
      private String AV16EMail ;
      private String AV19ExternalId ;
      private String AV42URLProfile ;
      private String AV52Image_GXI ;
      private String AV36Photo ;
      private String AV23Image ;
      private String AV12BlobPhoto ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationType AV6AuthenticationType ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private String aP0_Gx_mode ;
      private String aP1_UserId ;
      private GXCombobox cmbavAuthenticationtypename ;
      private GXCombobox cmbavGender ;
      private GXCheckbox chkavIsactive ;
      private GXCheckbox chkavDontreceiveinformation ;
      private GXCheckbox chkavCannotchangepassword ;
      private GXCheckbox chkavMustchangepassword ;
      private GXCheckbox chkavPasswordneverexpires ;
      private GXCheckbox chkavIsblocked ;
      private GXCombobox cmbavSecuritypolicyid ;
      private GXCheckbox chkavIsenabledinrepository ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV18Errors ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple> AV8AuthenticationTypes ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy> AV38SecurityPolicies ;
      private GXWebForm Form ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV17Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMAuthenticationTypeSimple AV9AuthenticationTypesIns ;
      private GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicyFilter AV20FilterSecPol ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV46GAMRepository ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV37Repository ;
      private GeneXus.Programs.genexussecurity.SdtGAMUser AV43User ;
      private GeneXus.Programs.genexussecurity.SdtGAMSecurityPolicy AV39SecurityPolicy ;
   }

   public class gamexampleuserentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamexampleuserentry__default : DataStoreHelperBase, IDataStoreHelper
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
