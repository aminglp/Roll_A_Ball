using UnityEngine;
//https://github.com/3lf/design-patterns-for-humans
/// <summary>
/// SimpleFactory:
/// فرض کنید درحال ساخت یک خونه هستین و توی بخش‌های مختلف به درب نیاز دارین،
/// خب اگه برای هر کدومش بخواین لباس نجاری بپوشین و درگیر ساختنش بشین، قراره کلی هرج و مرج تجربه کنین.
/// به همین دلیل مردم ترجیح میدن برای حل این مشکل اونو از یک کارخونه تهیه کنن. 
/// </summary>
public class SimpleFactory : MonoBehaviour
{

    public void Init()
    {
        var door = DoorFactory.MakeDoor(20, 30);
        Debug.Log($"door heigh {door.GetHeight()} and door width {door.GetWidth()}");
    }
    
    
}

//ایول یه اینترفیس مربوط به درب میسازیم و بعدش یک کلاس factory برای ساخت درب میسازیم.
public interface IDoor
{
    int GetHeight();
    int GetWidth();
}

public class WoodDoor : IDoor
{
    public int Height { get; set; }
    public int Width { get; set; }

    public WoodDoor(int height,int width)
    {
        this.Height = height;
        this.Width = width;
    }
    public int GetHeight()
    {
        return this.Height;
    }

    public int GetWidth()
    {
        return this.Width;
    }
}


public static class DoorFactory
{
    public static IDoor MakeDoor(int height,int width)
    {
        return new WoodDoor(height, width);
    }
}