<?php

class Servicios extends conectar{
    public function get_servicios(){
        $conectar=parent::conexion();
        parent::set_names();
        $sql="SELECT * FROM servicios";
        $sql=$conectar->prepare($sql);
        $sql->execute();
        return $resultado=$sql->fetchAll(PDO::FETCH_ASSOC);
    }

     public function get_Horarios(){
        $conectar=parent::conexion();
        parent::set_names();
        $sql="SELECT idServicio,horarios FROM servicios";
        $sql=$conectar->prepare($sql);
        $sql->execute();
        return $resultado=$sql->fetchAll(PDO::FETCH_ASSOC);
    }

    //Traer horarios virtuales por id
    public function getHorariosVirtualesId($id_Servicio){
        $conectar=parent::conexion();
        parent::set_names();
        $sql="SELECT idServicio,horariosVirtuales FROM servicios WHERE idServicio like :idServicio";

        $stmt=$conectar->prepare($sql);

        $stmt->bindParam(':idServicio',$id_Servicio,PDO::PARAM_STR);
  
        $stmt->execute();
        return $resultado=$stmt->fetchAll(PDO::FETCH_ASSOC);

        
    }

     //Traer horarios presenciales por id
     public function getHorariosPresencialesId($id_Servicio){
        $conectar=parent::conexion();
        parent::set_names();
        $sql="SELECT idServicio,horariosPresenciales FROM servicios WHERE idServicio like :idServicio";

        $stmt=$conectar->prepare($sql);

        $stmt->bindParam(':idServicio',$id_Servicio,PDO::PARAM_STR);
  
        $stmt->execute();
        return $resultado=$stmt->fetchAll(PDO::FETCH_ASSOC);

        
    }







}

?>