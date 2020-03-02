using System;
using System.Collections;
using System.Collections.Generic;

namespace T1904A
{
    public class Cart
    {
        private int id;
        private string TenKH;
        private int tongTien;
        private string city;
        private string country;
        public List<Product> productList =new List<Product>();

        public List<Product> ProductList
        {
            get => productList;
            set => productList = value;
        }

        public Cart(int id, string tenKh, int tongTien, string city, string country)
        {
            this.id = id;
            TenKH = tenKh;
            this.tongTien = tongTien;
            this.city = city;
            this.country = country;
        }

        public Cart()
        {
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string TenKh
        {
            get => TenKH;
            set => TenKH = value;
        }

        public int TongTien
        {
            get => tongTien;
            set => tongTien = value;
        }
        

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public void AddProduct()
        { 
            Console.WriteLine("Them san pham vao gio hang : ");
            Product p =new Product();
            productList.Add(p);
            
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Chon anh de xoa");
            int s = Convert.ToInt32(Console.ReadLine());
           productList.Remove(productList[s]);
        }

        public void grandTotal()
        {  
             
            for (int i = 0; i < productList.Count; i++)
            {
                 
            }
            if (city == "HN" || city == "TPHCM")
            {
                tongTien = tongTien* 101/100 ;
            }else
            {
                tongTien = tongTien * 102 / 100;
            }

            if (country == "NN")
            {
                tongTien = tongTien * 105 / 100;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}