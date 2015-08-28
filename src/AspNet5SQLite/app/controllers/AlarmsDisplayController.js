(function () {
	'use strict';

	var module = angular.module("mainApp");

	var AlarmsDisplayController = (function () {
	    function AlarmsDisplayController($scope, log, alarmsService, $rootScope, Hub, $timeout) {
	        $scope.Vm = this;

	        this.$scope = $scope;
	        this.alarmsService = alarmsService;
	        this.log = log;
	        this.$rootScope = $rootScope;
	        this.Hub = Hub;
	        this.$timeout = $timeout;

	        this.log.info("AlarmsDisplayController called");
	        this.Name = "Displaying Watcher alarms";

	        var hub = new Hub('alarms', {

	            //client side methods
	            listeners: {
	                'sendtotalalarmscount': function (count) {
	                    $rootScope.AlarmsCount = count;
	                    $rootScope.$apply();
	                    console.log("Recieved SendTotalAlarmsCount:" + count);
	                },
	                'sendlasttencriticalalarms': function (lasttenalarms) {
	                    $rootScope.LastTenCriticalAlarms = lasttenalarms;
	                    $rootScope.$apply();
	                    console.log(lasttenalarms);
	                },
	            },

	            //handle connection error
	            errorHandler: function (error) {
	                console.error(error);
	            },

	            stateChanged: function (state) {
	                switch (state.newState) {
	                    case $.signalR.connectionState.connecting:
	                        console.log("signalR.connectionState.connecting" + state.newState)
	                        break;
	                    case $.signalR.connectionState.connected:
	                        console.log("signalR.connectionState.connected" + state.newState)
	                        break;
	                    case $.signalR.connectionState.reconnecting:
	                        console.log("signalR.connectionState.reconnecting" + state.newState)
	                        break;
	                    case $.signalR.connectionState.disconnected:
	                        console.log("signalR.connectionState.disconnected" + state.newState)
	                        break;
	                }
	            }
	        });
	    }

	    return AlarmsDisplayController;
	})();

    // this code can be used with uglify
	module.controller("alarmsDisplayController",
		[
			"$scope",
			"$log",
			"alarmsService",
            '$rootScope',
            'Hub',
            '$timeout',
			AlarmsDisplayController
		]
	);
})();