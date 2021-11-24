<?php
namespace App\Http\Controllers;
class HangszerController extends Controller
{
    public function index($mode = null)
    {
        if($mode == null)
        {
            return view("hangszer.index",[
                "tomb" => $this->loadData()
            ]);
        }
        if ($mode == "cards")
        {
            return view("hangszer.cards",[
                "tomb" => $this->loadData()
            ]); 
        }
    }
    public function show($id)
    {
        return view("hangszer.show",[
            "tomb" => $this->loadData(),
            "hangszerId" => $id
        ]);
    }
    private function loadData()
    {
        $adatok = json_decode(file_get_contents("hangszerek.json"),true);
        return $adatok;
    }
}