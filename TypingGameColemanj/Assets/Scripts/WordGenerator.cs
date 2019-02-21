using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour {

    private static string[] wordList = {"cout<<","cin>>","<iostream>","#include","{}","[]","main()","int","float","double","return0","using",
    "namespace","std",";","for()","while()","<fstream>",".open",".close","bool","<vector>","<ctime>","char","const","i++","i--","ofstream","void",
    "outputFile<<","++num","endl","\n","\t","num1/num2","(x>y)","else","average","display(5)","static","<string>","<iomanip>","cows",".length",":",".width","file",
    "case","<cctype>","switch" };

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }



}
