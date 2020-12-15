<?php

require 'connect.php';

$ProductName = $_POST['ProductName'];
$Model = $_POST['Model'];
$Brand = $_POST['Brand'];
$Attributes = $_POST['Attributes'];


//PREPARE CALLING PROCEDURE

$statement = $conn->prepare("CALL insertProduct(?,?,?,?)");

$statement->bindParam(1, $ProductName, PDO::PARAM_STR);
$statement->bindParam(2, $Model, PDO::PARAM_STR);
$statement->bindParam(3, $Brand, PDO::PARAM_STR);
$statement->bindParam(4, $Attributes, PDO::PARAM_STR);


if(($statement->execute()) == 1){
	echo 'success';
}

$conn = null;
?>