<?php
mb_internal_encoding("UTF-8");
$pp = [
    "sziporka" => "Blossom",
    "puszedli" => "Bubbles",
    "csuporka" => "Buttercup",
    "pukkancs" => "Bliss",
    "nyuszi" => "Bunny"
];
echo "Pindúr Pandúrok (The Powerpuff Girls)\n";
$szoveg = $argv[1];
$szereplok = (explode(":", mb_strtolower($szoveg)));
foreach ($szereplok as $szereplo)
{
    foreach ($pp as $magyar => $angol)
    {
        if($szereplo == $magyar)
        {
            echo $angol . "\n";
        }
    }
}