/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:31.62
*/
gx.evt.autoSkip=!1;gx.define("gx0081",!1,function(){var n,t;this.ServerClass="gx0081";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7pIdLineaBase=gx.fn.getIntegerValue("vPIDLINEABASE",",");this.AV8pIdTarea=gx.fn.getIntegerValue("vPIDTAREA",",");this.AV7pIdLineaBase=gx.fn.getIntegerValue("vPIDLINEABASE",",")};this.e122p1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e112p1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("IDTAREAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("IDTAREAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCIDTAREA","Visible",!0)):(gx.fn.setCtrlProperty("IDTAREAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCIDTAREA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("IDTAREAFILTERCONTAINER","Class")',ctrl:"IDTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDTAREA","Visible")',ctrl:"vCIDTAREA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e152p2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e162p1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,26,27,28,29,30];this.GXLastCtrlId=30;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",24,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0081",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",25,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(5,26,"IDTAREA","Id de Tarea","","IdTarea","int",0,"px",4,4,"right",null,[],5,"IdTarea",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(21,27,"IDLINEABASE","Id Linea Base","","IdLineaBase","int",0,"px",4,4,"right",null,[],21,"IdLineaBase",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"IDTAREAFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLIDTAREAFILTER",format:1,grid:0,evt:"e112p1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCIDTAREA",gxz:"ZV6cIdTarea",gxold:"OV6cIdTarea",gxvar:"AV6cIdTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cIdTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cIdTarea=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCIDTAREA",gx.O.AV6cIdTarea,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cIdTarea=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCIDTAREA",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDTABLE",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTNTOGGLE",grid:0,evt:"e122p1_client"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[25]={id:25,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(24),gx.O.AV5LinkSelection,gx.O.AV12Linkselection_GXI)},c2v:function(n){gx.O.AV12Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(24))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(24))},gxvar_GXI:"AV12Linkselection_GXI",nac:gx.falseFn};n[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDTAREA",gxz:"Z5IdTarea",gxold:"O5IdTarea",gxvar:"A5IdTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A5IdTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5IdTarea=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDTAREA",n||gx.fn.currentGridRowImpl(24),gx.O.A5IdTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A5IdTarea=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDTAREA",n||gx.fn.currentGridRowImpl(24),",")},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDLINEABASE",gxz:"Z21IdLineaBase",gxold:"O21IdLineaBase",gxvar:"A21IdLineaBase",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A21IdLineaBase=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z21IdLineaBase=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDLINEABASE",n||gx.fn.currentGridRowImpl(24),gx.O.A21IdLineaBase,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A21IdLineaBase=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDLINEABASE",n||gx.fn.currentGridRowImpl(24),",")},nac:gx.falseFn};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"BTN_CANCEL",grid:0,evt:"e162p1_client"};this.AV6cIdTarea=0;this.ZV6cIdTarea=0;this.OV6cIdTarea=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z5IdTarea=0;this.O5IdTarea=0;this.Z21IdLineaBase=0;this.O21IdLineaBase=0;this.AV6cIdTarea=0;this.AV7pIdLineaBase=0;this.AV8pIdTarea=0;this.AV5LinkSelection="";this.A5IdTarea=0;this.A21IdLineaBase=0;this.Events={e152p2_client:["ENTER",!0],e162p1_client:["CANCEL",!0],e122p1_client:["'TOGGLE'",!1],e112p1_client:["LBLIDTAREAFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7pIdLineaBase",fld:"vPIDLINEABASE",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLIDTAREAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("IDTAREAFILTERCONTAINER","Class")',ctrl:"IDTAREAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("IDTAREAFILTERCONTAINER","Class")',ctrl:"IDTAREAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDTAREA","Visible")',ctrl:"vCIDTAREA",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A5IdTarea",fld:"IDTAREA",pic:"ZZZ9",hsh:!0}],[{av:"AV8pIdTarea",fld:"vPIDTAREA",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7pIdLineaBase",fld:"vPIDLINEABASE",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7pIdLineaBase",fld:"vPIDLINEABASE",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7pIdLineaBase",fld:"vPIDLINEABASE",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cIdTarea",fld:"vCIDTAREA",pic:"ZZZ9"},{av:"AV7pIdLineaBase",fld:"vPIDLINEABASE",pic:"ZZZ9"}],[]];this.setVCMap("AV7pIdLineaBase","vPIDLINEABASE",0,"int",4,0);this.setVCMap("AV8pIdTarea","vPIDTAREA",0,"int",4,0);this.setVCMap("AV7pIdLineaBase","vPIDLINEABASE",0,"int",4,0);this.setVCMap("AV7pIdLineaBase","vPIDLINEABASE",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV7pIdLineaBase"});t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm({rfrVar:"AV7pIdLineaBase"});this.Initialize()});gx.wi(function(){gx.createParentObj(gx0081)})