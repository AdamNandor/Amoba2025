Amőba játék – Felhasználói dokumentáció
=======================================

Áttekintés
----------
Ez a program egy **10×10-es táblán játszható kétszemélyes Amőba (ötödölő)** játék.  
A cél, hogy az egyik játékos 5 azonos jelet (**X** vagy **Y**) rakjon egymás mellé vízszintesen, függőlegesen vagy átlósan.  

A program konzolos felületen fut, és felváltva kéri a játékosok lépéseit koordináták megadásával.

Indítás
-------
A játék a `Program.cs` fájl futtatásával indítható (például Visual Studio-ban, vagy a parancssorban `dotnet run` paranccsal).

Játékmenet
----------
1. A program indítás után inicializálja a 10×10-es táblát.  
   - Az üres mezőket három szóköz (`"   "`) jelöli.
   - Az **X** játékos zöld színnel, az **Y** játékos piros színnel jelenik meg a táblán.

2. A tábla kirajzolása után a program kiírja, hogy **melyik játékos következik**:  
   - "X következik" → az első játékos lép  
   - "Y következik" → a második játékos lép  

3. A játékosoknak meg kell adniuk a lépésük **x** és **y koordinátáját**:  
   - `Koordináta (x):` → az oszlop száma (1–10)  
   - `Koordináta (y):` → a sor száma (1–10)  

4. A program ellenőrzi, hogy a választott mező **szabad-e**.  
   - Ha igen → a bábu (X vagy Y) bekerül a táblára.  
   - Ha nem → hibaüzenet jelenik meg: *„ide már nem lehet tenni!”*, majd újra kér egy érvényes lépést.  

5. Minden lépés után a program **ellenőrzi a győzelmi feltételt**:  
   - 5 egymás melletti azonos jel vízszintesen, függőlegesen vagy átlósan.  
   - Ha valamelyik játékos nyer, a program törli a képernyőt, majd kiírja:  
     - `nyert:  x` vagy  
     - `nyert:  y`  
     Ezután a játék leáll.

6. Ha a bemeneti érték hibás (például betűt írsz szám helyett), a program hibaüzenetet ad:  
   - *„hiba történt!”*  
   - Ezután megkérdezi: *„Szeretné látni a hibát? (i/n)”*  
     - Ha `i` → részletes hibainformáció megjelenik  
     - Ha `n` → csak folytatódik a játék  

Billentyűzet használat
----------------------
- **Számok (1–10)**: koordináták megadására  
- **Enter**: lépés megerősítése  
- **Enter hibánál**: továbblépés újra próbálkozáshoz  

Játék vége
----------
A játék addig tart, amíg valamelyik játékos el nem ér 5 egymás melletti bábut.  
Döntetlen állapot nincs kezelve, a játék végtelenül folytatódik, ha senki sem nyer.

Példa játékmenet
----------------

+---+---+---+---+---+---+---+---+---+---
|   |   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+---
...
X következik
Koordináta (x):
3
Koordináta (y):
5

Ezután az **X** bábu a (3,5) mezőre kerül.

Tippek
------
- Mindig ügyelj arra, hogy a koordinátákat **1 és 10 közötti számmal** add meg.  
- Ha véletlenül rossz helyre raksz, azt már nem lehet javítani.  
- Figyeld a színezést: **zöld az X**, **piros az Y**.
"""
