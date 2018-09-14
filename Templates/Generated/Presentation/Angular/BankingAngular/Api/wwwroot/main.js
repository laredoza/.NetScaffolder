(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error('Cannot find module "' + req + '".');
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _hero_form_hero_form_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./hero-form/hero-form.component */ "./src/app/hero-form/hero-form.component.ts");
/* harmony import */ var _bank_account_bank_account_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./bank-account/bank-account.component */ "./src/app/bank-account/bank-account.component.ts");
/* harmony import */ var _books_books_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./books/books.component */ "./src/app/books/books.component.ts");
/* harmony import */ var _countries_countries_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./countries/countries.component */ "./src/app/countries/countries.component.ts");
/* harmony import */ var _customers_customers_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./customers/customers.component */ "./src/app/customers/customers.component.ts");
/* harmony import */ var _software_software_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./software/software.component */ "./src/app/software/software.component.ts");
/* harmony import */ var _login_login_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./login/login.component */ "./src/app/login/login.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};









var routes = [
    {
        path: "",
        component: _hero_form_hero_form_component__WEBPACK_IMPORTED_MODULE_2__["HeroFormComponent"]
    },
    {
        path: "bankAccount",
        component: _bank_account_bank_account_component__WEBPACK_IMPORTED_MODULE_3__["BankAccountComponent"]
    },
    {
        path: "books",
        component: _books_books_component__WEBPACK_IMPORTED_MODULE_4__["BooksComponent"]
    },
    {
        path: "countries",
        component: _countries_countries_component__WEBPACK_IMPORTED_MODULE_5__["CountriesComponent"]
    },
    {
        path: "customers",
        component: _customers_customers_component__WEBPACK_IMPORTED_MODULE_6__["CustomersComponent"]
    },
    {
        path: "software",
        component: _software_software_component__WEBPACK_IMPORTED_MODULE_7__["SoftwareComponent"]
    },
    {
        path: "login",
        component: _login_login_component__WEBPACK_IMPORTED_MODULE_8__["LoginComponent"]
    },
    //{
    //  path: 'courses/:id',
    //  component: CourseComponent,
    //  resolve: {
    //    course: CourseResolver
    //  }
    //},
    {
        path: "**",
        redirectTo: '/'
    }
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forRoot(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());



/***/ }),

/***/ "./src/app/app.component.css":
/*!***********************************!*\
  !*** ./src/app/app.component.css ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".example-container {\r\n  display: flex;\r\n  flex-direction: column;\r\n  position: absolute;\r\n  top: 0;\r\n  bottom: 0;\r\n  left: 0;\r\n  right: 0;\r\n}\r\n\r\n.example-is-mobile .example-toolbar {\r\n  position: fixed;\r\n  /* Make sure the toolbar will stay on top of the content as it scrolls past. */\r\n  z-index: 2;\r\n}\r\n\r\nh1.example-app-name {\r\n  margin-left: 8px;\r\n}\r\n\r\n.example-sidenav-container {\r\n  /* When the sidenav is not fixed, stretch the sidenav container to fill the available space. This\r\n     causes `<mat-sidenav-content>` to act as our scrolling element for desktop layouts. */\r\n  flex: 1;\r\n}\r\n\r\n.example-is-mobile .example-sidenav-container {\r\n  /* When the sidenav is fixed, don't constrain the height of the sidenav container. This allows the\r\n     `<body>` to be our scrolling element for mobile layouts. */\r\n  flex: 1 0 auto;\r\n}\r\n"

/***/ }),

