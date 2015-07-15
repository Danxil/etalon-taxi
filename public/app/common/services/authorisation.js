angular.module('app').factory('authorisation', function ($http) {
    return {
        login: function(login, password) {
            return $http.post('/api/login', {login: login, password: password})
        },
        getUserData: function () {
            return $http.get("/api/login")
        }
    }
})