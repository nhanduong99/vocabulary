"use strict";


var VocaEconomicsRepository = {
    data: [],
    init: function () {
        $("#VocaEconomicsLoading").hide();
        VocaEconomicsRepository.btnVocaEconomicsSearchList_Click();
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
    },
    getDetails: function (id) {
        var dataPost = {
            ID: parseInt(id)
        }
        $.ajax({
            method: "POST",
            url: "home/get-list-voca-details",
            data: JSON.stringify(dataPost),
            contentType: "application/json"
        }).done(function (result) {
            $("#wordDetails").val(result.word);
            $("#englishDetails").val(result.english);
            $("#vietnameseDetails").val(result.vietnamese);
            $("#spellingDetails").val(result.spelling);
        });
    },
    getEdit: function (id) {
        var dataPost = {
            ID: parseInt(id)
        };
        $.ajax({
            method: "POST",
            url: "home/get-list-voca-details",
            data: JSON.stringify(dataPost),
            contentType: "application/json"
        }).done(function (result) {
            $("#idEdit").val(result.id);
            $("#wordEdit").val(result.word);
            $("#englishEdit").val(result.english);
            $("#vietnameseEdit").val(result.vietnamese);
            $("#spellingEdit").val(result.spelling);
        });
    },
    UpdateVoca: function () {
        var dataPost = {
            ID: parseInt($("#idEdit").val()),
            WORD: $("#wordEdit").val(),
            ENGLISH: $("#englishEdit").val(),
            VIETNAMESE: $("#vietnameseEdit").val(),
            SPELLING: $("#spellingEdit").val()
        }
        $.ajax({
            method: "POST",
            url: "home/update-voca",
            data: JSON.stringify(dataPost),
            contentType: "application/json"
        }).done(function (result) {
            if (result == 1) {
                swal(
                    'Updated',
                    'Update successfully!',
                    'success'
                ).then(function (result) {
                    location.reload();
                })
            }
            else {
                swal('Failed',
                    'Opps! Something was wrong!',
                    'error').then(function (result) {
                        location.reload();
                    })
            }
        })
    },
    AddVoca: function () {
        var dataPost = {
            WORD: $("#word").val(),
            ENGLISH: $("#english").val(),
            VIETNAMESE: $("#vietnamese").val(),
            SPELLING: $("#spelling").val()
        }
        $.ajax({
            method: "POST",
            url: "home/add-voca",
            data: JSON.stringify(dataPost),
            contentType: "application/json"
        }).done(function (result) {
            if (result == 1) {
                swal(
                    'Updated',
                    'Update successfully!',
                    'success'
                ).then(function (result) {
                    location.reload();
                })
            }
            else {
                swal('Failed',
                    'Opps! Something was wrong!',
                    'error').then(function (result) {
                        location.reload();
                    })
            }
        })
    }
}