/// <reference path="../assets/libs/angular/angular.js" />


(function () {
    angular.module('shopbug',
        ['shopbug.products',
            'shopbug.product_categories',
            'shopbug.common'])
        .config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin')
    }
})();