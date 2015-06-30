var mailer = require("nodemailer");
var vow = require("vow");

module.exports = function (config) {
    var transporter = mailer.createTransport({
        host: config.emailHost,
        port: config.emailPort,
        auth: {
            user: config.smtpUser,
            pass: config.smtpPassword
        }
    });

    return {
        sendEmail: function (text, subject) {
            var def = vow.defer()

            transporter.sendMail({
                to: config.managerEmail,
                from: config.fromEmail,
                subject: subject,
                html: text
            }, function(error) {
                if (error)
                    return def.reject(error)

                def.resolve()
            });

            return def.promise()
        }
    }
};