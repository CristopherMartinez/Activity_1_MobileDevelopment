<?php


header('Content-Type:application/json');

require_once("../config/conexion.php");
require_once("../models/Servicios.php");
$servicios=new Servicios();

$body=json_decode(file_get_contents("php://input"),true);

switch ($_GET["op"]) {
    case 'traer_servicios':
        $servicios=$servicios->get_servicios();
        echo json_encode($servicios);
        break;

    case 'traer_horarios':
        $horarios=$servicios->get_Horarios();
        echo json_encode($horarios);
        break;

    case 'traerHorariosVirtuales': 
        $horarios=$servicios->getHorariosVirtualesId($body['idServicio']);
        echo json_encode($horarios);
        break;

    case 'traerHorariosPresenciales':
        $horarios=$servicios->getHorariosPresencialesId($body['idServicio']);
        echo json_encode($horarios);
        break;
    


    
}

?>