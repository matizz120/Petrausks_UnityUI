using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atteluparadishana : MonoBehaviour
{
    public GameObject krekls;
    public GameObject apavi;
    public GameObject bikses;
    public GameObject cepures;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
    public GameObject slaideris2;
    public AudioSource skanasAvots;
    public AudioClip SkanaKoAtskanot;

    public void kreklsAttelosana(bool vertiba){
        krekls.SetActive(vertiba);
    }

    public void apaviAttelosana(bool vertiba){
        apavi.SetActive(vertiba);
    }

    public void biksesAttelosana(bool vertiba){
        bikses.SetActive(vertiba);
    }

    public void cepureAttelosana(bool vertiba){
        cepures.SetActive(vertiba);
    }

    public void izkritosais(int skaitlis){
        if(skaitlis == 0){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }else if(skaitlis == 1){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }else if(skaitlis == 2){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        }
    }

    public void mainitLielumu1(){
        float pasreizejaVert = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1, 1F*pasreizejaVert);
    }
    public void mainitLielumu2(){
        float pasreizejaVert2 = slaideris2.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1F*pasreizejaVert2, 1);
    }
    public void uzbiditsUzAttela(){
        skanasAvots.PlayOneShot(SkanaKoAtskanot);

    }
    public void nobiditsNoAttela(){
        skanasAvots.Stop();
        
    }
}
