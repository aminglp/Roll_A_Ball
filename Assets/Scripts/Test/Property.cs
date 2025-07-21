using System;
using UnityEngine;

public class Property : MonoBehaviour
{
    private int health =2;
    
    public int Health
    {
        get { return health;}//اگه اینو تنها بزاریم دیگه نمیتونیم مقدار بهش بدیم فقط میتونیم مقدارشو بگیریم و بخونیم 
        set { health=value;}//اگه اینو تنها بزاریم یعنی این که مقدار میتونیم فقط بهش بدیم و نمیتونیم بخونیمش 
    }

    private void Start()
    {
        Health = 13;// در صورت تنها بودن میبینی که فقط ست روشن هست یعنی میخوایم یه مقدار نشون میده
        Debug.Log(Health);//وقتی اینو تنها بزاریم میبینیم که فقط گت روشن میشه
        
    }
}
