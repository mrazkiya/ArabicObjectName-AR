using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuaraSoal19 : MonoBehaviour
{
    public static SuaraSoal19 instance;

    public AudioClip[] Clips;
    List<AudioSource> Soal = new List<AudioSource>();

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Soal.Clear();

        for (int i = 0; i < Clips.Length; i++)
        {
            Soal.Add(gameObject.AddComponent<AudioSource>());
            Soal[i].clip = Clips[i];
        }
    }

    public void Panggil_Suara(int i)
    {
        Soal[i].Play();
    }
}
