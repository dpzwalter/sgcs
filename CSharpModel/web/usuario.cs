/*
               File: Usuario
        Description: Usuario
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/23/2020 14:32:29.54
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
   public class usuario : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A40RolId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A40RolId", StringUtil.LTrimStr( (decimal)(A40RolId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_11( A40RolId) ;
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
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV13UsuarioID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV13UsuarioID", StringUtil.LTrimStr( (decimal)(AV13UsuarioID), 4, 0));
               GxWebStd.gx_hidden_field( context, "gxhash_vUSUARIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13UsuarioID), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            if ( context.ExposeMetadata( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_10-142546", 0) ;
            }
            Form.Meta.addItem("description", "Usuario", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuarioID_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public usuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public usuario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_UsuarioID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV13UsuarioID = aP1_UsuarioID;
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

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("masterpage", "GeneXus.Programs.masterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            DrawControls( ) ;
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void DrawControls( )
      {
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Usuario", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         ClassString = "ErrorViewer";
         StyleString = "";
         GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "BtnFirst";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtUsuarioID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtUsuarioID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42UsuarioID), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A42UsuarioID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtUsuID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtUsuID_Internalname, A32UsuID, StringUtil.RTrim( context.localUtil.Format( A32UsuID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuID_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuNom_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtUsuNom_Internalname, "Nom", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtUsuNom_Internalname, A35UsuNom, StringUtil.RTrim( context.localUtil.Format( A35UsuNom, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuNom_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuNom_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuApe_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtUsuApe_Internalname, "Ape", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtUsuApe_Internalname, A36UsuApe, StringUtil.RTrim( context.localUtil.Format( A36UsuApe, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuApe_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuApe_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgUsuImg_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Img", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         A33UsuImg_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000UsuImg_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)) ? A40000UsuImg_GXI : context.PathToRelativeUrl( A33UsuImg));
         GxWebStd.gx_bitmap( context, imgUsuImg_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgUsuImg_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "", "", "", 0, A33UsuImg_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Usuario.htm");
         AssignProp("", false, imgUsuImg_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)) ? A40000UsuImg_GXI : context.PathToRelativeUrl( A33UsuImg)), true);
         AssignProp("", false, imgUsuImg_Internalname, "IsBlob", StringUtil.BoolToStr( A33UsuImg_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuCla_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtUsuCla_Internalname, "Cla", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtUsuCla_Internalname, StringUtil.RTrim( A37UsuCla), StringUtil.RTrim( context.localUtil.Format( A37UsuCla, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuCla_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuCla_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, -1, 0, 0, 1, 0, -1, true, "", "left", true, "", "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtRolId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtRolId_Internalname, "Rol Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtRolId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A40RolId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A40RolId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtRolId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtRolId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Usuario.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_40_Internalname, sImgUrl, imgprompt_40_Link, "", "", context.GetTheme( ), imgprompt_40_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtRolNom_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtRolNom_Internalname, "Rol Nom", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtRolNom_Internalname, A39RolNom, StringUtil.RTrim( context.localUtil.Format( A39RolNom, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtRolNom_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtRolNom_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuNomCom_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtUsuNomCom_Internalname, "Nom Com", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtUsuNomCom_Internalname, A34UsuNomCom, StringUtil.RTrim( context.localUtil.Format( A34UsuNomCom, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuNomCom_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuNomCom_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Usuario.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110C2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z42UsuarioID = (short)(context.localUtil.CToN( cgiGet( "Z42UsuarioID"), ".", ","));
               Z32UsuID = cgiGet( "Z32UsuID");
               Z35UsuNom = cgiGet( "Z35UsuNom");
               Z36UsuApe = cgiGet( "Z36UsuApe");
               Z37UsuCla = cgiGet( "Z37UsuCla");
               Z40RolId = (short)(context.localUtil.CToN( cgiGet( "Z40RolId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N40RolId = (short)(context.localUtil.CToN( cgiGet( "N40RolId"), ".", ","));
               AV13UsuarioID = (short)(context.localUtil.CToN( cgiGet( "vUSUARIOID"), ".", ","));
               AV11Insert_RolId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ROLID"), ".", ","));
               A40000UsuImg_GXI = cgiGet( "USUIMG_GXI");
               AV14Pgmname = cgiGet( "vPGMNAME");
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioID_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIOID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A42UsuarioID = 0;
                  AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
               }
               else
               {
                  A42UsuarioID = (short)(context.localUtil.CToN( cgiGet( edtUsuarioID_Internalname), ".", ","));
                  AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
               }
               A32UsuID = cgiGet( edtUsuID_Internalname);
               AssignAttri("", false, "A32UsuID", A32UsuID);
               A35UsuNom = cgiGet( edtUsuNom_Internalname);
               AssignAttri("", false, "A35UsuNom", A35UsuNom);
               A36UsuApe = cgiGet( edtUsuApe_Internalname);
               AssignAttri("", false, "A36UsuApe", A36UsuApe);
               A33UsuImg = cgiGet( imgUsuImg_Internalname);
               AssignAttri("", false, "A33UsuImg", A33UsuImg);
               A37UsuCla = cgiGet( edtUsuCla_Internalname);
               AssignAttri("", false, "A37UsuCla", A37UsuCla);
               if ( ( ( context.localUtil.CToN( cgiGet( edtRolId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRolId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ROLID");
                  AnyError = 1;
                  GX_FocusControl = edtRolId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A40RolId = 0;
                  AssignAttri("", false, "A40RolId", StringUtil.LTrimStr( (decimal)(A40RolId), 4, 0));
               }
               else
               {
                  A40RolId = (short)(context.localUtil.CToN( cgiGet( edtRolId_Internalname), ".", ","));
                  AssignAttri("", false, "A40RolId", StringUtil.LTrimStr( (decimal)(A40RolId), 4, 0));
               }
               A39RolNom = cgiGet( edtRolNom_Internalname);
               AssignAttri("", false, "A39RolNom", A39RolNom);
               A34UsuNomCom = cgiGet( edtUsuNomCom_Internalname);
               AssignAttri("", false, "A34UsuNomCom", A34UsuNomCom);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgUsuImg_Internalname, ref  A33UsuImg, ref  A40000UsuImg_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Usuario");
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A42UsuarioID != Z42UsuarioID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLogError("usuario:[ SecurityCheckFailed (403 Forbidden) value for]"+forbiddenHiddens.ToJSonString());
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  A42UsuarioID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( IsDsp( ) )
                  {
                     sMode15 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode15;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound15 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_0C0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "USUARIOID");
                        AnyError = 1;
                        GX_FocusControl = edtUsuarioID_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E110C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! IsDsp( ) )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E120C2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll0C15( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         bttBtn_first_Visible = 0;
         AssignProp("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_first_Visible), 5, 0), true);
         bttBtn_previous_Visible = 0;
         AssignProp("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_previous_Visible), 5, 0), true);
         bttBtn_next_Visible = 0;
         AssignProp("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_next_Visible), 5, 0), true);
         bttBtn_last_Visible = 0;
         AssignProp("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_last_Visible), 5, 0), true);
         bttBtn_select_Visible = 0;
         AssignProp("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_select_Visible), 5, 0), true);
         if ( IsDsp( ) || IsDlt( ) )
         {
            bttBtn_delete_Visible = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
            if ( IsDsp( ) )
            {
               bttBtn_enter_Visible = 0;
               AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
            }
            DisableAttributes0C15( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( IsDlt( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_0C0( )
      {
         BeforeValidate0C15( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls0C15( ) ;
            }
            else
            {
               CheckExtendedTable0C15( ) ;
               CloseExtendedTableCursors0C15( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         }
      }

      protected void ResetCaption0C0( )
      {
      }

      protected void E110C2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV14Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "SGCS");
         AV11Insert_RolId = 0;
         AssignAttri("", false, "AV11Insert_RolId", StringUtil.LTrimStr( (decimal)(AV11Insert_RolId), 4, 0));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV14Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV15GXV1 = 1;
            AssignAttri("", false, "AV15GXV1", StringUtil.LTrimStr( (decimal)(AV15GXV1), 8, 0));
            while ( AV15GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV15GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "RolId") == 0 )
               {
                  AV11Insert_RolId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV11Insert_RolId", StringUtil.LTrimStr( (decimal)(AV11Insert_RolId), 4, 0));
               }
               AV15GXV1 = (int)(AV15GXV1+1);
               AssignAttri("", false, "AV15GXV1", StringUtil.LTrimStr( (decimal)(AV15GXV1), 8, 0));
            }
         }
      }

      protected void E120C2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwusuario.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0C15( short GX_JID )
      {
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z32UsuID = T000C3_A32UsuID[0];
               Z35UsuNom = T000C3_A35UsuNom[0];
               Z36UsuApe = T000C3_A36UsuApe[0];
               Z37UsuCla = T000C3_A37UsuCla[0];
               Z40RolId = T000C3_A40RolId[0];
            }
            else
            {
               Z32UsuID = A32UsuID;
               Z35UsuNom = A35UsuNom;
               Z36UsuApe = A36UsuApe;
               Z37UsuCla = A37UsuCla;
               Z40RolId = A40RolId;
            }
         }
         if ( GX_JID == -10 )
         {
            Z42UsuarioID = A42UsuarioID;
            Z32UsuID = A32UsuID;
            Z35UsuNom = A35UsuNom;
            Z36UsuApe = A36UsuApe;
            Z33UsuImg = A33UsuImg;
            Z40000UsuImg_GXI = A40000UsuImg_GXI;
            Z37UsuCla = A37UsuCla;
            Z40RolId = A40RolId;
            Z39RolNom = A39RolNom;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_40_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ROLID"+"'), id:'"+"ROLID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV13UsuarioID) )
         {
            A42UsuarioID = AV13UsuarioID;
            AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
         }
         if ( ! (0==AV13UsuarioID) )
         {
            edtUsuarioID_Enabled = 0;
            AssignProp("", false, edtUsuarioID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuarioID_Enabled), 5, 0), true);
         }
         else
         {
            edtUsuarioID_Enabled = 1;
            AssignProp("", false, edtUsuarioID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuarioID_Enabled), 5, 0), true);
         }
         if ( ! (0==AV13UsuarioID) )
         {
            edtUsuarioID_Enabled = 0;
            AssignProp("", false, edtUsuarioID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuarioID_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_RolId) )
         {
            edtRolId_Enabled = 0;
            AssignProp("", false, edtRolId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtRolId_Enabled), 5, 0), true);
         }
         else
         {
            edtRolId_Enabled = 1;
            AssignProp("", false, edtRolId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtRolId_Enabled), 5, 0), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_RolId) )
         {
            A40RolId = AV11Insert_RolId;
            AssignAttri("", false, "A40RolId", StringUtil.LTrimStr( (decimal)(A40RolId), 4, 0));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV14Pgmname = "Usuario";
            AssignAttri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000C4 */
            pr_default.execute(2, new Object[] {A40RolId});
            A39RolNom = T000C4_A39RolNom[0];
            AssignAttri("", false, "A39RolNom", A39RolNom);
            pr_default.close(2);
         }
      }

      protected void Load0C15( )
      {
         /* Using cursor T000C5 */
         pr_default.execute(3, new Object[] {A42UsuarioID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound15 = 1;
            A32UsuID = T000C5_A32UsuID[0];
            AssignAttri("", false, "A32UsuID", A32UsuID);
            A35UsuNom = T000C5_A35UsuNom[0];
            AssignAttri("", false, "A35UsuNom", A35UsuNom);
            A36UsuApe = T000C5_A36UsuApe[0];
            AssignAttri("", false, "A36UsuApe", A36UsuApe);
            A40000UsuImg_GXI = T000C5_A40000UsuImg_GXI[0];
            AssignProp("", false, imgUsuImg_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)) ? A40000UsuImg_GXI : context.convertURL( context.PathToRelativeUrl( A33UsuImg))), true);
            AssignProp("", false, imgUsuImg_Internalname, "SrcSet", context.GetImageSrcSet( A33UsuImg), true);
            A37UsuCla = T000C5_A37UsuCla[0];
            AssignAttri("", false, "A37UsuCla", A37UsuCla);
            A39RolNom = T000C5_A39RolNom[0];
            AssignAttri("", false, "A39RolNom", A39RolNom);
            A40RolId = T000C5_A40RolId[0];
            AssignAttri("", false, "A40RolId", StringUtil.LTrimStr( (decimal)(A40RolId), 4, 0));
            A33UsuImg = T000C5_A33UsuImg[0];
            AssignAttri("", false, "A33UsuImg", A33UsuImg);
            AssignProp("", false, imgUsuImg_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)) ? A40000UsuImg_GXI : context.convertURL( context.PathToRelativeUrl( A33UsuImg))), true);
            AssignProp("", false, imgUsuImg_Internalname, "SrcSet", context.GetImageSrcSet( A33UsuImg), true);
            ZM0C15( -10) ;
         }
         pr_default.close(3);
         OnLoadActions0C15( ) ;
      }

      protected void OnLoadActions0C15( )
      {
         AV14Pgmname = "Usuario";
         AssignAttri("", false, "AV14Pgmname", AV14Pgmname);
         A34UsuNomCom = StringUtil.Trim( A35UsuNom) + " " + StringUtil.Trim( A36UsuApe);
         AssignAttri("", false, "A34UsuNomCom", A34UsuNomCom);
      }

      protected void CheckExtendedTable0C15( )
      {
         nIsDirty_15 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV14Pgmname = "Usuario";
         AssignAttri("", false, "AV14Pgmname", AV14Pgmname);
         nIsDirty_15 = 1;
         A34UsuNomCom = StringUtil.Trim( A35UsuNom) + " " + StringUtil.Trim( A36UsuApe);
         AssignAttri("", false, "A34UsuNomCom", A34UsuNomCom);
         /* Using cursor T000C4 */
         pr_default.execute(2, new Object[] {A40RolId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Rol'.", "ForeignKeyNotFound", 1, "ROLID");
            AnyError = 1;
            GX_FocusControl = edtRolId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A39RolNom = T000C4_A39RolNom[0];
         AssignAttri("", false, "A39RolNom", A39RolNom);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0C15( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_11( short A40RolId )
      {
         /* Using cursor T000C6 */
         pr_default.execute(4, new Object[] {A40RolId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Rol'.", "ForeignKeyNotFound", 1, "ROLID");
            AnyError = 1;
            GX_FocusControl = edtRolId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A39RolNom = T000C6_A39RolNom[0];
         AssignAttri("", false, "A39RolNom", A39RolNom);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A39RolNom)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(4) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(4);
      }

      protected void GetKey0C15( )
      {
         /* Using cursor T000C7 */
         pr_default.execute(5, new Object[] {A42UsuarioID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound15 = 1;
         }
         else
         {
            RcdFound15 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000C3 */
         pr_default.execute(1, new Object[] {A42UsuarioID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0C15( 10) ;
            RcdFound15 = 1;
            A42UsuarioID = T000C3_A42UsuarioID[0];
            AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
            A32UsuID = T000C3_A32UsuID[0];
            AssignAttri("", false, "A32UsuID", A32UsuID);
            A35UsuNom = T000C3_A35UsuNom[0];
            AssignAttri("", false, "A35UsuNom", A35UsuNom);
            A36UsuApe = T000C3_A36UsuApe[0];
            AssignAttri("", false, "A36UsuApe", A36UsuApe);
            A40000UsuImg_GXI = T000C3_A40000UsuImg_GXI[0];
            AssignProp("", false, imgUsuImg_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)) ? A40000UsuImg_GXI : context.convertURL( context.PathToRelativeUrl( A33UsuImg))), true);
            AssignProp("", false, imgUsuImg_Internalname, "SrcSet", context.GetImageSrcSet( A33UsuImg), true);
            A37UsuCla = T000C3_A37UsuCla[0];
            AssignAttri("", false, "A37UsuCla", A37UsuCla);
            A40RolId = T000C3_A40RolId[0];
            AssignAttri("", false, "A40RolId", StringUtil.LTrimStr( (decimal)(A40RolId), 4, 0));
            A33UsuImg = T000C3_A33UsuImg[0];
            AssignAttri("", false, "A33UsuImg", A33UsuImg);
            AssignProp("", false, imgUsuImg_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)) ? A40000UsuImg_GXI : context.convertURL( context.PathToRelativeUrl( A33UsuImg))), true);
            AssignProp("", false, imgUsuImg_Internalname, "SrcSet", context.GetImageSrcSet( A33UsuImg), true);
            Z42UsuarioID = A42UsuarioID;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            Load0C15( ) ;
            if ( AnyError == 1 )
            {
               RcdFound15 = 0;
               InitializeNonKey0C15( ) ;
            }
            Gx_mode = sMode15;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound15 = 0;
            InitializeNonKey0C15( ) ;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode15;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0C15( ) ;
         if ( RcdFound15 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound15 = 0;
         /* Using cursor T000C8 */
         pr_default.execute(6, new Object[] {A42UsuarioID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000C8_A42UsuarioID[0] < A42UsuarioID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000C8_A42UsuarioID[0] > A42UsuarioID ) ) )
            {
               A42UsuarioID = T000C8_A42UsuarioID[0];
               AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
               RcdFound15 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound15 = 0;
         /* Using cursor T000C9 */
         pr_default.execute(7, new Object[] {A42UsuarioID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000C9_A42UsuarioID[0] > A42UsuarioID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000C9_A42UsuarioID[0] < A42UsuarioID ) ) )
            {
               A42UsuarioID = T000C9_A42UsuarioID[0];
               AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
               RcdFound15 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0C15( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtUsuarioID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0C15( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound15 == 1 )
            {
               if ( A42UsuarioID != Z42UsuarioID )
               {
                  A42UsuarioID = Z42UsuarioID;
                  AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUARIOID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsuarioID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0C15( ) ;
                  GX_FocusControl = edtUsuarioID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A42UsuarioID != Z42UsuarioID )
               {
                  /* Insert record */
                  GX_FocusControl = edtUsuarioID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0C15( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUARIOID");
                     AnyError = 1;
                     GX_FocusControl = edtUsuarioID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtUsuarioID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0C15( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( IsUpd( ) || IsDlt( ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A42UsuarioID != Z42UsuarioID )
         {
            A42UsuarioID = Z42UsuarioID;
            AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuarioID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0C15( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T000C2 */
            pr_default.execute(0, new Object[] {A42UsuarioID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuario"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z32UsuID, T000C2_A32UsuID[0]) != 0 ) || ( StringUtil.StrCmp(Z35UsuNom, T000C2_A35UsuNom[0]) != 0 ) || ( StringUtil.StrCmp(Z36UsuApe, T000C2_A36UsuApe[0]) != 0 ) || ( StringUtil.StrCmp(Z37UsuCla, T000C2_A37UsuCla[0]) != 0 ) || ( Z40RolId != T000C2_A40RolId[0] ) )
            {
               if ( StringUtil.StrCmp(Z32UsuID, T000C2_A32UsuID[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuID");
                  GXUtil.WriteLogRaw("Old: ",Z32UsuID);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A32UsuID[0]);
               }
               if ( StringUtil.StrCmp(Z35UsuNom, T000C2_A35UsuNom[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuNom");
                  GXUtil.WriteLogRaw("Old: ",Z35UsuNom);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A35UsuNom[0]);
               }
               if ( StringUtil.StrCmp(Z36UsuApe, T000C2_A36UsuApe[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuApe");
                  GXUtil.WriteLogRaw("Old: ",Z36UsuApe);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A36UsuApe[0]);
               }
               if ( StringUtil.StrCmp(Z37UsuCla, T000C2_A37UsuCla[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuCla");
                  GXUtil.WriteLogRaw("Old: ",Z37UsuCla);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A37UsuCla[0]);
               }
               if ( Z40RolId != T000C2_A40RolId[0] )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"RolId");
                  GXUtil.WriteLogRaw("Old: ",Z40RolId);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A40RolId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Usuario"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0C15( )
      {
         BeforeValidate0C15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C15( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0C15( 0) ;
            CheckOptimisticConcurrency0C15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0C15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C10 */
                     pr_default.execute(8, new Object[] {A42UsuarioID, A32UsuID, A35UsuNom, A36UsuApe, A33UsuImg, A40000UsuImg_GXI, A37UsuCla, A40RolId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuario") ;
                     if ( (pr_default.getStatus(8) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0C0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0C15( ) ;
            }
            EndLevel0C15( ) ;
         }
         CloseExtendedTableCursors0C15( ) ;
      }

      protected void Update0C15( )
      {
         BeforeValidate0C15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C15( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0C15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C11 */
                     pr_default.execute(9, new Object[] {A32UsuID, A35UsuNom, A36UsuApe, A37UsuCla, A40RolId, A42UsuarioID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuario") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuario"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0C15( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( IsUpd( ) || IsDlt( ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0C15( ) ;
         }
         CloseExtendedTableCursors0C15( ) ;
      }

      protected void DeferredUpdate0C15( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000C12 */
            pr_default.execute(10, new Object[] {A33UsuImg, A40000UsuImg_GXI, A42UsuarioID});
            pr_default.close(10);
            dsDefault.SmartCacheProvider.SetUpdated("Usuario") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate0C15( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C15( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0C15( ) ;
            AfterConfirm0C15( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0C15( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000C13 */
                  pr_default.execute(11, new Object[] {A42UsuarioID});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("Usuario") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( IsUpd( ) || IsDlt( ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode15 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel0C15( ) ;
         Gx_mode = sMode15;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0C15( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "Usuario";
            AssignAttri("", false, "AV14Pgmname", AV14Pgmname);
            A34UsuNomCom = StringUtil.Trim( A35UsuNom) + " " + StringUtil.Trim( A36UsuApe);
            AssignAttri("", false, "A34UsuNomCom", A34UsuNomCom);
            /* Using cursor T000C14 */
            pr_default.execute(12, new Object[] {A40RolId});
            A39RolNom = T000C14_A39RolNom[0];
            AssignAttri("", false, "A39RolNom", A39RolNom);
            pr_default.close(12);
         }
      }

      protected void EndLevel0C15( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0C15( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("usuario",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0C0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("usuario",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0C15( )
      {
         /* Scan By routine */
         /* Using cursor T000C15 */
         pr_default.execute(13);
         RcdFound15 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound15 = 1;
            A42UsuarioID = T000C15_A42UsuarioID[0];
            AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0C15( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound15 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound15 = 1;
            A42UsuarioID = T000C15_A42UsuarioID[0];
            AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
         }
      }

      protected void ScanEnd0C15( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm0C15( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0C15( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0C15( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0C15( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0C15( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0C15( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0C15( )
      {
         edtUsuarioID_Enabled = 0;
         AssignProp("", false, edtUsuarioID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuarioID_Enabled), 5, 0), true);
         edtUsuID_Enabled = 0;
         AssignProp("", false, edtUsuID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuID_Enabled), 5, 0), true);
         edtUsuNom_Enabled = 0;
         AssignProp("", false, edtUsuNom_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuNom_Enabled), 5, 0), true);
         edtUsuApe_Enabled = 0;
         AssignProp("", false, edtUsuApe_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuApe_Enabled), 5, 0), true);
         imgUsuImg_Enabled = 0;
         AssignProp("", false, imgUsuImg_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgUsuImg_Enabled), 5, 0), true);
         edtUsuCla_Enabled = 0;
         AssignProp("", false, edtUsuCla_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuCla_Enabled), 5, 0), true);
         edtRolId_Enabled = 0;
         AssignProp("", false, edtRolId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtRolId_Enabled), 5, 0), true);
         edtRolNom_Enabled = 0;
         AssignProp("", false, edtRolNom_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtRolNom_Enabled), 5, 0), true);
         edtUsuNomCom_Enabled = 0;
         AssignProp("", false, edtUsuNomCom_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUsuNomCom_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes0C15( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0C0( )
      {
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 142546), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 142546), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 142546), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202082314323014", false, true);
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
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("usuario.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV13UsuarioID)+"\">") ;
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
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", "hsh"+"Usuario");
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLogInfo("usuario:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z42UsuarioID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42UsuarioID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z32UsuID", Z32UsuID);
         GxWebStd.gx_hidden_field( context, "Z35UsuNom", Z35UsuNom);
         GxWebStd.gx_hidden_field( context, "Z36UsuApe", Z36UsuApe);
         GxWebStd.gx_hidden_field( context, "Z37UsuCla", StringUtil.RTrim( Z37UsuCla));
         GxWebStd.gx_hidden_field( context, "Z40RolId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40RolId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N40RolId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40RolId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV9TrnContext, context));
         GxWebStd.gx_hidden_field( context, "vUSUARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13UsuarioID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUARIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13UsuarioID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_ROLID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_RolId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "USUIMG_GXI", A40000UsuImg_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
         GXCCtlgxBlob = "USUIMG" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A33UsuImg);
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("usuario.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV13UsuarioID) ;
      }

      public override String GetPgmname( )
      {
         return "Usuario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuario" ;
      }

      protected void InitializeNonKey0C15( )
      {
         A40RolId = 0;
         AssignAttri("", false, "A40RolId", StringUtil.LTrimStr( (decimal)(A40RolId), 4, 0));
         A34UsuNomCom = "";
         AssignAttri("", false, "A34UsuNomCom", A34UsuNomCom);
         A32UsuID = "";
         AssignAttri("", false, "A32UsuID", A32UsuID);
         A35UsuNom = "";
         AssignAttri("", false, "A35UsuNom", A35UsuNom);
         A36UsuApe = "";
         AssignAttri("", false, "A36UsuApe", A36UsuApe);
         A33UsuImg = "";
         AssignAttri("", false, "A33UsuImg", A33UsuImg);
         AssignProp("", false, imgUsuImg_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)) ? A40000UsuImg_GXI : context.convertURL( context.PathToRelativeUrl( A33UsuImg))), true);
         AssignProp("", false, imgUsuImg_Internalname, "SrcSet", context.GetImageSrcSet( A33UsuImg), true);
         A40000UsuImg_GXI = "";
         AssignProp("", false, imgUsuImg_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A33UsuImg)) ? A40000UsuImg_GXI : context.convertURL( context.PathToRelativeUrl( A33UsuImg))), true);
         AssignProp("", false, imgUsuImg_Internalname, "SrcSet", context.GetImageSrcSet( A33UsuImg), true);
         A37UsuCla = "";
         AssignAttri("", false, "A37UsuCla", A37UsuCla);
         A39RolNom = "";
         AssignAttri("", false, "A39RolNom", A39RolNom);
         Z32UsuID = "";
         Z35UsuNom = "";
         Z36UsuApe = "";
         Z37UsuCla = "";
         Z40RolId = 0;
      }

      protected void InitAll0C15( )
      {
         A42UsuarioID = 0;
         AssignAttri("", false, "A42UsuarioID", StringUtil.LTrimStr( (decimal)(A42UsuarioID), 4, 0));
         InitializeNonKey0C15( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202082314323019", true, true);
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
         context.AddJavascriptSource("usuario.js", "?202082314323019", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtUsuarioID_Internalname = "USUARIOID";
         edtUsuID_Internalname = "USUID";
         edtUsuNom_Internalname = "USUNOM";
         edtUsuApe_Internalname = "USUAPE";
         imgUsuImg_Internalname = "USUIMG";
         edtUsuCla_Internalname = "USUCLA";
         edtRolId_Internalname = "ROLID";
         edtRolNom_Internalname = "ROLNOM";
         edtUsuNomCom_Internalname = "USUNOMCOM";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_40_Internalname = "PROMPT_40";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Usuario";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtUsuNomCom_Jsonclick = "";
         edtUsuNomCom_Enabled = 0;
         edtRolNom_Jsonclick = "";
         edtRolNom_Enabled = 0;
         imgprompt_40_Visible = 1;
         imgprompt_40_Link = "";
         edtRolId_Jsonclick = "";
         edtRolId_Enabled = 1;
         edtUsuCla_Jsonclick = "";
         edtUsuCla_Enabled = 1;
         imgUsuImg_Enabled = 1;
         edtUsuApe_Jsonclick = "";
         edtUsuApe_Enabled = 1;
         edtUsuNom_Jsonclick = "";
         edtUsuNom_Enabled = 1;
         edtUsuID_Jsonclick = "";
         edtUsuID_Enabled = 1;
         edtUsuarioID_Jsonclick = "";
         edtUsuarioID_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public void Valid_Rolid( )
      {
         /* Using cursor T000C14 */
         pr_default.execute(12, new Object[] {A40RolId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Rol'.", "ForeignKeyNotFound", 1, "ROLID");
            AnyError = 1;
            GX_FocusControl = edtRolId_Internalname;
         }
         A39RolNom = T000C14_A39RolNom[0];
         pr_default.close(12);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A39RolNom", A39RolNom);
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV13UsuarioID',fld:'vUSUARIOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV13UsuarioID',fld:'vUSUARIOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120C2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_USUARIOID","{handler:'Valid_Usuarioid',iparms:[]");
         setEventMetadata("VALID_USUARIOID",",oparms:[]}");
         setEventMetadata("VALID_USUNOM","{handler:'Valid_Usunom',iparms:[]");
         setEventMetadata("VALID_USUNOM",",oparms:[]}");
         setEventMetadata("VALID_USUAPE","{handler:'Valid_Usuape',iparms:[]");
         setEventMetadata("VALID_USUAPE",",oparms:[]}");
         setEventMetadata("VALID_ROLID","{handler:'Valid_Rolid',iparms:[{av:'A40RolId',fld:'ROLID',pic:'ZZZ9'},{av:'A39RolNom',fld:'ROLNOM',pic:''}]");
         setEventMetadata("VALID_ROLID",",oparms:[{av:'A39RolNom',fld:'ROLNOM',pic:''}]}");
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
         pr_default.close(1);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z32UsuID = "";
         Z35UsuNom = "";
         Z36UsuApe = "";
         Z37UsuCla = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A32UsuID = "";
         A35UsuNom = "";
         A36UsuApe = "";
         A33UsuImg = "";
         A40000UsuImg_GXI = "";
         sImgUrl = "";
         A37UsuCla = "";
         A39RolNom = "";
         A34UsuNomCom = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV14Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode15 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z33UsuImg = "";
         Z40000UsuImg_GXI = "";
         Z39RolNom = "";
         T000C4_A39RolNom = new String[] {""} ;
         T000C5_A42UsuarioID = new short[1] ;
         T000C5_A32UsuID = new String[] {""} ;
         T000C5_A35UsuNom = new String[] {""} ;
         T000C5_A36UsuApe = new String[] {""} ;
         T000C5_A40000UsuImg_GXI = new String[] {""} ;
         T000C5_A37UsuCla = new String[] {""} ;
         T000C5_A39RolNom = new String[] {""} ;
         T000C5_A40RolId = new short[1] ;
         T000C5_A33UsuImg = new String[] {""} ;
         T000C6_A39RolNom = new String[] {""} ;
         T000C7_A42UsuarioID = new short[1] ;
         T000C3_A42UsuarioID = new short[1] ;
         T000C3_A32UsuID = new String[] {""} ;
         T000C3_A35UsuNom = new String[] {""} ;
         T000C3_A36UsuApe = new String[] {""} ;
         T000C3_A40000UsuImg_GXI = new String[] {""} ;
         T000C3_A37UsuCla = new String[] {""} ;
         T000C3_A40RolId = new short[1] ;
         T000C3_A33UsuImg = new String[] {""} ;
         T000C8_A42UsuarioID = new short[1] ;
         T000C9_A42UsuarioID = new short[1] ;
         T000C2_A42UsuarioID = new short[1] ;
         T000C2_A32UsuID = new String[] {""} ;
         T000C2_A35UsuNom = new String[] {""} ;
         T000C2_A36UsuApe = new String[] {""} ;
         T000C2_A40000UsuImg_GXI = new String[] {""} ;
         T000C2_A37UsuCla = new String[] {""} ;
         T000C2_A40RolId = new short[1] ;
         T000C2_A33UsuImg = new String[] {""} ;
         T000C14_A39RolNom = new String[] {""} ;
         T000C15_A42UsuarioID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuario__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuario__default(),
            new Object[][] {
                new Object[] {
               T000C2_A42UsuarioID, T000C2_A32UsuID, T000C2_A35UsuNom, T000C2_A36UsuApe, T000C2_A40000UsuImg_GXI, T000C2_A37UsuCla, T000C2_A40RolId, T000C2_A33UsuImg
               }
               , new Object[] {
               T000C3_A42UsuarioID, T000C3_A32UsuID, T000C3_A35UsuNom, T000C3_A36UsuApe, T000C3_A40000UsuImg_GXI, T000C3_A37UsuCla, T000C3_A40RolId, T000C3_A33UsuImg
               }
               , new Object[] {
               T000C4_A39RolNom
               }
               , new Object[] {
               T000C5_A42UsuarioID, T000C5_A32UsuID, T000C5_A35UsuNom, T000C5_A36UsuApe, T000C5_A40000UsuImg_GXI, T000C5_A37UsuCla, T000C5_A39RolNom, T000C5_A40RolId, T000C5_A33UsuImg
               }
               , new Object[] {
               T000C6_A39RolNom
               }
               , new Object[] {
               T000C7_A42UsuarioID
               }
               , new Object[] {
               T000C8_A42UsuarioID
               }
               , new Object[] {
               T000C9_A42UsuarioID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000C14_A39RolNom
               }
               , new Object[] {
               T000C15_A42UsuarioID
               }
            }
         );
         AV14Pgmname = "Usuario";
      }

      private short wcpOAV13UsuarioID ;
      private short Z42UsuarioID ;
      private short Z40RolId ;
      private short N40RolId ;
      private short GxWebError ;
      private short A40RolId ;
      private short AV13UsuarioID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A42UsuarioID ;
      private short AV11Insert_RolId ;
      private short RcdFound15 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short nIsDirty_15 ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsuarioID_Enabled ;
      private int edtUsuID_Enabled ;
      private int edtUsuNom_Enabled ;
      private int edtUsuApe_Enabled ;
      private int imgUsuImg_Enabled ;
      private int edtUsuCla_Enabled ;
      private int edtRolId_Enabled ;
      private int imgprompt_40_Visible ;
      private int edtRolNom_Enabled ;
      private int edtUsuNomCom_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV15GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z37UsuCla ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuarioID_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtUsuarioID_Jsonclick ;
      private String edtUsuID_Internalname ;
      private String edtUsuID_Jsonclick ;
      private String edtUsuNom_Internalname ;
      private String edtUsuNom_Jsonclick ;
      private String edtUsuApe_Internalname ;
      private String edtUsuApe_Jsonclick ;
      private String imgUsuImg_Internalname ;
      private String sImgUrl ;
      private String edtUsuCla_Internalname ;
      private String A37UsuCla ;
      private String edtUsuCla_Jsonclick ;
      private String edtRolId_Internalname ;
      private String edtRolId_Jsonclick ;
      private String imgprompt_40_Internalname ;
      private String imgprompt_40_Link ;
      private String edtRolNom_Internalname ;
      private String edtRolNom_Jsonclick ;
      private String edtUsuNomCom_Internalname ;
      private String edtUsuNomCom_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV14Pgmname ;
      private String hsh ;
      private String sMode15 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A33UsuImg_IsBlob ;
      private bool returnInSub ;
      private String Z32UsuID ;
      private String Z35UsuNom ;
      private String Z36UsuApe ;
      private String A32UsuID ;
      private String A35UsuNom ;
      private String A36UsuApe ;
      private String A40000UsuImg_GXI ;
      private String A39RolNom ;
      private String A34UsuNomCom ;
      private String Z40000UsuImg_GXI ;
      private String Z39RolNom ;
      private String A33UsuImg ;
      private String Z33UsuImg ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000C4_A39RolNom ;
      private short[] T000C5_A42UsuarioID ;
      private String[] T000C5_A32UsuID ;
      private String[] T000C5_A35UsuNom ;
      private String[] T000C5_A36UsuApe ;
      private String[] T000C5_A40000UsuImg_GXI ;
      private String[] T000C5_A37UsuCla ;
      private String[] T000C5_A39RolNom ;
      private short[] T000C5_A40RolId ;
      private String[] T000C5_A33UsuImg ;
      private String[] T000C6_A39RolNom ;
      private short[] T000C7_A42UsuarioID ;
      private short[] T000C3_A42UsuarioID ;
      private String[] T000C3_A32UsuID ;
      private String[] T000C3_A35UsuNom ;
      private String[] T000C3_A36UsuApe ;
      private String[] T000C3_A40000UsuImg_GXI ;
      private String[] T000C3_A37UsuCla ;
      private short[] T000C3_A40RolId ;
      private String[] T000C3_A33UsuImg ;
      private short[] T000C8_A42UsuarioID ;
      private short[] T000C9_A42UsuarioID ;
      private short[] T000C2_A42UsuarioID ;
      private String[] T000C2_A32UsuID ;
      private String[] T000C2_A35UsuNom ;
      private String[] T000C2_A36UsuApe ;
      private String[] T000C2_A40000UsuImg_GXI ;
      private String[] T000C2_A37UsuCla ;
      private short[] T000C2_A40RolId ;
      private String[] T000C2_A33UsuImg ;
      private String[] T000C14_A39RolNom ;
      private short[] T000C15_A42UsuarioID ;
      private IDataStoreProvider pr_gam ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class usuario__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuario__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new ForEachCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new UpdateCursor(def[9])
       ,new UpdateCursor(def[10])
       ,new UpdateCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000C5 ;
        prmT000C5 = new Object[] {
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C4 ;
        prmT000C4 = new Object[] {
        new Object[] {"@RolId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C6 ;
        prmT000C6 = new Object[] {
        new Object[] {"@RolId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C7 ;
        prmT000C7 = new Object[] {
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C3 ;
        prmT000C3 = new Object[] {
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C8 ;
        prmT000C8 = new Object[] {
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C9 ;
        prmT000C9 = new Object[] {
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C2 ;
        prmT000C2 = new Object[] {
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C10 ;
        prmT000C10 = new Object[] {
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@UsuID",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@UsuNom",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@UsuApe",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@UsuImg",SqlDbType.VarBinary,1024,0} ,
        new Object[] {"@UsuImg_GXI",SqlDbType.VarChar,2048,0} ,
        new Object[] {"@UsuCla",SqlDbType.NChar,20,0} ,
        new Object[] {"@RolId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C11 ;
        prmT000C11 = new Object[] {
        new Object[] {"@UsuID",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@UsuNom",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@UsuApe",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@UsuCla",SqlDbType.NChar,20,0} ,
        new Object[] {"@RolId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C12 ;
        prmT000C12 = new Object[] {
        new Object[] {"@UsuImg",SqlDbType.VarBinary,1024,0} ,
        new Object[] {"@UsuImg_GXI",SqlDbType.VarChar,2048,0} ,
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C13 ;
        prmT000C13 = new Object[] {
        new Object[] {"@UsuarioID",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000C15 ;
        prmT000C15 = new Object[] {
        } ;
        Object[] prmT000C14 ;
        prmT000C14 = new Object[] {
        new Object[] {"@RolId",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000C2", "SELECT [UsuarioID], [UsuID], [UsuNom], [UsuApe], [UsuImg_GXI], [UsuCla], [RolId], [UsuImg] FROM [Usuario] WITH (UPDLOCK) WHERE [UsuarioID] = @UsuarioID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C2,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000C3", "SELECT [UsuarioID], [UsuID], [UsuNom], [UsuApe], [UsuImg_GXI], [UsuCla], [RolId], [UsuImg] FROM [Usuario] WHERE [UsuarioID] = @UsuarioID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C3,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000C4", "SELECT [RolNom] FROM [Rol] WHERE [RolId] = @RolId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C4,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000C5", "SELECT TM1.[UsuarioID], TM1.[UsuID], TM1.[UsuNom], TM1.[UsuApe], TM1.[UsuImg_GXI], TM1.[UsuCla], T2.[RolNom], TM1.[RolId], TM1.[UsuImg] FROM ([Usuario] TM1 INNER JOIN [Rol] T2 ON T2.[RolId] = TM1.[RolId]) WHERE TM1.[UsuarioID] = @UsuarioID ORDER BY TM1.[UsuarioID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C5,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000C6", "SELECT [RolNom] FROM [Rol] WHERE [RolId] = @RolId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C6,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000C7", "SELECT [UsuarioID] FROM [Usuario] WHERE [UsuarioID] = @UsuarioID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C7,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000C8", "SELECT TOP 1 [UsuarioID] FROM [Usuario] WHERE ( [UsuarioID] > @UsuarioID) ORDER BY [UsuarioID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C8,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000C9", "SELECT TOP 1 [UsuarioID] FROM [Usuario] WHERE ( [UsuarioID] < @UsuarioID) ORDER BY [UsuarioID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C9,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000C10", "INSERT INTO [Usuario]([UsuarioID], [UsuID], [UsuNom], [UsuApe], [UsuImg], [UsuImg_GXI], [UsuCla], [RolId]) VALUES(@UsuarioID, @UsuID, @UsuNom, @UsuApe, @UsuImg, @UsuImg_GXI, @UsuCla, @RolId)", GxErrorMask.GX_NOMASK,prmT000C10)
           ,new CursorDef("T000C11", "UPDATE [Usuario] SET [UsuID]=@UsuID, [UsuNom]=@UsuNom, [UsuApe]=@UsuApe, [UsuCla]=@UsuCla, [RolId]=@RolId  WHERE [UsuarioID] = @UsuarioID", GxErrorMask.GX_NOMASK,prmT000C11)
           ,new CursorDef("T000C12", "UPDATE [Usuario] SET [UsuImg]=@UsuImg, [UsuImg_GXI]=@UsuImg_GXI  WHERE [UsuarioID] = @UsuarioID", GxErrorMask.GX_NOMASK,prmT000C12)
           ,new CursorDef("T000C13", "DELETE FROM [Usuario]  WHERE [UsuarioID] = @UsuarioID", GxErrorMask.GX_NOMASK,prmT000C13)
           ,new CursorDef("T000C14", "SELECT [RolNom] FROM [Rol] WHERE [RolId] = @RolId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C14,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000C15", "SELECT [UsuarioID] FROM [Usuario] ORDER BY [UsuarioID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C15,100, GxCacheFrequency.OFF ,true,false )
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
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[4])[0] = rslt.getMultimediaUri(5) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
              ((short[]) buf[6])[0] = rslt.getShort(7) ;
              ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(5)) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[4])[0] = rslt.getMultimediaUri(5) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
              ((short[]) buf[6])[0] = rslt.getShort(7) ;
              ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(5)) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[4])[0] = rslt.getMultimediaUri(5) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
              ((short[]) buf[7])[0] = rslt.getShort(8) ;
              ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(5)) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 5 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 6 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 7 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 12 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 13 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
           case 1 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameterBlob(5, (String)parms[4], false);
              stmt.SetParameterMultimedia(6, (String)parms[5], (String)parms[4], "Usuario", "UsuImg");
              stmt.SetParameter(7, (String)parms[6]);
              stmt.SetParameter(8, (short)parms[7]);
              return;
           case 9 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (short)parms[4]);
              stmt.SetParameter(6, (short)parms[5]);
              return;
           case 10 :
              stmt.SetParameterBlob(1, (String)parms[0], false);
              stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Usuario", "UsuImg");
              stmt.SetParameter(3, (short)parms[2]);
              return;
           case 11 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
     }
  }

}

}
