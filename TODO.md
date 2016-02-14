# TODO: aan de slag met het project

## Opstart

Zorg er voor dat elk teamlid een account heeft op:

- [ ] Github (projectbrochure, bijlage A)
- [ ] Huboard (zie projectbrochure, bijlage B)
- [ ] Toggl (zie projectbrochure, bijlage C)

## In [README.md](README.md):

- [ ] Vul namen van teamleden en links naar jullie Github account in
- [ ] Vul namen begeleiders in
- [ ] Vul deze tools aan in de README (*volledige* link naar jullie "projectruimte"), zodat de begeleider dit snel kan terugvinden.
- [ ] Wat zijn de missie en de kernwaarden van jullie team? (bv. grijp terug op resulaten worldcafé). Schrijf daar een kort statement over.

## Sjabloon voortgangsrapport

Er is een sjabloon voorzien voor een voortgangsrapport in [voortgangsrapport/weeknn.md]

- [ ] Vul groepnummer in
- [ ] Vul overal namen van de teamleden in op de plaatsen waar nu "student N" staat

Het voortgangsrapport handelt telkens over de *afgelopen week*, d.w.z. vanaf de dag waarop de vorige sessie plaats vond tot en met de dag voor deze sessie. Bijvoorbeeld als de sessies doorgaan op maandag rapporteer je telkens over de periode van de vorige maandag tot zondagavond.

Maak telkens je voortgangsrapport al aan bij het begin van de periode waarover je rapporteert. Bijvoorbeeld, in week 2 maak je het rapport aan voor week 3, enz. Zo kan elk teamlid dit aanvullen telkens zij/hij iets voor het project doet en heb je bij het volgende voortgangsgesprek nog een minimum aan werk om het rapport af te werken. Kopieer het sjabloon naar een document met naam `week03.md`, `week04.md`, enz. (gebruik de nummers van de weken zoals in de academische kalender). Het is de **begeleider** die in het begin van het document de aanwezigheden invult en eventuele opmerkingen. Ook de secties *Feedback* onderaan zijn voor de begeleiders gereserveerd.


- [ ] Elk teamlid zorgt afzonderlijk nog voor een individueel tijdregistratierapport met screenshots van de geleverde prestaties. Een voorbeeldje van de nodige Markdown code:

    ```Markdown
    ![Tijdregistratie Piet, 15-21 februari 2016](img/timesheet-w3-piet.jpg)
    ```

- [ ] Voeg elke week een screenshot in van de toestand van de kanban-borden van de deelopdrachten waar nu aan gewerkt wordt.
- [ ] Voeg ook telkens een overzicht van de tijdregistratie toe, onderverdeeld per deelopdracht voor de periode waarover het voortgangsrapport gaat.

## Deelopdrachten

De deliverables van elke deelopdracht worden in een aparte directory bijgehouden `opdracht01`, `opdracht02`, enz. Voor elke opdracht is er minstens een lastenboek (zie verder), een testplan en testrapport. Daar zijn al rudimentaire sjablonen voor voorzien.

De werkwijze bij het ontvangen van een nieuwe opdracht is telkens:

- Samenzitten om de opdracht door te nemen en te bespreken
- De opdracht onderverdelen in taken. Elke taak wordt een ticket op Huboard (en dus ook een Github issue)
    - Maak een milestone aan voor de opdracht en groepeer taken per milestone
    - Gebruik de mogelijkheden van Github/Huboard om info toe te voegen aan elk ticket: verantwoordelijke voor uitvoeren en testen, links naar relevante info elders in de repo, discussies over oplossingsstrategie, labels, enz.
    - "Assignee" is de persoon die verantwoordelijk is voor de huidige stap. Als de taak klaar is voor uitvoeren is de "Assignee" de verantwoordelijke voor uitvoeren, achteraf kan je de verantwoordelijke voor het testen aanduiden.
    - Doe een schatting van de totale tijd in manuur die jullie zullen besteden aan de opdracht (inclusief bespreken, uitvoeren, testen, opleveren).
- Kanban flow
    - Taken beginnen in de kolom "Backlog". Meestal zullen jullie eerst informatie moeten opzoeken voordat je de taak effectief kan uitvoeren. Zorg dat er een neerslag is hiervan (bv. in een aparte subdirectory zoals `opdracht01/doc`) en voeg een link toe in de issue.
    - Wanneer je voldoende info hebt om een taak uit te voeren, komt die in de kolom "Ready". Er moet op dit moment zeker een "Assignee" aangeduid zijn.
    - Wie aan een taak begint te werken verplaatst die naar "Working"
    - Als de taak klaar is om getest te worden, past de uitvoerder de "Assignee" aan. Eventueel moeten jullie nog een kolom "Testing" toevoegen.
    - Na succesvol testen zet je de taak op "Ready for next stage". De begeleiders kunnen dan nakijken en de zullen de taak al dan niet naar "Done" verplaatsen.

Jullie kunnen binnen je team zelf afspraken maken om deze werkwijze te verfijnen of aan te passen aan jullie eigen wensen. Het doel is altijd een transparante communicatie tussen alle teamleden en begeleiders, en een effeciënte doorstroom van taken doorheen het proces.

## Administratie

Bij het uitvoeren van het project is er relatief wat administratie en overhead. Dit is een expliciet onderdeel van het project, en we verwachten ook hier een neerslag van.

Voorzie op Huboard een milestone "Overhead" en op Toggl een project met dezelfde naam. Hou telkens bij hoe lang en aan welke taken je werkt. **Doe dit niet pas tijdens de wekelijkse afspraken!** Doe je tijdregistratie telkens op het moment dat je voor het project werkt.

Gebruik telkens consistente benamingen voor de taken waar je aan werkt. Gebruik dus in Toggl dezelfde naam als de Github issue/Huboard ticket.
