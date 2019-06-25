(window["webpackJsonp"] = window["webpackJsonp"] || []).push([[4],{

/***/ "./Typings/app/sales/order/order-detail.component.ts":
/*!***********************************************************!*\
  !*** ./Typings/app/sales/order/order-detail.component.ts ***!
  \***********************************************************/
/*! exports provided: OrderDetailComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrderDetailComponent", function() { return OrderDetailComponent; });
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
 * 订单详情页
 */
var OrderDetailComponent = /** @class */ (function (_super) {
    __extends(OrderDetailComponent, _super);
    /**
     * 初始化订单详情页
     * @param injector 注入器
     */
    function OrderDetailComponent(injector) {
        return _super.call(this, injector) || this;
    }
    /**
     * 获取基地址
     */
    OrderDetailComponent.prototype.getBaseUrl = function () {
        return "order";
    };
    OrderDetailComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'order-detail',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/order-detail.component.html' : '/view/sales/order/detail'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], OrderDetailComponent);
    return OrderDetailComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["EditComponentBase"]));



/***/ }),

/***/ "./Typings/app/sales/order/order-edit.component.ts":
/*!*********************************************************!*\
  !*** ./Typings/app/sales/order/order-edit.component.ts ***!
  \*********************************************************/
/*! exports provided: OrderEditComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrderEditComponent", function() { return OrderEditComponent; });
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
 * 订单编辑页
 */
var OrderEditComponent = /** @class */ (function (_super) {
    __extends(OrderEditComponent, _super);
    /**
     * 初始化订单编辑页
     * @param injector 注入器
     */
    function OrderEditComponent(injector) {
        return _super.call(this, injector) || this;
    }
    /**
     * 获取基地址
     */
    OrderEditComponent.prototype.getBaseUrl = function () {
        return "order";
    };
    OrderEditComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'order-edit',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/order-edit.component.html' : '/view/sales/order/edit'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], OrderEditComponent);
    return OrderEditComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["EditComponentBase"]));



/***/ }),

/***/ "./Typings/app/sales/order/order-list.component.ts":
/*!*********************************************************!*\
  !*** ./Typings/app/sales/order/order-list.component.ts ***!
  \*********************************************************/
/*! exports provided: OrderListComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrderListComponent", function() { return OrderListComponent; });
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
 * 订单列表页
 */
var OrderListComponent = /** @class */ (function (_super) {
    __extends(OrderListComponent, _super);
    /**
     * 初始化订单列表页
     * @param injector 注入器
     */
    function OrderListComponent(injector) {
        return _super.call(this, injector) || this;
    }
    OrderListComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'order-list',
            templateUrl: !_env__WEBPACK_IMPORTED_MODULE_1__["env"].dev() ? './html/order-index.component.html' : '/view/sales/order'
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injector"]])
    ], OrderListComponent);
    return OrderListComponent;
}(_util__WEBPACK_IMPORTED_MODULE_2__["TableQueryComponentBase"]));



/***/ }),

/***/ "./Typings/app/sales/sale-routing.module.ts":
/*!**************************************************!*\
  !*** ./Typings/app/sales/sale-routing.module.ts ***!
  \**************************************************/
/*! exports provided: SaleRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SaleRoutingModule", function() { return SaleRoutingModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _order_order_list_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./order/order-list.component */ "./Typings/app/sales/order/order-list.component.ts");
/* harmony import */ var _order_order_edit_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./order/order-edit.component */ "./Typings/app/sales/order/order-edit.component.ts");
/* harmony import */ var _order_order_detail_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./order/order-detail.component */ "./Typings/app/sales/order/order-detail.component.ts");
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
            { path: 'order', children: [
                    { path: '', component: _order_order_list_component__WEBPACK_IMPORTED_MODULE_2__["OrderListComponent"] },
                    { path: 'create', component: _order_order_edit_component__WEBPACK_IMPORTED_MODULE_3__["OrderEditComponent"] },
                    { path: 'edit/:id', component: _order_order_edit_component__WEBPACK_IMPORTED_MODULE_3__["OrderEditComponent"] },
                    { path: 'detail/:id', component: _order_order_detail_component__WEBPACK_IMPORTED_MODULE_4__["OrderDetailComponent"] }
                ] }
        ]
    }
];
/**
 * sales路由模块
 */
var SaleRoutingModule = /** @class */ (function () {
    function SaleRoutingModule() {
    }
    SaleRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(routes)]
        })
    ], SaleRoutingModule);
    return SaleRoutingModule;
}());



/***/ }),

/***/ "./Typings/app/sales/sale.module.ts":
/*!******************************************!*\
  !*** ./Typings/app/sales/sale.module.ts ***!
  \******************************************/
/*! exports provided: SaleModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SaleModule", function() { return SaleModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _framework_module__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../framework.module */ "./Typings/app/framework.module.ts");
/* harmony import */ var _sale_routing_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./sale-routing.module */ "./Typings/app/sales/sale-routing.module.ts");
/* harmony import */ var _order_order_list_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./order/order-list.component */ "./Typings/app/sales/order/order-list.component.ts");
/* harmony import */ var _order_order_edit_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./order/order-edit.component */ "./Typings/app/sales/order/order-edit.component.ts");
/* harmony import */ var _order_order_detail_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./order/order-detail.component */ "./Typings/app/sales/order/order-detail.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};






/**
 * sales模块
 */
var SaleModule = /** @class */ (function () {
    function SaleModule() {
    }
    SaleModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            declarations: [
                _order_order_list_component__WEBPACK_IMPORTED_MODULE_3__["OrderListComponent"], _order_order_edit_component__WEBPACK_IMPORTED_MODULE_4__["OrderEditComponent"], _order_order_detail_component__WEBPACK_IMPORTED_MODULE_5__["OrderDetailComponent"],
            ],
            imports: [
                _framework_module__WEBPACK_IMPORTED_MODULE_1__["FrameworkModule"], _sale_routing_module__WEBPACK_IMPORTED_MODULE_2__["SaleRoutingModule"]
            ]
        })
    ], SaleModule);
    return SaleModule;
}());



/***/ })

}]);
//# sourceMappingURL=4.chunk.js.map