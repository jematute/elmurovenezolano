(function () {
    'use strict';

    angular
        .module('app')
        .controller('listado', listado);

    listado.$inject = ['$location']; 

    function listado($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'listado';

        vm.map = { center: { latitude: 6.327618611972444, longitude: -66.44843750000001 }, zoom: 6 };

        vm.rowCollection = [
            { estado: "Apure"},
            { estado: "Aragua" },
            { estado: "Carbobo" },
            { estado: "Cojedes" },
            { estado: "Guarico" },
        ];
    }
})();
