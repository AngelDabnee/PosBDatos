<?php 
    print_r($_POST);
    try {
        //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos") 
        $sqlqueryupdateUsuarios = "UPDATE usuarios SET apellido1 = '{$_POST['apellido1']}',apellido2 = '{$_POST['apellido2']}',nombres = '{$_POST['nombres']}',email = '{$_POST['email']}', password = '{$_POST['password']}',rfc = '{$_POST['rfc']}',curp='{$_POST['curp']}'WHERE id = '{$_POST['id']}';";
        $conn = new mysqli("localhost","root","","pos");
        $comando = mysqli_query($conn , $sqlqueryupdateUsuarios);
        header('Location: usuarios.php');
    } catch (Exception $e) {
        echo 'Se ha detectado un acceso no permitido. : ',  $e->getMessage(), "\n";
    } 
?>  