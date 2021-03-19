using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vardaparadishana : MonoBehaviour
{
    public string vards;
    public string vecums;
    public GameObject ievadteksts1;
    public GameObject ievadteksts2;
    public GameObject tekstuAtteeloshana;
     public void uzglabaatTekstuGadu(){
        vards = ievadteksts1.GetComponent<Text>().text;
        vecums = ievadteksts2.GetComponent<Text>().text;
        tekstuAtteeloshana.GetComponent<Text>().text = vards.ToUpper()+" ir "+vecums.ToUpper()+" gadus vecs!";
    }
}
