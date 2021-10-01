angular.module("myApp")
    .controller("empEditController", ($scope, $http, $routeParams) => {
        var id = $routeParams.id;
        var obj = $scope.model.employees.find(e => e.employeeId == id);
        angular.copy(obj, $scope.empObject);

        $scope.updateEmp = f => {

            $http.put("/api/Employees/" + $scope.empObject.employeeId, $scope.empObject)
                .then(r => {
                    var i = $scope.model.employees.findIndex(d => d.employeeId == $scope.empObject.employeeId);
                    angular.copy($scope.empObject, $scope.model.employees[i]);
                    f.$setPristine();
                    f.$setUntouched();
                    $scope.alertMsg = "Data modified."
                }, err => {
                    $scope.alertMsg = "Failed to modify data."
                });
            
        }
    })