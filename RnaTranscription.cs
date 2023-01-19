using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string cont = "";

        if( String.IsNullOrEmpty( dna ) )
            return "";

        for (int i = 0; i < dna.Length;i++){
            if(dna[i] == 'A'){
                cont += 'U';
            }
            else if(dna[i] == 'G'){
                cont += 'C';
            }
            else if(dna[i] == 'C'){
                cont += 'G';
            }
            else if(dna[i] == 'T'){
                cont += 'A';
            }
        }

            return cont;
    }
}