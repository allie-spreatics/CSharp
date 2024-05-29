using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // using 은 namespace를 가져오기 위한 명령어

namespace WindowsFormsApp1
{
    public partial class Form1 : Form // Form 클래스를 상속받는 Form1클래스임
    {
        public Form1() // 생성자
        {
            InitializeComponent();
            MessageBox.Show("프로젝트 만드는걸 잘 보고 해야하는구만~");
            textBox_print.Text = "드디어 쓸 수 있구만....\r\n ㅜㅜ 나 그만 돌아갈래~~~ \r\n";
            int a = 10;
            textBox_print.Text+=a.ToString() + "\r\n";
            var b = "11";
            var c = 'A';
            var d = 3333;
            textBox_print.Text +=b.GetType()+"\r\n"; // System.String
            textBox_print.Text +=c.GetType()+"\r\n"; // System.Char
            textBox_print.Text +=d.GetType()+"\r\n"; // System.Int32
        }
            public void method_form()
            {
   //         do_something();
            }
    }
}


namespace allie
{
    // int myNumber = 10; // namespace 내부에서는 변수 선언 불가
    /*int test_method()
    {
        return 1;
    }*/ // namespace 내부에서는 함수 선언 불가..?!
    // namespace 내부에선 함수, 변수 등의 멤버 선언 불가능. interface, class ok.
    public class School // 클래스 선언 가능
    {
        // school class' constructor
        public School() { }
        public void do_something() {
            // 같은 파일에서는 using 키워드 없더라도 네임스페이스에 접근 가능
            WindowsFormsApp1.Form1 myForm1 = new WindowsFormsApp1.Form1();
            myForm1.method_form();


        }

    }


   
}