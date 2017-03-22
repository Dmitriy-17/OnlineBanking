'use strict';

bankingApp.controller('DialogController', function ($scope, $http, $mdDialog, addNew, clientsRepo, clientToEdit) {

    $scope.client = angular.copy(clientToEdit) ;

    $scope.clientStatuses = clientsRepo.clientStatuses();
    $scope.addNew = addNew;
    $scope.listText = {
        "edit": { "title": 'Edit', "button": 'Редактировать' },
        "add": { "title": 'Add', "button": 'Добавить' }
    }
    $scope.text = addNew ? $scope.listText.add : $scope.listText.edit;

   
    $scope.add = function (client) {
        $mdDialog.hide(client);
    };

    $scope.update = function (client) {
        $mdDialog.hide(client);
    };

    $scope.cancel = function () {
        $mdDialog.cancel();
    };
});