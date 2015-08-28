(function () {
    var mainApp = angular.module("mainApp", ["ui.router", "SignalR"]);

	mainApp.config(["$stateProvider", "$urlRouterProvider",
		function ($stateProvider, $urlRouterProvider) {
		    $urlRouterProvider.otherwise("/home/createAlarm");

            	$stateProvider
                    .state("home", { abstract: true, url: "/home", templateUrl: "/templates/home.html" })
                        .state("createAlarm", {
                            parent: "home", url: "/createAlarm", templateUrl: "/templates/createAlarm.html", controller: "alarmsController",
                        	
                        })
                    .state("alarms", {
                        url: "/alarms", templateUrl: "/templates/alarms.html", controller: "alarmsDisplayController",

                    })
        }
	]
    );

	
})();
