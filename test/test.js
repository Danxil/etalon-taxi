var http = require('http');
http.post = require('http-post');

/*
describe('mailer', function () {
    it('should return success', function (done) {
        http.post('http://localhost:3030/api/backCall', {phoneNumber: '333-33-33'}, function (res) {
            done()
        }, function() {
            done('error')
        });
    });
});
*/

describe('api', function () {
    it('places must be array', function (done) {
        http.get('http://localhost:3030/api/places', function(res) {
            done()
        }, function(error) {
            done(error)
        });
    });
});