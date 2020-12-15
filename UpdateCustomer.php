<?php
require 'connect.php';


$CustomerID = $_POST['CustomerID'];
$CustomerName = $_POST['CustomerName'];
$ItemBrought = $_POST['ItemBrought'];
$DateBrought = $_POST['DateBrought'];



//PREPARE CALLING PROCEDURE

$statement = $conn->prepare("CALL UpdateCustomer(?,?,?,?)");

$statement->bindParam(1, $CustomerID, PDO::PARAM_INT);
$statement->bindParam(2, $CustomerName, PDO::PARAM_STR);
$statement->bindParam(3, $ItemBrought, PDO::PARAM_STR);
$statement->bindParam(4, $DateBrought, PDO::PARAM_STR);

if(($statement->execute()) == 1){
	echo 'success';
}

$conn = null;
?>