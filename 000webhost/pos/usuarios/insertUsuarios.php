<?php 
    //echo $_POST['codigo']; 
    try {
        //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos") 
        $conn = new mysqli("localhost","root","","pos");
        $sqlqueryselectusuarios = "INSERT INTO usuarios(id,apellido1,apellido2,nombres,email,password,rfc,curp) VALUE("."'".$_POST['apellido1']."'".','."'".$_POST['apellido2']."'".','."'".$_POST['nombres']."'".','."'".$_POST['email']."'".','."'".$_POST['password']."'".','."'".$_POST['password']."'".','."'".$_POST['rfc']."'".','."'".$_POST['curp']."'".");";
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