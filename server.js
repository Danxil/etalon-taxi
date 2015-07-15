var path = require('path');
global.appRoot = path.resolve(__dirname);

var express = require('express');

var env = process.env.NODE_ENV = process.env.NODE_ENV || 'development';

var app = express();
var config = require('./server/config/config')[env];

require('./server/config/express')(app, config);

var emailService = require('./server/apiServices/emailService')(config)
var soapService = require('./server/apiServices/soapService')(config)
var passport = require('./server/config/passport')(app, soapService);

soapService.createClient().then(function(soapClient) {
    require('./server/config/routes')(app, emailService, soapClient, passport);

    app.listen(config.port);
    console.log('Listening on port ' + config.port + '...');
})