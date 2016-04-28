(function () {
    'use strict';

    angular
        .module('Kintrestapp')
        .controller('Kincontroller', controller);

    controller.$inject = ['$scope', 'factory'];

    function controller($scope, factory) {


        activate();
    

        $scope.saveKin = function () {
            console.log('called controller saveKin()');
            var newkin = { ImgURL: $scope.newKin.ImgURL, Body: $scope.newKin.Body, LinkURL: $scope.newKin.LinkURL };
            factory.saveNewKin(newkin).then(function (res) {

                $scope.newKin.ImgURL = "";
                $scope.newKin.Body = "";
                $scope.newKin.LinkURL = "";

                $scope.Kins.push(res.data);
            });
        }


        function activate() {
            console.log("controller activated");
            factory.getData().then(function (res) {
                console.log(res.data);
                $scope.Kins = res.data;
            });


        }
    }
})();
