/*
               File: Menu
        Description: Menu
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/25/2020 23:18:40.82
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
   public class menu : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7MenuXid = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7MenuXid", StringUtil.LTrimStr( (decimal)(AV7MenuXid), 4, 0));
               GxWebStd.gx_hidden_field( context, "gxhash_vMENUXID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7MenuXid), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Menu", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtMenuXDesc_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public menu( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public menu( IGxContext context )
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
                           short aP1_MenuXid )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7MenuXid = aP1_MenuXid;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbMenXEst = new GXCombobox();
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
         if ( cmbMenXEst.ItemCount > 0 )
         {
            A31MenXEst = cmbMenXEst.getValidValue(A31MenXEst);
            n31MenXEst = false;
            AssignAttri("", false, "A31MenXEst", A31MenXEst);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbMenXEst.CurrentValue = StringUtil.RTrim( A31MenXEst);
            AssignProp("", false, cmbMenXEst_Internalname, "Values", cmbMenXEst.ToJavascriptSource(), true);
         }
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Menu", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Menu.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Menu.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMenuXid_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtMenuXid_Internalname, "Xid", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtMenuXid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27MenuXid), 4, 0, ".", "")), ((edtMenuXid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A27MenuXid), "ZZZ9")) : context.localUtil.Format( (decimal)(A27MenuXid), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenuXid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenuXid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMenuXDesc_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtMenuXDesc_Internalname, "XDesc", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtMenuXDesc_Internalname, A28MenuXDesc, StringUtil.RTrim( context.localUtil.Format( A28MenuXDesc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenuXDesc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenuXDesc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMenuXPosi_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtMenuXPosi_Internalname, "Position", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtMenuXPosi_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A29MenuXPosi), 4, 0, ".", "")), ((edtMenuXPosi_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A29MenuXPosi), "ZZZ9")) : context.localUtil.Format( (decimal)(A29MenuXPosi), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenuXPosi_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenuXPosi_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMenXUrl_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtMenXUrl_Internalname, "Url", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtMenXUrl_Internalname, A30MenXUrl, StringUtil.RTrim( context.localUtil.Format( A30MenXUrl, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenXUrl_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenXUrl_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbMenXEst_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, cmbMenXEst_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         /* ComboBox */
         GxWebStd.gx_combobox_ctrl1( context, cmbMenXEst, cmbMenXEst_Internalname, StringUtil.RTrim( A31MenXEst), 1, cmbMenXEst_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbMenXEst.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "", true, "HLP_Menu.htm");
         cmbMenXEst.CurrentValue = StringUtil.RTrim( A31MenXEst);
         AssignProp("", false, cmbMenXEst_Internalname, "Values", (String)(cmbMenXEst.ToJavascriptSource()), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMenXPadre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtMenXPadre_Internalname, "XPadre", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtMenXPadre_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A43MenXPadre), 4, 0, ".", "")), ((edtMenXPadre_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A43MenXPadre), "ZZZ9")) : context.localUtil.Format( (decimal)(A43MenXPadre), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenXPadre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenXPadre_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Menu.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
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
         E11082 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z27MenuXid = (short)(context.localUtil.CToN( cgiGet( "Z27MenuXid"), ".", ","));
               Z28MenuXDesc = cgiGet( "Z28MenuXDesc");
               n28MenuXDesc = (String.IsNullOrEmpty(StringUtil.RTrim( A28MenuXDesc)) ? true : false);
               Z29MenuXPosi = (short)(context.localUtil.CToN( cgiGet( "Z29MenuXPosi"), ".", ","));
               n29MenuXPosi = ((0==A29MenuXPosi) ? true : false);
               Z30MenXUrl = cgiGet( "Z30MenXUrl");
               n30MenXUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A30MenXUrl)) ? true : false);
               Z31MenXEst = cgiGet( "Z31MenXEst");
               n31MenXEst = (String.IsNullOrEmpty(StringUtil.RTrim( A31MenXEst)) ? true : false);
               Z43MenXPadre = (short)(context.localUtil.CToN( cgiGet( "Z43MenXPadre"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7MenuXid = (short)(context.localUtil.CToN( cgiGet( "vMENUXID"), ".", ","));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               AV11Pgmname = cgiGet( "vPGMNAME");
               /* Read variables values. */
               A27MenuXid = (short)(context.localUtil.CToN( cgiGet( edtMenuXid_Internalname), ".", ","));
               AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
               A28MenuXDesc = cgiGet( edtMenuXDesc_Internalname);
               n28MenuXDesc = false;
               AssignAttri("", false, "A28MenuXDesc", A28MenuXDesc);
               n28MenuXDesc = (String.IsNullOrEmpty(StringUtil.RTrim( A28MenuXDesc)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtMenuXPosi_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMenuXPosi_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MENUXPOSI");
                  AnyError = 1;
                  GX_FocusControl = edtMenuXPosi_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A29MenuXPosi = 0;
                  n29MenuXPosi = false;
                  AssignAttri("", false, "A29MenuXPosi", StringUtil.LTrimStr( (decimal)(A29MenuXPosi), 4, 0));
               }
               else
               {
                  A29MenuXPosi = (short)(context.localUtil.CToN( cgiGet( edtMenuXPosi_Internalname), ".", ","));
                  n29MenuXPosi = false;
                  AssignAttri("", false, "A29MenuXPosi", StringUtil.LTrimStr( (decimal)(A29MenuXPosi), 4, 0));
               }
               n29MenuXPosi = ((0==A29MenuXPosi) ? true : false);
               A30MenXUrl = cgiGet( edtMenXUrl_Internalname);
               n30MenXUrl = false;
               AssignAttri("", false, "A30MenXUrl", A30MenXUrl);
               n30MenXUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A30MenXUrl)) ? true : false);
               cmbMenXEst.CurrentValue = cgiGet( cmbMenXEst_Internalname);
               A31MenXEst = cgiGet( cmbMenXEst_Internalname);
               n31MenXEst = false;
               AssignAttri("", false, "A31MenXEst", A31MenXEst);
               n31MenXEst = (String.IsNullOrEmpty(StringUtil.RTrim( A31MenXEst)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtMenXPadre_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMenXPadre_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MENXPADRE");
                  AnyError = 1;
                  GX_FocusControl = edtMenXPadre_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A43MenXPadre = 0;
                  AssignAttri("", false, "A43MenXPadre", StringUtil.LTrimStr( (decimal)(A43MenXPadre), 4, 0));
               }
               else
               {
                  A43MenXPadre = (short)(context.localUtil.CToN( cgiGet( edtMenXPadre_Internalname), ".", ","));
                  AssignAttri("", false, "A43MenXPadre", StringUtil.LTrimStr( (decimal)(A43MenXPadre), 4, 0));
               }
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Menu");
               A27MenuXid = (short)(context.localUtil.CToN( cgiGet( edtMenuXid_Internalname), ".", ","));
               AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
               forbiddenHiddens.Add("MenuXid", context.localUtil.Format( (decimal)(A27MenuXid), "ZZZ9"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A27MenuXid != Z27MenuXid ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLogError("menu:[ SecurityCheckFailed (403 Forbidden) value for]"+forbiddenHiddens.ToJSonString());
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
                  A27MenuXid = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
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
                     sMode10 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode10;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound10 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_080( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "MENUXID");
                        AnyError = 1;
                        GX_FocusControl = edtMenuXid_Internalname;
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
                           E11082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12082 ();
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
            E12082 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll0810( ) ;
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
            DisableAttributes0810( ) ;
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

      protected void CONFIRM_080( )
      {
         BeforeValidate0810( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls0810( ) ;
            }
            else
            {
               CheckExtendedTable0810( ) ;
               CloseExtendedTableCursors0810( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         }
      }

      protected void ResetCaption080( )
      {
      }

      protected void E11082( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "SGCS");
      }

      protected void E12082( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwmenu.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0810( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z28MenuXDesc = T00083_A28MenuXDesc[0];
               Z29MenuXPosi = T00083_A29MenuXPosi[0];
               Z30MenXUrl = T00083_A30MenXUrl[0];
               Z31MenXEst = T00083_A31MenXEst[0];
               Z43MenXPadre = T00083_A43MenXPadre[0];
            }
            else
            {
               Z28MenuXDesc = A28MenuXDesc;
               Z29MenuXPosi = A29MenuXPosi;
               Z30MenXUrl = A30MenXUrl;
               Z31MenXEst = A31MenXEst;
               Z43MenXPadre = A43MenXPadre;
            }
         }
         if ( GX_JID == -5 )
         {
            Z27MenuXid = A27MenuXid;
            Z28MenuXDesc = A28MenuXDesc;
            Z29MenuXPosi = A29MenuXPosi;
            Z30MenXUrl = A30MenXUrl;
            Z31MenXEst = A31MenXEst;
            Z43MenXPadre = A43MenXPadre;
         }
      }

      protected void standaloneNotModal( )
      {
         edtMenuXid_Enabled = 0;
         AssignProp("", false, edtMenuXid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtMenuXid_Enabled), 5, 0), true);
         Gx_BScreen = 0;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         edtMenuXid_Enabled = 0;
         AssignProp("", false, edtMenuXid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtMenuXid_Enabled), 5, 0), true);
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7MenuXid) )
         {
            A27MenuXid = AV7MenuXid;
            AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
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
         if ( IsIns( )  && (0==A43MenXPadre) && ( Gx_BScreen == 0 ) )
         {
            A43MenXPadre = 0;
            AssignAttri("", false, "A43MenXPadre", StringUtil.LTrimStr( (decimal)(A43MenXPadre), 4, 0));
         }
      }

      protected void Load0810( )
      {
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A27MenuXid});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound10 = 1;
            A28MenuXDesc = T00084_A28MenuXDesc[0];
            n28MenuXDesc = T00084_n28MenuXDesc[0];
            AssignAttri("", false, "A28MenuXDesc", A28MenuXDesc);
            A29MenuXPosi = T00084_A29MenuXPosi[0];
            n29MenuXPosi = T00084_n29MenuXPosi[0];
            AssignAttri("", false, "A29MenuXPosi", StringUtil.LTrimStr( (decimal)(A29MenuXPosi), 4, 0));
            A30MenXUrl = T00084_A30MenXUrl[0];
            n30MenXUrl = T00084_n30MenXUrl[0];
            AssignAttri("", false, "A30MenXUrl", A30MenXUrl);
            A31MenXEst = T00084_A31MenXEst[0];
            n31MenXEst = T00084_n31MenXEst[0];
            AssignAttri("", false, "A31MenXEst", A31MenXEst);
            A43MenXPadre = T00084_A43MenXPadre[0];
            AssignAttri("", false, "A43MenXPadre", StringUtil.LTrimStr( (decimal)(A43MenXPadre), 4, 0));
            ZM0810( -5) ;
         }
         pr_default.close(2);
         OnLoadActions0810( ) ;
      }

      protected void OnLoadActions0810( )
      {
         AV11Pgmname = "Menu";
         AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable0810( )
      {
         nIsDirty_10 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV11Pgmname = "Menu";
         AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
         if ( ! ( ( StringUtil.StrCmp(A31MenXEst, "A") == 0 ) || ( StringUtil.StrCmp(A31MenXEst, "I") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A31MenXEst)) ) )
         {
            GX_msglist.addItem("Field Estado is out of range", "OutOfRange", 1, "MENXEST");
            AnyError = 1;
            GX_FocusControl = cmbMenXEst_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0810( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0810( )
      {
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {A27MenuXid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound10 = 1;
         }
         else
         {
            RcdFound10 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A27MenuXid});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0810( 5) ;
            RcdFound10 = 1;
            A27MenuXid = T00083_A27MenuXid[0];
            AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
            A28MenuXDesc = T00083_A28MenuXDesc[0];
            n28MenuXDesc = T00083_n28MenuXDesc[0];
            AssignAttri("", false, "A28MenuXDesc", A28MenuXDesc);
            A29MenuXPosi = T00083_A29MenuXPosi[0];
            n29MenuXPosi = T00083_n29MenuXPosi[0];
            AssignAttri("", false, "A29MenuXPosi", StringUtil.LTrimStr( (decimal)(A29MenuXPosi), 4, 0));
            A30MenXUrl = T00083_A30MenXUrl[0];
            n30MenXUrl = T00083_n30MenXUrl[0];
            AssignAttri("", false, "A30MenXUrl", A30MenXUrl);
            A31MenXEst = T00083_A31MenXEst[0];
            n31MenXEst = T00083_n31MenXEst[0];
            AssignAttri("", false, "A31MenXEst", A31MenXEst);
            A43MenXPadre = T00083_A43MenXPadre[0];
            AssignAttri("", false, "A43MenXPadre", StringUtil.LTrimStr( (decimal)(A43MenXPadre), 4, 0));
            Z27MenuXid = A27MenuXid;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            Load0810( ) ;
            if ( AnyError == 1 )
            {
               RcdFound10 = 0;
               InitializeNonKey0810( ) ;
            }
            Gx_mode = sMode10;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound10 = 0;
            InitializeNonKey0810( ) ;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode10;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0810( ) ;
         if ( RcdFound10 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound10 = 0;
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A27MenuXid});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00086_A27MenuXid[0] < A27MenuXid ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00086_A27MenuXid[0] > A27MenuXid ) ) )
            {
               A27MenuXid = T00086_A27MenuXid[0];
               AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
               RcdFound10 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0;
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A27MenuXid});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00087_A27MenuXid[0] > A27MenuXid ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00087_A27MenuXid[0] < A27MenuXid ) ) )
            {
               A27MenuXid = T00087_A27MenuXid[0];
               AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
               RcdFound10 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0810( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtMenuXDesc_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0810( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound10 == 1 )
            {
               if ( A27MenuXid != Z27MenuXid )
               {
                  A27MenuXid = Z27MenuXid;
                  AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "MENUXID");
                  AnyError = 1;
                  GX_FocusControl = edtMenuXid_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtMenuXDesc_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0810( ) ;
                  GX_FocusControl = edtMenuXDesc_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A27MenuXid != Z27MenuXid )
               {
                  /* Insert record */
                  GX_FocusControl = edtMenuXDesc_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0810( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "MENUXID");
                     AnyError = 1;
                     GX_FocusControl = edtMenuXid_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtMenuXDesc_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0810( ) ;
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
         if ( A27MenuXid != Z27MenuXid )
         {
            A27MenuXid = Z27MenuXid;
            AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "MENUXID");
            AnyError = 1;
            GX_FocusControl = edtMenuXid_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtMenuXDesc_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0810( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00082 */
            pr_default.execute(0, new Object[] {A27MenuXid});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Menu"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z28MenuXDesc, T00082_A28MenuXDesc[0]) != 0 ) || ( Z29MenuXPosi != T00082_A29MenuXPosi[0] ) || ( StringUtil.StrCmp(Z30MenXUrl, T00082_A30MenXUrl[0]) != 0 ) || ( StringUtil.StrCmp(Z31MenXEst, T00082_A31MenXEst[0]) != 0 ) || ( Z43MenXPadre != T00082_A43MenXPadre[0] ) )
            {
               if ( StringUtil.StrCmp(Z28MenuXDesc, T00082_A28MenuXDesc[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"MenuXDesc");
                  GXUtil.WriteLogRaw("Old: ",Z28MenuXDesc);
                  GXUtil.WriteLogRaw("Current: ",T00082_A28MenuXDesc[0]);
               }
               if ( Z29MenuXPosi != T00082_A29MenuXPosi[0] )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"MenuXPosi");
                  GXUtil.WriteLogRaw("Old: ",Z29MenuXPosi);
                  GXUtil.WriteLogRaw("Current: ",T00082_A29MenuXPosi[0]);
               }
               if ( StringUtil.StrCmp(Z30MenXUrl, T00082_A30MenXUrl[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"MenXUrl");
                  GXUtil.WriteLogRaw("Old: ",Z30MenXUrl);
                  GXUtil.WriteLogRaw("Current: ",T00082_A30MenXUrl[0]);
               }
               if ( StringUtil.StrCmp(Z31MenXEst, T00082_A31MenXEst[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"MenXEst");
                  GXUtil.WriteLogRaw("Old: ",Z31MenXEst);
                  GXUtil.WriteLogRaw("Current: ",T00082_A31MenXEst[0]);
               }
               if ( Z43MenXPadre != T00082_A43MenXPadre[0] )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"MenXPadre");
                  GXUtil.WriteLogRaw("Old: ",Z43MenXPadre);
                  GXUtil.WriteLogRaw("Current: ",T00082_A43MenXPadre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Menu"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0810( )
      {
         BeforeValidate0810( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0810( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0810( 0) ;
            CheckOptimisticConcurrency0810( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0810( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0810( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00088 */
                     pr_default.execute(6, new Object[] {n28MenuXDesc, A28MenuXDesc, n29MenuXPosi, A29MenuXPosi, n30MenXUrl, A30MenXUrl, n31MenXEst, A31MenXEst, A43MenXPadre});
                     A27MenuXid = T00088_A27MenuXid[0];
                     AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Menu") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption080( ) ;
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
               Load0810( ) ;
            }
            EndLevel0810( ) ;
         }
         CloseExtendedTableCursors0810( ) ;
      }

      protected void Update0810( )
      {
         BeforeValidate0810( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0810( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0810( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0810( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0810( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00089 */
                     pr_default.execute(7, new Object[] {n28MenuXDesc, A28MenuXDesc, n29MenuXPosi, A29MenuXPosi, n30MenXUrl, A30MenXUrl, n31MenXEst, A31MenXEst, A43MenXPadre, A27MenuXid});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Menu") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Menu"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0810( ) ;
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
            EndLevel0810( ) ;
         }
         CloseExtendedTableCursors0810( ) ;
      }

      protected void DeferredUpdate0810( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0810( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0810( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0810( ) ;
            AfterConfirm0810( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0810( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000810 */
                  pr_default.execute(8, new Object[] {A27MenuXid});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Menu") ;
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
         sMode10 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel0810( ) ;
         Gx_mode = sMode10;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0810( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Menu";
            AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void EndLevel0810( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0810( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("menu",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("menu",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0810( )
      {
         /* Scan By routine */
         /* Using cursor T000811 */
         pr_default.execute(9);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound10 = 1;
            A27MenuXid = T000811_A27MenuXid[0];
            AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0810( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound10 = 1;
            A27MenuXid = T000811_A27MenuXid[0];
            AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
         }
      }

      protected void ScanEnd0810( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0810( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0810( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0810( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0810( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0810( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0810( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0810( )
      {
         edtMenuXid_Enabled = 0;
         AssignProp("", false, edtMenuXid_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtMenuXid_Enabled), 5, 0), true);
         edtMenuXDesc_Enabled = 0;
         AssignProp("", false, edtMenuXDesc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtMenuXDesc_Enabled), 5, 0), true);
         edtMenuXPosi_Enabled = 0;
         AssignProp("", false, edtMenuXPosi_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtMenuXPosi_Enabled), 5, 0), true);
         edtMenXUrl_Enabled = 0;
         AssignProp("", false, edtMenXUrl_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtMenXUrl_Enabled), 5, 0), true);
         cmbMenXEst.Enabled = 0;
         AssignProp("", false, cmbMenXEst_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbMenXEst.Enabled), 5, 0), true);
         edtMenXPadre_Enabled = 0;
         AssignProp("", false, edtMenXPadre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtMenXPadre_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes0810( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues080( )
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
         context.AddJavascriptSource("gxcfg.js", "?202082523184116", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("menu.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7MenuXid)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Menu");
         forbiddenHiddens.Add("MenuXid", context.localUtil.Format( (decimal)(A27MenuXid), "ZZZ9"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLogInfo("menu:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z27MenuXid", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27MenuXid), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z28MenuXDesc", Z28MenuXDesc);
         GxWebStd.gx_hidden_field( context, "Z29MenuXPosi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29MenuXPosi), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z30MenXUrl", Z30MenXUrl);
         GxWebStd.gx_hidden_field( context, "Z31MenXEst", StringUtil.RTrim( Z31MenXEst));
         GxWebStd.gx_hidden_field( context, "Z43MenXPadre", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z43MenXPadre), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
         GxWebStd.gx_hidden_field( context, "vMENUXID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7MenuXid), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vMENUXID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7MenuXid), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
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
         return formatLink("menu.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7MenuXid) ;
      }

      public override String GetPgmname( )
      {
         return "Menu" ;
      }

      public override String GetPgmdesc( )
      {
         return "Menu" ;
      }

      protected void InitializeNonKey0810( )
      {
         A28MenuXDesc = "";
         n28MenuXDesc = false;
         AssignAttri("", false, "A28MenuXDesc", A28MenuXDesc);
         n28MenuXDesc = (String.IsNullOrEmpty(StringUtil.RTrim( A28MenuXDesc)) ? true : false);
         A29MenuXPosi = 0;
         n29MenuXPosi = false;
         AssignAttri("", false, "A29MenuXPosi", StringUtil.LTrimStr( (decimal)(A29MenuXPosi), 4, 0));
         n29MenuXPosi = ((0==A29MenuXPosi) ? true : false);
         A30MenXUrl = "";
         n30MenXUrl = false;
         AssignAttri("", false, "A30MenXUrl", A30MenXUrl);
         n30MenXUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A30MenXUrl)) ? true : false);
         A31MenXEst = "";
         n31MenXEst = false;
         AssignAttri("", false, "A31MenXEst", A31MenXEst);
         n31MenXEst = (String.IsNullOrEmpty(StringUtil.RTrim( A31MenXEst)) ? true : false);
         A43MenXPadre = 0;
         AssignAttri("", false, "A43MenXPadre", StringUtil.LTrimStr( (decimal)(A43MenXPadre), 4, 0));
         Z28MenuXDesc = "";
         Z29MenuXPosi = 0;
         Z30MenXUrl = "";
         Z31MenXEst = "";
         Z43MenXPadre = 0;
      }

      protected void InitAll0810( )
      {
         A27MenuXid = 0;
         AssignAttri("", false, "A27MenuXid", StringUtil.LTrimStr( (decimal)(A27MenuXid), 4, 0));
         InitializeNonKey0810( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A43MenXPadre = i43MenXPadre;
         AssignAttri("", false, "A43MenXPadre", StringUtil.LTrimStr( (decimal)(A43MenXPadre), 4, 0));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202082523184120", true, true);
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
         context.AddJavascriptSource("menu.js", "?202082523184120", false, true);
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
         edtMenuXid_Internalname = "MENUXID";
         edtMenuXDesc_Internalname = "MENUXDESC";
         edtMenuXPosi_Internalname = "MENUXPOSI";
         edtMenXUrl_Internalname = "MENXURL";
         cmbMenXEst_Internalname = "MENXEST";
         edtMenXPadre_Internalname = "MENXPADRE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Menu";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtMenXPadre_Jsonclick = "";
         edtMenXPadre_Enabled = 1;
         cmbMenXEst_Jsonclick = "";
         cmbMenXEst.Enabled = 1;
         edtMenXUrl_Jsonclick = "";
         edtMenXUrl_Enabled = 1;
         edtMenuXPosi_Jsonclick = "";
         edtMenuXPosi_Enabled = 1;
         edtMenuXDesc_Jsonclick = "";
         edtMenuXDesc_Enabled = 1;
         edtMenuXid_Jsonclick = "";
         edtMenuXid_Enabled = 0;
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
         cmbMenXEst.Name = "MENXEST";
         cmbMenXEst.WebTags = "";
         cmbMenXEst.addItem("A", "ACTIVO", 0);
         cmbMenXEst.addItem("I", "INACTIVO", 0);
         if ( cmbMenXEst.ItemCount > 0 )
         {
            A31MenXEst = cmbMenXEst.getValidValue(A31MenXEst);
            n31MenXEst = false;
            AssignAttri("", false, "A31MenXEst", A31MenXEst);
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

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7MenuXid',fld:'vMENUXID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7MenuXid',fld:'vMENUXID',pic:'ZZZ9',hsh:true},{av:'A27MenuXid',fld:'MENUXID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12082',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_MENUXID","{handler:'Valid_Menuxid',iparms:[]");
         setEventMetadata("VALID_MENUXID",",oparms:[]}");
         setEventMetadata("VALID_MENXEST","{handler:'Valid_Menxest',iparms:[]");
         setEventMetadata("VALID_MENXEST",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z28MenuXDesc = "";
         Z30MenXUrl = "";
         Z31MenXEst = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A31MenXEst = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A28MenuXDesc = "";
         A30MenXUrl = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV11Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode10 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00084_A27MenuXid = new short[1] ;
         T00084_A28MenuXDesc = new String[] {""} ;
         T00084_n28MenuXDesc = new bool[] {false} ;
         T00084_A29MenuXPosi = new short[1] ;
         T00084_n29MenuXPosi = new bool[] {false} ;
         T00084_A30MenXUrl = new String[] {""} ;
         T00084_n30MenXUrl = new bool[] {false} ;
         T00084_A31MenXEst = new String[] {""} ;
         T00084_n31MenXEst = new bool[] {false} ;
         T00084_A43MenXPadre = new short[1] ;
         T00085_A27MenuXid = new short[1] ;
         T00083_A27MenuXid = new short[1] ;
         T00083_A28MenuXDesc = new String[] {""} ;
         T00083_n28MenuXDesc = new bool[] {false} ;
         T00083_A29MenuXPosi = new short[1] ;
         T00083_n29MenuXPosi = new bool[] {false} ;
         T00083_A30MenXUrl = new String[] {""} ;
         T00083_n30MenXUrl = new bool[] {false} ;
         T00083_A31MenXEst = new String[] {""} ;
         T00083_n31MenXEst = new bool[] {false} ;
         T00083_A43MenXPadre = new short[1] ;
         T00086_A27MenuXid = new short[1] ;
         T00087_A27MenuXid = new short[1] ;
         T00082_A27MenuXid = new short[1] ;
         T00082_A28MenuXDesc = new String[] {""} ;
         T00082_n28MenuXDesc = new bool[] {false} ;
         T00082_A29MenuXPosi = new short[1] ;
         T00082_n29MenuXPosi = new bool[] {false} ;
         T00082_A30MenXUrl = new String[] {""} ;
         T00082_n30MenXUrl = new bool[] {false} ;
         T00082_A31MenXEst = new String[] {""} ;
         T00082_n31MenXEst = new bool[] {false} ;
         T00082_A43MenXPadre = new short[1] ;
         T00088_A27MenuXid = new short[1] ;
         T000811_A27MenuXid = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.menu__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.menu__default(),
            new Object[][] {
                new Object[] {
               T00082_A27MenuXid, T00082_A28MenuXDesc, T00082_n28MenuXDesc, T00082_A29MenuXPosi, T00082_n29MenuXPosi, T00082_A30MenXUrl, T00082_n30MenXUrl, T00082_A31MenXEst, T00082_n31MenXEst, T00082_A43MenXPadre
               }
               , new Object[] {
               T00083_A27MenuXid, T00083_A28MenuXDesc, T00083_n28MenuXDesc, T00083_A29MenuXPosi, T00083_n29MenuXPosi, T00083_A30MenXUrl, T00083_n30MenXUrl, T00083_A31MenXEst, T00083_n31MenXEst, T00083_A43MenXPadre
               }
               , new Object[] {
               T00084_A27MenuXid, T00084_A28MenuXDesc, T00084_n28MenuXDesc, T00084_A29MenuXPosi, T00084_n29MenuXPosi, T00084_A30MenXUrl, T00084_n30MenXUrl, T00084_A31MenXEst, T00084_n31MenXEst, T00084_A43MenXPadre
               }
               , new Object[] {
               T00085_A27MenuXid
               }
               , new Object[] {
               T00086_A27MenuXid
               }
               , new Object[] {
               T00087_A27MenuXid
               }
               , new Object[] {
               T00088_A27MenuXid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000811_A27MenuXid
               }
            }
         );
         Z43MenXPadre = 0;
         A43MenXPadre = 0;
         i43MenXPadre = 0;
         AV11Pgmname = "Menu";
      }

      private short wcpOAV7MenuXid ;
      private short Z27MenuXid ;
      private short Z29MenuXPosi ;
      private short Z43MenXPadre ;
      private short GxWebError ;
      private short AV7MenuXid ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A27MenuXid ;
      private short A29MenuXPosi ;
      private short A43MenXPadre ;
      private short Gx_BScreen ;
      private short RcdFound10 ;
      private short GX_JID ;
      private short nIsDirty_10 ;
      private short gxajaxcallmode ;
      private short i43MenXPadre ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtMenuXid_Enabled ;
      private int edtMenuXDesc_Enabled ;
      private int edtMenuXPosi_Enabled ;
      private int edtMenXUrl_Enabled ;
      private int edtMenXPadre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z31MenXEst ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtMenuXDesc_Internalname ;
      private String A31MenXEst ;
      private String cmbMenXEst_Internalname ;
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
      private String edtMenuXid_Internalname ;
      private String edtMenuXid_Jsonclick ;
      private String edtMenuXDesc_Jsonclick ;
      private String edtMenuXPosi_Internalname ;
      private String edtMenuXPosi_Jsonclick ;
      private String edtMenXUrl_Internalname ;
      private String edtMenXUrl_Jsonclick ;
      private String cmbMenXEst_Jsonclick ;
      private String edtMenXPadre_Internalname ;
      private String edtMenXPadre_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV11Pgmname ;
      private String hsh ;
      private String sMode10 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n31MenXEst ;
      private bool n28MenuXDesc ;
      private bool n29MenuXPosi ;
      private bool n30MenXUrl ;
      private bool returnInSub ;
      private String Z28MenuXDesc ;
      private String Z30MenXUrl ;
      private String A28MenuXDesc ;
      private String A30MenXUrl ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbMenXEst ;
      private IDataStoreProvider pr_default ;
      private short[] T00084_A27MenuXid ;
      private String[] T00084_A28MenuXDesc ;
      private bool[] T00084_n28MenuXDesc ;
      private short[] T00084_A29MenuXPosi ;
      private bool[] T00084_n29MenuXPosi ;
      private String[] T00084_A30MenXUrl ;
      private bool[] T00084_n30MenXUrl ;
      private String[] T00084_A31MenXEst ;
      private bool[] T00084_n31MenXEst ;
      private short[] T00084_A43MenXPadre ;
      private short[] T00085_A27MenuXid ;
      private short[] T00083_A27MenuXid ;
      private String[] T00083_A28MenuXDesc ;
      private bool[] T00083_n28MenuXDesc ;
      private short[] T00083_A29MenuXPosi ;
      private bool[] T00083_n29MenuXPosi ;
      private String[] T00083_A30MenXUrl ;
      private bool[] T00083_n30MenXUrl ;
      private String[] T00083_A31MenXEst ;
      private bool[] T00083_n31MenXEst ;
      private short[] T00083_A43MenXPadre ;
      private short[] T00086_A27MenuXid ;
      private short[] T00087_A27MenuXid ;
      private short[] T00082_A27MenuXid ;
      private String[] T00082_A28MenuXDesc ;
      private bool[] T00082_n28MenuXDesc ;
      private short[] T00082_A29MenuXPosi ;
      private bool[] T00082_n29MenuXPosi ;
      private String[] T00082_A30MenXUrl ;
      private bool[] T00082_n30MenXUrl ;
      private String[] T00082_A31MenXEst ;
      private bool[] T00082_n31MenXEst ;
      private short[] T00082_A43MenXPadre ;
      private short[] T00088_A27MenuXid ;
      private short[] T000811_A27MenuXid ;
      private IDataStoreProvider pr_gam ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class menu__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class menu__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00084 ;
        prmT00084 = new Object[] {
        new Object[] {"@MenuXid",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00085 ;
        prmT00085 = new Object[] {
        new Object[] {"@MenuXid",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00083 ;
        prmT00083 = new Object[] {
        new Object[] {"@MenuXid",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00086 ;
        prmT00086 = new Object[] {
        new Object[] {"@MenuXid",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00087 ;
        prmT00087 = new Object[] {
        new Object[] {"@MenuXid",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00082 ;
        prmT00082 = new Object[] {
        new Object[] {"@MenuXid",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00088 ;
        prmT00088 = new Object[] {
        new Object[] {"@MenuXDesc",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@MenuXPosi",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@MenXUrl",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@MenXEst",SqlDbType.NChar,1,0} ,
        new Object[] {"@MenXPadre",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00089 ;
        prmT00089 = new Object[] {
        new Object[] {"@MenuXDesc",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@MenuXPosi",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@MenXUrl",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@MenXEst",SqlDbType.NChar,1,0} ,
        new Object[] {"@MenXPadre",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@MenuXid",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000810 ;
        prmT000810 = new Object[] {
        new Object[] {"@MenuXid",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000811 ;
        prmT000811 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T00082", "SELECT [MenuXid], [MenuXDesc], [MenuXPosi], [MenXUrl], [MenXEst], [MenXPadre] FROM [Menu] WITH (UPDLOCK) WHERE [MenuXid] = @MenuXid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00083", "SELECT [MenuXid], [MenuXDesc], [MenuXPosi], [MenXUrl], [MenXEst], [MenXPadre] FROM [Menu] WHERE [MenuXid] = @MenuXid ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00084", "SELECT TM1.[MenuXid], TM1.[MenuXDesc], TM1.[MenuXPosi], TM1.[MenXUrl], TM1.[MenXEst], TM1.[MenXPadre] FROM [Menu] TM1 WHERE TM1.[MenuXid] = @MenuXid ORDER BY TM1.[MenuXid]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00085", "SELECT [MenuXid] FROM [Menu] WHERE [MenuXid] = @MenuXid  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00086", "SELECT TOP 1 [MenuXid] FROM [Menu] WHERE ( [MenuXid] > @MenuXid) ORDER BY [MenuXid]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T00087", "SELECT TOP 1 [MenuXid] FROM [Menu] WHERE ( [MenuXid] < @MenuXid) ORDER BY [MenuXid] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T00088", "INSERT INTO [Menu]([MenuXDesc], [MenuXPosi], [MenXUrl], [MenXEst], [MenXPadre]) VALUES(@MenuXDesc, @MenuXPosi, @MenXUrl, @MenXEst, @MenXPadre); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00088)
           ,new CursorDef("T00089", "UPDATE [Menu] SET [MenuXDesc]=@MenuXDesc, [MenuXPosi]=@MenuXPosi, [MenXUrl]=@MenXUrl, [MenXEst]=@MenXEst, [MenXPadre]=@MenXPadre  WHERE [MenuXid] = @MenuXid", GxErrorMask.GX_NOMASK,prmT00089)
           ,new CursorDef("T000810", "DELETE FROM [Menu]  WHERE [MenuXid] = @MenuXid", GxErrorMask.GX_NOMASK,prmT000810)
           ,new CursorDef("T000811", "SELECT [MenuXid] FROM [Menu] ORDER BY [MenuXid]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000811,100, GxCacheFrequency.OFF ,true,false )
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
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((short[]) buf[9])[0] = rslt.getShort(6) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((short[]) buf[9])[0] = rslt.getShort(6) ;
              return;
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((short[]) buf[9])[0] = rslt.getShort(6) ;
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 4 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 5 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 6 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 9 :
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              stmt.SetParameter(5, (short)parms[8]);
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              stmt.SetParameter(5, (short)parms[8]);
              stmt.SetParameter(6, (short)parms[9]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
     }
  }

}

}
