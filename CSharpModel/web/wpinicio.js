/*!   GeneXus C# 16_0_7-138086 on 4/15/2020 11:15:15.69
*/
gx.evt.autoSkip=!1;gx.define("wpinicio",!1,function(){this.ServerClass="wpinicio";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e112l1_client=function(){return this.clearMessages(),this.call("wwtarea.aspx",[]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e122l1_client=function(){return this.clearMessages(),this.call("wwproyecto.aspx",[]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e132l1_client=function(){return this.clearMessages(),this.call("wwestado.aspx",[]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e152l2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e162l2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12];this.GXLastCtrlId=12;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TAREA",grid:0,evt:"e112l1_client"};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"PROYECTO",grid:0,evt:"e122l1_client"};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"ESTADO",grid:0,evt:"e132l1_client"};this.Events={e152l2_client:["ENTER",!0],e162l2_client:["CANCEL",!0],e112l1_client:["'TAREA'",!1],e122l1_client:["'PROYECTO'",!1],e132l1_client:["'ESTADO'",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'TAREA'"]=[[],[]];this.EvtParms["'PROYECTO'"]=[[],[]];this.EvtParms["'ESTADO'"]=[[],[]];this.Initialize()});gx.wi(function(){gx.createParentObj(wpinicio)})