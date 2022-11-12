using Odev2_altın;
using System.Collections.Generic;

using Odev2_altın;
using System.Linq.Expressions;

public class Program
{
    class LinkedListNode
    {
        public int toplamaltinsayisi;
        public LinkedListNode next;

        public LinkedListNode(int x)
        {
            toplamaltinsayisi = x;
            next = null;
        }
    }
    static void Main(string[] args)
    {

        int toplamaltinsayisi = 100;


        Random avuc = new Random();

        int tur = 1;

        LinkedList<Koltuk> koltuklar = new LinkedList<Koltuk>();
        for (int i = 1; i <= 40; i++)
        {
            koltuklar.AddLast(new LinkedListNode<Koltuk>(new Koltuk
            {
                No = i
            }));
        }

        for (LinkedListNode<Koltuk> node = koltuklar.First; node != null; node = node.Next)
        {
            //Elinde 5ten az kaldıysa kalanı sıradaki koltuğa atıyor.
            if (toplamaltinsayisi < 5)
            {

                node.Value.AltınSayisi += toplamaltinsayisi;
                toplamaltinsayisi = 0;
            }
            if (toplamaltinsayisi > 0)
            {

                int koltuktakialtin = avuc.Next(6);
                node.Value.AltınSayisi += koltuktakialtin;
                toplamaltinsayisi -= koltuktakialtin;
            }

            if (node == koltuklar.Last && toplamaltinsayisi > 0)
            {
                tur++;
                node = koltuklar.First;
            }
        }


        Console.WriteLine("tursayisi " + tur);


        var rnd = new Random();
        Kisi[] kisilistesi = new Kisi[15];
        for (int i = 0; i < 15; i++)
        {

            var kisi = new Kisi();
            Console.WriteLine((i + 1).ToString() + ". yolcu ismini giriniz:");
            kisi.Isim = Console.ReadLine();
            Console.WriteLine((i + 1).ToString() + ". yolcu cinsiyetini giriniz");
            kisi.Cinsiyet = Console.ReadLine();
            kisilistesi[i] = kisi;

        }

        foreach (Kisi kisi in kisilistesi)
        {
            bool oturdumu = false;

            for (LinkedListNode<Koltuk> node = koltuklar.First; node != null; node = node?.Next)
            {
                if (node.Value.Kisi == null)
                {
                    if ((rnd.Next(10) > 5))
                    {
                        node.Value.Kisi = kisi;
                        var koltuk = koltuklar.Single(x => x.No == node.Value.No);
                        node.Value.Kisi = kisi;
                        oturdumu = true;
                        node = null;
                    }
                }

                if (node == koltuklar.Last && oturdumu == false)
                {
                    node = koltuklar.First;
                }
            }
        }

        var soforunAltinlari = 0;
        var kadinlarinAltinlari = 0;
        var erkeklerinAltinlari = 0;
        for (LinkedListNode<Koltuk> node = koltuklar.First; node != null; node = node?.Next)
        {
            if (node.Value.Kisi != null)
            {
                Console.WriteLine("Kisi : " + node.Value.Kisi.Isim + "- Koltuk Numarası : " + node.Value.No + "- Altın Sayisi :" + node.Value.AltınSayisi);
                if (node.Value.Kisi.Cinsiyet == "E")
                {
                    erkeklerinAltinlari += node.Value.AltınSayisi;
                }
                else
                {
                    kadinlarinAltinlari += node.Value.AltınSayisi;

                }
            }
            else
            {
                soforunAltinlari += node.Value.AltınSayisi;
            }
        }

        Console.WriteLine("Erkeklerin Altın Sayisi : " + erkeklerinAltinlari);
        Console.WriteLine("Kadınların Altın Sayisi : " + kadinlarinAltinlari);
        Console.WriteLine("Şoförün Altın Sayisi : " + soforunAltinlari);



        //Sofor altinlari koltuklara saklarken bir bos bir dolu sekilde saklamaya calısmıstır
        //Sofor eline en fazla 5 altın alabilmektedir.




    }

}



