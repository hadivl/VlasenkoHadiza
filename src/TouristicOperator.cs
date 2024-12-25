using MailKit.Search;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

//Создать класс TouristicOperator, в котором обеспечить хранение одномерного массива указателей (или ссылок) на экземпляры типа Trip (специфику языка программирования учесть самостоятельно).
// В классе TouristicOperator реализовать (в виде двух отдельных методов) алгоритм сортировки по возрастанию (по сочетанию значений двух свойств в порядке убывания приоритета: «цена» 
//и «размер туристической группы») и сохранение массива в файл.

namespace Vlasenko
{
   public  class TouristicOperator
    {
        private List<Trip> trips = new List<Trip>();
        public TouristicOperator()
        {
            trips = new List<Trip>();
        }

        public void AddTrip(Trip trip)
        {
            trips.Add(trip);
        }

        public void Sortirovka()
        {
            trips = trips
            .OrderBy(c => c.Prise)
            .ThenBy(c => c.Razmer)
            .ToList();
                
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var trip in trips)
                {
                    writer.WriteLine(trip.ToString());
                }
            }
        }
    }
}
