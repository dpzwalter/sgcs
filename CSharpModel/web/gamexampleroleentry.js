/*!   GeneXus C# 16_0_7-138086 on 4/15/2020 11:7:13.69
*/
gx.evt.autoSkip=!1;gx.define("gamexampleroleentry",!1,function(){this.ServerClass="gamexampleroleentry";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.e131b1_client=function(){return this.clearMessages(),this.call("gamexamplewwrolepermissions.aspx",[this.AV11Id,0]),this.refreshOutputs([{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}]),gx.$.Deferred().resolve()};this.e141b1_client=function(){return this.clearMessages(),this.call("gamexampleroleentry.aspx",["DLT",this.AV11Id]),this.refreshOutputs([{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}]),gx.$.Deferred().resolve()};this.e111b1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ACTIONSCONTAINER","Class")=="ActionsContainer"?gx.fn.setCtrlProperty("ACTIONSCONTAINER","Class","ActionsContainerVisible"):gx.fn.setCtrlProperty("ACTIONSCONTAINER","Class","ActionsContainer"),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ACTIONSCONTAINER","Class")',ctrl:"ACTIONSCONTAINER",prop:"Class"}]),gx.$.Deferred().resolve()};this.e121b1_client=function(){return this.clearMessages(),this.call("gamexampleroleentry.aspx",["UPD",this.AV11Id]),this.refreshOutputs([{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}]),gx.$.Deferred().resolve()};this.e161b2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e171b2_client=function(){return this.executeServerEvent("'ROLECHILDREN'",!0,null,!1,!1)};this.e191b1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88];this.GXLastCtrlId=88;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLE2",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TEXTBLOCK1",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"SHOWHIDE",grid:0,evt:"e111b1_client"};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"ACTIONSCONTAINER",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEEDIT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"IMAGE4",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"TEXTBLOCK2",format:0,grid:0,evt:"e121b1_client"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"TABLE4",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"IMAGE1",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"CHILDREN",format:0,grid:0,evt:"e171b2_client"};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"TABLE6",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"IMAGE3",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"PERMISSION",format:0,grid:0,evt:"e131b1_client"};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"TABLE5",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"IMAGE2",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"DELETEROLE",format:0,grid:0,evt:"e141b1_client"};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"TABLE1",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"int",len:12,dec:0,sign:!1,pic:"ZZZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vID",gxz:"ZV11Id",gxold:"OV11Id",gxvar:"AV11Id",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11Id=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11Id=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vID",gx.O.AV11Id,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV11Id=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vID",",")},nac:gx.falseFn};this.declareDomainHdlr(56,function(){});n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vGUID",gxz:"ZV10GUID",gxold:"OV10GUID",gxvar:"AV10GUID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10GUID=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10GUID=n)},v2c:function(){gx.fn.setControlValue("vGUID",gx.O.AV10GUID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV10GUID=this.val())},val:function(){return gx.fn.getControlValue("vGUID")},nac:gx.falseFn};this.declareDomainHdlr(61,function(){});n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNAME",gxz:"ZV12Name",gxold:"OV12Name",gxvar:"AV12Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12Name=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Name=n)},v2c:function(){gx.fn.setControlValue("vNAME",gx.O.AV12Name,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV12Name=this.val())},val:function(){return gx.fn.getControlValue("vNAME")},nac:gx.falseFn};this.declareDomainHdlr(66,function(){});n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDSC",gxz:"ZV5Dsc",gxold:"OV5Dsc",gxvar:"AV5Dsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5Dsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5Dsc=n)},v2c:function(){gx.fn.setControlValue("vDSC",gx.O.AV5Dsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV5Dsc=this.val())},val:function(){return gx.fn.getControlValue("vDSC")},nac:gx.falseFn};this.declareDomainHdlr(71,function(){});n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vEXTID",gxz:"ZV8ExtId",gxold:"OV8ExtId",gxvar:"AV8ExtId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8ExtId=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8ExtId=n)},v2c:function(){gx.fn.setControlValue("vEXTID",gx.O.AV8ExtId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV8ExtId=this.val())},val:function(){return gx.fn.getControlValue("vEXTID")},nac:gx.falseFn};this.declareDomainHdlr(76,function(){});n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECPOLID",gxz:"ZV14SecPolId",gxold:"OV14SecPolId",gxvar:"AV14SecPolId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV14SecPolId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV14SecPolId=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("vSECPOLID",gx.O.AV14SecPolId);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV14SecPolId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECPOLID",",")},nac:gx.falseFn};this.declareDomainHdlr(81,function(){});n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"BTNCANCEL",grid:0,evt:"e191b1_client"};n[87]={id:87,fld:"",grid:0};n[88]={id:88,fld:"BTNCONFIRM",grid:0,evt:"e161b2_client",std:"ENTER"};this.AV11Id=0;this.ZV11Id=0;this.OV11Id=0;this.AV10GUID="";this.ZV10GUID="";this.OV10GUID="";this.AV12Name="";this.ZV12Name="";this.OV12Name="";this.AV5Dsc="";this.ZV5Dsc="";this.OV5Dsc="";this.AV8ExtId="";this.ZV8ExtId="";this.OV8ExtId="";this.AV14SecPolId=0;this.ZV14SecPolId=0;this.OV14SecPolId=0;this.AV11Id=0;this.AV10GUID="";this.AV12Name="";this.AV5Dsc="";this.AV8ExtId="";this.AV14SecPolId=0;this.Gx_mode="";this.Events={e161b2_client:["ENTER",!0],e171b2_client:["'ROLECHILDREN'",!0],e191b1_client:["CANCEL",!0],e131b1_client:["'ROLEPERMISSIONS'",!1],e141b1_client:["'DELETEROLE'",!1],e111b1_client:["'SHOWHIDE'",!1],e121b1_client:["'EDIT'",!1]};this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0}],[]];this.EvtParms.START=[[{ctrl:"vSECPOLID"},{av:"AV14SecPolId",fld:"vSECPOLID",pic:"ZZZZZZZZ9"},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}],[{ctrl:"vSECPOLID"},{av:"AV14SecPolId",fld:"vSECPOLID",pic:"ZZZZZZZZ9"},{av:'gx.fn.getCtrlProperty("TABLEEDIT","Visible")',ctrl:"TABLEEDIT",prop:"Visible"},{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"},{av:"AV10GUID",fld:"vGUID",pic:""},{av:"AV12Name",fld:"vNAME",pic:""},{av:"AV5Dsc",fld:"vDSC",pic:""},{av:"AV8ExtId",fld:"vEXTID",pic:""},{av:'gx.fn.getCtrlProperty("vNAME","Enabled")',ctrl:"vNAME",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vDSC","Enabled")',ctrl:"vDSC",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vEXTID","Enabled")',ctrl:"vEXTID",prop:"Enabled"},{ctrl:"BTNCONFIRM",prop:"Visible"},{ctrl:"BTNCONFIRM",prop:"Caption"},{av:'gx.fn.getCtrlProperty("ACTIONSCONTAINER","Visible")',ctrl:"ACTIONSCONTAINER",prop:"Visible"}]];this.EvtParms.ENTER=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"},{av:"AV12Name",fld:"vNAME",pic:""},{av:"AV5Dsc",fld:"vDSC",pic:""},{av:"AV8ExtId",fld:"vEXTID",pic:""},{ctrl:"vSECPOLID"},{av:"AV14SecPolId",fld:"vSECPOLID",pic:"ZZZZZZZZ9"}],[]];this.EvtParms["'ROLEPERMISSIONS'"]=[[{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}],[{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}]];this.EvtParms["'ROLECHILDREN'"]=[[{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}],[]];this.EvtParms["'DELETEROLE'"]=[[{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}],[{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}]];this.EvtParms["'SHOWHIDE'"]=[[{av:'gx.fn.getCtrlProperty("ACTIONSCONTAINER","Class")',ctrl:"ACTIONSCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ACTIONSCONTAINER","Class")',ctrl:"ACTIONSCONTAINER",prop:"Class"}]];this.EvtParms["'EDIT'"]=[[{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}],[{av:"AV11Id",fld:"vID",pic:"ZZZZZZZZZZZ9"}]];this.EnterCtrl=["BTNCONFIRM"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.wi(function(){gx.createParentObj(gamexampleroleentry)})