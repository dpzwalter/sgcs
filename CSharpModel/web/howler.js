/*! howler.js v2.0.4 | (c) 2013-2017, James Simpson of GoldFire Studios | MIT License | howlerjs.com */
!function(){"use strict";var u=function(){this.init()},n,i,r;u.prototype={init:function(){var t=this||n;return t._counter=1e3,t._codecs={},t._howls=[],t._muted=!1,t._volume=1,t._canPlayEvent="canplaythrough",t._navigator="undefined"!=typeof window&&window.navigator?window.navigator:null,t.masterGain=null,t.noAudio=!1,t.usingWebAudio=!0,t.autoSuspend=!0,t.ctx=null,t.mobileAutoEnable=!0,t._setup(),t},volume:function(t){var i=this||n,r,o,e,u;if(t=parseFloat(t),i.ctx||f(),void 0!==t&&t>=0&&t<=1){if(i._volume=t,i._muted)return i;for(i.usingWebAudio&&(i.masterGain.gain.value=t),r=0;r<i._howls.length;r++)if(!i._howls[r]._webAudio)for(o=i._howls[r]._getSoundIds(),e=0;e<o.length;e++)u=i._howls[r]._soundById(o[e]),u&&u._node&&(u._node.volume=u._volume*t);return i}return i._volume},mute:function(t){var i=this||n,r,o,e,u;for(i.ctx||f(),i._muted=t,i.usingWebAudio&&(i.masterGain.gain.value=t?0:i._volume),r=0;r<i._howls.length;r++)if(!i._howls[r]._webAudio)for(o=i._howls[r]._getSoundIds(),e=0;e<o.length;e++)u=i._howls[r]._soundById(o[e]),u&&u._node&&(u._node.muted=!!t||u._muted);return i},unload:function(){for(var t=this||n,i=t._howls.length-1;i>=0;i--)t._howls[i].unload();return t.usingWebAudio&&t.ctx&&void 0!==t.ctx.close&&(t.ctx.close(),t.ctx=null,f()),t},codecs:function(t){return(this||n)._codecs[t.replace(/^x-/,"")]},_setup:function(){var t=this||n,i;if(t.state=t.ctx?t.ctx.state||"running":"running",t._autoSuspend(),!t.usingWebAudio)if("undefined"!=typeof Audio)try{i=new Audio;void 0===i.oncanplaythrough&&(t._canPlayEvent="canplay")}catch(n){t.noAudio=!0}else t.noAudio=!0;try{i=new Audio;i.muted&&(t.noAudio=!0)}catch(t){}return t.noAudio||t._setupCodecs(),t},_setupCodecs:function(){var i=this||n,t=null;try{t="undefined"!=typeof Audio?new Audio:null}catch(n){return i}if(!t||"function"!=typeof t.canPlayType)return i;var r=t.canPlayType("audio/mpeg;").replace(/^no$/,""),u=i._navigator&&i._navigator.userAgent.match(/OPR\/([0-6].)/g),f=u&&parseInt(u[0].split("/")[1],10)<33;return i._codecs={mp3:!(f||!r&&!t.canPlayType("audio/mp3;").replace(/^no$/,"")),mpeg:!!r,opus:!!t.canPlayType('audio/ogg; codecs="opus"').replace(/^no$/,""),ogg:!!t.canPlayType('audio/ogg; codecs="vorbis"').replace(/^no$/,""),oga:!!t.canPlayType('audio/ogg; codecs="vorbis"').replace(/^no$/,""),wav:!!t.canPlayType('audio/wav; codecs="1"').replace(/^no$/,""),aac:!!t.canPlayType("audio/aac;").replace(/^no$/,""),caf:!!t.canPlayType("audio/x-caf;").replace(/^no$/,""),m4a:!!(t.canPlayType("audio/x-m4a;")||t.canPlayType("audio/m4a;")||t.canPlayType("audio/aac;")).replace(/^no$/,""),mp4:!!(t.canPlayType("audio/x-mp4;")||t.canPlayType("audio/mp4;")||t.canPlayType("audio/aac;")).replace(/^no$/,""),weba:!!t.canPlayType('audio/webm; codecs="vorbis"').replace(/^no$/,""),webm:!!t.canPlayType('audio/webm; codecs="vorbis"').replace(/^no$/,""),dolby:!!t.canPlayType('audio/mp4; codecs="ec-3"').replace(/^no$/,""),flac:!!(t.canPlayType("audio/x-flac;")||t.canPlayType("audio/flac;")).replace(/^no$/,"")},i},_enableMobileAudio:function(){var t=this||n,r=/iPhone|iPad|iPod|Android|BlackBerry|BB10|Silk|Mobi/i.test(t._navigator&&t._navigator.userAgent),u=!!("ontouchend"in window||t._navigator&&t._navigator.maxTouchPoints>0||t._navigator&&t._navigator.msMaxTouchPoints>0),i;if(!t._mobileEnabled&&t.ctx&&(r||u))return t._mobileEnabled=!1,t._mobileUnloaded||44100===t.ctx.sampleRate||(t._mobileUnloaded=!0,t.unload()),t._scratchBuffer=t.ctx.createBuffer(1,1,22050),i=function(){n._autoResume();var r=t.ctx.createBufferSource();r.buffer=t._scratchBuffer;r.connect(t.ctx.destination);void 0===r.start?r.noteOn(0):r.start(0);"function"==typeof t.ctx.resume&&t.ctx.resume();r.onended=function(){r.disconnect(0);t._mobileEnabled=!0;t.mobileAutoEnable=!1;document.removeEventListener("touchend",i,!0)}},document.addEventListener("touchend",i,!0),t},_autoSuspend:function(){var t=this,i,r;if(t.autoSuspend&&t.ctx&&void 0!==t.ctx.suspend&&n.usingWebAudio){for(i=0;i<t._howls.length;i++)if(t._howls[i]._webAudio)for(r=0;r<t._howls[i]._sounds.length;r++)if(!t._howls[i]._sounds[r]._paused)return t;return t._suspendTimer&&clearTimeout(t._suspendTimer),t._suspendTimer=setTimeout(function(){t.autoSuspend&&(t._suspendTimer=null,t.state="suspending",t.ctx.suspend().then(function(){t.state="suspended";t._resumeAfterSuspend&&(delete t._resumeAfterSuspend,t._autoResume())}))},3e4),t}},_autoResume:function(){var t=this;if(t.ctx&&void 0!==t.ctx.resume&&n.usingWebAudio)return"running"===t.state&&t._suspendTimer?(clearTimeout(t._suspendTimer),t._suspendTimer=null):"suspended"===t.state?(t.ctx.resume().then(function(){t.state="running";for(var n=0;n<t._howls.length;n++)t._howls[n]._emit("resume")}),t._suspendTimer&&(clearTimeout(t._suspendTimer),t._suspendTimer=null)):"suspending"===t.state&&(t._resumeAfterSuspend=!0),t}};n=new u;i=function(n){var t=this;if(!n.src||0===n.src.length)return void console.error("An array of source files must be passed with any new Howl.");t.init(n)};i.prototype={init:function(t){var i=this;return n.ctx||f(),i._autoplay=t.autoplay||!1,i._format="string"!=typeof t.format?t.format:[t.format],i._html5=t.html5||!1,i._muted=t.mute||!1,i._loop=t.loop||!1,i._pool=t.pool||5,i._preload="boolean"!=typeof t.preload||t.preload,i._rate=t.rate||1,i._sprite=t.sprite||{},i._src="string"!=typeof t.src?t.src:[t.src],i._volume=void 0!==t.volume?t.volume:1,i._duration=0,i._state="unloaded",i._sounds=[],i._endTimers={},i._queue=[],i._onend=t.onend?[{fn:t.onend}]:[],i._onfade=t.onfade?[{fn:t.onfade}]:[],i._onload=t.onload?[{fn:t.onload}]:[],i._onloaderror=t.onloaderror?[{fn:t.onloaderror}]:[],i._onpause=t.onpause?[{fn:t.onpause}]:[],i._onplay=t.onplay?[{fn:t.onplay}]:[],i._onstop=t.onstop?[{fn:t.onstop}]:[],i._onmute=t.onmute?[{fn:t.onmute}]:[],i._onvolume=t.onvolume?[{fn:t.onvolume}]:[],i._onrate=t.onrate?[{fn:t.onrate}]:[],i._onseek=t.onseek?[{fn:t.onseek}]:[],i._onresume=[],i._webAudio=n.usingWebAudio&&!i._html5,void 0!==n.ctx&&n.ctx&&n.mobileAutoEnable&&n._enableMobileAudio(),n._howls.push(i),i._autoplay&&i._queue.push({event:"play",action:function(){i.play()}}),i._preload&&i.load(),i},load:function(){var t=this,f=null,u,i,e;if(n.noAudio)return void t._emit("loaderror",null,"No audio support.");for("string"==typeof t._src&&(t._src=[t._src]),u=0;u<t._src.length;u++){if(t._format&&t._format[u])i=t._format[u];else{if("string"!=typeof(e=t._src[u])){t._emit("loaderror",null,"Non-string found in selected audio sources - ignoring.");continue}i=/^data:audio\/([^;,]+);/i.exec(e);i||(i=/\.([^.]+)$/.exec(e.split("?",1)[0]));i&&(i=i[1].toLowerCase())}if(i||console.warn('No file extension was found. Consider using the "format" property or specify an extension.'),i&&n.codecs(i)){f=t._src[u];break}}return f?(t._src=f,t._state="loading","https:"===window.location.protocol&&"http:"===f.slice(0,5)&&(t._html5=!0,t._webAudio=!1),new r(t),t._webAudio&&s(t),t):void t._emit("loaderror",null,"No codec support for selected audio sources.")},play:function(t,i){var u=this,e=null,l,s,r,a,f,y,c,b,p,k,w;if("number"==typeof t)e=t,t=null;else{if("string"==typeof t&&"loaded"===u._state&&!u._sprite[t])return null;if(void 0===t){for(t="__default",l=0,s=0;s<u._sounds.length;s++)u._sounds[s]._paused&&!u._sounds[s]._ended&&(l++,e=u._sounds[s]._id);1===l?t=null:e=null}}if(r=e?u._soundById(e):u._inactiveSound(),!r)return null;if(e&&!t&&(t=r._sprite||"__default"),"loaded"!==u._state)return r._sprite=t,r._ended=!1,a=r._id,u._queue.push({event:"play",action:function(){u.play(a)}}),a;if(e&&!r._paused)return i||setTimeout(function(){u._emit("play",r._id)},0),r._id;u._webAudio&&n._autoResume();var o=Math.max(0,r._seek>0?r._seek:u._sprite[t][0]/1e3),v=Math.max(0,(u._sprite[t][0]+u._sprite[t][1])/1e3-o),h=1e3*v/Math.abs(r._rate);return r._paused=!1,r._ended=!1,r._sprite=t,r._seek=o,r._start=u._sprite[t][0]/1e3,r._stop=(u._sprite[t][0]+u._sprite[t][1])/1e3,r._loop=!(!r._loop&&!u._sprite[t][2]),f=r._node,u._webAudio?(y=function(){u._refreshBuffer(r);var t=r._muted||u._muted?0:r._volume;f.gain.setValueAtTime(t,n.ctx.currentTime);r._playStart=n.ctx.currentTime;void 0===f.bufferSource.start?r._loop?f.bufferSource.noteGrainOn(0,o,86400):f.bufferSource.noteGrainOn(0,o,v):r._loop?f.bufferSource.start(0,o,86400):f.bufferSource.start(0,o,v);h!==1/0&&(u._endTimers[r._id]=setTimeout(u._ended.bind(u,r),h));i||setTimeout(function(){u._emit("play",r._id)},0)},c="running"===n.state,"loaded"===u._state&&c?y():(b=c||"loaded"!==u._state?"load":"resume",u.once(b,y,c?r._id:null),u._clearTimer(r._id))):(p=function(){f.currentTime=o;f.muted=r._muted||u._muted||n._muted||f.muted;f.volume=r._volume*n.volume();f.playbackRate=r._rate;f.play();h!==1/0&&(u._endTimers[r._id]=setTimeout(u._ended.bind(u,r),h));i||u._emit("play",r._id)},k="loaded"===u._state&&(window&&window.ejecta||!f.readyState&&n._navigator.isCocoonJS),4===f.readyState||k?p():(w=function(){p();f.removeEventListener(n._canPlayEvent,w,!1)},f.addEventListener(n._canPlayEvent,w,!1),u._clearTimer(r._id))),r._id},pause:function(n){var i=this,u,r,t;if("loaded"!==i._state)return i._queue.push({event:"pause",action:function(){i.pause(n)}}),i;for(u=i._getSoundIds(n),r=0;r<u.length;r++){if(i._clearTimer(u[r]),t=i._soundById(u[r]),t&&!t._paused&&(t._seek=i.seek(u[r]),t._rateSeek=0,t._paused=!0,i._stopFade(u[r]),t._node))if(i._webAudio){if(!t._node.bufferSource)continue;void 0===t._node.bufferSource.stop?t._node.bufferSource.noteOff(0):t._node.bufferSource.stop(0);i._cleanBuffer(t._node)}else isNaN(t._node.duration)&&t._node.duration!==1/0||t._node.pause();arguments[1]||i._emit("pause",t?t._id:null)}return i},stop:function(n,t){var r=this,f,u,i;if("loaded"!==r._state)return r._queue.push({event:"stop",action:function(){r.stop(n)}}),r;for(f=r._getSoundIds(n),u=0;u<f.length;u++)r._clearTimer(f[u]),i=r._soundById(f[u]),i&&(i._seek=i._start||0,i._rateSeek=0,i._paused=!0,i._ended=!0,r._stopFade(f[u]),i._node&&(r._webAudio?i._node.bufferSource&&(void 0===i._node.bufferSource.stop?i._node.bufferSource.noteOff(0):i._node.bufferSource.stop(0),r._cleanBuffer(i._node)):isNaN(i._node.duration)&&i._node.duration!==1/0||(i._node.currentTime=i._start||0,i._node.pause())),t||r._emit("stop",i._id));return r},mute:function(t,i){var r=this,e,f,u;if("loaded"!==r._state)return r._queue.push({event:"mute",action:function(){r.mute(t,i)}}),r;if(void 0===i){if("boolean"!=typeof t)return r._muted;r._muted=t}for(e=r._getSoundIds(i),f=0;f<e.length;f++)u=r._soundById(e[f]),u&&(u._muted=t,r._webAudio&&u._node?u._node.gain.setValueAtTime(t?0:u._volume,n.ctx.currentTime):u._node&&(u._node.muted=!!n._muted||t),r._emit("mute",u._id));return r},volume:function(){var f,u,t=this,i=arguments,r,e;if(0===i.length)return t._volume;if(1===i.length||2===i.length&&void 0===i[1]?t._getSoundIds().indexOf(i[0])>=0?u=parseInt(i[0],10):f=parseFloat(i[0]):i.length>=2&&(f=parseFloat(i[0]),u=parseInt(i[1],10)),!(void 0!==f&&f>=0&&f<=1))return r=u?t._soundById(u):t._sounds[0],r?r._volume:0;if("loaded"!==t._state)return t._queue.push({event:"volume",action:function(){t.volume.apply(t,i)}}),t;for(void 0===u&&(t._volume=f),u=t._getSoundIds(u),e=0;e<u.length;e++)(r=t._soundById(u[e]))&&(r._volume=f,i[2]||t._stopFade(u[e]),t._webAudio&&r._node&&!r._muted?r._node.gain.setValueAtTime(f,n.ctx.currentTime):r._node&&!r._muted&&(r._node.volume=f*n.volume()),t._emit("volume",r._id));return t},fade:function(t,i,r,u){var f=this,y=Math.abs(t-i),p=t>i?"out":"in",h=y/.01,l=h>0?r/h:r,c,s,o,a,v,e;if(l<4&&(h=Math.ceil(h/(4/l)),l=4),"loaded"!==f._state)return f._queue.push({event:"fade",action:function(){f.fade(t,i,r,u)}}),f;for(f.volume(t,u),c=f._getSoundIds(u),s=0;s<c.length;s++)o=f._soundById(c[s]),o&&((u||f._stopFade(c[s]),f._webAudio&&!o._muted)&&(a=n.ctx.currentTime,v=a+r/1e3,o._volume=t,o._node.gain.setValueAtTime(t,a),o._node.gain.linearRampToValueAtTime(i,v)),e=t,o._interval=setInterval(function(n,r){h>0&&(e+="in"===p?.01:-.01);e=Math.max(0,e);e=Math.min(1,e);e=Math.round(100*e)/100;f._webAudio?(void 0===u&&(f._volume=e),r._volume=e):f.volume(e,n,!0);(i<t&&e<=i||i>t&&e>=i)&&(clearInterval(r._interval),r._interval=null,f.volume(i,n),f._emit("fade",n))}.bind(f,c[s],o),l));return f},_stopFade:function(t){var r=this,i=r._soundById(t);return i&&i._interval&&(r._webAudio&&i._node.gain.cancelScheduledValues(n.ctx.currentTime),clearInterval(i._interval),i._interval=null,r._emit("fade",t)),r},loop:function(){var r,e,n,i=this,t=arguments,f,u;if(0===t.length)return i._loop;if(1===t.length){if("boolean"!=typeof t[0])return!!(n=i._soundById(parseInt(t[0],10)))&&n._loop;r=t[0];i._loop=r}else 2===t.length&&(r=t[0],e=parseInt(t[1],10));for(f=i._getSoundIds(e),u=0;u<f.length;u++)(n=i._soundById(f[u]))&&(n._loop=r,i._webAudio&&n._node&&n._node.bufferSource&&(n._node.bufferSource.loop=r,r&&(n._node.bufferSource.loopStart=n._start||0,n._node.bufferSource.loopEnd=n._stop)));return i},rate:function(){var e,r,t=this,u=arguments,o,s,i,f;if(0===u.length?r=t._sounds[0]._id:1===u.length?(o=t._getSoundIds(),s=o.indexOf(u[0]),s>=0?r=parseInt(u[0],10):e=parseFloat(u[0])):2===u.length&&(e=parseFloat(u[0]),r=parseInt(u[1],10)),"number"!=typeof e)return i=t._soundById(r),i?i._rate:t._rate;if("loaded"!==t._state)return t._queue.push({event:"rate",action:function(){t.rate.apply(t,u)}}),t;for(void 0===r&&(t._rate=e),r=t._getSoundIds(r),f=0;f<r.length;f++)if(i=t._soundById(r[f])){i._rateSeek=t.seek(r[f]);i._playStart=t._webAudio?n.ctx.currentTime:i._playStart;i._rate=e;t._webAudio&&i._node&&i._node.bufferSource?i._node.bufferSource.playbackRate.value=e:i._node&&(i._node.playbackRate=e);var h=t.seek(r[f]),c=(t._sprite[i._sprite][0]+t._sprite[i._sprite][1])/1e3-h,l=1e3*c/Math.abs(i._rate);!t._endTimers[r[f]]&&i._paused||(t._clearTimer(r[f]),t._endTimers[r[f]]=setTimeout(t._ended.bind(t,i),l));t._emit("rate",i._id)}return t},seek:function(){var f,r,t=this,u=arguments,o,s,i,h,c,e;if(0===u.length?r=t._sounds[0]._id:1===u.length?(o=t._getSoundIds(),s=o.indexOf(u[0]),s>=0?r=parseInt(u[0],10):(r=t._sounds[0]._id,f=parseFloat(u[0]))):2===u.length&&(f=parseFloat(u[0]),r=parseInt(u[1],10)),void 0===r)return t;if("loaded"!==t._state)return t._queue.push({event:"seek",action:function(){t.seek.apply(t,u)}}),t;if(i=t._soundById(r),i){if(!("number"==typeof f&&f>=0))return t._webAudio?(h=t.playing(r)?n.ctx.currentTime-i._playStart:0,c=i._rateSeek?i._rateSeek-i._seek:0,i._seek+(c+h*Math.abs(i._rate))):i._node.currentTime;e=t.playing(r);e&&t.pause(r,!0);i._seek=f;i._ended=!1;t._clearTimer(r);e&&t.play(r,!0);!t._webAudio&&i._node&&(i._node.currentTime=f);t._emit("seek",r)}return t},playing:function(n){var i=this,r,t;if("number"==typeof n)return r=i._soundById(n),!!r&&!r._paused;for(t=0;t<i._sounds.length;t++)if(!i._sounds[t]._paused)return!0;return!1},duration:function(n){var t=this,i=t._duration,r=t._soundById(n);return r&&(i=t._sprite[r._sprite][1]/1e3),i},state:function(){return this._state},unload:function(){for(var f,e,r=this,u=r._sounds,i=0;i<u.length;i++)(u[i]._paused||r.stop(u[i]._id),r._webAudio)||(/MSIE |Trident\//.test(n._navigator&&n._navigator.userAgent)||(u[i]._node.src="data:audio/wav;base64,UklGRigAAABXQVZFZm10IBIAAAABAAEARKwAAIhYAQACABAAAABkYXRhAgAAAAEA"),u[i]._node.removeEventListener("error",u[i]._errorFn,!1),u[i]._node.removeEventListener(n._canPlayEvent,u[i]._loadFn,!1)),delete u[i]._node,r._clearTimer(u[i]._id),f=n._howls.indexOf(r),f>=0&&n._howls.splice(f,1);for(e=!0,i=0;i<n._howls.length;i++)if(n._howls[i]._src===r._src){e=!1;break}return t&&e&&delete t[r._src],n.noAudio=!1,r._state="unloaded",r._sounds=[],r=null,null},on:function(n,t,i,r){var u=this,f=u["_on"+n];return"function"==typeof t&&f.push(r?{id:i,fn:t,once:r}:{id:i,fn:t}),u},off:function(n,t,i){var u=this,e=u["_on"+n],r=0,o,f;if("number"==typeof t&&(i=t,t=null),t||i){for(r=0;r<e.length;r++)if(o=i===e[r].id,t===e[r].fn&&o||!t&&o){e.splice(r,1);break}}else if(n)u["_on"+n]=[];else for(f=Object.keys(u),r=0;r<f.length;r++)0===f[r].indexOf("_on")&&Array.isArray(u[f[r]])&&(u[f[r]]=[]);return u},once:function(n,t,i){var r=this;return r.on(n,t,i,1),r},_emit:function(n,t,i){for(var f=this,u=f["_on"+n],r=u.length-1;r>=0;r--)u[r].id&&u[r].id!==t&&"load"!==n||(setTimeout(function(n){n.call(this,t,i)}.bind(f,u[r].fn),0),u[r].once&&f.off(n,u[r].fn,u[r].id));return f},_loadQueue:function(){var n=this,t;return n._queue.length>0&&(t=n._queue[0],n.once(t.event,function(){n._queue.shift();n._loadQueue()}),t.action()),n},_ended:function(t){var i=this,f=t._sprite,r,u;return!i._webAudio&&i._node&&!i._node.ended?(setTimeout(i._ended.bind(i,t),100),i):(r=!(!t._loop&&!i._sprite[f][2]),(i._emit("end",t._id),!i._webAudio&&r&&i.stop(t._id,!0).play(t._id),i._webAudio&&r)&&(i._emit("play",t._id),t._seek=t._start||0,t._rateSeek=0,t._playStart=n.ctx.currentTime,u=1e3*(t._stop-t._start)/Math.abs(t._rate),i._endTimers[t._id]=setTimeout(i._ended.bind(i,t),u)),i._webAudio&&!r&&(t._paused=!0,t._ended=!0,t._seek=t._start||0,t._rateSeek=0,i._clearTimer(t._id),i._cleanBuffer(t._node),n._autoSuspend()),i._webAudio||r||i.stop(t._id),i)},_clearTimer:function(n){var t=this;return t._endTimers[n]&&(clearTimeout(t._endTimers[n]),delete t._endTimers[n]),t},_soundById:function(n){for(var i=this,t=0;t<i._sounds.length;t++)if(n===i._sounds[t]._id)return i._sounds[t];return null},_inactiveSound:function(){var n=this,t;for(n._drain(),t=0;t<n._sounds.length;t++)if(n._sounds[t]._ended)return n._sounds[t].reset();return new r(n)},_drain:function(){var t=this,r=t._pool,i=0,n=0;if(!(t._sounds.length<r)){for(n=0;n<t._sounds.length;n++)t._sounds[n]._ended&&i++;for(n=t._sounds.length-1;n>=0;n--){if(i<=r)return;t._sounds[n]._ended&&(t._webAudio&&t._sounds[n]._node&&t._sounds[n]._node.disconnect(0),t._sounds.splice(n,1),i--)}}},_getSoundIds:function(n){var r=this,i,t;if(void 0===n){for(i=[],t=0;t<r._sounds.length;t++)i.push(r._sounds[t]._id);return i}return[n]},_refreshBuffer:function(i){var r=this;return i._node.bufferSource=n.ctx.createBufferSource(),i._node.bufferSource.buffer=t[r._src],i._panner?i._node.bufferSource.connect(i._panner):i._node.bufferSource.connect(i._node),i._node.bufferSource.loop=i._loop,i._loop&&(i._node.bufferSource.loopStart=i._start||0,i._node.bufferSource.loopEnd=i._stop),i._node.bufferSource.playbackRate.value=i._rate,r},_cleanBuffer:function(n){var t=this;if(t._scratchBuffer){n.bufferSource.onended=null;n.bufferSource.disconnect(0);try{n.bufferSource.buffer=t._scratchBuffer}catch(n){}}return n.bufferSource=null,t}};r=function(n){this._parent=n;this.init()};r.prototype={init:function(){var t=this,i=t._parent;return t._muted=i._muted,t._loop=i._loop,t._volume=i._volume,t._rate=i._rate,t._seek=0,t._paused=!0,t._ended=!0,t._sprite="__default",t._id=++n._counter,i._sounds.push(t),t.create(),t},create:function(){var t=this,i=t._parent,r=n._muted||t._muted||t._parent._muted?0:t._volume;return i._webAudio?(t._node=void 0===n.ctx.createGain?n.ctx.createGainNode():n.ctx.createGain(),t._node.gain.setValueAtTime(r,n.ctx.currentTime),t._node.paused=!0,t._node.connect(n.masterGain)):(t._node=new Audio,t._errorFn=t._errorListener.bind(t),t._node.addEventListener("error",t._errorFn,!1),t._loadFn=t._loadListener.bind(t),t._node.addEventListener(n._canPlayEvent,t._loadFn,!1),t._node.src=i._src,t._node.preload="auto",t._node.volume=r*n.volume(),t._node.load()),t},reset:function(){var t=this,i=t._parent;return t._muted=i._muted,t._loop=i._loop,t._volume=i._volume,t._rate=i._rate,t._seek=0,t._rateSeek=0,t._paused=!0,t._ended=!0,t._sprite="__default",t._id=++n._counter,t},_errorListener:function(){var n=this;n._parent._emit("loaderror",n._id,n._node.error?n._node.error.code:0);n._node.removeEventListener("error",n._errorFn,!1)},_loadListener:function(){var i=this,t=i._parent;t._duration=Math.ceil(10*i._node.duration)/10;0===Object.keys(t._sprite).length&&(t._sprite={__default:[0,1e3*t._duration]});"loaded"!==t._state&&(t._state="loaded",t._emit("load"),t._loadQueue());i._node.removeEventListener(n._canPlayEvent,i._loadFn,!1)}};var t={},s=function(n){var r=n._src,i;if(t[r])return n._duration=t[r].duration,void o(n);if(/^data:[^;]+;base64,/.test(r)){for(var f=atob(r.split(",")[1]),s=new Uint8Array(f.length),u=0;u<f.length;++u)s[u]=f.charCodeAt(u);e(s.buffer,n)}else i=new XMLHttpRequest,i.open("GET",r,!0),i.responseType="arraybuffer",i.onload=function(){var t=(i.status+"")[0];if("0"!==t&&"2"!==t&&"3"!==t)return void n._emit("loaderror",null,"Failed loading audio file with status: "+i.status+".");e(i.response,n)},i.onerror=function(){n._webAudio&&(n._html5=!0,n._webAudio=!1,n._sounds=[],delete t[r],n.load())},h(i)},h=function(n){try{n.send()}catch(t){n.onerror()}},e=function(i,r){n.ctx.decodeAudioData(i,function(n){n&&r._sounds.length>0&&(t[r._src]=n,o(r,n))},function(){r._emit("loaderror",null,"Decoding audio data failed.")})},o=function(n,t){t&&!n._duration&&(n._duration=t.duration);0===Object.keys(n._sprite).length&&(n._sprite={__default:[0,1e3*n._duration]});"loaded"!==n._state&&(n._state="loaded",n._emit("load"),n._loadQueue())},f=function(){var t;try{"undefined"!=typeof AudioContext?n.ctx=new AudioContext:"undefined"!=typeof webkitAudioContext?n.ctx=new webkitAudioContext:n.usingWebAudio=!1}catch(u){n.usingWebAudio=!1}var u=/iP(hone|od|ad)/.test(n._navigator&&n._navigator.platform),i=n._navigator&&n._navigator.appVersion.match(/OS (\d+)_(\d+)_?(\d+)?/),r=i?parseInt(i[1],10):null;u&&r&&r<9&&(t=/safari/.test(n._navigator&&n._navigator.userAgent.toLowerCase()),(n._navigator&&n._navigator.standalone&&!t||n._navigator&&!n._navigator.standalone&&!t)&&(n.usingWebAudio=!1));n.usingWebAudio&&(n.masterGain=void 0===n.ctx.createGain?n.ctx.createGainNode():n.ctx.createGain(),n.masterGain.gain.value=n._muted?0:1,n.masterGain.connect(n.ctx.destination));n._setup()};"function"==typeof define&&define.amd&&define([],function(){return{Howler:n,Howl:i}});"undefined"!=typeof exports&&(exports.Howler=n,exports.Howl=i);"undefined"!=typeof window?(window.HowlerGlobal=u,window.Howler=n,window.Howl=i,window.Sound=r):"undefined"!=typeof global&&(global.HowlerGlobal=u,global.Howler=n,global.Howl=i,global.Sound=r)}();
/*! Spatial Plugin */
!function(){"use strict";HowlerGlobal.prototype._pos=[0,0,0];HowlerGlobal.prototype._orientation=[0,0,-1,0,1,0];HowlerGlobal.prototype.stereo=function(n){var t=this,i;if(!t.ctx||!t.ctx.listener)return t;for(i=t._howls.length-1;i>=0;i--)t._howls[i].stereo(n);return t};HowlerGlobal.prototype.pos=function(n,t,i){var r=this;return r.ctx&&r.ctx.listener?(t="number"!=typeof t?r._pos[1]:t,i="number"!=typeof i?r._pos[2]:i,"number"!=typeof n?r._pos:(r._pos=[n,t,i],r.ctx.listener.setPosition(r._pos[0],r._pos[1],r._pos[2]),r)):r};HowlerGlobal.prototype.orientation=function(n,t,i,r,u,f){var e=this,o;return!e.ctx||!e.ctx.listener?e:(o=e._orientation,t="number"!=typeof t?o[1]:t,i="number"!=typeof i?o[2]:i,r="number"!=typeof r?o[3]:r,u="number"!=typeof u?o[4]:u,f="number"!=typeof f?o[5]:f,"number"!=typeof n?o:(e._orientation=[n,t,i,r,u,f],e.ctx.listener.setOrientation(n,t,i,r,u,f),e))};Howl.prototype.init=function(n){return function(t){var i=this;return i._orientation=t.orientation||[1,0,0],i._stereo=t.stereo||null,i._pos=t.pos||null,i._pannerAttr={coneInnerAngle:void 0!==t.coneInnerAngle?t.coneInnerAngle:360,coneOuterAngle:void 0!==t.coneOuterAngle?t.coneOuterAngle:360,coneOuterGain:void 0!==t.coneOuterGain?t.coneOuterGain:0,distanceModel:void 0!==t.distanceModel?t.distanceModel:"inverse",maxDistance:void 0!==t.maxDistance?t.maxDistance:1e4,panningModel:void 0!==t.panningModel?t.panningModel:"HRTF",refDistance:void 0!==t.refDistance?t.refDistance:1,rolloffFactor:void 0!==t.rolloffFactor?t.rolloffFactor:1},i._onstereo=t.onstereo?[{fn:t.onstereo}]:[],i._onpos=t.onpos?[{fn:t.onpos}]:[],i._onorientation=t.onorientation?[{fn:t.onorientation}]:[],n.call(this,t)}}(Howl.prototype.init);Howl.prototype.stereo=function(t,i){var r=this,e,o,f,u;if(!r._webAudio)return r;if("loaded"!==r._state)return r._queue.push({event:"stereo",action:function(){r.stereo(t,i)}}),r;if(e=void 0===Howler.ctx.createStereoPanner?"spatial":"stereo",void 0===i){if("number"!=typeof t)return r._stereo;r._stereo=t;r._pos=[t,0,0]}for(o=r._getSoundIds(i),f=0;f<o.length;f++)if(u=r._soundById(o[f]),u){if("number"!=typeof t)return u._stereo;u._stereo=t;u._pos=[t,0,0];u._node&&(u._pannerAttr.panningModel="equalpower",u._panner&&u._panner.pan||n(u,e),"spatial"===e?u._panner.setPosition(t,0,0):u._panner.pan.value=t);r._emit("stereo",u._id)}return r};Howl.prototype.pos=function(t,i,r,u){var f=this,s,o,e;if(!f._webAudio)return f;if("loaded"!==f._state)return f._queue.push({event:"pos",action:function(){f.pos(t,i,r,u)}}),f;if(i="number"!=typeof i?0:i,r="number"!=typeof r?-.5:r,void 0===u){if("number"!=typeof t)return f._pos;f._pos=[t,i,r]}for(s=f._getSoundIds(u),o=0;o<s.length;o++)if(e=f._soundById(s[o]),e){if("number"!=typeof t)return e._pos;e._pos=[t,i,r];e._node&&(e._panner&&!e._panner.pan||n(e,"spatial"),e._panner.setPosition(t,i,r));f._emit("pos",e._id)}return f};Howl.prototype.orientation=function(t,i,r,u){var f=this,s,o,e;if(!f._webAudio)return f;if("loaded"!==f._state)return f._queue.push({event:"orientation",action:function(){f.orientation(t,i,r,u)}}),f;if(i="number"!=typeof i?f._orientation[1]:i,r="number"!=typeof r?f._orientation[2]:r,void 0===u){if("number"!=typeof t)return f._orientation;f._orientation=[t,i,r]}for(s=f._getSoundIds(u),o=0;o<s.length;o++)if(e=f._soundById(s[o]),e){if("number"!=typeof t)return e._orientation;e._orientation=[t,i,r];e._node&&(e._panner||(e._pos||(e._pos=f._pos||[0,0,-.5]),n(e,"spatial")),e._panner.setOrientation(t,i,r));f._emit("orientation",e._id)}return f};Howl.prototype.pannerAttr=function(){var t,s,f,i=this,e=arguments,h,o,r,u;if(!i._webAudio)return i;if(0===e.length)return i._pannerAttr;if(1===e.length){if("object"!=typeof e[0])return f=i._soundById(parseInt(e[0],10)),f?f._pannerAttr:i._pannerAttr;t=e[0];void 0===s&&(i._pannerAttr={coneInnerAngle:void 0!==t.coneInnerAngle?t.coneInnerAngle:i._coneInnerAngle,coneOuterAngle:void 0!==t.coneOuterAngle?t.coneOuterAngle:i._coneOuterAngle,coneOuterGain:void 0!==t.coneOuterGain?t.coneOuterGain:i._coneOuterGain,distanceModel:void 0!==t.distanceModel?t.distanceModel:i._distanceModel,maxDistance:void 0!==t.maxDistance?t.maxDistance:i._maxDistance,panningModel:void 0!==t.panningModel?t.panningModel:i._panningModel,refDistance:void 0!==t.refDistance?t.refDistance:i._refDistance,rolloffFactor:void 0!==t.rolloffFactor?t.rolloffFactor:i._rolloffFactor})}else 2===e.length&&(t=e[0],s=parseInt(e[1],10));for(h=i._getSoundIds(s),o=0;o<h.length;o++)(f=i._soundById(h[o]))&&(r=f._pannerAttr,r={coneInnerAngle:void 0!==t.coneInnerAngle?t.coneInnerAngle:r.coneInnerAngle,coneOuterAngle:void 0!==t.coneOuterAngle?t.coneOuterAngle:r.coneOuterAngle,coneOuterGain:void 0!==t.coneOuterGain?t.coneOuterGain:r.coneOuterGain,distanceModel:void 0!==t.distanceModel?t.distanceModel:r.distanceModel,maxDistance:void 0!==t.maxDistance?t.maxDistance:r.maxDistance,panningModel:void 0!==t.panningModel?t.panningModel:r.panningModel,refDistance:void 0!==t.refDistance?t.refDistance:r.refDistance,rolloffFactor:void 0!==t.rolloffFactor?t.rolloffFactor:r.rolloffFactor},u=f._panner,u?(u.coneInnerAngle=r.coneInnerAngle,u.coneOuterAngle=r.coneOuterAngle,u.coneOuterGain=r.coneOuterGain,u.distanceModel=r.distanceModel,u.maxDistance=r.maxDistance,u.panningModel=r.panningModel,u.refDistance=r.refDistance,u.rolloffFactor=r.rolloffFactor):(f._pos||(f._pos=i._pos||[0,0,-.5]),n(f,"spatial")));return i};Sound.prototype.init=function(n){return function(){var t=this,i=t._parent;t._orientation=i._orientation;t._stereo=i._stereo;t._pos=i._pos;t._pannerAttr=i._pannerAttr;n.call(this);t._stereo?i.stereo(t._stereo):t._pos&&i.pos(t._pos[0],t._pos[1],t._pos[2],t._id)}}(Sound.prototype.init);Sound.prototype.reset=function(n){return function(){var t=this,i=t._parent;return t._orientation=i._orientation,t._pos=i._pos,t._pannerAttr=i._pannerAttr,n.call(this)}}(Sound.prototype.reset);var n=function(n,t){t=t||"spatial";"spatial"===t?(n._panner=Howler.ctx.createPanner(),n._panner.coneInnerAngle=n._pannerAttr.coneInnerAngle,n._panner.coneOuterAngle=n._pannerAttr.coneOuterAngle,n._panner.coneOuterGain=n._pannerAttr.coneOuterGain,n._panner.distanceModel=n._pannerAttr.distanceModel,n._panner.maxDistance=n._pannerAttr.maxDistance,n._panner.panningModel=n._pannerAttr.panningModel,n._panner.refDistance=n._pannerAttr.refDistance,n._panner.rolloffFactor=n._pannerAttr.rolloffFactor,n._panner.setPosition(n._pos[0],n._pos[1],n._pos[2]),n._panner.setOrientation(n._orientation[0],n._orientation[1],n._orientation[2])):(n._panner=Howler.ctx.createStereoPanner(),n._panner.pan.value=n._stereo);n._panner.connect(n._node);n._paused||n._parent.pause(n._id,!0).play(n._id)}}()