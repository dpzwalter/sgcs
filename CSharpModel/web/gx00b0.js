/*!   GeneXus C# 16_0_10-142546 on 8/14/2020 18:38:58.48
*/
gx.evt.autoSkip=!1;gx.define("gx00b0",!1,function(){var n,t;this.ServerClass="gx00b0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pUsuID=gx.fn.getControlValue("vPUSUID")};this.e16341_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11341_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUID","Visible",!0)):(gx.fn.setCtrlProperty("USUIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUIDFILTERCONTAINER","Class")',ctrl:"USUIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUID","Visible")',ctrl:"vCUSUID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12341_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUNOMFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUNOMFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUNOM","Visible",!0)):(gx.fn.setCtrlProperty("USUNOMFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUNOM","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUNOMFILTERCONTAINER","Class")',ctrl:"USUNOMFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUNOM","Visible")',ctrl:"vCUSUNOM",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e13341_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUAPEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUAPEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUAPE","Visible",!0)):(gx.fn.setCtrlProperty("USUAPEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUAPE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUAPEFILTERCONTAINER","Class")',ctrl:"USUAPEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUAPE","Visible")',ctrl:"vCUSUAPE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e14341_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUCLAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUCLAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUCLA","Visible",!0)):(gx.fn.setCtrlProperty("USUCLAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUCLA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUCLAFILTERCONTAINER","Class")',ctrl:"USUCLAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUCLA","Visible")',ctrl:"vCUSUCLA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e15341_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ROLIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ROLIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCROLID","Visible",!0)):(gx.fn.setCtrlProperty("ROLIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCROLID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ROLIDFILTERCONTAINER","Class")',ctrl:"ROLIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCROLID","Visible")',ctrl:"vCROLID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e19342_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e20341_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,65,66,67,68,69,70,71];this.GXLastCtrlId=71;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00b0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(32,66,"USUID","ID","","UsuID","svchar",0,"px",40,40,"left",null,[],32,"UsuID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(35,67,"USUNOM","Nom","","UsuNom","svchar",0,"px",40,40,"left",null,[],35,"UsuNom",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(36,68,"USUAPE","Ape","","UsuApe","svchar",0,"px",40,40,"left",null,[],36,"UsuApe",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"USUIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLUSUIDFILTER",format:1,grid:0,evt:"e11341_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUID",gxz:"ZV6cUsuID",gxold:"OV6cUsuID",gxvar:"AV6cUsuID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cUsuID=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6cUsuID=n)},v2c:function(){gx.fn.setControlValue("vCUSUID",gx.O.AV6cUsuID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cUsuID=this.val())},val:function(){return gx.fn.getControlValue("vCUSUID")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"USUNOMFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLUSUNOMFILTER",format:1,grid:0,evt:"e12341_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUNOM",gxz:"ZV7cUsuNom",gxold:"OV7cUsuNom",gxvar:"AV7cUsuNom",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cUsuNom=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cUsuNom=n)},v2c:function(){gx.fn.setControlValue("vCUSUNOM",gx.O.AV7cUsuNom,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cUsuNom=this.val())},val:function(){return gx.fn.getControlValue("vCUSUNOM")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"USUAPEFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLUSUAPEFILTER",format:1,grid:0,evt:"e13341_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUAPE",gxz:"ZV8cUsuApe",gxold:"OV8cUsuApe",gxvar:"AV8cUsuApe",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cUsuApe=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cUsuApe=n)},v2c:function(){gx.fn.setControlValue("vCUSUAPE",gx.O.AV8cUsuApe,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cUsuApe=this.val())},val:function(){return gx.fn.getControlValue("vCUSUAPE")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"USUCLAFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLUSUCLAFILTER",format:1,grid:0,evt:"e14341_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUCLA",gxz:"ZV9cUsuCla",gxold:"OV9cUsuCla",gxvar:"AV9cUsuCla",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cUsuCla=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cUsuCla=n)},v2c:function(){gx.fn.setControlValue("vCUSUCLA",gx.O.AV9cUsuCla,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cUsuCla=this.val())},val:function(){return gx.fn.getControlValue("vCUSUCLA")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"ROLIDFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLROLIDFILTER",format:1,grid:0,evt:"e15341_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCROLID",gxz:"ZV10cRolId",gxold:"OV10cRolId",gxvar:"AV10cRolId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cRolId=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cRolId=n)},v2c:function(){gx.fn.setControlValue("vCROLID",gx.O.AV10cRolId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cRolId=this.val())},val:function(){return gx.fn.getControlValue("vCROLID")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"GRIDTABLE",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"BTNTOGGLE",grid:0,evt:"e16341_client"};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[65]={id:65,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(n){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={id:66,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUID",gxz:"Z32UsuID",gxold:"O32UsuID",gxvar:"A32UsuID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A32UsuID=n)},v2z:function(n){n!==undefined&&(gx.O.Z32UsuID=n)},v2c:function(n){gx.fn.setGridControlValue("USUID",n||gx.fn.currentGridRowImpl(64),gx.O.A32UsuID,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A32UsuID=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUID",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[67]={id:67,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUNOM",gxz:"Z35UsuNom",gxold:"O35UsuNom",gxvar:"A35UsuNom",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A35UsuNom=n)},v2z:function(n){n!==undefined&&(gx.O.Z35UsuNom=n)},v2c:function(n){gx.fn.setGridControlValue("USUNOM",n||gx.fn.currentGridRowImpl(64),gx.O.A35UsuNom,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A35UsuNom=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUNOM",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={id:68,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUAPE",gxz:"Z36UsuApe",gxold:"O36UsuApe",gxvar:"A36UsuApe",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A36UsuApe=n)},v2z:function(n){n!==undefined&&(gx.O.Z36UsuApe=n)},v2c:function(n){gx.fn.setGridControlValue("USUAPE",n||gx.fn.currentGridRowImpl(64),gx.O.A36UsuApe,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A36UsuApe=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUAPE",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"BTN_CANCEL",grid:0,evt:"e20341_client"};this.AV6cUsuID="";this.ZV6cUsuID="";this.OV6cUsuID="";this.AV7cUsuNom="";this.ZV7cUsuNom="";this.OV7cUsuNom="";this.AV8cUsuApe="";this.ZV8cUsuApe="";this.OV8cUsuApe="";this.AV9cUsuCla="";this.ZV9cUsuCla="";this.OV9cUsuCla="";this.AV10cRolId="";this.ZV10cRolId="";this.OV10cRolId="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z32UsuID="";this.O32UsuID="";this.Z35UsuNom="";this.O35UsuNom="";this.Z36UsuApe="";this.O36UsuApe="";this.AV6cUsuID="";this.AV7cUsuNom="";this.AV8cUsuApe="";this.AV9cUsuCla="";this.AV10cRolId="";this.AV11pUsuID="";this.A40RolId="";this.A37UsuCla="";this.AV5LinkSelection="";this.A32UsuID="";this.A35UsuNom="";this.A36UsuApe="";this.Events={e19342_client:["ENTER",!0],e20341_client:["CANCEL",!0],e16341_client:["'TOGGLE'",!1],e11341_client:["LBLUSUIDFILTER.CLICK",!1],e12341_client:["LBLUSUNOMFILTER.CLICK",!1],e13341_client:["LBLUSUAPEFILTER.CLICK",!1],e14341_client:["LBLUSUCLAFILTER.CLICK",!1],e15341_client:["LBLROLIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuID",fld:"vCUSUID",pic:""},{av:"AV7cUsuNom",fld:"vCUSUNOM",pic:""},{av:"AV8cUsuApe",fld:"vCUSUAPE",pic:""},{av:"AV9cUsuCla",fld:"vCUSUCLA",pic:""},{av:"AV10cRolId",fld:"vCROLID",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLUSUIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUIDFILTERCONTAINER","Class")',ctrl:"USUIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUIDFILTERCONTAINER","Class")',ctrl:"USUIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUID","Visible")',ctrl:"vCUSUID",prop:"Visible"}]];this.EvtParms["LBLUSUNOMFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUNOMFILTERCONTAINER","Class")',ctrl:"USUNOMFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUNOMFILTERCONTAINER","Class")',ctrl:"USUNOMFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUNOM","Visible")',ctrl:"vCUSUNOM",prop:"Visible"}]];this.EvtParms["LBLUSUAPEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUAPEFILTERCONTAINER","Class")',ctrl:"USUAPEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUAPEFILTERCONTAINER","Class")',ctrl:"USUAPEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUAPE","Visible")',ctrl:"vCUSUAPE",prop:"Visible"}]];this.EvtParms["LBLUSUCLAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUCLAFILTERCONTAINER","Class")',ctrl:"USUCLAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUCLAFILTERCONTAINER","Class")',ctrl:"USUCLAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUCLA","Visible")',ctrl:"vCUSUCLA",prop:"Visible"}]];this.EvtParms["LBLROLIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ROLIDFILTERCONTAINER","Class")',ctrl:"ROLIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ROLIDFILTERCONTAINER","Class")',ctrl:"ROLIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCROLID","Visible")',ctrl:"vCROLID",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A32UsuID",fld:"USUID",pic:"",hsh:!0}],[{av:"AV11pUsuID",fld:"vPUSUID",pic:""}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuID",fld:"vCUSUID",pic:""},{av:"AV7cUsuNom",fld:"vCUSUNOM",pic:""},{av:"AV8cUsuApe",fld:"vCUSUAPE",pic:""},{av:"AV9cUsuCla",fld:"vCUSUCLA",pic:""},{av:"AV10cRolId",fld:"vCROLID",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuID",fld:"vCUSUID",pic:""},{av:"AV7cUsuNom",fld:"vCUSUNOM",pic:""},{av:"AV8cUsuApe",fld:"vCUSUAPE",pic:""},{av:"AV9cUsuCla",fld:"vCUSUCLA",pic:""},{av:"AV10cRolId",fld:"vCROLID",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuID",fld:"vCUSUID",pic:""},{av:"AV7cUsuNom",fld:"vCUSUNOM",pic:""},{av:"AV8cUsuApe",fld:"vCUSUAPE",pic:""},{av:"AV9cUsuCla",fld:"vCUSUCLA",pic:""},{av:"AV10cRolId",fld:"vCROLID",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuID",fld:"vCUSUID",pic:""},{av:"AV7cUsuNom",fld:"vCUSUNOM",pic:""},{av:"AV8cUsuApe",fld:"vCUSUAPE",pic:""},{av:"AV9cUsuCla",fld:"vCUSUCLA",pic:""},{av:"AV10cRolId",fld:"vCROLID",pic:""}],[]];this.setVCMap("AV11pUsuID","vPUSUID",0,"svchar",40,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[36]);t.addRefreshingParm(this.GXValidFnc[46]);t.addRefreshingParm(this.GXValidFnc[56]);this.Initialize()});gx.wi(function(){gx.createParentObj(gx00b0)})