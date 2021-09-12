<?php
$versenyzok = [
    "ricciardo" => [
        "rajtszam" => 3,
        "nev" => "Daniel Ricciardo",
        "orszag" => "Australia",
        "szulido" => "1989.07.01",
    ],
    "norris" => [
        "rajtszam" => 4,
        "nev" => "Lando Norris",
        "orszag" => "United Kingdom",
        "szulido" => "1999.11.13",
    ],
    "vettel" => [
        "rajtszam" => 5,
        "nev" => "Sebastian Vettel",
        "orszag" => "Germany",
        "szulido" => "1987.07.03",
    ],
    "raikkonen" => [
        "rajtszam" => 7,
        "nev" => "Kimi Raikkönen",
        "orszag" => "Finland",
        "szulido" => "1979.10.17",
    ],
];
foreach($versenyzok as $versenyzo)
{
    foreach($versenyzo as $cucc)
    {
        echo $cucc . "\t";
    }
    echo "\n";
}