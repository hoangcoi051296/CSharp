using System;

namespace T1904A
{
    public class Customer
    {
        public int ID;
        public string ten;
        public string ngayhoadon;
        public float sodien;
        public int[] dongia = {1000,1200,1500,2000};
        public static int[] dinhmuc = {0,50,100,200};
        public float tongtien;

        public Customer() { }

        public Customer(int id, string ten, string ngayhoadon, float sodien, float tongtien)
        {
            ID = id;
            this.ten = ten;
            this.ngayhoadon = ngayhoadon;
            this.sodien = sodien;
            this.tongtien = tongtien;
        }

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Ngayhoadon
        {
            get => ngayhoadon;
            set => ngayhoadon = value;
        }

        public float Sodien
        {
            get => sodien;
            set => sodien = value;
        }
        
        
        public void InputCustomer(){
            Console.WriteLine("Nhap thong tin khach hang: ");
            Console.WriteLine("Nhap ID khach hang: ");
            Id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten khach hang: ");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap ngay in hoa don: ");
            ngayhoadon = Console.ReadLine();
            Console.WriteLine("Nhap so luong dien tieu thu (kW): ");
            sodien= Id =Convert.ToInt32(Console.ReadLine());
        }
        
        public void ShowCustomer(){
            Console.WriteLine("ID: "+ID+" - Ten KH: "+ten
                              +" - Ngay in hoa don: "+ngayhoadon+" - So luong dien tieu thu (kW): "+sodien);
        }
        
        public void tinhtongtien(){
            if(sodien<50){
                tongtien = sodien * dongia[0];
            }
            else if(sodien>50& sodien<100){
                tongtien = 50*dongia[0] + (sodien-50)*dongia[1];
            }
            else if(sodien>100& sodien<200){
                tongtien = 50*dongia[0] + 50*dongia[1] + ( sodien-100)*dongia[2];
            }
            else {
                tongtien = 50*dongia[0] + 50*dongia[1] + 100*dongia[2] + (sodien-200)*dongia[3];
            }
        }
    }

    
    
    public class CustomerVN : Customer
    {
        private String doituong;

        public string Doituong
        {
            get => doituong;
            set => doituong = value;
        }

        public CustomerVN( )
        {
          InputCustomer();
          this.tinhtongtien();
          
        }

        public CustomerVN(int id, string ten, string ngayhoadon, float sodien, float tongtien, string doituong) : base(id, ten, ngayhoadon, sodien, tongtien)
        {
            this.doituong = doituong;
            this.tinhtongtien();
        }

        public void InputCustomer()
        {
            base.InputCustomer();
            Console.WriteLine("Nhap doi tuong");
            doituong = Console.ReadLine();

        }

        public void ShowCustomer()
        {
            base.ShowCustomer();
           Console.WriteLine("Doi tuong: "+doituong+" - Tong tien: "+this.tongtien);
        }
        
        public void tinhtongtien() {
            base.tinhtongtien();
        }
        
    }

    
    
    
    public class CustomerNN : Customer
    {
        private String quoctich;

        public string Quoctich
        {
            get => quoctich;
            set => quoctich = value;
        }

        public CustomerNN() {
            InputCustomer();
            this.tinhtongtien();
        }

        public CustomerNN(int id, string ten, string ngayhoadon, float sodien, float tongtien) : base(id, ten, ngayhoadon, sodien, tongtien)
        {
            this.quoctich = quoctich;
            this.tinhtongtien();
        }
        public void InputCustomer()
        {
            base.InputCustomer();
            Console.WriteLine("Nhap quoc tich : ");
            quoctich = Console.ReadLine();

        }

        public void ShowCustomer()
        {
            base.ShowCustomer();
            Console.WriteLine("Quoc tich: "+quoctich+" - Tong tien: "+this.tongtien);
        }
        
        public void tinhtongtien() {
            tongtien = this.sodien * this.dongia[3];
        }

    }
}