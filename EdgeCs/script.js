var path = require('path');
var edge = require(path.join(__dirname, 'node_modules/edge'));
var csscript = path.join(__dirname, 'script.cs');
var dotNetFunc = edge.func(csscript);
module.exports = function (fromNetData, callback) {
    dotNetFunc(fromNetData, function (error, result) {
        callback(null, error || result);
    });    
};