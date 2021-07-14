using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> wizards = new List<GameObject>();
    public GameObject currentWizard;

    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomWizard();
    }

    // Update is called once per frame
    void Update()
    {
        //Change Wizard
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(currentWizard);
            GenerateRandomWizard();
        }
    }

    private void GenerateRandomWizard()
    {
        int index = Random.Range(0, 4);
        currentWizard = Instantiate(wizards[index], wizards[index].transform.position, wizards[index].transform.rotation);
    }
}
