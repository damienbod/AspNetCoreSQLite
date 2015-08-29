(function () {
	'use strict';

	var module = angular.module('mainApp');

	// this code can be used with uglify
	module.controller('DetailsController',
		[
			'$scope',
			'$log',
			'dataEventRecord',
			DetailsController
		]
	);

	function DetailsController($scope, $log, dataEventRecord) {
		$log.info("DetailsController called");
		$scope.message = "dataEventRecord Details";

		$scope.dataEventRecord = dataEventRecord;

	}

})();
