var request = require('request');

var options = {
    //proxy: process.env.QUOTAGUARDSTATIC_URL,
    url: 'https://api.github.com/repos/joyent/node',
    headers: {
        'User-Agent': 'node.js'
    }
};

describe('test static:', function () {
    it('should return success', function (done) {
        request(options, function callback(error, response, body) {
            if (!error && response.statusCode == 200) {
                console.log(options.proxy);
                done();
            } else {
                done(error);
            }
        });
    });
});
