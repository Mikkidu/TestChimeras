using UnityEngine;


public class AlchemyUI : MonoBehaviour
{
    public GameObject alchemyWindow, alchemyWindowAsset;

    //Открытие-закрытие окна Алхимии
    public void ShowAlchemyWindow()
    {
        //Создаём объект только при первом открытии
        if (alchemyWindow == null)
        {
            alchemyWindow = Instantiate(alchemyWindowAsset, transform);
        }
        alchemyWindow.SetActive(true);
        //Заполнение списка рецептов
        alchemyWindow.GetComponent<AlchemyWindowUI>().FillRecipesUI();
    }


}
