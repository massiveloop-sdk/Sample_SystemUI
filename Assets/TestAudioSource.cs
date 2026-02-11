using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudioSource : MonoBehaviour
{
    [SerializeField] AudioClip m_AudioClip = null;
    [SerializeField] AudioSource m_AudioSource = null;

    private void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("[TestAudioSource] {0}", m_AudioClip == null ? "Null" : m_AudioClip.name);
        m_AudioSource.clip = m_AudioClip;

        m_AudioSource.loop = true;
        m_AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
