module.exports = function (app, emailService) {
    app.get('/partials/*', function (req, res) {
        var locale = req.cookies.locale;
        req.setLocale(locale);
        res.render('../../public/app/' + req.params[0]);
    });

    app.route('/api/backCall').post(function (req, res) {
        emailService.sendEmail('Человек по имени ' + req.body.name + ' с телефоном: ' + req.body.phoneNumber + ' и email адресом: ' + req.body.email +  ' хочет зарегистрировать компанию. ', 'Обратный звонок');
        res.json({success: true});
    });

    app.get('/:lang*', function (req, res) {
        var locale = req.params.lang || req.cookies.locale;

        if (locale != 'ru' && locale != 'en' && locale != 'ua') {
            return res.redirect('/ru')
        }

        res.cookie('locale', locale);
        req.setLocale(locale);

        res.render('index');
    });
};