using System;

namespace CodeGym
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int loop = -1;
            var service = new Service();
            while ( loop !=0)
            {
                Console.WriteLine("\t\t\tMenu");
                Console.WriteLine("\t\t\tselect 1 : add");
                Console.WriteLine("\t\t\tselect 2 : show");
                Console.WriteLine("\t\t\tselect 3 : search");
                Console.WriteLine("\t\t\tselect 4 : delete ");
                Console.WriteLine("\t\t\tselect 5 : insert");
                Console.WriteLine("\t\t\tout : 0");
                var input = Console.ReadLine();
                int choice;
                bool result = int.TryParse(input, out choice);

                if (result == true && choice < 5 && choice >= 0)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("ban muon them bao nhieu nhan vien");
                            input = Console.ReadLine();
                            int ketqua;
                            bool kiemtra = int.TryParse(input, out ketqua);
                            if (kiemtra)
                            {
                                for (int i = 0; i < ketqua; i++)
                                {
                                    Console.WriteLine("nhan vien :  " + (i + 1));
                                    Console.WriteLine("Ten");
                                    var ten = Console.ReadLine();
                                    Console.WriteLine("Tuoi");
                                    var tuoi = Console.ReadLine();
                                    Console.WriteLine("id");
                                    var maso = Console.ReadLine();
                                    Console.WriteLine("gioi tinh");
                                    var gioitinh = Console.ReadLine();
                                    Console.WriteLine("ngay sinh");
                                    var ngaysinh = Console.ReadLine();


                                    var request = new NhanVien()
                                    {
                                        Name = ten,
                                        Age = tuoi,
                                        ID = maso,
                                        GioiTinh = gioitinh,
                                        NgaySinh = ngaysinh

                                    };
                                    service.add(request);


                                }
                            }
                            else Console.WriteLine("moi ban nhap lai so luong ");
                            break;
                        case 2:


                            Console.WriteLine("--danh sach--");
                            foreach (var nv in service.Gets())
                            {
                                Console.WriteLine("Ten:\t Tuoi:\t ID:\t NgaySinh:\t GioiTinh:\t");
                                Console.WriteLine(nv.Name + "\t" + nv.Age + "\t" + nv.ID + "\t\t" + nv.NgaySinh + "\t\t" + nv.GioiTinh);
                            }
                            break;
                        case 4:
                            Console.WriteLine("ban co muon xoa yes or no");
                            var xacnhan = Console.ReadLine();
                            if (xacnhan == "yes")
                            {
                                service.delete();

                                Console.WriteLine("xoa thanh cong");
                            }

                            break;
                        case 5:
                            Console.WriteLine("ban muon them vao danh sach vi tri thu");
                            var nhap = Console.ReadLine();
                            bool yep = int.TryParse(nhap, out var index);
                            if (yep)
                            {

                                Console.WriteLine("Ten");
                                var ten = Console.ReadLine();
                                Console.WriteLine("Tuoi");
                                var tuoi = Console.ReadLine();
                                Console.WriteLine("id");
                                var maso = Console.ReadLine();
                                Console.WriteLine("gioi tinh");
                                var gioitinh = Console.ReadLine();
                                Console.WriteLine("ngay sinh");
                                var ngaysinh = Console.ReadLine();
                                var request = new NhanVien()
                                {
                                    Name = ten,
                                    Age = tuoi,
                                    ID = maso,
                                    GioiTinh = gioitinh,
                                    NgaySinh = ngaysinh
                                };



                                service.update(index, request);

                            }
                            else Console.WriteLine("nhap lai index");

                            break;
                        case 0:
                           
                            Console.WriteLine("ban muon thoat khoi chuong trinh yes / no");
                            var acept = Console.ReadLine();
                            if (acept == "yes")
                            {
                                loop = 0;
                            }
                            else loop = -1;
                            break;

                    }
                }
                else Console.WriteLine("nhap lai");
                
            }
            
        }
    }
}
