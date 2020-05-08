using UnityEngine;

public class FlowerBehavior : MonoBehaviour
{
    private bool inFrame = false;

    public SeedButtonHandler SeedPresent;
    public DirtButtonHandler DirtPresent;
    public WaterButtonHandler WaterPresent;
    public SunButtonHandler SunPresent;


    private void Start()
    {
        //SeedPresent = FindObjectOfType<SeedButtonHandler>();
        //DirtPresent = FindObjectOfType<DirtButtonHandler>();
        //WaterPresent = FindObjectOfType<WaterButtonHandler>();
        //SunPresent = FindObjectOfType<SunButtonHandler>();
        

    }

    private void Update()
    {

        
        if (!inFrame && SeedPresent.inFrame && DirtPresent.inFrame &&
          WaterPresent.inFrame && SunPresent.inFrame)
        {
            this.transform.position += new Vector3(0, 0, -3f);
            inFrame = true;
        }

    }

   
}
