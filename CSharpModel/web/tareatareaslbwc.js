/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:29.33
*/
gx.evt.autoSkip=!1;gx.define("tareatareaslbwc",!0,function(n){var t,i;this.ServerClass="tareatareaslbwc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6IdTarea=gx.fn.getIntegerValue("vIDTAREA",",");this.AV6IdTarea=gx.fn.getIntegerValue("vIDTAREA",",")};this.Valid_Idlineabase=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Idlineabase",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("IDLINEABASE",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e112v2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e142v2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e152v2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28];this.GXLastCtrlId=28;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tareatareaslbwc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(21,21,"IDLINEABASE","Id Linea Base","","IdLineaBase","int",0,"px",4,4,"right",null,[],21,"IdLineaBase",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(22,22,"NOMBRELINEABASE","Nombre Linea Base","","NombreLineaBase","char",0,"px",20,20,"left",null,[],22,"NombreLineaBase",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addSingleLineEdit("Update",23,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");i.addSingleLineEdit("Delete",24,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0,evt:"e112v2_client"};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Idlineabase,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDLINEABASE",gxz:"Z21IdLineaBase",gxold:"O21IdLineaBase",gxvar:"A21IdLineaBase",ucs:[],op:[22],ip:[22,21],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A21IdLineaBase=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z21IdLineaBase=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDLINEABASE",n||gx.fn.currentGridRowImpl(20),gx.O.A21IdLineaBase,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A21IdLineaBase=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDLINEABASE",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOMBRELINEABASE",gxz:"Z22NombreLineaBase",gxold:"O22NombreLineaBase",gxvar:"A22NombreLineaBase",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A22NombreLineaBase=n)},v2z:function(n){n!==undefined&&(gx.O.Z22NombreLineaBase=n)},v2c:function(n){gx.fn.setGridControlValue("NOMBRELINEABASE",n||gx.fn.currentGridRowImpl(20),gx.O.A22NombreLineaBase,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A22NombreLineaBase=this.val(n))},val:function(n){return gx.fn.getGridControlValue("NOMBRELINEABASE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV11Update",gxold:"OV11Update",gxvar:"AV11Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV11Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV11Update,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV11Update=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV12Delete",gxold:"OV12Delete",gxvar:"AV12Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Delete,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV12Delete=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDTAREA",gxz:"Z5IdTarea",gxold:"O5IdTarea",gxvar:"A5IdTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5IdTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5IdTarea=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("IDTAREA",gx.O.A5IdTarea,0)},c2v:function(){this.val()!==undefined&&(gx.O.A5IdTarea=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("IDTAREA",",")},nac:gx.falseFn};this.Z21IdLineaBase=0;this.O21IdLineaBase=0;this.Z22NombreLineaBase="";this.O22NombreLineaBase="";this.ZV11Update="";this.OV11Update="";this.ZV12Delete="";this.OV12Delete="";this.A5IdTarea=0;this.Z5IdTarea=0;this.O5IdTarea=0;this.A5IdTarea=0;this.AV6IdTarea=0;this.A21IdLineaBase=0;this.A22NombreLineaBase="";this.AV11Update="";this.AV12Delete="";this.Events={e112v2_client:["'DOINSERT'",!0],e142v2_client:["ENTER",!0],e152v2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdTarea",fld:"vIDTAREA",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6IdTarea",fld:"vIDTAREA",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("IDTAREA","Visible")',ctrl:"IDTAREA",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A21IdLineaBase",fld:"IDLINEABASE",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("NOMBRELINEABASE","Link")',ctrl:"NOMBRELINEABASE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A21IdLineaBase",fld:"IDLINEABASE",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdTarea",fld:"vIDTAREA",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdTarea",fld:"vIDTAREA",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdTarea",fld:"vIDTAREA",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdTarea",fld:"vIDTAREA",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.VALID_IDLINEABASE=[[{av:"A22NombreLineaBase",fld:"NOMBRELINEABASE",pic:""},{av:"A21IdLineaBase",fld:"IDLINEABASE",pic:"ZZZ9",hsh:!0}],[{av:"A22NombreLineaBase",fld:"NOMBRELINEABASE",pic:""}]];this.setVCMap("AV6IdTarea","vIDTAREA",0,"int",4,0);this.setVCMap("AV6IdTarea","vIDTAREA",0,"int",4,0);this.setVCMap("AV6IdTarea","vIDTAREA",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6IdTarea"});i.addRefreshingVar({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});i.addRefreshingParm({rfrVar:"AV6IdTarea"});i.addRefreshingParm({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingParm({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()})