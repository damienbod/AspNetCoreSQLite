(function () {
	'use strict';

	var module = angular.module('mainApp');

	// this code can be used with uglify
	module.controller('DetailsController',
		[
			'$scope',
			'$log',
			'dataEventRecord',
            'DataEventRecordsService',
			DetailsController
		]
	);

	function DetailsController($scope, $log, dataEventRecord, DataEventRecordsService) {
		$log.info("DetailsController called");
		$scope.message = "dataEventRecord Details";
	    $scope.DataEventRecordsService = DataEventRecordsService;

		$scope.dataEventRecord = dataEventRecord;

		$scope.Update = function() {
		    $log.info("Updating");
		    $log.info(dataEventRecord);
		    $scope.DataEventRecordsService.UpdateDataEventRecord(dataEventRecord);
		};

	}

})();
