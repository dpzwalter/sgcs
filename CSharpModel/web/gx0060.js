/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:31.50
*/
gx.evt.autoSkip=!1;gx.define("gx0060",!1,function(){var n,t;this.ServerClass="gx0060";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pIdEstadoTarea=gx.fn.getIntegerValue("vPIDESTADOTAREA",",")};this.e130y1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e110y1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCIDESTADOTAREA","Visible",!0)):(gx.fn.setCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCIDESTADOTAREA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class")',ctrl:"IDESTADOTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDESTADOTAREA","Visible")',ctrl:"vCIDESTADOTAREA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e120y1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ESTADOTAREAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTADOTAREAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTADOTAREA","Visible",!0)):(gx.fn.setCtrlProperty("ESTADOTAREAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTADOTAREA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTADOTAREAFILTERCONTAINER","Class")',ctrl:"ESTADOTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTADOTAREA","Visible")',ctrl:"vCESTADOTAREA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e160y2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e170y1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40];this.GXLastCtrlId=40;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0060",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(17,36,"IDESTADOTAREA","Id Estado Tarea","","IdEstadoTarea","int",0,"px",4,4,"right",null,[],17,"IdEstadoTarea",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(18,37,"ESTADOTAREA","Estado Tarea","","EstadoTarea","char",0,"px",20,20,"left",null,[],18,"EstadoTarea",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"IDESTADOTAREAFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLIDESTADOTAREAFILTER",format:1,grid:0,evt:"e110y1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCIDESTADOTAREA",gxz:"ZV6cIdEstadoTarea",gxold:"OV6cIdEstadoTarea",gxvar:"AV6cIdEstadoTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cIdEstadoTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cIdEstadoTarea=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCIDESTADOTAREA",gx.O.AV6cIdEstadoTarea,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cIdEstadoTarea=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCIDESTADOTAREA",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"ESTADOTAREAFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLESTADOTAREAFILTER",format:1,grid:0,evt:"e120y1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCESTADOTAREA",gxz:"ZV7cEstadoTarea",gxold:"OV7cEstadoTarea",gxvar:"AV7cEstadoTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cEstadoTarea=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cEstadoTarea=n)},v2c:function(){gx.fn.setControlValue("vCESTADOTAREA",gx.O.AV7cEstadoTarea,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cEstadoTarea=this.val())},val:function(){return gx.fn.getControlValue("vCESTADOTAREA")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0,evt:"e130y1_client"};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV12Linkselection_GXI)},c2v:function(n){gx.O.AV12Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV12Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDESTADOTAREA",gxz:"Z17IdEstadoTarea",gxold:"O17IdEstadoTarea",gxvar:"A17IdEstadoTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A17IdEstadoTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17IdEstadoTarea=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDESTADOTAREA",n||gx.fn.currentGridRowImpl(34),gx.O.A17IdEstadoTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A17IdEstadoTarea=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDESTADOTAREA",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTADOTAREA",gxz:"Z18EstadoTarea",gxold:"O18EstadoTarea",gxvar:"A18EstadoTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A18EstadoTarea=n)},v2z:function(n){n!==undefined&&(gx.O.Z18EstadoTarea=n)},v2c:function(n){gx.fn.setGridControlValue("ESTADOTAREA",n||gx.fn.currentGridRowImpl(34),gx.O.A18EstadoTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A18EstadoTarea=this.val(n))},val:function(n){return gx.fn.getGridControlValue("ESTADOTAREA",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"BTN_CANCEL",grid:0,evt:"e170y1_client"};this.AV6cIdEstadoTarea=0;this.ZV6cIdEstadoTarea=0;this.OV6cIdEstadoTarea=0;this.AV7cEstadoTarea="";this.ZV7cEstadoTarea="";this.OV7cEstadoTarea="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z17IdEstadoTarea=0;this.O17IdEstadoTarea=0;this.Z18EstadoTarea="";this.O18EstadoTarea="";this.AV6cIdEstadoTarea=0;this.AV7cEstadoTarea="";this.AV8pIdEstadoTarea=0;this.AV5LinkSelection="";this.A17IdEstadoTarea=0;this.A18EstadoTarea="";this.Events={e160y2_client:["ENTER",!0],e170y1_client:["CANCEL",!0],e130y1_client:["'TOGGLE'",!1],e110y1_client:["LBLIDESTADOTAREAFILTER.CLICK",!1],e120y1_client:["LBLESTADOTAREAFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"},{av:"AV7cEstadoTarea",fld:"vCESTADOTAREA",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLIDESTADOTAREAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class")',ctrl:"IDESTADOTAREAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("IDESTADOTAREAFILTERCONTAINER","Class")',ctrl:"IDESTADOTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDESTADOTAREA","Visible")',ctrl:"vCIDESTADOTAREA",prop:"Visible"}]];this.EvtParms["LBLESTADOTAREAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTADOTAREAFILTERCONTAINER","Class")',ctrl:"ESTADOTAREAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTADOTAREAFILTERCONTAINER","Class")',ctrl:"ESTADOTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTADOTAREA","Visible")',ctrl:"vCESTADOTAREA",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A17IdEstadoTarea",fld:"IDESTADOTAREA",pic:"ZZZ9",hsh:!0}],[{av:"AV8pIdEstadoTarea",fld:"vPIDESTADOTAREA",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"},{av:"AV7cEstadoTarea",fld:"vCESTADOTAREA",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"},{av:"AV7cEstadoTarea",fld:"vCESTADOTAREA",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"},{av:"AV7cEstadoTarea",fld:"vCESTADOTAREA",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdEstadoTarea",fld:"vCIDESTADOTAREA",pic:"ZZZ9"},{av:"AV7cEstadoTarea",fld:"vCESTADOTAREA",pic:""}],[]];this.setVCMap("AV8pIdEstadoTarea","vPIDESTADOTAREA",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);this.Initialize()});gx.wi(function(){gx.createParentObj(gx0060)})