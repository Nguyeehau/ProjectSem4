(function (app) {
    app.filter('statusFilter', function () {
        return function (input) {
            if (input == true) {
                return 'Kích hoạt';
            }
            return 'Khóa';
        }
    });
})(angular.module('shopbug.common'));