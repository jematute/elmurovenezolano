(function () {
    'use strict';

    angular.module('app', [
        // Angular modules
        'smart-table',
        'uiGmapgoogle-maps'
        // Custom modules

        // 3rd Party Modules
        
    ]);
})();
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
        { firstName: 'Laurent', lastName: 'Renard', birthDate: new Date('1987-05-21'), balance: 102, email: 'whatever@gmail.com' },
        { firstName: 'Blandine', lastName: 'Faivre', birthDate: new Date('1987-04-25'), balance: -2323.22, email: 'oufblandou@gmail.com' },
        { firstName: 'Francoise', lastName: 'Frere', birthDate: new Date('1955-08-27'), balance: 42343, email: 'raymondef@gmail.com' }
        ];
    }
})();
