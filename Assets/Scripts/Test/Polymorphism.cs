using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    //حالت اول متدهای همنام ولی با ورودی های متفاوت
    public int Amin(int a,int b)
    {
        return a + b;
    }

    public int Amin(int a, int b, int c)
    {
        return a + b + c;
    }
    
}

public class Area
{ 
    //حالت دوم اینه که ما متدهایی که تعریف کردیم میتونیم با اوورراید کردن بدنشو شخصی سازی کنیم
    public int a = 1;
    public int b = 2;

    public virtual int Alaki()
    {
        return a+b;
    }
}

public class Squar : Area
{
    private int b = 3;
    private int g = 10;
    public override int Alaki()
    {
        
        //این حالت بیس وقتی که اووراد میکنی میگه میتونی حالت کلی هم که تعریف شده بود هم داشته بشیم
        //return base.Alaki();
        //ولی در هر صورت الان میتونیم تغییراتی که نیاز داریم توش بنویسیم حتی اصلا ربطی به اون متد پایه نداشته باشه
        return b * g;
    }
}