/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:29.87
*/
gx.evt.autoSkip=!1;gx.define("rolusuariowc",!0,function(n){var t,i;this.ServerClass="rolusuariowc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6RolId=gx.fn.getIntegerValue("vROLID",",");this.AV6RolId=gx.fn.getIntegerValue("vROLID",",")};this.Valid_Usunom=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Usunom",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("USUNOM",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Usuape=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Usuape",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("USUAPE",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e113i2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e143i2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e153i2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29,30,31,32,33];this.GXLastCtrlId=33;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"rolusuariowc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(32,21,"USUID","ID","","UsuID","svchar",0,"px",40,40,"left",null,[],32,"UsuID",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addSingleLineEdit(35,22,"USUNOM","Nom","","UsuNom","svchar",0,"px",40,40,"left",null,[],35,"UsuNom",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(36,23,"USUAPE","Ape","","UsuApe","svchar",0,"px",40,40,"left",null,[],36,"UsuApe",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBitmap(33,"USUIMG",24,0,"px",17,"px",null,"","Img","ImageAttribute","WWColumn WWOptionalColumn");i.addSingleLineEdit(42,25,"USUARIOID","ID","","UsuarioID","int",0,"px",4,4,"right",null,[],42,"UsuarioID",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(37,26,"USUCLA","Cla","","UsuCla","char",0,"px",20,20,"left",null,[],37,"UsuCla",!1,0,!1,!0,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(34,27,"USUNOMCOM","Nom Com","","UsuNomCom","svchar",0,"px",80,80,"left",null,[],34,"UsuNomCom",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit("Update",28,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");i.addSingleLineEdit("Delete",29,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0,evt:"e113i2_client"};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUID",gxz:"Z32UsuID",gxold:"O32UsuID",gxvar:"A32UsuID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A32UsuID=n)},v2z:function(n){n!==undefined&&(gx.O.Z32UsuID=n)},v2c:function(n){gx.fn.setGridControlValue("USUID",n||gx.fn.currentGridRowImpl(20),gx.O.A32UsuID,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A32UsuID=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUID",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Usunom,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUNOM",gxz:"Z35UsuNom",gxold:"O35UsuNom",gxvar:"A35UsuNom",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A35UsuNom=n)},v2z:function(n){n!==undefined&&(gx.O.Z35UsuNom=n)},v2c:function(n){gx.fn.setGridControlValue("USUNOM",n||gx.fn.currentGridRowImpl(20),gx.O.A35UsuNom,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A35UsuNom=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUNOM",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Usuape,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUAPE",gxz:"Z36UsuApe",gxold:"O36UsuApe",gxvar:"A36UsuApe",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A36UsuApe=n)},v2z:function(n){n!==undefined&&(gx.O.Z36UsuApe=n)},v2c:function(n){gx.fn.setGridControlValue("USUAPE",n||gx.fn.currentGridRowImpl(20),gx.O.A36UsuApe,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A36UsuApe=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUAPE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUIMG",gxz:"Z33UsuImg",gxold:"O33UsuImg",gxvar:"A33UsuImg",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A33UsuImg=n)},v2z:function(n){n!==undefined&&(gx.O.Z33UsuImg=n)},v2c:function(n){gx.fn.setGridMultimediaValue("USUIMG",n||gx.fn.currentGridRowImpl(20),gx.O.A33UsuImg,gx.O.A40000UsuImg_GXI)},c2v:function(n){gx.O.A40000UsuImg_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.A33UsuImg=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUIMG",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("USUIMG_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"A40000UsuImg_GXI",nac:gx.falseFn};t[25]={id:25,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOID",gxz:"Z42UsuarioID",gxold:"O42UsuarioID",gxvar:"A42UsuarioID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A42UsuarioID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42UsuarioID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("USUARIOID",n||gx.fn.currentGridRowImpl(20),gx.O.A42UsuarioID,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A42UsuarioID=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("USUARIOID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[26]={id:26,lvl:2,type:"char",len:20,dec:0,sign:!1,isPwd:!0,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUCLA",gxz:"Z37UsuCla",gxold:"O37UsuCla",gxvar:"A37UsuCla",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A37UsuCla=n)},v2z:function(n){n!==undefined&&(gx.O.Z37UsuCla=n)},v2c:function(n){gx.fn.setGridControlValue("USUCLA",n||gx.fn.currentGridRowImpl(20),gx.O.A37UsuCla,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A37UsuCla=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUCLA",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[27]={id:27,lvl:2,type:"svchar",len:80,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUNOMCOM",gxz:"Z34UsuNomCom",gxold:"O34UsuNomCom",gxvar:"A34UsuNomCom",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A34UsuNomCom=n)},v2z:function(n){n!==undefined&&(gx.O.Z34UsuNomCom=n)},v2c:function(n){gx.fn.setGridControlValue("USUNOMCOM",n||gx.fn.currentGridRowImpl(20),gx.O.A34UsuNomCom,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A34UsuNomCom=this.val(n))},val:function(n){return gx.fn.getGridControlValue("USUNOMCOM",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[28]={id:28,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Update,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV12Update=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[29]={id:29,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV13Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV13Delete,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV13Delete=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ROLID",gxz:"Z40RolId",gxold:"O40RolId",gxvar:"A40RolId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A40RolId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z40RolId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ROLID",gx.O.A40RolId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A40RolId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ROLID",",")},nac:gx.falseFn};this.Z32UsuID="";this.O32UsuID="";this.Z35UsuNom="";this.O35UsuNom="";this.Z36UsuApe="";this.O36UsuApe="";this.Z33UsuImg="";this.O33UsuImg="";this.Z42UsuarioID=0;this.O42UsuarioID=0;this.Z37UsuCla="";this.O37UsuCla="";this.Z34UsuNomCom="";this.O34UsuNomCom="";this.ZV12Update="";this.OV12Update="";this.ZV13Delete="";this.OV13Delete="";this.A40RolId=0;this.Z40RolId=0;this.O40RolId=0;this.A40RolId=0;this.A40000UsuImg_GXI="";this.AV6RolId=0;this.A32UsuID="";this.A35UsuNom="";this.A36UsuApe="";this.A33UsuImg="";this.A42UsuarioID=0;this.A37UsuCla="";this.A34UsuNomCom="";this.AV12Update="";this.AV13Delete="";this.Events={e113i2_client:["'DOINSERT'",!0],e143i2_client:["ENTER",!0],e153i2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6RolId",fld:"vROLID",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6RolId",fld:"vROLID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("ROLID","Visible")',ctrl:"ROLID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A42UsuarioID",fld:"USUARIOID",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("USUID","Link")',ctrl:"USUID",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A42UsuarioID",fld:"USUARIOID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6RolId",fld:"vROLID",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6RolId",fld:"vROLID",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6RolId",fld:"vROLID",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6RolId",fld:"vROLID",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.VALID_USUNOM=[[],[]];this.EvtParms.VALID_USUAPE=[[],[]];this.setVCMap("AV6RolId","vROLID",0,"int",4,0);this.setVCMap("AV6RolId","vROLID",0,"int",4,0);this.setVCMap("AV6RolId","vROLID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6RolId"});i.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});i.addRefreshingParm({rfrVar:"AV6RolId"});i.addRefreshingParm({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingParm({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()})