using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AutoModel : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        string bundleName = "auto_model";
        AssetBundleCreateRequest asyncBundleRequest = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, bundleName));
        yield return asyncBundleRequest;
        AssetBundle localAssetBundle = asyncBundleRequest.assetBundle;
        if (localAssetBundle == null) {
            Debug.LogError("failed");
            yield break;
        } else {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("ModelScene", UnityEngine.SceneManagement.LoadSceneMode.Additive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
