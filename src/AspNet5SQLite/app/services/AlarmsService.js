(function () {
    'use strict';

	function AlarmsService($http, $log, $q) {
	    $log.info("alarmsService called");

	    var AddAlarm = function (alarm) {
	        var deferred = $q.defer();

	        console.log("addAlarm started");
	        console.log(alarm);

	        $http({
	            url: 'api/alarms/AddAlarm',
	            method: "POST",
	            data: alarm
	        }).success(function (data) {
	            deferred.resolve(data);
	        }).error(function (error) {
	            deferred.reject(error);
	        });
	        return deferred.promise;
	    };

	    var StartWatcher = function (alarm) {
	        var deferred = $q.defer();

	        console.log("StartWatcher begin");
	        console.log(alarm);

	        $http({
	            url: 'api/WatcherEvents/Start',
	            method: "POST",
	            data: ""
	        }).success(function (data) {
	            deferred.resolve(data);
	        }).error(function (error) {
	            deferred.reject(error);
	        });
	        return deferred.promise;
	    };

	    var DeleteWatcher = function (alarm) {
	        var deferred = $q.defer();

	        console.log("DeleteWatcher begin");
	        console.log(alarm);

	        $http({
	            url: 'api/WatcherEvents/Delete',
	            method: "POST",
	            data: ""
	        }).success(function (data) {
	            deferred.resolve(data);
	        }).error(function (error) {
	            deferred.reject(error);
	        });
	        return deferred.promise;
	    };

		return {
		    AddAlarm: AddAlarm,
		    StartWatcher: StartWatcher,
            DeleteWatcher: DeleteWatcher
		}
	}

	var module = angular.module('mainApp');

	// this code can be used with uglify
	module.factory("alarmsService",
		[
			"$http",
			"$log",
            "$q",
			AlarmsService
		]
	);

})();
