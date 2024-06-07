using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeSinceLastDog = 0f; // Variable para acumular el tiempo

    // Update is called once per frame
    void Update()
    {
        timeSinceLastDog += Time.deltaTime; // Acumula el tiempo transcurrido

        // On spacebar press, send dog if 1 second have passed
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastDog >= 1f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceLastDog = 0f; // Resetea el tiempo acumulado después de instanciar el perro
        }
    }
}
