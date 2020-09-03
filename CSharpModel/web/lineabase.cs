/*
               File: LineaBase
        Description: Linea Base
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/23/2020 14:32:30.30
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
   public class lineabase : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action3") == 0 )
         {
            A21IdLineaBase = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_3_077( A21IdLineaBase) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A5IdTarea = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_6( A5IdTarea) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridlineabase_tareaslb") == 0 )
         {
            nRC_GXsfl_48 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_48_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_48_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridlineabase_tareaslb_newrow( ) ;
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
            Gx_mode = gxfirstwebparm;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7IdLineaBase = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7IdLineaBase", StringUtil.LTrimStr( (decimal)(AV7IdLineaBase), 4, 0));
               GxWebStd.gx_hidden_field( context, "gxhash_vIDLINEABASE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7IdLineaBase), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Linea Base", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtNombreLineaBase_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public lineabase( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public lineabase( IGxContext context )
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
                           short aP1_IdLineaBase )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7IdLineaBase = aP1_IdLineaBase;
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Linea Base", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_LineaBase.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_LineaBase.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdLineaBase_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtIdLineaBase_Internalname, "Id Linea Base", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtIdLineaBase_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A21IdLineaBase), 4, 0, ".", "")), ((edtIdLineaBase_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A21IdLineaBase), "ZZZ9")) : context.localUtil.Format( (decimal)(A21IdLineaBase), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdLineaBase_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdLineaBase_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNombreLineaBase_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtNombreLineaBase_Internalname, "Nombre Linea Base", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtNombreLineaBase_Internalname, StringUtil.RTrim( A22NombreLineaBase), StringUtil.RTrim( context.localUtil.Format( A22NombreLineaBase, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNombreLineaBase_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNombreLineaBase_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTareaslbtable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitletareaslb_Internalname, "Tareas LB", "", "", lblTitletareaslb_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Gridlineabase_tareaslb( ) ;
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
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_LineaBase.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Gridlineabase_tareaslb( )
      {
         /*  Grid Control  */
         Gridlineabase_tareaslbContainer.AddObjectProperty("GridName", "Gridlineabase_tareaslb");
         Gridlineabase_tareaslbContainer.AddObjectProperty("Header", subGridlineabase_tareaslb_Header);
         Gridlineabase_tareaslbContainer.AddObjectProperty("Class", "Grid");
         Gridlineabase_tareaslbContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlineabase_tareaslb_Backcolorstyle), 1, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("CmpContext", "");
         Gridlineabase_tareaslbContainer.AddObjectProperty("InMasterPage", "false");
         Gridlineabase_tareaslbColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlineabase_tareaslbColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5IdTarea), 4, 0, ".", "")));
         Gridlineabase_tareaslbColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtIdTarea_Enabled), 5, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddColumnProperties(Gridlineabase_tareaslbColumn);
         Gridlineabase_tareaslbColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlineabase_tareaslbContainer.AddColumnProperties(Gridlineabase_tareaslbColumn);
         Gridlineabase_tareaslbColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlineabase_tareaslbColumn.AddObjectProperty("Value", StringUtil.RTrim( A6NombreTarea));
         Gridlineabase_tareaslbColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtNombreTarea_Enabled), 5, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddColumnProperties(Gridlineabase_tareaslbColumn);
         Gridlineabase_tareaslbContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlineabase_tareaslb_Selectedindex), 4, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlineabase_tareaslb_Allowselection), 1, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlineabase_tareaslb_Selectioncolor), 9, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlineabase_tareaslb_Allowhovering), 1, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlineabase_tareaslb_Hoveringcolor), 9, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlineabase_tareaslb_Allowcollapsing), 1, 0, ".", "")));
         Gridlineabase_tareaslbContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlineabase_tareaslb_Collapsed), 1, 0, ".", "")));
         nGXsfl_48_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount8 = 1;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_8 = 1;
               ScanStart078( ) ;
               while ( RcdFound8 != 0 )
               {
                  init_level_properties8( ) ;
                  getByPrimaryKey078( ) ;
                  AddRow078( ) ;
                  ScanNext078( ) ;
               }
               ScanEnd078( ) ;
               nBlankRcdCount8 = 1;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal078( ) ;
            standaloneModal078( ) ;
            sMode8 = Gx_mode;
            while ( nGXsfl_48_idx < nRC_GXsfl_48 )
            {
               bGXsfl_48_Refreshing = true;
               ReadRow078( ) ;
               edtIdTarea_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDTAREA_"+sGXsfl_48_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtIdTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdTarea_Enabled), 5, 0), !bGXsfl_48_Refreshing);
               edtNombreTarea_Enabled = (int)(context.localUtil.CToN( cgiGet( "NOMBRETAREA_"+sGXsfl_48_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtNombreTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtNombreTarea_Enabled), 5, 0), !bGXsfl_48_Refreshing);
               imgprompt_5_Link = cgiGet( "PROMPT_5_"+sGXsfl_48_idx+"Link");
               if ( ( nRcdExists_8 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal078( ) ;
               }
               SendRow078( ) ;
               bGXsfl_48_Refreshing = false;
            }
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount8 = 1;
            nRcdExists_8 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart078( ) ;
               while ( RcdFound8 != 0 )
               {
                  sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_48_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_488( ) ;
                  init_level_properties8( ) ;
                  standaloneNotModal078( ) ;
                  getByPrimaryKey078( ) ;
                  standaloneModal078( ) ;
                  AddRow078( ) ;
                  ScanNext078( ) ;
               }
               ScanEnd078( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ! IsDsp( ) && ! IsDlt( ) )
         {
            sMode8 = Gx_mode;
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_48_idx+1), 4, 0), 4, "0");
            SubsflControlProps_488( ) ;
            InitAll078( ) ;
            init_level_properties8( ) ;
            nRcdExists_8 = 0;
            nIsMod_8 = 0;
            nRcdDeleted_8 = 0;
            nBlankRcdCount8 = (short)(nBlankRcdUsr8+nBlankRcdCount8);
            fRowAdded = 0;
            while ( nBlankRcdCount8 > 0 )
            {
               standaloneNotModal078( ) ;
               standaloneModal078( ) ;
               AddRow078( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtIdTarea_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount8 = (short)(nBlankRcdCount8-1);
            }
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridlineabase_tareaslbContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridlineabase_tareaslb", Gridlineabase_tareaslbContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridlineabase_tareaslbContainerData", Gridlineabase_tareaslbContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridlineabase_tareaslbContainerData"+"V", Gridlineabase_tareaslbContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridlineabase_tareaslbContainerData"+"V"+"\" value='"+Gridlineabase_tareaslbContainer.GridValuesHidden()+"'/>") ;
         }
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
         E11072 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z21IdLineaBase = (short)(context.localUtil.CToN( cgiGet( "Z21IdLineaBase"), ".", ","));
               Z22NombreLineaBase = cgiGet( "Z22NombreLineaBase");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_48 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_48"), ".", ","));
               AV7IdLineaBase = (short)(context.localUtil.CToN( cgiGet( "vIDLINEABASE"), ".", ","));
               AV11Pgmname = cgiGet( "vPGMNAME");
               /* Read variables values. */
               A21IdLineaBase = (short)(context.localUtil.CToN( cgiGet( edtIdLineaBase_Internalname), ".", ","));
               AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
               A22NombreLineaBase = cgiGet( edtNombreLineaBase_Internalname);
               AssignAttri("", false, "A22NombreLineaBase", A22NombreLineaBase);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"LineaBase");
               A21IdLineaBase = (short)(context.localUtil.CToN( cgiGet( edtIdLineaBase_Internalname), ".", ","));
               AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
               forbiddenHiddens.Add("IdLineaBase", context.localUtil.Format( (decimal)(A21IdLineaBase), "ZZZ9"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A21IdLineaBase != Z21IdLineaBase ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLogError("lineabase:[ SecurityCheckFailed (403 Forbidden) value for]"+forbiddenHiddens.ToJSonString());
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
               /* Check if conditions changed and reset current page numbers */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  A21IdLineaBase = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
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
                     sMode7 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode7;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound7 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_070( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "IDLINEABASE");
                        AnyError = 1;
                        GX_FocusControl = edtIdLineaBase_Internalname;
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
                           E11072 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12072 ();
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
            E12072 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll077( ) ;
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
            DisableAttributes077( ) ;
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

      protected void CONFIRM_070( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls077( ) ;
            }
            else
            {
               CheckExtendedTable077( ) ;
               CloseExtendedTableCursors077( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode7 = Gx_mode;
            CONFIRM_078( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode7;
               AssignAttri("", false, "Gx_mode", Gx_mode);
               IsConfirmed = 1;
               AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
            }
            /* Restore parent mode. */
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
      }

      protected void CONFIRM_078( )
      {
         nGXsfl_48_idx = 0;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            ReadRow078( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               GetKey078( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  if ( RcdFound8 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate078( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable078( ) ;
                        CloseExtendedTableCursors078( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "IDTAREA_" + sGXsfl_48_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtIdTarea_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( nRcdDeleted_8 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey078( ) ;
                        Load078( ) ;
                        BeforeValidate078( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls078( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_8 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate078( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable078( ) ;
                              CloseExtendedTableCursors078( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GXCCtl = "IDTAREA_" + sGXsfl_48_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtIdTarea_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtIdTarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5IdTarea), 4, 0, ".", ""))) ;
            ChangePostValue( edtNombreTarea_Internalname, StringUtil.RTrim( A6NombreTarea)) ;
            ChangePostValue( "ZT_"+"Z5IdTarea_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5IdTarea), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ".", ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "IDTAREA_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtIdTarea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "NOMBRETAREA_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtNombreTarea_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption070( )
      {
      }

      protected void E11072( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "SGCS");
      }

      protected void E12072( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwlineabase.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM077( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z22NombreLineaBase = T00076_A22NombreLineaBase[0];
            }
            else
            {
               Z22NombreLineaBase = A22NombreLineaBase;
            }
         }
         if ( GX_JID == -4 )
         {
            Z21IdLineaBase = A21IdLineaBase;
            Z22NombreLineaBase = A22NombreLineaBase;
         }
      }

      protected void standaloneNotModal( )
      {
         edtIdLineaBase_Enabled = 0;
         AssignProp("", false, edtIdLineaBase_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdLineaBase_Enabled), 5, 0), true);
         edtIdLineaBase_Enabled = 0;
         AssignProp("", false, edtIdLineaBase_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdLineaBase_Enabled), 5, 0), true);
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7IdLineaBase) )
         {
            A21IdLineaBase = AV7IdLineaBase;
            AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
         }
      }

      protected void standaloneModal( )
      {
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
      }

      protected void Load077( )
      {
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A21IdLineaBase});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound7 = 1;
            A22NombreLineaBase = T00077_A22NombreLineaBase[0];
            AssignAttri("", false, "A22NombreLineaBase", A22NombreLineaBase);
            ZM077( -4) ;
         }
         pr_default.close(5);
         OnLoadActions077( ) ;
      }

      protected void OnLoadActions077( )
      {
         AV11Pgmname = "LineaBase";
         AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable077( )
      {
         nIsDirty_7 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "LineaBase";
         AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors077( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey077( )
      {
         /* Using cursor T00078 */
         pr_default.execute(6, new Object[] {A21IdLineaBase});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A21IdLineaBase});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM077( 4) ;
            RcdFound7 = 1;
            A21IdLineaBase = T00076_A21IdLineaBase[0];
            AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
            A22NombreLineaBase = T00076_A22NombreLineaBase[0];
            AssignAttri("", false, "A22NombreLineaBase", A22NombreLineaBase);
            Z21IdLineaBase = A21IdLineaBase;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            Load077( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey077( ) ;
            }
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey077( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey077( ) ;
         if ( RcdFound7 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound7 = 0;
         /* Using cursor T00079 */
         pr_default.execute(7, new Object[] {A21IdLineaBase});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00079_A21IdLineaBase[0] < A21IdLineaBase ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00079_A21IdLineaBase[0] > A21IdLineaBase ) ) )
            {
               A21IdLineaBase = T00079_A21IdLineaBase[0];
               AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
               RcdFound7 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T000710 */
         pr_default.execute(8, new Object[] {A21IdLineaBase});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000710_A21IdLineaBase[0] > A21IdLineaBase ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000710_A21IdLineaBase[0] < A21IdLineaBase ) ) )
            {
               A21IdLineaBase = T000710_A21IdLineaBase[0];
               AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
               RcdFound7 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey077( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtNombreLineaBase_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert077( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( A21IdLineaBase != Z21IdLineaBase )
               {
                  A21IdLineaBase = Z21IdLineaBase;
                  AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDLINEABASE");
                  AnyError = 1;
                  GX_FocusControl = edtIdLineaBase_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtNombreLineaBase_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update077( ) ;
                  GX_FocusControl = edtNombreLineaBase_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A21IdLineaBase != Z21IdLineaBase )
               {
                  /* Insert record */
                  GX_FocusControl = edtNombreLineaBase_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert077( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDLINEABASE");
                     AnyError = 1;
                     GX_FocusControl = edtIdLineaBase_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtNombreLineaBase_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert077( ) ;
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
         if ( A21IdLineaBase != Z21IdLineaBase )
         {
            A21IdLineaBase = Z21IdLineaBase;
            AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDLINEABASE");
            AnyError = 1;
            GX_FocusControl = edtIdLineaBase_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtNombreLineaBase_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency077( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00075 */
            pr_default.execute(3, new Object[] {A21IdLineaBase});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"LineaBase"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z22NombreLineaBase, T00075_A22NombreLineaBase[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z22NombreLineaBase, T00075_A22NombreLineaBase[0]) != 0 )
               {
                  GXUtil.WriteLog("lineabase:[seudo value changed for attri]"+"NombreLineaBase");
                  GXUtil.WriteLogRaw("Old: ",Z22NombreLineaBase);
                  GXUtil.WriteLogRaw("Current: ",T00075_A22NombreLineaBase[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"LineaBase"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM077( 0) ;
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000711 */
                     pr_default.execute(9, new Object[] {A22NombreLineaBase});
                     A21IdLineaBase = T000711_A21IdLineaBase[0];
                     AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("LineaBase") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel077( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption070( ) ;
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
            else
            {
               Load077( ) ;
            }
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void Update077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000712 */
                     pr_default.execute(10, new Object[] {A22NombreLineaBase, A21IdLineaBase});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("LineaBase") ;
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"LineaBase"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate077( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel077( ) ;
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
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void DeferredUpdate077( )
      {
      }

      protected void delete( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls077( ) ;
            AfterConfirm077( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete077( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart078( ) ;
                  while ( RcdFound8 != 0 )
                  {
                     getByPrimaryKey078( ) ;
                     Delete078( ) ;
                     ScanNext078( ) ;
                  }
                  ScanEnd078( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000713 */
                     pr_default.execute(11, new Object[] {A21IdLineaBase});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("LineaBase") ;
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
         }
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel077( ) ;
         Gx_mode = sMode7;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls077( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "LineaBase";
            AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void ProcessNestedLevel078( )
      {
         nGXsfl_48_idx = 0;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            ReadRow078( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               standaloneNotModal078( ) ;
               GetKey078( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert078( ) ;
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( ( nRcdDeleted_8 != 0 ) && ( nRcdExists_8 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete078( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_8 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update078( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GXCCtl = "IDTAREA_" + sGXsfl_48_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtIdTarea_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtIdTarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5IdTarea), 4, 0, ".", ""))) ;
            ChangePostValue( edtNombreTarea_Internalname, StringUtil.RTrim( A6NombreTarea)) ;
            ChangePostValue( "ZT_"+"Z5IdTarea_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5IdTarea), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ".", ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "IDTAREA_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtIdTarea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "NOMBRETAREA_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtNombreTarea_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll078( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_8 = 0;
         nIsMod_8 = 0;
         nRcdDeleted_8 = 0;
      }

      protected void ProcessLevel077( )
      {
         /* Save parent mode. */
         sMode7 = Gx_mode;
         ProcessNestedLevel078( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode7;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel077( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete077( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("lineabase",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
            }
            /* After transaction rules */
            new procedurestatus(context ).execute(  A21IdLineaBase) ;
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.RollbackDataStores("lineabase",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart077( )
      {
         /* Scan By routine */
         /* Using cursor T000714 */
         pr_default.execute(12);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound7 = 1;
            A21IdLineaBase = T000714_A21IdLineaBase[0];
            AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext077( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound7 = 1;
            A21IdLineaBase = T000714_A21IdLineaBase[0];
            AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
         }
      }

      protected void ScanEnd077( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm077( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert077( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate077( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete077( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete077( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate077( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes077( )
      {
         edtIdLineaBase_Enabled = 0;
         AssignProp("", false, edtIdLineaBase_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdLineaBase_Enabled), 5, 0), true);
         edtNombreLineaBase_Enabled = 0;
         AssignProp("", false, edtNombreLineaBase_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtNombreLineaBase_Enabled), 5, 0), true);
      }

      protected void ZM078( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -5 )
         {
            Z21IdLineaBase = A21IdLineaBase;
            Z5IdTarea = A5IdTarea;
            Z6NombreTarea = A6NombreTarea;
         }
      }

      protected void standaloneNotModal078( )
      {
      }

      protected void standaloneModal078( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtIdTarea_Enabled = 0;
            AssignProp("", false, edtIdTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdTarea_Enabled), 5, 0), !bGXsfl_48_Refreshing);
         }
         else
         {
            edtIdTarea_Enabled = 1;
            AssignProp("", false, edtIdTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdTarea_Enabled), 5, 0), !bGXsfl_48_Refreshing);
         }
      }

      protected void Load078( )
      {
         /* Using cursor T000715 */
         pr_default.execute(13, new Object[] {A21IdLineaBase, A5IdTarea});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound8 = 1;
            A6NombreTarea = T000715_A6NombreTarea[0];
            ZM078( -5) ;
         }
         pr_default.close(13);
         OnLoadActions078( ) ;
      }

      protected void OnLoadActions078( )
      {
      }

      protected void CheckExtendedTable078( )
      {
         nIsDirty_8 = 0;
         Gx_BScreen = 1;
         standaloneModal078( ) ;
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A5IdTarea});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "IDTAREA_" + sGXsfl_48_idx;
            GX_msglist.addItem("No matching 'Tarea'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtIdTarea_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A6NombreTarea = T00074_A6NombreTarea[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors078( )
      {
         pr_default.close(2);
      }

      protected void enableDisable078( )
      {
      }

      protected void gxLoad_6( short A5IdTarea )
      {
         /* Using cursor T000716 */
         pr_default.execute(14, new Object[] {A5IdTarea});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GXCCtl = "IDTAREA_" + sGXsfl_48_idx;
            GX_msglist.addItem("No matching 'Tarea'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtIdTarea_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A6NombreTarea = T000716_A6NombreTarea[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A6NombreTarea))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(14) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(14);
      }

      protected void GetKey078( )
      {
         /* Using cursor T000717 */
         pr_default.execute(15, new Object[] {A21IdLineaBase, A5IdTarea});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(15);
      }

      protected void getByPrimaryKey078( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A21IdLineaBase, A5IdTarea});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM078( 5) ;
            RcdFound8 = 1;
            InitializeNonKey078( ) ;
            A5IdTarea = T00073_A5IdTarea[0];
            Z21IdLineaBase = A21IdLineaBase;
            Z5IdTarea = A5IdTarea;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            Load078( ) ;
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey078( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal078( ) ;
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes078( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency078( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00072 */
            pr_default.execute(0, new Object[] {A21IdLineaBase, A5IdTarea});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TareasLB"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TareasLB"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert078( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable078( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM078( 0) ;
            CheckOptimisticConcurrency078( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm078( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert078( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000718 */
                     pr_default.execute(16, new Object[] {A21IdLineaBase, A5IdTarea});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("TareasLB") ;
                     if ( (pr_default.getStatus(16) == 1) )
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
               Load078( ) ;
            }
            EndLevel078( ) ;
         }
         CloseExtendedTableCursors078( ) ;
      }

      protected void Update078( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable078( ) ;
         }
         if ( ( nIsMod_8 != 0 ) || ( nIsDirty_8 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency078( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm078( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate078( ) ;
                     if ( AnyError == 0 )
                     {
                        /* No attributes to update on table [TareasLB] */
                        DeferredUpdate078( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey078( ) ;
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
               EndLevel078( ) ;
            }
         }
         CloseExtendedTableCursors078( ) ;
      }

      protected void DeferredUpdate078( )
      {
      }

      protected void Delete078( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency078( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls078( ) ;
            AfterConfirm078( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete078( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000719 */
                  pr_default.execute(17, new Object[] {A21IdLineaBase, A5IdTarea});
                  pr_default.close(17);
                  dsDefault.SmartCacheProvider.SetUpdated("TareasLB") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel078( ) ;
         Gx_mode = sMode8;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls078( )
      {
         standaloneModal078( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000720 */
            pr_default.execute(18, new Object[] {A5IdTarea});
            A6NombreTarea = T000720_A6NombreTarea[0];
            pr_default.close(18);
         }
      }

      protected void EndLevel078( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart078( )
      {
         /* Scan By routine */
         /* Using cursor T000721 */
         pr_default.execute(19, new Object[] {A21IdLineaBase});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound8 = 1;
            A5IdTarea = T000721_A5IdTarea[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext078( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound8 = 1;
            A5IdTarea = T000721_A5IdTarea[0];
         }
      }

      protected void ScanEnd078( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm078( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert078( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate078( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete078( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete078( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate078( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes078( )
      {
         edtIdTarea_Enabled = 0;
         AssignProp("", false, edtIdTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdTarea_Enabled), 5, 0), !bGXsfl_48_Refreshing);
         edtNombreTarea_Enabled = 0;
         AssignProp("", false, edtNombreTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtNombreTarea_Enabled), 5, 0), !bGXsfl_48_Refreshing);
      }

      protected void send_integrity_lvl_hashes078( )
      {
      }

      protected void send_integrity_lvl_hashes077( )
      {
      }

      protected void SubsflControlProps_488( )
      {
         edtIdTarea_Internalname = "IDTAREA_"+sGXsfl_48_idx;
         imgprompt_5_Internalname = "PROMPT_5_"+sGXsfl_48_idx;
         edtNombreTarea_Internalname = "NOMBRETAREA_"+sGXsfl_48_idx;
      }

      protected void SubsflControlProps_fel_488( )
      {
         edtIdTarea_Internalname = "IDTAREA_"+sGXsfl_48_fel_idx;
         imgprompt_5_Internalname = "PROMPT_5_"+sGXsfl_48_fel_idx;
         edtNombreTarea_Internalname = "NOMBRETAREA_"+sGXsfl_48_fel_idx;
      }

      protected void AddRow078( )
      {
         nGXsfl_48_idx = (int)(nGXsfl_48_idx+1);
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_48_idx), 4, 0), 4, "0");
         SubsflControlProps_488( ) ;
         SendRow078( ) ;
      }

      protected void SendRow078( )
      {
         Gridlineabase_tareaslbRow = GXWebRow.GetNew(context);
         if ( subGridlineabase_tareaslb_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridlineabase_tareaslb_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridlineabase_tareaslb_Class, "") != 0 )
            {
               subGridlineabase_tareaslb_Linesclass = subGridlineabase_tareaslb_Class+"Odd";
            }
         }
         else if ( subGridlineabase_tareaslb_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridlineabase_tareaslb_Backstyle = 0;
            subGridlineabase_tareaslb_Backcolor = subGridlineabase_tareaslb_Allbackcolor;
            if ( StringUtil.StrCmp(subGridlineabase_tareaslb_Class, "") != 0 )
            {
               subGridlineabase_tareaslb_Linesclass = subGridlineabase_tareaslb_Class+"Uniform";
            }
         }
         else if ( subGridlineabase_tareaslb_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridlineabase_tareaslb_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridlineabase_tareaslb_Class, "") != 0 )
            {
               subGridlineabase_tareaslb_Linesclass = subGridlineabase_tareaslb_Class+"Odd";
            }
            subGridlineabase_tareaslb_Backcolor = (int)(0x0);
         }
         else if ( subGridlineabase_tareaslb_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridlineabase_tareaslb_Backstyle = 1;
            if ( ((int)((nGXsfl_48_idx) % (2))) == 0 )
            {
               subGridlineabase_tareaslb_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridlineabase_tareaslb_Class, "") != 0 )
               {
                  subGridlineabase_tareaslb_Linesclass = subGridlineabase_tareaslb_Class+"Even";
               }
            }
            else
            {
               subGridlineabase_tareaslb_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridlineabase_tareaslb_Class, "") != 0 )
               {
                  subGridlineabase_tareaslb_Linesclass = subGridlineabase_tareaslb_Class+"Odd";
               }
            }
         }
         imgprompt_5_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDTAREA_"+sGXsfl_48_idx+"'), id:'"+"IDTAREA_"+sGXsfl_48_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_8_"+sGXsfl_48_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_8_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridlineabase_tareaslbRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtIdTarea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5IdTarea), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A5IdTarea), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,49);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtIdTarea_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtIdTarea_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridlineabase_tareaslbRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_5_Internalname,(String)sImgUrl,(String)imgprompt_5_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_5_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridlineabase_tareaslbRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNombreTarea_Internalname,StringUtil.RTrim( A6NombreTarea),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtNombreTarea_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtNombreTarea_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridlineabase_tareaslbRow);
         send_integrity_lvl_hashes078( ) ;
         GXCCtl = "Z5IdTarea_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5IdTarea), 4, 0, ".", "")));
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_8_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ".", "")));
         GXCCtl = "nIsMod_8_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_48_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vIDLINEABASE_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7IdLineaBase), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IDTAREA_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtIdTarea_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "NOMBRETAREA_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtNombreTarea_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_5_"+sGXsfl_48_idx+"Link", StringUtil.RTrim( imgprompt_5_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridlineabase_tareaslbContainer.AddRow(Gridlineabase_tareaslbRow);
      }

      protected void ReadRow078( )
      {
         nGXsfl_48_idx = (int)(nGXsfl_48_idx+1);
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_48_idx), 4, 0), 4, "0");
         SubsflControlProps_488( ) ;
         edtIdTarea_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDTAREA_"+sGXsfl_48_idx+"Enabled"), ".", ","));
         edtNombreTarea_Enabled = (int)(context.localUtil.CToN( cgiGet( "NOMBRETAREA_"+sGXsfl_48_idx+"Enabled"), ".", ","));
         imgprompt_5_Link = cgiGet( "PROMPT_5_"+sGXsfl_48_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtIdTarea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtIdTarea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "IDTAREA_" + sGXsfl_48_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtIdTarea_Internalname;
            wbErr = true;
            A5IdTarea = 0;
         }
         else
         {
            A5IdTarea = (short)(context.localUtil.CToN( cgiGet( edtIdTarea_Internalname), ".", ","));
         }
         A6NombreTarea = cgiGet( edtNombreTarea_Internalname);
         GXCCtl = "Z5IdTarea_" + sGXsfl_48_idx;
         Z5IdTarea = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_48_idx;
         nRcdDeleted_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_8_" + sGXsfl_48_idx;
         nRcdExists_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_8_" + sGXsfl_48_idx;
         nIsMod_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtIdTarea_Enabled = edtIdTarea_Enabled;
      }

      protected void ConfirmValues070( )
      {
         nGXsfl_48_idx = 0;
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_48_idx), 4, 0), 4, "0");
         SubsflControlProps_488( ) ;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            nGXsfl_48_idx = (int)(nGXsfl_48_idx+1);
            sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_48_idx), 4, 0), 4, "0");
            SubsflControlProps_488( ) ;
            ChangePostValue( "Z5IdTarea_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z5IdTarea_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z5IdTarea_"+sGXsfl_48_idx) ;
         }
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
         context.AddJavascriptSource("gxcfg.js", "?202082314323086", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("lineabase.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7IdLineaBase)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"LineaBase");
         forbiddenHiddens.Add("IdLineaBase", context.localUtil.Format( (decimal)(A21IdLineaBase), "ZZZ9"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLogInfo("lineabase:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z21IdLineaBase", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z21IdLineaBase), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z22NombreLineaBase", StringUtil.RTrim( Z22NombreLineaBase));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_48", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_48_idx), 8, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "vIDLINEABASE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7IdLineaBase), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIDLINEABASE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7IdLineaBase), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
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
         return formatLink("lineabase.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7IdLineaBase) ;
      }

      public override String GetPgmname( )
      {
         return "LineaBase" ;
      }

      public override String GetPgmdesc( )
      {
         return "Linea Base" ;
      }

      protected void InitializeNonKey077( )
      {
         A22NombreLineaBase = "";
         AssignAttri("", false, "A22NombreLineaBase", A22NombreLineaBase);
         Z22NombreLineaBase = "";
      }

      protected void InitAll077( )
      {
         A21IdLineaBase = 0;
         AssignAttri("", false, "A21IdLineaBase", StringUtil.LTrimStr( (decimal)(A21IdLineaBase), 4, 0));
         InitializeNonKey077( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey078( )
      {
         A6NombreTarea = "";
      }

      protected void InitAll078( )
      {
         A5IdTarea = 0;
         InitializeNonKey078( ) ;
      }

      protected void StandaloneModalInsert078( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202082314323089", true, true);
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
         context.AddJavascriptSource("lineabase.js", "?202082314323089", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties8( )
      {
         edtIdTarea_Enabled = defedtIdTarea_Enabled;
         AssignProp("", false, edtIdTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdTarea_Enabled), 5, 0), !bGXsfl_48_Refreshing);
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
         edtIdLineaBase_Internalname = "IDLINEABASE";
         edtNombreLineaBase_Internalname = "NOMBRELINEABASE";
         lblTitletareaslb_Internalname = "TITLETAREASLB";
         edtIdTarea_Internalname = "IDTAREA";
         edtNombreTarea_Internalname = "NOMBRETAREA";
         divTareaslbtable_Internalname = "TAREASLBTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_5_Internalname = "PROMPT_5";
         subGridlineabase_tareaslb_Internalname = "GRIDLINEABASE_TAREASLB";
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
         Form.Caption = "Linea Base";
         edtNombreTarea_Jsonclick = "";
         imgprompt_5_Visible = 1;
         imgprompt_5_Link = "";
         imgprompt_5_Visible = 1;
         edtIdTarea_Jsonclick = "";
         subGridlineabase_tareaslb_Class = "Grid";
         subGridlineabase_tareaslb_Backcolorstyle = 0;
         subGridlineabase_tareaslb_Allowcollapsing = 0;
         subGridlineabase_tareaslb_Allowselection = 0;
         edtNombreTarea_Enabled = 0;
         edtIdTarea_Enabled = 1;
         subGridlineabase_tareaslb_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtNombreLineaBase_Jsonclick = "";
         edtNombreLineaBase_Enabled = 1;
         edtIdLineaBase_Jsonclick = "";
         edtIdLineaBase_Enabled = 0;
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

      protected void XC_3_077( short A21IdLineaBase )
      {
         new procedurestatus(context ).execute(  A21IdLineaBase) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "]") ;
         if ( true )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
      }

      protected void gxnrGridlineabase_tareaslb_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_488( ) ;
         while ( nGXsfl_48_idx <= nRC_GXsfl_48 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal078( ) ;
            standaloneModal078( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow078( ) ;
            nGXsfl_48_idx = (int)(nGXsfl_48_idx+1);
            sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_48_idx), 4, 0), 4, "0");
            SubsflControlProps_488( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridlineabase_tareaslbContainer)) ;
         /* End function gxnrGridlineabase_tareaslb_newrow */
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

      public void Valid_Idtarea( )
      {
         /* Using cursor T000720 */
         pr_default.execute(18, new Object[] {A5IdTarea});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No matching 'Tarea'.", "ForeignKeyNotFound", 1, "IDTAREA");
            AnyError = 1;
            GX_FocusControl = edtIdTarea_Internalname;
         }
         A6NombreTarea = T000720_A6NombreTarea[0];
         pr_default.close(18);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A6NombreTarea", StringUtil.RTrim( A6NombreTarea));
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7IdLineaBase',fld:'vIDLINEABASE',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7IdLineaBase',fld:'vIDLINEABASE',pic:'ZZZ9',hsh:true},{av:'A21IdLineaBase',fld:'IDLINEABASE',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12072',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_IDLINEABASE","{handler:'Valid_Idlineabase',iparms:[]");
         setEventMetadata("VALID_IDLINEABASE",",oparms:[]}");
         setEventMetadata("VALID_IDTAREA","{handler:'Valid_Idtarea',iparms:[{av:'A5IdTarea',fld:'IDTAREA',pic:'ZZZ9'},{av:'A6NombreTarea',fld:'NOMBRETAREA',pic:''}]");
         setEventMetadata("VALID_IDTAREA",",oparms:[{av:'A6NombreTarea',fld:'NOMBRETAREA',pic:''}]}");
         setEventMetadata("NULL","{handler:'Valid_Nombretarea',iparms:[]");
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
         pr_default.close(1);
         pr_default.close(18);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z22NombreLineaBase = "";
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
         A22NombreLineaBase = "";
         lblTitletareaslb_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridlineabase_tareaslbContainer = new GXWebGrid( context);
         Gridlineabase_tareaslbColumn = new GXWebColumn();
         A6NombreTarea = "";
         sMode8 = "";
         sStyleString = "";
         AV11Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode7 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00077_A21IdLineaBase = new short[1] ;
         T00077_A22NombreLineaBase = new String[] {""} ;
         T00078_A21IdLineaBase = new short[1] ;
         T00076_A21IdLineaBase = new short[1] ;
         T00076_A22NombreLineaBase = new String[] {""} ;
         T00079_A21IdLineaBase = new short[1] ;
         T000710_A21IdLineaBase = new short[1] ;
         T00075_A21IdLineaBase = new short[1] ;
         T00075_A22NombreLineaBase = new String[] {""} ;
         T000711_A21IdLineaBase = new short[1] ;
         T000714_A21IdLineaBase = new short[1] ;
         Z6NombreTarea = "";
         T000715_A21IdLineaBase = new short[1] ;
         T000715_A6NombreTarea = new String[] {""} ;
         T000715_A5IdTarea = new short[1] ;
         T00074_A6NombreTarea = new String[] {""} ;
         T000716_A6NombreTarea = new String[] {""} ;
         T000717_A21IdLineaBase = new short[1] ;
         T000717_A5IdTarea = new short[1] ;
         T00073_A21IdLineaBase = new short[1] ;
         T00073_A5IdTarea = new short[1] ;
         T00072_A21IdLineaBase = new short[1] ;
         T00072_A5IdTarea = new short[1] ;
         T000720_A6NombreTarea = new String[] {""} ;
         T000721_A21IdLineaBase = new short[1] ;
         T000721_A5IdTarea = new short[1] ;
         Gridlineabase_tareaslbRow = new GXWebRow();
         subGridlineabase_tareaslb_Linesclass = "";
         ROClassString = "";
         sImgUrl = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.lineabase__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.lineabase__default(),
            new Object[][] {
                new Object[] {
               T00072_A21IdLineaBase, T00072_A5IdTarea
               }
               , new Object[] {
               T00073_A21IdLineaBase, T00073_A5IdTarea
               }
               , new Object[] {
               T00074_A6NombreTarea
               }
               , new Object[] {
               T00075_A21IdLineaBase, T00075_A22NombreLineaBase
               }
               , new Object[] {
               T00076_A21IdLineaBase, T00076_A22NombreLineaBase
               }
               , new Object[] {
               T00077_A21IdLineaBase, T00077_A22NombreLineaBase
               }
               , new Object[] {
               T00078_A21IdLineaBase
               }
               , new Object[] {
               T00079_A21IdLineaBase
               }
               , new Object[] {
               T000710_A21IdLineaBase
               }
               , new Object[] {
               T000711_A21IdLineaBase
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000714_A21IdLineaBase
               }
               , new Object[] {
               T000715_A21IdLineaBase, T000715_A6NombreTarea, T000715_A5IdTarea
               }
               , new Object[] {
               T000716_A6NombreTarea
               }
               , new Object[] {
               T000717_A21IdLineaBase, T000717_A5IdTarea
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000720_A6NombreTarea
               }
               , new Object[] {
               T000721_A21IdLineaBase, T000721_A5IdTarea
               }
            }
         );
         AV11Pgmname = "LineaBase";
      }

      private short nIsMod_8 ;
      private short wcpOAV7IdLineaBase ;
      private short Z21IdLineaBase ;
      private short Z5IdTarea ;
      private short nRcdDeleted_8 ;
      private short nRcdExists_8 ;
      private short GxWebError ;
      private short A21IdLineaBase ;
      private short A5IdTarea ;
      private short AV7IdLineaBase ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridlineabase_tareaslb_Backcolorstyle ;
      private short subGridlineabase_tareaslb_Allowselection ;
      private short subGridlineabase_tareaslb_Allowhovering ;
      private short subGridlineabase_tareaslb_Allowcollapsing ;
      private short subGridlineabase_tareaslb_Collapsed ;
      private short nBlankRcdCount8 ;
      private short RcdFound8 ;
      private short nBlankRcdUsr8 ;
      private short RcdFound7 ;
      private short GX_JID ;
      private short nIsDirty_7 ;
      private short Gx_BScreen ;
      private short nIsDirty_8 ;
      private short subGridlineabase_tareaslb_Backstyle ;
      private short gxajaxcallmode ;
      private int nRC_GXsfl_48 ;
      private int nGXsfl_48_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtIdLineaBase_Enabled ;
      private int edtNombreLineaBase_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtIdTarea_Enabled ;
      private int edtNombreTarea_Enabled ;
      private int subGridlineabase_tareaslb_Selectedindex ;
      private int subGridlineabase_tareaslb_Selectioncolor ;
      private int subGridlineabase_tareaslb_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridlineabase_tareaslb_Backcolor ;
      private int subGridlineabase_tareaslb_Allbackcolor ;
      private int imgprompt_5_Visible ;
      private int defedtIdTarea_Enabled ;
      private int idxLst ;
      private long GRIDLINEABASE_TAREASLB_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_48_idx="0001" ;
      private String wcpOGx_mode ;
      private String Z22NombreLineaBase ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtNombreLineaBase_Internalname ;
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
      private String edtIdLineaBase_Internalname ;
      private String edtIdLineaBase_Jsonclick ;
      private String A22NombreLineaBase ;
      private String edtNombreLineaBase_Jsonclick ;
      private String divTareaslbtable_Internalname ;
      private String lblTitletareaslb_Internalname ;
      private String lblTitletareaslb_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridlineabase_tareaslb_Header ;
      private String A6NombreTarea ;
      private String sMode8 ;
      private String edtIdTarea_Internalname ;
      private String edtNombreTarea_Internalname ;
      private String imgprompt_5_Link ;
      private String sStyleString ;
      private String AV11Pgmname ;
      private String hsh ;
      private String sMode7 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z6NombreTarea ;
      private String imgprompt_5_Internalname ;
      private String sGXsfl_48_fel_idx="0001" ;
      private String subGridlineabase_tareaslb_Class ;
      private String subGridlineabase_tareaslb_Linesclass ;
      private String ROClassString ;
      private String edtIdTarea_Jsonclick ;
      private String sImgUrl ;
      private String edtNombreTarea_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridlineabase_tareaslb_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_48_Refreshing=false ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private GXWebGrid Gridlineabase_tareaslbContainer ;
      private GXWebRow Gridlineabase_tareaslbRow ;
      private GXWebColumn Gridlineabase_tareaslbColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00077_A21IdLineaBase ;
      private String[] T00077_A22NombreLineaBase ;
      private short[] T00078_A21IdLineaBase ;
      private short[] T00076_A21IdLineaBase ;
      private String[] T00076_A22NombreLineaBase ;
      private short[] T00079_A21IdLineaBase ;
      private short[] T000710_A21IdLineaBase ;
      private short[] T00075_A21IdLineaBase ;
      private String[] T00075_A22NombreLineaBase ;
      private short[] T000711_A21IdLineaBase ;
      private short[] T000714_A21IdLineaBase ;
      private short[] T000715_A21IdLineaBase ;
      private String[] T000715_A6NombreTarea ;
      private short[] T000715_A5IdTarea ;
      private String[] T00074_A6NombreTarea ;
      private String[] T000716_A6NombreTarea ;
      private short[] T000717_A21IdLineaBase ;
      private short[] T000717_A5IdTarea ;
      private short[] T00073_A21IdLineaBase ;
      private short[] T00073_A5IdTarea ;
      private short[] T00072_A21IdLineaBase ;
      private short[] T00072_A5IdTarea ;
      private String[] T000720_A6NombreTarea ;
      private short[] T000721_A21IdLineaBase ;
      private short[] T000721_A5IdTarea ;
      private IDataStoreProvider pr_gam ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class lineabase__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class lineabase__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[9])
       ,new UpdateCursor(def[10])
       ,new UpdateCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
       ,new UpdateCursor(def[16])
       ,new UpdateCursor(def[17])
       ,new ForEachCursor(def[18])
       ,new ForEachCursor(def[19])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00077 ;
        prmT00077 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00078 ;
        prmT00078 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00076 ;
        prmT00076 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00079 ;
        prmT00079 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000710 ;
        prmT000710 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00075 ;
        prmT00075 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000711 ;
        prmT000711 = new Object[] {
        new Object[] {"@NombreLineaBase",SqlDbType.NChar,20,0}
        } ;
        Object[] prmT000712 ;
        prmT000712 = new Object[] {
        new Object[] {"@NombreLineaBase",SqlDbType.NChar,20,0} ,
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000713 ;
        prmT000713 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000714 ;
        prmT000714 = new Object[] {
        } ;
        Object[] prmT000715 ;
        prmT000715 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00074 ;
        prmT00074 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000716 ;
        prmT000716 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000717 ;
        prmT000717 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00073 ;
        prmT00073 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00072 ;
        prmT00072 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000718 ;
        prmT000718 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000719 ;
        prmT000719 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000721 ;
        prmT000721 = new Object[] {
        new Object[] {"@IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000720 ;
        prmT000720 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00072", "SELECT [IdLineaBase], [IdTarea] FROM [TareasLB] WITH (UPDLOCK) WHERE [IdLineaBase] = @IdLineaBase AND [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00073", "SELECT [IdLineaBase], [IdTarea] FROM [TareasLB] WHERE [IdLineaBase] = @IdLineaBase AND [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00074", "SELECT [NombreTarea] FROM [Tarea] WHERE [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00075", "SELECT [IdLineaBase], [NombreLineaBase] FROM [LineaBase] WITH (UPDLOCK) WHERE [IdLineaBase] = @IdLineaBase ",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00076", "SELECT [IdLineaBase], [NombreLineaBase] FROM [LineaBase] WHERE [IdLineaBase] = @IdLineaBase ",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00077", "SELECT TM1.[IdLineaBase], TM1.[NombreLineaBase] FROM [LineaBase] TM1 WHERE TM1.[IdLineaBase] = @IdLineaBase ORDER BY TM1.[IdLineaBase]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00078", "SELECT [IdLineaBase] FROM [LineaBase] WHERE [IdLineaBase] = @IdLineaBase  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00078,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00079", "SELECT TOP 1 [IdLineaBase] FROM [LineaBase] WHERE ( [IdLineaBase] > @IdLineaBase) ORDER BY [IdLineaBase]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00079,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000710", "SELECT TOP 1 [IdLineaBase] FROM [LineaBase] WHERE ( [IdLineaBase] < @IdLineaBase) ORDER BY [IdLineaBase] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000710,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000711", "INSERT INTO [LineaBase]([NombreLineaBase]) VALUES(@NombreLineaBase); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000711)
           ,new CursorDef("T000712", "UPDATE [LineaBase] SET [NombreLineaBase]=@NombreLineaBase  WHERE [IdLineaBase] = @IdLineaBase", GxErrorMask.GX_NOMASK,prmT000712)
           ,new CursorDef("T000713", "DELETE FROM [LineaBase]  WHERE [IdLineaBase] = @IdLineaBase", GxErrorMask.GX_NOMASK,prmT000713)
           ,new CursorDef("T000714", "SELECT [IdLineaBase] FROM [LineaBase] ORDER BY [IdLineaBase]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000714,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000715", "SELECT T1.[IdLineaBase], T2.[NombreTarea], T1.[IdTarea] FROM ([TareasLB] T1 INNER JOIN [Tarea] T2 ON T2.[IdTarea] = T1.[IdTarea]) WHERE T1.[IdLineaBase] = @IdLineaBase and T1.[IdTarea] = @IdTarea ORDER BY T1.[IdLineaBase], T1.[IdTarea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000715,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000716", "SELECT [NombreTarea] FROM [Tarea] WHERE [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000716,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000717", "SELECT [IdLineaBase], [IdTarea] FROM [TareasLB] WHERE [IdLineaBase] = @IdLineaBase AND [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000717,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000718", "INSERT INTO [TareasLB]([IdLineaBase], [IdTarea]) VALUES(@IdLineaBase, @IdTarea)", GxErrorMask.GX_NOMASK,prmT000718)
           ,new CursorDef("T000719", "DELETE FROM [TareasLB]  WHERE [IdLineaBase] = @IdLineaBase AND [IdTarea] = @IdTarea", GxErrorMask.GX_NOMASK,prmT000719)
           ,new CursorDef("T000720", "SELECT [NombreTarea] FROM [Tarea] WHERE [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000720,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000721", "SELECT [IdLineaBase], [IdTarea] FROM [TareasLB] WHERE [IdLineaBase] = @IdLineaBase ORDER BY [IdLineaBase], [IdTarea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000721,100, GxCacheFrequency.OFF ,true,false )
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
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
              return;
           case 4 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
              return;
           case 5 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
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
           case 9 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 12 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 13 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 15 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 18 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 19 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
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
              return;
           case 9 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 11 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 14 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 15 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 16 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 17 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 18 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 19 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
     }
  }

}

}
