﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    internal class Movie
    {
        private string biograf;
        public string Biograf 
        { 
            get {  return biograf; } 
            set {  biograf = value; } 
        }

        private string by;
        public string By 
        { 
           get { return by; } 
           set { by = value; } 
        }

        private DateTime forestillingstidspunkt;

        public  DateTime Forestillingstidspunkt
        {
            get { return forestillingstidspunkt; }
            set { forestillingstidspunkt = value; }
        }

        private string filmtitel;

        public string Filmtitel
        {
            get { return filmtitel; }
            set { filmtitel = value; }
        }

        private string filmgenre;

        public string Filmgenre
        {
            get { return filmgenre; }
            set { filmgenre = value; }
        }

        private TimeSpan filmvarighed;

        public TimeSpan Filmvarighed
        {
            get { return filmvarighed; }
            set { filmvarighed = value; }
        }

        private string filminstruktør;

        public string Filminstruktør
        {
            get { return filminstruktør; }
            set { filminstruktør = value; }
        }

        private DateTime premieredato;

        public DateTime Premieredato
        {
            get { return premieredato; }
            set { premieredato = value; }
        }

        private string bookingmail;

        public string Bookingmail
        {
            get { return bookingmail; }
            set { bookingmail = value; }
        }

        private int bookingtelefonnummer;

        public int Bookingtelefonnummer
        {
            get { return bookingtelefonnummer; }
            set { bookingtelefonnummer = value; }
        }

        public Movie(List<string> csvList)
        {
            Biograf = csvList[0];
            By = csvList[1];
            Forestillingstidspunkt = DateTime.Parse(csvList[2]);
            Filmtitel = csvList[3];
            Filmgenre = csvList[4];
            Filmvarighed = new TimeSpan(int.Parse(csvList[5].Split(":")[0]), int.Parse(csvList[5].Split(":")[1]), 0);
            Filminstruktør = csvList[6];
            Premieredato = DateTime.Parse(csvList[7]);
            Bookingmail = csvList[8];
            Bookingtelefonnummer = int.Parse(csvList[9]);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in typeof(Movie).GetProperties())
            {
                sb.Append(property.GetValue(this, null).ToString() + ";");
            }
            return sb.ToString();
        }
    }

}
