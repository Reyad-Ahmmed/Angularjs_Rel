angular.module("myApp")
    .controller("EmpController", ($scope, $http, $routeParams) => {

        $scope.$emit('selectedTypeChanged', $routeParams.id);
        $scope.insertEmp = f => {
            $http.post("/api/Employees", $scope.empObject)
                .then(r => {
                    $scope.model.employees.push(r.data);
                    $scope.empObject = {};
                    $scope.alertMsg = "Success! Data saved successfully."
                    f.$setPristine();
                    f.$setUntouched();

                }, err => {
                    $scope.alertMsg = "Something wrong! Failed to saved data."
                })
            

        }
    })