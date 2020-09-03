/*
               File: GAMCheckUserActivationMethod
        Description: Check User Activation Method
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 4/15/2020 11:6:53.26
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gamcheckuseractivationmethod : GXProcedure
   {
      public gamcheckuseractivationmethod( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gamcheckuseractivationmethod( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_UserGUID ,
                           out GXBaseCollection<SdtMessages_Message> aP1_Messages )
      {
         this.AV10UserGUID = aP0_UserGUID;
         this.AV12Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus") ;
         initialize();
         executePrivate();
         aP1_Messages=this.AV12Messages;
      }

      public GXBaseCollection<SdtMessages_Message> executeUdp( String aP0_UserGUID )
      {
         execute(aP0_UserGUID, out aP1_Messages);
         return AV12Messages ;
      }

      public void executeSubmit( String aP0_UserGUID ,
                                 out GXBaseCollection<SdtMessages_Message> aP1_Messages )
      {
         gamcheckuseractivationmethod objgamcheckuseractivationmethod;
         objgamcheckuseractivationmethod = new gamcheckuseractivationmethod();
         objgamcheckuseractivationmethod.AV10UserGUID = aP0_UserGUID;
         objgamcheckuseractivationmethod.AV12Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus") ;
         objgamcheckuseractivationmethod.context.SetSubmitInitialConfig(context);
         objgamcheckuseractivationmethod.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgamcheckuseractivationmethod);
         aP1_Messages=this.AV12Messages;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gamcheckuseractivationmethod)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV9Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).get();
         if ( StringUtil.StrCmp(AV9Repository.gxTpr_Useractivationmethod, "U") == 0 )
         {
            AV14Message = new SdtMessages_Message(context);
            AV14Message.gxTpr_Type = 0;
            AV14Message.gxTpr_Description = "The user was created successfully!!, you must confirm the account, check your email, you will receive an email with a link to activate your account.";
            AV12Messages.Add(AV14Message, 0);
            AV11User.load( AV10UserGUID);
            AV15ActivactionKey = AV11User.getactivationkey(out  AV13Errors);
            AV8isOK = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context).activateuser(AV15ActivactionKey, true, out  AV13Errors);
            if ( AV8isOK )
            {
               AV14Message = new SdtMessages_Message(context);
               AV14Message.gxTpr_Type = 0;
               AV14Message.gxTpr_Description = "Your user account was successfully activated !!";
               AV12Messages.Add(AV14Message, 0);
            }
            else
            {
               GXt_objcol_SdtMessages_Message1 = AV12Messages;
               new gamconverterrorstomessages(context ).execute(  AV13Errors, out  GXt_objcol_SdtMessages_Message1) ;
               AV12Messages = GXt_objcol_SdtMessages_Message1;
            }
         }
         else if ( StringUtil.StrCmp(AV9Repository.gxTpr_Useractivationmethod, "D") == 0 )
         {
            AV14Message = new SdtMessages_Message(context);
            AV14Message.gxTpr_Type = 0;
            AV14Message.gxTpr_Description = "The user was created successfully!!, you must wait for confirmation from the administrator.";
            AV12Messages.Add(AV14Message, 0);
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV9Repository = new GeneXus.Programs.genexussecurity.SdtGAMRepository(context);
         AV14Message = new SdtMessages_Message(context);
         AV11User = new GeneXus.Programs.genexussecurity.SdtGAMUser(context);
         AV15ActivactionKey = "";
         AV13Errors = new GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError>( context, "GeneXus.Programs.genexussecurity.SdtGAMError", "GeneXus.Programs");
         GXt_objcol_SdtMessages_Message1 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV10UserGUID ;
      private String AV15ActivactionKey ;
      private bool AV8isOK ;
      private GXBaseCollection<SdtMessages_Message> aP1_Messages ;
      private GXExternalCollection<GeneXus.Programs.genexussecurity.SdtGAMError> AV13Errors ;
      private GXBaseCollection<SdtMessages_Message> AV12Messages ;
      private GXBaseCollection<SdtMessages_Message> GXt_objcol_SdtMessages_Message1 ;
      private GeneXus.Programs.genexussecurity.SdtGAMRepository AV9Repository ;
      private GeneXus.Programs.genexussecurity.SdtGAMUser AV11User ;
      private SdtMessages_Message AV14Message ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.gamcheckuseractivationmethod_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class gamcheckuseractivationmethod_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( String UserGUID ,
                           out GxGenericCollection<SdtMessages_Message_RESTInterface> Messages )
      {
         Messages = new GxGenericCollection<SdtMessages_Message_RESTInterface>() ;
         try
         {
            if ( ! ProcessHeaders("gamcheckuseractivationmethod") )
            {
               return  ;
            }
            gamcheckuseractivationmethod worker = new gamcheckuseractivationmethod(context) ;
            worker.IsMain = RunAsMain ;
            GXBaseCollection<SdtMessages_Message> gxrMessages = new GXBaseCollection<SdtMessages_Message>() ;
            worker.execute(UserGUID,out gxrMessages );
            worker.cleanup( );
            Messages = new GxGenericCollection<SdtMessages_Message_RESTInterface>(gxrMessages) ;
         }
         catch ( Exception e )
         {
            WebException(e);
         }
         finally
         {
            Cleanup();
         }
      }

   }

}
