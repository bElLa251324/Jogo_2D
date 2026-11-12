using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class tempo : MonoBehaviour
{
    float segundos = 0f;
    void Start()
    {

        Debug.Log("Cronômetro da partida ");

    }
    private void Update()
    {
        segundos += Time.deltaTime;

        Debug.Log("Segundos: " + segundos);

        if (segundos >= 95f)
        {
            Debug.Log("Fim da partida, o tempo acabou!");

        }
    }
}