/***/ "./src/app/app.component.html":
/*!************************************!*\
  !*** ./src/app/app.component.html ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!--<h1>Application says what?</h1>\r\n<ul>\r\n  <li *ngFor=\"let value of apiValues\">{{value}}</li>\r\n</ul>\r\n\r\n<app-hero-form></app-hero-form>-->\r\n\r\n<!--<div>\r\n  <mat-toolbar color=\"primary\">\r\n    <span><mat-icon>mood</mat-icon></span>\r\n\r\n    <span>Yay, Material in Angular 2!</span>\r\n\r\n    <button mat-icon-button [mat-menu-trigger-for]=\"menu\">\r\n      <mat-icon>more_vert</mat-icon>\r\n    </button>\r\n  </mat-toolbar>\r\n  <mat-menu x-position=\"before\" #menu=\"matMenu\">\r\n    <button mat-menu-item>Option 1</button>\r\n    <button mat-menu-item>Option 2</button>\r\n  </mat-menu>\r\n\r\n  <mat-card>\r\n    <button mat-button>All</button>\r\n    <button mat-raised-button>Of</button>\r\n    <button mat-raised-button color=\"primary\">The</button>\r\n    <button mat-raised-button color=\"accent\">Buttons</button>\r\n  </mat-card>\r\n\r\n  <span class=\"done\">\r\n    <button mat-fab>\r\n      <mat-icon>check circle</mat-icon>\r\n    </button>\r\n  </span>\r\n</div>-->\r\n\r\n<!--<mat-sidenav-container fullscreen>\r\n  <mat-toolbar color=\"primary\">\r\n    <span>Application Title</span>\r\n\r\n    <span class=\"example-fill-remaining-space\"></span>\r\n\r\n    <span>Right Aligned Text</span>\r\n  </mat-toolbar>\r\n\r\n  <mat-sidenav #start>\r\n    <mat-nav-list>\r\n\r\n      <a mat-list-item routerLink=\"/\">\r\n        <mat-icon>library_books</mat-icon>\r\n        <span>Hero</span>\r\n      </a>\r\n\r\n      <a mat-list-item routerLink=\"bankAccount\">\r\n        <mat-icon>account_balance</mat-icon>\r\n        <span>Bank Account</span>\r\n      </a>\r\n      <a mat-list-item routerLink=\"books\">\r\n        <mat-icon>library_books</mat-icon>\r\n        <span>Books</span>\r\n      </a>\r\n      <a mat-list-item routerLink=\"countries\">\r\n        <mat-icon>question_answer</mat-icon>\r\n        <span>Countries</span>\r\n      </a>\r\n      <a mat-list-item routerLink=\"customers\">\r\n        <mat-icon>contacts</mat-icon>\r\n        <span>Customers</span>\r\n      </a>\r\n      <a mat-list-item routerLink=\"software\">\r\n        <mat-icon>web</mat-icon>\r\n        <span>Software</span>\r\n      </a>\r\n      <a mat-list-item>\r\n        <mat-icon>person_add</mat-icon>\r\n        <span>Register</span>\r\n      </a>\r\n      <a mat-list-item routerLink=\"login\">\r\n        <mat-icon>account_circle</mat-icon>\r\n        <span>Login</span>\r\n      </a>\r\n    </mat-nav-list>\r\n\r\n  </mat-sidenav>\r\n\r\n  <mat-toolbar color=\"primary\">\r\n    <button mat-icon-button (click)=\"start.open('mouse')\">\r\n      <mat-icon>menu</mat-icon>\r\n    </button>\r\n  </mat-toolbar>\r\n\r\n  <router-outlet></router-outlet>\r\n\r\n</mat-sidenav-container>-->\r\n\r\n<div class=\"example-container\" [class.example-is-mobile]=\"mobileQuery.matches\" fullscreen>\r\n  <mat-toolbar color=\"primary\" class=\"example-toolbar\">\r\n    <button mat-icon-button (click)=\"snav.toggle()\"><mat-icon>menu</mat-icon></button>\r\n    <h1 class=\"example-app-name\">Responsive App</h1>\r\n  </mat-toolbar>\r\n\r\n  <mat-sidenav-container class=\"example-sidenav-container\"\r\n                         [style.marginTop.px]=\"mobileQuery.matches ? 56 : 0\"  >\r\n\r\n    <mat-sidenav #snav [mode]=\"mobileQuery.matches ? 'over' : 'side'\"\r\n                 [fixedInViewport]=\"mobileQuery.matches\" fixedTopGap=\"56\">\r\n      <mat-nav-list>\r\n        <a mat-list-item *ngFor=\"let link of links\" [routerLink]=\"link.path\">\r\n          <mat-icon>{{link.icon}}</mat-icon>\r\n          <span>{{link.text}}</span>\r\n        </a>\r\n      </mat-nav-list>\r\n    </mat-sidenav>\r\n\r\n    <mat-sidenav-content>\r\n      <router-outlet></router-outlet>\r\n    </mat-sidenav-content>\r\n\r\n  </mat-sidenav-container>\r\n</div>\r\n"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");
/* harmony import */ var _angular_cdk_layout__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/cdk/layout */ "./node_modules/@angular/cdk/esm5/layout.es5.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



