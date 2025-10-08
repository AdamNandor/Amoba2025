Amőba játék – Felhasználói dokumentáció
=======================================

Felhasználói dokumentáció

Indítás

A program elindításakor megjelenik egy egyszerű menü:

Új játék (1-es gomb)
Kilépés (2-es gomb)

- Írd be az 1-et az új játék indításához.
- Írd be a 2-t a kilépéshez.

---

Játékszabályok

- A játékot két játékos játssza felváltva.
- A cél: 5 azonos jel (x vagy y) egymás mellett elhelyezése vízszintesen, függőlegesen vagy átlósan.
- A tábla mérete: 10 sor × 10 oszlop.

---

Lépés menete

1. A program kiírja, hogy melyik játékos következik (x vagy y).
2. A játékos megadja a kívánt mező oszlopát (x) és sorát (y):
   Példa:
   Koordináta (x): 3
   Koordináta (y): 5

   Ez a lépés az 5. sor, 3. oszlop mezőre helyezi a bábut.

3. Ha a mező már foglalt, a program figyelmeztet, és új lépést kér.

---

Nyerés és játék vége

- A játék automatikusan ellenőrzi minden lépés után, hogy van-e 5 azonos jel egymás mellett.
- Ha valamelyik játékos nyer:
  nyert:  x  vagy nyert:  y

- Ezután a program megkérdezi:
  új játék (i/n)

  - i – új játék kezdése
  - n – kilépés

---

Döntetlen

- Ha betelik a tábla és senki sem nyer:
  Nincs több hely! Itt a vége!
  Szeretne újat? (i/n)

---

Hibakezelés

- Ha nem számot írsz be vagy hibás koordinátát adsz meg, a program hibaüzenetet jelenít meg.
- A hiba után lehetőséget kapsz megtekinteni a részletes hibaüzenetet:
  hiba történt!
  Szeretné látni a hibát? (i/n)

---



Színek

- x: zöld színnel jelenik meg
- y: piros színnel jelenik meg

---



fejlesztői dokumentáció

program:
  nev: Amőba konzolos játék
  nyelv: C#
  leiras: >
    Kétjátékos amőba játék konzolban. A játékosok felváltva rakják le a saját bábujukat (x vagy y)
    egy 10x10-es táblán. Az nyer, aki elsőként ötöt rak egymás mellé vízszintesen, függőlegesen vagy átlósan.

adatkezeles:
  tabla: 10x10-es 2D tömb, mezők: " x ", " y " vagy üres ("   ")
  valtozok:
    - x_y_lep: következő játékos váltása
    - nyert: győztes állapot tárolása
    - ellenor: aktuálisan ellenőrzött sor karakterei
    - uj_jatek: új játék indításának jelzése

teszteles:
  modszerek:
    - Kezi jatek: játékosként tesztelve a funkciókat (lépés, nyerés, döntetlen)
    - Hibas inputok: pl. foglalt mezőre lépés, nem szám bevitel
  tesztek:
    - Vizszintes 5 bábu: OK
    - Függőleges 5 bábu: OK
    - Átlós (mindkét irány): OK
    - Döntetlen: OK
    - Foglalt mezőre lépés: megfelelő figyelmeztetés
    - Hibás input (pl. betű): hiba kezelve

fejlesztesi_otletek:
  - ellenor változó minden ellenőrzés előtt legyen nullázva
  - ellenőrzéseket külön függvényekbe szervezni
  - számbevitel TryParse-szal történjen, ne dobjon hibát

