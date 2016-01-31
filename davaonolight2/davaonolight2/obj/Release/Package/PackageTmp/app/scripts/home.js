(function () {
    'use strict';

    angular
        .module('home', [])
        .controller('homeController', homeController)
        .service('homeService', homeService)

    homeController.$inject = ['$location', '$filter', 'homeService'];
    homeService.$inject = ['$q', '$http']

    function homeService($q, $http) {
        return {
            getData: function () {
                var deferred = $q.defer();
                $http.get('/app/davaolight.json').success(function(data) {                    
                    deferred.resolve(data);
                }).error(function (data, status) {
                    deferred.reject(data);
                });

                return deferred.promise;
            }
        }
    }

    function homeController($location, $filter, homeService) {
        var vm = this;
        vm.list = [];        


        var loadData = function () {
            homeService.getData().then(function (data) {                
                changeFormat(data);
            });
        }


        var changeFormat = function (data) {
            var list = [];
            angular.forEach(data.groups, function (g, gk) {
                angular.forEach(g.feeders, function (f, fk) {
                    angular.forEach(f.places, function (p, pk) {
                        vm.list.push({
                            Group: g.name,
                            Feeder: f.name,
                            Place: p,
                            Schedule: g.schedule.join(' | ')
                        });
                    });
                });
            });            
        }

        loadData();

    }
})();
