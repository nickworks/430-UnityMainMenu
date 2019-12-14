using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public RectTransform bttnsMain;
    public RectTransform bttnsLevels;

    public EventSystem events;

    public GenericButton buttonPrefab;

    Levels levels;

    void Start()
    {
        levels = GetComponent<Levels>();
        HideSubMenu();
        BuildSubMenu();
    }

    private void BuildSubMenu()
    {
        // spawn those buttons

        float y = -90;
        float x = -346;

        foreach (LevelInfo level in levels.levels)
        {
            MakeSubMenuButton(ref x, ref y, level.nameOfLevel, level.imageForButton, () => {

                SceneManager.LoadScene(level.filenameOfScene);
            
            });

        }
    }

    void MakeSubMenuButton(ref float x, ref float y, string caption, Sprite image, GenericButton.ClickDelegate callback)
    {

        GenericButton bttn = Instantiate(buttonPrefab, bttnsLevels);

        bttn.Init(caption, image, callback);

        RectTransform t = (bttn.transform as RectTransform);
        t.anchoredPosition = new Vector2(x, y);
        if (y <= -270)
        {
            x += 692;
            y = 10;
        }
        y -= 100;
    }

    void ShowSubMenu()
    {
        bttnsMain.gameObject.SetActive(false);
        bttnsLevels.gameObject.SetActive(true);
    }

    public void HideSubMenu()
    {
        bttnsMain.gameObject.SetActive(true);
        bttnsLevels.gameObject.SetActive(false);
    }

    void Update()
    {
        Focus();
    }

    private void Focus()
    {
        if (events == null) return; // return out early if null
        if (events.currentSelectedGameObject != null) return;
        if (events.firstSelectedGameObject == null) return;
        events.SetSelectedGameObject(events.firstSelectedGameObject);

    }

    public void BttnPlayClicked()
    {
        SceneManager.LoadScene("Level01");
    }

    public void BttnOptionsCLicked()
    {
        ShowSubMenu();
    }

    public void BttnExitClicked()
    {
        Application.Quit();
    }

}