// https://stackblitz.com/angular/aydrrdqnrjk?file=app%2Fsidenav-responsive-example.ts
var AppComponent = /** @class */ (function () {
    function AppComponent(httpService, changeDetectorRef, media) {
        this.httpService = httpService;
        this.links = [];
        this.fillerNav = Array.from({ length: 50 }, function (_, i) { return "Nav Item " + (i + 1); });
        this.fillerContent = Array.from({ length: 50 }, function () {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut\n       labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco\n       laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in\n       voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat\n       cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        });
        this.apiValues = [];
        //shouldRun = [/(^|\.)plnkr\.co$/, /(^|\.)stackblitz\.io$/].some(h => h.test(window.location.host));
        this.shouldRun = true;
        this.mobileQuery = media.matchMedia('(max-width: 600px)');
        this._mobileQueryListener = function () { return changeDetectorRef.detectChanges(); };
        this.mobileQuery.addListener(this._mobileQueryListener);
        this.links.push({ text: 'Hero', path: '/', icon: "library_books" }, { text: 'Bank Account', path: 'bankAccount', icon: "account_balance" }, { text: 'Books', path: 'books', icon: "library_books" }, { text: 'Countries', path: 'countries', icon: "question_answer" }, { text: 'Customers', path: 'customers', icon: "contacts" }, { text: 'Software', path: 'software', icon: "web" }, { text: 'Register', path: '', icon: "person_add" }, { text: 'Login', path: 'login', icon: "account_circle" });
    }
    AppComponent.prototype.ngOnInit = function () {
        //let dataService: DataService = new DataService(this.httpService);
        //dataService.returnValues().then((data) => {
        //  this.apiValues = data;
        //}).catch((error) => {
        //  console.log("An unknown error occured while returning values: " + error);
        //});
    };
    AppComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./src/app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.css */ "./src/app/app.component.css")]
        }),
        __metadata("design:paramtypes", [_angular_http__WEBPACK_IMPORTED_MODULE_1__["Http"], _angular_core__WEBPACK_IMPORTED_MODULE_0__["ChangeDetectorRef"], _angular_cdk_layout__WEBPACK_IMPORTED_MODULE_2__["MediaMatcher"]])
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm5/animations.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm5/material.es5.js");
/* harmony import */ var _hero_form_hero_form_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./hero-form/hero-form.component */ "./src/app/hero-form/hero-form.component.ts");
/* harmony import */ var _customers_customers_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./customers/customers.component */ "./src/app/customers/customers.component.ts");
/* harmony import */ var _books_books_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./books/books.component */ "./src/app/books/books.component.ts");
/* harmony import */ var _software_software_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./software/software.component */ "./src/app/software/software.component.ts");
/* harmony import */ var _countries_countries_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./countries/countries.component */ "./src/app/countries/countries.component.ts");
/* harmony import */ var _bank_account_bank_account_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./bank-account/bank-account.component */ "./src/app/bank-account/bank-account.component.ts");
/* harmony import */ var _login_login_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./login/login.component */ "./src/app/login/login.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};






// Material Design


// Pages







var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_2__["AppComponent"],
                _hero_form_hero_form_component__WEBPACK_IMPORTED_MODULE_8__["HeroFormComponent"],
                _customers_customers_component__WEBPACK_IMPORTED_MODULE_9__["CustomersComponent"],
                _books_books_component__WEBPACK_IMPORTED_MODULE_10__["BooksComponent"],
                _software_software_component__WEBPACK_IMPORTED_MODULE_11__["SoftwareComponent"],
                _countries_countries_component__WEBPACK_IMPORTED_MODULE_12__["CountriesComponent"],
                _bank_account_bank_account_component__WEBPACK_IMPORTED_MODULE_13__["BankAccountComponent"],
                _login_login_component__WEBPACK_IMPORTED_MODULE_14__["LoginComponent"]
            ],
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__["BrowserModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                _angular_http__WEBPACK_IMPORTED_MODULE_4__["HttpModule"],
                _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_6__["BrowserAnimationsModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatButtonModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatCheckboxModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatMenuModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatToolbarModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatIconModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatCardModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatDatepickerModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatDialogModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatInputModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatListModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatPaginatorModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatProgressSpinnerModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatSelectModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatSidenavModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatSortModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatTableModule"],
                _app_routing_module__WEBPACK_IMPORTED_MODULE_5__["AppRoutingModule"]
            ],
            exports: [
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatButtonModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatMenuModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatToolbarModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatIconModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_7__["MatCardModule"]
            ],
            providers: [],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_2__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/bank-account/bank-account.component.css":
