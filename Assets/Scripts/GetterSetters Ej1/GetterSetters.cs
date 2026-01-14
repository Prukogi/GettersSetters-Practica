using UnityEngine;
using System;

public class GetterSetters : MonoBehaviour
{
	#region Properties
	public int Vida
	{ 
		get {return vida;}
		set 
		{
			if (value < 0)
				vida = 0;
			else
				vida = value;
        }
	}

	public int Monedas
	{
		get {return monedas;}
		set
		{
			if (value < 0)
				monedas = 0;
			else
				monedas = value;
        }
	}
	#endregion
                
            
                
            

	#region Fields
	[SerializeField] private int vida = 100;
	[SerializeField] private int monedas = 250;
	#endregion

	#region Unity Callbacks
	
	void Start()
    {
        
    }

    
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Q))
			RecibirDaño();
		if (Input.GetKeyDown(KeyCode.E))
			Curar();
		if (Input.GetKeyDown(KeyCode.Space))
			GastarMonedas();
		if (Input.GetKeyDown(KeyCode.K))
			GanarMonedas();

    }
    #endregion

    #region Public Methods
    public void RecibirDaño() 
	{
        Vida -= 10;
		Debug.Log("Vida: " + Vida);
	}
    public void Curar()
    {
        Vida += 10;
        Debug.Log("Vida: " + Vida);
    }

    public void GastarMonedas() 
	{
        Monedas -= 10;
        Debug.Log("Monedas: " + Monedas);
    }

    public void GanarMonedas() 
	{
        Monedas += 10;
        Debug.Log("Monedas: " + Monedas);
    }

    #endregion

    #region Private Methods
    #endregion

}
