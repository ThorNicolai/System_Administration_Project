# Opdracht 2: Automatiseren opzetten servers

## Opdrachtomschrijving: Webapplicatieservers

Verschillende klanten vragen ons om hun **webapplicatie** te hosten. Tot nu toe hebben we altijd manueel een server opgezet waarbij de nodige software geïnstalleerd en geconfigureerd werd. Door de groeiende vraag is dit niet houdbaar. De bedoeling is een soort "sjabloon" uit te werken zodat we veel sneller een nieuwe server kunnen opzetten die meteen geconfigureerd is om een applicatie op te draaien. Om het voor een webapplicatie-ontwikkelaar eenvoudiger te maken om op haar/zijn eigen laptop een **testomgeving** op te zetten, is de eerste stap het creëren van VirtualBox VMs.

We voorzien in eerste instantie de volgende platformen:

- **LAMP stack**: **L**inux (CentOS 7 of Fedora Server) + **A**pache + **M**ariaDB + **P**HP
- **WISA stack**: **W**indows Server 2016 + **I**IS + **S**QLServer (of eventueel MySQL) + **A**SP.NET

De bedoeling is om servers met *exact dezelfde* configuratie in een **productie-omgeving** te kunnen opzetten. We zijn er echter nog niet uit of we zelf de nodige infrastructuur willen opzetten en onderhouden (*private cloud*), of dit uitbesteden via een Infrastructure as a Service provider (*public cloud*). Public cloud providers die we overwegen zijn [Digital Ocean](https://www.digitalocean.com/) (50$ credits verkrijgbaar via [Github Student Pack](https://education.github.com/pack)), of [Amazon Web Services](https://aws.amazon.com/s/dm/landing-page/start-your-free-trial/) (12 maand gratis trial, maar wel kredietkaart nodig bij activeren).

### Acceptatiecriteria

- Het moet voor een applicatie-ontwikkelaar eenvoudig zijn om een testomgeving op te zetten voor het draaien van een webapplicatie met database-backend.
    - Dit toon je aan door een demo te geven van een webapplicatie die op het platform draait (bv. Drupal op LAMP, of een [open source ASP.NET applicatie](https://www.codeproject.com/Tips/667263/ASP-NET-Open-Source-Projects) op WISA)
- Het opzetten van deze servers moet **exact reproduceerbaar** zijn. Om écht op schaal bruikbaar te zijn, moet je het installatieproces automatiseren. Dat kan door gebruik te maken van een automatiseringstool zoals [Vagrant](http://vagrantup.com/), gecombineerd met een installatiescript (Bash, PowerShell).
- Er is de nodige aandacht besteed aan herbruikbaarheid.
    - De scripts zijn bruikbaar op verschillende types systemen: binnen de VirtualBox testomgeving op je desktop, binnen één van de voorgestelde public/private cloud platformen.
    - Instellingen die specifiek zijn voor een applicatie (bv. initialisatie database, installatie applicatie op de server) zijn configureerbaar. Vermijd dus "hard-coded" data tussen de code, maar gebruik waar mogelijk variabelen.
    - Maak onderscheid tussen het installatiescript voor het *platform* (dat herbruikbaar is) en de webapplicatie zelf (door de gebruiker bepaald)
- Er is een proof-of-concept opgezet met een public cloud platform (hetzij uit de opgegeven providers/producten hetzij een ander na afspraak met de begeleiders) voor minstens één van de types applicatieservers.

## Opdrachtomschrijving: Lokale SAP-ontwikkelingsomgeving

Verder kregen we ook een vraag van een team SAP-developers. SAP is een zgn. Enterprise Resource Planning system dat toelaat administratieve bedrijfsprocessen te automatiseren. De huidige situatie is dat zij werken op een centrale SAP-server als development-omgeving, maar daar zijn verschillende praktische en organisatorische problemen mee. De server die ze ter beschikking hebben is ondergedimensioneerd, zodat die regelmatig uitvalt als er te veel activiteit op plaats vindt. Bovendien is dit soort installatie onderhevig aan de licentievoorwaarden van SAP en om kosten te besparen zijn ze op zoek naar een alternatief.

Een mogelijke piste zou zijn om de *developer edition* van [SAP NetWeaver](https://en.wikipedia.org/wiki/SAP_NetWeaver) ABAP [Application Server](https://en.wikipedia.org/wiki/SAP_NetWeaver_Application_Server) te installeren op een Linux VM in VirtualBox zodat ontwikkelaars een lokale ontwikkelingsomgeving kunnen opzetten zonder af te hangen van een server over het netwerk.

Jullie taak is om deze installatie uit te voeren, waar mogelijk te automatiseren of zoniet grondig te documenteren. Jullie voorzien ook een handleiding te voorzien voor de ontwikkelaars hoe zij aan de slag kunnen gaan met deze virtuele SAP server.

Meer informatie:

- <https://blogs.sap.com/2017/09/04/newbies-guide-installing-abap-as-751-sp02-on-linux/>
- <http://www.sapyard.com/minisap-installation-part-1/>
- <https://blogs.sap.com/2013/05/16/developer-trial-editions-sap-netweaver-application-server-abap-and-sap-business-warehouse-powered-by-sap-hana/>
- <https://tools.hana.ondemand.com/#abap>

### Acceptatiecriteria

- Er is een proof-of-concept van een SAP NetWeaver ontwikkelingsomgeving in VirtualBox
- De installatie is waar mogelijk geautomatiseerd, en in elk geval gedocumenteerd. Hou in het installatiescript en de documentatie rekening met hoe deze omgeving in de toekomst (met nieuwe versies van de gebruikte tools) kan gereproduceerd worden.
- Voorzie een handleiding:
    - enerzijds een technische handleiding voor het opzetten van de ontwikkelingsomgeving,
    - anderzijds een gebruikershandleiding voor een ABAP-developer die met deze omgeving aan de slag wil gaan

## Deliverables

Demo tijdens de contactmomenten van:

- Testomgeving met VirtualBox voor alle gevraagde platformen:
    - Toon hoe de VMs kunnen geïnitialiseerd worden.
    - Toon hoe een webapplicatie op de VM kan geïnstalleerd worden (aan de hand van een webapplicatie met een database-backend) en hoe een ABAP-ontwikkelaar met de SAP-omgeving kan werken
- Proof-of-concept met een public cloud platform van één van de webapplicatieservers, geïnitialiseerd met hetzelfde installatiescript als de testomgeving.

Op Github:

- Lastenboek
- Alle achtergrondinformatie die jullie verzameld hebben om met de opdracht aan de slag te kunnen gaan
- Gedetailleerde technische handleidingen gericht naar andere teamleden over installatieprocedures en de gebruikte scripts
- Handleiding voor gebruikers (i.e. webapplicatie- of SAP-ontwikkelaar)
- Testplannen en testrapporten
