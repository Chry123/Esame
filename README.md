Esame

Descrizione progetto:
Il progetto prevede la gestione di un  sistema centralizzato di consegne a 
domicilio per un ristorante,e a pianificare la successiva progettazione, predisponendo le fasi di realizzazione del software


Struttura progetto:

1)DATA

La cartella DATA, contiene le classi e DataBase(le strutture dati), riguardanti i Piatti:

Piatto.cs rappresenta un insieme di dati che riguardano i dati specifici di un piatto;
BancaDati.cs rappresenta il DbContext e quindi la connessione al database;
Portata.cs rappresenta il Tipo di portata che si utilizerà per creare il nostro Piatto;
Allergeni.cs rappresenta gli allergeni degli allergeni che si utilizerà per creare il nostro Piatto;

2)Pages 

Il contenuto di Pages descrive gli end point del progetto.

Il quale nel mio progetto viene sopranominato Piatti.razor e Portate.razor e Allergenico.razor 

All' interno di pages ho svolto una modifica, la quale mi permette di impostare come sfondo della pagina un Immagine.

3) DataBase

ristorante.db rappresenta il database dei piatti, in cui si andrà a a Salvare i dati oppure Creare nuovi campi in caso dovesse essere aggiunto un nuovo piatto,
Modificare se ci dovessere essere delle mofifiche da svolgere e infine Eliminare il rispettivo campo.


