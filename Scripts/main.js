var datos = [];
window.onload = async function () {

    webgazer.params.showVideoPreview = true;
    //start the webgazer tracker
    await webgazer.setRegression('ridge') /* currently must set regression and tracker */
        //.setTracker('clmtrackr')
        .setGazeListener(function (data, clock) {
            if (data == null) {
                return;
            }
            var dat = { clock: clock, x: data.x, y: data.y, experimento: '' };
            datos.push(dat);
            console.log(dat);
        }).begin();
        webgazer.showPredictionPoints(true); /* shows a square every 100 milliseconds where current prediction is */


    //Set up the webgazer video feedback.
    var setup = function() {

        //Set up the main canvas. The main canvas is used to calibrate the webgazer.
        var canvas = document.getElementById("plotting_canvas");
        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;
        canvas.style.position = 'fixed';
    };
    setup();

};

// Kalman Filter defaults to on. Can be toggled by user.
window.applyKalmanFilter = true;

// Set to true if you want to save the data even if you reload the page.
window.saveDataAcrossSessions = true;


window.onbeforeunload = function (exp) {
    datos.forEach(function setExp(item) {
        item.experimento = exp;
    });
    webgazer.end();
    var datas = JSON.stringify(datos);
    //es para pruebas para ver cómo está jalando la informacion 
    //document.write(datas);
    
    var uri = '/Home/ProcesarDatos';
    $.ajax({
      url: uri,
       data: datas,
        type: 'POST',
        contentType: "application/json; charset=utf-8",
       dataType: "json"
    });
    document.location = exp;
}


/**
 * Restart the calibration process by clearing the local storage and reseting the calibration point
 */
function Restart(){
    document.getElementById("Accuracy").innerHTML = "<a>Not yet Calibrated</a>";
    webgazer.clearData();
    ClearCalibration();
    PopUpInstruction();
}