/*!*********************************************************!*\
  !*** ./src/app/bank-account/bank-account.component.css ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/bank-account/bank-account.component.html":
/*!**********************************************************!*\
  !*** ./src/app/bank-account/bank-account.component.html ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n\r\n<mat-card>\r\n  <h1>bank-account works!</h1>\r\n  <button mat-button>All</button>\r\n  <button mat-raised-button>Of</button>\r\n  <button mat-raised-button color=\"primary\">The</button>\r\n  <button mat-raised-button color=\"accent\">Buttons</button>\r\n</mat-card>\r\n"

/***/ }),

/***/ "./src/app/bank-account/bank-account.component.ts":
/*!********************************************************!*\
  !*** ./src/app/bank-account/bank-account.component.ts ***!
  \********************************************************/
/*! exports provided: BankAccountComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "BankAccountComponent", function() { return BankAccountComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var BankAccountComponent = /** @class */ (function () {
    function BankAccountComponent() {
    }
    BankAccountComponent.prototype.ngOnInit = function () {
    };
    BankAccountComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-bank-account',
            template: __webpack_require__(/*! ./bank-account.component.html */ "./src/app/bank-account/bank-account.component.html"),
            styles: [__webpack_require__(/*! ./bank-account.component.css */ "./src/app/bank-account/bank-account.component.css")]
        }),
        __metadata("design:paramtypes", [])
    ], BankAccountComponent);
    return BankAccountComponent;
}());



/***/ }),

/***/ "./src/app/books/books.component.css":
/*!*******************************************!*\
  !*** ./src/app/books/books.component.css ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/books/books.component.html":
/*!********************************************!*\
  !*** ./src/app/books/books.component.html ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-card>\r\n    books works!\r\n</mat-card>\r\n"

/***/ }),

/***/ "./src/app/books/books.component.ts":
/*!******************************************!*\
  !*** ./src/app/books/books.component.ts ***!
  \******************************************/
/*! exports provided: BooksComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "BooksComponent", function() { return BooksComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var BooksComponent = /** @class */ (function () {
    function BooksComponent() {
    }
    BooksComponent.prototype.ngOnInit = function () {
    };
    BooksComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-books',
            template: __webpack_require__(/*! ./books.component.html */ "./src/app/books/books.component.html"),
            styles: [__webpack_require__(/*! ./books.component.css */ "./src/app/books/books.component.css")]
        }),
        __metadata("design:paramtypes", [])
    ], BooksComponent);
    return BooksComponent;
}());



/***/ }),

/***/ "./src/app/countries/countries.component.css":
/*!***************************************************!*\
  !*** ./src/app/countries/countries.component.css ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/countries/countries.component.html":
/*!****************************************************!*\
  !*** ./src/app/countries/countries.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-card>\r\n  countries works!\r\n</mat-card>\r\n"

/***/ }),

/***/ "./src/app/countries/countries.component.ts":
/*!**************************************************!*\
  !*** ./src/app/countries/countries.component.ts ***!
  \**************************************************/
/*! exports provided: CountriesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CountriesComponent", function() { return CountriesComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var CountriesComponent = /** @class */ (function () {
    function CountriesComponent() {
    }
    CountriesComponent.prototype.ngOnInit = function () {
    };
    CountriesComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-countries',
            template: __webpack_require__(/*! ./countries.component.html */ "./src/app/countries/countries.component.html"),
            styles: [__webpack_require__(/*! ./countries.component.css */ "./src/app/countries/countries.component.css")]
        }),
        __metadata("design:paramtypes", [])
    ], CountriesComponent);
    return CountriesComponent;
}());



/***/ }),

/***/ "./src/app/customers/customers.component.css":
/*!***************************************************!*\
  !*** ./src/app/customers/customers.component.css ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/customers/customers.component.html":
/*!****************************************************!*\
  !*** ./src/app/customers/customers.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-card>\r\n  customers works!\r\n</mat-card>\r\n"

/***/ }),

/***/ "./src/app/customers/customers.component.ts":
/*!**************************************************!*\
  !*** ./src/app/customers/customers.component.ts ***!
  \**************************************************/
