(window["webpackJsonp"] = window["webpackJsonp"] || []).push([[1],{

/***/ "./Typings/app/agents/agent-routing.module.ts":
/*!****************************************************!*\
  !*** ./Typings/app/agents/agent-routing.module.ts ***!
  \****************************************************/
/*! exports provided: AgentRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AgentRoutingModule", function() { return AgentRoutingModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _agent_agent_list_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./agent/agent-list.component */ "./Typings/app/agents/agent/agent-list.component.ts");
/* harmony import */ var _agent_agent_edit_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./agent/agent-edit.component */ "./Typings/app/agents/agent/agent-edit.component.ts");
/* harmony import */ var _agent_agent_detail_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./agent/agent-detail.component */ "./Typings/app/agents/agent/agent-detail.component.ts");
/* harmony import */ var _outCash_outCash_list_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./outCash/outCash-list.component */ "./Typings/app/agents/outCash/outCash-list.component.ts");
/* harmony import */ var _outCash_outCash_edit_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./outCash/outCash-edit.component */ "./Typings/app/agents/outCash/outCash-edit.component.ts");
/* harmony import */ var _outCash_outCash_detail_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./outCash/outCash-detail.component */ "./Typings/app/agents/outCash/outCash-detail.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};








//路由配置
var routes = [
    {
        path: '',
        children: [
            { path: 'agent', children: [
                    { path: '', component: _agent_agent_list_component__WEBPACK_IMPORTED_MODULE_2__["AgentListComponent"] },
                    { path: 'create', component: _agent_agent_edit_component__WEBPACK_IMPORTED_MODULE_3__["AgentEditComponent"] },
                    { path: 'edit/:id', component: _agent_agent_edit_component__WEBPACK_IMPORTED_MODULE_3__["AgentEditComponent"] },
                    { path: 'detail/:id', component: _agent_agent_detail_component__WEBPACK_IMPORTED_MODULE_4__["AgentDetailComponent"] }
                ] },
            { path: 'outCash', children: [
                    { path: '', component: _outCash_outCash_list_component__WEBPACK_IMPORTED_MODULE_5__["OutCashListComponent"] },
                    { path: 'create', component: _outCash_outCash_edit_component__WEBPACK_IMPORTED_MODULE_6__["OutCashEditComponent"] },
                    { path: 'edit/:id', component: _outCash_outCash_edit_component__WEBPACK_IMPORTED_MODULE_6__["OutCashEditComponent"] },
                    { path: 'detail/:id', component: _outCash_outCash_detail_component__WEBPACK_IMPORTED_MODULE_7__["OutCashDetailComponent"] }
                ] },
        ]
    }
];
/**
 * agents路由模块
 */
var AgentRoutingModule = /** @class */ (function () {
    function AgentRoutingModule() {
    }
    AgentRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(routes)]
        })
    ], AgentRoutingModule);
    return AgentRoutingModule;
}());



/***/ }),

/***/ "./Typings/app/agents/agent.module.ts":
/*!********************************************!*\
  !*** ./Typings/app/agents/agent.module.ts ***!
  \********************************************/
/*! exports provided: AgentModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AgentModule", function() { return AgentModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _framework_module__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../framework.module */ "./Typings/app/framework.module.ts");
/* harmony import */ var _agent_routing_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./agent-routing.module */ "./Typings/app/agents/agent-routing.module.ts");
/* harmony import */ var _agent_agent_list_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./agent/agent-list.component */ "./Typings/app/agents/agent/agent-list.component.ts");
/* harmony import */ var _agent_agent_edit_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./agent/agent-edit.component */ "./Typings/app/agents/agent/agent-edit.component.ts");
/* harmony import */ var _agent_agent_detail_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./agent/agent-detail.component */ "./Typings/app/agents/agent/agent-detail.component.ts");
/* harmony import */ var _outCash_outCash_list_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./outCash/outCash-list.component */ "./Typings/app/agents/outCash/outCash-list.component.ts");
/* harmony import */ var _outCash_outCash_edit_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./outCash/outCash-edit.component */ "./Typings/app/agents/outCash/outCash-edit.component.ts");
/* harmony import */ var _outCash_outCash_detail_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./outCash/outCash-detail.component */ "./Typings/app/agents/outCash/outCash-detail.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};









