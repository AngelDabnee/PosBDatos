<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Actualizar</title>
</head>
<body bgcolor = "ccd5ae">
    <center><t1 style = "font-size:50px">Actualizar</t1></center>
    <?php
        $codigo = $_GET['codigo'];
        $conn = new mysqli("localhost","root","","pos")  
        or die("Por alguna razón no nos pudimos conectar al servidor");
        /*ESTABLECEMOS LAS VARIABLES DE COMANDO */
        $sqlqueryselect = "SELECT * FROM productos WHERE codigo = '$codigo';";
        $comando = mysqli_query($conn , $sqlqueryselect);
        if($comando->num_rows > 0)
        {
            while ($registro = $comando->fetch_assoc())
            {
                
                $id = $registro['codigo'];
                $nombre = $registro['nombre'];
                $precio = $registro['precio'];
            }
        }

    ?>
    <center>
    <form action="updateBack.php" method = "post">
    <fieldset style="width:0px">
        <legend>AGREGAR NUEVO PRODUCTO</legend>
        Codigo del Producto: <input name = "codigo" type="text" value = "<?php echo $id;?>"><br>
        Nombre del Producto: <input name = "nombre" type="text" value = "<?php echo $nombre;?>" ><br>
        Precio del Producto: <input name = "precio" type = "text" value = "<?php echo $precio;?>"><br>
        <input type ="submit" value = 'Actualizar Producto'>
    </fieldset>
    </center>
</form>
</body>
</html>