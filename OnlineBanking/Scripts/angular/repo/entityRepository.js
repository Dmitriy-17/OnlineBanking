"use strict";

bankingApp.factory('clientsRepo', function ($http, BaseRepository) {
    var repo = new BaseRepository('/api/clients');

    repo.clientStatuses = function () {
        return [
            { Id: 1, Name: 'VIP' },
            { Id: 2, Name: 'Classic' }
        ];
    };

    return repo;
});