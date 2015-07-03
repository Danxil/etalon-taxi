module.exports = function (app, emailService) {
    app.get('/partials/*', function (req, res) {
        var locale = req.cookies.locale;
        req.setLocale(locale);
        res.render('../../public/app/' + req.params[0]);
    });

    app.route('/api/backCall').post(function (req, res) {
        if (!req.body.phoneNumber)
            return res.send(400);

        emailService.sendEmail('Человек с телефоном: ' + req.body.phoneNumber + ' хочет вызвать такси. ', 'Обратный звонок').then(function() {
            res.send(200);
        }, function() {
            res.send(500);
        });
    });

    app.get('/:lang*', function (req, res) {
        var locale = req.params.lang || req.cookies.locale;

        console.log('/:lang* is' + locale)

        if (locale != 'ru' && locale != 'en' && locale != 'ua') {
            return res.redirect('/ru')
        }

        res.cookie('locale', locale);
        req.setLocale(locale);

        res.render('index');
    });

    app.get('/', function (req, res) {
        var locale = req.cookies.locale;
        console.log('/ is' + locale)

        if (locale != 'ru' && locale != 'en' && locale != 'ua') {
            return res.redirect('/ru')
        } else {
            return res.redirect('/' + locale)
        }

        res.render('index');
    });
};