/*! exports provided: CustomersComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CustomersComponent", function() { return CustomersComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var CustomersComponent = /** @class */ (function () {
    function CustomersComponent() {
    }
    CustomersComponent.prototype.ngOnInit = function () {
    };
    CustomersComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-customers',
            template: __webpack_require__(/*! ./customers.component.html */ "./src/app/customers/customers.component.html"),
            styles: [__webpack_require__(/*! ./customers.component.css */ "./src/app/customers/customers.component.css")]
        }),
        __metadata("design:paramtypes", [])
    ], CustomersComponent);
    return CustomersComponent;
}());



/***/ }),

/***/ "./src/app/hero-form/hero-form.component.css":
/*!***************************************************!*\
  !*** ./src/app/hero-form/hero-form.component.css ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/hero-form/hero-form.component.html":
/*!****************************************************!*\
  !*** ./src/app/hero-form/hero-form.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-card>\r\n  {{diagnostic}}\r\n  <div [hidden]=\"submitted\">\r\n    <h1>Hero Form</h1>\r\n    <form (ngSubmit)=\"onSubmit()\" #heroForm=\"ngForm\">\r\n      <div class=\"form-group\">\r\n        <label for=\"name\">Name</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"name\"\r\n               required\r\n               [(ngModel)]=\"model.name\" name=\"name\"\r\n               #name=\"ngModel\">\r\n        <div [hidden]=\"name.valid || name.pristine\"\r\n             class=\"alert alert-danger\">\r\n          Name is required\r\n        </div>\r\n      </div>\r\n\r\n      <div class=\"form-group\">\r\n        <label for=\"alterEgo\">Alter Ego</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"alterEgo\"\r\n               [(ngModel)]=\"model.alterEgo\" name=\"alterEgo\">\r\n      </div>\r\n\r\n      <div class=\"form-group\">\r\n        <label for=\"power\">Hero Power</label>\r\n        <select class=\"form-control\" id=\"power\"\r\n                required\r\n                [(ngModel)]=\"model.power\" name=\"power\"\r\n                #power=\"ngModel\">\r\n          <option *ngFor=\"let pow of powers\" [value]=\"pow\">{{pow}}</option>\r\n        </select>\r\n        <div [hidden]=\"power.valid || power.pristine\" class=\"alert alert-danger\">\r\n          Power is required\r\n        </div>\r\n      </div>\r\n\r\n      <button type=\"submit\" class=\"btn btn-success\" [disabled]=\"!heroForm.form.valid\">Submit</button>\r\n      <button type=\"button\" class=\"btn btn-default\" (click)=\"newHero(); heroForm.reset()\">New Hero</button>\r\n    </form>\r\n  </div>\r\n\r\n  <div [hidden]=\"!submitted\">\r\n    <h2>You submitted the following:</h2>\r\n    <div class=\"row\">\r\n      <div class=\"col-xs-3\">Name</div>\r\n      <div class=\"col-xs-9  pull-left\">{{ model.name }}</div>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-xs-3\">Alter Ego</div>\r\n      <div class=\"col-xs-9 pull-left\">{{ model.alterEgo }}</div>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-xs-3\">Power</div>\r\n      <div class=\"col-xs-9 pull-left\">{{ model.power }}</div>\r\n    </div>\r\n    <br>\r\n    <button class=\"btn btn-primary\" (click)=\"submitted=false\">Edit</button>\r\n  </div>\r\n</mat-card>\r\n"

/***/ }),

/***/ "./src/app/hero-form/hero-form.component.ts":
/*!**************************************************!*\
  !*** ./src/app/hero-form/hero-form.component.ts ***!
  \**************************************************/
/*! exports provided: HeroFormComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HeroFormComponent", function() { return HeroFormComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _hero__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../hero */ "./src/app/hero.ts");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");
/* harmony import */ var _services_data_services__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../services/data.services */ "./src/services/data.services.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};




var HeroFormComponent = /** @class */ (function () {
    function HeroFormComponent(httpService) {
        var _this = this;
        this.httpService = httpService;
        this.powers = ['Really Smart', 'Super Flexible',
            'Super Hot', 'Weather Changer'];
        this.submitted = false;
        var dataService = new _services_data_services__WEBPACK_IMPORTED_MODULE_3__["DataService"](this.httpService);
        dataService.returnHero().then(function (data) {
            _this.model = data;
        }).catch(function (error) {
            console.log("An unknown error occured while returning values: " + error);
        });
    }
    HeroFormComponent.prototype.onSubmit = function () { this.submitted = true; };
    HeroFormComponent.prototype.newHero = function () {
        // https://angular.io/guide/forms
        this.model = new _hero__WEBPACK_IMPORTED_MODULE_1__["Hero"](42, '', '');
    };
    HeroFormComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-hero-form',
            template: __webpack_require__(/*! ./hero-form.component.html */ "./src/app/hero-form/hero-form.component.html"),
            styles: [__webpack_require__(/*! ./hero-form.component.css */ "./src/app/hero-form/hero-form.component.css")]
        }),
        __metadata("design:paramtypes", [_angular_http__WEBPACK_IMPORTED_MODULE_2__["Http"]])
    ], HeroFormComponent);
    return HeroFormComponent;
}());



