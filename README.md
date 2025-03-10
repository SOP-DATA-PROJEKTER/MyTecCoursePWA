# MitTecForløb.dk

## Den ultimative TEC-studerendes ressource

## Indholdsfortegnelse

1. [Overordnede ide bag projektet](#overordnede-ide-bag-projektet)
2. [Kravspecifikationer for TEC-projektet](#kravspecifikationer-for-tec-projektet)
   - [Generelle krav](#generelle-krav)
   - [Laerlinge-log og opfoelgning](#laerlinge-log-og-opfoelgning)
   - [Inputfeltets struktur](#inputfeltets-struktur)
   - [Teknologi og design](#teknologi-og-design)
3. [Design og Layout](#design-og-layout)
   - [Desktop view](#desktop-view)
     - [Forside](#forside)
     - [Uddannelsesvej](#uddannelsesvej)
     - [Specialisering](#specialisering)
     - [Forloeb](#forloeb)
     - [Fag](#fag)
     - [Fag beskrivelse](#fag-beskrivelse)

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

## Design og Layout

Projektets front-end er lavet i Blazor (PWA - Progressive web app)

### Desktop view
#### Forside
![image](https://raw.githubusercontent.com/SOP-DATA-PROJEKTER/MyTecCoursePWA/refs/heads/master/readmeFiles/pictures/desktop/frontpage_desktop.png)

#### Uddannelsesvej
![image](https://github.com/SOP-DATA-PROJEKTER/MyTecCoursePWA/blob/master/readmeFiles/pictures/desktop/uddannelsevej_desktop.png?raw=true)

#### Specialisering
![image](https://github.com/SOP-DATA-PROJEKTER/MyTecCoursePWA/blob/master/readmeFiles/pictures/desktop/specialisering_desktop.png?raw=true)

#### Forloeb
![image](https://github.com/SOP-DATA-PROJEKTER/MyTecCoursePWA/blob/master/readmeFiles/pictures/desktop/forloeb_desktop.png?raw=true)

#### Fag
![image](https://github.com/SOP-DATA-PROJEKTER/MyTecCoursePWA/blob/master/readmeFiles/pictures/desktop/fag_desktop.png?raw=true)

#### Fag beskrivelse
![image](https://github.com/SOP-DATA-PROJEKTER/MyTecCoursePWA/blob/master/readmeFiles/pictures/desktop/fabbeskrivelse_desktop.png?raw=true)
