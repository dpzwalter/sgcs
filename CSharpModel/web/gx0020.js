/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:32.20
*/
gx.evt.autoSkip=!1;gx.define("gx0020",!1,function(){var n,t;this.ServerClass="gx0020";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV12pIdTarea=gx.fn.getIntegerValue("vPIDTAREA",",")};this.e180a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e110a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("IDTAREAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("IDTAREAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCIDTAREA","Visible",!0)):(gx.fn.setCtrlProperty("IDTAREAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCIDTAREA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("IDTAREAFILTERCONTAINER","Class")',ctrl:"IDTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDTAREA","Visible")',ctrl:"vCIDTAREA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e120a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("NOMBRETAREAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("NOMBRETAREAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCNOMBRETAREA","Visible",!0)):(gx.fn.setCtrlProperty("NOMBRETAREAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCNOMBRETAREA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("NOMBRETAREAFILTERCONTAINER","Class")',ctrl:"NOMBRETAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNOMBRETAREA","Visible")',ctrl:"vCNOMBRETAREA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e130a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DESCRIPCIONTAREAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DESCRIPCIONTAREAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDESCRIPCIONTAREA","Visible",!0)):(gx.fn.setCtrlProperty("DESCRIPCIONTAREAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDESCRIPCIONTAREA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DESCRIPCIONTAREAFILTERCONTAINER","Class")',ctrl:"DESCRIPCIONTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDESCRIPCIONTAREA","Visible")',ctrl:"vCDESCRIPCIONTAREA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e140a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("IDPROYECTOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("IDPROYECTOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCIDPROYECTO","Visible",!0)):(gx.fn.setCtrlProperty("IDPROYECTOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCIDPROYECTO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("IDPROYECTOFILTERCONTAINER","Class")',ctrl:"IDPROYECTOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDPROYECTO","Visible")',ctrl:"vCIDPROYECTO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e150a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("IDPRIORIDADFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("IDPRIORIDADFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCIDPRIORIDAD","Visible",!0)):(gx.fn.setCtrlProperty("IDPRIORIDADFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCIDPRIORIDAD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("IDPRIORIDADFILTERCONTAINER","Class")',ctrl:"IDPRIORIDADFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDPRIORIDAD","Visible")',ctrl:"vCIDPRIORIDAD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e160a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("IDFASEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("IDFASEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCIDFASE","Visible",!0)):(gx.fn.setCtrlProperty("IDFASEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCIDFASE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("IDFASEFILTERCONTAINER","Class")',ctrl:"IDFASEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDFASE","Visible")',ctrl:"vCIDFASE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e170a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCIDESTADOTAREA","Visible",!0)):(gx.fn.setCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCIDESTADOTAREA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class")',ctrl:"IDESTADOTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDESTADOTAREA","Visible")',ctrl:"vCIDESTADOTAREA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e210a2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e220a1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,85,86,87,88,89,90,91,92,93,94];this.GXLastCtrlId=94;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0020",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(5,86,"IDTAREA","Id de Tarea","","IdTarea","int",0,"px",4,4,"right",null,[],5,"IdTarea",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(6,87,"NOMBRETAREA","Nombre de Tarea","","NombreTarea","char",0,"px",60,60,"left",null,[],6,"NombreTarea",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(1,88,"IDPROYECTO","Id de Proyecto","","IdProyecto","int",0,"px",4,4,"right",null,[],1,"IdProyecto",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(9,89,"IDPRIORIDAD","Id de Prioridad","","IdPrioridad","int",0,"px",4,4,"right",null,[],9,"IdPrioridad",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(13,90,"IDFASE","Id Fase","","IdFase","int",0,"px",4,4,"right",null,[],13,"IdFase",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(17,91,"IDESTADOTAREA","Id Estado Tarea","","IdEstadoTarea","int",0,"px",4,4,"right",null,[],17,"IdEstadoTarea",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"IDTAREAFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLIDTAREAFILTER",format:1,grid:0,evt:"e110a1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCIDTAREA",gxz:"ZV6cIdTarea",gxold:"OV6cIdTarea",gxvar:"AV6cIdTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cIdTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cIdTarea=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCIDTAREA",gx.O.AV6cIdTarea,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cIdTarea=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCIDTAREA",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"NOMBRETAREAFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLNOMBRETAREAFILTER",format:1,grid:0,evt:"e120a1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:60,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCNOMBRETAREA",gxz:"ZV7cNombreTarea",gxold:"OV7cNombreTarea",gxvar:"AV7cNombreTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cNombreTarea=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cNombreTarea=n)},v2c:function(){gx.fn.setControlValue("vCNOMBRETAREA",gx.O.AV7cNombreTarea,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cNombreTarea=this.val())},val:function(){return gx.fn.getControlValue("vCNOMBRETAREA")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"DESCRIPCIONTAREAFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLDESCRIPCIONTAREAFILTER",format:1,grid:0,evt:"e130a1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:60,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDESCRIPCIONTAREA",gxz:"ZV8cDescripcionTarea",gxold:"OV8cDescripcionTarea",gxvar:"AV8cDescripcionTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cDescripcionTarea=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cDescripcionTarea=n)},v2c:function(){gx.fn.setControlValue("vCDESCRIPCIONTAREA",gx.O.AV8cDescripcionTarea,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cDescripcionTarea=this.val())},val:function(){return gx.fn.getControlValue("vCDESCRIPCIONTAREA")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"IDPROYECTOFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLIDPROYECTOFILTER",format:1,grid:0,evt:"e140a1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCIDPROYECTO",gxz:"ZV10cIdProyecto",gxold:"OV10cIdProyecto",gxvar:"AV10cIdProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cIdProyecto=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cIdProyecto=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCIDPROYECTO",gx.O.AV10cIdProyecto,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cIdProyecto=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCIDPROYECTO",",")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"IDPRIORIDADFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLIDPRIORIDADFILTER",format:1,grid:0,evt:"e150a1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCIDPRIORIDAD",gxz:"ZV11cIdPrioridad",gxold:"OV11cIdPrioridad",gxvar:"AV11cIdPrioridad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cIdPrioridad=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cIdPrioridad=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCIDPRIORIDAD",gx.O.AV11cIdPrioridad,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cIdPrioridad=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCIDPRIORIDAD",",")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"IDFASEFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLIDFASEFILTER",format:1,grid:0,evt:"e160a1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCIDFASE",gxz:"ZV14cIdFase",gxold:"OV14cIdFase",gxvar:"AV14cIdFase",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV14cIdFase=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV14cIdFase=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCIDFASE",gx.O.AV14cIdFase,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14cIdFase=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCIDFASE",",")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"IDESTADOTAREAFILTERCONTAINER",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"LBLIDESTADOTAREAFILTER",format:1,grid:0,evt:"e170a1_client"};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCIDESTADOTAREA",gxz:"ZV15cIdEstadoTarea",gxold:"OV15cIdEstadoTarea",gxvar:"AV15cIdEstadoTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15cIdEstadoTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV15cIdEstadoTarea=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCIDESTADOTAREA",gx.O.AV15cIdEstadoTarea,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15cIdEstadoTarea=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCIDESTADOTAREA",",")},nac:gx.falseFn};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"GRIDTABLE",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"BTNTOGGLE",grid:0,evt:"e180a1_client"};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[85]={id:85,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV18Linkselection_GXI)},c2v:function(n){gx.O.AV18Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV18Linkselection_GXI",nac:gx.falseFn};n[86]={id:86,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDTAREA",gxz:"Z5IdTarea",gxold:"O5IdTarea",gxvar:"A5IdTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A5IdTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5IdTarea=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDTAREA",n||gx.fn.currentGridRowImpl(84),gx.O.A5IdTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A5IdTarea=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDTAREA",n||gx.fn.currentGridRowImpl(84),",")},nac:gx.falseFn};n[87]={id:87,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOMBRETAREA",gxz:"Z6NombreTarea",gxold:"O6NombreTarea",gxvar:"A6NombreTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A6NombreTarea=n)},v2z:function(n){n!==undefined&&(gx.O.Z6NombreTarea=n)},v2c:function(n){gx.fn.setGridControlValue("NOMBRETAREA",n||gx.fn.currentGridRowImpl(84),gx.O.A6NombreTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A6NombreTarea=this.val(n))},val:function(n){return gx.fn.getGridControlValue("NOMBRETAREA",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[88]={id:88,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDPROYECTO",gxz:"Z1IdProyecto",gxold:"O1IdProyecto",gxvar:"A1IdProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1IdProyecto=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1IdProyecto=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDPROYECTO",n||gx.fn.currentGridRowImpl(84),gx.O.A1IdProyecto,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A1IdProyecto=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDPROYECTO",n||gx.fn.currentGridRowImpl(84),",")},nac:gx.falseFn};n[89]={id:89,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDPRIORIDAD",gxz:"Z9IdPrioridad",gxold:"O9IdPrioridad",gxvar:"A9IdPrioridad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A9IdPrioridad=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z9IdPrioridad=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDPRIORIDAD",n||gx.fn.currentGridRowImpl(84),gx.O.A9IdPrioridad,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A9IdPrioridad=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDPRIORIDAD",n||gx.fn.currentGridRowImpl(84),",")},nac:gx.falseFn};n[90]={id:90,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDFASE",gxz:"Z13IdFase",gxold:"O13IdFase",gxvar:"A13IdFase",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A13IdFase=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13IdFase=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDFASE",n||gx.fn.currentGridRowImpl(84),gx.O.A13IdFase,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A13IdFase=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDFASE",n||gx.fn.currentGridRowImpl(84),",")},nac:gx.falseFn};n[91]={id:91,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDESTADOTAREA",gxz:"Z17IdEstadoTarea",gxold:"O17IdEstadoTarea",gxvar:"A17IdEstadoTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A17IdEstadoTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17IdEstadoTarea=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDESTADOTAREA",n||gx.fn.currentGridRowImpl(84),gx.O.A17IdEstadoTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A17IdEstadoTarea=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDESTADOTAREA",n||gx.fn.currentGridRowImpl(84),",")},nac:gx.falseFn};n[92]={id:92,fld:"",grid:0};n[93]={id:93,fld:"",grid:0};n[94]={id:94,fld:"BTN_CANCEL",grid:0,evt:"e220a1_client"};this.AV6cIdTarea=0;this.ZV6cIdTarea=0;this.OV6cIdTarea=0;this.AV7cNombreTarea="";this.ZV7cNombreTarea="";this.OV7cNombreTarea="";this.AV8cDescripcionTarea="";this.ZV8cDescripcionTarea="";this.OV8cDescripcionTarea="";this.AV10cIdProyecto=0;this.ZV10cIdProyecto=0;this.OV10cIdProyecto=0;this.AV11cIdPrioridad=0;this.ZV11cIdPrioridad=0;this.OV11cIdPrioridad=0;this.AV14cIdFase=0;this.ZV14cIdFase=0;this.OV14cIdFase=0;this.AV15cIdEstadoTarea=0;this.ZV15cIdEstadoTarea=0;this.OV15cIdEstadoTarea=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z5IdTarea=0;this.O5IdTarea=0;this.Z6NombreTarea="";this.O6NombreTarea="";this.Z1IdProyecto=0;this.O1IdProyecto=0;this.Z9IdPrioridad=0;this.O9IdPrioridad=0;this.Z13IdFase=0;this.O13IdFase=0;this.Z17IdEstadoTarea=0;this.O17IdEstadoTarea=0;this.AV6cIdTarea=0;this.AV7cNombreTarea="";this.AV8cDescripcionTarea="";this.AV10cIdProyecto=0;this.AV11cIdPrioridad=0;this.AV14cIdFase=0;this.AV15cIdEstadoTarea=0;this.AV12pIdTarea=0;this.A7DescripcionTarea="";this.AV5LinkSelection="";this.A5IdTarea=0;this.A6NombreTarea="";this.A1IdProyecto=0;this.A9IdPrioridad=0;this.A13IdFase=0;this.A17IdEstadoTarea=0;this.Events={e210a2_client:["ENTER",!0],e220a1_client:["CANCEL",!0],e180a1_client:["'TOGGLE'",!1],e110a1_client:["LBLIDTAREAFILTER.CLICK",!1],e120a1_client:["LBLNOMBRETAREAFILTER.CLICK",!1],e130a1_client:["LBLDESCRIPCIONTAREAFILTER.CLICK",!1],e140a1_client:["LBLIDPROYECTOFILTER.CLICK",!1],e150a1_client:["LBLIDPRIORIDADFILTER.CLICK",!1],e160a1_client:["LBLIDFASEFILTER.CLICK",!1],e170a1_client:["LBLIDESTADOTAREAFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7cNombreTarea",fld:"vCNOMBRETAREA",pic:""},{av:"AV8cDescripcionTarea",fld:"vCDESCRIPCIONTAREA",pic:""},{av:"AV10cIdProyecto",fld:"vCIDPROYECTO",pic:"ZZZ9"},{av:"AV11cIdPrioridad",fld:"vCIDPRIORIDAD",pic:"ZZZ9"},{av:"AV14cIdFase",fld:"vCIDFASE",pic:"ZZZ9"},{av:"AV15cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLIDTAREAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("IDTAREAFILTERCONTAINER","Class")',ctrl:"IDTAREAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("IDTAREAFILTERCONTAINER","Class")',ctrl:"IDTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDTAREA","Visible")',ctrl:"vCIDTAREA",prop:"Visible"}]];this.EvtParms["LBLNOMBRETAREAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("NOMBRETAREAFILTERCONTAINER","Class")',ctrl:"NOMBRETAREAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("NOMBRETAREAFILTERCONTAINER","Class")',ctrl:"NOMBRETAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNOMBRETAREA","Visible")',ctrl:"vCNOMBRETAREA",prop:"Visible"}]];this.EvtParms["LBLDESCRIPCIONTAREAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DESCRIPCIONTAREAFILTERCONTAINER","Class")',ctrl:"DESCRIPCIONTAREAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DESCRIPCIONTAREAFILTERCONTAINER","Class")',ctrl:"DESCRIPCIONTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDESCRIPCIONTAREA","Visible")',ctrl:"vCDESCRIPCIONTAREA",prop:"Visible"}]];this.EvtParms["LBLIDPROYECTOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("IDPROYECTOFILTERCONTAINER","Class")',ctrl:"IDPROYECTOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("IDPROYECTOFILTERCONTAINER","Class")',ctrl:"IDPROYECTOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDPROYECTO","Visible")',ctrl:"vCIDPROYECTO",prop:"Visible"}]];this.EvtParms["LBLIDPRIORIDADFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("IDPRIORIDADFILTERCONTAINER","Class")',ctrl:"IDPRIORIDADFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("IDPRIORIDADFILTERCONTAINER","Class")',ctrl:"IDPRIORIDADFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDPRIORIDAD","Visible")',ctrl:"vCIDPRIORIDAD",prop:"Visible"}]];this.EvtParms["LBLIDFASEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("IDFASEFILTERCONTAINER","Class")',ctrl:"IDFASEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("IDFASEFILTERCONTAINER","Class")',ctrl:"IDFASEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDFASE","Visible")',ctrl:"vCIDFASE",prop:"Visible"}]];this.EvtParms["LBLIDESTADOTAREAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class")',ctrl:"IDESTADOTAREAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class")',ctrl:"IDESTADOTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDESTADOTAREA","Visible")',ctrl:"vCIDESTADOTAREA",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A5IdTarea",fld:"IDTAREA",pic:"ZZZ9",hsh:!0}],[{av:"AV12pIdTarea",fld:"vPIDTAREA",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7cNombreTarea",fld:"vCNOMBRETAREA",pic:""},{av:"AV8cDescripcionTarea",fld:"vCDESCRIPCIONTAREA",pic:""},{av:"AV10cIdProyecto",fld:"vCIDPROYECTO",pic:"ZZZ9"},{av:"AV11cIdPrioridad",fld:"vCIDPRIORIDAD",pic:"ZZZ9"},{av:"AV14cIdFase",fld:"vCIDFASE",pic:"ZZZ9"},{av:"AV15cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7cNombreTarea",fld:"vCNOMBRETAREA",pic:""},{av:"AV8cDescripcionTarea",fld:"vCDESCRIPCIONTAREA",pic:""},{av:"AV10cIdProyecto",fld:"vCIDPROYECTO",pic:"ZZZ9"},{av:"AV11cIdPrioridad",fld:"vCIDPRIORIDAD",pic:"ZZZ9"},{av:"AV14cIdFase",fld:"vCIDFASE",pic:"ZZZ9"},{av:"AV15cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7cNombreTarea",fld:"vCNOMBRETAREA",pic:""},{av:"AV8cDescripcionTarea",fld:"vCDESCRIPCIONTAREA",pic:""},{av:"AV10cIdProyecto",fld:"vCIDPROYECTO",pic:"ZZZ9"},{av:"AV11cIdPrioridad",fld:"vCIDPRIORIDAD",pic:"ZZZ9"},{av:"AV14cIdFase",fld:"vCIDFASE",pic:"ZZZ9"},{av:"AV15cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7cNombreTarea",fld:"vCNOMBRETAREA",pic:""},{av:"AV8cDescripcionTarea",fld:"vCDESCRIPCIONTAREA",pic:""},{av:"AV10cIdProyecto",fld:"vCIDPROYECTO",pic:"ZZZ9"},{av:"AV11cIdPrioridad",fld:"vCIDPRIORIDAD",pic:"ZZZ9"},{av:"AV14cIdFase",fld:"vCIDFASE",pic:"ZZZ9"},{av:"AV15cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"}],[]];this.setVCMap("AV12pIdTarea","vPIDTAREA",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[36]);t.addRefreshingParm(this.GXValidFnc[46]);t.addRefreshingParm(this.GXValidFnc[56]);t.addRefreshingParm(this.GXValidFnc[66]);t.addRefreshingParm(this.GXValidFnc[76]);this.Initialize()});gx.wi(function(){gx.createParentObj(gx0020)})