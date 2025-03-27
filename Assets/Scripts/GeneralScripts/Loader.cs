using UnityEngine;
using static SceneLoader;

public class Loader : MonoBehaviour
{
    public void IntroScene()
    {
        Load(Scene.IntroScene);
    }
    
    public void MenuScene()
    {
        Load(Scene.MenuScene);
    }
    
    public void GameScene()
    {
        Load(Scene.GameScene);
    }
    
    public void SettingsScene()
    {
        Load(Scene.SettingsScene);
    }
    
    public void VictoryScene()
    {
        Load(Scene.VictoryScene);
    }
}
