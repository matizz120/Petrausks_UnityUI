using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Objektuparvietoshana : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform transformacijuLogs;
    public Canvas kanva;
    private void Awake(){
        transformacijuLogs = GetComponent<RectTransform>();

    }
    //Funkcija nostrādā, kad uzklikšķināts uz pārvietojamā objekta
    public void OnPointerDown(PointerEventData notikums){
        Debug.Log("Kreisais klikšķis uz pārvietojamā objekta!");
    }
    //Funkcija nostrādā uzsākot pārvietošanu
    public void OnBeginDrag(PointerEventData notikums){
        Debug.Log("Uzsākta pārvietošana!");
    }
    //Funkcija nostrādā uzsākot pārvietošanas brīdī
    public void OnDrag(PointerEventData notikums){
        transformacijuLogs.anchoredPosition += notikums.delta/kanva.scaleFactor;
    }
    //Funkcija nostrādā atlaižot vilkto objektu
    public void OnEndDrag(PointerEventData notikums){
        Debug.Log("Vilkšana pabeigta!");
    }

}