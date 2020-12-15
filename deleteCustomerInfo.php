<?php

require 'connect.php';
$id = $_POST['CustomerID'];

$statement = $conn->prepare("CALL deleteCustomerInfo(?);");

$statement->bindParam(1, $id, PDO::PARAM_INT);

if(($statement->execute()) == 1)
{
	echo 'success';
}

$conn = null;




?>