<?php

$szamok = [
    1,2,3,4,5,6,7,8,9,10
];
function negyzet(array $szamok)
{
    $negyzetTomb = [];
    for($i = 0; $i < count($szamok); $i++)
    {
      $negyzetTomb[] = pow($szamok[$i], 2);
    }
    return $negyzetTomb;
}
function osszeg(array $szamok)
{
    return array_sum($szamok);
}

function atlag(array $szamok)
{
    return osszeg($szamok) / count($szamok);
}

function parosDb(array $szamok)
{
    $db = 0;
    foreach($szamok as $osztva)
    {
        if($osztva % 2 == 0)
        {
            $db++;
        }
    }
    return $db;
}

function forditva(array $szamok)
{
    $segedTomb = [];
    for($i = count($szamok) - 1; $i >= 0 ; $i--)
    {
        $segedTomb[] = $szamok[$i];
    }
    return implode(", ", $segedTomb);
}

function duplaz(array $szamok)
{
    $segedTomb = [];
    for($i = 0; $i < count($szamok) ; $i++)
    {
        $segedTomb[] = $szamok[$i] * 2;
    }
    return $segedTomb;
}
function modosit(array $szamok, $fugv)
{
    $segedTomb = [];
    for($i = 0; $i < count($szamok) ; $i++)
    {
        $segedTomb[] = $szamok[$i];
    }
    if($fugv == "negyzet")
    {
        return negyzet($segedTomb);
    }
    elseif($fugv == "osszeg")
    {
        return osszeg($segedTomb);
    }
    elseif($fugv == "atlag")
    {
        return atlag($segedTomb);
    }
    elseif($fugv == "parosdb")
    {
        return parosDb($segedTomb);
    }
    elseif($fugv == "forditva")
    {
        return forditva($segedTomb);
    }
    elseif($fugv == "duplaz")
    {
        return duplaz($segedTomb);
    }
}

if($argc == 1)
{
    echo "1.feladat:\n";
    foreach(negyzet($szamok) as $negyzet)
    {
        echo $negyzet . "\n";
    }

    echo "2.feladat:\n";
    echo osszeg($szamok) . "\n";

    echo "3.feladat:\n";
    echo atlag($szamok) . "\n";

    echo "4.feladat:\n";
    echo parosDb($szamok) . "\n";

    echo "5.feladat:\n";
    echo forditva($szamok) . "\n";

    echo "6.feladat:\n";
    foreach(duplaz($szamok) as $dszam)
    {
        echo $dszam . "\n";
    }
}
elseif($argc == 2)
{
  echo "7.feladat:\n";
  if($argv[1] == "negyzet")
  {
    foreach(modosit($szamok, $argv[1]) as $negyzet)
    {
      echo $negyzet . "\n";
    }
  }
  elseif($argv[1] == "duplaz")
  {
    foreach(modosit($szamok, $argv[1]) as $dszam)
    {
      echo $dszam . "\n";
    }
  }
  else
  {
    echo modosit($szamok, $argv[1]) . "\n";
  }
}





