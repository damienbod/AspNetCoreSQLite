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
		$scope.message = "dataEventRecord Create, Update or Delete";
	    $scope.DataEventRecordsService = DataEventRecordsService;

		$scope.dataEventRecord = dataEventRecord;

		$scope.Update = function() {
		    $log.info("Updating");
		    $log.info(dataEventRecord);
		    $scope.DataEventRecordsService.UpdateDataEventRecord(dataEventRecord);
		};

		$scope.Create = function () {
		    $log.info("Creating");
		    $log.info(dataEventRecord);
		    $scope.DataEventRecordsService.AddDataEventRecord(dataEventRecord);
		};

	}

})();
