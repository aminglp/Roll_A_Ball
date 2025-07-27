using System;
using UnityEngine;

public class FactoryMethod : MonoBehaviour
{
    void Start()
    {
        var devManager = new DevelopmentManeger();
        devManager.TakeInterviewer();//outputing : Asking about dev

        var marketingManager = new MarketingManager();
        marketingManager.TakeInterviewer();//outputing : Asking about Design
        ;
    }


    /// <summary>
    /// یک مدیر رو فرض کنید که وظیفه استخدام
    /// افراد رو به عهده داره. مطمئنن براش غیر ممکنه که مصاحبه با همه افراد در پوزیشن‌های مختلف شرکت
    /// رو خودش انجام بده! پس میاد با توجه به پوزیشن تصمیم میگیره که مسئولیت مصاحبه رو
    /// به عهده یکی از کارمند‌هاش بزاره.
    /// به زبون ساده:
    ///این دیزاین پترن میگه جای اینکه خودمون مستقیم درگیر ساخت ابجکت بشیم، این کار رو به عهده کلاس‌های فرزند بزاریم.
    /// </summary>
    public interface IInterviewer
    {
        void AskQuestions();
    }

    public class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Debug.Log("questions....???");
        }
    }

    public class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Debug.Log("ask questions about design...?");
        }
    }

    abstract class HiringManager
    {
        abstract protected IInterviewer MakInterviewer();

        public void TakeInterviewer()
        {
            var interviewer = this.MakInterviewer();
            interviewer.AskQuestions();
        }
    }

    class DevelopmentManeger : HiringManager
    {
        protected override IInterviewer MakInterviewer()
        {
            return new Developer();
        }
    }

    class MarketingManager : HiringManager
    {
        protected override IInterviewer MakInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}