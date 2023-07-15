<?php 
    include ("../inc/function.php");
    if($_GET['error']==100)
    {
    header('Location: login.php?error=100');
    }
    else{
        header('Location: login.php');
    }
?>  
