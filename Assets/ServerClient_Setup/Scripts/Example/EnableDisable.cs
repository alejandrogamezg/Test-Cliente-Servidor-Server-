using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class EnableDisable : NetworkBehaviour
{

	public GameObject cubo;
	public bool enaDisa = false;


	[ClientRpc]
	void RpcTest()
	{
		Test();	
	}

	[ClientRpc]
	void RpcEnableDisable()
	{
		ActivaDesactiva();	
	}

	void Test()
	{
		Debug.Log("HOLA");
	}

	void ActivaDesactiva(){
		enaDisa = !enaDisa;
		if(enaDisa == true)
		{
			cubo.SetActive(true);
		}
		if(enaDisa == false)
		{
			cubo.SetActive(false);
		}
	}

	public void BtnTest()
	{
		 if(isServer)
		Test();
		RpcTest();
	}
	public void BtnEnableDisable()
	{
		 if(isServer)
		 ActivaDesactiva();
		RpcEnableDisable();
	}
}
