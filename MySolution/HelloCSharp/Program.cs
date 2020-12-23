//using System;
//using System.Collections; 
    

//namespace HelloCSharp
//{
//    //class FieldSample
//    //{
//    //    public static int MYSTATICFIELD = 100;
//    //    public string MyValue;
//    //    public FieldSample(String value)
//    //    {
//    //        this.MyValue = value;
//    //    }
//    //}
//    class FieldSampleTest

//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine($"Field Mysample.MYSTATICFIELD = {FieldSample.MYSTATICFIELD}");
//            //Console.WriteLine("-----------");
//            //FieldSample obj1 = new FieldSample("value1");
//            //Console.WriteLine("obj1.MyValue= {0}", obj1.MyValue);
//            //FieldSample obj2 = new FieldSample("Value2");
//            //Console.WriteLine("obj2.MyValue= {0}", obj2.MyValue);
//            //obj2.MyValue = "Value2-2";

//            DongVat concho = new DongVat();//đây là mình tạo ra 1 con vật cụ thể. À okie, tức tạo vậy nó thuộc class dongvat dung k, ko nói là thuộc đc
//            //thoi cu lam tiep di, hieu hieu dc roi. chu giai thich bang tieng Viet kho vl, cái này từ từ sẽ hiểu, chứ nó mơ hồ 
//            //concho gọi là instance 
//            // khi minh mô tả concho ví dụ 
//            DongVat vinh = new DongVat();
//            DongVat an = new DongVat();
//            DongVat A = new DongVat();
//            A.name = "Ai do";
//            A.name = "???";
//            //A.name2 = ""; //lỗi không có gọi đc static nó ko gọi đc tư 1 object ma nó gọi trực tiếp tư class;
//            DongVat.name2 = "";//hiểu nó dung như vậy con tại sao lại sinh ra nó tư tư vê sau
//            // okie, vi thay may cai len cung hay co tu do
//            // áp dụng bai mảng sẽ dễ hinh dung Uhm ý nghĩa của nó tạo ra la, ông để ý cái name đó muốn gọi nó phải tạo ra 1 object , 
//            // tạo 1 mảng học sinh Ma cái ni t biết r. Mi cứ ví dụ đi
            

              
            
//               //i phân arra y đi quay lại ví dụ tiếp vụ class obj ok. méo nhơ syntax luôn :)) mé :v Khai báo tên là string đúng ko


//            concho.name = "Don";
//            ArrayList listDV = new ArrayList();
//            A.name = "vinh";
//            A.age = 22;
//            listDV.Add(A);
//            A.name = "an";
//            A.age = 44;
//            listDV.Add(A);
//            foreach(DongVat dv in listDV)
//            {
//                Console.WriteLine("Name" + dv.name +" Age:" +dv.age);
//                Console.ReadKey();

//            }
//            //vong lap dung vs phim hu

//            //cho này mình sẽ hiểu concho tên An laf 1 object cụ thể. ok ok
//            //con cái instance nó như 1 object ảo thôi, đai khái vậy. Vay ha umh
//            // vậy ý là cái nào cụ thể nhất có thể, thì xem là 1 object cuois cùng đúng ko. Tại trong cái bài nó ghi tù mù lắm. ko dễ hiểu như vậy
//            Console.WriteLine($"toi gio an roi {concho.name} ");
//            Console.ReadLine();
//        }
//    }


//    //nguyên cụm nay minh đang mô tả về động vật. okie tam on. Clm trong kia nó nói phuc tap qua


//    public class DongVat
//    {
//        public string name;//public la nó cho biến name phạm vi truy cập ở trong 1 bai nay luôn. cái ni t hiểu r, nãy có đọc r
//        public static string name2;
//        public int age;
//    }

//    public class Test
//    {
//        //toi muốn gọi cái name thi lại phải tạo thêm 1 cái oblject
//        void test()
//        {
//            DongVat bb = new DongVat();
//            bb.name = "";// cứ mõi chổ class khác nó lại phai tạo mới gọi đc, nhưng có những biến nó hay sử dụng nên việc tạo ra như vậy tốn bộ nhớ hơi phim
//            DongVat.name2 = "";// thay vi ở đâu cũng gọi đc ma ko phải tạo ra cái gi hết
//            // tư khóa new khi máy tính đọc dong lệnh đó nó sẽ tạo ra 1 vung nhớ có tên la bb chẳng hạn. Ua okie roi, cho nay hieu so so. Co gi t hoir tiep hi

//        }


//    }

//}
