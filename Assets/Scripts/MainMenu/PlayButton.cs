using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : SimpleButton
{
    public override void OnClick()
    {
        base.OnClick();
        SceneManager.LoadScene("Game");
    }

    private void Start()
    {
        AddButtonListener();
    }
}
