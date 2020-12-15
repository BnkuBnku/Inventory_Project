<?php

require 'connect.php';

$id = $_POST['ProductID'];

$statement = $conn->prepare("CALL deleteProduct(?);");

$statement->bindParam(1, $id, PDO::PARAM_INT);

if(($statement->execute()) == 1)
{
	echo 'success';
}

$conn = null;




?>