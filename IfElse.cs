namespace _KB;

class IfElse
{
public int возраст = 16;
public int сдача = 18;


    public void Else()
    {
      if (сдача  >= 0)
        {
            Console.WriteLine("Все хорошо!");
        }
     else
        {
            Console.WriteLine("Ошибка расчета! Робот-продавец ошибся.");
        }
    }
}
