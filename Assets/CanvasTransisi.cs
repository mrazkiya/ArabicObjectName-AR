using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasTransisi : MonoBehaviour
{
    public static string NamaScene;


    public void btn_pindah(string nama)
    {
        //KumpulanSuara.instance.Panggil_Suara(0);
        this.gameObject.SetActive(true);
        NamaScene = nama;
        GetComponent<Animator>().Play("end");
    }

    public void Object_InActive()
    {
        this.gameObject.SetActive(false);
    }

    public void Pindah_Scene()
    {
        SceneManager.LoadScene(NamaScene);
    }
}
