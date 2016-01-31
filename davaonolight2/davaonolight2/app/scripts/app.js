(function () {
    'use strict';

    angular.module('app', [
         'ui.router',
         'ui.bootstrap',
         'home'
    ])
     .config([
            '$stateProvider',
            '$urlRouterProvider',
            '$httpProvider',
            function config(
                $stateProvider, $urlRouterProvider, $httpProvider) {

                $stateProvider
                    .state('home', {
                        url: '/home',
                        templateUrl: "app/home.html"
                    })

                $urlRouterProvider.otherwise('/home');
            }])
})();
