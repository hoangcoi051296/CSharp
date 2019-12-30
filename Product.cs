using System;
using System.Collections;
using System.Collections.Generic;

namespace T1904A
{
    public class Product
    {
        private int ID;
        private string name;
        private int price;
        private int qty;
        private string image;
        private string desc;
        List<string> gallery =new List<string>();

        public Product()
        {
            Console.WriteLine("Nhap ID : ");
            ID= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten : ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap gia : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so luong : ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap anh : ");
            image = Console.ReadLine();
            gallery.Add(image);
            Console.WriteLine("Nhap mieu ta : ");
            desc = Console.ReadLine();
            
        }

        public Product(int id, string name, int price, int qty, string image, string desc)
        {
            ID = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            set => gallery = value;
        }

        public void getInfo()
        {
            Console.WriteLine("ID :"+ID);
            Console.WriteLine("Ten SP : "+name);
            Console.WriteLine("Gia : "+price);
            Console.WriteLine("SL : "+qty);
            Console.WriteLine("Anh : "+image);
            Console.WriteLine("Describe : " +desc);
            foreach (string i in gallery)
            {
                Console.WriteLine(i);
            }
        }

        public void CheckQty()
        {
            if (qty > 0)
            {
                Console.WriteLine("Con "+ qty + "san pham");
            }else{Console.WriteLine("Het Hang");}
        }

        public void AddImg()
        {
            
            if (gallery.Count >= 10)
            {
                Console.WriteLine("Thu vien day");
            }
            else {
                Console.WriteLine("Nhap anh : ");
                string s = Console.ReadLine();
                gallery.Add(s);
            }
        }

        public void RemoveImg()
        {
            foreach (string i in gallery)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Chon anh de xoa");
            int s = Convert.ToInt32(Console.ReadLine());
            gallery.Remove(gallery[s]);
        }
    }
}