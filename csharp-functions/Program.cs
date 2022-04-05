﻿/*




Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
Stampare l’array di numeri fornito a video
Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e 
verificare che sia rimasto [2, 6, 7, 5, 3, 9])
Stampare la somma di tutti i numeri
Stampare la somma di tutti i numeri elevati al quadrati
 */




// che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.
void StampaArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        } else
        {
            Console.Write(array [i]);
        }
    }
    Console.WriteLine("]");
}


//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    return numero * numero;
}


//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.


int[] QuadratoDiElementaArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone(); //lo sostituisce
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }
    return copiaArray;
}


//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

/*
int[] SommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone(); //lo sostituisce
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
         somma = somma + array[i];
    }
    return somma;
}*/


int SommaElementiArray(int[] array)
{
    int[] copiArray = (int[])array.Clone();
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    return somma;
}



//--------------CODICE--------------

int[] laMiaArray = new int[] { 2, 6, 7, 5, 3, 9 };


//Stampare l’array di numeri fornito a video
StampaArray(laMiaArray);

//quadrato dei numeri
int[] arrayElevata = QuadratoDiElementaArray(laMiaArray);
Console.WriteLine(arrayElevata);

//somma
int somma = SommaElementiArray(laMiaArray);
Console.WriteLine(somma);

//quadrato di somma
Console.WriteLine(Quadrato(somma)); 