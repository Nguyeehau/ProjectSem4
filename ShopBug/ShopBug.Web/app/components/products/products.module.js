/// <reference path="../assets/libs/angular/angular.js" />


(function () {
    angular.module('shopbug.products', ['shopbug.common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        });
    }
})();