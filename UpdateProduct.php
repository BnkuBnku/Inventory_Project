<?php
require 'connect.php';



$ProductName = $_POST['ProductName'];
$ProductID = $_POST['ProductID'];
$Model = $_POST['Model'];
$Brand = $_POST['Brand'];
$Attributes = $_POST['Attributes'];


$statement = $conn->prepare("Call UpdateProduct(?,?,?,?,?)");

$statement->bindParam(1, $ProductName, PDO::PARAM_STR);
$statement->bindParam(2, $ProductID, PDO::PARAM_INT);
$statement->bindParam(3, $Model, PDO::PARAM_STR);
$statement->bindParam(4, $Brand, PDO::PARAM_STR);
$statement->bindParam(5, $Attributes, PDO::PARAM_STR);


if(($statement->execute()) == 1){
	echo 'success';
}

$conn = null;
?>