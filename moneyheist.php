<?php
$foszereplok = [
    "Tokió" => [
        "varos" => "Tokió",
        "szinesz" => "Úrsula Corberó",
        "szereplo" => "Silene Oliveira",
        "szinkron" => "Dobó Enikő",
    ],
    "Lisszabon" => [
        "varos" => "Lisszabon",
        "szinesz" => "Itziar Ituno",
        "szereplo" => "Raquel Murillo",
        "szinkron" => "Bánfalvi Eszter",
    ],
    "Salvador" => [
        "varos" => "Salvador",
        "szinesz" => "Alvaro Morte",
        "szereplo" => "Sergio Marquina",
        "szinkron" => "Dévai Balázs",
    ],
    "Moszkva" => [
        "varos" => "Moszkva",
        "szinesz" => "Paco Tous",
        "szereplo" => "Agustin Ramos",
        "szinkron" => "Csuja Imre",
    ],
    "Berlin" => [
        "varos" => "Berlin",
        "szinesz" => "Pedro Alonso",
        "szereplo" => "Andrés de Fonollosa",
        "szinkron" => "Kálid Artúr",
    ],
    "Nairobi" => [
        "varos" => "Nairobi",
        "szinesz" => "Alba Flores",
        "szereplo" => "Ágata Jiménez",
        "szinkron" => "Szilágyi Csenge",
    ],
    "Rio" => [
        "varos" => "Rio",
        "szinesz" => "Miguel Herrán",
        "szereplo" => "Anibal Cortés",
        "szinkron" => "Jéger Zsombor",
    ],
    "Denver" => [
        "varos" => "Denver",
        "szinesz" => "Jaime Lorente",
        "szereplo" => "Daniel Ramos",
        "szinkron" => "Ember Márk",
    ],
    "Stockholm" => [
        "varos" => "Stockholm",
        "szinesz" => "Esther Acebo",
        "szereplo" => "Mónica Gaztambide",
        "szinkron" => "Lovas Rozi",
    ],
];
echo "2. feladat:\n";
echo "Színész \tSzereplő\tSzinkron\n";
foreach($foszereplok as $varos)
{
    echo $varos["szinesz"] . "\t" . $varos["szereplo"] . "\t" . $varos["szinkron"] . "\n";
};
echo "3. feladat:\n";
$_3varos = $argv[1];
foreach($foszereplok as $varos)
{
    if ($varos["varos"] == $_3varos)
    {
        echo "Szinész:\t" . $varos["szinesz"] . "\n";
        echo "Szereplő:\t" . $varos["szereplo"] . "\n";
        echo "Szinkron:\t" . $varos["szinkron"];
    }
};
echo "\n4. feladat:\n";
$_4varos = $argv[1];
$foglalkozas = $argv[2];
foreach($foszereplok as $varos)
{
    if ($varos["varos"] == $_4varos)
    {
        if ($foglalkozas == "Szinész")
        {
            echo "Szinész:\t" . $varos["szinesz"];
        }
        else if ($foglalkozas == "Szereplő")
        {
            echo "Szereplő:\t" . $varos["szereplo"];
        }
        else if ($foglalkozas == "Szinkron")
        {
            echo "Szinkron:\t" . $varos["szinkron"];
        }
    }
}