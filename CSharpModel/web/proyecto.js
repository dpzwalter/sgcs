/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:29.79
*/
gx.evt.autoSkip=!1;gx.define("proyecto",!1,function(){this.ServerClass="proyecto";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7IdProyecto=gx.fn.getIntegerValue("vIDPROYECTO",",");this.AV11Insert_IdEstado=gx.fn.getIntegerValue("vINSERT_IDESTADO",",");this.Gx_date=gx.fn.getDateValue("vTODAY");this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",",");this.AV15Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Idproyecto=function(){return this.validCliEvt("Valid_Idproyecto",0,function(){try{var n=gx.util.balloon.getNew("IDPROYECTO");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Idestado=function(){return this.validSrvEvt("Valid_Idestado",0).then(function(n){return n}.closure(this))};this.e12012_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e13011_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14011_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69];this.GXLastCtrlId=69;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0,evt:"e15011_client",std:"FIRST"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0,evt:"e16011_client",std:"PREVIOUS"};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0,evt:"e17011_client",std:"NEXT"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0,evt:"e18011_client",std:"LAST"};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0,evt:"e19011_client",std:"SELECT"};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Idproyecto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDPROYECTO",gxz:"Z1IdProyecto",gxold:"O1IdProyecto",gxvar:"A1IdProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1IdProyecto=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1IdProyecto=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("IDPROYECTO",gx.O.A1IdProyecto,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1IdProyecto=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("IDPROYECTO",",")},nac:gx.falseFn};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"char",len:60,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOMBREPROYECTO",gxz:"Z2NombreProyecto",gxold:"O2NombreProyecto",gxvar:"A2NombreProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2NombreProyecto=n)},v2z:function(n){n!==undefined&&(gx.O.Z2NombreProyecto=n)},v2c:function(){gx.fn.setControlValue("NOMBREPROYECTO",gx.O.A2NombreProyecto,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2NombreProyecto=this.val())},val:function(){return gx.fn.getControlValue("NOMBREPROYECTO")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"char",len:60,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESCRIPCIONPROYECTO",gxz:"Z4DescripcionProyecto",gxold:"O4DescripcionProyecto",gxvar:"A4DescripcionProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4DescripcionProyecto=n)},v2z:function(n){n!==undefined&&(gx.O.Z4DescripcionProyecto=n)},v2c:function(){gx.fn.setControlValue("DESCRIPCIONPROYECTO",gx.O.A4DescripcionProyecto,0)},c2v:function(){this.val()!==undefined&&(gx.O.A4DescripcionProyecto=this.val())},val:function(){return gx.fn.getControlValue("DESCRIPCIONPROYECTO")},nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Idestado,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDESTADO",gxz:"Z11IdEstado",gxold:"O11IdEstado",gxvar:"A11IdEstado",ucs:[],op:[54],ip:[54,49],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11IdEstado=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11IdEstado=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("IDESTADO",gx.O.A11IdEstado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11IdEstado=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("IDESTADO",",")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV11Insert_IdEstado)}};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTADO",gxz:"Z12Estado",gxold:"O12Estado",gxvar:"A12Estado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A12Estado=n)},v2z:function(n){n!==undefined&&(gx.O.Z12Estado=n)},v2c:function(){gx.fn.setControlValue("ESTADO",gx.O.A12Estado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12Estado=this.val())},val:function(){return gx.fn.getControlValue("ESTADO")},nac:gx.falseFn};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"date",len:8,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FECHACREACION",gxz:"Z3FechaCreacion",gxold:"O3FechaCreacion",gxvar:"A3FechaCreacion",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3FechaCreacion=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z3FechaCreacion=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("FECHACREACION",gx.O.A3FechaCreacion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3FechaCreacion=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("FECHACREACION")},nac:gx.falseFn};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"BTN_ENTER",grid:0,evt:"e13011_client",std:"ENTER"};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"BTN_CANCEL",grid:0,evt:"e14011_client"};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"BTN_DELETE",grid:0,evt:"e20011_client",std:"DELETE"};n[69]={id:69,fld:"PROMPT_11",grid:0};this.A1IdProyecto=0;this.Z1IdProyecto=0;this.O1IdProyecto=0;this.A2NombreProyecto="";this.Z2NombreProyecto="";this.O2NombreProyecto="";this.A4DescripcionProyecto="";this.Z4DescripcionProyecto="";this.O4DescripcionProyecto="";this.A11IdEstado=0;this.Z11IdEstado=0;this.O11IdEstado=0;this.A12Estado="";this.Z12Estado="";this.O12Estado="";this.A3FechaCreacion=gx.date.nullDate();this.Z3FechaCreacion=gx.date.nullDate();this.O3FechaCreacion=gx.date.nullDate();this.AV15Pgmname="";this.AV9TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV11Insert_IdEstado=0;this.AV16GXV1=0;this.AV12TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7IdProyecto=0;this.AV10WebSession={};this.A1IdProyecto=0;this.A11IdEstado=0;this.Gx_BScreen=0;this.Gx_date=gx.date.nullDate();this.A2NombreProyecto="";this.A4DescripcionProyecto="";this.A12Estado="";this.A3FechaCreacion=gx.date.nullDate();this.Gx_mode="";this.Events={e12012_client:["AFTER TRN",!0],e13011_client:["ENTER",!0],e14011_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7IdProyecto",fld:"vIDPROYECTO",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0},{av:"AV7IdProyecto",fld:"vIDPROYECTO",pic:"ZZZ9",hsh:!0},{av:"A1IdProyecto",fld:"IDPROYECTO",pic:"ZZZ9"},{av:"A3FechaCreacion",fld:"FECHACREACION",pic:""}],[]];this.EvtParms.START=[[{av:"AV15Pgmname",fld:"vPGMNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0}],[{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0},{av:"AV11Insert_IdEstado",fld:"vINSERT_IDESTADO",pic:"ZZZ9"},{av:"AV16GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV12TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:"",hsh:!0}],[]];this.EvtParms.VALID_IDPROYECTO=[[],[]];this.EvtParms.VALID_IDESTADO=[[{av:"A11IdEstado",fld:"IDESTADO",pic:"ZZZ9"},{av:"A12Estado",fld:"ESTADO",pic:""}],[{av:"A12Estado",fld:"ESTADO",pic:""}]];this.setPrompt("PROMPT_11",[49]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7IdProyecto","vIDPROYECTO",0,"int",4,0);this.setVCMap("AV11Insert_IdEstado","vINSERT_IDESTADO",0,"int",4,0);this.setVCMap("Gx_date","vTODAY",0,"date",8,0);this.setVCMap("Gx_BScreen","vGXBSCREEN",0,"int",1,0);this.setVCMap("AV15Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV9TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);this.Initialize()});gx.wi(function(){gx.createParentObj(proyecto)})