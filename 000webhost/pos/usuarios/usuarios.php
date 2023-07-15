<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Usuarios</title>
</head>
<body bgcolor ="ccd5ae">
    <h1>Usuarios</h1>
    Productos Usuarios
    <?php
    /*Establecemos la conexión a la BD con Mysql */
    //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos") 
    $conn = new mysqli("localhost","root","","pos")  
    or die("Por alguna razón no nos pudimos conectar al servidor");
    /*ESTABLECEMOS LAS VARIABLES DE COMANDO */
    $sqlqueryselect = "SELECT * FROM usuarios;";/*COMANDO SELECT PARA PODER BUSCAR*/
    $comando = mysqli_query($conn , $sqlqueryselect);
    if($comando->num_rows > 0){/*AQUI ES IGUAL QUE EN C$, BUSCAMOS QUE SEA MAYOR QUE 0, UNA VEZ QUE SEA ASÍ, IMPRIMIMOS LOS PRODUCTOS*/
        echo "<table border='2' bgcolor = 'e9edc9'>
            <tr>
            <th colspan='10'>TABLA DE USUARIOS</th>
                <tr><th>id</th>
                <th>Apellido1</th>
                <th>Apellido2</th>
                <th>NOMBRES</th>
                <th>EMAIL</th>
                <th>PASSWORD</th>
                <th>RFC</th>
                <th>CURP</th>
                <th>ELIMINAR</th>
                <th>MODIFICAR</th>
            </tr>";//CON ESTO METEMOS LOS EL TITULO DE LA TABLA Y LOS TH SON LOS SUBTITULOS
        while($registro = $comando->fetch_assoc()){
            echo("\n\t<tr>\n\t
                    <td>".$registro["id"]."</td>
                    <td>\n\t".$registro["apellido1"]."</td>
                    <td>\n\t".$registro["apellido2"]."</td>
                    <td>\n\t".$registro["nombres"]."</td>
                    <td>\n\t".$registro["email"]."</td>
                    <td>\n\t".$registro["password"]."</td>
                    <td>\n\t".$registro["rfc"]."</td>
                    <td>\n\t".$registro["curp"]."</td>
                    <td><a href = 'deleteUsuarios.php?id={$registro['id']}'><img src = '../img/delete_icon.png'></a></td>
                    <td><a href = 'updateUsuarios.php?id={$registro['id']}'><img src = '../img/update_icon.png'></a></td>
                </tr>\n");
        }echo "</table>";
    }
    else{
        echo("NO SE ENCONTRARON REGISTROS EN LA BASE DE DATOS. ");
    }
    ?>
    
<form action="../usuarios/insertUsuarios.php" method = "post">
    <fieldset style="width:0px">
        <legend>AGREGAR NUEVO USUARIO</legend>
        Apellido 1: <input name = "apellido1" type="text" value = "caguama miler"><br>
        Apellido 2: <input name = "apellido2" type = "text" value = "tecate"><br>
        Nombres: <input name = "nombres" type = "text" value = "cocavidrio"><br>
        Email: <input name = "email" type = "text" value = "coca@gmail.com"><br>
        Password: <input name = "password" type = "text" value = "123123"><br>
        RFC: <input name = "rfc" type = "text" value = "12345"><br>
        CURP: <input name = "curp" type = "text" value = "12345"><br>
        
        <input type ="submit" value = 'Agregar Usuario'>
    </fieldset>
</form>
</body>
</html>