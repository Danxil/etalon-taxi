var path = require('path');
var rootPath = path.normalize(__dirname + '/../../');

module.exports = {
    development: {
        rootPath: rootPath,
        port: process.env.PORT || 3030,
        smtpUser: 'eriendel97@gmail.com',
        smtpPassword: 'xqbF2y5c5KRokhpPTVLdIQ',
        emailHost: 'smtp.mandrillapp.com',
        emailPort: '587',
        fromEmail: 'eriendel97@gmail.com',
        managerEmail: 'danxil@list.ru',
        soapUrl: 'http://taxi.intelserv.com/YTaxiSOAP/YTxWebService.asmx?WSDL',
        soapProvider: '00000000-0000-0000-0000-000000000115'
    },
    production: {
        rootPath: rootPath,
        port: process.env.PORT ||80,
        smtpUser: 'eriendel97@gmail.com',
        smtpPassword: 'xqbF2y5c5KRokhpPTVLdIQ',
        emailHost: 'smtp.mandrillapp.com',
        emailPort: '587',
        fromEmail: 'eriendel97@gmail.com',
        managerEmail: 'taxi@etalontaxi.com.ua',
        soapUrl: 'http://taxi.intelserv.com/YTaxiSOAP/YTxWebService.asmx?WSDL',
        soapProvider: '00000000-0000-0000-0000-000000000115'
    }
};