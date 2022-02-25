﻿function DeleteModal(url, muestraModal) {
    const valores = window.location.search;
    const urlParams = new URLSearchParams(valores);
    var id = urlParams.get("id");
    var alumno = { id: parseInt(id) };
    var parametros = JSON.stringify(alumno);

    $.ajax({
        type: 'GET',
        url: url,
        data: parametros,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: muestraModal,
        error: errorGenerico
    })
};