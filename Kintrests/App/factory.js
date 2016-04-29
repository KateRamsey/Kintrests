(function () {
    'use strict';

    angular
        .module('Kintrestapp')
        .factory('factory', factory);

    factory.$inject = ['$http'];

    function factory($http) {
        var service = {
            getData: getData,
            saveNewKin: saveNewKin,
            getDetail: getDetail
        };

        return service;

        function saveNewKin(newKin) {
            return $http.post('/home/NewKin', newKin);
        }

        function getDetail(detailId){
            return $http({
                url: '/home/kindetail',
                method: "GET",
                params: { kinId: detailId }
            });;
        }

        function getData() {
           return $http.get('/home/GetAllKins');
        }
    }
})();