'use strict';

bankingApp.controller('ClientsController', function ($scope, $http, $location, $window, $mdDialog, clientsRepo) {
    $scope.clients = null;
    $scope.dialogUrl = '/Scripts/views/dialog.html';

    //$scope.loadClients = function() {
    //    $http.get('api/clients').then(function(result) {
    //        $scope.clients = result.data;
    //    });
    //}; //clientsRepo.all();
    $scope.loadClients = function() {
        clientsRepo.all().then(function(result) {
            $scope.clients = result.data;
        });
    };

    $scope.editclientDialog = function(ev, client) {
        var confirm = $mdDialog.prompt({
            controller: 'DialogController',
            templateUrl: $scope.dialogUrl,
            parent: angular.element(document.body),
            targetEvent: ev,
            resolve: {
                addNew: function() { return false; },
                clientToEdit: function() { return client; }
            },
            clickOutsideToClose: true
        });
        $mdDialog.show(confirm).then(function(data) {
            clientsRepo.update(data);
            client = data;
        });
    };

    $scope.addclientDialog = function (ev) {
        var confirm = $mdDialog.prompt({
            controller: 'DialogController',
            templateUrl: $scope.dialogUrl,
            parent: angular.element(document.body),
            targetEvent: ev,
            resolve: {
                addNew: function () { return true; },
                clientToEdit: function () { return null; }
            },
            clickOutsideToClose: true
        });
        $mdDialog.show(confirm).then(function (data) {
            clientsRepo.add(data);
            client = data;
        });
    };


});