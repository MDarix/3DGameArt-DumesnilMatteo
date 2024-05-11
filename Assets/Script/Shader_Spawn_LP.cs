using UnityEngine;

public class Shader_Spawn_LP : MonoBehaviour
{
    [SerializeField] Renderer dissolve;
    [SerializeField] Renderer dissolve1;
    [SerializeField] Renderer dissolve2;
    [SerializeField] Renderer dissolve3;
    [SerializeField] Renderer dissolve4;
    [SerializeField] Renderer dissolve5;
    [SerializeField] Renderer dissolve6;
    [SerializeField] Renderer dissolve7;
    [SerializeField] Renderer dissolve8;
    [SerializeField] Renderer dissolve9;
    [SerializeField] Renderer dissolve10;
    [SerializeField] Renderer dissolve11;
    [SerializeField] Renderer dissolve12;
    [SerializeField] Renderer dissolve13;
    [SerializeField] Renderer dissolve14;
    [SerializeField] Renderer dissolve15;
    [SerializeField] Renderer dissolve16;
    

    [SerializeField] Material dissolvant;
    public void ShaderSpawn()
    {
        print("walhalli ");

        dissolve.material = dissolvant;
        dissolve1.material = dissolvant;
        dissolve2.material = dissolvant;
        dissolve3.material = dissolvant;
        dissolve4.material = dissolvant;
        dissolve5.material = dissolvant;
        dissolve6.material = dissolvant;
        dissolve7.material = dissolvant;
        dissolve8.material = dissolvant;
        dissolve9.material = dissolvant;
        dissolve10.material = dissolvant;
        dissolve11.material = dissolvant;
        dissolve12.material = dissolvant;
        dissolve13.material = dissolvant;
        dissolve14.material = dissolvant;
        dissolve15.material = dissolvant;
        dissolve16.material = dissolvant;
      


    }
}
