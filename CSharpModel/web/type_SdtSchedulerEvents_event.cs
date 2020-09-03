/*
				   File: type_SdtSchedulerEvents_event
			Description: Items
				 Author: Nemo 🐠 for C# version 16.0.10.142546
		   Program type: Callable routine
			  Main DBMS: 
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Services.Protocols;


namespace GeneXus.Programs
{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="SchedulerEvents.event")]
	[XmlType(TypeName="SchedulerEvents.event" , Namespace="" )]
	[Serializable]
	public class SdtSchedulerEvents_event : GxUserType
	{
		public SdtSchedulerEvents_event( )
		{
			/* Constructor for serialization */
			gxTv_SdtSchedulerEvents_event_Id = "";

			gxTv_SdtSchedulerEvents_event_Name = "";

			gxTv_SdtSchedulerEvents_event_Notes = "";

			gxTv_SdtSchedulerEvents_event_Link = "";

			gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(DateTime.MinValue);

			gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(DateTime.MinValue);

			gxTv_SdtSchedulerEvents_event_Additionalinformation = "";

			gxTv_SdtSchedulerEvents_event_Color = "";

			gxTv_SdtSchedulerEvents_event_Backgroundcolor = "";

			gxTv_SdtSchedulerEvents_event_Nameweekview = "";

			gxTv_SdtSchedulerEvents_event_Namemonthview = "";

			gxTv_SdtSchedulerEvents_event_Namedayview = "";

			gxTv_SdtSchedulerEvents_event_Tooltip = "";

		}

		public SdtSchedulerEvents_event(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("Id", gxTpr_Id, false);


			AddObjectProperty("Name", gxTpr_Name, false);


			AddObjectProperty("Notes", gxTpr_Notes, false);


			AddObjectProperty("Link", gxTpr_Link, false);


			datetime_STZ = gxTpr_Starttime;
			sDateCnv = "";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Year(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + "-";
			sNumToPad = StringUtil.Trim( StringUtil.Str((decimal)(DateTimeUtil.Month(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + "-";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Day(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + "T";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Hour(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + ":";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Minute(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + ":";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Second(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			AddObjectProperty("StartTime", sDateCnv, false);


			datetime_STZ = gxTpr_Endtime;
			sDateCnv = "";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Year(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + "-";
			sNumToPad = StringUtil.Trim( StringUtil.Str((decimal)(DateTimeUtil.Month(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + "-";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Day(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + "T";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Hour(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + ":";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Minute(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			sDateCnv = sDateCnv + ":";
			sNumToPad = StringUtil.Trim(StringUtil.Str((decimal)(DateTimeUtil.Second(datetime_STZ)), 10, 0));
			sDateCnv = sDateCnv + StringUtil.Substring("00", 1, 2-StringUtil.Len(sNumToPad)) + sNumToPad;
			AddObjectProperty("EndTime", sDateCnv, false);


			AddObjectProperty("AdditionalInformation", gxTpr_Additionalinformation, false);


			AddObjectProperty("Color", gxTpr_Color, false);


			AddObjectProperty("BackgroundColor", gxTpr_Backgroundcolor, false);


			AddObjectProperty("NameWeekView", gxTpr_Nameweekview, false);


			AddObjectProperty("NameMonthView", gxTpr_Namemonthview, false);


			AddObjectProperty("NameDayView", gxTpr_Namedayview, false);


			AddObjectProperty("ToolTip", gxTpr_Tooltip, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Id")]
		[XmlElement(ElementName="Id")]
		public String gxTpr_Id
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Id; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Id = value;
				SetDirty("Id");
			}
		}




		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Name; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Name = value;
				SetDirty("Name");
			}
		}




		[SoapElement(ElementName="Notes")]
		[XmlElement(ElementName="Notes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public String gxTpr_Notes
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Notes; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Notes = value;
				SetDirty("Notes");
			}
		}




		[SoapElement(ElementName="Link")]
		[XmlElement(ElementName="Link")]
		public String gxTpr_Link
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Link; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Link = value;
				SetDirty("Link");
			}
		}



		[SoapElement(ElementName="StartTime")]
		[XmlElement(ElementName="StartTime" , IsNullable=true)]
		public string gxTpr_Starttime_Nullable
		{
			get {
				if ( gxTv_SdtSchedulerEvents_event_Starttime == DateTime.MinValue)
					return null;
				return new GxDatetimeString(gxTv_SdtSchedulerEvents_event_Starttime).value ;
			}
			set {
				gxTv_SdtSchedulerEvents_event_Starttime = DateTimeUtil.CToD2(value);
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public DateTime gxTpr_Starttime
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Starttime; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Starttime = value;
				SetDirty("Starttime");
			}
		}


		[SoapElement(ElementName="EndTime")]
		[XmlElement(ElementName="EndTime" , IsNullable=true)]
		public string gxTpr_Endtime_Nullable
		{
			get {
				if ( gxTv_SdtSchedulerEvents_event_Endtime == DateTime.MinValue)
					return null;
				return new GxDatetimeString(gxTv_SdtSchedulerEvents_event_Endtime).value ;
			}
			set {
				gxTv_SdtSchedulerEvents_event_Endtime = DateTimeUtil.CToD2(value);
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public DateTime gxTpr_Endtime
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Endtime; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Endtime = value;
				SetDirty("Endtime");
			}
		}



		[SoapElement(ElementName="AdditionalInformation")]
		[XmlElement(ElementName="AdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public String gxTpr_Additionalinformation
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Additionalinformation; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Additionalinformation = value;
				SetDirty("Additionalinformation");
			}
		}




		[SoapElement(ElementName="Color")]
		[XmlElement(ElementName="Color")]
		public String gxTpr_Color
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Color; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Color_N = 0;

				gxTv_SdtSchedulerEvents_event_Color = value;
				SetDirty("Color");
			}
		}

		public bool ShouldSerializegxTpr_Color()

		{
				return gxTv_SdtSchedulerEvents_event_Color_N == 0;

		}



		[SoapElement(ElementName="BackgroundColor")]
		[XmlElement(ElementName="BackgroundColor")]
		public String gxTpr_Backgroundcolor
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Backgroundcolor; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 0;

				gxTv_SdtSchedulerEvents_event_Backgroundcolor = value;
				SetDirty("Backgroundcolor");
			}
		}

		public bool ShouldSerializegxTpr_Backgroundcolor()

		{
				return gxTv_SdtSchedulerEvents_event_Backgroundcolor_N == 0;

		}



		[SoapElement(ElementName="NameWeekView")]
		[XmlElement(ElementName="NameWeekView")]
		public String gxTpr_Nameweekview
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Nameweekview; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Nameweekview_N = 0;

				gxTv_SdtSchedulerEvents_event_Nameweekview = value;
				SetDirty("Nameweekview");
			}
		}

		public bool ShouldSerializegxTpr_Nameweekview()

		{
				return gxTv_SdtSchedulerEvents_event_Nameweekview_N == 0;

		}



		[SoapElement(ElementName="NameMonthView")]
		[XmlElement(ElementName="NameMonthView")]
		public String gxTpr_Namemonthview
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Namemonthview; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Namemonthview_N = 0;

				gxTv_SdtSchedulerEvents_event_Namemonthview = value;
				SetDirty("Namemonthview");
			}
		}

		public bool ShouldSerializegxTpr_Namemonthview()

		{
				return gxTv_SdtSchedulerEvents_event_Namemonthview_N == 0;

		}



		[SoapElement(ElementName="NameDayView")]
		[XmlElement(ElementName="NameDayView")]
		public String gxTpr_Namedayview
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Namedayview; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Namedayview_N = 0;

				gxTv_SdtSchedulerEvents_event_Namedayview = value;
				SetDirty("Namedayview");
			}
		}

		public bool ShouldSerializegxTpr_Namedayview()

		{
				return gxTv_SdtSchedulerEvents_event_Namedayview_N == 0;

		}



		[SoapElement(ElementName="ToolTip")]
		[XmlElement(ElementName="ToolTip")]
		public String gxTpr_Tooltip
		{
			get { 
				return gxTv_SdtSchedulerEvents_event_Tooltip; 
			}
			set { 
				gxTv_SdtSchedulerEvents_event_Tooltip_N = 0;

				gxTv_SdtSchedulerEvents_event_Tooltip = value;
				SetDirty("Tooltip");
			}
		}

		public bool ShouldSerializegxTpr_Tooltip()

		{
				return gxTv_SdtSchedulerEvents_event_Tooltip_N == 0;

		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSchedulerEvents_event_Id = "";
			gxTv_SdtSchedulerEvents_event_Name = "";
			gxTv_SdtSchedulerEvents_event_Notes = "";
			gxTv_SdtSchedulerEvents_event_Link = "";
			gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(DateTime.MinValue);
			gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(DateTime.MinValue);
			gxTv_SdtSchedulerEvents_event_Additionalinformation = "";
			gxTv_SdtSchedulerEvents_event_Color = "";
			gxTv_SdtSchedulerEvents_event_Color_N = 1;

			gxTv_SdtSchedulerEvents_event_Backgroundcolor = "";
			gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 1;

			gxTv_SdtSchedulerEvents_event_Nameweekview = "";
			gxTv_SdtSchedulerEvents_event_Nameweekview_N = 1;

			gxTv_SdtSchedulerEvents_event_Namemonthview = "";
			gxTv_SdtSchedulerEvents_event_Namemonthview_N = 1;

			gxTv_SdtSchedulerEvents_event_Namedayview = "";
			gxTv_SdtSchedulerEvents_event_Namedayview_N = 1;

			gxTv_SdtSchedulerEvents_event_Tooltip = "";
			gxTv_SdtSchedulerEvents_event_Tooltip_N = 1;

			datetime_STZ = (DateTime)(DateTime.MinValue);
			sDateCnv = "";
			sNumToPad = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String sDateCnv ;
		protected String sNumToPad ;
		protected DateTime datetime_STZ ;

		protected String gxTv_SdtSchedulerEvents_event_Id;
		 

		protected String gxTv_SdtSchedulerEvents_event_Name;
		 

		protected String gxTv_SdtSchedulerEvents_event_Notes;
		 

		protected String gxTv_SdtSchedulerEvents_event_Link;
		 

		protected DateTime gxTv_SdtSchedulerEvents_event_Starttime;
		 

		protected DateTime gxTv_SdtSchedulerEvents_event_Endtime;
		 

		protected String gxTv_SdtSchedulerEvents_event_Additionalinformation;
		 

		protected String gxTv_SdtSchedulerEvents_event_Color;
		protected short gxTv_SdtSchedulerEvents_event_Color_N;
		 

		protected String gxTv_SdtSchedulerEvents_event_Backgroundcolor;
		protected short gxTv_SdtSchedulerEvents_event_Backgroundcolor_N;
		 

		protected String gxTv_SdtSchedulerEvents_event_Nameweekview;
		protected short gxTv_SdtSchedulerEvents_event_Nameweekview_N;
		 

		protected String gxTv_SdtSchedulerEvents_event_Namemonthview;
		protected short gxTv_SdtSchedulerEvents_event_Namemonthview_N;
		 

		protected String gxTv_SdtSchedulerEvents_event_Namedayview;
		protected short gxTv_SdtSchedulerEvents_event_Namedayview_N;
		 

		protected String gxTv_SdtSchedulerEvents_event_Tooltip;
		protected short gxTv_SdtSchedulerEvents_event_Tooltip_N;
		 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SchedulerEvents.event", Namespace="")]
	public class SdtSchedulerEvents_event_RESTInterface : GxGenericCollectionItem<SdtSchedulerEvents_event>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSchedulerEvents_event_RESTInterface( ) : base()
		{
		}

		public SdtSchedulerEvents_event_RESTInterface( SdtSchedulerEvents_event psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Id", Order=0)]
		public  String gxTpr_Id
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Id);

			}
			set { 
				 sdt.gxTpr_Id = value;
			}
		}

		[DataMember(Name="Name", Order=1)]
		public  String gxTpr_Name
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Name);

			}
			set { 
				 sdt.gxTpr_Name = value;
			}
		}

		[DataMember(Name="Notes", Order=2)]
		public  String gxTpr_Notes
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Notes);

			}
			set { 
				 sdt.gxTpr_Notes = value;
			}
		}

		[DataMember(Name="Link", Order=3)]
		public  String gxTpr_Link
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Link);

			}
			set { 
				 sdt.gxTpr_Link = value;
			}
		}

		[DataMember(Name="StartTime", Order=4)]
		public  String gxTpr_Starttime
		{
			get { 
				return DateTimeUtil.TToC2( sdt.gxTpr_Starttime);

			}
			set { 
				sdt.gxTpr_Starttime = DateTimeUtil.CToT2(value);
			}
		}

		[DataMember(Name="EndTime", Order=5)]
		public  String gxTpr_Endtime
		{
			get { 
				return DateTimeUtil.TToC2( sdt.gxTpr_Endtime);

			}
			set { 
				sdt.gxTpr_Endtime = DateTimeUtil.CToT2(value);
			}
		}

		[DataMember(Name="AdditionalInformation", Order=6)]
		public  String gxTpr_Additionalinformation
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Additionalinformation);

			}
			set { 
				 sdt.gxTpr_Additionalinformation = value;
			}
		}

		[DataMember(Name="Color", Order=7)]
		public  String gxTpr_Color
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Color);

			}
			set { 
				 sdt.gxTpr_Color = value;
			}
		}

		[DataMember(Name="BackgroundColor", Order=8)]
		public  String gxTpr_Backgroundcolor
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Backgroundcolor);

			}
			set { 
				 sdt.gxTpr_Backgroundcolor = value;
			}
		}

		[DataMember(Name="NameWeekView", Order=9)]
		public  String gxTpr_Nameweekview
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Nameweekview);

			}
			set { 
				 sdt.gxTpr_Nameweekview = value;
			}
		}

		[DataMember(Name="NameMonthView", Order=10)]
		public  String gxTpr_Namemonthview
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Namemonthview);

			}
			set { 
				 sdt.gxTpr_Namemonthview = value;
			}
		}

		[DataMember(Name="NameDayView", Order=11)]
		public  String gxTpr_Namedayview
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Namedayview);

			}
			set { 
				 sdt.gxTpr_Namedayview = value;
			}
		}

		[DataMember(Name="ToolTip", Order=12)]
		public  String gxTpr_Tooltip
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Tooltip);

			}
			set { 
				 sdt.gxTpr_Tooltip = value;
			}
		}


		#endregion

		public SdtSchedulerEvents_event sdt
		{
			get { 
				return (SdtSchedulerEvents_event)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtSchedulerEvents_event() ;
			}
		}
	}
	#endregion
}