<?php

class Alumnos extends conectar{
    public function get_alumnos(){
        $conectar=parent::conexion();
        parent::set_names();
        $sql="SELECT * FROM alumnos";
        $sql=$conectar->prepare($sql);
        $sql->execute();
        return $resultado=$sql->fetchAll(PDO::FETCH_ASSOC);
    }

    public function get_alumno_x_matricula($nombre_alumno,$matricula){
        $conectar=parent::conexion();
        parent::set_names();
        $sql="SELECT * FROM alumnos WHERE nombre like :nombre AND matricula like :matricula ";

        $stmt=$conectar->prepare($sql);

        $stmt->bindParam(':nombre',$nombre_alumno,PDO::PARAM_STR);
        $stmt->bindParam(':matricula',$matricula,PDO::PARAM_STR);

        $stmt->execute();
        return $resultado=$stmt->fetchAll(PDO::FETCH_ASSOC);

        
    }
}

?>