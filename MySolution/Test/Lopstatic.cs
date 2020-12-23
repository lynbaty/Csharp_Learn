using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Test.Cal;
using static System.Console;

namespace Test
{
    class Lopstatic
    {
        /* la lop cung cap tien ich cho cac lop khac.
         * cau truc static class name. 
         * khong the tao ra doi tuong
         * chi chua cac thanh phan static
         * import staticcccc
         * 
         * 
         * Dac trung ngon ngu lap trinh
         * - Tinh Dong goi encapsulation: 
         * Public Khong gioi han => khong gioi han truy cap, nhin thay moi noi. Ai cung co the su dung
         * Private: Chi truy cap trong Class do thoi
         * Protected: Dc truy cap boi lop cua no va lop con cua no. 
         * Internal: dc truy cap ơ asembly hien tai. Khai niem google. Thâp hơn (Priveted(=
         * Protected Internal: Lop no va lop con. => neu ra 1 thong diep. 
         * 
         * 
         * Tính dong goi, ke thua va da dung. 
         * DOng goi: Du lieu cua 1 doi tuong k ne được truy cập từ ngoài lớp bởi chính nó (abc.xyz) ma thông qua các thành phần Public khác
         * Dữ liệu 1 lớp sẽ khai báo qua Private và được quản lý thông qua 2 cách: 
         * 1. Sử dụng accessor mutator. (getter/setter)
         * 2. Định nghĩa 1 Public property. 
         * 1 class thiết kế tooits về tính đóng gói sẽ ẩn giấu nhữn thực thi chi tiết bên trong nó khỏi thế giới bên ngoài (tránh hacker/ trách sao chép...)
         * 
         * .Net the hien dong goi thong qua propertyu
         * Ket hop bang canh dinh nghia cap Getter Settter trong ban than 1 propert
         * ko su dung cap ngoac
         * trả vè la kieu cua truong du lieu ma no dong goi
         * Su dung keyword value trong khjoi set
         * 
         * So sanh Property và Getter/Setter:
         * Expression Bodied (don gian h oa khoi getset vs bieu thuc Lambda. 1 lenh
         * - lựa chọn cách bạn muốn
         * Sử dụng Property để tránh dư thừa code
         * 
         * Khởi tạo properties cho đối tượng
         * 
         * 
         */


        private static void Main(string[] args)
        {
            int a = 120, b = 500;
            WriteLine(Add(a,b));


        }


    }
}
