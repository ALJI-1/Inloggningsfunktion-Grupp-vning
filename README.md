# Inloggningsfunktion Gruppövning - Grupp 7 (Azat, Rashiid, Christoffer och Albin) 

Beskrivning:

Detta projekt är en inloggningsfunktion med olika användarroller (Admin och Användare). Beroende på användarrollen får användaren tillgång till olika menyer och funktioner.

Funktioner:

Inloggning: Användare kan logga in med sina användarnamn och lösenord.
Adminmeny: Administratörer kan skapa nya användare, ändra inställningar och visa användarlistan.
Användarmeny: Vanliga användare kan visa sitt lösenord och logga ut.
Automatisk utloggning: Programmet avslutas automatiskt efter en viss tid av inaktivitet.

Installation:

Instruktioner för hur man installerar och kör projektet lokalt.

bash
Kopiera:

git clone https://github.com/ALJI-1/Inloggningsfunktion-Grupp-vning
cd inloggningsfunktion-gruppovning
dotnet build
dotnet run


Testning:

För att testa programmet, följ dessa steg:

Kör programmet enligt installationsinstruktionerna ovan.
Vid inloggningsprompten, ange lösenordet för en befintlig användare. Exempel:

Admin lösenord: 1234
Användare lösenord: 5678

Navigera genom menyerna och prova olika funktioner, som att skapa en ny användare, visa användarlistan, ändra inställningar och visa lösenord.

Projektstruktur:

Program.cs: Innehåller huvudklassen som hanterar applikationens körning och användarlistan.
Användare.cs: Innehåller funktioner och menyer för både admin och vanliga användare.
Security.cs: Innehåller inloggningslogiken och säkerhetsfunktioner för användarna.