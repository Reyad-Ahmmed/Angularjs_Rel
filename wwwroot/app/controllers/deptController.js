angular.module("myApp")
    .controller("deptController", ($scope, $http) => {
        $scope.insertDept = (frm) => {
            $scope.deptObject = {};
            $http.post("/api/Departments", $scope.deptObject)
                .then(r => {
                    $scope.model.departments.push(r.data);
                    $scope.alertMsg="Success! Data saved successfully."
                    frm.$setPristine();
                    frm.$setUntouched();
                    $scope.deptObject = {};
                    
                }, err => {
                    $scope.alertMsg = "Something wrong! Failed to saved data."
                })
        }
        // back button 
        $scope.back = (frm) => {
            frm.$setPristine();
            frm.$setUntouched();
            $scope.deptObject = {};
            $location.path("/departments");
        }
    })