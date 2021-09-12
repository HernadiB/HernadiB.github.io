<?php
$utazasok = [
    "London" => [
        "First" => [
            "A8" => [
                "ulohely" => "A8",
                "nev" => "Dexter Howells",
                "szulido" => "1992-05-24",
            ],
            "A10" => [
                "ulohely" => "A10",
                "nev" => "Salim Greer",
                "szulido" => "1978-01-12",
            ],
        ],
        "Tourist" => [
            "F18" => [
                "ulohely" => "F18",
                "nev" => "Rebekah Bennett",
                "szulido" => "1996-04-12",
            ],
            "E18" => [
                "ulohely" => "E18",
                "nev" => "Colette Silva",
                "szulido" => "1997-02-07",
            ],
            "B20" => [
                "ulohely" => "B20",
                "nev" => "Alexandros Casey",
                "szulido" => "1963-08-31",
            ],
        ],
    ],
    "New York" => [
        "Business" => [
            "F3" => [
                "ulohely" => "F3",
                "nev" => "Jamaal Neal",
                "szulido" => "1943-11-23",
            ],
        ],
    ],
];
echo "1. feladat: \n";
foreach ($utazasok["London"] as $osztaly)
{
    foreach($osztaly as $ulohely)
    {
        echo $ulohely["ulohely"] . ":" . "\t" . $ulohely["nev"] . "\n";
    }
}
echo "2. feladat: \n";
foreach ($utazasok["New York"]["Business"] as $ulohely)
{
    if ($ulohely["ulohely"] == "F3")
    {
        echo $ulohely["nev"] . " ült az F3 ülésen";
    }
}
echo "\n3. feladat: \n";
echo count($utazasok["London"]["First"]) . " ember utazott Londonba első osztályon";
echo "\n4. feladat: \n";
$osszeg = 0;
foreach ($utazasok as $varos)
{
    foreach ($varos as $osztaly)
    {
        $osszeg += count($osztaly);
    }
}
$dollar = 296;
echo $osszeg*$dollar*100 . " ft bevételük van";
echo "\n5. feladat: \n";
$szamlalo = 0;
foreach ($utazasok as $varos)
{
    foreach ($varos as $osztaly)
    {
        foreach ($osztaly as $ulohely)
        {
            if (intval(substr($ulohely["szulido"], 0, 4)) > 1981)
            {
                $szamlalo += 1;
            }
        }
    }
}
echo $osszeg*$dollar*100-$szamlalo*$dollar*100*0.1 . " ft bevételük lenne";
echo "\n6. feladat: \n";
$szamlalo2 = 0;
foreach ($utazasok as $varos)
{
    foreach ($varos as $osztaly)
    {
        foreach ($osztaly as $ulohely)
        {
            if (substr($ulohely["ulohely"], 0, 1) == "A")
            {
                $szamlalo2 += 1;
            }
        }
    }
}
echo $szamlalo2 . " ember választotta az A ülést";