<?php

require 'connect.php';

$statement = $conn->prepare("Call DisplayCustomerInfo()");
$statement->execute();

$response = $statement->fetchAll(PDO::FETCH_ASSOC);

echo json_encode($response);

?>