(function () {
    'use strict';

    angular
        .module('Kintrestapp')
        .controller('Kincontroller', controller);

    controller.$inject = ['$scope', 'factory'];

    function controller($scope, factory) {


        activate();
    


        function activate() {
            console.log("controller activated");
            factory.getData().then(function (res) {
                console.log(res.data);
                $scope.Kins = res.data;
            });


        }
    }
})();
