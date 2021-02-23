# GameDevHandIn1

## *Handin by: Gruppe 11*
* Martin Laurvig Brandstrup, mb604
* Jeppe Lotz Juul, jj443
* Jannich Højmose Møller, jm312

Treasure Hunt er det vi har navngivet vores første aflevering. På nuværende stund er der meget få spilelementer over det, men der er 

stor mulighed for at viderebygge det i fremtiden, i takt med, at vi får nye færdigheder.

Som basis i ideen, består vores program af en 3d interaktiv oplevelse, hvor man kontrollerer en figur, der med en "metaldetektor" skal 

forsøge at finde skjulte skatte i en scene.
Senere i processen kan vi bygge videre på ideen og gøre det mere til et spil, fx tilføje miner; forskellige former for skatte; lave forhindringer i scenen, etc.

Vi har valgt at fokusere på tre hovedemner i vores projekt:
* Scene-building: det er et spil, hvor det er oplagt at fokusere på banedesign.
* Grundlæggende UI: god mulighed for at snuse til noget nyt; vi benytter dette her til at tracke scoren
* Scripts, der håndterer objekter og afstand mellem objekter (med tilhørende lydeffekt)

Herudover har vi arbejdet med random instantiering af objekter i en scene.
Nogle af de største udfordringer vi stødte på var bl.a. at undgå at disse objekter spawnede under terrænet.
Herudover har vi også haft problemer med at kunne referere variabler fra andre Scripts. Tror vi fandt ud af det, men vi har på fornemmelsen at der findes mere elegante løsninger.
Endeligt har vi også haft problemer med at fjerne de "skatte" vi "samler op" efter at løbe igennem dem uden at få null pointer exceptions.
