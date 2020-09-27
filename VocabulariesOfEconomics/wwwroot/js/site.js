"use strict";

var VocaEconomicsRepository = {
    data: [],
    init: function () {
        $("#VocaEconomicsLoading").hide();
        VocaEconomicsRepository.btnVocaEconomicsClear_Click(); 
        VocaEconomicsRepository.btnVocaEconomicsSearchList_Click();
    },
    btnVocaEconomicsClear_Click: function () {
        $("#btnVocaEconomicsClear").click(function (e) {
            location.reload(true);
        });
    },
    btnVocaEconomicsSearchList_Click: function () {
        $("#btnVocaEconomicsSearchList").click(function (e) {
            VocaEconomicsRepository.loadListVoca();
        });
    },
    loadListVoca: function () {
        $.ajax({
            method: "GET",
            url: "home/get-list-voca",
            data: {
                "FilterText": $("#FilterBySearch").val(),
                "FilterBy": $("#FilterBy").val()
            },
            contentType: "application/json",
            beforeSend: function () {
                $("#VocaEconomicsLoading").show();
            }
        }).done(function (result) {
            $("#VocaEconomicsLoading").hide();
            $('#tblVoca').html(result);
        });
    }
}