- �ben solutionen "DabAflevering2"
- G� ind under StartUp.cs
- P� Linje 46 �ndres connectionstring til brugerens personlige MSSQL server, og som database angives der eks. "DabAfl" ogs� oprettes der automatisk en ny database med p�g�ldende navn.
- �ben Package Manager Console i MS Visual Studio
- skriv update-database
- K�r IIS express, eller g� under Debug/Start Debugging(F5)
- Browser �bner sig selv og der skrives /Resturents/index efter https://localhost:44357/
- Her vises data for alle resturanter (view nr. 1)
- Derefter �ndres url til https://localhost:44357/Resturents/Menu/ID (view nr. 2)
Id er her resturantens ID, fra top til bund startes der ved 1, og incrementeres hver gang man g�r ned. S� Jerrys /Resturents/Menu/1. South India /Resturents/menu/2, osv. 
- Hern�st kan guest reviews tilg�es p� siden /Resturents/Guestreview/ID (view nr. 3)
Id er det samme som forrige her, ved Jerrys /Resturents/Guestreview/1. South India /Resturents/Guestreview/2 osv. 
