(function () {
    'use strict';

    angular
        .module('Kintrestapp')
        .controller('Kincontroller', controller);

    controller.$inject = ['$scope']; 

    function controller($scope) {
        activate();
        $scope.kins = [];


        function activate() {
            //factory.getData
        }
    }
})();