/***/ }),

/***/ "./src/app/hero.ts":
/*!*************************!*\
  !*** ./src/app/hero.ts ***!
  \*************************/
/*! exports provided: Hero */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Hero", function() { return Hero; });
var Hero = /** @class */ (function () {
    function Hero(id, name, power, alterEgo) {
        this.id = id;
        this.name = name;
        this.power = power;
        this.alterEgo = alterEgo;
    }
    return Hero;
}());



/***/ }),

/***/ "./src/app/login/login.component.css":
/*!*******************************************!*\
  !*** ./src/app/login/login.component.css ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/login/login.component.html":
/*!********************************************!*\
  !*** ./src/app/login/login.component.html ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-card>\r\n  login works!\r\n</mat-card>\r\n"

/***/ }),

/***/ "./src/app/login/login.component.ts":
/*!******************************************!*\
  !*** ./src/app/login/login.component.ts ***!
  \******************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var LoginComponent = /** @class */ (function () {
    function LoginComponent() {
    }
    LoginComponent.prototype.ngOnInit = function () {
    };
    LoginComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-login',
            template: __webpack_require__(/*! ./login.component.html */ "./src/app/login/login.component.html"),
            styles: [__webpack_require__(/*! ./login.component.css */ "./src/app/login/login.component.css")]
        }),
        __metadata("design:paramtypes", [])
    ], LoginComponent);
    return LoginComponent;
}());



/***/ }),

/***/ "./src/app/software/software.component.css":
/*!*************************************************!*\
  !*** ./src/app/software/software.component.css ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/software/software.component.html":
/*!**************************************************!*\
  !*** ./src/app/software/software.component.html ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-card>\r\n  software works!\r\n</mat-card>\r\n"

/***/ }),

/***/ "./src/app/software/software.component.ts":
/*!************************************************!*\
  !*** ./src/app/software/software.component.ts ***!
  \************************************************/
/*! exports provided: SoftwareComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SoftwareComponent", function() { return SoftwareComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var SoftwareComponent = /** @class */ (function () {
    function SoftwareComponent() {
    }
    SoftwareComponent.prototype.ngOnInit = function () {
    };
    SoftwareComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-software',
            template: __webpack_require__(/*! ./software.component.html */ "./src/app/software/software.component.html"),
            styles: [__webpack_require__(/*! ./software.component.css */ "./src/app/software/software.component.css")]
        }),
        __metadata("design:paramtypes", [])
    ], SoftwareComponent);
    return SoftwareComponent;
}());



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ "./src/services/data.services.ts":
/*!***************************************!*\
  !*** ./src/services/data.services.ts ***!
  \***************************************/
/*! exports provided: DataService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DataService", function() { return DataService; });
/* harmony import */ var _app_hero__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../app/hero */ "./src/app/hero.ts");

var DataService = /** @class */ (function () {
    function DataService(httpService) {
        this.apiValues = [];
        this.httpService = httpService;
    }
    DataService.prototype.returnValues = function () {
        var _this = this;
        return new Promise(function (resolve, reject) {
            _this.httpService.get('/api/values').toPromise().then(function (values) {
                resolve(values.json());
            }).catch(function (error) {
                reject(error);
            });
        });
    };
    DataService.prototype.returnHero = function () {
        return new Promise(function (resolve, reject) {
            //this.httpService.get('/api/values').toPromise().then(values => {
            //  resolve(values.json() as Hero);
            //}).catch((error) => {
            //  reject(error);
            //});
            resolve(new _app_hero__WEBPACK_IMPORTED_MODULE_0__["Hero"](18, 'Dr IQ', 'Really Smart', 'Chuck Overstreet'));
            //);
        });
    };
    return DataService;
}());



/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Dev\Github\.NetScaffolder\Generated\Presentation\Angular\BankingAngular\Api\Angular\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map