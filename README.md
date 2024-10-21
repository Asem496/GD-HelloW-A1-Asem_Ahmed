Hier is een verbeterde versie van je beschrijving voor de GIT-README, inclusief de gevraagde technische documentatie, toelichting van gemaakte keuzes en reflectie:

---

# Projectbeschrijving

In dit project heb ik een kleine woonwijk gecreëerd bestaande uit huisjes en drie wegen. Daarnaast heb ik een speelbaar personage toegevoegd dat kan bewegen met behulp van de W, A, S, en D toetsen. Dit personage beweegt soepel door de wereld dankzij een **Rigidbody**-component en een aangepast script in Unity. De benodigde elementen, zoals de huizen en wegen, zijn gedownload via de Unity Asset Store.

## Mechanische Werking

### Beweging van het personage
De beweging van het personage wordt gerealiseerd door gebruik te maken van een **Rigidbody**-component in Unity, die zorgt voor realistische fysica zoals zwaartekracht en botsingen. Het script dat aan het personage is gekoppeld, detecteert invoer van de gebruiker (de toetsen W, A, S, en D) en vertaalt dit naar bewegingen in de gamewereld. Dit gebeurt met behulp van Unity's **Transform** en **Rigidbody** methodes om het personage soepel te laten bewegen zonder problemen met fysica.

**Hoofdpunten van de implementatie:**
1. **Rigidbody**: Dit zorgt voor realistische bewegingen en fysische interacties met de wereld.
2. **Input handling**: In het script wordt de invoer van de gebruiker (W, A, S, D) gedetecteerd om het personage in de juiste richting te laten bewegen.
3. **FixedUpdate()**: Voor het updaten van de beweging wordt **FixedUpdate()** gebruikt, omdat dit beter geschikt is voor fysische simulaties zoals die van de **Rigidbody**.

### Toegevoegde assets
De visuele elementen van de wereld, zoals de huizen en wegen, zijn gedownload via de Unity Asset Store. Dit heeft me veel tijd bespaard, zodat ik me kon richten op het programmeren en de functionaliteit van de mechanica.

## Keuzes en Oplossingen

### 1. Gebruik van de Unity Asset Store
Ik heb ervoor gekozen om assets van de Unity Asset Store te downloaden in plaats van alles zelf te maken. Dit was een bewuste keuze omdat het creëren van 3D-modellen tijdrovend is en ik me in dit stadium wilde concentreren op de functionaliteit van het project, zoals de bewegingsmechanica en interacties.

### 2. Rigidbody voor beweging
Ik heb ervoor gekozen om **Rigidbody** te gebruiken voor het besturen van het personage, omdat het gemakkelijk fysische interacties afhandelt, zoals zwaartekracht en botsingen. Hierdoor kon ik mij richten op het gedrag van het personage zonder dat ik zelf complexe fysische simulaties hoefde te programmeren.

### 3. Input handling via script
De besturing is geïmplementeerd via een script dat de **Input.GetAxis()** methodes gebruikt om de invoer van de gebruiker soepel te verwerken. Dit maakt het mogelijk om de beweging flexibel aan te passen als dat nodig is.

## Reflectie

### Wat goed werkte:
- Het gebruik van **Rigidbody** en Unity's ingebouwde fysische systemen zorgde ervoor dat het personage zonder veel extra moeite realistisch beweegt en reageert op de omgeving.
- Het downloaden van kant-en-klare assets gaf me de ruimte om meer tijd te besteden aan het begrijpen en implementeren van scripts en mechanieken.

### Wat ik de volgende keer anders zou doen:
- **Betere documentatie vooraf**: Ik merkte dat ik tijdens de ontwikkeling soms ongestructureerd werkte. De volgende keer wil ik meer tijd besteden aan het vooraf documenteren van mijn aanpak. Dit zou me helpen om efficiënter te werken en sneller problemen op te lossen.
- **Eigen assets creëren**: Hoewel de assets van de Unity Asset Store erg nuttig waren, wil ik in de toekomst proberen om meer eigen 3D-modellen te maken. Dit geeft me meer creatieve controle en de mogelijkheid om uniekere projecten te maken.
- **Geavanceerdere bewegingen**: De huidige bewegingen van het personage zijn vrij basic. In de toekomst wil ik experimenteren met meer geavanceerde mechanieken, zoals springen of het toevoegen van animaties om de beweging realistischer te maken.

Ik ben nog aan het leren en onderzoek Unity steeds verder om het programma beter te begrijpen en mijn vaardigheden te verbeteren.

---

Met deze beschrijving en reflectie heb je nu een duidelijke, gestructureerde README waarin je de mechaniek uitlegt, je keuzes motiveert en reflecteert op wat er beter kan.




laatste opdracht aanpassingen:

Skybox toegevoegd, met een dag & nacht script.

gezorgd voor nog een npc in de map die ook beweegt.

eigen idee: niet echt kunnen toevoegen.