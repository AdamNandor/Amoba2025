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

   Ez a lépés az 3. sor, 5. oszlop mezőre helyezi a bábut.

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

