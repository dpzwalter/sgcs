/*!   GeneXus C# 16_0_10-142546 on 8/23/2020 14:32:28.90
*/
gx.evt.autoSkip=!1;gx.define("prioridadtareawc",!0,function(n){var t,i;this.ServerClass="prioridadtareawc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6IdPrioridad=gx.fn.getIntegerValue("vIDPRIORIDAD",",");this.AV6IdPrioridad=gx.fn.getIntegerValue("vIDPRIORIDAD",",")};this.Valid_Idproyecto=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Idproyecto",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("IDPROYECTO",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Idfase=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Idfase",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("IDFASE",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Idestadotarea=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Idestadotarea",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("IDESTADOTAREA",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Idpadre=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Idpadre",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("IDPADRE",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e110q2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e140q2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e150q2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38];this.GXLastCtrlId=38;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"prioridadtareawc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(5,21,"IDTAREA","Id de Tarea","","IdTarea","int",0,"px",4,4,"right",null,[],5,"IdTarea",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(1,22,"IDPROYECTO","Id de Proyecto","","IdProyecto","int",0,"px",4,4,"right",null,[],1,"IdProyecto",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(2,23,"NOMBREPROYECTO","Nombre de Proyecto","","NombreProyecto","char",0,"px",60,60,"left",null,[],2,"NombreProyecto",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(6,24,"NOMBRETAREA","Nombre de Tarea","","NombreTarea","char",0,"px",60,60,"left",null,[],6,"NombreTarea",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addSingleLineEdit(7,25,"DESCRIPCIONTAREA","Descripcion de Tarea","","DescripcionTarea","char",0,"px",60,60,"left",null,[],7,"DescripcionTarea",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(13,26,"IDFASE","Id Fase","","IdFase","int",0,"px",4,4,"right",null,[],13,"IdFase",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(14,27,"FASE","Fase","","Fase","char",0,"px",20,20,"left",null,[],14,"Fase",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(17,28,"IDESTADOTAREA","Id Estado Tarea","","IdEstadoTarea","int",0,"px",4,4,"right",null,[],17,"IdEstadoTarea",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(18,29,"ESTADOTAREA","Estado Tarea","","EstadoTarea","char",0,"px",20,20,"left",null,[],18,"EstadoTarea",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(19,30,"IDPADRE","Id Tarea Padre","","IdPadre","int",0,"px",4,4,"right",null,[],19,"IdPadre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(20,31,"NOMBREPADRE","Nombre Tarea Padre","","NombrePadre","char",0,"px",60,60,"left",null,[],20,"NombrePadre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addCheckBox(23,32,"STATUSTAREA","Satus Tarea","","StatusTarea","boolean","true","false",null,!0,!1,0,"px","WWColumn WWOptionalColumn");i.addSingleLineEdit("Update",33,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");i.addSingleLineEdit("Delete",34,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0,evt:"e110q2_client"};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDTAREA",gxz:"Z5IdTarea",gxold:"O5IdTarea",gxvar:"A5IdTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A5IdTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5IdTarea=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDTAREA",n||gx.fn.currentGridRowImpl(20),gx.O.A5IdTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A5IdTarea=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDTAREA",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Idproyecto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDPROYECTO",gxz:"Z1IdProyecto",gxold:"O1IdProyecto",gxvar:"A1IdProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1IdProyecto=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1IdProyecto=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDPROYECTO",n||gx.fn.currentGridRowImpl(20),gx.O.A1IdProyecto,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A1IdProyecto=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDPROYECTO",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOMBREPROYECTO",gxz:"Z2NombreProyecto",gxold:"O2NombreProyecto",gxvar:"A2NombreProyecto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A2NombreProyecto=n)},v2z:function(n){n!==undefined&&(gx.O.Z2NombreProyecto=n)},v2c:function(n){gx.fn.setGridControlValue("NOMBREPROYECTO",n||gx.fn.currentGridRowImpl(20),gx.O.A2NombreProyecto,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A2NombreProyecto=this.val(n))},val:function(n){return gx.fn.getGridControlValue("NOMBREPROYECTO",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOMBRETAREA",gxz:"Z6NombreTarea",gxold:"O6NombreTarea",gxvar:"A6NombreTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A6NombreTarea=n)},v2z:function(n){n!==undefined&&(gx.O.Z6NombreTarea=n)},v2c:function(n){gx.fn.setGridControlValue("NOMBRETAREA",n||gx.fn.currentGridRowImpl(20),gx.O.A6NombreTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A6NombreTarea=this.val(n))},val:function(n){return gx.fn.getGridControlValue("NOMBRETAREA",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESCRIPCIONTAREA",gxz:"Z7DescripcionTarea",gxold:"O7DescripcionTarea",gxvar:"A7DescripcionTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A7DescripcionTarea=n)},v2z:function(n){n!==undefined&&(gx.O.Z7DescripcionTarea=n)},v2c:function(n){gx.fn.setGridControlValue("DESCRIPCIONTAREA",n||gx.fn.currentGridRowImpl(20),gx.O.A7DescripcionTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A7DescripcionTarea=this.val(n))},val:function(n){return gx.fn.getGridControlValue("DESCRIPCIONTAREA",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Idfase,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDFASE",gxz:"Z13IdFase",gxold:"O13IdFase",gxvar:"A13IdFase",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A13IdFase=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13IdFase=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDFASE",n||gx.fn.currentGridRowImpl(20),gx.O.A13IdFase,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A13IdFase=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDFASE",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[27]={id:27,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FASE",gxz:"Z14Fase",gxold:"O14Fase",gxvar:"A14Fase",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A14Fase=n)},v2z:function(n){n!==undefined&&(gx.O.Z14Fase=n)},v2c:function(n){gx.fn.setGridControlValue("FASE",n||gx.fn.currentGridRowImpl(20),gx.O.A14Fase,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A14Fase=this.val(n))},val:function(n){return gx.fn.getGridControlValue("FASE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[28]={id:28,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Idestadotarea,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDESTADOTAREA",gxz:"Z17IdEstadoTarea",gxold:"O17IdEstadoTarea",gxvar:"A17IdEstadoTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A17IdEstadoTarea=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17IdEstadoTarea=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDESTADOTAREA",n||gx.fn.currentGridRowImpl(20),gx.O.A17IdEstadoTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A17IdEstadoTarea=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDESTADOTAREA",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[29]={id:29,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTADOTAREA",gxz:"Z18EstadoTarea",gxold:"O18EstadoTarea",gxvar:"A18EstadoTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A18EstadoTarea=n)},v2z:function(n){n!==undefined&&(gx.O.Z18EstadoTarea=n)},v2c:function(n){gx.fn.setGridControlValue("ESTADOTAREA",n||gx.fn.currentGridRowImpl(20),gx.O.A18EstadoTarea,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A18EstadoTarea=this.val(n))},val:function(n){return gx.fn.getGridControlValue("ESTADOTAREA",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[30]={id:30,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Idpadre,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDPADRE",gxz:"Z19IdPadre",gxold:"O19IdPadre",gxvar:"A19IdPadre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A19IdPadre=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19IdPadre=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDPADRE",n||gx.fn.currentGridRowImpl(20),gx.O.A19IdPadre,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A19IdPadre=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("IDPADRE",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[31]={id:31,lvl:2,type:"char",len:60,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOMBREPADRE",gxz:"Z20NombrePadre",gxold:"O20NombrePadre",gxvar:"A20NombrePadre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A20NombrePadre=n)},v2z:function(n){n!==undefined&&(gx.O.Z20NombrePadre=n)},v2c:function(n){gx.fn.setGridControlValue("NOMBREPADRE",n||gx.fn.currentGridRowImpl(20),gx.O.A20NombrePadre,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A20NombrePadre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("NOMBREPADRE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[32]={id:32,lvl:2,type:"boolean",len:4,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STATUSTAREA",gxz:"Z23StatusTarea",gxold:"O23StatusTarea",gxvar:"A23StatusTarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A23StatusTarea=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z23StatusTarea=gx.lang.booleanValue(n))},v2c:function(n){gx.fn.setGridCheckBoxValue("STATUSTAREA",n||gx.fn.currentGridRowImpl(20),gx.O.A23StatusTarea,!0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A23StatusTarea=gx.lang.booleanValue(this.val(n)))},val:function(n){return gx.fn.getGridControlValue("STATUSTAREA",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn,values:["true","false"]};t[33]={id:33,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Update,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV12Update=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[34]={id:34,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV13Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV13Delete,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV13Delete=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"IDPRIORIDAD",gxz:"Z9IdPrioridad",gxold:"O9IdPrioridad",gxvar:"A9IdPrioridad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A9IdPrioridad=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z9IdPrioridad=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("IDPRIORIDAD",gx.O.A9IdPrioridad,0)},c2v:function(){this.val()!==undefined&&(gx.O.A9IdPrioridad=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("IDPRIORIDAD",",")},nac:gx.falseFn};this.Z5IdTarea=0;this.O5IdTarea=0;this.Z1IdProyecto=0;this.O1IdProyecto=0;this.Z2NombreProyecto="";this.O2NombreProyecto="";this.Z6NombreTarea="";this.O6NombreTarea="";this.Z7DescripcionTarea="";this.O7DescripcionTarea="";this.Z13IdFase=0;this.O13IdFase=0;this.Z14Fase="";this.O14Fase="";this.Z17IdEstadoTarea=0;this.O17IdEstadoTarea=0;this.Z18EstadoTarea="";this.O18EstadoTarea="";this.Z19IdPadre=0;this.O19IdPadre=0;this.Z20NombrePadre="";this.O20NombrePadre="";this.Z23StatusTarea=!1;this.O23StatusTarea=!1;this.ZV12Update="";this.OV12Update="";this.ZV13Delete="";this.OV13Delete="";this.A9IdPrioridad=0;this.Z9IdPrioridad=0;this.O9IdPrioridad=0;this.A9IdPrioridad=0;this.AV6IdPrioridad=0;this.A5IdTarea=0;this.A1IdProyecto=0;this.A2NombreProyecto="";this.A6NombreTarea="";this.A7DescripcionTarea="";this.A13IdFase=0;this.A14Fase="";this.A17IdEstadoTarea=0;this.A18EstadoTarea="";this.A19IdPadre=0;this.A20NombrePadre="";this.A23StatusTarea=!1;this.AV12Update="";this.AV13Delete="";this.Events={e110q2_client:["'DOINSERT'",!0],e140q2_client:["ENTER",!0],e150q2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdPrioridad",fld:"vIDPRIORIDAD",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6IdPrioridad",fld:"vIDPRIORIDAD",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("IDPRIORIDAD","Visible")',ctrl:"IDPRIORIDAD",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A5IdTarea",fld:"IDTAREA",pic:"ZZZ9",hsh:!0},{av:"A1IdProyecto",fld:"IDPROYECTO",pic:"ZZZ9"},{av:"A13IdFase",fld:"IDFASE",pic:"ZZZ9"},{av:"A17IdEstadoTarea",fld:"IDESTADOTAREA",pic:"ZZZ9"}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("NOMBREPROYECTO","Link")',ctrl:"NOMBREPROYECTO",prop:"Link"},{av:'gx.fn.getCtrlProperty("NOMBRETAREA","Link")',ctrl:"NOMBRETAREA",prop:"Link"},{av:'gx.fn.getCtrlProperty("FASE","Link")',ctrl:"FASE",prop:"Link"},{av:'gx.fn.getCtrlProperty("ESTADOTAREA","Link")',ctrl:"ESTADOTAREA",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A5IdTarea",fld:"IDTAREA",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdPrioridad",fld:"vIDPRIORIDAD",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdPrioridad",fld:"vIDPRIORIDAD",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdPrioridad",fld:"vIDPRIORIDAD",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6IdPrioridad",fld:"vIDPRIORIDAD",pic:"ZZZ9"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.VALID_IDPROYECTO=[[],[]];this.EvtParms.VALID_IDFASE=[[],[]];this.EvtParms.VALID_IDESTADOTAREA=[[],[]];this.EvtParms.VALID_IDPADRE=[[],[]];this.setVCMap("AV6IdPrioridad","vIDPRIORIDAD",0,"int",4,0);this.setVCMap("AV6IdPrioridad","vIDPRIORIDAD",0,"int",4,0);this.setVCMap("AV6IdPrioridad","vIDPRIORIDAD",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6IdPrioridad"});i.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});i.addRefreshingParm({rfrVar:"AV6IdPrioridad"});i.addRefreshingParm({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingParm({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()})