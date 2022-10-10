using UnityEngine;


public class AlchemyUI : MonoBehaviour
{
    public GameObject alchemyWindow;

    void Start()
    {
        
    }

    //Открытие-закрытие окна Алхимии
    public void ShowAlchemyWindow()
    {
        //Создаём объект только при первом открытии
        if (alchemyWindow == null)
        {
            alchemyWindow = Instantiate(Resources.Load<GameObject>("AlchemyWindow"), transform);
        }
        alchemyWindow.SetActive(true);
        //Заполнение списка рецептов
        alchemyWindow.GetComponent<AlchemyWindowUI>().FillRecipesUI();
    }


}
