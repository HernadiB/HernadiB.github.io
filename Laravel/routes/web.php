<?php
use Illuminate\Support\Facades\Route;
use App\Models\Hetnapja;
use App\Models\Szamologep;
use App\Models\Szereplok;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
return view('index');
});
Route::get('/doctor-house', function () {
    return "Nemcsak az emberek megalázásával lehet a gőzt kiereszteni; mondják,
    hogy a bowling jobb még ennél is.";
});
Route::get('/uvegtigris/csoki', function () {
    return "Mennyire vagy túsz? Sörhöz odaférsz?";
});
Route::get('/uvegtigris/{name}', function ($name) {
    return "Az egybubis az egy kicsit drágább, mert hát abból ki kellett vennem
    a többi bubit. Hello $name";
});
Route::get('/modern-family', function () {
    return "A siker mindig 1 százalék ihlet, plusz 98 százalék verejték, végül
    pedig 2 százalék odafigyelés.";
})->name('modern-family');
Route::get('/harry-potter/fred-es-george', function () {
    return "Mindig is tudtuk hol a határ - bólintott Fred
    - És csak óvatosan léptük át - tette hozzá George.";
})->name('harry-potter.fred-es-george');
Route::get('/harry-potter/hermione', function () {
    return "Még egy ilyen remek ötlet, és mindhárman meghalunk, vagy akár ki
    is csaphatnak!";
})->name('harry-potter.hermione');
function format(DateTime $date){
    return $date->format("Y-m-d");
}
Route::get('/naptar/ma', function () {
    $today = new DateTime();
    return format($today);
});
Route::get('/naptar/holnap', function () {
    $tomorrow = new DateTime();
    $tomorrow->add(new DateInterval('P1D'));
    return format($tomorrow);
});
Route::get('/naptar/tegnap', function () {
    $tomorrow = new DateTime();
    $tomorrow->sub(new DateInterval('P1D'));
    return format($tomorrow);
});
Route::get('hetnapja/{value}', function($value){
    return Hetnapja::convert($value);
});
Route::get('szamologep/{a}+{b}', function($a, $b){
    return Szamologep::osszead($a, $b);
});
Route::get('szamologep/{a}-{b}', function($a, $b){
    return Szamologep::kivon($a, $b);
});
Route::get('szamologep/{a}*{b}', function($a, $b){
    return Szamologep::szoroz($a, $b);
});
Route::get('szamologep/{a}/{b}', function($a, $b){
    return Szamologep::oszt($a, $b);
});
Route::get('szereplok', function(){
    return view('fooldal');
});
Route::get('szereplok/{csalad}', function($csalad){
    return view ('csalad', [
        'csalad' => Szereplok::findCsalad($csalad)
    ]);
});
Route::get('szereplok/{csalad}/{szereplo}', function($csalad, $szereplo){
    return view ('szereplo', [
        'szereplo' => Szereplok::find($csalad, $szereplo),
        // 'image' => Szereplok::findImage($csalad, $szereplo)
        'csalad' => $csalad,
        'csaladtag' => $szereplo
    ]);
});
// Route::get("/horse",[\App\Http\Controllers\HorseController::class, "index"])->name("home");
Route::get("/horse/list",[\App\Http\Controllers\HorseController::class, "list"])->name("horse.list");
Route::get("/horse/table",[\App\Http\Controllers\HorseController::class, "table"])->name("horse.table");
Route::get("/horse/grid",[\App\Http\Controllers\HorseController::class, "grid"])->name("horse.grid");

Route::get("/hangszer/{mode?}",[\App\Http\Controllers\HangszerController::class, "index"])->name("home");
Route::get("/hangszer/{mode?}",[\App\Http\Controllers\HangszerController::class, "index"])->name("homehangszerek");
Route::get("/show/{id}",[\App\Http\Controllers\HangszerController::class, "show"])->name("hangszer.show");