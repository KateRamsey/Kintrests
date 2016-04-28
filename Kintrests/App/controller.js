(function () {
    'use strict';

    angular
        .module('Kintrestapp')
        .controller('Kincontroller', controller);

    controller.$inject = ['$scope', 'factory'];

    function controller($scope, factory) {


        activate();
    
        $scope.loadDetail = function(detailId) {
            factory.getDetail(detailId).then(function (res) {
                $scope.detailBody = res.data.Body;
                $scope.detailLinkURL = res.data.LinkURL;
                $scope.detailImgURL = res.data.ImgURL;
                $scope.detailOwnerHandle = res.data.OwnerHandle;

            });
        }

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
