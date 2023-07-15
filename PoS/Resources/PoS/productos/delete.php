<?php
    include ('../inc/function.php');
    validarUsuario(); 
    try {
        $id = $_GET["codigo"]; 
        //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos");
        $conn = new mysqli("localhost","root","","pos");
        $sqlqueryselect = "DELETE FROM productos WHERE codigo = '$id';";
        $comando = mysqli_query($conn , $sqlqueryselect);
        header('Location: productos.php');
    } catch (Exception $e) {
        echo 'Se ha detectado un acceso no permitido. : ',  $e->getMessage(), "\n";
    } 
?>