# Najžer-RST-MAG-RNSUV-Projektna

Projektna naloga simulira API za naročevanje koktejlov v baru. Stranka koktejl naroči preko terminala/tablice, ki je dodeljen njeni mizi.

Za demonstracijo dodatnih funkcionalnosti, smo API zasnovali v manager pogledu, torej poleg osnevne funkcionalnosti pregleda in naročanja koktejlov, ter pregleda vseh naročil za mizo, manager lahko še dodaja, odstranjuje in ureja koktejle, ter počisti vsa naročila za mizo (ko je miza plačala in se sprosti). Slike koktejlov so za primer projektne naloge shranjene znotraj mape "img" v "wwwroot", ter so poimenovane ime_koktejla.jpg.

Koktejli in naročila so shranjena v različnih tabelah znotraj iste podatkovne baze. V primeru da manager spremeni ceno koktejla, po tem ko ga je stranka že naročila (primer: happy hour), cena na računu ostane nespremenjena za že naročeni koktejl, novi se pa obračunajo po aktualni ceni.

Dopolnjeno:<br />
-Ločeni pogledi v top meniju za Customer, Cocktail Manager in Bartender<br />
-Customer lahko samo naroča koktejle<br />
-Cocktail Manager lahko dodaja, briše in ureja koktejle, ne more pa jih naročati<br />
-Bartender ima pregled nad naročili za mizo, ko plačajo, lahko počisti vsa naročila za mizo<br />
-Slike se dodajajo iz mape wwwroot/img ter se dinamično izpišejo v dropdownu za managerja (vse slike s katerimi razpolagamo je podrebno dodati v to mapo)<br />

V primeru da bi API želeli v celoti implementirati, bi bilo potrebno še dodati/urediti:<br />
-Ločene poglede (omejitve dostopa) za stranke in natakarje.<br />
-Identikator (Id) za specifične mize.<br />
-Avtentikacijo za managerje.<br />
-Potencialno tudi: podporo za plačilo s kreditno kartico in tiskanje računa.<br />