/**
 * agents模块
 */
var AgentModule = /** @class */ (function () {
    function AgentModule() {
    }
    AgentModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            declarations: [
                _agent_agent_list_component__WEBPACK_IMPORTED_MODULE_3__["AgentListComponent"], _agent_agent_edit_component__WEBPACK_IMPORTED_MODULE_4__["AgentEditComponent"], _agent_agent_detail_component__WEBPACK_IMPORTED_MODULE_5__["AgentDetailComponent"],
                _outCash_outCash_list_component__WEBPACK_IMPORTED_MODULE_6__["OutCashListComponent"], _outCash_outCash_edit_component__WEBPACK_IMPORTED_MODULE_7__["OutCashEditComponent"], _outCash_outCash_detail_component__WEBPACK_IMPORTED_MODULE_8__["OutCashDetailComponent"],
            ],
            imports: [
                _framework_module__WEBPACK_IMPORTED_MODULE_1__["FrameworkModule"], _agent_routing_module__WEBPACK_IMPORTED_MODULE_2__["AgentRoutingModule"]
            ]
        })
    ], AgentModule);
    return AgentModule;
}());



/***/ }),

/***/ "./Typings/app/agents/agent/agent-detail.component.ts":
/*!************************************************************!*\
  !*** ./Typings/app/agents/agent/agent-detail.component.ts ***!
  \************************************************************/
/*! exports provided: AgentDetailComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AgentDetailComponent", function() { return AgentDetailComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _env__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../env */ "./Typings/app/env.ts");
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../util */ "./Typings/util/index.ts");
var __extends = (undefined && undefined.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



/**
 * 代理详情页
 */
var AgentDetailComponent = /** @class */ (function (_super) {
    __extends(AgentDetailComponent, _super);
    /**
     * 初始化代理详情页
     * @param injector 注入器
     */
    function AgentDetailComponent(injector) {
        return _super.call(this, injector) || this;
    }
    /**
     * 获取基地址
     */
    AgentDetailComponent.prototype.getBaseUrl = function () {
        return "agent";
    };
    AgentDetailComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'agent-detail',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/agent-detail.component.html' : '/view/agents/agent/detail'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], AgentDetailComponent);
    return AgentDetailComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["EditComponentBase"]));



/***/ }),

/***/ "./Typings/app/agents/agent/agent-edit.component.ts":
/*!**********************************************************!*\
  !*** ./Typings/app/agents/agent/agent-edit.component.ts ***!
  \**********************************************************/
/*! exports provided: AgentEditComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AgentEditComponent", function() { return AgentEditComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _env__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../env */ "./Typings/app/env.ts");
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../util */ "./Typings/util/index.ts");
var __extends = (undefined && undefined.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



/**
 * 代理编辑页
 */
var AgentEditComponent = /** @class */ (function (_super) {
    __extends(AgentEditComponent, _super);
    /**
     * 初始化代理编辑页
     * @param injector 注入器
     */
    function AgentEditComponent(injector) {
        return _super.call(this, injector) || this;
    }
    /**
     * 获取基地址
     */
    AgentEditComponent.prototype.getBaseUrl = function () {
        return "agent";
    };
    AgentEditComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'agent-edit',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/agent-edit.component.html' : '/view/agents/agent/edit'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], AgentEditComponent);
    return AgentEditComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["EditComponentBase"]));



/***/ }),

/***/ "./Typings/app/agents/agent/agent-list.component.ts":
/*!**********************************************************!*\
  !*** ./Typings/app/agents/agent/agent-list.component.ts ***!
  \**********************************************************/
