angular.module("myApp")
    .controller("deptEditCtrl", ($scope, $http, $routeParams) => {
        var id = $routeParams.id;
        var obj = $scope.model.departments.find(d => d.departmentId == id);
        angular.copy(obj, $scope.deptObject);
        
        $scope.update =() => {
            
            $http.put("/api/Departments/" + $scope.deptObject.departmentId, $scope.deptObject)
                .then(r => {
                    console.log(r);
                    var i = $scope.model.departments.findIndex(d => d.departmentId == id);
                    angular.copy($scope.deptObject, $scope.model.departments[i]);
                    console.log($scope.deptObject);
                    $scope.alertMsg = "Data modified."
                    
                }, err => {
                    $scope.alertMsg = "Failed to modify data."
                });

        }
        
    })