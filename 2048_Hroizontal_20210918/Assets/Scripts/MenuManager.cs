using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

/// <summary>
/// �}�l�e�����޲z��
/// �}�l�C���B�]�w�B���}�C��
/// </summary>
public class MenuManager : MonoBehaviour
{
    // Unity ���s�P�{�����q
    // 1. ���}����k
    // 2. ���s�]�w�I���ƥ� On Click

    public AudioMixer mixer;

    /// <summary>
    /// �}�l�C�� 
    /// </summary>
    public void StartGame(float delay)
    {
        //�ϥ��~�����O�������y�k:
        //�~�����O����k
        //��k�W��(�����޼�)
        //���� delay ���I�s ��k
        Invoke("DelayStartGame", delay);

    }

    private void DelayStartGame()
    {
        //�����޲z.���J����(�����W��)
        SceneManager.LoadScene("�C������");
        //SceneManager.LoadScene(1);
    }

    /// <summary>
    /// �]�w�C��
    /// </summary>
    public void SettingGame(float volume)
    {
        print("BGM �Ʊ쭵�q:" + volume);
        mixer.SetFloat("���qBGM", volume);
    }

    public void SettingGames(float volume)
    {
        print("SFX �Ʊ쭵�q:" + volume);
        mixer.SetFloat("���qSFX", volume);
    }
    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame(float delay)
    {
        Invoke("DelayQuitGame", delay);
    }

    private void DelayQuitGame()
    {
        //���ε{��.���}();
        //Quil ���|�A Editor ����A�o�������� ����BPC
        Application.Quit();

        print("���}�C��~");
    }
}
