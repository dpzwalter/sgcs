/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:28.52
*/
gx.evt.autoSkip=!1;gx.define("estadoproyectowc",!0,function(n){var t,i;this.ServerClass="estadoproyectowc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6IdEstado=gx.fn.getIntegerValue("vIDESTADO",",");this.AV6IdEstado=gx.fn.getIntegerValue("vIDESTADO",",")};this.e110i2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e140i2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e150i2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29,30];this.GXLastCtrlId=30;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"estadoproyectowc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(1,21,"IDPROYECTO","Id de Proyecto","","IdProyecto","int",0,"px",4,4,"right",null,[],1,"IdProyecto",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(2,22,"NOMBREPROYECTO","Nombre de Proyecto","","NombreProyecto","char",0,"px",60,60,"left",null,[],2,"NombreProyecto",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addSingleLineEdit(4,23,"DESCRIPCIONPROYECTO","Descripcion de Proyecto","","DescripcionProyecto","char",0,"px",60,60,"left",null,[],4,"DescripcionProyecto",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(3,24,"FECHACREACION","Fecha Creacion","","FechaCreacion","date",0,"px",8,8,"right",null,[],3,"FechaCreacion",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit("Update",25,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");i.addSingleLineEdit("Delete",26,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0,evt:"e110i2_client"};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDPROYECTO",gxz:"Z1IdProyecto",gxold:"O1IdProyecto",gxvar:"A1IdProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1IdProyecto=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1IdProyecto=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDPROYECTO",n||gx.fn.currentGridRowImpl(20),gx.O.A1IdProyecto,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A1IdProyecto=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDPROYECTO",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOMBREPROYECTO",gxz:"Z2NombreProyecto",gxold:"O2NombreProyecto",gxvar:"A2NombreProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A2NombreProyecto=n)},v2z:function(n){n!==undefined&&(gx.O.Z2NombreProyecto=n)},v2c:function(n){gx.fn.setGridControlValue("NOMBREPROYECTO",n||gx.fn.currentGridRowImpl(20),gx.O.A2NombreProyecto,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A2NombreProyecto=this.val(n))},val:function(n){return gx.fn.getGridControlValue("NOMBREPROYECTO",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESCRIPCIONPROYECTO",gxz:"Z4DescripcionProyecto",gxold:"O4DescripcionProyecto",gxvar:"A4DescripcionProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A4DescripcionProyecto=n)},v2z:function(n){n!==undefined&&(gx.O.Z4DescripcionProyecto=n)},v2c:function(n){gx.fn.setGridControlValue("DESCRIPCIONPROYECTO",n||gx.fn.currentGridRowImpl(20),gx.O.A4DescripcionProyecto,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A4DescripcionProyecto=this.val(n))},val:function(n){return gx.fn.getGridControlValue("DESCRIPCIONPROYECTO",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"date",len:8,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FECHACREACION",gxz:"Z3FechaCreacion",gxold:"O3FechaCreacion",gxvar:"A3FechaCreacion",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A3FechaCreacion=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z3FechaCreacion=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("FECHACREACION",n||gx.fn.currentGridRowImpl(20),gx.O.A3FechaCreacion,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A3FechaCreacion=gx.fn.toDatetimeValue(this.val(n)))},val:function(n){return gx.fn.getGridDateTimeValue("FECHACREACION",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Update,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV12Update=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[26]={id:26,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV13Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV13Delete,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV13Delete=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"",grid:0};t[30]={id:30,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDESTADO",gxz:"Z11IdEstado",gxold:"O11IdEstado",gxvar:"A11IdEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11IdEstado=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11IdEstado=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("IDESTADO",gx.O.A11IdEstado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11IdEstado=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("IDESTADO",",")},nac:gx.falseFn};this.Z1IdProyecto=0;this.O1IdProyecto=0;this.Z2NombreProyecto="";this.O2NombreProyecto="";this.Z4DescripcionProyecto="";this.O4DescripcionProyecto="";this.Z3FechaCreacion=gx.date.nullDate();this.O3FechaCreacion=gx.date.nullDate();this.ZV12Update="";this.OV12Update="";this.ZV13Delete="";this.OV13Delete="";this.A11IdEstado=0;this.Z11IdEstado=0;this.O11IdEstado=0;this.A11IdEstado=0;this.AV6IdEstado=0;this.A1IdProyecto=0;this.A2NombreProyecto="";this.A4DescripcionProyecto="";this.A3FechaCreacion=gx.date.nullDate();this.AV12Update="";this.AV13Delete="";this.Events={e110i2_client:["'DOINSERT'",!0],e140i2_client:["ENTER",!0],e150i2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdEstado",fld:"vIDESTADO",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6IdEstado",fld:"vIDESTADO",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("IDESTADO","Visible")',ctrl:"IDESTADO",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A1IdProyecto",fld:"IDPROYECTO",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("NOMBREPROYECTO","Link")',ctrl:"NOMBREPROYECTO",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A1IdProyecto",fld:"IDPROYECTO",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdEstado",fld:"vIDESTADO",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdEstado",fld:"vIDESTADO",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdEstado",fld:"vIDESTADO",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdEstado",fld:"vIDESTADO",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.setVCMap("AV6IdEstado","vIDESTADO",0,"int",4,0);this.setVCMap("AV6IdEstado","vIDESTADO",0,"int",4,0);this.setVCMap("AV6IdEstado","vIDESTADO",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6IdEstado"});i.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});i.addRefreshingParm({rfrVar:"AV6IdEstado"});i.addRefreshingParm({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingParm({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()})