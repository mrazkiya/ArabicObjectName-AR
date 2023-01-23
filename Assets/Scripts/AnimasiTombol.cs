using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiTombol : MonoBehaviour
{
    // Start is called before the first frame update
    public void _Animasi()
    {
        GetComponent<Animation>().Play("button");
        KumpulanSuara.instance.Panggil_Suara(0);
    }

    public void _Animasi2()
    {
        GetComponent<Animation>().Play("kembali");
        KumpulanSuara.instance.Panggil_Suara(0);
    }

}
