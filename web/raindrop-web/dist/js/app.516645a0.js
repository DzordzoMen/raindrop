(function(e){function t(t){for(var a,r,c=t[0],s=t[1],u=t[2],l=0,d=[];l<c.length;l++)r=c[l],Object.prototype.hasOwnProperty.call(o,r)&&o[r]&&d.push(o[r][0]),o[r]=0;for(a in s)Object.prototype.hasOwnProperty.call(s,a)&&(e[a]=s[a]);p&&p(t);while(d.length)d.shift()();return i.push.apply(i,u||[]),n()}function n(){for(var e,t=0;t<i.length;t++){for(var n=i[t],a=!0,r=1;r<n.length;r++){var c=n[r];0!==o[c]&&(a=!1)}a&&(i.splice(t--,1),e=s(s.s=n[0]))}return e}var a={},r={app:0},o={app:0},i=[];function c(e){return s.p+"js/"+({}[e]||e)+"."+{"chunk-2d0b2747":"bfcdfdc1","chunk-49a0ab42":"9f0ab1c0","chunk-4c50c865":"3e4559ad","chunk-bacab442":"bf9caedb"}[e]+".js"}function s(t){if(a[t])return a[t].exports;var n=a[t]={i:t,l:!1,exports:{}};return e[t].call(n.exports,n,n.exports,s),n.l=!0,n.exports}s.e=function(e){var t=[],n={"chunk-49a0ab42":1,"chunk-4c50c865":1,"chunk-bacab442":1};r[e]?t.push(r[e]):0!==r[e]&&n[e]&&t.push(r[e]=new Promise((function(t,n){for(var a="css/"+({}[e]||e)+"."+{"chunk-2d0b2747":"31d6cfe0","chunk-49a0ab42":"fbbf9df6","chunk-4c50c865":"97a94fcb","chunk-bacab442":"083c8403"}[e]+".css",o=s.p+a,i=document.getElementsByTagName("link"),c=0;c<i.length;c++){var u=i[c],l=u.getAttribute("data-href")||u.getAttribute("href");if("stylesheet"===u.rel&&(l===a||l===o))return t()}var d=document.getElementsByTagName("style");for(c=0;c<d.length;c++){u=d[c],l=u.getAttribute("data-href");if(l===a||l===o)return t()}var p=document.createElement("link");p.rel="stylesheet",p.type="text/css",p.onload=t,p.onerror=function(t){var a=t&&t.target&&t.target.src||o,i=new Error("Loading CSS chunk "+e+" failed.\n("+a+")");i.code="CSS_CHUNK_LOAD_FAILED",i.request=a,delete r[e],p.parentNode.removeChild(p),n(i)},p.href=o;var m=document.getElementsByTagName("head")[0];m.appendChild(p)})).then((function(){r[e]=0})));var a=o[e];if(0!==a)if(a)t.push(a[2]);else{var i=new Promise((function(t,n){a=o[e]=[t,n]}));t.push(a[2]=i);var u,l=document.createElement("script");l.charset="utf-8",l.timeout=120,s.nc&&l.setAttribute("nonce",s.nc),l.src=c(e);var d=new Error;u=function(t){l.onerror=l.onload=null,clearTimeout(p);var n=o[e];if(0!==n){if(n){var a=t&&("load"===t.type?"missing":t.type),r=t&&t.target&&t.target.src;d.message="Loading chunk "+e+" failed.\n("+a+": "+r+")",d.name="ChunkLoadError",d.type=a,d.request=r,n[1](d)}o[e]=void 0}};var p=setTimeout((function(){u({type:"timeout",target:l})}),12e4);l.onerror=l.onload=u,document.head.appendChild(l)}return Promise.all(t)},s.m=e,s.c=a,s.d=function(e,t,n){s.o(e,t)||Object.defineProperty(e,t,{enumerable:!0,get:n})},s.r=function(e){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},s.t=function(e,t){if(1&t&&(e=s(e)),8&t)return e;if(4&t&&"object"===typeof e&&e&&e.__esModule)return e;var n=Object.create(null);if(s.r(n),Object.defineProperty(n,"default",{enumerable:!0,value:e}),2&t&&"string"!=typeof e)for(var a in e)s.d(n,a,function(t){return e[t]}.bind(null,a));return n},s.n=function(e){var t=e&&e.__esModule?function(){return e["default"]}:function(){return e};return s.d(t,"a",t),t},s.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},s.p="/raindrop/",s.oe=function(e){throw console.error(e),e};var u=window["webpackJsonp"]=window["webpackJsonp"]||[],l=u.push.bind(u);u.push=t,u=u.slice();for(var d=0;d<u.length;d++)t(u[d]);var p=l;i.push([0,"chunk-vendors"]),n()})({0:function(e,t,n){e.exports=n("56d7")},"56d7":function(e,t,n){"use strict";n.r(t);n("e260"),n("e6cf"),n("cca6"),n("a79d");var a=n("2b0e"),r=n("1dce"),o=n.n(r),i=function(){var e=this,t=e.$createElement,n=e._self._c||t;return n("v-app",[n("the-header"),n("v-navigation-drawer",{staticClass:"v-theme--dark",attrs:{permanent:"",left:"",clipped:"",app:""}},[n("v-list",{attrs:{dense:"",nav:""}},[e._l(e.items,(function(t){return n("v-list-item",{key:t.title,attrs:{link:""},on:{click:function(n){return e.redirect(t.routerName)}}},[n("v-list-item-icon",[n("v-icon",[e._v(e._s(t.icon))])],1),n("v-list-item-content",[n("v-list-item-title",[e._v(e._s(t.title))])],1)],1)})),n("v-list-item",{attrs:{link:""},on:{click:function(t){return e.openRankomat()}}},[n("v-list-item-icon",[n("v-icon",[e._v("mdi-water-alert-outline")])],1),n("v-list-item-content",[n("v-list-item-title",[e._v("Twoje zu??ycie wody")])],1)],1)],2)],1),n("v-main",[n("v-container",[n("router-view")],1)],1)],1)},c=[],s=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("v-app-bar",{attrs:{app:"",color:"primary lighten-2",dark:"","clipped-left":""}},[a("div",{staticClass:"d-flex align-center",staticStyle:{gap:"10px"}},[a("v-img",{attrs:{alt:"Raindrop Logo",contain:"",src:n("9b19"),width:"40",height:"40"}}),a("span",{staticClass:"headline"},[e._v(" Raindrop ")])],1),a("v-spacer"),a("button",{staticClass:"d-flex align-right"},[a("span",[e._v(" Przejd?? do aplikacji ")]),a("v-icon",[e._v(" arrow-right-thin ")])],1)],1)},u=[],l={name:"TheHeader"},d=l,p=n("2877"),m=n("6544"),f=n.n(m),h=n("40dc"),v=n("132d"),b=n("adda"),g=n("2fa4"),y=Object(p["a"])(d,s,u,!1,null,null,null),w=y.exports;f()(y,{VAppBar:h["a"],VIcon:v["a"],VImg:b["a"],VSpacer:g["a"]});var k={name:"App",components:{TheHeader:w},data:function(){return{items:[{title:"O nas",icon:"mdi-account-group",routerName:"Home"},{title:"Jak zacz????",icon:"mdi-help",routerName:"Start"},{title:"Dotacje",icon:"mdi-cash-multiple",routerName:"Grants"},{title:"Ile zaoszcz??dzisz",icon:"mdi-calculator",routerName:"Savings"}]}},methods:{redirect:function(e){this.$router.push({name:e})},openRankomat:function(){window.open("https://rankomat.pl/woda/#/","_blank")}}},z=k,_=(n("5c0b"),n("7496")),j=n("a523"),C=n("8860"),V=n("da13"),O=n("5d23"),S=n("34c3"),x=n("f6c4"),P=n("f774"),T=Object(p["a"])(z,i,c,!1,null,null,null),E=T.exports;f()(T,{VApp:_["a"],VContainer:j["a"],VIcon:v["a"],VList:C["a"],VListItem:V["a"],VListItemContent:O["a"],VListItemIcon:S["a"],VListItemTitle:O["b"],VMain:x["a"],VNavigationDrawer:P["a"]});n("d3b7"),n("3ca3"),n("ddb0");var I=n("8c4f"),N=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("v-container",[a("v-row",{attrs:{dense:""}},[a("v-col",{attrs:{cols:"12"}},[a("h1",[e._v("Team Raindrop")])]),a("v-col",{attrs:{cols:"12"}},[e._v(" Jeste??my grup?? m??odych ludzi, ??wiadomych nadchodz??cych k??opot??w klimatycznych, kt??re mog?? czeka?? zar??wno nas jak i przysz??e pokolenie. Idea Raindrop zrodzi??a si?? podczas Aquathonu 2021 - pierwszego hackathonu w Polsce po??wi??conego zagadnieniom gospodarki wodnej. ")]),a("v-col",{attrs:{"cols-12":""}},[a("h3",[e._v("Nasz cel")])]),a("v-col",{attrs:{cols:"12"}},[e._v(" W domach jednorodzinnych mieszka oko??o 55% Polak??w. W tej liczbie tkwi ogromny potencja??. Chcemy spopularyzowa?? oszcz??dzanie wody poprzez przydomowe zbiorniki retencyjne. Woda deszczowa mo??e mie?? wiele zastosowa?? - od nawadniania ogrod??w, przez u??ycie w zmywarce, po sp??ukiwanie toalety. Poprzez nasza stron?? chcemy u??atwi?? ka??demu uczynienia pierwszego kroku w stron?? domu pasywnego, czyli budynku o maksymalnie ograniczonych potrzebach energetycznych. ")]),a("v-col",{staticClass:"pt-3",attrs:{cols:"12"}},[a("v-img",{attrs:{alt:"Green-city",src:n("da22")}})],1)],1)],1)},L=[],A={name:"Home"},R=A,H=n("62ad"),M=n("0fd9"),$=Object(p["a"])(R,N,L,!1,null,null,null),B=$.exports;f()($,{VCol:H["a"],VContainer:j["a"],VImg:b["a"],VRow:M["a"]}),a["a"].use(I["a"]);var D=[{path:"/",name:"Home",component:B},{path:"/start",name:"Start",component:function(){return n.e("chunk-4c50c865").then(n.bind(null,"d701"))}},{path:"/grants",name:"Grants",component:function(){return n.e("chunk-bacab442").then(n.bind(null,"5faf"))}},{path:"/savings",name:"Savings",component:function(){return n.e("chunk-49a0ab42").then(n.bind(null,"1baa"))}},{path:"/water-consumption",name:"WaterConsumption",component:function(){return n.e("chunk-2d0b2747").then(n.bind(null,"23d4"))}}],J=new I["a"]({mode:"history",base:"/raindrop/",routes:D}),W=J,q=n("2f62");a["a"].use(q["a"]);var G=new q["a"].Store({state:{},mutations:{},actions:{},modules:{}}),F=n("f309");a["a"].use(F["a"]);var K=new F["a"]({});a["a"].config.productionTip=!1,new a["a"]({router:W,store:G,vuetify:K,render:function(e){return e(E)}}).$mount("#app"),a["a"].use(o.a)},"5c0b":function(e,t,n){"use strict";n("9c0c")},"9b19":function(e,t,n){e.exports=n.p+"img/logo.3e9b212f.svg"},"9c0c":function(e,t,n){},da22:function(e,t,n){e.exports=n.p+"img/city.a0fdb2b1.jpg"}});
//# sourceMappingURL=app.516645a0.js.map