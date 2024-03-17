using System;
using System.Collections.Generic;
using System.Text;

namespace book
{
    /*
Házi feladat kiinduló pont (4. hét):

Készítsen Book osztályt és egy Book osztályt 
használó osztályt az adatrejtés elvének betartásával. 
Az adattagjait és a metódusait a megadott
néven nevezze el.
 
A Book osztály adattagjai: 
title (könyv címe), author (könyv szerzője),
yearOfPublication (megjelenés éve), price (ára forintban)

A Book osztály metódusai:
1. IncreasePrice: egy paraméterként kapott százalékos értékkel növeli a könyv árát. Pl. input 15 -> a könyv árát 15%-al növeli
Tört eredmény esetén kerekítenie kell a matematikai szabályoknak megfelelõen! Pl. 10%-os emelés esetén: 1004 -> 1104, 1005 -> 1105, 1006 -> 1107
Ha az input 0 vagy negatív, akkor ne változzon a könyv ára.

2. DisplayInfo: egy  String-be összefűzi a könyv összes adatát és ezt adja vissza. 

3. Setter metódusok az adattagok beállításához, és getter metódusok az adattagok lekérdezéséhez.
Értékadás előtt ellenőrzések:
- a megjelenés éve, ha nem 1950 és 2021 között van, legyen 2021, egyébként a megadott érték
- az ár legyen 1000 forint 1000-nél kisebb értékekre, egyébként a megadott érték

A Book osztályt használó osztályban (Homework) hozzon 
létre egy könyvet, majd
- adjon értéket az adattagjainak,
- jelenítse meg az adatait,
- növelje meg az árát 10%-al,
- jelenítse meg ismét az adatait.      */
    public class Book
    {
        private string title;
        private string author;
        private int yearOfPublication;
        private int price;

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetYearOfPublication(int year)
        {

            if(year < 1950 || year > 2021)
            {
                this.yearOfPublication = 2021;
            }

            this.yearOfPublication = year;
        }

        public void SetPrice(int price)
        {

            if(price < 1000)
            {
                this.price = 1000;
                return;
            } 

            this.price = price;
        }

        public string GetTitle() { return this.title; }
        public string GetAuthor() { return this.author; }
        public int GetYearOfPublication() { return this.yearOfPublication; }
        public int GetPrice() { return this.price; }

        public void IncreasePrice(int percent)
        {

            if(percent <= 0)
            {
                return;
            }

            double newprice = this.price + Math.Round((this.price * (percent / 100.0)));
            int newpriceint = (int)newprice;

            SetPrice(newpriceint);
        }

        public string DisplayInformation()
        {
            return $"{title}\nSzerző: {author}\nMegjelenés éve: {yearOfPublication}\nKönyv ára: {price}";
        }

    }
}
