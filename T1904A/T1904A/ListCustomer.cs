using System;
using System.Collections;
using System.Collections.Generic;

namespace T1904A
{
    public class ListCustomer
    {
        public List<CustomerVN> listVN;
        public List<CustomerNN> listNN;

        public ListCustomer()
        {
            listVN=new List<CustomerVN>();
            listNN=new List<CustomerNN>();
        }
        public void addCusVN() {
            Console.WriteLine("Them khach hang Viet Nam vao danh sach");
            CustomerVN newCustomer = new CustomerVN();
            listVN.Add(newCustomer);
        }
        public void addCusNN() {
            Console.WriteLine("Them khach hang nuoc ngoai vao danh sach");
            CustomerNN newCustomer = new CustomerNN();
            listNN.Add(newCustomer);
        }
        public void showlistCustomer(){
            Console.WriteLine("Danh sach cac khach hang Viet Nam");
            foreach (var a  in listVN)
            {
                a.ShowCustomer();
            }
            Console.WriteLine("Danh sach cac khach hang Nuoc ngoai");
            foreach (var b  in listNN)
            {
                b.ShowCustomer();
            }
           
        }

        public void countCus(){
           Console.WriteLine("Hien tai co "+(listVN.Count+listNN.Count)+" khach hang: "
                               +listVN.Count+" khach hang VN, "+listNN.Count+" khach hang nuoc ngoai");
        }

        public void tienTBnuocngoai(){
            float temp = 0;
            foreach (var c in listNN)
            {
                temp = temp + c.tongtien;
            }
            Console.WriteLine("Trung binh tien dien nguoi nuoc ngoai: "+temp/listNN.Count);
        }
    }
}