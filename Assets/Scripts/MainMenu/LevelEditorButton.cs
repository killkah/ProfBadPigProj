using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEditorButton : SimpleButton
{
    public override void OnClick()
    {
        base.OnClick();
        SceneManager.LoadScene("LevelEditor");
    }

    private void Start()
    {
        AddButtonListener();
    }
}
