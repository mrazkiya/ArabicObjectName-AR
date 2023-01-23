using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiMulai : MonoBehaviour
{
    // Start is called before the first frame update
    public void _Animasi()
    {
        GetComponent<Animation>().Play("mulai");
        KumpulanSuara.instance.Panggil_Suara(0);
    }

}
