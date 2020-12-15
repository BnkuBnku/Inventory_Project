<?php

require 'connect.php';

$CustomerName = $_POST['CustomerName'];
$ItemBrought = $_POST['ItemBrought'];
$DateBrought = $_POST['DateBrought'];



//PREPARE CALLING PROCEDURE

$statement = $conn->prepare("CALL insertCustomerInfo(?,?,?)");

$statement->bindParam(1, $CustomerName, PDO::PARAM_STR);
$statement->bindParam(2, $ItemBrought, PDO::PARAM_STR);
$statement->bindParam(3, $DateBrought, PDO::PARAM_STR);



if(($statement->execute()) == 1){
	echo 'success';
}

$conn = null;
?>