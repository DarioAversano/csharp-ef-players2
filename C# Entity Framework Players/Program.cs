// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
csharp-ef-players

Milestone 0:
Modelliamo un’entità Player che rappresenta un giocatore del vostro sport preferito (calcio, basket, pallavolo, ecc). Un giocatore è caratterizzato da:
> id
> nome
> cognome
> punteggio
> numero partite giocate
> numero partite vinte
Aggiungiamo le data annotations nel modello Player e creiamo la relativa tabella nel nostro database, tramite una migration.

Milestone 1
Nel program.cs svolgiamo le operazioni CRUD sull’entità Players, usando dei dati inseriti nel codice, senza chiederli
all’utente ( sarebbe meglio usando il programma fatto nel live coding questa mattina dove avete un opzione per inserire un nuovo giocatore):
1- creazione di un nuovo giocatore, secondo queste regole:

    per il punteggio generiamo un numero decimale casuale da 1 a 10
    per il numero di partite giocate e partite vinte generiamo un numero intero casuale da 1 a 100, stando attenti che il numero di partite 
vinte sia inferiore alle partite giocate.

2- visualizzazione del giocatore appena creato
3- modifica del nome e del cognome del giocatore
4- cancellazione del giocatore
*/ 