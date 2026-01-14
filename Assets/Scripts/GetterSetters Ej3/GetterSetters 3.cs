using UnityEngine;
using System;

public class GetterSetters3 : MonoBehaviour
{
	#region Properties
	public int Ammo 
	{
		get
		{
			return ammo;
		}
		set
		{
			if (value < 0)
				ammo = 0;
			else if (value > magazineCapacity)
				ammo = magazineCapacity;
			else
				ammo = value;
        }
	}
    
	public int MagazineCapacity
	{
		get
		{
			return magazineCapacity;
		}
		private set
		{
			if (value < 1)
				magazineCapacity = 1;
			else
				magazineCapacity = value;
        }
	}
                
            
	
            
	
	#endregion

	#region Fields
	[SerializeField] private int ammo = 15;
	[SerializeField] private int magazineCapacity = 30;
	#endregion

	#region Unity Callbacks
	
	void Start()
    {
        
    }

    
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Mouse0))
			Shot();
		if (Input.GetKeyDown(KeyCode.R))
			Reload();
    }
    #endregion

    #region Public Methods
	public void Shot()
	{
		Ammo--;
	}
    public void Reload() 
	{
		Ammo = MagazineCapacity;

	}
    #endregion

    #region Private Methods
    #endregion

}
