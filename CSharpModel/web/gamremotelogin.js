/*!   GeneXus C# 16_0_7-138086 on 4/15/2020 11:11:1.65
*/
gx.evt.autoSkip=!1;gx.define("gamremotelogin",!1,function(){this.ServerClass="gamremotelogin";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6ApplicationClientId=gx.fn.getControlValue("vAPPLICATIONCLIENTID");this.AV18Language=gx.fn.getControlValue("vLANGUAGE");this.AV29UserRememberMe=gx.fn.getIntegerValue("vUSERREMEMBERME",",");this.AV6ApplicationClientId=gx.fn.getControlValue("vAPPLICATIONCLIENTID")};this.e112c1_client=function(){return this.clearMessages(),this.call("gamexamplerecoverpasswordstep1.aspx",[this.AV6ApplicationClientId]),this.refreshOutputs([{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}]),gx.$.Deferred().resolve()};this.e142c2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e162c2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50];this.GXLastCtrlId=50;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLE1",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TBLLOGIN",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"TEXTBLOCK1",format:0,grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLOGOAPPCLIENT",gxz:"ZV20LogoAppClient",gxold:"OV20LogoAppClient",gxvar:"AV20LogoAppClient",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV20LogoAppClient=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20LogoAppClient=n)},v2c:function(){gx.fn.setMultimediaValue("vLOGOAPPCLIENT",gx.O.AV20LogoAppClient,gx.O.AV32Logoappclient_GXI)},c2v:function(){gx.O.AV32Logoappclient_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV20LogoAppClient=this.val())},val:function(){return gx.fn.getBlobValue("vLOGOAPPCLIENT")},val_GXI:function(){return gx.fn.getControlValue("vLOGOAPPCLIENT_GXI")},gxvar_GXI:"AV32Logoappclient_GXI",nac:gx.falseFn};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"TBAPPNAME",format:0,grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:60,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLOGONTO",gxz:"ZV21LogOnTo",gxold:"OV21LogOnTo",gxvar:"AV21LogOnTo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV21LogOnTo=n)},v2z:function(n){n!==undefined&&(gx.O.ZV21LogOnTo=n)},v2c:function(){gx.fn.setComboBoxValue("vLOGONTO",gx.O.AV21LogOnTo);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV21LogOnTo=this.val())},val:function(){return gx.fn.getControlValue("vLOGONTO")},nac:gx.falseFn};this.declareDomainHdlr(26,function(){});n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,lvl:0,type:"svchar",len:100,dec:60,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERNAME",gxz:"ZV27UserName",gxold:"OV27UserName",gxvar:"AV27UserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV27UserName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV27UserName=n)},v2c:function(){gx.fn.setControlValue("vUSERNAME",gx.O.AV27UserName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV27UserName=this.val())},val:function(){return gx.fn.getControlValue("vUSERNAME")},nac:gx.falseFn};this.declareDomainHdlr(30,function(){});n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"char",len:50,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERPASSWORD",gxz:"ZV28UserPassword",gxold:"OV28UserPassword",gxvar:"AV28UserPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV28UserPassword=n)},v2z:function(n){n!==undefined&&(gx.O.ZV28UserPassword=n)},v2c:function(){gx.fn.setControlValue("vUSERPASSWORD",gx.O.AV28UserPassword,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV28UserPassword=this.val())},val:function(){return gx.fn.getControlValue("vUSERPASSWORD")},nac:gx.falseFn};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vKEEPMELOGGEDIN",gxz:"ZV17KeepMeLoggedIn",gxold:"OV17KeepMeLoggedIn",gxvar:"AV17KeepMeLoggedIn",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.AV17KeepMeLoggedIn=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV17KeepMeLoggedIn=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("vKEEPMELOGGEDIN",gx.O.AV17KeepMeLoggedIn,!0)},c2v:function(){this.val()!==undefined&&(gx.O.AV17KeepMeLoggedIn=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vKEEPMELOGGEDIN")},nac:gx.falseFn,values:["true","false"]};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vREMEMBERME",gxz:"ZV22RememberMe",gxold:"OV22RememberMe",gxvar:"AV22RememberMe",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.AV22RememberMe=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV22RememberMe=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("vREMEMBERME",gx.O.AV22RememberMe,!0)},c2v:function(){this.val()!==undefined&&(gx.O.AV22RememberMe=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vREMEMBERME")},nac:gx.falseFn,values:["true","false"]};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"ENTER",grid:0,evt:"e142c2_client",std:"ENTER"};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"TEXTBLOCK3",format:0,grid:0,evt:"e112c1_client"};this.AV32Logoappclient_GXI="";this.AV20LogoAppClient="";this.ZV20LogoAppClient="";this.OV20LogoAppClient="";this.AV21LogOnTo="";this.ZV21LogOnTo="";this.OV21LogOnTo="";this.AV27UserName="";this.ZV27UserName="";this.OV27UserName="";this.AV28UserPassword="";this.ZV28UserPassword="";this.OV28UserPassword="";this.AV17KeepMeLoggedIn=!1;this.ZV17KeepMeLoggedIn=!1;this.OV17KeepMeLoggedIn=!1;this.AV22RememberMe=!1;this.ZV22RememberMe=!1;this.OV22RememberMe=!1;this.AV20LogoAppClient="";this.AV21LogOnTo="";this.AV27UserName="";this.AV28UserPassword="";this.AV17KeepMeLoggedIn=!1;this.AV22RememberMe=!1;this.AV6ApplicationClientId="";this.AV18Language="";this.AV29UserRememberMe=0;this.Events={e142c2_client:["ENTER",!0],e162c2_client:["CANCEL",!0],e112c1_client:["'FORGOTPASSWORD'",!1]};this.EvtParms.REFRESH=[[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV27UserName",fld:"vUSERNAME",pic:""},{av:"AV18Language",fld:"vLANGUAGE",pic:"",hsh:!0},{av:"AV29UserRememberMe",fld:"vUSERREMEMBERME",pic:"Z9",hsh:!0},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}],[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV28UserPassword",fld:"vUSERPASSWORD",pic:""},{av:'gx.fn.getCtrlProperty("TBLLOGIN","Visible")',ctrl:"TBLLOGIN",prop:"Visible"},{ctrl:"vLOGONTO"},{av:"AV21LogOnTo",fld:"vLOGONTO",pic:""},{av:'gx.fn.getCtrlProperty("vREMEMBERME","Visible")',ctrl:"vREMEMBERME",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vKEEPMELOGGEDIN","Visible")',ctrl:"vKEEPMELOGGEDIN",prop:"Visible"},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms.START=[[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}],[{av:'gx.fn.getCtrlProperty("TBAPPNAME","Visible")',ctrl:"TBAPPNAME",prop:"Visible"},{av:"AV20LogoAppClient",fld:"vLOGOAPPCLIENT",pic:""},{av:'gx.fn.getCtrlProperty("TBAPPNAME","Caption")',ctrl:"TBAPPNAME",prop:"Caption"},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms.ENTER=[[{ctrl:"vLOGONTO"},{av:"AV21LogOnTo",fld:"vLOGONTO",pic:""},{av:"AV27UserName",fld:"vUSERNAME",pic:""},{av:"AV28UserPassword",fld:"vUSERPASSWORD",pic:""},{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}],[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV28UserPassword",fld:"vUSERPASSWORD",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms["'FORGOTPASSWORD'"]=[[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}],[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV22RememberMe",fld:"vREMEMBERME",pic:""}]];this.EnterCtrl=["ENTER"];this.setVCMap("AV6ApplicationClientId","vAPPLICATIONCLIENTID",0,"char",40,0);this.setVCMap("AV18Language","vLANGUAGE",0,"char",3,0);this.setVCMap("AV29UserRememberMe","vUSERREMEMBERME",0,"int",2,0);this.setVCMap("AV6ApplicationClientId","vAPPLICATIONCLIENTID",0,"char",40,0);this.Initialize()});gx.wi(function(){gx.createParentObj(gamremotelogin)})