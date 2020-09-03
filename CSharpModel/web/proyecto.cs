/*
               File: Proyecto
        Description: Proyecto
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/23/2020 14:32:28.98
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
   public class proyecto : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A11IdEstado = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A11IdEstado", StringUtil.LTrimStr( (decimal)(A11IdEstado), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_11( A11IdEstado) ;
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
               AV7IdProyecto = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7IdProyecto", StringUtil.LTrimStr( (decimal)(AV7IdProyecto), 4, 0));
               GxWebStd.gx_hidden_field( context, "gxhash_vIDPROYECTO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7IdProyecto), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Proyecto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtNombreProyecto_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public proyecto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public proyecto( IGxContext context )
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
                           short aP1_IdProyecto )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7IdProyecto = aP1_IdProyecto;
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Proyecto", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Proyecto.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Proyecto.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdProyecto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtIdProyecto_Internalname, "Id de Proyecto", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtIdProyecto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1IdProyecto), 4, 0, ".", "")), ((edtIdProyecto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9")) : context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdProyecto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdProyecto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Proyecto.htm");
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
         GxWebStd.gx_label_element( context, edtNombreProyecto_Internalname, "Nombre de Proyecto", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtNombreProyecto_Internalname, StringUtil.RTrim( A2NombreProyecto), StringUtil.RTrim( context.localUtil.Format( A2NombreProyecto, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNombreProyecto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNombreProyecto_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDescripcionProyecto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtDescripcionProyecto_Internalname, "Descripcion de Proyecto", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtDescripcionProyecto_Internalname, StringUtil.RTrim( A4DescripcionProyecto), StringUtil.RTrim( context.localUtil.Format( A4DescripcionProyecto, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDescripcionProyecto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDescripcionProyecto_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdEstado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtIdEstado_Internalname, "Id de Estado", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtIdEstado_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11IdEstado), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A11IdEstado), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdEstado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdEstado_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Proyecto.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_11_Internalname, sImgUrl, imgprompt_11_Link, "", "", context.GetTheme( ), imgprompt_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEstado_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEstado_Internalname, StringUtil.RTrim( A12Estado), StringUtil.RTrim( context.localUtil.Format( A12Estado, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstado_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtFechaCreacion_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtFechaCreacion_Internalname, "Fecha Creacion", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         context.WriteHtmlText( "<div id=\""+edtFechaCreacion_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtFechaCreacion_Internalname, context.localUtil.Format(A3FechaCreacion, "99/99/99"), context.localUtil.Format( A3FechaCreacion, "99/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFechaCreacion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFechaCreacion_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Proyecto.htm");
         GxWebStd.gx_bitmap( context, edtFechaCreacion_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtFechaCreacion_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Proyecto.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
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
         E11012 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z1IdProyecto = (short)(context.localUtil.CToN( cgiGet( "Z1IdProyecto"), ".", ","));
               Z2NombreProyecto = cgiGet( "Z2NombreProyecto");
               Z4DescripcionProyecto = cgiGet( "Z4DescripcionProyecto");
               Z3FechaCreacion = context.localUtil.CToD( cgiGet( "Z3FechaCreacion"), 0);
               Z11IdEstado = (short)(context.localUtil.CToN( cgiGet( "Z11IdEstado"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N11IdEstado = (short)(context.localUtil.CToN( cgiGet( "N11IdEstado"), ".", ","));
               AV7IdProyecto = (short)(context.localUtil.CToN( cgiGet( "vIDPROYECTO"), ".", ","));
               AV11Insert_IdEstado = (short)(context.localUtil.CToN( cgiGet( "vINSERT_IDESTADO"), ".", ","));
               Gx_date = context.localUtil.CToD( cgiGet( "vTODAY"), 0);
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               AV15Pgmname = cgiGet( "vPGMNAME");
               /* Read variables values. */
               A1IdProyecto = (short)(context.localUtil.CToN( cgiGet( edtIdProyecto_Internalname), ".", ","));
               AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
               A2NombreProyecto = cgiGet( edtNombreProyecto_Internalname);
               AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
               A4DescripcionProyecto = cgiGet( edtDescripcionProyecto_Internalname);
               AssignAttri("", false, "A4DescripcionProyecto", A4DescripcionProyecto);
               if ( ( ( context.localUtil.CToN( cgiGet( edtIdEstado_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtIdEstado_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDESTADO");
                  AnyError = 1;
                  GX_FocusControl = edtIdEstado_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A11IdEstado = 0;
                  AssignAttri("", false, "A11IdEstado", StringUtil.LTrimStr( (decimal)(A11IdEstado), 4, 0));
               }
               else
               {
                  A11IdEstado = (short)(context.localUtil.CToN( cgiGet( edtIdEstado_Internalname), ".", ","));
                  AssignAttri("", false, "A11IdEstado", StringUtil.LTrimStr( (decimal)(A11IdEstado), 4, 0));
               }
               A12Estado = cgiGet( edtEstado_Internalname);
               AssignAttri("", false, "A12Estado", A12Estado);
               A3FechaCreacion = context.localUtil.CToD( cgiGet( edtFechaCreacion_Internalname), 1);
               AssignAttri("", false, "A3FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Proyecto");
               A1IdProyecto = (short)(context.localUtil.CToN( cgiGet( edtIdProyecto_Internalname), ".", ","));
               AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
               forbiddenHiddens.Add("IdProyecto", context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               A3FechaCreacion = context.localUtil.CToD( cgiGet( edtFechaCreacion_Internalname), 1);
               AssignAttri("", false, "A3FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
               forbiddenHiddens.Add("FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1IdProyecto != Z1IdProyecto ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLogError("proyecto:[ SecurityCheckFailed (403 Forbidden) value for]"+forbiddenHiddens.ToJSonString());
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
                  A1IdProyecto = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
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
                     sMode1 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode1;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_010( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "IDPROYECTO");
                        AnyError = 1;
                        GX_FocusControl = edtIdProyecto_Internalname;
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
                           E11012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12012 ();
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
            E12012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
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
            DisableAttributes011( ) ;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         }
      }

      protected void ResetCaption010( )
      {
      }

      protected void E11012( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "SGCS");
         AV11Insert_IdEstado = 0;
         AssignAttri("", false, "AV11Insert_IdEstado", StringUtil.LTrimStr( (decimal)(AV11Insert_IdEstado), 4, 0));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1;
            AssignAttri("", false, "AV16GXV1", StringUtil.LTrimStr( (decimal)(AV16GXV1), 8, 0));
            while ( AV16GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV16GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "IdEstado") == 0 )
               {
                  AV11Insert_IdEstado = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV11Insert_IdEstado", StringUtil.LTrimStr( (decimal)(AV11Insert_IdEstado), 4, 0));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
               AssignAttri("", false, "AV16GXV1", StringUtil.LTrimStr( (decimal)(AV16GXV1), 8, 0));
            }
         }
      }

      protected void E12012( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwproyecto.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z2NombreProyecto = T00013_A2NombreProyecto[0];
               Z4DescripcionProyecto = T00013_A4DescripcionProyecto[0];
               Z3FechaCreacion = T00013_A3FechaCreacion[0];
               Z11IdEstado = T00013_A11IdEstado[0];
            }
            else
            {
               Z2NombreProyecto = A2NombreProyecto;
               Z4DescripcionProyecto = A4DescripcionProyecto;
               Z3FechaCreacion = A3FechaCreacion;
               Z11IdEstado = A11IdEstado;
            }
         }
         if ( GX_JID == -10 )
         {
            Z1IdProyecto = A1IdProyecto;
            Z2NombreProyecto = A2NombreProyecto;
            Z4DescripcionProyecto = A4DescripcionProyecto;
            Z3FechaCreacion = A3FechaCreacion;
            Z11IdEstado = A11IdEstado;
            Z12Estado = A12Estado;
         }
      }

      protected void standaloneNotModal( )
      {
         edtIdProyecto_Enabled = 0;
         AssignProp("", false, edtIdProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdProyecto_Enabled), 5, 0), true);
         edtFechaCreacion_Enabled = 0;
         AssignProp("", false, edtFechaCreacion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaCreacion_Enabled), 5, 0), true);
         Gx_BScreen = 0;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         Gx_date = DateTimeUtil.Today( context);
         AssignAttri("", false, "Gx_date", context.localUtil.Format(Gx_date, "99/99/99"));
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDESTADO"+"'), id:'"+"IDESTADO"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtIdProyecto_Enabled = 0;
         AssignProp("", false, edtIdProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdProyecto_Enabled), 5, 0), true);
         edtFechaCreacion_Enabled = 0;
         AssignProp("", false, edtFechaCreacion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaCreacion_Enabled), 5, 0), true);
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7IdProyecto) )
         {
            A1IdProyecto = AV7IdProyecto;
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_IdEstado) )
         {
            edtIdEstado_Enabled = 0;
            AssignProp("", false, edtIdEstado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdEstado_Enabled), 5, 0), true);
         }
         else
         {
            edtIdEstado_Enabled = 1;
            AssignProp("", false, edtIdEstado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdEstado_Enabled), 5, 0), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_IdEstado) )
         {
            A11IdEstado = AV11Insert_IdEstado;
            AssignAttri("", false, "A11IdEstado", StringUtil.LTrimStr( (decimal)(A11IdEstado), 4, 0));
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
         if ( IsIns( )  && (DateTime.MinValue==A3FechaCreacion) && ( Gx_BScreen == 0 ) )
         {
            A3FechaCreacion = Gx_date;
            AssignAttri("", false, "A3FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV15Pgmname = "Proyecto";
            AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A11IdEstado});
            A12Estado = T00014_A12Estado[0];
            AssignAttri("", false, "A12Estado", A12Estado);
            pr_default.close(2);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A1IdProyecto});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
            A2NombreProyecto = T00015_A2NombreProyecto[0];
            AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
            A4DescripcionProyecto = T00015_A4DescripcionProyecto[0];
            AssignAttri("", false, "A4DescripcionProyecto", A4DescripcionProyecto);
            A12Estado = T00015_A12Estado[0];
            AssignAttri("", false, "A12Estado", A12Estado);
            A3FechaCreacion = T00015_A3FechaCreacion[0];
            AssignAttri("", false, "A3FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
            A11IdEstado = T00015_A11IdEstado[0];
            AssignAttri("", false, "A11IdEstado", StringUtil.LTrimStr( (decimal)(A11IdEstado), 4, 0));
            ZM011( -10) ;
         }
         pr_default.close(3);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
         AV15Pgmname = "Proyecto";
         AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable011( )
      {
         nIsDirty_1 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV15Pgmname = "Proyecto";
         AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {A11IdEstado});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Estado'.", "ForeignKeyNotFound", 1, "IDESTADO");
            AnyError = 1;
            GX_FocusControl = edtIdEstado_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A12Estado = T00014_A12Estado[0];
         AssignAttri("", false, "A12Estado", A12Estado);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_11( short A11IdEstado )
      {
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A11IdEstado});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Estado'.", "ForeignKeyNotFound", 1, "IDESTADO");
            AnyError = 1;
            GX_FocusControl = edtIdEstado_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A12Estado = T00016_A12Estado[0];
         AssignAttri("", false, "A12Estado", A12Estado);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A12Estado))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(4) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(4);
      }

      protected void GetKey011( )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A1IdProyecto});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1IdProyecto});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 10) ;
            RcdFound1 = 1;
            A1IdProyecto = T00013_A1IdProyecto[0];
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
            A2NombreProyecto = T00013_A2NombreProyecto[0];
            AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
            A4DescripcionProyecto = T00013_A4DescripcionProyecto[0];
            AssignAttri("", false, "A4DescripcionProyecto", A4DescripcionProyecto);
            A3FechaCreacion = T00013_A3FechaCreacion[0];
            AssignAttri("", false, "A3FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
            A11IdEstado = T00013_A11IdEstado[0];
            AssignAttri("", false, "A11IdEstado", StringUtil.LTrimStr( (decimal)(A11IdEstado), 4, 0));
            Z1IdProyecto = A1IdProyecto;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A1IdProyecto});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00018_A1IdProyecto[0] < A1IdProyecto ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00018_A1IdProyecto[0] > A1IdProyecto ) ) )
            {
               A1IdProyecto = T00018_A1IdProyecto[0];
               AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
               RcdFound1 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1IdProyecto});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1IdProyecto[0] > A1IdProyecto ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1IdProyecto[0] < A1IdProyecto ) ) )
            {
               A1IdProyecto = T00019_A1IdProyecto[0];
               AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
               RcdFound1 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtNombreProyecto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1IdProyecto != Z1IdProyecto )
               {
                  A1IdProyecto = Z1IdProyecto;
                  AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDPROYECTO");
                  AnyError = 1;
                  GX_FocusControl = edtIdProyecto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtNombreProyecto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edtNombreProyecto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1IdProyecto != Z1IdProyecto )
               {
                  /* Insert record */
                  GX_FocusControl = edtNombreProyecto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDPROYECTO");
                     AnyError = 1;
                     GX_FocusControl = edtIdProyecto_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtNombreProyecto_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
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
         if ( A1IdProyecto != Z1IdProyecto )
         {
            A1IdProyecto = Z1IdProyecto;
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDPROYECTO");
            AnyError = 1;
            GX_FocusControl = edtIdProyecto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtNombreProyecto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1IdProyecto});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Proyecto"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z2NombreProyecto, T00012_A2NombreProyecto[0]) != 0 ) || ( StringUtil.StrCmp(Z4DescripcionProyecto, T00012_A4DescripcionProyecto[0]) != 0 ) || ( Z3FechaCreacion != T00012_A3FechaCreacion[0] ) || ( Z11IdEstado != T00012_A11IdEstado[0] ) )
            {
               if ( StringUtil.StrCmp(Z2NombreProyecto, T00012_A2NombreProyecto[0]) != 0 )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"NombreProyecto");
                  GXUtil.WriteLogRaw("Old: ",Z2NombreProyecto);
                  GXUtil.WriteLogRaw("Current: ",T00012_A2NombreProyecto[0]);
               }
               if ( StringUtil.StrCmp(Z4DescripcionProyecto, T00012_A4DescripcionProyecto[0]) != 0 )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"DescripcionProyecto");
                  GXUtil.WriteLogRaw("Old: ",Z4DescripcionProyecto);
                  GXUtil.WriteLogRaw("Current: ",T00012_A4DescripcionProyecto[0]);
               }
               if ( Z3FechaCreacion != T00012_A3FechaCreacion[0] )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"FechaCreacion");
                  GXUtil.WriteLogRaw("Old: ",Z3FechaCreacion);
                  GXUtil.WriteLogRaw("Current: ",T00012_A3FechaCreacion[0]);
               }
               if ( Z11IdEstado != T00012_A11IdEstado[0] )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"IdEstado");
                  GXUtil.WriteLogRaw("Old: ",Z11IdEstado);
                  GXUtil.WriteLogRaw("Current: ",T00012_A11IdEstado[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Proyecto"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000110 */
                     pr_default.execute(8, new Object[] {A2NombreProyecto, A4DescripcionProyecto, A3FechaCreacion, A11IdEstado});
                     A1IdProyecto = T000110_A1IdProyecto[0];
                     AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Proyecto") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption010( ) ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000111 */
                     pr_default.execute(9, new Object[] {A2NombreProyecto, A4DescripcionProyecto, A3FechaCreacion, A11IdEstado, A1IdProyecto});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Proyecto") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Proyecto"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000112 */
                  pr_default.execute(10, new Object[] {A1IdProyecto});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Proyecto") ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel011( ) ;
         Gx_mode = sMode1;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "Proyecto";
            AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000113 */
            pr_default.execute(11, new Object[] {A11IdEstado});
            A12Estado = T000113_A12Estado[0];
            AssignAttri("", false, "A12Estado", A12Estado);
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000114 */
            pr_default.execute(12, new Object[] {A1IdProyecto});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tarea"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel011( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("proyecto",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("proyecto",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Scan By routine */
         /* Using cursor T000115 */
         pr_default.execute(13);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1;
            A1IdProyecto = T000115_A1IdProyecto[0];
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1;
            A1IdProyecto = T000115_A1IdProyecto[0];
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
         edtIdProyecto_Enabled = 0;
         AssignProp("", false, edtIdProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdProyecto_Enabled), 5, 0), true);
         edtNombreProyecto_Enabled = 0;
         AssignProp("", false, edtNombreProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtNombreProyecto_Enabled), 5, 0), true);
         edtDescripcionProyecto_Enabled = 0;
         AssignProp("", false, edtDescripcionProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtDescripcionProyecto_Enabled), 5, 0), true);
         edtIdEstado_Enabled = 0;
         AssignProp("", false, edtIdEstado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdEstado_Enabled), 5, 0), true);
         edtEstado_Enabled = 0;
         AssignProp("", false, edtEstado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEstado_Enabled), 5, 0), true);
         edtFechaCreacion_Enabled = 0;
         AssignProp("", false, edtFechaCreacion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaCreacion_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues010( )
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
         context.AddJavascriptSource("gxcfg.js", "?202082314322951", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 142546), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 142546), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 142546), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("proyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7IdProyecto)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Proyecto");
         forbiddenHiddens.Add("IdProyecto", context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         forbiddenHiddens.Add("FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLogInfo("proyecto:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1IdProyecto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1IdProyecto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z2NombreProyecto", StringUtil.RTrim( Z2NombreProyecto));
         GxWebStd.gx_hidden_field( context, "Z4DescripcionProyecto", StringUtil.RTrim( Z4DescripcionProyecto));
         GxWebStd.gx_hidden_field( context, "Z3FechaCreacion", context.localUtil.DToC( Z3FechaCreacion, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z11IdEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11IdEstado), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N11IdEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11IdEstado), 4, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "vIDPROYECTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7IdProyecto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIDPROYECTO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7IdProyecto), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_IDESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_IdEstado), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
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
         return formatLink("proyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7IdProyecto) ;
      }

      public override String GetPgmname( )
      {
         return "Proyecto" ;
      }

      public override String GetPgmdesc( )
      {
         return "Proyecto" ;
      }

      protected void InitializeNonKey011( )
      {
         A11IdEstado = 0;
         AssignAttri("", false, "A11IdEstado", StringUtil.LTrimStr( (decimal)(A11IdEstado), 4, 0));
         A2NombreProyecto = "";
         AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
         A4DescripcionProyecto = "";
         AssignAttri("", false, "A4DescripcionProyecto", A4DescripcionProyecto);
         A12Estado = "";
         AssignAttri("", false, "A12Estado", A12Estado);
         A3FechaCreacion = Gx_date;
         AssignAttri("", false, "A3FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
         Z2NombreProyecto = "";
         Z4DescripcionProyecto = "";
         Z3FechaCreacion = DateTime.MinValue;
         Z11IdEstado = 0;
      }

      protected void InitAll011( )
      {
         A1IdProyecto = 0;
         AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A3FechaCreacion = i3FechaCreacion;
         AssignAttri("", false, "A3FechaCreacion", context.localUtil.Format(A3FechaCreacion, "99/99/99"));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202082314322956", true, true);
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
         context.AddJavascriptSource("proyecto.js", "?202082314322957", false, true);
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
         edtIdProyecto_Internalname = "IDPROYECTO";
         edtNombreProyecto_Internalname = "NOMBREPROYECTO";
         edtDescripcionProyecto_Internalname = "DESCRIPCIONPROYECTO";
         edtIdEstado_Internalname = "IDESTADO";
         edtEstado_Internalname = "ESTADO";
         edtFechaCreacion_Internalname = "FECHACREACION";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_11_Internalname = "PROMPT_11";
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
         Form.Caption = "Proyecto";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtFechaCreacion_Jsonclick = "";
         edtFechaCreacion_Enabled = 0;
         edtEstado_Jsonclick = "";
         edtEstado_Enabled = 0;
         imgprompt_11_Visible = 1;
         imgprompt_11_Link = "";
         edtIdEstado_Jsonclick = "";
         edtIdEstado_Enabled = 1;
         edtDescripcionProyecto_Jsonclick = "";
         edtDescripcionProyecto_Enabled = 1;
         edtNombreProyecto_Jsonclick = "";
         edtNombreProyecto_Enabled = 1;
         edtIdProyecto_Jsonclick = "";
         edtIdProyecto_Enabled = 0;
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

      public void Valid_Idestado( )
      {
         /* Using cursor T000113 */
         pr_default.execute(11, new Object[] {A11IdEstado});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Estado'.", "ForeignKeyNotFound", 1, "IDESTADO");
            AnyError = 1;
            GX_FocusControl = edtIdEstado_Internalname;
         }
         A12Estado = T000113_A12Estado[0];
         pr_default.close(11);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A12Estado", StringUtil.RTrim( A12Estado));
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7IdProyecto',fld:'vIDPROYECTO',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7IdProyecto',fld:'vIDPROYECTO',pic:'ZZZ9',hsh:true},{av:'A1IdProyecto',fld:'IDPROYECTO',pic:'ZZZ9'},{av:'A3FechaCreacion',fld:'FECHACREACION',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12012',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_IDPROYECTO","{handler:'Valid_Idproyecto',iparms:[]");
         setEventMetadata("VALID_IDPROYECTO",",oparms:[]}");
         setEventMetadata("VALID_IDESTADO","{handler:'Valid_Idestado',iparms:[{av:'A11IdEstado',fld:'IDESTADO',pic:'ZZZ9'},{av:'A12Estado',fld:'ESTADO',pic:''}]");
         setEventMetadata("VALID_IDESTADO",",oparms:[{av:'A12Estado',fld:'ESTADO',pic:''}]}");
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
         pr_default.close(11);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z2NombreProyecto = "";
         Z4DescripcionProyecto = "";
         Z3FechaCreacion = DateTime.MinValue;
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
         A2NombreProyecto = "";
         A4DescripcionProyecto = "";
         sImgUrl = "";
         A12Estado = "";
         A3FechaCreacion = DateTime.MinValue;
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_date = DateTime.MinValue;
         AV15Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode1 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z12Estado = "";
         T00014_A12Estado = new String[] {""} ;
         T00015_A1IdProyecto = new short[1] ;
         T00015_A2NombreProyecto = new String[] {""} ;
         T00015_A4DescripcionProyecto = new String[] {""} ;
         T00015_A12Estado = new String[] {""} ;
         T00015_A3FechaCreacion = new DateTime[] {DateTime.MinValue} ;
         T00015_A11IdEstado = new short[1] ;
         T00016_A12Estado = new String[] {""} ;
         T00017_A1IdProyecto = new short[1] ;
         T00013_A1IdProyecto = new short[1] ;
         T00013_A2NombreProyecto = new String[] {""} ;
         T00013_A4DescripcionProyecto = new String[] {""} ;
         T00013_A3FechaCreacion = new DateTime[] {DateTime.MinValue} ;
         T00013_A11IdEstado = new short[1] ;
         T00018_A1IdProyecto = new short[1] ;
         T00019_A1IdProyecto = new short[1] ;
         T00012_A1IdProyecto = new short[1] ;
         T00012_A2NombreProyecto = new String[] {""} ;
         T00012_A4DescripcionProyecto = new String[] {""} ;
         T00012_A3FechaCreacion = new DateTime[] {DateTime.MinValue} ;
         T00012_A11IdEstado = new short[1] ;
         T000110_A1IdProyecto = new short[1] ;
         T000113_A12Estado = new String[] {""} ;
         T000114_A5IdTarea = new short[1] ;
         T000115_A1IdProyecto = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i3FechaCreacion = DateTime.MinValue;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.proyecto__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.proyecto__default(),
            new Object[][] {
                new Object[] {
               T00012_A1IdProyecto, T00012_A2NombreProyecto, T00012_A4DescripcionProyecto, T00012_A3FechaCreacion, T00012_A11IdEstado
               }
               , new Object[] {
               T00013_A1IdProyecto, T00013_A2NombreProyecto, T00013_A4DescripcionProyecto, T00013_A3FechaCreacion, T00013_A11IdEstado
               }
               , new Object[] {
               T00014_A12Estado
               }
               , new Object[] {
               T00015_A1IdProyecto, T00015_A2NombreProyecto, T00015_A4DescripcionProyecto, T00015_A12Estado, T00015_A3FechaCreacion, T00015_A11IdEstado
               }
               , new Object[] {
               T00016_A12Estado
               }
               , new Object[] {
               T00017_A1IdProyecto
               }
               , new Object[] {
               T00018_A1IdProyecto
               }
               , new Object[] {
               T00019_A1IdProyecto
               }
               , new Object[] {
               T000110_A1IdProyecto
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000113_A12Estado
               }
               , new Object[] {
               T000114_A5IdTarea
               }
               , new Object[] {
               T000115_A1IdProyecto
               }
            }
         );
         AV15Pgmname = "Proyecto";
         Z3FechaCreacion = DateTime.MinValue;
         A3FechaCreacion = DateTime.MinValue;
         i3FechaCreacion = DateTime.MinValue;
         Gx_date = DateTimeUtil.Today( context);
      }

      private short wcpOAV7IdProyecto ;
      private short Z1IdProyecto ;
      private short Z11IdEstado ;
      private short N11IdEstado ;
      private short GxWebError ;
      private short A11IdEstado ;
      private short AV7IdProyecto ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A1IdProyecto ;
      private short AV11Insert_IdEstado ;
      private short Gx_BScreen ;
      private short RcdFound1 ;
      private short GX_JID ;
      private short nIsDirty_1 ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtIdProyecto_Enabled ;
      private int edtNombreProyecto_Enabled ;
      private int edtDescripcionProyecto_Enabled ;
      private int edtIdEstado_Enabled ;
      private int imgprompt_11_Visible ;
      private int edtEstado_Enabled ;
      private int edtFechaCreacion_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV16GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z2NombreProyecto ;
      private String Z4DescripcionProyecto ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtNombreProyecto_Internalname ;
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
      private String edtIdProyecto_Internalname ;
      private String edtIdProyecto_Jsonclick ;
      private String A2NombreProyecto ;
      private String edtNombreProyecto_Jsonclick ;
      private String edtDescripcionProyecto_Internalname ;
      private String A4DescripcionProyecto ;
      private String edtDescripcionProyecto_Jsonclick ;
      private String edtIdEstado_Internalname ;
      private String edtIdEstado_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_11_Internalname ;
      private String imgprompt_11_Link ;
      private String edtEstado_Internalname ;
      private String A12Estado ;
      private String edtEstado_Jsonclick ;
      private String edtFechaCreacion_Internalname ;
      private String edtFechaCreacion_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV15Pgmname ;
      private String hsh ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z12Estado ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z3FechaCreacion ;
      private DateTime A3FechaCreacion ;
      private DateTime Gx_date ;
      private DateTime i3FechaCreacion ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00014_A12Estado ;
      private short[] T00015_A1IdProyecto ;
      private String[] T00015_A2NombreProyecto ;
      private String[] T00015_A4DescripcionProyecto ;
      private String[] T00015_A12Estado ;
      private DateTime[] T00015_A3FechaCreacion ;
      private short[] T00015_A11IdEstado ;
      private String[] T00016_A12Estado ;
      private short[] T00017_A1IdProyecto ;
      private short[] T00013_A1IdProyecto ;
      private String[] T00013_A2NombreProyecto ;
      private String[] T00013_A4DescripcionProyecto ;
      private DateTime[] T00013_A3FechaCreacion ;
      private short[] T00013_A11IdEstado ;
      private short[] T00018_A1IdProyecto ;
      private short[] T00019_A1IdProyecto ;
      private short[] T00012_A1IdProyecto ;
      private String[] T00012_A2NombreProyecto ;
      private String[] T00012_A4DescripcionProyecto ;
      private DateTime[] T00012_A3FechaCreacion ;
      private short[] T00012_A11IdEstado ;
      private short[] T000110_A1IdProyecto ;
      private String[] T000113_A12Estado ;
      private short[] T000114_A5IdTarea ;
      private short[] T000115_A1IdProyecto ;
      private IDataStoreProvider pr_gam ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class proyecto__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class proyecto__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[8])
       ,new UpdateCursor(def[9])
       ,new UpdateCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00015 ;
        prmT00015 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00014 ;
        prmT00014 = new Object[] {
        new Object[] {"@IdEstado",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00016 ;
        prmT00016 = new Object[] {
        new Object[] {"@IdEstado",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00017 ;
        prmT00017 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00013 ;
        prmT00013 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00018 ;
        prmT00018 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00019 ;
        prmT00019 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00012 ;
        prmT00012 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000110 ;
        prmT000110 = new Object[] {
        new Object[] {"@NombreProyecto",SqlDbType.NChar,60,0} ,
        new Object[] {"@DescripcionProyecto",SqlDbType.NChar,60,0} ,
        new Object[] {"@FechaCreacion",SqlDbType.DateTime,8,0} ,
        new Object[] {"@IdEstado",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000111 ;
        prmT000111 = new Object[] {
        new Object[] {"@NombreProyecto",SqlDbType.NChar,60,0} ,
        new Object[] {"@DescripcionProyecto",SqlDbType.NChar,60,0} ,
        new Object[] {"@FechaCreacion",SqlDbType.DateTime,8,0} ,
        new Object[] {"@IdEstado",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000112 ;
        prmT000112 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000114 ;
        prmT000114 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000115 ;
        prmT000115 = new Object[] {
        } ;
        Object[] prmT000113 ;
        prmT000113 = new Object[] {
        new Object[] {"@IdEstado",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00012", "SELECT [IdProyecto], [NombreProyecto], [DescripcionProyecto], [FechaCreacion], [IdEstado] FROM [Proyecto] WITH (UPDLOCK) WHERE [IdProyecto] = @IdProyecto ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00013", "SELECT [IdProyecto], [NombreProyecto], [DescripcionProyecto], [FechaCreacion], [IdEstado] FROM [Proyecto] WHERE [IdProyecto] = @IdProyecto ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00014", "SELECT [Estado] FROM [Estado] WHERE [IdEstado] = @IdEstado ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00015", "SELECT TM1.[IdProyecto], TM1.[NombreProyecto], TM1.[DescripcionProyecto], T2.[Estado], TM1.[FechaCreacion], TM1.[IdEstado] FROM ([Proyecto] TM1 INNER JOIN [Estado] T2 ON T2.[IdEstado] = TM1.[IdEstado]) WHERE TM1.[IdProyecto] = @IdProyecto ORDER BY TM1.[IdProyecto]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00016", "SELECT [Estado] FROM [Estado] WHERE [IdEstado] = @IdEstado ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00017", "SELECT [IdProyecto] FROM [Proyecto] WHERE [IdProyecto] = @IdProyecto  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00018", "SELECT TOP 1 [IdProyecto] FROM [Proyecto] WHERE ( [IdProyecto] > @IdProyecto) ORDER BY [IdProyecto]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T00019", "SELECT TOP 1 [IdProyecto] FROM [Proyecto] WHERE ( [IdProyecto] < @IdProyecto) ORDER BY [IdProyecto] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000110", "INSERT INTO [Proyecto]([NombreProyecto], [DescripcionProyecto], [FechaCreacion], [IdEstado]) VALUES(@NombreProyecto, @DescripcionProyecto, @FechaCreacion, @IdEstado); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000110)
           ,new CursorDef("T000111", "UPDATE [Proyecto] SET [NombreProyecto]=@NombreProyecto, [DescripcionProyecto]=@DescripcionProyecto, [FechaCreacion]=@FechaCreacion, [IdEstado]=@IdEstado  WHERE [IdProyecto] = @IdProyecto", GxErrorMask.GX_NOMASK,prmT000111)
           ,new CursorDef("T000112", "DELETE FROM [Proyecto]  WHERE [IdProyecto] = @IdProyecto", GxErrorMask.GX_NOMASK,prmT000112)
           ,new CursorDef("T000113", "SELECT [Estado] FROM [Estado] WHERE [IdEstado] = @IdEstado ",true, GxErrorMask.GX_NOMASK, false, this,prmT000113,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000114", "SELECT TOP 1 [IdTarea] FROM [Tarea] WHERE [IdProyecto] = @IdProyecto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000115", "SELECT [IdProyecto] FROM [Proyecto] ORDER BY [IdProyecto]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,100, GxCacheFrequency.OFF ,true,false )
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
              ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
              ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
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
           case 8 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 11 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 12 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (DateTime)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              return;
           case 9 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (DateTime)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (short)parms[4]);
              return;
           case 10 :
              stmt.SetParameter(1, (short)parms[0]);
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
