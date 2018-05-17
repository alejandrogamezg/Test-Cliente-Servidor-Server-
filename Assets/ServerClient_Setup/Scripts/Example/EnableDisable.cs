using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class EnableDisable : NetworkBehaviour
{


	[ClientRpc]
	void RpcEnableDisable()
	{

		Test();
		
		
	}
	void Test()
	{
		Debug.Log("HOLA");
	}

	public void BtnEnableDisable()
	{
		 if(isServer)
		RpcEnableDisable();
	}
}
