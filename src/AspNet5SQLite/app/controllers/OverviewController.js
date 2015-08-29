(function () {
	'use strict';

	var module = angular.module("mainApp");

	// this code can be used with uglify
	module.controller("OverviewController",
		[
			"$scope",
			"$log",
			"dataEventRecords",
			//"fastestAnimals",
			OverviewController
		]
	);

	function OverviewController($scope, $log, dataEventRecords) {
		$log.info("OverviewController called");
		$scope.message = "Overview";

		$log.info(dataEventRecords);
		$scope.dataEventRecords = dataEventRecords;
	
	}
})();
