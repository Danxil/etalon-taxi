var express = require('express'),
    stylus = require('stylus'),
    logger = require('morgan'),
    bodyParser = require('body-parser'),
    cookieParser = require('cookie-parser'),
    session = require('express-session'),
    i18n = require("i18n"),
    path = require('path');

module.exports = function (app, config) {
    function compileStylus(str, path){
        console.log(1111111111111)
        return stylus(str).set('filename', path);
    }

    i18n.configure({
        locales: ['ru', 'en', 'ua'],
        cookie: 'locale',
        directory: path.join(__dirname, '../../local/')
    });

    app.set('views', config.rootPath + '/server/views');
    app.set('view engine', 'jade');
    app.use(logger('dev'));
    app.use(cookieParser());
    app.use(bodyParser());
    app.use(session({secret: 'lionheart vs dark knight', saveUninitialized: true}));

    app.use(stylus.middleware(
        {
            src: config.rootPath + 'public',
            compile: compileStylus
        }
    ));
    app.use(express.static(config.rootPath + '/public'));
    app.use('/static/', express.static(config.rootPath + '/public'));
    app.use(i18n.init);
};
