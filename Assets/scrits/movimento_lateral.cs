using UnityEngine;

public class movimento_lateral : MonoBehaviour
{


    public float velocidade = 5f;
    public float horizontal;


    void Start()
    {
        
    }

    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * horizontal * velocidade * Time.deltaTime;
    }
}
