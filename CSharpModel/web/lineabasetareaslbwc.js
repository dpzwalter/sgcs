/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:28.30
*/
gx.evt.autoSkip=!1;gx.define("lineabasetareaslbwc",!0,function(n){var t,i;this.ServerClass="lineabasetareaslbwc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6IdLineaBase=gx.fn.getIntegerValue("vIDLINEABASE",",");this.AV6IdLineaBase=gx.fn.getIntegerValue("vIDLINEABASE",",")};this.Valid_Idtarea=function(){var n=gx.fn.currentGridRowImpl(12);return this.validCliEvt("Valid_Idtarea",12,function(){try{if(gx.fn.currentGridRowImpl(12)===0)return!0;var n=gx.util.balloon.getNew("IDTAREA",gx.fn.currentGridRowImpl(12));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e132u2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e142u2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,13,14,15,16,17,18];this.GXLastCtrlId=18;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"lineabasetareaslbwc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(5,13,"IDTAREA","Id de Tarea","","IdTarea","int",0,"px",4,4,"right",null,[],5,"IdTarea",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(6,14,"NOMBRETAREA","Nombre de Tarea","","NombreTarea","char",0,"px",60,60,"left",null,[],6,"NombreTarea",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"GRIDCELL",grid:0};t[6]={id:6,fld:"GRIDTABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[13]={id:13,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Idtarea,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDTAREA",gxz:"Z5IdTarea",gxold:"O5IdTarea",gxvar:"A5IdTarea",ucs:[],op:[14],ip:[14,13],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A5IdTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5IdTarea=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDTAREA",n||gx.fn.currentGridRowImpl(12),gx.O.A5IdTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A5IdTarea=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDTAREA",n||gx.fn.currentGridRowImpl(12),",")},nac:gx.falseFn};t[14]={id:14,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOMBRETAREA",gxz:"Z6NombreTarea",gxold:"O6NombreTarea",gxvar:"A6NombreTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A6NombreTarea=n)},v2z:function(n){n!==undefined&&(gx.O.Z6NombreTarea=n)},v2c:function(n){gx.fn.setGridControlValue("NOMBRETAREA",n||gx.fn.currentGridRowImpl(12),gx.O.A6NombreTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A6NombreTarea=this.val(n))},val:function(n){return gx.fn.getGridControlValue("NOMBRETAREA",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDLINEABASE",gxz:"Z21IdLineaBase",gxold:"O21IdLineaBase",gxvar:"A21IdLineaBase",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A21IdLineaBase=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z21IdLineaBase=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("IDLINEABASE",gx.O.A21IdLineaBase,0)},c2v:function(){this.val()!==undefined&&(gx.O.A21IdLineaBase=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("IDLINEABASE",",")},nac:gx.falseFn};this.Z5IdTarea=0;this.O5IdTarea=0;this.Z6NombreTarea="";this.O6NombreTarea="";this.A21IdLineaBase=0;this.Z21IdLineaBase=0;this.O21IdLineaBase=0;this.A21IdLineaBase=0;this.AV6IdLineaBase=0;this.A5IdTarea=0;this.A6NombreTarea="";this.Events={e132u2_client:["ENTER",!0],e142u2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdLineaBase",fld:"vIDLINEABASE",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV14Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6IdLineaBase",fld:"vIDLINEABASE",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:'gx.fn.getCtrlProperty("IDLINEABASE","Visible")',ctrl:"IDLINEABASE",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A5IdTarea",fld:"IDTAREA",pic:"ZZZ9"}],[{av:'gx.fn.getCtrlProperty("NOMBRETAREA","Link")',ctrl:"NOMBRETAREA",prop:"Link"}]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdLineaBase",fld:"vIDLINEABASE",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdLineaBase",fld:"vIDLINEABASE",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdLineaBase",fld:"vIDLINEABASE",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdLineaBase",fld:"vIDLINEABASE",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.VALID_IDTAREA=[[{av:"A6NombreTarea",fld:"NOMBRETAREA",pic:""},{av:"A5IdTarea",fld:"IDTAREA",pic:"ZZZ9"}],[{av:"A6NombreTarea",fld:"NOMBRETAREA",pic:""}]];this.setVCMap("AV6IdLineaBase","vIDLINEABASE",0,"int",4,0);this.setVCMap("AV6IdLineaBase","vIDLINEABASE",0,"int",4,0);this.setVCMap("AV6IdLineaBase","vIDLINEABASE",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6IdLineaBase"});i.addRefreshingParm({rfrVar:"AV6IdLineaBase"});this.Initialize()})