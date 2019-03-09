float num = 30;string numeroum =  "split" ;while (true) {
    if (bc.lightness((1-1)) > num && bc.lightness((2-1)) > num) {
    bc.onTF(30f, 30f);


}if (bc.lightness((1-1)) < num && bc.lightness((2-1)) < num) {
    bc.onTF(0f, 0f);

bc.onTF(2f, 2f);

if (bc.lightness((1-1)) < num && bc.lightness((2-1)) > num) {
    bc.onTF(-(2*10), (2*10));



bc.wait(10);


}if (bc.lightness((1-1)) > num && bc.lightness((2-1)) < num) {
    bc.onTF((2*10), -(2*10));

bc.wait(10);


}
}if (bc.lightness((1-1)) < num && bc.lightness((2-1)) > num) {
    bc.onTF(-(15*10), (15*10));



bc.wait(10);


}if (bc.lightness((1-1)) > num && bc.lightness((2-1)) < num) {
    bc.onTF((15*10), -(15*10));

bc.wait(10);


}if (bc.returnColor((2-1), 0.55f) ==  "VERDE" ) {
    bc.onTF(-(15*10), (15*10));



bc.wait(10);


}if (bc.returnColor((1-1), 0.55f) ==  "VERDE" ) {
    bc.onTF((15*10), -(15*10));

bc.wait(10);


}bc.printLCD(bc.lightness((1-1)).ToString() + " | " + bc.lightness((2-1)).ToString() + " | " + bc.returnColor((1-1), 0.55f) + " | " + bc.returnColor((2-1), 0.55f));

bc.printLCD(bc.distance((1 - 1)).ToString());


}