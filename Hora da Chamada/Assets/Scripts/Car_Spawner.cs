using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections; // Necessário para IEnumerator e Coroutines

public class Car_Spawner : MonoBehaviour
{
    public GameObject[] car;

    void Start()
    {
        // Inicia o spawn repetido dos carros
        StartCoroutine(SpawnCars());
    }

    void Cars()
    {
        int rand = Random.Range(0, car.Length);

        float randXPos = Random.Range(-2.5f, 2.5f);

        // Posição do topo da tela convertida para o mundo
        Vector3 spawnPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1f, 10f));
        spawnPos.x = randXPos;

        Instantiate(car[rand], spawnPos, Quaternion.identity);
    }

    IEnumerator SpawnCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.3f);
            Cars();
        }
    }
}