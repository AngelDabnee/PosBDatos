<?php
    function menu(){
        $ruta="http://localhost/pos";
        echo "<a href ='$ruta/productos/productos.php'>PRODUCTOS</a> 
        <a href = '$ruta/usuarios/usuarios.php'>USUARIOS</a>
        <a href = '$ruta/ventas.php' >VENTAS</a> 
        <a href ='$ruta/menu.php'>MENU</a> 
        <a href = '$ruta/logout.php'>SALIR</a>";
    }
    function footer(){
        echo "<footer class = 'foter'> 2023 Todos los derechos reservados. Burger's Dabnee</footer> ";
    }
    function validarUsuario(){
        session_start();
        if(empty($_SESSION['usuario'])){
            header('location: index.php');
        }
    }
?>