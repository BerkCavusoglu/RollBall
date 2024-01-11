using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public int hiz = 5;
    public Rigidbody fizik;
    public int Puan;
    public int objeSayisi;

    public TextMeshProUGUI puanText;
    public TextMeshProUGUI baslikText;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        //transform.Translate(0,0,-10);
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 vektor = new Vector3(yatay, 0, dikey);

        transform.Translate(vektor * hiz / 50);
        //fizik.AddForce(vektor * hiz);
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.SetActive(false);
        Puan++;

        // PuanText null kontrolü
        if (puanText != null)
        {
            puanText.text = "Puan: " + Puan;
        }
        else
        {
            Debug.LogError("Puan Text nesnesi null. Lütfen puanText'i atayın.");
        }

        if (Puan == objeSayisi)
        {
            baslikText.gameObject.SetActive(true);
        }
    }
}
