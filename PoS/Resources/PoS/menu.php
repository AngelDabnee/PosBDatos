<?php
    include ("inc/function.php");
?>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>MENU</title>
    <link rel="stylesheet" href="./css/style.css">
</head>
<body bgcolor ="#f1f1f1">
    <center>
        <h1>MENÚ PRINCIPAL</h1>
        <a href = "../pos/productos/productos.php"></a>
        <?php
            menu();
        ?>       
    </center>
    <footer class ="footer">
    <?php
        footer();
    ?>
    </footer>
</body>
</html>