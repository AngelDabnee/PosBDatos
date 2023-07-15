<?php 
    print_r($_POST);
    try {
        //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos") 
        $sqlqueryupdate = "UPDATE productos SET nombre = '{$_POST['nombre']}',precio = '{$_POST['precio']}' WHERE codigo = '{$_POST['codigo']}'";
        $conn = new mysqli("localhost","root","","pos");
        $comando = mysqli_query($conn , $sqlqueryupdate);
        header('Location: productos.php');
    } catch (Exception $e) {
        echo 'Se ha detectado un acceso no permitido. : ',  $e->getMessage(), "\n";
    } 
?>  