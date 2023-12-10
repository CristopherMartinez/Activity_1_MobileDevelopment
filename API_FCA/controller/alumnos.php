<?php


header('Content-Type:application/json');

require_once("../config/conexion.php");
require_once("../models/Alumnos.php");
$alumnos=new Alumnos();

$body=json_decode(file_get_contents("php://input"),true);

switch ($_GET["op"]) {
    case 'traer_alumnos':
        $datos=$alumnos->get_alumnos();

        echo json_encode($datos);
        break;

    case 'obtener_alumno':
        $datos=$alumnos->get_alumno_x_matricula($body["nom"],$body["p"]);

        echo json_encode($datos);
        break;
    

}

?>