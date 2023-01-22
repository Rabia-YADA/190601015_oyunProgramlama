using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    public GameObject Car;
    public GameObject Yacht;
    public GameObject areaCar;
    public GameObject areaYacht;
    public GameObject exitCarButton;
    public GameObject exitYachtButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            Car.SetActive(true);
            areaCar.SetActive(false);
            exitCarButton.SetActive(true);

        }

        if (other.CompareTag("Yacht"))
        {
            Yacht.SetActive(true);
            areaYacht.SetActive(false);
            exitYachtButton.SetActive(true);
        }
    }

    public void ExitCar()
    {
        Car.SetActive(false);
        areaCar.SetActive(true);
        this.transform.position = new Vector3(this.transform.position.x - 3, this.transform.position.y, this.transform.position.z);
        exitCarButton.SetActive(false);

    }

    public void ExitYacth()
    {
        Yacht.SetActive(false);
        areaYacht.SetActive(true);
        this.transform.position = new Vector3(100, this.transform.position.y,-1);
        exitYachtButton.SetActive(false);
    }
}
