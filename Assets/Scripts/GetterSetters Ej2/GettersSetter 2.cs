using UnityEngine;
using System;

public class GettersSetter2 : MonoBehaviour
{
    #region Properties
    public int Energy
    {
		get 
		{ 
			return energy; 
		}
		set 
		{
			if (value < 0)
				energy = 0;
			else if (value > 100)
				energy = 100;
			else
				energy = value;
		}
    }
			
			
	
	public int Experience
	{
		get 
		{
			return experience;
		}
		private set
		{
			if (value < 0)
				experience = 0;
			else
				experience = value;
		}
	}
			
			
			
	#endregion

	#region Fields
	[SerializeField] private int energy = 50;
	[SerializeField] private int experience = 0;
	#endregion

	#region Unity Callbacks
	
	void Start()
    {
        
    }

    
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.A))
			UseEnergy();
        if (Input.GetKeyDown(KeyCode.S))
            RechargeEnergy();
        if (Input.GetKeyDown(KeyCode.D))
            GainXP();
    }
	#endregion

	#region Public Methods
	public void UseEnergy() 
	{
		Energy -= 10;
		Debug.Log("Energy: " + Energy);
	}
    public void RechargeEnergy() 
	{
        Energy += 15;
        Debug.Log("Energy: " + Energy);
    }
    public void GainXP() 
	{
		Experience += 20;
        Debug.Log("Experience: " + Experience);
    }


    #endregion

    #region Private Methods
    #endregion

}
