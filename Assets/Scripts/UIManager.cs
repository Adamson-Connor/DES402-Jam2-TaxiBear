using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] menus;
    private GameObject activeMenu;

    void Start()
    {
        ChangeMenu(0);
    }

    public void ChangeMenu(int menuNo)
    {
        activeMenu = menus[menuNo];

        foreach (var menu in menus)
        {
            if (menu == activeMenu)
            {
                menu.SetActive(true);
            }
            else
            {
                menu.SetActive(false);
            }
        }
    }
}
