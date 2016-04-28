(function () {
    'use strict';

    angular
        .module('Kintrestapp')
        .factory('factory', factory);

    factory.$inject = ['$http'];

    function factory($http) {
        var service = {
            getData: getData,
            saveNewKin: saveNewKin
        };

        return service;

        function saveNewKin(newKin) {
            return $http.post('/home/NewKin', newKin);
        }


        function getData() {
           return $http.get('/home/GetAllKins');
        }
    }
})();