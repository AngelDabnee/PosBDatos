<?php
    include ("../inc/function.php");
    validarUsuario(); 
    try {
        $id = $_GET["id"]; 
        $conn = new mysqli("localhost","root","","pos");
        //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos");        
        $sqlquerydelete = "DELETE FROM usuarios WHERE id = '$id';";
        $comando = mysqli_query($conn , $sqlquerydelete);
        header('Location: usuarios.php');
    } catch (Exception $e) {
        echo 'Se ha detectado un acceso no permitido. : ',  $e->getMessage(), "\n";
    } 
?>