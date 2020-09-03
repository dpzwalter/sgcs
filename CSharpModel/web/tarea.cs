/*
               File: Tarea
        Description: Tarea
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/23/2020 14:32:29.45
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
   public class tarea : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_33") == 0 )
         {
            A1IdProyecto = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_33( A1IdProyecto) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_37") == 0 )
         {
            A19IdPadre = (short)(NumberUtil.Val( GetNextPar( ), "."));
            n19IdPadre = false;
            AssignAttri("", false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_37( A19IdPadre) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_36") == 0 )
         {
            A17IdEstadoTarea = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_36( A17IdEstadoTarea) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
         {
            A13IdFase = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_35( A13IdFase) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
         {
            A9IdPrioridad = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_34( A9IdPrioridad) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridtarea_versiontarea") == 0 )
         {
            nRC_GXsfl_103 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_103_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_103_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridtarea_versiontarea_newrow( ) ;
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
               AV7IdTarea = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7IdTarea", StringUtil.LTrimStr( (decimal)(AV7IdTarea), 4, 0));
               GxWebStd.gx_hidden_field( context, "gxhash_vIDTAREA", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7IdTarea), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Tarea", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtIdProyecto_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public tarea( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public tarea( IGxContext context )
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
                           short aP1_IdTarea )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7IdTarea = aP1_IdTarea;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkStatusTarea = new GXCheckbox();
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
         A23StatusTarea = StringUtil.StrToBool( StringUtil.BoolToStr( A23StatusTarea));
         AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Tarea", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Tarea.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Tarea.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtIdTarea_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtIdTarea_Internalname, "Id de Tarea", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtIdTarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5IdTarea), 4, 0, ".", "")), ((edtIdTarea_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A5IdTarea), "ZZZ9")) : context.localUtil.Format( (decimal)(A5IdTarea), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdTarea_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdTarea_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtIdProyecto_Internalname, "Id de Proyecto", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtIdProyecto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1IdProyecto), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1IdProyecto), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdProyecto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdProyecto_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Tarea.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Tarea.htm");
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
         GxWebStd.gx_single_line_edit( context, edtNombreProyecto_Internalname, StringUtil.RTrim( A2NombreProyecto), StringUtil.RTrim( context.localUtil.Format( A2NombreProyecto, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNombreProyecto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNombreProyecto_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtNombreTarea_Internalname, "Nombre de Tarea", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtNombreTarea_Internalname, StringUtil.RTrim( A6NombreTarea), StringUtil.RTrim( context.localUtil.Format( A6NombreTarea, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNombreTarea_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNombreTarea_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtIdPadre_Internalname, "Id Tarea Padre", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtIdPadre_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19IdPadre), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19IdPadre), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdPadre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdPadre_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Tarea.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_19_Internalname, sImgUrl, imgprompt_19_Link, "", "", context.GetTheme( ), imgprompt_19_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtNombrePadre_Internalname, "Nombre Tarea Padre", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtNombrePadre_Internalname, StringUtil.RTrim( A20NombrePadre), StringUtil.RTrim( context.localUtil.Format( A20NombrePadre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNombrePadre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNombrePadre_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtDescripcionTarea_Internalname, "Descripcion de Tarea", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtDescripcionTarea_Internalname, StringUtil.RTrim( A7DescripcionTarea), StringUtil.RTrim( context.localUtil.Format( A7DescripcionTarea, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDescripcionTarea_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDescripcionTarea_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtIdEstadoTarea_Internalname, "Id Estado Tarea", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtIdEstadoTarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17IdEstadoTarea), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A17IdEstadoTarea), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdEstadoTarea_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdEstadoTarea_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Tarea.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_17_Internalname, sImgUrl, imgprompt_17_Link, "", "", context.GetTheme( ), imgprompt_17_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtEstadoTarea_Internalname, "Estado Tarea", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEstadoTarea_Internalname, StringUtil.RTrim( A18EstadoTarea), StringUtil.RTrim( context.localUtil.Format( A18EstadoTarea, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstadoTarea_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstadoTarea_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtIdFase_Internalname, "Id Fase", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtIdFase_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13IdFase), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A13IdFase), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdFase_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdFase_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Tarea.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_13_Internalname, sImgUrl, imgprompt_13_Link, "", "", context.GetTheme( ), imgprompt_13_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtFase_Internalname, "Fase", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtFase_Internalname, StringUtil.RTrim( A14Fase), StringUtil.RTrim( context.localUtil.Format( A14Fase, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFase_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFase_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtIdPrioridad_Internalname, "Id de Prioridad", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtIdPrioridad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A9IdPrioridad), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A9IdPrioridad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,89);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtIdPrioridad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtIdPrioridad_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Tarea.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_9_Internalname, sImgUrl, imgprompt_9_Link, "", "", context.GetTheme( ), imgprompt_9_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtPrioridad_Internalname, "Prioridad", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtPrioridad_Internalname, StringUtil.RTrim( A10Prioridad), StringUtil.RTrim( context.localUtil.Format( A10Prioridad, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrioridad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrioridad_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divVersiontareatable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitleversiontarea_Internalname, "Version Tarea", "", "", lblTitleversiontarea_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Gridtarea_versiontarea( ) ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkStatusTarea_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, chkStatusTarea_Internalname, "Satus Tarea", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Check box */
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_checkbox_ctrl( context, chkStatusTarea_Internalname, StringUtil.BoolToStr( A23StatusTarea), "", "Satus Tarea", 1, chkStatusTarea.Enabled, "true", "", StyleString, ClassString, "", "", "");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Gridtarea_versiontarea( )
      {
         /*  Grid Control  */
         Gridtarea_versiontareaContainer.AddObjectProperty("GridName", "Gridtarea_versiontarea");
         Gridtarea_versiontareaContainer.AddObjectProperty("Header", subGridtarea_versiontarea_Header);
         Gridtarea_versiontareaContainer.AddObjectProperty("Class", "Grid");
         Gridtarea_versiontareaContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtarea_versiontarea_Backcolorstyle), 1, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("CmpContext", "");
         Gridtarea_versiontareaContainer.AddObjectProperty("InMasterPage", "false");
         Gridtarea_versiontareaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridtarea_versiontareaColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VersionTarea), 4, 0, ".", "")));
         Gridtarea_versiontareaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtVersionTarea_Enabled), 5, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddColumnProperties(Gridtarea_versiontareaColumn);
         Gridtarea_versiontareaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridtarea_versiontareaColumn.AddObjectProperty("Value", context.localUtil.Format(A24FechaVersion, "99/99/99"));
         Gridtarea_versiontareaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFechaVersion_Enabled), 5, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddColumnProperties(Gridtarea_versiontareaColumn);
         Gridtarea_versiontareaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridtarea_versiontareaColumn.AddObjectProperty("Value", StringUtil.RTrim( A25ObservacionesVersion));
         Gridtarea_versiontareaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObservacionesVersion_Enabled), 5, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddColumnProperties(Gridtarea_versiontareaColumn);
         Gridtarea_versiontareaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridtarea_versiontareaColumn.AddObjectProperty("Value", StringUtil.RTrim( A26Editor));
         Gridtarea_versiontareaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEditor_Enabled), 5, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddColumnProperties(Gridtarea_versiontareaColumn);
         Gridtarea_versiontareaContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtarea_versiontarea_Selectedindex), 4, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtarea_versiontarea_Allowselection), 1, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtarea_versiontarea_Selectioncolor), 9, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtarea_versiontarea_Allowhovering), 1, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtarea_versiontarea_Hoveringcolor), 9, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtarea_versiontarea_Allowcollapsing), 1, 0, ".", "")));
         Gridtarea_versiontareaContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtarea_versiontarea_Collapsed), 1, 0, ".", "")));
         nGXsfl_103_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount9 = 1;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_9 = 1;
               ScanStart029( ) ;
               while ( RcdFound9 != 0 )
               {
                  init_level_properties9( ) ;
                  getByPrimaryKey029( ) ;
                  AddRow029( ) ;
                  ScanNext029( ) ;
               }
               ScanEnd029( ) ;
               nBlankRcdCount9 = 1;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal029( ) ;
            standaloneModal029( ) ;
            sMode9 = Gx_mode;
            while ( nGXsfl_103_idx < nRC_GXsfl_103 )
            {
               bGXsfl_103_Refreshing = true;
               ReadRow029( ) ;
               edtVersionTarea_Enabled = (int)(context.localUtil.CToN( cgiGet( "VERSIONTAREA_"+sGXsfl_103_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtVersionTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVersionTarea_Enabled), 5, 0), !bGXsfl_103_Refreshing);
               edtFechaVersion_Enabled = (int)(context.localUtil.CToN( cgiGet( "FECHAVERSION_"+sGXsfl_103_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtFechaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
               edtObservacionesVersion_Enabled = (int)(context.localUtil.CToN( cgiGet( "OBSERVACIONESVERSION_"+sGXsfl_103_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtObservacionesVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtObservacionesVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
               edtEditor_Enabled = (int)(context.localUtil.CToN( cgiGet( "EDITOR_"+sGXsfl_103_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtEditor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEditor_Enabled), 5, 0), !bGXsfl_103_Refreshing);
               if ( ( nRcdExists_9 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal029( ) ;
               }
               SendRow029( ) ;
               bGXsfl_103_Refreshing = false;
            }
            Gx_mode = sMode9;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount9 = 1;
            nRcdExists_9 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart029( ) ;
               while ( RcdFound9 != 0 )
               {
                  sGXsfl_103_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_103_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_1039( ) ;
                  init_level_properties9( ) ;
                  standaloneNotModal029( ) ;
                  getByPrimaryKey029( ) ;
                  standaloneModal029( ) ;
                  AddRow029( ) ;
                  ScanNext029( ) ;
               }
               ScanEnd029( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ! IsDsp( ) && ! IsDlt( ) )
         {
            sMode9 = Gx_mode;
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            sGXsfl_103_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_103_idx+1), 4, 0), 4, "0");
            SubsflControlProps_1039( ) ;
            InitAll029( ) ;
            init_level_properties9( ) ;
            nRcdExists_9 = 0;
            nIsMod_9 = 0;
            nRcdDeleted_9 = 0;
            nBlankRcdCount9 = (short)(nBlankRcdUsr9+nBlankRcdCount9);
            fRowAdded = 0;
            while ( nBlankRcdCount9 > 0 )
            {
               standaloneNotModal029( ) ;
               standaloneModal029( ) ;
               AddRow029( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtVersionTarea_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount9 = (short)(nBlankRcdCount9-1);
            }
            Gx_mode = sMode9;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridtarea_versiontareaContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridtarea_versiontarea", Gridtarea_versiontareaContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridtarea_versiontareaContainerData", Gridtarea_versiontareaContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridtarea_versiontareaContainerData"+"V", Gridtarea_versiontareaContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridtarea_versiontareaContainerData"+"V"+"\" value='"+Gridtarea_versiontareaContainer.GridValuesHidden()+"'/>") ;
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
         E11022 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z5IdTarea = (short)(context.localUtil.CToN( cgiGet( "Z5IdTarea"), ".", ","));
               Z6NombreTarea = cgiGet( "Z6NombreTarea");
               Z7DescripcionTarea = cgiGet( "Z7DescripcionTarea");
               Z23StatusTarea = StringUtil.StrToBool( cgiGet( "Z23StatusTarea"));
               Z1IdProyecto = (short)(context.localUtil.CToN( cgiGet( "Z1IdProyecto"), ".", ","));
               Z9IdPrioridad = (short)(context.localUtil.CToN( cgiGet( "Z9IdPrioridad"), ".", ","));
               Z13IdFase = (short)(context.localUtil.CToN( cgiGet( "Z13IdFase"), ".", ","));
               Z17IdEstadoTarea = (short)(context.localUtil.CToN( cgiGet( "Z17IdEstadoTarea"), ".", ","));
               Z19IdPadre = (short)(context.localUtil.CToN( cgiGet( "Z19IdPadre"), ".", ","));
               n19IdPadre = ((0==A19IdPadre) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_103 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_103"), ".", ","));
               N1IdProyecto = (short)(context.localUtil.CToN( cgiGet( "N1IdProyecto"), ".", ","));
               N19IdPadre = (short)(context.localUtil.CToN( cgiGet( "N19IdPadre"), ".", ","));
               n19IdPadre = ((0==A19IdPadre) ? true : false);
               N17IdEstadoTarea = (short)(context.localUtil.CToN( cgiGet( "N17IdEstadoTarea"), ".", ","));
               N13IdFase = (short)(context.localUtil.CToN( cgiGet( "N13IdFase"), ".", ","));
               N9IdPrioridad = (short)(context.localUtil.CToN( cgiGet( "N9IdPrioridad"), ".", ","));
               AV7IdTarea = (short)(context.localUtil.CToN( cgiGet( "vIDTAREA"), ".", ","));
               AV11Insert_IdProyecto = (short)(context.localUtil.CToN( cgiGet( "vINSERT_IDPROYECTO"), ".", ","));
               AV16Insert_IdPadre = (short)(context.localUtil.CToN( cgiGet( "vINSERT_IDPADRE"), ".", ","));
               AV15Insert_IdEstadoTarea = (short)(context.localUtil.CToN( cgiGet( "vINSERT_IDESTADOTAREA"), ".", ","));
               AV12Insert_IdFase = (short)(context.localUtil.CToN( cgiGet( "vINSERT_IDFASE"), ".", ","));
               AV13Insert_IdPrioridad = (short)(context.localUtil.CToN( cgiGet( "vINSERT_IDPRIORIDAD"), ".", ","));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               AV17Pgmname = cgiGet( "vPGMNAME");
               /* Read variables values. */
               A5IdTarea = (short)(context.localUtil.CToN( cgiGet( edtIdTarea_Internalname), ".", ","));
               AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
               if ( ( ( context.localUtil.CToN( cgiGet( edtIdProyecto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtIdProyecto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDPROYECTO");
                  AnyError = 1;
                  GX_FocusControl = edtIdProyecto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1IdProyecto = 0;
                  AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
               }
               else
               {
                  A1IdProyecto = (short)(context.localUtil.CToN( cgiGet( edtIdProyecto_Internalname), ".", ","));
                  AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
               }
               A2NombreProyecto = cgiGet( edtNombreProyecto_Internalname);
               AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
               A6NombreTarea = cgiGet( edtNombreTarea_Internalname);
               AssignAttri("", false, "A6NombreTarea", A6NombreTarea);
               if ( ( ( context.localUtil.CToN( cgiGet( edtIdPadre_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtIdPadre_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDPADRE");
                  AnyError = 1;
                  GX_FocusControl = edtIdPadre_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19IdPadre = 0;
                  n19IdPadre = false;
                  AssignAttri("", false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
               }
               else
               {
                  A19IdPadre = (short)(context.localUtil.CToN( cgiGet( edtIdPadre_Internalname), ".", ","));
                  n19IdPadre = false;
                  AssignAttri("", false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
               }
               n19IdPadre = ((0==A19IdPadre) ? true : false);
               A20NombrePadre = cgiGet( edtNombrePadre_Internalname);
               AssignAttri("", false, "A20NombrePadre", A20NombrePadre);
               A7DescripcionTarea = cgiGet( edtDescripcionTarea_Internalname);
               AssignAttri("", false, "A7DescripcionTarea", A7DescripcionTarea);
               if ( ( ( context.localUtil.CToN( cgiGet( edtIdEstadoTarea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtIdEstadoTarea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDESTADOTAREA");
                  AnyError = 1;
                  GX_FocusControl = edtIdEstadoTarea_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A17IdEstadoTarea = 0;
                  AssignAttri("", false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
               }
               else
               {
                  A17IdEstadoTarea = (short)(context.localUtil.CToN( cgiGet( edtIdEstadoTarea_Internalname), ".", ","));
                  AssignAttri("", false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
               }
               A18EstadoTarea = cgiGet( edtEstadoTarea_Internalname);
               AssignAttri("", false, "A18EstadoTarea", A18EstadoTarea);
               if ( ( ( context.localUtil.CToN( cgiGet( edtIdFase_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtIdFase_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDFASE");
                  AnyError = 1;
                  GX_FocusControl = edtIdFase_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A13IdFase = 0;
                  AssignAttri("", false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
               }
               else
               {
                  A13IdFase = (short)(context.localUtil.CToN( cgiGet( edtIdFase_Internalname), ".", ","));
                  AssignAttri("", false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
               }
               A14Fase = cgiGet( edtFase_Internalname);
               AssignAttri("", false, "A14Fase", A14Fase);
               if ( ( ( context.localUtil.CToN( cgiGet( edtIdPrioridad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtIdPrioridad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDPRIORIDAD");
                  AnyError = 1;
                  GX_FocusControl = edtIdPrioridad_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A9IdPrioridad = 0;
                  AssignAttri("", false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
               }
               else
               {
                  A9IdPrioridad = (short)(context.localUtil.CToN( cgiGet( edtIdPrioridad_Internalname), ".", ","));
                  AssignAttri("", false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
               }
               A10Prioridad = cgiGet( edtPrioridad_Internalname);
               AssignAttri("", false, "A10Prioridad", A10Prioridad);
               A23StatusTarea = StringUtil.StrToBool( cgiGet( chkStatusTarea_Internalname));
               AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Tarea");
               A5IdTarea = (short)(context.localUtil.CToN( cgiGet( edtIdTarea_Internalname), ".", ","));
               AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
               forbiddenHiddens.Add("IdTarea", context.localUtil.Format( (decimal)(A5IdTarea), "ZZZ9"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               A23StatusTarea = StringUtil.StrToBool( cgiGet( chkStatusTarea_Internalname));
               AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
               forbiddenHiddens.Add("StatusTarea", StringUtil.BoolToStr( A23StatusTarea));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A5IdTarea != Z5IdTarea ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLogError("tarea:[ SecurityCheckFailed (403 Forbidden) value for]"+forbiddenHiddens.ToJSonString());
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
                  A5IdTarea = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
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
                     sMode2 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode2;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound2 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_020( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "IDTAREA");
                        AnyError = 1;
                        GX_FocusControl = edtIdTarea_Internalname;
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
                           E11022 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12022 ();
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
            E12022 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll022( ) ;
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
            DisableAttributes022( ) ;
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

      protected void CONFIRM_020( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls022( ) ;
            }
            else
            {
               CheckExtendedTable022( ) ;
               CloseExtendedTableCursors022( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode2 = Gx_mode;
            CONFIRM_029( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode2;
               AssignAttri("", false, "Gx_mode", Gx_mode);
               IsConfirmed = 1;
               AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
            }
            /* Restore parent mode. */
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
      }

      protected void CONFIRM_029( )
      {
         nGXsfl_103_idx = 0;
         while ( nGXsfl_103_idx < nRC_GXsfl_103 )
         {
            ReadRow029( ) ;
            if ( ( nRcdExists_9 != 0 ) || ( nIsMod_9 != 0 ) )
            {
               GetKey029( ) ;
               if ( ( nRcdExists_9 == 0 ) && ( nRcdDeleted_9 == 0 ) )
               {
                  if ( RcdFound9 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate029( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable029( ) ;
                        CloseExtendedTableCursors029( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "VERSIONTAREA_" + sGXsfl_103_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtVersionTarea_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound9 != 0 )
                  {
                     if ( nRcdDeleted_9 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey029( ) ;
                        Load029( ) ;
                        BeforeValidate029( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls029( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_9 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate029( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable029( ) ;
                              CloseExtendedTableCursors029( ) ;
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
                     if ( nRcdDeleted_9 == 0 )
                     {
                        GXCCtl = "VERSIONTAREA_" + sGXsfl_103_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtVersionTarea_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtVersionTarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VersionTarea), 4, 0, ".", ""))) ;
            ChangePostValue( edtFechaVersion_Internalname, context.localUtil.Format(A24FechaVersion, "99/99/99")) ;
            ChangePostValue( edtObservacionesVersion_Internalname, StringUtil.RTrim( A25ObservacionesVersion)) ;
            ChangePostValue( edtEditor_Internalname, StringUtil.RTrim( A26Editor)) ;
            ChangePostValue( "ZT_"+"Z8VersionTarea_"+sGXsfl_103_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8VersionTarea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z24FechaVersion_"+sGXsfl_103_idx, context.localUtil.DToC( Z24FechaVersion, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z25ObservacionesVersion_"+sGXsfl_103_idx, StringUtil.RTrim( Z25ObservacionesVersion)) ;
            ChangePostValue( "ZT_"+"Z26Editor_"+sGXsfl_103_idx, StringUtil.RTrim( Z26Editor)) ;
            ChangePostValue( "nRcdDeleted_9_"+sGXsfl_103_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_9), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_9_"+sGXsfl_103_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_9), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_9_"+sGXsfl_103_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_9), 4, 0, ".", ""))) ;
            ChangePostValue( "N24FechaVersion_"+sGXsfl_103_idx, context.localUtil.DToC( A24FechaVersion, 0, "/")) ;
            ChangePostValue( "N25ObservacionesVersion_"+sGXsfl_103_idx, StringUtil.RTrim( A25ObservacionesVersion)) ;
            ChangePostValue( "N26Editor_"+sGXsfl_103_idx, StringUtil.RTrim( A26Editor)) ;
            if ( nIsMod_9 != 0 )
            {
               ChangePostValue( "VERSIONTAREA_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtVersionTarea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FECHAVERSION_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFechaVersion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBSERVACIONESVERSION_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObservacionesVersion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EDITOR_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEditor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         if ( ! (DateTime.MinValue==A24FechaVersion) )
         {
            edtFechaVersion_Enabled = 0;
            AssignProp("", false, edtFechaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A25ObservacionesVersion)) )
         {
            edtObservacionesVersion_Enabled = 0;
            AssignProp("", false, edtObservacionesVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtObservacionesVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A26Editor)) )
         {
            edtEditor_Enabled = 0;
            AssignProp("", false, edtEditor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEditor_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         }
         /* End of After( level) rules */
      }

      protected void ResetCaption020( )
      {
      }

      protected void E11022( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV17Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "SGCS");
         AV11Insert_IdProyecto = 0;
         AssignAttri("", false, "AV11Insert_IdProyecto", StringUtil.LTrimStr( (decimal)(AV11Insert_IdProyecto), 4, 0));
         AV16Insert_IdPadre = 0;
         AssignAttri("", false, "AV16Insert_IdPadre", StringUtil.LTrimStr( (decimal)(AV16Insert_IdPadre), 4, 0));
         AV15Insert_IdEstadoTarea = 0;
         AssignAttri("", false, "AV15Insert_IdEstadoTarea", StringUtil.LTrimStr( (decimal)(AV15Insert_IdEstadoTarea), 4, 0));
         AV12Insert_IdFase = 0;
         AssignAttri("", false, "AV12Insert_IdFase", StringUtil.LTrimStr( (decimal)(AV12Insert_IdFase), 4, 0));
         AV13Insert_IdPrioridad = 0;
         AssignAttri("", false, "AV13Insert_IdPrioridad", StringUtil.LTrimStr( (decimal)(AV13Insert_IdPrioridad), 4, 0));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            AssignAttri("", false, "AV18GXV1", StringUtil.LTrimStr( (decimal)(AV18GXV1), 8, 0));
            while ( AV18GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "IdProyecto") == 0 )
               {
                  AV11Insert_IdProyecto = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV11Insert_IdProyecto", StringUtil.LTrimStr( (decimal)(AV11Insert_IdProyecto), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "IdPadre") == 0 )
               {
                  AV16Insert_IdPadre = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV16Insert_IdPadre", StringUtil.LTrimStr( (decimal)(AV16Insert_IdPadre), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "IdEstadoTarea") == 0 )
               {
                  AV15Insert_IdEstadoTarea = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV15Insert_IdEstadoTarea", StringUtil.LTrimStr( (decimal)(AV15Insert_IdEstadoTarea), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "IdFase") == 0 )
               {
                  AV12Insert_IdFase = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV12Insert_IdFase", StringUtil.LTrimStr( (decimal)(AV12Insert_IdFase), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "IdPrioridad") == 0 )
               {
                  AV13Insert_IdPrioridad = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV13Insert_IdPrioridad", StringUtil.LTrimStr( (decimal)(AV13Insert_IdPrioridad), 4, 0));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
               AssignAttri("", false, "AV18GXV1", StringUtil.LTrimStr( (decimal)(AV18GXV1), 8, 0));
            }
         }
      }

      protected void E12022( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwtarea.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(5);
         pr_default.close(6);
         pr_default.close(7);
         pr_default.close(8);
         returnInSub = true;
         if (true) return;
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 32 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z6NombreTarea = T00025_A6NombreTarea[0];
               Z7DescripcionTarea = T00025_A7DescripcionTarea[0];
               Z23StatusTarea = T00025_A23StatusTarea[0];
               Z1IdProyecto = T00025_A1IdProyecto[0];
               Z9IdPrioridad = T00025_A9IdPrioridad[0];
               Z13IdFase = T00025_A13IdFase[0];
               Z17IdEstadoTarea = T00025_A17IdEstadoTarea[0];
               Z19IdPadre = T00025_A19IdPadre[0];
            }
            else
            {
               Z6NombreTarea = A6NombreTarea;
               Z7DescripcionTarea = A7DescripcionTarea;
               Z23StatusTarea = A23StatusTarea;
               Z1IdProyecto = A1IdProyecto;
               Z9IdPrioridad = A9IdPrioridad;
               Z13IdFase = A13IdFase;
               Z17IdEstadoTarea = A17IdEstadoTarea;
               Z19IdPadre = A19IdPadre;
            }
         }
         if ( GX_JID == -32 )
         {
            Z5IdTarea = A5IdTarea;
            Z6NombreTarea = A6NombreTarea;
            Z7DescripcionTarea = A7DescripcionTarea;
            Z23StatusTarea = A23StatusTarea;
            Z1IdProyecto = A1IdProyecto;
            Z9IdPrioridad = A9IdPrioridad;
            Z13IdFase = A13IdFase;
            Z17IdEstadoTarea = A17IdEstadoTarea;
            Z19IdPadre = A19IdPadre;
            Z2NombreProyecto = A2NombreProyecto;
            Z20NombrePadre = A20NombrePadre;
            Z18EstadoTarea = A18EstadoTarea;
            Z14Fase = A14Fase;
            Z10Prioridad = A10Prioridad;
         }
      }

      protected void standaloneNotModal( )
      {
         edtIdTarea_Enabled = 0;
         AssignProp("", false, edtIdTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdTarea_Enabled), 5, 0), true);
         chkStatusTarea.Enabled = 0;
         AssignProp("", false, chkStatusTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkStatusTarea.Enabled), 5, 0), true);
         Gx_BScreen = 0;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDPROYECTO"+"'), id:'"+"IDPROYECTO"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_19_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDPADRE"+"'), id:'"+"IDPADRE"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_17_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0060.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDESTADOTAREA"+"'), id:'"+"IDESTADOTAREA"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_13_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDFASE"+"'), id:'"+"IDFASE"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_9_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDPRIORIDAD"+"'), id:'"+"IDPRIORIDAD"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtIdTarea_Enabled = 0;
         AssignProp("", false, edtIdTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdTarea_Enabled), 5, 0), true);
         chkStatusTarea.Enabled = 0;
         AssignProp("", false, chkStatusTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkStatusTarea.Enabled), 5, 0), true);
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7IdTarea) )
         {
            A5IdTarea = AV7IdTarea;
            AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_IdProyecto) )
         {
            edtIdProyecto_Enabled = 0;
            AssignProp("", false, edtIdProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdProyecto_Enabled), 5, 0), true);
         }
         else
         {
            edtIdProyecto_Enabled = 1;
            AssignProp("", false, edtIdProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdProyecto_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV16Insert_IdPadre) )
         {
            edtIdPadre_Enabled = 0;
            AssignProp("", false, edtIdPadre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdPadre_Enabled), 5, 0), true);
         }
         else
         {
            edtIdPadre_Enabled = 1;
            AssignProp("", false, edtIdPadre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdPadre_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_IdEstadoTarea) )
         {
            edtIdEstadoTarea_Enabled = 0;
            AssignProp("", false, edtIdEstadoTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdEstadoTarea_Enabled), 5, 0), true);
         }
         else
         {
            edtIdEstadoTarea_Enabled = 1;
            AssignProp("", false, edtIdEstadoTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdEstadoTarea_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_IdFase) )
         {
            edtIdFase_Enabled = 0;
            AssignProp("", false, edtIdFase_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdFase_Enabled), 5, 0), true);
         }
         else
         {
            edtIdFase_Enabled = 1;
            AssignProp("", false, edtIdFase_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdFase_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_IdPrioridad) )
         {
            edtIdPrioridad_Enabled = 0;
            AssignProp("", false, edtIdPrioridad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdPrioridad_Enabled), 5, 0), true);
         }
         else
         {
            edtIdPrioridad_Enabled = 1;
            AssignProp("", false, edtIdPrioridad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdPrioridad_Enabled), 5, 0), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_IdPrioridad) )
         {
            A9IdPrioridad = AV13Insert_IdPrioridad;
            AssignAttri("", false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_IdFase) )
         {
            A13IdFase = AV12Insert_IdFase;
            AssignAttri("", false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_IdEstadoTarea) )
         {
            A17IdEstadoTarea = AV15Insert_IdEstadoTarea;
            AssignAttri("", false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV16Insert_IdPadre) )
         {
            A19IdPadre = AV16Insert_IdPadre;
            n19IdPadre = false;
            AssignAttri("", false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_IdProyecto) )
         {
            A1IdProyecto = AV11Insert_IdProyecto;
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
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
         if ( IsIns( )  && (false==A23StatusTarea) && ( Gx_BScreen == 0 ) )
         {
            A23StatusTarea = true;
            AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV17Pgmname = "Tarea";
            AssignAttri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T00027 */
            pr_default.execute(5, new Object[] {A9IdPrioridad});
            A10Prioridad = T00027_A10Prioridad[0];
            AssignAttri("", false, "A10Prioridad", A10Prioridad);
            pr_default.close(5);
            /* Using cursor T00028 */
            pr_default.execute(6, new Object[] {A13IdFase});
            A14Fase = T00028_A14Fase[0];
            AssignAttri("", false, "A14Fase", A14Fase);
            pr_default.close(6);
            /* Using cursor T00029 */
            pr_default.execute(7, new Object[] {A17IdEstadoTarea});
            A18EstadoTarea = T00029_A18EstadoTarea[0];
            AssignAttri("", false, "A18EstadoTarea", A18EstadoTarea);
            pr_default.close(7);
            /* Using cursor T000210 */
            pr_default.execute(8, new Object[] {n19IdPadre, A19IdPadre});
            A20NombrePadre = T000210_A20NombrePadre[0];
            AssignAttri("", false, "A20NombrePadre", A20NombrePadre);
            pr_default.close(8);
            /* Using cursor T00026 */
            pr_default.execute(4, new Object[] {A1IdProyecto});
            A2NombreProyecto = T00026_A2NombreProyecto[0];
            AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
            pr_default.close(4);
         }
      }

      protected void Load022( )
      {
         /* Using cursor T000211 */
         pr_default.execute(9, new Object[] {A5IdTarea});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound2 = 1;
            A2NombreProyecto = T000211_A2NombreProyecto[0];
            AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
            A6NombreTarea = T000211_A6NombreTarea[0];
            AssignAttri("", false, "A6NombreTarea", A6NombreTarea);
            A20NombrePadre = T000211_A20NombrePadre[0];
            AssignAttri("", false, "A20NombrePadre", A20NombrePadre);
            A7DescripcionTarea = T000211_A7DescripcionTarea[0];
            AssignAttri("", false, "A7DescripcionTarea", A7DescripcionTarea);
            A18EstadoTarea = T000211_A18EstadoTarea[0];
            AssignAttri("", false, "A18EstadoTarea", A18EstadoTarea);
            A14Fase = T000211_A14Fase[0];
            AssignAttri("", false, "A14Fase", A14Fase);
            A10Prioridad = T000211_A10Prioridad[0];
            AssignAttri("", false, "A10Prioridad", A10Prioridad);
            A23StatusTarea = T000211_A23StatusTarea[0];
            AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
            A1IdProyecto = T000211_A1IdProyecto[0];
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
            A9IdPrioridad = T000211_A9IdPrioridad[0];
            AssignAttri("", false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
            A13IdFase = T000211_A13IdFase[0];
            AssignAttri("", false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
            A17IdEstadoTarea = T000211_A17IdEstadoTarea[0];
            AssignAttri("", false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
            A19IdPadre = T000211_A19IdPadre[0];
            n19IdPadre = T000211_n19IdPadre[0];
            AssignAttri("", false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
            ZM022( -32) ;
         }
         pr_default.close(9);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
         AV17Pgmname = "Tarea";
         AssignAttri("", false, "AV17Pgmname", AV17Pgmname);
      }

      protected void CheckExtendedTable022( )
      {
         nIsDirty_2 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV17Pgmname = "Tarea";
         AssignAttri("", false, "AV17Pgmname", AV17Pgmname);
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A1IdProyecto});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Proyecto'.", "ForeignKeyNotFound", 1, "IDPROYECTO");
            AnyError = 1;
            GX_FocusControl = edtIdProyecto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A2NombreProyecto = T00026_A2NombreProyecto[0];
         AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
         pr_default.close(4);
         /* Using cursor T000210 */
         pr_default.execute(8, new Object[] {n19IdPadre, A19IdPadre});
         if ( (pr_default.getStatus(8) == 101) )
         {
            if ( ! ( (0==A19IdPadre) ) )
            {
               GX_msglist.addItem("No matching 'Id Padre'.", "ForeignKeyNotFound", 1, "IDPADRE");
               AnyError = 1;
               GX_FocusControl = edtIdPadre_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A20NombrePadre = T000210_A20NombrePadre[0];
         AssignAttri("", false, "A20NombrePadre", A20NombrePadre);
         pr_default.close(8);
         /* Using cursor T00029 */
         pr_default.execute(7, new Object[] {A17IdEstadoTarea});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No matching 'Estado Tarea'.", "ForeignKeyNotFound", 1, "IDESTADOTAREA");
            AnyError = 1;
            GX_FocusControl = edtIdEstadoTarea_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18EstadoTarea = T00029_A18EstadoTarea[0];
         AssignAttri("", false, "A18EstadoTarea", A18EstadoTarea);
         pr_default.close(7);
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {A13IdFase});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Fase'.", "ForeignKeyNotFound", 1, "IDFASE");
            AnyError = 1;
            GX_FocusControl = edtIdFase_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A14Fase = T00028_A14Fase[0];
         AssignAttri("", false, "A14Fase", A14Fase);
         pr_default.close(6);
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A9IdPrioridad});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Prioridad'.", "ForeignKeyNotFound", 1, "IDPRIORIDAD");
            AnyError = 1;
            GX_FocusControl = edtIdPrioridad_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A10Prioridad = T00027_A10Prioridad[0];
         AssignAttri("", false, "A10Prioridad", A10Prioridad);
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(4);
         pr_default.close(8);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_33( short A1IdProyecto )
      {
         /* Using cursor T000212 */
         pr_default.execute(10, new Object[] {A1IdProyecto});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No matching 'Proyecto'.", "ForeignKeyNotFound", 1, "IDPROYECTO");
            AnyError = 1;
            GX_FocusControl = edtIdProyecto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A2NombreProyecto = T000212_A2NombreProyecto[0];
         AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A2NombreProyecto))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(10) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(10);
      }

      protected void gxLoad_37( short A19IdPadre )
      {
         /* Using cursor T000213 */
         pr_default.execute(11, new Object[] {n19IdPadre, A19IdPadre});
         if ( (pr_default.getStatus(11) == 101) )
         {
            if ( ! ( (0==A19IdPadre) ) )
            {
               GX_msglist.addItem("No matching 'Id Padre'.", "ForeignKeyNotFound", 1, "IDPADRE");
               AnyError = 1;
               GX_FocusControl = edtIdPadre_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A20NombrePadre = T000213_A20NombrePadre[0];
         AssignAttri("", false, "A20NombrePadre", A20NombrePadre);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A20NombrePadre))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(11) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(11);
      }

      protected void gxLoad_36( short A17IdEstadoTarea )
      {
         /* Using cursor T000214 */
         pr_default.execute(12, new Object[] {A17IdEstadoTarea});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Estado Tarea'.", "ForeignKeyNotFound", 1, "IDESTADOTAREA");
            AnyError = 1;
            GX_FocusControl = edtIdEstadoTarea_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18EstadoTarea = T000214_A18EstadoTarea[0];
         AssignAttri("", false, "A18EstadoTarea", A18EstadoTarea);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A18EstadoTarea))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(12) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(12);
      }

      protected void gxLoad_35( short A13IdFase )
      {
         /* Using cursor T000215 */
         pr_default.execute(13, new Object[] {A13IdFase});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No matching 'Fase'.", "ForeignKeyNotFound", 1, "IDFASE");
            AnyError = 1;
            GX_FocusControl = edtIdFase_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A14Fase = T000215_A14Fase[0];
         AssignAttri("", false, "A14Fase", A14Fase);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A14Fase))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(13) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(13);
      }

      protected void gxLoad_34( short A9IdPrioridad )
      {
         /* Using cursor T000216 */
         pr_default.execute(14, new Object[] {A9IdPrioridad});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No matching 'Prioridad'.", "ForeignKeyNotFound", 1, "IDPRIORIDAD");
            AnyError = 1;
            GX_FocusControl = edtIdPrioridad_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A10Prioridad = T000216_A10Prioridad[0];
         AssignAttri("", false, "A10Prioridad", A10Prioridad);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A10Prioridad))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(14) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(14);
      }

      protected void GetKey022( )
      {
         /* Using cursor T000217 */
         pr_default.execute(15, new Object[] {A5IdTarea});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(15);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A5IdTarea});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM022( 32) ;
            RcdFound2 = 1;
            A5IdTarea = T00025_A5IdTarea[0];
            AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
            A6NombreTarea = T00025_A6NombreTarea[0];
            AssignAttri("", false, "A6NombreTarea", A6NombreTarea);
            A7DescripcionTarea = T00025_A7DescripcionTarea[0];
            AssignAttri("", false, "A7DescripcionTarea", A7DescripcionTarea);
            A23StatusTarea = T00025_A23StatusTarea[0];
            AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
            A1IdProyecto = T00025_A1IdProyecto[0];
            AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
            A9IdPrioridad = T00025_A9IdPrioridad[0];
            AssignAttri("", false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
            A13IdFase = T00025_A13IdFase[0];
            AssignAttri("", false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
            A17IdEstadoTarea = T00025_A17IdEstadoTarea[0];
            AssignAttri("", false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
            A19IdPadre = T00025_A19IdPadre[0];
            n19IdPadre = T00025_n19IdPadre[0];
            AssignAttri("", false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
            Z5IdTarea = A5IdTarea;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound2 = 0;
         /* Using cursor T000218 */
         pr_default.execute(16, new Object[] {A5IdTarea});
         if ( (pr_default.getStatus(16) != 101) )
         {
            while ( (pr_default.getStatus(16) != 101) && ( ( T000218_A5IdTarea[0] < A5IdTarea ) ) )
            {
               pr_default.readNext(16);
            }
            if ( (pr_default.getStatus(16) != 101) && ( ( T000218_A5IdTarea[0] > A5IdTarea ) ) )
            {
               A5IdTarea = T000218_A5IdTarea[0];
               AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
               RcdFound2 = 1;
            }
         }
         pr_default.close(16);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0;
         /* Using cursor T000219 */
         pr_default.execute(17, new Object[] {A5IdTarea});
         if ( (pr_default.getStatus(17) != 101) )
         {
            while ( (pr_default.getStatus(17) != 101) && ( ( T000219_A5IdTarea[0] > A5IdTarea ) ) )
            {
               pr_default.readNext(17);
            }
            if ( (pr_default.getStatus(17) != 101) && ( ( T000219_A5IdTarea[0] < A5IdTarea ) ) )
            {
               A5IdTarea = T000219_A5IdTarea[0];
               AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
               RcdFound2 = 1;
            }
         }
         pr_default.close(17);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtIdProyecto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert022( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A5IdTarea != Z5IdTarea )
               {
                  A5IdTarea = Z5IdTarea;
                  AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDTAREA");
                  AnyError = 1;
                  GX_FocusControl = edtIdTarea_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtIdProyecto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update022( ) ;
                  GX_FocusControl = edtIdProyecto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A5IdTarea != Z5IdTarea )
               {
                  /* Insert record */
                  GX_FocusControl = edtIdProyecto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert022( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDTAREA");
                     AnyError = 1;
                     GX_FocusControl = edtIdTarea_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtIdProyecto_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert022( ) ;
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
         if ( A5IdTarea != Z5IdTarea )
         {
            A5IdTarea = Z5IdTarea;
            AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDTAREA");
            AnyError = 1;
            GX_FocusControl = edtIdTarea_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtIdProyecto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00024 */
            pr_default.execute(2, new Object[] {A5IdTarea});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Tarea"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z6NombreTarea, T00024_A6NombreTarea[0]) != 0 ) || ( StringUtil.StrCmp(Z7DescripcionTarea, T00024_A7DescripcionTarea[0]) != 0 ) || ( Z23StatusTarea != T00024_A23StatusTarea[0] ) || ( Z1IdProyecto != T00024_A1IdProyecto[0] ) || ( Z9IdPrioridad != T00024_A9IdPrioridad[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z13IdFase != T00024_A13IdFase[0] ) || ( Z17IdEstadoTarea != T00024_A17IdEstadoTarea[0] ) || ( Z19IdPadre != T00024_A19IdPadre[0] ) )
            {
               if ( StringUtil.StrCmp(Z6NombreTarea, T00024_A6NombreTarea[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"NombreTarea");
                  GXUtil.WriteLogRaw("Old: ",Z6NombreTarea);
                  GXUtil.WriteLogRaw("Current: ",T00024_A6NombreTarea[0]);
               }
               if ( StringUtil.StrCmp(Z7DescripcionTarea, T00024_A7DescripcionTarea[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"DescripcionTarea");
                  GXUtil.WriteLogRaw("Old: ",Z7DescripcionTarea);
                  GXUtil.WriteLogRaw("Current: ",T00024_A7DescripcionTarea[0]);
               }
               if ( Z23StatusTarea != T00024_A23StatusTarea[0] )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"StatusTarea");
                  GXUtil.WriteLogRaw("Old: ",Z23StatusTarea);
                  GXUtil.WriteLogRaw("Current: ",T00024_A23StatusTarea[0]);
               }
               if ( Z1IdProyecto != T00024_A1IdProyecto[0] )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"IdProyecto");
                  GXUtil.WriteLogRaw("Old: ",Z1IdProyecto);
                  GXUtil.WriteLogRaw("Current: ",T00024_A1IdProyecto[0]);
               }
               if ( Z9IdPrioridad != T00024_A9IdPrioridad[0] )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"IdPrioridad");
                  GXUtil.WriteLogRaw("Old: ",Z9IdPrioridad);
                  GXUtil.WriteLogRaw("Current: ",T00024_A9IdPrioridad[0]);
               }
               if ( Z13IdFase != T00024_A13IdFase[0] )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"IdFase");
                  GXUtil.WriteLogRaw("Old: ",Z13IdFase);
                  GXUtil.WriteLogRaw("Current: ",T00024_A13IdFase[0]);
               }
               if ( Z17IdEstadoTarea != T00024_A17IdEstadoTarea[0] )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"IdEstadoTarea");
                  GXUtil.WriteLogRaw("Old: ",Z17IdEstadoTarea);
                  GXUtil.WriteLogRaw("Current: ",T00024_A17IdEstadoTarea[0]);
               }
               if ( Z19IdPadre != T00024_A19IdPadre[0] )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"IdPadre");
                  GXUtil.WriteLogRaw("Old: ",Z19IdPadre);
                  GXUtil.WriteLogRaw("Current: ",T00024_A19IdPadre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Tarea"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000220 */
                     pr_default.execute(18, new Object[] {A6NombreTarea, A7DescripcionTarea, A23StatusTarea, A1IdProyecto, A9IdPrioridad, A13IdFase, A17IdEstadoTarea, n19IdPadre, A19IdPadre});
                     A5IdTarea = T000220_A5IdTarea[0];
                     AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel022( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption020( ) ;
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
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000221 */
                     pr_default.execute(19, new Object[] {A6NombreTarea, A7DescripcionTarea, A23StatusTarea, A1IdProyecto, A9IdPrioridad, A13IdFase, A17IdEstadoTarea, n19IdPadre, A19IdPadre, A5IdTarea});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Tarea"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel022( ) ;
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
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart029( ) ;
                  while ( RcdFound9 != 0 )
                  {
                     getByPrimaryKey029( ) ;
                     Delete029( ) ;
                     ScanNext029( ) ;
                  }
                  ScanEnd029( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000222 */
                     pr_default.execute(20, new Object[] {A5IdTarea});
                     pr_default.close(20);
                     dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
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
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel022( ) ;
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "Tarea";
            AssignAttri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000223 */
            pr_default.execute(21, new Object[] {A1IdProyecto});
            A2NombreProyecto = T000223_A2NombreProyecto[0];
            AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
            pr_default.close(21);
            /* Using cursor T000224 */
            pr_default.execute(22, new Object[] {n19IdPadre, A19IdPadre});
            A20NombrePadre = T000224_A20NombrePadre[0];
            AssignAttri("", false, "A20NombrePadre", A20NombrePadre);
            pr_default.close(22);
            /* Using cursor T000225 */
            pr_default.execute(23, new Object[] {A17IdEstadoTarea});
            A18EstadoTarea = T000225_A18EstadoTarea[0];
            AssignAttri("", false, "A18EstadoTarea", A18EstadoTarea);
            pr_default.close(23);
            /* Using cursor T000226 */
            pr_default.execute(24, new Object[] {A13IdFase});
            A14Fase = T000226_A14Fase[0];
            AssignAttri("", false, "A14Fase", A14Fase);
            pr_default.close(24);
            /* Using cursor T000227 */
            pr_default.execute(25, new Object[] {A9IdPrioridad});
            A10Prioridad = T000227_A10Prioridad[0];
            AssignAttri("", false, "A10Prioridad", A10Prioridad);
            pr_default.close(25);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000228 */
            pr_default.execute(26, new Object[] {A5IdTarea});
            if ( (pr_default.getStatus(26) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tarea"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(26);
            /* Using cursor T000229 */
            pr_default.execute(27, new Object[] {A5IdTarea});
            if ( (pr_default.getStatus(27) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Id"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(27);
         }
      }

      protected void ProcessNestedLevel029( )
      {
         nGXsfl_103_idx = 0;
         while ( nGXsfl_103_idx < nRC_GXsfl_103 )
         {
            ReadRow029( ) ;
            if ( ( nRcdExists_9 != 0 ) || ( nIsMod_9 != 0 ) )
            {
               standaloneNotModal029( ) ;
               GetKey029( ) ;
               if ( ( nRcdExists_9 == 0 ) && ( nRcdDeleted_9 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert029( ) ;
               }
               else
               {
                  if ( RcdFound9 != 0 )
                  {
                     if ( ( nRcdDeleted_9 != 0 ) && ( nRcdExists_9 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete029( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_9 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update029( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_9 == 0 )
                     {
                        GXCCtl = "VERSIONTAREA_" + sGXsfl_103_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtVersionTarea_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtVersionTarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VersionTarea), 4, 0, ".", ""))) ;
            ChangePostValue( edtFechaVersion_Internalname, context.localUtil.Format(A24FechaVersion, "99/99/99")) ;
            ChangePostValue( edtObservacionesVersion_Internalname, StringUtil.RTrim( A25ObservacionesVersion)) ;
            ChangePostValue( edtEditor_Internalname, StringUtil.RTrim( A26Editor)) ;
            ChangePostValue( "ZT_"+"Z8VersionTarea_"+sGXsfl_103_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8VersionTarea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z24FechaVersion_"+sGXsfl_103_idx, context.localUtil.DToC( Z24FechaVersion, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z25ObservacionesVersion_"+sGXsfl_103_idx, StringUtil.RTrim( Z25ObservacionesVersion)) ;
            ChangePostValue( "ZT_"+"Z26Editor_"+sGXsfl_103_idx, StringUtil.RTrim( Z26Editor)) ;
            ChangePostValue( "nRcdDeleted_9_"+sGXsfl_103_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_9), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_9_"+sGXsfl_103_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_9), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_9_"+sGXsfl_103_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_9), 4, 0, ".", ""))) ;
            ChangePostValue( "N24FechaVersion_"+sGXsfl_103_idx, context.localUtil.DToC( A24FechaVersion, 0, "/")) ;
            ChangePostValue( "N25ObservacionesVersion_"+sGXsfl_103_idx, StringUtil.RTrim( A25ObservacionesVersion)) ;
            ChangePostValue( "N26Editor_"+sGXsfl_103_idx, StringUtil.RTrim( A26Editor)) ;
            if ( nIsMod_9 != 0 )
            {
               ChangePostValue( "VERSIONTAREA_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtVersionTarea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FECHAVERSION_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFechaVersion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBSERVACIONESVERSION_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObservacionesVersion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EDITOR_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEditor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         if ( ! (DateTime.MinValue==A24FechaVersion) )
         {
            edtFechaVersion_Enabled = 0;
            AssignProp("", false, edtFechaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A25ObservacionesVersion)) )
         {
            edtObservacionesVersion_Enabled = 0;
            AssignProp("", false, edtObservacionesVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtObservacionesVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A26Editor)) )
         {
            edtEditor_Enabled = 0;
            AssignProp("", false, edtEditor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEditor_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         }
         /* End of After( level) rules */
         InitAll029( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_9 = 0;
         nIsMod_9 = 0;
         nRcdDeleted_9 = 0;
      }

      protected void ProcessLevel022( )
      {
         /* Save parent mode. */
         sMode2 = Gx_mode;
         ProcessNestedLevel029( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel022( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(21);
            pr_default.close(25);
            pr_default.close(24);
            pr_default.close(23);
            pr_default.close(22);
            context.CommitDataStores("tarea",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(21);
            pr_default.close(25);
            pr_default.close(24);
            pr_default.close(23);
            pr_default.close(22);
            context.RollbackDataStores("tarea",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart022( )
      {
         /* Scan By routine */
         /* Using cursor T000230 */
         pr_default.execute(28);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound2 = 1;
            A5IdTarea = T000230_A5IdTarea[0];
            AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(28);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound2 = 1;
            A5IdTarea = T000230_A5IdTarea[0];
            AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
         }
      }

      protected void ScanEnd022( )
      {
         pr_default.close(28);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
         edtIdTarea_Enabled = 0;
         AssignProp("", false, edtIdTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdTarea_Enabled), 5, 0), true);
         edtIdProyecto_Enabled = 0;
         AssignProp("", false, edtIdProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdProyecto_Enabled), 5, 0), true);
         edtNombreProyecto_Enabled = 0;
         AssignProp("", false, edtNombreProyecto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtNombreProyecto_Enabled), 5, 0), true);
         edtNombreTarea_Enabled = 0;
         AssignProp("", false, edtNombreTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtNombreTarea_Enabled), 5, 0), true);
         edtIdPadre_Enabled = 0;
         AssignProp("", false, edtIdPadre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdPadre_Enabled), 5, 0), true);
         edtNombrePadre_Enabled = 0;
         AssignProp("", false, edtNombrePadre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtNombrePadre_Enabled), 5, 0), true);
         edtDescripcionTarea_Enabled = 0;
         AssignProp("", false, edtDescripcionTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtDescripcionTarea_Enabled), 5, 0), true);
         edtIdEstadoTarea_Enabled = 0;
         AssignProp("", false, edtIdEstadoTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdEstadoTarea_Enabled), 5, 0), true);
         edtEstadoTarea_Enabled = 0;
         AssignProp("", false, edtEstadoTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEstadoTarea_Enabled), 5, 0), true);
         edtIdFase_Enabled = 0;
         AssignProp("", false, edtIdFase_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdFase_Enabled), 5, 0), true);
         edtFase_Enabled = 0;
         AssignProp("", false, edtFase_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFase_Enabled), 5, 0), true);
         edtIdPrioridad_Enabled = 0;
         AssignProp("", false, edtIdPrioridad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtIdPrioridad_Enabled), 5, 0), true);
         edtPrioridad_Enabled = 0;
         AssignProp("", false, edtPrioridad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPrioridad_Enabled), 5, 0), true);
         chkStatusTarea.Enabled = 0;
         AssignProp("", false, chkStatusTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkStatusTarea.Enabled), 5, 0), true);
      }

      protected void ZM029( short GX_JID )
      {
         if ( ( GX_JID == 38 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z24FechaVersion = T00023_A24FechaVersion[0];
               Z25ObservacionesVersion = T00023_A25ObservacionesVersion[0];
               Z26Editor = T00023_A26Editor[0];
            }
            else
            {
               Z24FechaVersion = A24FechaVersion;
               Z25ObservacionesVersion = A25ObservacionesVersion;
               Z26Editor = A26Editor;
            }
         }
         if ( GX_JID == -38 )
         {
            Z5IdTarea = A5IdTarea;
            Z8VersionTarea = A8VersionTarea;
            Z24FechaVersion = A24FechaVersion;
            Z25ObservacionesVersion = A25ObservacionesVersion;
            Z26Editor = A26Editor;
         }
      }

      protected void standaloneNotModal029( )
      {
         edtFechaVersion_Enabled = 1;
         AssignProp("", false, edtFechaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtObservacionesVersion_Enabled = 1;
         AssignProp("", false, edtObservacionesVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtObservacionesVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtEditor_Enabled = 1;
         AssignProp("", false, edtEditor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEditor_Enabled), 5, 0), !bGXsfl_103_Refreshing);
      }

      protected void standaloneModal029( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtVersionTarea_Enabled = 0;
            AssignProp("", false, edtVersionTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVersionTarea_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         }
         else
         {
            edtVersionTarea_Enabled = 1;
            AssignProp("", false, edtVersionTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVersionTarea_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         }
      }

      protected void Load029( )
      {
         /* Using cursor T000231 */
         pr_default.execute(29, new Object[] {A5IdTarea, A8VersionTarea});
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound9 = 1;
            A24FechaVersion = T000231_A24FechaVersion[0];
            A25ObservacionesVersion = T000231_A25ObservacionesVersion[0];
            A26Editor = T000231_A26Editor[0];
            ZM029( -38) ;
         }
         pr_default.close(29);
         OnLoadActions029( ) ;
      }

      protected void OnLoadActions029( )
      {
      }

      protected void CheckExtendedTable029( )
      {
         nIsDirty_9 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal029( ) ;
         if ( ! ( (DateTime.MinValue==A24FechaVersion) || ( A24FechaVersion >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXCCtl = "FECHAVERSION_" + sGXsfl_103_idx;
            GX_msglist.addItem("Field Fecha Version is out of range", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtFechaVersion_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors029( )
      {
      }

      protected void enableDisable029( )
      {
      }

      protected void GetKey029( )
      {
         /* Using cursor T000232 */
         pr_default.execute(30, new Object[] {A5IdTarea, A8VersionTarea});
         if ( (pr_default.getStatus(30) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(30);
      }

      protected void getByPrimaryKey029( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A5IdTarea, A8VersionTarea});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM029( 38) ;
            RcdFound9 = 1;
            InitializeNonKey029( ) ;
            A8VersionTarea = T00023_A8VersionTarea[0];
            A24FechaVersion = T00023_A24FechaVersion[0];
            A25ObservacionesVersion = T00023_A25ObservacionesVersion[0];
            A26Editor = T00023_A26Editor[0];
            Z5IdTarea = A5IdTarea;
            Z8VersionTarea = A8VersionTarea;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            Load029( ) ;
            Gx_mode = sMode9;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey029( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal029( ) ;
            Gx_mode = sMode9;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes029( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency029( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {A5IdTarea, A8VersionTarea});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TareaVersionTarea"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z24FechaVersion != T00022_A24FechaVersion[0] ) || ( StringUtil.StrCmp(Z25ObservacionesVersion, T00022_A25ObservacionesVersion[0]) != 0 ) || ( StringUtil.StrCmp(Z26Editor, T00022_A26Editor[0]) != 0 ) )
            {
               if ( Z24FechaVersion != T00022_A24FechaVersion[0] )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"FechaVersion");
                  GXUtil.WriteLogRaw("Old: ",Z24FechaVersion);
                  GXUtil.WriteLogRaw("Current: ",T00022_A24FechaVersion[0]);
               }
               if ( StringUtil.StrCmp(Z25ObservacionesVersion, T00022_A25ObservacionesVersion[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"ObservacionesVersion");
                  GXUtil.WriteLogRaw("Old: ",Z25ObservacionesVersion);
                  GXUtil.WriteLogRaw("Current: ",T00022_A25ObservacionesVersion[0]);
               }
               if ( StringUtil.StrCmp(Z26Editor, T00022_A26Editor[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"Editor");
                  GXUtil.WriteLogRaw("Old: ",Z26Editor);
                  GXUtil.WriteLogRaw("Current: ",T00022_A26Editor[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TareaVersionTarea"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert029( )
      {
         BeforeValidate029( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable029( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM029( 0) ;
            CheckOptimisticConcurrency029( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm029( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert029( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000233 */
                     pr_default.execute(31, new Object[] {A5IdTarea, A8VersionTarea, A24FechaVersion, A25ObservacionesVersion, A26Editor});
                     pr_default.close(31);
                     dsDefault.SmartCacheProvider.SetUpdated("TareaVersionTarea") ;
                     if ( (pr_default.getStatus(31) == 1) )
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
               Load029( ) ;
            }
            EndLevel029( ) ;
         }
         CloseExtendedTableCursors029( ) ;
      }

      protected void Update029( )
      {
         BeforeValidate029( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable029( ) ;
         }
         if ( ( nIsMod_9 != 0 ) || ( nIsDirty_9 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency029( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm029( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate029( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000234 */
                        pr_default.execute(32, new Object[] {A24FechaVersion, A25ObservacionesVersion, A26Editor, A5IdTarea, A8VersionTarea});
                        pr_default.close(32);
                        dsDefault.SmartCacheProvider.SetUpdated("TareaVersionTarea") ;
                        if ( (pr_default.getStatus(32) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TareaVersionTarea"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate029( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey029( ) ;
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
               EndLevel029( ) ;
            }
         }
         CloseExtendedTableCursors029( ) ;
      }

      protected void DeferredUpdate029( )
      {
      }

      protected void Delete029( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate029( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency029( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls029( ) ;
            AfterConfirm029( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete029( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000235 */
                  pr_default.execute(33, new Object[] {A5IdTarea, A8VersionTarea});
                  pr_default.close(33);
                  dsDefault.SmartCacheProvider.SetUpdated("TareaVersionTarea") ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel029( ) ;
         Gx_mode = sMode9;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls029( )
      {
         standaloneModal029( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel029( )
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

      public void ScanStart029( )
      {
         /* Scan By routine */
         /* Using cursor T000236 */
         pr_default.execute(34, new Object[] {A5IdTarea});
         RcdFound9 = 0;
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound9 = 1;
            A8VersionTarea = T000236_A8VersionTarea[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext029( )
      {
         /* Scan next routine */
         pr_default.readNext(34);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound9 = 1;
            A8VersionTarea = T000236_A8VersionTarea[0];
         }
      }

      protected void ScanEnd029( )
      {
         pr_default.close(34);
      }

      protected void AfterConfirm029( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert029( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate029( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete029( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete029( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate029( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes029( )
      {
         edtVersionTarea_Enabled = 0;
         AssignProp("", false, edtVersionTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVersionTarea_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtFechaVersion_Enabled = 0;
         AssignProp("", false, edtFechaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtObservacionesVersion_Enabled = 0;
         AssignProp("", false, edtObservacionesVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtObservacionesVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtEditor_Enabled = 0;
         AssignProp("", false, edtEditor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEditor_Enabled), 5, 0), !bGXsfl_103_Refreshing);
      }

      protected void send_integrity_lvl_hashes029( )
      {
      }

      protected void send_integrity_lvl_hashes022( )
      {
      }

      protected void SubsflControlProps_1039( )
      {
         edtVersionTarea_Internalname = "VERSIONTAREA_"+sGXsfl_103_idx;
         edtFechaVersion_Internalname = "FECHAVERSION_"+sGXsfl_103_idx;
         edtObservacionesVersion_Internalname = "OBSERVACIONESVERSION_"+sGXsfl_103_idx;
         edtEditor_Internalname = "EDITOR_"+sGXsfl_103_idx;
      }

      protected void SubsflControlProps_fel_1039( )
      {
         edtVersionTarea_Internalname = "VERSIONTAREA_"+sGXsfl_103_fel_idx;
         edtFechaVersion_Internalname = "FECHAVERSION_"+sGXsfl_103_fel_idx;
         edtObservacionesVersion_Internalname = "OBSERVACIONESVERSION_"+sGXsfl_103_fel_idx;
         edtEditor_Internalname = "EDITOR_"+sGXsfl_103_fel_idx;
      }

      protected void AddRow029( )
      {
         nGXsfl_103_idx = (int)(nGXsfl_103_idx+1);
         sGXsfl_103_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_103_idx), 4, 0), 4, "0");
         SubsflControlProps_1039( ) ;
         SendRow029( ) ;
      }

      protected void SendRow029( )
      {
         Gridtarea_versiontareaRow = GXWebRow.GetNew(context);
         if ( subGridtarea_versiontarea_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridtarea_versiontarea_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridtarea_versiontarea_Class, "") != 0 )
            {
               subGridtarea_versiontarea_Linesclass = subGridtarea_versiontarea_Class+"Odd";
            }
         }
         else if ( subGridtarea_versiontarea_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridtarea_versiontarea_Backstyle = 0;
            subGridtarea_versiontarea_Backcolor = subGridtarea_versiontarea_Allbackcolor;
            if ( StringUtil.StrCmp(subGridtarea_versiontarea_Class, "") != 0 )
            {
               subGridtarea_versiontarea_Linesclass = subGridtarea_versiontarea_Class+"Uniform";
            }
         }
         else if ( subGridtarea_versiontarea_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridtarea_versiontarea_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridtarea_versiontarea_Class, "") != 0 )
            {
               subGridtarea_versiontarea_Linesclass = subGridtarea_versiontarea_Class+"Odd";
            }
            subGridtarea_versiontarea_Backcolor = (int)(0x0);
         }
         else if ( subGridtarea_versiontarea_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridtarea_versiontarea_Backstyle = 1;
            if ( ((int)((nGXsfl_103_idx) % (2))) == 0 )
            {
               subGridtarea_versiontarea_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridtarea_versiontarea_Class, "") != 0 )
               {
                  subGridtarea_versiontarea_Linesclass = subGridtarea_versiontarea_Class+"Even";
               }
            }
            else
            {
               subGridtarea_versiontarea_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridtarea_versiontarea_Class, "") != 0 )
               {
                  subGridtarea_versiontarea_Linesclass = subGridtarea_versiontarea_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_9_" + sGXsfl_103_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 104,'',false,'" + sGXsfl_103_idx + "',103)\"";
         ROClassString = "Attribute";
         Gridtarea_versiontareaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVersionTarea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VersionTarea), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A8VersionTarea), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,104);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVersionTarea_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtVersionTarea_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)103,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_9_" + sGXsfl_103_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 105,'',false,'" + sGXsfl_103_idx + "',103)\"";
         ROClassString = "Attribute";
         Gridtarea_versiontareaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFechaVersion_Internalname,context.localUtil.Format(A24FechaVersion, "99/99/99"),context.localUtil.Format( A24FechaVersion, "99/99/99"),TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,105);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtFechaVersion_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtFechaVersion_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)103,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_9_" + sGXsfl_103_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 106,'',false,'" + sGXsfl_103_idx + "',103)\"";
         ROClassString = "Attribute";
         Gridtarea_versiontareaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObservacionesVersion_Internalname,StringUtil.RTrim( A25ObservacionesVersion),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,106);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObservacionesVersion_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtObservacionesVersion_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)103,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_9_" + sGXsfl_103_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 107,'',false,'" + sGXsfl_103_idx + "',103)\"";
         ROClassString = "Attribute";
         Gridtarea_versiontareaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEditor_Internalname,StringUtil.RTrim( A26Editor),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,107);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEditor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtEditor_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)103,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridtarea_versiontareaRow);
         send_integrity_lvl_hashes029( ) ;
         GXCCtl = "Z8VersionTarea_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8VersionTarea), 4, 0, ".", "")));
         GXCCtl = "Z24FechaVersion_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z24FechaVersion, 0, "/"));
         GXCCtl = "Z25ObservacionesVersion_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z25ObservacionesVersion));
         GXCCtl = "Z26Editor_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z26Editor));
         GXCCtl = "nRcdDeleted_9_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_9), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_9_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_9), 4, 0, ".", "")));
         GXCCtl = "nIsMod_9_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_9), 4, 0, ".", "")));
         GXCCtl = "N24FechaVersion_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( A24FechaVersion, 0, "/"));
         GXCCtl = "N25ObservacionesVersion_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( A25ObservacionesVersion));
         GXCCtl = "N26Editor_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( A26Editor));
         GXCCtl = "vMODE_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_103_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vIDTAREA_" + sGXsfl_103_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7IdTarea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "VERSIONTAREA_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtVersionTarea_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FECHAVERSION_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFechaVersion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OBSERVACIONESVERSION_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObservacionesVersion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EDITOR_"+sGXsfl_103_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEditor_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridtarea_versiontareaContainer.AddRow(Gridtarea_versiontareaRow);
      }

      protected void ReadRow029( )
      {
         nGXsfl_103_idx = (int)(nGXsfl_103_idx+1);
         sGXsfl_103_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_103_idx), 4, 0), 4, "0");
         SubsflControlProps_1039( ) ;
         edtVersionTarea_Enabled = (int)(context.localUtil.CToN( cgiGet( "VERSIONTAREA_"+sGXsfl_103_idx+"Enabled"), ".", ","));
         edtFechaVersion_Enabled = (int)(context.localUtil.CToN( cgiGet( "FECHAVERSION_"+sGXsfl_103_idx+"Enabled"), ".", ","));
         edtObservacionesVersion_Enabled = (int)(context.localUtil.CToN( cgiGet( "OBSERVACIONESVERSION_"+sGXsfl_103_idx+"Enabled"), ".", ","));
         edtEditor_Enabled = (int)(context.localUtil.CToN( cgiGet( "EDITOR_"+sGXsfl_103_idx+"Enabled"), ".", ","));
         if ( ( ( context.localUtil.CToN( cgiGet( edtVersionTarea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVersionTarea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "VERSIONTAREA_" + sGXsfl_103_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtVersionTarea_Internalname;
            wbErr = true;
            A8VersionTarea = 0;
         }
         else
         {
            A8VersionTarea = (short)(context.localUtil.CToN( cgiGet( edtVersionTarea_Internalname), ".", ","));
         }
         if ( context.localUtil.VCDate( cgiGet( edtFechaVersion_Internalname), 1) == 0 )
         {
            GXCCtl = "FECHAVERSION_" + sGXsfl_103_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Version"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtFechaVersion_Internalname;
            wbErr = true;
            A24FechaVersion = DateTime.MinValue;
         }
         else
         {
            A24FechaVersion = context.localUtil.CToD( cgiGet( edtFechaVersion_Internalname), 1);
         }
         A25ObservacionesVersion = cgiGet( edtObservacionesVersion_Internalname);
         A26Editor = cgiGet( edtEditor_Internalname);
         GXCCtl = "Z8VersionTarea_" + sGXsfl_103_idx;
         Z8VersionTarea = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z24FechaVersion_" + sGXsfl_103_idx;
         Z24FechaVersion = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         GXCCtl = "Z25ObservacionesVersion_" + sGXsfl_103_idx;
         Z25ObservacionesVersion = cgiGet( GXCCtl);
         GXCCtl = "Z26Editor_" + sGXsfl_103_idx;
         Z26Editor = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_9_" + sGXsfl_103_idx;
         nRcdDeleted_9 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_9_" + sGXsfl_103_idx;
         nRcdExists_9 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_9_" + sGXsfl_103_idx;
         nIsMod_9 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "N24FechaVersion_" + sGXsfl_103_idx;
         N24FechaVersion = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         GXCCtl = "N25ObservacionesVersion_" + sGXsfl_103_idx;
         N25ObservacionesVersion = cgiGet( GXCCtl);
         GXCCtl = "N26Editor_" + sGXsfl_103_idx;
         N26Editor = cgiGet( GXCCtl);
      }

      protected void assign_properties_default( )
      {
         defedtEditor_Enabled = edtEditor_Enabled;
         defedtEditor_Enabled = edtEditor_Enabled;
         defedtObservacionesVersion_Enabled = edtObservacionesVersion_Enabled;
         defedtObservacionesVersion_Enabled = edtObservacionesVersion_Enabled;
         defedtFechaVersion_Enabled = edtFechaVersion_Enabled;
         defedtFechaVersion_Enabled = edtFechaVersion_Enabled;
         defedtVersionTarea_Enabled = edtVersionTarea_Enabled;
      }

      protected void ConfirmValues020( )
      {
         nGXsfl_103_idx = 0;
         sGXsfl_103_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_103_idx), 4, 0), 4, "0");
         SubsflControlProps_1039( ) ;
         while ( nGXsfl_103_idx < nRC_GXsfl_103 )
         {
            nGXsfl_103_idx = (int)(nGXsfl_103_idx+1);
            sGXsfl_103_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_103_idx), 4, 0), 4, "0");
            SubsflControlProps_1039( ) ;
            ChangePostValue( "Z8VersionTarea_"+sGXsfl_103_idx, cgiGet( "ZT_"+"Z8VersionTarea_"+sGXsfl_103_idx)) ;
            DeletePostValue( "ZT_"+"Z8VersionTarea_"+sGXsfl_103_idx) ;
            ChangePostValue( "Z24FechaVersion_"+sGXsfl_103_idx, cgiGet( "ZT_"+"Z24FechaVersion_"+sGXsfl_103_idx)) ;
            DeletePostValue( "ZT_"+"Z24FechaVersion_"+sGXsfl_103_idx) ;
            ChangePostValue( "Z25ObservacionesVersion_"+sGXsfl_103_idx, cgiGet( "ZT_"+"Z25ObservacionesVersion_"+sGXsfl_103_idx)) ;
            DeletePostValue( "ZT_"+"Z25ObservacionesVersion_"+sGXsfl_103_idx) ;
            ChangePostValue( "Z26Editor_"+sGXsfl_103_idx, cgiGet( "ZT_"+"Z26Editor_"+sGXsfl_103_idx)) ;
            DeletePostValue( "ZT_"+"Z26Editor_"+sGXsfl_103_idx) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202082314323099", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("tarea.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7IdTarea)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Tarea");
         forbiddenHiddens.Add("IdTarea", context.localUtil.Format( (decimal)(A5IdTarea), "ZZZ9"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         A23StatusTarea = StringUtil.StrToBool( StringUtil.BoolToStr( A23StatusTarea));
         AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
         forbiddenHiddens.Add("StatusTarea", StringUtil.BoolToStr( A23StatusTarea));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLogInfo("tarea:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z5IdTarea", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5IdTarea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z6NombreTarea", StringUtil.RTrim( Z6NombreTarea));
         GxWebStd.gx_hidden_field( context, "Z7DescripcionTarea", StringUtil.RTrim( Z7DescripcionTarea));
         GxWebStd.gx_boolean_hidden_field( context, "Z23StatusTarea", Z23StatusTarea);
         GxWebStd.gx_hidden_field( context, "Z1IdProyecto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1IdProyecto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z9IdPrioridad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9IdPrioridad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z13IdFase", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13IdFase), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z17IdEstadoTarea", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17IdEstadoTarea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z19IdPadre", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19IdPadre), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_103", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_103_idx), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N1IdProyecto", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1IdProyecto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N19IdPadre", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19IdPadre), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N17IdEstadoTarea", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17IdEstadoTarea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N13IdFase", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13IdFase), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N9IdPrioridad", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9IdPrioridad), 4, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "vIDTAREA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7IdTarea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIDTAREA", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7IdTarea), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_IDPROYECTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_IdProyecto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_IDPADRE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Insert_IdPadre), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_IDESTADOTAREA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Insert_IdEstadoTarea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_IDFASE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_IdFase), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_IDPRIORIDAD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_IdPrioridad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
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
         return formatLink("tarea.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7IdTarea) ;
      }

      public override String GetPgmname( )
      {
         return "Tarea" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tarea" ;
      }

      protected void InitializeNonKey022( )
      {
         A1IdProyecto = 0;
         AssignAttri("", false, "A1IdProyecto", StringUtil.LTrimStr( (decimal)(A1IdProyecto), 4, 0));
         A19IdPadre = 0;
         n19IdPadre = false;
         AssignAttri("", false, "A19IdPadre", StringUtil.LTrimStr( (decimal)(A19IdPadre), 4, 0));
         n19IdPadre = ((0==A19IdPadre) ? true : false);
         A17IdEstadoTarea = 0;
         AssignAttri("", false, "A17IdEstadoTarea", StringUtil.LTrimStr( (decimal)(A17IdEstadoTarea), 4, 0));
         A13IdFase = 0;
         AssignAttri("", false, "A13IdFase", StringUtil.LTrimStr( (decimal)(A13IdFase), 4, 0));
         A9IdPrioridad = 0;
         AssignAttri("", false, "A9IdPrioridad", StringUtil.LTrimStr( (decimal)(A9IdPrioridad), 4, 0));
         A2NombreProyecto = "";
         AssignAttri("", false, "A2NombreProyecto", A2NombreProyecto);
         A6NombreTarea = "";
         AssignAttri("", false, "A6NombreTarea", A6NombreTarea);
         A20NombrePadre = "";
         AssignAttri("", false, "A20NombrePadre", A20NombrePadre);
         A7DescripcionTarea = "";
         AssignAttri("", false, "A7DescripcionTarea", A7DescripcionTarea);
         A18EstadoTarea = "";
         AssignAttri("", false, "A18EstadoTarea", A18EstadoTarea);
         A14Fase = "";
         AssignAttri("", false, "A14Fase", A14Fase);
         A10Prioridad = "";
         AssignAttri("", false, "A10Prioridad", A10Prioridad);
         A23StatusTarea = true;
         AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
         Z6NombreTarea = "";
         Z7DescripcionTarea = "";
         Z23StatusTarea = false;
         Z1IdProyecto = 0;
         Z9IdPrioridad = 0;
         Z13IdFase = 0;
         Z17IdEstadoTarea = 0;
         Z19IdPadre = 0;
      }

      protected void InitAll022( )
      {
         A5IdTarea = 0;
         AssignAttri("", false, "A5IdTarea", StringUtil.LTrimStr( (decimal)(A5IdTarea), 4, 0));
         InitializeNonKey022( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A23StatusTarea = i23StatusTarea;
         AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
      }

      protected void InitializeNonKey029( )
      {
         A24FechaVersion = DateTime.MinValue;
         A25ObservacionesVersion = "";
         A26Editor = "";
         Z24FechaVersion = DateTime.MinValue;
         Z25ObservacionesVersion = "";
         Z26Editor = "";
      }

      protected void InitAll029( )
      {
         A8VersionTarea = 0;
         InitializeNonKey029( ) ;
      }

      protected void StandaloneModalInsert029( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20208231432319", true, true);
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
         context.AddJavascriptSource("tarea.js", "?20208231432319", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties9( )
      {
         edtEditor_Enabled = defedtEditor_Enabled;
         AssignProp("", false, edtEditor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEditor_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtEditor_Enabled = defedtEditor_Enabled;
         AssignProp("", false, edtEditor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEditor_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtObservacionesVersion_Enabled = defedtObservacionesVersion_Enabled;
         AssignProp("", false, edtObservacionesVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtObservacionesVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtObservacionesVersion_Enabled = defedtObservacionesVersion_Enabled;
         AssignProp("", false, edtObservacionesVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtObservacionesVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtFechaVersion_Enabled = defedtFechaVersion_Enabled;
         AssignProp("", false, edtFechaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtFechaVersion_Enabled = defedtFechaVersion_Enabled;
         AssignProp("", false, edtFechaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtFechaVersion_Enabled), 5, 0), !bGXsfl_103_Refreshing);
         edtVersionTarea_Enabled = defedtVersionTarea_Enabled;
         AssignProp("", false, edtVersionTarea_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVersionTarea_Enabled), 5, 0), !bGXsfl_103_Refreshing);
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
         edtIdTarea_Internalname = "IDTAREA";
         edtIdProyecto_Internalname = "IDPROYECTO";
         edtNombreProyecto_Internalname = "NOMBREPROYECTO";
         edtNombreTarea_Internalname = "NOMBRETAREA";
         edtIdPadre_Internalname = "IDPADRE";
         edtNombrePadre_Internalname = "NOMBREPADRE";
         edtDescripcionTarea_Internalname = "DESCRIPCIONTAREA";
         edtIdEstadoTarea_Internalname = "IDESTADOTAREA";
         edtEstadoTarea_Internalname = "ESTADOTAREA";
         edtIdFase_Internalname = "IDFASE";
         edtFase_Internalname = "FASE";
         edtIdPrioridad_Internalname = "IDPRIORIDAD";
         edtPrioridad_Internalname = "PRIORIDAD";
         lblTitleversiontarea_Internalname = "TITLEVERSIONTAREA";
         edtVersionTarea_Internalname = "VERSIONTAREA";
         edtFechaVersion_Internalname = "FECHAVERSION";
         edtObservacionesVersion_Internalname = "OBSERVACIONESVERSION";
         edtEditor_Internalname = "EDITOR";
         divVersiontareatable_Internalname = "VERSIONTAREATABLE";
         chkStatusTarea_Internalname = "STATUSTAREA";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_19_Internalname = "PROMPT_19";
         imgprompt_17_Internalname = "PROMPT_17";
         imgprompt_13_Internalname = "PROMPT_13";
         imgprompt_9_Internalname = "PROMPT_9";
         subGridtarea_versiontarea_Internalname = "GRIDTAREA_VERSIONTAREA";
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
         Form.Caption = "Tarea";
         edtEditor_Jsonclick = "";
         edtObservacionesVersion_Jsonclick = "";
         edtFechaVersion_Jsonclick = "";
         edtVersionTarea_Jsonclick = "";
         subGridtarea_versiontarea_Class = "Grid";
         subGridtarea_versiontarea_Backcolorstyle = 0;
         subGridtarea_versiontarea_Allowcollapsing = 0;
         subGridtarea_versiontarea_Allowselection = 0;
         edtEditor_Enabled = 1;
         edtObservacionesVersion_Enabled = 1;
         edtFechaVersion_Enabled = 1;
         edtVersionTarea_Enabled = 1;
         subGridtarea_versiontarea_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         chkStatusTarea.Enabled = 0;
         edtPrioridad_Jsonclick = "";
         edtPrioridad_Enabled = 0;
         imgprompt_9_Visible = 1;
         imgprompt_9_Link = "";
         edtIdPrioridad_Jsonclick = "";
         edtIdPrioridad_Enabled = 1;
         edtFase_Jsonclick = "";
         edtFase_Enabled = 0;
         imgprompt_13_Visible = 1;
         imgprompt_13_Link = "";
         edtIdFase_Jsonclick = "";
         edtIdFase_Enabled = 1;
         edtEstadoTarea_Jsonclick = "";
         edtEstadoTarea_Enabled = 0;
         imgprompt_17_Visible = 1;
         imgprompt_17_Link = "";
         edtIdEstadoTarea_Jsonclick = "";
         edtIdEstadoTarea_Enabled = 1;
         edtDescripcionTarea_Jsonclick = "";
         edtDescripcionTarea_Enabled = 1;
         edtNombrePadre_Jsonclick = "";
         edtNombrePadre_Enabled = 0;
         imgprompt_19_Visible = 1;
         imgprompt_19_Link = "";
         edtIdPadre_Jsonclick = "";
         edtIdPadre_Enabled = 1;
         edtNombreTarea_Jsonclick = "";
         edtNombreTarea_Enabled = 1;
         edtNombreProyecto_Jsonclick = "";
         edtNombreProyecto_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtIdProyecto_Jsonclick = "";
         edtIdProyecto_Enabled = 1;
         edtIdTarea_Jsonclick = "";
         edtIdTarea_Enabled = 0;
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

      protected void gxnrGridtarea_versiontarea_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_1039( ) ;
         while ( nGXsfl_103_idx <= nRC_GXsfl_103 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal029( ) ;
            standaloneModal029( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow029( ) ;
            nGXsfl_103_idx = (int)(nGXsfl_103_idx+1);
            sGXsfl_103_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_103_idx), 4, 0), 4, "0");
            SubsflControlProps_1039( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridtarea_versiontareaContainer)) ;
         /* End function gxnrGridtarea_versiontarea_newrow */
      }

      protected void init_web_controls( )
      {
         chkStatusTarea.Name = "STATUSTAREA";
         chkStatusTarea.WebTags = "";
         chkStatusTarea.Caption = "";
         AssignProp("", false, chkStatusTarea_Internalname, "TitleCaption", chkStatusTarea.Caption, true);
         chkStatusTarea.CheckedValue = "false";
         if ( (false==A23StatusTarea) )
         {
            A23StatusTarea = true;
            AssignAttri("", false, "A23StatusTarea", A23StatusTarea);
         }
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

      public void Valid_Idproyecto( )
      {
         /* Using cursor T000223 */
         pr_default.execute(21, new Object[] {A1IdProyecto});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("No matching 'Proyecto'.", "ForeignKeyNotFound", 1, "IDPROYECTO");
            AnyError = 1;
            GX_FocusControl = edtIdProyecto_Internalname;
         }
         A2NombreProyecto = T000223_A2NombreProyecto[0];
         pr_default.close(21);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A2NombreProyecto", StringUtil.RTrim( A2NombreProyecto));
      }

      public void Valid_Idpadre( )
      {
         n19IdPadre = false;
         /* Using cursor T000224 */
         pr_default.execute(22, new Object[] {n19IdPadre, A19IdPadre});
         if ( (pr_default.getStatus(22) == 101) )
         {
            if ( ! ( (0==A19IdPadre) ) )
            {
               GX_msglist.addItem("No matching 'Id Padre'.", "ForeignKeyNotFound", 1, "IDPADRE");
               AnyError = 1;
               GX_FocusControl = edtIdPadre_Internalname;
            }
         }
         A20NombrePadre = T000224_A20NombrePadre[0];
         pr_default.close(22);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A20NombrePadre", StringUtil.RTrim( A20NombrePadre));
      }

      public void Valid_Idestadotarea( )
      {
         /* Using cursor T000225 */
         pr_default.execute(23, new Object[] {A17IdEstadoTarea});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No matching 'Estado Tarea'.", "ForeignKeyNotFound", 1, "IDESTADOTAREA");
            AnyError = 1;
            GX_FocusControl = edtIdEstadoTarea_Internalname;
         }
         A18EstadoTarea = T000225_A18EstadoTarea[0];
         pr_default.close(23);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A18EstadoTarea", StringUtil.RTrim( A18EstadoTarea));
      }

      public void Valid_Idfase( )
      {
         /* Using cursor T000226 */
         pr_default.execute(24, new Object[] {A13IdFase});
         if ( (pr_default.getStatus(24) == 101) )
         {
            GX_msglist.addItem("No matching 'Fase'.", "ForeignKeyNotFound", 1, "IDFASE");
            AnyError = 1;
            GX_FocusControl = edtIdFase_Internalname;
         }
         A14Fase = T000226_A14Fase[0];
         pr_default.close(24);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A14Fase", StringUtil.RTrim( A14Fase));
      }

      public void Valid_Idprioridad( )
      {
         /* Using cursor T000227 */
         pr_default.execute(25, new Object[] {A9IdPrioridad});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No matching 'Prioridad'.", "ForeignKeyNotFound", 1, "IDPRIORIDAD");
            AnyError = 1;
            GX_FocusControl = edtIdPrioridad_Internalname;
         }
         A10Prioridad = T000227_A10Prioridad[0];
         pr_default.close(25);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A10Prioridad", StringUtil.RTrim( A10Prioridad));
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7IdTarea',fld:'vIDTAREA',pic:'ZZZ9',hsh:true},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7IdTarea',fld:'vIDTAREA',pic:'ZZZ9',hsh:true},{av:'A5IdTarea',fld:'IDTAREA',pic:'ZZZ9'},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("AFTER TRN","{handler:'E12022',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_IDTAREA","{handler:'Valid_Idtarea',iparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_IDTAREA",",oparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_IDPROYECTO","{handler:'Valid_Idproyecto',iparms:[{av:'A1IdProyecto',fld:'IDPROYECTO',pic:'ZZZ9'},{av:'A2NombreProyecto',fld:'NOMBREPROYECTO',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_IDPROYECTO",",oparms:[{av:'A2NombreProyecto',fld:'NOMBREPROYECTO',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_IDPADRE","{handler:'Valid_Idpadre',iparms:[{av:'A19IdPadre',fld:'IDPADRE',pic:'ZZZ9'},{av:'A20NombrePadre',fld:'NOMBREPADRE',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_IDPADRE",",oparms:[{av:'A20NombrePadre',fld:'NOMBREPADRE',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_IDESTADOTAREA","{handler:'Valid_Idestadotarea',iparms:[{av:'A17IdEstadoTarea',fld:'IDESTADOTAREA',pic:'ZZZ9'},{av:'A18EstadoTarea',fld:'ESTADOTAREA',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_IDESTADOTAREA",",oparms:[{av:'A18EstadoTarea',fld:'ESTADOTAREA',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_IDFASE","{handler:'Valid_Idfase',iparms:[{av:'A13IdFase',fld:'IDFASE',pic:'ZZZ9'},{av:'A14Fase',fld:'FASE',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_IDFASE",",oparms:[{av:'A14Fase',fld:'FASE',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_IDPRIORIDAD","{handler:'Valid_Idprioridad',iparms:[{av:'A9IdPrioridad',fld:'IDPRIORIDAD',pic:'ZZZ9'},{av:'A10Prioridad',fld:'PRIORIDAD',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_IDPRIORIDAD",",oparms:[{av:'A10Prioridad',fld:'PRIORIDAD',pic:''},{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_VERSIONTAREA","{handler:'Valid_Versiontarea',iparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_VERSIONTAREA",",oparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_FECHAVERSION","{handler:'Valid_Fechaversion',iparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_FECHAVERSION",",oparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_OBSERVACIONESVERSION","{handler:'Valid_Observacionesversion',iparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_OBSERVACIONESVERSION",",oparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
         setEventMetadata("VALID_EDITOR","{handler:'Valid_Editor',iparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]");
         setEventMetadata("VALID_EDITOR",",oparms:[{av:'A23StatusTarea',fld:'STATUSTAREA',pic:''}]}");
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
         pr_default.close(3);
         pr_default.close(21);
         pr_default.close(25);
         pr_default.close(24);
         pr_default.close(23);
         pr_default.close(22);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z6NombreTarea = "";
         Z7DescripcionTarea = "";
         Z24FechaVersion = DateTime.MinValue;
         Z25ObservacionesVersion = "";
         Z26Editor = "";
         N24FechaVersion = DateTime.MinValue;
         N25ObservacionesVersion = "";
         N26Editor = "";
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
         sImgUrl = "";
         A2NombreProyecto = "";
         A6NombreTarea = "";
         A20NombrePadre = "";
         A7DescripcionTarea = "";
         A18EstadoTarea = "";
         A14Fase = "";
         A10Prioridad = "";
         lblTitleversiontarea_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridtarea_versiontareaContainer = new GXWebGrid( context);
         Gridtarea_versiontareaColumn = new GXWebColumn();
         A24FechaVersion = DateTime.MinValue;
         A25ObservacionesVersion = "";
         A26Editor = "";
         sMode9 = "";
         sStyleString = "";
         AV17Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode2 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z2NombreProyecto = "";
         Z20NombrePadre = "";
         Z18EstadoTarea = "";
         Z14Fase = "";
         Z10Prioridad = "";
         T00027_A10Prioridad = new String[] {""} ;
         T00028_A14Fase = new String[] {""} ;
         T00029_A18EstadoTarea = new String[] {""} ;
         T000210_A20NombrePadre = new String[] {""} ;
         T00026_A2NombreProyecto = new String[] {""} ;
         T000211_A5IdTarea = new short[1] ;
         T000211_A2NombreProyecto = new String[] {""} ;
         T000211_A6NombreTarea = new String[] {""} ;
         T000211_A20NombrePadre = new String[] {""} ;
         T000211_A7DescripcionTarea = new String[] {""} ;
         T000211_A18EstadoTarea = new String[] {""} ;
         T000211_A14Fase = new String[] {""} ;
         T000211_A10Prioridad = new String[] {""} ;
         T000211_A23StatusTarea = new bool[] {false} ;
         T000211_A1IdProyecto = new short[1] ;
         T000211_A9IdPrioridad = new short[1] ;
         T000211_A13IdFase = new short[1] ;
         T000211_A17IdEstadoTarea = new short[1] ;
         T000211_A19IdPadre = new short[1] ;
         T000211_n19IdPadre = new bool[] {false} ;
         T000212_A2NombreProyecto = new String[] {""} ;
         T000213_A20NombrePadre = new String[] {""} ;
         T000214_A18EstadoTarea = new String[] {""} ;
         T000215_A14Fase = new String[] {""} ;
         T000216_A10Prioridad = new String[] {""} ;
         T000217_A5IdTarea = new short[1] ;
         T00025_A5IdTarea = new short[1] ;
         T00025_A6NombreTarea = new String[] {""} ;
         T00025_A7DescripcionTarea = new String[] {""} ;
         T00025_A23StatusTarea = new bool[] {false} ;
         T00025_A1IdProyecto = new short[1] ;
         T00025_A9IdPrioridad = new short[1] ;
         T00025_A13IdFase = new short[1] ;
         T00025_A17IdEstadoTarea = new short[1] ;
         T00025_A19IdPadre = new short[1] ;
         T00025_n19IdPadre = new bool[] {false} ;
         T000218_A5IdTarea = new short[1] ;
         T000219_A5IdTarea = new short[1] ;
         T00024_A5IdTarea = new short[1] ;
         T00024_A6NombreTarea = new String[] {""} ;
         T00024_A7DescripcionTarea = new String[] {""} ;
         T00024_A23StatusTarea = new bool[] {false} ;
         T00024_A1IdProyecto = new short[1] ;
         T00024_A9IdPrioridad = new short[1] ;
         T00024_A13IdFase = new short[1] ;
         T00024_A17IdEstadoTarea = new short[1] ;
         T00024_A19IdPadre = new short[1] ;
         T00024_n19IdPadre = new bool[] {false} ;
         T000220_A5IdTarea = new short[1] ;
         T000223_A2NombreProyecto = new String[] {""} ;
         T000224_A20NombrePadre = new String[] {""} ;
         T000225_A18EstadoTarea = new String[] {""} ;
         T000226_A14Fase = new String[] {""} ;
         T000227_A10Prioridad = new String[] {""} ;
         T000228_A19IdPadre = new short[1] ;
         T000228_n19IdPadre = new bool[] {false} ;
         T000229_A21IdLineaBase = new short[1] ;
         T000229_A5IdTarea = new short[1] ;
         T000230_A5IdTarea = new short[1] ;
         T000231_A5IdTarea = new short[1] ;
         T000231_A8VersionTarea = new short[1] ;
         T000231_A24FechaVersion = new DateTime[] {DateTime.MinValue} ;
         T000231_A25ObservacionesVersion = new String[] {""} ;
         T000231_A26Editor = new String[] {""} ;
         T000232_A5IdTarea = new short[1] ;
         T000232_A8VersionTarea = new short[1] ;
         T00023_A5IdTarea = new short[1] ;
         T00023_A8VersionTarea = new short[1] ;
         T00023_A24FechaVersion = new DateTime[] {DateTime.MinValue} ;
         T00023_A25ObservacionesVersion = new String[] {""} ;
         T00023_A26Editor = new String[] {""} ;
         T00022_A5IdTarea = new short[1] ;
         T00022_A8VersionTarea = new short[1] ;
         T00022_A24FechaVersion = new DateTime[] {DateTime.MinValue} ;
         T00022_A25ObservacionesVersion = new String[] {""} ;
         T00022_A26Editor = new String[] {""} ;
         T000236_A5IdTarea = new short[1] ;
         T000236_A8VersionTarea = new short[1] ;
         Gridtarea_versiontareaRow = new GXWebRow();
         subGridtarea_versiontarea_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.tarea__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tarea__default(),
            new Object[][] {
                new Object[] {
               T00022_A5IdTarea, T00022_A8VersionTarea, T00022_A24FechaVersion, T00022_A25ObservacionesVersion, T00022_A26Editor
               }
               , new Object[] {
               T00023_A5IdTarea, T00023_A8VersionTarea, T00023_A24FechaVersion, T00023_A25ObservacionesVersion, T00023_A26Editor
               }
               , new Object[] {
               T00024_A5IdTarea, T00024_A6NombreTarea, T00024_A7DescripcionTarea, T00024_A23StatusTarea, T00024_A1IdProyecto, T00024_A9IdPrioridad, T00024_A13IdFase, T00024_A17IdEstadoTarea, T00024_A19IdPadre, T00024_n19IdPadre
               }
               , new Object[] {
               T00025_A5IdTarea, T00025_A6NombreTarea, T00025_A7DescripcionTarea, T00025_A23StatusTarea, T00025_A1IdProyecto, T00025_A9IdPrioridad, T00025_A13IdFase, T00025_A17IdEstadoTarea, T00025_A19IdPadre, T00025_n19IdPadre
               }
               , new Object[] {
               T00026_A2NombreProyecto
               }
               , new Object[] {
               T00027_A10Prioridad
               }
               , new Object[] {
               T00028_A14Fase
               }
               , new Object[] {
               T00029_A18EstadoTarea
               }
               , new Object[] {
               T000210_A20NombrePadre
               }
               , new Object[] {
               T000211_A5IdTarea, T000211_A2NombreProyecto, T000211_A6NombreTarea, T000211_A20NombrePadre, T000211_A7DescripcionTarea, T000211_A18EstadoTarea, T000211_A14Fase, T000211_A10Prioridad, T000211_A23StatusTarea, T000211_A1IdProyecto,
               T000211_A9IdPrioridad, T000211_A13IdFase, T000211_A17IdEstadoTarea, T000211_A19IdPadre, T000211_n19IdPadre
               }
               , new Object[] {
               T000212_A2NombreProyecto
               }
               , new Object[] {
               T000213_A20NombrePadre
               }
               , new Object[] {
               T000214_A18EstadoTarea
               }
               , new Object[] {
               T000215_A14Fase
               }
               , new Object[] {
               T000216_A10Prioridad
               }
               , new Object[] {
               T000217_A5IdTarea
               }
               , new Object[] {
               T000218_A5IdTarea
               }
               , new Object[] {
               T000219_A5IdTarea
               }
               , new Object[] {
               T000220_A5IdTarea
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000223_A2NombreProyecto
               }
               , new Object[] {
               T000224_A20NombrePadre
               }
               , new Object[] {
               T000225_A18EstadoTarea
               }
               , new Object[] {
               T000226_A14Fase
               }
               , new Object[] {
               T000227_A10Prioridad
               }
               , new Object[] {
               T000228_A19IdPadre
               }
               , new Object[] {
               T000229_A21IdLineaBase, T000229_A5IdTarea
               }
               , new Object[] {
               T000230_A5IdTarea
               }
               , new Object[] {
               T000231_A5IdTarea, T000231_A8VersionTarea, T000231_A24FechaVersion, T000231_A25ObservacionesVersion, T000231_A26Editor
               }
               , new Object[] {
               T000232_A5IdTarea, T000232_A8VersionTarea
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000236_A5IdTarea, T000236_A8VersionTarea
               }
            }
         );
         Z23StatusTarea = true;
         A23StatusTarea = true;
         i23StatusTarea = true;
         AV17Pgmname = "Tarea";
      }

      private short wcpOAV7IdTarea ;
      private short Z5IdTarea ;
      private short Z1IdProyecto ;
      private short Z9IdPrioridad ;
      private short Z13IdFase ;
      private short Z17IdEstadoTarea ;
      private short Z19IdPadre ;
      private short N1IdProyecto ;
      private short N19IdPadre ;
      private short N17IdEstadoTarea ;
      private short N13IdFase ;
      private short N9IdPrioridad ;
      private short Z8VersionTarea ;
      private short nRcdDeleted_9 ;
      private short nRcdExists_9 ;
      private short nIsMod_9 ;
      private short GxWebError ;
      private short A1IdProyecto ;
      private short A19IdPadre ;
      private short A17IdEstadoTarea ;
      private short A13IdFase ;
      private short A9IdPrioridad ;
      private short AV7IdTarea ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A5IdTarea ;
      private short subGridtarea_versiontarea_Backcolorstyle ;
      private short A8VersionTarea ;
      private short subGridtarea_versiontarea_Allowselection ;
      private short subGridtarea_versiontarea_Allowhovering ;
      private short subGridtarea_versiontarea_Allowcollapsing ;
      private short subGridtarea_versiontarea_Collapsed ;
      private short nBlankRcdCount9 ;
      private short RcdFound9 ;
      private short nBlankRcdUsr9 ;
      private short AV11Insert_IdProyecto ;
      private short AV16Insert_IdPadre ;
      private short AV15Insert_IdEstadoTarea ;
      private short AV12Insert_IdFase ;
      private short AV13Insert_IdPrioridad ;
      private short Gx_BScreen ;
      private short RcdFound2 ;
      private short GX_JID ;
      private short nIsDirty_2 ;
      private short nIsDirty_9 ;
      private short subGridtarea_versiontarea_Backstyle ;
      private short gxajaxcallmode ;
      private int nRC_GXsfl_103 ;
      private int nGXsfl_103_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtIdTarea_Enabled ;
      private int edtIdProyecto_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtNombreProyecto_Enabled ;
      private int edtNombreTarea_Enabled ;
      private int edtIdPadre_Enabled ;
      private int imgprompt_19_Visible ;
      private int edtNombrePadre_Enabled ;
      private int edtDescripcionTarea_Enabled ;
      private int edtIdEstadoTarea_Enabled ;
      private int imgprompt_17_Visible ;
      private int edtEstadoTarea_Enabled ;
      private int edtIdFase_Enabled ;
      private int imgprompt_13_Visible ;
      private int edtFase_Enabled ;
      private int edtIdPrioridad_Enabled ;
      private int imgprompt_9_Visible ;
      private int edtPrioridad_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtVersionTarea_Enabled ;
      private int edtFechaVersion_Enabled ;
      private int edtObservacionesVersion_Enabled ;
      private int edtEditor_Enabled ;
      private int subGridtarea_versiontarea_Selectedindex ;
      private int subGridtarea_versiontarea_Selectioncolor ;
      private int subGridtarea_versiontarea_Hoveringcolor ;
      private int fRowAdded ;
      private int AV18GXV1 ;
      private int subGridtarea_versiontarea_Backcolor ;
      private int subGridtarea_versiontarea_Allbackcolor ;
      private int defedtEditor_Enabled ;
      private int defedtObservacionesVersion_Enabled ;
      private int defedtFechaVersion_Enabled ;
      private int defedtVersionTarea_Enabled ;
      private int idxLst ;
      private long GRIDTAREA_VERSIONTAREA_nFirstRecordOnPage ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z6NombreTarea ;
      private String Z7DescripcionTarea ;
      private String Z25ObservacionesVersion ;
      private String Z26Editor ;
      private String N25ObservacionesVersion ;
      private String N26Editor ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_103_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtIdProyecto_Internalname ;
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
      private String edtIdTarea_Internalname ;
      private String edtIdTarea_Jsonclick ;
      private String edtIdProyecto_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtNombreProyecto_Internalname ;
      private String A2NombreProyecto ;
      private String edtNombreProyecto_Jsonclick ;
      private String edtNombreTarea_Internalname ;
      private String A6NombreTarea ;
      private String edtNombreTarea_Jsonclick ;
      private String edtIdPadre_Internalname ;
      private String edtIdPadre_Jsonclick ;
      private String imgprompt_19_Internalname ;
      private String imgprompt_19_Link ;
      private String edtNombrePadre_Internalname ;
      private String A20NombrePadre ;
      private String edtNombrePadre_Jsonclick ;
      private String edtDescripcionTarea_Internalname ;
      private String A7DescripcionTarea ;
      private String edtDescripcionTarea_Jsonclick ;
      private String edtIdEstadoTarea_Internalname ;
      private String edtIdEstadoTarea_Jsonclick ;
      private String imgprompt_17_Internalname ;
      private String imgprompt_17_Link ;
      private String edtEstadoTarea_Internalname ;
      private String A18EstadoTarea ;
      private String edtEstadoTarea_Jsonclick ;
      private String edtIdFase_Internalname ;
      private String edtIdFase_Jsonclick ;
      private String imgprompt_13_Internalname ;
      private String imgprompt_13_Link ;
      private String edtFase_Internalname ;
      private String A14Fase ;
      private String edtFase_Jsonclick ;
      private String edtIdPrioridad_Internalname ;
      private String edtIdPrioridad_Jsonclick ;
      private String imgprompt_9_Internalname ;
      private String imgprompt_9_Link ;
      private String edtPrioridad_Internalname ;
      private String A10Prioridad ;
      private String edtPrioridad_Jsonclick ;
      private String divVersiontareatable_Internalname ;
      private String lblTitleversiontarea_Internalname ;
      private String lblTitleversiontarea_Jsonclick ;
      private String chkStatusTarea_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridtarea_versiontarea_Header ;
      private String A25ObservacionesVersion ;
      private String A26Editor ;
      private String sMode9 ;
      private String edtVersionTarea_Internalname ;
      private String edtFechaVersion_Internalname ;
      private String edtObservacionesVersion_Internalname ;
      private String edtEditor_Internalname ;
      private String sStyleString ;
      private String AV17Pgmname ;
      private String hsh ;
      private String sMode2 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z2NombreProyecto ;
      private String Z20NombrePadre ;
      private String Z18EstadoTarea ;
      private String Z14Fase ;
      private String Z10Prioridad ;
      private String sGXsfl_103_fel_idx="0001" ;
      private String subGridtarea_versiontarea_Class ;
      private String subGridtarea_versiontarea_Linesclass ;
      private String ROClassString ;
      private String edtVersionTarea_Jsonclick ;
      private String edtFechaVersion_Jsonclick ;
      private String edtObservacionesVersion_Jsonclick ;
      private String edtEditor_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridtarea_versiontarea_Internalname ;
      private DateTime Z24FechaVersion ;
      private DateTime N24FechaVersion ;
      private DateTime A24FechaVersion ;
      private bool Z23StatusTarea ;
      private bool entryPointCalled ;
      private bool n19IdPadre ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A23StatusTarea ;
      private bool bGXsfl_103_Refreshing=false ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool i23StatusTarea ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private GXWebGrid Gridtarea_versiontareaContainer ;
      private GXWebRow Gridtarea_versiontareaRow ;
      private GXWebColumn Gridtarea_versiontareaColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkStatusTarea ;
      private IDataStoreProvider pr_default ;
      private String[] T00027_A10Prioridad ;
      private String[] T00028_A14Fase ;
      private String[] T00029_A18EstadoTarea ;
      private String[] T000210_A20NombrePadre ;
      private String[] T00026_A2NombreProyecto ;
      private short[] T000211_A5IdTarea ;
      private String[] T000211_A2NombreProyecto ;
      private String[] T000211_A6NombreTarea ;
      private String[] T000211_A20NombrePadre ;
      private String[] T000211_A7DescripcionTarea ;
      private String[] T000211_A18EstadoTarea ;
      private String[] T000211_A14Fase ;
      private String[] T000211_A10Prioridad ;
      private bool[] T000211_A23StatusTarea ;
      private short[] T000211_A1IdProyecto ;
      private short[] T000211_A9IdPrioridad ;
      private short[] T000211_A13IdFase ;
      private short[] T000211_A17IdEstadoTarea ;
      private short[] T000211_A19IdPadre ;
      private bool[] T000211_n19IdPadre ;
      private String[] T000212_A2NombreProyecto ;
      private String[] T000213_A20NombrePadre ;
      private String[] T000214_A18EstadoTarea ;
      private String[] T000215_A14Fase ;
      private String[] T000216_A10Prioridad ;
      private short[] T000217_A5IdTarea ;
      private short[] T00025_A5IdTarea ;
      private String[] T00025_A6NombreTarea ;
      private String[] T00025_A7DescripcionTarea ;
      private bool[] T00025_A23StatusTarea ;
      private short[] T00025_A1IdProyecto ;
      private short[] T00025_A9IdPrioridad ;
      private short[] T00025_A13IdFase ;
      private short[] T00025_A17IdEstadoTarea ;
      private short[] T00025_A19IdPadre ;
      private bool[] T00025_n19IdPadre ;
      private short[] T000218_A5IdTarea ;
      private short[] T000219_A5IdTarea ;
      private short[] T00024_A5IdTarea ;
      private String[] T00024_A6NombreTarea ;
      private String[] T00024_A7DescripcionTarea ;
      private bool[] T00024_A23StatusTarea ;
      private short[] T00024_A1IdProyecto ;
      private short[] T00024_A9IdPrioridad ;
      private short[] T00024_A13IdFase ;
      private short[] T00024_A17IdEstadoTarea ;
      private short[] T00024_A19IdPadre ;
      private bool[] T00024_n19IdPadre ;
      private short[] T000220_A5IdTarea ;
      private String[] T000223_A2NombreProyecto ;
      private String[] T000224_A20NombrePadre ;
      private String[] T000225_A18EstadoTarea ;
      private String[] T000226_A14Fase ;
      private String[] T000227_A10Prioridad ;
      private short[] T000228_A19IdPadre ;
      private bool[] T000228_n19IdPadre ;
      private short[] T000229_A21IdLineaBase ;
      private short[] T000229_A5IdTarea ;
      private short[] T000230_A5IdTarea ;
      private short[] T000231_A5IdTarea ;
      private short[] T000231_A8VersionTarea ;
      private DateTime[] T000231_A24FechaVersion ;
      private String[] T000231_A25ObservacionesVersion ;
      private String[] T000231_A26Editor ;
      private short[] T000232_A5IdTarea ;
      private short[] T000232_A8VersionTarea ;
      private short[] T00023_A5IdTarea ;
      private short[] T00023_A8VersionTarea ;
      private DateTime[] T00023_A24FechaVersion ;
      private String[] T00023_A25ObservacionesVersion ;
      private String[] T00023_A26Editor ;
      private short[] T00022_A5IdTarea ;
      private short[] T00022_A8VersionTarea ;
      private DateTime[] T00022_A24FechaVersion ;
      private String[] T00022_A25ObservacionesVersion ;
      private String[] T00022_A26Editor ;
      private short[] T000236_A5IdTarea ;
      private short[] T000236_A8VersionTarea ;
      private IDataStoreProvider pr_gam ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class tarea__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class tarea__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
       ,new ForEachCursor(def[16])
       ,new ForEachCursor(def[17])
       ,new ForEachCursor(def[18])
       ,new UpdateCursor(def[19])
       ,new UpdateCursor(def[20])
       ,new ForEachCursor(def[21])
       ,new ForEachCursor(def[22])
       ,new ForEachCursor(def[23])
       ,new ForEachCursor(def[24])
       ,new ForEachCursor(def[25])
       ,new ForEachCursor(def[26])
       ,new ForEachCursor(def[27])
       ,new ForEachCursor(def[28])
       ,new ForEachCursor(def[29])
       ,new ForEachCursor(def[30])
       ,new UpdateCursor(def[31])
       ,new UpdateCursor(def[32])
       ,new UpdateCursor(def[33])
       ,new ForEachCursor(def[34])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000211 ;
        prmT000211 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00026 ;
        prmT00026 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000210 ;
        prmT000210 = new Object[] {
        new Object[] {"@IdPadre",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00029 ;
        prmT00029 = new Object[] {
        new Object[] {"@IdEstadoTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00028 ;
        prmT00028 = new Object[] {
        new Object[] {"@IdFase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00027 ;
        prmT00027 = new Object[] {
        new Object[] {"@IdPrioridad",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000212 ;
        prmT000212 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000213 ;
        prmT000213 = new Object[] {
        new Object[] {"@IdPadre",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000214 ;
        prmT000214 = new Object[] {
        new Object[] {"@IdEstadoTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000215 ;
        prmT000215 = new Object[] {
        new Object[] {"@IdFase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000216 ;
        prmT000216 = new Object[] {
        new Object[] {"@IdPrioridad",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000217 ;
        prmT000217 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00025 ;
        prmT00025 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000218 ;
        prmT000218 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000219 ;
        prmT000219 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00024 ;
        prmT00024 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000220 ;
        prmT000220 = new Object[] {
        new Object[] {"@NombreTarea",SqlDbType.NChar,60,0} ,
        new Object[] {"@DescripcionTarea",SqlDbType.NChar,60,0} ,
        new Object[] {"@StatusTarea",SqlDbType.Bit,4,0} ,
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdPrioridad",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdFase",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdEstadoTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdPadre",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000221 ;
        prmT000221 = new Object[] {
        new Object[] {"@NombreTarea",SqlDbType.NChar,60,0} ,
        new Object[] {"@DescripcionTarea",SqlDbType.NChar,60,0} ,
        new Object[] {"@StatusTarea",SqlDbType.Bit,4,0} ,
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdPrioridad",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdFase",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdEstadoTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdPadre",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000222 ;
        prmT000222 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000228 ;
        prmT000228 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000229 ;
        prmT000229 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000230 ;
        prmT000230 = new Object[] {
        } ;
        Object[] prmT000231 ;
        prmT000231 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@VersionTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000232 ;
        prmT000232 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@VersionTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00023 ;
        prmT00023 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@VersionTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00022 ;
        prmT00022 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@VersionTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000233 ;
        prmT000233 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@VersionTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@FechaVersion",SqlDbType.DateTime,8,0} ,
        new Object[] {"@ObservacionesVersion",SqlDbType.NChar,60,0} ,
        new Object[] {"@Editor",SqlDbType.NChar,20,0}
        } ;
        Object[] prmT000234 ;
        prmT000234 = new Object[] {
        new Object[] {"@FechaVersion",SqlDbType.DateTime,8,0} ,
        new Object[] {"@ObservacionesVersion",SqlDbType.NChar,60,0} ,
        new Object[] {"@Editor",SqlDbType.NChar,20,0} ,
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@VersionTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000235 ;
        prmT000235 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@VersionTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000236 ;
        prmT000236 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000223 ;
        prmT000223 = new Object[] {
        new Object[] {"@IdProyecto",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000224 ;
        prmT000224 = new Object[] {
        new Object[] {"@IdPadre",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000225 ;
        prmT000225 = new Object[] {
        new Object[] {"@IdEstadoTarea",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000226 ;
        prmT000226 = new Object[] {
        new Object[] {"@IdFase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000227 ;
        prmT000227 = new Object[] {
        new Object[] {"@IdPrioridad",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00022", "SELECT [IdTarea], [VersionTarea], [FechaVersion], [ObservacionesVersion], [Editor] FROM [TareaVersionTarea] WITH (UPDLOCK) WHERE [IdTarea] = @IdTarea AND [VersionTarea] = @VersionTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00023", "SELECT [IdTarea], [VersionTarea], [FechaVersion], [ObservacionesVersion], [Editor] FROM [TareaVersionTarea] WHERE [IdTarea] = @IdTarea AND [VersionTarea] = @VersionTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00024", "SELECT [IdTarea], [NombreTarea], [DescripcionTarea], [StatusTarea], [IdProyecto], [IdPrioridad], [IdFase], [IdEstadoTarea], [IdPadre] AS IdPadre FROM [Tarea] WITH (UPDLOCK) WHERE [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00025", "SELECT [IdTarea], [NombreTarea], [DescripcionTarea], [StatusTarea], [IdProyecto], [IdPrioridad], [IdFase], [IdEstadoTarea], [IdPadre] AS IdPadre FROM [Tarea] WHERE [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00026", "SELECT [NombreProyecto] FROM [Proyecto] WHERE [IdProyecto] = @IdProyecto ",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00027", "SELECT [Prioridad] FROM [Prioridad] WHERE [IdPrioridad] = @IdPrioridad ",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00028", "SELECT [Fase] FROM [Fase] WHERE [IdFase] = @IdFase ",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00029", "SELECT [EstadoTarea] FROM [EstadoTarea] WHERE [IdEstadoTarea] = @IdEstadoTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000210", "SELECT [NombreTarea] AS NombrePadre FROM [Tarea] WHERE [IdTarea] = @IdPadre ",true, GxErrorMask.GX_NOMASK, false, this,prmT000210,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000211", "SELECT TM1.[IdTarea], T2.[NombreProyecto], TM1.[NombreTarea], T3.[NombreTarea] AS NombrePadre, TM1.[DescripcionTarea], T4.[EstadoTarea], T5.[Fase], T6.[Prioridad], TM1.[StatusTarea], TM1.[IdProyecto], TM1.[IdPrioridad], TM1.[IdFase], TM1.[IdEstadoTarea], TM1.[IdPadre] AS IdPadre FROM ((((([Tarea] TM1 INNER JOIN [Proyecto] T2 ON T2.[IdProyecto] = TM1.[IdProyecto]) LEFT JOIN [Tarea] T3 ON T3.[IdTarea] = TM1.[IdPadre]) INNER JOIN [EstadoTarea] T4 ON T4.[IdEstadoTarea] = TM1.[IdEstadoTarea]) INNER JOIN [Fase] T5 ON T5.[IdFase] = TM1.[IdFase]) INNER JOIN [Prioridad] T6 ON T6.[IdPrioridad] = TM1.[IdPrioridad]) WHERE TM1.[IdTarea] = @IdTarea ORDER BY TM1.[IdTarea]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000211,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000212", "SELECT [NombreProyecto] FROM [Proyecto] WHERE [IdProyecto] = @IdProyecto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000212,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000213", "SELECT [NombreTarea] AS NombrePadre FROM [Tarea] WHERE [IdTarea] = @IdPadre ",true, GxErrorMask.GX_NOMASK, false, this,prmT000213,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000214", "SELECT [EstadoTarea] FROM [EstadoTarea] WHERE [IdEstadoTarea] = @IdEstadoTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000214,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000215", "SELECT [Fase] FROM [Fase] WHERE [IdFase] = @IdFase ",true, GxErrorMask.GX_NOMASK, false, this,prmT000215,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000216", "SELECT [Prioridad] FROM [Prioridad] WHERE [IdPrioridad] = @IdPrioridad ",true, GxErrorMask.GX_NOMASK, false, this,prmT000216,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000217", "SELECT [IdTarea] FROM [Tarea] WHERE [IdTarea] = @IdTarea  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000217,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000218", "SELECT TOP 1 [IdTarea] FROM [Tarea] WHERE ( [IdTarea] > @IdTarea) ORDER BY [IdTarea]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000218,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000219", "SELECT TOP 1 [IdTarea] FROM [Tarea] WHERE ( [IdTarea] < @IdTarea) ORDER BY [IdTarea] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000219,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000220", "INSERT INTO [Tarea]([NombreTarea], [DescripcionTarea], [StatusTarea], [IdProyecto], [IdPrioridad], [IdFase], [IdEstadoTarea], [IdPadre]) VALUES(@NombreTarea, @DescripcionTarea, @StatusTarea, @IdProyecto, @IdPrioridad, @IdFase, @IdEstadoTarea, @IdPadre); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000220)
           ,new CursorDef("T000221", "UPDATE [Tarea] SET [NombreTarea]=@NombreTarea, [DescripcionTarea]=@DescripcionTarea, [StatusTarea]=@StatusTarea, [IdProyecto]=@IdProyecto, [IdPrioridad]=@IdPrioridad, [IdFase]=@IdFase, [IdEstadoTarea]=@IdEstadoTarea, [IdPadre]=@IdPadre  WHERE [IdTarea] = @IdTarea", GxErrorMask.GX_NOMASK,prmT000221)
           ,new CursorDef("T000222", "DELETE FROM [Tarea]  WHERE [IdTarea] = @IdTarea", GxErrorMask.GX_NOMASK,prmT000222)
           ,new CursorDef("T000223", "SELECT [NombreProyecto] FROM [Proyecto] WHERE [IdProyecto] = @IdProyecto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000223,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000224", "SELECT [NombreTarea] AS NombrePadre FROM [Tarea] WHERE [IdTarea] = @IdPadre ",true, GxErrorMask.GX_NOMASK, false, this,prmT000224,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000225", "SELECT [EstadoTarea] FROM [EstadoTarea] WHERE [IdEstadoTarea] = @IdEstadoTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000225,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000226", "SELECT [Fase] FROM [Fase] WHERE [IdFase] = @IdFase ",true, GxErrorMask.GX_NOMASK, false, this,prmT000226,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000227", "SELECT [Prioridad] FROM [Prioridad] WHERE [IdPrioridad] = @IdPrioridad ",true, GxErrorMask.GX_NOMASK, false, this,prmT000227,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000228", "SELECT TOP 1 [IdTarea] AS IdPadre FROM [Tarea] WHERE [IdPadre] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000228,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000229", "SELECT TOP 1 [IdLineaBase], [IdTarea] FROM [TareasLB] WHERE [IdTarea] = @IdTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000229,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000230", "SELECT [IdTarea] FROM [Tarea] ORDER BY [IdTarea]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000230,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000231", "SELECT [IdTarea], [VersionTarea], [FechaVersion], [ObservacionesVersion], [Editor] FROM [TareaVersionTarea] WHERE [IdTarea] = @IdTarea and [VersionTarea] = @VersionTarea ORDER BY [IdTarea], [VersionTarea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000231,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000232", "SELECT [IdTarea], [VersionTarea] FROM [TareaVersionTarea] WHERE [IdTarea] = @IdTarea AND [VersionTarea] = @VersionTarea ",true, GxErrorMask.GX_NOMASK, false, this,prmT000232,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000233", "INSERT INTO [TareaVersionTarea]([IdTarea], [VersionTarea], [FechaVersion], [ObservacionesVersion], [Editor]) VALUES(@IdTarea, @VersionTarea, @FechaVersion, @ObservacionesVersion, @Editor)", GxErrorMask.GX_NOMASK,prmT000233)
           ,new CursorDef("T000234", "UPDATE [TareaVersionTarea] SET [FechaVersion]=@FechaVersion, [ObservacionesVersion]=@ObservacionesVersion, [Editor]=@Editor  WHERE [IdTarea] = @IdTarea AND [VersionTarea] = @VersionTarea", GxErrorMask.GX_NOMASK,prmT000234)
           ,new CursorDef("T000235", "DELETE FROM [TareaVersionTarea]  WHERE [IdTarea] = @IdTarea AND [VersionTarea] = @VersionTarea", GxErrorMask.GX_NOMASK,prmT000235)
           ,new CursorDef("T000236", "SELECT [IdTarea], [VersionTarea] FROM [TareaVersionTarea] WHERE [IdTarea] = @IdTarea ORDER BY [IdTarea], [VersionTarea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000236,100, GxCacheFrequency.OFF ,true,false )
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
              ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 60) ;
              ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 60) ;
              ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
              return;
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
              ((bool[]) buf[3])[0] = rslt.getBool(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((short[]) buf[6])[0] = rslt.getShort(7) ;
              ((short[]) buf[7])[0] = rslt.getShort(8) ;
              ((short[]) buf[8])[0] = rslt.getShort(9) ;
              ((bool[]) buf[9])[0] = rslt.wasNull(9);
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
              ((bool[]) buf[3])[0] = rslt.getBool(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((short[]) buf[6])[0] = rslt.getShort(7) ;
              ((short[]) buf[7])[0] = rslt.getShort(8) ;
              ((short[]) buf[8])[0] = rslt.getShort(9) ;
              ((bool[]) buf[9])[0] = rslt.wasNull(9);
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 7 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 9 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 60) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 60) ;
              ((String[]) buf[4])[0] = rslt.getString(5, 60) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
              ((String[]) buf[6])[0] = rslt.getString(7, 20) ;
              ((String[]) buf[7])[0] = rslt.getString(8, 20) ;
              ((bool[]) buf[8])[0] = rslt.getBool(9) ;
              ((short[]) buf[9])[0] = rslt.getShort(10) ;
              ((short[]) buf[10])[0] = rslt.getShort(11) ;
              ((short[]) buf[11])[0] = rslt.getShort(12) ;
              ((short[]) buf[12])[0] = rslt.getShort(13) ;
              ((short[]) buf[13])[0] = rslt.getShort(14) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(14);
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 11 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 12 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 13 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 15 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 16 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 17 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 18 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 21 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 22 :
              ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
              return;
           case 23 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 24 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 25 :
              ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
              return;
           case 26 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 27 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 28 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 29 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 60) ;
              ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
              return;
     }
     getresults30( cursor, rslt, buf) ;
  }

  public void getresults30( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
  {
     switch ( cursor )
     {
           case 30 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 34 :
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(1, (short)parms[1]);
              }
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 11 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(1, (short)parms[1]);
              }
              return;
           case 12 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 15 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 16 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 17 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 18 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (bool)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (short)parms[4]);
              stmt.SetParameter(6, (short)parms[5]);
              stmt.SetParameter(7, (short)parms[6]);
              if ( (bool)parms[7] )
              {
                 stmt.setNull( 8 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(8, (short)parms[8]);
              }
              return;
           case 19 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (bool)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (short)parms[4]);
              stmt.SetParameter(6, (short)parms[5]);
              stmt.SetParameter(7, (short)parms[6]);
              if ( (bool)parms[7] )
              {
                 stmt.setNull( 8 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(8, (short)parms[8]);
              }
              stmt.SetParameter(9, (short)parms[9]);
              return;
           case 20 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 21 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 22 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(1, (short)parms[1]);
              }
              return;
           case 23 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 24 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 25 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 26 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 27 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 29 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
     }
     setparameters30( cursor, stmt, parms) ;
  }

  public void setparameters30( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
  {
     switch ( cursor )
     {
           case 30 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 31 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              stmt.SetParameter(3, (DateTime)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              return;
           case 32 :
              stmt.SetParameter(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (short)parms[4]);
              return;
           case 33 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 34 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
     }
  }

}

}
