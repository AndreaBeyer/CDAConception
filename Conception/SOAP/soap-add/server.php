<?php
ini_set("soap.wsdl_cache_enabled","0");

function add($val1, $val2)
{
	return $val1 + $val2;
}

$server=new SoapServer("add.wsdl");

$server->addFunction('add');

$server->handle();

?>