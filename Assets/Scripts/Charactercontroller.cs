using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputController))]
public class Charactercontroller : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float rotationSpeed = 120f;
    private Animator anim;
    public float x, y;

    InputController inputController = null;
    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * speed);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
