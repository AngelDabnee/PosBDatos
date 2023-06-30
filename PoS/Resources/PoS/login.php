<html lang="en">
 <head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CRUD punto de venta</title>
 </head>
 <body bgcolor="f3f2f1">
    <center>
        <h1>BIENVENIDO AL CRUD DE PRODUCTOS</h1>
        <div>
            <h2>Iniciar Sesion</h2>
        <form action="validar.php" method="post">
            <!---este input es para correo--->           
            <div class = "username">
                <input type="email" name="correo" placeholder="Correo Electrónico" value="a@gmail.com" required><br>
            </div>
            <!---este input es para password--->
            <div class = "username">
                <input type="password" name="password" placeholder ="Contraseña" value="123" required><br>
            </div>
            <!---este input es para login--->
            <div class = "recordar">
                <input type="submit" value="Entrar" name = "btningresar"><br>
            </div>
        </form>
        <?php
        if(!empty($_GET))
            if($_GET['error'] == 100){
                echo "USUARIO Y/O CONTRASEÑA ERRONIA. FAVOR DE INTENTARLO";
            }
        ?>
        </div>
    </center>
</body>
 </html>
