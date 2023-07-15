<?php 
    include ("../inc/function.php");
    validarUsuario(); 
    try {
        $conn = new mysqli("localhost","root","","pos");
        //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos");
        $sqlqueryselectusuarios = "INSERT INTO usuarios(id,apellido1,apellido2,nombres,email,contra,curp,imagen) VALUE("."'".$_POST['apellido1']."'".','."'".$_POST['apellido2']."'".','."'".$_POST['nombres']."'".','."'".$_POST['email']."'".','."'".$_POST['password']."'".','."'".$_POST['curp']."'".','."'".$_POST['imagen']."'".");";
        echo $sqlqueryselectusuarios;
        $comando = mysqli_query($conn , $sqlqueryselectusuarios);
        header('Location: usuarios.php');
    } catch (Exception $e) {
        echo 'Se ha detectado un acceso no permitido. : ',  $e->getMessage(), "\n";
    } 
?>  
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=a">
    <title>Usuarios</title>
</head>
<body>
    <a href = "usuarios.php"> Usuarios</a>
</body>
</html>