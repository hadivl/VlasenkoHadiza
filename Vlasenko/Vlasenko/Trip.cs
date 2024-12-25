using System;
using System.Collections.Generic;
using System.Text;

//Описать тип(структуру или класс) Trip для хранения данных о туристической поездке (свойства: продолжительность - строка, цена - число, размер туристической группы - число).

namespace Vlasenko
{
    public class Trip
    {
        public string Prodolzhitelnost { get; set; }
        public double Prise { get; set; }
        public int Razmer { get; set; }


        public Trip(string prodol, double prise, int razmer)
        {
            Prodolzhitelnost = prodol;
            Prise = prise;
            Razmer = razmer;
        }

        public override string ToString()
        {
            return $"Продолжительность: {Prodolzhitelnost}, Цена: {Prise}, Размер группы: {Razmer} ";
        }
    }
}
