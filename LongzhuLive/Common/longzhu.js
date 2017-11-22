"use strict";
var page = require('webpage').create(),
    system = require('system'),
    t, address,
    host, port,exit;

address = system.args[1];
host = system.args[2];
port = system.args[3];
exit = system.args[4];
phantom.outputEncoding = "gbk"
page.settings.loadImages = false;
page.settings.setTimeout = "5";
//page.settings.userAgent = 'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.89 Safari/537.36';
page.settings.userAgent = 'WebKit/534.46 Mobile/9A405 Safari/7534.48.3';

if (address == "") {
    phantom.exit();
}
if (host == ""|| port=="") {
    OpenPlus();
}
else {
    //var lstPort = eval('(' + host + ')');
    //console.log(lstPort);
    //for (var i = 0; i < lstPort.length; i++) {
    //    console.log(lstPort[i].ip);
    //    console.log(lstPort[i].port);
    //        phantom.setProxy(lstPort[i].ip, lstPort[i].port, 'manual', '', '');
    //        OpenPlus(); 
    //}
    phantom.setProxy(host, port, 'manual', '', '')
    OpenPlus(); 
}

if (exit == "") {
    exit == true;
}

page.onResourceRequested = function (requestData, request) {
    if ((/http:\/\/.+?\.css/gi).test(requestData['url']) || requestData.headers['Content-Type'] == 'text/css') {
        console.log('The url of the request is matching. Aborting: ' + requestData['url']);
        request.abort();
    }
};
page.onResourceTimeout = function (request) {
    phantom.exit(0);
};

  


function GetLiveInfo() {
    console.log(page.evaluate(function () {
        var data = {};
        //主播现在不在，看下其它直播和视频吧
        data.online = $("#header-info-online").text();
        data.duration = $("#header-info-time").text();
        
        //return data;
        return JSON.stringify(data);
    }));
}

function OpenPlus() {
    t = Date.now();
    page.open(address, function (status) {

        if (status !== 'success') {
            console.log('FAIL to load the address');
            phantom.exit();
        } else {
            t = Date.now() - t;

            page.includeJs("http://code.jquery.com/jquery-latest.js", function () {

                GetLiveInfo();
                console.log('Loading time ' + t + ' msec');
                if (exit) {
                    phantom.exit();
                }

            });
        }

    });
}