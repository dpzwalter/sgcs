using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"aloadeventssampleproc", "dll");
      sc.Add( @"aschedulerrequesthandler", "dll");
      sc.Add( @"aschedulerrequesthandler", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"gx0010", "dll");
      sc.Add( @"gx0040", "dll");
      sc.Add( @"gx0030", "dll");
      sc.Add( @"gx0020", "dll");
      sc.Add( @"gx0050", "dll");
      sc.Add( @"home", "dll");
      sc.Add( @"home", "dll");
      sc.Add( @"notauthorized", "dll");
      sc.Add( @"tabbedview", "dll");
      sc.Add( @"viewestado", "dll");
      sc.Add( @"wwestado", "dll");
      sc.Add( @"estadogeneral", "dll");
      sc.Add( @"estadoproyectowc", "dll");
      sc.Add( @"viewfase", "dll");
      sc.Add( @"wwfase", "dll");
      sc.Add( @"fasegeneral", "dll");
      sc.Add( @"fasetareawc", "dll");
      sc.Add( @"viewprioridad", "dll");
      sc.Add( @"wwprioridad", "dll");
      sc.Add( @"prioridadgeneral", "dll");
      sc.Add( @"prioridadtareawc", "dll");
      sc.Add( @"viewproyecto", "dll");
      sc.Add( @"wwproyecto", "dll");
      sc.Add( @"proyectogeneral", "dll");
      sc.Add( @"proyectotareawc", "dll");
      sc.Add( @"viewtarea", "dll");
      sc.Add( @"wwtarea", "dll");
      sc.Add( @"tareageneral", "dll");
      sc.Add( @"gx0060", "dll");
      sc.Add( @"viewestadotarea", "dll");
      sc.Add( @"wwestadotarea", "dll");
      sc.Add( @"estadotareageneral", "dll");
      sc.Add( @"estadotareatareawc", "dll");
      sc.Add( @"tareatareawc", "dll");
      sc.Add( @"gx0070", "dll");
      sc.Add( @"gx0081", "dll");
      sc.Add( @"viewlineabase", "dll");
      sc.Add( @"wwlineabase", "dll");
      sc.Add( @"lineabasegeneral", "dll");
      sc.Add( @"lineabasetareaslbwc", "dll");
      sc.Add( @"tareatareaslbwc", "dll");
      sc.Add( @"tareaversiontareawc", "dll");
      sc.Add( @"gx0091", "dll");
      sc.Add( @"masterpage", "dll");
      sc.Add( @"viewmenu", "dll");
      sc.Add( @"wwmenu", "dll");
      sc.Add( @"menugeneral", "dll");
      sc.Add( @"login", "dll");
      sc.Add( @"login", "dll");
      sc.Add( @"gx00d0", "dll");
      sc.Add( @"viewrol", "dll");
      sc.Add( @"wwrol", "dll");
      sc.Add( @"rolgeneral", "dll");
      sc.Add( @"rolusuariowc", "dll");
      sc.Add( @"viewusuario", "dll");
      sc.Add( @"wwusuario", "dll");
      sc.Add( @"usuariogeneral", "dll");
      sc.Add( @"dashboard", "dll");
      sc.Add( @"schedulerdetailsform", "dll");
      sc.Add( @"wpdestroyer", "dll");
      sc.Add( @"proyecto", "dll");
      sc.Add( @"tarea", "dll");
      sc.Add( @"prioridad", "dll");
      sc.Add( @"estado", "dll");
      sc.Add( @"fase", "dll");
      sc.Add( @"estadotarea", "dll");
      sc.Add( @"lineabase", "dll");
      sc.Add( @"menu", "dll");
      sc.Add( @"rol", "dll");
      sc.Add( @"usuario", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.eng.dll", cs_path + @"\messages.eng.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainactiontexts.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaingooglecharttype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaingoogletableformatter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainestado.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainpage.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.eng.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.eng.txt" ))
            return true;
      }
      return false ;
   }

}

