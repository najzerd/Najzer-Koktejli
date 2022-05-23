# Najžer-RST-MAG-RNSUV-Projektna

Projektna naloga simulira API za naročevanje koktejlov v baru. Stranka koktejl naroči preko terminala/tablice, ki je dodeljen njeni mizi.

Za demonstracijo dodatnih funkcionalnosti, smo API zasnovali v manager pogledu, torej poleg osnevne funkcionalnosti pregleda in naročanja koktejlov, ter pregleda vseh naročil za mizo, manager lahko še dodaja, odstranjuje in ureja koktejle, ter počisti vsa naročila za mizo (ko je miza plačala in se sprosti).

Koktejli in naročila so shranjena v različnih tabelah znotraj iste podatkovne baze. V primeru da manager spremeni ceno koktejla, po tem ko ga je stranka že naročila (primer: happy hour), cena na računu ostane nespremenjena za že naročeni koktejl, novi se pa obračunajo po aktualni ceni.

V primeru da bi API želeli v celoti implementirati, bi bilo potrebno še dodati/urediti:<br />
-Ločene poglede (omejitve dostopa) za stranke in natakarje.<br />
-Identikator (Id) za specifične mize.<br />
-Avtentikacijo za managerje.<br />
-Potencialno tudi: podporo za plačilo s kreditno kartico in tiskanje računa.<br />
