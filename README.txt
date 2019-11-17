- Åben solutionen "DabAflevering2"
- Gå ind under StartUp.cs
- På Linje 46 ændres connectionstring til brugerens personlige MSSQL server, og som database angives der eks. "DabAfl" også oprettes der automatisk en ny database med pågældende navn.
- Åben Package Manager Console i MS Visual Studio
- skriv update-database
- Kør IIS express, eller gå under Debug/Start Debugging(F5)
- Browser åbner sig selv og der skrives /Resturents/index efter https://localhost:44357/
- Her vises data for alle resturanter (view nr. 1)
- Derefter ændres url til https://localhost:44357/Resturents/Menu/ID (view nr. 2)
Id er her resturantens ID, fra top til bund startes der ved 1, og incrementeres hver gang man går ned. Så Jerrys /Resturents/Menu/1. South India /Resturents/menu/2, osv. 
- Hernæst kan guest reviews tilgåes på siden /Resturents/Guestreview/ID (view nr. 3)
Id er det samme som forrige her, ved Jerrys /Resturents/Guestreview/1. South India /Resturents/Guestreview/2 osv. 
