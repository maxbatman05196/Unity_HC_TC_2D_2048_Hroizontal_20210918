using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

/// <summary>
/// 開始畫面選單管理器
/// 開始遊戲、設定、離開遊戲
/// </summary>
public class MenuManager : MonoBehaviour
{
    // Unity 按鈕與程式溝通
    // 1. 公開的方法
    // 2. 按鈕設定點擊事件 On Click

    public AudioMixer mixer;

    /// <summary>
    /// 開始遊戲 
    /// </summary>
    public void StartGame(float delay)
    {
        //使用繼承類別的成員語法:
        //繼承類別的方法
        //方法名稱(對應引數)
        //延遲 delay 秒後呼叫 方法
        Invoke("DelayStartGame", delay);

    }

    private void DelayStartGame()
    {
        //場景管理.戴入場景(場景名稱)
        SceneManager.LoadScene("遊戲場景");
        //SceneManager.LoadScene(1);
    }

    /// <summary>
    /// 設定遊戲
    /// </summary>
    public void SettingGame(float volume)
    {
        print("BGM 滑桿音量:" + volume);
        mixer.SetFloat("音量BGM", volume);
    }

    public void SettingGames(float volume)
    {
        print("SFX 滑桿音量:" + volume);
        mixer.SetFloat("音量SFX", volume);
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame(float delay)
    {
        Invoke("DelayQuitGame", delay);
    }

    private void DelayQuitGame()
    {
        //應用程式.離開();
        //Quil 不會再 Editor 執行，發布執行檔 手機、PC
        Application.Quit();

        print("離開遊戲~");
    }
}
