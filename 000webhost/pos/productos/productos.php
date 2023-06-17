<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Productos</title>
</head>
<body bgcolor ="ccd5ae">
    <h1>Productos</h1>
    <?php
    /*Establecemos la conexión a la BD con Mysql */
    $conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos") 
    or die("Por alguna razón no nos pudimos conectar al servidor");
    /*ESTABLECEMOS LAS VARIABLES DE COMANDO */
    $sqlqueryselect = "SELECT * FROM productos;";/*COMANDO SELECT PARA PODER BUSCAR*/
    $comando = mysqli_query($conn , $sqlqueryselect);
    if($comando->num_rows > 0){/*AQUI ES IGUAL QUE EN C$, BUSCAMOS QUE SEA MAYOR QUE 0, UNA VEZ QUE SEA ASÍ, IMPRIMIMOS LOS PRODUCTOS*/
        echo "<table border='2' bgcolor = 'e9edc9'>
            <tr>
            <th colspan='5'>TABLA DE PRODUCTO</th>
                <tr><th>CODIGO</th>
                <th>NOMBRE</th>
                <th>PRECIO</th>
                <th>ELIMINAR</th>
                <th>MODIFICAR</th>
            </tr>";//CON ESTO METEMOS LOS EL TITULO DE LA TABLA Y LOS TH SON LOS SUBTITULOS
        while($registro = $comando->fetch_assoc()){
            echo("\n\t<tr>\n\t
                    <td>".$registro["codigo"]."</td>
                    <td>\n\t".$registro["nombre"]."</td>
                    <td>\n\t".$registro["precio"]."</td>
                    <td> <img src = '../img/delete_icon.png'</td> 
                    <td> <img src = '../img/update_icon.png'</td>
                </tr>\n");
        }echo "</table>";
    }
    else{
        echo("NO SE ENCONTRARON REGISTROS EN LA BASE DE DATOS. ");
    }
    ?>
    
<form action="insert.php" method = "post">
    <fieldset style="width:0px">
        <legend>AGREGAR NUEVO PRODUCTO</legend>
        Codigo del Producto: <input name = "codigo" type="text" value = "13"><br>
        Nombre del Producto: <input name = "nombre" type="text" value = "caguama miler"><br>
        Precio del Producto: <input name = "precio" type = "text" value = "12.12"><br>
        <input type ="submit" value = 'Agregar Producto'>
    </fieldset>
</form>
</body>
</html>