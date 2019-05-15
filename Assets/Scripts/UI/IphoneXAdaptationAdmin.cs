using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IphoneXAdaptationAdmin : MonoBehaviour
{
	public RectTransform BtnHolder;
	public Camera cam;

	void Start()
	{
		if ((cam.pixelHeight == 2436 && cam.pixelWidth == 1125) || (cam.pixelHeight == 1792 && cam.pixelWidth == 828) || (cam.pixelHeight == 2688 && cam.pixelWidth == 1242))
		{
			Vector2 ofs = BtnHolder.offsetMax;
			ofs.y -= 95;
			BtnHolder.offsetMax = ofs;
		}		
	}
}
