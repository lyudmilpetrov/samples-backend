!function(){function e(e,t,n,o,a,i,r){try{var s=e[i](r),c=s.value}catch(l){return void n(l)}s.done?t(c):Promise.resolve(c).then(o,a)}function t(t){return function(){var n=this,o=arguments;return new Promise((function(a,i){var r=t.apply(n,o);function s(t){e(r,a,i,s,c,"next",t)}function c(t){e(r,a,i,s,c,"throw",t)}s(void 0)}))}}function n(e,t){if(!(e instanceof t))throw new TypeError("Cannot call a class as a function")}function o(e,t){for(var n=0;n<t.length;n++){var o=t[n];o.enumerable=o.enumerable||!1,o.configurable=!0,"value"in o&&(o.writable=!0),Object.defineProperty(e,o.key,o)}}function a(e,t,n){return t&&o(e.prototype,t),n&&o(e,n),e}(window.webpackJsonp=window.webpackJsonp||[]).push([[9],{pgxD:function(e,o,i){"use strict";i.r(o),i.d(o,"FaceLoginModule",(function(){return X}));var r,s=i("3Pt+"),c=i("ofXK"),l=i("tyNb"),d=i("S0DU"),h=i("fXoL"),u=i("0IaG"),m=i("kmnG"),p=i("qFsG"),g=i("d3UM"),f=i("FKr1"),b=((r=function(){function e(t,o,a,i){var r=this;n(this,e),this.data=o,this.dialogRef=a,this.ngZone=i,this.form=new s.f({username:new s.d(""),password:new s.d("")}),this.submitEM=new h.o,this.message="Are you sure?",this.confirmButtonText="Close",this.cancelButtonText="Cancel",this.ngZone.run((function(){o&&(r.message=o.message||r.message)}))}return a(e,[{key:"onConfirmClick",value:function(){var e=this;console.log("Close now"),this.ngZone.run((function(){e.dialogRef.close("some info here")}))}},{key:"submit",value:function(){this.form.valid&&this.submitEM.emit(this.form.value)}}]),e}()).\u0275fac=function(e){return new(e||r)(h.Mb(r,12),h.Mb(u.a),h.Mb(u.f),h.Mb(h.B))},r.\u0275cmp=h.Gb({type:r,selectors:[["app-login-form"]],outputs:{submitEM:"submitEM"},decls:10,vars:0,consts:[[2,"min-width","50vw !important"],["matInput","","placeholder","Enter name"],["matInput","","placeholder","Textarea"],["placeholder","Select"],["value","option"]],template:function(e,t){1&e&&(h.Sb(0,"mat-form-field",0),h.Nb(1,"input",1),h.Rb(),h.Nb(2,"br"),h.Sb(3,"mat-form-field"),h.Nb(4,"textarea",2),h.Rb(),h.Nb(5,"br"),h.Sb(6,"mat-form-field"),h.Sb(7,"mat-select",3),h.Sb(8,"mat-option",4),h.Cc(9,"Option"),h.Rb(),h.Rb(),h.Rb())},directives:[m.c,p.b,g.a,f.m],encapsulation:2}),r),v=i("qzk7"),w=i("XBjD"),C=i("42F4"),x=i("dNgK"),y=i("tk/3"),M=i("XiUz"),k=i("Wp6s"),P=i("NFeN"),S=i("bTqV"),R=i("7EHt"),E=["video"],O=["canvasLast"],F=["canvasPrior"];function L(e,t){1&e&&(h.Sb(0,"mat-error"),h.Cc(1," You must provide the "),h.Sb(2,"strong"),h.Cc(3," user name"),h.Rb(),h.Rb())}function _(e,t){1&e&&(h.Sb(0,"mat-error"),h.Cc(1," It must start with a "),h.Sb(2,"strong"),h.Cc(3," letter"),h.Rb(),h.Rb())}function I(e,t){1&e&&(h.Sb(0,"mat-error"),h.Cc(1," You must provide the "),h.Sb(2,"strong"),h.Cc(3," password"),h.Rb(),h.Rb())}function D(e,t){if(1&e&&(h.Sb(0,"mat-error"),h.Cc(1," It contains "),h.Sb(2,"strong"),h.Cc(3," restricted "),h.Rb(),h.Cc(4),h.Rb()),2&e){var n=h.ec(2);h.Bb(4),h.Ec(" word - ",null==n.password.errors?null:n.password.errors.restrictedWords," ")}}function W(e,t){if(1&e){var n=h.Tb();h.Sb(0,"div",2),h.Sb(1,"mat-card",3),h.Sb(2,"mat-card-header"),h.Sb(3,"mat-card-title"),h.Cc(4,"Log in"),h.Rb(),h.Rb(),h.Sb(5,"form",4),h.Sb(6,"mat-card-content"),h.Sb(7,"mat-form-field",5),h.Nb(8,"input",6),h.Bc(9,L,4,0,"mat-error",1),h.Bc(10,_,4,0,"mat-error",1),h.Rb(),h.Sb(11,"mat-form-field",5),h.Nb(12,"input",7),h.Sb(13,"mat-icon",8),h.ac("click",(function(){h.tc(n);var e=h.ec();return e.hidePassword=!e.hidePassword})),h.Cc(14),h.Rb(),h.Bc(15,I,4,0,"mat-error",1),h.Bc(16,D,5,1,"mat-error",1),h.Rb(),h.Rb(),h.Sb(17,"button",9),h.ac("click",(function(){h.tc(n);var e=h.ec();return e.loginWithPassword(e.profileForm.value)})),h.Cc(18,"Log in with password"),h.Rb(),h.Sb(19,"button",10),h.ac("click",(function(){h.tc(n);var e=h.ec();return e.loginWithFace(e.profileForm.value)})),h.Cc(20,"Log in with face"),h.Rb(),h.Rb(),h.Rb(),h.Rb()}if(2&e){var o=h.ec();h.Bb(5),h.jc("formGroup",o.profileForm),h.Bb(4),h.jc("ngIf",o.errorHandling("username","required")),h.Bb(1),h.jc("ngIf",null==o.username.errors?null:o.username.errors.pattern),h.Bb(2),h.jc("type",o.hidePassword?"password":"text"),h.Bb(2),h.Dc(o.hidePassword?"visibility_off":"visibility"),h.Bb(1),h.jc("ngIf",o.errorHandling("password","required")),h.Bb(1),h.jc("ngIf",null==o.password.errors?null:o.password.errors.restrictedWords)}}function B(e,t){if(1&e){var n=h.Tb();h.Sb(0,"mat-accordion"),h.Sb(1,"mat-expansion-panel",11),h.Sb(2,"mat-expansion-panel-header"),h.Sb(3,"mat-panel-title"),h.Cc(4," This is the expansion title "),h.Rb(),h.Sb(5,"mat-panel-description"),h.Cc(6," This is a summary of the content "),h.Rb(),h.Rb(),h.Sb(7,"p"),h.Cc(8,"This is the primary content of the panel."),h.Rb(),h.Rb(),h.Sb(9,"mat-expansion-panel",12),h.ac("opened",(function(){return h.tc(n),h.ec().panelOpenState=!0}))("closed",(function(){return h.tc(n),h.ec().panelOpenState=!1})),h.Sb(10,"mat-expansion-panel-header"),h.Sb(11,"mat-panel-title"),h.Cc(12," Self aware panel "),h.Rb(),h.Sb(13,"mat-panel-description"),h.Cc(14),h.Rb(),h.Rb(),h.Sb(15,"p"),h.Cc(16),h.Rb(),h.Rb(),h.Rb()}if(2&e){var o=h.ec();h.Bb(14),h.Ec(" ",o.panelOpenState?"Opened":"Closed"," "),h.Bb(2),h.Ec("Welcome ",o.currentUserName,"")}}var N,T,j=[{path:"",component:(N=function(){function e(t,o,a,i,r,c,l){var d,h=this;n(this,e),this.toastr=t,this.renderer=o,this.os=a,this.dialog=i,this.snackBar=r,this.httpClient=c,this.ngZone=l,this.MODEL_URL="../../assets/weights",this.constraints={audio:!1,video:{facingMode:"selfie",width:{ideal:4096},height:{ideal:2160}}},this.mtcnnForwardParams={minFaceSize:200,scaleFactor:.709,maxNumScales:10,scoreThresholds:[.6,.7,.7]},this.videoWidth=0,this.videoHeight=0,this.result=0,this.valueInput="",this.images=[],this.matched="These faces belong to different people!",this.maxDescriptorDistance=.4,this.IsWait=!1,this.switchimage=1,this.username=new s.d("",[s.q.required,s.q.pattern("[a-zA-Z].*")]),this.password=new s.d("",[s.q.required,(d=["test","bar"],function(e){if(d){var t=d.map((function(t){return e.value.includes(t)?t:null})).filter((function(e){return null!=e}));return t&&t.length>0?{restrictedWords:t.join(", ")}:null}return null})]),this.profileForm=new s.f({username:this.username,password:this.password}),this.hideLoginForm=!1,this.hidePassword=!0,this.panelOpenState=!1,this.currentUserName="",this.errorHandling=function(e,t){return h.profileForm.controls[e].hasError(t)},Promise.all([this.loadF(this.MODEL_URL,"loadSsdMobilenetv1Model").then((function(e){console.log(e)})).catch((function(e){console.log(e)})).finally((function(){console.log("done")})),this.loadF(this.MODEL_URL,"loadFaceDetectionModel").then((function(e){console.log(e)})).catch((function(e){console.log(e)})).finally((function(){console.log("done")})),this.loadF(this.MODEL_URL,"loadFaceLandmarkModel").then((function(e){console.log(e)})).catch((function(e){console.log(e)})).finally((function(){console.log("done")})),this.loadF(this.MODEL_URL,"loadFaceRecognitionModel").then((function(e){console.log(e)})).catch((function(e){console.log(e)})).finally((function(){console.log("done")}))]).then((function(e){console.log(e)})).catch((function(e){return console.log(e)})).finally((function(){console.log("done loading"),console.log(v)}))}var o,i,r;return a(e,[{key:"ngOnInit",value:function(){this.toastr.options.positionClass="toast-top-center",this.toastr.success("open now","title"),console.log(v),this.breakpoint=window.innerWidth<=400?1:2}},{key:"loginWithPassword",value:function(e){if(console.log(e),this.profileForm.valid&&e.username.replace(/ +/g," ").length>=1&&e.password.replace(/ +/g," ").length){var t={username:e.username,password:e.password};this.currentUserName=e.username,this.os.setCache("localStorage",e.username.replace(/ +/g," "),t,"object"),this.hideLoginForm=!0}}},{key:"loginWithFace",value:function(e){console.log(e)}},{key:"openLoginForm",value:function(e){this.dialog.open(b,{width:"60vw",maxWidth:"60vw",height:"60vh",maxHeight:"60vh",data:{message:e,buttonText:{ok:"Save",cancel:"No"}}}).afterClosed().subscribe((function(e){console.log(e)}))}},{key:"onResize",value:function(e){this.breakpoint=e.target.innerWidth<=4?1:2}},{key:"loadF",value:(r=t(regeneratorRuntime.mark((function e(t,n){return regeneratorRuntime.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,v[n](t);case 2:case"end":return e.stop()}}),e)}))),function(e,t){return r.apply(this,arguments)})},{key:"handleError",value:function(e){console.log("Error: ",e)}},{key:"attachVideo",value:function(e){var t=this;this.renderer.setProperty(this.videoElement.nativeElement,"srcObject",e),this.renderer.listen(this.videoElement.nativeElement,"play",(function(e){t.videoHeight=t.videoElement.nativeElement.videoHeight,t.videoWidth=t.videoElement.nativeElement.videoWidth}))}},{key:"startCamera",value:function(){navigator.mediaDevices&&navigator.mediaDevices.getUserMedia?navigator.mediaDevices.getUserMedia(this.constraints).then(this.attachVideo.bind(this)).catch(this.handleError):alert("Camera not available.")}},{key:"captureImageFirst",value:function(){this.renderer.setProperty(this.canvasLast.nativeElement,"width",this.videoWidth),this.renderer.setProperty(this.canvasLast.nativeElement,"height",this.videoHeight),this.canvasLast.nativeElement.getContext("2d").drawImage(this.videoElement.nativeElement,0,0)}},{key:"captureImageSecond",value:function(){this.renderer.setProperty(this.canvasPrior.nativeElement,"width",this.videoWidth),this.renderer.setProperty(this.canvasPrior.nativeElement,"height",this.videoHeight),this.canvasPrior.nativeElement.getContext("2d").drawImage(this.videoElement.nativeElement,0,0)}},{key:"capture",value:function(){1===this.switchimage?(this.switchimage=2,this.captureImageFirst()):(this.switchimage=1,this.captureImageSecond())}},{key:"compareImages",value:(i=t(regeneratorRuntime.mark((function e(){var t,n=this;return regeneratorRuntime.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return this.IsWait=!0,this.ngZone.run((function(){n.IsWait=!0})),e.next=3,this.computeSingleFaceDescriptors(this.canvasLast.nativeElement,this.canvasPrior.nativeElement,"Lyudmil",this.videoHeight,this.videoWidth);case 3:t=e.sent,console.log(t),t<=this.maxDescriptorDistance?(this.matched="The faces belong to one person!",this.openDialog(this.matched),this.IsWait=!1):(this.matched="It is hard to tell if that is the same person!",this.openDialog(this.matched),this.IsWait=!1);case 5:case"end":return e.stop()}}),e,this)}))),function(){return i.apply(this,arguments)})},{key:"computeSingleFaceDescriptors",value:(o=t(regeneratorRuntime.mark((function e(t,n,o,a,i){var r,s,c,l,d,h;return regeneratorRuntime.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return r={width:i,height:a},e.next=4,v.detectSingleFace(t).withFaceLandmarks().withFaceDescriptor();case 4:return s=e.sent,s=v.resizeResults(s,r),e.next=8,v.detectSingleFace(n).withFaceLandmarks().withFaceDescriptor();case 8:return c=e.sent,c=v.resizeResults(c,r),void 0!==s&&(v.draw.drawDetections(t,s),v.draw.drawFaceLandmarks(t,s)),void 0!==c&&(v.draw.drawDetections(n,c),v.draw.drawFaceLandmarks(n,c)),console.log([s.descriptor]),l=[c.descriptor],console.log(l),d=new v.LabeledFaceDescriptors("Prior",l),h=new v.FaceMatcher(d,this.maxDescriptorDistance),e.abrupt("return",[s].map((function(e){return h.findBestMatch(e.descriptor)}))[0]._distance);case 14:case"end":return e.stop()}}),e,this)}))),function(e,t,n,a,i){return o.apply(this,arguments)})},{key:"openDialog",value:function(e){this.dialog.open(d.a,{data:{message:e,buttonText:{ok:"Save",cancel:"No"}}}).afterClosed().subscribe((function(e){console.log(e)}))}},{key:"onFileComplete",value:function(e){var t=this;console.log(e);var n=new Image;n.src=e.result,n.onload=function(){var e=n.naturalWidth,o=t.canvasLast.nativeElement.width,a=1;e>o&&(a=o/e);var i=n.naturalHeight,r=t.canvasLast.nativeElement.height,s=1;i>r&&(s=r/i);var c=s;a<s&&(c=a),c<1&&(i*=c,e*=c),t.canvasLast.nativeElement.height=i,t.canvasLast.nativeElement.width=e,t.canvasLast.nativeElement.getContext("2d").drawImage(n,0,0,n.naturalWidth,n.naturalHeight,0,0,e,i)}}},{key:"clearFirst",value:function(){var e=this.canvasLast.nativeElement.getContext("2d");e.clearRect(0,0,e.canvas.width,e.canvas.height),e.restore()}},{key:"clearSecond",value:function(){var e=this.canvasPrior.nativeElement.getContext("2d");e.clearRect(0,0,e.canvas.width,e.canvas.height),e.restore()}}]),e}(),N.\u0275fac=function(e){return new(e||N)(h.Mb(w.a),h.Mb(h.G),h.Mb(C.b),h.Mb(u.b),h.Mb(x.a),h.Mb(y.a),h.Mb(h.B))},N.\u0275cmp=h.Gb({type:N,selectors:[["ng-component"]],viewQuery:function(e,t){var n;1&e&&(h.xc(E,!0),h.xc(O,!0),h.xc(F,!0)),2&e&&(h.pc(n=h.bc())&&(t.videoElement=n.first),h.pc(n=h.bc())&&(t.canvasLast=n.first),h.pc(n=h.bc())&&(t.canvasPrior=n.first))},decls:2,vars:2,consts:[["class","login-wrapper","fxLayout","row","fxLayoutAlign","center center",4,"ngIf"],[4,"ngIf"],["fxLayout","row","fxLayoutAlign","center center",1,"login-wrapper"],[1,"box"],["autocomplete","off","novalidate","",1,"example-form",3,"formGroup"],[1,"example-full-width"],["matInput","","formControlName","username","placeholder","Username"],["matInput","","placeholder","Password","formControlName","password","required","",3,"type"],["matSuffix","",3,"click"],["mat-stroked-button","","color","accent",1,"btn",2,"float","left",3,"click"],["mat-stroked-button","","color","accent",1,"btn",2,"float","right",3,"click"],["hideToggle",""],[3,"opened","closed"]],template:function(e,t){1&e&&(h.Bc(0,W,21,7,"div",0),h.Bc(1,B,17,2,"mat-accordion",1)),2&e&&(h.jc("ngIf",!t.hideLoginForm),h.Bb(1),h.jc("ngIf",t.hideLoginForm))},directives:[c.k,M.b,M.a,k.a,k.d,k.g,s.r,s.m,s.g,k.c,m.c,p.b,s.c,s.l,s.e,s.p,P.a,m.f,S.a,m.b,R.a,R.c,R.e,R.f,R.d],styles:['.login-wrapper[_ngcontent-%COMP%]{height:100%}.positronx[_ngcontent-%COMP%]{text-decoration:none;color:#b81d1d}.box[_ngcontent-%COMP%]{position:relative;top:0;opacity:1;float:left;width:100%;background:#8a88fb;border-radius:10px;transform:scale(1);-webkit-transform:scale(1);-ms-transform:scale(1);z-index:5;max-width:330px}.box.back[_ngcontent-%COMP%]{top:-20px;opacity:.8}.box.back[_ngcontent-%COMP%], .box[_ngcontent-%COMP%]:before{transform:scale(.95);-webkit-transform:scale(.95);-ms-transform:scale(.95);z-index:-1}.box[_ngcontent-%COMP%]:before{content:"";position:absolute;background:hsla(0,0%,100%,.6);left:0}.login-wrapper[_ngcontent-%COMP%]   .example-form[_ngcontent-%COMP%]{min-width:100%;max-width:300px;width:100%}.login-wrapper[_ngcontent-%COMP%]   .btn-block[_ngcontent-%COMP%], .login-wrapper[_ngcontent-%COMP%]   .example-full-width[_ngcontent-%COMP%]{width:100%}.login-wrapper[_ngcontent-%COMP%]   mat-card-header[_ngcontent-%COMP%]{text-align:center;width:100%;display:block;font-weight:700}.login-wrapper[_ngcontent-%COMP%]   mat-card-header[_ngcontent-%COMP%]   mat-card-title[_ngcontent-%COMP%]{font-size:30px;margin:0}.login-wrapper[_ngcontent-%COMP%]   .mat-card[_ngcontent-%COMP%]{padding:40px 70px 50px}.login-wrapper[_ngcontent-%COMP%]   .mat-stroked-button[_ngcontent-%COMP%]{border:1px solid;line-height:54px;background:#e70d5d}.login-wrapper[_ngcontent-%COMP%]   .mat-form-field-appearance-legacy[_ngcontent-%COMP%]   .mat-form-field-infix[_ngcontent-%COMP%]{padding:.8375em 0}.vid[_ngcontent-%COMP%]{width:100%;height:100%}.mat-chip[_ngcontent-%COMP%]{justify-content:space-between}.pointer[_ngcontent-%COMP%]{cursor:pointer}.center[_ngcontent-%COMP%]{position:absolute;top:50%;left:50%;transform:translateX(-50%) translateY(-50%)}.overlay[_ngcontent-%COMP%]{height:100vh;width:100%;background-color:rgba(0,0,0,.286);z-index:10;top:0;left:0;position:fixed;background:#000;opacity:.75!important}body[_ngcontent-%COMP%]{margin:0}.close-right[_ngcontent-%COMP%]{cursor:pointer;position:absolute;right:0;margin-right:10px}.toast-top-center[_ngcontent-%COMP%]{left:50%}']}),N)}],U=i("5dmV"),H=i("Q92/"),q=i("NyRW"),z=i("X5Wf"),G=i("YUcS"),X=((T=function e(){n(this,e)}).\u0275mod=h.Kb({type:T}),T.\u0275inj=h.Jb({factory:function(e){return new(e||T)},providers:[C.b],imports:[[l.e.forChild(j),s.o,s.h,c.c,U.a,H.a,q.a,z.a,G.a]]}),T)}}])}();