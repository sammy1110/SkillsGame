using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2dController : MonoBehaviour
{
    public float MovementSpeed = 1;

    public void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        movement = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, movement, 0) * Time.deltaTime * MovementSpeed;

    }






}
