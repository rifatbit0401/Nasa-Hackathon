app.controller('pestCtrl', function($scope, $routeParams, $http) {

    $scope.pest = {};
    $scope.getPestInfo=function() {
        var pestId = parseInt($routeParams('pestId'));
        $http.get('http://localhost:51507/Pest/?pestId=' + pestId).success(function(response) {
            $scope.pest = response;
        });
    }

    $scope.questions = [];
    $scope.getQuestions=function() {
        $http.get('http://localhost:51507/GetAllQuestionByPestName?pestName' + $scope.Name).success(function(response) {
            $scope.questions = response;
        });
    }

    $scope.pesticides = [];
    $scope.getPesticides = function() {
        $http.get('http://localhost:51507/Peticide/GetAllPescideByPestName+' + $scope.pest.Name).success(function(response) {
            $scope.getPesticides = response;
        });
    };

    $scope.crops = [];
    $scope.getCrops=function() {
        $http.get('http://localhost:51507/Crop/GetAllCropByPestName+' + $scope.pest.Name).success(function(response) {
            $scope.crops = response;
        });
    }

});