using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class GLTF_Manager : MonoBehaviour
{
    
    private string filePath = "C:\\Users\\KIM\\Desktop\\testAnimation.glb";
    [SerializeField] private GameObject gltfPrefab;
    [SerializeField] private List<Shader> requiredShader = new List<Shader>();//���忡 urp���̴��� ���Խ�Ű�� ���� �Ҵ�. ���� ����� x
    public void GLTF_LoadFile()
    {
        Debug.Log(filePath);
        GameObject gltf = Instantiate(gltfPrefab);
        gltf.GetComponent<GLTFast.GltfAsset>().Url = filePath;
    }
    public void TestObjectLoadFile()
    {
        GameObject gltf = Instantiate(gltfPrefab);
        gltf.GetComponent<GLTFast.GltfAsset>().Url = "https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Models/master/2.0/Duck/glTF/Duck.gltf";
    }
}
