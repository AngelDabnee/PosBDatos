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
        
        while ($registro = $comando->fetch_assoc())
        {
            
            $id = $registro['id'];
            $apellido1 = $registro['apellido1'];
            $apellido2 = $registro['apellido2'];
            $nombres = $registro['nombres'];
            $email = $registro['email'];
            $password = $registro['password'];
            $rfc = $registro['rfc'];
            $curp = $registro['curp'];
        }
        
    }
    else{
        echo("NO SE ENCONTRARON REGISTROS EN LA BASE DE DATOS. ");
    }
    ?>
    
<form action="../usuarios/updateUsuariosBack.php" method = "post">
    <fieldset style="width:0px">
        <legend>AGREGAR NUEVO USUARIO</legend>
        id: <input name = "id" type="text" value = "<?php echo $id;?>"><br>
        Apellido 1: <input name = "apellido1" type="text" value = "<?php echo $apellido1;?>"><br>
        Apellido 2: <input name = "apellido2" type = "text" value = "<?php echo $apellido2;?>"><br>
        Nombres: <input name = "nombres" type = "text" value = "<?php echo $nombres;?>"<br>
        Email: <input name = "email" type = "text" value = "<?php echo $email;?>"><br>
        Password: <input name = "password" type = "text" value = "<?php echo $password;?>"><br>
        CURP: <input name = "curp" type = "text" value = "<?php echo $curp;?>"><br>
        IMAGEN: <input name = "imagen" type = "text" value = "<?php echo $imagen;?>"><br>
        
        <input type ="submit" value = 'Actualizar Usuario'>
    </fieldset>
</form>
</body>
</html>