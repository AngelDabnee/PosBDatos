<?php 
    //echo $_POST['codigo']; 


    try {
        //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos") 
        $conn = new mysqli("localhost","root","","pos");
        $sqlqueryselect = "INSERT INTO productos(codigo,nombre,precio) VALUE("."'".$_POST['codigo']."'".','."'".$_POST['nombre']."'".','.$_POST['precio'].");";
        $comando = mysqli_query($conn , $sqlqueryselect);
        header('Location: productos.php');
    } catch (Exception $e) {
        echo 'Se ha detectado un acceso no permitido. : ',  $e->getMessage(), "\n";
    } 
?>  
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=a">
    <title>Productos</title>
</head>
<body>
    <a href = "productos.php"> producto</a>
</body>
</html>