namespace _KB;

class IfElse
{
public int сдача = 0;


    public void Else()
    {
        if (сдача  >= 20)
            {
                Console.WriteLine("Все хорошо!");
            }
        else if(сдача  <= 0)
            {
                Console.WriteLine("все верно");
            }
        else
            {
                Console.WriteLine("Ошибка расчета! Робот-продавец ошибся.");
            }

            
    }
}
