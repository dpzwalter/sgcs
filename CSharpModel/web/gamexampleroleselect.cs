/*
               File: GAMExampleRoleSelect
        Description: Select role
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:10:17.14
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
   public class gamexampleroleselect : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamexampleroleselect( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamexampleroleselect( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_RoleId ,
                           ref long aP1_RoleIdAux )
      {
         this.AV18RoleId = aP0_RoleId;
         this.AV19RoleIdAux = aP1_RoleIdAux;
         executePrivate();
         aP0_RoleId=this.AV18RoleId;
         aP1_RoleIdAux=this.AV19RoleIdAux;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavSelect = new GXCheckbox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridww") == 0 )
            {
               nRC_GXsfl_50 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_50_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_50_idx = GetNextPar( );
               edtavBtnaddrole_Tooltiptext = GetNextPar( );
               AssignProp("", false, edtavBtnaddrole_Internalname, "Tooltiptext", edtavBtnaddrole_Tooltiptext, !bGXsfl_50_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGridww_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridww") == 0 )
            {
               edtavBtnaddrole_Tooltiptext = GetNextPar( );
               AssignProp("", false, edtavBtnaddrole_Internalname, "Tooltiptext", edtavBtnaddrole_Tooltiptext, !bGXsfl_50_Refreshing);
               AV19RoleIdAux = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV11FilName = GetNextPar( );
               AV21SearchFilter = GetNextPar( );
               AV10FilExternalId = GetNextPar( );
               AV7CurrentPage = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( AV19RoleIdAux, AV11FilName, AV21SearchFilter, AV10FilExternalId, AV7CurrentPage) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV18RoleId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV18RoleId", StringUtil.LTrimStr( (decimal)(AV18RoleId), 12, 0));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV19RoleIdAux = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "AV19RoleIdAux", StringUtil.LTrimStr( (decimal)(AV19RoleIdAux), 12, 0));
                  AssignAttri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
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
         PA2B2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2B2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202041511101736", false, true);
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
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamexampleroleselect.aspx") + "?" + UrlEncode("" +AV18RoleId) + "," + UrlEncode("" +AV19RoleIdAux)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vSEARCHFILTER", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV21SearchFilter, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_50", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_50), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vROLEIDAUX", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19RoleIdAux), 12, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vSEARCHFILTER", StringUtil.RTrim( AV21SearchFilter));
         GxWebStd.gx_hidden_field( context, "gxhash_vSEARCHFILTER", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV21SearchFilter, "")), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISOK", AV15isOK);
         GxWebStd.gx_hidden_field( context, "vROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18RoleId), 12, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FILTERSCONTAINER_Class", StringUtil.RTrim( divFilterscontainer_Class));
         GxWebStd.gx_hidden_field( context, "vBTNADDROLE_Tooltiptext", StringUtil.RTrim( edtavBtnaddrole_Tooltiptext));
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
            WE2B2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2B2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gamexampleroleselect.aspx") + "?" + UrlEncode("" +AV18RoleId) + "," + UrlEncode("" +AV19RoleIdAux) ;
      }

      public override String GetPgmname( )
      {
         return "GAMExampleRoleSelect" ;
      }

      public override String GetPgmdesc( )
      {
         return "Select role" ;
      }

      protected void WB2B0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable5_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = bttHide_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttHide_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 2, 0)+","+"null"+");", bttHide_Caption, bttHide_Jsonclick, 7, "HIDE FILTERS", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e112b1_client"+"'", TempTags, "", 2, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10 col-sm-2", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Add children", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-sm-push-3 col-md-3 col-md-push-4", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"";
            ClassString = "BtnTextBlockBack";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBack_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 2, 0)+","+"null"+");", "Back", bttBack_Jsonclick, 1, "Back", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnAdd";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttAddselected_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 2, 0)+","+"null"+");", "Add Selected", bttAddselected_Jsonclick, 5, "Add Selected", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'ADDSELECTED\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-sm-pull-4 col-md-4 col-md-pull-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilname_Internalname, "Fil Name", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_50_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilname_Internalname, StringUtil.RTrim( AV11FilName), StringUtil.RTrim( context.localUtil.Format( AV11FilName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Try a Search", edtavFilname_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavFilname_Enabled, 0, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCellfilters_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-md-2 WWAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFilterscontainer_Internalname, 1, 0, "px", 0, "px", divFilterscontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10 col-sm-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "AdvancedContainerItemExpanded", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "EXTERNAL ID", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FilterLabel", 0, "", 1, 1, 0, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilexternalid_Internalname, "External Id", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_50_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilexternalid_Internalname, StringUtil.RTrim( AV10FilExternalId), StringUtil.RTrim( context.localUtil.Format( AV10FilExternalId, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFilexternalid_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavFilexternalid_Enabled, 0, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GeneXusSecurityCommon\\GAMDescriptionLong", "left", true, "", "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridcell_Internalname, 1, 0, "px", 0, "px", divGridcell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "ContainerFluid WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-9 SubtitleContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCtlname1_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtlname1_Internalname, "PARENT ROLE", "col-xs-6 col-sm-4 col-md-3 SubtitleAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-8 col-md-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "SubtitleAttribute";
            StyleString = "";
            ClassString = "SubtitleAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavCtlname1_Internalname, StringUtil.RTrim( AV13GAMRole.gxTpr_Name), "", "", 0, 1, edtavCtlname1_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "254", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9 col-xs-offset-3 col-sm-12 col-sm-offset-0 col-lg-6 col-lg-offset-3", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridwwContainer.SetWrapped(nGXWrapped);
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"50\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridww_Internalname, subGridww_Internalname, "", "WorkWith", 0, "", "", 1, 0, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGridww_Backcolorstyle == 0 )
               {
                  subGridww_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGridww_Class) > 0 )
                  {
                     subGridww_Linesclass = subGridww_Class+"Title";
                  }
               }
               else
               {
                  subGridww_Titlebackstyle = 1;
                  if ( subGridww_Backcolorstyle == 1 )
                  {
                     subGridww_Titlebackcolor = subGridww_Allbackcolor;
                     if ( StringUtil.Len( subGridww_Class) > 0 )
                     {
                        subGridww_Linesclass = subGridww_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGridww_Class) > 0 )
                     {
                        subGridww_Linesclass = subGridww_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"CheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Select") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Role") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Key Numeric Long") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute TextLikeLink"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridwwContainer.AddObjectProperty("GridName", "Gridww");
            }
            else
            {
               GridwwContainer.AddObjectProperty("GridName", "Gridww");
               GridwwContainer.AddObjectProperty("Header", subGridww_Header);
               GridwwContainer.AddObjectProperty("Class", "WorkWith");
               GridwwContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Backcolorstyle), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("CmpContext", "");
               GridwwContainer.AddObjectProperty("InMasterPage", "false");
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV22Select));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV16Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Id), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavId_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV5BtnAddRole));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnaddrole_Enabled), 5, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnaddrole_Tooltiptext));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectedindex), 4, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowselection), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectioncolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowhovering), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Hoveringcolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowcollapsing), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 50 )
         {
            wbEnd = 0;
            nRC_GXsfl_50 = (int)(nGXsfl_50_idx-1);
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridww", GridwwContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridwwContainerData", GridwwContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridwwContainerData"+"V", GridwwContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridwwContainerData"+"V"+"\" value='"+GridwwContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-sm-offset-3 col-lg-4 col-lg-offset-4", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable6_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-3 col-md-2 col-md-offset-2", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbfirst_Internalname, "FIRST", "", "", lblTbfirst_Jsonclick, "'"+""+"'"+",false,"+"'"+"e122b1_client"+"'", "", lblTbfirst_Class, 7, "", 1, lblTbfirst_Enabled, 0, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-md-1", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTb1_Internalname, "/", "", "", lblTb1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SelectedPagingText TextLikeLink", 0, "", 1, 1, 0, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-3 col-lg-2", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbprev_Internalname, "PREV", "", "", lblTbprev_Jsonclick, "'"+""+"'"+",false,"+"'"+"e132b1_client"+"'", "", lblTbprev_Class, 7, "", 1, lblTbprev_Enabled, 0, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-md-1", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTb2_Internalname, "/", "", "", lblTb2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SelectedPagingText TextLikeLink", 0, "", 1, 1, 0, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbnext_Internalname, "NEXT", "", "", lblTbnext_Jsonclick, "'"+""+"'"+",false,"+"'"+"e142b1_client"+"'", "", lblTbnext_Class, 7, "", 1, 1, 0, "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_50_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CurrentPage), 4, 0, ".", "")), ((edtavCurrentpage_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7CurrentPage), "ZZZ9")) : context.localUtil.Format( (decimal)(AV7CurrentPage), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavCurrentpage_Visible, edtavCurrentpage_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_GAMExampleRoleSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 50 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridwwContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridww", GridwwContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridwwContainerData", GridwwContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridwwContainerData"+"V", GridwwContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridwwContainerData"+"V"+"\" value='"+GridwwContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START2B2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Select role", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2B0( ) ;
      }

      protected void WS2B2( )
      {
         START2B2( ) ;
         EVT2B2( ) ;
      }

      protected void EVT2B2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'ADDSELECTED'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddSelected' */
                              E152B2 ();
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
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "GRIDWW.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'ADDROLE'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "'ADDROLE'") == 0 ) )
                           {
                              nGXsfl_50_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_50_idx), 4, 0), 4, "0");
                              SubsflControlProps_502( ) ;
                              AV22Select = StringUtil.StrToBool( cgiGet( chkavSelect_Internalname));
                              AssignAttri("", false, chkavSelect_Internalname, AV22Select);
                              AV16Name = cgiGet( edtavName_Internalname);
                              AssignAttri("", false, edtavName_Internalname, AV16Name);
                              if ( ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ",") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vID");
                                 GX_FocusControl = edtavId_Internalname;
                                 AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV14Id = 0;
                                 AssignAttri("", false, edtavId_Internalname, StringUtil.LTrimStr( (decimal)(AV14Id), 12, 0));
                                 AssignAttri("", false, "gxhash_vID"+"_"+sGXsfl_50_idx, GetSecureSignedToken( sGXsfl_50_idx, context.localUtil.Format( (decimal)(AV14Id), "ZZZZZZZZZZZ9"), context));
                              }
                              else
                              {
                                 AV14Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ","));
                                 AssignAttri("", false, edtavId_Internalname, StringUtil.LTrimStr( (decimal)(AV14Id), 12, 0));
                                 AssignAttri("", false, "gxhash_vID"+"_"+sGXsfl_50_idx, GetSecureSignedToken( sGXsfl_50_idx, context.localUtil.Format( (decimal)(AV14Id), "ZZZZZZZZZZZ9"), context));
                              }
                              AV5BtnAddRole = cgiGet( edtavBtnaddrole_Internalname);
                              AssignAttri("", false, edtavBtnaddrole_Internalname, AV5BtnAddRole);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E162B2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E172B2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ADDROLE'") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: 'AddRole' */
                                    E182B2 ();
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
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
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

      protected void WE2B2( )
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

      protected void PA2B2( )
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
               GX_FocusControl = edtavFilname_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridww_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_502( ) ;
         while ( nGXsfl_50_idx <= nRC_GXsfl_50 )
         {
            sendrow_502( ) ;
            nGXsfl_50_idx = ((subGridww_Islastpage==1)&&(nGXsfl_50_idx+1>subGridww_fnc_Recordsperpage( )) ? 1 : nGXsfl_50_idx+1);
            sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_50_idx), 4, 0), 4, "0");
            SubsflControlProps_502( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( GridwwContainer)) ;
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( long AV19RoleIdAux ,
                                         String AV11FilName ,
                                         String AV21SearchFilter ,
                                         String AV10FilExternalId ,
                                         short AV7CurrentPage )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRIDWW_nCurrentRecord = 0;
         RF2B2( ) ;
         /* End function gxgrGridww_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Id), 12, 0, ".", "")));
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
         RF2B2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavCtlname1_Enabled = 0;
         AssignProp("", false, edtavCtlname1_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname1_Enabled), 5, 0), true);
         edtavName_Enabled = 0;
         AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), !bGXsfl_50_Refreshing);
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), !bGXsfl_50_Refreshing);
         edtavBtnaddrole_Enabled = 0;
         AssignProp("", false, edtavBtnaddrole_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtnaddrole_Enabled), 5, 0), !bGXsfl_50_Refreshing);
         edtavCurrentpage_Enabled = 0;
         AssignProp("", false, edtavCurrentpage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCurrentpage_Enabled), 5, 0), true);
      }

      protected void RF2B2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 50;
         nGXsfl_50_idx = 1;
         sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_50_idx), 4, 0), 4, "0");
         SubsflControlProps_502( ) ;
         bGXsfl_50_Refreshing = true;
         GridwwContainer.AddObjectProperty("GridName", "Gridww");
         GridwwContainer.AddObjectProperty("CmpContext", "");
         GridwwContainer.AddObjectProperty("InMasterPage", "false");
         GridwwContainer.AddObjectProperty("Class", "WorkWith");
         GridwwContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridwwContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
         GridwwContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Backcolorstyle), 1, 0, ".", "")));
         GridwwContainer.PageSize = subGridww_fnc_Recordsperpage( );
         if ( subGridww_Islastpage != 0 )
         {
            GRIDWW_nFirstRecordOnPage = (long)(subGridww_fnc_Recordcount( )-subGridww_fnc_Recordsperpage( ));
            GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
            GridwwContainer.AddObjectProperty("GRIDWW_nFirstRecordOnPage", GRIDWW_nFirstRecordOnPage);
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_502( ) ;
            E172B2 ();
            wbEnd = 50;
            WB2B0( ) ;
         }
         bGXsfl_50_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2B2( )
      {
         GxWebStd.gx_hidden_field( context, "vROLEIDAUX", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19RoleIdAux), 12, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vSEARCHFILTER", StringUtil.RTrim( AV21SearchFilter));
         GxWebStd.gx_hidden_field( context, "gxhash_vSEARCHFILTER", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV21SearchFilter, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vID"+"_"+sGXsfl_50_idx, GetSecureSignedToken( sGXsfl_50_idx, context.localUtil.Format( (decimal)(AV14Id), "ZZZZZZZZZZZ9"), context));
      }

      protected int subGridww_fnc_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGridww_fnc_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGridww_fnc_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGridww_fnc_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP2B0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavCtlname1_Enabled = 0;
         AssignProp("", false, edtavCtlname1_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCtlname1_Enabled), 5, 0), true);
         edtavName_Enabled = 0;
         AssignProp("", false, edtavName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavName_Enabled), 5, 0), !bGXsfl_50_Refreshing);
         edtavId_Enabled = 0;
         AssignProp("", false, edtavId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavId_Enabled), 5, 0), !bGXsfl_50_Refreshing);
         edtavBtnaddrole_Enabled = 0;
         AssignProp("", false, edtavBtnaddrole_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavBtnaddrole_Enabled), 5, 0), !bGXsfl_50_Refreshing);
         edtavCurrentpage_Enabled = 0;
         AssignProp("", false, edtavCurrentpage_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavCurrentpage_Enabled), 5, 0), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E162B2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_50 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_50"), ".", ","));
            /* Read variables values. */
            AV11FilName = cgiGet( edtavFilname_Internalname);
            AssignAttri("", false, "AV11FilName", AV11FilName);
            AV10FilExternalId = cgiGet( edtavFilexternalid_Internalname);
            AssignAttri("", false, "AV10FilExternalId", AV10FilExternalId);
            AV13GAMRole.gxTpr_Name = cgiGet( edtavCtlname1_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCurrentpage_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCurrentpage_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCURRENTPAGE");
               GX_FocusControl = edtavCurrentpage_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7CurrentPage = 0;
               AssignAttri("", false, "AV7CurrentPage", StringUtil.LTrimStr( (decimal)(AV7CurrentPage), 4, 0));
            }
            else
            {
               AV7CurrentPage = (short)(context.localUtil.CToN( cgiGet( edtavCurrentpage_Internalname), ".", ","));
               AssignAttri("", false, "AV7CurrentPage", StringUtil.LTrimStr( (decimal)(AV7CurrentPage), 4, 0));
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
         E162B2 ();
         if (returnInSub) return;
      }

      protected void E162B2( )
      {
         /* Start Routine */
         if ( (0==AV18RoleId) || (0==AV19RoleIdAux) )
         {
            context.setWebReturnParms(new Object[] {(long)AV18RoleId,(long)AV19RoleIdAux});
            context.setWebReturnParmsMetadata(new Object[] {"AV18RoleId","AV19RoleIdAux"});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         AV13GAMRole.load( AV19RoleIdAux);
         AssignAttri("", false, "AV19RoleIdAux", StringUtil.LTrimStr( (decimal)(AV19RoleIdAux), 12, 0));
         AssignAttri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
         AV7CurrentPage = 1;
         AssignAttri("", false, "AV7CurrentPage", StringUtil.LTrimStr( (decimal)(AV7CurrentPage), 4, 0));
         edtavCurrentpage_Visible = 0;
         AssignProp("", false, edtavCurrentpage_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavCurrentpage_Visible), 5, 0), true);
         edtavBtnaddrole_Tooltiptext = "Add This Role";
         AssignProp("", false, edtavBtnaddrole_Internalname, "Tooltiptext", edtavBtnaddrole_Tooltiptext, !bGXsfl_50_Refreshing);
      }

      private void E172B2( )
      {
         /* Gridww_Load Routine */
         AV6CountRoles = 0;
         AV20RolesXPage = 10;
         AV13GAMRole.load( AV19RoleIdAux);
         AssignAttri("", false, "AV19RoleIdAux", StringUtil.LTrimStr( (decimal)(AV19RoleIdAux), 12, 0));
         AssignAttri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11FilName)) )
         {
            AV12Filter.gxTpr_Name = "%"+AV11FilName;
         }
         else
         {
            AV12Filter.gxTpr_Name = "%"+AV21SearchFilter;
         }
         AV12Filter.gxTpr_Externalid = "%"+AV10FilExternalId;
         AV12Filter.gxTpr_Limit = AV20RolesXPage;
         AV12Filter.gxTpr_Start = (int)((AV7CurrentPage-1)*AV12Filter.gxTpr_Limit+1);
         AV5BtnAddRole = "Add";
         AssignAttri("", false, edtavBtnaddrole_Internalname, AV5BtnAddRole);
         AV27GXV3 = 1;
         AV26GXV2 = AV13GAMRole.getunassignedroles(AV12Filter, out  AV9Errors);
         while ( AV27GXV3 <= AV26GXV2.Count )
         {
            AV17Role = ((GeneXus.Programs.genexussecurity.SdtGAMRole)AV26GXV2.Item(AV27GXV3));
            AV6CountRoles = (long)(AV6CountRoles+1);
            AV22Select = false;
            AssignAttri("", false, chkavSelect_Internalname, AV22Select);
            AV14Id = AV17Role.gxTpr_Id;
            AssignAttri("", false, edtavId_Internalname, StringUtil.LTrimStr( (decimal)(AV14Id), 12, 0));
            AssignAttri("", false, "gxhash_vID"+"_"+sGXsfl_50_idx, GetSecureSignedToken( sGXsfl_50_idx, context.localUtil.Format( (decimal)(AV14Id), "ZZZZZZZZZZZ9"), context));
            AV16Name = AV17Role.gxTpr_Name;
            AssignAttri("", false, edtavName_Internalname, AV16Name);
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 50;
            }
            sendrow_502( ) ;
            if ( isFullAjaxMode( ) && ! bGXsfl_50_Refreshing )
            {
               context.DoAjaxLoad(50, GridwwRow);
            }
            AV27GXV3 = (int)(AV27GXV3+1);
         }
         if ( AV6CountRoles < AV20RolesXPage )
         {
            lblTbnext_Class = "SelectedPagingText";
            AssignProp("", false, lblTbnext_Internalname, "Class", lblTbnext_Class, true);
         }
         else
         {
            lblTbnext_Class = "PagingText";
            AssignProp("", false, lblTbnext_Internalname, "Class", lblTbnext_Class, true);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13GAMRole", AV13GAMRole);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12Filter", AV12Filter);
      }

      protected void E152B2( )
      {
         /* 'AddSelected' Routine */
         AV13GAMRole.load( AV19RoleIdAux);
         AssignAttri("", false, "AV19RoleIdAux", StringUtil.LTrimStr( (decimal)(AV19RoleIdAux), 12, 0));
         AssignAttri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
         /* Start For Each Line */
         nRC_GXsfl_50 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_50"), ".", ","));
         nGXsfl_50_fel_idx = 0;
         while ( nGXsfl_50_fel_idx < nRC_GXsfl_50 )
         {
            nGXsfl_50_fel_idx = ((subGridww_Islastpage==1)&&(nGXsfl_50_fel_idx+1>subGridww_fnc_Recordsperpage( )) ? 1 : nGXsfl_50_fel_idx+1);
            sGXsfl_50_fel_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_50_fel_idx), 4, 0), 4, "0");
            SubsflControlProps_fel_502( ) ;
            AV22Select = StringUtil.StrToBool( cgiGet( chkavSelect_Internalname));
            AV16Name = cgiGet( edtavName_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ",") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vID");
               GX_FocusControl = edtavId_Internalname;
               wbErr = true;
               AV14Id = 0;
            }
            else
            {
               AV14Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ".", ","));
            }
            AV5BtnAddRole = cgiGet( edtavBtnaddrole_Internalname);
            if ( AV22Select )
            {
               AV15isOK = AV13GAMRole.addrolebyid(AV14Id, ref  AV9Errors);
               AssignAttri("", false, "AV15isOK", AV15isOK);
               if ( ! AV15isOK )
               {
                  AV29GXV4 = 1;
                  while ( AV29GXV4 <= AV9Errors.Count )
                  {
                     AV8Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV9Errors.Item(AV29GXV4));
                     GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV8Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV8Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
                     AV29GXV4 = (int)(AV29GXV4+1);
                  }
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_50_fel_idx == 0 )
         {
            nGXsfl_50_idx = 1;
            sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_50_idx), 4, 0), 4, "0");
            SubsflControlProps_502( ) ;
         }
         nGXsfl_50_fel_idx = 1;
         if ( AV15isOK )
         {
            context.CommitDataStores("gamexampleroleselect",pr_default);
            gxgrGridww_refresh( AV19RoleIdAux, AV11FilName, AV21SearchFilter, AV10FilExternalId, AV7CurrentPage) ;
         }
         else
         {
            AV30GXV5 = 1;
            while ( AV30GXV5 <= AV9Errors.Count )
            {
               AV8Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV9Errors.Item(AV30GXV5));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV8Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV8Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV30GXV5 = (int)(AV30GXV5+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13GAMRole", AV13GAMRole);
      }

      protected void E182B2( )
      {
         /* 'AddRole' Routine */
         AV13GAMRole.load( AV19RoleIdAux);
         AssignAttri("", false, "AV19RoleIdAux", StringUtil.LTrimStr( (decimal)(AV19RoleIdAux), 12, 0));
         AssignAttri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
         AV15isOK = AV13GAMRole.addrolebyid(AV14Id, ref  AV9Errors);
         AssignAttri("", false, "AV15isOK", AV15isOK);
         if ( ! AV15isOK )
         {
            AV31GXV6 = 1;
            while ( AV31GXV6 <= AV9Errors.Count )
            {
               AV8Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV9Errors.Item(AV31GXV6));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV8Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV8Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV31GXV6 = (int)(AV31GXV6+1);
            }
         }
         if ( AV15isOK )
         {
            context.CommitDataStores("gamexampleroleselect",pr_default);
            gxgrGridww_refresh( AV19RoleIdAux, AV11FilName, AV21SearchFilter, AV10FilExternalId, AV7CurrentPage) ;
         }
         else
         {
            AV32GXV7 = 1;
            while ( AV32GXV7 <= AV9Errors.Count )
            {
               AV8Error = ((GeneXus.Programs.genexussecurity.SdtGAMError)AV9Errors.Item(AV32GXV7));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV8Error.gxTpr_Message, StringUtil.LTrimStr( (decimal)(AV8Error.gxTpr_Code), 12, 0), "", "", "", "", "", "", ""));
               AV32GXV7 = (int)(AV32GXV7+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13GAMRole", AV13GAMRole);
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV18RoleId = Convert.ToInt64(getParm(obj,0));
         AssignAttri("", false, "AV18RoleId", StringUtil.LTrimStr( (decimal)(AV18RoleId), 12, 0));
         AV19RoleIdAux = Convert.ToInt64(getParm(obj,1));
         AssignAttri("", false, "AV19RoleIdAux", StringUtil.LTrimStr( (decimal)(AV19RoleIdAux), 12, 0));
         AssignAttri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19RoleIdAux), "ZZZZZZZZZZZ9"), context));
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
         PA2B2( ) ;
         WS2B2( ) ;
         WE2B2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202041511102092", true, true);
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
         context.AddJavascriptSource("gamexampleroleselect.js", "?202041511102093", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_502( )
      {
         chkavSelect_Internalname = "vSELECT_"+sGXsfl_50_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_50_idx;
         edtavId_Internalname = "vID_"+sGXsfl_50_idx;
         edtavBtnaddrole_Internalname = "vBTNADDROLE_"+sGXsfl_50_idx;
      }

      protected void SubsflControlProps_fel_502( )
      {
         chkavSelect_Internalname = "vSELECT_"+sGXsfl_50_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_50_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_50_fel_idx;
         edtavBtnaddrole_Internalname = "vBTNADDROLE_"+sGXsfl_50_fel_idx;
      }

      protected void sendrow_502( )
      {
         SubsflControlProps_502( ) ;
         WB2B0( ) ;
         GridwwRow = GXWebRow.GetNew(context,GridwwContainer);
         if ( subGridww_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridww_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
            {
               subGridww_Linesclass = subGridww_Class+"Odd";
            }
         }
         else if ( subGridww_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridww_Backstyle = 0;
            subGridww_Backcolor = subGridww_Allbackcolor;
            if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
            {
               subGridww_Linesclass = subGridww_Class+"Uniform";
            }
         }
         else if ( subGridww_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridww_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
            {
               subGridww_Linesclass = subGridww_Class+"Odd";
            }
            subGridww_Backcolor = (int)(0x0);
         }
         else if ( subGridww_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridww_Backstyle = 1;
            if ( ((int)((nGXsfl_50_idx) % (2))) == 0 )
            {
               subGridww_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
               {
                  subGridww_Linesclass = subGridww_Class+"Even";
               }
            }
            else
            {
               subGridww_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
               {
                  subGridww_Linesclass = subGridww_Class+"Odd";
               }
            }
         }
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_50_idx+"\">") ;
         }
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavSelect.Enabled!=0)&&(chkavSelect.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 51,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ");
         ClassString = "CheckBox";
         StyleString = "";
         GXCCtl = "vSELECT_" + sGXsfl_50_idx;
         chkavSelect.Name = GXCCtl;
         chkavSelect.WebTags = "";
         chkavSelect.Caption = "";
         AssignProp("", false, chkavSelect_Internalname, "TitleCaption", chkavSelect.Caption, !bGXsfl_50_Refreshing);
         chkavSelect.CheckedValue = "false";
         AV22Select = StringUtil.StrToBool( StringUtil.BoolToStr( AV22Select));
         AssignAttri("", false, chkavSelect_Internalname, AV22Select);
         GridwwRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSelect_Internalname,StringUtil.BoolToStr( AV22Select),(String)"",(String)"",(short)-1,(short)1,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",TempTags+" onclick="+"\"gx.fn.checkboxClick(51, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+((chkavSelect.Enabled!=0)&&(chkavSelect.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,51);\"" : " ")});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 52,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ");
         ROClassString = "Attribute";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV16Name),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,52);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)50,(short)1,(short)-1,(short)-1,(bool)true,(String)"GeneXusSecurityCommon\\GAMDescriptionLong",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 53,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ");
         ROClassString = "Attribute";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Id), 12, 0, ".", "")),((edtavId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14Id), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV14Id), "ZZZZZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,53);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)50,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXusSecurityCommon\\GAMKeyNumLong",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         if ( GridwwContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavBtnaddrole_Enabled!=0)&&(edtavBtnaddrole_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 54,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ");
         ROClassString = "TextActionAttribute TextLikeLink";
         GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnaddrole_Internalname,StringUtil.RTrim( AV5BtnAddRole),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavBtnaddrole_Enabled!=0)&&(edtavBtnaddrole_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,54);\"" : " "),"'"+""+"'"+",false,"+"'"+"E\\'ADDROLE\\'."+sGXsfl_50_idx+"'",(String)"",(String)"",(String)edtavBtnaddrole_Tooltiptext,(String)"",(String)edtavBtnaddrole_Jsonclick,(short)5,(String)"TextActionAttribute TextLikeLink",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavBtnaddrole_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)50,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         send_integrity_lvl_hashes2B2( ) ;
         GridwwContainer.AddRow(GridwwRow);
         nGXsfl_50_idx = ((subGridww_Islastpage==1)&&(nGXsfl_50_idx+1>subGridww_fnc_Recordsperpage( )) ? 1 : nGXsfl_50_idx+1);
         sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_50_idx), 4, 0), 4, "0");
         SubsflControlProps_502( ) ;
         /* End function sendrow_502 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "vSELECT_" + sGXsfl_50_idx;
         chkavSelect.Name = GXCCtl;
         chkavSelect.WebTags = "";
         chkavSelect.Caption = "";
         AssignProp("", false, chkavSelect_Internalname, "TitleCaption", chkavSelect.Caption, !bGXsfl_50_Refreshing);
         chkavSelect.CheckedValue = "false";
         AV22Select = StringUtil.StrToBool( StringUtil.BoolToStr( AV22Select));
         AssignAttri("", false, chkavSelect_Internalname, AV22Select);
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttHide_Internalname = "HIDE";
         divTable5_Internalname = "TABLE5";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         bttBack_Internalname = "BACK";
         bttAddselected_Internalname = "ADDSELECTED";
         divTable1_Internalname = "TABLE1";
         edtavFilname_Internalname = "vFILNAME";
         divTable3_Internalname = "TABLE3";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtavFilexternalid_Internalname = "vFILEXTERNALID";
         divTable4_Internalname = "TABLE4";
         divFilterscontainer_Internalname = "FILTERSCONTAINER";
         divCellfilters_Internalname = "CELLFILTERS";
         edtavCtlname1_Internalname = "CTLNAME1";
         chkavSelect_Internalname = "vSELECT";
         edtavName_Internalname = "vNAME";
         edtavId_Internalname = "vID";
         edtavBtnaddrole_Internalname = "vBTNADDROLE";
         lblTbfirst_Internalname = "TBFIRST";
         lblTb1_Internalname = "TB1";
         lblTbprev_Internalname = "TBPREV";
         lblTb2_Internalname = "TB2";
         lblTbnext_Internalname = "TBNEXT";
         divTable6_Internalname = "TABLE6";
         edtavCurrentpage_Internalname = "vCURRENTPAGE";
         divGridtable_Internalname = "GRIDTABLE";
         divGridcell_Internalname = "GRIDCELL";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridww_Internalname = "GRIDWW";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavBtnaddrole_Jsonclick = "";
         edtavBtnaddrole_Visible = -1;
         edtavId_Jsonclick = "";
         edtavId_Visible = 0;
         edtavName_Jsonclick = "";
         edtavName_Visible = -1;
         chkavSelect.Caption = "";
         chkavSelect.Visible = -1;
         chkavSelect.Enabled = 1;
         edtavCtlname1_Enabled = -1;
         edtavCurrentpage_Jsonclick = "";
         edtavCurrentpage_Enabled = 1;
         edtavCurrentpage_Visible = 1;
         lblTbnext_Class = "PagingText TextLikeLink";
         lblTbprev_Class = "SelectedPagingText TextLikeLink";
         lblTbprev_Enabled = 1;
         lblTbfirst_Class = "SelectedPagingText TextLikeLink";
         lblTbfirst_Enabled = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         subGridww_Header = "";
         edtavBtnaddrole_Enabled = 1;
         edtavId_Enabled = 1;
         edtavName_Enabled = 1;
         subGridww_Class = "WorkWith";
         subGridww_Backcolorstyle = 0;
         edtavCtlname1_Enabled = 0;
         divGridcell_Class = "col-xs-12 col-sm-8 col-md-10 WWGridCell";
         edtavFilexternalid_Jsonclick = "";
         edtavFilexternalid_Enabled = 1;
         edtavFilname_Jsonclick = "";
         edtavFilname_Enabled = 1;
         bttHide_Class = "ShowFiltersButton";
         bttHide_Caption = "HIDE FILTERS";
         divFilterscontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Select role";
         edtavBtnaddrole_Tooltiptext = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'edtavBtnaddrole_Tooltiptext',ctrl:'vBTNADDROLE',prop:'Tooltiptext'},{av:'AV11FilName',fld:'vFILNAME',pic:''},{av:'AV10FilExternalId',fld:'vFILEXTERNALID',pic:''},{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'},{av:'AV19RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV21SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E172B2',iparms:[{av:'AV19RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV11FilName',fld:'vFILNAME',pic:''},{av:'AV21SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV10FilExternalId',fld:'vFILEXTERNALID',pic:''},{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("GRIDWW.LOAD",",oparms:[{av:'AV5BtnAddRole',fld:'vBTNADDROLE',pic:''},{av:'AV22Select',fld:'vSELECT',pic:''},{av:'AV14Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV16Name',fld:'vNAME',pic:''},{av:'lblTbnext_Class',ctrl:'TBNEXT',prop:'Class'}]}");
         setEventMetadata("'ADDSELECTED'","{handler:'E152B2',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'edtavBtnaddrole_Tooltiptext',ctrl:'vBTNADDROLE',prop:'Tooltiptext'},{av:'AV19RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV11FilName',fld:'vFILNAME',pic:''},{av:'AV21SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV10FilExternalId',fld:'vFILEXTERNALID',pic:''},{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'},{av:'AV22Select',fld:'vSELECT',grid:50,pic:''},{av:'nRC_GXsfl_50',ctrl:'GRIDWW',grid:50,prop:'GridRC'},{av:'AV14Id',fld:'vID',grid:50,pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV15isOK',fld:'vISOK',pic:''}]");
         setEventMetadata("'ADDSELECTED'",",oparms:[{av:'AV15isOK',fld:'vISOK',pic:''}]}");
         setEventMetadata("'ADDROLE'","{handler:'E182B2',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'edtavBtnaddrole_Tooltiptext',ctrl:'vBTNADDROLE',prop:'Tooltiptext'},{av:'AV19RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV11FilName',fld:'vFILNAME',pic:''},{av:'AV21SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV10FilExternalId',fld:'vFILEXTERNALID',pic:''},{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'},{av:'AV14Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true}]");
         setEventMetadata("'ADDROLE'",",oparms:[{av:'AV15isOK',fld:'vISOK',pic:''}]}");
         setEventMetadata("'HIDE'","{handler:'E112B1',iparms:[{av:'divFilterscontainer_Class',ctrl:'FILTERSCONTAINER',prop:'Class'}]");
         setEventMetadata("'HIDE'",",oparms:[{av:'divFilterscontainer_Class',ctrl:'FILTERSCONTAINER',prop:'Class'},{ctrl:'HIDE',prop:'Caption'},{ctrl:'HIDE',prop:'Class'},{av:'divGridcell_Class',ctrl:'GRIDCELL',prop:'Class'}]}");
         setEventMetadata("'FIRST'","{handler:'E122B1',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'edtavBtnaddrole_Tooltiptext',ctrl:'vBTNADDROLE',prop:'Tooltiptext'},{av:'AV19RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV11FilName',fld:'vFILNAME',pic:''},{av:'AV21SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV10FilExternalId',fld:'vFILEXTERNALID',pic:''},{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("'FIRST'",",oparms:[{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'},{av:'lblTbfirst_Class',ctrl:'TBFIRST',prop:'Class'},{av:'lblTbprev_Class',ctrl:'TBPREV',prop:'Class'},{av:'lblTbfirst_Enabled',ctrl:'TBFIRST',prop:'Enabled'},{av:'lblTbprev_Enabled',ctrl:'TBPREV',prop:'Enabled'}]}");
         setEventMetadata("'PREVIOUS'","{handler:'E132B1',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'edtavBtnaddrole_Tooltiptext',ctrl:'vBTNADDROLE',prop:'Tooltiptext'},{av:'AV19RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV11FilName',fld:'vFILNAME',pic:''},{av:'AV21SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV10FilExternalId',fld:'vFILEXTERNALID',pic:''},{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("'PREVIOUS'",",oparms:[{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'},{av:'lblTbfirst_Class',ctrl:'TBFIRST',prop:'Class'},{av:'lblTbprev_Class',ctrl:'TBPREV',prop:'Class'},{av:'lblTbfirst_Enabled',ctrl:'TBFIRST',prop:'Enabled'},{av:'lblTbprev_Enabled',ctrl:'TBPREV',prop:'Enabled'}]}");
         setEventMetadata("'NEXT'","{handler:'E142B1',iparms:[{av:'GRIDWW_nFirstRecordOnPage'},{av:'GRIDWW_nEOF'},{av:'edtavBtnaddrole_Tooltiptext',ctrl:'vBTNADDROLE',prop:'Tooltiptext'},{av:'AV19RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true},{av:'AV11FilName',fld:'vFILNAME',pic:''},{av:'AV21SearchFilter',fld:'vSEARCHFILTER',pic:'',hsh:true},{av:'AV10FilExternalId',fld:'vFILEXTERNALID',pic:''},{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]");
         setEventMetadata("'NEXT'",",oparms:[{av:'lblTbfirst_Class',ctrl:'TBFIRST',prop:'Class'},{av:'lblTbprev_Class',ctrl:'TBPREV',prop:'Class'},{av:'lblTbfirst_Enabled',ctrl:'TBFIRST',prop:'Enabled'},{av:'lblTbprev_Enabled',ctrl:'TBPREV',prop:'Enabled'},{av:'AV7CurrentPage',fld:'vCURRENTPAGE',pic:'ZZZ9'}]}");
         setEventMetadata("NULL","{handler:'Validv_Btnaddrole',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
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
         AV11FilName = "";
         AV21SearchFilter = "";
         AV10FilExternalId = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttHide_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         bttBack_Jsonclick = "";
         bttAddselected_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         AV13GAMRole = new GeneXus.Programs.genexussecurity.SdtGAMRole(context);
         GridwwContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridww_Linesclass = "";
         GridwwColumn = new GXWebColumn();
         AV16Name = "";
         AV5BtnAddRole = "";
         lblTbfirst_Jsonclick = "";
         lblTb1_Jsonclick = "";
         lblTbprev_Jsonclick = "";
         lblTb2_Jsonclick = "";
         lblTbnext_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV12Filter = new GeneXus.Programs.genexussecurity.SdtGAMRoleFilter(context);
         AV26GXV2 = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMRole>( context, "GeneXus.Programs.genexussecurity.SdtGAMRole", "GeneXus.Programs");
         AV9Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         AV17Role = new GeneXus.Programs.genexussecurity.SdtGAMRole(context);
         GridwwRow = new GXWebRow();
         AV8Error = new GeneXus.Programs.genexussecurity.SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         GXCCtl = "";
         ROClassString = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamexampleroleselect__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamexampleroleselect__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavCtlname1_Enabled = 0;
         edtavName_Enabled = 0;
         edtavId_Enabled = 0;
         edtavBtnaddrole_Enabled = 0;
         edtavCurrentpage_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short AV7CurrentPage ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGridww_Backcolorstyle ;
      private short subGridww_Titlebackstyle ;
      private short subGridww_Allowselection ;
      private short subGridww_Allowhovering ;
      private short subGridww_Allowcollapsing ;
      private short subGridww_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV20RolesXPage ;
      private short GRIDWW_nEOF ;
      private short nGXWrapped ;
      private short subGridww_Backstyle ;
      private int nRC_GXsfl_50 ;
      private int nGXsfl_50_idx=1 ;
      private int edtavFilname_Enabled ;
      private int edtavFilexternalid_Enabled ;
      private int edtavCtlname1_Enabled ;
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavName_Enabled ;
      private int edtavId_Enabled ;
      private int edtavBtnaddrole_Enabled ;
      private int subGridww_Selectedindex ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int lblTbfirst_Enabled ;
      private int lblTbprev_Enabled ;
      private int edtavCurrentpage_Enabled ;
      private int edtavCurrentpage_Visible ;
      private int subGridww_Islastpage ;
      private int AV27GXV3 ;
      private int nGXsfl_50_fel_idx=1 ;
      private int AV29GXV4 ;
      private int AV30GXV5 ;
      private int AV31GXV6 ;
      private int AV32GXV7 ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private int edtavName_Visible ;
      private int edtavId_Visible ;
      private int edtavBtnaddrole_Visible ;
      private long AV18RoleId ;
      private long AV19RoleIdAux ;
      private long wcpOAV18RoleId ;
      private long wcpOAV19RoleIdAux ;
      private long AV14Id ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV6CountRoles ;
      private String edtavBtnaddrole_Tooltiptext ;
      private String divFilterscontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_50_idx="0001" ;
      private String edtavBtnaddrole_Internalname ;
      private String AV11FilName ;
      private String AV21SearchFilter ;
      private String AV10FilExternalId ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable3_Internalname ;
      private String divTable5_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String bttHide_Class ;
      private String StyleString ;
      private String bttHide_Internalname ;
      private String bttHide_Caption ;
      private String bttHide_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String divTable1_Internalname ;
      private String bttBack_Internalname ;
      private String bttBack_Jsonclick ;
      private String bttAddselected_Internalname ;
      private String bttAddselected_Jsonclick ;
      private String edtavFilname_Internalname ;
      private String edtavFilname_Jsonclick ;
      private String divCellfilters_Internalname ;
      private String divFilterscontainer_Internalname ;
      private String divTable4_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavFilexternalid_Internalname ;
      private String edtavFilexternalid_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridcell_Class ;
      private String divGridtable_Internalname ;
      private String edtavCtlname1_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String subGridww_Header ;
      private String AV16Name ;
      private String AV5BtnAddRole ;
      private String divTable6_Internalname ;
      private String lblTbfirst_Internalname ;
      private String lblTbfirst_Jsonclick ;
      private String lblTbfirst_Class ;
      private String lblTb1_Internalname ;
      private String lblTb1_Jsonclick ;
      private String lblTbprev_Internalname ;
      private String lblTbprev_Jsonclick ;
      private String lblTbprev_Class ;
      private String lblTb2_Internalname ;
      private String lblTb2_Jsonclick ;
      private String lblTbnext_Internalname ;
      private String lblTbnext_Jsonclick ;
      private String lblTbnext_Class ;
      private String edtavCurrentpage_Internalname ;
      private String edtavCurrentpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavSelect_Internalname ;
      private String edtavName_Internalname ;
      private String edtavId_Internalname ;
      private String sGXsfl_50_fel_idx="0001" ;
      private String GXCCtl ;
      private String ROClassString ;
      private String edtavName_Jsonclick ;
      private String edtavId_Jsonclick ;
      private String edtavBtnaddrole_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_50_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool AV15isOK ;
      private bool wbLoad ;
      private bool AV22Select ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private long aP0_RoleId ;
      private long aP1_RoleIdAux ;
      private GXCheckbox chkavSelect ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV9Errors ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMRole> AV26GXV2 ;
      private GXWebForm Form ;
      private GeneXus.Programs.genexussecurity.SdtGAMError AV8Error ;
      private GeneXus.Programs.genexussecurity.SdtGAMRoleFilter AV12Filter ;
      private GeneXus.Programs.genexussecurity.SdtGAMRole AV13GAMRole ;
      private GeneXus.Programs.genexussecurity.SdtGAMRole AV17Role ;
   }

   public class gamexampleroleselect__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamexampleroleselect__default : DataStoreHelperBase, IDataStoreHelper
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
