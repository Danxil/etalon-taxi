var passport = require('passport')
    , LocalStrategy = require('passport-local').Strategy

var USER = {
    login: 'admin',
    password: 'admin'
}

module.exports = function (app, soapService) {
    passport.serializeUser(function(user, next) {
        next(null, user.login);
    });

    passport.deserializeUser(function(id, next) {
        if (USER.login == id)
            next(false, USER);
    });

    passport.use(new LocalStrategy({
            usernameField: 'login',
            passwordField: 'password',
            session: false
        }, function(username, password, done) {
            if (username != USER.login)
                return done(null, false, JSON.stringify({ message: 'Unknown user'}))

            if (password != USER.password)
                return done(null, false, JSON.stringify('Invalid password'));

            return done(null, USER)
        }
    ));

    app.use(passport.initialize());
    app.use(passport.session());

    return passport
};
