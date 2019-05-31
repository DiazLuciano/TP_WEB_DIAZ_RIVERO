
$(document).ready(function ()
{
    var urlActual = window.location.toString().trim().toUpperCase();

    if (urlActual.indexOf('PASOTRES.ASPX') > -1)
    {
        AceptaSoloNumero('textoDNI');
        AceptaSoloNumero('CP');


    }
}
)