using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Magazine : Item, IPubs
    {
        private int volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        private bool returnSrok;

        public Magazine(int volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


        public void ReturnSrok1()
        {
            returnSrok = true;
        }

        // реализация интерфейса
        public override void Return()    // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }


        public void Subs()
        {
            if (returnSrok == true)
                IfSubs = false;
            else
                IfSubs = true;


        }
        public override string ToString()
        {
           if (IfSubs)
           return "\nЖурнал:\nНазвание: " + title + "\nТом: " + volume +
           "\nНомер: " + number + "\nГод выпуска: " + year + "\nПодписка оформлена";
           else
               return "\nЖурнал:\nНазвание: " + title + "\nТом: " + volume +
           "\nНомер: " + number + "\nГод выпуска: " + year + "\nПодписка не оформлена"; ;
       }
    }
}
