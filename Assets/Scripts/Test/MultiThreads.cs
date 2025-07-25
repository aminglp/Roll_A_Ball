using System;
using System.Threading;
using UnityEngine;

namespace Test
{
    public class MultiThreads : MonoBehaviour ,ITest
    {
        //new Thread(() =>{}) به این عملگر لامبدا میگن 
        //(()=>)این عملگر لامبدا هست برای این که ما خط کوتاه کنیم
        private Thread newThread = new Thread(() =>
        {
            for (int i = 0; i < 50; i++)
            {
                Debug.Log("hello world");
            }
        });

        private Thread newThread2;

        public GameObject[] gameObjects;
        private void Start()
        {
            newThread2 = new Thread(loadData);
            newThread.Start();
        }

        public void loadData()
        {
            Debug.Log("load Data");
            foreach (var gameObject in gameObjects)
            {
                Destroy(gameObject);
                Thread.Sleep(20000);
            }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
