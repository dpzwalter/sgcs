/*!   GeneXus C# 16_0_7-138086 on 4/15/2020 11:5:14.45
*/
gx.evt.autoSkip=!1;gx.define("gamexamplechangeyourpassword",!1,function(){this.ServerClass="gamexamplechangeyourpassword";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e12172_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14172_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39];this.GXLastCtrlId=39;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLE4",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TEXTBLOCK1",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"TABLE2",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,lvl:0,type:"svchar",len:100,dec:60,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERNAME",gxz:"ZV8UserName",gxold:"OV8UserName",gxvar:"AV8UserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8UserName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8UserName=n)},v2c:function(){gx.fn.setControlValue("vUSERNAME",gx.O.AV8UserName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV8UserName=this.val())},val:function(){return gx.fn.getControlValue("vUSERNAME")},nac:gx.falseFn};this.declareDomainHdlr(19,function(){});n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,lvl:0,type:"char",len:50,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERPASSWORD",gxz:"ZV9UserPassword",gxold:"OV9UserPassword",gxvar:"AV9UserPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9UserPassword=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9UserPassword=n)},v2c:function(){gx.fn.setControlValue("vUSERPASSWORD",gx.O.AV9UserPassword,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV9UserPassword=this.val())},val:function(){return gx.fn.getControlValue("vUSERPASSWORD")},nac:gx.falseFn};this.declareDomainHdlr(24,function(){});n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,lvl:0,type:"char",len:50,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERPASSWORDNEW",gxz:"ZV10UserPasswordNew",gxold:"OV10UserPasswordNew",gxvar:"AV10UserPasswordNew",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10UserPasswordNew=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10UserPasswordNew=n)},v2c:function(){gx.fn.setControlValue("vUSERPASSWORDNEW",gx.O.AV10UserPasswordNew,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV10UserPasswordNew=this.val())},val:function(){return gx.fn.getControlValue("vUSERPASSWORDNEW")},nac:gx.falseFn};this.declareDomainHdlr(29,function(){});n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"char",len:50,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERPASSWORDNEWCONF",gxz:"ZV11UserPasswordNewConf",gxold:"OV11UserPasswordNewConf",gxvar:"AV11UserPasswordNewConf",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11UserPasswordNewConf=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11UserPasswordNewConf=n)},v2c:function(){gx.fn.setControlValue("vUSERPASSWORDNEWCONF",gx.O.AV11UserPasswordNewConf,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV11UserPasswordNewConf=this.val())},val:function(){return gx.fn.getControlValue("vUSERPASSWORDNEWCONF")},nac:gx.falseFn};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"CONFIRM",grid:0,evt:"e12172_client",std:"ENTER"};this.AV8UserName="";this.ZV8UserName="";this.OV8UserName="";this.AV9UserPassword="";this.ZV9UserPassword="";this.OV9UserPassword="";this.AV10UserPasswordNew="";this.ZV10UserPasswordNew="";this.OV10UserPasswordNew="";this.AV11UserPasswordNewConf="";this.ZV11UserPasswordNewConf="";this.OV11UserPasswordNewConf="";this.AV8UserName="";this.AV9UserPassword="";this.AV10UserPasswordNew="";this.AV11UserPasswordNewConf="";this.Events={e12172_client:["ENTER",!0],e14172_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[],[{av:"AV8UserName",fld:"vUSERNAME",pic:""}]];this.EvtParms.ENTER=[[{av:"AV10UserPasswordNew",fld:"vUSERPASSWORDNEW",pic:""},{av:"AV11UserPasswordNewConf",fld:"vUSERPASSWORDNEWCONF",pic:""},{av:"AV9UserPassword",fld:"vUSERPASSWORD",pic:""}],[{av:'gx.fn.getCtrlProperty("vUSERPASSWORD","Enabled")',ctrl:"vUSERPASSWORD",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vUSERPASSWORDNEW","Enabled")',ctrl:"vUSERPASSWORDNEW",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vUSERPASSWORDNEWCONF","Enabled")',ctrl:"vUSERPASSWORDNEWCONF",prop:"Enabled"},{ctrl:"CONFIRM",prop:"Visible"}]];this.EnterCtrl=["CONFIRM"];this.Initialize()});gx.wi(function(){gx.createParentObj(gamexamplechangeyourpassword)})