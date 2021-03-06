﻿'use strict';


testAPIApp.factory('DebitNoteService', function ($http, $rootScope) {

    var config = {
        headers: { 'Content-Type': 'application/json; charset=UTF-8', 'Authorization': $rootScope.authKey }

    };

    var getAllPolicyInfoRecording = function () {
        return $http.post($rootScope.serviceURL + 'api/Policy/GetAllPolicyInfoRecordings', null, config).then(function (results) {
            return results.data;
        }, function (data) {
            // Handle error here
        })
    };

    var getAllPolicyInfoRecordingByClientID = function (ClientID) {
        var params = { "ClientID": ClientID };
        return $http.post($rootScope.serviceURL + 'api/Policy/GetPolicyInfoRecordingsByClient', params, config).then(function (results) {
            return results.data;
        }, function (data) {
            // Handle error here
        })
    };

    var UpdatePolicyInfoRecording = function (quotationHeaderID, policyInfoRecList, userID) {
        var params = { "QuotationHeaderID": 1, "PolicyInfoRecList": policyInfoRecList, "UserID": userID };
        return $http.post($rootScope.serviceURL + 'api/Policy/UpdatePolicyInformationRecording', params, config).then(function (results) {
            return results.data;
        }, function (data) {
            // Handle error here
        })
    };
    var getQuatationHeader = function (quotationHeaderID) {
        var params = { "QuotationHeaderID": quotationHeaderID };
        return $http.post($rootScope.serviceURL + 'api/Quotation/GetQuotationHeaderByID', params, config).then(function (results) {
            return results.data;
        }, function (data) {
            // Handle error here
        })
    };
    var getClientByID = function (ClientID) {
        var params = { "ClientID": ClientID };
        return $http.post($rootScope.serviceURL + 'api/ClientRequest/GetClientByID', params, config).then(function (results) {
            return results.data;
        }, function (data) {
            // Handle error here
        })
    };

    var getClientRequest = function (ClientRequestHeaderID) {
        var params = { "ClientRequestHeaderID": ClientRequestHeaderID };
        return $http.post($rootScope.serviceURL + 'api/ClientRequest/GetClientRequestByID', params, config).then(function (results) {
            return results.data;
        }, function (data) {
            // Handle error here
        })
    };

    var getAllPartners = function () {
        return $http.post($rootScope.serviceURL + 'api/Partner/GetAllPartners', null, config).then(function (results) {
            return results.data;
        }, function (data) {
            //Handle error here
        });
    };

    var getAllComStructuresHeaders = function () {
        return $http.post($rootScope.serviceURL + 'api/ComStructure/GetAllComStructureHeaders', null, config).then(function (results) {
            return results.data;
        }, function (data) {
            //Handle error here
        });
    };

    var getAllComStructuresLine = function () {
        return $http.post($rootScope.serviceURL + 'api/ComStructure/GetAllComStructureLines', null, config).then(function (results) {
            return results.data;
        }, function (data) {
            //Handle error here
        });
    };

    var getAllChargeType = function () {
        return $http.post($rootScope.serviceURL + 'api/ChargeType/GetAllChargeTypes', null, config).then(function (results) {
            return results.data;
        }, function (data) {
            //Handle error here
        });
    };

    var getAllPaymentDebitNotes = function () {
        return $http.post($rootScope.serviceURL + 'api/Payment/GetAllPayments', null, config).then(function (results) {
            return results.data;
        }, function (data) {
            //Handle error here
        });
    };
    var SaveDebitNote = function (PaymentObj, UserID) {
        var params = { "PaymentObj": PaymentObj, "UserID": UserID };
        alert("" + angular.toJson(params));
        return $http.post($rootScope.serviceURL + 'api/Payment/SavePayment', params, config).then(function (results) {
            return results.data;
        }, function (data) {
            //Handle error here
        });
    };

    var getAllClients = function (businessUnitID) {
        var params = { "businessUnitID": businessUnitID, "homeCountryID": null, "residentCountryID": null };

        return $http.post($rootScope.serviceURL + 'api/ClientRequest/GetAllClients', null, config).then(function (results) {
            return results.data;
        }, function (data) {
            //Handle error here
        });
    };

    return {
        getAllPolicyInfoRecording: getAllPolicyInfoRecording,
        UpdatePolicyInfoRecording: UpdatePolicyInfoRecording,
        getQuatationHeader: getQuatationHeader,
        getClientByID: getClientByID,
        getClientRequest: getClientRequest,
        getAllPartners: getAllPartners,
        getAllComStructuresHeaders: getAllComStructuresHeaders,
        getAllComStructuresLine: getAllComStructuresLine,
        getAllChargeType: getAllChargeType,
        getAllPaymentDebitNotes: getAllPaymentDebitNotes,
        SaveDebitNote: SaveDebitNote,
        getAllClients: getAllClients,
        getAllPolicyInfoRecordingByClientID: getAllPolicyInfoRecordingByClientID
    };
});