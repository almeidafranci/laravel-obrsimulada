using UnityEngine;using System.Collections;using System.Collections.Generic;using System.Threading;using System.IO;using System;using Bot;namespace RuntimeCSharpCompiler{public class TestLoadScript : MonoBehaviour {private GameObject robo;private BotController bc;private string nome;Thread t1;void Start(){nome = GameObject.Find("Robos").GetComponent<EscolherModelo>().nome;robo = GameObject.Find(nome);bc = robo.GetComponent<BotController>();bc.running = true;t1 = new Thread(() => {
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
}); t1.Start(); } private void killTheThread() { if (bc.running == false) { t1.Abort(); bc.onTF(0.0f, 0.0f); Destroy(this); }}void Update(){ killTheThread(); } } }