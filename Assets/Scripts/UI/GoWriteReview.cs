using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoWriteReview : MonoBehaviour
{
	string androidUrl = "market://details?id=com.yuriki3d.PocketMoneyMath";
	string ios7UrlOld = "itms-apps://itunes.apple.com/app/idcom.3dyuriki.PocketMoneyMath?action=write-review&mt=8";
	string iosUrlOld = "itms-apps://itunes.apple.com/WebObjects/MZStore.woa/wa/viewContentsUserReviews?id=com.3dyuriki.PocketMoneyMath&onlyLatestVersion=true&pageNumber=0&sortOrdering=1&type=Purple+Software";
	string ios7Url = "itms-apps://itunes.apple.com/app/id1372434662?action=write-review&mt=8";
	string iosUrl = "itms-apps://itunes.apple.com/WebObjects/MZStore.woa/wa/viewContentsUserReviews?id=1372434662&onlyLatestVersion=true&pageNumber=0&sortOrdering=1&type=Purple+Software";

	public void RateApp()
	{
		#if UNITY_ANDROID
			Application.OpenURL(androidUrl);
		#endif

		#if UNITY_IOS
			Application.OpenURL(iosUrl);
		#endif
	}
}
