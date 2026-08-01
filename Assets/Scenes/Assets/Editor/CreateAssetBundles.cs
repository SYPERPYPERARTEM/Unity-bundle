using UnityEditor;
using System.IO;
public class CreateAssetBundles {
    [MenuItem("Assets/Build AssetBundles")]
    public static void BuildAllAssetBundles() {
        string dir = "Assets/AssetBundles";
        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
}
