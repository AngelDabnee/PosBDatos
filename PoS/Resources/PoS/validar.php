<?php
    include ("./inc/function.php");
    validarUsuario(); 
    $conn = new mysqli("localhost","root","","pos");
    //$conn = new mysqli("localhost","id20924409_angeldabnee","AngelDabnee123.","id20924409_pos");

    /**UTILIZAMOS EL ARREGLO POST, PARA GUARDAR UN ARREGLO DE LOS DATOS QUE CAPTURA EL USUARIO EN LOS INPUT */
    $querySelectValidar = "SELECT email FROM usuarios WHERE email = '".$_POST['correo']."' AND contra = md5(sha(sha1('" .$_POST['password']."')));";
    $comando = mysqli_query($conn , $querySelectValidar);
    if($comando -> num_rows == 1)
    {
        //iniciamos sesión. 
        session_start();
        $_SESSION['usuario'] = $_POST['correo'];
        header("location:menu.php");
    }
    else
    {
        header("location: index.php?error=100");
    }
?>