/*! exports provided: AgentListComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AgentListComponent", function() { return AgentListComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _env__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../env */ "./Typings/app/env.ts");
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../util */ "./Typings/util/index.ts");
var __extends = (undefined && undefined.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



/**
 * 代理列表页
 */
var AgentListComponent = /** @class */ (function (_super) {
    __extends(AgentListComponent, _super);
    /**
     * 初始化代理列表页
     * @param injector 注入器
     */
    function AgentListComponent(injector) {
        return _super.call(this, injector) || this;
    }
    AgentListComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'agent-list',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/agent-index.component.html' : '/view/agents/agent'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], AgentListComponent);
    return AgentListComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["TableQueryComponentBase"]));



/***/ }),

/***/ "./Typings/app/agents/outCash/outCash-detail.component.ts":
/*!****************************************************************!*\
  !*** ./Typings/app/agents/outCash/outCash-detail.component.ts ***!
  \****************************************************************/
/*! exports provided: OutCashDetailComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OutCashDetailComponent", function() { return OutCashDetailComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _env__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../env */ "./Typings/app/env.ts");
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../util */ "./Typings/util/index.ts");
var __extends = (undefined && undefined.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



/**
 * 提现详情页
 */
var OutCashDetailComponent = /** @class */ (function (_super) {
    __extends(OutCashDetailComponent, _super);
    /**
     * 初始化提现详情页
     * @param injector 注入器
     */
    function OutCashDetailComponent(injector) {
        return _super.call(this, injector) || this;
    }
    /**
     * 获取基地址
     */
    OutCashDetailComponent.prototype.getBaseUrl = function () {
        return "outCash";
    };
    OutCashDetailComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'outCash-detail',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/outCash-detail.component.html' : '/view/agents/outCash/detail'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], OutCashDetailComponent);
    return OutCashDetailComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["EditComponentBase"]));



/***/ }),

/***/ "./Typings/app/agents/outCash/outCash-edit.component.ts":
/*!**************************************************************!*\
  !*** ./Typings/app/agents/outCash/outCash-edit.component.ts ***!
  \**************************************************************/
/*! exports provided: OutCashEditComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OutCashEditComponent", function() { return OutCashEditComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _env__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../env */ "./Typings/app/env.ts");
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../util */ "./Typings/util/index.ts");
var __extends = (undefined && undefined.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



/**
 * 提现编辑页
 */
var OutCashEditComponent = /** @class */ (function (_super) {
    __extends(OutCashEditComponent, _super);
    /**
     * 初始化提现编辑页
     * @param injector 注入器
     */
    function OutCashEditComponent(injector) {
        return _super.call(this, injector) || this;
    }
    /**
     * 获取基地址
     */
    OutCashEditComponent.prototype.getBaseUrl = function () {
        return "outCash";
    };
    OutCashEditComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'outCash-edit',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/outCash-edit.component.html' : '/view/agents/outCash/edit'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], OutCashEditComponent);
    return OutCashEditComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["EditComponentBase"]));



/***/ }),

/***/ "./Typings/app/agents/outCash/outCash-list.component.ts":
/*!**************************************************************!*\
  !*** ./Typings/app/agents/outCash/outCash-list.component.ts ***!
  \**************************************************************/
/*! exports provided: OutCashListComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OutCashListComponent", function() { return OutCashListComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _env__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../env */ "./Typings/app/env.ts");
/* harmony import */ var _util__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../util */ "./Typings/util/index.ts");
var __extends = (undefined && undefined.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



/**
 * 提现列表页
 */
var OutCashListComponent = /** @class */ (function (_super) {
    __extends(OutCashListComponent, _super);
    /**
     * 初始化提现列表页
     * @param injector 注入器
     */
    function OutCashListComponent(injector) {
        return _super.call(this, injector) || this;
    }
    OutCashListComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'outCash-list',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/outCash-index.component.html' : '/view/agents/outCash'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], OutCashListComponent);
    return OutCashListComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["TableQueryComponentBase"]));



/***/ })

}]);
//# sourceMappingURL=1.chunk.js.map