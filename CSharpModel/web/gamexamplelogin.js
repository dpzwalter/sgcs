/*!   GeneXus C# 16_0_7-138086 on 4/15/2020 11:5:48.46
*/
gx.evt.autoSkip=!1;gx.define("gamexamplelogin",!1,function(){var n,t;this.ServerClass="gamexamplelogin";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6ApplicationClientId=gx.fn.getControlValue("vAPPLICATIONCLIENTID");this.AV18Language=gx.fn.getControlValue("vLANGUAGE");this.AV34AuxUserName=gx.fn.getControlValue("vAUXUSERNAME");this.AV28UserRememberMe=gx.fn.getIntegerValue("vUSERREMEMBERME",",");this.AV6ApplicationClientId=gx.fn.getControlValue("vAPPLICATIONCLIENTID");this.AV18Language=gx.fn.getControlValue("vLANGUAGE");this.AV34AuxUserName=gx.fn.getControlValue("vAUXUSERNAME");this.AV28UserRememberMe=gx.fn.getIntegerValue("vUSERREMEMBERME",",");this.AV6ApplicationClientId=gx.fn.getControlValue("vAPPLICATIONCLIENTID")};this.Validv_Typeauthtype=function(){var n=gx.fn.currentGridRowImpl(63);return this.validCliEvt("Validv_Typeauthtype",63,function(){try{var n=gx.util.balloon.getNew("vTYPEAUTHTYPE");if(this.AnyError=0,!(this.AV33TypeAuthType=="AppleID"||this.AV33TypeAuthType=="Custom"||this.AV33TypeAuthType=="ExternalWebService"||this.AV33TypeAuthType=="Facebook"||this.AV33TypeAuthType=="GAMLocal"||this.AV33TypeAuthType=="GAMRemote"||this.AV33TypeAuthType=="GAMRemoteRest"||this.AV33TypeAuthType=="Google"||this.AV33TypeAuthType=="Twitter"||this.AV33TypeAuthType=="Oauth20"||this.AV33TypeAuthType=="Saml20"))try{n.setError("Field Type Auth Type is out of range");this.AnyError=gx.num.trunc(1,0)}catch(t){}this.refreshOutputs([{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e11141_client=function(){return this.clearMessages(),this.call("gamexamplerecoverpasswordstep1.aspx",[this.AV6ApplicationClientId]),this.refreshOutputs([{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]),gx.$.Deferred().resolve()};this.e17141_client=function(){return this.clearMessages(),this.call("gamexampleregisteruser.aspx",[]),this.refreshOutputs([{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]),gx.$.Deferred().resolve()};this.e12142_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16142_client=function(){return this.executeServerEvent("'SELECTAUTHENTICATIONTYPE'",!0,arguments[0],!1,!1)};this.e18142_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,53,55,56,57,58,59,60,61,62,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80];this.GXLastCtrlId=80;this.GridauthtypesContainer=new gx.grid.grid(this,2,"WbpLvl2",63,"Gridauthtypes","Gridauthtypes","GridauthtypesContainer",this.CmpContext,this.IsMasterPage,"gamexamplelogin",[],!0,5,!1,!0,0,!1,!1,!1,"",0,"px",0,"px","New row",!1,!1,!1,null,null,!1,"",!0,[2,2,5,5],!1,0,!1,!1);t=this.GridauthtypesContainer;t.startDiv(64,"Grid1table","0px","0px");t.startDiv(65,"","0px","0px");t.startDiv(66,"","45px","0px");t.startDiv(67,"","0px","0px");t.addLabel();t.addBitmap("&Imageauthtype","vIMAGEAUTHTYPE",68,0,"",0,"","e16142_client","","","Fixed30","");t.endDiv();t.endDiv();t.endDiv();t.startDiv(69,"","0px","0px");t.startDiv(70,"","0px","0px");t.startDiv(71,"Tableauthtypeinfo","0px","0px");t.startDiv(72,"","0px","0px");t.startDiv(73,"","0px","0px");t.startDiv(74,"","0px","0px");t.addLabel();t.addComboBox("Typeauthtype",75,"vTYPEAUTHTYPE","","TypeAuthType","char",null,0,!0,!1,30,"chr","");t.endDiv();t.endDiv();t.endDiv();t.startDiv(76,"","0px","0px");t.startDiv(77,"","0px","0px");t.startDiv(78,"","0px","0px");t.addLabel();t.addSingleLineEdit("Nameauthtype",79,"vNAMEAUTHTYPE","","","NameAuthType","char",60,"chr",60,60,"left",null,[],"Nameauthtype","NameAuthType",!0,0,!1,!1,"Attribute",1,"");t.endDiv();t.endDiv();t.endDiv();t.endDiv();t.endDiv();t.endDiv();t.endDiv();this.GridauthtypesContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLE1",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLELOGIN",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"TEXTBLOCK1",format:0,grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"CURRENTREPOSITORY",format:0,grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,lvl:0,type:"char",len:60,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLOGONTO",gxz:"ZV20LogOnTo",gxold:"OV20LogOnTo",gxvar:"AV20LogOnTo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV20LogOnTo=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20LogOnTo=n)},v2c:function(){gx.fn.setComboBoxValue("vLOGONTO",gx.O.AV20LogOnTo);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV20LogOnTo=this.val())},val:function(){return gx.fn.getControlValue("vLOGONTO")},nac:gx.falseFn};this.declareDomainHdlr(23,function(){});n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,lvl:0,type:"svchar",len:100,dec:60,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERNAME",gxz:"ZV26UserName",gxold:"OV26UserName",gxvar:"AV26UserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV26UserName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV26UserName=n)},v2c:function(){gx.fn.setControlValue("vUSERNAME",gx.O.AV26UserName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV26UserName=this.val())},val:function(){return gx.fn.getControlValue("vUSERNAME")},nac:gx.falseFn};this.declareDomainHdlr(27,function(){});n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,lvl:0,type:"char",len:50,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERPASSWORD",gxz:"ZV27UserPassword",gxold:"OV27UserPassword",gxvar:"AV27UserPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV27UserPassword=n)},v2z:function(n){n!==undefined&&(gx.O.ZV27UserPassword=n)},v2c:function(){gx.fn.setControlValue("vUSERPASSWORD",gx.O.AV27UserPassword,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV27UserPassword=this.val())},val:function(){return gx.fn.getControlValue("vUSERPASSWORD")},nac:gx.falseFn};this.declareDomainHdlr(31,function(){});n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vKEEPMELOGGEDIN",gxz:"ZV17KeepMeLoggedIn",gxold:"OV17KeepMeLoggedIn",gxvar:"AV17KeepMeLoggedIn",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.AV17KeepMeLoggedIn=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV17KeepMeLoggedIn=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("vKEEPMELOGGEDIN",gx.O.AV17KeepMeLoggedIn,!0)},c2v:function(){this.val()!==undefined&&(gx.O.AV17KeepMeLoggedIn=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vKEEPMELOGGEDIN")},nac:gx.falseFn,values:["true","false"]};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vREMEMBERME",gxz:"ZV21RememberMe",gxold:"OV21RememberMe",gxvar:"AV21RememberMe",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.AV21RememberMe=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV21RememberMe=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("vREMEMBERME",gx.O.AV21RememberMe,!0)},c2v:function(){this.val()!==undefined&&(gx.O.AV21RememberMe=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vREMEMBERME")},nac:gx.falseFn,values:["true","false"]};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"LOGIN",grid:0,evt:"e12142_client",std:"ENTER"};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"TBREMEMBERME2",format:0,grid:0,evt:"e11141_client"};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"TABLE2",grid:0};n[53]={id:53,fld:"TEXTBLOCK3",format:0,grid:0};n[55]={id:55,fld:"TBREGISTER",format:0,grid:0,evt:"e17141_client"};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"BUTTONS",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"TBEXTERNALAUTHENTICATION",format:0,grid:0};n[62]={id:62,fld:"",grid:0};n[64]={id:64,fld:"GRID1TABLE",grid:63};n[65]={id:65,fld:"",grid:63};n[66]={id:66,fld:"",grid:63};n[67]={id:67,fld:"",grid:63};n[68]={id:68,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:63,gxgrid:this.GridauthtypesContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vIMAGEAUTHTYPE",gxz:"ZV30ImageAuthType",gxold:"OV30ImageAuthType",gxvar:"AV30ImageAuthType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV30ImageAuthType=n)},v2z:function(n){n!==undefined&&(gx.O.ZV30ImageAuthType=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vIMAGEAUTHTYPE",n||gx.fn.currentGridRowImpl(63),gx.O.AV30ImageAuthType,gx.O.AV41Imageauthtype_GXI)},c2v:function(n){gx.O.AV41Imageauthtype_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV30ImageAuthType=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vIMAGEAUTHTYPE",n||gx.fn.currentGridRowImpl(63))},val_GXI:function(n){return gx.fn.getGridControlValue("vIMAGEAUTHTYPE_GXI",n||gx.fn.currentGridRowImpl(63))},gxvar_GXI:"AV41Imageauthtype_GXI",nac:gx.falseFn,evt:"e16142_client"};n[69]={id:69,fld:"",grid:63};n[70]={id:70,fld:"",grid:63};n[71]={id:71,fld:"TABLEAUTHTYPEINFO",grid:63};n[72]={id:72,fld:"",grid:63};n[73]={id:73,fld:"",grid:63};n[74]={id:74,fld:"",grid:63};n[75]={id:75,lvl:2,type:"char",len:30,dec:0,sign:!1,ro:0,isacc:0,grid:63,gxgrid:this.GridauthtypesContainer,fnc:this.Validv_Typeauthtype,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vTYPEAUTHTYPE",gxz:"ZV33TypeAuthType",gxold:"OV33TypeAuthType",gxvar:"AV33TypeAuthType",ucs:[],op:[75],ip:[75],nacdep:[],ctrltype:"combo",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV33TypeAuthType=n)},v2z:function(n){n!==undefined&&(gx.O.ZV33TypeAuthType=n)},v2c:function(n){gx.fn.setGridComboBoxValue("vTYPEAUTHTYPE",n||gx.fn.currentGridRowImpl(63),gx.O.AV33TypeAuthType);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV33TypeAuthType=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vTYPEAUTHTYPE",n||gx.fn.currentGridRowImpl(63))},nac:gx.falseFn};n[76]={id:76,fld:"",grid:63};n[77]={id:77,fld:"",grid:63};n[78]={id:78,fld:"",grid:63};n[79]={id:79,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:0,isacc:0,grid:63,gxgrid:this.GridauthtypesContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNAMEAUTHTYPE",gxz:"ZV32NameAuthType",gxold:"OV32NameAuthType",gxvar:"AV32NameAuthType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV32NameAuthType=n)},v2z:function(n){n!==undefined&&(gx.O.ZV32NameAuthType=n)},v2c:function(n){gx.fn.setGridControlValue("vNAMEAUTHTYPE",n||gx.fn.currentGridRowImpl(63),gx.O.AV32NameAuthType,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV32NameAuthType=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vNAMEAUTHTYPE",n||gx.fn.currentGridRowImpl(63))},nac:gx.falseFn};n[80]={id:80,fld:"",grid:0};this.AV20LogOnTo="";this.ZV20LogOnTo="";this.OV20LogOnTo="";this.AV26UserName="";this.ZV26UserName="";this.OV26UserName="";this.AV27UserPassword="";this.ZV27UserPassword="";this.OV27UserPassword="";this.AV17KeepMeLoggedIn=!1;this.ZV17KeepMeLoggedIn=!1;this.OV17KeepMeLoggedIn=!1;this.AV21RememberMe=!1;this.ZV21RememberMe=!1;this.OV21RememberMe=!1;this.ZV30ImageAuthType="";this.OV30ImageAuthType="";this.ZV33TypeAuthType="";this.OV33TypeAuthType="";this.ZV32NameAuthType="";this.OV32NameAuthType="";this.AV20LogOnTo="";this.AV26UserName="";this.AV27UserPassword="";this.AV17KeepMeLoggedIn=!1;this.AV21RememberMe=!1;this.AV30ImageAuthType="";this.AV33TypeAuthType="";this.AV32NameAuthType="";this.AV6ApplicationClientId="";this.AV18Language="";this.AV34AuxUserName="";this.AV28UserRememberMe=0;this.Events={e12142_client:["ENTER",!0],e16142_client:["'SELECTAUTHENTICATIONTYPE'",!0],e18142_client:["CANCEL",!0],e11141_client:["'FORGOTPASSWORD'",!1],e17141_client:["'REGISTER'",!1]};this.EvtParms.REFRESH=[[{av:"GRIDAUTHTYPES_nFirstRecordOnPage"},{av:"GRIDAUTHTYPES_nEOF"},{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV18Language",fld:"vLANGUAGE",pic:"",hsh:!0},{av:"AV34AuxUserName",fld:"vAUXUSERNAME",pic:"",hsh:!0},{av:"AV28UserRememberMe",fld:"vUSERREMEMBERME",pic:"Z9",hsh:!0},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}],[{av:'gx.fn.getCtrlProperty("GRIDAUTHTYPES","Visible")',ctrl:"GRIDAUTHTYPES",prop:"Visible"},{av:'gx.fn.getCtrlProperty("TABLEAUTHTYPEINFO","Visible")',ctrl:"TABLEAUTHTYPEINFO",prop:"Visible"},{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV27UserPassword",fld:"vUSERPASSWORD",pic:""},{ctrl:"vLOGONTO"},{av:"AV20LogOnTo",fld:"vLOGONTO",pic:""},{av:"AV26UserName",fld:"vUSERNAME",pic:""},{av:'gx.fn.getCtrlProperty("vKEEPMELOGGEDIN","Visible")',ctrl:"vKEEPMELOGGEDIN",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vREMEMBERME","Visible")',ctrl:"vREMEMBERME",prop:"Visible"},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms.START=[[{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}],[{av:'gx.fn.getCtrlProperty("CURRENTREPOSITORY","Visible")',ctrl:"CURRENTREPOSITORY",prop:"Visible"},{av:'gx.fn.getCtrlProperty("CURRENTREPOSITORY","Caption")',ctrl:"CURRENTREPOSITORY",prop:"Caption"},{av:'gx.fn.getCtrlProperty("BUTTONS","Visible")',ctrl:"BUTTONS",prop:"Visible"},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms["GRIDAUTHTYPES.LOAD"]=[[{av:'gx.fn.getCtrlProperty("BUTTONS","Visible")',ctrl:"BUTTONS",prop:"Visible"},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}],[{av:"AV30ImageAuthType",fld:"vIMAGEAUTHTYPE",pic:""},{ctrl:"vTYPEAUTHTYPE"},{av:"AV33TypeAuthType",fld:"vTYPEAUTHTYPE",pic:""},{av:"AV32NameAuthType",fld:"vNAMEAUTHTYPE",pic:"",hsh:!0},{av:'gx.fn.getCtrlProperty("vIMAGEAUTHTYPE","Tooltiptext")',ctrl:"vIMAGEAUTHTYPE",prop:"Tooltiptext"},{av:'gx.fn.getCtrlProperty("BUTTONS","Visible")',ctrl:"BUTTONS",prop:"Visible"},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms.ENTER=[[{ctrl:"vLOGONTO"},{av:"AV20LogOnTo",fld:"vLOGONTO",pic:""},{av:"AV26UserName",fld:"vUSERNAME",pic:""},{av:"AV27UserPassword",fld:"vUSERPASSWORD",pic:""},{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}],[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV27UserPassword",fld:"vUSERPASSWORD",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms["'FORGOTPASSWORD'"]=[[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}],[{av:"AV6ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms["'REGISTER'"]=[[{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}],[{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms["'SELECTAUTHENTICATIONTYPE'"]=[[{av:"AV32NameAuthType",fld:"vNAMEAUTHTYPE",pic:"",hsh:!0},{av:"AV26UserName",fld:"vUSERNAME",pic:""},{av:"AV27UserPassword",fld:"vUSERPASSWORD",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}],[{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]];this.EvtParms.VALIDV_TYPEAUTHTYPE=[[{ctrl:"vTYPEAUTHTYPE"},{av:"AV33TypeAuthType",fld:"vTYPEAUTHTYPE",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}],[{ctrl:"vTYPEAUTHTYPE"},{av:"AV33TypeAuthType",fld:"vTYPEAUTHTYPE",pic:""},{av:"AV17KeepMeLoggedIn",fld:"vKEEPMELOGGEDIN",pic:""},{av:"AV21RememberMe",fld:"vREMEMBERME",pic:""}]];this.EnterCtrl=["LOGIN"];this.setVCMap("AV6ApplicationClientId","vAPPLICATIONCLIENTID",0,"char",40,0);this.setVCMap("AV18Language","vLANGUAGE",0,"char",3,0);this.setVCMap("AV34AuxUserName","vAUXUSERNAME",0,"svchar",100,60);this.setVCMap("AV28UserRememberMe","vUSERREMEMBERME",0,"int",2,0);this.setVCMap("AV6ApplicationClientId","vAPPLICATIONCLIENTID",0,"char",40,0);this.setVCMap("AV18Language","vLANGUAGE",0,"char",3,0);this.setVCMap("AV34AuxUserName","vAUXUSERNAME",0,"svchar",100,60);this.setVCMap("AV28UserRememberMe","vUSERREMEMBERME",0,"int",2,0);this.setVCMap("AV6ApplicationClientId","vAPPLICATIONCLIENTID",0,"char",40,0);this.setVCMap("AV6ApplicationClientId","vAPPLICATIONCLIENTID",0,"char",40,0);this.setVCMap("AV18Language","vLANGUAGE",0,"char",3,0);this.setVCMap("AV34AuxUserName","vAUXUSERNAME",0,"svchar",100,60);this.setVCMap("AV28UserRememberMe","vUSERREMEMBERME",0,"int",2,0);t.addRefreshingVar({rfrVar:"AV6ApplicationClientId"});t.addRefreshingVar({rfrVar:"AV18Language"});t.addRefreshingVar({rfrVar:"AV34AuxUserName"});t.addRefreshingVar({rfrVar:"AV28UserRememberMe"});t.addRefreshingParm({rfrVar:"AV6ApplicationClientId"});t.addRefreshingParm({rfrVar:"AV18Language"});t.addRefreshingParm({rfrVar:"AV34AuxUserName"});t.addRefreshingParm({rfrVar:"AV28UserRememberMe"});t.addRefreshingParm(this.GXValidFnc[36]);t.addRefreshingParm(this.GXValidFnc[41]);this.Initialize()});gx.wi(function(){gx.createParentObj(gamexamplelogin)})