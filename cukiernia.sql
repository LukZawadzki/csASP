BEGIN;

INSERT INTO klienci (idklienta, nazwa, ulica, miejscowosc, kod, telefon) VALUES (1,"Hłasko Regina","Edwarda Bera 5","Elbląg","91-001","111 222 111
"),(2,"Pikowski Stefan","Wolna 3","Kraków","92-111","012 111 11 11
"),(3,"Czarnkowska Dalia","Wolska 89","Iława","11-373","111 222 001
"),(4,"Wandziak Wojciech","Gregorowa 3","Warszawa","10-001","111 222 002
"),(7,"Wojak Alicja","Beringa 89","Wrocław","70-764","111 222 003
"),(8,"Górka Andrzej","Stefanowska 35","Gdańsk","11-788","111 222 004
"),(10,"Moniak Antoni","Młyńska 34","Kraków","91-001","012 222 22 00
"),(11,"Sokół Robert","Akacjowa 3","Kraków","92-111","012 111 11 00
"),(12,"Witak Nina","Kasztanowa 23","Warszawa","11-373","022 888 88 00
"),(13,"Walendziak Jarosław","Krucza 12","Warszawa","10-001","022 888 88 01
"),(14,"Piotrowska Regina","Rzeczna 44","Borki","74-013","123 456 002
"),(15,"Miszak Stefan","Boczna 23/91","Pomiechówek","70-764","123 456 003
"),(16,"Sowa Dalia","Krucza 12/43","Warszawa","11-788","123 456 004
"),(18,"Wolski Wojciech","Edwarda Bera 5","Lubinek","91-001","123 456 005
"),(19,"Wojak Mirosław","Akacjowa 3","Borki","92-111","777 001 001
"),(21,"Górka Alicja","Wolna12/89","Katowice","11-373","777 001 002
"),(22,"Moński Andrzej","Towarowa 3","Kraków","10-001","777 001 003
"),(24,"Sokół Antoni","Prosta 345","Siedlce","74-013","777 001 004
"),(25,"Heroński Robert","Barstefska 89","Gdańsk","70-764","777 001 005
"),(26,"Walendziak Tomasz","Rzeczna 4","Płock","91-001","777 001 006
"),(27,"Piotrowski Jaroslaw","Młyńska 34","Borki","92-111","777 001 007
"),(28,"Miszak Helena","Akacjowa 3","Kraków","11-373","012 555 00 11
"),(29,"Sowa Rafał","Kasztanowa 23","Siedlce","10-001","333 000 100
"),(30,"Wolska Regina","Krucza 12","Gdańsk","74-013","333 000 101
"),(31,"Fisiak Stefan","Rzeczna 44","Pomiechówek","70-764","333 000 102
"),(33,"Wojak Dalia","Boczna 23/91","Kraków","91-001","333 000 103
"),(34,"Górka Wojciech","Krucza 12/43","Siedlce","92-111","333 000 104
"),(35,"Moniak Mirosław","Trakt 10","Gdańsk","11-373","333 000 105
"),(37,"Sokół Alicja","Akacjowa 12/89","Borki","10-001","333 000 106
"),(38,"Helkowski Andrzej","Edwarda Bera 5","Katowice","74-013","333 000 107
"),(39,"Walendziak Antoni","Akacjowa 3","Kraków","70-764","012 111 11 55
"),(40,"Piotrowska Regina","Wolna12/89","Siedlce","11-788","787 345 012
"),(42,"Wojak Stefan","Towarowa 3","Gdańsk","79-408","787 345 013
"),(43,"Górka Dalia","Prosta 345","Dołowe","19-047","787 345 014
"),(44,"Moniak Wojciech","Beringa 89","Pomiechówek","91-001","787 345 015
"),(46,"Sokół Miroslaw","Rzeczna 4","Borki","92-111","787 345 016
"),(47,"Hern Alicja","Młyńska 34","Doły","11-373","787 345 017
"),(48,"Walendziak Andrzej","Akacjowa 3","Kraków","10-001","787 345 018
"),(49,"Piotrowski Antoni","Kasztanowa 23","Kownik","74-013","232 777 900
"),(50,"Miszak Robert","Krucza 12","Katowice","70-764","232 777 901
"),(51,"Sowa Tomasz","Edwarda Bera 5","Siedlce","11-788","232 777 902
"),(52,"Wolski Jarosław","Akacjowa 3","Sopot","91-001","232 777 903
"),(53,"Fisiak Helena","Wolna12/89","Pomiechówek","92-111","232 777 904
"),(54,"Fisiak Regina","Towarowa 3","Kraków","11-373","232 777 905
"),(55,"Wojak Stefan","Prosta 345","Siedlce","10-001","232 777 906
"),(56,"Górka Dalia","Beringa 89","Gdańsk","74-013","232 777 907
"),(57,"Moniak Wojciech","Rzeczna 4","Pomiechówek","70-764","232 777 908
"),(58,"Sokół Mirosław","Młyńska 34","Pomiechówek","11-788","232 777 909
"),(59,"Herron Alicja","Akacjowa 3","Wicie","79-408","564 345 303
"),(62,"Walendziak Andrzej","Kasztanowa 23","Siedlce","91-001","564 345 304
"),(63,"Piotrowski Antoni","Krucza 12","Kraków","92-111","012 334 44 56
"),(64,"Wojak Robert","Rzeczna 44","Siedlce","11-373","564 345 305
"),(66,"Górka Tomasz","Boczna 23/91","Gdańsk","10-001","564 345 306
"),(67,"Moniak Jarosław","Edwarda Bera 5","Michów","74-013","564 345 307
"),(68,"Witak Nina","Akacjowa 3","Siedlce","70-764","564 345 308
"),(69,"Herron Stefan","Wolna 12/89","Gdańsk","11-788","564 345 309
"),(70,"Walendziak Dalia","Towarowa 3","Tarnów","79-408","564 345 312
"),(71,"Piotrowski Wojciech","Prosta 345","Kraków","19-047","012 334 44 57
"),(73,"Miszak Mirosław","Beringa 89","Płock","81-230","746 006 020
"),(74,"Sowa Alicja","Rzeczna 4","Siedlce","91-001","746 006 021
"),(76,"Wolski Andrzej","Młyńska 34","Sokółka","92-111","746 006 022
"),(79,"Fisiak Antoni","Akacjowa 3","Konstancin","11-373","746 006 023
"),(80,"Wyga Robert","Kasztanowa 23","Płock","10-001","746 006 024
"),(82,"Fisiak Tomasz","Krucza 12","Katowice","74-013","746 006 025
"),(84,"Wojak Jarosław","Rzeczna 44","Ludwiki","70-764","746 006 026
"),(85,"Górka Helena","Boczna 23/91","Regina","11-788","746 006 027
"),(86,"Moniak Rafał","Krucza 12/43","Kraków","79-408","012 334 44 58
");
INSERT INTO zamowienia (idzamowienia, idklienta, datarealizacji) VALUES (1,2,"2013-10-30
"),(3,57,"2013-10-30
"),(4,58,"2013-10-31
"),(5,12,"2013-10-31
"),(6,1,"2013-11-02
"),(7,33,"2013-11-02
"),(8,4,"2013-11-02
"),(9,86,"2013-11-05
"),(10,54,"2013-11-06
"),(11,11,"2013-11-07
"),(12,4,"2013-11-08
"),(13,53,"2013-11-09
"),(14,59,"2013-11-09
"),(15,62,"2013-11-12
"),(16,12,"2013-11-12
"),(17,86,"2013-11-12
"),(18,4,"2013-11-12
"),(19,38,"2013-11-12
"),(20,71,"2013-11-13
"),(22,73,"2013-11-14
"),(23,2,"2013-11-15
"),(24,63,"2013-11-16
"),(25,64,"2013-11-16
"),(26,4,"2013-11-17
"),(27,86,"2013-11-17
"),(28,54,"2013-11-17
"),(29,74,"2013-11-18
"),(30,76,"2013-11-19
"),(31,3,"2013-11-19
"),(32,54,"2013-11-20
"),(33,43,"2013-11-21
"),(34,44,"2013-11-22
"),(35,46,"2013-11-23
"),(36,12,"2013-11-24
"),(37,26,"2013-11-24
"),(38,31,"2013-11-25
"),(39,26,"2013-11-25
"),(40,55,"2013-11-25
"),(41,86,"2013-11-26
"),(42,7,"2013-11-26
"),(43,40,"2013-11-26
"),(44,82,"2013-11-27
"),(45,28,"2013-11-27
"),(46,29,"2013-11-27
"),(47,30,"2013-11-27
"),(49,3,"2013-12-05
"),(50,28,"2013-12-05
"),(51,2,"2013-12-06
"),(52,26,"2013-12-06
"),(53,39,"2013-12-06
"),(54,73,"2013-12-06
"),(55,54,"2013-12-06
"),(56,35,"2013-12-06
"),(57,2,"2013-12-06
"),(58,79,"2013-12-07
"),(59,80,"2013-12-07
"),(60,82,"2013-12-07
"),(61,66,"2013-12-07
"),(62,67,"2013-12-07
"),(63,49,"2013-12-07
"),(64,82,"2013-12-07
"),(65,68,"2013-12-08
"),(66,69,"2013-12-08
"),(67,70,"2013-12-08
"),(68,63,"2013-12-08
"),(69,35,"2013-12-08
"),(70,49,"2013-12-08
"),(71,8,"2013-12-08
"),(72,10,"2013-12-09
"),(73,11,"2013-12-09
"),(74,12,"2013-12-09
"),(75,13,"2013-12-09
"),(76,11,"2013-12-09
"),(77,14,"2013-12-09
"),(78,21,"2013-12-09
"),(79,7,"2013-12-10
"),(80,28,"2013-12-10
"),(81,29,"2013-12-10
"),(82,30,"2013-12-10
"),(83,14,"2013-12-10
"),(84,15,"2013-12-10
"),(85,16,"2013-12-10
"),(86,18,"2013-12-11
"),(87,73,"2013-12-11
"),(88,14,"2013-12-11
"),(89,15,"2013-12-11
"),(90,16,"2013-12-11
"),(91,18,"2013-12-11
"),(92,19,"2013-12-11
"),(93,21,"2013-12-12
"),(94,22,"2013-12-12
"),(95,24,"2013-12-12
"),(96,49,"2013-12-12
"),(97,3,"2013-12-12
"),(98,25,"2013-12-12
"),(99,26,"2013-12-12
"),(100,27,"2013-12-13
"),(101,4,"2013-12-13
"),(102,28,"2013-12-13
"),(103,29,"2013-12-13
"),(104,30,"2013-12-13
"),(105,31,"2013-12-13
"),(106,53,"2013-12-13
"),(107,84,"2013-12-14
"),(108,79,"2013-12-14
"),(109,33,"2013-12-14
"),(110,34,"2013-12-14
"),(111,35,"2013-12-14
"),(112,56,"2013-12-14
"),(113,1,"2013-12-14
"),(114,1,"2013-12-15
"),(115,37,"2013-12-15
"),(116,38,"2013-12-15
"),(117,39,"2013-12-15
"),(118,40,"2013-12-15
"),(119,42,"2013-12-15
"),(120,43,"2013-12-15
"),(121,44,"2013-12-16
"),(122,63,"2013-12-16
"),(123,73,"2013-12-16
"),(124,28,"2013-12-16
"),(125,63,"2013-12-16
"),(126,44,"2013-12-16
"),(127,46,"2013-12-16
"),(128,47,"2013-12-17
"),(129,48,"2013-12-17
"),(130,49,"2013-12-17
"),(131,84,"2013-12-17
"),(132,85,"2013-12-17
"),(133,56,"2013-12-17
"),(134,79,"2013-12-17
"),(136,73,"2013-12-18
"),(137,73,"2013-12-18
"),(138,44,"2013-12-18
"),(139,11,"2013-12-18
"),(140,86,"2013-12-18
"),(141,4,"2013-12-18
"),(142,50,"2013-12-19
"),(143,51,"2013-12-19
"),(144,52,"2013-12-19
"),(145,16,"2013-12-19
"),(146,25,"2013-12-19
"),(147,53,"2013-12-19
"),(148,54,"2013-12-19
"),(149,55,"2013-12-20
");
INSERT INTO czekoladki (idczekoladki, nazwa, czekolada, orzechy, nadzienie, opis, koszt, masa) VALUES ("b01","Płomienna ekstaza","gorzka","łuskane","krem","Orzechy w kremie, zatopione w gorzkiej czekoladzie.",0.30,20
),("b02","Gorzka jagodowa","gorzka","","jagody","Smakowite górskie jagody w czekoladzie.",0.25,25
),("b03","Marcepanowe listki","gorzka","","marcepan","Marcepany w kształcie liści dębu oblewane gorzką czekoladą.",0.40,12
),("b04","Gorzka truskawkowa","gorzka","","truskawki","Truskawki w gorzkiej czekoladzie, wyśmienite.",0.23,20
),("b05","Gorzka malinowa","gorzka","","maliny","Maliny zrywane na bezludnych wyspach, w polewie czekoladowej.",0.25,20
),("b06","Gorzka z marmoladą","gorzka","","marmolada","Marmolada w polewie czekoladowej - prawdziwie brytyjski smakołyk.",0.17,25
),("b07","Gorzka z wiśniami","gorzka","","wiśnie","Ulubione wiśnie królowej Anny zatopione w czekoladzie.",0.26,25
),("b08","Gorzkie orzechy","gorzka","laskowe","","Orzechy laskowe w czekoladzie.",0.24,20
),("d01","Migdałowy smak","ciemna","migdały","","Całe migdały, ręcznie topione w czekoladzie.",0.30,15
),("d02","Serce na dłoni","ciemna","","krem wiśniowy","Ciemna czekolada o sercu z kremu wiśniowego.",0.32,25
),("d03","Potęga orzechów","ciemna","łuskane","","Ogromne orzechy ręcznie umieszczane w czekoladzie.",0.30,15
),("d04","Migdalowa ambrozja","ciemna","migdały","amaretto","Migdały zatapiane w amaretto.",0.44,25
),("d06","Smak orzechow laskowych","ciemna","laskowe","","Całe orzechy laskowe, ręcznie topione w czekoladzie.",0.21,10
),("d07","Wiśniowa klasyczna","ciemna","","wiśnie","Wiśnie w czekoladzie.",0.28,24
),("d08","Czekoladowe kiwi","ciemna","brazylijskie","","Orzechy brazylijskie na czekoladzie tworzące wspaniałą kompozycję wzorowana na owocu kiwi.",0.29,30
),("d09","Amerykańska piekność","ciemna","","","Twarda czekolada w kształcie amerykanskich piękności.",0.24,30
),("d11","Marcepanowe delicje","ciemna","","marcepan","Smakowity marcepan w gorzkiej czekoladzie.",0.38,30
),("f01","Twarda kremowa włoska","twarda","włoskie","krem","Słodziutki krem z orzechami włoskimi.",0.19,25
),("f02","Twarda kremowa pistacjowa","twarda","pistacjowe","krem","Słodziutki krem z orzechami pistacjowymi.",0.21,25
),("m01","Słodkie truskawki","mleczna","","truskawki","Truskawki oblewane mleczną czekoladą.",0.20,25
),("m02","Smak macadamia","mleczna","macadamia","","Całe macadamia, ręcznie umieszczane w mlecznej czekoladzie.",0.40,20
),("m03","Smak pistacji","mleczna","Pistacjowe","","Całe pistacjowe orzechy, ręcznie umieszczane w mlecznej czekoladzie.",0.30,12
),("m04","Rozkosz kremu orzechowego","mleczna","","krem orzechowy","Delikatny krem orzechowy robiony z senegalskich orzeszków w mlecznej czekoladzie.",0.21,12
),("m05","Marcepanki","mleczna","","marcepan","Marcepan oblewany mleczną czekoladą.",0.32,35
),("m06","Serce kochanka","mleczna","","krem wiśniowy","Czekoladki mleczne w kształcie serc z nadzieniem wiśniowym.",0.25,35
),("m07","Jabłkowe amory","mleczna","migdały","","Mleczne czekoladki w kształcie jabłuszek z listkami z migdałów.",0.24,25
),("m08","Marcepanowy klon","mleczna","","marcepan","Marcepan w kształcie listków klonu z mleczną czekoladą.",0.37,25
),("m09","Słodkie maliny","mleczna","","maliny","Maliny oblewane mleczną czekoladą.",0.26,15
),("m10","Niezapominajki","mleczna","","jagody","Niezapomniana mleczna czekolada nadziewana jagodami.",0.19,15
),("m11","Słodkie wiśnie","mleczna","","wiśnie","Wiśnie w polewie z mlecznej czekolady.",0.27,20
),("m12","Słodkie jagody","mleczna","","jagody","Jagody osładzane mleczną czekoladą.",0.25,20
),("m13","Słodka marmolada","mleczna","","marmolada","Mleczna czekolada z nadzieniem z pomarańczowej marmolady.",0.18,30
),("m14","Wiśnie z orzechami","mleczna","laskowe","krem wiśniowy","Świetne orzechy laskowe przykryte kremem wiśniowym i mleczną czekoladą.",0.26,30
),("m15","Tropikalna palma","mleczna","","kokosy","Palma z mlecznej czekolady z kokosami.",0.23,25
),("m16","Cud marcepanu","mleczna","","marcepan","Marcepan w kształcie migdałów z czekoladowym Mniam mniam.",0.33,25
),("m17","Amaretto z orzechali","mleczna","laskowe","amaretto","Orzechy laskowe z amaretto oblewane mleczną czekoladą.",0.36,25
),("m18","Orzechy w kremie","mleczna","laskowe","krem","Orzechy laskowe z kremem oblewane mleczną czekoladą.",0.33,20
),("w01","Marcepanowa jaskółka","biała","","marcepan","Marcepanowe jaskółki o skrzydłach z mlecznej czekolady.",0.34,20
),("w02","Biale lilie","biała","","","Elegancka biała czekolada formowana w kształcie lilii.",0.27,25
),("w03","Zlamane serce","biała","pekan","","Dwie połówki pekanowego serca z białej czekolady.",0.30,25
),("w06","Smak Brazylii","biała","brazylijskie","","Brazylijskie orzechy, ręcznie umieszczane w białej czekoladzie.",0.28,35
);
INSERT INTO pudelka (idpudelka, nazwa, opis, cena, stan) VALUES ("alls","Pory roku","Jagody, truskawki i maliny, wszystkie słodziutkie i smaczne.",14.00,700
),("alpi","Kolekcja alpejska","Alpejskie jagody i maliny w naszej najlepszej czekoladzie.",20.00,400
),("autu","Kolekcja jesienna","Rodzinne pudełko czekoladek, na jesienne wieczory.",43.00,200
),("bitt","Gorzkie czekoladki","Nasza gorzka czekolada z jagodami, wiśniami, marmoladą, malinami i truskawkami.",27.70,200
),("cher","Klasyczne wiśnie","Całe wiśnie w czekoladzie, klasyczne i słodkie.",16.20,500
),("fudg","Kremowa fantazja","Kolekcja czekoladek kremowych - jak senne marzenie.",18.00,400
),("heav","Niebiańskie orzechy","Najlepsze orzechy w orzechowych czekoladkach.",15.00,300
),("inte","Międzynarodowe","Międzynarodowy zestaw czekoladek zawierający czekoladki: Amerykańska piękność, Smak Brazylii i Czekoladowe kiwi.",34.00,500
),("isla","Islandzka kolekcja","Delikatesy które zabiorą Cię na bezludną wyspę, czekoladki: Czekoladowe kiwi, Białe lilie i Tropikalna palma.",35.00,400
),("love","Serca kochanków","Najlepsze czekoladki mleczne w sercowej kolekcji, takie jak: Złamane serce, Serce kochanka i Serce na dłoni.",17.50,300
),("marz","Marcepanowy cud","Świetny zestaw marcepanowych czekoladek.",32.20,500
),("nort","Kolekcja północna","Szczególna kolekcja czekoladek dla kochanków, takich jak: Marcepanowy klon, Marcepanowa jaskółka i  Niezapominajki.",32.20,700
),("paci","Obfitość Pacyfiku","Najwykwintniejszy zestaw czekoladek Pacyfiku: Białe lilie, Amaretto z orzechami i Orzechy w kremie.",21.00,500
),("pean","Kremowe delikatesy","Oblewana czekoladą masa kremowa, smakująca wszystkim.",19.00,900
),("roma","Kolekcja romantyczna","Nasz klasyczny i romantyczny wybór czekoladek: Migdałowa ambrozja, Płomienna ekstaza, Amerykańska piękność i Jabłkowe amory.",34.00,700
),("supr","Smaki","Smaki wybranych orzechów oblewanych czekoladą.",18.00,400
),("swe2","Słodkie kremowe","Smakowite kremy dla wszystkich którzy uwielbiają nadzienie kremowe.",23.00,200
),("swee","Mieszanka czekoladowa","Nasza najlepsza mieszanka owoców w czekoladzie.",27.00,300
);
INSERT INTO artykuly (idartykulu, idzamowienia, idpudelka, sztuk) VALUES (0, 1,"pean",2
),(1,3,"alpi",1
),(2,3,"love",2
),(3,3,"cher",2
),(4,3,"nort",1
),(5,4,"autu",1
),(6,4,"bitt",2
),(7,4,"paci",1
),(8,5,"autu",2
),(9,5,"bitt",2
),(10,5,"fudg",1
),(11,5,"isla",1
),(12,6,"bitt",1
),(13,6,"fudg",1
),(14,6,"heav",2
),(15,6,"nort",2
),(16,6,"pean",1
),(17,6,"swee",2
),(18,7,"pean",1
),(19,8,"fudg",1
),(20,8,"marz",2
),(21,9,"nort",2
),(22,9,"paci",1
),(23,10,"paci",1
),(24,10,"swee",2
),(25,11,"bitt",1
),(26,11,"heav",2
),(27,11,"pean",1
),(28,11,"supr",2
),(29,11,"swee",1
),(30,12,"alpi",2
),(31,12,"fudg",2
),(32,12,"roma",1
),(33,12,"swe2",1
),(34,12,"swee",1
),(35,13,"swee",2
),(36,14,"heav",1
),(37,14,"isla",1
),(38,15,"alpi",1
),(39,15,"roma",2
),(40,16,"isla",1
),(41,16,"roma",2
),(42,16,"supr",1
),(43,16,"swee",2
),(44,17,"love",1
),(45,17,"nort",1
),(46,17,"pean",2
),(47,17,"swee",1
),(48,18,"autu",2
),(49,18,"bitt",2
),(50,18,"cher",1
),(51,18,"heav",1
),(52,18,"paci",2
),(53,18,"roma",1
),(54,19,"fudg",1
),(55,20,"heav",1
),(56,22,"bitt",1
),(57,22,"inte",2
),(58,23,"fudg",1
),(59,23,"nort",1
),(60,23,"pean",1
),(61,23,"roma",2
),(62,23,"swee",1
),(63,24,"alpi",2
),(64,24,"autu",1
),(65,24,"bitt",1
),(66,24,"nort",2
),(67,25,"heav",1
),(68,26,"bitt",1
),(69,27,"cher",1
),(70,27,"nort",2
),(71,27,"swe2",1
),(72,28,"alpi",2
),(73,28,"heav",1
),(74,28,"pean",2
),(75,29,"alls",2
),(76,29,"bitt",1
),(77,29,"pean",1
),(78,29,"roma",1
),(79,29,"swee",2
),(80,30,"bitt",2
),(81,30,"supr",1
),(82,30,"swe2",1
),(83,30,"swee",2
),(84,31,"swee",2
),(85,32,"love",1
),(86,33,"cher",1
),(87,33,"fudg",1
),(88,33,"nort",2
),(89,33,"paci",2
),(90,34,"autu",1
),(91,34,"roma",1
),(92,34,"supr",2
),(93,34,"swee",1
),(94,35,"bitt",1
),(95,35,"fudg",2
),(96,35,"isla",2
),(97,35,"nort",1
),(98,35,"swee",1
),(99,36,"bitt",2
),(100,36,"cher",1
),(101,36,"fudg",2
),(102,36,"nort",2
),(103,36,"roma",1
),(104,36,"swee",1
),(105,37,"marz",1
),(106,38,"bitt",1
),(107,38,"swee",2
),(108,39,"nort",1
),(109,39,"roma",2
),(110,40,"bitt",2
),(111,40,"roma",1
),(112,40,"swee",2
),(113,41,"alpi",1
),(114,41,"heav",1
),(115,41,"paci",1
),(116,41,"swe2",2
),(117,41,"swee",2
),(118,42,"alpi",2
),(119,42,"fudg",1
),(120,42,"inte",2
),(121,42,"roma",1
),(122,42,"swe2",1
),(123,42,"swee",1
),(124,43,"alpi",1
),(125,44,"autu",1
),(126,44,"bitt",2
),(127,45,"alls",2
),(128,45,"cher",2
),(129,45,"fudg",1
),(130,46,"heav",1
),(131,46,"inte",2
),(132,46,"pean",1
),(133,46,"supr",1
),(134,47,"bitt",1
),(135,47,"cher",1
),(136,47,"love",2
),(137,47,"nort",2
),(138,47,"pean",1
),(139,47,"autu",1
),(140,47,"fudg",1
),(141,47,"isla",2
),(142,47,"paci",2
),(143,47,"roma",1
),(144,49,"fudg",2
),(145,50,"bitt",1
),(146,50,"isla",2
),(147,51,"heav",2
),(148,51,"nort",1
),(149,52,"cher",2
),(150,52,"heav",1
),(151,52,"pean",1
),(152,53,"bitt",2
),(153,53,"marz",2
),(154,53,"nort",2
),(155,53,"supr",1
),(156,53,"swee",1
),(157,54,"bitt",1
),(158,54,"fudg",1
),(159,54,"heav",2
),(160,54,"nort",2
),(161,54,"roma",1
),(162,54,"swee",1
),(163,55,"bitt",1
),(164,56,"fudg",1
),(165,56,"heav",2
),(166,57,"alpi",1
),(167,57,"swe2",1
),(168,57,"swee",2
),(169,58,"alpi",2
),(170,58,"inte",1
),(171,58,"roma",1
),(172,58,"swee",2
),(173,59,"alls",2
),(174,59,"nort",1
),(175,59,"roma",2
),(176,59,"swe2",1
),(177,59,"swee",1
),(178,60,"love",1
),(179,60,"pean",2
),(180,60,"roma",1
),(181,60,"supr",2
),(182,60,"swe2",1
),(183,60,"swee",1
),(184,61,"love",2
),(185,62,"alpi",1
),(186,62,"nort",2
),(187,63,"cher",1
),(188,63,"paci",1
),(189,63,"roma",2
),(190,64,"autu",2
),(191,64,"bitt",1
),(192,64,"fudg",1
),(193,64,"love",1
),(194,65,"autu",1
),(195,65,"fudg",2
),(196,65,"isla",2
),(197,65,"love",1
),(198,65,"nort",1
),(199,66,"bitt",2
),(200,66,"fudg",1
),(201,66,"love",2
),(202,66,"marz",2
),(203,66,"nort",1
),(204,66,"swee",1
),(205,67,"bitt",1
),(206,68,"nort",2
),(207,68,"swee",1
),(208,69,"fudg",1
),(209,69,"roma",1
),(210,69,"swee",2
),(211,70,"bitt",1
),(212,70,"cher",1
),(213,70,"heav",2
),(214,70,"isla",2
),(215,71,"bitt",1
),(216,71,"fudg",2
),(217,71,"love",1
),(218,71,"swe2",2
),(219,71,"swee",1
),(220,72,"alpi",1
),(221,72,"bitt",1
),(222,72,"heav",1
),(223,72,"nort",2
),(224,73,"bitt",2
),(225,74,"alls",1
),(226,74,"love",1
),(227,75,"inte",1
),(228,75,"roma",2
),(229,75,"supr",1
),(230,76,"alpi",2
),(231,76,"pean",2
),(232,76,"supr",1
),(233,76,"swee",1
),(234,77,"cher",2
),(235,77,"heav",1
),(236,77,"love",2
),(237,77,"nort",1
),(238,77,"paci",1
),(239,78,"alpi",2
),(240,78,"autu",2
),(241,78,"bitt",2
),(242,78,"fudg",1
),(243,78,"inte",1
),(244,78,"roma",1
),(245,79,"autu",1
),(246,80,"bitt",2
),(247,80,"isla",1
),(248,81,"inte",1
),(249,81,"isla",2
),(250,82,"bitt",2
),(251,82,"inte",1
),(252,82,"love",1
),(253,82,"marz",2
),(254,83,"cher",2
),(255,83,"inte",1
),(256,83,"isla",1
),(257,83,"love",1
),(258,83,"swee",1
),(259,84,"bitt",1
),(260,84,"cher",1
),(261,84,"heav",2
),(262,84,"love",2
),(263,84,"nort",2
),(264,84,"paci",1
),(265,85,"paci",1
),(266,86,"love",2
),(267,86,"nort",1
),(268,87,"alpi",2
),(269,87,"heav",1
),(270,87,"swe2",1
),(271,88,"bitt",1
),(272,88,"fudg",2
),(273,88,"heav",2
),(274,88,"inte",1
),(275,89,"alls",1
),(276,89,"bitt",1
),(277,89,"love",2
),(278,89,"nort",2
),(279,90,"cher",1
),(280,90,"heav",2
),(281,90,"isla",1
),(282,90,"love",1
),(283,90,"pean",2
),(284,90,"supr",1
),(285,91,"love",2
),(286,92,"cher",1
),(287,92,"nort",1
),(288,93,"nort",2
),(289,93,"paci",2
),(290,93,"roma",1
),(291,94,"alpi",1
),(292,94,"autu",2
),(293,94,"cher",1
),(294,94,"fudg",1
),(295,95,"isla",1
),(296,95,"nort",2
),(297,95,"paci",1
),(298,95,"pean",2
),(299,95,"swee",1
),(300,96,"alpi",2
),(301,96,"bitt",1
),(302,96,"cher",1
),(303,96,"love",2
),(304,96,"marz",1
),(305,96,"nort",2
),(306,97,"fudg",1
),(307,98,"bitt",2
),(308,98,"fudg",1
),(309,99,"love",1
),(310,99,"nort",2
),(311,100,"bitt",1
),(312,100,"heav",1
),(313,100,"supr",2
),(314,100,"swee",2
),(315,101,"alpi",2
),(316,101,"autu",1
),(317,101,"fudg",2
),(318,101,"nort",1
),(319,101,"swe2",1
),(320,102,"bitt",2
),(321,102,"fudg",2
),(322,102,"inte",1
),(323,102,"love",1
),(324,102,"roma",1
),(325,102,"swee",1
),(326,103,"pean",1
),(327,104,"alls",2
),(328,104,"bitt",1
),(329,105,"supr",1
),(330,105,"swe2",2
),(331,105,"swee",2
),(332,106,"love",1
),(333,106,"pean",1
),(334,106,"roma",1
),(335,106,"swe2",2
),(336,107,"cher",1
),(337,107,"nort",2
),(338,107,"paci",2
),(339,107,"roma",1
),(340,108,"autu",1
),(341,108,"bitt",1
),(342,108,"fudg",2
),(343,108,"inte",1
),(344,108,"love",1
),(345,108,"swee",2
),(346,109,"isla",2
),(347,110,"cher",1
),(348,110,"roma",2
),(349,111,"bitt",1
),(350,111,"paci",1
),(351,111,"swe2",2
),(352,112,"alpi",1
),(353,112,"fudg",1
),(354,112,"roma",2
),(355,112,"swe2",1
),(356,113,"love",1
),(357,113,"nort",2
),(358,113,"roma",2
),(359,113,"swe2",2
),(360,113,"swee",1
),(361,114,"alpi",2
),(362,114,"bitt",2
),(363,114,"heav",1
),(364,114,"love",1
),(365,114,"roma",1
),(366,115,"heav",1
),(367,116,"heav",2
),(368,116,"swe2",1
),(369,117,"alpi",2
),(370,117,"bitt",1
),(371,117,"love",1
),(372,118,"bitt",1
),(373,118,"inte",2
),(374,118,"love",2
),(375,118,"nort",1
),(376,119,"alls",2
),(377,119,"bitt",2
),(378,119,"heav",1
),(379,119,"nort",1
),(380,119,"supr",1
),(381,120,"heav",1
),(382,120,"love",2
),(383,120,"nort",1
),(384,120,"paci",1
),(385,120,"pean",1
),(386,120,"roma",2
),(387,121,"nort",2
),(388,122,"cher",1
),(389,122,"paci",2
),(390,123,"nort",2
),(391,123,"paci",1
),(392,123,"roma",1
),(393,124,"autu",1
),(394,124,"fudg",1
),(395,124,"heav",2
),(396,124,"isla",1
),(397,125,"autu",1
),(398,125,"bitt",1
),(399,125,"isla",2
),(400,125,"nort",2
),(401,125,"pean",1
),(402,126,"bitt",1
),(403,126,"love",1
),(404,126,"marz",2
),(405,126,"nort",2
),(406,126,"pean",1
),(407,126,"swee",2
),(408,127,"pean",1
),(409,128,"alpi",2
),(410,128,"swee",1
),(411,129,"bitt",2
),(412,129,"pean",1
),(413,129,"swee",1
),(414,130,"bitt",1
),(415,130,"heav",2
),(416,130,"roma",2
),(417,130,"swee",1
),(418,131,"alpi",1
),(419,131,"inte",2
),(420,131,"roma",1
),(421,131,"swe2",1
),(422,131,"swee",2
),(423,132,"alpi",2
),(424,132,"bitt",1
),(425,132,"fudg",2
),(426,132,"inte",1
),(427,132,"pean",1
),(428,133,"alls",2
),(429,134,"cher",1
),(430,134,"fudg",1
),(431,134,"nort",1
),(432,134,"supr",2
),(433,134,"love",2
),(434,134,"pean",2
),(435,137,"cher",1
),(436,137,"nort",2
),(437,137,"paci",1
),(438,137,"pean",1
),(439,137,"roma",2
),(440,138,"autu",2
),(441,138,"cher",1
),(442,138,"fudg",1
),(443,138,"inte",2
),(444,138,"isla",2
),(445,138,"nort",1
),(446,139,"fudg",1
),(447,140,"fudg",2
),(448,140,"nort",1
),(449,141,"autu",1
),(450,141,"bitt",2
),(451,142,"heav",1
),(452,142,"marz",2
),(453,142,"nort",2
),(454,143,"cher",1
),(455,143,"inte",1
),(456,143,"pean",1
),(457,143,"roma",1
),(458,143,"swee",2
),(459,144,"bitt",1
),(460,144,"heav",2
),(461,144,"inte",1
),(462,144,"roma",2
),(463,144,"swe2",2
),(464,144,"swee",1
),(465,145,"supr",1
),(466,146,"alpi",1
),(467,146,"swe2",2
),(468,147,"alpi",2
),(469,147,"fudg",1
),(470,147,"inte",1
),(471,148,"heav",1
),(472,148,"roma",2
),(473,148,"supr",2
),(474,148,"swe2",1
),(475,149,"alls",1
),(476,149,"love",2
),(477,149,"roma",2
),(478,149,"supr",1
),(479,149,"swe2",1
);
INSERT INTO zawartosc (idzawartosci, idpudelka, idczekoladki, sztuk) VALUES (0, "alls","b02",2
),(1,"alls","b04",2
),(2,"alls","b05",2
),(3,"alls","m01",2
),(4,"alls","m09",2
),(5,"alls","m12",2
),(6,"alpi","m12",4
),(7,"alpi","b04",5
),(8,"alpi","m01",5
),(9,"alpi","b02",4
),(10,"autu","m05",6
),(11,"autu","b03",6
),(12,"autu","w01",6
),(13,"autu","m08",6
),(14,"bitt","b07",4
),(15,"bitt","b04",5
),(16,"bitt","b05",5
),(17,"bitt","b06",5
),(18,"bitt","b02",5
),(19,"cher","b07",4
),(20,"cher","m11",4
),(21,"cher","d07",4
),(22,"fudg","f01",9
),(23,"fudg","b03",4
),(24,"fudg","f02",9
),(25,"fudg","b05",4
),(26,"fudg","b04",4
),(27,"heav","m14",2
),(28,"heav","d06",2
),(29,"heav","m16",3
),(30,"heav","b08",3
),(31,"heav","m15",2
),(32,"inte","d08",6
),(33,"inte","d09",6
),(34,"inte","w06",6
),(35,"inte","m05",6
),(36,"isla","m08",6
),(37,"isla","d08",6
),(38,"isla","m15",6
),(39,"isla","w02",6
),(40,"love","d02",4
),(41,"love","m06",4
),(42,"love","w03",4
),(43,"marz","m08",3
),(44,"marz","m05",3
),(45,"marz","d11",3
),(46,"marz","b03",3
),(47,"marz","w01",3
),(48,"marz","m16",3
),(49,"nort","b05",4
),(50,"nort","d09",4
),(51,"nort","m05",4
),(52,"nort","m10",4
),(53,"nort","w01",4
),(54,"nort","w02",4
),(55,"paci","m18",3
),(56,"paci","m17",3
),(57,"paci","d04",3
),(58,"paci","w02",3
),(59,"pean","m04",18
),(60,"roma","b02",3
),(61,"roma","d04",3
),(62,"roma","d02",3
),(63,"roma","d09",3
),(64,"roma","m06",3
),(65,"roma","m07",3
),(66,"roma","m10",3
),(67,"roma","w03",3
),(68,"supr","d06",2
),(69,"supr","d03",2
),(70,"supr","d01",2
),(71,"supr","m02",2
),(72,"supr","m03",2
),(73,"supr","w06",2
),(74,"swe2","b04",6
),(75,"swe2","m06",6
),(76,"swe2","m04",6
),(77,"swee","b07",3
),(78,"swee","b06",3
),(79,"swee","b04",3
),(80,"swee","b02",2
),(81,"swee","b05",3
),(82,"swee","m01",2
),(83,"swee","m13",2
),(84,"swee","m12",2
),(85,"swee","m11",2
),(86,"swee","m09",2
);

COMMIT;