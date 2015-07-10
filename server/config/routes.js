module.exports = function (app, emailService, soapClient) {
    app.route('/api/backCall').post(function (req, res) {
        if (!req.body.phoneNumber)
            return res.send(400);

        emailService.sendEmail('Человек с телефоном: ' + req.body.phoneNumber + ' хочет вызвать такси. ', 'Обратный звонок').then(function() {
            res.send(200);
        }, function() {
            res.send(500);
        });
    });

    app.route('/api/places').get(function (req, res) {
        soapClient.execute('RegistersQuery').then(function(response) {
            res.send(response)
        })
    });

    app.route('/api/order-calculate-only').post(function (req, res) {
        soapClient.execute('OrderCalculateOnly', req.body).then(function(response) {
            res.send(response)
        })
    });

    app.route('/api/add-new-order').post(function (req, res) {
        soapClient.execute('AddNewOrder', req.body).then(function(response) {
            res.send(response)
        })
    });

    app.get('/cabinet', function (req, res) {
        res.render('cabinet');
    });

    app.get('/partials/*', function (req, res) {
        var locale = req.cookies.locale;
        req.setLocale(locale);
        res.render('../../public/app/' + req.params[0]);
    });

    app.get('/cabinet-partials/*', function (req, res) {
        res.render('../../public/cabinet/' + req.params[0]);
    });

    app.get('/:lang*', function (req, res) {
        var locale = req.params.lang || req.cookies.locale;

        if (locale == 'static')
            return

        if (locale != 'ru' && locale != 'en' && locale != 'ua') {
            return res.redirect('/ru')
        }

        res.cookie('locale', locale);
        req.setLocale(locale);

        res.render('index');
    });

    app.get('/', function (req, res) {
        var locale = req.cookies.locale;

        if (locale != 'ru' && locale != 'en' && locale != 'ua') {
            return res.redirect('/ru')
        } else {
            return res.redirect('/' + locale)
        }

        res.render('index');
    });
};