/*!   GeneXus C# 16_0_10-142546 on 8/25/2020 23:18:38.76
*/
gx.evt.autoSkip=!1;gx.define("menugeneral",!0,function(n){this.ServerClass="menugeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Menuxid=function(){return this.validCliEvt("Valid_Menuxid",0,function(){try{var n=gx.util.balloon.getNew("MENUXID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e11311_client=function(){return this.clearMessages(),this.call("menu.aspx",["UPD",this.A27MenuXid]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e12311_client=function(){return this.clearMessages(),this.call("menu.aspx",["DLT",this.A27MenuXid]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e15312_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16312_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43];this.GXLastCtrlId=43;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0,evt:"e11311_client"};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0,evt:"e12311_client"};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Menuxid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENUXID",gxz:"Z27MenuXid",gxold:"O27MenuXid",gxvar:"A27MenuXid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A27MenuXid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z27MenuXid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MENUXID",gx.O.A27MenuXid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A27MenuXid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MENUXID",",")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENUXDESC",gxz:"Z28MenuXDesc",gxold:"O28MenuXDesc",gxvar:"A28MenuXDesc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A28MenuXDesc=n)},v2z:function(n){n!==undefined&&(gx.O.Z28MenuXDesc=n)},v2c:function(){gx.fn.setControlValue("MENUXDESC",gx.O.A28MenuXDesc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A28MenuXDesc=this.val())},val:function(){return gx.fn.getControlValue("MENUXDESC")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENUXPOSI",gxz:"Z29MenuXPosi",gxold:"O29MenuXPosi",gxvar:"A29MenuXPosi",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A29MenuXPosi=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z29MenuXPosi=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MENUXPOSI",gx.O.A29MenuXPosi,0)},c2v:function(){this.val()!==undefined&&(gx.O.A29MenuXPosi=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MENUXPOSI",",")},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENXURL",gxz:"Z30MenXUrl",gxold:"O30MenXUrl",gxvar:"A30MenXUrl",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A30MenXUrl=n)},v2z:function(n){n!==undefined&&(gx.O.Z30MenXUrl=n)},v2c:function(){gx.fn.setControlValue("MENXURL",gx.O.A30MenXUrl,0)},c2v:function(){this.val()!==undefined&&(gx.O.A30MenXUrl=this.val())},val:function(){return gx.fn.getControlValue("MENXURL")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENXEST",gxz:"Z31MenXEst",gxold:"O31MenXEst",gxvar:"A31MenXEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A31MenXEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z31MenXEst=n)},v2c:function(){gx.fn.setComboBoxValue("MENXEST",gx.O.A31MenXEst);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A31MenXEst=this.val())},val:function(){return gx.fn.getControlValue("MENXEST")},nac:gx.falseFn};this.declareDomainHdlr(38,function(){});t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENXPADRE",gxz:"Z43MenXPadre",gxold:"O43MenXPadre",gxvar:"A43MenXPadre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A43MenXPadre=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z43MenXPadre=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MENXPADRE",gx.O.A43MenXPadre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A43MenXPadre=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MENXPADRE",",")},nac:gx.falseFn};this.A27MenuXid=0;this.Z27MenuXid=0;this.O27MenuXid=0;this.A28MenuXDesc="";this.Z28MenuXDesc="";this.O28MenuXDesc="";this.A29MenuXPosi=0;this.Z29MenuXPosi=0;this.O29MenuXPosi=0;this.A30MenXUrl="";this.Z30MenXUrl="";this.O30MenXUrl="";this.A31MenXEst="";this.Z31MenXEst="";this.O31MenXEst="";this.A43MenXPadre=0;this.Z43MenXPadre=0;this.O43MenXPadre=0;this.A27MenuXid=0;this.A28MenuXDesc="";this.A29MenuXPosi=0;this.A30MenXUrl="";this.A31MenXEst="";this.A43MenXPadre=0;this.Events={e15312_client:["ENTER",!0],e16312_client:["CANCEL",!0],e11311_client:["'DOUPDATE'",!1],e12311_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[{av:"A27MenuXid",fld:"MENUXID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6MenuXid",fld:"vMENUXID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A27MenuXid",fld:"MENUXID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A27MenuXid",fld:"MENUXID",pic:"ZZZ9"}],[]];this.EvtParms.VALID_MENUXID=[[],[]];this.Initialize()})