<?php

$val1 = 3;
$val2 = 8;

$client=new SoapClient('http://localhost/soap-add/server.php?wsdl',['trace'=>1,'cache_wsdl'=>WSDL_CACHE_NONE]);
$resp  = $client->Add($val1, $val2);

echo $client->__getLastResponse();
?>