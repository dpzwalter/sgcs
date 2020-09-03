/*
               File: ProcedureStatus
        Description: Procedure Status
             Author: GeneXus C# Generator version 16_0_10-142546
       Generated on: 8/23/2020 14:32:28.0
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class procedurestatus : GXProcedure
   {
      public procedurestatus( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public procedurestatus( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_IdLineaBase )
      {
         this.AV8IdLineaBase = aP0_IdLineaBase;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_IdLineaBase )
      {
         procedurestatus objprocedurestatus;
         objprocedurestatus = new procedurestatus();
         objprocedurestatus.AV8IdLineaBase = aP0_IdLineaBase;
         objprocedurestatus.context.SetSubmitInitialConfig(context);
         objprocedurestatus.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprocedurestatus);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((procedurestatus)stateInfo).executePrivate();
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
         /* Using cursor P000F2 */
         pr_default.execute(0, new Object[] {AV8IdLineaBase});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A5IdTarea = P000F2_A5IdTarea[0];
            A21IdLineaBase = P000F2_A21IdLineaBase[0];
            /* Optimized UPDATE. */
            /* Using cursor P000F3 */
            pr_default.execute(1, new Object[] {A5IdTarea});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
            /* End optimized UPDATE. */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         context.CommitDataStores("procedurestatus",pr_default);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("procedurestatus",pr_default);
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
         scmdbuf = "";
         P000F2_A5IdTarea = new short[1] ;
         P000F2_A21IdLineaBase = new short[1] ;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.procedurestatus__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.procedurestatus__default(),
            new Object[][] {
                new Object[] {
               P000F2_A5IdTarea, P000F2_A21IdLineaBase
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8IdLineaBase ;
      private short A5IdTarea ;
      private short A21IdLineaBase ;
      private String scmdbuf ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000F2_A5IdTarea ;
      private short[] P000F2_A21IdLineaBase ;
      private IDataStoreProvider pr_gam ;
   }

   public class procedurestatus__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class procedurestatus__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new UpdateCursor(def[1])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmP000F2 ;
        prmP000F2 = new Object[] {
        new Object[] {"@AV8IdLineaBase",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmP000F3 ;
        prmP000F3 = new Object[] {
        new Object[] {"@IdTarea",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("P000F2", "SELECT [IdTarea], [IdLineaBase] FROM [TareasLB] WHERE [IdLineaBase] = @AV8IdLineaBase ORDER BY [IdLineaBase] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F2,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("P000F3", "UPDATE [Tarea] SET [StatusTarea]=CONVERT(BIT, 0)  WHERE [IdTarea] = @IdTarea", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000F3)
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
     }
  }

}

}
