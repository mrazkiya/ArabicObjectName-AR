using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistem : MonoBehaviour
{
    public static sistem instance; 
    public int ID;

    public GameObject TempatSpawn;
    public GameObject[] KoleksiBarang;
    public AudioClip[] SuaraBarang;
    AudioSource Suara;

    public GameObject Gui_Utama;
    public GameObject Benda;
    
    
    
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ID = 0;

        Benda = Instantiate(KoleksiBarang[ID]);
        Benda.transform.SetParent(TempatSpawn.transform, false);
        //SpawnObject();

        Gui_Utama.SetActive(false);

        Suara = gameObject.AddComponent<AudioSource>();
    }

    public void SpawnObject()
    {
        //GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Barang");
        //Debug.Log(BendaSebelumnya);
        if(Benda != null)
        {
            Destroy(Benda);
        }
            
       
                
        Benda = Instantiate(KoleksiBarang[ID]);
        Benda.transform.SetParent(TempatSpawn.transform, false);

        TempatSpawn.GetComponent<Animation>().Play("PopUp");
        KumpulanSuara.instance.Panggil_Suara(1);
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            GantiBarang(true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GantiBarang(false);
        }
    }

    public void GantiBarang(bool Kanan)
    {
        if(Kanan)
        {
            if(ID >= KoleksiBarang.Length-1)
            {
                ID = 0;
            }
            else
            {
                ID++;
            }
        }
        else
        {
            if (ID <= 0)
            {
                ID = KoleksiBarang.Length-1; 
            }
            else
            {
                ID--;
            }

        }

        SpawnObject();
        PanggilSuaraBuah();
    }

    public void PanggilSuaraBuah()
    {
        Suara.clip = SuaraBarang[ID];
        Suara.Play();
    }
}
