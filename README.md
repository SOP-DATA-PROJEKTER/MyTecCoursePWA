# MitTecForløb.dk

## Den ultimative TEC-studerendes ressource

## Indholdsfortegnelse

1. [Overordnede ide bag projektet](#overordnede-ide-bag-projektet)
2. [Kravspecifikationer for TEC-projektet](#kravspecifikationer-for-tec-projektet)
   - [Generelle krav](#generelle-krav)
   - [Laerlinge-log og opfoelgning](#laerlinge-log-og-opfoelgning)
   - [Inputfeltets struktur](#inputfeltets-struktur)
   - [Teknologi og design](#teknologi-og-design)
3. [📐 Design og Layout](DESIGN.md)

---

### Overordnede ide bag projektet
Projektet handler om at skabe en app eller et website, som TEC-elever kan bruge til en række forskellige formål:

- Indeholde informationer om alle uddannelser, der tilbydes på TEC.
- Beskrive de forskellige uddannelseslinjer under hver uddannelse, såsom IT-Support, Infrastruktur og Programmering.
- Indeholde alle de fag, en elev skal igennem under uddannelsen, samt detaljer om disse.
- Have en noteboks, hvor eleven kan notere, hvad de har lavet under deres lærlingeforløb, herunder udfordringer de har overkommet, eller hvor de har brug for hjælp.
- Gøre det muligt for underviseren at få adgang til disse journaler, så de kan strukturere læringen efter elevernes viden og behov.
- Appen/websitet skal have administratoradgang, så de forskellige uddannelser og fag kan opdateres ved forandringer.

---

## Kravspecifikationer for TEC-projektet

### Generelle krav
- Brugen af knapper til at vælge mellem **EUD** og **EUX**.
- Mulighed for oprettelse af profil.
- Visning af de forskellige uddannelser.
- Integration af **GF2** (med overvejelse om denne vises før eller efter punkt 4, hvis man er elev).
- Visning af de uddannelseslinjer, der er under den valgte uddannelse.
- Visning af alle hovedforløbene for uddannelsen.
- Visning af alle fag, som man skal igennem hele hovedforløbet.
- Information om hvert fag.

### Laerlinge-log og opfoelgning
- Et inputfelt, hvor eleverne kan udfylde deres datalog over, hvad de har lavet i deres lærlingeforløb.
- To uger før eleven skal tilbage i skole, sendes en reminder-mail til eleven og lærlingeansvarlig omkring udfyldelse.
- Mulighed for at uploade det udfyldte inputfelt til en afleveringsmappe i **Itslearning** eller nemt vedhæfte det til en mail via en knap med et **mail/upload ikon**.

### Inputfeltets struktur
- **"Udfyld gerne med din lærlingeansvarlige"**
- Beskrivelse af **4-5 ting**, man har arbejdet med undervejs i læretiden.
- Beskrivelse af en opgave, som gav udfordringer, og som enten blev løst eller som man ønsker input til at løse i det kommende skoleforløb.

### Teknologi og design
- Brug af passende **database** eller **cloud-løsning**, da det er en hjemmeside, der besøges.
- Hostning af **web-app og back-end** på en server.
- Designet med **TEC's nye farve, lilla** (som set på deres hjemmeside).
- Administrator skal kunne administrere indholdet af de valg og fag, som eleven møder, når denne klikker.

---

📐 **Se detaljer om design og layout her: [DESIGN.md](DESIGN.md)**


<hr>

## Tailwind
til udvikling af tailwind - download [tailwind cli](https://github.com/tailwindlabs/tailwindcss/releases/tag/v4.0.12) og pladser den i mappen hvor projektet er (ikke solution), kør derefter denne powershell commando for at få tailwind til at generere filer ud fra de tailwind classes der bliver skrevet.
```
.\tailwindcss-windows-x64.exe -i .\wwwroot\css\app.css -o .\wwwroot\css\app.min.css --watch
```
Husk desuden at lade tailwind-powershell stå åben mens der udvikles.


<hr>

## Her er de kravspecifikationer vi fik stillet med programmet: - Fra gammelt hold
(~~) Man starter med at kunne se EUD og EUX i form af knapper
Mulighed for at oprettelse af profil (~~)
(~~) Derefter kan man se de forskellige uddannelser(~~)

Husk GF2 (hvis man er elev giver det så mening den kommer før eller efter pkt. 4?)

(~~) Derefter ses de forskellige uddannelseslinjer under uddannelsen, som var valgt før (~~)

(~~) Derefter bliver man rykket til en ny side hvor man kan se de alle hoved forløbene for uddannelsen. (~~)

(~~) Derefter kan man se alle de fag, som man skal igennem hele hoved forløbet (~~)

Information om faget

Derefter kan man se et stort input felt, som skal udfyldes med elevernes datalog for hvad de har lavet i deres lærlingeforløb.

To uger før elev skal tilbage i skole, sendes en reminder-mail til elev og lærlingeansvarlig omkring udfyldelse.

Kan det udfyldte inputfelt uploades til en ”afleveringsmappe” i itslearning (hvis der vel at mærke er oprettet en af underviser, eller nemt vedhæftes en mail? – bare med en knap med et mail/upload ikon??

Input feltet skal beskrives med og deles i to ”afsnit”;
”Udfyld gerne med din lærlingeansvarlige”.

Du skal udfylde med 4-5 ting du har arbejdet med undervejs i din læretid.
Beskrive gerne en opgave som gav dig udfordringer, enten som du løste eller gerne vil have input til at løse på dit kommende skoleforløb
Database? Cloud? (pas, det er jo en hjemmeside man besøger, så det som passer til det!)

Domain

Server til host web-app and back-end

(~~) Evt. Designes med TEC nye farve lilla (se hjemmeside) (~~)

En administrator skal kunne administrere indholdet af de valg og fag, som eleven møder når denne klikker


## Ny Kravspecifikation
