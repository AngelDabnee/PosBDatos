<?php
    function menu(){
        $ruta="http://localhost/pos";
        echo "<a href ='$ruta/productos/productos.php'>PRODUCTOS</a> 
        <a href = '$ruta/usuarios/usuarios.php'>USUARIOS</a>
        <a href = '#' >VENTAS</a> 
        <a href ='$ruta/menu.php'>MENU</a> 
        <a href = '$ruta/index.php'>SALIR</a>";
    }
    function footer(){
        echo "aaaaa ";
    }
?>