var app = angular.module('appMovies',[])
var Controllers = {};
    Controllers.newMovie = function ($scope,$http) {
    $scope.save = function () {
        console.log($scope.Movie);
        $scope.result = JSON.stringify($scope.Movie);
        //$http.get("/api/movies/GetSaludo").then(
        //    function (data) {
        //        console.log(data);
        //    },
        //    function (data) {
        //        console.log(data);
        //    });
        $http.post("/api/movies/SetMovie",$scope.Movie).then(
            function (data) {
                console.log(data);
            },
            function (data) {
                console.log(data);
            });
    }
}
app.controller(Controllers);