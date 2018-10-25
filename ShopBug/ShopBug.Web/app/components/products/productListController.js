(function (app) {
    app.controller('productListController', productListController);
    productListController.$inject = ['$scope', 'apiService'];

    function productListController($scope, apiService) {
        $scope.products = [];

        $scope.getProducts = getProducts;

        function getProducts() {
            apiService.get('/api/product/getall', null, function (result) {
                $scope.products = result.data;
            }, function () {
                console.log('Load product failed.');
            });
        }
        $scope.getProducts();
    }
})(angular.module('shopbug.products'));