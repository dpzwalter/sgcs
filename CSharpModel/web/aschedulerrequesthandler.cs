/*
               File: SchedulerRequestHandler
        Description: Scheduler Request Handler
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/23/2020 14:32:27.99
       Program type: Main program
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
using GeneXus.Http.Server;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class aschedulerrequesthandler : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("Carmine");
         initialize();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public aschedulerrequesthandler( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public aschedulerrequesthandler( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         aschedulerrequesthandler objaschedulerrequesthandler;
         objaschedulerrequesthandler = new aschedulerrequesthandler();
         objaschedulerrequesthandler.context.SetSubmitInitialConfig(context);
         objaschedulerrequesthandler.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objaschedulerrequesthandler);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((aschedulerrequesthandler)stateInfo).executePrivate();
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
         AV21queryString = AV20httpRequest.QueryString;
         if ( ( StringUtil.StringSearch( AV21queryString, "&from=", 1) > 0 ) && ( StringUtil.StringSearch( AV21queryString, "&to=", 1) > 0 ) )
         {
            AV10callbackIndex = (short)(StringUtil.StringSearch( AV21queryString, "&callback=", 1));
            AV8auxIndex = (short)(StringUtil.StringSearch( AV21queryString, "&", AV10callbackIndex+10));
            AV9callback = StringUtil.Substring( AV21queryString, AV10callbackIndex+10, AV8auxIndex-(AV10callbackIndex+10));
            AV12fromIndex = (short)(StringUtil.StringSearch( AV21queryString, "&from=", 1));
            AV8auxIndex = (short)(StringUtil.StringSearch( AV21queryString, "&", AV12fromIndex+6));
            AV11from = StringUtil.Substring( AV21queryString, AV12fromIndex+6, AV8auxIndex-(AV12fromIndex+6));
            AV15toIndex = (short)(StringUtil.StringSearch( AV21queryString, "&to=", 1));
            AV14to = StringUtil.Substring( AV21queryString, AV15toIndex+4, StringUtil.Len( AV21queryString));
            AV19fromCollection = GxRegex.Split(AV11from,"-");
            AV22toCollection = GxRegex.Split(AV14to,"-");
            AV16dateFrom = context.localUtil.YMDToD( (int)(NumberUtil.Val( AV19fromCollection.GetString(1), ".")), (int)(NumberUtil.Val( AV19fromCollection.GetString(2), ".")), (int)(NumberUtil.Val( AV19fromCollection.GetString(3), ".")));
            AV17dateTo = context.localUtil.YMDToD( (int)(NumberUtil.Val( AV22toCollection.GetString(1), ".")), (int)(NumberUtil.Val( AV22toCollection.GetString(2), ".")), (int)(NumberUtil.Val( AV22toCollection.GetString(3), ".")));
            try {
               args = new Object[] {(DateTime)AV16dateFrom,(DateTime)AV17dateTo,(SdtSchedulerEvents)AV18events} ;
               ClassLoader.WebExecute(AV9callback,"GeneXus.Programs",AV9callback.ToLower().Trim(), new Object[] {context }, "execute", args);
               if ( ( args != null ) && ( args.Length == 3 ) )
               {
                  AV16dateFrom = (DateTime)(args[0]) ;
                  AV17dateTo = (DateTime)(args[1]) ;
                  AV18events = (SdtSchedulerEvents)(args[2]) ;
               }
            }
            catch (GxClassLoaderException) {
               if ( AV9callback .Trim().Length < 6 || AV9callback .Substring( AV9callback .Trim().Length - 5, 5) != ".aspx")
               {
                  context.wjLoc = formatLink(AV9callback+".aspx") + "?" + UrlEncode(DateTimeUtil.FormatDateParm(AV16dateFrom)) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV17dateTo));
               }
               else
               {
                  context.wjLoc = formatLink(AV9callback) + "?" + UrlEncode(DateTimeUtil.FormatDateParm(AV16dateFrom)) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV17dateTo));
               }
            }
         }
         if ( ! context.isAjaxRequest( ) )
         {
            AV13httpResponse.AppendHeader("Content-Type", "text/xml");
         }
         AV13httpResponse.AddString(AV18events.ToXml(false, true, "data", ""));
         if ( context.WillRedirect( ) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "";
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         base.cleanup();
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
         GXKey = "";
         gxfirstwebparm = "";
         AV21queryString = "";
         AV20httpRequest = new GxHttpRequest( context);
         AV9callback = "";
         AV11from = "";
         AV14to = "";
         AV19fromCollection = new GxSimpleCollection<String>();
         AV22toCollection = new GxSimpleCollection<String>();
         AV16dateFrom = DateTime.MinValue;
         AV17dateTo = DateTime.MinValue;
         AV18events = new SdtSchedulerEvents(context);
         AV13httpResponse = new GxHttpResponse( context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short gxcookieaux ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV10callbackIndex ;
      private short AV8auxIndex ;
      private short AV12fromIndex ;
      private short AV15toIndex ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String AV21queryString ;
      private String AV9callback ;
      private String AV11from ;
      private String AV14to ;
      private DateTime AV16dateFrom ;
      private DateTime AV17dateTo ;
      private bool entryPointCalled ;
      private Object[] args ;
      private GxHttpRequest AV20httpRequest ;
      private GxHttpResponse AV13httpResponse ;
      private GxSimpleCollection<String> AV19fromCollection ;
      private GxSimpleCollection<String> AV22toCollection ;
      private SdtSchedulerEvents AV18events ;
   }

}
